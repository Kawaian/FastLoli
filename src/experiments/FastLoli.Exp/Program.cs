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
        bool programOn = true;

        public Program()
        {
            Commands = new Dictionary<CommandDesc, Action>()
            {
                {
                    new CommandDesc("help", "Show helps"),
                    ()=>
                    {
                        Console.WriteLine("FastLoli's Playground \n");
                        foreach (var item in Commands)
                        {
                            Console.WriteLine($"{item.Key.Key.PadRight(12)} {item.Key.Describe}");
	                    }
                    }
                },
                {
                    new CommandDesc("exit", "Exit program"),
                    () =>
                    {
                        programOn = false;
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
            while (programOn)
            {
                Console.Write(">>> ");
                var read = Console.ReadLine();
                read = read.ToLower().Trim();
                foreach (var item in Commands)
                {
                    if(item.Key.Key == read)
                    {
                        item.Value.Invoke();
                    }
                }
            }
        }
    }
}
