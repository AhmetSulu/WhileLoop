
// Kendime inanıyorum, ben bu yazılım işini hallederim! 10 Tekrar

using System;

int i = 0;

while (i < 10)
{
    Console.WriteLine($"Kendime inanıyorum, ben bu yazılım işini hallederim!");

    i++;

}


// 1 ile 20 arasındaki sayılar


int i1 = 1;

while (i1 <=  20)
{
    Console.WriteLine(i1);

    i1++;

}


// 1 ile 20 arasındaki cift sayılar


int i2 = 2;

while (i2 <= 20)
{
    Console.WriteLine(i2);

    i2 += 2;

}


// 50 ile 150 arasındaki sayıların toplamı


int i3 = 50;
int sum = 0;

while (i3 <= 150)
{
    sum += i3;
    i3 ++;

}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı = " + sum);


// 1 ile 120 arasındaki tek ve çift sayıların toplamları

int i4 = 1;
int sumTek = 0;
int sumCift = 0;

while (i4 <= 120)
{
    // Cift sayıları kontrolü
    if (i4 % 2 == 0)
    {
        sumCift += i4;
    }
    else
    {
        sumTek += i4;

    }
    i4++;
}
Console.WriteLine("Çift sayıların toplamı: " + sumCift);
Console.WriteLine("Tek sayıların toplamı: " + sumTek);



