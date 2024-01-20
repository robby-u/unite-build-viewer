using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Unite_BuildDisplay
{
    public partial class MainForm : Form
    {
        int held_item_1 = -1;
        int held_item_2 = -1;
        int held_item_3 = -1;

        int selected_pokemon = -1;

        int battle_item = -1;

        ImageList resized_heldItemList = null;
        ImageList resized_battleItemList = null;
        ImageList resized_pokemonList = null;

        List<Preset> saved_presets = new List<Preset>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            resized_heldItemList = resizedImageList(heldItemsList, 96, 96);
            resized_pokemonList = resizedImageList(pokemonList, 144, 144);
            resized_battleItemList = resizedImageList(battleItemsList, 96, 96);
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;

            this.menuStrip1.BackColor = Color.Transparent;
            this.settingsToolStripMenuItem.BackColor = Color.Transparent;
            this.presetsToolStripMenuItem.BackColor = Color.Transparent;
            
            this.menuStrip1.ForeColor = Color.White;

            DatabaseHelper.Initialize();
            saved_presets = DatabaseHelper.LoadPresets();

            foreach(Preset p in saved_presets)
            {
                ToolStripMenuItem presetItem = new ToolStripMenuItem($"{p.name}");
                presetItem.AccessibleName = $"{p.id}";
                presetItem.Name = p.name;
                presetItem.Click += PresetItem_Click;

                presetsToolStripMenuItem.DropDownItems.Add(presetItem);
            }
        }

        private void updateUI()
        {
            if (held_item_1 >= 0) this.button1.BackgroundImage = resized_heldItemList.Images[held_item_1];
            else this.button1.BackgroundImage = null;
            if (held_item_2 >= 0) this.button2.BackgroundImage = resized_heldItemList.Images[held_item_2];
            else this.button2.BackgroundImage = null;
            if (held_item_3 >= 0) this.button3.BackgroundImage = resized_heldItemList.Images[held_item_3];
            else this.button3.BackgroundImage = null;
            if (selected_pokemon >= 0) this.button4.BackgroundImage = resized_pokemonList.Images[selected_pokemon];
            else this.button4.BackgroundImage = null;
            if (battle_item >= 0) this.button5.BackgroundImage = resized_battleItemList.Images[battle_item];
            else this.button5.BackgroundImage = null;
        }

        private ImageList resizedImageList(ImageList passedImageList, int Width, int Height)
        {
            ImageList largeImageList = new ImageList();
            largeImageList.ColorDepth = ColorDepth.Depth32Bit;
            largeImageList.ImageSize = new Size(Width, Height); //actual size of image
            foreach (Image i in passedImageList.Images)
                largeImageList.Images.Add(i);

            ListView listView = new ListView();
            listView.LargeImageList = largeImageList;
            return listView.LargeImageList;
        }

        private void setFormColor(Color color)
        {
            this.BackColor = color;
            this.button1.BackColor = color;
            this.button2.BackColor = color;
            this.button3.BackColor = color;
            this.button4.BackColor = color;
            this.button5.BackColor = color;
        }

        // Change Held Item 1
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.button1.Text = "";
            if(e.Button == MouseButtons.Left)
            {
                if (held_item_1 + 1 < resized_heldItemList.Images.Count) held_item_1++;
                else held_item_1 = 0;
            }
            if(e.Button == MouseButtons.Right)
            {
                if (held_item_1 - 1 >= 0) held_item_1--;
                // we have to subtract 1 because our collection of images starts at zero
                else held_item_1 = resized_heldItemList.Images.Count - 1;
            }
            this.button1.BackgroundImage = resized_heldItemList.Images[held_item_1];
        }

        // Change Held Item 2
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            this.button2.Text = "";
            if (e.Button == MouseButtons.Left)
            {
                if (held_item_2 + 1 < resized_heldItemList.Images.Count) held_item_2++;
                else held_item_2 = 0;
            }
            if (e.Button == MouseButtons.Right)
            {
                if (held_item_2 - 1 >= 0) held_item_2--;
                else held_item_2 = resized_heldItemList.Images.Count - 1;
            }
            this.button2.BackgroundImage = resized_heldItemList.Images[held_item_2];
        }

        // Change Held Item 3
        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            this.button3.Text = "";
            if (e.Button == MouseButtons.Left)
            {
                if (held_item_3 + 1 < resized_heldItemList.Images.Count) held_item_3++;
                else held_item_3 = 0;
            }
            if (e.Button == MouseButtons.Right)
            {
                if (held_item_3 - 1 >= 0) held_item_3--;
                else held_item_3 = resized_heldItemList.Images.Count - 1;
            }
            this.button3.BackgroundImage = resized_heldItemList.Images[held_item_3];
        }

        // Change Pokemon
        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            this.button4.Text = "";
            if (e.Button == MouseButtons.Left)
            {
                if (selected_pokemon + 1 < resized_pokemonList.Images.Count) selected_pokemon++;
                else selected_pokemon = 0;
            }
            if (e.Button == MouseButtons.Right)
            {
                if (selected_pokemon - 1 >= 0) selected_pokemon--;
                else selected_pokemon = resized_pokemonList.Images.Count - 1;
            }
            this.button4.BackgroundImage = resized_pokemonList.Images[selected_pokemon];
        }

        // Change Battle Item
        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            this.button5.Text = "";

            if (e.Button == MouseButtons.Left)
            {
                if (battle_item + 1 < resized_battleItemList.Images.Count) battle_item++;
                else battle_item = 0;
            }

            if (e.Button == MouseButtons.Right)
            {
                if (battle_item - 1 >= 0) battle_item--;
                else battle_item = resized_battleItemList.Images.Count - 1;
            }
            this.button5.BackgroundImage = resized_battleItemList.Images[battle_item];
        }

        // Default screen background
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background_small;
            setFormColor(Color.DarkSlateBlue);
        }

        // Green screen background
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            setFormColor(Color.Lime);
        }

        // Blue screen background
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            setFormColor(Color.Blue);
        }

        // Pink screen background
        private void magentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            setFormColor(Color.Magenta);
        }

        private void addNewPresetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string prompt = Interaction.InputBox("Enter a name for this preset:", "UNITE Viewer");
            if (string.IsNullOrWhiteSpace(prompt)) return;

            Preset new_preset = new Preset(saved_presets.Count, prompt.ToString(), this.held_item_1, this.held_item_2,
                this.held_item_3, this.selected_pokemon, this.battle_item);

            ToolStripMenuItem presetItem = new ToolStripMenuItem($"{prompt}");
            presetItem.AccessibleName = $"Preset #{saved_presets.Count}";
            presetItem.Name = $"{prompt}";
            presetItem.Click += PresetItem_Click;

            saved_presets.Add(new_preset);
            presetsToolStripMenuItem.DropDownItems.Add(presetItem);
            DatabaseHelper.SavePreset(new_preset);
            
        }

        private void PresetItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            Match match = Regex.Match(clickedItem.AccessibleName, @"\d+$");

            if (match.Success)
            {
                int index = Convert.ToInt32(match.Value);
                Preset selected_preset = saved_presets[index];
                Name = selected_preset.name;
                held_item_1 = selected_preset.held_item_1;
                held_item_2 = selected_preset.held_item_2;
                held_item_3 = selected_preset.held_item_3;
                selected_pokemon = selected_preset.selected_pokemon;
                battle_item = selected_preset.battle_item;
            }

            updateUI();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int padding = 10; // Adjust this value based on your preference

            // Calculate the new size for the buttons based on the form size
            int buttonWidth = (this.ClientSize.Width - 4 * padding) / 3; // 3 buttons with 2 paddings between them
            int buttonHeight = (this.ClientSize.Height - 5 * padding) / 2; // 2 buttons with 4 paddings between them

            // Update button sizes
            button1.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            button2.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            button3.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            button4.Size = new System.Drawing.Size(2 * buttonWidth + padding, 2 * buttonHeight + padding);
            button5.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            // Update button positions
            button1.Location = new Point(padding, this.ClientSize.Height - buttonHeight - padding);
            button2.Location = new Point(2 * padding + buttonWidth, this.ClientSize.Height - buttonHeight - padding);
            button3.Location = new Point(3 * padding + 2 * buttonWidth, this.ClientSize.Height - buttonHeight - padding);
            button4.Location = new Point(padding, padding);
            button5.Location = new Point(3 * padding + 2 * buttonWidth, padding);
        }
    }
}
