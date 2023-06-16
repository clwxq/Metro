using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    internal class menu
    {
        public string[] a { get; set; }
        public string[] b { get; set; }
        public string[] c { get; set; }
        public string[] d { get; set; }

        public void main_menu()
        {
            //WIP
            while (true) 
            {
                var hs = new Style(Color.Aqua);
                var menu = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .PageSize(10)
                    .HighlightStyle(hs)
                    .Title("Zadej linku")
                    .AddChoices(new[] { "A", "B", "C", "D", "Ukončit" }));
                if (menu == "A")
                {
                    Ax();
                }
                else if (menu == "B")
                {
                    Bx();
                }
                else if (menu == "C")
                {
                    Cx();
                }
                else if (menu == "D")
                {
                    Dx();
                }
                else if (menu == "Ukončit")
                {
                    end_program();
                }
            }
        }
        void Ax ()
        {
            LinkaMetra linkaA = new LinkaMetra()
            { name = "A", color_metro = "zelená", active = true, stations = a };
            var hs = new Style(Color.Aqua);
            var menu = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .PageSize(10)
            .HighlightStyle(hs)
            .Title("vyber")
            .AddChoices(new[] { "Vypsat všechny stanice", "Vypsat první a poslední stanici", "Spočítat cestu" }));
            if (menu == "Vypsat všechny stanice")
            {
                linkaA.all_stations();
                Thread.Sleep(6000);
            }
            else if (menu == "Vypsat první a poslední stanici")
            {
                linkaA.first_last_station();
                Thread.Sleep(2000);
            }
            else if (menu == "Spočítat cestu")
            {
                linkaA.time();
                Thread.Sleep(2000);
            }
        }
        void Bx ()
        {
            LinkaMetra linkaB = new LinkaMetra()
            { name = "B", color_metro = "červená", active = true, stations = b };
            var hs = new Style(Color.Aqua);
            var menu = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .PageSize(10)
            .HighlightStyle(hs)
            .Title("vyber")
            .AddChoices(new[] { "Vypsat všechny stanice", "Vypsat první a poslední stanici", "Spočítat cestu" }));
            if (menu == "Vypsat všechny stanice")
            {
                linkaB.all_stations();
                Thread.Sleep(6000);
            }
            else if (menu == "Vypsat první a poslední stanici")
            {
                linkaB.first_last_station();
                Thread.Sleep(2000);
            }
            else if (menu == "Spočítat cestu")
            {
                linkaB.time();
                Thread.Sleep(2000);
            }

        }
        void Cx ()
        {
            LinkaMetra linkaC = new LinkaMetra()
            { name = "C", color_metro = "žlutá", active = true, stations = c };
            var hs = new Style(Color.Aqua);
            var menu = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .PageSize(10)
            .HighlightStyle(hs)
            .Title("vyber")
            .AddChoices(new[] { "Vypsat všechny stanice", "Vypsat první a poslední stanici", "Spočítat cestu" }));
            if (menu == "Vypsat všechny stanice")
            {
                linkaC.all_stations();
                Thread.Sleep(6000);
            }
            else if (menu == "Vypsat první a poslední stanici")
            {
                linkaC.first_last_station();
                Thread.Sleep(2000);
            }
            else if (menu == "Spočítat cestu")
            {
                linkaC.time();
                Thread.Sleep(2000);
            }
        }
        void Dx ()
        {
            LinkaMetra linkaD = new LinkaMetra()
            { name = "D", color_metro = "modrá", active = true, stations = d };
            var hs = new Style(Color.Aqua);
            var menu = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .PageSize(10)
            .HighlightStyle(hs)
            .Title("vyber")
            .AddChoices(new[] { "Vypsat všechny stanice", "Vypsat první a poslední stanici", "Spočítat cestu" }));
            if (menu == "Vypsat všechny stanice")
            {
                linkaD.all_stations();
                Thread.Sleep(6000);
            }
            else if (menu == "Vypsat první a poslední stanici")
            {
                linkaD.first_last_station();
                Thread.Sleep(2000);
            }
            else if (menu == "Spočítat cestu")
            {
                linkaD.time();
                Thread.Sleep(2000);
            }
        }
        void end_program ()
        {
            System.Environment.Exit (0);
        }
        public void linky ()
        {
            string[] Ay = { "Depo Hostivař", "Skalka", "Strašnická", "Želivského", "Flora", "Jiřího z Poděbrad",
            "Náměstí Míru", "Muzeum", "Můstek", "Staroměstská", "Malostranská", "Hradčanská", "Dejvická",
            "Bořislavka", "Nádraží Veleslavín", "Petřiny", "Nemocnice Motol" };

            string[] By = { "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jinonice",
            "Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí", "Národní třída", "Můstek",
            "Náměstí republiky", "Florenc", "Křižíkova", "Invalidovna", "Palmovka", "Českomoravská",
            "Vysočanská", "Kolbenova", "Hloubětín", "Rajská zahrada", "Černý most" };

            string[] Cy = { "Letňany", "Prosek", "Střížkov", "Ládví", "Kobylisy", "Nádraží Holešovice",
            "Vltavská", "Florenc", "Hlavní nádraží", "Muzeum","I. P. Pavlova", "Vyšehrad", "Pražského povstání",
            "Pankrác", "Budějovická", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje" };

            string[] Dy = { "Depo Písnice", "Písnice", "Libuš", "Nové Dvory", "Nemocnice Krč", "Nádraží Krč",
            "Olbrachtova", "Pankrác", "Náměstí Bratří Synků", "Náměstí Míru" };
            a = Ay;
            b = By;
            c = Cy;
            d = Dy;
        }
    }
}
