[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.VsIntegration.SinceVs09.Interop
{
    
    [JetBrains.VsIntegration.Application.WrapVsInterfacesAttribute()]
    public class ExposeSinceVs09Services : JetBrains.VsIntegration.Application.IExposeVsServices { }
}