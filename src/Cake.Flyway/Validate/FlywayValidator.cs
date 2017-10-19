using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Flyway.Validate {
    /// <summary>
    /// The Flyway validate command.
    /// </summary>
    public class FlywayValidator : FlywayTool<FlywayValidateSettings> {
        private readonly ICakeEnvironment _environment;

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="fileSystem">The filesystem.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tool locator.</param>
        public FlywayValidator(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools) : base(fileSystem, environment, processRunner, tools) {
            _environment = environment;
        }

        /// <summary>
        /// Runs the Flyway validate command with the specificed settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Validate(FlywayValidateSettings settings) {
            if (settings == null) {
                throw new ArgumentNullException(nameof(settings));
            }
            Run(settings, GetArguments(settings));
        }

        private ProcessArgumentBuilder GetArguments(FlywayValidateSettings settings) {
            var builder = new ProcessArgumentBuilder();
            builder.Append("validate");

            return builder;
        }
    }
}