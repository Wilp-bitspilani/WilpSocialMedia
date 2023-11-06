using WilpSocialMedia.Common.API.DTO;
using WilpSocialMedia.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Services.Interface
{
    public interface IMessageService
    {
        ApiDto SendMessage(SendMessageRequest request);
        List<AccountUserDto> ListUserConversation(Guid idUser);
        List<ListMessagesResponse> ListMessage(Guid idConversation);
    }
}
