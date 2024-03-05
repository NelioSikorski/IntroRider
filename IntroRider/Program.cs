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

// Start des Programmes

Say(age.ToString());
Say(isLightOn.ToString());
Say(name);
Say(price.ToString());
Say(reallyBigNumber.ToString());



// Funktionen


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

