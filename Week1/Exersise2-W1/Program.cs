// See https://aka.ms/new-console-template for more information
int i;
int j;
for (i = 1; i <= 10; i++)
{
    for (j = 1; j <=9; j++) 
    {
        int ji = j * i;
        Console.Write($"|{j} x {i} = {ji}\t");
    }
Console.WriteLine();
}
