using System;
using Microsoft.Win32;

namespace SuperGalacticFederation.Registry{
public class RegistryHack {
public Func<RegistryKey> GetRegKey = () => { return null; };
private string _Location = "";
public string Location { get { return _Location; } }
private string _Name = "";
public string Name { get { return _Name; } }
public RegistryHack(Func<RegistryKey> _GetRegKey,string Location,string Name) {
GetRegKey = _GetRegKey;
_Location = Location;
_Name = Name;
}
public string Tamper{
get{
var X = (string)GetRegKey.Invoke().OpenSubKey(Location, false).GetValue(Name);
return X;
}set{
GetRegKey.Invoke().OpenSubKey(Location, true).SetValue(Name, value);
}
}

}

}
