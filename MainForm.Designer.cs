﻿namespace Unite_BuildDisplay
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.heldItemsList = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pokemonList = new System.Windows.Forms.ImageList(this.components);
            this.battleItemsList = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageList = this.heldItemsList;
            this.button1.Location = new System.Drawing.Point(12, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "Held Item 1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // heldItemsList
            // 
            this.heldItemsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("heldItemsList.ImageStream")));
            this.heldItemsList.TransparentColor = System.Drawing.Color.Magenta;
            this.heldItemsList.Images.SetKeyName(0, "Aeos+Cookie.jpg");
            this.heldItemsList.Images.SetKeyName(1, "Assault+Vest.jpg");
            this.heldItemsList.Images.SetKeyName(2, "Attack+Weight.jpg");
            this.heldItemsList.Images.SetKeyName(3, "Buddy+Barrier.jpg");
            this.heldItemsList.Images.SetKeyName(4, "Charging+Charm.png");
            this.heldItemsList.Images.SetKeyName(5, "Choice+Specs.jpg");
            this.heldItemsList.Images.SetKeyName(6, "Curse+Bangle.png");
            this.heldItemsList.Images.SetKeyName(7, "Curse+Incense.png");
            this.heldItemsList.Images.SetKeyName(8, "Drain+Crown.jpg");
            this.heldItemsList.Images.SetKeyName(9, "Energy+Amplifier.jpg");
            this.heldItemsList.Images.SetKeyName(10, "Exp+Share.jpg");
            this.heldItemsList.Images.SetKeyName(11, "Float+Stone.jpg");
            this.heldItemsList.Images.SetKeyName(12, "Focus+Band.jpg");
            this.heldItemsList.Images.SetKeyName(13, "Leftovers.jpg");
            this.heldItemsList.Images.SetKeyName(14, "Muscle+Band.jpg");
            this.heldItemsList.Images.SetKeyName(15, "Rapid+Fire+Scarf.jpg");
            this.heldItemsList.Images.SetKeyName(16, "Razor+Claw.jpg");
            this.heldItemsList.Images.SetKeyName(17, "Rocky+Helmet.jpg");
            this.heldItemsList.Images.SetKeyName(18, "Rescue+Hood.jpg");
            this.heldItemsList.Images.SetKeyName(19, "Resonant+Guard.png");
            this.heldItemsList.Images.SetKeyName(20, "Rusted+Sword.jpg");
            this.heldItemsList.Images.SetKeyName(21, "Scope+Lens.jpg");
            this.heldItemsList.Images.SetKeyName(22, "Score+Shield.jpg");
            this.heldItemsList.Images.SetKeyName(23, "Shell+Bell.jpg");
            this.heldItemsList.Images.SetKeyName(24, "Slick+Spoon.jpg");
            this.heldItemsList.Images.SetKeyName(25, "Special+Attack+Specs.jpg");
            this.heldItemsList.Images.SetKeyName(26, "Weakness+Policy.jpg");
            this.heldItemsList.Images.SetKeyName(27, "Wise+Glasses.jpg");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ImageList = this.heldItemsList;
            this.button2.Location = new System.Drawing.Point(93, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 4;
            this.button2.Text = "Held Item 2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ImageList = this.heldItemsList;
            this.button3.Location = new System.Drawing.Point(176, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 5;
            this.button3.Text = "Held Item 3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.ImageList = this.pokemonList;
            this.button4.Location = new System.Drawing.Point(12, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 156);
            this.button4.TabIndex = 1;
            this.button4.Text = "Change Pokemon";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // pokemonList
            // 
            this.pokemonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pokemonList.ImageStream")));
            this.pokemonList.TransparentColor = System.Drawing.Color.Transparent;
            this.pokemonList.Images.SetKeyName(0, "absol.jpg");
            this.pokemonList.Images.SetKeyName(1, "aegislash.jpg");
            this.pokemonList.Images.SetKeyName(2, "azumarill.jpg");
            this.pokemonList.Images.SetKeyName(3, "blastoise.jpg");
            this.pokemonList.Images.SetKeyName(4, "blaziken.jpg");
            this.pokemonList.Images.SetKeyName(5, "blissey.jpg");
            this.pokemonList.Images.SetKeyName(6, "buzzwole.jpg");
            this.pokemonList.Images.SetKeyName(7, "chandelure.jpg");
            this.pokemonList.Images.SetKeyName(8, "charizard.jpg");
            this.pokemonList.Images.SetKeyName(9, "cinderace.jpg");
            this.pokemonList.Images.SetKeyName(10, "clefable.jpg");
            this.pokemonList.Images.SetKeyName(11, "comfey.jpg");
            this.pokemonList.Images.SetKeyName(12, "cramorant.jpg");
            this.pokemonList.Images.SetKeyName(13, "crustle.jpg");
            this.pokemonList.Images.SetKeyName(14, "decidueye.jpg");
            this.pokemonList.Images.SetKeyName(15, "delphox.jpg");
            this.pokemonList.Images.SetKeyName(16, "dodrio.jpg");
            this.pokemonList.Images.SetKeyName(17, "dragapult.jpg");
            this.pokemonList.Images.SetKeyName(18, "dragonite.jpg");
            this.pokemonList.Images.SetKeyName(19, "duraludon.jpg");
            this.pokemonList.Images.SetKeyName(20, "eldegoss.jpg");
            this.pokemonList.Images.SetKeyName(21, "espeon.jpg");
            this.pokemonList.Images.SetKeyName(22, "garchomp.jpg");
            this.pokemonList.Images.SetKeyName(23, "gardevoir.jpg");
            this.pokemonList.Images.SetKeyName(24, "gengar.jpg");
            this.pokemonList.Images.SetKeyName(25, "glaceon.jpg");
            this.pokemonList.Images.SetKeyName(26, "goodra.jpg");
            this.pokemonList.Images.SetKeyName(27, "greedent.jpg");
            this.pokemonList.Images.SetKeyName(28, "greninja.jpg");
            this.pokemonList.Images.SetKeyName(29, "hoopa.jpg");
            this.pokemonList.Images.SetKeyName(30, "inteleon.jpg");
            this.pokemonList.Images.SetKeyName(31, "lapras.jpg");
            this.pokemonList.Images.SetKeyName(32, "leafeon.jpg");
            this.pokemonList.Images.SetKeyName(33, "lucario.jpg");
            this.pokemonList.Images.SetKeyName(34, "machamp.jpg");
            this.pokemonList.Images.SetKeyName(35, "mamoswine.jpg");
            this.pokemonList.Images.SetKeyName(36, "meowscarada.jpg");
            this.pokemonList.Images.SetKeyName(37, "metagross.jpg");
            this.pokemonList.Images.SetKeyName(38, "mew.jpg");
            this.pokemonList.Images.SetKeyName(39, "mewtwo_x.jpg");
            this.pokemonList.Images.SetKeyName(40, "mewtwo_y.jpg");
            this.pokemonList.Images.SetKeyName(41, "mimikyu.jpg");
            this.pokemonList.Images.SetKeyName(42, "mr. mime.jpg");
            this.pokemonList.Images.SetKeyName(43, "ninetails.jpg");
            this.pokemonList.Images.SetKeyName(44, "pikachu.jpg");
            this.pokemonList.Images.SetKeyName(45, "sableye.jpg");
            this.pokemonList.Images.SetKeyName(46, "scizor.jpg");
            this.pokemonList.Images.SetKeyName(47, "slowbro.jpg");
            this.pokemonList.Images.SetKeyName(48, "snorlax.jpg");
            this.pokemonList.Images.SetKeyName(49, "sylveon.jpg");
            this.pokemonList.Images.SetKeyName(50, "talonflame.jpg");
            this.pokemonList.Images.SetKeyName(51, "trevenant.jpg");
            this.pokemonList.Images.SetKeyName(52, "tsareena.jpg");
            this.pokemonList.Images.SetKeyName(53, "tyranitar.jpg");
            this.pokemonList.Images.SetKeyName(54, "umbreon.jpg");
            this.pokemonList.Images.SetKeyName(55, "urshifu.jpg");
            this.pokemonList.Images.SetKeyName(56, "venusaur.jpg");
            this.pokemonList.Images.SetKeyName(57, "wigglytuff.jpg");
            this.pokemonList.Images.SetKeyName(58, "zacian.jpg");
            this.pokemonList.Images.SetKeyName(59, "zeraora.jpg");
            this.pokemonList.Images.SetKeyName(60, "zoroark.jpg");
            // 
            // battleItemsList
            // 
            this.battleItemsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("battleItemsList.ImageStream")));
            this.battleItemsList.TransparentColor = System.Drawing.Color.Transparent;
            this.battleItemsList.Images.SetKeyName(0, "Eject+Button.jpg");
            this.battleItemsList.Images.SetKeyName(1, "Fluffy+Tail.jpg");
            this.battleItemsList.Images.SetKeyName(2, "Full+Heal.jpg");
            this.battleItemsList.Images.SetKeyName(3, "Goal+Getter.jpg");
            this.battleItemsList.Images.SetKeyName(4, "Potion.jpg");
            this.battleItemsList.Images.SetKeyName(5, "Slow+Smoke.jpg");
            this.battleItemsList.Images.SetKeyName(6, "X+Attack.jpg");
            this.battleItemsList.Images.SetKeyName(7, "X+Speed.jpg");
            this.battleItemsList.Images.SetKeyName(8, "Shedinja+Doll.png");
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.ImageList = this.battleItemsList;
            this.button5.Location = new System.Drawing.Point(176, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 2;
            this.button5.Text = "Battle Item";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(115, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pokemon UNITE Build Display";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(229, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 11);
            this.label2.TabIndex = 7;
            this.label2.Text = "by vec";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 6.5F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(8, 8);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.presetsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 27);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackgroundColorToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            this.changeBackgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.magentaToolStripMenuItem});
            this.changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            this.changeBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.changeBackgroundColorToolStripMenuItem.Text = "Change Background Color";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // magentaToolStripMenuItem
            // 
            this.magentaToolStripMenuItem.Name = "magentaToolStripMenuItem";
            this.magentaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.magentaToolStripMenuItem.Text = "Magenta";
            this.magentaToolStripMenuItem.Click += new System.EventHandler(this.magentaToolStripMenuItem_Click);
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPresetToolStripMenuItem});
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.presetsToolStripMenuItem.Text = "Presets";
            // 
            // addNewPresetToolStripMenuItem
            // 
            this.addNewPresetToolStripMenuItem.Name = "addNewPresetToolStripMenuItem";
            this.addNewPresetToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addNewPresetToolStripMenuItem.Text = "Add New Preset...";
            this.addNewPresetToolStripMenuItem.Click += new System.EventHandler(this.addNewPresetToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::Unite_BuildDisplay.Properties.Resources.background_small;
            this.ClientSize = new System.Drawing.Size(263, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "UNITE Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList heldItemsList;
        private System.Windows.Forms.ImageList battleItemsList;
        private System.Windows.Forms.ImageList pokemonList;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPresetToolStripMenuItem;
    }
}

