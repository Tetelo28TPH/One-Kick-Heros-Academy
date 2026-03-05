# One-Kick-Heros-Academy
The Superhero Database System is a C# Windows Forms group project developed for Programming 2782. It manages trainee hero records for One Kick Heroes Academy, calculating ranks and threat levels from exam scores. I was responsible for View.cs, editing hero details, and managing the data layer.
****Features****

**Add New Superhero**
Users can enter superhero details through a form interface including:
Hero ID
Name
Age
Superpower
Exam Score
The system automatically calculates:
Hero Rank
Threat Level
All records are saved to superheroes.txt.

**View All Superheroes**
All stored superheroes are displayed in a DataGridView, showing:
Hero ID
Name
Age
Superpower
Exam Score
Rank
Threat Level
The data is loaded directly from superheroes.txt

**Update Superhero Information**
Users can:
Select a hero from the DataGridView
Edit their information
Update exam scores
The system automatically recalculates the rank and threat level before saving the updated data.

**Delete a Superhero**
Users can select a superhero from the DataGridView and delete their record from the system.
The corresponding entry is removed from superheroes.txt.

**Generate Summary Report**
The system generates statistics including:
Total number of superheroes
Average hero age
Average exam score
Number of heroes per rank (S, A, B, C)
The results are displayed in the application and saved to summary.txt.
