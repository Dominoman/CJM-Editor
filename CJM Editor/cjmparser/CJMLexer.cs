﻿using System;
using System.Text;

namespace CJM_Editor.cjmparser {
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CJM_Editor.cjmparser.Lexer" />
    class CJMLexer:Lexer {
        [Flags]
        private enum Ct { None=0, Whitespace=1,Digit=2,Alpha=4}
        private readonly Ct[] ctype = new Ct[256];
        private Ct Ctype => 0<=c&&c<=ctype.Length ? ctype[c] : Ct.Alpha;

        /// <summary>
        /// Initializes a new instance of the <see cref="CJMLexer"/> class.
        /// </summary>
        /// <param name="script">The script.</param>
        public CJMLexer(string script) : base(script) {
            AddWhiteSpaces(0,' ');
            AddAlphas('a','z');
            AddAlphas('A','Z');
            AddDigits();
        }

        /// <summary>
        /// Adds the white spaces.
        /// </summary>
        /// <param name="low">The low.</param>
        /// <param name="high">The high.</param>
        private void AddWhiteSpaces(int low,int high) {
            while(low<=high) {
                ctype[low++]|=Ct.Whitespace;
            }
        }

        /// <summary>
        /// Adds the alphas.
        /// </summary>
        /// <param name="low">The low.</param>
        /// <param name="high">The high.</param>
        private void AddAlphas(int low,int high) {
            while(low<=high) {
                ctype[low++]|=Ct.Alpha;
            }
        }

        /// <summary>
        /// Adds the digits.
        /// </summary>
        private void AddDigits() {
            for(var i = '0';i<='9';i++) {
                ctype[i]|=Ct.Digit;
            }
        }

        /// <summary>
        /// Gets the next token.
        /// </summary>
        /// <returns></returns>
        public override Token GetNextToken() {
            while(c!=EOF) {
                if(c=='\r' ||c=='\n') {
                    SkipEOL();
                    return new Token(Token.EOL);
                }
                if(Ctype.HasFlag(Ct.Whitespace)) SkipWhiteSpace();
                if(Ctype.HasFlag(Ct.Digit)) return GetNumber();
                if(Ctype.HasFlag(Ct.Alpha)) return GetText();
                var tmp = c;
                Consume();
                return new Token(tmp);
            }
            return new Token(Token.EOF);
        }

        /// <summary>
        /// Skips the eol.
        /// </summary>
        private void SkipEOL() {
            while(c=='\r'||c=='\n') Consume();
        }

        /// <summary>
        /// Skips the white space.
        /// </summary>
        private void SkipWhiteSpace() {
            while(Ctype.HasFlag(Ct.Whitespace)) Consume();
        }

        /// <summary>
        /// Gets the number.
        /// </summary>
        /// <returns></returns>
        private Token GetNumber() {
            var sb = new StringBuilder();
            while(Ctype.HasFlag(Ct.Digit)) {
                sb.Append(c);
                Consume();
            }
            return new Token(Token.NUMBER,int.Parse(sb.ToString()));
        }

        /// <summary>
        /// Gets the text.
        /// </summary>
        /// <returns></returns>
        private Token GetText() {
            var sb = new StringBuilder();
            while(Ctype.HasFlag(Ct.Alpha)) {
                sb.Append(c);
                Consume();
            }
            return new Token(Token.TEXT,sb.ToString());
        }
    }
}
