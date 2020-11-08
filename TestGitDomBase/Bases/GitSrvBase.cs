using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestGitDomBase.Interfaces;
using TestGitDomBase.Models.GitCommit;

namespace TestGitDomBase.Bases
{
    public abstract class GitSrvBase : IGitSrv
    {
        public abstract Func<string, Task<RepoCommit>> ShowHist { get; }
    }
}
