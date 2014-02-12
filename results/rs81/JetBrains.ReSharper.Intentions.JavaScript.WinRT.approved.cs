[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.JavaScript.WinRT.QuickFixes.CreateFromUsage
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CreateFromUsageWinRTContextProvider : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.ICreatePropertyFromUsageContextProvier
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.IJsCreateFromUsageBulbItem> ProvideContexts(JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.CreateFromUsageContextProviders providers, JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType type, JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.UsageInfo usageInfo) { }
    }
    public class CreateMethodFromUsageWinRT : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext, JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference>, JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.IJsCreateFromUsageBulbItem
    {
        public CreateMethodFromUsageWinRT(JetBrains.ReSharper.Psi.ITypeElement typeElement, bool isStatic, JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.UsageInfo usageInfo) { }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
    }
    public class CreatePropertyFromUsageWinRT : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext, JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference>, JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.IJsCreateFromUsageBulbItem
    {
        public CreatePropertyFromUsageWinRT(JetBrains.ReSharper.Psi.ITypeElement typeElement, bool isStatic, JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.UsageInfo usageInfo) { }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
    }
}