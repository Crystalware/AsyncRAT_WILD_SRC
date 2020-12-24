using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace stubPrincipal.My.Resources
{
	// Token: 0x02000006 RID: 6
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resource1
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002111 File Offset: 0x00000311
		internal Resource1()
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002119 File Offset: 0x00000319
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resource1.resourceMan, null))
				{
					Resource1.resourceMan = new ResourceManager("stubPrincipal.Resource1", typeof(Resource1).Assembly);
				}
				return Resource1.resourceMan;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000214B File Offset: 0x0000034B
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002152 File Offset: 0x00000352
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resource1.resourceCulture;
			}
			set
			{
				Resource1.resourceCulture = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000215A File Offset: 0x0000035A
		internal static string euqueriaumg3
		{
			get
			{
				return Resource1.ResourceManager.GetString("euqueriaumg3", Resource1.resourceCulture);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002170 File Offset: 0x00000370
		internal static Bitmap tempbild
		{
			get
			{
				return (Bitmap)RuntimeHelpers.GetObjectValue(Resource1.ResourceManager.GetObject("tempbild", Resource1.resourceCulture));
			}
		}

		// Token: 0x04000008 RID: 8
		private static ResourceManager resourceMan;

		// Token: 0x04000009 RID: 9
		private static CultureInfo resourceCulture;
	}
}
