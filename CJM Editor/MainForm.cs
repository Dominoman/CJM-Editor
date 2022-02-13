using CjmEditor.CjmParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CjmEditor {
    public partial class MainForm:Form {
        private const string UNTITLED = "Untitled";
        private string fileName = UNTITLED;
        private Dictionary<string,Control> controls;
        private string[] banks = { "bank0","bank1","bank2","bank3","bank5" };
        private string[] ks = { "3k","4k","8k","16k","24k","32k","35k" };
        private Dictionary<string,string> reus = new Dictionary<string, string>{ {"reu512","Reu 512 Kb" },{ "reu2048","Reu 2 Mb" },{"reu16384","Reu 16 Mb" } };
                        
        public MainForm() {
            InitializeComponent();
            Model_CheckedChanged(this,null);
            Text="CJM editor - "+fileName;
            controls=new Dictionary<string,Control> { { "c64",modelc64 },{"vic",modelvic20 },{"pal",pal},{"ntsc",ntsc},{"driveicon",driveicon},
                {"readonly",_readonly },{"accuratedisk",accuratedisk },{"fullheight",fullheight},{"noaudioscale",noaudioscale}};
            var tooltip = new ToolTip {
                AutoPopDelay=5000,
                InitialDelay=1000,
                ReshowDelay=500,
                ShowAlways=true,
            };
            tooltip.SetToolTip(modelc64,"Specifies a C64 computer model (THEC64 only).");
            tooltip.SetToolTip(modelvic20,"Specifies a VIC 20 computer model (THEC64 only).");
            tooltip.SetToolTip(pal,"This makes the program behave as though running on a European (PAL) computer. It doesn’t affect the HDMI output of THEC64/THEVIC20.");
            tooltip.SetToolTip(ntsc,"This makes the program behave as though running on a North American (NTSC) computer. It doesn’t affect the HDMI output of THEC64/THEVIC20.");
            tooltip.SetToolTip(driveicon,"This activates the on-screen drive icon, to show when a disk is accessed.");
            tooltip.SetToolTip(_readonly,"This makes a disk read-only, meaning THEC64/THEVIC20 cannot write back to the virtual disk.");
            tooltip.SetToolTip(accuratedisk,"This switches ON accurate (slower) disk drive functionality, necessary for some programs to load correctly from a d64 or g64 file. This is off by default.");
            tooltip.SetToolTip(fullheight,"This displays the full height of the computer display when running the program, sacrificing the accurate display to fit everything into the 720p image");
            tooltip.SetToolTip(noaudioscale,"This turns off the Audio scaling option, which is enabled by default.");
            tooltip.SetToolTip(bank0,"Use VIC 20 expanded memory bank 0.");
            tooltip.SetToolTip(bank1,"Use VIC 20 expanded memory bank 1.");
            tooltip.SetToolTip(bank2,"Use VIC 20 expanded memory bank 2.");
            tooltip.SetToolTip(bank3,"Use VIC 20 expanded memory bank 3.");
            tooltip.SetToolTip(bank5,"Use VIC 20 expanded memory bank 5.");
        }

        private void Model_CheckedChanged(object sender,EventArgs e) {
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

        private void Bank_CheckedChanged(object sender,EventArgs e) {
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

        private void Joy_Click(object sender,EventArgs e) {
            var dlg = new JoyConfig();
            if(dlg.ShowDialog()==DialogResult.OK) { }
        }

        private void OpenToolStripMenuItem_Click(object sender,EventArgs e) {
            if(openFileDialog1.ShowDialog()==DialogResult.OK) {
                var text = File.ReadAllText(openFileDialog1.FileName);
                fileName=openFileDialog1.FileName;
                ResetControls();
                var lexer = new CjmLexer(text);
                var parser = new CjmParser.CjmParser(lexer);
                var line = parser.GetNextLine();
                while(line!=null) {
                    switch(line.LineType) {
                        case LineType.XType:
                            foreach(var item in line.Params) {
                                if(controls.ContainsKey(item)) {
                                    if(controls[item] is CheckBox) (controls[item] as CheckBox).Checked=true;
                                    else if(controls[item] is RadioButton) (controls[item] as RadioButton).Checked=true;
                                    else throw new NotSupportedException();
                                }else if(banks.Contains(item)) {
                                    var control = groupBox4.Controls[item] as CheckBox;
                                    control.Checked=true;
                                }else if(ks.Contains(item)) {
                                    vic20memory.Text=item;
                                }else if(reus.ContainsKey(item)) {
                                    reu.Text=reus[item];
                                }                                
                            }
                            break;
                        case LineType.JType:
                            break;
                        case LineType.VType:
                            v.Value=line.VerticalShift;
                            break;
                    }
                    line = parser.GetNextLine();
                }

            }
            toolStatus.Text="Loaded";
            Text="CJM editor - "+fileName;
        }

        /// <summary>
        /// Resets the controls.
        /// </summary>
        private void ResetControls() {
            modelc64.Checked=true;
            pal.Checked=true;
            reu.Text="";
            vic20memory.Text="";
            bank0.Checked=false;
            bank1.Checked=false;
            bank2.Checked=false;
            bank3.Checked=false;
            bank5.Checked=false;
            driveicon.Checked=false;
            _readonly.Checked=false;
            accuratedisk.Checked=false;
            fullheight.Checked=false;
            noaudioscale.Checked=false;
            v.Value=0;
        }

        private void SaveToolStripMenuItem_Click(object sender,EventArgs e) {
            if(fileName==UNTITLED) {
                SaveAsToolStripMenuItem_Click(sender,e);
            } else {
                SaveFile();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender,EventArgs e) {
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
                foreach(var item in controls) {
                    if(item.Value is CheckBox && ((CheckBox)item.Value).Checked) outarray.Add(item.Key);
                    else if(item.Value is RadioButton && ((RadioButton)item.Value).Checked) outarray.Add(item.Key);
                }
                if(modelvic20.Checked) {
                    foreach(var bank in banks) {
                        var control = groupBox4.Controls[bank] as CheckBox;                        
                        if(control.Checked) outarray.Add(bank);
                    }
                    if(vic20memory.Text!="") outarray.Add(vic20memory.Text);
                }
                if(modelc64.Checked &&reu.Text!="") {
                    outarray.Add(reus.FirstOrDefault(x => x.Value==reu.Text).Key);
                }
                file.WriteLine("X:"+string.Join(",",outarray));
                //Ide jön a joy
                if (!fullheight.Checked) file.WriteLine("V:"+v.Value);
                toolStatus.Text="Saved";
            }
        }

        private void Fullheight_CheckedChanged(object sender,EventArgs e) {
            v.Enabled=!fullheight.Checked;
        }

        private void NewToolStripMenuItem_Click(object sender,EventArgs e) {
            ResetControls();
        }
    }
}
