using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMenuPages
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine();
                Log.Info("\nMenu Pages Started.");
                GetMenuPages menuPages = new GetMenuPages();

                var guid = Guid.NewGuid().ToString();
                Log.Info($"Guid Value set at : {guid}");

                menuPages.GetMenuPagesInformation(guid);
                Log.Info("Menu Pages Finished.\n");
            }
            catch (Exception ex)
            {
                Log.Error("Error" + ex);
            }

        }
    }
}
