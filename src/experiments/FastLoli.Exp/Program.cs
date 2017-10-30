using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastLoli.Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.Run();
        }

        class CommandDesc
        {
            public string Key { get; set; }
            public string Describe { get; set; }
            public CommandDesc(string key, string desc)
            {
                Key = key;
                Describe = desc;
            }
        }

        Dictionary<CommandDesc, Action> Commands;

        public Program()
        {
            Commands = new Dictionary<CommandDesc, Action>()
            {
                {
                    new CommandDesc("help", "Show helps"),
                    ()=>
                    {
                        foreach (var item in Commands)
                        {
                            Console.WriteLine($"{item.Key.Key.PadRight(12)} {item.Key.Describe}");
	                    }
                    }
                },
                {
                    new CommandDesc("mnist", "Run CNTK's mnist sample"),
                    () =>
                    {
                        
                    }
                }
            };
        }

        public void Run()
        {

        }
    }
}
