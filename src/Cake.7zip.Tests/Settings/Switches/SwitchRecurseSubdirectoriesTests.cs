namespace Cake.SevenZip.Tests.Settings.Switches
{
    using Xunit;

    public class SwitchRecurseSubdirectoriesTests
    {
        [Fact]
        public void Recurse_set_outputs_r()
        {
            var fixture = new SevenZipSettingsFixture();
            var sut = new SwitchRecurseSubdirectories(RecurseType.Enable);
            const string expected = "-r";

            var actual = fixture.Parse(b => sut.BuildArguments(ref b));

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Recurse_unset_outputs_r_minus()
        {
            var fixture = new SevenZipSettingsFixture();
            var sut = new SwitchRecurseSubdirectories(RecurseType.Disable);
            const string expected = "-r-";

            var actual = fixture.Parse(b => sut.BuildArguments(ref b));

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Recurse_wildcard_outputs_r_zero()
        {
            var fixture = new SevenZipSettingsFixture();
            var sut = new SwitchRecurseSubdirectories(RecurseType.EnableOnlyForWildcardNames);
            const string expected = "-r0";

            var actual = fixture.Parse(b => sut.BuildArguments(ref b));

            Assert.Equal(expected, actual);
        }
    }
}
