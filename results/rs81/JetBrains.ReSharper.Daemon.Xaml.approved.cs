[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedFieldGlobalWarning), "XAML")]
[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberLocalWarning), "XAML")]
[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberGlobalWarning), "XAML")]
[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldLocalWarning), "XAML")]
[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldGlobalWarning), "XAML")]
[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedFieldLocalWarning), "XAML")]
[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.MemberCanBePrivateGlobalWarning), "XAML")]
[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.MemberCanBeProtectedGlobalWarning), "XAML")]
[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.MemberCanBeInternalWarning), "XAML")]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.RedundantFreezeAttribute", null, "CodeRedundancy", "Redundant \'Freeze\' attribute", "Freeze attribute is not used and can be safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.RedundantModifiersAttribute", null, "CodeRedundancy", "Redundant modifiers attribute", "Accessibility set by attribute coincides with default one, thus attribute can be " +
    "safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.RedundantNameAttribute", null, "CodeRedundancy", "Redundant name attribute", "Name attribute in resource declaration is neglectable and can be safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.RedundantNamespaceAlias", null, "CodeRedundancy", "Redundant namespace alias", "Namespace alias is not required by code and can be safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.RedundantResource", null, "CodeRedundancy", "Redundant resource", "Resource is not used and can be safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.RedundantPropertyTypeQualifier", null, "CodeRedundancy", "Redundant property type qualifier", "Property owner type qualifier is redundant and can be safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.RedundantCollectionProperty", null, "CodeRedundancy", "Redundant empty collection property setter", "Empty collection property setter is redundand and can be safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.RedundantAttachedProperty", null, "CodeRedundancy", "Remove redundant attached property setter", "Attached property setter has no effect in current context and can be removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.RedundantStyledValue", null, "CodeRedundancy", "Property value is equal to style-provided", "Property value is equal to value, provided by explicit style and can be removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.LanguageLevel", null, "CodeSmell", "XAML language level error", "Xaml 2009 language construct is not allowed here", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.StaticResourceNotResolved", null, "CodeInfo", "Static resource not resolved", "Static resource not resolved", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.ConstructorWarning", null, "CodeInfo", "Constructor not resolved", "Constructor not resolved", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.DependencyPropertyResolveError", null, "CodeInfo", "Dependency property not resolved", "Dependency property implementation does not comply with Microsoft style guide", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.XamlRelativeSourceDefaultModeWarningHighlighting", null, "CodeSmell", "RelativeSourceMode is not set explicitly", "Default RelativeSourceMode value is platform-specific, explicit specification is " +
    "required to process RelativeSource usage unambiguously", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.XKeyAttributeDisallowed", null, "CodeSmell", "x:Key is allowed for resources and dictionary elements only", "x:Key is allowed for resources and dictionary elements only", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.PathError", null, "CodeSmell", "Path error", "Path error", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.IgnoredPathHighlighting", null, "CodeInfo", "Ignored path", "Path is ignored in project settings", JetBrains.ReSharper.Daemon.Severity.DO_NOT_SHOW, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.MappedPathHighlighting", null, "CodeInfo", "Mapped path", "Path is mapped to a different path in project settings", JetBrains.ReSharper.Daemon.Severity.HINT, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.StyleInvalidTargetType", null, "CodeSmell", "Style target type is not convertible to base type", "Style declaration target type is not convertible to style base type", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.DuplicateStyleSetter", null, "CodeSmell", "Duplicate style property/event setter", "Duplicate style property/event setter", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.BindingWithoutContextNotResolved", null, "CodeInfo", "Unresolved binding path when DataContext is unknown", "Unresolved binding path when DataContext for data binding is not specified", JetBrains.ReSharper.Daemon.Severity.HINT, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.BindingWithContextNotResolved", null, "CodeInfo", "Unresolved binding path when DataContext is known", "Unresolved binding path when DataContext for data binding is specified, but symbo" +
    "l cannot be found", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.IndexOutOfGridDefinition", null, "CodeSmell", "Grid element column/row index is out of grid definition range", "Grid element column/row index is out of grid definition range", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.RedundantGridDefinitions", null, "CodeRedundancy", "Single grid row/column definition is redundant", "Single grid row/column definition is redundant", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.RedundantGridSpan", null, "CodeRedundancy", "Single-cell grid column/row span is redundant", "Single-cell grid column/row span is redundant", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.MissingGridIndex", null, "CodeSmell", "Missing grid column/row setter for non-first child", "Missing grid column/row setter for non-first child inside non-trivial grid", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Xaml.ElementNameReferenceNotResolved", null, "CodeInfo", "Element name reference not resolved", "Element name reference not resolved to any of named elements in scope", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("XAMLErrors", "XAML Errors", true)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Xaml.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlAccessRightsErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlightingBase
    {
        public XamlAccessRightsErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.BindingWithContextNotResolved", "XAML", AttributeId="ReSharper Warning")]
    public class XamlBindingWithContextNotResolvedHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlNotResolvedLateBoundHighlighting
    {
        public readonly JetBrains.ReSharper.Psi.Xaml.Tree.IBinding BindingElement;
        public readonly JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement ObjectElementWithDataContext;
        public const string SEVERITY_ID = "Xaml.BindingWithContextNotResolved";
        public XamlBindingWithContextNotResolvedHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Xaml.Tree.IBinding binding, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElementWithDataContext) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.BindingWithoutContextNotResolved", "XAML", AttributeId="ReSharper Hint")]
    public class XamlBindingWithoutContextNotResolvedHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlNotResolvedLateBoundHighlighting
    {
        public readonly JetBrains.ReSharper.Psi.Xaml.Tree.IBinding BindingElement;
        public const string SEVERITY_ID = "Xaml.BindingWithoutContextNotResolved";
        public readonly JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement UpperContextElement;
        public XamlBindingWithoutContextNotResolvedHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Xaml.Tree.IBinding bindingElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement upperContextElement) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.ConstructorWarning", "XAML", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class XamlConstructorWarningHiglighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.ConstructorWarning";
        public XamlConstructorWarningHiglighting(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlConstructorReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.DependencyPropertyResolveError", "XAML", AttributeId="ReSharper Underlined Error Highlighting")]
    public class XamlDependencyPropertyResolveErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.DependencyPropertyResolveError";
        public XamlDependencyPropertyResolveErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public XamlDependencyPropertyResolveErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference, string tooltip) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlDynamicResourceNotAllowedErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        public XamlDynamicResourceNotAllowedErrorHighlighting(JetBrains.ReSharper.Psi.Xaml.Tree.IResourceUsage resourceUsage) { }
        public JetBrains.ReSharper.Psi.Xaml.Tree.IResourceUsage ResourceUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.ElementNameReferenceNotResolved", "XAML", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlElementNameReferenceNotResolvedHiglighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.ElementNameReferenceNotResolved";
        public XamlElementNameReferenceNotResolvedHiglighting([JetBrains.Annotations.NotNullAttribute()] string elementName, [JetBrains.Annotations.NotNullAttribute()] string scopeName) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        public XamlErrorHighlighting(string toolTip) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("toolTipFormat")]
        public XamlErrorHighlighting(string toolTipFormat, params object[] args) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class XamlEventHandlerNotResolvedError : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlNotResolvedError
    {
        public XamlEventHandlerNotResolvedError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlEventHandlerSignatureError : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlighting
    {
        public XamlEventHandlerSignatureError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.IndexOutOfGridDefinition", "XAML", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class XamlGridIndexOutOfRangeHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.IndexOutOfGridDefinition";
        public XamlGridIndexOutOfRangeHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement gridElement, [JetBrains.Annotations.NotNullAttribute()] string definitionName, int index, System.Nullable<int> span, int range) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string DefinitionName { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement GridElement { get; }
        public int Index { get; set; }
        public int Range { get; set; }
        public System.Nullable<int> Span { get; set; }
        public override bool IsValid() { }
    }
    public abstract class XamlHighlightingBase : JetBrains.ReSharper.Daemon.IHighlighting
    {
        protected XamlHighlightingBase() { }
        protected XamlHighlightingBase(string toolTip) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("toolTipFormat")]
        protected XamlHighlightingBase(string toolTipFormat, params object[] args) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; set; }
        public virtual bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.IgnoredPathHighlighting", "XAMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class XamlIgnoredPathHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlighting
    {
        public const string SEVERITY_ID = "Xaml.IgnoredPathHighlighting";
        public XamlIgnoredPathHighlighting(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlInvalidResourceTargetTypeErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlInvalidTypeErrorBase<JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference>
    {
        public XamlInvalidResourceTargetTypeErrorHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType expectedType) { }
        protected override JetBrains.ReSharper.Psi.IType GetActualType(JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference reference) { }
        protected override string GetReason(JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlInvalidResourceTypeErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlInvalidTypeErrorBase<JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference>
    {
        public XamlInvalidResourceTypeErrorHighlighting(JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference reference) { }
        protected override JetBrains.ReSharper.Psi.IType GetActualType(JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference reference) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetExpectedTypes(JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference reference) { }
    }
    public abstract class XamlInvalidTypeErrorBase<TReference> : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlightingBase
        where TReference : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        protected XamlInvalidTypeErrorBase(TReference reference, params JetBrains.ReSharper.Psi.IType[] expectedTypes) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.IType GetActualType(TReference reference);
        protected virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetExpectedTypes(TReference reference) { }
        protected virtual string GetReason(TReference reference) { }
        protected virtual void PrintActualType(JetBrains.ReSharper.Psi.IType actualType, System.Text.StringBuilder sb, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlInvalidTypeErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlInvalidTypeErrorBase<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference>
    {
        public XamlInvalidTypeErrorHighlighting(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference reference) { }
        protected override JetBrains.ReSharper.Psi.IType GetActualType(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference reference) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetExpectedTypes(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference reference) { }
        protected override string GetReason(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference reference) { }
        protected override void PrintActualType(JetBrains.ReSharper.Psi.IType actualType, System.Text.StringBuilder sb, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlInvalidTypeMemberErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlInvalidTypeErrorBase<JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberReference>
    {
        public XamlInvalidTypeMemberErrorHighlighting(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberReference reference) { }
        protected override JetBrains.ReSharper.Psi.IType GetActualType(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberReference reference) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetExpectedTypes(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberReference reference) { }
        protected override string GetReason(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.LanguageLevel", "XAML", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlLanguageLevelErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        public const string ERROR_TOOLTIP = "Xaml 2009 language construct is not allowed here";
        public const string SEVERITY_ID = "Xaml.LanguageLevel";
        public XamlLanguageLevelErrorHighlighting(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string tooltip) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.LanguageLevel", "XAML", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlLanguageLevelResolveErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlightingBase
    {
        public XamlLanguageLevelResolveErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.MappedPathHighlighting", "XAMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class XamlMappedPathHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlighting
    {
        public const string SEVERITY_ID = "Xaml.MappedPathHighlighting";
        public XamlMappedPathHighlighting(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlMethodErrorHiglighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlightingBase
    {
        public XamlMethodErrorHiglighting(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlMethodReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.MissingGridIndex", "XAML", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class XamlMissingGridIndexHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string SEVERITY_ID = "Xaml.MissingGridIndex";
        public XamlMissingGridIndexHighlighting([JetBrains.Annotations.NotNullAttribute()] string definitionName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string DefinitionName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement Element { get; set; }
        public JetBrains.DocumentModel.DocumentRange CalculateRange() { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "GutterMarks", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class XamlNamespaceAliasMarkOnGutter : JetBrains.ReSharper.Daemon.InheritanceMarkOnGutterBase<JetBrains.ReSharper.Psi.IDeclaredElement>
    {
        public XamlNamespaceAliasMarkOnGutter(JetBrains.ReSharper.Psi.Tree.IDeclaration inheritor) { }
        protected override string FormatLocation(JetBrains.ReSharper.Psi.IDeclaredElement member) { }
        protected override string FromName(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class XamlNotResolvedError : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlighting
    {
        public XamlNotResolvedError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public abstract class XamlNotResolvedLateBoundHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlighting
    {
        protected XamlNotResolvedLateBoundHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference, string tooltip) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.PathError", "XAMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class XamlPathWarningHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlighting
    {
        public XamlPathWarningHighlighting(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.RedundantAttachedProperty", "XAML", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class XamlRedundantAttachedPropertySetterHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantElementHighlightingBase
    {
        public const string DESCRIPTION = "Attached property setter \'{0}.{1}\' has no effect in current context and can be re" +
            "moved";
        public const string QUICK_FIX_TEXT = "Remove redundant attached property setter";
        public const string SEVERITY_ID = "Xaml.RedundantAttachedProperty";
        public XamlRedundantAttachedPropertySetterHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType ownerType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertySetter) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.RedundantCollectionProperty", "XAML", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class XamlRedundantCollectionPropertyHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantElementHighlightingBase
    {
        public const string DESCRIPTION = "Empty collection property setter is redundand and can be safely removed";
        public const string QUICK_FIX_TEXT = "Remove redundant property property setter";
        public const string SEVERITY_ID = "Xaml.RedundantCollectionProperty";
        public XamlRedundantCollectionPropertyHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPropertyElement propertyElement) { }
    }
    public abstract class XamlRedundantElementHighlightingBase : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlighting, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected XamlRedundantElementHighlightingBase([JetBrains.Annotations.NotNullAttribute()] string tooltipText, [JetBrains.Annotations.NotNullAttribute()] string quickFixText, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string QuickFixText { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode UnusedElement { get; }
        public JetBrains.DocumentModel.DocumentRange CalculateRange() { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.RedundantFreezeAttribute", "XAML", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class XamlRedundantFreezeAttributeHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantElementHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.RedundantFreezeAttribute";
        public XamlRedundantFreezeAttributeHighlighting([JetBrains.Annotations.NotNullAttribute()] string tooltipText, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute freezeAttribute) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.RedundantGridDefinitions", "XAML", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class XamlRedundantGridDefinitionsAttributeHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantElementHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.RedundantGridDefinitions";
        public XamlRedundantGridDefinitionsAttributeHighlighting([JetBrains.Annotations.NotNullAttribute()] string definitionName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPropertyElement setter) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.RedundantGridSpan", "XAML", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class XamlRedundantGridSpanAttributeHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantElementHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.RedundantGridSpan";
        public XamlRedundantGridSpanAttributeHighlighting([JetBrains.Annotations.NotNullAttribute()] string definitionName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter setter) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.RedundantNameAttribute", "XAML", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class XamlRedundantNameAttributeHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantElementHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.RedundantNameAttribute";
        public XamlRedundantNameAttributeHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute nameAttribute) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.RedundantNamespaceAlias", "XAML", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class XamlRedundantNamespaceAliasHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantElementHighlightingBase
    {
        public const string DESCRIPTION = "Namespace alias is not required by code and can be safely removed";
        public const string QUICK_FIX_TEXT = "Remove redundant namespace alias";
        public const string SEVERITY_ID = "Xaml.RedundantNamespaceAlias";
        public XamlRedundantNamespaceAliasHighlighting([JetBrains.Annotations.NotNullAttribute()] string tooltipText, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode namespaceAlias, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias> list) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias> AllRedundantAliases { get; }
        public static string NotUsedTooltip([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias namespaceAlias) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.RedundantPropertyTypeQualifier", "XAML", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class XamlRedundantPropertyTypeQualifierHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantRangeHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.RedundantPropertyTypeQualifier";
        public XamlRedundantPropertyTypeQualifierHighlighting(JetBrains.DocumentModel.DocumentRange range) { }
        public XamlRedundantPropertyTypeQualifierHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference typeReference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference propertyReference) { }
    }
    public abstract class XamlRedundantRangeHighlightingBase : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlighting, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected XamlRedundantRangeHighlightingBase([JetBrains.Annotations.NotNullAttribute()] string tooltipText, [JetBrains.Annotations.NotNullAttribute()] string quickFixText, JetBrains.DocumentModel.DocumentRange range, System.Nullable<JetBrains.DocumentModel.DocumentRange> replaceWithRange = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string QuickFixText { get; }
        public System.Nullable<JetBrains.DocumentModel.DocumentRange> ReplaceWithRange { get; set; }
        public JetBrains.DocumentModel.DocumentRange UnusedRange { get; }
        public JetBrains.DocumentModel.DocumentRange CalculateRange() { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.RedundantResource", "XAML", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class XamlRedundantResourceHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantElementHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string QUICK_FIX_TEXT = "Remove redundant resource";
        public const string SEVERITY_ID = "Xaml.RedundantResource";
        public XamlRedundantResourceHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration declaration) { }
        public JetBrains.DocumentModel.DocumentRange CalculateRange() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.RedundantStyledValue", "XAML", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class XamlRedundantStyledValueHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantElementHighlightingBase
    {
        public const string DESCRIPTION = "Equal value provided by style \'{0}\'";
        public const string QUICK_FIX_TEXT = "Remove redundant property setter";
        public const string SEVERITY_ID = "Xaml.RedundantStyledValue";
        public XamlRedundantStyledValueHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode setter, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlResource resource, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> allUnusedProperties) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> AllUnusedElements { get; }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlResolveErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlightingBase
    {
        public XamlResolveErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public XamlResolveErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference, string tooltip) { }
    }
    public abstract class XamlResolveErrorHighlightingBase : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        protected XamlResolveErrorHighlightingBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected XamlResolveErrorHighlightingBase(JetBrains.ReSharper.Psi.Resolve.IReference reference, string tooltip) { }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        protected static string CreateTooltip(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected static string FormatResourceReference(JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference resourceReference) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlResolveFolderOrAssemblyErrorHiglighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlighting
    {
        public XamlResolveFolderOrAssemblyErrorHiglighting(JetBrains.ReSharper.Psi.Xaml.Tree.IFolderOrAssemblyReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "GutterMarks", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class XamlResourceMarkOnGutter : JetBrains.ReSharper.Daemon.InheritanceMarkOnGutterBase<JetBrains.ReSharper.Psi.IDeclaredElement>
    {
        public XamlResourceMarkOnGutter(JetBrains.ReSharper.Psi.Tree.IDeclaration inheritor) { }
        protected override string FormatLocation(JetBrains.ReSharper.Psi.IDeclaredElement member) { }
        protected override string FromName(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class static XamlStaticHighlightingsGroups
    {
        public const string XAML_ERRORS_GROUP = "XAMLErrors";
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.StaticResourceNotResolved", "XAML", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class XamlStaticResourceNotResolvedHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlNotResolvedLateBoundHighlighting
    {
        public const string SEVERITY_ID = "Xaml.StaticResourceNotResolved";
        public XamlStaticResourceNotResolvedHighlighting(JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference reference) { }
        public JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference Reference { get; }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.DuplicateStyleSetter", "XAML", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class XamlStyleDuplicateSetterWarning : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.DuplicateStyleSetter";
        public XamlStyleDuplicateSetterWarning([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement setter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.StyleInvalidTargetType", "XAML", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlStyleInvalidTargetTypeError : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.StyleInvalidTargetType";
        public XamlStyleInvalidTargetTypeError([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType targetType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType basedOnStyle) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "GutterMarks", AttributeId="ReSharper Hides", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class XamlStyleSetterResourceMarkOnGutter : JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.IInheritanceMarkOnGutter
    {
        public XamlStyleSetterResourceMarkOnGutter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertySetter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlResource basedOnResource) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
        public void OnClick(System.Drawing.Image icon) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlTextMissingHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        public XamlTextMissingHighlighting(JetBrains.ReSharper.Psi.Tree.ITreeNode element, int offset, string textToInsert, string tooltip) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public int Offset { get; }
        public string TextToInsert { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlTypeDeclarationAccessRightsErrorHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        public XamlTypeDeclarationAccessRightsErrorHighlighting(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeDeclaration typeDeclaration) { }
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeDeclaration TypeDeclaration { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class XamlTypeNotResolvedError : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlNotResolvedError
    {
        public XamlTypeNotResolvedError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlValueTypeResourceCannotHaveNameHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantElementHighlightingBase
    {
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute NameAttribute;
        public XamlValueTypeResourceCannotHaveNameHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute nameAttribute) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Xaml.XKeyAttributeDisallowed", "XAML", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlXKeyAttributeDisallowedHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        public const string SEVERITY_ID = "Xaml.XKeyAttributeDisallowed";
        public XamlXKeyAttributeDisallowedHighlighting(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XAMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XamlXKeyAttributeRequiredHighlighting : JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlHighlightingBase
    {
        public XamlXKeyAttributeRequiredHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration resourceDeclaration) { }
        public JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration ResourceDeclaration { get; }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Daemon.Xaml.Stages.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlNotResolvedErrorHandler : JetBrains.ReSharper.Daemon.Xml.Stages.Resolve.XmlNotResolvedErrorHandler
    {
        protected override JetBrains.ReSharper.Daemon.IHighlighting CreateNotResolvedErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override JetBrains.ReSharper.Daemon.IHighlighting CreateNotResolvedLateBoundReferenceHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlPathErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.PathErrorHandler
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public override JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class static XamlPathHighlightingUtil
    {
        public static JetBrains.ReSharper.Daemon.IHighlighting CreateHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Xaml.Stages
{
    
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlTypeDeclarationAccessRightsErrorHighlighting)})]
    public class XamlAccessRightsProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeDeclaration>
    {
        protected override void Run(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeDeclaration element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlGridIndexOutOfRangeHighlighting),
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantGridDefinitionsAttributeHighlighting),
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantGridSpanAttributeHighlighting)})]
    public class XamlGridProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement>
    {
        protected override void Run(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public static System.Nullable<int> TryGetNumericPropertyValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType propertyOwner, [JetBrains.Annotations.NotNullAttribute()] string propertyName, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertySetter) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryGetStringPropertyValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType propertyOwner, [JetBrains.Annotations.NotNullAttribute()] string propertyName, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertySetter) { }
    }
    public class static XamlHighlightingConsumerExtension
    {
        public static void AddHighlighting([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.IHighlighting error, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode rangeNode) { }
        public static void AddHighlighting([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.IHighlighting error, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static void AddHighlighting([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange error) { }
        public static void AddHighlighting([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, JetBrains.ReSharper.Daemon.IHighlighting error, JetBrains.DocumentModel.DocumentRange range) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Xaml.Tree.IModifiersAttribute)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantModifiersAttributeHighlighting),
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlErrorHighlighting)})]
    public class XamlModifiersAttributeProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.Xaml.Tree.IModifiersAttribute>
    {
        protected override void Run(JetBrains.ReSharper.Psi.Xaml.Tree.IModifiersAttribute element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantPropertyTypeQualifierHighlighting),
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantAttachedPropertySetterHighlighting),
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantCollectionPropertyHighlighting)})]
    public class XamlPropertySetterProblemAnalzyer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter>
    {
        protected override void Run(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Xaml.Tree.IRelativeSourceUsage)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlResolveErrorHighlighting),
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRelativeSourceDefaultModeWarningHighlighting)})]
    public class XamlRelativeSourceProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.Xaml.Tree.IRelativeSourceUsage>
    {
        protected override void Run(JetBrains.ReSharper.Psi.Xaml.Tree.IRelativeSourceUsage element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement)})]
    public class XamlStyledControlProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement>
    {
        protected override void Run(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Xaml.Tree.IStyleDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlStyleInvalidTargetTypeError),
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantPropertyTypeQualifierHighlighting)})]
    public class XamlStyleDeclarationProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.Xaml.Tree.IStyleDeclaration>
    {
        protected override void Run(JetBrains.ReSharper.Psi.Xaml.Tree.IStyleDeclaration declaration, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Xaml.Tree.IResourceUsage)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlInvalidResourceTargetTypeErrorHighlighting)})]
    public class XamlStyleResourceProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.Xaml.Tree.IResourceUsage>
    {
        protected override void Run(JetBrains.ReSharper.Psi.Xaml.Tree.IResourceUsage element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
}