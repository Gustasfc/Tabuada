int tabuada;

Console.Clear();

Console.WriteLine("Digite um número: ");
tabuada = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
}