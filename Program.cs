using ConsloleAppTOCalculationsDamageForOscar;

internal class Program
{
    static Random random = new Random();
    private static void Main(string[] args)
    {       
        SwordDamage sword = new SwordDamage(RollDice());
        while(true)
        {
            
            Console.WriteLine("0 - ani magiczny ani płonący; 1 - magiczny; 2 - płonący; 3 - magiczny i płonący; inne wartości koniec");
            Console.Write("Wybierza atak: ");
            char userchose;
            userchose = Console.ReadKey().KeyChar;
            
            
            if (userchose != '0' && userchose != '1' && userchose != '2' && userchose != '3') return;
            sword.Roll = RollDice();
            sword.Magic = (userchose == '1' || userchose == '3');
            sword.Flaming = (userchose == '2' || userchose == '3');
            Console.WriteLine("\nRzut: " + sword.Roll + ", punty obrazen: " + sword.Damage);
            Console.WriteLine('\n');
        }
        
    }

    private static int RollDice()
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }
}