using System;
using Antlr4.Runtime;

public class Program
{
    public static void Main(string[] args)
    {
        var input = new AntlrInputStream("tu codigo aqui");
        var lexer = new GamecsharpLexer(input);
        var tokens = new CommonTokenStream(lexer);
        var parser = new GamecsharpParser(tokens);

        var context = parser.prog();  // 'prog' es la regla inicial de tu gramática
    }
}