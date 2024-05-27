grammar Gamecsharp;

prog:   statement* ;

statement: 
      objectDecl
    | eventHandler
    | actionDecl
    | command
    ;

// Declaración de objetos  personajes
objectDecl: 'object' ID '{' objectBody '}' ;
objectBody: (propertyDecl ';')* ;
propertyDecl: 'property' ID '=' value ;

// Manejo de eventos como clics o teclado
eventHandler: 'on' eventType '{' command* '}' ;
eventType: 'click' | 'keydown' | 'keyup' | 'mousemove' ;

// Acciones definidas por el usuario
actionDecl: 'action' ID '{' command* '}' ;

// Comandos dentro de acciones  de eventos
command: 
      assignment
    | ifStatement
    | whileStatement
    | functionCall
    | printStatement
    ;

// Asignación y expresiones
assignment: ID '=' expr ';' ;
expr: 
      expr ('*' | '/') expr   # Multiplicacionydivision
    | expr ('+' | '-') expr   # AddSub
    | '(' expr ')'            # Parentesis
    | NUMBER                  # Numero
    | ID                      # Identicador
    ;

// Estructuras de control de flujo
ifStatement: 'if' '(' expr ')' '{' command* '}' ;
whileStatement: 'while' '(' expr ')' '{' command* '}' ;

// Llamadas a funciones predefinidas
functionCall: ID '(' exprList ')' ';' ;
exprList: expr (',' expr)* ;

// Valores
value: STRING | NUMBER | 'true' | 'false' | ID ;

//Imprimir en consola 
printStatement: 'print' '(' expr ')' ';' ;
// Tokens
ID     : [a-zA-Z_][a-zA-Z0-9_]* ; // Identificadores
NUMBER : [0-9]+ ;                 // Números enteros
STRING : '"' [^"]* '"' ;          // Cadenas de texto
WS     : [ \t\r\n]+ -> skip ;     // Espacios en blanco y saltos de línea