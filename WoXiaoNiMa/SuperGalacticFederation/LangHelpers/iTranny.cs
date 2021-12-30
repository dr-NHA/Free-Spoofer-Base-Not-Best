namespace SuperGalacticFederation.LangHelpers{
public class iTranny { 
private string[] _strMap;
public string Chinese => _strMap[0];
public string English => _strMap[1];
public string Current(Lang C) { 
return (C==Lang.English)?English:(C==Lang.Chinese)?Chinese:"";
}

public iTranny(string[] Input) { 
_strMap = Input;
}
public iTranny(string Chinese, string English) {
_strMap =new []{ Chinese, English}; 
}
        
public static iTranny iTrans(string[] Input) {
return new iTranny(Input);}
public static iTranny iTrans(string Chinese,string English) {
return new iTranny(Chinese, English );}
}
}
