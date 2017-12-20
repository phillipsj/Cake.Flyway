namespace Cake.Flyway.Migrate {
    /// <summary>
    /// Contains settings used by <see cref="FlywayMigrator"/>.
    /// </summary>
    public class FlywayMigrateSettings : FlywaySettings {
        /// <inheritdoc cref="FlywaySettings"/>
        public FlywayMigrateSettings(string url) : base(url) { }
    }
}