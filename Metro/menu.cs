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
        public void name()
        {
            //WIP
            var hs = new Style(Color.Aqua);
            var menu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .PageSize(10)
                .HighlightStyle(hs)
                .Title("Zadej linku")
                .AddChoices(new[] { "A", "B", "C", "D", "Ukončit" }));
            if (menu == "A")
            {

            }
            else if (menu == "B")
            {

            }
            else if (menu == "C")
            {

            }
            else if (menu == "D")
            {

            }
            else if (menu == "Ukončit")
            {

            }
        }
        void a ()
        {

        }
    }
}
