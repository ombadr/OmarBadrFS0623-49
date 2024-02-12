using System.ComponentModel.Design;
using System.Diagnostics;

namespace Esercizio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, (string, decimal)> menuItems = new Dictionary<int, (string, decimal)>
            {
                { 1, ("Coca Cola 150ml", 2.50m)},
                { 2, ("Insalata di pollo", 5.20m)},
                { 3, ("Pizza Margherita", 10.00m)},
                { 4, ("Pizza 4 formaggi", 12.50m)},
                { 5, ("Pz patatine fritte", 3.50m)},
                { 6, ("Insalata di riso", 8.00m)},
                { 7, ("Frutta di stagione", 5.00m)},
                { 8, ("Pizza fritta", 5.00m)},
                { 9, ("Piadina vegetariana", 6.00m)},
                { 10, ("Panino Hamburger", 7.90m)},
            };

            List<(string, decimal)> ordini = new List<(string, decimal)>();
            bool continua = true;

            while (continua)
            {
                Console.WriteLine("=========MENU=========");
                foreach(var item in menuItems)
                {
                    Console.WriteLine($"{item.Key}: {item.Value.Item1} (EUR {item.Value.Item2})");
                }
                Console.WriteLine("11: Stampa conto finale e conferma");
                Console.WriteLine("Seleziona un'opzione:");

                if(int.TryParse(Console.ReadLine(), out int scelta) && scelta >= 1 && scelta <= 11)
                {
                     if(scelta == 11)
                    {
                        decimal totale = 0;
                        Console.WriteLine("\n Hai ordinato:");
                        foreach(var ordine in ordini)
                        {
                            Console.WriteLine($"{ordine.Item1}-€{ordine.Item2}");
                            totale += ordine.Item2;
                        }
                        totale += 3.00m; // Costo del servizio
                        Console.WriteLine($"Costo servizio: €3.00");
                        Console.WriteLine($"Totale: {totale}");
                        continua = false;
                    }
                     else
                    {
                        ordini.Add(menuItems[scelta]);
                        Console.WriteLine($"Hai aggiunto: {menuItems[scelta].Item1}\n");
                    }
                } else
                {
                    Console.WriteLine("Opzione non valida, riprova.");
                }
               
            }
        }
    }

}