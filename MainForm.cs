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

        // Change Held Item 1
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = "";
            if (held_item_1+1 < resized_heldItemList.Images.Count)
            {
                held_item_1++;
            }
            else
            {
                held_item_1 = 0;
            }
            this.button1.BackgroundImage = resized_heldItemList.Images[held_item_1];
        }

        // Change Held Item 2
        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Text = "";
            if (held_item_2 + 1 < resized_heldItemList.Images.Count)
            {
                held_item_2++;
            }
            else
            {
                held_item_2 = 0;
            }
            this.button2.BackgroundImage = resized_heldItemList.Images[held_item_2];
        }

        // Change Held Item 3
        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Text = "";
            if (held_item_3 + 1 < resized_heldItemList.Images.Count)
            {
                held_item_3++;
            }
            else
            {
                held_item_3 = 0;
            }
            this.button3.BackgroundImage = resized_heldItemList.Images[held_item_3];
        }

        // Change Pokemon
        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.Text = "";
            if (selected_pokemon + 1 < resized_pokemonList.Images.Count)
            {
                selected_pokemon++;
            }
            else
            {
                selected_pokemon = 0;
            }

            this.button4.BackgroundImage = resized_pokemonList.Images[selected_pokemon];
        }

        // Changle Battle Item
        private void button5_Click(object sender, EventArgs e)
        {
            this.button5.Text = "";
            if (battle_item + 1 < resized_battleItemList.Images.Count)
            {
                battle_item++;
            }
            else
            {
                battle_item= 0;
            }
            this.button5.BackgroundImage = resized_battleItemList.Images[battle_item];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            resized_heldItemList = resizedImageList(heldItemsList, 96, 96);
            resized_pokemonList = resizedImageList(pokemonList, 144, 144);
            resized_battleItemList = resizedImageList(battleItemsList, 96, 96);
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;

        }
    }
}
