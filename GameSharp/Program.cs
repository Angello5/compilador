using Antlr4.Runtime;
using System;
using System.IO;
using GameSharp.SemanticAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
        var isi = "input.isi";
        var fileContent = File.ReadAllText(isi);

        var input = new AntlrInputStream(fileContent);
        var lexer = new GameSharpLexer(input);
        var tokenStream = new CommonTokenStream(lexer);
        var parser = new GameSharpParser(tokenStream);

        var progContext = parser.prog();
     // Aplicando el análisis semántico
            var semanticAnalyzer = new SemanticAnalyzer();
            semanticAnalyzer.Visit(progContext);

            Console.WriteLine("Análisis semántico completado con éxito.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error durante el análisis: " + ex.Message);
        }
    }
}