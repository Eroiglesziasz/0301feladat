int elso;
int masodik;
do
{
    Console.Write("Kérem az első játékos választását kódolva (0-kő, 1-papír, 2-olló):");
    elso = Convert.ToInt32(Console.ReadLine());
} while (elso < 0 || elso > 2);

do
{
    Console.Write("Kérem a második játékos választását kódolva (0-kő, 1-papír, 2-olló):");
    masodik = Convert.ToInt32(Console.ReadLine());
} while (masodik < 0 || masodik > 2);

switch (nem(elso, masodik)) {
    case 0: 
        Console.WriteLine("Döntetlen"); 
        break;
    case 1:
        Console.WriteLine("1");
        break;
    case 2:
        Console.WriteLine("2");
        break;
}


string[] xd = File.ReadAllLines("jatek.txt");
int[] eredmeny = new int[3];
foreach (var item in xd)
{
    string[] temp = item.Split("-");
    int eso = Convert.ToInt32(temp[0]);
    int mas = Convert.ToInt32(temp[1]);
    eredmeny[nem(eso, mas)]++;
}
Console.WriteLine("Döntetlenek száma: " + eredmeny[0]);
Console.WriteLine("Első játékos nyert: " + eredmeny[1]);
Console.WriteLine("Második játékos nyert: " + eredmeny[2]);


static int nem(int elso, int masodik)
{
    if (elso == 0 && masodik == 0 || elso == 1 && masodik == 1 || elso == 2 && masodik == 2)
    {
        return 0;
    }
    if (elso == 0 && masodik == 2 || elso == 1 && masodik == 0 || elso == 2 && masodik == 1)
    {
        return 1;
    }
    if (elso == 0 && masodik == 1 || elso == 1 && masodik == 2 || elso == 2 && masodik == 0)
    {
        return 2;
    }
    return 123;
}





Console.ReadKey();
