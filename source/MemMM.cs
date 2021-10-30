namespace Kernel
{
    class MemMM
    {
        public static unsafe void memset(byte* ptr, int c, int count)
	    {
		    for (byte* p = ptr; p < ptr + count; p++)
			    *p = (byte)c;
	    }
    }
}