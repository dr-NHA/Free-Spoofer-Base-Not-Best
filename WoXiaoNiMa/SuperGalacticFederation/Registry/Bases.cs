using Microsoft.Win32;

namespace SuperGalacticFederation.Registry{
public static class Bases{
public static RegistryView GetCurrentRegistryView { get { return RegistryView.Default; } }
public static RegistryKey CurrentUser => RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, GetCurrentRegistryView);
public static RegistryKey LocalMachine => RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, GetCurrentRegistryView);
public static RegistryKey CurrentConfig => RegistryKey.OpenBaseKey(RegistryHive.CurrentConfig, GetCurrentRegistryView);
public static RegistryKey Users => RegistryKey.OpenBaseKey(RegistryHive.Users, GetCurrentRegistryView);
}
}
