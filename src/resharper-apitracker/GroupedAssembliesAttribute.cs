using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit.Extensions;

namespace CitizenMatt.ReSharper.ApiTracker
{
    public class GroupedAssembliesAttribute : DataAttribute
    {
        private readonly string[] assemblyPrefixes;
        private readonly string assemblyPath;

        public GroupedAssembliesAttribute(string assemblyPath, params string[] assemblyPrefixes)
        {
            this.assemblyPrefixes = assemblyPrefixes;
            this.assemblyPath = assemblyPath;
        }

        public string[] AssemblyPrefixesToIgnore { get; set; }

        private IEnumerable<string> SafeAssemblyPrefixesToIgnore
        {
            get { return AssemblyPrefixesToIgnore ?? new string[0]; }
        } 

        public override IEnumerable<object[]> GetData(MethodInfo methodUnderTest, Type[] parameterTypes)
        {
            // Note that assembly name and path are split purely to get nicer reporting in
            // the test runner - the name comes first which makes it easier to read
            return Directory.EnumerateFiles(assemblyPath, "*.dll").OrderBy(p => p)
                .Select(Path.GetFileName)
                .Where(ShouldInclude)
                .Select(f => new object[] { f, assemblyPath });
        }

        private static readonly ISet<string> IgnoredAssemblies = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            // Consumed by ReSharper, not exposed
            "JetBrains.dotTrace.ProfilingApi.dll",
            "JetBrains.Profiler.Core.Api.dll",

            // Not a public API
            "JetBrains.ReSharper.ExternalProcessStorage.dll",

            // Don't care if any APIs change in nunit, mstest or js test runners
            "JetBrains.ReSharper.UnitTestProvider.JavaScript.dll",
            "JetBrains.ReSharper.UnitTestProvider.MSTest.dll",
            "JetBrains.ReSharper.UnitTestProvider.MSTest09.dll",
            "JetBrains.ReSharper.UnitTestProvider.MSTest10.dll",
            "JetBrains.ReSharper.UnitTestProvider.MSTest11.dll",
            "JetBrains.ReSharper.UnitTestProvider.MSTest12.dll",
            "JetBrains.ReSharper.UnitTestProvider.nUnit.dll",
            "JetBrains.ReSharper.UnitTestRunner.JavaScript.dll",
            "JetBrains.ReSharper.UnitTestRunner.MSTest09.dll",
            "JetBrains.ReSharper.UnitTestRunner.MSTest10.dll",
            "JetBrains.ReSharper.UnitTestRunner.MSTest11.dll",
            "JetBrains.ReSharper.UnitTestRunner.MSTest12.dll",
            "JetBrains.ReSharper.UnitTestRunner.nUnit.dll",

            // Test assemblies
            "JetBrains.ReSharper.Feature.Services.Tests.Common.dll",
            "JetBrains.ReSharper.Feature.Services.Tests.Basic.dll",
            "JetBrains.ReSharper.PsiTestsBasic.dll",
            "JetBrains.ReSharper.TestResources.dll",
        };

        private bool ShouldInclude(string assembly)
        {
            return !SafeAssemblyPrefixesToIgnore.Any(prefix => assembly.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)) &&
                    assemblyPrefixes.Any(prefix => assembly.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)) &&
                   !IgnoredAssemblies.Contains(assembly) &&
                   !assembly.EndsWith("Tests.dll", StringComparison.OrdinalIgnoreCase) &&
                   !assembly.StartsWith("JetBrains.ReSharper.Refactorings.Test.", StringComparison.OrdinalIgnoreCase) &&
                   !assembly.EndsWith("Tests.Basic.dll", StringComparison.OrdinalIgnoreCase);
        }
    }
}