using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;

namespace GameSharp.SemanticAnalysis {
    public class SemanticAnalyzer : GameSharpBaseVisitor<object> {
        private Scope currentScope;

        public SemanticAnalyzer() {
            currentScope = new Scope(null); // Ámbito global
        }

        public new object Visit(IParseTree tree) {
            return base.Visit(tree);
        }

        // Analizar el programa completo
        public override object VisitProg(GameSharpParser.ProgContext context) {
            Console.WriteLine("Analizando el programa");
            foreach (var statement in context.statement()) {
                Visit(statement);
            }
            return null;
        }

        // Declaración de objetos
        public override object VisitObjectDecl(GameSharpParser.ObjectDeclContext context) {
            string objectId = context.ID().GetText();
            Console.WriteLine($"Declaración del objeto: {objectId}");
            if (currentScope.Resolve(objectId) != null) {
                throw new Exception($"El objeto '{objectId}' ya está declarado en este ámbito.");
            }
            currentScope.Define(new Symbol(objectId, "Object"));

            Scope oldScope = currentScope;
            currentScope = new Scope(currentScope);

            foreach (var property in context.objectBody().propertyDecl()) {
                Visit(property);
            }

            currentScope = oldScope;
            return null;
        }

        // Declaración de propiedades
        public override object VisitPropertyDecl(GameSharpParser.PropertyDeclContext context) {
            string propertyId = context.ID().GetText();
            Console.WriteLine($"Declaración de la propiedad: {propertyId}");
            if (currentScope.Resolve(propertyId) != null) {
                throw new Exception($"La propiedad '{propertyId}' ya está declarada en este ámbito.");
            }

            var valueContext = context.value();
            if (valueContext.NUMBER() == null) {
                throw new Exception($"La propiedad '{propertyId}' debe ser asignada a un valor entero.");
            }

            currentScope.Define(new Symbol(propertyId, "int"));
            return null;
        }

        // Manejadores de eventos
        public override object VisitEventHandler(GameSharpParser.EventHandlerContext context) {
            string eventType = context.eventType().GetText();
            Console.WriteLine($"Manejador de eventos: {eventType}");

            Scope oldScope = currentScope;
            currentScope = new Scope(currentScope);

            foreach (var command in context.command()) {
                Visit(command);
            }

            currentScope = oldScope;
            return null;
        }

        // Declaraciones de acciones
        public override object VisitActionDecl(GameSharpParser.ActionDeclContext context) {
            string actionId = context.ID().GetText();
            Console.WriteLine($"Declaración de la acción: {actionId}");
            if (currentScope.Resolve(actionId) != null) {
                throw new Exception($"La acción '{actionId}' ya está declarada en este ámbito.");
            }
            currentScope.Define(new Symbol(actionId, "Action"));

            Scope oldScope = currentScope;
            currentScope = new Scope(currentScope);

            foreach (var command in context.command()) {
                Visit(command);
            }

            currentScope = oldScope;
            return null;
        }

        // Asignaciones
        public override object VisitAssignment(GameSharpParser.AssignmentContext context) {
            string varName = context.ID().GetText();
            Console.WriteLine($"Asignación: {varName}");
            Symbol? varSymbol = currentScope.Resolve(varName);
            if (varSymbol == null) {
                throw new Exception($"La variable '{varName}' no está declarada.");
            }

            Visit(context.expr());
            return null;
        }

        // Declaraciones if
        public override object VisitIfStatement(GameSharpParser.IfStatementContext context) {
            Console.WriteLine("Declaración if");
            Visit(context.expr());

            Scope oldScope = currentScope;
            currentScope = new Scope(currentScope);

            foreach (var command in context.command()) {
                Visit(command);
            }

            currentScope = oldScope;
            return null;
        }

        // Declaraciones while
        public override object VisitWhileStatement(GameSharpParser.WhileStatementContext context) {
            Console.WriteLine("Declaración while");
            Visit(context.expr());

            Scope oldScope = currentScope;
            currentScope = new Scope(currentScope);

            foreach (var command in context.command()) {
                Visit(command);
            }

            currentScope = oldScope;
            return null;
        }

        // Llamadas a funciones
        public override object VisitFunctionCall(GameSharpParser.FunctionCallContext context) {
            string functionId = context.ID().GetText();
            Console.WriteLine($"Llamada a función: {functionId}");
            Symbol? functionSymbol = currentScope.Resolve(functionId);
            if (functionSymbol == null) {
                throw new Exception($"La función '{functionId}' no está declarada.");
            }

            // Lógica adicional de verificación de argumentos puede ser añadida aquí
            return base.VisitFunctionCall(context);
        }

        // Declaraciones de impresión
        public override object VisitPrintStatement(GameSharpParser.PrintStatementContext context) {
            Console.WriteLine("Declaración de impresión");
            Visit(context.expr());
            return null;
        }

        // Expresiones
        public override object VisitAddSub(GameSharpParser.AddSubContext context) {
            Console.WriteLine("Expresión de suma/resta");
            Visit(context.expr(0));
            Visit(context.expr(1));
            return null;
        }

        public override object VisitMultiplicacionydivision(GameSharpParser.MultiplicacionydivisionContext context) {
            Console.WriteLine("Expresión de multiplicación/división");
            Visit(context.expr(0));
            Visit(context.expr(1));
            return null;
        }

        public override object VisitParentesis(GameSharpParser.ParentesisContext context) {
            Console.WriteLine("Expresión entre paréntesis");
            Visit(context.expr());
            return null;
        }

        public override object VisitNumero(GameSharpParser.NumeroContext context) {
            Console.WriteLine("Número: " + context.GetText());
            return null;
        }

        public override object VisitIdenticador(GameSharpParser.IdenticadorContext context) {
            string id = context.ID().GetText();
            Console.WriteLine($"Identificador: {id}");
            if (currentScope.Resolve(id) == null) {
                throw new Exception($"El identificador '{id}' no está declarado.");
            }
            return null;
        }
    }
}
