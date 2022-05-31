﻿using RedditTextToSpeech.Logic.Services;
using System;
using System.Threading.Tasks;

namespace RedditTextToSpeech.Logic.Factories
{
    public class ImageFactory : IImageFactory
    {
        private IImageService imageService;

        public ImageFactory(IImageService imageService)
        {
            this.imageService = imageService;
        }

        public async Task<string> GetImage(string title, string username, string subreddit, string avatar)
        {
            var path = Guid.NewGuid().ToString();
            var file = await this.imageService.GetImage(path, title, username, subreddit, avatar);
            return file;
        }

        public async Task<string> GetImage(string title, string username, string subreddit)
        {
            var path = Guid.NewGuid().ToString();
            var file = await this.imageService.GetImage(path, title, username, subreddit);
            return file;
        }

        public async Task<string> GetImage(string text)
        {
            var path = Guid.NewGuid().ToString();
            var file = await this.imageService.GetImage(path, text);
            return file;
        }
    }
}