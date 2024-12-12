// Дан массив 30 значений в диапазоне [-10;10] найти количество значений равных 5 и - 5.

int[] array = new int[30];  
Random random = new Random();
for (int i = 0; i < array.Length; i++)  
{
    array[i] = random.Next(-10, 11);
}

int pKol = array.Count(x => x == 5);  
int nKol = array.Count(x => x == -5);    

Console.WriteLine($"Кол-во значений равных 5 = {pKol}");
Console.WriteLine($"Кол-во значений равных -5 = {nKol}");