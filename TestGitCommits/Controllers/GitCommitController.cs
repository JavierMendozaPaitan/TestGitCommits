using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestGitDomBase.Interfaces;


namespace TestGitCommits.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitCommitController : ControllerBase
    {
        public GitCommitController(IGitSrv gsrv, ILogger<GitCommitController> logger)
        {
            this.gsrv = gsrv;
            logg = logger;
        }

        private readonly ILogger<GitCommitController> logg;
        private readonly IGitSrv gsrv;

        [HttpGet("/Welcome")]
        public string Welcome()
        {
            return "Welcome GitCommit";
        }

        [HttpGet]
        public async Task<IActionResult> Get(string repo)
        {
            try
            {
                var hist = await gsrv.ShowHist(repo);

                return Ok(hist);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
