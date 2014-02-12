using System.IO;
using ApiApprover;

namespace CitizenMatt.ReSharper.ApiTracker
{
    public abstract class ReSharperApiApprover
    {
        protected void ApprovePublicApi(string path, string assembly)
        {
            PublicApiApprover.ApprovePublicApi(Path.Combine(path, assembly), ResultsPath);
        }

        protected abstract string ResultsPath { get; }
    }
}