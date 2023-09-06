public static class MyNotes
{

public static string PageVariabler1 =
@"...
Variabler i C# er navngivne opbevaringssteder, der bruges til at gemme og manipulere data i et program. 
De tillader programmører at arbejde med værdier af forskellige typer, såsom heltal, decimaltal, tekst og objekter.";

public static string PageDatatyper =
@"
Datatyper i C# definerer typen af data, som en variabel kan indeholde. De bestemmer, hvordan data skal
fortolkes, lagres og behandles i programmet. C# har to hovedkategorier af datatyper: værdityper (value types) og
reference datatyper (reference types).
";

public static string PageDatatyper2 =
@"
Her er nogle eksempler på datatyper i C-sharp:
______________________________________________

String:
Datatypen string indeholder linjer med tekst.

Integer / Int:
Dataypen Int indeholder hele tal.

Float:
Dataypen float indeholder kommatal med 6-9 decimaler.

Bool:
Datatypen bool indeholder true or false / sandt eller falsk.
";

public static string PageArrays =
@"
I C# er et array en samling af elementer af samme datatyper, der er arrangeret i en sekvens 
og identificeret ved hjælp af indekser. Arrays giver dig mulighed for at gemme flere værdier af samme type
under et enkelt navn og manipulere dem ved hjælp af indekser.";

public static string PageArrays2 =
@"
Her er nogle grundlæggende oplysninger om Arrays i C-Sharp:
___________________________________________________________
1. Deklaration og initialisering
Du kan deklarere et array ved at angive dets datatyper og navn, efterfulgt af []-parenteser. 
For eksempel: int[] numbers; deklarerer et array af heltal.

Du kan også initialisere et array samtidig med deklarationen ved at angive dets elementer i {}-klammer. 
For eksempel: int[] numbers = { 1, 2, 3, 4, 5 }; initialiserer et array med fem heltal.


2. Adgang til elementer
Elementerne i et array kan tilgås ved hjælp af indekser, der starter med 0 for det første element. 
For eksempel: int firstNumber = numbers[0]; vil hente det første element (1) fra arrayet.


3. Længde og Indeksgrænser
Du kan få længden af et array ved at bruge Length-egenskaben. For eksempel: int length = numbers.Length; 
giver dig antallet af elementer i arrayet.

Det er vigtigt at være opmærksom på indeksgrænserne. Hvis du forsøger at tilgå et element uden for de gyldige indeks, 
vil det resultere i en IndexOutOfRangeException.


4. Ændring af elementer
Du kan ændre værdien af et element i et array ved at tildele en ny værdi til det. For eksempel: numbers[0] = 42; ændrer det første element til 42.


5. Iteration gennem et Array
Du kan bruge løkker som for eller foreach til at gennemgå alle elementer i et array og udføre operationer på dem.
";

public static string PageLister =
@"
I C# er en liste (List) en dynamisk samling af elementer, der kan vokse eller formindskes i størrelse efter behov. 
Lister er en del af .NET Framework-klassen System.Collections.Generic og er meget nyttige, når du har brug for at gemme en 
samling af elementer, som du ikke kender størrelsen på på forhånd. Her er nogle grundlæggende oplysninger om lister i C#:
";

public static string PageLister2 =
@"
Her er nogle grundlæggende oplysninger om Arrays i C-Sharp:
___________________________________________________________
1. Deklaration og initialisering:
Du kan deklarere og initialisere en liste ved at bruge List<T>-klassen, hvor T repræsenterer typen af elementer, 
du vil gemme i listen. For eksempel: List<int> numbers = new List<int>(); opretter en tom liste af heltal.

2. Tilføjelse af Elementer:
Du kan tilføje elementer til listen ved hjælp af Add-metoden. For eksempel: numbers.Add(42); tilføjer 
tallet 42 til listen.

3. Fjernelse af Elementer:
Du kan fjerne elementer fra listen ved hjælp af Remove-metoden ved at angive værdien, der skal fjernes. 
For eksempel: numbers.Remove(42); fjerner den første forekomst af værdien 42 fra listen.

4. Indeksadgang:
Elementer i en liste kan tilgås ved hjælp af indekser på samme måde som i et array. For eksempel: 
int firstNumber = numbers[0]; giver dig det første element i listen.

5. Længde:
Længden af en liste kan fås ved at bruge Count-egenskaben. For eksempel: int count = numbers.Count; 
giver dig antallet af elementer i listen.

Her et eksempel på brug af en liste:
List<string> names = new List<string>();
names.Add('Alice');
names.Add('Bob');
names.Add('Charlie');

foreach (string name in names)
{
    Console.WriteLine(name);
}

int count = names.Count;
Console.WriteLine('Total names:  count');
";

public static string PageLoops =
@"
I C# (og i de fleste programmeringssprog) bruges loops til at udføre gentagne handlinger eller en 
blok af kode flere gange. Dette er nyttigt, når du ønsker at automatisere gentagne opgaver eller 
behandle en række data. Der er forskellige typer løkker i C#, inklusive for, while, do-while, 
og foreach. Her er en forklaring på hver type:
";

public static string PageLoops2 =
@"
Her er nogle grundlæggende oplysninger om Arrays i C-Sharp:
___________________________________________________________
1. For-loops
Et for-loop bruges til at udføre en blok kode et bestemt antal gange.
Du angiver normalt en tæller, en betingelse for fortsættelse og en opdatering af tælleren.

Eksempel:
For (int i = 0; i < 5; i++)
{
    Console.Writeline(i);
}


2. While-loops
Et While-loop udfører en blok kode, så længe en betingelse er sand.
Betingelsen evalueres før udførelsen af blokken.

Eksempel:
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}


3. Do-While-loops
Et do-while-loop udfører en blok kode mindst én gang, og derefter gentager den, så længe en betingelse er sand.
Betingelsen evalueres efter udførelsen af blokken.

Eksempel:
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 5);


4. Foreach-loop
Et foreach-loop bruges til at gennemgå elementer i en samling (f.eks. et array eller en liste).
Den er særligt nyttig, når du ikke har brug for at spore indekserne, men kun vil arbejde med elementerne.

Eksempel:
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int num in numbers)
{
    Console.WriteLine(num);
}

5. Break og Continue
Du kan bruge break til at afslutte et loop tidligt, hvis en bestemt betingelse er opfyldt.

continue bruges til at springe den aktuelle iteration over og gå videre til næste iteration af loop.
}
";

public static string PageMethods =
@"
I C# bruges metoder til at organisere og udføre opgaver i en struktureret og genbrugelig måde. 
Metoder er en central del af objektorienteret programmering og hjælper med at opdele komplekse 
opgaver i mindre, håndterbare dele. Her er en forklaring på, hvad metoder er, og hvordan de fungerer i C#:
";

public static string PageMethods2 =
@"
Her er nogle grundlæggende oplysninger om Methods i C-Sharp:
___________________________________________________________
1. Metode Definition:
En metode i C# er en blok kode, der udfører en bestemt opgave eller handling. Du definerer en 
metode ved at angive dens navn, returtype, og eventuelle parametre den tager.

Her er en simpel metodedefinition:
public int Add(int a, int b)
{
    int sum = a + b;
    return sum;
}
I dette eksempel er 'Add' metoden, der tager to heltal som parametre og returnerer et 
heltal (summen af de to tal).

2. Metodekald:
For at udføre en metode skal du kalde den ved at bruge dens navn og eventuelle nødvendige argumenter.

Eksempel på metodekald:
int result = Add(5, 3);

Her kaldes 'Add' metoden med argumenterne 5 og 3, og resultatet gemmes i variablen 'result.'

3. Returtype:

Hver metode har en returtype, der angiver, hvilken type data metoden returnerer. Hvis metoden 
ikke returnerer nogen værdi, bruger du 'void' som returtype.
I eksemplet ovenfor har 'Add' metoden en returtype 'int,' fordi den returnerer et heltal.

4. Parametre:
Metoder kan tage nul eller flere parametre, som er værdier eller objekter, der sendes til 
metoden for at udføre dens opgave.
Parametre angives i parenteserne efter metodenavnet.

Eksempel:
public void PrintMessage(string message)
{
    Console.WriteLine(message);
}

Her tager 'PrintMessage' metoden en parameter af typen 'string' kaldet 'message.''

5. Return Statement:
Hvis en metode har en returtype, skal den indeholde et 'return' statement for at returnere 
en værdi af den påkrævede type.

Eksempel:
public int Multiply(int x, int y)
{
    return x * y;
}
Her returnerer 'Multiply' metoden produktet af de to inputværdier.

Modifierer:

Du kan tilføje forskellige modifierer til metode definitionen for at styre dens synlighed og adgangsniveau. Fælles modifierer 
inkluderer 'public,'' 'private,' 'protected,' og 'internal.'
";


public static string PageClasses = 
@"
I C# er en klasse en grundlæggende byggesten i objektorienteret programmering (OOP). En klasse fungerer som en skabelon eller en blåtryk, 
der definerer, hvordan objekter oprettes og fungerer. Her er en forklaring på, hvad klasser er, og hvordan de fungerer i C#:

";

public static string PageClasses2 =
@"
Her er nogle grundlæggende oplysninger om Classes i C-Sharp:
___________________________________________________________
1.  class definition 
En klasse i C# er en brugerdefineret datatype, der definerer egenskaber (felter) og metoder (funktioner).
Du definerer en klasse ved at bruge nøgleordet class efterfulgt af klasseens navn.

Eksempel på klassedefinition:
public class Person
{
    // Egenskaber (felter)
    public string Name;
    public int Age;

    // Metoder
    public void SayHello()
    {
        Console.WriteLine('Hello, my name is' + Name);
    }

}


2. Objekter
Når du har defineret en klasse, kan du oprette objekter (instanser) af den klasse. 
Et objekt er en konkret forekomst af en klasse, der indeholder specifikke data og kan udføre metoder, 
der er defineret i klassen.

Eksempel på objekter:
Person person1 = new Person();
person1.Name = 'Alice';
person1.Age = 30;


3. Egenskaber
En klasse definerer ofte egenskaber (felter), der beskriver tilstanden eller attributterne for objekterne.
I eksemplet ovenfor har 'Person' klassen to egenskaber: 'Name' og 'Age.'


4. Metoder
En klasse indeholder også metoder, der beskriver, hvad objekter af klassen kan gøre.
I eksemplet ovenfor har 'Person' klassen en metode kaldet 'SayHello,' der udskriver en hilsen med personens navn.


5. Adgangsniveauer
Du kan kontrollere adgangsniveauet for klassens medlemmer ved hjælp af nøgleord som public, private, protected, og internal.
For eksempel kan du angive, om en egenskab skal være offentligt tilgængelig (public) eller kun tilgængelig inden for klassen (private).


6. Constructers
En klasse kan have en konstruktør, der bruges til at initialisere objekter, når de oprettes.

Eksempel på en konstruktør:
public Person(string name, int age)
{
    Name = name;
    Age = age;
}


7. Arv og OOP-koncepter
Klasser i C# understøtter OOP-koncepter som arv, polymorfi og abstrakte klasser, 
hvilket gør det muligt at opbygge hierarkier af klasser og dele fælles funktionalitet.
";
}
