using Issue39255ReproExtension.Utils;

using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;

namespace Issue39255ReproExtension.Commands;

public sealed partial class StartMediaPlayer : InvokableCommand
{
    public StartMediaPlayer()
    {
        Name = "Start Media Player";
        Icon = IconHelpers.FromRelativePath("Assets\\StoreLogo.png");
    }

    public override ICommandResult Invoke(object? sender)
    {
        ApplicationActivationManager appActivationManager = new ApplicationActivationManager();
        appActivationManager.ActivateApplication("Microsoft.ZuneMusic_8wekyb3d8bbwe!Microsoft.ZuneMusic", "", ActivateOptions.None, out _);
        return CommandResult.Dismiss();
    }
}