grammar test;
input: EOL*? (mnemonic (EOL* mnemonic)*)? EOF;
mnemonic: inst | inst WS+ (operand (WS+ operand)*)?;
device1: TEXT UINT (TEXT UINT?)?;           //ワード中ビットをサポートできる形式
device2: TEXT UINT TEXT (UINT | REAL_FULL)?
        | TEXT (UINT | REAL_FULL)
        | TEXT
        | UINT
        ;
device3: TM (UINT | REAL_FULL);                 //#TM
operand: indirect
        | index_ref
        | AT? (device1 | device2 | UINT)
        | device3
        | direct_value
        | QUESTION+
        | LITERAL;
inst: TEXT (OPERATOR | ASTERISK)? SUFFIX?;                  //数字を含んだ命令後あったはずだけど放置
indirect: ASTERISK AT? (device1 | index_ref?);
index_ref: AT? (device1 | UINT) COLON (DEC | SINT | UINT | device1);        // UINT > deviceでないと1がR1で解釈される
direct_value: DEC | HEX | SINT | REAL_FULL | REAL_DOT_DIGIT | REAL_DIGIT_DOT | FLOAT | EXP;        //直値

UINT: DIGIT;
REAL_FULL: DIGIT DOT DIGIT;
REAL_DOT_DIGIT: DOT DIGIT;
REAL_DIGIT_DOT: DIGIT DOT;
REAL: REAL_FULL | REAL_DOT_DIGIT | REAL_DIGIT_DOT;

SINT: (PLUS | MINUS) (DIGIT | REAL);
DEC: (K | SHARP) (SINT | UINT | EXP);
HEX: (H | '$') [0-9a-fA-F]+;
FLOAT: (K | SHARP) (EXP | REAL);
EXP: (DIGIT | REAL | SINT) E (DIGIT | SINT);

SUFFIX: DOT TEXT;
LITERAL: DQ (DQ DQ | N_DQ)* DQ;
TEXT: [_a-zA-Z]+;
AT: '@';
QUESTION: '?';
COLON: ':';
OPERATOR: '~' | '=' | '<<' | '>>' | '<>' | '<' | '>' | '|' | '<=' | '>=' | PLUS | MINUS | '/' | '^' | '&';
ASTERISK: '*';
TM: SHARP T M;

EOL: '\r' | '\n' | '\r\n';
WS: ' ';

fragment E: [Ee];
fragment H: [Hh];
fragment K: [Kk];
fragment M: [Mm];
fragment T: [Tt];
fragment DIGIT: [0-9]+;
fragment SHARP: '#';
fragment PLUS: '+';
fragment MINUS: '-';
fragment DOT: '.';
fragment DQ: '"';
fragment N_DQ: ~["];
