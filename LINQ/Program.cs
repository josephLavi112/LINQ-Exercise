namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videogames = new List<string>() { "Halo", "Fallout 3", "Call Of Duty", "Rainbow Six", "Grand Theft Auto", "Mortal Kombat", "Ghost Recon" };
            var longNames = videogames.Where(videogames => videogames.Length > 10).ToList();
            foreach (var videogams in longNames) 
            {
                Console.WriteLine(videogams);
            }
        }
    }
}
