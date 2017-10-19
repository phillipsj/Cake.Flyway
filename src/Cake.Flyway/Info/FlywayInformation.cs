using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Flyway.Info {
    /// <summary>
    /// The Flyway info command.
    /// </summary>
    public class FlywayInformation : FlywayTool<FlywayInfoSettings> {
        private readonly ICakeEnvironment _environment;

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="fileSystem">The filesystem.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tool locator.</param>
        public FlywayInformation(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools) : base(fileSystem, environment, processRunner, tools) {
            _environment = environment;
        }

        /// <summary>
        /// Runs the Flyway info command with the specificed settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Info(FlywayInfoSettings settings) {
            if (settings == null) {
                throw new ArgumentNullException(nameof(settings));
            }
            Run(settings, GetArguments(settings));
        }

        private ProcessArgumentBuilder GetArguments(FlywayInfoSettings settings) {
            var builder = new ProcessArgumentBuilder();
            builder.Append("info");

            return builder;
        }
    }
}