using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace EasyEnvironment.Utils
{
    static class AutoStart
    {
        public static void Set()
        {
            try
            {
                using var baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                if (baseKey == null)
                {
                    Console.WriteLine(@"Cannot find HKCU\Software\Microsoft\Windows\CurrentVersion\Run");
                    return;
                }
                baseKey.SetValue("EasyEnvironment", Assembly.GetEntryAssembly().Location);
                Console.WriteLine("AutoStart has been Set");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to set AutoStartUp {e.Message}");
                throw;
            }
        }

        public static void Remove()
        {
            try
            {
                using var baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                if (baseKey == null)
                {
                    Console.WriteLine(@"Cannot find HKCU\Software\Microsoft\Windows\CurrentVersion\Run");
                    return;
                }
                baseKey.DeleteValue("EasyEnvironment", false);
                Console.WriteLine("AutoStart has been Remove");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to set AutoStartUp {e.Message}");
                throw;
            }
        }

        public static bool Check()
        {
            try
            {
                using var baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                if (baseKey == null)
                {
                    Console.WriteLine(@"Cannot find HKCU\Software\Microsoft\Windows\CurrentVersion\Run");
                    return false;
                }

                var ace = baseKey.GetValue("EasyEnvironment");
                var exe = Assembly.GetEntryAssembly().Location;
                return exe.Equals(ace);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to set AutoStartUp {e.Message}");
                throw;
            }

            return false;
        }
    }
}
