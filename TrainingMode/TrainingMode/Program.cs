using System;
using System.Collections.Generic;
using System.Net;
using HtmlAgilityPack;

namespace TrainingMode
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlAnalysis.GetAllImages();
            HtmlAnalysis.GetText();
        }
    }

}
