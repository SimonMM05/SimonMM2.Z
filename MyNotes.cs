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
Selvfølgelig! I C# er et array en samling af elementer af samme datatyper, der er arrangeret i en sekvens 
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

}

