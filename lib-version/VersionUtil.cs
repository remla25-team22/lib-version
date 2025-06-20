using System;
using System.IO;

namespace lib_version
{
    public static class VersionUtil
    {
        public static string CurrentVersion
        {
            get
            {
                try
                {
                    var baseDir = AppContext.BaseDirectory;
                    var versionFile = Path.Combine(baseDir, "VERSION.txt");

                    if (!File.Exists(versionFile))
                    {
                        versionFile = Path.Combine(baseDir, "..", "..", "..", "VERSION.txt");
                    }

                    return File.Exists(versionFile)
                        ? File.ReadAllText(versionFile).Trim()
                        : "unknown";
                }
                catch
                {
                    return "error-loading-version";
                }
            }
        }
    }
}
