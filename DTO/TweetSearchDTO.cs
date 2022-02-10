using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningWorkingWithTwitterAPI.DTO
{
    public class TweetSearchDTO
    {
        public string TweetId { get; set; }
        public string Tweet { get; set; }
        public string UserThatTweeted { get; set; }
    }
}
