using System;

namespace stubPrincipal.xlsgen
{
	// Token: 0x02000021 RID: 33
	internal interface IXlsChart
	{
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x0600104D RID: 4173
		object SurfaceArea { get; }

		// Token: 0x0600104E RID: 4174
		object DataSource();

		// Token: 0x0600104F RID: 4175
		object Legend();

		// Token: 0x06001050 RID: 4176
		object MainTitle();

		// Token: 0x06001051 RID: 4177
		object SeriesByIndex(int v);
	}
}
