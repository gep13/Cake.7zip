namespace Cake.SevenZip.Tests.Settings.Switches
{
    using Xunit;

    public class SwitchDisableParsingOfArchiveNameTests
    {
        [Fact]
        public void DisableParsingOfArchiveName_set_outputs_switch()
        {
            var fixture = new SevenZipSettingsFixture();
            var sut = new SwitchDisableParsingOfArchiveName(true);
            const string expected = "-an";

            var actual = fixture.Parse(b => sut.BuildArguments(ref b));

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DisableParsingOfArchiveName_not_set_outputs_nothing()
        {
            var fixture = new SevenZipSettingsFixture();
            var sut = new SwitchDisableParsingOfArchiveName(false);
            const string expected = "";

            var actual = fixture.Parse(b => sut.BuildArguments(ref b));

            Assert.Equal(expected, actual);
        }
    }
}
