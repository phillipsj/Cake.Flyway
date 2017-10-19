using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Flyway {
    /// <summary>
    /// Base class for all Flyway tools.
    /// </summary>
    /// <typeparam name="TSettings"><see cref="FlywaySettings"/></typeparam>
    public abstract class FlywayTool<TSettings> : Tool<TSettings> where TSettings : FlywaySettings {

        /// <summary>
        /// Initializes a new instance of <see cref="FlywayTool{TSettings}"/> class.
        /// </summary>
        /// <param name="fileSystem">The filesystem.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tool locator.</param>
        protected FlywayTool(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools) : base(fileSystem, environment, processRunner, tools) { }

        /// <summary>
        /// Gets the name of the tool.
        /// </summary>
        /// <returns>The name of the tool.</returns>
        protected sealed override string GetToolName() {
            return "Flyway";
        }

        /// <summary>
        /// Gets the possible names of the tool executable.
        /// </summary>
        /// <returns>The tool executable name.</returns>
        protected sealed override IEnumerable<string> GetToolExecutableNames() {
            return new[] {"", ""};
        }

        /// <summary>
        /// Gets alternative file paths which the tool may exist.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The default tool path.</returns>
        protected override IEnumerable<FilePath> GetAlternativeToolPaths(TSettings settings) {
            return null;
        }
    }
}