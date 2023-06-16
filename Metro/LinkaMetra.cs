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
        menu mainmenu = new menu();
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
        public void first_last_station()
        {
            var table = new Table();
            table.AddColumn("první").Centered();
            table.AddColumn("poslední").Centered();
            table.AddRow(stations[0], stations[stations.Length - 1]);
            AnsiConsole.Write(table);
        }
        public void station_settings()
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
            Console.WriteLine($"linka {name}");
        }
        public void timeA()
        {
            var hs = new Style(Color.Aqua);
            var menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .PageSize(10)
                .HighlightStyle(hs)
                .Title("Vyber stanici 1")
                .AddChoices(new[] { "Depo Hostivař", "Skalka", "Strašnická", "Želivského", "Flora", "Jiřího z Poděbrad",
            "Náměstí Míru", "Muzeum", "Můstek", "Staroměstská", "Malostranská", "Hradčanská", "Dejvická",
            "Bořislavka", "Nádraží Veleslavín", "Petřiny", "Nemocnice Motol" }));
            int st = Array.IndexOf(stations, menu);
            menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .PageSize(10)
                .HighlightStyle(hs)
                .Title("Vyber stanici 2")
                .AddChoices(new[] { "Depo Hostivař", "Skalka", "Strašnická", "Želivského", "Flora", "Jiřího z Poděbrad",
            "Náměstí Míru", "Muzeum", "Můstek", "Staroměstská", "Malostranská", "Hradčanská", "Dejvická",
            "Bořislavka", "Nádraží Veleslavín", "Petřiny", "Nemocnice Motol" }));
            int nd = Array.IndexOf(stations, menu);
            Console.WriteLine($"{(nd - st) * 2} minut/a/y");
        }
        public void timeB()
        {
            var hs = new Style(Color.Aqua);
            var menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .PageSize(10)
                .HighlightStyle(hs)
                .Title("Vyber stanici 1")
                .AddChoices(new[] { "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jinonice",
            "Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí", "Národní třída", "Můstek",
            "Náměstí republiky", "Florenc", "Křižíkova", "Invalidovna", "Palmovka", "Českomoravská",
            "Vysočanská", "Kolbenova", "Hloubětín", "Rajská zahrada", "Černý most" }));
            int st = Array.IndexOf(stations, menu);
            menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .PageSize(10)
                .HighlightStyle(hs)
                .Title("Vyber stanici 2")
                .AddChoices(new[] { "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jinonice",
            "Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí", "Národní třída", "Můstek",
            "Náměstí republiky", "Florenc", "Křižíkova", "Invalidovna", "Palmovka", "Českomoravská",
            "Vysočanská", "Kolbenova", "Hloubětín", "Rajská zahrada", "Černý most" }));
            int nd = Array.IndexOf(stations, menu);
            Console.WriteLine($"{(nd - st) * 2} minut/a/y");
        }
        public void timeC()
        {
            var hs = new Style(Color.Aqua);
            var menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .PageSize(10)
                .HighlightStyle(hs)
                .Title("Vyber stanici 1")
                .AddChoices(new[] { "Letňany", "Prosek", "Střížkov", "Ládví", "Kobylisy", "Nádraží Holešovice",
            "Vltavská", "Florenc", "Hlavní nádraží", "Muzeum","I. P. Pavlova", "Vyšehrad", "Pražského povstání",
            "Pankrác", "Budějovická", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje" }));
            int st = Array.IndexOf(stations, menu);
            menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .PageSize(10)
                .HighlightStyle(hs)
                .Title("Vyber stanici 2")
                .AddChoices(new[] { "Letňany", "Prosek", "Střížkov", "Ládví", "Kobylisy", "Nádraží Holešovice",
            "Vltavská", "Florenc", "Hlavní nádraží", "Muzeum","I. P. Pavlova", "Vyšehrad", "Pražského povstání",
            "Pankrác", "Budějovická", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje" }));
            int nd = Array.IndexOf(stations, menu);
            Console.WriteLine($"{(nd - st) * 2} minut/a/y");
        }
        public void timeD()
        {
            var hs = new Style(Color.Aqua);
            var menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .PageSize(10)
                .HighlightStyle(hs)
                .Title("Vyber stanici 1")
                .AddChoices(new[] { "Depo Písnice", "Písnice", "Libuš", "Nové Dvory", "Nemocnice Krč", "Nádraží Krč",
            "Olbrachtova", "Pankrác", "Náměstí Bratří Synků", "Náměstí Míru" }));
            int st = Array.IndexOf(stations, menu);
            menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .PageSize(10)
                .HighlightStyle(hs)
                .Title("Vyber stanici 2")
                .AddChoices(new[] { "Depo Písnice", "Písnice", "Libuš", "Nové Dvory", "Nemocnice Krč", "Nádraží Krč",
            "Olbrachtova", "Pankrác", "Náměstí Bratří Synků", "Náměstí Míru" }));
            int nd = Array.IndexOf(stations, menu);
            Console.WriteLine($"{(nd - st) * 2} minut/a/y");
        }

        string[] Dy = { "Depo Písnice", "Písnice", "Libuš", "Nové Dvory", "Nemocnice Krč", "Nádraží Krč",
            "Olbrachtova", "Pankrác", "Náměstí Bratří Synků", "Náměstí Míru" };
    }
}
