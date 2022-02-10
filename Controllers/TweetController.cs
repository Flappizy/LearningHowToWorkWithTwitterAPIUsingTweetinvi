using LearningWorkingWithTwitterAPI.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningWorkingWithTwitterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetController : ControllerBase
    {
        private ITweet _twitterUserName;

        public TweetController(ITweet twitterUserName)
        {
            _twitterUserName = twitterUserName;
        }

        //This allows you to get the Twitter User 
        [HttpGet]
        [Route("gettweet")]
        public async Task<IActionResult> GetTwitterUser([FromBody]long id)
        {
            var tweet = await _twitterUserName.GetTweetByIDAsync(id);
            return Ok(tweet);
        }
    }
}
