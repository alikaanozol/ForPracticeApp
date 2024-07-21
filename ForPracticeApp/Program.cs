Console.WriteLine("-----< Alıştırma 1 >-----");
for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"{i}) Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine("-----< Alıştırma 2 >-----");
for (int i = 1;i < 21; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("-----< Alıştırma 3 >-----");
for (int i = 2; i < 21; i+=2)
{
    Console.WriteLine(i);
}

Console.WriteLine("-----< Alıştırma 4 >-----");
int total = 0;
for (int i = 50;i < 151; i++)
{
    total=total+i;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı" + " " + total);

Console.WriteLine("-----< Alıştırma 5 >-----");
//tek sayıların toplamı(1-120)
int single= 0;
for (int i = 1; i <120; i+=2)
{
    single=single+i;
}
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı" + " " + single);
//çift sayıların toplamı(1-120)
int couple = 0;
for (int i = 2; i < 121; i+=2)
{
    couple = couple + i;
}
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı" + " " + couple);
