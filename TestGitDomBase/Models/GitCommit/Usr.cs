using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace TestGitDomBase.Models.GitCommit
{
    public class Usr
    {
        public string Login { get; set; }
        public string Id { get; set; }
        [BsonElement("node_id")]
        public string NodeId { get; set; }
        [BsonElement("avatar_url")]
        public string AvatarUrl { get; set; }
    }
}
