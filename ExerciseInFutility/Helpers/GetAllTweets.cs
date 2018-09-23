using ExerciseInFutility.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseInFutility.Helpers
{
    public static class GetAllTweets
    {
        public static bool GetMore(string lastDate, string endDate, int listCount)
        {
            DateTime last = DateTime.Parse(lastDate);
            DateTime end = DateTime.Parse(endDate);

            return last <= end && listCount == 100;
        }

        public static List<Tweets> GetTweets(string startDate, string endDate)
        {
            List<Tweets> tweets = new List<Tweets>();
            bool getMoreTweets = true;
            DateTime startD = DateTime.Parse(startDate);
            DateTime endD = DateTime.Parse(endDate);
            while (getMoreTweets)
            {
                var getTweetStorm = CallService.GetTweets(startD, endD);
                var converted = JsonConvert.DeserializeObject<List<Tweets>>(getTweetStorm.Result);
                tweets.AddRange(converted);
                getMoreTweets = GetMore(converted.Last().stamp, endDate, converted.Count);
                startD = DateTime.Parse(converted.Last().stamp);
            }

            return tweets;
        }
    }
}
