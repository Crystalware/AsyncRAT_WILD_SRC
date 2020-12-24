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
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	internal class Form1 : Form
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0000B064 File Offset: 0x00009264
		public void New22323()
		{
			try
			{
				Type declaringType = Assembly.GetExecutingAssembly().EntryPoint.DeclaringType;
				base.GetType();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000B0A8 File Offset: 0x000092A8
		public void minhaROla()
		{
			object obj;
			if (base.Disposing && obj != null)
			{
				NewLateBinding.LateCall(obj, null, "Dispose", new object[0], null, null, null, true);
			}
			base.Dispose(base.Disposing);
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000B0E3 File Offset: 0x000092E3
		// (set) Token: 0x06000222 RID: 546 RVA: 0x0000B0EB File Offset: 0x000092EB
		public virtual Button Command12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000223 RID: 547 RVA: 0x0000B0F4 File Offset: 0x000092F4
		[DebuggerStepThrough]
		private void PaunoSeuCU()
		{
			this.components2 = new Container();
			this.ToolTip1 = new ToolTip(this.components2);
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
			this.Command1.Text = "Run the procedure";
			this.Command1.UseVisualStyleBackColor = false;
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000B280 File Offset: 0x00009480
		// (set) Token: 0x06000225 RID: 549 RVA: 0x0000B290 File Offset: 0x00009490
		public static Form1 DefInstance2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000B294 File Offset: 0x00009494
		private void Command12_Click(object eventSender, EventArgs eventArgs)
		{
			IXlsWorkbook xlsWorkbook = (IXlsWorkbook)((CoXlsEngine)Interaction.CreateObject("ExcelGenerator.ARsTDesign", "")).Open("Book1_testmacros.xls", "");
			IXlsWorksheet xlsWorksheet = xlsWorkbook.get_WorksheetByIndex(1);
			xlsWorkbook.VBAMacros();
			xlsWorksheet.VBAMacros();
			int num = Conversions.ToInteger(NewLateBinding.LateGet(xlsWorkbook.VBAModules, null, "Count", new object[0], null, null, null));
			checked
			{
				for (int i = 1; i <= num; i++)
				{
					object[] array;
					bool[] array2;
					object instance = NewLateBinding.LateGet(xlsWorkbook.VBAModules, null, "Item", array = new object[]
					{
						i
					}, null, null, array2 = new bool[]
					{
						true
					});
					if (array2[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					Conversions.ToString(NewLateBinding.LateGet(instance, null, "VBAMacros", new object[0], null, null, null));
				}
				xlsWorkbook.Close();
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000B380 File Offset: 0x00009580
		public Form1()
		{
			try
			{
				Type declaringType = Assembly.GetExecutingAssembly().EntryPoint.DeclaringType;
				base.GetType();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000B3C8 File Offset: 0x000095C8
		public void PauGrande()
		{
			if (base.Disposing && this.components2 != null)
			{
				this.components2.Dispose();
			}
			base.Dispose(base.Disposing);
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000B3F1 File Offset: 0x000095F1
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000B3F9 File Offset: 0x000095F9
		public virtual Button Command123 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600022B RID: 555 RVA: 0x0000B404 File Offset: 0x00009604
		[DebuggerStepThrough]
		private void PauMedio()
		{
			new Container();
			new ToolTip(this.components223());
			base.SuspendLayout();
			NewLateBinding.LateSetComplex(this.Command1234(), null, "BackColor", new object[]
			{
				SystemColors.Control
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(this.Command1234(), null, "Cursor", new object[]
			{
				Cursors.Default
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(this.Command1234(), null, "Font", new object[]
			{
				new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(this.Command1234(), null, "ForeColor", new object[]
			{
				SystemColors.ControlText
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(this.Command1234(), null, "Location", new object[]
			{
				new Point(32, 32)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(this.Command1234(), null, "Name", new object[]
			{
				"Command1"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(this.Command1234(), null, "RightToLeft", new object[]
			{
				RightToLeft.No
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(this.Command1234(), null, "Size", new object[]
			{
				new Size(185, 49)
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(this.Command1234(), null, "TabIndex", new object[]
			{
				0
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(this.Command1234(), null, "Text", new object[]
			{
				"Create pivot table"
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(this.Command1234(), null, "UseVisualStyleBackColor", new object[]
			{
				false
			}, null, null, false, true);
			this.AutoScaleBaseSize = new Size(5, 13);
			this.BackColor = SystemColors.Control;
			base.ClientSize = new Size(312, 211);
			base.Controls.Add((Control)this.Command1234());
			this.Cursor = Cursors.Default;
			this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Location = new Point(4, 25);
			base.Name = "Form1";
			this.RightToLeft = RightToLeft.No;
			this.Text = "Form1";
			base.ResumeLayout(false);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000B674 File Offset: 0x00009874
		private object Command1234()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000B688 File Offset: 0x00009888
		private IContainer components223()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000B69C File Offset: 0x0000989C
		private object Command123678789()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000B6B0 File Offset: 0x000098B0
		private IContainer components2276567()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000B6C4 File Offset: 0x000098C4
		private ToolTip ToolTip1223423454()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000B6D8 File Offset: 0x000098D8
		private IContainer components256756765()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000B6EC File Offset: 0x000098EC
		private object Command12234234243()
		{
			throw new NotImplementedException();
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000B700 File Offset: 0x00009900
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0000B710 File Offset: 0x00009910
		public static Form1 DefInstance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000B714 File Offset: 0x00009914
		private void Command1_Click(object eventSender, EventArgs eventArgs)
		{
			CoXlsEngine coXlsEngine = (CoXlsEngine)Interaction.CreateObject("ExcelGenerator.ARsTDesign", "");
			IXlsWorkbook xlsWorkbook = (IXlsWorkbook)coXlsEngine.Open("mu_report_300.xlsx", "pivottable.xlsx");
			IXlsWorksheet xlsWorksheet = xlsWorkbook.get_WorksheetByIndex(1);
			IXlsPivotTable xlsPivotTable = xlsWorkbook.get_AddWorksheet("SheetNew").NewPivotTable();
			NewLateBinding.LateSetComplex(xlsPivotTable.DataSource(), null, "Range", new object[]
			{
				"MU_REPORT!A1:S300"
			}, null, null, false, true);
			IXlsPivotTableField xlsPivotTableField = (IXlsPivotTableField)NewLateBinding.LateGet(xlsPivotTable.Rows(), null, "AddByName", new object[]
			{
				"EHR Product Name"
			}, null, null, null);
			NewLateBinding.LateCall(xlsPivotTable.Rows(), null, "AddByName", new object[]
			{
				"Vendor Name"
			}, null, null, null, true);
			NewLateBinding.LateCall(xlsPivotTable.Rows(), null, "AddByName", new object[]
			{
				"EHR Product Version"
			}, null, null, null, true);
			NewLateBinding.LateCall(xlsPivotTable.Data(), null, "AddByName", new object[]
			{
				"Specialty"
			}, null, null, null, true);
			xlsPivotTable.InsertAt(2, 2);
			xlsWorkbook.Close();
			Marshal.ReleaseComObject(coXlsEngine);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000B834 File Offset: 0x00009A34
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000B874 File Offset: 0x00009A74
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Button1 = new Button();
			this.CheckedListBox1 = new CheckedListBox();
			this.CheckBox1 = new CheckBox();
			this.Label1 = new Label();
			this.ComboBox1 = new ComboBox();
			this.ComboBox2 = new ComboBox();
			this.DateTimePicker1 = new DateTimePicker();
			this.MonthCalendar1 = new MonthCalendar();
			this.NumericUpDown1 = new NumericUpDown();
			this.PictureBox1 = new PictureBox();
			this.RadioButton1 = new RadioButton();
			this.ProgressBar1 = new ProgressBar();
			this.RichTextBox1 = new RichTextBox();
			this.RichTextBox2 = new RichTextBox();
			this.TreeView1 = new TreeView();
			this.WebBrowser1 = new WebBrowser();
			this.PictureBox2 = new PictureBox();
			this.ListBox1 = new ListBox();
			this.Label2 = new Label();
			this.ListView1 = new ListView();
			this.DateTimePicker2 = new DateTimePicker();
			this.CheckBox2 = new CheckBox();
			this.Button2 = new Button();
			this.Button3 = new Button();
			this.CheckedListBox2 = new CheckedListBox();
			this.DateTimePicker3 = new DateTimePicker();
			this.DateTimePicker4 = new DateTimePicker();
			this.CheckedListBox3 = new CheckedListBox();
			this.Button4 = new Button();
			this.Button5 = new Button();
			this.CheckBox3 = new CheckBox();
			this.DateTimePicker5 = new DateTimePicker();
			this.ListView2 = new ListView();
			this.Label3 = new Label();
			this.ListBox2 = new ListBox();
			this.PictureBox3 = new PictureBox();
			this.WebBrowser2 = new WebBrowser();
			this.TreeView2 = new TreeView();
			this.RichTextBox3 = new RichTextBox();
			this.RichTextBox4 = new RichTextBox();
			this.ProgressBar2 = new ProgressBar();
			this.RadioButton2 = new RadioButton();
			this.PictureBox4 = new PictureBox();
			this.NumericUpDown2 = new NumericUpDown();
			this.MonthCalendar2 = new MonthCalendar();
			this.DateTimePicker6 = new DateTimePicker();
			this.ComboBox3 = new ComboBox();
			this.ComboBox4 = new ComboBox();
			this.Label4 = new Label();
			this.CheckBox4 = new CheckBox();
			this.CheckedListBox4 = new CheckedListBox();
			this.Button6 = new Button();
			this.DateTimePicker7 = new DateTimePicker();
			this.CheckedListBox5 = new CheckedListBox();
			this.Button7 = new Button();
			this.Button8 = new Button();
			this.CheckBox5 = new CheckBox();
			this.DateTimePicker8 = new DateTimePicker();
			this.ListView3 = new ListView();
			this.Label5 = new Label();
			this.ListBox3 = new ListBox();
			this.PictureBox5 = new PictureBox();
			this.WebBrowser3 = new WebBrowser();
			this.TreeView3 = new TreeView();
			this.RichTextBox5 = new RichTextBox();
			this.RichTextBox6 = new RichTextBox();
			this.ProgressBar3 = new ProgressBar();
			this.RadioButton3 = new RadioButton();
			this.PictureBox6 = new PictureBox();
			this.NumericUpDown3 = new NumericUpDown();
			this.MonthCalendar3 = new MonthCalendar();
			this.DateTimePicker9 = new DateTimePicker();
			this.ComboBox5 = new ComboBox();
			this.ComboBox6 = new ComboBox();
			this.Label6 = new Label();
			this.CheckBox6 = new CheckBox();
			this.CheckedListBox6 = new CheckedListBox();
			this.Button9 = new Button();
			this.DateTimePicker10 = new DateTimePicker();
			this.CheckedListBox7 = new CheckedListBox();
			this.Button10 = new Button();
			this.Button11 = new Button();
			this.CheckBox7 = new CheckBox();
			this.DateTimePicker11 = new DateTimePicker();
			this.ListView4 = new ListView();
			this.Label7 = new Label();
			this.ListBox4 = new ListBox();
			this.PictureBox7 = new PictureBox();
			this.WebBrowser4 = new WebBrowser();
			this.TreeView4 = new TreeView();
			this.RichTextBox7 = new RichTextBox();
			this.RichTextBox8 = new RichTextBox();
			this.ProgressBar4 = new ProgressBar();
			this.RadioButton4 = new RadioButton();
			this.PictureBox8 = new PictureBox();
			this.NumericUpDown4 = new NumericUpDown();
			this.MonthCalendar4 = new MonthCalendar();
			this.DateTimePicker12 = new DateTimePicker();
			this.ComboBox7 = new ComboBox();
			this.ComboBox8 = new ComboBox();
			this.Label8 = new Label();
			this.CheckBox8 = new CheckBox();
			this.CheckedListBox8 = new CheckedListBox();
			this.Button12 = new Button();
			this.DateTimePicker13 = new DateTimePicker();
			this.CheckedListBox9 = new CheckedListBox();
			this.Button13 = new Button();
			this.Button14 = new Button();
			this.CheckBox9 = new CheckBox();
			this.DateTimePicker14 = new DateTimePicker();
			this.ListView5 = new ListView();
			this.Label9 = new Label();
			this.ListBox5 = new ListBox();
			this.PictureBox9 = new PictureBox();
			this.WebBrowser5 = new WebBrowser();
			this.TreeView5 = new TreeView();
			this.RichTextBox9 = new RichTextBox();
			this.RichTextBox10 = new RichTextBox();
			this.ProgressBar5 = new ProgressBar();
			this.RadioButton5 = new RadioButton();
			this.PictureBox10 = new PictureBox();
			this.NumericUpDown5 = new NumericUpDown();
			this.MonthCalendar5 = new MonthCalendar();
			this.DateTimePicker15 = new DateTimePicker();
			this.ComboBox9 = new ComboBox();
			this.ComboBox10 = new ComboBox();
			this.Label10 = new Label();
			this.CheckBox10 = new CheckBox();
			this.CheckedListBox10 = new CheckedListBox();
			this.Button15 = new Button();
			this.DateTimePicker16 = new DateTimePicker();
			this.CheckedListBox11 = new CheckedListBox();
			this.Button16 = new Button();
			this.Button17 = new Button();
			this.CheckBox11 = new CheckBox();
			this.DateTimePicker17 = new DateTimePicker();
			this.ListView6 = new ListView();
			this.ListBox6 = new ListBox();
			this.WebBrowser6 = new WebBrowser();
			this.TreeView6 = new TreeView();
			this.RichTextBox11 = new RichTextBox();
			this.RichTextBox12 = new RichTextBox();
			this.ProgressBar6 = new ProgressBar();
			this.RadioButton6 = new RadioButton();
			this.PictureBox11 = new PictureBox();
			this.NumericUpDown6 = new NumericUpDown();
			this.MonthCalendar6 = new MonthCalendar();
			this.DateTimePicker18 = new DateTimePicker();
			this.ComboBox11 = new ComboBox();
			this.ComboBox12 = new ComboBox();
			this.Label11 = new Label();
			this.CheckBox12 = new CheckBox();
			this.CheckedListBox12 = new CheckedListBox();
			this.Button18 = new Button();
			this.DateTimePicker19 = new DateTimePicker();
			this.CheckedListBox13 = new CheckedListBox();
			this.Button19 = new Button();
			this.Button20 = new Button();
			this.CheckBox13 = new CheckBox();
			this.DateTimePicker20 = new DateTimePicker();
			this.ListView7 = new ListView();
			this.ListBox7 = new ListBox();
			this.WebBrowser7 = new WebBrowser();
			this.TreeView7 = new TreeView();
			this.RichTextBox13 = new RichTextBox();
			this.RichTextBox14 = new RichTextBox();
			this.ProgressBar7 = new ProgressBar();
			this.RadioButton7 = new RadioButton();
			this.PictureBox12 = new PictureBox();
			this.NumericUpDown7 = new NumericUpDown();
			this.MonthCalendar7 = new MonthCalendar();
			this.DateTimePicker21 = new DateTimePicker();
			this.ComboBox13 = new ComboBox();
			this.ComboBox14 = new ComboBox();
			this.Label12 = new Label();
			this.CheckBox14 = new CheckBox();
			this.CheckedListBox14 = new CheckedListBox();
			this.Button21 = new Button();
			this.DateTimePicker22 = new DateTimePicker();
			this.CheckedListBox15 = new CheckedListBox();
			this.Button22 = new Button();
			this.Button23 = new Button();
			this.CheckBox15 = new CheckBox();
			this.DateTimePicker23 = new DateTimePicker();
			this.ListView8 = new ListView();
			this.ListBox8 = new ListBox();
			this.WebBrowser8 = new WebBrowser();
			this.TreeView8 = new TreeView();
			this.RichTextBox15 = new RichTextBox();
			this.RichTextBox16 = new RichTextBox();
			this.ProgressBar8 = new ProgressBar();
			this.RadioButton8 = new RadioButton();
			this.PictureBox13 = new PictureBox();
			this.NumericUpDown8 = new NumericUpDown();
			this.MonthCalendar8 = new MonthCalendar();
			this.DateTimePicker24 = new DateTimePicker();
			this.ComboBox15 = new ComboBox();
			this.ComboBox16 = new ComboBox();
			this.Label13 = new Label();
			this.CheckBox16 = new CheckBox();
			this.CheckedListBox16 = new CheckedListBox();
			this.Button24 = new Button();
			this.DateTimePicker25 = new DateTimePicker();
			this.CheckedListBox17 = new CheckedListBox();
			this.Button25 = new Button();
			this.CheckBox17 = new CheckBox();
			this.DateTimePicker26 = new DateTimePicker();
			this.ListView9 = new ListView();
			this.ListBox9 = new ListBox();
			this.WebBrowser9 = new WebBrowser();
			this.TreeView9 = new TreeView();
			this.RichTextBox17 = new RichTextBox();
			this.RichTextBox18 = new RichTextBox();
			this.ProgressBar9 = new ProgressBar();
			this.RadioButton9 = new RadioButton();
			this.PictureBox14 = new PictureBox();
			this.NumericUpDown9 = new NumericUpDown();
			this.MonthCalendar9 = new MonthCalendar();
			this.DateTimePicker27 = new DateTimePicker();
			this.ComboBox17 = new ComboBox();
			this.ComboBox18 = new ComboBox();
			this.Label14 = new Label();
			this.CheckBox18 = new CheckBox();
			this.CheckedListBox18 = new CheckedListBox();
			this.Button26 = new Button();
			this.DateTimePicker28 = new DateTimePicker();
			this.CheckedListBox19 = new CheckedListBox();
			this.Button27 = new Button();
			this.Button28 = new Button();
			this.CheckBox19 = new CheckBox();
			this.DateTimePicker29 = new DateTimePicker();
			this.ListView10 = new ListView();
			this.ListBox10 = new ListBox();
			this.WebBrowser10 = new WebBrowser();
			this.TreeView10 = new TreeView();
			this.RichTextBox19 = new RichTextBox();
			this.RichTextBox20 = new RichTextBox();
			this.ProgressBar10 = new ProgressBar();
			this.RadioButton10 = new RadioButton();
			this.PictureBox15 = new PictureBox();
			this.NumericUpDown10 = new NumericUpDown();
			this.MonthCalendar10 = new MonthCalendar();
			this.DateTimePicker30 = new DateTimePicker();
			this.ComboBox19 = new ComboBox();
			this.ComboBox20 = new ComboBox();
			this.Label15 = new Label();
			this.CheckBox20 = new CheckBox();
			this.CheckedListBox20 = new CheckedListBox();
			this.Button29 = new Button();
			((ISupportInitialize)this.NumericUpDown1).BeginInit();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			((ISupportInitialize)this.PictureBox2).BeginInit();
			((ISupportInitialize)this.PictureBox3).BeginInit();
			((ISupportInitialize)this.PictureBox4).BeginInit();
			((ISupportInitialize)this.NumericUpDown2).BeginInit();
			((ISupportInitialize)this.PictureBox5).BeginInit();
			((ISupportInitialize)this.PictureBox6).BeginInit();
			((ISupportInitialize)this.NumericUpDown3).BeginInit();
			((ISupportInitialize)this.PictureBox7).BeginInit();
			((ISupportInitialize)this.PictureBox8).BeginInit();
			((ISupportInitialize)this.NumericUpDown4).BeginInit();
			((ISupportInitialize)this.PictureBox9).BeginInit();
			((ISupportInitialize)this.PictureBox10).BeginInit();
			((ISupportInitialize)this.NumericUpDown5).BeginInit();
			((ISupportInitialize)this.PictureBox11).BeginInit();
			((ISupportInitialize)this.NumericUpDown6).BeginInit();
			((ISupportInitialize)this.PictureBox12).BeginInit();
			((ISupportInitialize)this.NumericUpDown7).BeginInit();
			((ISupportInitialize)this.PictureBox13).BeginInit();
			((ISupportInitialize)this.NumericUpDown8).BeginInit();
			((ISupportInitialize)this.PictureBox14).BeginInit();
			((ISupportInitialize)this.NumericUpDown9).BeginInit();
			((ISupportInitialize)this.PictureBox15).BeginInit();
			((ISupportInitialize)this.NumericUpDown10).BeginInit();
			base.SuspendLayout();
			this.Button1.Location = new Point(100, 91);
			this.Button1.Name = "Button1";
			this.Button1.Size = new Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			this.CheckedListBox1.FormattingEnabled = true;
			this.CheckedListBox1.Location = new Point(321, 122);
			this.CheckedListBox1.Name = "CheckedListBox1";
			this.CheckedListBox1.Size = new Size(120, 94);
			this.CheckedListBox1.TabIndex = 1;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Location = new Point(455, 70);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new Size(81, 17);
			this.CheckBox1.TabIndex = 2;
			this.CheckBox1.Text = "CheckBox1";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Location = new Point(182, 130);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(39, 13);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Label1";
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new Point(242, 206);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new Size(121, 21);
			this.ComboBox1.TabIndex = 4;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new Point(145, 141);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new Size(121, 21);
			this.ComboBox2.TabIndex = 5;
			this.DateTimePicker1.Location = new Point(644, 149);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new Size(200, 20);
			this.DateTimePicker1.TabIndex = 6;
			this.MonthCalendar1.Location = new Point(163, 238);
			this.MonthCalendar1.Name = "MonthCalendar1";
			this.MonthCalendar1.TabIndex = 7;
			this.NumericUpDown1.Location = new Point(145, 149);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new Size(8, 20);
			this.NumericUpDown1.TabIndex = 8;
			this.PictureBox1.Location = new Point(220, 115);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new Size(100, 50);
			this.PictureBox1.TabIndex = 9;
			this.PictureBox1.TabStop = false;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Location = new Point(275, 122);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new Size(90, 17);
			this.RadioButton1.TabIndex = 10;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "RadioButton1";
			this.RadioButton1.UseVisualStyleBackColor = true;
			this.ProgressBar1.Location = new Point(557, 50);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new Size(72, 11);
			this.ProgressBar1.TabIndex = 11;
			this.RichTextBox1.Location = new Point(557, 194);
			this.RichTextBox1.Name = "RichTextBox1";
			this.RichTextBox1.Size = new Size(9, 13);
			this.RichTextBox1.TabIndex = 12;
			this.RichTextBox1.Text = "";
			this.RichTextBox2.Location = new Point(486, 91);
			this.RichTextBox2.Name = "RichTextBox2";
			this.RichTextBox2.Size = new Size(71, 100);
			this.RichTextBox2.TabIndex = 13;
			this.RichTextBox2.Text = "";
			this.TreeView1.Location = new Point(512, 238);
			this.TreeView1.Name = "TreeView1";
			this.TreeView1.Size = new Size(77, 41);
			this.TreeView1.TabIndex = 14;
			this.WebBrowser1.Location = new Point(601, 113);
			this.WebBrowser1.MinimumSize = new Size(20, 20);
			this.WebBrowser1.Name = "WebBrowser1";
			this.WebBrowser1.Size = new Size(54, 127);
			this.WebBrowser1.TabIndex = 15;
			this.PictureBox2.Location = new Point(34, 168);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new Size(43, 95);
			this.PictureBox2.TabIndex = 16;
			this.PictureBox2.TabStop = false;
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.Location = new Point(113, 215);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new Size(93, 4);
			this.ListBox1.TabIndex = 17;
			this.Label2.AutoSize = true;
			this.Label2.Location = new Point(34, 117);
			this.Label2.Name = "Label2";
			this.Label2.Size = new Size(39, 13);
			this.Label2.TabIndex = 18;
			this.Label2.Text = "Label2";
			this.ListView1.HideSelection = false;
			this.ListView1.Location = new Point(93, 168);
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new Size(70, 70);
			this.ListView1.TabIndex = 19;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker2.Location = new Point(143, 43);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new Size(77, 20);
			this.DateTimePicker2.TabIndex = 20;
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.Location = new Point(52, 48);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new Size(81, 17);
			this.CheckBox2.TabIndex = 21;
			this.CheckBox2.Text = "CheckBox2";
			this.CheckBox2.UseVisualStyleBackColor = true;
			this.Button2.Location = new Point(52, 269);
			this.Button2.Name = "Button2";
			this.Button2.Size = new Size(67, 84);
			this.Button2.TabIndex = 22;
			this.Button2.Text = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button3.Location = new Point(273, 74);
			this.Button3.Name = "Button3";
			this.Button3.Size = new Size(91, 12);
			this.Button3.TabIndex = 23;
			this.Button3.Text = "Button3";
			this.Button3.UseVisualStyleBackColor = true;
			this.CheckedListBox2.FormattingEnabled = true;
			this.CheckedListBox2.Location = new Point(248, 19);
			this.CheckedListBox2.Name = "CheckedListBox2";
			this.CheckedListBox2.Size = new Size(207, 34);
			this.CheckedListBox2.TabIndex = 24;
			this.DateTimePicker3.Location = new Point(423, 301);
			this.DateTimePicker3.Name = "DateTimePicker3";
			this.DateTimePicker3.Size = new Size(221, 20);
			this.DateTimePicker3.TabIndex = 25;
			this.DateTimePicker4.Location = new Point(384, 317);
			this.DateTimePicker4.Name = "DateTimePicker4";
			this.DateTimePicker4.Size = new Size(221, 20);
			this.DateTimePicker4.TabIndex = 51;
			this.CheckedListBox3.FormattingEnabled = true;
			this.CheckedListBox3.Location = new Point(209, 35);
			this.CheckedListBox3.Name = "CheckedListBox3";
			this.CheckedListBox3.Size = new Size(207, 34);
			this.CheckedListBox3.TabIndex = 50;
			this.Button4.Location = new Point(234, 90);
			this.Button4.Name = "Button4";
			this.Button4.Size = new Size(91, 12);
			this.Button4.TabIndex = 49;
			this.Button4.Text = "Button4";
			this.Button4.UseVisualStyleBackColor = true;
			this.Button5.Location = new Point(13, 285);
			this.Button5.Name = "Button5";
			this.Button5.Size = new Size(67, 84);
			this.Button5.TabIndex = 48;
			this.Button5.Text = "Button5";
			this.Button5.UseVisualStyleBackColor = true;
			this.CheckBox3.AutoSize = true;
			this.CheckBox3.Location = new Point(13, 64);
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.Size = new Size(81, 17);
			this.CheckBox3.TabIndex = 47;
			this.CheckBox3.Text = "CheckBox3";
			this.CheckBox3.UseVisualStyleBackColor = true;
			this.DateTimePicker5.Location = new Point(104, 59);
			this.DateTimePicker5.Name = "DateTimePicker5";
			this.DateTimePicker5.Size = new Size(77, 20);
			this.DateTimePicker5.TabIndex = 46;
			this.ListView2.HideSelection = false;
			this.ListView2.Location = new Point(54, 184);
			this.ListView2.Name = "ListView2";
			this.ListView2.Size = new Size(70, 70);
			this.ListView2.TabIndex = 45;
			this.ListView2.UseCompatibleStateImageBehavior = false;
			this.Label3.AutoSize = true;
			this.Label3.Location = new Point(-5, 133);
			this.Label3.Name = "Label3";
			this.Label3.Size = new Size(39, 13);
			this.Label3.TabIndex = 44;
			this.Label3.Text = "Label3";
			this.ListBox2.FormattingEnabled = true;
			this.ListBox2.Location = new Point(74, 231);
			this.ListBox2.Name = "ListBox2";
			this.ListBox2.Size = new Size(93, 4);
			this.ListBox2.TabIndex = 43;
			this.PictureBox3.Location = new Point(-5, 184);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new Size(43, 95);
			this.PictureBox3.TabIndex = 42;
			this.PictureBox3.TabStop = false;
			this.WebBrowser2.Location = new Point(562, 129);
			this.WebBrowser2.MinimumSize = new Size(20, 20);
			this.WebBrowser2.Name = "WebBrowser2";
			this.WebBrowser2.Size = new Size(54, 127);
			this.WebBrowser2.TabIndex = 41;
			this.TreeView2.Location = new Point(473, 254);
			this.TreeView2.Name = "TreeView2";
			this.TreeView2.Size = new Size(77, 41);
			this.TreeView2.TabIndex = 40;
			this.RichTextBox3.Location = new Point(447, 107);
			this.RichTextBox3.Name = "RichTextBox3";
			this.RichTextBox3.Size = new Size(71, 100);
			this.RichTextBox3.TabIndex = 39;
			this.RichTextBox3.Text = "";
			this.RichTextBox4.Location = new Point(518, 210);
			this.RichTextBox4.Name = "RichTextBox4";
			this.RichTextBox4.Size = new Size(9, 13);
			this.RichTextBox4.TabIndex = 38;
			this.RichTextBox4.Text = "";
			this.ProgressBar2.Location = new Point(518, 66);
			this.ProgressBar2.Name = "ProgressBar2";
			this.ProgressBar2.Size = new Size(72, 11);
			this.ProgressBar2.TabIndex = 37;
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new Point(236, 138);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new Size(90, 17);
			this.RadioButton2.TabIndex = 36;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "RadioButton2";
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.PictureBox4.Location = new Point(181, 131);
			this.PictureBox4.Name = "PictureBox4";
			this.PictureBox4.Size = new Size(100, 50);
			this.PictureBox4.TabIndex = 35;
			this.PictureBox4.TabStop = false;
			this.NumericUpDown2.Location = new Point(106, 165);
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new Size(8, 20);
			this.NumericUpDown2.TabIndex = 34;
			this.MonthCalendar2.Location = new Point(124, 254);
			this.MonthCalendar2.Name = "MonthCalendar2";
			this.MonthCalendar2.TabIndex = 33;
			this.DateTimePicker6.Location = new Point(605, 165);
			this.DateTimePicker6.Name = "DateTimePicker6";
			this.DateTimePicker6.Size = new Size(200, 20);
			this.DateTimePicker6.TabIndex = 32;
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new Point(106, 157);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new Size(121, 21);
			this.ComboBox3.TabIndex = 31;
			this.ComboBox4.FormattingEnabled = true;
			this.ComboBox4.Location = new Point(203, 222);
			this.ComboBox4.Name = "ComboBox4";
			this.ComboBox4.Size = new Size(121, 21);
			this.ComboBox4.TabIndex = 30;
			this.Label4.AutoSize = true;
			this.Label4.Location = new Point(143, 146);
			this.Label4.Name = "Label4";
			this.Label4.Size = new Size(39, 13);
			this.Label4.TabIndex = 29;
			this.Label4.Text = "Label4";
			this.CheckBox4.AutoSize = true;
			this.CheckBox4.Location = new Point(416, 86);
			this.CheckBox4.Name = "CheckBox4";
			this.CheckBox4.Size = new Size(81, 17);
			this.CheckBox4.TabIndex = 28;
			this.CheckBox4.Text = "CheckBox4";
			this.CheckBox4.UseVisualStyleBackColor = true;
			this.CheckedListBox4.FormattingEnabled = true;
			this.CheckedListBox4.Location = new Point(282, 138);
			this.CheckedListBox4.Name = "CheckedListBox4";
			this.CheckedListBox4.Size = new Size(120, 94);
			this.CheckedListBox4.TabIndex = 27;
			this.Button6.Location = new Point(61, 107);
			this.Button6.Name = "Button6";
			this.Button6.Size = new Size(75, 23);
			this.Button6.TabIndex = 26;
			this.Button6.Text = "Button6";
			this.Button6.UseVisualStyleBackColor = true;
			this.DateTimePicker7.Location = new Point(389, 282);
			this.DateTimePicker7.Name = "DateTimePicker7";
			this.DateTimePicker7.Size = new Size(221, 20);
			this.DateTimePicker7.TabIndex = 77;
			this.CheckedListBox5.FormattingEnabled = true;
			this.CheckedListBox5.Location = new Point(214, 0);
			this.CheckedListBox5.Name = "CheckedListBox5";
			this.CheckedListBox5.Size = new Size(207, 34);
			this.CheckedListBox5.TabIndex = 76;
			this.Button7.Location = new Point(239, 55);
			this.Button7.Name = "Button7";
			this.Button7.Size = new Size(91, 12);
			this.Button7.TabIndex = 75;
			this.Button7.Text = "Button7";
			this.Button7.UseVisualStyleBackColor = true;
			this.Button8.Location = new Point(18, 250);
			this.Button8.Name = "Button8";
			this.Button8.Size = new Size(67, 84);
			this.Button8.TabIndex = 74;
			this.Button8.Text = "Button8";
			this.Button8.UseVisualStyleBackColor = true;
			this.CheckBox5.AutoSize = true;
			this.CheckBox5.Location = new Point(18, 29);
			this.CheckBox5.Name = "CheckBox5";
			this.CheckBox5.Size = new Size(81, 17);
			this.CheckBox5.TabIndex = 73;
			this.CheckBox5.Text = "CheckBox5";
			this.CheckBox5.UseVisualStyleBackColor = true;
			this.DateTimePicker8.Location = new Point(109, 24);
			this.DateTimePicker8.Name = "DateTimePicker8";
			this.DateTimePicker8.Size = new Size(77, 20);
			this.DateTimePicker8.TabIndex = 72;
			this.ListView3.HideSelection = false;
			this.ListView3.Location = new Point(59, 149);
			this.ListView3.Name = "ListView3";
			this.ListView3.Size = new Size(70, 70);
			this.ListView3.TabIndex = 71;
			this.ListView3.UseCompatibleStateImageBehavior = false;
			this.Label5.AutoSize = true;
			this.Label5.Location = new Point(0, 98);
			this.Label5.Name = "Label5";
			this.Label5.Size = new Size(39, 13);
			this.Label5.TabIndex = 70;
			this.Label5.Text = "Label5";
			this.ListBox3.FormattingEnabled = true;
			this.ListBox3.Location = new Point(79, 196);
			this.ListBox3.Name = "ListBox3";
			this.ListBox3.Size = new Size(93, 4);
			this.ListBox3.TabIndex = 69;
			this.PictureBox5.Location = new Point(0, 149);
			this.PictureBox5.Name = "PictureBox5";
			this.PictureBox5.Size = new Size(43, 95);
			this.PictureBox5.TabIndex = 68;
			this.PictureBox5.TabStop = false;
			this.WebBrowser3.Location = new Point(567, 94);
			this.WebBrowser3.MinimumSize = new Size(20, 20);
			this.WebBrowser3.Name = "WebBrowser3";
			this.WebBrowser3.Size = new Size(54, 127);
			this.WebBrowser3.TabIndex = 67;
			this.TreeView3.Location = new Point(478, 219);
			this.TreeView3.Name = "TreeView3";
			this.TreeView3.Size = new Size(77, 41);
			this.TreeView3.TabIndex = 66;
			this.RichTextBox5.Location = new Point(452, 72);
			this.RichTextBox5.Name = "RichTextBox5";
			this.RichTextBox5.Size = new Size(71, 100);
			this.RichTextBox5.TabIndex = 65;
			this.RichTextBox5.Text = "";
			this.RichTextBox6.Location = new Point(523, 175);
			this.RichTextBox6.Name = "RichTextBox6";
			this.RichTextBox6.Size = new Size(9, 13);
			this.RichTextBox6.TabIndex = 64;
			this.RichTextBox6.Text = "";
			this.ProgressBar3.Location = new Point(523, 31);
			this.ProgressBar3.Name = "ProgressBar3";
			this.ProgressBar3.Size = new Size(72, 11);
			this.ProgressBar3.TabIndex = 63;
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Location = new Point(241, 103);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new Size(90, 17);
			this.RadioButton3.TabIndex = 62;
			this.RadioButton3.TabStop = true;
			this.RadioButton3.Text = "RadioButton3";
			this.RadioButton3.UseVisualStyleBackColor = true;
			this.PictureBox6.Location = new Point(186, 96);
			this.PictureBox6.Name = "PictureBox6";
			this.PictureBox6.Size = new Size(100, 50);
			this.PictureBox6.TabIndex = 61;
			this.PictureBox6.TabStop = false;
			this.NumericUpDown3.Location = new Point(111, 130);
			this.NumericUpDown3.Name = "NumericUpDown3";
			this.NumericUpDown3.Size = new Size(8, 20);
			this.NumericUpDown3.TabIndex = 60;
			this.MonthCalendar3.Location = new Point(129, 219);
			this.MonthCalendar3.Name = "MonthCalendar3";
			this.MonthCalendar3.TabIndex = 59;
			this.DateTimePicker9.Location = new Point(610, 130);
			this.DateTimePicker9.Name = "DateTimePicker9";
			this.DateTimePicker9.Size = new Size(200, 20);
			this.DateTimePicker9.TabIndex = 58;
			this.ComboBox5.FormattingEnabled = true;
			this.ComboBox5.Location = new Point(111, 122);
			this.ComboBox5.Name = "ComboBox5";
			this.ComboBox5.Size = new Size(121, 21);
			this.ComboBox5.TabIndex = 57;
			this.ComboBox6.FormattingEnabled = true;
			this.ComboBox6.Location = new Point(208, 187);
			this.ComboBox6.Name = "ComboBox6";
			this.ComboBox6.Size = new Size(121, 21);
			this.ComboBox6.TabIndex = 56;
			this.Label6.AutoSize = true;
			this.Label6.Location = new Point(148, 111);
			this.Label6.Name = "Label6";
			this.Label6.Size = new Size(39, 13);
			this.Label6.TabIndex = 55;
			this.Label6.Text = "Label6";
			this.CheckBox6.AutoSize = true;
			this.CheckBox6.Location = new Point(421, 51);
			this.CheckBox6.Name = "CheckBox6";
			this.CheckBox6.Size = new Size(81, 17);
			this.CheckBox6.TabIndex = 54;
			this.CheckBox6.Text = "CheckBox6";
			this.CheckBox6.UseVisualStyleBackColor = true;
			this.CheckedListBox6.FormattingEnabled = true;
			this.CheckedListBox6.Location = new Point(287, 103);
			this.CheckedListBox6.Name = "CheckedListBox6";
			this.CheckedListBox6.Size = new Size(120, 94);
			this.CheckedListBox6.TabIndex = 53;
			this.Button9.Location = new Point(66, 72);
			this.Button9.Name = "Button9";
			this.Button9.Size = new Size(75, 23);
			this.Button9.TabIndex = 52;
			this.Button9.Text = "Button9";
			this.Button9.UseVisualStyleBackColor = true;
			this.DateTimePicker10.Location = new Point(389, 282);
			this.DateTimePicker10.Name = "DateTimePicker10";
			this.DateTimePicker10.Size = new Size(221, 20);
			this.DateTimePicker10.TabIndex = 103;
			this.CheckedListBox7.FormattingEnabled = true;
			this.CheckedListBox7.Location = new Point(214, 0);
			this.CheckedListBox7.Name = "CheckedListBox7";
			this.CheckedListBox7.Size = new Size(207, 34);
			this.CheckedListBox7.TabIndex = 102;
			this.Button10.Location = new Point(239, 55);
			this.Button10.Name = "Button10";
			this.Button10.Size = new Size(91, 12);
			this.Button10.TabIndex = 101;
			this.Button10.Text = "Button10";
			this.Button10.UseVisualStyleBackColor = true;
			this.Button11.Location = new Point(18, 250);
			this.Button11.Name = "Button11";
			this.Button11.Size = new Size(67, 84);
			this.Button11.TabIndex = 100;
			this.Button11.Text = "Button11";
			this.Button11.UseVisualStyleBackColor = true;
			this.CheckBox7.AutoSize = true;
			this.CheckBox7.Location = new Point(18, 29);
			this.CheckBox7.Name = "CheckBox7";
			this.CheckBox7.Size = new Size(81, 17);
			this.CheckBox7.TabIndex = 99;
			this.CheckBox7.Text = "CheckBox7";
			this.CheckBox7.UseVisualStyleBackColor = true;
			this.DateTimePicker11.Location = new Point(109, 24);
			this.DateTimePicker11.Name = "DateTimePicker11";
			this.DateTimePicker11.Size = new Size(77, 20);
			this.DateTimePicker11.TabIndex = 98;
			this.ListView4.HideSelection = false;
			this.ListView4.Location = new Point(59, 149);
			this.ListView4.Name = "ListView4";
			this.ListView4.Size = new Size(70, 70);
			this.ListView4.TabIndex = 97;
			this.ListView4.UseCompatibleStateImageBehavior = false;
			this.Label7.AutoSize = true;
			this.Label7.Location = new Point(0, 98);
			this.Label7.Name = "Label7";
			this.Label7.Size = new Size(39, 13);
			this.Label7.TabIndex = 96;
			this.Label7.Text = "Label7";
			this.ListBox4.FormattingEnabled = true;
			this.ListBox4.Location = new Point(79, 196);
			this.ListBox4.Name = "ListBox4";
			this.ListBox4.Size = new Size(93, 4);
			this.ListBox4.TabIndex = 95;
			this.PictureBox7.Location = new Point(0, 149);
			this.PictureBox7.Name = "PictureBox7";
			this.PictureBox7.Size = new Size(43, 95);
			this.PictureBox7.TabIndex = 94;
			this.PictureBox7.TabStop = false;
			this.WebBrowser4.Location = new Point(567, 94);
			this.WebBrowser4.MinimumSize = new Size(20, 20);
			this.WebBrowser4.Name = "WebBrowser4";
			this.WebBrowser4.Size = new Size(54, 127);
			this.WebBrowser4.TabIndex = 93;
			this.TreeView4.Location = new Point(478, 219);
			this.TreeView4.Name = "TreeView4";
			this.TreeView4.Size = new Size(77, 41);
			this.TreeView4.TabIndex = 92;
			this.RichTextBox7.Location = new Point(452, 72);
			this.RichTextBox7.Name = "RichTextBox7";
			this.RichTextBox7.Size = new Size(71, 100);
			this.RichTextBox7.TabIndex = 91;
			this.RichTextBox7.Text = "";
			this.RichTextBox8.Location = new Point(523, 175);
			this.RichTextBox8.Name = "RichTextBox8";
			this.RichTextBox8.Size = new Size(9, 13);
			this.RichTextBox8.TabIndex = 90;
			this.RichTextBox8.Text = "";
			this.ProgressBar4.Location = new Point(523, 31);
			this.ProgressBar4.Name = "ProgressBar4";
			this.ProgressBar4.Size = new Size(72, 11);
			this.ProgressBar4.TabIndex = 89;
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Location = new Point(241, 103);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new Size(90, 17);
			this.RadioButton4.TabIndex = 88;
			this.RadioButton4.TabStop = true;
			this.RadioButton4.Text = "RadioButton4";
			this.RadioButton4.UseVisualStyleBackColor = true;
			this.PictureBox8.Location = new Point(186, 96);
			this.PictureBox8.Name = "PictureBox8";
			this.PictureBox8.Size = new Size(100, 50);
			this.PictureBox8.TabIndex = 87;
			this.PictureBox8.TabStop = false;
			this.NumericUpDown4.Location = new Point(111, 130);
			this.NumericUpDown4.Name = "NumericUpDown4";
			this.NumericUpDown4.Size = new Size(8, 20);
			this.NumericUpDown4.TabIndex = 86;
			this.MonthCalendar4.Location = new Point(129, 219);
			this.MonthCalendar4.Name = "MonthCalendar4";
			this.MonthCalendar4.TabIndex = 85;
			this.DateTimePicker12.Location = new Point(610, 130);
			this.DateTimePicker12.Name = "DateTimePicker12";
			this.DateTimePicker12.Size = new Size(200, 20);
			this.DateTimePicker12.TabIndex = 84;
			this.ComboBox7.FormattingEnabled = true;
			this.ComboBox7.Location = new Point(111, 122);
			this.ComboBox7.Name = "ComboBox7";
			this.ComboBox7.Size = new Size(121, 21);
			this.ComboBox7.TabIndex = 83;
			this.ComboBox8.FormattingEnabled = true;
			this.ComboBox8.Location = new Point(208, 187);
			this.ComboBox8.Name = "ComboBox8";
			this.ComboBox8.Size = new Size(121, 21);
			this.ComboBox8.TabIndex = 82;
			this.Label8.AutoSize = true;
			this.Label8.Location = new Point(148, 111);
			this.Label8.Name = "Label8";
			this.Label8.Size = new Size(39, 13);
			this.Label8.TabIndex = 81;
			this.Label8.Text = "Label8";
			this.CheckBox8.AutoSize = true;
			this.CheckBox8.Location = new Point(421, 51);
			this.CheckBox8.Name = "CheckBox8";
			this.CheckBox8.Size = new Size(81, 17);
			this.CheckBox8.TabIndex = 80;
			this.CheckBox8.Text = "CheckBox8";
			this.CheckBox8.UseVisualStyleBackColor = true;
			this.CheckedListBox8.FormattingEnabled = true;
			this.CheckedListBox8.Location = new Point(287, 103);
			this.CheckedListBox8.Name = "CheckedListBox8";
			this.CheckedListBox8.Size = new Size(120, 94);
			this.CheckedListBox8.TabIndex = 79;
			this.Button12.Location = new Point(66, 72);
			this.Button12.Name = "Button12";
			this.Button12.Size = new Size(75, 23);
			this.Button12.TabIndex = 78;
			this.Button12.Text = "Button12";
			this.Button12.UseVisualStyleBackColor = true;
			this.DateTimePicker13.Location = new Point(389, 282);
			this.DateTimePicker13.Name = "DateTimePicker13";
			this.DateTimePicker13.Size = new Size(221, 20);
			this.DateTimePicker13.TabIndex = 129;
			this.CheckedListBox9.FormattingEnabled = true;
			this.CheckedListBox9.Location = new Point(214, 0);
			this.CheckedListBox9.Name = "CheckedListBox9";
			this.CheckedListBox9.Size = new Size(207, 34);
			this.CheckedListBox9.TabIndex = 128;
			this.Button13.Location = new Point(239, 55);
			this.Button13.Name = "Button13";
			this.Button13.Size = new Size(91, 12);
			this.Button13.TabIndex = 127;
			this.Button13.Text = "Button13";
			this.Button13.UseVisualStyleBackColor = true;
			this.Button14.Location = new Point(18, 250);
			this.Button14.Name = "Button14";
			this.Button14.Size = new Size(67, 84);
			this.Button14.TabIndex = 126;
			this.Button14.Text = "Button14";
			this.Button14.UseVisualStyleBackColor = true;
			this.CheckBox9.AutoSize = true;
			this.CheckBox9.Location = new Point(18, 29);
			this.CheckBox9.Name = "CheckBox9";
			this.CheckBox9.Size = new Size(81, 17);
			this.CheckBox9.TabIndex = 125;
			this.CheckBox9.Text = "CheckBox9";
			this.CheckBox9.UseVisualStyleBackColor = true;
			this.DateTimePicker14.Location = new Point(109, 24);
			this.DateTimePicker14.Name = "DateTimePicker14";
			this.DateTimePicker14.Size = new Size(77, 20);
			this.DateTimePicker14.TabIndex = 124;
			this.ListView5.HideSelection = false;
			this.ListView5.Location = new Point(59, 149);
			this.ListView5.Name = "ListView5";
			this.ListView5.Size = new Size(70, 70);
			this.ListView5.TabIndex = 123;
			this.ListView5.UseCompatibleStateImageBehavior = false;
			this.Label9.AutoSize = true;
			this.Label9.Location = new Point(0, 98);
			this.Label9.Name = "Label9";
			this.Label9.Size = new Size(39, 13);
			this.Label9.TabIndex = 122;
			this.Label9.Text = "Label9";
			this.ListBox5.FormattingEnabled = true;
			this.ListBox5.Location = new Point(79, 196);
			this.ListBox5.Name = "ListBox5";
			this.ListBox5.Size = new Size(93, 4);
			this.ListBox5.TabIndex = 121;
			this.PictureBox9.Location = new Point(0, 149);
			this.PictureBox9.Name = "PictureBox9";
			this.PictureBox9.Size = new Size(43, 95);
			this.PictureBox9.TabIndex = 120;
			this.PictureBox9.TabStop = false;
			this.WebBrowser5.Location = new Point(567, 94);
			this.WebBrowser5.MinimumSize = new Size(20, 20);
			this.WebBrowser5.Name = "WebBrowser5";
			this.WebBrowser5.Size = new Size(54, 127);
			this.WebBrowser5.TabIndex = 119;
			this.TreeView5.Location = new Point(478, 219);
			this.TreeView5.Name = "TreeView5";
			this.TreeView5.Size = new Size(77, 41);
			this.TreeView5.TabIndex = 118;
			this.RichTextBox9.Location = new Point(452, 72);
			this.RichTextBox9.Name = "RichTextBox9";
			this.RichTextBox9.Size = new Size(71, 100);
			this.RichTextBox9.TabIndex = 117;
			this.RichTextBox9.Text = "";
			this.RichTextBox10.Location = new Point(523, 175);
			this.RichTextBox10.Name = "RichTextBox10";
			this.RichTextBox10.Size = new Size(9, 13);
			this.RichTextBox10.TabIndex = 116;
			this.RichTextBox10.Text = "";
			this.ProgressBar5.Location = new Point(523, 31);
			this.ProgressBar5.Name = "ProgressBar5";
			this.ProgressBar5.Size = new Size(72, 11);
			this.ProgressBar5.TabIndex = 115;
			this.RadioButton5.AutoSize = true;
			this.RadioButton5.Location = new Point(241, 103);
			this.RadioButton5.Name = "RadioButton5";
			this.RadioButton5.Size = new Size(90, 17);
			this.RadioButton5.TabIndex = 114;
			this.RadioButton5.TabStop = true;
			this.RadioButton5.Text = "RadioButton5";
			this.RadioButton5.UseVisualStyleBackColor = true;
			this.PictureBox10.Location = new Point(186, 96);
			this.PictureBox10.Name = "PictureBox10";
			this.PictureBox10.Size = new Size(100, 50);
			this.PictureBox10.TabIndex = 113;
			this.PictureBox10.TabStop = false;
			this.NumericUpDown5.Location = new Point(111, 130);
			this.NumericUpDown5.Name = "NumericUpDown5";
			this.NumericUpDown5.Size = new Size(8, 20);
			this.NumericUpDown5.TabIndex = 112;
			this.MonthCalendar5.Location = new Point(129, 219);
			this.MonthCalendar5.Name = "MonthCalendar5";
			this.MonthCalendar5.TabIndex = 111;
			this.DateTimePicker15.Location = new Point(610, 130);
			this.DateTimePicker15.Name = "DateTimePicker15";
			this.DateTimePicker15.Size = new Size(200, 20);
			this.DateTimePicker15.TabIndex = 110;
			this.ComboBox9.FormattingEnabled = true;
			this.ComboBox9.Location = new Point(111, 122);
			this.ComboBox9.Name = "ComboBox9";
			this.ComboBox9.Size = new Size(121, 21);
			this.ComboBox9.TabIndex = 109;
			this.ComboBox10.FormattingEnabled = true;
			this.ComboBox10.Location = new Point(208, 187);
			this.ComboBox10.Name = "ComboBox10";
			this.ComboBox10.Size = new Size(121, 21);
			this.ComboBox10.TabIndex = 108;
			this.Label10.AutoSize = true;
			this.Label10.Location = new Point(148, 111);
			this.Label10.Name = "Label10";
			this.Label10.Size = new Size(45, 13);
			this.Label10.TabIndex = 107;
			this.Label10.Text = "Label10";
			this.CheckBox10.AutoSize = true;
			this.CheckBox10.Location = new Point(421, 51);
			this.CheckBox10.Name = "CheckBox10";
			this.CheckBox10.Size = new Size(87, 17);
			this.CheckBox10.TabIndex = 106;
			this.CheckBox10.Text = "CheckBox10";
			this.CheckBox10.UseVisualStyleBackColor = true;
			this.CheckedListBox10.FormattingEnabled = true;
			this.CheckedListBox10.Location = new Point(287, 103);
			this.CheckedListBox10.Name = "CheckedListBox10";
			this.CheckedListBox10.Size = new Size(120, 94);
			this.CheckedListBox10.TabIndex = 105;
			this.Button15.Location = new Point(66, 72);
			this.Button15.Name = "Button15";
			this.Button15.Size = new Size(75, 23);
			this.Button15.TabIndex = 104;
			this.Button15.Text = "Button15";
			this.Button15.UseVisualStyleBackColor = true;
			this.DateTimePicker16.Location = new Point(428, 299);
			this.DateTimePicker16.Name = "DateTimePicker16";
			this.DateTimePicker16.Size = new Size(221, 20);
			this.DateTimePicker16.TabIndex = 248;
			this.CheckedListBox11.FormattingEnabled = true;
			this.CheckedListBox11.Location = new Point(253, 17);
			this.CheckedListBox11.Name = "CheckedListBox11";
			this.CheckedListBox11.Size = new Size(207, 34);
			this.CheckedListBox11.TabIndex = 247;
			this.Button16.Location = new Point(278, 72);
			this.Button16.Name = "Button16";
			this.Button16.Size = new Size(91, 12);
			this.Button16.TabIndex = 246;
			this.Button16.Text = "Button16";
			this.Button16.UseVisualStyleBackColor = true;
			this.Button17.Location = new Point(57, 267);
			this.Button17.Name = "Button17";
			this.Button17.Size = new Size(67, 84);
			this.Button17.TabIndex = 245;
			this.Button17.Text = "Button17";
			this.Button17.UseVisualStyleBackColor = true;
			this.CheckBox11.AutoSize = true;
			this.CheckBox11.Location = new Point(57, 46);
			this.CheckBox11.Name = "CheckBox11";
			this.CheckBox11.Size = new Size(87, 17);
			this.CheckBox11.TabIndex = 244;
			this.CheckBox11.Text = "CheckBox11";
			this.CheckBox11.UseVisualStyleBackColor = true;
			this.DateTimePicker17.Location = new Point(148, 41);
			this.DateTimePicker17.Name = "DateTimePicker17";
			this.DateTimePicker17.Size = new Size(77, 20);
			this.DateTimePicker17.TabIndex = 243;
			this.ListView6.HideSelection = false;
			this.ListView6.Location = new Point(98, 166);
			this.ListView6.Name = "ListView6";
			this.ListView6.Size = new Size(70, 70);
			this.ListView6.TabIndex = 242;
			this.ListView6.UseCompatibleStateImageBehavior = false;
			this.ListBox6.FormattingEnabled = true;
			this.ListBox6.Location = new Point(118, 213);
			this.ListBox6.Name = "ListBox6";
			this.ListBox6.Size = new Size(93, 4);
			this.ListBox6.TabIndex = 241;
			this.WebBrowser6.Location = new Point(606, 111);
			this.WebBrowser6.MinimumSize = new Size(20, 20);
			this.WebBrowser6.Name = "WebBrowser6";
			this.WebBrowser6.Size = new Size(54, 127);
			this.WebBrowser6.TabIndex = 240;
			this.TreeView6.Location = new Point(517, 236);
			this.TreeView6.Name = "TreeView6";
			this.TreeView6.Size = new Size(77, 41);
			this.TreeView6.TabIndex = 239;
			this.RichTextBox11.Location = new Point(491, 89);
			this.RichTextBox11.Name = "RichTextBox11";
			this.RichTextBox11.Size = new Size(71, 100);
			this.RichTextBox11.TabIndex = 238;
			this.RichTextBox11.Text = "";
			this.RichTextBox12.Location = new Point(562, 192);
			this.RichTextBox12.Name = "RichTextBox12";
			this.RichTextBox12.Size = new Size(9, 13);
			this.RichTextBox12.TabIndex = 237;
			this.RichTextBox12.Text = "";
			this.ProgressBar6.Location = new Point(562, 48);
			this.ProgressBar6.Name = "ProgressBar6";
			this.ProgressBar6.Size = new Size(72, 11);
			this.ProgressBar6.TabIndex = 236;
			this.RadioButton6.AutoSize = true;
			this.RadioButton6.Location = new Point(280, 120);
			this.RadioButton6.Name = "RadioButton6";
			this.RadioButton6.Size = new Size(90, 17);
			this.RadioButton6.TabIndex = 235;
			this.RadioButton6.TabStop = true;
			this.RadioButton6.Text = "RadioButton6";
			this.RadioButton6.UseVisualStyleBackColor = true;
			this.PictureBox11.Location = new Point(225, 113);
			this.PictureBox11.Name = "PictureBox11";
			this.PictureBox11.Size = new Size(100, 50);
			this.PictureBox11.TabIndex = 234;
			this.PictureBox11.TabStop = false;
			this.NumericUpDown6.Location = new Point(150, 147);
			this.NumericUpDown6.Name = "NumericUpDown6";
			this.NumericUpDown6.Size = new Size(8, 20);
			this.NumericUpDown6.TabIndex = 233;
			this.MonthCalendar6.Location = new Point(168, 236);
			this.MonthCalendar6.Name = "MonthCalendar6";
			this.MonthCalendar6.TabIndex = 232;
			this.DateTimePicker18.Location = new Point(649, 147);
			this.DateTimePicker18.Name = "DateTimePicker18";
			this.DateTimePicker18.Size = new Size(200, 20);
			this.DateTimePicker18.TabIndex = 231;
			this.ComboBox11.FormattingEnabled = true;
			this.ComboBox11.Location = new Point(150, 139);
			this.ComboBox11.Name = "ComboBox11";
			this.ComboBox11.Size = new Size(121, 21);
			this.ComboBox11.TabIndex = 230;
			this.ComboBox12.FormattingEnabled = true;
			this.ComboBox12.Location = new Point(247, 204);
			this.ComboBox12.Name = "ComboBox12";
			this.ComboBox12.Size = new Size(121, 21);
			this.ComboBox12.TabIndex = 229;
			this.Label11.AutoSize = true;
			this.Label11.Location = new Point(187, 128);
			this.Label11.Name = "Label11";
			this.Label11.Size = new Size(45, 13);
			this.Label11.TabIndex = 228;
			this.Label11.Text = "Label11";
			this.CheckBox12.AutoSize = true;
			this.CheckBox12.Location = new Point(460, 68);
			this.CheckBox12.Name = "CheckBox12";
			this.CheckBox12.Size = new Size(87, 17);
			this.CheckBox12.TabIndex = 227;
			this.CheckBox12.Text = "CheckBox12";
			this.CheckBox12.UseVisualStyleBackColor = true;
			this.CheckedListBox12.FormattingEnabled = true;
			this.CheckedListBox12.Location = new Point(326, 120);
			this.CheckedListBox12.Name = "CheckedListBox12";
			this.CheckedListBox12.Size = new Size(120, 94);
			this.CheckedListBox12.TabIndex = 226;
			this.Button18.Location = new Point(105, 89);
			this.Button18.Name = "Button18";
			this.Button18.Size = new Size(75, 23);
			this.Button18.TabIndex = 225;
			this.Button18.Text = "Button18";
			this.Button18.UseVisualStyleBackColor = true;
			this.DateTimePicker19.Location = new Point(428, 299);
			this.DateTimePicker19.Name = "DateTimePicker19";
			this.DateTimePicker19.Size = new Size(221, 20);
			this.DateTimePicker19.TabIndex = 224;
			this.CheckedListBox13.FormattingEnabled = true;
			this.CheckedListBox13.Location = new Point(253, 17);
			this.CheckedListBox13.Name = "CheckedListBox13";
			this.CheckedListBox13.Size = new Size(207, 34);
			this.CheckedListBox13.TabIndex = 223;
			this.Button19.Location = new Point(278, 72);
			this.Button19.Name = "Button19";
			this.Button19.Size = new Size(91, 12);
			this.Button19.TabIndex = 222;
			this.Button19.Text = "Button19";
			this.Button19.UseVisualStyleBackColor = true;
			this.Button20.Location = new Point(57, 267);
			this.Button20.Name = "Button20";
			this.Button20.Size = new Size(67, 84);
			this.Button20.TabIndex = 221;
			this.Button20.Text = "Button20";
			this.Button20.UseVisualStyleBackColor = true;
			this.CheckBox13.AutoSize = true;
			this.CheckBox13.Location = new Point(57, 46);
			this.CheckBox13.Name = "CheckBox13";
			this.CheckBox13.Size = new Size(87, 17);
			this.CheckBox13.TabIndex = 220;
			this.CheckBox13.Text = "CheckBox13";
			this.CheckBox13.UseVisualStyleBackColor = true;
			this.DateTimePicker20.Location = new Point(148, 41);
			this.DateTimePicker20.Name = "DateTimePicker20";
			this.DateTimePicker20.Size = new Size(77, 20);
			this.DateTimePicker20.TabIndex = 219;
			this.ListView7.HideSelection = false;
			this.ListView7.Location = new Point(98, 166);
			this.ListView7.Name = "ListView7";
			this.ListView7.Size = new Size(70, 70);
			this.ListView7.TabIndex = 218;
			this.ListView7.UseCompatibleStateImageBehavior = false;
			this.ListBox7.FormattingEnabled = true;
			this.ListBox7.Location = new Point(118, 213);
			this.ListBox7.Name = "ListBox7";
			this.ListBox7.Size = new Size(93, 4);
			this.ListBox7.TabIndex = 217;
			this.WebBrowser7.Location = new Point(606, 111);
			this.WebBrowser7.MinimumSize = new Size(20, 20);
			this.WebBrowser7.Name = "WebBrowser7";
			this.WebBrowser7.Size = new Size(54, 127);
			this.WebBrowser7.TabIndex = 216;
			this.TreeView7.Location = new Point(517, 236);
			this.TreeView7.Name = "TreeView7";
			this.TreeView7.Size = new Size(77, 41);
			this.TreeView7.TabIndex = 215;
			this.RichTextBox13.Location = new Point(491, 89);
			this.RichTextBox13.Name = "RichTextBox13";
			this.RichTextBox13.Size = new Size(71, 100);
			this.RichTextBox13.TabIndex = 214;
			this.RichTextBox13.Text = "";
			this.RichTextBox14.Location = new Point(562, 192);
			this.RichTextBox14.Name = "RichTextBox14";
			this.RichTextBox14.Size = new Size(9, 13);
			this.RichTextBox14.TabIndex = 213;
			this.RichTextBox14.Text = "";
			this.ProgressBar7.Location = new Point(562, 48);
			this.ProgressBar7.Name = "ProgressBar7";
			this.ProgressBar7.Size = new Size(72, 11);
			this.ProgressBar7.TabIndex = 212;
			this.RadioButton7.AutoSize = true;
			this.RadioButton7.Location = new Point(280, 120);
			this.RadioButton7.Name = "RadioButton7";
			this.RadioButton7.Size = new Size(90, 17);
			this.RadioButton7.TabIndex = 211;
			this.RadioButton7.TabStop = true;
			this.RadioButton7.Text = "RadioButton7";
			this.RadioButton7.UseVisualStyleBackColor = true;
			this.PictureBox12.Location = new Point(225, 113);
			this.PictureBox12.Name = "PictureBox12";
			this.PictureBox12.Size = new Size(100, 50);
			this.PictureBox12.TabIndex = 210;
			this.PictureBox12.TabStop = false;
			this.NumericUpDown7.Location = new Point(150, 147);
			this.NumericUpDown7.Name = "NumericUpDown7";
			this.NumericUpDown7.Size = new Size(8, 20);
			this.NumericUpDown7.TabIndex = 209;
			this.MonthCalendar7.Location = new Point(168, 236);
			this.MonthCalendar7.Name = "MonthCalendar7";
			this.MonthCalendar7.TabIndex = 208;
			this.DateTimePicker21.Location = new Point(649, 147);
			this.DateTimePicker21.Name = "DateTimePicker21";
			this.DateTimePicker21.Size = new Size(200, 20);
			this.DateTimePicker21.TabIndex = 207;
			this.ComboBox13.FormattingEnabled = true;
			this.ComboBox13.Location = new Point(150, 139);
			this.ComboBox13.Name = "ComboBox13";
			this.ComboBox13.Size = new Size(121, 21);
			this.ComboBox13.TabIndex = 206;
			this.ComboBox14.FormattingEnabled = true;
			this.ComboBox14.Location = new Point(247, 204);
			this.ComboBox14.Name = "ComboBox14";
			this.ComboBox14.Size = new Size(121, 21);
			this.ComboBox14.TabIndex = 205;
			this.Label12.AutoSize = true;
			this.Label12.Location = new Point(187, 128);
			this.Label12.Name = "Label12";
			this.Label12.Size = new Size(45, 13);
			this.Label12.TabIndex = 204;
			this.Label12.Text = "Label12";
			this.CheckBox14.AutoSize = true;
			this.CheckBox14.Location = new Point(460, 68);
			this.CheckBox14.Name = "CheckBox14";
			this.CheckBox14.Size = new Size(87, 17);
			this.CheckBox14.TabIndex = 203;
			this.CheckBox14.Text = "CheckBox14";
			this.CheckBox14.UseVisualStyleBackColor = true;
			this.CheckedListBox14.FormattingEnabled = true;
			this.CheckedListBox14.Location = new Point(326, 120);
			this.CheckedListBox14.Name = "CheckedListBox14";
			this.CheckedListBox14.Size = new Size(120, 94);
			this.CheckedListBox14.TabIndex = 202;
			this.Button21.Location = new Point(105, 89);
			this.Button21.Name = "Button21";
			this.Button21.Size = new Size(75, 23);
			this.Button21.TabIndex = 201;
			this.Button21.Text = "Button21";
			this.Button21.UseVisualStyleBackColor = true;
			this.DateTimePicker22.Location = new Point(428, 299);
			this.DateTimePicker22.Name = "DateTimePicker22";
			this.DateTimePicker22.Size = new Size(221, 20);
			this.DateTimePicker22.TabIndex = 200;
			this.CheckedListBox15.FormattingEnabled = true;
			this.CheckedListBox15.Location = new Point(253, 17);
			this.CheckedListBox15.Name = "CheckedListBox15";
			this.CheckedListBox15.Size = new Size(207, 34);
			this.CheckedListBox15.TabIndex = 199;
			this.Button22.Location = new Point(278, 72);
			this.Button22.Name = "Button22";
			this.Button22.Size = new Size(91, 12);
			this.Button22.TabIndex = 198;
			this.Button22.Text = "Button22";
			this.Button22.UseVisualStyleBackColor = true;
			this.Button23.Location = new Point(57, 267);
			this.Button23.Name = "Button23";
			this.Button23.Size = new Size(67, 84);
			this.Button23.TabIndex = 197;
			this.Button23.Text = "Button23";
			this.Button23.UseVisualStyleBackColor = true;
			this.CheckBox15.AutoSize = true;
			this.CheckBox15.Location = new Point(57, 46);
			this.CheckBox15.Name = "CheckBox15";
			this.CheckBox15.Size = new Size(87, 17);
			this.CheckBox15.TabIndex = 196;
			this.CheckBox15.Text = "CheckBox15";
			this.CheckBox15.UseVisualStyleBackColor = true;
			this.DateTimePicker23.Location = new Point(148, 41);
			this.DateTimePicker23.Name = "DateTimePicker23";
			this.DateTimePicker23.Size = new Size(77, 20);
			this.DateTimePicker23.TabIndex = 195;
			this.ListView8.HideSelection = false;
			this.ListView8.Location = new Point(98, 166);
			this.ListView8.Name = "ListView8";
			this.ListView8.Size = new Size(70, 70);
			this.ListView8.TabIndex = 194;
			this.ListView8.UseCompatibleStateImageBehavior = false;
			this.ListBox8.FormattingEnabled = true;
			this.ListBox8.Location = new Point(118, 213);
			this.ListBox8.Name = "ListBox8";
			this.ListBox8.Size = new Size(93, 4);
			this.ListBox8.TabIndex = 193;
			this.WebBrowser8.Location = new Point(606, 111);
			this.WebBrowser8.MinimumSize = new Size(20, 20);
			this.WebBrowser8.Name = "WebBrowser8";
			this.WebBrowser8.Size = new Size(54, 127);
			this.WebBrowser8.TabIndex = 192;
			this.TreeView8.Location = new Point(517, 236);
			this.TreeView8.Name = "TreeView8";
			this.TreeView8.Size = new Size(77, 41);
			this.TreeView8.TabIndex = 191;
			this.RichTextBox15.Location = new Point(491, 89);
			this.RichTextBox15.Name = "RichTextBox15";
			this.RichTextBox15.Size = new Size(71, 100);
			this.RichTextBox15.TabIndex = 190;
			this.RichTextBox15.Text = "";
			this.RichTextBox16.Location = new Point(562, 192);
			this.RichTextBox16.Name = "RichTextBox16";
			this.RichTextBox16.Size = new Size(9, 13);
			this.RichTextBox16.TabIndex = 189;
			this.RichTextBox16.Text = "";
			this.ProgressBar8.Location = new Point(562, 48);
			this.ProgressBar8.Name = "ProgressBar8";
			this.ProgressBar8.Size = new Size(72, 11);
			this.ProgressBar8.TabIndex = 188;
			this.RadioButton8.AutoSize = true;
			this.RadioButton8.Location = new Point(280, 120);
			this.RadioButton8.Name = "RadioButton8";
			this.RadioButton8.Size = new Size(90, 17);
			this.RadioButton8.TabIndex = 187;
			this.RadioButton8.TabStop = true;
			this.RadioButton8.Text = "RadioButton8";
			this.RadioButton8.UseVisualStyleBackColor = true;
			this.PictureBox13.Location = new Point(225, 113);
			this.PictureBox13.Name = "PictureBox13";
			this.PictureBox13.Size = new Size(100, 50);
			this.PictureBox13.TabIndex = 186;
			this.PictureBox13.TabStop = false;
			this.NumericUpDown8.Location = new Point(150, 147);
			this.NumericUpDown8.Name = "NumericUpDown8";
			this.NumericUpDown8.Size = new Size(8, 20);
			this.NumericUpDown8.TabIndex = 185;
			this.MonthCalendar8.Location = new Point(168, 236);
			this.MonthCalendar8.Name = "MonthCalendar8";
			this.MonthCalendar8.TabIndex = 184;
			this.DateTimePicker24.Location = new Point(649, 147);
			this.DateTimePicker24.Name = "DateTimePicker24";
			this.DateTimePicker24.Size = new Size(200, 20);
			this.DateTimePicker24.TabIndex = 183;
			this.ComboBox15.FormattingEnabled = true;
			this.ComboBox15.Location = new Point(150, 139);
			this.ComboBox15.Name = "ComboBox15";
			this.ComboBox15.Size = new Size(121, 21);
			this.ComboBox15.TabIndex = 182;
			this.ComboBox16.FormattingEnabled = true;
			this.ComboBox16.Location = new Point(247, 204);
			this.ComboBox16.Name = "ComboBox16";
			this.ComboBox16.Size = new Size(121, 21);
			this.ComboBox16.TabIndex = 181;
			this.Label13.AutoSize = true;
			this.Label13.Location = new Point(187, 128);
			this.Label13.Name = "Label13";
			this.Label13.Size = new Size(45, 13);
			this.Label13.TabIndex = 180;
			this.Label13.Text = "Label13";
			this.CheckBox16.AutoSize = true;
			this.CheckBox16.Location = new Point(460, 68);
			this.CheckBox16.Name = "CheckBox16";
			this.CheckBox16.Size = new Size(87, 17);
			this.CheckBox16.TabIndex = 179;
			this.CheckBox16.Text = "CheckBox16";
			this.CheckBox16.UseVisualStyleBackColor = true;
			this.CheckedListBox16.FormattingEnabled = true;
			this.CheckedListBox16.Location = new Point(326, 120);
			this.CheckedListBox16.Name = "CheckedListBox16";
			this.CheckedListBox16.Size = new Size(120, 94);
			this.CheckedListBox16.TabIndex = 178;
			this.Button24.Location = new Point(105, 89);
			this.Button24.Name = "Button24";
			this.Button24.Size = new Size(75, 23);
			this.Button24.TabIndex = 177;
			this.Button24.Text = "Button24";
			this.Button24.UseVisualStyleBackColor = true;
			this.DateTimePicker25.Location = new Point(423, 334);
			this.DateTimePicker25.Name = "DateTimePicker25";
			this.DateTimePicker25.Size = new Size(221, 20);
			this.DateTimePicker25.TabIndex = 176;
			this.CheckedListBox17.FormattingEnabled = true;
			this.CheckedListBox17.Location = new Point(248, 52);
			this.CheckedListBox17.Name = "CheckedListBox17";
			this.CheckedListBox17.Size = new Size(207, 34);
			this.CheckedListBox17.TabIndex = 175;
			this.Button25.Location = new Point(273, 107);
			this.Button25.Name = "Button25";
			this.Button25.Size = new Size(91, 12);
			this.Button25.TabIndex = 174;
			this.Button25.Text = "Button25";
			this.Button25.UseVisualStyleBackColor = true;
			this.CheckBox17.AutoSize = true;
			this.CheckBox17.Location = new Point(52, 81);
			this.CheckBox17.Name = "CheckBox17";
			this.CheckBox17.Size = new Size(87, 17);
			this.CheckBox17.TabIndex = 173;
			this.CheckBox17.Text = "CheckBox17";
			this.CheckBox17.UseVisualStyleBackColor = true;
			this.DateTimePicker26.Location = new Point(143, 76);
			this.DateTimePicker26.Name = "DateTimePicker26";
			this.DateTimePicker26.Size = new Size(77, 20);
			this.DateTimePicker26.TabIndex = 172;
			this.ListView9.HideSelection = false;
			this.ListView9.Location = new Point(93, 201);
			this.ListView9.Name = "ListView9";
			this.ListView9.Size = new Size(70, 70);
			this.ListView9.TabIndex = 171;
			this.ListView9.UseCompatibleStateImageBehavior = false;
			this.ListBox9.FormattingEnabled = true;
			this.ListBox9.Location = new Point(113, 248);
			this.ListBox9.Name = "ListBox9";
			this.ListBox9.Size = new Size(93, 4);
			this.ListBox9.TabIndex = 170;
			this.WebBrowser9.Location = new Point(601, 146);
			this.WebBrowser9.MinimumSize = new Size(20, 20);
			this.WebBrowser9.Name = "WebBrowser9";
			this.WebBrowser9.Size = new Size(54, 127);
			this.WebBrowser9.TabIndex = 169;
			this.TreeView9.Location = new Point(512, 271);
			this.TreeView9.Name = "TreeView9";
			this.TreeView9.Size = new Size(77, 41);
			this.TreeView9.TabIndex = 168;
			this.RichTextBox17.Location = new Point(486, 124);
			this.RichTextBox17.Name = "RichTextBox17";
			this.RichTextBox17.Size = new Size(71, 100);
			this.RichTextBox17.TabIndex = 167;
			this.RichTextBox17.Text = "";
			this.RichTextBox18.Location = new Point(557, 227);
			this.RichTextBox18.Name = "RichTextBox18";
			this.RichTextBox18.Size = new Size(9, 13);
			this.RichTextBox18.TabIndex = 166;
			this.RichTextBox18.Text = "";
			this.ProgressBar9.Location = new Point(557, 83);
			this.ProgressBar9.Name = "ProgressBar9";
			this.ProgressBar9.Size = new Size(72, 11);
			this.ProgressBar9.TabIndex = 165;
			this.RadioButton9.AutoSize = true;
			this.RadioButton9.Location = new Point(275, 155);
			this.RadioButton9.Name = "RadioButton9";
			this.RadioButton9.Size = new Size(90, 17);
			this.RadioButton9.TabIndex = 164;
			this.RadioButton9.TabStop = true;
			this.RadioButton9.Text = "RadioButton9";
			this.RadioButton9.UseVisualStyleBackColor = true;
			this.PictureBox14.Location = new Point(220, 148);
			this.PictureBox14.Name = "PictureBox14";
			this.PictureBox14.Size = new Size(100, 50);
			this.PictureBox14.TabIndex = 163;
			this.PictureBox14.TabStop = false;
			this.NumericUpDown9.Location = new Point(145, 182);
			this.NumericUpDown9.Name = "NumericUpDown9";
			this.NumericUpDown9.Size = new Size(8, 20);
			this.NumericUpDown9.TabIndex = 162;
			this.MonthCalendar9.Location = new Point(163, 271);
			this.MonthCalendar9.Name = "MonthCalendar9";
			this.MonthCalendar9.TabIndex = 161;
			this.DateTimePicker27.Location = new Point(644, 182);
			this.DateTimePicker27.Name = "DateTimePicker27";
			this.DateTimePicker27.Size = new Size(200, 20);
			this.DateTimePicker27.TabIndex = 160;
			this.ComboBox17.FormattingEnabled = true;
			this.ComboBox17.Location = new Point(145, 174);
			this.ComboBox17.Name = "ComboBox17";
			this.ComboBox17.Size = new Size(121, 21);
			this.ComboBox17.TabIndex = 159;
			this.ComboBox18.FormattingEnabled = true;
			this.ComboBox18.Location = new Point(242, 239);
			this.ComboBox18.Name = "ComboBox18";
			this.ComboBox18.Size = new Size(121, 21);
			this.ComboBox18.TabIndex = 158;
			this.Label14.AutoSize = true;
			this.Label14.Location = new Point(182, 163);
			this.Label14.Name = "Label14";
			this.Label14.Size = new Size(45, 13);
			this.Label14.TabIndex = 157;
			this.Label14.Text = "Label14";
			this.CheckBox18.AutoSize = true;
			this.CheckBox18.Location = new Point(455, 103);
			this.CheckBox18.Name = "CheckBox18";
			this.CheckBox18.Size = new Size(87, 17);
			this.CheckBox18.TabIndex = 156;
			this.CheckBox18.Text = "CheckBox18";
			this.CheckBox18.UseVisualStyleBackColor = true;
			this.CheckedListBox18.FormattingEnabled = true;
			this.CheckedListBox18.Location = new Point(321, 155);
			this.CheckedListBox18.Name = "CheckedListBox18";
			this.CheckedListBox18.Size = new Size(120, 94);
			this.CheckedListBox18.TabIndex = 155;
			this.Button26.Location = new Point(100, 124);
			this.Button26.Name = "Button26";
			this.Button26.Size = new Size(75, 23);
			this.Button26.TabIndex = 154;
			this.Button26.Text = "Button26";
			this.Button26.UseVisualStyleBackColor = true;
			this.DateTimePicker28.Location = new Point(462, 318);
			this.DateTimePicker28.Name = "DateTimePicker28";
			this.DateTimePicker28.Size = new Size(221, 20);
			this.DateTimePicker28.TabIndex = 153;
			this.CheckedListBox19.FormattingEnabled = true;
			this.CheckedListBox19.Location = new Point(287, 36);
			this.CheckedListBox19.Name = "CheckedListBox19";
			this.CheckedListBox19.Size = new Size(207, 34);
			this.CheckedListBox19.TabIndex = 152;
			this.Button27.Location = new Point(312, 91);
			this.Button27.Name = "Button27";
			this.Button27.Size = new Size(91, 12);
			this.Button27.TabIndex = 151;
			this.Button27.Text = "Button27";
			this.Button27.UseVisualStyleBackColor = true;
			this.Button28.Location = new Point(91, 286);
			this.Button28.Name = "Button28";
			this.Button28.Size = new Size(67, 84);
			this.Button28.TabIndex = 150;
			this.Button28.Text = "Button28";
			this.Button28.UseVisualStyleBackColor = true;
			this.CheckBox19.AutoSize = true;
			this.CheckBox19.Location = new Point(91, 65);
			this.CheckBox19.Name = "CheckBox19";
			this.CheckBox19.Size = new Size(87, 17);
			this.CheckBox19.TabIndex = 149;
			this.CheckBox19.Text = "CheckBox19";
			this.CheckBox19.UseVisualStyleBackColor = true;
			this.DateTimePicker29.Location = new Point(182, 60);
			this.DateTimePicker29.Name = "DateTimePicker29";
			this.DateTimePicker29.Size = new Size(77, 20);
			this.DateTimePicker29.TabIndex = 148;
			this.ListView10.HideSelection = false;
			this.ListView10.Location = new Point(132, 185);
			this.ListView10.Name = "ListView10";
			this.ListView10.Size = new Size(70, 70);
			this.ListView10.TabIndex = 147;
			this.ListView10.UseCompatibleStateImageBehavior = false;
			this.ListBox10.FormattingEnabled = true;
			this.ListBox10.Location = new Point(152, 232);
			this.ListBox10.Name = "ListBox10";
			this.ListBox10.Size = new Size(93, 4);
			this.ListBox10.TabIndex = 146;
			this.WebBrowser10.Location = new Point(640, 130);
			this.WebBrowser10.MinimumSize = new Size(20, 20);
			this.WebBrowser10.Name = "WebBrowser10";
			this.WebBrowser10.Size = new Size(54, 127);
			this.WebBrowser10.TabIndex = 145;
			this.TreeView10.Location = new Point(551, 255);
			this.TreeView10.Name = "TreeView10";
			this.TreeView10.Size = new Size(77, 41);
			this.TreeView10.TabIndex = 144;
			this.RichTextBox19.Location = new Point(525, 108);
			this.RichTextBox19.Name = "RichTextBox19";
			this.RichTextBox19.Size = new Size(71, 100);
			this.RichTextBox19.TabIndex = 143;
			this.RichTextBox19.Text = "";
			this.RichTextBox20.Location = new Point(596, 211);
			this.RichTextBox20.Name = "RichTextBox20";
			this.RichTextBox20.Size = new Size(9, 13);
			this.RichTextBox20.TabIndex = 142;
			this.RichTextBox20.Text = "";
			this.ProgressBar10.Location = new Point(596, 67);
			this.ProgressBar10.Name = "ProgressBar10";
			this.ProgressBar10.Size = new Size(72, 11);
			this.ProgressBar10.TabIndex = 141;
			this.RadioButton10.AutoSize = true;
			this.RadioButton10.Location = new Point(314, 139);
			this.RadioButton10.Name = "RadioButton10";
			this.RadioButton10.Size = new Size(96, 17);
			this.RadioButton10.TabIndex = 140;
			this.RadioButton10.TabStop = true;
			this.RadioButton10.Text = "RadioButton10";
			this.RadioButton10.UseVisualStyleBackColor = true;
			this.PictureBox15.Location = new Point(259, 132);
			this.PictureBox15.Name = "PictureBox15";
			this.PictureBox15.Size = new Size(100, 50);
			this.PictureBox15.TabIndex = 139;
			this.PictureBox15.TabStop = false;
			this.NumericUpDown10.Location = new Point(184, 166);
			this.NumericUpDown10.Name = "NumericUpDown10";
			this.NumericUpDown10.Size = new Size(8, 20);
			this.NumericUpDown10.TabIndex = 138;
			this.MonthCalendar10.Location = new Point(202, 255);
			this.MonthCalendar10.Name = "MonthCalendar10";
			this.MonthCalendar10.TabIndex = 137;
			this.DateTimePicker30.Location = new Point(683, 166);
			this.DateTimePicker30.Name = "DateTimePicker30";
			this.DateTimePicker30.Size = new Size(200, 20);
			this.DateTimePicker30.TabIndex = 136;
			this.ComboBox19.FormattingEnabled = true;
			this.ComboBox19.Location = new Point(184, 158);
			this.ComboBox19.Name = "ComboBox19";
			this.ComboBox19.Size = new Size(121, 21);
			this.ComboBox19.TabIndex = 135;
			this.ComboBox20.FormattingEnabled = true;
			this.ComboBox20.Location = new Point(281, 223);
			this.ComboBox20.Name = "ComboBox20";
			this.ComboBox20.Size = new Size(121, 21);
			this.ComboBox20.TabIndex = 134;
			this.Label15.AutoSize = true;
			this.Label15.Location = new Point(221, 147);
			this.Label15.Name = "Label15";
			this.Label15.Size = new Size(45, 13);
			this.Label15.TabIndex = 133;
			this.Label15.Text = "Label15";
			this.CheckBox20.AutoSize = true;
			this.CheckBox20.Location = new Point(494, 87);
			this.CheckBox20.Name = "CheckBox20";
			this.CheckBox20.Size = new Size(87, 17);
			this.CheckBox20.TabIndex = 132;
			this.CheckBox20.Text = "CheckBox20";
			this.CheckBox20.UseVisualStyleBackColor = true;
			this.CheckedListBox20.FormattingEnabled = true;
			this.CheckedListBox20.Location = new Point(360, 139);
			this.CheckedListBox20.Name = "CheckedListBox20";
			this.CheckedListBox20.Size = new Size(120, 94);
			this.CheckedListBox20.TabIndex = 131;
			this.Button29.Location = new Point(139, 108);
			this.Button29.Name = "Button29";
			this.Button29.Size = new Size(75, 23);
			this.Button29.TabIndex = 130;
			this.Button29.Text = "Button29";
			this.Button29.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(800, 450);
			base.Controls.Add(this.DateTimePicker16);
			base.Controls.Add(this.CheckedListBox11);
			base.Controls.Add(this.Button16);
			base.Controls.Add(this.Button17);
			base.Controls.Add(this.CheckBox11);
			base.Controls.Add(this.DateTimePicker17);
			base.Controls.Add(this.ListView6);
			base.Controls.Add(this.ListBox6);
			base.Controls.Add(this.WebBrowser6);
			base.Controls.Add(this.TreeView6);
			base.Controls.Add(this.RichTextBox11);
			base.Controls.Add(this.RichTextBox12);
			base.Controls.Add(this.ProgressBar6);
			base.Controls.Add(this.RadioButton6);
			base.Controls.Add(this.PictureBox11);
			base.Controls.Add(this.NumericUpDown6);
			base.Controls.Add(this.MonthCalendar6);
			base.Controls.Add(this.DateTimePicker18);
			base.Controls.Add(this.ComboBox11);
			base.Controls.Add(this.ComboBox12);
			base.Controls.Add(this.Label11);
			base.Controls.Add(this.CheckBox12);
			base.Controls.Add(this.CheckedListBox12);
			base.Controls.Add(this.Button18);
			base.Controls.Add(this.DateTimePicker19);
			base.Controls.Add(this.CheckedListBox13);
			base.Controls.Add(this.Button19);
			base.Controls.Add(this.Button20);
			base.Controls.Add(this.CheckBox13);
			base.Controls.Add(this.DateTimePicker20);
			base.Controls.Add(this.ListView7);
			base.Controls.Add(this.ListBox7);
			base.Controls.Add(this.WebBrowser7);
			base.Controls.Add(this.TreeView7);
			base.Controls.Add(this.RichTextBox13);
			base.Controls.Add(this.RichTextBox14);
			base.Controls.Add(this.ProgressBar7);
			base.Controls.Add(this.RadioButton7);
			base.Controls.Add(this.PictureBox12);
			base.Controls.Add(this.NumericUpDown7);
			base.Controls.Add(this.MonthCalendar7);
			base.Controls.Add(this.DateTimePicker21);
			base.Controls.Add(this.ComboBox13);
			base.Controls.Add(this.ComboBox14);
			base.Controls.Add(this.Label12);
			base.Controls.Add(this.CheckBox14);
			base.Controls.Add(this.CheckedListBox14);
			base.Controls.Add(this.Button21);
			base.Controls.Add(this.DateTimePicker22);
			base.Controls.Add(this.CheckedListBox15);
			base.Controls.Add(this.Button22);
			base.Controls.Add(this.Button23);
			base.Controls.Add(this.CheckBox15);
			base.Controls.Add(this.DateTimePicker23);
			base.Controls.Add(this.ListView8);
			base.Controls.Add(this.ListBox8);
			base.Controls.Add(this.WebBrowser8);
			base.Controls.Add(this.TreeView8);
			base.Controls.Add(this.RichTextBox15);
			base.Controls.Add(this.RichTextBox16);
			base.Controls.Add(this.ProgressBar8);
			base.Controls.Add(this.RadioButton8);
			base.Controls.Add(this.PictureBox13);
			base.Controls.Add(this.NumericUpDown8);
			base.Controls.Add(this.MonthCalendar8);
			base.Controls.Add(this.DateTimePicker24);
			base.Controls.Add(this.ComboBox15);
			base.Controls.Add(this.ComboBox16);
			base.Controls.Add(this.Label13);
			base.Controls.Add(this.CheckBox16);
			base.Controls.Add(this.CheckedListBox16);
			base.Controls.Add(this.Button24);
			base.Controls.Add(this.DateTimePicker25);
			base.Controls.Add(this.CheckedListBox17);
			base.Controls.Add(this.Button25);
			base.Controls.Add(this.CheckBox17);
			base.Controls.Add(this.DateTimePicker26);
			base.Controls.Add(this.ListView9);
			base.Controls.Add(this.ListBox9);
			base.Controls.Add(this.WebBrowser9);
			base.Controls.Add(this.TreeView9);
			base.Controls.Add(this.RichTextBox17);
			base.Controls.Add(this.RichTextBox18);
			base.Controls.Add(this.ProgressBar9);
			base.Controls.Add(this.RadioButton9);
			base.Controls.Add(this.PictureBox14);
			base.Controls.Add(this.NumericUpDown9);
			base.Controls.Add(this.MonthCalendar9);
			base.Controls.Add(this.DateTimePicker27);
			base.Controls.Add(this.ComboBox17);
			base.Controls.Add(this.ComboBox18);
			base.Controls.Add(this.Label14);
			base.Controls.Add(this.CheckBox18);
			base.Controls.Add(this.CheckedListBox18);
			base.Controls.Add(this.Button26);
			base.Controls.Add(this.DateTimePicker28);
			base.Controls.Add(this.CheckedListBox19);
			base.Controls.Add(this.Button27);
			base.Controls.Add(this.Button28);
			base.Controls.Add(this.CheckBox19);
			base.Controls.Add(this.DateTimePicker29);
			base.Controls.Add(this.ListView10);
			base.Controls.Add(this.ListBox10);
			base.Controls.Add(this.WebBrowser10);
			base.Controls.Add(this.TreeView10);
			base.Controls.Add(this.RichTextBox19);
			base.Controls.Add(this.RichTextBox20);
			base.Controls.Add(this.ProgressBar10);
			base.Controls.Add(this.RadioButton10);
			base.Controls.Add(this.PictureBox15);
			base.Controls.Add(this.NumericUpDown10);
			base.Controls.Add(this.MonthCalendar10);
			base.Controls.Add(this.DateTimePicker30);
			base.Controls.Add(this.ComboBox19);
			base.Controls.Add(this.ComboBox20);
			base.Controls.Add(this.Label15);
			base.Controls.Add(this.CheckBox20);
			base.Controls.Add(this.CheckedListBox20);
			base.Controls.Add(this.Button29);
			base.Controls.Add(this.DateTimePicker13);
			base.Controls.Add(this.CheckedListBox9);
			base.Controls.Add(this.Button13);
			base.Controls.Add(this.Button14);
			base.Controls.Add(this.CheckBox9);
			base.Controls.Add(this.DateTimePicker14);
			base.Controls.Add(this.ListView5);
			base.Controls.Add(this.Label9);
			base.Controls.Add(this.ListBox5);
			base.Controls.Add(this.PictureBox9);
			base.Controls.Add(this.WebBrowser5);
			base.Controls.Add(this.TreeView5);
			base.Controls.Add(this.RichTextBox9);
			base.Controls.Add(this.RichTextBox10);
			base.Controls.Add(this.ProgressBar5);
			base.Controls.Add(this.RadioButton5);
			base.Controls.Add(this.PictureBox10);
			base.Controls.Add(this.NumericUpDown5);
			base.Controls.Add(this.MonthCalendar5);
			base.Controls.Add(this.DateTimePicker15);
			base.Controls.Add(this.ComboBox9);
			base.Controls.Add(this.ComboBox10);
			base.Controls.Add(this.Label10);
			base.Controls.Add(this.CheckBox10);
			base.Controls.Add(this.CheckedListBox10);
			base.Controls.Add(this.Button15);
			base.Controls.Add(this.DateTimePicker10);
			base.Controls.Add(this.CheckedListBox7);
			base.Controls.Add(this.Button10);
			base.Controls.Add(this.Button11);
			base.Controls.Add(this.CheckBox7);
			base.Controls.Add(this.DateTimePicker11);
			base.Controls.Add(this.ListView4);
			base.Controls.Add(this.Label7);
			base.Controls.Add(this.ListBox4);
			base.Controls.Add(this.PictureBox7);
			base.Controls.Add(this.WebBrowser4);
			base.Controls.Add(this.TreeView4);
			base.Controls.Add(this.RichTextBox7);
			base.Controls.Add(this.RichTextBox8);
			base.Controls.Add(this.ProgressBar4);
			base.Controls.Add(this.RadioButton4);
			base.Controls.Add(this.PictureBox8);
			base.Controls.Add(this.NumericUpDown4);
			base.Controls.Add(this.MonthCalendar4);
			base.Controls.Add(this.DateTimePicker12);
			base.Controls.Add(this.ComboBox7);
			base.Controls.Add(this.ComboBox8);
			base.Controls.Add(this.Label8);
			base.Controls.Add(this.CheckBox8);
			base.Controls.Add(this.CheckedListBox8);
			base.Controls.Add(this.Button12);
			base.Controls.Add(this.DateTimePicker7);
			base.Controls.Add(this.CheckedListBox5);
			base.Controls.Add(this.Button7);
			base.Controls.Add(this.Button8);
			base.Controls.Add(this.CheckBox5);
			base.Controls.Add(this.DateTimePicker8);
			base.Controls.Add(this.ListView3);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.ListBox3);
			base.Controls.Add(this.PictureBox5);
			base.Controls.Add(this.WebBrowser3);
			base.Controls.Add(this.TreeView3);
			base.Controls.Add(this.RichTextBox5);
			base.Controls.Add(this.RichTextBox6);
			base.Controls.Add(this.ProgressBar3);
			base.Controls.Add(this.RadioButton3);
			base.Controls.Add(this.PictureBox6);
			base.Controls.Add(this.NumericUpDown3);
			base.Controls.Add(this.MonthCalendar3);
			base.Controls.Add(this.DateTimePicker9);
			base.Controls.Add(this.ComboBox5);
			base.Controls.Add(this.ComboBox6);
			base.Controls.Add(this.Label6);
			base.Controls.Add(this.CheckBox6);
			base.Controls.Add(this.CheckedListBox6);
			base.Controls.Add(this.Button9);
			base.Controls.Add(this.DateTimePicker4);
			base.Controls.Add(this.CheckedListBox3);
			base.Controls.Add(this.Button4);
			base.Controls.Add(this.Button5);
			base.Controls.Add(this.CheckBox3);
			base.Controls.Add(this.DateTimePicker5);
			base.Controls.Add(this.ListView2);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.ListBox2);
			base.Controls.Add(this.PictureBox3);
			base.Controls.Add(this.WebBrowser2);
			base.Controls.Add(this.TreeView2);
			base.Controls.Add(this.RichTextBox3);
			base.Controls.Add(this.RichTextBox4);
			base.Controls.Add(this.ProgressBar2);
			base.Controls.Add(this.RadioButton2);
			base.Controls.Add(this.PictureBox4);
			base.Controls.Add(this.NumericUpDown2);
			base.Controls.Add(this.MonthCalendar2);
			base.Controls.Add(this.DateTimePicker6);
			base.Controls.Add(this.ComboBox3);
			base.Controls.Add(this.ComboBox4);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.CheckBox4);
			base.Controls.Add(this.CheckedListBox4);
			base.Controls.Add(this.Button6);
			base.Controls.Add(this.DateTimePicker3);
			base.Controls.Add(this.CheckedListBox2);
			base.Controls.Add(this.Button3);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.CheckBox2);
			base.Controls.Add(this.DateTimePicker2);
			base.Controls.Add(this.ListView1);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.ListBox1);
			base.Controls.Add(this.PictureBox2);
			base.Controls.Add(this.WebBrowser1);
			base.Controls.Add(this.TreeView1);
			base.Controls.Add(this.RichTextBox2);
			base.Controls.Add(this.RichTextBox1);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.RadioButton1);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.NumericUpDown1);
			base.Controls.Add(this.MonthCalendar1);
			base.Controls.Add(this.DateTimePicker1);
			base.Controls.Add(this.ComboBox2);
			base.Controls.Add(this.ComboBox1);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.CheckBox1);
			base.Controls.Add(this.CheckedListBox1);
			base.Controls.Add(this.Button1);
			base.Name = "Form1";
			this.Text = "Form1";
			((ISupportInitialize)this.NumericUpDown1).EndInit();
			((ISupportInitialize)this.PictureBox1).EndInit();
			((ISupportInitialize)this.PictureBox2).EndInit();
			((ISupportInitialize)this.PictureBox3).EndInit();
			((ISupportInitialize)this.PictureBox4).EndInit();
			((ISupportInitialize)this.NumericUpDown2).EndInit();
			((ISupportInitialize)this.PictureBox5).EndInit();
			((ISupportInitialize)this.PictureBox6).EndInit();
			((ISupportInitialize)this.NumericUpDown3).EndInit();
			((ISupportInitialize)this.PictureBox7).EndInit();
			((ISupportInitialize)this.PictureBox8).EndInit();
			((ISupportInitialize)this.NumericUpDown4).EndInit();
			((ISupportInitialize)this.PictureBox9).EndInit();
			((ISupportInitialize)this.PictureBox10).EndInit();
			((ISupportInitialize)this.NumericUpDown5).EndInit();
			((ISupportInitialize)this.PictureBox11).EndInit();
			((ISupportInitialize)this.NumericUpDown6).EndInit();
			((ISupportInitialize)this.PictureBox12).EndInit();
			((ISupportInitialize)this.NumericUpDown7).EndInit();
			((ISupportInitialize)this.PictureBox13).EndInit();
			((ISupportInitialize)this.NumericUpDown8).EndInit();
			((ISupportInitialize)this.PictureBox14).EndInit();
			((ISupportInitialize)this.NumericUpDown9).EndInit();
			((ISupportInitialize)this.PictureBox15).EndInit();
			((ISupportInitialize)this.NumericUpDown10).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00012DD2 File Offset: 0x00010FD2
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00012DDA File Offset: 0x00010FDA
		internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00012DE3 File Offset: 0x00010FE3
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00012DEB File Offset: 0x00010FEB
		internal virtual CheckedListBox CheckedListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00012DF4 File Offset: 0x00010FF4
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00012DFC File Offset: 0x00010FFC
		internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00012E05 File Offset: 0x00011005
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00012E0D File Offset: 0x0001100D
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00012E16 File Offset: 0x00011016
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00012E1E File Offset: 0x0001101E
		internal virtual ComboBox ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00012E27 File Offset: 0x00011027
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00012E2F File Offset: 0x0001102F
		internal virtual ComboBox ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00012E38 File Offset: 0x00011038
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00012E40 File Offset: 0x00011040
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00012E49 File Offset: 0x00011049
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00012E51 File Offset: 0x00011051
		internal virtual MonthCalendar MonthCalendar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00012E5A File Offset: 0x0001105A
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00012E62 File Offset: 0x00011062
		internal virtual NumericUpDown NumericUpDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00012E6B File Offset: 0x0001106B
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00012E73 File Offset: 0x00011073
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00012E7C File Offset: 0x0001107C
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00012E84 File Offset: 0x00011084
		internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00012E8D File Offset: 0x0001108D
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00012E95 File Offset: 0x00011095
		internal virtual ProgressBar ProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00012E9E File Offset: 0x0001109E
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00012EA6 File Offset: 0x000110A6
		internal virtual RichTextBox RichTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00012EAF File Offset: 0x000110AF
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00012EB7 File Offset: 0x000110B7
		internal virtual RichTextBox RichTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00012EC0 File Offset: 0x000110C0
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00012EC8 File Offset: 0x000110C8
		internal virtual TreeView TreeView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00012ED1 File Offset: 0x000110D1
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00012ED9 File Offset: 0x000110D9
		internal virtual WebBrowser WebBrowser1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00012EE2 File Offset: 0x000110E2
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00012EEA File Offset: 0x000110EA
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00012EF3 File Offset: 0x000110F3
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00012EFB File Offset: 0x000110FB
		internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00012F04 File Offset: 0x00011104
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00012F0C File Offset: 0x0001110C
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00012F15 File Offset: 0x00011115
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00012F1D File Offset: 0x0001111D
		internal virtual ListView ListView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00012F26 File Offset: 0x00011126
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00012F2E File Offset: 0x0001112E
		internal virtual DateTimePicker DateTimePicker2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00012F37 File Offset: 0x00011137
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00012F3F File Offset: 0x0001113F
		internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00012F48 File Offset: 0x00011148
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00012F50 File Offset: 0x00011150
		internal virtual Button Button2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00012F59 File Offset: 0x00011159
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00012F61 File Offset: 0x00011161
		internal virtual Button Button3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00012F6A File Offset: 0x0001116A
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00012F72 File Offset: 0x00011172
		internal virtual CheckedListBox CheckedListBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00012F7B File Offset: 0x0001117B
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00012F83 File Offset: 0x00011183
		internal virtual DateTimePicker DateTimePicker3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00012F8C File Offset: 0x0001118C
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00012F94 File Offset: 0x00011194
		internal virtual DateTimePicker DateTimePicker4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00012F9D File Offset: 0x0001119D
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00012FA5 File Offset: 0x000111A5
		internal virtual CheckedListBox CheckedListBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00012FAE File Offset: 0x000111AE
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00012FB6 File Offset: 0x000111B6
		internal virtual Button Button4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00012FBF File Offset: 0x000111BF
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00012FC7 File Offset: 0x000111C7
		internal virtual Button Button5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00012FD0 File Offset: 0x000111D0
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00012FD8 File Offset: 0x000111D8
		internal virtual CheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00012FE1 File Offset: 0x000111E1
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00012FE9 File Offset: 0x000111E9
		internal virtual DateTimePicker DateTimePicker5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00012FF2 File Offset: 0x000111F2
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00012FFA File Offset: 0x000111FA
		internal virtual ListView ListView2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00013003 File Offset: 0x00011203
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0001300B File Offset: 0x0001120B
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00013014 File Offset: 0x00011214
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0001301C File Offset: 0x0001121C
		internal virtual ListBox ListBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00013025 File Offset: 0x00011225
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0001302D File Offset: 0x0001122D
		internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00013036 File Offset: 0x00011236
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0001303E File Offset: 0x0001123E
		internal virtual WebBrowser WebBrowser2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00013047 File Offset: 0x00011247
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0001304F File Offset: 0x0001124F
		internal virtual TreeView TreeView2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00013058 File Offset: 0x00011258
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00013060 File Offset: 0x00011260
		internal virtual RichTextBox RichTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00013069 File Offset: 0x00011269
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00013071 File Offset: 0x00011271
		internal virtual RichTextBox RichTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0001307A File Offset: 0x0001127A
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00013082 File Offset: 0x00011282
		internal virtual ProgressBar ProgressBar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0001308B File Offset: 0x0001128B
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00013093 File Offset: 0x00011293
		internal virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0001309C File Offset: 0x0001129C
		// (set) Token: 0x0600028D RID: 653 RVA: 0x000130A4 File Offset: 0x000112A4
		internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600028E RID: 654 RVA: 0x000130AD File Offset: 0x000112AD
		// (set) Token: 0x0600028F RID: 655 RVA: 0x000130B5 File Offset: 0x000112B5
		internal virtual NumericUpDown NumericUpDown2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000290 RID: 656 RVA: 0x000130BE File Offset: 0x000112BE
		// (set) Token: 0x06000291 RID: 657 RVA: 0x000130C6 File Offset: 0x000112C6
		internal virtual MonthCalendar MonthCalendar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000292 RID: 658 RVA: 0x000130CF File Offset: 0x000112CF
		// (set) Token: 0x06000293 RID: 659 RVA: 0x000130D7 File Offset: 0x000112D7
		internal virtual DateTimePicker DateTimePicker6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000130E0 File Offset: 0x000112E0
		// (set) Token: 0x06000295 RID: 661 RVA: 0x000130E8 File Offset: 0x000112E8
		internal virtual ComboBox ComboBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000296 RID: 662 RVA: 0x000130F1 File Offset: 0x000112F1
		// (set) Token: 0x06000297 RID: 663 RVA: 0x000130F9 File Offset: 0x000112F9
		internal virtual ComboBox ComboBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00013102 File Offset: 0x00011302
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0001310A File Offset: 0x0001130A
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00013113 File Offset: 0x00011313
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0001311B File Offset: 0x0001131B
		internal virtual CheckBox CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00013124 File Offset: 0x00011324
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0001312C File Offset: 0x0001132C
		internal virtual CheckedListBox CheckedListBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00013135 File Offset: 0x00011335
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0001313D File Offset: 0x0001133D
		internal virtual Button Button6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00013146 File Offset: 0x00011346
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0001314E File Offset: 0x0001134E
		internal virtual DateTimePicker DateTimePicker7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00013157 File Offset: 0x00011357
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0001315F File Offset: 0x0001135F
		internal virtual CheckedListBox CheckedListBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00013168 File Offset: 0x00011368
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00013170 File Offset: 0x00011370
		internal virtual Button Button7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00013179 File Offset: 0x00011379
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00013181 File Offset: 0x00011381
		internal virtual Button Button8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0001318A File Offset: 0x0001138A
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00013192 File Offset: 0x00011392
		internal virtual CheckBox CheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0001319B File Offset: 0x0001139B
		// (set) Token: 0x060002AB RID: 683 RVA: 0x000131A3 File Offset: 0x000113A3
		internal virtual DateTimePicker DateTimePicker8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000131AC File Offset: 0x000113AC
		// (set) Token: 0x060002AD RID: 685 RVA: 0x000131B4 File Offset: 0x000113B4
		internal virtual ListView ListView3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060002AE RID: 686 RVA: 0x000131BD File Offset: 0x000113BD
		// (set) Token: 0x060002AF RID: 687 RVA: 0x000131C5 File Offset: 0x000113C5
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000131CE File Offset: 0x000113CE
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x000131D6 File Offset: 0x000113D6
		internal virtual ListBox ListBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000131DF File Offset: 0x000113DF
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x000131E7 File Offset: 0x000113E7
		internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000131F0 File Offset: 0x000113F0
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000131F8 File Offset: 0x000113F8
		internal virtual WebBrowser WebBrowser3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00013201 File Offset: 0x00011401
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00013209 File Offset: 0x00011409
		internal virtual TreeView TreeView3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00013212 File Offset: 0x00011412
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0001321A File Offset: 0x0001141A
		internal virtual RichTextBox RichTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00013223 File Offset: 0x00011423
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0001322B File Offset: 0x0001142B
		internal virtual RichTextBox RichTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00013234 File Offset: 0x00011434
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0001323C File Offset: 0x0001143C
		internal virtual ProgressBar ProgressBar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00013245 File Offset: 0x00011445
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0001324D File Offset: 0x0001144D
		internal virtual RadioButton RadioButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00013256 File Offset: 0x00011456
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0001325E File Offset: 0x0001145E
		internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00013267 File Offset: 0x00011467
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0001326F File Offset: 0x0001146F
		internal virtual NumericUpDown NumericUpDown3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00013278 File Offset: 0x00011478
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00013280 File Offset: 0x00011480
		internal virtual MonthCalendar MonthCalendar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00013289 File Offset: 0x00011489
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00013291 File Offset: 0x00011491
		internal virtual DateTimePicker DateTimePicker9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0001329A File Offset: 0x0001149A
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x000132A2 File Offset: 0x000114A2
		internal virtual ComboBox ComboBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060002CA RID: 714 RVA: 0x000132AB File Offset: 0x000114AB
		// (set) Token: 0x060002CB RID: 715 RVA: 0x000132B3 File Offset: 0x000114B3
		internal virtual ComboBox ComboBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060002CC RID: 716 RVA: 0x000132BC File Offset: 0x000114BC
		// (set) Token: 0x060002CD RID: 717 RVA: 0x000132C4 File Offset: 0x000114C4
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000132CD File Offset: 0x000114CD
		// (set) Token: 0x060002CF RID: 719 RVA: 0x000132D5 File Offset: 0x000114D5
		internal virtual CheckBox CheckBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x000132DE File Offset: 0x000114DE
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000132E6 File Offset: 0x000114E6
		internal virtual CheckedListBox CheckedListBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000132EF File Offset: 0x000114EF
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000132F7 File Offset: 0x000114F7
		internal virtual Button Button9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00013300 File Offset: 0x00011500
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00013308 File Offset: 0x00011508
		internal virtual DateTimePicker DateTimePicker10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00013311 File Offset: 0x00011511
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00013319 File Offset: 0x00011519
		internal virtual CheckedListBox CheckedListBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00013322 File Offset: 0x00011522
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0001332A File Offset: 0x0001152A
		internal virtual Button Button10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00013333 File Offset: 0x00011533
		// (set) Token: 0x060002DB RID: 731 RVA: 0x0001333B File Offset: 0x0001153B
		internal virtual Button Button11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00013344 File Offset: 0x00011544
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0001334C File Offset: 0x0001154C
		internal virtual CheckBox CheckBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00013355 File Offset: 0x00011555
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0001335D File Offset: 0x0001155D
		internal virtual DateTimePicker DateTimePicker11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00013366 File Offset: 0x00011566
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0001336E File Offset: 0x0001156E
		internal virtual ListView ListView4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00013377 File Offset: 0x00011577
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0001337F File Offset: 0x0001157F
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00013388 File Offset: 0x00011588
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00013390 File Offset: 0x00011590
		internal virtual ListBox ListBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00013399 File Offset: 0x00011599
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x000133A1 File Offset: 0x000115A1
		internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x000133AA File Offset: 0x000115AA
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x000133B2 File Offset: 0x000115B2
		internal virtual WebBrowser WebBrowser4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000133BB File Offset: 0x000115BB
		// (set) Token: 0x060002EB RID: 747 RVA: 0x000133C3 File Offset: 0x000115C3
		internal virtual TreeView TreeView4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060002EC RID: 748 RVA: 0x000133CC File Offset: 0x000115CC
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000133D4 File Offset: 0x000115D4
		internal virtual RichTextBox RichTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000133DD File Offset: 0x000115DD
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000133E5 File Offset: 0x000115E5
		internal virtual RichTextBox RichTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x000133EE File Offset: 0x000115EE
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x000133F6 File Offset: 0x000115F6
		internal virtual ProgressBar ProgressBar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x000133FF File Offset: 0x000115FF
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00013407 File Offset: 0x00011607
		internal virtual RadioButton RadioButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00013410 File Offset: 0x00011610
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00013418 File Offset: 0x00011618
		internal virtual PictureBox PictureBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00013421 File Offset: 0x00011621
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00013429 File Offset: 0x00011629
		internal virtual NumericUpDown NumericUpDown4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00013432 File Offset: 0x00011632
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0001343A File Offset: 0x0001163A
		internal virtual MonthCalendar MonthCalendar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00013443 File Offset: 0x00011643
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0001344B File Offset: 0x0001164B
		internal virtual DateTimePicker DateTimePicker12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00013454 File Offset: 0x00011654
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0001345C File Offset: 0x0001165C
		internal virtual ComboBox ComboBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00013465 File Offset: 0x00011665
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0001346D File Offset: 0x0001166D
		internal virtual ComboBox ComboBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00013476 File Offset: 0x00011676
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0001347E File Offset: 0x0001167E
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00013487 File Offset: 0x00011687
		// (set) Token: 0x06000303 RID: 771 RVA: 0x0001348F File Offset: 0x0001168F
		internal virtual CheckBox CheckBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00013498 File Offset: 0x00011698
		// (set) Token: 0x06000305 RID: 773 RVA: 0x000134A0 File Offset: 0x000116A0
		internal virtual CheckedListBox CheckedListBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000134A9 File Offset: 0x000116A9
		// (set) Token: 0x06000307 RID: 775 RVA: 0x000134B1 File Offset: 0x000116B1
		internal virtual Button Button12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000308 RID: 776 RVA: 0x000134BA File Offset: 0x000116BA
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000134C2 File Offset: 0x000116C2
		internal virtual DateTimePicker DateTimePicker13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000134CB File Offset: 0x000116CB
		// (set) Token: 0x0600030B RID: 779 RVA: 0x000134D3 File Offset: 0x000116D3
		internal virtual CheckedListBox CheckedListBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000134DC File Offset: 0x000116DC
		// (set) Token: 0x0600030D RID: 781 RVA: 0x000134E4 File Offset: 0x000116E4
		internal virtual Button Button13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000134ED File Offset: 0x000116ED
		// (set) Token: 0x0600030F RID: 783 RVA: 0x000134F5 File Offset: 0x000116F5
		internal virtual Button Button14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000134FE File Offset: 0x000116FE
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00013506 File Offset: 0x00011706
		internal virtual CheckBox CheckBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0001350F File Offset: 0x0001170F
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00013517 File Offset: 0x00011717
		internal virtual DateTimePicker DateTimePicker14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00013520 File Offset: 0x00011720
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00013528 File Offset: 0x00011728
		internal virtual ListView ListView5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00013531 File Offset: 0x00011731
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00013539 File Offset: 0x00011739
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00013542 File Offset: 0x00011742
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0001354A File Offset: 0x0001174A
		internal virtual ListBox ListBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00013553 File Offset: 0x00011753
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0001355B File Offset: 0x0001175B
		internal virtual PictureBox PictureBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00013564 File Offset: 0x00011764
		// (set) Token: 0x0600031D RID: 797 RVA: 0x0001356C File Offset: 0x0001176C
		internal virtual WebBrowser WebBrowser5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00013575 File Offset: 0x00011775
		// (set) Token: 0x0600031F RID: 799 RVA: 0x0001357D File Offset: 0x0001177D
		internal virtual TreeView TreeView5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00013586 File Offset: 0x00011786
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0001358E File Offset: 0x0001178E
		internal virtual RichTextBox RichTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00013597 File Offset: 0x00011797
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0001359F File Offset: 0x0001179F
		internal virtual RichTextBox RichTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000135A8 File Offset: 0x000117A8
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000135B0 File Offset: 0x000117B0
		internal virtual ProgressBar ProgressBar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000135B9 File Offset: 0x000117B9
		// (set) Token: 0x06000327 RID: 807 RVA: 0x000135C1 File Offset: 0x000117C1
		internal virtual RadioButton RadioButton5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000135CA File Offset: 0x000117CA
		// (set) Token: 0x06000329 RID: 809 RVA: 0x000135D2 File Offset: 0x000117D2
		internal virtual PictureBox PictureBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000135DB File Offset: 0x000117DB
		// (set) Token: 0x0600032B RID: 811 RVA: 0x000135E3 File Offset: 0x000117E3
		internal virtual NumericUpDown NumericUpDown5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000135EC File Offset: 0x000117EC
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000135F4 File Offset: 0x000117F4
		internal virtual MonthCalendar MonthCalendar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600032E RID: 814 RVA: 0x000135FD File Offset: 0x000117FD
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00013605 File Offset: 0x00011805
		internal virtual DateTimePicker DateTimePicker15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0001360E File Offset: 0x0001180E
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00013616 File Offset: 0x00011816
		internal virtual ComboBox ComboBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0001361F File Offset: 0x0001181F
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00013627 File Offset: 0x00011827
		internal virtual ComboBox ComboBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00013630 File Offset: 0x00011830
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00013638 File Offset: 0x00011838
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00013641 File Offset: 0x00011841
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00013649 File Offset: 0x00011849
		internal virtual CheckBox CheckBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00013652 File Offset: 0x00011852
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0001365A File Offset: 0x0001185A
		internal virtual CheckedListBox CheckedListBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00013663 File Offset: 0x00011863
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0001366B File Offset: 0x0001186B
		internal virtual Button Button15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00013674 File Offset: 0x00011874
		// (set) Token: 0x0600033D RID: 829 RVA: 0x0001367C File Offset: 0x0001187C
		internal virtual DateTimePicker DateTimePicker16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00013685 File Offset: 0x00011885
		// (set) Token: 0x0600033F RID: 831 RVA: 0x0001368D File Offset: 0x0001188D
		internal virtual CheckedListBox CheckedListBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00013696 File Offset: 0x00011896
		// (set) Token: 0x06000341 RID: 833 RVA: 0x0001369E File Offset: 0x0001189E
		internal virtual Button Button16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000342 RID: 834 RVA: 0x000136A7 File Offset: 0x000118A7
		// (set) Token: 0x06000343 RID: 835 RVA: 0x000136AF File Offset: 0x000118AF
		internal virtual Button Button17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000344 RID: 836 RVA: 0x000136B8 File Offset: 0x000118B8
		// (set) Token: 0x06000345 RID: 837 RVA: 0x000136C0 File Offset: 0x000118C0
		internal virtual CheckBox CheckBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000346 RID: 838 RVA: 0x000136C9 File Offset: 0x000118C9
		// (set) Token: 0x06000347 RID: 839 RVA: 0x000136D1 File Offset: 0x000118D1
		internal virtual DateTimePicker DateTimePicker17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000136DA File Offset: 0x000118DA
		// (set) Token: 0x06000349 RID: 841 RVA: 0x000136E2 File Offset: 0x000118E2
		internal virtual ListView ListView6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000136EB File Offset: 0x000118EB
		// (set) Token: 0x0600034B RID: 843 RVA: 0x000136F3 File Offset: 0x000118F3
		internal virtual ListBox ListBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600034C RID: 844 RVA: 0x000136FC File Offset: 0x000118FC
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00013704 File Offset: 0x00011904
		internal virtual WebBrowser WebBrowser6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0001370D File Offset: 0x0001190D
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00013715 File Offset: 0x00011915
		internal virtual TreeView TreeView6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0001371E File Offset: 0x0001191E
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00013726 File Offset: 0x00011926
		internal virtual RichTextBox RichTextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0001372F File Offset: 0x0001192F
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00013737 File Offset: 0x00011937
		internal virtual RichTextBox RichTextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00013740 File Offset: 0x00011940
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00013748 File Offset: 0x00011948
		internal virtual ProgressBar ProgressBar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00013751 File Offset: 0x00011951
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00013759 File Offset: 0x00011959
		internal virtual RadioButton RadioButton6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00013762 File Offset: 0x00011962
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0001376A File Offset: 0x0001196A
		internal virtual PictureBox PictureBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00013773 File Offset: 0x00011973
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0001377B File Offset: 0x0001197B
		internal virtual NumericUpDown NumericUpDown6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00013784 File Offset: 0x00011984
		// (set) Token: 0x0600035D RID: 861 RVA: 0x0001378C File Offset: 0x0001198C
		internal virtual MonthCalendar MonthCalendar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00013795 File Offset: 0x00011995
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0001379D File Offset: 0x0001199D
		internal virtual DateTimePicker DateTimePicker18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000137A6 File Offset: 0x000119A6
		// (set) Token: 0x06000361 RID: 865 RVA: 0x000137AE File Offset: 0x000119AE
		internal virtual ComboBox ComboBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000362 RID: 866 RVA: 0x000137B7 File Offset: 0x000119B7
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000137BF File Offset: 0x000119BF
		internal virtual ComboBox ComboBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000137C8 File Offset: 0x000119C8
		// (set) Token: 0x06000365 RID: 869 RVA: 0x000137D0 File Offset: 0x000119D0
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000366 RID: 870 RVA: 0x000137D9 File Offset: 0x000119D9
		// (set) Token: 0x06000367 RID: 871 RVA: 0x000137E1 File Offset: 0x000119E1
		internal virtual CheckBox CheckBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000368 RID: 872 RVA: 0x000137EA File Offset: 0x000119EA
		// (set) Token: 0x06000369 RID: 873 RVA: 0x000137F2 File Offset: 0x000119F2
		internal virtual CheckedListBox CheckedListBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000137FB File Offset: 0x000119FB
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00013803 File Offset: 0x00011A03
		internal virtual Button Button18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0001380C File Offset: 0x00011A0C
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00013814 File Offset: 0x00011A14
		internal virtual DateTimePicker DateTimePicker19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0001381D File Offset: 0x00011A1D
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00013825 File Offset: 0x00011A25
		internal virtual CheckedListBox CheckedListBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0001382E File Offset: 0x00011A2E
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00013836 File Offset: 0x00011A36
		internal virtual Button Button19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0001383F File Offset: 0x00011A3F
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00013847 File Offset: 0x00011A47
		internal virtual Button Button20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00013850 File Offset: 0x00011A50
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00013858 File Offset: 0x00011A58
		internal virtual CheckBox CheckBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00013861 File Offset: 0x00011A61
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00013869 File Offset: 0x00011A69
		internal virtual DateTimePicker DateTimePicker20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00013872 File Offset: 0x00011A72
		// (set) Token: 0x06000379 RID: 889 RVA: 0x0001387A File Offset: 0x00011A7A
		internal virtual ListView ListView7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00013883 File Offset: 0x00011A83
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0001388B File Offset: 0x00011A8B
		internal virtual ListBox ListBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00013894 File Offset: 0x00011A94
		// (set) Token: 0x0600037D RID: 893 RVA: 0x0001389C File Offset: 0x00011A9C
		internal virtual WebBrowser WebBrowser7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600037E RID: 894 RVA: 0x000138A5 File Offset: 0x00011AA5
		// (set) Token: 0x0600037F RID: 895 RVA: 0x000138AD File Offset: 0x00011AAD
		internal virtual TreeView TreeView7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000380 RID: 896 RVA: 0x000138B6 File Offset: 0x00011AB6
		// (set) Token: 0x06000381 RID: 897 RVA: 0x000138BE File Offset: 0x00011ABE
		internal virtual RichTextBox RichTextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000138C7 File Offset: 0x00011AC7
		// (set) Token: 0x06000383 RID: 899 RVA: 0x000138CF File Offset: 0x00011ACF
		internal virtual RichTextBox RichTextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000384 RID: 900 RVA: 0x000138D8 File Offset: 0x00011AD8
		// (set) Token: 0x06000385 RID: 901 RVA: 0x000138E0 File Offset: 0x00011AE0
		internal virtual ProgressBar ProgressBar7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000386 RID: 902 RVA: 0x000138E9 File Offset: 0x00011AE9
		// (set) Token: 0x06000387 RID: 903 RVA: 0x000138F1 File Offset: 0x00011AF1
		internal virtual RadioButton RadioButton7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000388 RID: 904 RVA: 0x000138FA File Offset: 0x00011AFA
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00013902 File Offset: 0x00011B02
		internal virtual PictureBox PictureBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0001390B File Offset: 0x00011B0B
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00013913 File Offset: 0x00011B13
		internal virtual NumericUpDown NumericUpDown7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0001391C File Offset: 0x00011B1C
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00013924 File Offset: 0x00011B24
		internal virtual MonthCalendar MonthCalendar7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0001392D File Offset: 0x00011B2D
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00013935 File Offset: 0x00011B35
		internal virtual DateTimePicker DateTimePicker21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0001393E File Offset: 0x00011B3E
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00013946 File Offset: 0x00011B46
		internal virtual ComboBox ComboBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0001394F File Offset: 0x00011B4F
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00013957 File Offset: 0x00011B57
		internal virtual ComboBox ComboBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00013960 File Offset: 0x00011B60
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00013968 File Offset: 0x00011B68
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00013971 File Offset: 0x00011B71
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00013979 File Offset: 0x00011B79
		internal virtual CheckBox CheckBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00013982 File Offset: 0x00011B82
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0001398A File Offset: 0x00011B8A
		internal virtual CheckedListBox CheckedListBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00013993 File Offset: 0x00011B93
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0001399B File Offset: 0x00011B9B
		internal virtual Button Button21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600039C RID: 924 RVA: 0x000139A4 File Offset: 0x00011BA4
		// (set) Token: 0x0600039D RID: 925 RVA: 0x000139AC File Offset: 0x00011BAC
		internal virtual DateTimePicker DateTimePicker22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600039E RID: 926 RVA: 0x000139B5 File Offset: 0x00011BB5
		// (set) Token: 0x0600039F RID: 927 RVA: 0x000139BD File Offset: 0x00011BBD
		internal virtual CheckedListBox CheckedListBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000139C6 File Offset: 0x00011BC6
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x000139CE File Offset: 0x00011BCE
		internal virtual Button Button22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x000139D7 File Offset: 0x00011BD7
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x000139DF File Offset: 0x00011BDF
		internal virtual Button Button23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000139E8 File Offset: 0x00011BE8
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x000139F0 File Offset: 0x00011BF0
		internal virtual CheckBox CheckBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x000139F9 File Offset: 0x00011BF9
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00013A01 File Offset: 0x00011C01
		internal virtual DateTimePicker DateTimePicker23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00013A0A File Offset: 0x00011C0A
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00013A12 File Offset: 0x00011C12
		internal virtual ListView ListView8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00013A1B File Offset: 0x00011C1B
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00013A23 File Offset: 0x00011C23
		internal virtual ListBox ListBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00013A2C File Offset: 0x00011C2C
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00013A34 File Offset: 0x00011C34
		internal virtual WebBrowser WebBrowser8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00013A3D File Offset: 0x00011C3D
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00013A45 File Offset: 0x00011C45
		internal virtual TreeView TreeView8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00013A4E File Offset: 0x00011C4E
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00013A56 File Offset: 0x00011C56
		internal virtual RichTextBox RichTextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00013A5F File Offset: 0x00011C5F
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00013A67 File Offset: 0x00011C67
		internal virtual RichTextBox RichTextBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00013A70 File Offset: 0x00011C70
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00013A78 File Offset: 0x00011C78
		internal virtual ProgressBar ProgressBar8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00013A81 File Offset: 0x00011C81
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00013A89 File Offset: 0x00011C89
		internal virtual RadioButton RadioButton8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00013A92 File Offset: 0x00011C92
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00013A9A File Offset: 0x00011C9A
		internal virtual PictureBox PictureBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00013AA3 File Offset: 0x00011CA3
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00013AAB File Offset: 0x00011CAB
		internal virtual NumericUpDown NumericUpDown8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00013AB4 File Offset: 0x00011CB4
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00013ABC File Offset: 0x00011CBC
		internal virtual MonthCalendar MonthCalendar8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00013AC5 File Offset: 0x00011CC5
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00013ACD File Offset: 0x00011CCD
		internal virtual DateTimePicker DateTimePicker24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00013AD6 File Offset: 0x00011CD6
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00013ADE File Offset: 0x00011CDE
		internal virtual ComboBox ComboBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00013AE7 File Offset: 0x00011CE7
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00013AEF File Offset: 0x00011CEF
		internal virtual ComboBox ComboBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00013AF8 File Offset: 0x00011CF8
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00013B00 File Offset: 0x00011D00
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00013B09 File Offset: 0x00011D09
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00013B11 File Offset: 0x00011D11
		internal virtual CheckBox CheckBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00013B1A File Offset: 0x00011D1A
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00013B22 File Offset: 0x00011D22
		internal virtual CheckedListBox CheckedListBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00013B2B File Offset: 0x00011D2B
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00013B33 File Offset: 0x00011D33
		internal virtual Button Button24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00013B3C File Offset: 0x00011D3C
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00013B44 File Offset: 0x00011D44
		internal virtual DateTimePicker DateTimePicker25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00013B4D File Offset: 0x00011D4D
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00013B55 File Offset: 0x00011D55
		internal virtual CheckedListBox CheckedListBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00013B5E File Offset: 0x00011D5E
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00013B66 File Offset: 0x00011D66
		internal virtual Button Button25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00013B6F File Offset: 0x00011D6F
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00013B77 File Offset: 0x00011D77
		internal virtual CheckBox CheckBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00013B80 File Offset: 0x00011D80
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00013B88 File Offset: 0x00011D88
		internal virtual DateTimePicker DateTimePicker26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00013B91 File Offset: 0x00011D91
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00013B99 File Offset: 0x00011D99
		internal virtual ListView ListView9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00013BA2 File Offset: 0x00011DA2
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00013BAA File Offset: 0x00011DAA
		internal virtual ListBox ListBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00013BB3 File Offset: 0x00011DB3
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00013BBB File Offset: 0x00011DBB
		internal virtual WebBrowser WebBrowser9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00013BC4 File Offset: 0x00011DC4
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00013BCC File Offset: 0x00011DCC
		internal virtual TreeView TreeView9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00013BD5 File Offset: 0x00011DD5
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00013BDD File Offset: 0x00011DDD
		internal virtual RichTextBox RichTextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00013BE6 File Offset: 0x00011DE6
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00013BEE File Offset: 0x00011DEE
		internal virtual RichTextBox RichTextBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00013BF7 File Offset: 0x00011DF7
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00013BFF File Offset: 0x00011DFF
		internal virtual ProgressBar ProgressBar9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00013C08 File Offset: 0x00011E08
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00013C10 File Offset: 0x00011E10
		internal virtual RadioButton RadioButton9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00013C19 File Offset: 0x00011E19
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00013C21 File Offset: 0x00011E21
		internal virtual PictureBox PictureBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00013C2A File Offset: 0x00011E2A
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00013C32 File Offset: 0x00011E32
		internal virtual NumericUpDown NumericUpDown9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00013C3B File Offset: 0x00011E3B
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00013C43 File Offset: 0x00011E43
		internal virtual MonthCalendar MonthCalendar9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00013C4C File Offset: 0x00011E4C
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00013C54 File Offset: 0x00011E54
		internal virtual DateTimePicker DateTimePicker27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00013C5D File Offset: 0x00011E5D
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00013C65 File Offset: 0x00011E65
		internal virtual ComboBox ComboBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00013C6E File Offset: 0x00011E6E
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00013C76 File Offset: 0x00011E76
		internal virtual ComboBox ComboBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00013C7F File Offset: 0x00011E7F
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00013C87 File Offset: 0x00011E87
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00013C90 File Offset: 0x00011E90
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00013C98 File Offset: 0x00011E98
		internal virtual CheckBox CheckBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00013CA1 File Offset: 0x00011EA1
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00013CA9 File Offset: 0x00011EA9
		internal virtual CheckedListBox CheckedListBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00013CB2 File Offset: 0x00011EB2
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00013CBA File Offset: 0x00011EBA
		internal virtual Button Button26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00013CC3 File Offset: 0x00011EC3
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00013CCB File Offset: 0x00011ECB
		internal virtual DateTimePicker DateTimePicker28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00013CD4 File Offset: 0x00011ED4
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00013CDC File Offset: 0x00011EDC
		internal virtual CheckedListBox CheckedListBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00013CE5 File Offset: 0x00011EE5
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00013CED File Offset: 0x00011EED
		internal virtual Button Button27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00013CF6 File Offset: 0x00011EF6
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00013CFE File Offset: 0x00011EFE
		internal virtual Button Button28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00013D07 File Offset: 0x00011F07
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00013D0F File Offset: 0x00011F0F
		internal virtual CheckBox CheckBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00013D18 File Offset: 0x00011F18
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00013D20 File Offset: 0x00011F20
		internal virtual DateTimePicker DateTimePicker29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00013D29 File Offset: 0x00011F29
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00013D31 File Offset: 0x00011F31
		internal virtual ListView ListView10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00013D3A File Offset: 0x00011F3A
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00013D42 File Offset: 0x00011F42
		internal virtual ListBox ListBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00013D4B File Offset: 0x00011F4B
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00013D53 File Offset: 0x00011F53
		internal virtual WebBrowser WebBrowser10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00013D5C File Offset: 0x00011F5C
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00013D64 File Offset: 0x00011F64
		internal virtual TreeView TreeView10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00013D6D File Offset: 0x00011F6D
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00013D75 File Offset: 0x00011F75
		internal virtual RichTextBox RichTextBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00013D7E File Offset: 0x00011F7E
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00013D86 File Offset: 0x00011F86
		internal virtual RichTextBox RichTextBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00013D8F File Offset: 0x00011F8F
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00013D97 File Offset: 0x00011F97
		internal virtual ProgressBar ProgressBar10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00013DA0 File Offset: 0x00011FA0
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00013DA8 File Offset: 0x00011FA8
		internal virtual RadioButton RadioButton10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00013DB1 File Offset: 0x00011FB1
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00013DB9 File Offset: 0x00011FB9
		internal virtual PictureBox PictureBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00013DC2 File Offset: 0x00011FC2
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00013DCA File Offset: 0x00011FCA
		internal virtual NumericUpDown NumericUpDown10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00013DD3 File Offset: 0x00011FD3
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00013DDB File Offset: 0x00011FDB
		internal virtual MonthCalendar MonthCalendar10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00013DE4 File Offset: 0x00011FE4
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00013DEC File Offset: 0x00011FEC
		internal virtual DateTimePicker DateTimePicker30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00013DF5 File Offset: 0x00011FF5
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00013DFD File Offset: 0x00011FFD
		internal virtual ComboBox ComboBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00013E06 File Offset: 0x00012006
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00013E0E File Offset: 0x0001200E
		internal virtual ComboBox ComboBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00013E17 File Offset: 0x00012017
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00013E1F File Offset: 0x0001201F
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00013E28 File Offset: 0x00012028
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00013E30 File Offset: 0x00012030
		internal virtual CheckBox CheckBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00013E39 File Offset: 0x00012039
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00013E41 File Offset: 0x00012041
		internal virtual CheckedListBox CheckedListBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00013E4A File Offset: 0x0001204A
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00013E52 File Offset: 0x00012052
		internal virtual Button Button29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600042A RID: 1066 RVA: 0x00013E5C File Offset: 0x0001205C
		public void New45456()
		{
			if (Form1.m_vb6FormDefInstance == null)
			{
				if (Form1.m_InitializingDefInstance)
				{
					Form1.m_vb6FormDefInstance = this;
					return;
				}
				try
				{
					if (Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == base.GetType())
					{
						Form1.m_vb6FormDefInstance = this;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00013EBC File Offset: 0x000120BC
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00013EC4 File Offset: 0x000120C4
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
				EventHandler value2 = new EventHandler(this.Command145_Click);
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

		// Token: 0x0600042D RID: 1069 RVA: 0x00013F08 File Offset: 0x00012108
		[DebuggerStepThrough]
		private void Meuapunasuaorelha()
		{
			new ResourceManager(typeof(Form1));
			this.components2 = new Container();
			this.ToolTip1 = new ToolTip(this.components2);
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
			this.Command1.Text = "Create color scales";
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0001410C File Offset: 0x0001230C
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0001414D File Offset: 0x0001234D
		public static Form1 DefInstance24
		{
			get
			{
				if (Form1.m_vb6FormDefInstance == null || Form1.m_vb6FormDefInstance.IsDisposed)
				{
					Form1.m_InitializingDefInstance = true;
					Form1.m_vb6FormDefInstance = new Form1();
					Form1.m_InitializingDefInstance = false;
				}
				Form1.DefInstance = Form1.m_vb6FormDefInstance;
				Form1 result;
				return result;
			}
			set
			{
				Form1.m_vb6FormDefInstance = value;
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00014158 File Offset: 0x00012358
		private void Command145_Click(object eventSender, EventArgs eventArgs)
		{
			CoXlsEngine o = (CoXlsEngine)Interaction.CreateObject("ExcelGenerator.ARsTDesign", "");
			IXlsWorkbook xlsWorkbook;
			IXlsWorksheet xlsWorksheet = xlsWorkbook.get_AddWorksheet("color scale");
			NewLateBinding.LateSetComplex(xlsWorksheet.Columns("B1:B1"), null, "Width", new object[]
			{
				15
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(xlsWorksheet.Columns("C1:F1"), null, "Width", new object[]
			{
				10
			}, null, null, false, true);
			IXlsStyle xlsStyle = xlsWorksheet.NewStyle();
			NewLateBinding.LateSetComplex(xlsStyle.Font(), null, "Bold", new object[]
			{
				true
			}, null, null, false, true);
			IXlsStyle xlsStyle2 = xlsStyle.Duplicate();
			NewLateBinding.LateSetComplex(xlsStyle2.Alignment(), null, "Horizontal", new object[1], null, null, false, true);
			xlsStyle2.Apply();
			xlsStyle.Apply();
			IXlsStyle xlsStyle3 = xlsWorksheet.NewStyle();
			xlsStyle3.Apply();
			IXlsStyle xlsStyle4 = xlsWorksheet.NewStyle();
			NewLateBinding.LateSetComplex(xlsStyle4.Pattern(), null, "BackgroundColor", new object[]
			{
				16711680
			}, null, null, false, true);
			IXlsStyle xlsStyle5 = xlsStyle4.Duplicate();
			IXlsStyle xlsStyle6 = xlsStyle4.Duplicate();
			IXlsStyle xlsStyle7 = xlsStyle4.Duplicate();
			IXlsStyle xlsStyle8 = xlsStyle4.Duplicate();
			IXlsStyle xlsStyle9 = xlsStyle4.Duplicate();
			IXlsStyle xlsStyle10 = xlsStyle4.Duplicate();
			IXlsStyle xlsStyle11 = xlsStyle4.Duplicate();
			IXlsStyle xlsStyle12 = xlsStyle4.Duplicate();
			object instance = xlsStyle5.Pattern();
			Type type = null;
			string memberName = "BackgroundColor";
			object[] array = new object[1];
			int num = 0;
			object loopObj = 255;
			object loopObj2 = 0;
			object loopObj3 = 0;
			array[num] = this.RGB_Renamed(ref loopObj, ref loopObj2, ref loopObj3);
			NewLateBinding.LateSetComplex(instance, type, memberName, array, null, null, false, true);
			object instance2 = xlsStyle6.Pattern();
			Type type2 = null;
			string memberName2 = "BackgroundColor";
			object[] array2 = new object[1];
			int num2 = 0;
			loopObj3 = 255;
			loopObj2 = 136;
			loopObj = 0;
			array2[num2] = this.RGB_Renamed(ref loopObj3, ref loopObj2, ref loopObj);
			NewLateBinding.LateSetComplex(instance2, type2, memberName2, array2, null, null, false, true);
			object instance3 = xlsStyle7.Pattern();
			Type type3 = null;
			string memberName3 = "BackgroundColor";
			object[] array3 = new object[1];
			int num3 = 0;
			loopObj = 255;
			loopObj2 = 170;
			loopObj3 = 0;
			array3[num3] = this.RGB_Renamed(ref loopObj, ref loopObj2, ref loopObj3);
			NewLateBinding.LateSetComplex(instance3, type3, memberName3, array3, null, null, false, true);
			object instance4 = xlsStyle8.Pattern();
			Type type4 = null;
			string memberName4 = "BackgroundColor";
			object[] array4 = new object[1];
			int num4 = 0;
			loopObj3 = 255;
			loopObj2 = 221;
			loopObj = 0;
			array4[num4] = this.RGB_Renamed(ref loopObj3, ref loopObj2, ref loopObj);
			NewLateBinding.LateSetComplex(instance4, type4, memberName4, array4, null, null, false, true);
			object instance5 = xlsStyle9.Pattern();
			Type type5 = null;
			string memberName5 = "BackgroundColor";
			object[] array5 = new object[1];
			int num5 = 0;
			loopObj = 255;
			loopObj2 = 255;
			loopObj3 = 0;
			array5[num5] = this.RGB_Renamed(ref loopObj, ref loopObj2, ref loopObj3);
			NewLateBinding.LateSetComplex(instance5, type5, memberName5, array5, null, null, false, true);
			object instance6 = xlsStyle10.Pattern();
			Type type6 = null;
			string memberName6 = "BackgroundColor";
			object[] array6 = new object[1];
			int num6 = 0;
			loopObj3 = 170;
			loopObj2 = 255;
			loopObj = 0;
			array6[num6] = this.RGB_Renamed(ref loopObj3, ref loopObj2, ref loopObj);
			NewLateBinding.LateSetComplex(instance6, type6, memberName6, array6, null, null, false, true);
			object instance7 = xlsStyle11.Pattern();
			Type type7 = null;
			string memberName7 = "BackgroundColor";
			object[] array7 = new object[1];
			int num7 = 0;
			loopObj = 136;
			loopObj2 = 255;
			loopObj3 = 0;
			array7[num7] = this.RGB_Renamed(ref loopObj, ref loopObj2, ref loopObj3);
			NewLateBinding.LateSetComplex(instance7, type7, memberName7, array7, null, null, false, true);
			object instance8 = xlsStyle12.Pattern();
			Type type8 = null;
			string memberName8 = "BackgroundColor";
			object[] array8 = new object[1];
			int num8 = 0;
			loopObj3 = 0;
			loopObj2 = 255;
			loopObj = 0;
			array8[num8] = this.RGB_Renamed(ref loopObj3, ref loopObj2, ref loopObj);
			NewLateBinding.LateSetComplex(instance8, type8, memberName8, array8, null, null, false, true);
			Form1.StyleUnit[] array9 = new Form1.StyleUnit[9];
			array9[0].style = xlsStyle4;
			array9[0].threshold = 0.2;
			array9[1].style = xlsStyle5;
			array9[1].threshold = 0.3;
			array9[2].style = xlsStyle6;
			array9[2].threshold = 0.4;
			array9[3].style = xlsStyle7;
			array9[3].threshold = 0.5;
			array9[4].style = xlsStyle8;
			array9[4].threshold = 0.6;
			array9[5].style = xlsStyle9;
			array9[5].threshold = 0.7;
			array9[6].style = xlsStyle10;
			array9[6].threshold = 0.8;
			array9[7].style = xlsStyle11;
			array9[7].threshold = 0.9;
			array9[8].style = xlsStyle12;
			array9[8].threshold = 1.001;
			object right = Information.UBound(array9, 1);
			Form1.StyleUnit[] array10 = new Form1.StyleUnit[2];
			array10[0].style = xlsStyle3;
			array10[0].threshold = 0.9;
			array10[1].style = xlsStyle12;
			array10[1].threshold = 1.001;
			object right2 = Information.UBound(array10, 1);
			object instance9 = new object[]
			{
				0.5,
				0.44,
				0.21,
				0.1,
				0.6,
				0.33,
				0.36,
				0.25,
				0.2,
				0.45,
				0.28,
				0.27,
				0.08,
				0.17,
				0.21,
				0.01,
				0.07,
				0.08,
				0.11,
				0.31
			};
			double num9 = Conversions.ToDouble(NewLateBinding.LateIndexGet(instance9, new object[]
			{
				0
			}, null));
			double num10 = num9;
			object obj;
			object obj2;
			if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, 5, 1, ref loopObj, ref obj))
			{
				do
				{
					if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, 1, 4, 1, ref loopObj2, ref obj2))
					{
						do
						{
							double num11 = Conversions.ToDouble(NewLateBinding.LateIndexGet(instance9, new object[]
							{
								Operators.AddObject(Operators.MultiplyObject(Operators.SubtractObject(obj, 1), 4), Operators.SubtractObject(obj2, 1))
							}, null));
							if (num10 < num11)
							{
								num10 = num11;
							}
							if (num9 > num11)
							{
								num9 = num11;
							}
						}
						while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, loopObj2, ref obj2));
					}
				}
				while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, loopObj, ref obj));
			}
			xlsStyle3.Apply();
			if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, 5, 1, ref loopObj3, ref obj))
			{
				do
				{
					object loopObj4;
					if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, 1, 4, 1, ref loopObj4, ref obj2))
					{
						for (;;)
						{
							IL_822:
							double num12 = Conversions.ToDouble(NewLateBinding.LateIndexGet(instance9, new object[]
							{
								Operators.AddObject(Operators.MultiplyObject(Operators.SubtractObject(obj, 1), 4), Operators.SubtractObject(obj2, 1))
							}, null));
							double num11;
							if (num10 > num9)
							{
								num11 = (num12 - num9) / (num10 - num9);
							}
							else
							{
								num11 = 0.0;
							}
							xlsStyle3.Apply();
							object obj3 = 0;
							while (num11 > array9[Conversions.ToInteger(obj3)].threshold)
							{
								obj3 = Operators.AddObject(obj3, 1);
								if (!Operators.ConditionalCompareObjectLessEqual(obj3, right, false))
								{
									IL_8DD:
									if (!ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, loopObj4, ref obj2))
									{
										goto IL_8EC;
									}
									goto IL_822;
								}
							}
							array9[Conversions.ToInteger(obj3)].style.Apply();
							goto IL_8DD;
						}
					}
					IL_8EC:;
				}
				while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, loopObj3, ref obj));
			}
			xlsStyle3.Apply();
			object loopObj5;
			if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, 5, 1, ref loopObj5, ref obj))
			{
				do
				{
					object loopObj6;
					if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, 1, 4, 1, ref loopObj6, ref obj2))
					{
						for (;;)
						{
							IL_944:
							double num12 = Conversions.ToDouble(NewLateBinding.LateIndexGet(instance9, new object[]
							{
								Operators.AddObject(Operators.MultiplyObject(Operators.SubtractObject(obj, 1), 4), Operators.SubtractObject(obj2, 1))
							}, null));
							double num11;
							if (num10 > num9)
							{
								num11 = (num12 - num9) / (num10 - num9);
							}
							else
							{
								num11 = 0.0;
							}
							xlsStyle3.Apply();
							object obj3 = 0;
							while (num11 > array10[Conversions.ToInteger(obj3)].threshold)
							{
								obj3 = Operators.AddObject(obj3, 1);
								if (!Operators.ConditionalCompareObjectLessEqual(obj3, right2, false))
								{
									IL_9FF:
									if (!ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, loopObj6, ref obj2))
									{
										goto IL_A0E;
									}
									goto IL_944;
								}
							}
							array10[Conversions.ToInteger(obj3)].style.Apply();
							goto IL_9FF;
						}
					}
					IL_A0E:;
				}
				while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, loopObj5, ref obj));
			}
			xlsWorkbook.Close();
			Marshal.ReleaseComObject(o);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00014B90 File Offset: 0x00012D90
		public int RGB_Renamed(ref object r, ref object g, ref object b)
		{
			return Conversions.ToInteger(Operators.AddObject(Operators.AddObject(Operators.MultiplyObject(r, 65536), Operators.MultiplyObject(g, 256)), b));
		}

		// Token: 0x04000110 RID: 272
		private IContainer components2;

		// Token: 0x04000111 RID: 273
		public ToolTip ToolTip12;

		// Token: 0x04000113 RID: 275
		private IContainer components22;

		// Token: 0x04000114 RID: 276
		public ToolTip ToolTip123;

		// Token: 0x04000116 RID: 278
		private IContainer components;

		// Token: 0x04000210 RID: 528
		public ToolTip ToolTip1;

		// Token: 0x04000212 RID: 530
		private static Form1 m_vb6FormDefInstance;

		// Token: 0x04000213 RID: 531
		private static bool m_InitializingDefInstance;

		// Token: 0x0200002B RID: 43
		private struct StyleUnit
		{
			// Token: 0x04000816 RID: 2070
			public IXlsStyle style;

			// Token: 0x04000817 RID: 2071
			public double threshold;
		}
	}
}
