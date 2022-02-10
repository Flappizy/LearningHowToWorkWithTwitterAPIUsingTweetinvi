using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningWorkingWithTwitterAPI.DTO
{
    public class TweetDTO
    {
        public string Tweet { get; set; }
        public long TweetId { get; set; }
        public string UserThatTweeted { get; set; }
    }
}
