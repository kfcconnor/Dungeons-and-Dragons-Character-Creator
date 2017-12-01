using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace WindowsFormsApp1
{
    class backList
    {
        public List<Backgrounds> avaliableBackgrounds = new List<Backgrounds>();
        public backList()
        {
            string backlocation = Directory.GetCurrentDirectory() + "\\Json\\Backgrounds";
            string[] backJson = Directory.GetFiles(backlocation);
            foreach (string bJ in backJson)
            {
                avaliableBackgrounds.Add(JsonConvert.DeserializeObject<Backgrounds>(File.ReadAllText(bJ)));
            }

        }

        public List<string> ListBackgrounds()
        {
            List<string> classList = new List<string>();

            foreach (Backgrounds b in avaliableBackgrounds)
            {
                classList.Add(b.backName);
            }

            return classList;
        }

        public Backgrounds selectBack(string selected)
        {
            Backgrounds selectedBack = new Backgrounds();
            foreach (Backgrounds b in avaliableBackgrounds)
            {
                if (selected == b.backName)
                {
                    selectedBack = b;
                    break;
                }
            }
            return selectedBack;
        }
    }

    class Backgrounds
    {
        //public List<string> backgrounds = new List<string>();
        public string backName = "";
        public string description = "";
        public List<string> skillProfs = new List<string>();
        public List<string> toolProfs = new List<string>();
        public int languageChoices = 0;
        public List<string> backEquip = new List<string>();
        public int backGold = 0;
        public string feature = "";


        /*public void Json()
        {
            string output = JsonConvert.SerializeObject(this);
            string currentDir = Directory.GetCurrentDirectory() + "\\Json\\Backgrounds";
            string fileName = "\\" + backName + ".json";
            string fileLocation = currentDir + fileName;
            System.IO.File.WriteAllText(fileLocation, output);

        }*/
    }
}
