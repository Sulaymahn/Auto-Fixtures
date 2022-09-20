using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentDrafter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many teams are being fixed?: ");
            int teamNumber = int.Parse(Console.ReadLine());
            var teamList = new List<string>();
            for(int i = 1; i <= teamNumber; i++)
            {
                Console.Write($"Team #{i} Name: ");
                teamList.Add(Console.ReadLine());
            }
            Console.WriteLine("Calculating..");
            var rand = new Random();
            var fixtures = new List<Tuple<string, string>>();
            for(int i = 0; i < teamNumber/2; i++)
            {
                string firstPick = teamList[rand.Next(0, teamList.Count)];
                teamList.Remove(firstPick);
                string secondPick = teamList[rand.Next(0, teamList.Count)];
                teamList.Remove(secondPick);
                fixtures.Add(new Tuple<string, string>(firstPick, secondPick));
            }
            Console.WriteLine("Finishing..");
            int counter = 1;
            foreach(var fixture in fixtures)
            {
                Console.WriteLine($"Match #{counter++}");
                Console.WriteLine($"{fixture.Item1} vs {fixture.Item2}\n");
            }
            Console.WriteLine(teamList[0] + " automatically qualified");
        }
    }
}
