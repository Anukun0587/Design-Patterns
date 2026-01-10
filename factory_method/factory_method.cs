using System;

namespace GardenSystem
{
    interface Plant
    {
        string water();
        string fertilize();
        string harvest();
    }

    class Carrot : Plant
    {
        public string water() { return "watered the carrot"; }
        public string fertilize() { return "fertilized the carrot"; }
        public string harvest() { return "harvested the carrot"; }
    }

    class Rose : Plant
    {
        public string water() { return "watered the rose"; }
        public string fertilize() { return "fertilized the rose"; }
        public string harvest() { return "harvested the rose"; }
    }

    class AloeVera : Plant
    {
        public string water() { return "watered the aloe vera"; }
        public string fertilize() { return "fertilized the aloe vera"; }
        public string harvest() { return "harvested the aloe vera"; }
    }

    abstract class Garden
    {
        public abstract Plant getPlant();
        public string gardening()
        {
            Plant plant = getPlant();
            string result = "Gardening...\n";
            result += plant.water() + "\n";
            result += plant.fertilize() + "\n";
            return result;
        }
        public string harvest()
        {
            Plant plant = getPlant();
            string result;
            result = plant.harvest() + "\n";
            return result;
        }
    }

    class EdibleGarden : Garden
    {
        public override Plant getPlant()
        {
            return new Carrot();
        }
    }

    class FlowerGarden : Garden
    {
        public override Plant getPlant()
        {
            return new Rose();
        }
    }

    class HerbGarden : Garden
    {
        public override Plant getPlant()
        {
            return new AloeVera();
        }
    }

    class Program
    {
        static void Client(Garden garden)
        {
            Console.WriteLine(garden.gardening());
            Console.WriteLine(garden.harvest());
        }

        static void Main()
        {
            Garden garden = new EdibleGarden();
            Client(garden);

            garden = new FlowerGarden();
            Client(garden);

            garden = new HerbGarden();
            Client(garden);

        }
    }
}