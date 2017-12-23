using Cake.Flyway.Baseline;

namespace Cake.Flyway.Tests.Fixtures.Baseline {
    internal sealed class FlywayBaselinerFixture : FlywayFixture<FlywayBaselineSettings> {
        public string Url { get; set; }

        public FlywayBaselinerFixture() {
            Url = "jdbc:hsqldb:file:/db/flyway_sample";
        }
        
        protected override void RunTool() {
            var tool = new FlywayBaseliner(FileSystem, Environment, ProcessRunner, Tools);
            tool.Baseline(Url, Settings);
        }
    }
}