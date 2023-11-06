using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.DTO
{
    public class FriendRelationshipRequest
    {
        [Required]
        public Guid UserSender { get; set; }
        [Required]
        public Guid UserReciever { get; set; }
    }
}
