namespace Unite_BuildDisplay
{
    public class Preset
    {
        public Preset(int i, string n, int hi1, int hi2, int hi3, int sp, int bi)
        {
            this.id = i;
            this.name = n;
            this.held_item_1 = hi1;
            this.held_item_2 = hi2;
            this.held_item_3 = hi3;
            this.selected_pokemon = sp;
            this.battle_item = bi;
        }
        public int id { get; set; }
        public string name {  get; set; }
        public int held_item_1 { get; set; }
        public int held_item_2 { get; set; }
        public int held_item_3 { get; set; }
        public int selected_pokemon { get; set; }
        public int battle_item { get; set; }
    }
}
