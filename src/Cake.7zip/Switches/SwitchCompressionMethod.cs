namespace Cake.SevenZip
{
    using Cake.Core;
    using Cake.Core.IO;

    /// <summary>
    /// <para>
    /// -m (Set compression Method) switch.
    /// </para>
    /// <para>
    /// Specifies the compression method.
    /// </para>
    /// <para>
    /// <list type="bullet">
    /// <item><description><see cref="ISupportSwitchCompressionMethod"/></description></item>
    /// <item><description><see cref="SwitchCompressionMethodBuilder"/></description></item>
    /// </list>
    /// </para>
    /// <seealso cref="ISwitch" />
    /// </summary>
    public class SwitchCompressionMethod : ISwitch
    {
        /// <summary>
        /// Gets or sets the level.
        /// parameter: x.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        public int? Level { get; set; }

        /// <summary>
        /// Gets or sets the method.
        /// parameter: m.
        /// </summary>
        /// <value>
        /// The method.
        /// </value>
        // TODO: Enum or static Props?
        public string Method { get; set; }

        /// <inheritdoc/>
        public void BuildArguments(ref ProcessArgumentBuilder builder)
        {
            // this is more complicated... :-)
            if (Level.HasValue)
            {
                builder.Append($"-mx={Level.Value}");
            }

            if (Method != null)
            {
                builder.Append($"-mm={Method}");
            }
        }
    }
}
