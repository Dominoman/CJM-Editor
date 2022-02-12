using System;

namespace CjmEditor.CjmParser {
    class CjmParser:Parser {
        public CjmParser(Lexer input) : base(input) {

        }

        public CjmLine GetNextLine() {
            if(LA(1)==Token.EOF) return null;
            if(LA(1)==Token.TEXT && LA(2)==':') {
                switch(LT(1).StrValue) {
                    case "X":
                        return ParseX();
                    case "J":
                        return ParseJ();
                    case "V":
                        return ParseV();
                    default:
                        break;
                }
            }
            throw new NotImplementedException();
        }

        private CjmLine ParseX() {
            var line = new CjmLine {
                LineType=LineType.XType
            };
            Consume();
            Match(':');
            if(LA(1)==Token.TEXT) {
                line.Params.Add(LT(1).StrValue);
                Consume();
                while(LA(1)!=Token.EOF&&LA(1)!=Token.EOL) {
                    Match(',');
                    line.Params.Add(LT(1).StrValue);
                    Consume();
                }
            }
            if(LA(1)!=Token.EOF) Match(Token.EOL);
            return line;
        }

        private CjmLine ParseJ() {
            var line = new CjmLine {
                LineType=LineType.XType
            };
            Consume();
            Match(':');
            line.Port=int.Parse(LT(1).StrValue);
            Match(Token.TEXT);
            if(LA(1)=='*') {
                line.DefaultPort=true;
                Consume();
            }
            Match(':');
            if(LA(1)==Token.TEXT) {
                line.Params.Add(LT(1).StrValue);
                Consume();
                while(LA(1)!=Token.EOF&&LA(1)!=Token.EOL) {
                    Match(',');
                    line.Params.Add(LT(1).StrValue);
                    Consume();
                }
            }
            if(LA(1)!=Token.EOF) Match(Token.EOL);
            return line;
        }

        private CjmLine ParseV() {
            var line = new CjmLine {
                LineType=LineType.XType
            };
            Consume();
            Match(':');
            line.VerticalShift=int.Parse(LT(1).StrValue);
            Consume();
            if(LA(1)!=Token.EOF) Match(Token.EOL);
            return line;
        }
    }
}
