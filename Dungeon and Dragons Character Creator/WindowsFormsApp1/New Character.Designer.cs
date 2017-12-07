namespace WindowsFormsApp1
{
    partial class New_Character
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNewCharacter = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblBackground = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblWis = new System.Windows.Forms.Label();
            this.lblCha = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboRace = new System.Windows.Forms.ComboBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboBackground = new System.Windows.Forms.ComboBox();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtWis = new System.Windows.Forms.TextBox();
            this.txtCha = new System.Windows.Forms.TextBox();
            this.btnRollStats = new System.Windows.Forms.Button();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtChaMod = new System.Windows.Forms.TextBox();
            this.txtWisMod = new System.Windows.Forms.TextBox();
            this.txtIntMod = new System.Windows.Forms.TextBox();
            this.txtConMod = new System.Windows.Forms.TextBox();
            this.txtDexMod = new System.Windows.Forms.TextBox();
            this.txtStrMod = new System.Windows.Forms.TextBox();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.lbEquip4 = new System.Windows.Forms.ListBox();
            this.lbEquip3 = new System.Windows.Forms.ListBox();
            this.lbEquip2 = new System.Windows.Forms.ListBox();
            this.lbEquip1 = new System.Windows.Forms.ListBox();
            this.lblEquip = new System.Windows.Forms.Label();
            this.lbSub = new System.Windows.Forms.ListBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblSkillChoices = new System.Windows.Forms.Label();
            this.clbSkillChoices = new System.Windows.Forms.CheckedListBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewCharacter
            // 
            this.lblNewCharacter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewCharacter.AutoSize = true;
            this.lblNewCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCharacter.Location = new System.Drawing.Point(129, 9);
            this.lblNewCharacter.Name = "lblNewCharacter";
            this.lblNewCharacter.Size = new System.Drawing.Size(231, 37);
            this.lblNewCharacter.TabIndex = 0;
            this.lblNewCharacter.Text = "New Character";
            this.lblNewCharacter.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(133, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblRace
            // 
            this.lblRace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(133, 96);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 2;
            this.lblRace.Text = "Race";
            this.lblRace.Visible = false;
            // 
            // lblClass
            // 
            this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(133, 122);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Class";
            this.lblClass.Visible = false;
            // 
            // lblBackground
            // 
            this.lblBackground.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBackground.AutoSize = true;
            this.lblBackground.Location = new System.Drawing.Point(100, 151);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(65, 13);
            this.lblBackground.TabIndex = 4;
            this.lblBackground.Text = "Background";
            this.lblBackground.Visible = false;
            // 
            // lblStr
            // 
            this.lblStr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(138, 174);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(20, 13);
            this.lblStr.TabIndex = 5;
            this.lblStr.Text = "Str";
            this.lblStr.Visible = false;
            // 
            // lblDex
            // 
            this.lblDex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(171, 174);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(26, 13);
            this.lblDex.TabIndex = 6;
            this.lblDex.Text = "Dex";
            this.lblDex.Visible = false;
            // 
            // lblCon
            // 
            this.lblCon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(204, 174);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(26, 13);
            this.lblCon.TabIndex = 7;
            this.lblCon.Text = "Con";
            this.lblCon.Visible = false;
            // 
            // lblInt
            // 
            this.lblInt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(237, 174);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(19, 13);
            this.lblInt.TabIndex = 8;
            this.lblInt.Text = "Int";
            this.lblInt.Visible = false;
            // 
            // lblWis
            // 
            this.lblWis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(263, 174);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(25, 13);
            this.lblWis.TabIndex = 9;
            this.lblWis.Text = "Wis";
            this.lblWis.Visible = false;
            // 
            // lblCha
            // 
            this.lblCha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCha.AutoSize = true;
            this.lblCha.Location = new System.Drawing.Point(295, 174);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(26, 13);
            this.lblCha.TabIndex = 10;
            this.lblCha.Text = "Cha";
            this.lblCha.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(174, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 20);
            this.txtName.TabIndex = 11;
            this.txtName.Visible = false;
            // 
            // cboRace
            // 
            this.cboRace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboRace.FormattingEnabled = true;
            this.cboRace.Location = new System.Drawing.Point(172, 93);
            this.cboRace.Name = "cboRace";
            this.cboRace.Size = new System.Drawing.Size(121, 21);
            this.cboRace.Sorted = true;
            this.cboRace.TabIndex = 12;
            this.cboRace.Visible = false;
            this.cboRace.SelectedIndexChanged += new System.EventHandler(this.cboRace_SelectedIndexChanged);
            // 
            // cboClass
            // 
            this.cboClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(172, 122);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 21);
            this.cboClass.Sorted = true;
            this.cboClass.TabIndex = 13;
            this.cboClass.Visible = false;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // cboBackground
            // 
            this.cboBackground.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboBackground.FormattingEnabled = true;
            this.cboBackground.Location = new System.Drawing.Point(171, 149);
            this.cboBackground.Name = "cboBackground";
            this.cboBackground.Size = new System.Drawing.Size(121, 21);
            this.cboBackground.Sorted = true;
            this.cboBackground.TabIndex = 14;
            this.cboBackground.Visible = false;
            this.cboBackground.SelectedIndexChanged += new System.EventHandler(this.cboBackground_SelectedIndexChanged);
            // 
            // txtStr
            // 
            this.txtStr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStr.Location = new System.Drawing.Point(140, 192);
            this.txtStr.MaxLength = 2;
            this.txtStr.Name = "txtStr";
            this.txtStr.ReadOnly = true;
            this.txtStr.Size = new System.Drawing.Size(22, 20);
            this.txtStr.TabIndex = 15;
            this.txtStr.Visible = false;
            // 
            // txtDex
            // 
            this.txtDex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDex.Location = new System.Drawing.Point(173, 192);
            this.txtDex.MaxLength = 2;
            this.txtDex.Name = "txtDex";
            this.txtDex.ReadOnly = true;
            this.txtDex.Size = new System.Drawing.Size(22, 20);
            this.txtDex.TabIndex = 16;
            this.txtDex.Visible = false;
            // 
            // txtCon
            // 
            this.txtCon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCon.Location = new System.Drawing.Point(206, 192);
            this.txtCon.MaxLength = 2;
            this.txtCon.Name = "txtCon";
            this.txtCon.ReadOnly = true;
            this.txtCon.Size = new System.Drawing.Size(22, 20);
            this.txtCon.TabIndex = 17;
            this.txtCon.Visible = false;
            // 
            // txtInt
            // 
            this.txtInt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInt.Location = new System.Drawing.Point(236, 192);
            this.txtInt.MaxLength = 2;
            this.txtInt.Name = "txtInt";
            this.txtInt.ReadOnly = true;
            this.txtInt.Size = new System.Drawing.Size(22, 20);
            this.txtInt.TabIndex = 18;
            this.txtInt.Visible = false;
            // 
            // txtWis
            // 
            this.txtWis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWis.Location = new System.Drawing.Point(265, 192);
            this.txtWis.MaxLength = 2;
            this.txtWis.Name = "txtWis";
            this.txtWis.ReadOnly = true;
            this.txtWis.Size = new System.Drawing.Size(22, 20);
            this.txtWis.TabIndex = 19;
            this.txtWis.Visible = false;
            // 
            // txtCha
            // 
            this.txtCha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCha.Location = new System.Drawing.Point(293, 192);
            this.txtCha.MaxLength = 2;
            this.txtCha.Name = "txtCha";
            this.txtCha.ReadOnly = true;
            this.txtCha.Size = new System.Drawing.Size(22, 20);
            this.txtCha.TabIndex = 20;
            this.txtCha.Visible = false;
            // 
            // btnRollStats
            // 
            this.btnRollStats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRollStats.Location = new System.Drawing.Point(320, 190);
            this.btnRollStats.Name = "btnRollStats";
            this.btnRollStats.Size = new System.Drawing.Size(75, 23);
            this.btnRollStats.TabIndex = 21;
            this.btnRollStats.Text = "Reroll";
            this.btnRollStats.UseVisualStyleBackColor = true;
            this.btnRollStats.Visible = false;
            this.btnRollStats.Click += new System.EventHandler(this.btnRollStats_Click);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDescription.Location = new System.Drawing.Point(12, 241);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.Size = new System.Drawing.Size(490, 173);
            this.rtxtDescription.TabIndex = 22;
            this.rtxtDescription.Text = "";
            this.rtxtDescription.Visible = false;
            // 
            // txtChaMod
            // 
            this.txtChaMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChaMod.Location = new System.Drawing.Point(293, 215);
            this.txtChaMod.MaxLength = 2;
            this.txtChaMod.Name = "txtChaMod";
            this.txtChaMod.ReadOnly = true;
            this.txtChaMod.Size = new System.Drawing.Size(22, 20);
            this.txtChaMod.TabIndex = 28;
            this.txtChaMod.Visible = false;
            // 
            // txtWisMod
            // 
            this.txtWisMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWisMod.Location = new System.Drawing.Point(265, 215);
            this.txtWisMod.MaxLength = 2;
            this.txtWisMod.Name = "txtWisMod";
            this.txtWisMod.ReadOnly = true;
            this.txtWisMod.Size = new System.Drawing.Size(22, 20);
            this.txtWisMod.TabIndex = 27;
            this.txtWisMod.Visible = false;
            // 
            // txtIntMod
            // 
            this.txtIntMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIntMod.Location = new System.Drawing.Point(236, 215);
            this.txtIntMod.MaxLength = 2;
            this.txtIntMod.Name = "txtIntMod";
            this.txtIntMod.ReadOnly = true;
            this.txtIntMod.Size = new System.Drawing.Size(22, 20);
            this.txtIntMod.TabIndex = 26;
            this.txtIntMod.Visible = false;
            // 
            // txtConMod
            // 
            this.txtConMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConMod.Location = new System.Drawing.Point(206, 215);
            this.txtConMod.MaxLength = 2;
            this.txtConMod.Name = "txtConMod";
            this.txtConMod.ReadOnly = true;
            this.txtConMod.Size = new System.Drawing.Size(22, 20);
            this.txtConMod.TabIndex = 25;
            this.txtConMod.Visible = false;
            // 
            // txtDexMod
            // 
            this.txtDexMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDexMod.Location = new System.Drawing.Point(173, 215);
            this.txtDexMod.MaxLength = 2;
            this.txtDexMod.Name = "txtDexMod";
            this.txtDexMod.ReadOnly = true;
            this.txtDexMod.Size = new System.Drawing.Size(22, 20);
            this.txtDexMod.TabIndex = 24;
            this.txtDexMod.Visible = false;
            // 
            // txtStrMod
            // 
            this.txtStrMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStrMod.Location = new System.Drawing.Point(140, 215);
            this.txtStrMod.MaxLength = 2;
            this.txtStrMod.Name = "txtStrMod";
            this.txtStrMod.ReadOnly = true;
            this.txtStrMod.Size = new System.Drawing.Size(22, 20);
            this.txtStrMod.TabIndex = 23;
            this.txtStrMod.Visible = false;
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Location = new System.Drawing.Point(322, 215);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTest.TabIndex = 29;
            this.btnSaveTest.Text = "Save Test";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Visible = false;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // lbEquip4
            // 
            this.lbEquip4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEquip4.FormattingEnabled = true;
            this.lbEquip4.Location = new System.Drawing.Point(387, 131);
            this.lbEquip4.Name = "lbEquip4";
            this.lbEquip4.Size = new System.Drawing.Size(120, 95);
            this.lbEquip4.TabIndex = 36;
            this.lbEquip4.Visible = false;
            // 
            // lbEquip3
            // 
            this.lbEquip3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEquip3.FormattingEnabled = true;
            this.lbEquip3.Location = new System.Drawing.Point(261, 131);
            this.lbEquip3.Name = "lbEquip3";
            this.lbEquip3.Size = new System.Drawing.Size(120, 95);
            this.lbEquip3.TabIndex = 35;
            this.lbEquip3.Visible = false;
            // 
            // lbEquip2
            // 
            this.lbEquip2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEquip2.FormattingEnabled = true;
            this.lbEquip2.Location = new System.Drawing.Point(135, 131);
            this.lbEquip2.Name = "lbEquip2";
            this.lbEquip2.Size = new System.Drawing.Size(120, 95);
            this.lbEquip2.TabIndex = 34;
            this.lbEquip2.Visible = false;
            // 
            // lbEquip1
            // 
            this.lbEquip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEquip1.FormattingEnabled = true;
            this.lbEquip1.Location = new System.Drawing.Point(9, 131);
            this.lbEquip1.Name = "lbEquip1";
            this.lbEquip1.Size = new System.Drawing.Size(120, 95);
            this.lbEquip1.TabIndex = 33;
            this.lbEquip1.Visible = false;
            // 
            // lblEquip
            // 
            this.lblEquip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEquip.AutoSize = true;
            this.lblEquip.Location = new System.Drawing.Point(9, 115);
            this.lblEquip.Name = "lblEquip";
            this.lblEquip.Size = new System.Drawing.Size(98, 13);
            this.lblEquip.TabIndex = 32;
            this.lblEquip.Text = "Equipment Choices";
            this.lblEquip.Visible = false;
            // 
            // lbSub
            // 
            this.lbSub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSub.FormattingEnabled = true;
            this.lbSub.Location = new System.Drawing.Point(9, 17);
            this.lbSub.Name = "lbSub";
            this.lbSub.Size = new System.Drawing.Size(120, 95);
            this.lbSub.TabIndex = 31;
            this.lbSub.Visible = false;
            // 
            // lblSub
            // 
            this.lblSub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(12, 1);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(50, 13);
            this.lblSub.TabIndex = 30;
            this.lblSub.Text = "Subclass";
            this.lblSub.Visible = false;
            // 
            // lblSkillChoices
            // 
            this.lblSkillChoices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSkillChoices.AutoSize = true;
            this.lblSkillChoices.Location = new System.Drawing.Point(334, 1);
            this.lblSkillChoices.Name = "lblSkillChoices";
            this.lblSkillChoices.Size = new System.Drawing.Size(35, 13);
            this.lblSkillChoices.TabIndex = 55;
            this.lblSkillChoices.Text = "label1";
            this.lblSkillChoices.Visible = false;
            // 
            // clbSkillChoices
            // 
            this.clbSkillChoices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clbSkillChoices.CheckOnClick = true;
            this.clbSkillChoices.FormattingEnabled = true;
            this.clbSkillChoices.Location = new System.Drawing.Point(387, 15);
            this.clbSkillChoices.Name = "clbSkillChoices";
            this.clbSkillChoices.Size = new System.Drawing.Size(120, 94);
            this.clbSkillChoices.TabIndex = 56;
            this.clbSkillChoices.Visible = false;
            this.clbSkillChoices.SelectedIndexChanged += new System.EventHandler(this.clbSkillChoices_SelectedIndexChanged);
            // 
            // lblSelected
            // 
            this.lblSelected.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(384, 112);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(82, 13);
            this.lblSelected.TabIndex = 57;
            this.lblSelected.Text = "Skills Selected: ";
            this.lblSelected.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(285, 79);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 59;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // New_Character
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(514, 426);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.clbSkillChoices);
            this.Controls.Add(this.lblSkillChoices);
            this.Controls.Add(this.lbEquip4);
            this.Controls.Add(this.lbEquip3);
            this.Controls.Add(this.lbEquip2);
            this.Controls.Add(this.lbEquip1);
            this.Controls.Add(this.lblEquip);
            this.Controls.Add(this.lbSub);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.btnSaveTest);
            this.Controls.Add(this.txtChaMod);
            this.Controls.Add(this.txtWisMod);
            this.Controls.Add(this.txtIntMod);
            this.Controls.Add(this.txtConMod);
            this.Controls.Add(this.txtDexMod);
            this.Controls.Add(this.txtStrMod);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.btnRollStats);
            this.Controls.Add(this.txtCha);
            this.Controls.Add(this.txtWis);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtDex);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.cboBackground);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.cboRace);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCha);
            this.Controls.Add(this.lblWis);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.lblBackground);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNewCharacter);
            this.Name = "New_Character";
            this.Text = "Create New Character";
            this.Load += new System.EventHandler(this.New_Character_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewCharacter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboRace;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboBackground;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtWis;
        private System.Windows.Forms.TextBox txtCha;
        private System.Windows.Forms.Button btnRollStats;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtChaMod;
        private System.Windows.Forms.TextBox txtWisMod;
        private System.Windows.Forms.TextBox txtIntMod;
        private System.Windows.Forms.TextBox txtConMod;
        private System.Windows.Forms.TextBox txtDexMod;
        private System.Windows.Forms.TextBox txtStrMod;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.ListBox lbEquip4;
        private System.Windows.Forms.ListBox lbEquip3;
        private System.Windows.Forms.ListBox lbEquip2;
        private System.Windows.Forms.ListBox lbEquip1;
        private System.Windows.Forms.Label lblEquip;
        private System.Windows.Forms.ListBox lbSub;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblSkillChoices;
        private System.Windows.Forms.CheckedListBox clbSkillChoices;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}