using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    internal class LinkaMetra
    {
        public string name { get; set; }
        public bool active { get; set; }
        public string[] stations { get; set; }
        public string color_metro { get; set; }
        public void all_stations()
        {
            var table = new Table();
            table.AddColumn($"Stanice linky {name}").Centered();
            foreach (var item in stations)
            {
                table.AddRow(item);
            }
            AnsiConsole.Write(table);
        }
        public void first_last_station ()
        {
            var table = new Table();
            table.AddColumn("první").Centered();
            table.AddColumn("poslední").Centered();
            table.AddRow(stations[0], stations[stations.Length - 1]);
            AnsiConsole.Write(table);
        }
        public void station_settings ()
        {
            if (color_metro == "zelená")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else if (color_metro == "červená")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            else if (color_metro == "žlutá")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else if (color_metro == "modrá")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.WriteLine($"linka { name }");
        }
        public void time ()
        {
            //WIP

            //all_stations();
            //var station_menu = AnsiConsole.Prompt(
            //new MultiSelectionPrompt<string>()
            //.Title("Vyber si stanici")
            //.NotRequired()
            //.PageSize(10)
            //.MoreChoicesText("Pro více možností použí šipky (nahoru/dolu)")
            //.InstructionsText(
            //"[grey](Press [blue]<space>[/] to toggle a fruit, " +
            //"[green]<enter>[/] to accept)[/]")
            //.AddChoices(new[] { "" }));
            //foreach (string station in station_menu)
            //{
            //    AnsiConsole.WriteLine(station);
            //}
            all_stations();
            Console.WriteLine("stanice 1");
            string prvi = Console.ReadLine();
            int indexprvi = Array.IndexOf(stations, prvi);
            Console.WriteLine("stanice 2");
            string druhy = Console.ReadLine();
            int indexdruhy = Array.IndexOf(stations, druhy);
            Console.WriteLine($"{(indexdruhy-indexprvi)*2} minut");
        }
    }
}
