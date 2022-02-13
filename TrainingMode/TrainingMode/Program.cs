using System;
using System.Collections.Generic;
using System.Net;
using HtmlAgilityPack;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMode
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = HtmlAnalysis.GetText(Console.ReadLine());
            TextFileCreate.Create(str);
        }
    }

}
