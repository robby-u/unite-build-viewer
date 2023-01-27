using System;
using System.Drawing;
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
            this.menuStrip1.ForeColor = Color.White;

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
    }
}
