List<Page> pages = new List<Page>();
Page PageVariabler = new Page("Min første side");
Page PageDatatyper = new Page("Min side 2");
Page PageArrays = new Page("Min side 3");
Page PageLister = new Page("Min side 3");
Page PageLoops = new Page("Min side 3");
Page PageMethods = new Page("Min side 3");
Page PageClasses = new Page("Min side 3");

pages.Add(PageVariabler);
pages.Add(PageDatatyper);
pages.Add(PageArrays);
pages.Add(PageLister);
pages.Add(PageLoops);
pages.Add(PageMethods);
pages.Add(PageClasses);

Chapter Variabler = new Chapter("Variabler");
Variabler.Pages = pages;
Chapter Datatyper = new Chapter("Datatyper", pages);
Chapter Arrays = new Chapter("Arrays", pages);
Chapter Lister = new Chapter("Lister", pages);
Chapter Loops = new Chapter("Loops", pages);
Chapter Methods = new Chapter("Methods", pages);
Chapter Classes = new Chapter("Classes", pages);

List<Chapter> Chapters = new List<Chapter>();
Chapters.Add(Variabler);
Chapters.Add(Datatyper);
Chapters.Add(Arrays);
Chapters.Add(Lister);
Chapters.Add(Loops);
Chapters.Add(Methods);
Chapters.Add(Classes);


Book mybook = new Book("Programmerings noter", Chapters);

//pause
Console.ReadLine();

mybook.Start();