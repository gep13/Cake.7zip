namespace Cake.SevenZip
{
    using Cake.Core;
    using Cake.Core.IO;

    /// <summary>
    /// <para>
    /// -ax (Exclude archive filenames) switch.
    /// </para>
    /// <para>
    /// Specifies archives to be excluded from the operation.
    /// Multiple exclude archive switches are supported.
    /// </para>
    /// <para>
    /// <list type="bullet">
    /// <item><description><see cref="ISupportSwitchExcludeArchiveFilenames"/></description></item>
    /// <item><description><see cref="SwitchExcludeArchiveFilenamesBuilder"/></description></item>
    /// <item><description><see cref="SwitchExcludeArchiveFilenameCollection"/></description></item>
    /// </list>
    /// </para>
    /// <seealso cref="ISwitch" />
    /// </summary>
    public class SwitchExcludeArchiveFilename : ISwitch
    {
        private readonly string wildcard;
        private readonly RecurseType recurseType;

        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchExcludeArchiveFilename"/> class.
        /// </summary>
        /// <param name="wildcard">The wildcard.</param>
        /// <param name="recurseType">Type of the recurse.</param>
        public SwitchExcludeArchiveFilename(string wildcard, RecurseType recurseType)
        {
            this.wildcard = wildcard;
            this.recurseType = recurseType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchExcludeArchiveFilename"/> class.
        /// </summary>
        /// <param name="wildcard">The wildcard.</param>
        public SwitchExcludeArchiveFilename(string wildcard)
            : this(wildcard, null)
        {
        }

        /// <inheritdoc/>
        public void BuildArguments(ref ProcessArgumentBuilder builder)
        {
            var recurse = recurseType == null ? string.Empty : $"r{recurseType}";
            builder.Append($"-ax{recurse}!{wildcard}");
        }
    }
}