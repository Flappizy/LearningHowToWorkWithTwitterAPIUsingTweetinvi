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
    public class TweetSearchController : ControllerBase
    {
        private ITweetSearch _tweetSearch;

        public TweetSearchController(ITweetSearch tweetSearch)
        {
            _tweetSearch = tweetSearch;
        }

        [HttpGet]
        [Route("gettweets")]
        public async Task<IActionResult> GetTweetsBySearchTerm([FromBody]string searchTerm)
        {
            var tweets = await _tweetSearch.SearchTweetBySearchTermAsync(searchTerm);
            return Ok(tweets);
        }
    }
}
