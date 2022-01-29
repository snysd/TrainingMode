using System;
using System.Collections.Generic;
using System.Net;
using HtmlAgilityPack;

namespace TrainingMode
{
    public class HtmlAnalysis
    {
        public static void GetText()
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            string htmlStr = wc.DownloadString("https://www.amazon.co.jp/");
            if (htmlStr != null)
            {
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(htmlStr);
                HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes("//*[contains(text(), 'コロナ')]");
                // "//p/a[contains(text(), 'コロナ')]"
                // "//[contains(@class,'topics')]"
                // "//*[@id='newsrelease']/div/div/div/p"
                // "//*[contains(@class,'topics')]"
                foreach (HtmlNode node in nodes)
                {
                    Console.WriteLine(node.InnerText);
                }
            }
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
