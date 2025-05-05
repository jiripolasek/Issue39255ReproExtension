// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Issue39255ReproExtension.Commands;

using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;

namespace Issue39255ReproExtension.Pages;

internal sealed partial class Issue39255ReproExtensionPage : ListPage
{
    public Issue39255ReproExtensionPage()
    {
        Icon = new("\uE762");
        Title = "Nice Page List (Repro for #39255)";
        Name = "Open";
    }

    public override IListItem[] GetItems()
    {
        return [
            new ListItem(new StartMediaPlayer())
            {
                Subtitle = "I'm not able to set foreground window at all.",
                MoreCommands = [
                    new CommandContextItem(new Pages.Issue39255ReproExtensionPage())
                    {
                        Title = "Start Media Player (Context)"
                    },
                ]
            }
        ];
    }
}
