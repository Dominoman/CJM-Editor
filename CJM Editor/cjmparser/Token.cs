using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJM_Editor.cjmparser {
    /// <summary>
    ///   <br />
    /// </summary>
    class Token {
        public const int EOF = -1;
        public const int EOL = -2;
        public const int TEXT = -3;
        public const int NUMBER = -4;

        public int TokenType { get; private set; }
        public int IntValue { get; private set; }
        public string StrValue { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Token"/> class.
        /// </summary>
        /// <param name="tokenType">Type of the token.</param>
        /// <param name="intValue">The int value.</param>
        public Token(int tokenType,int intValue = 0) {
            TokenType=tokenType;
            IntValue=intValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Token"/> class.
        /// </summary>
        /// <param name="tokenType">Type of the token.</param>
        /// <param name="strValue">The string value.</param>
        public Token(int tokenType,string strValue) {
            TokenType=tokenType;
            StrValue=strValue;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <param name="tokenType">Type of the token.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public static string ToString(int tokenType) {
            switch(tokenType) {
                case EOF: return "<EOF>";
                case EOL: return "<EOL>";
                case TEXT: return "<TEXT>";
                case NUMBER: return "<NUMBER>";
                default: return $"<{(char)tokenType}>";
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString() {
            switch(TokenType) {
                case TEXT: return $"<TEXT:{StrValue}>";
                case NUMBER: return $"<NUMBER:{IntValue}>";
                default: return ToString(TokenType);
            }
        }
    }
}
