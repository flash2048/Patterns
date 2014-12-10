﻿using Adapter.Adapters;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            var vkUser = new Vk.Vk("Василий Пупкин", 22, 987);
            var facebookUser = new Facebook.Facebook("Геннадий Петров", 28, 56);
            var twitterUser = new Twitter.Twitter("Елизавета Короткевич", 18, 99);

            UserProfile.PrintUserInfo(new VkAdapter(vkUser));
            UserProfile.PrintUserInfo(new FacebookAdapter(facebookUser));
            UserProfile.PrintUserInfo(new TwitterAdapter(twitterUser));
        }
    }
}
