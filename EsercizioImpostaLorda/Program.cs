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

Console.WriteLine("Inserire il reddito");
var reddito = int.Parse(Console.ReadLine());

int impostaBase;
int aliquota;
int limiteEccedenza;

if (reddito <= 15000)
{
    impostaBase = 0;
    aliquota = 23;
    limiteEccedenza = 0;
}
else if (reddito <= 28000)
{
    impostaBase = 3450;
    aliquota = 27;
    limiteEccedenza = 15000;
}
else if (reddito <= 55000)
{
    impostaBase = 6960;
    aliquota = 38;
    limiteEccedenza = 28000;
}
else if (reddito <= 75000)
{
    impostaBase = 17220;
    aliquota = 41;
    limiteEccedenza = 55000;
}
else
{
    impostaBase = 25420;
    aliquota = 43;
    limiteEccedenza = 75000;
}

Console.WriteLine($"L'imposta è pari a {impostaBase + (reddito - limiteEccedenza) * aliquota / 100} euro");