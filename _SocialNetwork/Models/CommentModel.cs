using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace _SocialNetwork;

public class CommentModel : ICommentable
{
    public Guid parent_id { get; set; }
    public Guid user_id { get; set; }
    public int depth { get; set; }
    public string text { get; set; }
    public DateTime comment_time { get; set; }
    public List<Guid> liked_by { get; set; }
    [BsonId] public Guid id { get; set; }
}