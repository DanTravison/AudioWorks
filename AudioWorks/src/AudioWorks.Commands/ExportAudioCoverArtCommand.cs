﻿/* Copyright © 2018 Jeremy Herbison

This file is part of AudioWorks.

AudioWorks is free software: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later
version.

AudioWorks is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied
warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
details.

You should have received a copy of the GNU Lesser General Public License along with AudioWorks. If not, see
<https://www.gnu.org/licenses/>. */

using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Management.Automation;
using AudioWorks.Api;
using AudioWorks.Common;
using JetBrains.Annotations;

namespace AudioWorks.Commands
{
    [PublicAPI]
    [Cmdlet(VerbsData.Export, "AudioCoverArt"), OutputType(typeof(FileInfo))]
    public sealed class ExportAudioCoverArtCommand : LoggingPSCmdlet
    {
        [CanBeNull] CoverArtExtractor _extractor;

        [NotNull]
        [SuppressMessage("ReSharper", "NotNullMemberIsNotInitialized",
            Justification = "Mandatory properties cannot be null by default")]
        [Parameter(Mandatory = true, Position = 0)]
        public string Path { get; set; }

        [NotNull]
        [SuppressMessage("ReSharper", "NotNullMemberIsNotInitialized",
            Justification = "Mandatory properties cannot be null by default")]
        [Parameter(Mandatory = true, Position = 1, ValueFromPipeline = true)]
        public ITaggedAudioFile AudioFile { get; set; }

        [CanBeNull]
        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public SwitchParameter Replace { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            _extractor = new CoverArtExtractor(
                SessionState.Path.GetUnresolvedProviderPathFromPSPath(Path),
                Name,
                Replace);
        }

        protected override void ProcessRecord()
        {
            // ReSharper disable once PossibleNullReferenceException
            var result = _extractor.Extract(AudioFile);

            ProcessLogMessages();

            if (result != null)
                WriteObject(result);
        }
    }
}
