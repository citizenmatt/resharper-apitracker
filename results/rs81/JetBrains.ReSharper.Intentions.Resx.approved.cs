[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.IntentionsTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010087F63BA6A789C30E210E7EC987234AD9FE33BAF7367993BAB1B312D6F72CA296B91ED5C658964FFB9E7570EB184A527C68C6BDBA41CFE67D8CFD3F888234206BF39205A3652D3AF3445BB6F715FDAC532E289FEA41229BAC37762B67EB16F58FEE717D2465FCA9EE17F08ED16772A1FC52C1C17022E1F0D9BDD004524A663ACA")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.Resx.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Edit current resource value", Name="Edit resource value")]
    public class EditResourceValueContextAction : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public EditResourceValueContextAction(JetBrains.ReSharper.Feature.Services.Bulbs.LanguageIndependentContextActionDataProvider provider) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}