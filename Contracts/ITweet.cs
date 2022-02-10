using LearningWorkingWithTwitterAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi.Models;
using Tweetinvi.Models.V2;

namespace LearningWorkingWithTwitterAPI.Contracts
{
    public interface ITweet
    {
        Task<TweetDTO> GetTweetByIDAsync(long id);
    }
}
