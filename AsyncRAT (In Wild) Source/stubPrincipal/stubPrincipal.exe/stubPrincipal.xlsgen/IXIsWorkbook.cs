using System;

namespace stubPrincipal.xlsgen
{
	// Token: 0x02000025 RID: 37
	internal interface IXlsWorkbook
	{
		// Token: 0x0600105D RID: 4189
		object ExcelTargetVersion();

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x0600105E RID: 4190
		IXlsWorksheet AddWorksheet { get; }

		// Token: 0x0600105F RID: 4191
		void Close();

		// Token: 0x06001060 RID: 4192
		object CalculationOptions();

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001061 RID: 4193
		IXlsWorksheet WorksheetByIndex { get; }

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001062 RID: 4194
		object VBAModules { get; }

		// Token: 0x06001063 RID: 4195
		string VBAMacros();
	}
}
