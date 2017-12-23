using System;
using System.Collections.Generic;
using System.Text;
using Cake.Core;
using Cake.Core.IO;

namespace Cake.Flyway {
    public static class Extensions {
        public static ProcessArgumentBuilder AppendIfNot(this ProcessArgumentBuilder builder,
            string setting) {
            return !string.IsNullOrWhiteSpace(setting) ? builder.Append(setting) : builder;
        }

        public static ProcessArgumentBuilder AppendIfNot(this ProcessArgumentBuilder builder,
            string setting, string formatExpression) {
            return !string.IsNullOrWhiteSpace(setting)
                ? builder.Append(formatExpression, setting)
                : builder;
        }
        
        public static ProcessArgumentBuilder AppendIf(this ProcessArgumentBuilder builder,
            bool setting, string formatExpression) {
            return setting
                ? builder.Append(formatExpression, "true")
                : builder;
        }
    }
}
