using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TestGitDomBase.Config.Git;
using TestGitDomBase.Interfaces;
using WppDom.Services;

namespace TestGitDom.Items
{
    public class GitParm : IGitParm
    {
        public GitParm(IConfiguration cfg)
        {
            try
            {
                cfgsrv = new CfgSrv(cfg);
                Conn = cfgsrv.CfgOpt<GitConn>();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private CfgSrv cfgsrv;

        public GitConn Conn { get; }

    }
}
