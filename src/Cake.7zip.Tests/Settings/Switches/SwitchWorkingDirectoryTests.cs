namespace Cake.SevenZip.Tests.Settings.Switches
{
    using Cake.Core.IO;

    using Xunit;

    public class SwitchWorkingDirectoryTests
    {
        [Fact]
        public void WorkingDirectory_works()
        {
            var fixture = new SevenZipSettingsFixture();
            var sut = new SwitchWorkingDirectory(new DirectoryPath("c:\\temp"));
            const string expected = @"-w""c:/temp""";

            var actual = fixture.Parse(b => sut.BuildArguments(ref b));

            Assert.Equal(expected, actual);
        }
    }
}
