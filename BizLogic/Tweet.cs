using LearningWorkingWithTwitterAPI.Contracts;
using LearningWorkingWithTwitterAPI.DTO;
using LearningWorkingWithTwitterAPI.Model;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi;

namespace LearningWorkingWithTwitterAPI.BizLogic
{
    public class Tweet : Contracts.ITweet
    {
        private TwitterSettings _twitterSettings;

        public Tweet(IOptions<TwitterSettings> twitterSettings)
        {
            _twitterSettings = twitterSettings.Value;
        }

        //This method is used to get the authenticated account that has access to the Twitter API
        public async Task<TweetDTO> GetTweetByIDAsync(long id)
        {
            var userClient = new TwitterClient(_twitterSettings.ConsumerKey, _twitterSettings.ConsumerSecret, 
                _twitterSettings.AccessToken, _twitterSettings.AccessTokenSecret);

            var tweet = await userClient.TweetsV2.GetTweetAsync(id);

            TweetDTO tweetDTO = new TweetDTO
            {
                Tweet = tweet.Tweet.Text,
                TweetId = long.Parse(tweet.Tweet.Id),
                UserThatTweeted = tweet.Includes.Users[0].Name
            };

            return tweetDTO;
        }
    }
}
