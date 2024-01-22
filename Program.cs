/* Criação de tipos literais por meio dos métodos Write e WriteLine.

// O tipo literal char é definido passando o valor literal entre aspas simples.
// o char permite apenas um caractere por método, desta forma, caso tentem passar um valor maior do que um caractere, como por 
// exemplo a palavra char, retornará um erro de execução. 
Console.Write("Criando um valor literal do tipo Char: ");
Console.WriteLine('C');

// O tipo literal string é definido passando o valor literal entre aspas duplas. 
Console.Write("Criando um valor literal do tipo String: ");
Console.WriteLine("Hello World!");

// O tipo literal int é definido passando o valor numérico, sem aspas. 
Console.Write("Criando um valor literal do tipo Inteiro: ");
Console.WriteLine(123);

// o tipo literal float é definido passando o valor numérico com ponto e a letra F de Float ao final do valor, que pode ser F ou f.
// TIPO DECIMAL COM PRECISÃO DE ~6-9 digitos
Console.Write("Criando um valor literal do tipo decimal float, ou ponto flutuante: ");
Console.WriteLine(0.25f);

// o tipo literal double é definido passando o valor numérico com ponto.
// TIPO DECIMAL COM PRECISÃO DE  ~15-17 digits
Console.Write("Criando um valor literal do tipo decimal double: ");
Console.WriteLine(2.625);

// o tipo literal decimal é definido passando o valor numérico com ponto e com a letra m ao final do valor, que pode ser M ou m.
// TIPO DECIMAL COM PRECISÃO DE  28-29 digits
Console.Write("Criando um valor literal do tipo decimal ");
Console.WriteLine(12.39816M);

// o tipo literal bool é definido passando o valor true ou false como parâmetro, sem aspas.
Console.Write("Criando um valor literal do tipo bool ");
Console.WriteLine(true);

___________________________________________________________________________________________________________________

/* Diferença entre os métodos Write, e WriteLine, da Classe Console. 

// O método WriteLine acrescenta uma nova linha após a saída. 
Console.WriteLine("Exibição de caracteres literais utilizando o Console.WriteLine: ");
Console.WriteLine("A");
Console.WriteLine("B");
Console.WriteLine("C");
Console.WriteLine("D");

// O método Write NÃO acrescenta uma nova linha após a saíde, então a exibição do conteúdo fica em uma mesma linha.  
Console.WriteLine("Exibição de caracteres literais utilizando o Console.Write: ");
Console.Write("A");
Console.Write("B");
Console.Write("C");
Console.Write("D");

*/