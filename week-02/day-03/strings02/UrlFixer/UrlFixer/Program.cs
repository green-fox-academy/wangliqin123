using System;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            
            url = (url.Replace("bots" , "odds"));
            Console.WriteLine(url.Insert(5, ":"));

            Console.ReadLine();
        }
    }
}
