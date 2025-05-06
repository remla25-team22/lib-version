namespace lib_version.tests;
using lib_version;

public class VersionTest
{
    [Fact]
    public void GetVersion_returnsVersion()
    {
        Version? version = VersionUtil.CurrentVersion;
        Assert.NotNull(version);
        Assert.Equal(1, version.Major);
        Assert.Equal(0, version.Minor);
        Assert.Equal(0, version.Revision);
    }
}