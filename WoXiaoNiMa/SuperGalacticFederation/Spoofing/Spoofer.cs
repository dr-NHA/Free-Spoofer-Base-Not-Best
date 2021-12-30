using SuperGalacticFederation.Registry;
using System.Collections.Generic;
using Microsoft.Win32;
using SuperGalacticFederation.LangHelpers;
using System;

namespace SuperGalacticFederation.Spoofing{
public class Spoofer{
private string _GPUKeyStore="";
public string GPUKeyStore=> _GPUKeyStore;
public RegistryKey GPURegistryKey => Bases.LocalMachine.OpenSubKey(GPUKeyStore);

public Spoofer(Func<Lang> GetLang,Func<bool> IsRedactedMethod){
_GPUKeyStore = Bases.LocalMachine.OpenSubKey(@"HARDWARE\DEVICEMAP\VIDEO").GetValue(@"\Device\Video0") as string;
_GPUKeyStore = _GPUKeyStore.Replace(@"\Registry\Machine\", "");

SpoofableList = new List<Spoofable>(){
new Spoofable(new RegistryHack(()=>{return Bases.LocalMachine; },
@"HARDWARE\DESCRIPTION\System\CentralProcessor\0","ProcessorNameString"),
new iTranny("Chǔlǐ qì míngchēng zìfú chuàn","Processor Name String"),GetLang,IsRedactedMethod
),

new Spoofable(new RegistryHack(()=>{return Bases.LocalMachine; },
@"HARDWARE\DESCRIPTION\System\CentralProcessor\0","VendorIdentifier"),
new iTranny("Gōngyìng shāng biāozhì fú","Vendor Identifier"),GetLang,IsRedactedMethod
),

new Spoofable(new RegistryHack(()=>{return Bases.LocalMachine; },
@"HARDWARE\DESCRIPTION\System\CentralProcessor\0","Identifier"),
new iTranny("Biāozhì fú","Identifier"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return Bases.LocalMachine; },
@"HARDWARE\DESCRIPTION\System\BIOS","SystemProductName"),
new iTranny("Xìtǒng chǎnpǐn míngchēng","System Product Name"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return Bases.LocalMachine; },
@"HARDWARE\DESCRIPTION\System\BIOS","SystemManufacturer"),
new iTranny("Xìtǒng zhìzào shāng","System Manufacturer"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return Bases.LocalMachine; },
@"HARDWARE\DESCRIPTION\System\BIOS","BIOSVendor"),
new iTranny("BIOS gōngyìng shāng","BIOS Vendor"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return Bases.LocalMachine; },
@"HARDWARE\DESCRIPTION\System\BIOS","BIOSReleaseDate"),
new iTranny("BIOS fābù rìqí","BIOS Release Date"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return Bases.LocalMachine; },
@"HARDWARE\DESCRIPTION\System\BIOS","BaseBoardProduct"),
new iTranny("Jībǎn chǎnpǐn","Base Board Product"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return Bases.LocalMachine; },
@"HARDWARE\DESCRIPTION\System\BIOS","BaseBoardManufacturer"),
new iTranny("Jībǎn zhìzào shāng","Base Board Manufacturer"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return GPURegistryKey; },
@"","HardwareInformation.ChipType"),
new iTranny("Yìngjiàn xìnxī xīnpiàn lèixíng","Hardware Information Chip Type"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return GPURegistryKey; },
@"","HardwareInformation.AdapterString"),
new iTranny("Yìngjiàn xìnxī shìpèiqì zìfú chuàn","Hardware Information Adapter String"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return GPURegistryKey; },
@"","HardwareInformation.BiosString"),
new iTranny("Yìngjiàn xìnxī Bios zìfú chuàn","Hardware Information Bios String"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return GPURegistryKey; },
@"","DriverDesc"),
new iTranny("Qūdòng chéngxù miáoshù","Driver Desc"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return GPURegistryKey; },
@"","DriverDate"),
new iTranny("Sījī rìqí","Driver Date"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return GPURegistryKey; },
@"","DriverVersion"),
new iTranny("Qūdòng bǎnběn","Driver Version"),GetLang,IsRedactedMethod),

new Spoofable(new RegistryHack(()=>{return GPURegistryKey; },
@"","ProviderName"),
new iTranny("Tígōng zhě míngchēng","Provider Name"),GetLang,IsRedactedMethod),
            
new Spoofable(new RegistryHack(()=>{return GPURegistryKey; },
@"","UserModeDriverGUID"),
new iTranny("Yònghù móshì qūdòng chéngxù GUID","User Mode Driver GUID"),GetLang,IsRedactedMethod),
};
}

public List<Spoofable> SpoofableList;
}
}
