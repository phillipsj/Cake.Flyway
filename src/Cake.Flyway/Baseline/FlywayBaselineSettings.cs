namespace Cake.Flyway.Baseline {
    /// <summary>
    /// Contains settings used by <see cref="FlywayBaseliner"/>.
    /// </summary>
    public class FlywayBaselineSettings : FlywaySettings {
        /// <summary>
        /// Gets or sets a comma-separated list of fully qualified class names of FlywayCallback 
        /// implementations to use to hook into the Flyway lifecycle.
        /// </summary>
        public string Callbacks { get; set; }

        /// <summary>
        /// Gets or sets whether default built-in callbacks (sql) should be skipped.
        /// </summary>
        /// <value>
        /// <c>true</c> if only custom callbacks are used.; otherwise, <c>false</c>.
        /// </value>
        public bool SkipDefaultCallbacks { get; set; }

        /// <summary>
        /// Gets or sets the version to tag an existing schema with when executing baseline.
        /// </summary>
        /// <value>Defaults to 1.</value>
        public string BaselineVersion { get; set; }

        /// <summary>
        /// Gets or sets the description to tag an existing schema with when executing baseline.
        /// </summary>
        /// <value>&lt;&lt; Flyway Baseline &gt;&gt; </value>
        public string BaselineDescription { get; set; }

        /// <inheritdoc cref="FlywaySettings"/>
        public FlywayBaselineSettings(string url) : base(url) { }
    }
}