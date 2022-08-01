// Exercício do site URI "intervalo2"

int X, Dentro, Fora;
int N = int.Parse(Console.ReadLine());

Dentro = 0;
Fora = 0;
for (int i = 1; i <= N; i++)
{
    X = int.Parse(Console.ReadLine());
    if (X >= 10 && X <= 20)
    {
        Dentro ++;
    }
    else
    {
        Fora ++;
    }
}   
Console.WriteLine(Dentro + " in");
Console.WriteLine(Fora + " out");