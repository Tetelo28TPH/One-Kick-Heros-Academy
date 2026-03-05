using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using One_Kick_Heroes_Academy.BusinessLogicLayer;
using System.Windows.Forms;

namespace One_Kick_Heroes_Academy.DataLayer
{
    internal class FileHandler
    {
        private static readonly string Filepath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "superheroes.txt");

        public static List<SuperHero> LoadSuperhero()
        {
            var list = new List<SuperHero>();
            if (File.Exists(Filepath))
            {
                foreach (var line in File.ReadAllLines(Filepath))
                {
                    if (!string.IsNullOrWhiteSpace(line))
                        list.Add(SuperHero.FromFile(line));
                }
            }
            return list;
        }

        public static void SaveSuperhero(List<SuperHero> heroes)
        {
            var lines = heroes.Select(h => h.ToString()).ToArray();
            File.WriteAllLines(Filepath, lines);
        }
    }
}
