using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SuperGalacticFederation.Other;

namespace SuperGalacticFederation.Settings{

public class SettingHandler{
private string _Name;
public string Name { get { return _Name; } }

private string _SettingFileDir;
public string SettingFileDirectory { get { return _SettingFileDir; } }
public bool FileExists =>File.Exists(SettingFileDirectory);
public char SettingPartSplitKey=Rare.dá.ToCharArray()[0];
public char SettingArraySplitKey=Rare.Tāotiè.ToCharArray()[0];
public async Task SaveFile() { 
var X="";
foreach(Setting Set in SettingsList) { 
X+=$"{Set.Name}{SettingPartSplitKey}{Set.Type.Name}{SettingPartSplitKey}{Set.Value}{SettingArraySplitKey}";         
}  
if(FileExists){ File.Delete(SettingFileDirectory); }
File.WriteAllText(SettingFileDirectory,X.Trim(SettingArraySplitKey));
}
public async Task LoadFile() { 
if(FileExists){
var X= File.ReadAllText(SettingFileDirectory).Split(SettingArraySplitKey);
foreach (string CompiledSetting in X) { 
var XA= CompiledSetting.Split(SettingPartSplitKey);
UpdateAndInitLoadOnSettingByName(XA[0], XA[2]);
}  
}}
public List<Setting> SettingsList = new List<Setting>();
public async Task UpdateAndInitLoadOnSettingByName(string Name,string Value) { 
foreach(Setting setting in SettingsList) {
if(setting.Name == Name) {
setting.UpdateValue(Value,setting.Type,true);
}
}      
}
public async Task UpdateSettingByName(string Name,dynamic Value,Type NewType=null) { 
foreach(Setting setting in SettingsList) {
if(setting.Name == Name) {
setting.UnsafeUpdateValue(Value, NewType==null?setting.Type:NewType, false);
}
}      
}

public SettingHandler(string Name,string SettingFileDirectory,Setting[] InitialSettings){
_Name=Name;
_SettingFileDir= SettingFileDirectory;
SettingsList.AddRange(InitialSettings);
}


    }
}
