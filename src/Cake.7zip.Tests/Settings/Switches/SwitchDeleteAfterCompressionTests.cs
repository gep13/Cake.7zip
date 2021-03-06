namespace Cake.SevenZip.Tests.Settings.Switches
{
    using Xunit;

    public class SwitchDeleteAfterCompressionTests
    {
        [Fact]
        public void Sdel_set_outputs_switch()
        {
            var fixture = new SevenZipSettingsFixture();
            var sut = new SwitchDeleteAfterCompression(true);
            const string expected = "-sdel";

            var actual = fixture.Parse(b => sut.BuildArguments(ref b));

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Sdel_not_set_outputs_nothing()
        {
            var fixture = new SevenZipSettingsFixture();
            var sut = new SwitchDeleteAfterCompression(false);
            const string expected = "";

            var actual = fixture.Parse(b => sut.BuildArguments(ref b));

            Assert.Equal(expected, actual);
        }
    }
}
