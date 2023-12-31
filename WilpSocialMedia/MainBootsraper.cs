﻿using WilpSocialMedia.Services;
using WilpSocialMedia.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia
{
    public static class MainBootsraper
    {
        public static void InitAppBootsraper(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IFriendService, FriendService>();
            services.AddTransient<IMessageService, MessageService>();
        }
    }
}
