using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    
    class AbilityJson
    {
        [JsonProperty("Abilities")]
        public List<Ability> Ability { get; set; }
    }
    class Ability
    {
        [JsonProperty("Name")]
        public string name { get; set; }
        [JsonProperty("Class")]
        public string abClass { get; set; }
        [JsonProperty("Level")]
        public int lvl { get; set; }
        [JsonProperty("Description")]
        public string descrip { get; set; }
        [JsonProperty("SubclassChoice")]
        public bool subChoice { get; set; }
        [JsonProperty("fightingStyleChoice")]
        public bool fightChoice { get; set; }
        [JsonProperty("upgradesrepeatAtHigherLevel")]
        public bool upRepAtHigher { get; set; }
        [JsonProperty("upgraderepeatLevels")]
        public int[] upRepLvls { get; set; }
        [JsonProperty("upgraderepeatNotes")]
        public string upRepNotes { get; set; }
}
}
