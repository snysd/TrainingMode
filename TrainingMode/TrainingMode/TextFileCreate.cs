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
    class TextFileCreate
    {
        public static void Create(string text)
        {
            // 現在のVisual Studio Projectのトップディレクトリを取得
            // binフォルダの下にファイルを出力する
            var pathNamePJ = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            Console.WriteLine(pathNamePJ);

            // ファイル名に現在時刻を設定
            var datetime = DateTime.Now;
            var dtstr = datetime.ToString("yyyyMMddHHmmss");

            //出力ファイルの絶対パスを作成
            var pathFNameOut1 = Path.Combine(pathNamePJ, $"test1_{dtstr}.txt");
            var pathFNameOut2 = Path.Combine(pathNamePJ, $"test2_{dtstr}.txt");

            // 出力文字列配列を作成
            var lines = text.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            // .NET Coreや.NET 5 のデフォのエンコードリストにSJISがないため、
            // エンコードプロバイダを登録する
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var sjis = Encoding.GetEncoding("shift_jis");

            // ファイルに出力
            File.WriteAllText(pathFNameOut1, text, Encoding.GetEncoding("UTF-8")); // 文字列
            File.WriteAllLines(pathFNameOut2, lines, sjis); // 文字列の配列やリストなど
        }
    }
}
