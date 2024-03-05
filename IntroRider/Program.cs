/*                  // <--- Start
 * Dieses Programm soll als Hilfestellung dienen um die IDE Rider bzw. den allgemeinen Syntax zu verstehen.
 *
 *  <---- Dies ist eine Möglichkeit über mehrere Zeilen zu Kommentieren.
 * 
 */                 // <--- Ende

// <---- Dies ist eine Möglichkeit nur eine Zeile zu kommenttieren, alles ab // wird Kommentiert. 


//  Definition Variablen      

int age = 10;                   // int Die Werte des Datentyps "int" sind die ganzen Zahlen im Bereich von "-2147483648" bis "2147483647". (Die größte und kleinste Zahl des Datentyps "int" ist die Konstante "Integer.
bool isLightOn = true;          // Boolean ist in Programmiersprachen der Datentyp für Wahrheitswerte. Der Datentyp boolean kann entweder den Wert wahr (entspricht in dem binären Wert 1) oder falsch (entspricht dem binären Wert 0) annehmen.
string name = "HTK Academy";    // Ein “string” ist ein Datentyp in der Programmierung, der eine Zeichenkette enthält. Zeichenketten werden verwendet, um Wörter, Sätze und Texte zu speichern.
float price = 0.99f;            // Gleitkommazahl, Datentyp zum Speichern von Kommazahlen.


// Zusätzliche Datentypen

double reallyBigNumber = 99;    //Ein Double enthält doppelt so viele Bits wie eine normale Gleitkommazahl (float). Ein Double kann 64 Bit enthalten und positiv (+) oder negativ (-) sein. Wird aber selten verwendet.

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


int example = 42;                                           // Mann kann das auch hier initialisieren, jedoch ist dies nicht "schön" nur so machen wenn man weiß was man macht. 
Say(example.ToString());                            //.ToString() wandelt die Variable in das Format String um, damit dieser auch als Text ausgegeben werden kann.


Say("Integer: " + age);                             // Hier ist eine Kombination aus Roher information und einer Variable. In diesem Falle, ist es nicht notwendig .toString() hinzuzufügen

Say( "Boolean: " + isLightOn);                      // "xxxx" ist eine andere art der Dateneingabe. Hier wird der String direkt mithilfe von "" eingegeben.

Say("String: " + name);                             // Das "+" hängt die Texte zusammen

Say("Float: " + price);           

Say("Double: " + reallyBigNumber);



//  Funktion Definitionen


/*
 * @ToDo Das ist eine Möglichkeit um darzustellen was noch gemacht gehört
 *
 * Die Funktion Say soll einen Text in der Konsole ausgeben
 *
 * @param message Text der in der Konsole ausgegeben werden soll.
 */
void Say(string message)
{
    Console.WriteLine(message);
}

