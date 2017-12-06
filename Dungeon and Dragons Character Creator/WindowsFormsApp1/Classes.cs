using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    class classList
    {
        public List<Classes> avaliableClasses = new List<Classes>();

        public classList()
        {
            string classlocation = Directory.GetCurrentDirectory() + "\\Json\\Classes";
            string[] classJson = Directory.GetFiles(classlocation);
            foreach (string cJ in classJson)
            {
                avaliableClasses.Add(JsonConvert.DeserializeObject<Classes>(File.ReadAllText(cJ)));
            }
            
        }
        public List<string> ListClasses()
        {
            List<string> classList = new List<string>();

            foreach (Classes c in avaliableClasses)
            {
                classList.Add(c.className);
                c.getAbilities();
            }

            return classList;
        }

        public Classes selectClass(string selected)
        {
            Classes selectedClass = new Classes();
            foreach(Classes c in avaliableClasses)
            {
                if(selected == c.className)
                {
                    selectedClass = c;
                    break;
                }
            }

            return selectedClass;
        }
    }


    class Classes
    {
        //public List<string> classes = new List<string>();
        [JsonProperty("className")]
        public string className { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("magicUser")]
        public Boolean magicUser { get; set; }
        [JsonProperty("hitdice")]
        public string hitdice { get; set; }
        [JsonProperty("armourProf")]
        public List<string> armourProf { get; set; }
        [JsonProperty("weaponProf")]
        public List<string> weaponProf { get; set; }
        [JsonProperty("toolProf")]
        public List<string> toolProf { get; set; }
        [JsonProperty("savingProf")]
        public List<string> savingProf { get; set; }
        [JsonProperty("skillChoices")]
        public int skillChoices { get; set; }
        [JsonProperty("skillsToChoose")]
        public List<string> skillsToChoose { get; set; }
        [JsonProperty("EquipmentChoice1")]
        public List<string> EquipmentChoice1 { get; set; }
        [JsonProperty("EquipmentChoice2")]
        public List<string> EquipmentChoice2 { get; set; }
        [JsonProperty("EquipmentChoice3")]
        public List<string> EquipmentChoice3 { get; set; }
        [JsonProperty("EquipmentChoice4")]
        public List<string> EquipmentChoice4 { get; set; }
        [JsonProperty("otherEquipment")]
        public List<string> otherEquipment { get; set; }
        public List<string> startingClassAbilities { get; set; }
        public AbilityJson classAbilities { get; set; }
        [JsonProperty("Subclass")]
        public List<string> Subclass { get; set; }

        public void getAbilities()
        {
            string currentDir = Directory.GetCurrentDirectory() + "\\Json\\Abilities";
            string jsonFile = "\\" + className + " Abilities.json";
            string fileLocation = currentDir + jsonFile;
            try
            {
                classAbilities = JsonConvert.DeserializeObject<AbilityJson>(File.ReadAllText(fileLocation));
            } catch
            {
               
            }
            
            
        }

        /*public void Json()
        {
            string output = JsonConvert.SerializeObject(this);
            string currentDir = Directory.GetCurrentDirectory() + "\\Json\\Abilities";
            string fileName = "\\" + className + ".json";
            string fileLocation = currentDir + fileName;
            System.IO.File.WriteAllText(fileLocation, output);

        }*/
        //public void Ranger()
        //{
        //    className = "Ranger";
        //    description = "A warrior who uses martial prowess and nature magic to combat threats on the edges of civilization.";
        //    hitdice = "d10";
        //    magicUser = true;
        //    armourProf.Add("Light Armour");
        //    armourProf.Add("Medium Armour");
        //    armourProf.Add("Shields");
        //    weaponProf.Add("Simple Weapons");
        //    weaponProf.Add("Martial Weapons");
        //    savingProf.Add("Strength");
        //    savingProf.Add("Dexterity");
        //    skillChoices = 3;
        //    skillsToChoose.Add("Animal Handling");
        //    skillsToChoose.Add("Athletics");
        //    skillsToChoose.Add("Insight");
        //    skillsToChoose.Add("Investigation");
        //    skillsToChoose.Add("Nature");
        //    skillsToChoose.Add("Perception");
        //    skillsToChoose.Add("Stealth");
        //    skillsToChoose.Add("Survival");
        //    EquipmentChoice1.Add("Scale Mail");
        //    EquipmentChoice1.Add("Leather Mail");
        //    EquipmentChoice2.Add("Two Shortswords");
        //    EquipmentChoice2.Add("Two Simple Melee Weapons");
        //    EquipmentChoice3.Add("Dungeoneer's Pack");
        //    EquipmentChoice3.Add("Explorer's Pack");
        //    otherEquipment.Add("Longbow");
        //    otherEquipment.Add("Quiver of 20 Arrows");
        //    Subclass.Add("Hunter");
        //    Subclass.Add("Beast Master");
        //    Json();
        //}
        //public void Rogue()
        //{
        //    className = "Rogue";
        //    description = "A scoundrel who uses stealth and trickery to overcome obstacles and enemies.";
        //    hitdice = "d8";
        //    armourProf.Add("Light Armour");
        //    weaponProf.Add("Simple Weapons");
        //    weaponProf.Add("Hand Crossbows");
        //    weaponProf.Add("Longswords");
        //    weaponProf.Add("Rapiers");
        //    weaponProf.Add("Shortswords");
        //    toolProf.Add("Thieves' Tools");
        //    savingProf.Add("Dexterity");
        //    savingProf.Add("Intelligence");
        //    skillChoices = 4;
        //    skillsToChoose.Add("Acrobatics");
        //    skillsToChoose.Add("Athletics");
        //    skillsToChoose.Add("Deception");
        //    skillsToChoose.Add("Insight");
        //    skillsToChoose.Add("Intimidation");
        //    skillsToChoose.Add("Investigation");
        //    skillsToChoose.Add("Perception");
        //    skillsToChoose.Add("Performance");
        //    skillsToChoose.Add("Persuasion");
        //    skillsToChoose.Add("Sleight of Hands");
        //    skillsToChoose.Add("Stealth");
        //    EquipmentChoice1.Add("Rapier");
        //    EquipmentChoice1.Add("Shortsword");
        //    EquipmentChoice2.Add("Shortbow and quiver of 20 arrows");
        //    EquipmentChoice2.Add("Shortsword");
        //    EquipmentChoice3.Add("Burglar's Pack");
        //    EquipmentChoice3.Add("Dungeoneer's Pack");
        //    EquipmentChoice3.Add("Explorer's Pack");
        //    otherEquipment.Add("Leather Armour");
        //    otherEquipment.Add("Two Daggers");
        //    otherEquipment.Add("Thieves' Tools");
        //    Subclass.Add("Thief");
        //    Subclass.Add("Assassin");
        //    Subclass.Add("Arcane Trickster");
        //    Json();
        //}
        //public void Sorcerer()
        //{
        //    className = "Sorcerer";
        //    description = "A spellcaster who draws on inherent magic from a gift or bloodline";
        //    hitdice = "d6";
        //    magicUser = true;
        //    weaponProf.Add("Daggers");
        //    weaponProf.Add("Darts");
        //    weaponProf.Add("Slings");
        //    weaponProf.Add("Quarterstaffs");
        //    weaponProf.Add("Light Crossbows"); 
        //    savingProf.Add("Constitution");
        //    savingProf.Add("Charisma");
        //    skillChoices = 2;
        //    skillsToChoose.Add("Arcana");
        //    skillsToChoose.Add("Deception");
        //    skillsToChoose.Add("Insight");
        //    skillsToChoose.Add("Intimidation");
        //    skillsToChoose.Add("Persuasion");
        //    skillsToChoose.Add("Religion");
        //    EquipmentChoice1.Add("Light Crossbow and 20 Bolts");
        //    EquipmentChoice1.Add("Any Simple Weapon");
        //    EquipmentChoice2.Add("Component Pouch");
        //    EquipmentChoice2.Add("Arcane Focus");
        //    EquipmentChoice3.Add("Dungeoneer's Pack");
        //    EquipmentChoice3.Add("Explorer's Pack");
        //    otherEquipment.Add("Two Daggers");
        //    Subclass.Add("Draconic Bloodline");
        //    Subclass.Add("Wild Magic");
        //    Json();
        //}
        //public void Warlock()
        //{
        //    className = "Warlock";
        //    description = "A wielder of magic that is derived from a bargain with an extraplanar entity.";
        //    hitdice = "d8";
        //    magicUser = true;
        //    armourProf.Add("Light Armour");
        //    weaponProf.Add("Simple Weapons");
        //    savingProf.Add("Wisdom");
        //    savingProf.Add("Charisma");
        //    skillChoices = 2;
        //    skillsToChoose.Add("Arcana");
        //    skillsToChoose.Add("Deception");
        //    skillsToChoose.Add("History");
        //    skillsToChoose.Add("Intimidation");
        //    skillsToChoose.Add("Investigation");
        //    skillsToChoose.Add("Nature");
        //    skillsToChoose.Add("Religion");
        //    EquipmentChoice1.Add("Light Crossbow and 20 Bolts");
        //    EquipmentChoice1.Add("Any Simple Weapon");
        //    EquipmentChoice2.Add("Component Pouch");
        //    EquipmentChoice2.Add("Arcane Focus");
        //    EquipmentChoice3.Add("Scholar's Pack");
        //    EquipmentChoice3.Add("Dungeoneer's Pack");
        //    otherEquipment.Add("Leather Armour");
        //    otherEquipment.Add("Any Simple Weapon");
        //    otherEquipment.Add("Two Daggers");
        //    Subclass.Add("Archfey");
        //    Subclass.Add("The Fiend");
        //    Subclass.Add("The Great Old One");
        //    Json();
        //}
        //public void Wizard()
        //{
        //    className = "Wizard";
        //    description = "A scholarly magic-user capable of manipulating the structures of reality.";
        //    hitdice = "d6";
        //    magicUser = true;
        //    weaponProf.Add("Daggers");
        //    weaponProf.Add("Darts");
        //    weaponProf.Add("Slings");
        //    weaponProf.Add("Quarterstaffs");
        //    weaponProf.Add("Light Crossbows");
        //    savingProf.Add("Intelligence");
        //    savingProf.Add("Wisdom");
        //    skillChoices = 2;
        //    skillsToChoose.Add("Arcana");
        //    skillsToChoose.Add("History");
        //    skillsToChoose.Add("Insight");
        //    skillsToChoose.Add("Investigation");
        //    skillsToChoose.Add("Medicine");
        //    skillsToChoose.Add("Religion");
        //    EquipmentChoice1.Add("Quarterstaff");
        //    EquipmentChoice1.Add("Dagger");
        //    EquipmentChoice2.Add("Component Pouch");
        //    EquipmentChoice2.Add("Arcane Focus");
        //    EquipmentChoice3.Add("Scholar's Pack");
        //    EquipmentChoice3.Add("Explorer's Pack");
        //    otherEquipment.Add("Spellbook");
        //    Subclass.Add("Abjuration");
        //    Subclass.Add("Conjuration");
        //    Subclass.Add("Divination");
        //    Subclass.Add("Enchantment");
        //    Subclass.Add("Evocation");
        //    Subclass.Add("Illusion");
        //    Subclass.Add("Necromancy");
        //    Subclass.Add("Transmutation");
        //    Json();
        //}
    }
}
//skillsToChoose.Add("");
