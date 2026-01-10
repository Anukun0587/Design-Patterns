namespace SingletonPattern
{
    public class Excalibur
    {
        private static Excalibur? instance;
        Master master;

        private Excalibur(Master master)
        {
            this.master = master;
        }

        public static Excalibur getExcalibur()
        {
            if(instance == null)
            {
                instance = new Excalibur(new Master());
            }
            return instance;
        }

        public void SetNewMaster(Master master)
        {
            this.master = master;
        }
        
        public void GetExcaliburDetail()
        {
            Console.WriteLine($"Excalibur Bearer : {master.MasterInfo()}");
        }
    }
}