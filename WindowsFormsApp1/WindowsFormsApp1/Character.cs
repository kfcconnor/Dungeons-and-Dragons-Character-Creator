using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Character
    {
        public string charName = "";
        public int[] charStats = new int[6];
        public int[] charStatMod = new int[6];
        public int level = 0;
        public Race charRace = new Race();
        public Classes charClass = new Classes();
        public Backgrounds charBack = new Backgrounds();
        public List<Ability> charAbilities = new List<Ability>();
        public List<string> Languages = new List<string>();
        public int charGold = 0;
        public int charSilver = 0;
        public int charCopper = 0;
        List<string> Equipment = new List<string>();

        public Character(string Name, int[] stats, int[] mod, Race race, Classes classes, Backgrounds backgrounds)
        {
            charName = Name;
            charStats = stats;
            charStatMod = mod;
            level = 1;
            charRace = race;
            charClass = classes;
            charBack = backgrounds;
            foreach (Ability ab in charClass.classAbilities.Ability)
            {
                if(level == ab.lvl)
                {
                    charAbilities.Add(ab);
                }
            }
            foreach(string item in charClass.otherEquipment)
            {
                Equipment.Add(item);
            }
            foreach(string item in charBack.backEquip)
            {
                Equipment.Add(item);
            }
            charGold = backgrounds.backGold;
            string messageBoxText = "Character Saved.";
            string caption = "Save Successful";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(messageBoxText, caption, buttons, icon);
            
            
        }
    }
}
