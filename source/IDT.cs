using System.Runtime.CompilerServices;

namespace Kernel
{
    public static class IDT
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static unsafe extern void LoadIDT();
    }
}