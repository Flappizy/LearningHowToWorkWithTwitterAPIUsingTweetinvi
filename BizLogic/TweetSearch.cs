using LearningWorkingWithTwitterAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi;
using LearningWorkingWithTwitterAPI.DTO;
using LearningWorkingWithTwitterAPI.Model;
using Microsoft.Extensions.Options;

namespace LearningWorkingWithTwitterAPI.BizLogic
{
    public class TweetSearch : ITweetSearch
    {
        private TwitterSettings _twitterSettings;

        public TweetSearch(IOptions<TwitterSettings> twitterSettings)
        {
            _twitterSettings = twitterSettings.Value;
        }

        //This method is used to get the authenticated account that has access to the Twitter API
        public async Task<List<TweetSearchDTO>> SearchTweetBySearchTermAsync(string searchTerm)
        {
            var userClient = new TwitterClient(_twitterSettings.ConsumerKey, _twitterSettings.ConsumerSecret,
                _twitterSettings.AccessToken, _twitterSettings.AccessTokenSecret);

            var searchResponse = await userClient.SearchV2.SearchTweetsAsync(searchTerm);
            var tweets = searchResponse.Tweets;
            List<TweetSearchDTO> tweetsDTO = new List<TweetSearchDTO>();

            foreach (var tweet in tweets)
            {
                if (tweet.Text.StartsWith("RT"))
                {
                    continue;
                }

                tweetsDTO.Add( new TweetSearchDTO { Tweet = tweet.Text, TweetId = tweet.Id });
            }

            return tweetsDTO;
        }
    }
}
