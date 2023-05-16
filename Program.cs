using ConsloleAppTOCalculationsDamageForOscar;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        SwordDamage sword = new SwordDamage();
        while(true)
        {
            sword.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            Console.WriteLine("0 - ani magiczny ani płonący; 1 - magiczny; 2 - płonący; 3 - magiczny i płonący; inne wartości koniec");
            Console.Write("Wybierza atak: ");
            char userchose;
            userchose = Console.ReadKey().KeyChar;
            
            if (userchose != '0' && userchose != '1' && userchose != '2' && userchose != '3') return;
            sword.SetMagic(userchose != '1' || userchose != '3');
            sword.SetFlamingDamage(userchose != '2' || userchose != '3');
            Console.WriteLine("\nRzut: " + sword.Roll + ", punty obrazen: " + sword.Damage);
            Console.WriteLine('\n');
        }
        
    }
}