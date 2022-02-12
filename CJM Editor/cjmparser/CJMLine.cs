using System.Collections.Generic;

namespace CjmEditor.CjmParser {
    public enum LineType { XType,JType,VType}

    public class CjmLine {
        public LineType LineType {get;set;}
        public int Port { get; internal set; }
        public bool DefaultPort { get; internal set; }
        public int VerticalShift { get; internal set; }

        public readonly List<string> Params = new List<string>();
    }
}