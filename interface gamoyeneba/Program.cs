using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_gamoyeneba
{
    public interface Domesticbird
    {
        void Speak();
    }
    public class Goose : Domesticbird
    {
        public void Speak()
        {
            Console.WriteLine("ssssss!");
        }
    }

    public class Chicken : Domesticbird
    {
        public void Speak()
        {
            Console.WriteLine("kakaka");
        }
    }

    public class Program
    {
        public static void MakeDomesticbirdSpeak(Domesticbird domesticbird)
        {
            domesticbird.Speak();
        }

        public static void Main(string[] args)
        {
            Domesticbird goose = new Goose();
            Domesticbird chicken = new Chicken();

            MakeDomesticbirdSpeak(goose);
            MakeDomesticbirdSpeak(chicken);
            Console.ReadLine();
        }
    }
}






