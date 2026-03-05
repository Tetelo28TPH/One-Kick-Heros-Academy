using One_Kick_Heroes_Academy.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Kick_Heroes_Academy.DataLayer
{
    internal static class DataManager
    {
        public static List<SuperHero> Heroes { get; private set; } = new List<SuperHero>();

        // ✅ Load heroes from file
        public static void LoadData()
        {
            Heroes = FileHandler.LoadSuperhero();
        }

        // ✅ Save heroes back to file
        public static void SaveData()
        {
            FileHandler.SaveSuperhero(Heroes);
        }

        // ✅ Refresh any DataGridView with current list
        public static void RefreshGrid(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = Heroes;
        }

        // ✅ Search by Hero ID
        public static List<SuperHero> SearchById(string id)
        {
            return Heroes.FindAll(h => h.HeroID.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        // ✅ Optional: Search by name
        public static List<SuperHero> SearchByName(string name)
        {
            return Heroes.FindAll(h => h.Name.ToLower().Contains(name.ToLower()));
        }
    }
}

