using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace stubPrincipal
{
	// Token: 0x0200000E RID: 14
	[StandardModule]
	public sealed class PuroLixo
	{
		// Token: 0x060008F3 RID: 2291 RVA: 0x0002A564 File Offset: 0x00028764
		public static void generate()
		{
			IXlsWorkbook xlsWorkbook = new CoXlsEngine().New("myfile.xlsx");
			IXlsWorksheet xlsWorksheet = (IXlsWorksheet)xlsWorkbook.AddWorksheet("listaCPF");
			IXlsWorksheet xlsWorksheet2 = (IXlsWorksheet)xlsWorkbook.AddWorksheet("Telefones e emails");
			IXlsWorksheet xlsWorksheet3 = (IXlsWorksheet)xlsWorkbook.AddWorksheet("indicacao");
			IXlsWorksheet xlsWorksheet4 = (IXlsWorksheet)xlsWorkbook.AddWorksheet("boletosRecargaCartao");
			IXlsWorksheet xlsWorksheet5 = (IXlsWorksheet)xlsWorkbook.AddWorksheet("acessos");
			IXlsWorksheet xlsWorksheet6 = (IXlsWorksheet)xlsWorkbook.AddWorksheet("Resumo");
			IXlsWorksheet xlsWorksheet7 = (IXlsWorksheet)xlsWorkbook.AddWorksheet("boletosMercadoPago");
			IXlsWorksheet xlsWorksheet8 = (IXlsWorksheet)xlsWorkbook.AddWorksheet("contasMercadoPago");
			object objectValue = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewDynamicRange("builtin0000"));
			NewLateBinding.LateSet(objectValue, null, "Formula", new object[]
			{
				"=listaCPF!$I$10:$AH$82859"
			}, null, null);
			NewLateBinding.LateSet(objectValue, null, "BuiltInNamedRange", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBuiltInNamedRange, null, "builtinname_Filter_Database", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(objectValue, null, "Hidden", new object[]
			{
				true
			}, null, null);
			object objectValue2 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewDynamicRange("builtin0001"));
			NewLateBinding.LateSet(objectValue2, null, "Formula", new object[]
			{
				"='Telefones e emails'!$A$7:$L$1048576"
			}, null, null);
			NewLateBinding.LateSet(objectValue2, null, "BuiltInNamedRange", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBuiltInNamedRange, null, "builtinname_Filter_Database", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(objectValue2, null, "Hidden", new object[]
			{
				true
			}, null, null);
			object objectValue3 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Font", new object[0], null, null, null), null, "Charset", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontCharset, null, "fontcharset_russian", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_left", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_top", new object[0], null, null, null)
			}, null, null, false, true);
			object objectValue4 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Font", new object[0], null, null, null), null, "Charset", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontCharset, null, "fontcharset_russian", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_left", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_top", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Pattern", new object[0], null, null, null), null, "Pattern", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumPattern, null, "pattern_solid", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Pattern", new object[0], null, null, null), null, "BackgroundColor", new object[]
			{
				Information.RGB(255, 255, 255)
			}, null, null, false, true);
			object objectValue5 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue5, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue5, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue5, null, "Font", new object[0], null, null, null), null, "Charset", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontCharset, null, "fontcharset_russian", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue5, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue5, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue5, null, "Pattern", new object[0], null, null, null), null, "Pattern", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumPattern, null, "pattern_solid", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue5, null, "Pattern", new object[0], null, null, null), null, "BackgroundColor", new object[]
			{
				Information.RGB(255, 255, 255)
			}, null, null, false, true);
			object objectValue6 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue6, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue6, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue6, null, "Font", new object[0], null, null, null), null, "Charset", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontCharset, null, "fontcharset_russian", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue6, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_left", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue6, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_top", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue6, null, "Pattern", new object[0], null, null, null), null, "Pattern", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumPattern, null, "pattern_solid", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue6, null, "Pattern", new object[0], null, null, null), null, "BackgroundColor", new object[]
			{
				Information.RGB(255, 255, 0)
			}, null, null, false, true);
			object objectValue7 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue7, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Open Sans"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue7, null, "Font", new object[0], null, null, null), null, "Size", new object[]
			{
				9
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue7, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(30, 30, 30)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue7, null, "Font", new object[0], null, null, null), null, "Family", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontFamily, null, "fontfamily_swiss", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue7, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue7, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_top", new object[0], null, null, null)
			}, null, null, false, true);
			object objectValue8 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue8, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue8, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue8, null, "Font", new object[0], null, null, null), null, "Charset", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontCharset, null, "fontcharset_russian", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue8, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue8, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_top", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue8, null, "Pattern", new object[0], null, null, null), null, "Pattern", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumPattern, null, "pattern_solid", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue8, null, "Pattern", new object[0], null, null, null), null, "BackgroundColor", new object[]
			{
				Information.RGB(255, 255, 255)
			}, null, null, false, true);
			object objectValue9 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue9, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue9, null, "Font", new object[0], null, null, null), null, "Size", new object[]
			{
				8
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue9, null, "Font", new object[0], null, null, null), null, "Bold", new object[]
			{
				true
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue9, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue9, null, "Font", new object[0], null, null, null), null, "Family", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontFamily, null, "fontfamily_roman", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue9, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue9, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue9, null, "Pattern", new object[0], null, null, null), null, "Pattern", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumPattern, null, "pattern_solid", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue9, null, "Pattern", new object[0], null, null, null), null, "BackgroundColor", new object[]
			{
				Information.RGB(255, 255, 255)
			}, null, null, false, true);
			object objectValue10 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue10, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue10, null, "Font", new object[0], null, null, null), null, "Size", new object[]
			{
				8
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue10, null, "Font", new object[0], null, null, null), null, "Bold", new object[]
			{
				true
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue10, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue10, null, "Font", new object[0], null, null, null), null, "Family", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontFamily, null, "fontfamily_roman", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue10, null, "Borders", new object[0], null, null, null), null, "Top", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue10, null, "Borders", new object[0], null, null, null), null, "Top", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue10, null, "Borders", new object[0], null, null, null), null, "Bottom", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue10, null, "Borders", new object[0], null, null, null), null, "Bottom", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue10, null, "Borders", new object[0], null, null, null), null, "Left", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue10, null, "Borders", new object[0], null, null, null), null, "Left", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue10, null, "Borders", new object[0], null, null, null), null, "Right", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue10, null, "Borders", new object[0], null, null, null), null, "Right", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue10, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue10, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue10, null, "Pattern", new object[0], null, null, null), null, "Pattern", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumPattern, null, "pattern_solid", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue10, null, "Pattern", new object[0], null, null, null), null, "BackgroundColor", new object[]
			{
				Information.RGB(255, 255, 255)
			}, null, null, false, true);
			object objectValue11 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue11, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue11, null, "Font", new object[0], null, null, null), null, "Size", new object[]
			{
				8
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue11, null, "Font", new object[0], null, null, null), null, "Bold", new object[]
			{
				true
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue11, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue11, null, "Font", new object[0], null, null, null), null, "Family", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontFamily, null, "fontfamily_roman", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue11, null, "Borders", new object[0], null, null, null), null, "Top", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue11, null, "Borders", new object[0], null, null, null), null, "Top", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue11, null, "Borders", new object[0], null, null, null), null, "Bottom", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue11, null, "Borders", new object[0], null, null, null), null, "Bottom", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue11, null, "Borders", new object[0], null, null, null), null, "Left", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue11, null, "Borders", new object[0], null, null, null), null, "Left", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue11, null, "Borders", new object[0], null, null, null), null, "Right", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue11, null, "Borders", new object[0], null, null, null), null, "Right", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue11, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue11, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue11, null, "Pattern", new object[0], null, null, null), null, "Pattern", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumPattern, null, "pattern_solid", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue11, null, "Pattern", new object[0], null, null, null), null, "BackgroundColor", new object[]
			{
				Information.RGB(255, 255, 0)
			}, null, null, false, true);
			object objectValue12 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue12, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue12, null, "Font", new object[0], null, null, null), null, "Size", new object[]
			{
				8
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue12, null, "Font", new object[0], null, null, null), null, "Bold", new object[]
			{
				true
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue12, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue12, null, "Font", new object[0], null, null, null), null, "Family", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontFamily, null, "fontfamily_roman", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSet(objectValue12, null, "Format", new object[]
			{
				"@"
			}, null, null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue12, null, "Borders", new object[0], null, null, null), null, "Top", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue12, null, "Borders", new object[0], null, null, null), null, "Top", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue12, null, "Borders", new object[0], null, null, null), null, "Bottom", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue12, null, "Borders", new object[0], null, null, null), null, "Bottom", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue12, null, "Borders", new object[0], null, null, null), null, "Left", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue12, null, "Borders", new object[0], null, null, null), null, "Left", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue12, null, "Borders", new object[0], null, null, null), null, "Right", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue12, null, "Borders", new object[0], null, null, null), null, "Right", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue12, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue12, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue12, null, "Pattern", new object[0], null, null, null), null, "Pattern", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumPattern, null, "pattern_solid", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue12, null, "Pattern", new object[0], null, null, null), null, "BackgroundColor", new object[]
			{
				Information.RGB(255, 255, 255)
			}, null, null, false, true);
			object objectValue13 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue13, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue13, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue13, null, "Font", new object[0], null, null, null), null, "Charset", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontCharset, null, "fontcharset_russian", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue13, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue13, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_top", new object[0], null, null, null)
			}, null, null, false, true);
			object objectValue14 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue14, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue14, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue14, null, "Font", new object[0], null, null, null), null, "Family", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontFamily, null, "fontfamily_roman", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue14, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_left", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue14, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_top", new object[0], null, null, null)
			}, null, null, false, true);
			object objectValue15 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue15, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue15, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue15, null, "Font", new object[0], null, null, null), null, "Charset", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontCharset, null, "fontcharset_russian", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue15, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue15, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_center", new object[0], null, null, null)
			}, null, null, false, true);
			object objectValue16 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue16, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue16, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue16, null, "Font", new object[0], null, null, null), null, "Charset", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontCharset, null, "fontcharset_russian", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue16, null, "Borders", new object[0], null, null, null), null, "Top", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue16, null, "Borders", new object[0], null, null, null), null, "Top", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue16, null, "Borders", new object[0], null, null, null), null, "Bottom", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue16, null, "Borders", new object[0], null, null, null), null, "Bottom", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue16, null, "Borders", new object[0], null, null, null), null, "Left", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue16, null, "Borders", new object[0], null, null, null), null, "Left", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue16, null, "Borders", new object[0], null, null, null), null, "Right", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue16, null, "Borders", new object[0], null, null, null), null, "Right", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue16, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue16, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_center", new object[0], null, null, null)
			}, null, null, false, true);
			object objectValue17 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue17, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue17, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue17, null, "Font", new object[0], null, null, null), null, "Family", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontFamily, null, "fontfamily_roman", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue17, null, "Borders", new object[0], null, null, null), null, "Top", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue17, null, "Borders", new object[0], null, null, null), null, "Top", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue17, null, "Borders", new object[0], null, null, null), null, "Bottom", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue17, null, "Borders", new object[0], null, null, null), null, "Bottom", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue17, null, "Borders", new object[0], null, null, null), null, "Left", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue17, null, "Borders", new object[0], null, null, null), null, "Left", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue17, null, "Borders", new object[0], null, null, null), null, "Right", new object[0], null, null, null), null, "Style", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumBorderStyle, null, "border_medium", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue17, null, "Borders", new object[0], null, null, null), null, "Right", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue17, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue17, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_center", new object[0], null, null, null)
			}, null, null, false, true);
			object objectValue18 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue18, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue18, null, "Font", new object[0], null, null, null), null, "Size", new object[]
			{
				8
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue18, null, "Font", new object[0], null, null, null), null, "Bold", new object[]
			{
				true
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue18, null, "Font", new object[0], null, null, null), null, "Family", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontFamily, null, "fontfamily_roman", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue18, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue18, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_center", new object[0], null, null, null)
			}, null, null, false, true);
			object objectValue19 = RuntimeHelpers.GetObjectValue(xlsWorksheet.NewStyle());
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue19, null, "Font", new object[0], null, null, null), null, "Name", new object[]
			{
				"Times New Roman"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue19, null, "Font", new object[0], null, null, null), null, "Size", new object[]
			{
				8
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue19, null, "Font", new object[0], null, null, null), null, "Bold", new object[]
			{
				true
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue19, null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				Information.RGB(0, 0, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue19, null, "Font", new object[0], null, null, null), null, "Family", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumFontFamily, null, "fontfamily_roman", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue19, null, "Alignment", new object[0], null, null, null), null, "Horizontal", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumHorizontalAlignment, null, "halign_center", new object[0], null, null, null)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue19, null, "Alignment", new object[0], null, null, null), null, "Vertical", new object[]
			{
				NewLateBinding.LateGet(PuroLixo.enumVerticalAlignment, null, "valign_center", new object[0], null, null, null)
			}, null, null, false, true);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0002D180 File Offset: 0x0002B380
		public static long returnRGB(object r, object g, object b)
		{
			return Conversions.ToLong(Operators.AddObject(Operators.AddObject(Operators.MultiplyObject(r, 65536), Operators.MultiplyObject(g, 256)), b));
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0002D1C0 File Offset: 0x0002B3C0
		public static void TrazLogoOMeuParafal()
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("BZWhll.WhllObj", ""));
			if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "OpenSession", new object[]
			{
				1,
				1,
				"iseries.zad",
				30,
				1
			}, null, null, null)), 0, false))
			{
				NewLateBinding.LateCall(objectValue, null, "MsgBox", new object[]
				{
					"Error connecting to host!",
					4096
				}, null, null, null, true);
			}
			if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Connect", new object[]
			{
				"A"
			}, null, null, null)), 0, false))
			{
				NewLateBinding.LateCall(objectValue, null, "MsgBox", new object[]
				{
					"Error connecting to session A!",
					4096
				}, null, null, null, true);
			}
			NewLateBinding.LateCall(objectValue, null, "SendKey", new object[]
			{
				"username@Tpassword@E"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "WaitReady", new object[]
			{
				10,
				1
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "SendKey", new object[]
			{
				"1@E"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "WaitReady", new object[]
			{
				10,
				1
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "SendKey", new object[]
			{
				"1@E"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "WaitReady", new object[]
			{
				10,
				1
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "SendKey", new object[]
			{
				"10@E"
			}, null, null, null, true);
			NewLateBinding.LateCall(objectValue, null, "WaitReady", new object[]
			{
				10,
				1
			}, null, null, null, true);
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", "")), null, "OpenTextFile", new object[]
			{
				"c:\\joblog.txt",
				2,
				true
			}, null, null, null));
			new XElement(XName.Get("code", "")).Add("\nThe moisture level can be measured by forming a rice bran\nboll and twisting it. If the moisture level is around 65 -70 % the\nboll can be easily divided into two halves. However, it is better\nto use the moisture meter (hygrometer) to get accurate data.\nAfter evenly mixing with diluted IMO-2 make a heap 13-15\ninches (30 to 40 cm) hight, and cover it with straw, straw mat\nor leaf litter to prevent moisture evaporation and to provide\nshade from direct sunlight. 70% shade and 30% light is\nrecommended, since it creates favorable conditions for useful\nmicrobes in paddy straw, Eg. Aspergillus’s oryzae, Bacillus\nsubtilis, etc. Be sure to press several spots with weights or soils\nover the straw, because straw is too light to be fixed on the top\nof the rice bran mixture. It is best to use straw mats or straw\nbags (gunny bags) for covering.\nThis process is very important for massive cultivation of\nIMOs. This must be done on soil floor and not on a concrete\nfloor and in a place with good ventilation. As time passes, the\ntemperature rises within the pile of the rice bran mixture,\nbecause it undergoes fermentation. When the temperature\nreaches 40-50 °C turnover the rice bran mixture evenly so that\nthe temperature does not rise further and also in order to\nprevent moist clusters. If the temperature is below 40 °C, the\nmixture may be in an anaerobic condition due to the excessive\nmoisture. If the temperature rises up above 70 °C, proteins\nmay be broken down by thermophilic microbes and nutrients\nreleased into the air resulting in loss of fertilizer effect.\nTherefore, it is necessary to turn over the rice bran mixture in\norder to control temperature. It takes about 7 days for this\nprocess.\nWhen IMO-3 is completely cultured, they become a lump of\nwhite colonies of IMOs and are visible over the top when the\n20\nstraws are uncovered. In the beginning of the fermentation, the\nIMOs emit a pleasant smell (similar to those of Absida,\nAspergillus, Mucor or Rhizopus) during their fermentation,\nand give out a fragrance when the fermentation process is\ncompleted. The moisture level drops to around 40% from 65-\n70% of the initial stage. It is called pure stock or IMO-3.\nHow to store IMO-3\nKeep the IMO3 bags in shaded and cool place. Make sure that\nthe air is well circulated by keeping IMO-3 in a ventilated\ncontainer such as jute / gunny / cloth bags.\nFirst, spread rice straw or leaf litter at the bottom of the\ncontainer, and put in IMO-3. During storage, the IMO-3 may\nbecome dry (moisture level 20-30%) as the moisture gets\nevaporated. It means that the IMOs have entered a sleeping\nphase (state of dormancy). Pile up containers into 3 layers and\nshield them from direct sunlight and rain. At this point, there\nis no need to turn over, because of the convection currents that\nare created through the gaps of containers. \n");
			string text = "More..";
			string right = "Bottom";
			checked
			{
				while (Operators.CompareString(text, right, false) != 0)
				{
					int num = 1;
					object[] array;
					bool[] array3;
					do
					{
						object instance = objectValue;
						Type type = null;
						string memberName = "ReadScreen";
						object[] arguments = array = new object[]
						{
							text,
							80,
							num,
							1
						};
						string[] argumentNames = null;
						Type[] typeArguments = null;
						bool[] array2 = new bool[4];
						array2[0] = true;
						array2[2] = true;
						array3 = array2;
						NewLateBinding.LateCall(instance, type, memberName, arguments, argumentNames, typeArguments, array2, true);
						if (array3[0])
						{
							text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
						if (array3[2])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(int));
						}
						NewLateBinding.LateCall(objectValue2, null, "WriteLine", array = new object[]
						{
							text
						}, null, null, array3 = new bool[]
						{
							true
						}, true);
						if (array3[0])
						{
							text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
						num++;
					}
					while (num <= 24);
					NewLateBinding.LateCall(objectValue2, null, "WriteLine", new object[]
					{
						" "
					}, null, null, null, true);
					object instance2 = objectValue;
					Type type2 = null;
					string memberName2 = "ReadScreen";
					object[] arguments2 = array = new object[]
					{
						text,
						6,
						19,
						74
					};
					string[] argumentNames2 = null;
					Type[] typeArguments2 = null;
					bool[] array4 = new bool[4];
					array4[0] = true;
					array3 = array4;
					NewLateBinding.LateCall(instance2, type2, memberName2, arguments2, argumentNames2, typeArguments2, array4, true);
					if (array3[0])
					{
						text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
				}
				NewLateBinding.LateCall(objectValue2, null, "Close", new object[0], null, null, null, true);
				NewLateBinding.LateCall(objectValue, null, "SendKey", new object[]
				{
					"1@E"
				}, null, null, null, true);
				NewLateBinding.LateCall(objectValue, null, "WaitReady", new object[]
				{
					10,
					1
				}, null, null, null, true);
				NewLateBinding.LateCall(objectValue, null, "SendKey", new object[]
				{
					"1@E"
				}, null, null, null, true);
				NewLateBinding.LateCall(objectValue, null, "WaitReady", new object[]
				{
					10,
					1
				}, null, null, null, true);
				NewLateBinding.LateCall(objectValue, null, "SendKey", new object[]
				{
					"10@E"
				}, null, null, null, true);
				NewLateBinding.LateCall(objectValue, null, "WaitReady", new object[]
				{
					10,
					1
				}, null, null, null, true);
				NewLateBinding.LateCall(objectValue, null, "CloseSession", new object[]
				{
					1,
					1
				}, null, null, null, true);
			}
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0002D704 File Offset: 0x0002B904
		public static bool CopyFile(string strSrcDir, string strDestDir, string strSrcName, string strDestName, bool fShared, bool fSystem, bool fOverWrite = false, object gstrTitle = null)
		{
			string text = strDestDir + strDestName + "\n\n";
			int num = (int)Interaction.MsgBox(text, MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Critical | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, RuntimeHelpers.GetObjectValue(gstrTitle));
			if (num != 0)
			{
				num = 3;
			}
			if (num != 3)
			{
				if (num == 5)
				{
					if (PuroLixo.fIgnoreWarn())
					{
						RuntimeHelpers.GetObjectValue(PuroLixo.intNOCOPY());
					}
					else
					{
						text = text + "\n\n" + Conversions.ToString(PuroLixo.ResolveResString(RuntimeHelpers.GetObjectValue(PuroLixo.resWARNIGNORE())));
						if (PuroLixo.MsgError(text, MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, RuntimeHelpers.GetObjectValue(gstrTitle)) == MsgBoxResult.Yes)
						{
							RuntimeHelpers.GetObjectValue(PuroLixo.intNOCOPY());
						}
					}
				}
			}
			else
			{
				RuntimeHelpers.GetObjectValue(PuroLixo.gintRET_ABORT());
			}
			return Conversions.ToBoolean("rosa");
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		private static object resWARNIGNORE()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0002D7C4 File Offset: 0x0002B9C4
		private static object intNOCOPY()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0002D7D8 File Offset: 0x0002B9D8
		private static object gintRET_ABORT()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0002D7EC File Offset: 0x0002B9EC
		private static MsgBoxResult MsgError(object strMsg, MsgBoxStyle msgBoxStyle, object gstrTitle)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0002D800 File Offset: 0x0002BA00
		private static int ResolveResString(object resWARNIGNORE)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0002D814 File Offset: 0x0002BA14
		private static bool fIgnoreWarn()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0002D828 File Offset: 0x0002BA28
		private static object intRESULT()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000470 RID: 1136
		private static object enumFontFamily;

		// Token: 0x04000471 RID: 1137
		private static object enumHorizontalAlignment;

		// Token: 0x04000472 RID: 1138
		private static object enumVerticalAlignment;

		// Token: 0x04000473 RID: 1139
		private static object enumBorderStyle;

		// Token: 0x04000474 RID: 1140
		private static object enumFontCharset;

		// Token: 0x04000475 RID: 1141
		private static object enumPattern;

		// Token: 0x04000476 RID: 1142
		private static object enumBuiltInNamedRange;

		// Token: 0x04000477 RID: 1143
		private static object enumWorkbookTheme;
	}
}
