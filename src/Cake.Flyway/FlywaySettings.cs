using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Flyway {
    /// <summary>
    /// The common settings used by all Flyway commands.
    /// </summary>
    public abstract class FlywaySettings : ToolSettings {
        /// <summary>
        /// Gets or sets he jdbc url to use to connect to the database
        /// </summary>
        /// <value>Atuo-detected based on URL.</value>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets he fully qualified classname of the jdbc driver to use to connect to the database.
        /// </summary>
        /// <value>Defaults to auto-detected based on URL.</value>
        public string Driver { get; set; }

        /// <summary>
        /// Gets or sets the user to use to connect to the database.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the password to use to connect to the database.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a comma-separated case-sensitive list of schemas managed by Flyway.
        /// </summary>
        /// <value>Defaults to schema of the connection.</value>
        /// <remarks>
        /// The first schema will be the one containing the schema history table.
        /// </remarks>
        public string Schemas { get; set; }

        /// <summary>
        /// Gets or sets the name of Flyway's schema history table.
        /// </summary>
        /// <value>Defaults to flyway_schema_history</value>
        /// <remarks>
        /// By default (single-schema mode) the schema history table is placed in 
        /// the default schema for the connection provided by the datasource.
        /// When the flyway.schemas property is set(multi-schema mode), 
        /// the schema history table is placed in the first schema of the list.
        /// </remarks>
        public string Table { get; set; }

        /// <summary>
        /// Gets or sets a comma-separated list of locations to scan recursively for migrations. The location type is determined by its prefix.
        /// </summary>
        /// <value>Defaults to filesystem:&lt;install-dir&gt;/sql</value>
        /// <remarks>
        /// Unprefixed locations or locations starting with classpath: point to a package on the classpath and may contain both sql and java-based migrations.
        /// Locations starting with filesystem: point to a directory on the filesystem and may only contain sql migrations.
        /// </remarks>
        public string Locations { get; set; }

        /// <summary>
        /// Gets or sets a comma-separated list of directories containing JDBC drivers and Java-based migrations.
        /// </summary>
        /// <value>Defaults to &lt;install-dir&gt;/jars</value>
        public string JarDirs { get; set; }

        /// <summary>
        /// The constructor.
        /// </summary>
        protected FlywaySettings() { }

        protected ProcessArgumentBuilder GetCommonArguments(FlywaySettings settings) {
            var builder = new ProcessArgumentBuilder();
            builder.Append($"url={settings.Url}");

            if (!string.IsNullOrWhiteSpace(settings.Driver)) {
                builder.Append($"driver={settings.Driver}");
            }

            return builder;
        }
    }
}