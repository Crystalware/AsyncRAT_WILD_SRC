using System;

namespace stubPrincipal.xlsgen
{
	// Token: 0x02000024 RID: 36
	internal interface IXlsStyle
	{
		// Token: 0x06001057 RID: 4183
		object Font();

		// Token: 0x06001058 RID: 4184
		void Apply();

		// Token: 0x06001059 RID: 4185
		IXlsStyle Duplicate();

		// Token: 0x0600105A RID: 4186
		object Alignment();

		// Token: 0x0600105B RID: 4187
		string Format();

		// Token: 0x0600105C RID: 4188
		object Pattern();
	}
}
