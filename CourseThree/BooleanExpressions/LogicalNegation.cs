/*

string pangram = "The quick brown fox jumps over the lazy dog.";

// Como o conteúdo de pangram contém a palavra fox, esta expressão resultaria em true
Console.WriteLine("Expressão booleana simples, quando a palavra está contida no conteúdo: " + pangram.Contains("fox")); // True

// Como o conteúdo de pangram contém a palavra fox, esta expressão resultaria em true, porém, com a aplicação da 
// negação lógica, retornará false. 

Console.WriteLine("Expressão booleana quando a palavra está contida no conteúdo, e com negação lógica: " + !pangram.Contains("fox")); // False

// Como o conteúdo de pangram não contém a palavra cow, esta expressão resultaria em false, porém, com a aplicação da 
// negação lógica, retornará true. 

Console.WriteLine("Expressão booleana simples, quando a palavra NÃO está contida no conteúdo: " +  pangram.Contains("cow")); // False

Console.WriteLine("Expressão booleana quando a palavra NÃO está contida no conteúdo, e com negação lógica: " + !pangram.Contains("cow")); // True

*/