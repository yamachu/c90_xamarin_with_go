using System;
using System.Runtime.InteropServices;

namespace comiket_aobayama
{
	public class GoAobayama
	{
#if __ANDROID__
		[DllImport("libaobayama.so", CharSet=CharSet.Auto, CallingConvention=CallingConvention.Cdecl)]
#elif __IOS__
		[DllImport("__Internal", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
#endif
		private static extern IntPtr myCLibrary(string user);

		public static string callCLibrary(string user)
		{
			IntPtr pStr = myCLibrary(user);
			var str = Marshal.PtrToStringAuto(pStr);
			Marshal.FreeHGlobal(pStr);
			return str;
		}
	}
}

