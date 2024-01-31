int a = 5;
int b = 6;
int c = 7;

int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
return max;