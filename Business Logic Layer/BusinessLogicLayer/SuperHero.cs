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
        public SuperHero(string heroID, string name, int age, string superPower, double examScore)
        {
            HeroID = heroID;
            Name = name;
            Age = age;
            SuperPower = superPower;
            ExamScore = examScore;
            //Rank = CalculateRank(examScore);
            //ThreatLevel = DetermineThreatLevel(examScore);
        }

        private string CalculateRank(double score)
        {
            if (score >= 81 && score <= 100)
            {
                return "S";
            }
            else if (score >= 61 && score <= 80)
            {
                return "A";
            }
            else if (score >= 41 && score <= 60)
            {
                return "B";
            }
            else if (score >= 0 && score <= 40)
            {
                return "C";
            }
            else
            {
                return $"Score: {score} is out of interval scale. Please re-enter score.";
            }
        }
        // 🧠 Business logic: recalculate rank & threat level
        private string DetermineThreatLevel(double score)
        {

            if (score >= 81 && score <= 100)
            {
                return "Finals Week";
            }
            else if (score >= 61 && score <= 80)
            {
                return "Midterm Madness";
            }
            else if (score >= 41 && score <= 60)
            {
                return "Group Project Gone Wrong";
            }
            else if (score >= 0 && score <= 40)
            {
                return "Pop Quiz";
            }
            else
            {
                return $"Score: {score}, is out of interval scale. Please re-enter score ";
            }

        }
    
         //since the method of calculating rank and threat level are private, a caller method will be created. This way both methods can be re-used throught the program
         public void Caller(double score)
        {
          ThreatLevel =DetermineThreatLevel(score);
           Rank = CalculateRank(score);


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
