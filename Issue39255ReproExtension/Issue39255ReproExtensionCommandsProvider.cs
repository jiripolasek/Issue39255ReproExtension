// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;

namespace Issue39255ReproExtension;

public sealed partial class Issue39255ReproExtensionCommandsProvider : CommandProvider
{
    private readonly ICommandItem[] _commands;

    public Issue39255ReproExtensionCommandsProvider()
    {
        DisplayName = "Start Media Player (Repro for #39255)";
        Icon = IconHelpers.FromRelativePath("Assets\\StoreLogo.png");

        _commands = [
            new CommandItem(new Pages.Issue39255ReproExtensionPage()) { Title = "Nice Page List (Repro for #39255)" },

            new CommandItem(new Commands.StartMediaPlayer())
            {
                Title = "Start Media Player (Top level)",
                Subtitle = "I'll correctly execute only once; after that I'm not able to set foreground window until another extension is activated",
                Icon = new IconInfo("\uE768"),
                MoreCommands = [
                    new CommandContextItem(new Pages.Issue39255ReproExtensionPage())
                    {
                        Title = "Start Media Player (Context)"
                    },
                ]
            },
        ];
    }

    public override ICommandItem[] TopLevelCommands()
    {
        return _commands;
    }

}
