namespace GameSharp.SemanticAnalysis
{
    public class Symbol
    {
        public string Name { get; }
        public string Type { get; }

        public Symbol(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
