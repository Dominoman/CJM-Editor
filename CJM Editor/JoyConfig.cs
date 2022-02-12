using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CjmEditor {
    public partial class JoyConfig:Form {
        private const int CONTROLCOUNT = 15;
        private Dictionary<string,string> dictionary = new Dictionary<string,string>{
            {"","" },
{"JU","Joy Up"},
{"JD","Joy Down"},
{"JL","Joy Left"},
{"JR","Joy Right"},
{"JF","Joy Fire"},
{"F1","F1"},
{"F2","F2"},
{"F3","F3"},
{"F4","F4"},
{"F5","F5"},
{"F6","F6"},
{"F7","F7"},
{"F8","F8"},
{"A","A"},
{"B","B"},
{"C","C"},
{"D","D"},
{"E","E"},
{"F","F"},
{"G","G"},
{"H","H"},
{"I","I"},
{"J","J"},
{"K","K"},
{"L","L"},
{"M","M"},
{"N","N"},
{"O","O"},
{"P","P"},
{"Q","Q"},
{"R","R"},
{"S","S"},
{"T","T"},
{"U","U"},
{"V","V"},
{"W","W"},
{"X","X"},
{"Y","Y"},
{"Z","Z"},
{"0","0"},
{"1","1"},
{"2","2"},
{"3","3"},
{"4","4"},
{"5","5"},
{"6","6"},
{"7","7"},
{"8","8"},
{"9","9"},
{"AL","Left arrow"},
{"AU","Up Arrow"},
{"CM","Commodore key"},
{"CO","Coma"},
{"CT","CTRL"},
{"CU","Cursor Up"},
{"CD","Cursor Down"},
{"CL","Cursor Left"},
{"CR","Cursor Right"},
{"DL","Inst / Del"},
{"EN","Return"},
{"HM","CLR / Home"},
{"RS","Run Stop"},
{"RE","Restore"},
{"SL","Left Shift"},
{"SR","Right Shift"},
{"SS","Shift Lock"},
{"SP","Space"},
{"PO","Pound (£)"},
        };

        public JoyConfig() {
            InitializeComponent();
            var items = dictionary.Values.ToArray();
            for(var i = 0;i<CONTROLCOUNT;i++) {
                var control = (ComboBox)Controls["j"+i];
                control.Items.AddRange(items);
            }
        }
    }
}
