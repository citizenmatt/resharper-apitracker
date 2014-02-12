[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.BuildScriptSupport
{
    
    public class GoToPrevTargetHandler : JetBrains.ReSharper.Feature.Services.BuildScripts.GoToNextPrevTarget.GoToNextPrevTargetHandlerBase, JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class BuildScriptFeatureServicesComponent
    {
        public BuildScriptFeatureServicesComponent(JetBrains.ActionManagement.IActionManager actionManager, JetBrains.DataFlow.Lifetime lifetime) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2
{
    
    public abstract class BuildScriptCodeCompletionContext : JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlCodeCompletionContext
    {
        protected BuildScriptCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext UnterminatedContext { get; }
    }
    public abstract class BuildScriptCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.CodeCompletionContextProviderBase
    {
        protected abstract JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptCodeCompletionContext GetBuildScriptCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.Util.TextRange referenceDocumentRange, JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext unterminatedContext);
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext GetUnterminatedContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Psi.TreeTextRange selectedRange);
    }
    public abstract class BuildScriptReparsedCodeCompletionContext : JetBrains.ReSharper.Feature.Services.Xml.CodeCompletion.XmlReparsedCodeCompletionContext
    {
        protected BuildScriptReparsedCodeCompletionContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
        public int GetCaretOffsetInNewNode(int nodeStartOffset) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AutopopupInMSBuildOnAttributeStrategy : JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.AutopopupInMSBuildStrategyBase
    {
        public AutopopupInMSBuildOnAttributeStrategy(JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AutopopupInMSBuildStrategy : JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.AutopopupInMSBuildStrategyBase
    {
        public AutopopupInMSBuildStrategy(JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
    public abstract class AutopopupInMSBuildStrategyBase : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        protected JetBrains.ReSharper.Psi.Services.CachingLexerService CachingLexerService;
        protected JetBrains.Application.Settings.SettingsScalarEntry SettingsEntry;
        protected AutopopupInMSBuildStrategyBase(JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public abstract bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore);
        protected bool FindAndCheckXmlToken(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, int offset, System.Func<JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet> checker) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class MSBuildCodeCompletionContext : JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptCodeCompletionContext
    {
        public MSBuildCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public override string ContextId { get; }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class MSBuildCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptCodeCompletionContextProvider
    {
        public MSBuildCodeCompletionContextProvider(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.Settings.MSBuildIntellisenseManager msBuildIntellisenseManager) { }
        protected override JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptCodeCompletionContext GetBuildScriptCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.Util.TextRange referenceDocumentRange, JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext unterminatedContext) { }
        protected override JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext GetUnterminatedContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Psi.TreeTextRange selectedRange) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class MSBuildCompletingCharactersProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSetting<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext, JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCompletingCharactersSettingsKey>
    {
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCompletingCharactersSettingsKey, bool>> GetCompleteOnSpaceSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetEnterActionSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCompletingCharactersSettingsKey, string>> GetNonCompletingCharactersSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetTabActionSettingKey() { }
        protected override bool IsApplicable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey), "MSBuild")]
    public class MSBuildCompletingCharactersSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Complete on space")]
        public bool CompleteOnSpace;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Insert, "Enter action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType EnterAction;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Non-completing characters")]
        public string NonCompletingCharacters;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Replace, "Tab action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType TabAction;
    }
    public class MSBuildReparsedCodeCompletionContext : JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext
    {
        public MSBuildReparsedCodeCompletionContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
        protected override JetBrains.ReSharper.Psi.Services.IReparseContext GetReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.LookupItems
{
    
    public class MSBuildAttributeLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public MSBuildAttributeLookupItem(string attributeName, bool required) { }
        public string AttributeName { get; }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class MSBuildAttributeWithValueLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public MSBuildAttributeWithValueLookupItem(string attributeName, string value, bool required) { }
        public string AttributeName { get; }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public string Value { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class MSBuildCommentLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public MSBuildCommentLookupItem() { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class MSBuildDeclaredElementLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public MSBuildDeclaredElementLookupItem(string elementName, bool isProperty, JetBrains.Util.TextRange completionRange) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class MSBuildElementLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public MSBuildElementLookupItem(string elementName, bool isTask) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        protected static JetBrains.ReSharper.Psi.Tree.IFile CommitPSI(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken FindClosingIdentifier(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.TreeOffset offset, JetBrains.ProjectModel.ISolution solution, out JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken openIdentifierNode, out bool completingClosingIdentifier) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class MSBuildMetadataLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public MSBuildMetadataLookupItem(string itemName) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public override string ToString() { }
        public void Unshrink() { }
    }
    public class MSBuildSingleLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public MSBuildSingleLookupItem(string name) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class MSBuildTargetLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public MSBuildTargetLookupItem(string targetName) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class NewMSBuildPropertyLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public NewMSBuildPropertyLookupItem() { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.Rules
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MSBuildAttributeCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext>
    {
        public MSBuildAttributeCompletionRule(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguageService languageService) { }
        public bool CanGenerate { get; }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MSBuildAttributeValueCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext>
    {
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MSBuildDeclaredElementCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext>
    {
        public MSBuildDeclaredElementCompletionRule(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguageService languageService) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MSBuildTagCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext>
    {
        public MSBuildTagCompletionRule(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguageService languageService) { }
        public bool CanGenerate { get; }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MSBuildTargetCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext>
    {
        public MSBuildTargetCompletionRule(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        public bool CanGenerate { get; }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class RangesProviderBase : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext>, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICodeCompletionItemsProvider, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletionRangesProvider
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.MSBuildCodeCompletionContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.MSBuild.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledSettingsKey), "Override VS IntelliSense for MSBuild")]
    public class IntellisenseEnabledSettingMSBuild
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "MSBuild")]
        public bool IntellisenseEnabled;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupEnabledSettingsKey), "MSBuild")]
    public class MSBuildAutopopupEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "All")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType All;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.SoftAutopopup, "Attribute")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType Attribute;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MSBuildIntellisenseManager : JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.LanguageSpecificIntellisenseManager
    {
        public MSBuildIntellisenseManager(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override bool GetIntellisenseEnabledSpecific(JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.LookupItems
{
    
    public abstract class BuildScriptLookupItemBase : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        protected JetBrains.Util.TextRange myCompletionRange;
        protected JetBrains.UI.RichText.RichText myRichText;
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public abstract string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public abstract void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill);
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public abstract JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl);
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class NAntAttributeLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public NAntAttributeLookupItem(string attributeName, bool isRequired) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class NAntElementLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public NAntElementLookupItem(string elementName, bool isTask, JetBrains.Util.TextRange completionRange) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        protected static JetBrains.ReSharper.Psi.Tree.IFile CommitPSI(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken FindClosingIdentifier(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.TreeOffset offset, JetBrains.ProjectModel.ISolution solution, out JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken openIdentifierNode, out bool completingClosingIdentifier) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class NAntFunctionLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public NAntFunctionLookupItem(string functionName, JetBrains.Util.TextRange completionRange) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class NAntPropertyLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public NAntPropertyLookupItem(string propertyName, JetBrains.Util.TextRange completionRange) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class NAntScriptElementLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public NAntScriptElementLookupItem(string elementName, JetBrains.Util.TextRange completionRange) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken FindClosingIdentifier(JetBrains.TextControl.ITextControl textControl, int offset, JetBrains.ProjectModel.ISolution solution, out JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken openIdentifierNode) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    public class NAntSimpleLookupItem : JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.LookupItems.BuildScriptLookupItemBase
    {
        public NAntSimpleLookupItem(string text, JetBrains.Util.TextRange completionRange) { }
        public override string Identity { get; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class NAntTargetLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public NAntTargetLookupItem(string targetName, JetBrains.Util.TextRange completionRange) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class RangesProviderBase : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext>, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICodeCompletionItemsProvider, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletionRangesProvider
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt
{
    
    public class NAntCodeCompletionContext : JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptCodeCompletionContext
    {
        public NAntCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public override string ContextId { get; }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class NAntCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptCodeCompletionContextProvider
    {
        public NAntCodeCompletionContextProvider(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.Settings.NAntIntellisenseManager nAntIntellisenseManager) { }
        protected override JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptCodeCompletionContext GetBuildScriptCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.Util.TextRange referenceDocumentRange, JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext unterminatedContext) { }
        protected override JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext GetUnterminatedContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Psi.TreeTextRange selectedRange) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    public class NAntReparsedCodeCompletionContext : JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptReparsedCodeCompletionContext
    {
        public NAntReparsedCodeCompletionContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
        protected override JetBrains.ReSharper.Psi.Services.IReparseContext GetReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.Rules
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntAttributeCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntClosingTagCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext>
    {
        public NAntClosingTagCompletionRule(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context) { }
    }
    public class static NAntCompletionRuleUtil
    {
        public static JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElementCollection FindContainingCollection(JetBrains.ReSharper.Psi.Tree.ITreeNode token) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement FindContainingElement(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptCodeCompletionContext context) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement FindElement(JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement element, JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase lookFor, JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase currentTag) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntPropertyCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext>
    {
        public NAntPropertyCompletionRule(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes, JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguageService nAntLanguageService) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        public static System.Collections.Generic.JetHashSet<string> EvaluateAvailableProperties(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptCodeCompletionContext context) { }
        public System.Collections.Generic.IList<string> GetNAntFunctions() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context) { }
    }
    public class NAntScriptCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext>
    {
        public NAntScriptCompletionRule(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context) { }
        public bool ShouldCompleteClosingTag(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntTagCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext>
    {
        public NAntTagCompletionRule(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context) { }
        public bool ShouldCompleteClosingTag(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.BuildScriptCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntTargetCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext>
    {
        public NAntTargetCompletionRule(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguageService nAntLanguageService) { }
        public bool CanGenerate { get; }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntTaskElementAttributeCompletionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.NAntCodeCompletionContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.CodeCompletion2.NAnt.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledSettingsKey), "Override VS IntelliSense for NAnt")]
    public class IntellisenseEnabledSettingNAnt
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "NAnt")]
        public bool IntellisenseEnabled;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NAntIntellisenseManager : JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.LanguageSpecificIntellisenseManager
    {
        public NAntIntellisenseManager(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override bool GetIntellisenseEnabledSpecific(JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.CodeStructure.NAnt
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntCodeStructureProvider : JetBrains.ReSharper.Feature.Services.Xml.CodeStructure.XmlCodeStructureProvider
    {
        protected override void CreateElement(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement CreateRootElement(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.GoToNextPrevTarget
{
    
    public abstract class GoToNextPrevTargetHandlerBase
    {
        protected void Execute(JetBrains.Application.DataContext.IDataContext context, bool nextMethod) { }
        protected static int GetNavigationOffset(JetBrains.Application.DataContext.IDataContext context, bool nextMethod) { }
        protected static bool IsAvailable(JetBrains.Application.DataContext.IDataContext context, bool nextMethod) { }
    }
    public class GotoNextTargetHandler : JetBrains.ReSharper.Feature.Services.BuildScripts.GoToNextPrevTarget.GoToNextPrevTargetHandlerBase, JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.SelectEmbracingConstruct
{
    
    public abstract class BuildScriptEmbracingConstructProvider : JetBrains.ReSharper.Feature.Services.Xml.SelectEmbracingConstruct.XmlSelectEmbracingConstructProvider
    {
        protected BuildScriptEmbracingConstructProvider(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public abstract JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange TryExtendToEntityUsage(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode token, int offsetInToken, string tokenText, bool fromDotSelection);
    }
    public class BuildScriptTokenPartSelection : JetBrains.ReSharper.Feature.Services.Xml.SelectEmbracingConstruct.XmlTokenPartSelection
    {
        public BuildScriptTokenPartSelection(JetBrains.ReSharper.Feature.Services.BuildScripts.SelectEmbracingConstruct.BuildScriptEmbracingConstructProvider provider, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile node, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.MSBuildProjectFileType))]
    public class MSBuildScriptEmbracingConstructProvider : JetBrains.ReSharper.Feature.Services.BuildScripts.SelectEmbracingConstruct.BuildScriptEmbracingConstructProvider
    {
        public MSBuildScriptEmbracingConstructProvider(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetSelectedRange(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public override bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile file) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange TryExtendToEntityUsage(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode token, int offsetInToken, string tokenText, bool fromDotSelection) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.NAntProjectFileType))]
    public class NAntScriptEmbracingConstructProvider : JetBrains.ReSharper.Feature.Services.BuildScripts.SelectEmbracingConstruct.BuildScriptEmbracingConstructProvider
    {
        public NAntScriptEmbracingConstructProvider(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetSelectedRange(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public override bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange TryExtendToEntityUsage(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode token, int offsetInToken, string tokenText, bool fromDotSelection) { }
    }
    public abstract class SelectionBase : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange
    {
        protected SelectionBase(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile node, JetBrains.DocumentModel.DocumentRange range) { }
        public JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy ExtendToWholeLine { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile FileNode { get; }
        public abstract JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
    }
    public class TokenComparer : System.Collections.Generic.IComparer<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken>
    {
        public int Compare(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken x, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken y) { }
    }
    public class TokenSelection : JetBrains.ReSharper.Feature.Services.BuildScripts.SelectEmbracingConstruct.SelectionBase
    {
        public TokenSelection(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile node, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
    public class TokenSequenceSelection : JetBrains.ReSharper.Feature.Services.BuildScripts.SelectEmbracingConstruct.SelectionBase
    {
        public TokenSequenceSelection(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile node, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken[] tokens) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
    public class TreeNodeSelection : JetBrains.ReSharper.Feature.Services.BuildScripts.SelectEmbracingConstruct.SelectionBase
    {
        public TreeNodeSelection(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile node, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement selectedElement) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
        public static JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetTreeNodeSequenceRange(JetBrains.ReSharper.Psi.Tree.ITreeNode selectedElement, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile fileNode) { }
    }
    public class TreeNodeSequenceSelection : JetBrains.ReSharper.Feature.Services.BuildScripts.SelectEmbracingConstruct.SelectionBase
    {
        public TreeNodeSequenceSelection(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile node, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement[] siblings) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.BuildScripts.TypingAssistance
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MSBuildTypingAssist : JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistLanguageBase<JetBrains.ReSharper.Psi.Xml.XmlLanguage, JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter>, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler
    {
        public MSBuildTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
        public bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
    }
}