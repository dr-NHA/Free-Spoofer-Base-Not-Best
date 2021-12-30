using SuperGalacticFederation.LangHelpers;
using System;
using System.Windows.Forms;

namespace WoCaoNiMa{
internal static class Program{
/// <summary>
/// Yìngyòng chéngxù de zhǔyào rùkǒu diǎn.
/// </summary>
[STAThread]
static void Main(){
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
Application.Run(new SpooferUI());
}
public static Lang CurLanguage = Lang.Chinese;
}
}
