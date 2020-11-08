using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace TestGitDomBase.Models.GitCommit
{
    public class CommitDat
    {
        public string Sha { get; set; }
        [BsonElement("node_id")]
        public string NodeId { get; set; }
        public Commit Commit { get; set; }
        public string Url { get; set; }
        [BsonElement("html_url")]
        public string HtmlUrl { get; set; }
        [BsonElement("comments_url")]
        public string CommentsUrl { get; set; }
        public Usr Author { get; set; }
        public Usr Committer { get; set; }
    }
}
