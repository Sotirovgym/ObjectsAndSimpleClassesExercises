using System;
using System.Collections.Generic;
using System.Linq;

class Websites
{
    static void Main()
    {
        var sites = new List<Website>();

        var newWebsite = new Website();

        var input = Console.ReadLine();

        while (input != "end")
        {
            var tokens = input.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 2)
            {
                newWebsite = new Website()
                {
                    Host = tokens[0],
                    Domain = tokens[1],                    
                };

                sites.Add(newWebsite);
            }
            else
            {
                newWebsite = new Website()
                {
                    Host = tokens[0],
                    Domain = tokens[1],
                    Queries = tokens.Skip(2).Select(q => $"[{q}]").ToList()
                };

                sites.Add(newWebsite);
            }

            input = Console.ReadLine();
        }

        foreach (var webSite in sites)
        {
            if (webSite.Queries == null)
            {
                Console.WriteLine($"https://www.{webSite.Host}.{webSite.Domain}");
            }
            else
            {
                Console.WriteLine($"https://www.{webSite.Host}.{webSite.Domain}/query?={string.Join("&", webSite.Queries)}");
            }
            
        }
    }
}

