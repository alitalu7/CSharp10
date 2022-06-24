int[] dizi = {9, 8, 7, 6, 5, 4, 3, 2, 1, 0};


Console.WriteLine("Dizi eleman sayısı = " + dizi.Length);

for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine($"Dizinin {i + 1} . elemanı = {dizi[i]} ");
}

Console.WriteLine("Dizinin en küçük elemanı = " + dizi.Min());
Console.WriteLine("Dizinin en büyük elemanı = " + dizi.Max());
