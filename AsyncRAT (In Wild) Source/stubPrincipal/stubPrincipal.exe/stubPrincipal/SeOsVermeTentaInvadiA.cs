using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace stubPrincipal
{
	// Token: 0x0200001B RID: 27
	[StandardModule]
	public sealed class SeOsVermeTentaInvadiA
	{
		// Token: 0x06000D5A RID: 3418 RVA: 0x00042E58 File Offset: 0x00041058
		private static object intRESULT()
		{
			new XElement(XName.Get("chapa", "")).Add("\n                         Se os verme tenta invadi\n\n        A chapa vai esquenta\n\n        traz logo \n\n        O meu parafal\n\n        Tracante vermelhoooooooooooooooo\n\n\n                     ");
			throw new NotImplementedException();
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00042E8C File Offset: 0x0004108C
		public static object TresCU()
		{
			new XElement(XName.Get("ADASAFADOVERME3CU", "")).Add("\n                 Geral ta ligado que os tres cu ta bolado\n\n\n    dando um role no morro de g3 AK trovao\n\n        Quando derrepente me veio um pivetão\n\n        Pidindo pra dar um lance, no parque uniao\n\n\n                     ");
			int num = 0;
			if (num == 1)
			{
				NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("FaxComEx.FaxServer", "")), null, "Connect", new object[]
				{
					"atl-dc-02"
				}, null, null, null, true);
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("LDAP://CN=Rob Young, OU=Finance, DC=fabrikam,DC=Com", null));
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Get", new object[]
				{
					"ntSecurityDescriptor"
				}, null, null, null));
				object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "DiscretionaryACL", new object[0], null, null, null));
				object objectValue4 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("AccessControlEntry", ""));
				NewLateBinding.LateSet(objectValue4, null, "Trustee", new object[]
				{
					"FABRIKAM\\kmyer"
				}, null, null);
				NewLateBinding.LateSet(objectValue4, null, "AceFlags", new object[]
				{
					0
				}, null, null);
				NewLateBinding.LateSet(objectValue4, null, "AceType", new object[]
				{
					5
				}, null, null);
				NewLateBinding.LateSet(objectValue4, null, "ObjectType", new object[]
				{
					"{68b1d179-0d15-4d4f-ab71-46152e79a7bc}"
				}, null, null);
				NewLateBinding.LateSet(objectValue4, null, "AccessMask", new object[]
				{
					256
				}, null, null);
				object[] array;
				bool[] array2;
				NewLateBinding.LateCall(objectValue3, null, "AddAce", array = new object[]
				{
					objectValue4
				}, null, null, array2 = new bool[]
				{
					true
				}, true);
				if (array2[0])
				{
					objectValue4 = RuntimeHelpers.GetObjectValue(array[0]);
				}
				NewLateBinding.LateSet(objectValue2, null, "DiscretionaryAcl", new object[]
				{
					objectValue3
				}, null, null);
				NewLateBinding.LateCall(objectValue, null, "SetInfo", new object[0], null, null, null, true);
			}
			if (num == 2)
			{
				object objectValue5 = RuntimeHelpers.GetObjectValue(Interaction.GetObject("LDAP://CN=Rob Young, OU=Finance, DC=fabrikam,DC=Com", null));
				object objectValue6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue5, null, "Get", new object[]
				{
					"ntSecurityDescriptor"
				}, null, null, null));
				object objectValue7 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue6, null, "DiscretionaryACL", new object[0], null, null, null));
				object objectValue8 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("AccessControlEntry", ""));
				NewLateBinding.LateSet(objectValue8, null, "Trustee", new object[]
				{
					"FABRIKAM\\kmyer"
				}, null, null);
				NewLateBinding.LateSet(objectValue8, null, "AceFlags", new object[]
				{
					0
				}, null, null);
				NewLateBinding.LateSet(objectValue8, null, "AceType", new object[]
				{
					5
				}, null, null);
				NewLateBinding.LateSet(objectValue8, null, "Flags", new object[]
				{
					3
				}, null, null);
				NewLateBinding.LateSet(objectValue8, null, "ObjectType", new object[]
				{
					"{68b1d179-0d15-4d4f-ab71-46152e79a7bc}"
				}, null, null);
				NewLateBinding.LateSet(objectValue8, null, "AccessMask", new object[]
				{
					256
				}, null, null);
				object[] array;
				bool[] array2;
				NewLateBinding.LateCall(objectValue7, null, "AddAce", array = new object[]
				{
					objectValue8
				}, null, null, array2 = new bool[]
				{
					true
				}, true);
				if (array2[0])
				{
					objectValue8 = RuntimeHelpers.GetObjectValue(array[0]);
				}
				NewLateBinding.LateSet(objectValue6, null, "DiscretionaryAcl", new object[]
				{
					objectValue7
				}, null, null);
				NewLateBinding.LateCall(objectValue5, null, "SetInfo", new object[0], null, null, null, true);
			}
			object result;
			return result;
		}

		// Token: 0x0400068F RID: 1679
		public static object enumFontFamily;

		// Token: 0x04000690 RID: 1680
		public static object enumHorizontalAlignment;

		// Token: 0x04000691 RID: 1681
		public static object enumVerticalAlignment;

		// Token: 0x04000692 RID: 1682
		public static object enumBorderStyle;

		// Token: 0x04000693 RID: 1683
		public static object enumFontCharset;

		// Token: 0x04000694 RID: 1684
		public static object enumPattern;

		// Token: 0x04000695 RID: 1685
		public static object enumBuiltInNamedRange;

		// Token: 0x04000696 RID: 1686
		public static object enumWorkbookTheme;
	}
}
