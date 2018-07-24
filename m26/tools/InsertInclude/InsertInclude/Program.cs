using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

/*
    ソースのinclude指定を展開する

        引数１ インクルード検索ディレクトリ 引数２　検索開始フォルダ  

        検索開始フォルダ以下の *.csファイルの以下の指定部分をインクルードファイル挿入、または上書きする。

        //<<<include=ファイル名
         :
        //>>>

*/

namespace InsertInclude
{
    class Program
    {
        static readonly string MARK_BEGIN="//<<<include=";
        static readonly string MARK_END  ="//>>>";

        static string m_include_search_path  = string.Empty;
        static string m_source_traverse_path = string.Empty;
        static void Main(string[] args)
        {
            //Debugger.Break();

            if (args.Length < 2)
            {
                Console.WriteLine("引数１ インクルード検索ディレクトリ 引数２　検索開始フォルダx ");
                Environment.Exit(-1);
            }

            m_include_search_path = Path.GetFullPath(args[0]);
            m_source_traverse_path= Path.GetFullPath(args[1]);

            Action<DirectoryInfo> trv = null;
            trv = (d)=> {
                foreach(var fi in d.GetFiles("*.cs"))
                {
                    if (fi.Attributes.HasFlag(FileAttributes.Hidden)) continue;
                    CheckAndInsert(fi.FullName);
                }
                foreach(var di in d.GetDirectories())
                {
                    if (di.Attributes.HasFlag(FileAttributes.Hidden)) continue;
                    trv(di);
                }
            };

            Console.WriteLine("Start...");

            trv(new DirectoryInfo(m_source_traverse_path));

            Console.WriteLine("... done.");
        }
        static void CheckAndInsert(string file)
        {
            int bi = -1;
            int ei = -1;
            var list = File.ReadAllLines(file,Encoding.UTF8);
            for(var i = 0; i<list.Length; i++)
            {
                var t_bi = list[i].IndexOf(MARK_BEGIN);
                if (t_bi>=0)
                {
                    bi = i;
                    continue;
                }
                
                var t_ei = list[i].IndexOf(MARK_END);
                if (t_ei>=0)
                {
                    ei = i;

                    if (bi >= 0 && ei >= 0) break;
                }
            }
            if (bi==-1 || ei==-1) return;

            var include_file = list[bi].Substring(MARK_BEGIN.Length).Trim();
            var include_text = File.ReadAllLines(Path.Combine(m_include_search_path, include_file),Encoding.UTF8);  
            if (include_text==null || include_text.Length==0)
            {
                Console.WriteLine("Include File Not Found :" + include_file );
                Console.WriteLine("..aborted");
                Environment.Exit(-1);
            }

            var nlist = new List<string>();

            bool? bIncludeRange = null; // null -> true -> false
            for(var i = 0; i<list.Length; i++)
            {
                if (bIncludeRange==null)
                {
                    nlist.Add(list[i]);
                    if (i == bi)
                    {
                        foreach(var t in include_text)
                        {
                            nlist.Add(t);
                        }
                        bIncludeRange = true;
                    }
                }
                else if (bIncludeRange==true)
                {
                    if (i==ei)
                    {
                        nlist.Add(list[ei]);
                        bIncludeRange = false;
                    }
                }
                else
                {
                    nlist.Add(list[i]);
                }
            }

            //出力組み上げ
            string o = string.Empty;
            foreach(var l in nlist)
            {
                var l2 = l.TrimEnd();
                if (string.IsNullOrEmpty(l2))
                {
                    o+="\n";
                }
                else
                {
                    o += l2 + "\n";
                }
            }

            File.WriteAllText(file,o,Encoding.UTF8);

            Console.WriteLine("Write .." + Path.GetFileName(file));
        }
    }
}
