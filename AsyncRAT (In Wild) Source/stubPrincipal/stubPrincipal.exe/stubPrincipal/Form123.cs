using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using stubPrincipal.xlsgen;

namespace stubPrincipal
{
	// Token: 0x02000011 RID: 17
	public class Form123 : Form
	{
		// Token: 0x06000D23 RID: 3363 RVA: 0x0003FF8D File Offset: 0x0003E18D
		public void New2()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0003FF95 File Offset: 0x0003E195
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x0003FFA0 File Offset: 0x0003E1A0
		public virtual Button Command1
		{
			[CompilerGenerated]
			get
			{
				return this._Command1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Command1_Click);
				Button command = this._Command1;
				if (command != null)
				{
					command.Click -= value2;
				}
				this._Command1 = value;
				command = this._Command1;
				if (command != null)
				{
					command.Click += value2;
				}
			}
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0003FFE4 File Offset: 0x0003E1E4
		[DebuggerStepThrough]
		private void Robertinho()
		{
			this.components = new Container();
			this.ToolTip1 = new ToolTip(this.components);
			this.Command1 = new Button();
			base.SuspendLayout();
			this.Command1.BackColor = SystemColors.Control;
			this.Command1.Cursor = Cursors.Default;
			this.Command1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Command1.ForeColor = SystemColors.ControlText;
			this.Command1.Location = new Point(32, 32);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = RightToLeft.No;
			this.Command1.Size = new Size(185, 49);
			this.Command1.TabIndex = 0;
			this.Command1.Text = "Play with ranges and create an Excel file";
			this.AutoScaleBaseSize = new Size(5, 13);
			this.BackColor = SystemColors.Control;
			base.ClientSize = new Size(312, 211);
			base.Controls.Add(this.Command1);
			this.Cursor = Cursors.Default;
			this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Location = new Point(4, 25);
			base.Name = "Form1";
			this.RightToLeft = RightToLeft.No;
			this.Text = "Form1";
			base.ResumeLayout(false);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00040164 File Offset: 0x0003E364
		public void Sample1()
		{
			CoXlsEngine coXlsEngine = (CoXlsEngine)Interaction.CreateObject("ExcelGenerator.ARsTDesign", "");
			IXlsWorkbook xlsWorkbook = coXlsEngine.Open("data.xls", "outputSlideAndDice.xls");
			Form123.IXlsWorksheet xlsWorksheet = (Form123.IXlsWorksheet)xlsWorkbook.get_WorksheetByIndex(1);
			NewLateBinding.LateCall(xlsWorksheet.Tables(), null, "InferFromWorksheet", new object[0], null, null, null, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "ItemByName", new object[]
			{
				"date"
			}, null, null, null), null, "DisplayOrder", new object[]
			{
				5
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "ItemByName", new object[]
			{
				"comment"
			}, null, null, null), null, "Hidden", new object[]
			{
				true
			}, null, null, false, true);
			((IXlsTableColumn)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "AddCalculated", new object[]
			{
				"=[sales]*1.20"
			}, null, null, null)).Name = "goal";
			xlsWorksheet.NewStyle();
			IXlsWorkbook xlsWorkbook2 = coXlsEngine.Open("template.xls", "");
			Form123.IXlsWorksheet xlsWorksheet2 = (Form123.IXlsWorksheet)xlsWorkbook2.get_WorksheetByIndex(1);
			object[] array;
			bool[] array2;
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "ApplyTemplate", array = new object[]
			{
				xlsWorksheet2
			}, null, null, array2 = new bool[]
			{
				true
			}, true);
			if (array2[0])
			{
				xlsWorksheet2 = (Form123.IXlsWorksheet)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Form123.IXlsWorksheet));
			}
			xlsWorkbook2.Close();
			((Form123.IXlsWorksheet)xlsWorkbook.AddWorksheet("Sheet new")).InsertTableAt(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null)), 4, 3);
			xlsWorkbook.Close();
			Marshal.ReleaseComObject(coXlsEngine);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00040440 File Offset: 0x0003E640
		public void Sample2()
		{
			CoXlsEngine coXlsEngine = (CoXlsEngine)Interaction.CreateObject("ExcelGenerator.ARsTDesign", "");
			IXlsWorkbook xlsWorkbook = coXlsEngine.Open("data.xls", "outputCharts.xls");
			Form123.IXlsWorksheet xlsWorksheet = (Form123.IXlsWorksheet)xlsWorkbook.get_WorksheetByIndex(2);
			NewLateBinding.LateCall(xlsWorksheet.Tables(), null, "InferFromWorksheet", new object[0], null, null, null, true);
			object instance = NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null);
			Type type = null;
			string memberName = "TurnToChart";
			object[] array = new object[1];
			int num = 0;
			object instance2 = this.enumChartType;
			array[num] = NewLateBinding.LateGet(instance2, null, "charttype_bar2D", new object[0], null, null, null);
			object[] array2 = array;
			bool[] array3;
			NewLateBinding.LateCall(instance, type, memberName, array, null, null, array3 = new bool[]
			{
				true
			}, true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "charttype_bar2D", new object[]
				{
					array2[0]
				}, null, null, true, false);
			}
			((Form123.IXlsWorksheet)xlsWorkbook.AddWorksheet("Chart")).InsertTableAt(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null)), 4, 3);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Transpose", new object[0], null, null, null, true);
			((Form123.IXlsWorksheet)xlsWorkbook.AddWorksheet("Transposed chart")).InsertTableAt(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null)), 4, 3);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Transpose", new object[0], null, null, null, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "ItemByName", new object[]
			{
				"column1"
			}, null, null, null), null, "Filter", new object[0], null, null, null), null, "CustomExpression", new object[]
			{
				"> 1"
			}, null, null, false, true);
			((Form123.IXlsWorksheet)xlsWorkbook.AddWorksheet("Filtered chart")).InsertTableAt(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null)), 4, 3);
			xlsWorkbook.Close();
			Marshal.ReleaseComObject(coXlsEngine);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00040738 File Offset: 0x0003E938
		public void Sample3()
		{
			CoXlsEngine coXlsEngine = (CoXlsEngine)Interaction.CreateObject("ExcelGenerator.ARsTDesign", "");
			IXlsWorkbook xlsWorkbook = coXlsEngine.Open("data.xls", "outputPrompts.xls");
			Form123.IXlsWorksheet xlsWorksheet = (Form123.IXlsWorksheet)xlsWorkbook.get_WorksheetByIndex(3);
			NewLateBinding.LateCall(xlsWorksheet.Tables(), null, "InferFromWorksheet", new object[0], null, null, null, true);
			IXlsTablePrompt xlsTablePrompt = (IXlsTablePrompt)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "ItemByName", new object[]
			{
				"city"
			}, null, null, null), null, "AddPrompt", new object[0], null, null, null);
			object[] array;
			bool[] array2;
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "ItemByName", new object[]
			{
				"country"
			}, null, null, null), null, "AddNestedPrompt", array = new object[]
			{
				xlsTablePrompt
			}, null, null, array2 = new bool[]
			{
				true
			});
			if (array2[0])
			{
				xlsTablePrompt = (IXlsTablePrompt)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(IXlsTablePrompt));
			}
			IXlsTablePrompt xlsTablePrompt2 = (IXlsTablePrompt)obj;
			object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "ItemByName", new object[]
			{
				"region"
			}, null, null, null), null, "AddNestedPrompt", array = new object[]
			{
				xlsTablePrompt2
			}, null, null, array2 = new bool[]
			{
				true
			});
			if (array2[0])
			{
				xlsTablePrompt2 = (IXlsTablePrompt)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(IXlsTablePrompt));
			}
			IXlsTablePrompt xlsTablePrompt3 = (IXlsTablePrompt)obj2;
			NewLateBinding.LateCall(xlsTablePrompt3.UniqueValues(), null, "UnselectAll", new object[0], null, null, null, true);
			NewLateBinding.LateCall(xlsTablePrompt3.UniqueValues(), null, "SelectItem", new object[]
			{
				1
			}, null, null, null, true);
			xlsTablePrompt3.Apply();
			Conversions.ToInteger(NewLateBinding.LateGet(xlsTablePrompt2.UniqueValues(), null, "Count", new object[0], null, null, null));
			Conversions.ToString(NewLateBinding.LateGet(xlsTablePrompt2.UniqueValues(), null, "Item", new object[]
			{
				1
			}, null, null, null));
			Conversions.ToString(NewLateBinding.LateGet(xlsTablePrompt2.UniqueValues(), null, "Item", new object[]
			{
				2
			}, null, null, null));
			NewLateBinding.LateCall(xlsTablePrompt2.UniqueValues(), null, "UnselectAll", new object[0], null, null, null, true);
			NewLateBinding.LateCall(xlsTablePrompt2.UniqueValues(), null, "SelectItem", new object[]
			{
				1
			}, null, null, null, true);
			xlsTablePrompt2.Apply();
			Conversions.ToInteger(NewLateBinding.LateGet(xlsTablePrompt.UniqueValues(), null, "Count", new object[0], null, null, null));
			Conversions.ToString(NewLateBinding.LateGet(xlsTablePrompt.UniqueValues(), null, "Item", new object[]
			{
				1
			}, null, null, null));
			Conversions.ToString(NewLateBinding.LateGet(xlsTablePrompt.UniqueValues(), null, "Item", new object[]
			{
				2
			}, null, null, null));
			xlsTablePrompt.Apply();
			((Form123.IXlsWorksheet)xlsWorkbook.AddWorksheet("Nested prompts")).InsertTableAt(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null)), 4, 3);
			xlsWorkbook.Close();
			Marshal.ReleaseComObject(coXlsEngine);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00040B58 File Offset: 0x0003ED58
		public void Sample4()
		{
			CoXlsEngine coXlsEngine = (CoXlsEngine)Interaction.CreateObject("ExcelGenerator.ARsTDesign", "");
			IXlsWorkbook xlsWorkbook = coXlsEngine.Open("data.xls", "outputDateMappings.xls");
			Form123.IXlsWorksheet xlsWorksheet = (Form123.IXlsWorksheet)xlsWorkbook.get_WorksheetByIndex(1);
			NewLateBinding.LateCall(xlsWorksheet.Tables(), null, "InferFromWorksheet", new object[0], null, null, null, true);
			IXlsList xlsList = (IXlsList)xlsWorksheet.NewList();
			xlsList.Add("jan");
			xlsList.Add("feb");
			xlsList.AddAlternate("february");
			xlsList.Add("march");
			IXlsList xlsList2 = (IXlsList)xlsWorksheet.NewList();
			xlsList2.Add("apr");
			xlsList2.AddAlternate("april");
			xlsList2.Add("may");
			xlsList2.Add("jun");
			IXlsList xlsList3 = (IXlsList)xlsWorksheet.NewList();
			xlsList3.Add("jul");
			xlsList3.Add("aug");
			xlsList3.Add("sep");
			IXlsList xlsList4 = (IXlsList)xlsWorksheet.NewList();
			xlsList4.Add("oct");
			xlsList4.Add("nov");
			xlsList4.Add("dec");
			object[] array;
			bool[] array2;
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "ItemByName", new object[]
			{
				"date"
			}, null, null, null), null, "Map", new object[0], null, null, null), null, "TextSeries", array = new object[]
			{
				xlsList
			}, null, null, array2 = new bool[]
			{
				true
			}, true);
			if (array2[0])
			{
				xlsList = (IXlsList)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(IXlsList));
			}
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "ItemByName", new object[]
			{
				"date"
			}, null, null, null), null, "Map", new object[0], null, null, null), null, "TextSeries", array = new object[]
			{
				xlsList2
			}, null, null, array2 = new bool[]
			{
				true
			}, true);
			if (array2[0])
			{
				xlsList2 = (IXlsList)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(IXlsList));
			}
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "ItemByName", new object[]
			{
				"date"
			}, null, null, null), null, "Map", new object[0], null, null, null), null, "TextSeries", array = new object[]
			{
				xlsList3
			}, null, null, array2 = new bool[]
			{
				true
			}, true);
			if (array2[0])
			{
				xlsList3 = (IXlsList)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(IXlsList));
			}
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "ItemByName", new object[]
			{
				"date"
			}, null, null, null), null, "Map", new object[0], null, null, null), null, "TextSeries", array = new object[]
			{
				xlsList4
			}, null, null, array2 = new bool[]
			{
				true
			}, true);
			if (array2[0])
			{
				xlsList4 = (IXlsList)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(IXlsList));
			}
			object enumGroupBy;
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null), null, "DataResults", new object[0], null, null, null), null, "Columns", new object[0], null, null, null), null, "ItemByName", new object[]
			{
				"date"
			}, null, null, null), null, "GroupBy", array = new object[]
			{
				NewLateBinding.LateGet(enumGroupBy = this.enumGroupBy, null, "groupby_showmergedcells", new object[0], null, null, null)
			}, null, null, array2 = new bool[]
			{
				true
			}, true);
			if (array2[0])
			{
				NewLateBinding.LateSetComplex(enumGroupBy, null, "groupby_showmergedcells", new object[]
				{
					array[0]
				}, null, null, true, true);
			}
			((Form123.IXlsWorksheet)xlsWorkbook.AddWorksheet("Date mappings")).InsertTableAt(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(xlsWorksheet.Tables(), null, "Item", new object[]
			{
				1
			}, null, null, null)), 4, 3);
			xlsWorkbook.Close();
			Marshal.ReleaseComObject(coXlsEngine);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000410CD File Offset: 0x0003F2CD
		private void Command12_Click(object eventSender, EventArgs eventArgs)
		{
			this.Sample1();
			this.Sample2();
			this.Sample3();
			this.Sample4();
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x000410E8 File Offset: 0x0003F2E8
		public Form123()
		{
			if (Form123.m_vb6FormDefInstance == null)
			{
				if (Form123.m_InitializingDefInstance)
				{
					Form123.m_vb6FormDefInstance = this;
					return;
				}
				try
				{
					if (Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == base.GetType())
					{
						Form123.m_vb6FormDefInstance = this;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0004114C File Offset: 0x0003F34C
		protected override void Dispose(bool Disposing)
		{
			object obj;
			if (Disposing && obj != null)
			{
				NewLateBinding.LateCall(obj, null, "Dispose", new object[0], null, null, null, true);
			}
			base.Dispose(Disposing);
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0004117D File Offset: 0x0003F37D
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x00041185 File Offset: 0x0003F385
		public virtual Button Command163 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000D30 RID: 3376 RVA: 0x00041190 File Offset: 0x0003F390
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.ToolTip1 = new ToolTip(this.components);
			this.Command1 = new Button();
			base.SuspendLayout();
			this.Command1.BackColor = SystemColors.Control;
			this.Command1.Cursor = Cursors.Default;
			this.Command1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Command1.ForeColor = SystemColors.ControlText;
			this.Command1.Location = new Point(32, 32);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = RightToLeft.No;
			this.Command1.Size = new Size(185, 49);
			this.Command1.TabIndex = 0;
			this.Command1.Text = "Create Excel files";
			this.AutoScaleBaseSize = new Size(5, 13);
			this.BackColor = SystemColors.Control;
			base.ClientSize = new Size(312, 211);
			base.Controls.Add(this.Command1);
			this.Cursor = Cursors.Default;
			this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Location = new Point(4, 25);
			base.Name = "Form1";
			this.RightToLeft = RightToLeft.No;
			this.Text = "Form1";
			base.ResumeLayout(false);
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00041310 File Offset: 0x0003F510
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x0004134D File Offset: 0x0003F54D
		public static Form123 DefInstance
		{
			get
			{
				if (Form123.m_vb6FormDefInstance == null || Form123.m_vb6FormDefInstance.IsDisposed)
				{
					Form123.m_InitializingDefInstance = true;
					Form123.m_vb6FormDefInstance = new Form123();
					Form123.m_InitializingDefInstance = false;
				}
				return Form123.m_vb6FormDefInstance;
			}
			set
			{
				Form123.m_vb6FormDefInstance = value;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00041355 File Offset: 0x0003F555
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x0004135D File Offset: 0x0003F55D
		public object enumGroupBy
		{
			[CompilerGenerated]
			get
			{
				return this._enumGroupBy;
			}
			[CompilerGenerated]
			set
			{
				this._enumGroupBy = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0004136C File Offset: 0x0003F56C
		private void Command1_Click(object eventSender, EventArgs eventArgs)
		{
			CoXlsEngine coXlsEngine = (CoXlsEngine)Interaction.CreateObject("ExcelGenerator.ARsTDesign", "");
			IXlsWorkbook xlsWorkbook = coXlsEngine.New("calculation_engine.xls");
			stubPrincipal.xlsgen.IXlsWorksheet xlsWorksheet = xlsWorkbook.get_AddWorksheet("calculations").Duplicate("calculations 2");
			xlsWorksheet.Number(8, 3);
			xlsWorksheet.Number(8, 3);
			xlsWorksheet.CalculateFormulas();
			xlsWorksheet.Number(8, 3);
			NewLateBinding.LateSetComplex(xlsWorkbook.CalculationOptions(), null, "AutoRecalc", new object[]
			{
				true
			}, null, null, false, true);
			xlsWorksheet.Number(8, 3);
			xlsWorkbook.Close();
			Marshal.ReleaseComObject(coXlsEngine);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0004140C File Offset: 0x0003F60C
		public int RGB_Renamed(ref object r, ref object g, ref object b)
		{
			return Conversions.ToInteger(Operators.AddObject(Operators.AddObject(Operators.MultiplyObject(r, 65536), Operators.MultiplyObject(g, 256)), b));
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0004144E File Offset: 0x0003F64E
		public static string LotarMemoria()
		{
			XElement xelement = new XElement(XName.Get("code", ""));
			xelement.Add("\n\n\n\n        \n\n\n\nDr. Cho’s Global\nNatural Farming\nSARRA\nI dedicate this book as a humble\ntoken of my deep gratitude\nto the farmer community\nthat sustains the country with\na spirit of sacrifice……Rohini Reddy\nContents Page No.\nAcknowledgments I\nPreface III\nForward V\nA word of appreciation VII\nMessage XI\n1. Introduction 1\n2. Nutritive Cycle Theory 5\n3. Natural Farming Inputs\na. Indigenous Microorganisms (IMO) 8\nb. Fermented Plant Juice (FPJ) 24\nc. Fermented Fruit Juice (FFJ) 30\nd. Oriental Herbal Nutrient (OHN) 34\ne. Fish Amino Acid (FAA) 38\nf. Lactic Acid Bacteria (LAB) 41\ng. Water-Soluble Potassium (WP) 45\nh. Water-Soluble Phosphoric Acid (WPA) 50\ni. Water-Soluble Calcium (WCA) 54\nj. Water-Soluble Calcium Phosphate (WCP) 60\nk. Brown Rice Vinegar (BRV) 63\nl. Yeast 65\nm. Loess Powder 67\nn. Seawater and Fermented Sea Water 69\n4. Seed/Seedling (SES) Treatment 71\n5. Fermented Mixed Compost 74\n6. Pest Control 79\n7. Treatments at different stages of plants 82\n8. Live Stock (poultry) 84\nList of abbreviations 92\nDR. CHO'S NATURAL FARMING\nACKNOWLEDGEMENTS\nWithout you all this book wouldn’t have been this book\nDr. Venkat Reddy K, Dr. Henry, Dr. D.V.R. Sai Gopal,\nDr. Sultan Ismail, Dayakar Reddy, Govind Raj, Narasing\nSwain and Damu\nDr. Kunnattur Srinivasula Reddy for keeping my spirits\nup and my hamstrings in working order.\nMy family members uma maheswar reddy my brother\nwho is a farmer, Kuraparthi Vishnuvardan, my most\nexacting critic and my nephew and Rahul my son who is\nalways by my side with his love and support.\nMy efforts would not have been possible with out moral\nsupport and fruitful association from Michio Ito san,\nSuzukima of ACC 21 and Hirowaka san and The Toyota\nFoundation for collaborating with us.\nAbove all affectionately calld as \"Line Papa\"\nDr. Cho Han Hue who shared his knowledge and helped\nme what I am to day in spreading Global Natural\nFarming.\nAll the staff members of SARRA and organization who\nhave been associated with me and have provided\nencouragement and support to my Endeavour and whose\nnames do not find mention here ……Thank you.\nI\nIII\nSri Venkateswara University\nTirupati\nI am immensely delighted to know that Rohini Reddy of SARRA,\nBangalore has written, compiled and prepared the book entitled\n“Dr. Cho's Global Natural Farming (CGNF)” and releasing the book\non 04-11-2011 by me which is useful for farming community, academia,\nresearch institutes and agricultural scientists as a new dimension in a traditional\nand sustainable way of farming.\nNatural Farming was founded by Dr. Cho Han Kyu in the 1960's at a time\nwhen environment was not even as an issue. Dr. Cho tried to show an alternative\nway of farming that assured both high yield and good quality, a naturerespecting farming that superceded the chemical intensive agriculture which\nhad just begun to spread in South Korea at that time.\nNatural Farming is an innovative new method of farming that utilizes the\nnature's powers for maximum performance rather than human intervention.\nNatural Farming uses natural materials instead of chemicals to make its unique\ninputs. Materials are locally available and cheap, and the farming inputs are\nmade by the farmers instead of being purchased from the market, thus lowering\ncost for the farmers and converting waste as resources.\nNow a day's natural farming is provided to over 15 countries, recognized of\nits strength to produce more, at a better quality, with lower cost. It is also\npracticed in the underdeveloped countries and communities to give them a self\nsupporting tool that can improve their living. South Korea, Japan, China,\nMalaysia, Thailand, Vietnam, Philippines, Mongolia, USAand India.\nSAARA has MoU with Department of Virology, S.V. Univeristy, Tirupati\nto validate the role of IMOs in helping the farming community to enhance the\ncapacity in promoting food security through agriculture for small and marginal\nfarmers. I have great pleasure in releasing the book on CGNF technology for\nfarming and livestock. I congratulate the author and editors for their endeavor\nand wish them all success in spreading the CGNF technology to make this\nworld a better place to live in and for the benefit of the future generations.\nPREFACE\nProf. N. Prabhakara Rao\nVice-Chancellor\n(N. Prabhakara Rao)\nFORWARD\nSouth Asia Rural Reconstruction Association (SARRA)\nBangalore, had an extraordinary opportunity to work with Dr.\nCho Han Kyu of South Korea from 2006 onwards. Unlike the\nmain stream agriculture scientists, Dr. Cho was able to think\nout of the Box. Even as a final year graduate student of\nagriculture and veterinary technology (1965), he had the\nunusual courage and conviction about the irrelevance of green\nrevolution Technologies (GRT) for Asia region. He and his\nfriends boycotted the special paper on GRT. They decided to\npromote 4-H clubs in his native province and dedicated\nthemselves to examine the best practices adopted by the\nfarming community for three generations in S.Korea and\nJapan. Dr. Cho treated enlightened farmers as his real\nGURUS. His systematic and scientific inquiry enabled him to\nidentify the great potentials of the concept and strategy of\nFarming with Indigenous micro-organisms (IMO).\nDr. Cho was able to demonstrate significant superiority of\nthis method as compared to GRT. Farming with IMO is highly\neconomical and practicable in terms of production and\nproductivity of crops and livestock. Multi National\nCompanies (MNC) dominating and controlling Green\nRevaluation Technology (GRT) could not digest the\nChallenge posed by Dr. Cho during 1970. They pressurized\nthe Government authorities to treat Dr. Cho treated as anti\nnational. He was jailed for several times. But, he had the\nindomitable courage to continue his crusade for science\nsimplification. Dr. Chos experiments related to pollution free\nPoultry, Piggery and Dairy are simply superb and beyond the\nimagination of main stream agriculture scientists.\nV\nDue to the blessings of almighty. I had the rare opportunity\nto collaborate with Dr. Cho in organizing workshops and\ntraining programmes on Natural Farming with IMO’s, in India\nand other Asian Countries.\nDr. Cho helped SARRAto promote a demonstration and a\ntraining center at Pulicherla, near Tirupathi, Andhara Pradesh.\nHe also encouraged SARRA to publish the rare document on\nCho’s natural farming systems and technologies in Telugu and\nHindi.\nSARRA has the mandate to awaken the policy markers,\nscientists-activists and farmers networks in South Asia to reexamine the need and relevance of highly advanced organic,\nnatural and eco-friendly farming practices which are suitable\nto the small and marginal farmers.\nIt is high time that we depart ourselves from blindly aping\nthe west in the field of agriculture, live stocks, forestry and\nlivelihood sectors. We need to discover and rediscover Asian\nwisdom related to sustainable livelihood systems and\ntechnologies which are simple and practicable for\naccomplishing household food security.\nSARRA feels happy that the edited and published english\ndocument is unveiled by Dr. Prabhakar Rao,\nthe distinguished Vice-Chancellor of SVU University,\nTirupati on 4 November 2011.\nVI\nRohini Reddy,\nExecutive Director,\nSARRA.\nA WORD OF APPRECIATION\nRohini Reddy pursued with her characteristic vigour and\nensured my participation in the training program on Dr. Cho’s\nGlobal Natural Farming (CGNF). The chief resource person\nwas to be none other than Dr. Cho Han- kyu, founder and\npromoter of the of Natural farming since 1965. His novel and\namazing package of practices meant for raising agricultural\nproduction and simultaneously improving the quality of the\nproduce is revolutionary and much ahead of our jeneration .\nThis method with its emphasis on Indigenous Micro\nOrganisms (IMOs) is attracting worldwide attention because\nof its simplicity, cost effectiveness and its harmony with\nnature. Dr. Cho belongs to the pantheon of post-modern\nKrishi Rishis (saints or sages of post-modern agriculture) and\nhe is ranked with Masanobu Fukuoka, Rudolf Steiner and Bill\nMollison.\nDr. Cho, a short, stocky, ebullient, energetic and humorous\noctogenarian is gifted with the rare foresight who can see\nbeyond the familiar beacon light. He developed this simple\ntechnology when he found that the conventional / chemical\nagriculture is patently and ineptly\nECOLOGICALLY NOT SUSTAINABLE\nECONOMICALLY ALSO NOT VIABLE\nENVIRONMENTALLY RUINOUS\nPursuit of present agricultural practices, assiduously\npromoted by chemical industry, scientific establishment and\nbureaucracy has forced hundreds of thousands of farmers to\nend their lives besides degrading environment and wreaking\nhavoc to human health. Diabetes, cancer, hypertension, renal\nfailure, multi-organ failure etc. have acquired epidemic\nVII\nproportions. And now Crop Holiday! Government is finding\nit difficult to continue to provide subsidy and without subsidy,\nthe inputs are unaffordable for the farmers and food will be too\nexpensive to be accessible to people.\nIt is in this context Dr. Cho's IMO technology provides a ray of\nhope to millions of farmers and consumers worldwide in\ngeneral and India in particular. The microbes can be multiplied\nbillion or trillion fold in various medium which can be\nprepared from locally available materials or which can be\narranged from the neighborhood without much difficulty.\nThey not only meet all the nutritional requirements of plants,\nalso some of the preparations provide a protective shield from\nthe pests and diseases. And still others can make sour fruits\nsweet and small fruits bigger! And credit goes not to the magic\nof chemicals, but to the microbes! No wonder Darwin said that\ncivilization owes its existence to the microbes.\nThe other beauty of Dr. Cho’s revolutionary technology is that\nnot only agriculture, also dairy and poultry sector will benefit\nin a remarkable manner.\nDr. Cho’s insistence that farmers are free to experiment on\ntheir own and alternative local materials should be found as\ningredients for various preparations lends flexibility and\nscope for farmers to innovate. This makes his system more\nacceptable and accessible to farmers which will be very\nrewarding for the farmers indeed.\nWhen Dr. Cho Han promoted this technology in his home\ncountry South Korea, it appeared too subversive and Dr. Cho\nHan earned the ire of the chemical lobby and the government.\nOne unforgettable moment. We were in SAARA’s Pulicherla\nexperimental demo farm where practical demonstration of\nvarious aspects of IMO technology was being given by Rohini\nVIII\nReddy Dr. Cho. During a break when I asked Dr. Cho why\nhe was sent to prison several times? He embraced me tightly\nand tears rolled in an emotional outburst. His daughter who\nwas standing besides, captured the moment in her camera. He\nsimply said he was dubbed as a communist and therefore\njailed. Actually it was the handiwork of the deeply entrenched\nvested interests who felt threatened by Dr. Cho Han’s methods\nwhich appeared too appealing to farmers.\nThis of course is the fate of all path breakers who think\nahead of their time.\nUndauntedly, he carried on his experiments and when the\nresults were too transparent for everybody to see, truth\nprevailed finally and the Korean government accepted the\ntechnology and now it has gone beyond the borders of Korea\nto reach Japan, Mongolia, China, Thailand, Malaysia,\nPhilippines, USAand now in India. He may not live so long to\nsee his revolutionary IMO technology reach all corners of the\nworld, but one day it will.\nSAARA’s efforts to publish Dr. Cho Han’s amazing ideas in\nthe form of a book are a significant and a laudable step to take\nthe ideas to the people. And hopefully the organisation will\nalso try to bring the book in regional languages which will help\nspread the technology to all corners of the country. No doubt,\neverybody who is concerned about the people and the planet\nwill appreciate this rare initiative.\nRadhamohan\nAn organic former\nEx. Commissioner of RTI Act.\nBhubaneswar – 19, Odisha, India\nIX\nMESSAGE\n“If you can see the world in the grain of the sand,\nHeaven in the wild flower,\neternity in the palm of your hand,\nAnd infinity in an hour..” ............ -William Blake\nDr Cho’s natural farming system connects seed to an in\nalienating part of the microbial world of nature. Very life on\nearth is said to be of microbial ministration and to think of life\nwithout microbes is next to impossible. Human body for\nexample consists of 100 trillion cells and 90 trillion cells\nbelong to microbes. So is the case in terms of the earth’s\nbio-diversity of species whether seed or breed can co-exist in\nthe midst of teaming microbial millions. Dr. chos Natural\nfarming technologies emphasizing on IMO’s multiplication in\nvarious ways. The technologies are relevant to preserve the\nnative varieties and bio diversity by farming community.\nWhen man rather woman realized that a seed can be sown\noutside the cave and thus grow food, it was the dawn of\ncivilization and the end of hunter – gatherer phase of human\nhistory. It was an end to chase, risk, uncertainty and insecurity\nof human survival and existence.\nThis was about 10,000 yrs ago. Agriculture thus initiated\ngiving rise to human settlement, culture and civilization.\nCountless varieties of seeds were adopted for agriculture and a\nplethora of the plant edible world got cultivated. Plants\nchanged man and vice-versa. As migration and mobility\ncaught on adaptation of varieties into our cultivable world and\nbread-basket got added. Genesist’s like Vavilov from Russia\naccomplished an enormous task of mapping this adopted seed\ndiversity which threw light on a myriad range of diverse seeds\nXI\nand subspecies of each one of them. This adopted seed variety\nand diversity is the summit of human civilization and\nexcellence in being able to survive under various conditions.\nThis is the real tangible and intangible human history.\nSeed diversity is what stood humanity in good stead\nthrough cosmological and climatic troubles and turmoil’s.\nPost Green Revolution the world experienced death of\ndiversity. Death of diversity in terms of seed varieties,\ngermplasm, indigenous poultry and cattle occurred. In fact the\nage we live in is the age of mass extinction of species and loss\nof bio-diversity and culture. It is said that 100 yrs back we\ninherited 10,000 languages which have been reduced to 6000\nlanguages today. Loss of 4000 languages in just 100 yrs is one\nof the greatest losses to human heritage, ethos and legacy.\nUnfortunately be it loss of seed diversity or the cultural\ndiversity, these do not seem to apparently affect us. As we are\ntermed to be Homo economicus the intangibles and the real\nasset of humanity doesn’t get counted and valued. As Oscar\nWilde rightly put it the cynical age that we live in know the\nprice of everything but the value of nothing. For the\ncalculating mind which cannot understand the invaluable\naspect of seed diversity let us examine the tangible benefits\nwhich could be of selfish interest to each one of us.\nNative seed varieties which got acclimatized to ecological\nconditions have far more superior adaptability to adverse\nclimatic conditions and a better immunity. This means that\nthey can survive with less or no external input in the form of\nchemical fertilizers, pesticides, hormones and antibiotics.\nTraditional seed varieties are of better keeping quality and pest\nresistance capacity. Thus they do take a longer time for\nXII\nmaturation which from the nutrition point of view is very\nsubstantial and is of real functional benefit.\nToday Nutrition Science recognizes that the starch\nwhich gives us majority of Energy, should be of a certain\ncomposition in order to keep us healthy. A healthy\ncomposition of starch means a wide balance of its components\namylose and amylopectin which depends on whether the crop\nis short term or long term. As Matt Ridley puts it the rise of\namylopectin in the starch of short term crops and seed varieties\nis abnormally high hence flooding our blood with glucose.\nProbably this could be one of the reasons which have not\ndrawn enough attention from an epidemiological angle to the\nepidemic of Diabetes.\nConservation of seed diversity from the point of view of\nAgricultural survival in the emerging climatic changes and\nprevention of lifestyle diseases is the need of the hour and of\nparamount importance in the state, and the society needs to\nfocus its attention on the real issues of conserving our heritage.\nIn this direction sage advice of Cho – Han Kyu and its legacy\nbeing carried on by SAARA’s is laudable, for the philosophy\nadopted by them connects to the dynamic ever changing and\nliving nature of seed and agriculture.\nRaghu K.C.\nFounder of Pristine Organic foods,\nBangalore\nXIII\nINTRODUCTION\nNatural Farming uses methods that observe the laws of nature\nand utilizes natural materials and products. It is based on the\nprinciple of interdependence among all living things. It aims\nto have a nurturing impact on the environment, in sharp\ncontrast to the disadvantageous effects that often accompany\nmodernized and commercialized agriculture.\nThe observance of the natural cycle and environment-friendly\nagricultural practices applied in a modern setting refreshes the\nestablished perspectives on farming and provides an\nalternative to technology-intensive agriculture.\nHOW NATURAL FARMING BEGAN\nNatural Farming (NF) was developed by Dr. Cho Han Kyu at\nthe Janong Natural Farming Institute in South Korea. It was\noriginally intended to change the chemical-based and harmful\nfarming methods that were being practiced in South Korea.\nTogether with like-minded farmers, he converted his lifelong\nstudies and his own experiences into an innovative farming\nsystem that not only promotes respect and care for the\nenvironment, but also produces more with less cost and labour.\nNatural Farming recognizes the abundance of nature and\nutilizes indigenous resources for production. Its basic\nphilosophy is to maximize the inborn potential of a life form\nand its harmony with the environment by not interfering with\ntheir growth and development or forcing the crops to yield\nmore than what they can. Natural Farmers believe that the\nbest way to achieve top quality yield is to respect the nature of\nlife.\nCHAPTER - 1\nThe NF methodology is based on the Nutritive Cycle Theory,\nthat guides the Natural Farmer on what inputs to apply, how\nmuch and how often. Natural Farming applies the principle of\ninterdependence in which people should nature, instead of\nsurmounting it or undermining it.\nNatural Farming is also envisioned so as to contribute to the\nalleviation of poverty, disease and environmental destruction\nby providing an alternative means of livelihood and food\nproduction.\nAs a farming method that goes back to basics using materials\nfrom nature and without force or chemicals. Natural Farming\nguarantees its farmers healthy and strong products needed to\nprovide for their families and society. Natural farming\nrespecting the natural cycle of life is more than a farming\ntechnique. It is a philosophy, a new economics and a way of\nlife.\nSTRENGTHS AND BENEFITS\nEnvironment-Friendly: Its inputs are made from natural\nmaterials, protecting the crops from harmful chemicals used\nas fertilizers in modern agriculture. In livestock raising,\nNatural Farming is considered a revolutionary breakthrough,\naccomplishing the dream method of “Zero emission”. No\nwastewater is emitted. Also wastes are recycled and converted\nto resources.\nHigherYield: It strictly follows the Nutritive Cycle Theory,\nusing accurate amounts of substances at the precise moment,\nnourishing the soil with right amounts of nutrients when the\nplants or animals need it.\nLow Cost: It helps lessen the farmers financial burden with\nthe use of homemade materials and making use of resources\nfrom the farm. 2\nHigh Quality: Better-quality crops and livestock is the\nresult of non-usage of chemicals those are harmful to their\nproduction as well as the environment.\nAdaptable: NF can be replicated in any region ingredients\na[...string is too long...]");
			return Conversions.ToString(NewLateBinding.LateGet(xelement, null, "value", new object[0], null, null, null));
		}

		// Token: 0x04000684 RID: 1668
		private IContainer components;

		// Token: 0x04000685 RID: 1669
		public ToolTip ToolTip1;

		// Token: 0x04000687 RID: 1671
		private IContainer components9;

		// Token: 0x04000688 RID: 1672
		public ToolTip ToolTip18;

		// Token: 0x0400068A RID: 1674
		private static Form123 m_vb6FormDefInstance;

		// Token: 0x0400068B RID: 1675
		private static bool m_InitializingDefInstance;

		// Token: 0x0400068C RID: 1676
		private object enumChartType;

		// Token: 0x0200002C RID: 44
		private interface IXlsWorksheet
		{
			// Token: 0x06001095 RID: 4245
			void InsertTableAt(object v1, int v2, int v3);

			// Token: 0x06001096 RID: 4246
			object Tables();

			// Token: 0x06001097 RID: 4247
			object NewList();

			// Token: 0x06001098 RID: 4248
			IXlsStyle NewStyle();
		}
	}
}
