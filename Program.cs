﻿using System.Text;

List<Page> pages = new List<Page>();
Page PageVariabler = new Page(MyNotes.PageVariabler1);
Page PageDatatyper = new Page(MyNotes.PageDatatyper);
Page PageDatatyper2 = new Page(MyNotes.PageDatatyper2);
Page PageArrays = new Page(MyNotes.PageArrays);
Page PageArrays2 = new Page(MyNotes.PageArrays2);
Page PageLister = new Page("Lister");
Page PageLoops = new Page("Loops");
Page PageMethods = new Page("Methods");
Page PageClasses = new Page("Classes");

pages.Add(PageVariabler);
pages.Add(PageDatatyper);
pages.Add(PageDatatyper2);
pages.Add(PageArrays);
pages.Add(PageArrays2);
pages.Add(PageLister);
pages.Add(PageLoops);
pages.Add(PageMethods);
pages.Add(PageClasses);

Chapter Variabler = new Chapter("Variabler");
Variabler.Pages.Add(PageVariabler);
Chapter Datatyper = new Chapter("Datatyper");
Datatyper.Pages.Add(PageDatatyper);
Datatyper.Pages.Add(PageDatatyper2);
Chapter Arrays = new Chapter("Arrays");
Arrays.Pages.Add(PageArrays);
Arrays.Pages.Add(PageArrays2);
Chapter Lister = new Chapter("Lister");
Lister.Pages.Add(PageLister);
Chapter Loops = new Chapter("Loops");
Loops.Pages.Add(PageLoops);
Chapter Methods = new Chapter("Methods");
Methods.Pages.Add(PageMethods);
Chapter Classes = new Chapter("Classes");
Classes.Pages.Add(PageClasses);

List<Chapter> Chapters = new List<Chapter>();
Chapters.Add(Variabler);
Chapters.Add(Datatyper);
Chapters.Add(Arrays);
Chapters.Add(Lister);
Chapters.Add(Loops);
Chapters.Add(Methods);
Chapters.Add(Classes);

Book mybook = new Book("Programmerings noter", Chapters);

mybook.Start();

// Pause to keep the console window open
Console.ReadLine();