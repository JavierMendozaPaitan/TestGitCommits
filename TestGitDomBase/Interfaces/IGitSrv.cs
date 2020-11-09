using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitDomBase.Models.GitCommit;

namespace TestGitDomBase.Interfaces
{
    public interface IGitSrv
    {
        Func<string, Task<List<CommitDat>>> ShowHist { get; }
    }
}
