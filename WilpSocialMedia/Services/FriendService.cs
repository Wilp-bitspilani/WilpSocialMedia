using AutoMapper;
using WilpSocialMedia.Common;
using WilpSocialMedia.Common.API;
using WilpSocialMedia.Common.API.DTO;
using WilpSocialMedia.Common.API.Enum;
using WilpSocialMedia.Common.API.Interface;
using WilpSocialMedia.DTO;
using WilpSocialMedia.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Services
{
    public class FriendService : IFriendService
    {
        private readonly IUrlApiFactory _urlApiFactory;
        private readonly IMapper _mapper;
        public FriendService(IUrlApiFactory urlApiFactory, IMapper mapper)
        {
            _urlApiFactory = urlApiFactory;
            _mapper = mapper;
        }

        public ApiDto Approve(Guid idRequest)
        => new HTTPWebRequestUtilities<ApiDto>(_urlApiFactory.GetUrl(ServiceType.Activity))
                            .Request(Global.Method.GET, $"Friend/{idRequest}/Approve");

        public List<AccountUserDto> ListFriend(Guid idAccountUser)
        => new HTTPWebRequestUtilities<AccountUserDto>(_urlApiFactory.GetUrl(ServiceType.Activity))
                            .Get($"Friend/{idAccountUser}/relationship").ToList();

        public List<AccountUserDto> ListFriendRequest(Guid idAccountUser)
        => new HTTPWebRequestUtilities<AccountUserDto>(_urlApiFactory.GetUrl(ServiceType.Activity))
                            .Get($"Friend/{idAccountUser}/request").ToList();

        public List<ListFriendRequest> ListRequest()
        => new HTTPWebRequestUtilities<ListFriendRequest>(_urlApiFactory.GetUrl(ServiceType.Activity))
                            .Get($"Friend").ToList();

        public ApiDto Request(FriendRelationshipRequest request)
        => new HTTPWebRequestUtilities<ApiDto>(_urlApiFactory.GetUrl(ServiceType.Activity))
                            .Request(Global.Method.POST, $"Friend", request);
    }
}
