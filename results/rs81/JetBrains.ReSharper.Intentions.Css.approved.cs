[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.Css.ContextActions
{
    
    public abstract class ColorConvertActionBase : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        protected ColorConvertActionBase(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        protected JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider DataProvider { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution);
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode();
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Colors.IColorElement colorElement);
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionDataBuilderAttribute(typeof(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider))]
    public class CssContextActionDataBuilder : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataBuilder
    {
        public JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider Build(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class static CssContextActions
    {
        public const string GroupID = "CSS";
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from hex literal to hsl()", Group="CSS", Name="Convert hex color to hsl()", Priority=10)]
    public class HexColorToHslAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public HexColorToHslAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from hex literal to named form", Group="CSS", Name="Convert hex color to named", Priority=20)]
    public class HexColorToNamedColorAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public HexColorToNamedColorAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from hex literal to rgb()", Group="CSS", Name="Convert hex color to rgb()", Priority=15)]
    public class HexColorToRgbAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public HexColorToRgbAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from hsl() to hex literal", Group="CSS", Name="Convert hsl() to hex literal", Priority=15)]
    public class HslToHexColorAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public HslToHexColorAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from hsl() to named form", Group="CSS", Name="Convert hsl() to named form", Priority=15)]
    public class HslToNamedColorAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public HslToNamedColorAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from hsl() to rgb()", Group="CSS", Name="Convert hsl() to rgb()", Priority=15)]
    public class HslToRgbAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public HslToRgbAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from named form to hex literal", Group="CSS", Name="Convert named color to hex form", Priority=10)]
    public class NamedColorToHexColorAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public NamedColorToHexColorAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from named form to hsl()", Group="CSS", Name="Convert named color to hsl()", Priority=10)]
    public class NamedColorToHslAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public NamedColorToHslAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from named form to rgb()", Group="CSS", Name="Convert named color to rgb()", Priority=10)]
    public class NamedColorToRgbAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public NamedColorToRgbAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from rgb() to hex literal", Group="CSS", Name="Convert rgb() to hex literal", Priority=15)]
    public class RgbToHexColorAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public RgbToHexColorAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from rgb() to hsl()", Group="CSS", Name="Convert rgb() to hsl()", Priority=15)]
    public class RgbToHslAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public RgbToHslAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts color value from rgb() to named form", Group="CSS", Name="Convert rgb() to named form", Priority=15)]
    public class RgbToNamedColorAction : JetBrains.ReSharper.Intentions.Css.ContextActions.ColorConvertActionBase
    {
        public RgbToNamedColorAction(JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewColorNode(JetBrains.ReSharper.Psi.Colors.IColorElement colorElement, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode FindColorNode() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITreeNode colorNode, JetBrains.ReSharper.Psi.Colors.IColorElement colorElement) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Css.QuickFixes
{
    
    public class AddVendorSpecificPropertiesFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddVendorSpecificPropertiesFix(JetBrains.ReSharper.Daemon.Css.Stages.CssBrowserCompatibilityWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ConvertToHslaFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ConvertToHslaFix(JetBrains.ReSharper.Daemon.Css.Stages.HexColorValueWithAlphaError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ConvertToRgbaFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ConvertToRgbaFix(JetBrains.ReSharper.Daemon.Css.Stages.HexColorValueWithAlphaError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CreateFallbackColorFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CreateFallbackColorFix(JetBrains.ReSharper.Daemon.Css.Stages.RequiresFallbackColorWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CssUsePseudoSelectorNotFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CssUsePseudoSelectorNotFix(JetBrains.ReSharper.Daemon.Css.Stages.SyntaxIsNotAllowedError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class PutPropertyAfterVendorPropertiesFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public PutPropertyAfterVendorPropertiesFix(JetBrains.ReSharper.Daemon.Css.Stages.CssPropertyDoesNotOverrideVendorPropertyWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveAlphaComponentFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveAlphaComponentFix(JetBrains.ReSharper.Daemon.Css.Stages.HexColorValueWithAlphaError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveFix(JetBrains.ReSharper.Daemon.Css.Stages.DeclarationIsEmptyWarning warning) { }
        public RemoveFix(JetBrains.ReSharper.Daemon.Css.Stages.UnexpectedValueError warning) { }
        public RemoveFix(JetBrains.ReSharper.Daemon.Css.Stages.RedundantWarning warning) { }
        protected RemoveFix(JetBrains.ReSharper.Psi.ITreeRange range, string partName) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveUnitMeasureFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveUnitMeasureFix(JetBrains.ReSharper.Daemon.Css.Stages.UnitMeasureRedundantWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SwitchCssLanguageVersionFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SwitchCssLanguageVersionFix(JetBrains.ReSharper.Daemon.Css.Stages.CssNotResolvedError obj) { }
        public SwitchCssLanguageVersionFix(JetBrains.ReSharper.Daemon.Css.Stages.SyntaxIsNotAllowedError obj) { }
        public SwitchCssLanguageVersionFix(JetBrains.ReSharper.Daemon.Css.Stages.UnknownFunctionError obj) { }
        public SwitchCssLanguageVersionFix(JetBrains.ReSharper.Daemon.Css.Stages.UnknownPseudoFunctionError obj) { }
        public SwitchCssLanguageVersionFix(JetBrains.ReSharper.Daemon.Css.Stages.UnknownPseudoElementError obj) { }
        public SwitchCssLanguageVersionFix(JetBrains.ReSharper.Daemon.Css.Stages.UnknownPseudoClassError obj) { }
        public SwitchCssLanguageVersionFix(JetBrains.ReSharper.Daemon.Css.Stages.UnknownMediaFeatureError obj) { }
        public SwitchCssLanguageVersionFix(JetBrains.ReSharper.Daemon.Css.Stages.UnknownCssPropertyError obj) { }
        public SwitchCssLanguageVersionFix(JetBrains.ReSharper.Daemon.Css.Stages.UnknownCssVendorExtensionError obj) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class TurnOffBrowserCompatibilityFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public TurnOffBrowserCompatibilityFix(JetBrains.ReSharper.Daemon.Css.Stages.CssBrowserCompatibilityWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Css.QuickFixes.DisableWarnings
{
    
    public abstract class DisableByCommentFixBase : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        protected readonly string myId;
        protected DisableByCommentFixBase(JetBrains.DocumentModel.DocumentRange range, string id) { }
        protected abstract string ClosingText { get; }
        protected abstract string OpeningText { get; }
        public abstract string Text { get; }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
}