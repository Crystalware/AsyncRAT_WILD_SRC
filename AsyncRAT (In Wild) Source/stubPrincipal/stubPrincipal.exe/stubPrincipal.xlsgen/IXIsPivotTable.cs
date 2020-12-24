using System;

namespace stubPrincipal.xlsgen
{
	// Token: 0x02000022 RID: 34
	internal interface IXlsPivotTable
	{
		// Token: 0x06001052 RID: 4178
		object DataSource();

		// Token: 0x06001053 RID: 4179
		object Rows();

		// Token: 0x06001054 RID: 4180
		object Data();

		// Token: 0x06001055 RID: 4181
		void InsertAt(int v1, int v2);
	}
}
