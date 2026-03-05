using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Kick_Heroes_Academy.BusinessLogicLayer
{
    internal class SuperHero
    {
        public string HeroID { get;  set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string SuperPower { get; set; }
        public double ExamScore { get; set; }
        public string Rank { get; set; }
        public string ThreatLevel { get; set; }

        // --- Constructors ---
        public SuperHero() { }

        public SuperHero( string ID,string name, int age, string Superpower, double score )
        { 
            HeroID = ID;
            Name = name;
            Age = age;
            SuperPower = Superpower;
            ExamScore = score;
            calcThreatLevelAndRank(); // auto calculate rank & threat level
        }

        
        // 🧠 Business logic: recalculate rank & threat level
        public void calcThreatLevelAndRank()
        {
            // Calculate Rank
            if (ExamScore >= 81 && ExamScore <= 100)
                Rank = "S-Rank";
            else if (ExamScore >= 61)
                Rank = "ARank";
            else if (ExamScore >= 41)
                Rank = "B-Rank";
            else
                Rank = "C-Rank";

            // Calculate ThreatLevel
            if (ExamScore < 50)
                ThreatLevel = "Low";
            else if (ExamScore < 70)
                ThreatLevel = "Medium";
            else if (ExamScore < 90)
                ThreatLevel = "High";
            else
                ThreatLevel = "Critical";
        }

        // 🧾 Read from CSV-style line
        public static SuperHero FromFile(string line)
        {
            try
            {
                var parts = line.Split(',');

                if (parts.Length < 6)
                    throw new FormatException("Line format invalid. Expected 6 parts: HeroID,Name,Age, SuperPower, ExamScore,Rank,ThreatLevel");

                return new SuperHero
                {
                    HeroID = parts[0],
                    Name = parts[1],
                    Age = int.Parse(parts[2]),
                    SuperPower = parts[3],
                    ExamScore = double.Parse(parts[4]),
                    Rank = parts[5],
                    ThreatLevel = parts[6]
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading hero from file: {ex.Message}");
                return null;
            }
        }

        // 📝 Convert to CSV string for saving
        public override string ToString()
        {
            return $"{HeroID},{Name},{Age},{SuperPower},{ExamScore},{Rank},{ThreatLevel}";
        }
    }
}
