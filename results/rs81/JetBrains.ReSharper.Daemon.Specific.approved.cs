[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("CheckNamespace", null, "ConstraintViolation", "Namespace does not correspond to file location", "Namespace in file does not have a form of project Default Namespace plus folder n" +
    "ames in the path to file. \\r\\nYou can configure which folders participate in nam" +
    "espace building process on the folder\'s properties page", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("FormatStringProblem", null, "CodeSmell", "String formatting method problems", "\\n          Format string syntax errors (unescaped braces, invalid idices, invali" +
    "d alignments etc.) and other formatting method invocation problems.\\n        ", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("InconsistentNaming", null, "ConstraintViolation", "Inconsistent Naming", "Name doesn\'t match naming style defined for this kind of symbol", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("PossibleInfiniteInheritance", null, "CodeSmell", "Possible infinite inheritance", "According to ECMA-335 part II (Metadata) paragraph 9.2: \'Generics and recursive i" +
    "nheritance graphs\'", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("TODOHighlightings", "TODO Highlightings", false)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Todo Item", "{13D47EF0-D61D-4fe6-AD71-E62105F63B42}", DarkForegroundColor="LightSkyBlue", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.TEXT, ErrorStripeColorHighlighterAttributeId="ReSharper Todo Item Marker on Error Stripe", FontStyle=System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Bold, ForegroundColor="Blue", Layer=3999, VSPriority=850)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Todo Item Marker on Error Stripe", DarkForegroundColor="#0A72B2", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.ERROR_STRIPE_MARK, ForegroundColor="#80E7FF:Blue")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Specific.CheckNamespace
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CheckNamespace", "ANY", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class CheckNamespaceHighlighting : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string SeverityId = "CheckNamespace";
        public CheckNamespaceHighlighting(JetBrains.ReSharper.Psi.Tree.ITypeAndNamespaceHolderDeclaration holderDeclaration, string expectedNamespace) { }
        public string ErrorStripeToolTip { get; }
        public string ExpectedNamespace { get; }
        public JetBrains.ReSharper.Psi.Tree.ITypeAndNamespaceHolderDeclaration HolderDeclaration { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    public class NamespaceChecker
    {
        public string ExpectedNamespace { get; }
        public bool CheckNamespace(JetBrains.ReSharper.Psi.Tree.INamespaceDeclaration namespaceDeclaration) { }
        public bool CheckNamespace(JetBrains.ReSharper.Psi.Tree.IFile containingFile, string namespaceName) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Specific.Errors
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("FormatStringProblem", "CSHARP,VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Format string item alignment is not a number")]
    public class FormatStringAlignmentIsNotNumberWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string HIGHLIGHTING_ID = "FormatStringProblem";
        protected const string MESSAGE = "Format string item alignment is not a number";
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("FormatStringProblem", "CSHARP,VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Formatting is specified, but argument is not IFormattable")]
    public class FormatStringArgumentIsNotIFormattableWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string HIGHLIGHTING_ID = "FormatStringProblem";
        protected const string MESSAGE = "Formatting is specified, but argument is not IFormattable";
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("FormatStringProblem", "CSHARP,VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Argument is not used in format string")]
    public class FormatStringArgumentIsNotUsedWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "FormatStringProblem";
        protected const string MESSAGE = "Argument is not used in format string";
        public FormatStringArgumentIsNotUsedWarning(JetBrains.ReSharper.Psi.Tree.IExpression argument) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression Argument { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("FormatStringProblem", "CSHARP,VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Non-existing argument in format string")]
    public class FormatStringInexistingArgumentWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string HIGHLIGHTING_ID = "FormatStringProblem";
        protected const string MESSAGE = "Non-existing argument in format string";
        public FormatStringInexistingArgumentWarning(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner) { }
        public JetBrains.ReSharper.Psi.Tree.IArgumentsOwner ArgumentsOwner { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("FormatStringProblem", "CSHARP,VBASIC", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Format item index must be a number starting 0 without leading or trailing whitesp" +
        "aces")]
    public class FormatStringInvalidFormatItemIndexWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string HIGHLIGHTING_ID = "FormatStringProblem";
        protected const string MESSAGE = "Format item index must be a number starting 0 without leading or trailing whitesp" +
            "aces";
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("FormatStringProblem", "CSHARP,VBASIC", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Unmatched opening brace in format string")]
    public class FormatStringUnescapedLBraceWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string HIGHLIGHTING_ID = "FormatStringProblem";
        protected const string MESSAGE = "Unmatched opening brace in format string";
        public FormatStringUnescapedLBraceWarning(int braceEndOffset) { }
        public int BraceEndOffset { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("FormatStringProblem", "CSHARP,VBASIC", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Unmatched closing brace in format string")]
    public class FormatStringUnescapedRBraceWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string HIGHLIGHTING_ID = "FormatStringProblem";
        protected const string MESSAGE = "Unmatched closing brace in format string";
        public FormatStringUnescapedRBraceWarning(int braceEndOffset) { }
        public int BraceEndOffset { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Daemon.Specific.FormatStringProblemAnalyzer
{
    
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Specific.Errors.FormatStringUnescapedRBraceWarning),
            typeof(JetBrains.ReSharper.Daemon.Specific.Errors.FormatStringUnescapedLBraceWarning),
            typeof(JetBrains.ReSharper.Daemon.Specific.Errors.FormatStringInvalidFormatItemIndexWarning),
            typeof(JetBrains.ReSharper.Daemon.Specific.Errors.FormatStringAlignmentIsNotNumberWarning),
            typeof(JetBrains.ReSharper.Daemon.Specific.Errors.FormatStringInexistingArgumentWarning),
            typeof(JetBrains.ReSharper.Daemon.Specific.Errors.FormatStringArgumentIsNotUsedWarning),
            typeof(JetBrains.ReSharper.Daemon.Impl.FormatStringItemHighlighting)})]
    public class FormatStringProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.Tree.IArgumentsOwner>
    {
        public FormatStringProblemAnalyzer(JetBrains.ReSharper.Feature.Services.Util.ClrLanguages.FormattingFunctionInvocationInfoProvider formattingFunctionInvocationInfoProvider) { }
        public static bool AllFormatItemsAreInLiterals(JetBrains.ReSharper.Psi.Util.IStringConcatenationClrWrapper formatStringConcatenation, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Util.FormatStringParser.FormatItem> formatItemsToDecrement) { }
        protected override void Run(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Specific.InheritedGutterMarkChecker
{
    
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Specific.InheritedGutterMarkChecker.TypeIsInheritedMarkOnGutter)})]
    public class InheritedGutterMarkChecker : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "GutterMarks", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class TypeIsInheritedMarkOnGutter : JetBrains.ReSharper.Daemon.ICustomAttributeIdHighlighting, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.IInheritanceMarkOnGutter
    {
        public TypeIsInheritedMarkOnGutter(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public string AttributeId { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
        public void OnClick(System.Drawing.Image icon) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Specific.NamingConsistencyCheck
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("InconsistentNaming", "CSHARP,VBASIC,XAML,JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, OverloadResolvePriority=-1, ToolTipFormatString="Name \'{0}\' does not match rule \'{1}\'. Suggested name is \'{2}\'.")]
    public class InconsistentNamingWarning : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public InconsistentNamingWarning([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string name, string rule, string suggestedName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string ErrorStripeToolTip { get; }
        public string Name { get; }
        public int NavigationOffsetPatch { get; }
        public string Rule { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public string SuggestedName { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)})]
    public class NamingConsistencyCheckStage : JetBrains.ReSharper.Daemon.IDaemonStage, JetBrains.ReSharper.Daemon.IDaemonStageWithSettings
    {
        public NamingConsistencyCheckStage(JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Psi.Naming.Impl.NamingPolicyManager namingPolicyManager) { }
        public System.Type[] DaemonStagesRequired { get; }
        public int CalcSettingsHash(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Specific.PossibleInfiniteInheritance
{
    
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Specific.PossibleInfiniteInheritance.PossibleInfiniteInheritanceHighlighting)})]
    public class PossibleInfiniteInheritanceChecker : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PossibleInfiniteInheritance", "ANY", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class PossibleInfiniteInheritanceHighlighting : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string SeverityId = "PossibleInfiniteInheritance";
        public PossibleInfiniteInheritanceHighlighting(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Daemon.Specific.TodoItems
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "TODOHighlightings", AttributeId="ReSharper Todo Item", ErrorStripeColorHighlighterAttributeId="ReSharper Todo Item Marker on Error Stripe", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class TodoItemHighlighting : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public TodoItemHighlighting(JetBrains.ReSharper.Feature.Services.TodoItems.TodoItem item) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Feature.Services.TodoItems.TodoItem Item { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)})]
    public class TodoItemsDaemonStage : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public TodoItemsDaemonStage(JetBrains.ReSharper.Feature.Services.TodoItems.TodoManager todoManager, JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TodoItemsHighlighterInvalidator
    {
        public TodoItemsHighlighterInvalidator(JetBrains.ReSharper.Feature.Services.TodoItems.TodoManager todoManager, JetBrains.ReSharper.Daemon.Daemon daemon) { }
    }
}