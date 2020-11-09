using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TestGitDomBase.Bases;
using TestGitDomBase.Interfaces;
using TestGitDomBase.Models.GitCommit;
using WAppDom.Actions;

namespace TestGitDom.Services
{
    public class GitSrv : GitSrvBase
    {
        public GitSrv(IHttpClientFactory clifact, IGitParm parm)
        {
            try
            {
                htt = new HttpRqActions(clifact);
                htt.HClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("TestGitCommit","1"));
                this.parm = parm;
                ShowHist = ShowHistCommit;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private HttpRqActions htt;
        private IGitParm parm;

        public override Func<string, Task<List<CommitDat>>> ShowHist { get; }

        private async Task<List<CommitDat>> ShowHistCommit(string repo)
        {
            try
            {
                var url = $@"{parm.Conn.Url}/{parm.Conn.Owner}/{repo}/commits";
                //var lst = await htt.ContentAsType<RepoCommit>(url);
                var lst = await htt.ContentAsType<List<CommitDat>>(url);

                return lst;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
