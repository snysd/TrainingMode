using System;
using System.Collections.Generic;
using System.Net;
using HtmlAgilityPack;

namespace TrainingMode
{
    public class HtmlAnalysis
    {
        public static string GetText(string url)
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            string htmlStr = wc.DownloadString($"{url}");
            if (htmlStr != null)
            {
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(htmlStr);
                HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes("//*[contains(@class,'')]");

                // "//p/a[contains(text(), 'コロナ')]"
                // "//[contains(@class,'topics')]"
                // "//*[@id='newsrelease']/div/div/div/p"
                // "//*[contains(@class,'topics')]"

                if (nodes == null) return "no item";
                htmlStr = "";
                foreach (HtmlNode node in nodes)
                {
                    htmlStr += node.InnerText;
                }
            }
            return htmlStr;
        }
        public static void GetAllImages()
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            string htmlStr = wc.DownloadString("https://www.amazon.co.jp/");
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(htmlStr);
            List<string> image_links = new List<string>();

            foreach (HtmlNode link in htmlDoc.DocumentNode.SelectNodes("//img"))
            {
                image_links.Add(link.GetAttributeValue("src", ""));
            }
            foreach (string image_link in image_links)
            {
                Console.WriteLine(image_link);
            }
        }
    }
}
