using System;

namespace SuperGalacticFederation.Settings{
public class Setting{
private string _Name;
public string Name { get { return _Name; } }

private dynamic _Value;
public dynamic Value { get { return _Value; } }

public Type _Type;
public Type Type { get { return _Value.GetType(); } }

private Action<Setting> OnLoad=(X)=>{};
public void LoadInitiated() { OnLoad.Invoke(this); }

public Setting(string Name,dynamic StartValue,Type StartValueType, Action<Setting> _OnLoad) { 
_Name = Name;
_Value = StartValue;
_Type= StartValueType;
OnLoad = _OnLoad;
}

public void UpdateValue(string NewValue, Type NewValueType,bool InitiateLoad=false) { 
if(NewValueType==Types.String){
_Value = NewValue;
}else if(NewValueType==Types.Int){
int X;
if(int.TryParse(NewValue,out X))
_Value =X;
}else if(NewValueType==Types.Bool){
bool X;
if(bool.TryParse(NewValue,out X))
_Value =X;
}else if(NewValueType==Types.Bool){
bool X;
if(bool.TryParse(NewValue,out X))
_Value =X;
}else if(NewValueType==Types.Long){
long X;
if(long.TryParse(NewValue,out X))
_Value =X;
}
_Type = NewValueType;
if (InitiateLoad) { LoadInitiated(); }
}
public void UnsafeUpdateValue(dynamic NewValue, Type NewValueType,bool InitiateLoad=false) { 
_Value = NewValue;
_Type = NewValueType;
if (InitiateLoad) { LoadInitiated(); }
}

}
}
