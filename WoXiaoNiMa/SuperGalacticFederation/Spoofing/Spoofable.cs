using SuperGalacticFederation.Registry;
using SuperGalacticFederation.LangHelpers;
using System.Windows.Forms;
using System;

namespace SuperGalacticFederation.Spoofing{
public partial class Spoofable : Form{
public Action RefreshLabel = () => { };
public char RedactedChar='*';
private string RedactedStr =>RedactedChar.ToString();
private string Redact(string Text) { 
var X="";var S= RedactedStr;
for (var i=0; i<Text.Length; i++) {
X += S;
}return X;}

public Spoofable(RegistryHack RegHKKA,iTranny Tranz,Func<Lang> CL,Func<bool> IsRedactedMethod){
InitializeComponent();
this.TopLevel = false;
this.Dock = DockStyle.Top;
RegHack = RegHKKA;
RefreshLabel = () => {
NameLabel.Text = Tranz.Current(CL.Invoke());
ValueBox.Text = IsRedactedMethod .Invoke()== false?RegHack.Tamper:Redact(RegHack.Tamper);
};
RefreshLabel.Invoke();
this.Show();
}
public string GetSpoofName { get { return NameLabel.Text; } }
public string SpoofValue {
get { return ValueBox.Text; }
set { ValueBox.Text = value; }
}
public RegistryHack RegHack;

}
}
