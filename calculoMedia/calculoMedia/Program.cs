Console.WriteLine("isira as notas de sophia: (5 no total: 0 - 100 ");

int sophia1 = int.Parse(Console.ReadLine());
int sophia2 = int.Parse(Console.ReadLine());
int sophia3 = int.Parse(Console.ReadLine());
int sophia4 = int.Parse(Console.ReadLine());
int sophia5 = int.Parse(Console.ReadLine());

Console.WriteLine("isira as notas de nicolas: (5 no total: 0 - 100 ");

int nicolas1 = int.Parse(Console.ReadLine());
int nicolas2 = int.Parse(Console.ReadLine());
int nicolas3 = int.Parse(Console.ReadLine());
int nicolas4 = int.Parse(Console.ReadLine());
int nicolas5 = int.Parse(Console.ReadLine());

Console.WriteLine("isira as notas de zahira: (5 no total: 0 - 100 ");

int zahirah1 = int.Parse(Console.ReadLine());
int zahirah2 = int.Parse(Console.ReadLine());
int zahirah3 = int.Parse(Console.ReadLine());
int zahirah4 = int.Parse(Console.ReadLine());
int zahirah5 = int.Parse(Console.ReadLine());

Console.WriteLine("isira as notas de jeong: (5 no total: 0 - 100 ");

int jeong1 = int.Parse(Console.ReadLine());
int jeong2 = int.Parse(Console.ReadLine());
int jeong3 = int.Parse(Console.ReadLine());
int jeong4 = int.Parse(Console.ReadLine());
int jeong5 = int.Parse(Console.ReadLine());

var sophiaSoma = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
var nicolasSoma = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
var zahirahSoma = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
var jeongSoma = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
Console.WriteLine("SOMAS: ");

Console.WriteLine("Sophia: " + sophiaSoma);
Console.WriteLine("Nicolas: " + nicolasSoma);
Console.WriteLine("Zahirah: " + zahirahSoma);
Console.WriteLine("Jeong: " + jeongSoma);

var sophiaScore = sophiaSoma / 5;
var nicolasScore = nicolasSoma / 5;
var zahirahScore = zahirahSoma / 5;
var jeongScore = jeongSoma / 5;

Console.WriteLine("MEDIAS: ");

Console.WriteLine("Sophia: " + sophiaScore);
Console.WriteLine("Nicolas: " + nicolasScore);
Console.WriteLine("Zahirah: " + zahirahScore);
Console.WriteLine("Jeong: " + jeongScore);


if (sophiaScore >= 97 && sophiaScore <= 100)
{
    Console.WriteLine("Sophia: A+");
}
else if (sophiaScore >= 93 && sophiaScore <= 96)
{
    Console.WriteLine("Sophia: A");
}
else if (sophiaScore >= 90 && sophiaScore <= 92)
{
    Console.WriteLine("Sophia: A-");
}

