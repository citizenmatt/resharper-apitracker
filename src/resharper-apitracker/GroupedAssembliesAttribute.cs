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
        private readonly string[] assemblyPrefix;
        private readonly string assemblyPath;

        public GroupedAssembliesAttribute(string assemblyPath, params string[] assemblyPrefix)
        {
            this.assemblyPrefix = assemblyPrefix;
            this.assemblyPath = assemblyPath;
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

            // Test assemblies
            "JetBrains.ReSharper.Feature.Services.Tests.Common.dll",
            "JetBrains.ReSharper.Feature.Services.Tests.Basic.dll",
            "JetBrains.ReSharper.PsiTestsBasic.dll",
            "JetBrains.ReSharper.TestResources.dll",
        };

        private bool ShouldInclude(string assembly)
        {
            return assemblyPrefix.Any(p => assembly.StartsWith(p, StringComparison.OrdinalIgnoreCase)) &&
                   !IgnoredAssemblies.Contains(assembly) &&
                   !assembly.EndsWith("Tests.dll", StringComparison.OrdinalIgnoreCase) &&
                   !assembly.StartsWith("JetBrains.ReSharper.Refactorings.Test.", StringComparison.OrdinalIgnoreCase) &&
                   !assembly.EndsWith("Tests.Basic.dll", StringComparison.OrdinalIgnoreCase);
        }
    }
}