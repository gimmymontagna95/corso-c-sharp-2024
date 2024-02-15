/**
 * L’imposta lorda è determinata applicando al reddito complessivo le seguenti aliquote per scaglioni di reddito:

scaglioni di reddito in €	aliquota	imposta dovuta
            da 0 a 15.000	23%	        23% sulla parte eccedente la no tax area (per semplicità pari a 3000 €)
       da 15.000 a 28.000	27%	        3.450 € + 27% sulla parte eccedente i 15.000 €
       da 28.000 a 55.000	38%	        6.960 € + 38% sulla parte eccedente i 28.000 €
       da 55.000 a 75.000	41%	        17.220 € + 41% sulla parte eccedente i 55.000 €
             oltre 75.000	43%	        25.420 € + 43% sulla parte eccedente i 75.000 €
Scrivere un programma che dato in input il reddito determini l’imposta.

   */
double CalcolaImpostaLorda(double reddito, double limiteEccedenza, double aliquota, double impostaBase = 0)
{
    return impostaBase + (reddito - limiteEccedenza) * aliquota / 100;
}

Console.WriteLine("Inserire il reddito");
var reddito = int.Parse(Console.ReadLine());

double imposta;

if (reddito <= 15000)
{
    imposta = CalcolaImpostaLorda(reddito, 3000, 23);
}
else if (reddito <= 28000)
{
    imposta = CalcolaImpostaLorda(reddito, 15000, 27, 3450);
}
else if (reddito <= 55000)
{
    imposta = CalcolaImpostaLorda(reddito, 28000, 38, 6960);
}
else if (reddito <= 75000)
{
    imposta = CalcolaImpostaLorda(reddito, 55000, 41, 17220);
}
else
{
    imposta = CalcolaImpostaLorda(reddito, 75000, 43, 25420);
}

Console.WriteLine($"L'imposta è pari a {imposta} euro");