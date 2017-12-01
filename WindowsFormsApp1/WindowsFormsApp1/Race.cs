using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    class raceList
    {
        public List<Race> avaliableRaces = new List<Race>();

        public raceList()
        {
            string racelocation = Directory.GetCurrentDirectory() + "\\Json\\Races";
            string[] raceJson = Directory.GetFiles(racelocation);
            foreach (string rJ in raceJson)
            {
                avaliableRaces.Add(JsonConvert.DeserializeObject<Race>(File.ReadAllText(rJ)));
            }

        }

        public List<string> ListRaces()
        {
            List<string> RaceList = new List<string>();

            foreach (Race r in avaliableRaces)
            {
                RaceList.Add(r.raceName);
            }

            return RaceList;
        }
        public Race selectRace(string selected)
        {
            Race selectedClass = new Race();
            foreach (Race r in avaliableRaces)
            {
                if (selected == r.raceName)
                {
                    selectedClass = r;
                    break;
                }
            }

            return selectedClass;
        }
    }

    class Race
    {
        // public List<string> Races = new List<string>();
        [JsonProperty("raceName")]
        public String raceName = "";
        [JsonProperty("Description")]
        public String Description = "";
        [JsonProperty("raceBonuses")]
        public int[] raceBonuses = new int[6];
        [JsonProperty("bonusNotes")]
        public string bonusNotes = "";
        [JsonProperty("size")]
        public string size = "Medium";
        [JsonProperty("speed")]
        public int speed = 30;
        [JsonProperty("speedNotes")]
        public string speedNotes = "";
        [JsonProperty("Vision")]
        public string Vision = "Standard: Need a Torch or magic to see in the Dark";
        [JsonProperty("raceAbilities")]
        public List<string> raceAbilities = new List<string>();

        /*public void Json()
        {
            string output = JsonConvert.SerializeObject(this);
            string currentDir = Directory.GetCurrentDirectory() + "\\Json\\Races";
            string fileName = "\\" + raceName + ".json";
            string fileLocation = currentDir + fileName;
            System.IO.File.WriteAllText(fileLocation, output);

        }*/
    }
}
//raceAbilities.Add("");
