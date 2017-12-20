using System;
using System.Collections.Generic;
using System.Text;
using Cake.Core;
using Cake.Core.IO;

namespace Cake.Flyway {
    public static class Extensions {
        public static ProcessArgumentBuilder AppendIfNotNullOrWhiteSpace(this ProcessArgumentBuilder builder,
            string setting) {
            return !string.IsNullOrWhiteSpace(setting) ? builder.Append(setting) : builder;
        }

        public static ProcessArgumentBuilder AppendIfNotNullOrWhiteSpace(this ProcessArgumentBuilder builder,
            string setting, string formatExpression) {
            return !string.IsNullOrWhiteSpace(setting)
                ? builder.Append(string.Format(formatExpression, setting))
                : builder;
        }
    }
}
