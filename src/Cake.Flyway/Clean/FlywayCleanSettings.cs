namespace Cake.Flyway.Clean {
    /// <summary>
    /// Contains settings used by <see cref="FlywayCleaner"/>.
    /// </summary>
    public class FlywayCleanSettings : FlywaySettings {
        /// <inheritdoc cref="FlywaySettings"/>
        public FlywayCleanSettings(string url) : base(url) { }
    }
}