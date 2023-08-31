List<Page> pages = new List<Page>();
Page page1 = new Page("Min første side");
Page page2 = new Page("Min side 2");
Page page3 = new Page("Min side 3");

pages.Add(page1);
pages.Add(page2);
pages.Add(page3);

Chapter Variabler = new Chapter("Kapitel 1");
Variabler.Pages = pages;
Chapter Datatyper = new Chapter("Kapitel 2", pages);

Variabler.Read();
Datatyper.Read();

List<Chapter> Chapters = new List<Chapter>();
Chapters.Add(Variabler);
Chapters.Add(Datatyper);

Book mybook = new Book("Programmerings noter", Chapters);

//pause
Console.ReadLine();

Book.Start();