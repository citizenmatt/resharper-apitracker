﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ApiApprover;
using ApprovalTests.Reporters;
using Xunit.Extensions;

namespace CitizenMatt.ReSharper.ApiTracker
{
    public class ReSharperApiApprover
    {
        private const string ReSharperPath80 = @"C:\work\sdk\v8.0\bin";
        private const string ReSharperPath81 = @"C:\work\sdk\JetBrains.ReSharper.SDK.8.1.555\bin";

        [TheoryWithLimitedFailures(10)]
        [PropertyData("ReSharper80AssemblyPaths")]
        [UseReporter(typeof(DiffReporter))]
        public void Approve_resharper_80(string assembly, string path)
        {
            PublicApiApprover.ApprovePublicApi(Path.Combine(path, assembly), @"..\..\results\rs80");
        }

        [TheoryWithLimitedFailures(10)]
        [PropertyData("ReSharper81AssemblyPaths")]
        [UseReporter(typeof(DiffReporter))]
        public void Approve_resharper_81(string assembly, string path)
        {
            PublicApiApprover.ApprovePublicApi(Path.Combine(path, assembly), @"..\..\results\rs81");
        }

        private static readonly ISet<string> IgnoredAssemblies = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            // Consumed by ReSharper, not exposed
            "JetBrains.dotTrace.ProfilingApi.dll",

            // Test assemblies
            "JetBrains.ReSharper.Feature.Services.Tests.Common.dll",
            "JetBrains.ReSharper.Feature.Services.Tests.Basic.dll",
            "JetBrains.ReSharper.PsiTestsBasic.dll",
            "JetBrains.ReSharper.TestResources.dll",
        };

        public static IEnumerable<object[]> ReSharper80AssemblyPaths
        {
            get
            {
                return GetReSharperAssemblies(ReSharperPath80);
                //yield return new object[] { "JetBrains.ReSharper.Features.Architecture.yFiles.dll", ReSharperPath80 };
            }
        }

        public static IEnumerable<object[]> ReSharper81AssemblyPaths
        {
            get
            {
                return GetReSharperAssemblies(ReSharperPath81);
                //yield return new object[] { "JetBrains.ReSharper.Features.Architecture.yFiles.dll", ReSharperPath80 };
            }
        }

        private static IEnumerable<object[]> GetReSharperAssemblies(string assemblyPath)
        {
            // Note that assembly name and path are split purely to get nicer reporting in
            // the test runner - the name comes first which makes it easier to read
            return Directory.EnumerateFiles(assemblyPath, "*.dll").OrderBy(p => p)
                .Select(Path.GetFileName)
                .Where(ShouldInclude)
                .Select(f => new object[] { f, assemblyPath });
        }

        private static bool ShouldInclude(string assembly)
        {
            return assembly.StartsWith("JetBrains", StringComparison.OrdinalIgnoreCase) &&
                   !IgnoredAssemblies.Contains(assembly) &&
                   !assembly.EndsWith("Tests.dll", StringComparison.OrdinalIgnoreCase) &&
                   !assembly.StartsWith("JetBrains.ReSharper.Refactorings.Test.", StringComparison.OrdinalIgnoreCase) &&
                   !assembly.EndsWith("Tests.Basic.dll", StringComparison.OrdinalIgnoreCase);
        }
    }
}