using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Flyway.Baseline {
    /// <summary>
    /// The Flyway baseline command.
    /// </summary>
    public class FlywayBaseliner : FlywayTool<FlywayBaselineSettings> {
        private readonly ICakeEnvironment _environment;

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="fileSystem">The filesystem.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tool locator.</param>
        public FlywayBaseliner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools) : base(fileSystem, environment, processRunner, tools) {
            _environment = environment;
        }

        /// <summary>
        /// Runs the Flyway baseline command with the specificed settings.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="settings">The settings.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Baseline(string url, FlywayBaselineSettings settings) {
            if (string.IsNullOrWhiteSpace(url)) {
                throw new ArgumentNullException(nameof(url));
            }
            if (settings == null) {
                throw new ArgumentNullException(nameof(settings));
            }
            
            settings.Url = url;
            Run(settings, GetArguments(settings));
        }

        private ProcessArgumentBuilder GetArguments(FlywayBaselineSettings settings) {
            var builder = new ProcessArgumentBuilder();
            builder.Append("baseline");
            builder.AppendIfNot(settings.Driver, "-drive={0}");
            builder.Append("-url={0}", settings.Url);
            builder.AppendIfNot(settings.User, "-user={0}");
            builder.AppendIfNot(settings.Password, "-user={0}");
            builder.AppendIfNot(settings.Schemas, "-schemas={0}");
            builder.AppendIfNot(settings.Table, "-table={0}");
            builder.AppendIfNot(settings.Locations, "-locations={0}");
            builder.AppendIfNot(settings.JarDirs, "-jarDirs={0}");
            builder.AppendIfNot(settings.Callbacks, "-callbacks={0}");
            builder.AppendIf(settings.SkipDefaultCallbacks, "-skipDefaultCallbacks={0}");
            builder.AppendIfNot(settings.BaselineVersion, "-baselineVersion={0}");
            builder.AppendIfNot(settings.BaselineDescription, "-baselineDescription={0}");
            return builder;
        }
    }
}