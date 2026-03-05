using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using One_Kick_Heroes_Academy.BusinessLogicLayer;
using System.Windows.Forms;

namespace One_Kick_Heroes_Academy.DataLayer
{  internal class FileHandler
        {
            private static readonly string Filepath =
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "superheroes.txt");

            // ---------- Laura's style static methods (kept) ----------
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

  

            public void Add(SuperHero hero)
            {
                var heroes = LoadSuperhero();
                // avoid duplicate IDs
                if (heroes.Any(h => h.HeroID.Equals(hero.HeroID, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Hero ID already exists. Add cancelled.", "Duplicate ID",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                heroes.Add(hero);
                SaveSuperhero(heroes);
            }

            public void Update(SuperHero updatedHero)
            {
                var heroes = LoadSuperhero();
                var existing = heroes.FirstOrDefault(h => h.HeroID.Equals(updatedHero.HeroID, StringComparison.OrdinalIgnoreCase));
                if (existing != null)
                {
                    // update fields
                    existing.Name = updatedHero.Name;
                    existing.Age = updatedHero.Age;
                    existing.SuperPower = updatedHero.SuperPower;
                    existing.ExamScore = updatedHero.ExamScore;
                //the method repsonsible for calulating the rank and threat level also need to be called with the new exam score
                 existing.Caller(existing.ExamScore);

                    SaveSuperhero(heroes);
                }
                else
                {
                    MessageBox.Show("Hero not found. Update cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            public void Delete(string heroId)
            {
                var heroes = LoadSuperhero();
                var existing = heroes.FirstOrDefault(h => h.HeroID.Equals(heroId, StringComparison.OrdinalIgnoreCase));
                if (existing != null)
                {
                    heroes.Remove(existing);
                    SaveSuperhero(heroes);
                }
                else
                {
                    MessageBox.Show("Hero not found. Delete cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // The original code called handler.formatLines() to get an enumerable/list of heroes.
            public List<SuperHero> formatLines()
            {
                return LoadSuperhero();
            }
            public SummaryReport Calculations()
            {
                var heroes = LoadSuperhero();
                var report = new SummaryReport();

                if (heroes.Count == 0)
                {
                    report.NumberOfHeroes = 0;
                    report.AverageAge = 0;
                    report.AverageScore = 0;
                    report.S_RankCount = 0;
                    report.A_RankCount = 0;
                    report.B_RankCount = 0;
                    report.C_RankCount = 0;
                    return report;
                }

                report.NumberOfHeroes = heroes.Count;
                report.AverageAge = (int)heroes.Average(h => h.Age);
                report.AverageScore = heroes.Average(h => h.ExamScore);

                // Assuming Rank is a string property on SuperHero and possible values include "S", "A", "B", "C"
                report.S_RankCount = heroes.Count(h => string.Equals(h.Rank, "S", StringComparison.OrdinalIgnoreCase));
                report.A_RankCount = heroes.Count(h => string.Equals(h.Rank, "A", StringComparison.OrdinalIgnoreCase));
                report.B_RankCount = heroes.Count(h => string.Equals(h.Rank, "B", StringComparison.OrdinalIgnoreCase));
                report.C_RankCount = heroes.Count(h => string.Equals(h.Rank, "C", StringComparison.OrdinalIgnoreCase));

                return report;
            
            }
            

        }
    }


