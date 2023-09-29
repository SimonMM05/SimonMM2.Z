using System.Collections.Generic; // Importerer navnerummet for List<T>.
using System.IO; // Importerer navnerummet for fil- og mappeoperationer.

string dataDirectory = "Book_data"; // Definerer en strengvariabel med navnet dataDirectory og initialiserer den med stien til mappen "Book_data".

List<Chapter> chapters = ReadChaptersFromDirectory(dataDirectory); // Opretter en liste af Chapter-objekter ved at kalde ReadChaptersFromDirectory-funktionen med dataDirectory som argument.

Book mybook = new Book("Programmerings noter", chapters); // Opretter en instans af Book-klassen med titlen "Programmerings noter" og listen over kapitler.

mybook.Start(); // Kalder metoden Start på mybook-objektet.

List<Chapter> ReadChaptersFromDirectory(string directoryPath) // Definerer en funktion med navnet ReadChaptersFromDirectory, der tager en sti til en mappe som argument og returnerer en liste af Chapter-objekter.
{
    List<Chapter> chapters = new List<Chapter>(); // Opretter en tom liste til at gemme Chapter-objekter.

    if (Directory.Exists(directoryPath)) // Tjekker om den angivne directoryPath eksisterer.
    {
        string[] chapterDirectories = Directory.GetDirectories(directoryPath); // Får en liste af stier til undermapper inden for directoryPath.

        foreach (string chapterDir in chapterDirectories) // Gennemløber hver undermappe.
        {
            string chapterName = Path.GetFileName(chapterDir); // Udtrækker navnet på undermappen (kapitelnavnet).
            Chapter chapter = new Chapter(chapterName); // Opretter et nyt Chapter-objekt med det udtrukne kapitelnavn.

            string[] pageFiles = Directory.GetFiles(chapterDir, "*.txt"); // Får en liste af filstier med filtypen ".txt" inden for den aktuelle kapitelmappe.

            foreach (string pageFile in pageFiles) // Gennemløber hver sidefil.
            {
                string pageContent = File.ReadAllText(pageFile); // Læser indholdet af sidefilen.
                chapter.Pages.Add(new Page(pageContent)); // Opretter et nyt Page-objekt med sideindholdet og tilføjer det til kapitlets Pages-liste.
            }

            chapters.Add(chapter); // Tilføjer kapitlet (med dets sider) til listen over kapitler.
        }
    }

    return chapters; // Returnerer listen over kapitler.
}
