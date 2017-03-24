using System;
using System.Diagnostics;
using System.Reflection;

namespace Installatron.Net.Helpers
{
    public class InstallatronHelpers
    {
        /// <summary>
        /// Gets the version of the Assembly.
        /// </summary>
        /// <returns>The version.</returns>
        public static string GetVersion() {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.ProductVersion;

            return version;
        }

        /// <summary>
        /// Get the system information
        /// </summary>
        /// <returns>The .NET version</returns>
        public static string GetSystemInfo() {
            var runtimeVersion = Environment.Version;
            return $"Runtime v{runtimeVersion}";
        }

    }
}

