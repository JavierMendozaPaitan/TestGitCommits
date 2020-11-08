using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace TestGitDomBase.Models.GitCommit
{
    public class Commit
    {
        public CmmUsr Author { get; set; }
        public CmmUsr Committer { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }
        [BsonElement("comment_count")]
        public int CommentCount { get; set; }
    }
}
