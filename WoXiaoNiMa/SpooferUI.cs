using SuperGalacticFederation.LangHelpers;
using SuperGalacticFederation.Spoofing;
using SuperGalacticFederation.Settings;
using SuperGalacticFederation.Controls;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace WoCaoNiMa{
public partial class SpooferUI : Form{

public Spoofer sgfSpoof;
public SettingHandler MainSettings;
public SettingHandler BackupHWID;
public ThemeManager ToolTheme=new ThemeManager();
public ThemeColors Colors=new ThemeColors();

public void Redraw() {
ToolTheme.AutoSetupControls(this,
(X) => {//Default
if(X.AccessibleRole == AccessibleRole.Grip){ 
X.BackColor= Colors.GripColor;
X.ForeColor= Colors.GripColor;
}else{
X.BackColor= Colors.BackColor;
X.ForeColor= Colors.FontColor;
}
},
(X) => {//IfForm

},
(X) => {//IfButton
X.FlatStyle= FlatStyle.Flat;
},
(X) => {//IfLabel

},
(X) => {//IfTextBox

},
(X) => { //IfRichTextBox

},
(X) => { //IfPanel

},
(X) => { //IfSplitContainer

},
(X) => {//IfSplitter

},
(X) => {//IfListBox

},
(X) => { //IfListView

});
}

public void LoadFromBackupFile() { 
if(BackupHWID.FileExists){
BackupHWID.LoadFile();

}        
}
        
public string RegSep= SuperGalacticFederation.Other.Rare.píxiū;
public void InitializeBackups() { 
var X=new List<Setting>();
foreach(Spoofable Spoof in sgfSpoof.SpoofableList) { 
X.Add(new Setting((Spoof.RegHack.GetRegKey().ToString().TrimEnd('\\')+"\\"+ Spoof.RegHack.Location.TrimEnd('\\') + RegSep + Spoof.RegHack.Name).Replace("\\\\","\\"), Spoof.RegHack.Tamper, typeof(string),
XE => {
var xxx = XE.Name.Split(RegSep.ToCharArray()[0]);
var X2=Microsoft.Win32.Registry.GetValue(xxx[0],xxx[1], null);
if(X2 != null){
MessageBox.Show("Path: "+xxx[0]+"\nValue Name: "+xxx[1]+"\nValue: "+(string)X2);
}
}));}
BackupHWID =new SettingHandler("Backups",
Environment.CurrentDirectory+"\\Backups.gsfsettings"
, X.ToArray());  
if(!BackupHWID.FileExists){
BackupHWID.SaveFile();}
}

public void InitializeMainSettings(){
MainSettings = new SettingHandler("Main",
Environment.CurrentDirectory+"\\"+"AppsSettings.gsfsettings"
,new []{

new Setting("Lang", Program.CurLanguage.ToString(),typeof(string), (X) =>{
LoadLanguage(LanguageUtils.FromString(X.Value as string));
}),

new Setting("Redact", IsRedacted.Checked,typeof(bool), (X) =>{
IsRedacted.Checked=((bool)(X).Value);
})

});
}

public SpooferUI(){
InitializeComponent();
IsRedacted.CheckedChanged += (X, E) => {
MainSettings.UpdateSettingByName("Redact",IsRedacted.Checked);
LoadLanguage(Program.CurLanguage);
};
InitializeMainSettings();
InitializeSpooflist();
InitializeLangs();
InitializeBackups();
LoadLanguage(Lang.Chinese);
MainSettings.LoadFile();
Redraw();
}

public void LoadLanguage(Lang New) {
Program.CurLanguage = New;
SpoofInfo.Lines = (string[])Translating.CurrentInfo(Program.CurLanguage);
this.Text= Translating.SpooferUITitle.Current(Program.CurLanguage);
Langs.SelectedIndex= LanguageUtils.LangToIndex( Program.CurLanguage);
RandomSpoof.Text=Translating.RandomSpooferTitle.Current(Program.CurLanguage);
LoadBackup.Text=Translating.LoadBackupTitle.Current(Program.CurLanguage);
IsRedacted.Text=Translating.RedactmentTitle.Current(Program.CurLanguage);
SaveSettingsBtn.Text=Translating.SaveTitle.Current(Program.CurLanguage);
ReloadSpooflist();
}

public void ReloadSpooflist() { 
foreach (Spoofable SpoofProd in sgfSpoof.SpoofableList) {
SpoofProd.RefreshLabel.Invoke();
}
}
        
public void InitializeSpooflist() { 
sgfSpoof=new Spoofer(() => { return Program.CurLanguage; }, () => { return IsRedacted.Checked; });
Spoofables.Controls.Clear();
foreach (Spoofable SpoofProd in sgfSpoof.SpoofableList) {
Spoofables.Controls.Add(SpoofProd);
}
}


public void InitializeLangs() { 
Langs.Items.Clear();
foreach(Lang L in LanguageUtils.AllLangs) {Langs.Items.Add(L.ToString());}
Langs.SelectedIndexChanged+=(X,E)=> { 
if(Langs.SelectedIndex !=-1){
LoadLanguage(LanguageUtils.AllLangs[Langs.SelectedIndex]);
MainSettings.UpdateSettingByName("Lang", Program.CurLanguage.ToString());
}
};
}

private void SaveSettingsBtn_Click(object sender, System.EventArgs e){
MainSettings.SaveFile();
}

private void LoadBackup_Click(object sender, EventArgs e){
LoadFromBackupFile();
}



}


}
