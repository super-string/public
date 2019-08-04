grammar test;
input: EOL* (mnemonic EOL*)* EOF;
mnemonic: inst
        | inst WS+ ((indirect | device | direct_value | LITERAL) WS*)*;
inst: TEXT (OPERATOR | ASTERISK)? SUFFIX?;
device: AT?                             //ローカル
            ( TEXT UINT TEXT UINT?
            | SHARP? TEXT (UINT | REAL)                     //Tだけ特殊
            | TEXT                                          //label, system label
            | UINT                                          //数値のみの直値は暗黙的にR
            ) index_ref?                //インデックス修飾
       | QUESTION+;                     //???デバイス
indirect: ASTERISK device;              //関節参照
index_ref: COLON (DEC | HEX | SINT | device);// UINT > deviceでないと1がR1で解釈される
direct_value: DEC | HEX | SINT | REAL | FLOAT | EXP;       //直値

UINT: DIGIT;
SINT: (PLUS | MINUS) (DIGIT | REAL);
DEC: (K | SHARP) (SINT | UINT | EXP);
HEX: (H | '$') [0-9a-fA-F]+;

FLOAT: (K | SHARP) (EXP | REAL);
REAL: DIGIT DOT DIGIT | DIGIT DOT | DOT DIGIT;
EXP: DIGIT E DIGIT | REAL E DIGIT | SINT E SINT | REAL E SINT;

SUFFIX: DOT TEXT;
LITERAL: DQ (DQ DQ | N_DQ)* DQ;
TEXT: DIGIT | [_a-zA-Z]+;
AT: '@';
SHARP: '#';
QUESTION: '?';
COLON: ':';
OPERATOR: '~' | '=' | '<<' | '>>' | '<>' | '<' | '>' | '|' | '<=' | '>=' | PLUS | MINUS | '/' | '^';
ASTERISK: '*';

EOL: '\r' | '\n' | '\r\n';
WS: ' ';

fragment E: [Ee];
fragment H: [Hh];
fragment K: [Kk];
fragment DIGIT: [0-9]+;
fragment PLUS: '+';
fragment MINUS: '-';
fragment DOT: '.';
fragment DQ: '"';
fragment N_DQ: ~["];
