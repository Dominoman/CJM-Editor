namespace CjmEditor.CjmParser {
    /// <summary>
    /// 
    /// </summary>
    abstract class Lexer {
        protected const char EOF = char.MaxValue;
        private readonly string script;
        protected char c;
        private int p = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Lexer"/> class.
        /// </summary>
        /// <param name="script">The script.</param>
        protected Lexer(string script) {
            this.script=script;
            c=string.IsNullOrEmpty(script) ? EOF : script[0];
        }

        /// <summary>
        /// Consumes this instance.
        /// </summary>
        protected void Consume() {
            p++;
            c=p>=script.Length ? EOF : script[p];
        }

        public abstract Token GetNextToken();
    }
}
