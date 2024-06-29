namespace GameSharp.SemanticAnalysis {
public class Symbol {
    public string Name { get; set; }
    public string Type { get; set; }

    public Symbol(string name, string type) {
        Name = name;
        Type = type;
    }
  }
}
