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
    public class MessageService : IMessageService
    {
        private readonly IUrlApiFactory _urlApiFactory;
        private readonly IMapper _mapper;
        public MessageService(IUrlApiFactory urlApiFactory, IMapper mapper)
        {
            _urlApiFactory = urlApiFactory;
            _mapper = mapper;
        }
        public List<ListMessagesResponse> ListMessage(Guid idConversation)
        => new HTTPWebRequestUtilities<ListMessagesResponse>(_urlApiFactory.GetUrl(ServiceType.Message))
                .Get($"Message/{idConversation}/ReadMessages").ToList();

        public List<AccountUserDto> ListUserConversation(Guid idUser)
        => new HTTPWebRequestUtilities<AccountUserDto>(_urlApiFactory.GetUrl(ServiceType.Message))
                .Get($"Message/{idUser}/ReadConversation").ToList();

        public ApiDto SendMessage(SendMessageRequest request)
        => new HTTPWebRequestUtilities<ApiDto>(_urlApiFactory.GetUrl(ServiceType.Message))
            .Request(Global.Method.POST, $"Message/SendMessage", request);
    }
}
