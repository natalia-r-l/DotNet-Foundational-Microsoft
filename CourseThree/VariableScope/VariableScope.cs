
/*
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine($"Outside of code block: {value}");



bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine($"Outside of code block: {value}");

/*

Um desenvolvedor escreve um código que inclui um bloco de código da instrução if. 
Eles inicializam uma variável de inteiro para um valor de 5 acima (fora) do bloco de código. 
Eles inicializam uma segunda variável de inteiro para um valor de 6 na primeira linha dentro do bloco de código. 
A expressão booleana para o bloco de código é avaliada como true se a primeira variável inteira 
tiver um valor maior que 0. Na segunda linha dentro do bloco de código, a soma dos dois valores é 
atribuída à primeira variável. Na primeira linha depois (fora) do bloco de código, ele escreve um 
código para exibir o valor do primeiro integer. Qual é o resultado quando a instrução de código usada para exibir 
o primeiro integer é executada? 



int valor1 = 5;

if (valor1 > 0)
{
    int valor2 = 6;
    valor1 = valor1 + valor2;
    
}
Console.WriteLine($"Valor da primeira variável, somando o valor1 ao valor2: {valor1}");

*/

/*

Um desenvolvedor escreve um código que inclui um bloco de código da instrução if. Eles inicializam uma primeira variável inteira para um valor 
de 5 acima (fora) do bloco de código. A expressão booleana para o bloco de código de declaração if é avaliada como true se a primeira variável 
inteira tiver um valor maior que 0. A primeira linha de código dentro do bloco de código é usada para inicializar uma segunda variável de inteiro 
para um valor de 6. A primeira linha de código após o bloco de código é usada para adicionar o segundo valor inteiro ao valor do primeiro inteiro.
A segunda linha de código após o bloco de código é usada para exibir o valor do primeiro inteiro. Qual é o resultado quando o código é executado?



int valor1 = 5;

if (valor1 > 0)
{
    int valor2 = 6;   
}

valor1 = valor1 + valor2;
Console.WriteLine($"Valor da primeira variável, somando o valor1 ao valor2: {valor1}");


Output: Erro! O nome "valor2" não existe no contexto atual
*/