namespace Cake.Flyway.Repair {
    /// <summary>
    /// Contains settings used by <see cref="FlywayRepairer"/>.
    /// </summary>
    public class FlywayRepairSettings : FlywaySettings {
        /// <inheritdoc cref="FlywaySettings"/>
        public FlywayRepairSettings(string url) : base(url) { }
    }
}