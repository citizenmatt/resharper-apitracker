using System;
using System.Collections.Generic;
using System.Linq;
using Xunit.Extensions;
using Xunit.Sdk;

namespace CitizenMatt.ReSharper.ApiTracker
{
    /// <summary>
    /// Works like xunit's <see cref="TheoryAttribute"/>, but will stop after more than
    /// a configurable number of test failures
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TheoryWithLimitedFailuresAttribute : TheoryAttribute
    {
        private readonly int maxFailureCount;
        private int failureCount;

        public TheoryWithLimitedFailuresAttribute(int maxFailureCount)
        {
            this.maxFailureCount = maxFailureCount;
        }

        protected override IEnumerable<ITestCommand> EnumerateTestCommands(IMethodInfo method)
        {
            return base.EnumerateTestCommands(method).Select(c => new CancellingCommand(c, this)).TakeWhile(_ => failureCount < maxFailureCount);
        }

        private void OnFailure()
        {
            failureCount++;
        }

        private class CancellingCommand : DelegatingTestCommand
        {
            private readonly TheoryWithLimitedFailuresAttribute owner;

            public CancellingCommand(ITestCommand innerCommand, TheoryWithLimitedFailuresAttribute owner)
                : base(innerCommand)
            {
                this.owner = owner;
            }

            public override MethodResult Execute(object testClass)
            {
                try
                {
                    return InnerCommand.Execute(testClass);
                }
                catch
                {
                    owner.OnFailure();
                    throw;
                }
            }
        }
    }
}