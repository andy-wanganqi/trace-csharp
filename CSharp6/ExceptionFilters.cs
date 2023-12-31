﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    public class ExceptionFilters
    {
        public static async Task<string> Play()
        {
            var client = new HttpClient();
            var streamTask = client.GetStringAsync("https://localhost:10000");
            try
            {
                var responseText = await streamTask;
                return responseText;
            }
            catch (HttpRequestException e) when (e.Message.Contains("301"))
            {
                return "Site Moved";
            }
            catch (HttpRequestException e) when (e.Message.Contains("404"))
            {
                return "Page Not Found";
            }
            catch (HttpRequestException e)
            {
                return e.Message;
            }
        }
    }
}
