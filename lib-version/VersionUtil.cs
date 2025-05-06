using System.Reflection;

namespace lib_version
{
    public class VersionUtil
    {
        public Version? CurrentVersion { get; } = typeof(VersionUtil).Assembly.GetName().Version;
    }
}
