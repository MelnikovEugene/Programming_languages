int a = 617;
int b = (a / 10) % 10;
for (int i = 1; i < (a % 10); i++)
{
    b = b * ((a / 10) % 10);
}
System.Console.WriteLine(b);