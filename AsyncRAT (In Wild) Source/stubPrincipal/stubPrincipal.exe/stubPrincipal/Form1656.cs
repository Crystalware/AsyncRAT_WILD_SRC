using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using stubPrincipal.xlsgen;

namespace stubPrincipal
{
	// Token: 0x0200001E RID: 30
	internal class Form1656 : Form
	{
		// Token: 0x06001040 RID: 4160 RVA: 0x0005090C File Offset: 0x0004EB0C
		public Form1656()
		{
			object obj;
			if (obj == null)
			{
				if (Form1656.m_InitializingDefInstance)
				{
					obj = this;
				}
				else
				{
					try
					{
						if (Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == base.GetType())
						{
							obj = this;
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
			this.InitializeComponent();
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0005096C File Offset: 0x0004EB6C
		protected override void Dispose(bool Disposing)
		{
			if (Disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(Disposing);
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0005098B File Offset: 0x0004EB8B
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00050994 File Offset: 0x0004EB94
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

		// Token: 0x06001044 RID: 4164 RVA: 0x000509D8 File Offset: 0x0004EBD8
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			new ResourceManager(typeof(Form1656));
			this.components = new Container();
			this.ToolTip1 = new ToolTip(this.components);
			this.ToolTip1.Active = true;
			this.Command1 = new Button();
			this.Text = "Form1";
			base.ClientSize = new Size(312, 211);
			base.Location = new Point(4, 25);
			base.StartPosition = FormStartPosition.WindowsDefaultLocation;
			this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.AutoScaleBaseSize = new Size(5, 13);
			this.BackColor = SystemColors.Control;
			base.FormBorderStyle = FormBorderStyle.Sizable;
			base.ControlBox = true;
			base.Enabled = true;
			base.KeyPreview = false;
			base.MaximizeBox = true;
			base.MinimizeBox = true;
			this.Cursor = Cursors.Default;
			this.RightToLeft = RightToLeft.No;
			base.ShowInTaskbar = true;
			base.HelpButton = false;
			base.WindowState = FormWindowState.Normal;
			base.Name = "Form1";
			this.Command1.TextAlign = ContentAlignment.MiddleCenter;
			this.Command1.Text = "Create charts";
			this.Command1.Size = new Size(185, 49);
			this.Command1.Location = new Point(32, 32);
			this.Command1.TabIndex = 0;
			this.Command1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Command1.BackColor = SystemColors.Control;
			this.Command1.CausesValidation = true;
			this.Command1.Enabled = true;
			this.Command1.ForeColor = SystemColors.ControlText;
			this.Command1.Cursor = Cursors.Default;
			this.Command1.RightToLeft = RightToLeft.No;
			this.Command1.TabStop = true;
			this.Command1.Name = "Command1";
			base.Controls.Add(this.Command1);
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x00050BDC File Offset: 0x0004EDDC
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x00050C2F File Offset: 0x0004EE2F
		public static Form1656 DefInstance
		{
			get
			{
				object obj;
				if (Conversions.ToBoolean(obj == null || Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "IsDisposed", new object[0], null, null, null))))
				{
					Form1656.m_InitializingDefInstance = true;
					obj = new Form1656();
					Form1656.m_InitializingDefInstance = false;
				}
				return (Form1656)obj;
			}
			set
			{
			}
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00050C34 File Offset: 0x0004EE34
		private void Command1_Click(object eventSender, EventArgs eventArgs)
		{
			CoXlsEngine o = (CoXlsEngine)Interaction.CreateObject("ExcelGenerator.ARsTDesign", "");
			IXlsWorkbook xlsWorkbook;
			IXlsWorksheet xlsWorksheet = xlsWorkbook.get_AddWorksheet("Sheet1");
			IXlsStyle xlsStyle = xlsWorksheet.NewStyle();
			IXlsStyle xlsStyle2 = xlsWorksheet.NewStyle();
			NewLateBinding.LateSetComplex(xlsStyle2.Font(), null, "Bold", new object[]
			{
				1
			}, null, null, false, true);
			IXlsStyle xlsStyle3 = xlsWorksheet.NewStyle();
			NewLateBinding.LateSetComplex(xlsStyle3.Font(), null, "Italic", new object[]
			{
				1
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(xlsStyle3.Font(), null, "Size", new object[]
			{
				11
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(xlsStyle3.Font(), null, "Color", new object[]
			{
				8913117
			}, null, null, false, true);
			xlsStyle2.Apply();
			xlsStyle3.Apply();
			xlsStyle.Apply();
			IXlsChart xlsChart = (IXlsChart)xlsWorksheet.get_NewChart(null, 8, 1, 16, 5);
			NewLateBinding.LateSetComplex(xlsChart.DataSource(), null, "SeriesInRows", new object[]
			{
				1
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(xlsChart.DataSource(), null, "Range", new object[]
			{
				"Sheet1!R1C2:R3C6"
			}, null, null, false, true);
			IXlsChart xlsChart2 = (IXlsChart)xlsWorksheet.get_NewChart(null, 18, 1, 32, 8);
			NewLateBinding.LateSetComplex(xlsChart2.DataSource(), null, "SeriesInRows", new object[]
			{
				1
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(xlsChart2.DataSource(), null, "Range", new object[]
			{
				"Sheet1!R1C2:R3C6"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(xlsChart2.Legend(), null, "Show", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(xlsChart2.MainTitle(), null, "Label", new object[]
			{
				"a sample 3D chart"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(xlsChart2.MainTitle(), null, "Options", new object[0], null, null, null), null, "X", new object[]
			{
				80
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(xlsChart2.MainTitle(), null, "Options", new object[0], null, null, null), null, "Y", new object[]
			{
				5
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.MainTitle(), null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Borders", new object[0], null, null, null), null, "Shadow", new object[]
			{
				1
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.MainTitle(), null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Area", new object[0], null, null, null), null, "Type", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SurfaceArea, null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Borders", new object[0], null, null, null), null, "RoundCorners", new object[]
			{
				1
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SurfaceArea, null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Borders", new object[0], null, null, null), null, "Type", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SurfaceArea, null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Borders", new object[0], null, null, null), null, "style", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SurfaceArea, null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Borders", new object[0], null, null, null), null, "Weight", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SurfaceArea, null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Borders", new object[0], null, null, null), null, "Color", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SurfaceArea, null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Area", new object[0], null, null, null), null, "Type", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SurfaceArea, null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Area", new object[0], null, null, null), null, "Gradient", new object[0], null, null, null), null, "SingleColor", new object[0], null, null, null), null, "GradientStyle", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SurfaceArea, null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Area", new object[0], null, null, null), null, "Gradient", new object[0], null, null, null), null, "SingleColor", new object[0], null, null, null), null, "Color", new object[]
			{
				14518272
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SurfaceArea, null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Area", new object[0], null, null, null), null, "Gradient", new object[0], null, null, null), null, "SingleColor", new object[0], null, null, null), null, "LightThreshold", new object[]
			{
				100
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SeriesByIndex(1), null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Borders", new object[0], null, null, null), null, "Type", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SeriesByIndex(1), null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Area", new object[0], null, null, null), null, "Type", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SeriesByIndex(1), null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Area", new object[0], null, null, null), null, "Gradient", new object[0], null, null, null), null, "SingleColor", new object[0], null, null, null), null, "GradientStyle", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SeriesByIndex(1), null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Area", new object[0], null, null, null), null, "Gradient", new object[0], null, null, null), null, "SingleColor", new object[0], null, null, null), null, "Color", new object[]
			{
				221
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SeriesByIndex(1), null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Area", new object[0], null, null, null), null, "Gradient", new object[0], null, null, null), null, "SingleColor", new object[0], null, null, null), null, "LightThreshold", new object[]
			{
				100
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SeriesByIndex(2), null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Area", new object[0], null, null, null), null, "Type", new object[1], null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(xlsChart2.SeriesByIndex(2), null, "Options", new object[0], null, null, null), null, "Patterns", new object[0], null, null, null), null, "Area", new object[0], null, null, null), null, "PredefinedTexture", new object[0], null, null, null), null, "TextureStyle", new object[1], null, null, false, true);
			object instance = null;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Options", new object[0], null, null, null), null, "Font", new object[0], null, null, null), null, "Italic", new object[]
			{
				1
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Options", new object[0], null, null, null), null, "Font", new object[0], null, null, null), null, "Bold", new object[]
			{
				1
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Options", new object[0], null, null, null), null, "Font", new object[0], null, null, null), null, "Color", new object[]
			{
				14483456
			}, null, null, false, true);
			NewLateBinding.LateSet(instance, null, "MinorTicks", new object[1], null, null);
			xlsWorkbook.Close();
			Marshal.ReleaseComObject(o);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00051710 File Offset: 0x0004F910
		public int RGB_Renamed(ref object r, ref object g, ref object b)
		{
			return Conversions.ToInteger(Operators.AddObject(Operators.AddObject(Operators.MultiplyObject(r, 65536), Operators.MultiplyObject(g, 256)), b));
		}

		// Token: 0x04000807 RID: 2055
		private IContainer components;

		// Token: 0x04000808 RID: 2056
		public ToolTip ToolTip1;

		// Token: 0x0400080A RID: 2058
		private static bool m_InitializingDefInstance;
	}
}
