using System;

namespace stubPrincipal
{
	// Token: 0x02000017 RID: 23
	internal interface IXlsWorkbook
	{
		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06000D45 RID: 3397
		object WorksheetByIndex { get; }

		// Token: 0x06000D46 RID: 3398
		object AddWorksheet(string v);

		// Token: 0x06000D47 RID: 3399
		void Close();
	}
}
