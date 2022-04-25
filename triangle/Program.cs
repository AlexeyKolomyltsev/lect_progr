Console.Clear();

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30,
    count = 0;
int x = xa;
int y = ya;


while (count < 1000)
{
    int sel = new Random().Next(0, 3);
    if (sel == 0)
    {
        x = (xa + x) / 2;
        y = (ya + y) / 2;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+");
    }
    if (sel == 1)
    {
        x = (xb + x) / 2;
        y = (yb + y) / 2;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+");
    }
    if (sel == 2)
    {
        x = (xc + x) / 2;
        y = (yc + y) / 2;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+");
    }
    count += 1;
}
