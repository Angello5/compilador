using System.Collections.Generic;

namespace GameSharp.SemanticAnalysis {
    public class Scope {
        public Scope? Parent { get; set; }
        public Dictionary<string, Symbol> Symbols { get; set; }

        public Scope(Scope? parent = null) {
            Parent = parent;
            Symbols = new Dictionary<string, Symbol>();
        }

        public void Define(Symbol symbol) {
            if (Symbols.ContainsKey(symbol.Name)) {
                throw new System.Exception($"Symbol '{symbol.Name}' is already defined in the current scope.");
            }
            Symbols[symbol.Name] = symbol;
        }

        public Symbol? Resolve(string name) {
            if (Symbols.TryGetValue(name, out Symbol symbol)) {
                return symbol;
            } else if (Parent != null) {
                return Parent.Resolve(name);
            }
            return null;
        }
    }
}
