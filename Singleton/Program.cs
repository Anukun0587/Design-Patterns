using SingletonPattern;

class Program
{
    static void Main(string[] args)
    {
        Master master = new Master("Arthur Pendragon", "king of Camelot");

        Excalibur excalibur1 = Excalibur.getExcalibur();
        excalibur1.GetExcaliburDetail();

        Console.WriteLine("\n" + new string('-', 50) + "\n");

        Console.WriteLine("The sword chooses a new bearer");
        excalibur1.SetNewMaster(master);
        excalibur1.GetExcaliburDetail();

        Console.WriteLine("\n" + new string('-', 50) + "\n");

        Console.WriteLine("Calling for the Excalibur sword");
        Excalibur excalibur2 = Excalibur.getExcalibur();
        excalibur2.GetExcaliburDetail();
    }
}