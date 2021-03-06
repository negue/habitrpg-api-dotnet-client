﻿using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HabitRPG.Client.Extensions
{
   static class HttpContentExtension
   {
      public static async Task<T> ReadAsAsync<T>(this HttpContent content)
      {
         var contentJson = await content.ReadAsStringAsync();

         var deserializeObject = JsonConvert.DeserializeObject<T>(contentJson);

         return deserializeObject;
      }
   }
}
