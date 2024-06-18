// Generated from /Users/angellollerena/Documents/GitHub/compilador/Gamecsharp.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link GamecsharpParser}.
 */
public interface GamecsharpListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#prog}.
	 * @param ctx the parse tree
	 */
	void enterProg(GamecsharpParser.ProgContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#prog}.
	 * @param ctx the parse tree
	 */
	void exitProg(GamecsharpParser.ProgContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#statement}.
	 * @param ctx the parse tree
	 */
	void enterStatement(GamecsharpParser.StatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#statement}.
	 * @param ctx the parse tree
	 */
	void exitStatement(GamecsharpParser.StatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#objectDecl}.
	 * @param ctx the parse tree
	 */
	void enterObjectDecl(GamecsharpParser.ObjectDeclContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#objectDecl}.
	 * @param ctx the parse tree
	 */
	void exitObjectDecl(GamecsharpParser.ObjectDeclContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#objectBody}.
	 * @param ctx the parse tree
	 */
	void enterObjectBody(GamecsharpParser.ObjectBodyContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#objectBody}.
	 * @param ctx the parse tree
	 */
	void exitObjectBody(GamecsharpParser.ObjectBodyContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#propertyDecl}.
	 * @param ctx the parse tree
	 */
	void enterPropertyDecl(GamecsharpParser.PropertyDeclContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#propertyDecl}.
	 * @param ctx the parse tree
	 */
	void exitPropertyDecl(GamecsharpParser.PropertyDeclContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#eventHandler}.
	 * @param ctx the parse tree
	 */
	void enterEventHandler(GamecsharpParser.EventHandlerContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#eventHandler}.
	 * @param ctx the parse tree
	 */
	void exitEventHandler(GamecsharpParser.EventHandlerContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#eventType}.
	 * @param ctx the parse tree
	 */
	void enterEventType(GamecsharpParser.EventTypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#eventType}.
	 * @param ctx the parse tree
	 */
	void exitEventType(GamecsharpParser.EventTypeContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#actionDecl}.
	 * @param ctx the parse tree
	 */
	void enterActionDecl(GamecsharpParser.ActionDeclContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#actionDecl}.
	 * @param ctx the parse tree
	 */
	void exitActionDecl(GamecsharpParser.ActionDeclContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#command}.
	 * @param ctx the parse tree
	 */
	void enterCommand(GamecsharpParser.CommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#command}.
	 * @param ctx the parse tree
	 */
	void exitCommand(GamecsharpParser.CommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#assignment}.
	 * @param ctx the parse tree
	 */
	void enterAssignment(GamecsharpParser.AssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#assignment}.
	 * @param ctx the parse tree
	 */
	void exitAssignment(GamecsharpParser.AssignmentContext ctx);
	/**
	 * Enter a parse tree produced by the {@code Numero}
	 * labeled alternative in {@link GamecsharpParser#expr}.
	 * @param ctx the parse tree
	 */
	void enterNumero(GamecsharpParser.NumeroContext ctx);
	/**
	 * Exit a parse tree produced by the {@code Numero}
	 * labeled alternative in {@link GamecsharpParser#expr}.
	 * @param ctx the parse tree
	 */
	void exitNumero(GamecsharpParser.NumeroContext ctx);
	/**
	 * Enter a parse tree produced by the {@code AddSub}
	 * labeled alternative in {@link GamecsharpParser#expr}.
	 * @param ctx the parse tree
	 */
	void enterAddSub(GamecsharpParser.AddSubContext ctx);
	/**
	 * Exit a parse tree produced by the {@code AddSub}
	 * labeled alternative in {@link GamecsharpParser#expr}.
	 * @param ctx the parse tree
	 */
	void exitAddSub(GamecsharpParser.AddSubContext ctx);
	/**
	 * Enter a parse tree produced by the {@code Parentesis}
	 * labeled alternative in {@link GamecsharpParser#expr}.
	 * @param ctx the parse tree
	 */
	void enterParentesis(GamecsharpParser.ParentesisContext ctx);
	/**
	 * Exit a parse tree produced by the {@code Parentesis}
	 * labeled alternative in {@link GamecsharpParser#expr}.
	 * @param ctx the parse tree
	 */
	void exitParentesis(GamecsharpParser.ParentesisContext ctx);
	/**
	 * Enter a parse tree produced by the {@code Identicador}
	 * labeled alternative in {@link GamecsharpParser#expr}.
	 * @param ctx the parse tree
	 */
	void enterIdenticador(GamecsharpParser.IdenticadorContext ctx);
	/**
	 * Exit a parse tree produced by the {@code Identicador}
	 * labeled alternative in {@link GamecsharpParser#expr}.
	 * @param ctx the parse tree
	 */
	void exitIdenticador(GamecsharpParser.IdenticadorContext ctx);
	/**
	 * Enter a parse tree produced by the {@code Multiplicacionydivision}
	 * labeled alternative in {@link GamecsharpParser#expr}.
	 * @param ctx the parse tree
	 */
	void enterMultiplicacionydivision(GamecsharpParser.MultiplicacionydivisionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code Multiplicacionydivision}
	 * labeled alternative in {@link GamecsharpParser#expr}.
	 * @param ctx the parse tree
	 */
	void exitMultiplicacionydivision(GamecsharpParser.MultiplicacionydivisionContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#ifStatement}.
	 * @param ctx the parse tree
	 */
	void enterIfStatement(GamecsharpParser.IfStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#ifStatement}.
	 * @param ctx the parse tree
	 */
	void exitIfStatement(GamecsharpParser.IfStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#whileStatement}.
	 * @param ctx the parse tree
	 */
	void enterWhileStatement(GamecsharpParser.WhileStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#whileStatement}.
	 * @param ctx the parse tree
	 */
	void exitWhileStatement(GamecsharpParser.WhileStatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#functionCall}.
	 * @param ctx the parse tree
	 */
	void enterFunctionCall(GamecsharpParser.FunctionCallContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#functionCall}.
	 * @param ctx the parse tree
	 */
	void exitFunctionCall(GamecsharpParser.FunctionCallContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#exprList}.
	 * @param ctx the parse tree
	 */
	void enterExprList(GamecsharpParser.ExprListContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#exprList}.
	 * @param ctx the parse tree
	 */
	void exitExprList(GamecsharpParser.ExprListContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#value}.
	 * @param ctx the parse tree
	 */
	void enterValue(GamecsharpParser.ValueContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#value}.
	 * @param ctx the parse tree
	 */
	void exitValue(GamecsharpParser.ValueContext ctx);
	/**
	 * Enter a parse tree produced by {@link GamecsharpParser#printStatement}.
	 * @param ctx the parse tree
	 */
	void enterPrintStatement(GamecsharpParser.PrintStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link GamecsharpParser#printStatement}.
	 * @param ctx the parse tree
	 */
	void exitPrintStatement(GamecsharpParser.PrintStatementContext ctx);
}