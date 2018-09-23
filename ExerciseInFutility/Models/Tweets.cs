    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseInFutility.Models
{
    public class Tweets
    {
        public string id { get; set; }
        public string stamp { get; set; }
        public string text { get; set; }
    }

    public class TweetView
    {
        public List<Tweets> TweetList { get; set; }
    }
}
