using ApprovalTests.Reporters;

namespace CitizenMatt.ReSharper.ApiTracker
{
    [UseReporter(typeof(DiffReporter))]
    public class ReSharper80ApiApprover : ReSharperApiApprover
    {
        private const string AssemblyPath = @"C:\work\sdk\v8.0\bin";

        protected override string ResultsPath
        {
            get { return @"..\..\results\rs80"; }
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.Annotations")]
        public void Approver_resharper_annotations(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.Decompiler")]
        public void Approver_resharper_decompiler(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.Platform", "JetBrains.ReSharper.Product.UI",
            AssemblyPrefixesToIgnore = new[] { "JetBrains.Platform.ReSharper.VisualStudio" })]
        public void Approver_resharper_platform(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.Platform.ReSharper.VisualStudio",
            "JetBrains.PsiFeatures.VisualStudio", "JetBrains.ReSharper.Product.VisualStudio")]
        public void Approver_resharper_visual_studio_integration(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.Daemon")]
        public void Approver_resharper_daemon(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.ExternalSources")]
        public void Approver_resharper_external_sources(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.Feature.Services")]
        public void Approver_resharper_feature_services(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.Features")]
        public void Approver_resharper_features(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.I18n")]
        public void Approver_resharper_i18n(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.Intentions")]
        public void Approver_resharper_intentions(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.LiveTemplates")]
        public void Approver_resharper_live_templates(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.Psi")]
        public void Approver_resharper_psi(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.Refactorings", 
            "JetBrains.ReSharper.InplaceRefactorings", "JetBrains.ReSharper.NewRefactorings")]
        public void Approver_resharper_refactorings(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.Resources")]
        public void Approver_resharper_resources(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.SolutionAnalysis")]
        public void Approver_resharper_solution_analysis(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.SolutionBuilder")]
        public void Approver_resharper_solution_builder(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }

        [TheoryWithLimitedFailures(10)]
        [GroupedAssemblies(AssemblyPath, "JetBrains.ReSharper.UnitTest",
            "JetBrains.ReSharper.Test", "JetBrains.ReSharper.TaskRunnerFramework")]
        public void Approver_resharper_unit_test(string assembly, string path)
        {
            ApprovePublicApi(path, assembly);
        }
    }
}