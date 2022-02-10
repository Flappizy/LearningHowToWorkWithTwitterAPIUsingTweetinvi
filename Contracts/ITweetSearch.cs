using LearningWorkingWithTwitterAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningWorkingWithTwitterAPI.Contracts
{
    public interface ITweetSearch
    {
        Task<List<TweetSearchDTO>> SearchTweetBySearchTermAsync(string searchTerm);
    }
}
