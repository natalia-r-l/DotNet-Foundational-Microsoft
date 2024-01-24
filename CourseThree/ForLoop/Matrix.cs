
// Lendo a matriz e trocando o nome David por Sammy
string[] names2 = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names2.Length; i++)
    if (names2[i] == "David") names2[i] = "Sammy";

Console.WriteLine($"Lendo a Matriz: ");
foreach (var name in names2) Console.WriteLine(name);

// Lendo a matriz de trás para frente e trocando o nome David por Sammy

string[] names1 = { "Alex", "Eddie", "David", "Michael" };

Console.WriteLine($"Lendo a Matriz de trás para frente: ");

for (int i = names1.Length - 1; i >= 0; i--)
{    
    if (names1[i] == "David")
    {
        names1[i] = "Sammy";
    }

    Console.WriteLine(names1[i]);
}


