using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FairyTales
{
    class Controller
    {
        private List<Lady> Ladies = new List<Lady>();
        private string BLESS = "fairy";
        private string CURSE = "witches";
        public void Start()
        {
            StaticValues();
            ReadData();
            //Output();
            //Activities();
            //OverallEffect();
            //Sorting();
            foreach (Lady lady in Ladies)
            {
                Console.WriteLine("The name" + lady.Name + "their strength" + lady.Strength);

            }
        }
        private void StaticValues()
        {
            Fairy.fairiesMultiplier = 10;
            Witches.withchesMultiplier = 10;
        }

        private void ReadData()
        {
            string name, type, catagory;
            int strength;
            string dataLine;
            string[] data;
            StreamReader streamreader = new StreamReader("invitees.txt");
            while (!streamreader.EndOfStream)
            {
                dataLine = streamreader.ReadLine();
                data = dataLine.Split(';');
                type = data[0];
                name = data[1];
                strength = int.Parse(data[1]);
                if (type == BLESS)
                {
                    catagory = data[2];
                    Console.WriteLine("fairy");
                }
                else if (type == CURSE)
                {
                    catagory = data[2];
                    Console.WriteLine("witch");
                }

            }
            streamreader.Close();
        }
        private void Activities(int overallEffect)
        {
            // the strength of the fairies and the witches is a random number
            Random rand = new Random();
            int power;
            int good;
            int bad;
            //int limit=10;

            foreach (Lady lady in Ladies)
            {
                power = rand.Next(lady.Strength);
                good = lady.Strength + 1;
                bad = lady.Strength - 1;
                Console.WriteLine("the strength of ladies" + power + "fairies strength" + good + "witches strength" + bad);

                foreach (Fairy fairy in Ladies)
                {
                    overallEffect = power + good;
                    Console.WriteLine("the overall effect during conjure is:" + overallEffect);
                }
                foreach (Witches witch in Ladies)
                {
                    overallEffect = power + bad;
                    Console.WriteLine("the overall effect during conjure is:" + overallEffect);
                }
            }
        }
    }
}


        


