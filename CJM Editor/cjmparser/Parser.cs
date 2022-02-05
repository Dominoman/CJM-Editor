using System;
using System.Collections.Generic;

namespace CJM_Editor.cjmparser {
    /// <summary>
    /// 
    /// </summary>
    class Parser {
        private readonly Lexer input;
        private readonly List<Token> lookahead = new List<Token>();
        private int p;

        /// <summary>
        /// Initializes a new instance of the <see cref="Parser"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public Parser(Lexer input) {
            this.input=input;
            Sync(1);
        }

        /// <summary>
        /// Synchronizes the specified i.
        /// </summary>
        /// <param name="i">The i.</param>
        private void Sync(int i) {
            var n = p+i-lookahead.Count;
            for(var j = 0;j<n;j++) lookahead.Add(input.GetNextToken());
        }


        /// <summary>
        /// Consumes this instance.
        /// </summary>
        protected void Consume() {
            p++;
            if(p==lookahead.Count) {
                p=0;
                lookahead.Clear();
            }
            Sync(1);
        }

        /// <summary>
        /// Lts the specified i.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        protected Token LT(int i) {
            Sync(i);
            return lookahead[p+i-1];
        }

        /// <summary>
        /// Las the specified i.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        protected int LA(int i) => LT(i).TokenType;

        /// <summary>
        /// Matches the specified i.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <exception cref="System.Exception">Token mismatch! Expected:{Token.ToString(i)}, found:{LT(1)}</exception>
        protected void Match(int i) {
            if(LA(1)==i) Consume();
            throw new Exception($"Token mismatch! Expected:{Token.ToString(i)}, found:{LT(1)}");
        }
    }
}
