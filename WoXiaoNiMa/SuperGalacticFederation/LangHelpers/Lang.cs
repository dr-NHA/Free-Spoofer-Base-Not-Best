namespace SuperGalacticFederation.LangHelpers{
public enum Lang { Chinese,English}
public static class LanguageUtils { 
public static Lang[] AllLangs =>new[] {Lang.Chinese,Lang.English}; 

public static Lang FromString(string Str){
foreach(Lang L in AllLangs){
if(Str== L.ToString()){
return L;
}
}
return Lang.Chinese;
}

public static int LangToIndex (Lang I) { 
var IXX=0;
foreach(Lang IX in AllLangs){
if(I==IX){
break;
}
IXX++;
}
return IXX;
}

}
}
