/*                  // <--- Start
 * Dieses Programm soll als Hilfestellung dienen um die IDE Rider bzw. den allgemeinen Syntax zu verstehen.
 *
 *  <---- Dies ist eine Möglichkeit über mehrere Zeilen zu Kommentieren.
 *
 */ // <--- Ende

// <---- Dies ist eine Möglichkeit nur eine Zeile zu kommenttieren, alles ab // wird Kommentiert. 


//  Definition Variablen      

int
    age = 10; // int Die Werte des Datentyps "int" sind die ganzen Zahlen im Bereich von "-2147483648" bis "2147483647". (Die größte und kleinste Zahl des Datentyps "int" ist die Konstante "Integer.
bool
    isLightOn = true; // Boolean ist in Programmiersprachen der Datentyp für Wahrheitswerte. Der Datentyp boolean kann entweder den Wert wahr (entspricht in dem binären Wert 1) oder falsch (entspricht dem binären Wert 0) annehmen.
string
    name = "HTK Academy"; // Ein “string” ist ein Datentyp in der Programmierung, der eine Zeichenkette enthält. Zeichenketten werden verwendet, um Wörter, Sätze und Texte zu speichern.
float price = 0.99f; // Gleitkommazahl, Datentyp zum Speichern von Kommazahlen.


// Zusätzliche Datentypen

double
    reallyBigNumber =
        99; //Ein Double enthält doppelt so viele Bits wie eine normale Gleitkommazahl (float). Ein Double kann 64 Bit enthalten und positiv (+) oder negativ (-) sein. Wird aber selten verwendet.


//übungs Variablen
int a, b;
int balance;


//  Funktionen Aufrufe

/* Um eine Funktion aufzurufen:
 * FunktionsName(Mitgegebene Variable1, Mitgegebene Variable2, ...);
 *
 * In unserem Fall:
 * Say(Variable);
 *
 * Variable sollte in unserem Fall dem Datentyp string entsprechen, dazu weiter unten
 * Beispiele bzw. erklärung zu den Schreibweisen weiter unten.
 *
 * Say(age); funktioniert nicht, da age ein INT ist und kein String.
 * deswegen:
 */


int
    example = 42; // Mann kann das auch hier initialisieren, jedoch ist dies nicht "schön" nur so machen wenn man weiß was man macht. 
Say(example.ToString()); //.ToString() wandelt die Variable in das Format String um, damit dieser auch als Text ausgegeben werden kann.


Say("Integer: " + age); // Hier ist eine Kombination aus Roher information und einer Variable. In diesem Falle, ist es nicht notwendig .toString() hinzuzufügen

Say("Boolean: " +
    isLightOn); // "xxxx" ist eine andere art der Dateneingabe. Hier wird der String direkt mithilfe von "" eingegeben.

Say("String: " + name); // Das "+" hängt die Texte zusammen

Say("Float: " + price);

Say("Double: " + reallyBigNumber);


//------------------------------------------------------------ 
//Übung:

a = 10; //Hier wird der Wert 5 in die Variable a gespeichert
b = 5; //Hier wird der Wert 8 in die Variable b gespeichert

AddInts(a, b); //hier wird die Funktion AddInts aufgerufen und es werden die Variablen a & b weitergegeben
SubtractInts(a, b);
MultiplayInts(a, b);
DivideInts(a, b);

//------------------------------------------------------------ 
//Übung:
balance = 150; //<-- Hier dein Bankkontostand eingeben. Danke!
Rich(balance);


//Test
Rich(-50);
Rich(50);
Rich(150); //Schreibweise möglich, aber unüblich (Nebeneinander, getrennt mit ;

//------------------------------------------------------------ 
//Übung:
HightestNumOfTwo(a, b);


//  Funktion Definitionen


/*@ToDo Das ist eine Möglichkeit um darzustellen was noch gemacht gehört
 *
 * Die Funktion Say soll einen Text in der Konsole ausgeben
 *
 * @param message Text der in der Konsole ausgegeben werden soll.
 */

void Say(string message)
{
    Console.WriteLine(message);
}


// --------------- Übungsfunktionen

/* Die Funktion AddInts soll zwei Integer miteinander addieren und ruft Say auf.
 *
 * @param number1, number2 Wert der Zahlen
 */
void AddInts(int number1, int number2)
{
    Say("Das Ergebnis der Addition lautet: " + (number1 + number2));
}

/* Die Funktion SubtractInts soll zwei Integer miteinander subtrahieren und ruft Say auf.
 *
 * @param number1, number2 Wert der Zahlen
 */
void SubtractInts(int number1, int number2)
{
    Say("Das Ergebnis der Subtraction lautet: " + (number1 - number2));
}

/* Die Funktion MultiplayInts soll zwei Integer miteinander multiplizieren und ruft Say auf.
 *
 * @param number1, number2 Wert der Zahlen
 */
void MultiplayInts(int number1, int number2)
{
    Say("Das Ergebnis der Multiplikation lautet: " + (number1 * number2));
}

/* Die Funktion DivideInts soll zwei Integer miteinander teilen und ruft Say auf.
 *
 * @param number1, number2 Wert der Zahlen
 */
void DivideInts(int number1, int number2)
{
    Say("Das Ergebnis der Division lautet: " + (number1 / number2));
}


/* Die Funktion Rich soll zwei Integer miteinander teilen und ruft Say auf.
 *
 * @param dollar Wert von deinem Bankkonto
 */
void Rich(int dollar)
{
    if (dollar > 100) // Schaut ob der Inhalt der Klammer Wahr ist. Wenn nicht => entspricht es den boolischen Wert False, Wenn Ja => True
    {
        Say("You are rich!!! Congratulations!");
    }
    else if (dollar < 0) // Wird erst aufgerufen wenn das erste IF falsch ist. 
    {
        Say("No need to spend more money than you have!!!!! >:O ");
    }
    else
    {
        // Wenn die Fälle nicht zutreffen, dann wird hier weitergemacht
        Say("Better Luck next time, you are POOOR :c ");
    }


    Say("You have: " + dollar + " $");
}

/* Die Funktion HightestNumOfTwo soll zwei Integer miteinander vergleichen, nimmt die höchste Zahl und ruft Say auf.
 *
 * @param number1, number2 Wert der Zahlen
 */
void HightestNumOfTwo(int number1, int number2)
{
    if (number1 > number2)
    {
        Say("Die Größere Zahl ist: " + number1);
    }
    else if (number1 < number2)
    {
        Say("Die Größere Zahl ist: " + number2);
    }
    else
    {
        Say("Die Zahlen" + number1 + " " + number2 + " sind gleich groß");
    }
}