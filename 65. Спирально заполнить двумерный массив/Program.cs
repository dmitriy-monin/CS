// Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 

Console.Clear();
int n = 4;
int t = 4;
int[,] a = new int[n, n];
int x , y , r = 1;
int c = 0;
double m = Math.Ceiling(n / 2.0);

while (r <= m)
{
    for (x = r-1, y = r-1; y < n; y++)
    {
        a[x, y] = ++c;
    }
    y--;
    for (x++ ; x < n; x++)
    {
        a[x, y] = ++c;
    }
    x--;
    for (y --; y >= r-1; y--)
    {
        a[x, y] = ++c;
    }
    y++;
    for (x--; x >= r ; x--)
    {
        a[x, y] = ++c;
    }
    n = n - 1;
    r++;
}

for (int i = 0; i < t; i++)
{
    for (int j = 0; j < t; j++)
    {
        Console.Write("{0,3}", a[i, j]);
    }
    Console.WriteLine();
}