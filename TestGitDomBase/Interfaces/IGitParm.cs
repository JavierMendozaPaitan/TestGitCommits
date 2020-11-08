using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitDomBase.Config.Git;

namespace TestGitDomBase.Interfaces
{
    public interface IGitParm
    {
        GitConn Conn { get; }
    }
}