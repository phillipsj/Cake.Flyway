using System;
using Cake.Flyway.Tests.Fixtures.Baseline;
using Xunit;

namespace Cake.Flyway.Tests.Baseline
{
    public sealed class FlywayBaselinerTests
    {
        public sealed class TheBaselineMethod {
            [Fact]
            public void Should_Throw_If_Url_Is_Null() {
                // Given
                var fixture = new FlywayBaselinerFixture();
                fixture.Url = null;
                
                // When 
                var result = Record.Exception(() => fixture.Run());
                
                // Then
                Assert.IsType<ArgumentNullException>(result).ParamName.Equals("Url");
            }
        }
    }
}
