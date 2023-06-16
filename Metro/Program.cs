using Metro;
using Spectre.Console;

#region pole_metra
string[] A = { "Depo Hostivař", "Skalka", "Strašnická", "Želivského", "Flora", "Jiřího z Poděbrad", 
    "Náměstí Míru", "Muzeum", "Můstek", "Staroměstská", "Malostranská", "Hradčanská", "Dejvická", 
    "Bořislavka", "Nádraží Veleslavín", "Petřiny", "Nemocnice Motol" };

string[] B = { "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jinonice", 
    "Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí", "Národní třída", "Můstek", 
    "Náměstí republiky", "Florenc", "Křižíkova", "Invalidovna", "Palmovka", "Českomoravská", 
    "Vysočanská", "Kolbenova", "Hloubětín", "Rajská zahrada", "Černý most" };

string[] C = { "Letňany", "Prosek", "Střížkov", "Ládví", "Kobylisy", "Nádraží Holešovice", 
    "Vltavská", "Florenc", "Hlavní nádraží", "Muzeum","I. P. Pavlova", "Vyšehrad", "Pražského povstání",
    "Pankrác", "Budějovická", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje" };

string[] D = { "Depo Písnice", "Písnice", "Libuš", "Nové Dvory", "Nemocnice Krč", "Nádraží Krč",
        "Olbrachtova", "Pankrác", "Náměstí Bratří Synků", "Náměstí Míru" };
#endregion

var hs = new Style(Color.Aqua);
var menu = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
    .PageSize(10)
    .HighlightStyle(hs)
    .Title("Zadej linku")
    .AddChoices(new[] { "A", "B", "C", "D" }));
if (menu == "A")
{
    LinkaMetra linkaA = new LinkaMetra()
        { name = "A", color_metro = "zelená", active = true, stations = A };
    menu = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
    .PageSize(10)
    .HighlightStyle(hs)
    .Title("vyber")
    .AddChoices(new[] { "Vypsat všechny stanice", "Vypsat první a poslední stanici", "Spočítat cestu" }));
    if (menu == "Vypsat všechny stanice")
    {
        linkaA.all_stations();
    }
    else if (menu == "Vypsat první a poslední stanici")
    {
        linkaA.first_last_station();
    }
    else if (menu == "Spočítat cestu")
    {
        linkaA.time();
    }
}
else if (menu == "B")
{
    LinkaMetra linkaB = new LinkaMetra()
    { name = "B", color_metro = "červená", active = true, stations = B };
    menu = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
    .PageSize(10)
    .HighlightStyle(hs)
    .Title("vyber")
    .AddChoices(new[] { "Vypsat všechny stanice", "Vypsat první a poslední stanici", "Spočítat cestu" }));
    if (menu == "Vypsat všechny stanice")
    {
        linkaB.all_stations();
    }
    else if (menu == "Vypsat první a poslední stanici")
    {
        linkaB.first_last_station();
    }
    else if (menu == "Spočítat cestu")
    {
        linkaB.time();
    }
}
else if (menu == "C")
{
    LinkaMetra linkaC = new LinkaMetra()
    { name = "C", color_metro = "žlutá", active = true, stations = C };
    menu = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
    .PageSize(10)
    .HighlightStyle(hs)
    .Title("vyber")
    .AddChoices(new[] { "Vypsat všechny stanice", "Vypsat první a poslední stanici", "Spočítat cestu" }));
    if (menu == "Vypsat všechny stanice")
    {
        linkaC.all_stations();
    }
    else if (menu == "Vypsat první a poslední stanici")
    {
        linkaC.first_last_station();
    }
    else if (menu == "Spočítat cestu")
    {
        linkaC.time();
    }
}
else if (menu == "D")
{
    LinkaMetra linkaD = new LinkaMetra()
    { name = "D", color_metro = "modrá", active = true, stations = D };
    menu = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
    .PageSize(10)
    .HighlightStyle(hs)
    .Title("vyber")
    .AddChoices(new[] { "Vypsat všechny stanice", "Vypsat první a poslední stanici", "Spočítat cestu" }));
    if (menu == "Vypsat všechny stanice")
    {
        linkaD.all_stations();
    }
    else if (menu == "Vypsat první a poslední stanici")
    {
        linkaD.first_last_station();
    }
    else if (menu == "Spočítat cestu")
    {
        linkaD.time();
    }
}