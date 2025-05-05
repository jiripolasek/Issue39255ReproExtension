using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Issue39255ReproExtension.Utils;

[ComImport, Guid("45BA127D-10A8-46EA-8AB7-56EA9078943C")] //Application Activation Manager
internal class ApplicationActivationManager : IApplicationActivationManager
{
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime) /*, PreserveSig*/]
    public extern nint ActivateApplication([In] string appUserModelId, [In] string arguments,
        [In] ActivateOptions options, [Out] out uint processId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern nint ActivateForFile([In] string appUserModelId, [In] nint /*IShellItemArray* */ itemArray,
        [In] string verb, [Out] out uint processId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern nint ActivateForProtocol([In] string appUserModelId, [In] nint /* IShellItemArray* */itemArray,
        [Out] out uint processId);
}