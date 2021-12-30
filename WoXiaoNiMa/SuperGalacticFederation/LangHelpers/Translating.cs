using System.Collections.Generic;
using static SuperGalacticFederation.LangHelpers.iTranny;

namespace SuperGalacticFederation.LangHelpers{
public static class Translating{

public static iTranny SpooferUITitle= 
iTrans("Qīpiàn yònghù jièmiàn", "spoofer ui");
        
public static iTranny RandomSpooferTitle= 
iTrans("Duì suǒyǒu rén suíjī ègǎo", "random spoof to all");

public static iTranny LoadBackupTitle= 
iTrans("Jiāzài bèifèn", "load back ups");
        
public static iTranny RedactmentTitle= 
iTrans("Biānjí xìnxī", "Redact Infomation");
        
public static iTranny SaveTitle= 
iTrans("Bǎocún yìngyòng shèzhì", "Save app settings");

#region Info
public static dynamic cesaInfo = new [] { 
iTrans("",""),
iTrans("Qīpiàn zhě xìnxī:","spoofer info"),
iTrans("Qīpiàn zhě bù huì ràng nǐ miǎn yú jìnlìng táobì","spoofer wont save you from ban evasion"),
iTrans("Qīpiàn zhě kěnéng tā mā de fùfèi ruǎnjiàn!","Spoofer May Fuck Paid Software!"),
iTrans("Bù yāo mǎi piànzi dà bùfèn dōu shì yīyàng de!","Dont Buy Spoofers Most Are The Same!"),
iTrans("Zhè shì bùshì cóng hùliánwǎng shàng fùzhì de suǒyǒu xīn dàimǎ, dàn zuò tóngyàng de shìqíng","this is all new code not copied from internet but does the same shit")
};
public static dynamic CurrentInfo(Lang C){
var L=new List<string>();
foreach (iTranny Cax in (iTranny[])cesaInfo) {
L.Add(Cax.Current(C));
}
return L.ToArray();
}
#endregion

}
}
