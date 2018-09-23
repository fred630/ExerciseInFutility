using ExerciseInFutility.Helpers;
using System;
using Xunit;

namespace ExerciseInFutility.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GetMoreStartDateLessTest()
        {
            string startDate = "01/01/2018";
            string endDate = "01/02/2018";

            Assert.True(GetAllTweets.GetMore(startDate, endDate, 100), "The GetMore test failed");
            Assert.False(GetAllTweets.GetMore(startDate, endDate, 99), "The GetMore test faile on count change.");
        }

        [Fact]
        public void GetMoreStartDateGreaterTest()
        {
            string startDate = "01/02/2018";
            string endDate = "01/01/2018";

            Assert.False(GetAllTweets.GetMore(startDate, endDate, 100), "The GetMore test failed");
            Assert.False(GetAllTweets.GetMore(startDate, endDate, 99), "The GetMore test faile on count change.");
        }
    }
}
