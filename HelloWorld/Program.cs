//string esempio = "variabile STRING di STRING STRING Esempio";

//string esempioMaiuscolo = esempio.ToUpper();

//Console.WriteLine($"esempio {esempio} esempioMaiuscolo {esempioMaiuscolo}");

//string esempioMinuscolo = esempioMaiuscolo.ToLower();
//Console.WriteLine($"esempio minuscolo {esempioMinuscolo}");

//string esempioReplace = esempio.Replace("STRING", "");
//Console.WriteLine($"esempio replace {esempioReplace}");

//Console.WriteLine(esempio[3]);

//Console.WriteLine(esempio.Length);

//int indiceUltimaLettera = esempio.Length - 1;
//Console.WriteLine(esempio[indiceUltimaLettera]);

//bool contieneCiao = esempio.Contains("ciao"); //false
//bool contieneSTRING = esempio.Contains("STRING"); //true
//bool contieneSTriNG = esempio.Contains("STriNG"); //false

//// esempio conitiene STRING a prescindere dalle maiuscole e dalle minuscole
//bool risultato = esempio.ToLower().Contains("string"); //true
//Console.WriteLine(risultato);

//string esempioInserimento = esempio.Insert(9, " nuova roba");
//Console.WriteLine(esempioInserimento);

//string substring = esempio.Substring(9, 11);
//string esempioRimozione = esempio.Remove(9, 11);

//Console.WriteLine("substring " + substring);
//Console.WriteLine("remove " + esempioRimozione);

/*
 * Numeri
 * 
 * +, -, * , /, %
 * Comandi di Math
 * Pow, Sqrt, Abs, Round, Floor, Ceiling
 * 
 * Stringhe
 * 
 * concatenazione +
 * interpolazione $
 * Comandi sulla stringa
 * ToLower, ToUpper, Replace, Contains, Insert, Substring, Remove
 */



// Controllo del flusso

// if ci permette di eseguire un blocco di codice se una condizione è vera

/** -------------------------------------------------------- */
//Console.WriteLine("Sempre eseguito");

//if (true)
//{
//    Console.WriteLine("eseguito se la condizione è vera");
//}

//if (false)
//{
//    Console.WriteLine("eseguito se la condizione è false");
//}

//bool condizione = true; //false

//string testString = "questo è un testo di prova";

//bool contieneStringaTesto = testString.Contains("testo");
//bool contieneStringaCiao = testString.Contains("ciao");

//if (contieneStringaTesto)
//{
//    Console.WriteLine("La stringa contiene la parola testo");
//}

//if (contieneStringaCiao)
//{
//    Console.WriteLine("La stringa contiene la parola ciao");
//}

///**
// * Operatori logici
// *  
// *  == Uguaglianza
// *  != Disuguaglianza
// *  <  Minore
// *  >  Maggiore
// *  <= Minore o uguale
// *  >= Maggiore o uguale
// * 
// */

//bool numeriUguali = 5 == 5; //true
//bool numeriDiversi = 5 == 7; //false

//numeriUguali = 5 != 5; //false
//numeriDiversi = 5 != 7; //true

//bool minore = 5 < 7; //true
//minore = 5 < 4; //false

//bool maggiore = 5 > 4; //true
//maggiore = 5 > 7; //false

//bool minoreUguale = 5 <= 5; //true
//minoreUguale = 5 <= 4; //false

//bool maggioreUguale = 5 >= 5; //true
//maggioreUguale = 5 >= 7; //false

///**  Operatori logici
// * *  
// * *  && AND
// * *  || OR
// * *  !  NOT
// * * 
// * */

//bool confrontoConAnd = true && true; //true
//confrontoConAnd = true && false; //false
//confrontoConAnd = false && true; //false
//confrontoConAnd = false && false; //false

//bool confrontoConOr = true || true; //true
//confrontoConOr = true || false; //true
//confrontoConOr = false || true; //true
//confrontoConOr = false || false; //false

//bool not = !true; //false
//not = !false; //true

///** Confronto stringhe */
//bool stringheUguali = "ciao" == "ciao"; //true
//stringheUguali = "ciao" == "mondo"; //false

//bool stringheDisuguali = "ciao" != "ciao"; //false
//stringheDisuguali = "ciao" != "mondo"; //true


/** -------------------------------------------------------- */

//int numero1 = 13;
//int numero2 = 4;

//var divIntera = 13 / 4; //3

//int resto = 13 - 4 * divIntera; // 1

//int restoConmodulo = 13 % 4; //1

//// esempio
//int incremento = 5;

//var count = incremento % 4; // 1

/** -------------------------------------------------------- */
// Parse

string stringaNumero = "123";
string stringaNumero2 = "10";

string stringaNumero3 = stringaNumero + stringaNumero2; //12310

int numeroParsato = int.Parse(stringaNumero); //123
double numeroParsatoDouble = double.Parse("123.456"); //123.456

if (int.TryParse(stringaNumero, out int numeroParsatoTryParse))
{
    // sono sicuro che la conversione è andata a buon fine
    // numeroParsatoTryParse == 123
}
else
{
    // la conversione non è andata a buon fine
}