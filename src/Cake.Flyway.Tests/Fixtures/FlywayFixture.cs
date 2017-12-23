using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Core.Tooling;
using Cake.Testing.Fixtures;
using NSubstitute;

namespace Cake.Flyway.Tests.Fixtures {
    internal abstract class FlywayFixture<TSettings> : FlywayFixture<TSettings, ToolFixtureResult>
        where TSettings : ToolSettings, new() {
        protected override ToolFixtureResult CreateResult(FilePath path, ProcessSettings process) {
            return new ToolFixtureResult(path, process);
        }
    }

    internal abstract class FlywayFixture<TSettings, TFixtureResult> : ToolFixture<TSettings, TFixtureResult>
        where TSettings : ToolSettings, new()
        where TFixtureResult : ToolFixtureResult {

        public ICakeLog Log { get; set; }

        protected FlywayFixture() : base("flyway.exe") {
            Log = Substitute.For<ICakeLog>();
        }
    }
}