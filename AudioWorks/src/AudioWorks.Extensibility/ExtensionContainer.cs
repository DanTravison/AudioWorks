﻿using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using AudioWorks.Common;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;

namespace AudioWorks.Extensibility
{
    sealed class ExtensionContainer<T> : ExtensionContainerBase
    {
        [NotNull] static readonly Lazy<ExtensionContainer<T>> _lazyInstance =
            new Lazy<ExtensionContainer<T>>(() => new ExtensionContainer<T>());

        [NotNull]
        internal static ExtensionContainer<T> Instance => _lazyInstance.Value;

        [UsedImplicitly]
        [ImportMany]
        internal IEnumerable<ExportFactory<T, IDictionary<string, object>>> Factories { get; private set; }

        ExtensionContainer()
        {
            CompositionHost.SatisfyImports(this);

            LoggingManager.LoggerFactory.CreateLogger<ExtensionContainer<T>>()
                .LogDebug("Composed {0} part(s) of type '{1}'.", Factories.Count(), typeof(T).Name);
        }
    }
}