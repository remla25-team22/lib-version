namespace lib_version;

public static class VersionUtil
{
    public static Version? CurrentVersion { get; } = typeof(VersionUtil).Assembly.GetName().Version;
}