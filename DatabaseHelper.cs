using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Unite_BuildDisplay
{
    public static class DatabaseHelper
    {
        private const string connectionString = "Data Source=Presets.db;Version=3;";
        public static void Initialize()
        {
            using(var connection=new SQLiteConnection(connectionString))
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Presets (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    HeldItem1 INTEGER,
                    HeldItem2 INTEGER,
                    HeldItem3 INTEGER,
                    SelectedPokemon INTEGER,
                    BattleItem INTEGER
                    );
                  ";
                cmd.ExecuteNonQuery();
            }
        }
        public static void SavePreset(Preset p)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO Presets (Name, HeldItem1, HeldItem2, HeldItem3, SelectedPokemon, BattleItem)
                    VALUES (@Name, @HeldItem1, @HeldItem2, @HeldItem3, @SelectedPokemon, @BattleItem);
                ";
                cmd.Parameters.AddWithValue("@Name", p.name);
                cmd.Parameters.AddWithValue("@HeldItem1", p.held_item_1);
                cmd.Parameters.AddWithValue("@HeldItem2", p.held_item_2);
                cmd.Parameters.AddWithValue("@HeldItem3", p.held_item_3);
                cmd.Parameters.AddWithValue("@SelectedPokemon", p.selected_pokemon);
                cmd.Parameters.AddWithValue("@BattleItem", p.battle_item);

                cmd.ExecuteNonQuery();
            }
        }
        public static List<Preset> LoadPresets()
        {
            var presets = new List<Preset>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Presets";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var preset = new Preset(Convert.ToInt32(reader["Id"]),
                            reader["Name"].ToString(),
                            Convert.ToInt32(reader["HeldItem1"]),
                            Convert.ToInt32(reader["HeldItem2"]),
                            Convert.ToInt32(reader["HeldItem3"]),
                            Convert.ToInt32(reader["SelectedPokemon"]),
                            Convert.ToInt32(reader["BattleItem"]));
                        presets.Add(preset);
                    }
                }
            }
            return presets;
        }
    }
}
