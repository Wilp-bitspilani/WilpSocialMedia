using WilpSocialMedia.Common.API.DTO;
using WilpSocialMedia.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Services.Interface
{
    public interface IFriendService
    {
        ApiDto Approve(Guid idRequest);
        ApiDto Request(FriendRelationshipRequest request);
        List<AccountUserDto> ListFriendRequest(Guid idAccountUser);
        List<ListFriendRequest> ListRequest();
        List<AccountUserDto> ListFriend(Guid idAccountUser);

    }
}
