using System;


namespace GetMenuPages
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("GetMenuPages started.....");

                Log.Info("\nMenu Pages Started.");
                GetMenuPages menuPages = new GetMenuPages();


                var guid = Guid.NewGuid().ToString();
                Log.Info($"Guid Value set at : {guid}");

                menuPages.GetMenuPagesInformation(guid);
                Log.Info("Menu Pages Finished.\n");

                Console.WriteLine("GetMenuPages Finished.....");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetMenuPages see Logs.");

                Log.Error("Error" + ex);

                Console.ReadKey();
            }

        }
    }
}
