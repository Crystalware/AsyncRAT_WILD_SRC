using System;

namespace stubPrincipal.xlsgen
{
	// Token: 0x02000026 RID: 38
	internal interface IXlsWorksheet
	{
		// Token: 0x06001064 RID: 4196
		int RowHeight(int v);

		// Token: 0x06001065 RID: 4197
		int Number(int v1, int v2);

		// Token: 0x06001066 RID: 4198
		void CalculateFormulas();

		// Token: 0x06001067 RID: 4199
		IXlsWorksheet Duplicate(string v);

		// Token: 0x06001068 RID: 4200
		string Formula(int v1, int v2);

		// Token: 0x06001069 RID: 4201
		IXlsStyle NewStyle();

		// Token: 0x0600106A RID: 4202
		string Label(int v1, int v2);

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x0600106B RID: 4203
		object NewChart { get; }

		// Token: 0x0600106C RID: 4204
		IXlsPivotTable NewPivotTable();

		// Token: 0x0600106D RID: 4205
		string VBAMacros();

		// Token: 0x0600106E RID: 4206
		object Columns(string v);

		// Token: 0x0600106F RID: 4207
		object Float(object v1, object v2);

		// Token: 0x06001070 RID: 4208
		int DefaultStyle();

		// Token: 0x06001071 RID: 4209
		string Date(object v1, int v2);
	}
}
