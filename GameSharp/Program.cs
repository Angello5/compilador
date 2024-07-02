using Antlr4.Runtime;
using GameSharp;

internal class Program
{
    private static void Main(string[] args)
    {
        var isi = "input.isi";
        var fileContent = File.ReadAllText(isi);

        var input = new AntlrInputStream(fileContent);
        var lexer = new GameSharpLexer(input);
        var tokenStream = new CommonTokenStream(lexer);
        var parser = new GameSharpParser(tokenStream);
        var visitor = new Visitor();
        var progContext = parser.prog();
        visitor.Visit(progContext);
    }
}
