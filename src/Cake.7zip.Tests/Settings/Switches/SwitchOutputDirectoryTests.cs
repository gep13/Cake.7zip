namespace Cake.SevenZip.Tests.Settings.Switches
{
    using Cake.Core.IO;

    using Xunit;

    public class SwitchOutputDirectoryTests
    {
        [Fact]
        public void OutputDirectory_works()
        {
            var fixture = new SevenZipSettingsFixture();
            var sut = new SwitchOutputDirectory(new DirectoryPath("c:\\temp"));
            const string expected = "-o\"c:/temp\"";

            var actual = fixture.Parse(b => sut.BuildArguments(ref b));

            Assert.Equal(expected, actual);
        }
    }
}
