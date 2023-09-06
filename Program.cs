using System.Collections.Generic;
using System.IO;


    string dataDirectory = "Book_data";
    List<Chapter> chapters = ReadChaptersFromDirectory(dataDirectory);

    Book mybook = new Book("Programmerings noter", chapters);
    mybook.Start();



List<Chapter> ReadChaptersFromDirectory(string directoryPath)
{
    List<Chapter> chapters = new List<Chapter>();

    if (Directory.Exists(directoryPath))
    {
        string[] chapterDirectories = Directory.GetDirectories(directoryPath);

        foreach (string chapterDir in chapterDirectories)
        {
            string chapterName = Path.GetFileName(chapterDir);
            Chapter chapter = new Chapter(chapterName);

            string[] pageFiles = Directory.GetFiles(chapterDir, "*.txt");

            foreach (string pageFile in pageFiles)
            {
                string pageContent = File.ReadAllText(pageFile);
                chapter.Pages.Add(new Page(pageContent));
            }

            chapters.Add(chapter);
        }
    }

    return chapters;
}
