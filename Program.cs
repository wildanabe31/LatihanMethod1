static void tambah (int a, int b)
{
    int c = 0;

    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

static void kurang (int a, int b)
{
    int c = 0;

    c = c + b;
    Console.WriteLine($"{a} - {b} = {c}");
}

static void kali (int a, int b)
{
    int c = 0;

    c = c + b;
    Console.WriteLine($"{a} * {b} = {c}");
}

static void bagi (int a, int b)
{
    int c = 0;

    c = c + b;
    Console.WriteLine($"{a} : {b} = {c}");
}

tambah(10, 70);
tambah(3, 9);

kurang(10, 4);
kurang(9, 1);

kali(7, 12);
kali(11, 13);

bagi(90, 3);
bagi(12, 2);
