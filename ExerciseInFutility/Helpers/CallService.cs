using ExerciseInFutility.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExerciseInFutility.Helpers
{
    public class CallService
    {
        public static async Task<string> GetTweets(DateTime startDate, DateTime endDate)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.BaseAddress = new Uri("https://badapi.iqvia.io/swagger");
                    var callResponse = await httpClient.GetAsync($"/api/v1/tweets/?startDate=" + startDate.ToString("MM/dd/yyyy HH:mm:ss.fff") + $"&endDate=" + endDate.ToString("MM/dd/yyyy HH:mm:ss.fff"));
                    callResponse.EnsureSuccessStatusCode();

                    return await callResponse.Content.ReadAsStringAsync();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
