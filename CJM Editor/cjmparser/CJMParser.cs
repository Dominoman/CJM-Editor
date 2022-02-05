using System;

namespace CJM_Editor.cjmparser {
    class CJMParser:Parser {
        public CJMParser(Lexer input) : base(input) {

        }

        public CJMLine GetNextLine() {
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

        private CJMLine ParseX() {
            throw new NotImplementedException();
        }

        private CJMLine ParseJ() {
            throw new NotImplementedException();
        }

        private CJMLine ParseV() {
            throw new NotImplementedException();
        }
    }
}
