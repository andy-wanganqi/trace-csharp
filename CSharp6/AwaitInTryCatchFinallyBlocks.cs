using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    public class AwaitInTryCatchFinallyBlocks
    {
        public static async Task Play()
        {
            WebClient wc = new WebClient();
            string result;
            try
            {
                result = await wc.DownloadStringTaskAsync(new Uri("http://badurl"));
            }
            catch
            {
                result = await wc.DownloadStringTaskAsync(new Uri("http://fallbackurl"));
            }
            finally
            {
                result = await wc.DownloadStringTaskAsync(new Uri("http://finallyurl"));
            }
        }
    }
}
