using CJM_Editor.cjmparser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CJM_Editor {
    public partial class MainForm:Form {
        private const string UNTITLED = "Untitled";
        private string fileName = UNTITLED;

        public MainForm() {
            InitializeComponent();
            model_CheckedChanged(this,null);
            Text="CJM editor - "+fileName;
        }

        private void model_CheckedChanged(object sender,EventArgs e) {
            reu.Enabled=modelc64.Checked;
            vic20memory.Enabled=modelvic20.Checked;
            bank0.Enabled=modelvic20.Checked;
            bank1.Enabled=modelvic20.Checked;
            bank2.Enabled=modelvic20.Checked;
            bank3.Enabled=modelvic20.Checked;
            bank5.Enabled=modelvic20.Checked;
            if(modelc64.Checked) {
                v.Minimum=-15;
                v.Maximum=17;
            } else if(pal.Checked) {
                v.Minimum=-16;
                v.Maximum=16;
            } else {
                v.Minimum=-13;
                v.Maximum=0;
            }
            joy2.Enabled=modelc64.Checked;
            joy3.Enabled=modelc64.Checked;
            joy4.Enabled=modelc64.Checked;
        }

        private void bank_CheckedChanged(object sender,EventArgs e) {
            if(sender==vic20memory) {
                bank0.Checked=false;
                bank1.Checked=false;
                bank2.Checked=false;
                bank3.Checked=false;
                bank5.Checked=false;
            } else {
                vic20memory.Text="";
            }
        }

        private void joy_Click(object sender,EventArgs e) {
            var dlg = new JoyConfig();
            if(dlg.ShowDialog()==DialogResult.OK) { }
        }

        private void openToolStripMenuItem_Click(object sender,EventArgs e) {
            if(openFileDialog1.ShowDialog()==DialogResult.OK) {
                var text = File.ReadAllText(openFileDialog1.FileName);
                var lexer = new CJMLexer(text);
                var token = lexer.GetNextToken();
                while(token.TokenType!=Token.EOF) {
                    Console.WriteLine(token);
                    token=lexer.GetNextToken();
                }

            }
        }

        private void saveToolStripMenuItem_Click(object sender,EventArgs e) {
            if(fileName==UNTITLED) {
                saveAsToolStripMenuItem_Click(sender,e);
            } else {
                SaveFile();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender,EventArgs e) {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK) {
                fileName=saveFileDialog1.FileName;
                Text="CJM editor - "+fileName;
                SaveFile();
            }
        }

        /// <summary>
        /// Saves the file.
        /// </summary>
        private void SaveFile() {
            using(var file=new StreamWriter(fileName)) {
                var outarray = new List<string>();
                if(modelc64.Checked) outarray.Add("c64");
                if(modelvic20.Checked) outarray.Add("vic");
                if(pal.Checked) outarray.Add("pal");
                if(ntsc.Checked) outarray.Add("ntsc");
                if(driveicon.Checked) outarray.Add("driveicon");
                if(_readonly.Checked) outarray.Add("readonly");
                if(accuratedisk.Checked) outarray.Add("accuratedisk");
                if(fullheight.Checked) outarray.Add("fullheight");
                if(noaudioscale.Checked) outarray.Add("noaudioscale");
                if(modelvic20.Checked) {
                    if(bank0.Checked) outarray.Add("bank0");
                    if(bank1.Checked) outarray.Add("bank1");
                    if(bank2.Checked) outarray.Add("bank2");
                    if(bank3.Checked) outarray.Add("bank3");
                    if(bank5.Checked) outarray.Add("bank5");
                    if(vic20memory.Text!="") outarray.Add(vic20memory.Text);
                }
                if(modelc64.Checked &&reu.Text!="") {
                    switch(reu.Text) {
                        case "Reu 512 Kb":
                            outarray.Add("reu512");
                            break;
                        case "Reu 2 Mb":
                            outarray.Add("reu2048");
                            break;
                        case "Reu 16 Mb":
                            outarray.Add("reu16384");
                            break;
                    }
                }
                file.WriteLine("X:"+string.Join(",",outarray));
                //Ide jön a joy
                if (!fullheight.Checked) file.WriteLine("V:"+v.Value);
                toolStatus.Text="Saved";
            }
        }

        private void fullheight_CheckedChanged(object sender,EventArgs e) {
            v.Enabled=!fullheight.Checked;
        }
    }
}
