using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class New_Character : Form
    {
        classList aClasses = new classList();
        raceList aRaces = new raceList();
        backList aBacks = new backList();
        Character newChar;
        Classes classes;
        Race races;
        Backgrounds backgrounds;
        Random rnd = new Random();
        bool page1Vis = false;
        int[] stats = new int[6];
        int[] mod = new int[6];
        int[] previousBonus = new int[6];
        int[] currentBonus = new int[6];
        public New_Character()
        {
            InitializeComponent();
        }

        private void New_Character_Load(object sender, EventArgs e)
        {
            toggleP1Vis();


            List<string> avaliableRaces = aRaces.ListRaces();
            foreach (string aRace in avaliableRaces)
            {
                cboRace.Items.Add(aRace);
            }

            List<string> avaliableClasses =  aClasses.ListClasses();
            foreach (string aClass in avaliableClasses)
            {
                cboClass.Items.Add(aClass);
            }

            List<string> avaliableBackgrounds = aBacks.ListBackgrounds();
            foreach(string aBack in avaliableBackgrounds)
            {
                cboBackground.Items.Add(aBack);
            }

            statRoll();
            updateStats();
        }

        private void statRoll()
        {
            stats[0] = rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);
            stats[1] = rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);
            stats[2] = rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);
            stats[3] = rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);
            stats[4] = rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);
            stats[5] = rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);
        }

        private void cboRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Selected = cboRace.SelectedItem.ToString();
            races = aRaces.selectRace(Selected);
            string descriptionTxt = string.Format("Name: {0}\nDescription: {1}\nStr: +{2}|Dex: +{3}|Con: +{4}|Int: +{5}|Wis: +{6}|Cha: +{7}\nSpeed: {8}ft {9}\nVision: {10}", races.raceName, races.Description, races.raceBonuses[0], races.raceBonuses[1], races.raceBonuses[2], races.raceBonuses[3], races.raceBonuses[4], races.raceBonuses[5], races.speed, races.speedNotes, races.Vision);
            foreach (string ability in races.raceAbilities)
            {
                descriptionTxt = descriptionTxt + "\n" + ability;
            }
            rtxtDescription.Text = descriptionTxt;
            for (int i = 0; i < 6; i++)
            {
                currentBonus[i] = races.raceBonuses[i];
            }
            addRaceStats();
            for (int i = 0; i < 6; i++)
            {
                previousBonus[i] = races.raceBonuses[i];
            }

        }

        private void updateStats()
        {
            int i = 0;
            foreach (int stat in stats)
            {
                switch (stat)
                {
                    case  1:
                        mod[i] = -5;
                        break;
                    case 2:
                    case 3:
                        mod[i] = -4;
                        break;
                    case 4:
                    case 5:
                        mod[i] = -3;
                        break;
                    case 6:
                    case 7:
                        mod[i] = -2;
                        break;
                    case 8:
                    case 9:
                        mod[i] = -1;
                        break;
                    case 10:
                    case 11:
                        mod[i] = 0;
                        break;
                    case 12:
                    case 13:
                        mod[i] = 1;
                        break;
                    case 14:
                    case 15:
                        mod[i] = 2;
                        break;
                    case 16:
                    case 17:
                        mod[i] = 3;
                        break;
                    case 18:
                    case 19:
                        mod[i] = 4;
                        break;
                    case 20:
                        mod[i] = 5;
                        break;
                }
                i++;
            }
            txtStr.Text = Convert.ToString(stats[0]);
            txtStrMod.Text = Convert.ToString(mod[0]);
            txtDex.Text = Convert.ToString(stats[1]);
            txtDexMod.Text = Convert.ToString(mod[1]);
            txtCon.Text = Convert.ToString(stats[2]);
            txtConMod.Text = Convert.ToString(mod[2]);
            txtInt.Text = Convert.ToString(stats[3]);
            txtIntMod.Text = Convert.ToString(mod[3]);
            txtWis.Text = Convert.ToString(stats[4]);
            txtWisMod.Text = Convert.ToString(mod[4]);
            txtCha.Text = Convert.ToString(stats[5]);
            txtChaMod.Text = Convert.ToString(mod[5]);
        }

        private void addRaceStats()
        {
            for (int i = 0;i < 6; i++)
            {
                stats[i] = stats[i] - previousBonus[i];
            }
            for (int i = 0; i < 6; i++)
            {
                stats[i] = stats[i] + currentBonus[i];
            }
            updateStats();
        }

        private void btnRollStats_Click(object sender, EventArgs e)
        {
            statRoll();
            addRaceStats();
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Selected = cboClass.SelectedItem.ToString();
            classes = aClasses.selectClass(Selected);
            string descriptionTxt = string.Format("Name: {0}\nDescription: {1}\nHit Dice: {2}", classes.className,classes.description,classes.hitdice);
            if(classes.magicUser == true)
            {
                descriptionTxt = descriptionTxt + "\nMagic User: Yes";
            }
            else if(classes.magicUser != true)
            {
                descriptionTxt = descriptionTxt + "\nMagic User: No";
            }
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nArmour Proficiencies: ";
            if (classes.armourProf.Count() == 0)
            {
                descriptionTxt = descriptionTxt + "\nNone";
            }
            else
            {
                foreach (string armour in classes.armourProf)
                {
                    descriptionTxt = descriptionTxt + "\n" + armour;
                }
            }
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nWeapon Proficiencies: ";
            foreach(string weapon in classes.weaponProf)
            {
                descriptionTxt = descriptionTxt + "\n" + weapon;
            }
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nTool Proficiencies: ";
            if (classes.toolProf.Count() == 0)
            {
                descriptionTxt = descriptionTxt + "\nNone";       
            }
            else
            {
                foreach(string tool in classes.toolProf)
                {
                    descriptionTxt = descriptionTxt + "\n" + tool;
                }
            }
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nSaving Throw Proficiencies: ";
            foreach(string save in classes.savingProf)
            {
                descriptionTxt = descriptionTxt + "\n" + save;
            }
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nChoose " + classes.skillChoices + " skills from the following: ";
            foreach(string skill in classes.skillsToChoose)
            {
                descriptionTxt = descriptionTxt + "\n" + skill;
            }
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nStarting equipment: \n";
            int equipChoice = 1;
            foreach (string equip in classes.EquipmentChoice1)
            {
                descriptionTxt = descriptionTxt + equip;
                if(equipChoice != classes.EquipmentChoice1.Count())
                {
                    descriptionTxt = descriptionTxt + " or ";
                }
                equipChoice++;
            }
            equipChoice = 1;
            descriptionTxt = descriptionTxt + "\n";
            foreach (string equip in classes.EquipmentChoice2)
            {
                descriptionTxt = descriptionTxt + equip;
                if (equipChoice != classes.EquipmentChoice2.Count())
                {
                    descriptionTxt = descriptionTxt + " or ";
                }
                equipChoice++;
            }
            equipChoice = 1;
            
            if (classes.EquipmentChoice3.Count() != 0)
            {
                descriptionTxt = descriptionTxt + "\n";
                foreach (string equip in classes.EquipmentChoice3)
                {
                    descriptionTxt = descriptionTxt + equip;
                    if (equipChoice != classes.EquipmentChoice3.Count())
                    {
                        descriptionTxt = descriptionTxt + " or ";
                    }
                    equipChoice++;
                }
            }
            equipChoice = 1;
           
            if (classes.EquipmentChoice4.Count() != 0)
            {
                descriptionTxt = descriptionTxt + "\n";
                foreach (string equip in classes.EquipmentChoice4)
                {
                    descriptionTxt = descriptionTxt + equip;
                    if (equipChoice != classes.EquipmentChoice4.Count())
                    {
                        descriptionTxt = descriptionTxt + " or ";
                    }
                    equipChoice++;
                }
            }
            if (classes.otherEquipment.Count() != 0)
            {
                foreach (string equip in classes.otherEquipment)
                {
                    descriptionTxt = descriptionTxt + "\n" + equip;
                }
            }
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nStarting Abilities";
            foreach (Ability ability in classes.classAbilities.Ability)
            {
                if (ability.lvl == 1)
                {
                    descriptionTxt = descriptionTxt + "\n" + ability.name + ": " + ability.descrip;
                }
            }
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nSubclass Choices: ";
            foreach(string subclass in classes.Subclass)
            {
                descriptionTxt = descriptionTxt + "\n" + subclass;
            }
            rtxtDescription.Text = descriptionTxt;
        }

        private void cboBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Selected = cboBackground.SelectedItem.ToString();
            backgrounds = aBacks.selectBack(Selected);
            string descriptionTxt = string.Format("Name: {0}\nDescription: {1}",backgrounds.backName, backgrounds.description);
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nSkill Proficiencies: ";
            foreach (string skill in backgrounds.skillProfs)
            {
                descriptionTxt = descriptionTxt + "\n" + skill;
            }

            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nTool Proficiencies: ";
            if (backgrounds.toolProfs.Count() == 0)
            {
                descriptionTxt = descriptionTxt + "\nNone";
            }
            else
            {
                foreach(string tool in backgrounds.toolProfs)
                {
                    descriptionTxt = descriptionTxt + "\n" + tool;
                }
            }
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nNumber of New Lanauges: " + Convert.ToString(backgrounds.languageChoices);
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nBackground Equipment: ";
            if (backgrounds.backEquip.Count() == 0)
            {
                descriptionTxt = descriptionTxt + "\nNone";
            }
            else
            {
                foreach(string equip in backgrounds.backEquip)
                {
                    descriptionTxt = descriptionTxt + "\n" + equip;
                }
            }
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nGold from Background: " + Convert.ToString(backgrounds.backGold) + "GP";
            descriptionTxt = descriptionTxt + "\n------------------------------";
            descriptionTxt = descriptionTxt + "\nFeature: ";
            descriptionTxt = descriptionTxt + backgrounds.feature;
            rtxtDescription.Text = descriptionTxt;
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            newChar = new Character(txtName.Text, stats, mod, races, classes, backgrounds);
            toggleP1Vis();
            toggleVisP2();
        }

        public void toggleP1Vis()
        {
            if (page1Vis == false)
            {
                lblNewCharacter.Visible = true;
                lblName.Visible = true;
                lblRace.Visible = true;
                lblClass.Visible = true;
                lblBackground.Visible = true;
                lblStr.Visible = true;
                lblDex.Visible = true;
                lblCon.Visible = true;
                lblInt.Visible = true;
                lblWis.Visible = true;
                lblCha.Visible = true;
                txtName.Visible = true;
                cboRace.Visible = true;
                cboClass.Visible = true;
                cboBackground.Visible = true;
                txtStr.Visible = true;
                txtStrMod.Visible = true;
                txtDex.Visible = true;
                txtDexMod.Visible = true;
                txtCha.Visible = true;
                txtChaMod.Visible = true;
                txtCon.Visible = true;
                txtConMod.Visible = true;
                txtInt.Visible = true;
                txtIntMod.Visible = true;
                txtWis.Visible = true;
                txtWisMod.Visible = true;
                btnRollStats.Visible = true;
                btnSaveTest.Visible = true;
                rtxtDescription.Visible = true;
                page1Vis = true;
            }
            else
            {
                lblNewCharacter.Visible = false;
                lblName.Visible = false;
                lblRace.Visible = false;
                lblClass.Visible = false;
                lblBackground.Visible = false;
                lblStr.Visible = false;
                lblDex.Visible = false;
                lblCon.Visible = false;
                lblInt.Visible = false;
                lblWis.Visible = false;
                lblCha.Visible = false;
                txtName.Visible = false;
                cboRace.Visible = false;
                cboClass.Visible = false;
                cboBackground.Visible = false;
                txtStr.Visible = false;
                txtStrMod.Visible = false;
                txtDex.Visible = false;
                txtDexMod.Visible = false;
                txtCha.Visible = false;
                txtChaMod.Visible = false;
                txtCon.Visible = false;
                txtConMod.Visible = false;
                txtInt.Visible = false;
                txtIntMod.Visible = false;
                txtWis.Visible = false;
                txtWisMod.Visible = false;
                btnRollStats.Visible = false;
                btnSaveTest.Visible = false;
                page1Vis = false;
            }
            
            
        }
        public void toggleVisP2()
        {
            
            lblEquip.Visible = true;
            lbEquip1.Visible = true;
            
            rtxtDescription.Clear();
            
            foreach(Ability ab in newChar.charClass.classAbilities.Ability)
            {
                if (ab.lvl == 1&& ab.subChoice == true)
                {
                    lblSub.Visible = true;
                    lbSub.Visible = true;
                    foreach (string subclass in newChar.charClass.Subclass)
                    {
                        lbSub.Items.Add(subclass);
                    }
                }
                else if (ab.lvl == 1 && ab.fightChoice == true)
                {
                    lblSub.Visible = true;
                    lbSub.Visible = true;
                    lblSub.Text = "Fighting Style";
                    //Add Fighting styles here when needed
                }
            }
            foreach(string equip in newChar.charClass.EquipmentChoice1)
            {
                lbEquip1.Items.Add(equip);
            }
            if (newChar.charClass.EquipmentChoice2.Count() != 0)
            {
                lbEquip2.Visible = true;
                foreach (string equip in newChar.charClass.EquipmentChoice2)
                {
                    lbEquip2.Items.Add(equip);
                }
            }
            if (newChar.charClass.EquipmentChoice3.Count() != 0)
            {
                lbEquip3.Visible = true;
                foreach (string equip in newChar.charClass.EquipmentChoice3)
                {
                    lbEquip3.Items.Add(equip);
                }
            }
            if (newChar.charClass.EquipmentChoice4.Count() != 0)
            {
                lbEquip4.Visible = true;
                foreach (string equip in newChar.charClass.EquipmentChoice4)
                {
                    lbEquip4.Items.Add(equip);
                }
            }
            displayChar();
        }
        public void displayChar()
        {
            string CharTxt = string.Format("Name: {0}\nRace: {1}\nClass: {2}\nBackground: {3}\n", newChar.charName, newChar.charRace.raceName, newChar.charClass.className, newChar.charBack.backName);
            int index = 0;
            foreach(int stat in newChar.charStats)
            {
                switch (index)
                {
                    case 0:
                        CharTxt = CharTxt + "Str: " + stat.ToString() + "|";
                        break;
                    case 1:
                        CharTxt = CharTxt + "Dex: " + stat.ToString() + "|";
                        break;
                    case 2:
                        CharTxt = CharTxt + "Con: " + stat.ToString() + "|";
                        break;
                    case 3:
                        CharTxt = CharTxt + "Int: " + stat.ToString() + "|";
                        break;
                    case 4:
                        CharTxt = CharTxt + "Wis: " + stat.ToString() + "|";
                        break;
                    case 5:
                        CharTxt = CharTxt + "Cha: " + stat.ToString();
                        break;
                }
                index++;
            }
            index = 0;
            CharTxt = CharTxt + "\n";
            foreach (int mod in newChar.charStatMod)
            {
                switch (index)
                {
                    case 0:
                        CharTxt = CharTxt + "Str Mod: " + mod.ToString() + "|";
                        break;
                    case 1:
                        CharTxt = CharTxt + "Dex Mod: " + mod.ToString() + "|";
                        break;
                    case 2:
                        CharTxt = CharTxt + "Con Mod: " + mod.ToString() + "|";
                        break;
                    case 3:
                        CharTxt = CharTxt + "Int Mod: " + mod.ToString() + "|";
                        break;
                    case 4:
                        CharTxt = CharTxt + "Wis Mod: " + mod.ToString() + "|";
                        break;
                    case 5:
                        CharTxt = CharTxt + "Cha Mod: " + mod.ToString();
                        break;
                }
                index++;
            }
            CharTxt = CharTxt + "\n---------------------------";
            CharTxt = CharTxt + "\nRace Traits:";
            foreach (string rTrait in newChar.charRace.raceAbilities)
            {
                CharTxt += "\n" + rTrait; 
            }
            CharTxt = CharTxt + "\n---------------------------";
            CharTxt = CharTxt + "\nClass Starting Abilities:";
            foreach (Ability ab in newChar.charAbilities)
            {
                CharTxt += "\n" + ab.name + "\n" + ab.descrip + "\n---------";
            }
            CharTxt = CharTxt + "------------------";
            CharTxt = CharTxt + "\nBackground Feature: \n" + newChar.charBack.feature;
            
            rtxtDescription.Text = CharTxt;
        }
    }
}
