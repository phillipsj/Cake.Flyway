using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Flyway.Clean {
    /// <summary>
    /// The Flyway clean command.
    /// </summary>
    public class FlywayCleaner : FlywayTool<FlywayCleanSettings> {
        private readonly ICakeEnvironment _environment;

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="fileSystem">The filesystem.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tool locator.</param>
        public FlywayCleaner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools) : base(fileSystem, environment, processRunner, tools) {
            _environment = environment;
        }

        /// <summary>
        /// Runs the Flyway clean command with the specificed settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Clean(FlywayCleanSettings settings) {
            if (settings == null) {
                throw new ArgumentNullException(nameof(settings));
            }
            Run(settings, GetArguments(settings));
        }

        private ProcessArgumentBuilder GetArguments(FlywayCleanSettings settings) {
            var builder = new ProcessArgumentBuilder();
            builder.Append("clean");

            return builder;
        }
    }
}