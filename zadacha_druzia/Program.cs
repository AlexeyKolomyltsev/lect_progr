int v1 = 2, v2 = 3, vs = 5, s = 1000, count = 0;
bool f = true;

while (s >= 10)
{
    if (f == true)      ///f=true собака двигается от первого путника
    {
        int t = s / (v2 + vs);
        s -= (v1 + v2) * t;
        f = false;
    }
    else
    {
        int t = s / (v1 + vs);
        s -= (v1 + v2) * t;
        f = true;
    }
    count += 1;
}
Console.WriteLine(count);