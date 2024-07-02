using System;
using System.Collections.Generic;

namespace GameSharp
{
    public class Visitor : GameSharpBaseVisitor<object?>
    {
        private Dictionary<string, Dictionary<string, object?>> Objects { get; } = new();
        private Dictionary<string, object?> Variables { get; } = new();
        private Dictionary<string, GameSharpParser.ActionDeclContext> Actions { get; } = new();

        public override object? VisitObjectDecl(GameSharpParser.ObjectDeclContext context)
        {
            var name = context.ID().GetText();
            var properties = Visit(context.objectBody()) as Dictionary<string, object?>;
            Objects[name] = properties ?? new Dictionary<string, object?>();
            return null;
        }

        public override object? VisitObjectBody(GameSharpParser.ObjectBodyContext context)
        {
            var properties = new Dictionary<string, object?>();
            foreach (var prop in context.propertyDecl())
            {
                var propName = prop.ID().GetText();
                var propValue = Visit(prop.value());
                properties[propName] = propValue;
            }
            return properties;
        }

        public override object? VisitAssignment(GameSharpParser.AssignmentContext context)
        {
            var target = context.ID(0).GetText();
            var value = Visit(context.expr());

            if (context.ID().Length > 1)
            {
                var objectName = context.ID(0).GetText();
                var propertyName = context.ID(1).GetText();

                if (Objects.ContainsKey(objectName))
                {
                    Objects[objectName][propertyName] = value;
                }
                else
                {
                    throw new Exception($"Object {objectName} not found");
                }
            }
            else
            {
                Variables[target] = value;
            }

            return null;
        }

        public override object? VisitPrintStatement(GameSharpParser.PrintStatementContext context)
        {
            var expression = Visit(context.expr());
            Console.WriteLine(expression);
            return null;
        }

        public override object? VisitReadStatement(GameSharpParser.ReadStatementContext context)
        {
            var varName = context.ID().GetText();
            var input = Console.ReadLine();

            if (int.TryParse(input, out var number))
            {
                Variables[varName] = number;
            }
            else if (bool.TryParse(input, out var boolean))
            {
                Variables[varName] = boolean;
            }
            else
            {
                Variables[varName] = input;
            }

            return null;
        }

        public override object? VisitValue(GameSharpParser.ValueContext context)
        {
            if (context.NUMBER() is { } number)
                return int.Parse(number.GetText());

            if (context.STRING() is { } str)
                return str.GetText()[1..^1];

            if (context.BOOL() is { } boolean)
                return boolean.GetText() == "verdadero";

            if (context.objectProperty() is { } objProp)
                return VisitObjectProperty(objProp);

            if (context.ID() != null)
            {
                var varName = context.ID().GetText();
                if (Variables.ContainsKey(varName))
                    return Variables[varName];

                foreach (var obj in Objects.Values)
                {
                    if (obj.ContainsKey(varName))
                        return obj[varName];
                }
            }

            return null;
        }

        public override object? VisitObjectProperty(GameSharpParser.ObjectPropertyContext context)
        {
            var objectName = context.ID(0).GetText();
            var propertyName = context.ID(1).GetText();

            if (Objects.ContainsKey(objectName) && Objects[objectName].ContainsKey(propertyName))
            {
                return Objects[objectName][propertyName];
            }

            throw new Exception($"Property {propertyName} not found in object {objectName}");
        }

        public override object? VisitIfStatement(GameSharpParser.IfStatementContext context)
        {
            var condition = (bool)Visit(context.comp_expr());
            if (condition)
            {
                foreach (var cmd in context.command())
                {
                    Visit(cmd);
                }
            }
            else if (context.elseStatement() != null)
            {
                foreach (var cmd in context.elseStatement().command())
                {
                    Visit(cmd);
                }
            }
            return null;
        }

        public override object? VisitWhileStatement(GameSharpParser.WhileStatementContext context)
        {
            while ((bool)Visit(context.comp_expr()))
            {
                foreach (var cmd in context.command())
                {
                    Visit(cmd);
                }
            }
            return null;
        }

        public override object? VisitComp_expr(GameSharpParser.Comp_exprContext context)
        {
            var left = Visit(context.expr(0));
            var right = context.expr().Length > 1 ? Visit(context.expr(1)) : null;
            var op = context.comp_op()?.GetText();

            return op switch
            {
                ">" => (int)left > (int)right,
                "<" => (int)left < (int)right,
                ">=" => (int)left >= (int)right,
                "<=" => (int)left <= (int)right,
                "==" => Equals(left, right),
                "!=" => !Equals(left, right),
                _ => left
            };
        }

        public override object? VisitExpr(GameSharpParser.ExprContext context)
        {
            var left = Visit(context.value(0));

            for (int i = 1; i < context.value().Length; i++)
            {
                var right = Visit(context.value(i));
                var op = context.op(i - 1).GetText();

                if (left is string leftStr || right is string rightStr)
                {
                    left = left?.ToString() + right?.ToString();
                }
                else
                {
                    left = op switch
                    {
                        "+" => Convert.ToInt32(left) + Convert.ToInt32(right),
                        "-" => Convert.ToInt32(left) - Convert.ToInt32(right),
                        "*" => Convert.ToInt32(left) * Convert.ToInt32(right),
                        "/" => Convert.ToInt32(left) / Convert.ToInt32(right),
                        _ => throw new Exception($"Unknown operator: {op}")
                    };
                }
            }

            return left;
        }

        public override object? VisitActionDecl(GameSharpParser.ActionDeclContext context)
        {
            var name = context.ID().GetText();
            Actions[name] = context;
            return null;
        }

        public override object? VisitFunctionCall(GameSharpParser.FunctionCallContext context)
        {
            var actionName = context.ID().GetText();
            if (Actions.ContainsKey(actionName))
            {
                foreach (var cmd in Actions[actionName].command())
                {
                    Visit(cmd);
                }
            }
            else
            {
                throw new Exception($"Action {actionName} not found");
            }
            return null;
        }
    }
}
