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
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public class Ingratek : Form
	{
		// Token: 0x06000B4D RID: 2893 RVA: 0x00038076 File Offset: 0x00036276
		public Ingratek()
		{
			base.Load += this.Ingratek_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00038098 File Offset: 0x00036298
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

		// Token: 0x06000B4F RID: 2895 RVA: 0x000380D8 File Offset: 0x000362D8
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.Button1 = new Button();
			this.Button2 = new Button();
			this.CheckedListBox1 = new CheckedListBox();
			this.DateTimePicker1 = new DateTimePicker();
			this.ComboBox1 = new ComboBox();
			this.MaskedTextBox1 = new MaskedTextBox();
			this.LinkLabel1 = new LinkLabel();
			this.Label1 = new Label();
			this.ProgressBar1 = new ProgressBar();
			this.PictureBox1 = new PictureBox();
			this.MonthCalendar1 = new MonthCalendar();
			this.MaskedTextBox2 = new MaskedTextBox();
			this.ListView1 = new ListView();
			this.DateTimePicker2 = new DateTimePicker();
			this.CheckBox1 = new CheckBox();
			this.Button3 = new Button();
			this.ComboBox2 = new ComboBox();
			this.RadioButton1 = new RadioButton();
			this.RichTextBox1 = new RichTextBox();
			this.TextBox1 = new TextBox();
			this.ToolTip1 = new ToolTip(this.components);
			this.TreeView1 = new TreeView();
			this.WebBrowser1 = new WebBrowser();
			this.PictureBox2 = new PictureBox();
			this.MaskedTextBox3 = new MaskedTextBox();
			this.ComboBox3 = new ComboBox();
			this.ComboBox4 = new ComboBox();
			this.Button4 = new Button();
			this.LinkLabel2 = new LinkLabel();
			this.LinkLabel3 = new LinkLabel();
			this.Button5 = new Button();
			this.ComboBox5 = new ComboBox();
			this.ComboBox6 = new ComboBox();
			this.MaskedTextBox4 = new MaskedTextBox();
			this.PictureBox3 = new PictureBox();
			this.WebBrowser2 = new WebBrowser();
			this.TreeView2 = new TreeView();
			this.ComboBox7 = new ComboBox();
			this.Button6 = new Button();
			this.CheckBox2 = new CheckBox();
			this.DateTimePicker3 = new DateTimePicker();
			this.ListView2 = new ListView();
			this.MonthCalendar2 = new MonthCalendar();
			this.PictureBox4 = new PictureBox();
			this.Label2 = new Label();
			this.LinkLabel4 = new LinkLabel();
			this.ComboBox8 = new ComboBox();
			this.DateTimePicker4 = new DateTimePicker();
			this.CheckedListBox2 = new CheckedListBox();
			this.Button7 = new Button();
			this.LinkLabel5 = new LinkLabel();
			this.Button8 = new Button();
			this.ComboBox9 = new ComboBox();
			this.ComboBox10 = new ComboBox();
			this.MaskedTextBox5 = new MaskedTextBox();
			this.PictureBox5 = new PictureBox();
			this.WebBrowser3 = new WebBrowser();
			this.TreeView3 = new TreeView();
			this.ComboBox11 = new ComboBox();
			this.Button9 = new Button();
			this.CheckBox3 = new CheckBox();
			this.DateTimePicker5 = new DateTimePicker();
			this.ListView3 = new ListView();
			this.MonthCalendar3 = new MonthCalendar();
			this.PictureBox6 = new PictureBox();
			this.Label3 = new Label();
			this.LinkLabel6 = new LinkLabel();
			this.ComboBox12 = new ComboBox();
			this.DateTimePicker6 = new DateTimePicker();
			this.CheckedListBox3 = new CheckedListBox();
			this.Button10 = new Button();
			this.LinkLabel7 = new LinkLabel();
			this.Button11 = new Button();
			this.ComboBox13 = new ComboBox();
			this.ComboBox14 = new ComboBox();
			this.MaskedTextBox6 = new MaskedTextBox();
			this.PictureBox7 = new PictureBox();
			this.TreeView4 = new TreeView();
			this.Button12 = new Button();
			this.MonthCalendar4 = new MonthCalendar();
			this.PictureBox8 = new PictureBox();
			this.Label4 = new Label();
			this.LinkLabel8 = new LinkLabel();
			this.ComboBox15 = new ComboBox();
			this.DateTimePicker7 = new DateTimePicker();
			this.CheckedListBox4 = new CheckedListBox();
			this.Button13 = new Button();
			this.LinkLabel9 = new LinkLabel();
			this.Button14 = new Button();
			this.ComboBox16 = new ComboBox();
			this.ComboBox17 = new ComboBox();
			this.MaskedTextBox7 = new MaskedTextBox();
			this.PictureBox9 = new PictureBox();
			this.WebBrowser4 = new WebBrowser();
			this.TreeView5 = new TreeView();
			this.Button15 = new Button();
			this.CheckBox4 = new CheckBox();
			this.DateTimePicker8 = new DateTimePicker();
			this.ListView4 = new ListView();
			this.MonthCalendar5 = new MonthCalendar();
			this.LinkLabel10 = new LinkLabel();
			this.DateTimePicker9 = new DateTimePicker();
			this.CheckedListBox5 = new CheckedListBox();
			this.Button16 = new Button();
			this.LinkLabel11 = new LinkLabel();
			this.Button17 = new Button();
			this.ComboBox18 = new ComboBox();
			this.ComboBox19 = new ComboBox();
			this.MaskedTextBox8 = new MaskedTextBox();
			this.PictureBox10 = new PictureBox();
			this.WebBrowser5 = new WebBrowser();
			this.TreeView6 = new TreeView();
			this.Button18 = new Button();
			this.CheckBox5 = new CheckBox();
			this.DateTimePicker10 = new DateTimePicker();
			this.ListView5 = new ListView();
			this.MonthCalendar6 = new MonthCalendar();
			this.PictureBox11 = new PictureBox();
			this.Label5 = new Label();
			this.LinkLabel12 = new LinkLabel();
			this.ComboBox20 = new ComboBox();
			this.DateTimePicker11 = new DateTimePicker();
			this.CheckedListBox6 = new CheckedListBox();
			this.Button19 = new Button();
			this.Button20 = new Button();
			this.LinkLabel13 = new LinkLabel();
			this.Button21 = new Button();
			this.ComboBox21 = new ComboBox();
			this.ComboBox22 = new ComboBox();
			this.MaskedTextBox9 = new MaskedTextBox();
			this.PictureBox12 = new PictureBox();
			this.TreeView7 = new TreeView();
			this.Button22 = new Button();
			this.MonthCalendar7 = new MonthCalendar();
			this.PictureBox13 = new PictureBox();
			this.Label6 = new Label();
			this.LinkLabel14 = new LinkLabel();
			this.ComboBox23 = new ComboBox();
			this.DateTimePicker12 = new DateTimePicker();
			this.CheckedListBox7 = new CheckedListBox();
			this.Button23 = new Button();
			this.LinkLabel15 = new LinkLabel();
			this.Button24 = new Button();
			this.ComboBox24 = new ComboBox();
			this.ComboBox25 = new ComboBox();
			this.MaskedTextBox10 = new MaskedTextBox();
			this.PictureBox14 = new PictureBox();
			this.WebBrowser6 = new WebBrowser();
			this.TreeView8 = new TreeView();
			this.Button25 = new Button();
			this.CheckBox6 = new CheckBox();
			this.DateTimePicker13 = new DateTimePicker();
			this.ListView6 = new ListView();
			this.MonthCalendar8 = new MonthCalendar();
			this.LinkLabel16 = new LinkLabel();
			this.DateTimePicker14 = new DateTimePicker();
			this.CheckedListBox8 = new CheckedListBox();
			this.Button26 = new Button();
			this.LinkLabel17 = new LinkLabel();
			this.Button27 = new Button();
			this.ComboBox26 = new ComboBox();
			this.ComboBox27 = new ComboBox();
			this.MaskedTextBox11 = new MaskedTextBox();
			this.PictureBox15 = new PictureBox();
			this.WebBrowser7 = new WebBrowser();
			this.TreeView9 = new TreeView();
			this.Button28 = new Button();
			this.CheckBox7 = new CheckBox();
			this.DateTimePicker15 = new DateTimePicker();
			this.ListView7 = new ListView();
			this.MonthCalendar9 = new MonthCalendar();
			this.PictureBox16 = new PictureBox();
			this.Label7 = new Label();
			this.LinkLabel18 = new LinkLabel();
			this.ComboBox28 = new ComboBox();
			this.DateTimePicker16 = new DateTimePicker();
			this.CheckedListBox9 = new CheckedListBox();
			this.Button29 = new Button();
			this.Button30 = new Button();
			this.LinkLabel19 = new LinkLabel();
			this.Button31 = new Button();
			this.ComboBox29 = new ComboBox();
			this.ComboBox30 = new ComboBox();
			this.MaskedTextBox12 = new MaskedTextBox();
			this.PictureBox17 = new PictureBox();
			this.TreeView10 = new TreeView();
			this.Button32 = new Button();
			this.MonthCalendar10 = new MonthCalendar();
			this.PictureBox18 = new PictureBox();
			this.Label8 = new Label();
			this.LinkLabel20 = new LinkLabel();
			this.ComboBox31 = new ComboBox();
			this.DateTimePicker17 = new DateTimePicker();
			this.CheckedListBox10 = new CheckedListBox();
			this.Button33 = new Button();
			this.LinkLabel21 = new LinkLabel();
			this.Button34 = new Button();
			this.ComboBox32 = new ComboBox();
			this.ComboBox33 = new ComboBox();
			this.MaskedTextBox13 = new MaskedTextBox();
			this.PictureBox19 = new PictureBox();
			this.WebBrowser8 = new WebBrowser();
			this.TreeView11 = new TreeView();
			this.Button35 = new Button();
			this.CheckBox8 = new CheckBox();
			this.DateTimePicker18 = new DateTimePicker();
			this.ListView8 = new ListView();
			this.MonthCalendar11 = new MonthCalendar();
			this.LinkLabel22 = new LinkLabel();
			this.DateTimePicker19 = new DateTimePicker();
			this.CheckedListBox11 = new CheckedListBox();
			this.Button36 = new Button();
			this.LinkLabel23 = new LinkLabel();
			this.Button37 = new Button();
			this.ComboBox34 = new ComboBox();
			this.ComboBox35 = new ComboBox();
			this.MaskedTextBox14 = new MaskedTextBox();
			this.PictureBox20 = new PictureBox();
			this.WebBrowser9 = new WebBrowser();
			this.TreeView12 = new TreeView();
			this.Button38 = new Button();
			this.CheckBox9 = new CheckBox();
			this.DateTimePicker20 = new DateTimePicker();
			this.ListView9 = new ListView();
			this.MonthCalendar12 = new MonthCalendar();
			this.PictureBox21 = new PictureBox();
			this.Label9 = new Label();
			this.LinkLabel24 = new LinkLabel();
			this.ComboBox36 = new ComboBox();
			this.DateTimePicker21 = new DateTimePicker();
			this.CheckedListBox12 = new CheckedListBox();
			this.Button39 = new Button();
			this.Button40 = new Button();
			((ISupportInitialize)this.PictureBox1).BeginInit();
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
			((ISupportInitialize)this.PictureBox16).BeginInit();
			((ISupportInitialize)this.PictureBox17).BeginInit();
			((ISupportInitialize)this.PictureBox18).BeginInit();
			((ISupportInitialize)this.PictureBox19).BeginInit();
			((ISupportInitialize)this.PictureBox20).BeginInit();
			((ISupportInitialize)this.PictureBox21).BeginInit();
			base.SuspendLayout();
			this.Button1.Location = new Point(0, 0);
			this.Button1.Name = "Button1";
			this.Button1.Size = new Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.Location = new Point(162, 134);
			this.Button2.Name = "Button2";
			this.Button2.Size = new Size(216, 81);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			this.CheckedListBox1.FormattingEnabled = true;
			this.CheckedListBox1.Location = new Point(438, 119);
			this.CheckedListBox1.Name = "CheckedListBox1";
			this.CheckedListBox1.Size = new Size(120, 94);
			this.CheckedListBox1.TabIndex = 2;
			this.DateTimePicker1.Location = new Point(276, 91);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new Size(200, 20);
			this.DateTimePicker1.TabIndex = 3;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new Point(329, 210);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new Size(8, 21);
			this.ComboBox1.TabIndex = 4;
			this.MaskedTextBox1.Location = new Point(127, 282);
			this.MaskedTextBox1.Name = "MaskedTextBox1";
			this.MaskedTextBox1.Size = new Size(100, 20);
			this.MaskedTextBox1.TabIndex = 5;
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.Location = new Point(230, 149);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new Size(59, 13);
			this.LinkLabel1.TabIndex = 6;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "LinkLabel1";
			this.Label1.AutoSize = true;
			this.Label1.Location = new Point(218, 206);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(39, 13);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "Label1";
			this.ProgressBar1.Location = new Point(303, 306);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new Size(100, 23);
			this.ProgressBar1.TabIndex = 8;
			this.PictureBox1.Location = new Point(414, 206);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new Size(82, 85);
			this.PictureBox1.TabIndex = 9;
			this.PictureBox1.TabStop = false;
			this.MonthCalendar1.Location = new Point(0, 35);
			this.MonthCalendar1.Name = "MonthCalendar1";
			this.MonthCalendar1.TabIndex = 10;
			this.MaskedTextBox2.Location = new Point(491, 289);
			this.MaskedTextBox2.Name = "MaskedTextBox2";
			this.MaskedTextBox2.Size = new Size(100, 20);
			this.MaskedTextBox2.TabIndex = 11;
			this.ListView1.HideSelection = false;
			this.ListView1.Location = new Point(654, 148);
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new Size(121, 97);
			this.ListView1.TabIndex = 12;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.DateTimePicker2.Location = new Point(552, 107);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new Size(200, 20);
			this.DateTimePicker2.TabIndex = 13;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Location = new Point(575, 72);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new Size(81, 17);
			this.CheckBox1.TabIndex = 14;
			this.CheckBox1.Text = "CheckBox1";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.Button3.Location = new Point(329, 53);
			this.Button3.Name = "Button3";
			this.Button3.Size = new Size(131, 32);
			this.Button3.TabIndex = 15;
			this.Button3.Text = "Button3";
			this.Button3.UseVisualStyleBackColor = true;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new Point(63, 256);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new Size(121, 21);
			this.ComboBox2.TabIndex = 16;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Location = new Point(74, 316);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new Size(90, 17);
			this.RadioButton1.TabIndex = 17;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "RadioButton1";
			this.RadioButton1.UseVisualStyleBackColor = true;
			this.RichTextBox1.Location = new Point(98, 342);
			this.RichTextBox1.Name = "RichTextBox1";
			this.RichTextBox1.Size = new Size(100, 96);
			this.RichTextBox1.TabIndex = 18;
			this.RichTextBox1.Text = "";
			this.TextBox1.Location = new Point(106, 350);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new Size(100, 20);
			this.TextBox1.TabIndex = 19;
			this.TreeView1.Location = new Point(0, 0);
			this.TreeView1.Name = "TreeView1";
			this.TreeView1.Size = new Size(121, 97);
			this.TreeView1.TabIndex = 20;
			this.WebBrowser1.Location = new Point(576, 3);
			this.WebBrowser1.MinimumSize = new Size(20, 20);
			this.WebBrowser1.Name = "WebBrowser1";
			this.WebBrowser1.Size = new Size(80, 58);
			this.WebBrowser1.TabIndex = 21;
			this.PictureBox2.Location = new Point(16, 16);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new Size(100, 50);
			this.PictureBox2.TabIndex = 22;
			this.PictureBox2.TabStop = false;
			this.MaskedTextBox3.Location = new Point(24, 24);
			this.MaskedTextBox3.Name = "MaskedTextBox3";
			this.MaskedTextBox3.Size = new Size(100, 20);
			this.MaskedTextBox3.TabIndex = 23;
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new Point(32, 32);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new Size(121, 21);
			this.ComboBox3.TabIndex = 24;
			this.ComboBox4.FormattingEnabled = true;
			this.ComboBox4.Location = new Point(40, 40);
			this.ComboBox4.Name = "ComboBox4";
			this.ComboBox4.Size = new Size(121, 21);
			this.ComboBox4.TabIndex = 25;
			this.Button4.Location = new Point(48, 48);
			this.Button4.Name = "Button4";
			this.Button4.Size = new Size(75, 23);
			this.Button4.TabIndex = 26;
			this.Button4.Text = "Button4";
			this.Button4.UseVisualStyleBackColor = true;
			this.LinkLabel2.AutoSize = true;
			this.LinkLabel2.Location = new Point(56, 56);
			this.LinkLabel2.Name = "LinkLabel2";
			this.LinkLabel2.Size = new Size(59, 13);
			this.LinkLabel2.TabIndex = 27;
			this.LinkLabel2.TabStop = true;
			this.LinkLabel2.Text = "LinkLabel2";
			this.LinkLabel3.AutoSize = true;
			this.LinkLabel3.Location = new Point(69, 136);
			this.LinkLabel3.Name = "LinkLabel3";
			this.LinkLabel3.Size = new Size(59, 13);
			this.LinkLabel3.TabIndex = 48;
			this.LinkLabel3.TabStop = true;
			this.LinkLabel3.Text = "LinkLabel3";
			this.Button5.Location = new Point(61, 128);
			this.Button5.Name = "Button5";
			this.Button5.Size = new Size(75, 23);
			this.Button5.TabIndex = 47;
			this.Button5.Text = "Button5";
			this.Button5.UseVisualStyleBackColor = true;
			this.ComboBox5.FormattingEnabled = true;
			this.ComboBox5.Location = new Point(53, 120);
			this.ComboBox5.Name = "ComboBox5";
			this.ComboBox5.Size = new Size(121, 21);
			this.ComboBox5.TabIndex = 46;
			this.ComboBox6.FormattingEnabled = true;
			this.ComboBox6.Location = new Point(45, 112);
			this.ComboBox6.Name = "ComboBox6";
			this.ComboBox6.Size = new Size(121, 21);
			this.ComboBox6.TabIndex = 45;
			this.MaskedTextBox4.Location = new Point(37, 104);
			this.MaskedTextBox4.Name = "MaskedTextBox4";
			this.MaskedTextBox4.Size = new Size(100, 20);
			this.MaskedTextBox4.TabIndex = 44;
			this.PictureBox3.Location = new Point(29, 96);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new Size(100, 50);
			this.PictureBox3.TabIndex = 43;
			this.PictureBox3.TabStop = false;
			this.WebBrowser2.Location = new Point(589, 83);
			this.WebBrowser2.MinimumSize = new Size(20, 20);
			this.WebBrowser2.Name = "WebBrowser2";
			this.WebBrowser2.Size = new Size(80, 58);
			this.WebBrowser2.TabIndex = 42;
			this.TreeView2.Location = new Point(13, 80);
			this.TreeView2.Name = "TreeView2";
			this.TreeView2.Size = new Size(121, 97);
			this.TreeView2.TabIndex = 41;
			this.ComboBox7.FormattingEnabled = true;
			this.ComboBox7.Location = new Point(76, 336);
			this.ComboBox7.Name = "ComboBox7";
			this.ComboBox7.Size = new Size(121, 21);
			this.ComboBox7.TabIndex = 40;
			this.Button6.Location = new Point(342, 133);
			this.Button6.Name = "Button6";
			this.Button6.Size = new Size(131, 32);
			this.Button6.TabIndex = 39;
			this.Button6.Text = "Button6";
			this.Button6.UseVisualStyleBackColor = true;
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.Location = new Point(588, 152);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new Size(81, 17);
			this.CheckBox2.TabIndex = 38;
			this.CheckBox2.Text = "CheckBox2";
			this.CheckBox2.UseVisualStyleBackColor = true;
			this.DateTimePicker3.Location = new Point(565, 187);
			this.DateTimePicker3.Name = "DateTimePicker3";
			this.DateTimePicker3.Size = new Size(200, 20);
			this.DateTimePicker3.TabIndex = 37;
			this.ListView2.HideSelection = false;
			this.ListView2.Location = new Point(667, 228);
			this.ListView2.Name = "ListView2";
			this.ListView2.Size = new Size(121, 97);
			this.ListView2.TabIndex = 36;
			this.ListView2.UseCompatibleStateImageBehavior = false;
			this.MonthCalendar2.Location = new Point(13, 115);
			this.MonthCalendar2.Name = "MonthCalendar2";
			this.MonthCalendar2.TabIndex = 35;
			this.PictureBox4.Location = new Point(427, 286);
			this.PictureBox4.Name = "PictureBox4";
			this.PictureBox4.Size = new Size(82, 85);
			this.PictureBox4.TabIndex = 34;
			this.PictureBox4.TabStop = false;
			this.Label2.AutoSize = true;
			this.Label2.Location = new Point(231, 286);
			this.Label2.Name = "Label2";
			this.Label2.Size = new Size(39, 13);
			this.Label2.TabIndex = 33;
			this.Label2.Text = "Label2";
			this.LinkLabel4.AutoSize = true;
			this.LinkLabel4.Location = new Point(243, 229);
			this.LinkLabel4.Name = "LinkLabel4";
			this.LinkLabel4.Size = new Size(59, 13);
			this.LinkLabel4.TabIndex = 32;
			this.LinkLabel4.TabStop = true;
			this.LinkLabel4.Text = "LinkLabel4";
			this.ComboBox8.FormattingEnabled = true;
			this.ComboBox8.Location = new Point(342, 290);
			this.ComboBox8.Name = "ComboBox8";
			this.ComboBox8.Size = new Size(8, 21);
			this.ComboBox8.TabIndex = 31;
			this.DateTimePicker4.Location = new Point(289, 171);
			this.DateTimePicker4.Name = "DateTimePicker4";
			this.DateTimePicker4.Size = new Size(200, 20);
			this.DateTimePicker4.TabIndex = 30;
			this.CheckedListBox2.FormattingEnabled = true;
			this.CheckedListBox2.Location = new Point(451, 199);
			this.CheckedListBox2.Name = "CheckedListBox2";
			this.CheckedListBox2.Size = new Size(120, 94);
			this.CheckedListBox2.TabIndex = 29;
			this.Button7.Location = new Point(175, 214);
			this.Button7.Name = "Button7";
			this.Button7.Size = new Size(216, 81);
			this.Button7.TabIndex = 28;
			this.Button7.Text = "Button7";
			this.Button7.UseVisualStyleBackColor = true;
			this.LinkLabel5.AutoSize = true;
			this.LinkLabel5.Location = new Point(220, 45);
			this.LinkLabel5.Name = "LinkLabel5";
			this.LinkLabel5.Size = new Size(59, 13);
			this.LinkLabel5.TabIndex = 69;
			this.LinkLabel5.TabStop = true;
			this.LinkLabel5.Text = "LinkLabel5";
			this.Button8.Location = new Point(212, 37);
			this.Button8.Name = "Button8";
			this.Button8.Size = new Size(75, 23);
			this.Button8.TabIndex = 68;
			this.Button8.Text = "Button8";
			this.Button8.UseVisualStyleBackColor = true;
			this.ComboBox9.FormattingEnabled = true;
			this.ComboBox9.Location = new Point(204, 29);
			this.ComboBox9.Name = "ComboBox9";
			this.ComboBox9.Size = new Size(121, 21);
			this.ComboBox9.TabIndex = 67;
			this.ComboBox10.FormattingEnabled = true;
			this.ComboBox10.Location = new Point(196, 21);
			this.ComboBox10.Name = "ComboBox10";
			this.ComboBox10.Size = new Size(121, 21);
			this.ComboBox10.TabIndex = 66;
			this.MaskedTextBox5.Location = new Point(188, 13);
			this.MaskedTextBox5.Name = "MaskedTextBox5";
			this.MaskedTextBox5.Size = new Size(100, 20);
			this.MaskedTextBox5.TabIndex = 65;
			this.PictureBox5.Location = new Point(180, 5);
			this.PictureBox5.Name = "PictureBox5";
			this.PictureBox5.Size = new Size(100, 50);
			this.PictureBox5.TabIndex = 64;
			this.PictureBox5.TabStop = false;
			this.WebBrowser3.Location = new Point(740, -8);
			this.WebBrowser3.MinimumSize = new Size(20, 20);
			this.WebBrowser3.Name = "WebBrowser3";
			this.WebBrowser3.Size = new Size(80, 58);
			this.WebBrowser3.TabIndex = 63;
			this.TreeView3.Location = new Point(164, -11);
			this.TreeView3.Name = "TreeView3";
			this.TreeView3.Size = new Size(121, 97);
			this.TreeView3.TabIndex = 62;
			this.ComboBox11.FormattingEnabled = true;
			this.ComboBox11.Location = new Point(227, 245);
			this.ComboBox11.Name = "ComboBox11";
			this.ComboBox11.Size = new Size(121, 21);
			this.ComboBox11.TabIndex = 61;
			this.Button9.Location = new Point(493, 42);
			this.Button9.Name = "Button9";
			this.Button9.Size = new Size(131, 32);
			this.Button9.TabIndex = 60;
			this.Button9.Text = "Button9";
			this.Button9.UseVisualStyleBackColor = true;
			this.CheckBox3.AutoSize = true;
			this.CheckBox3.Location = new Point(739, 61);
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.Size = new Size(81, 17);
			this.CheckBox3.TabIndex = 59;
			this.CheckBox3.Text = "CheckBox3";
			this.CheckBox3.UseVisualStyleBackColor = true;
			this.DateTimePicker5.Location = new Point(716, 96);
			this.DateTimePicker5.Name = "DateTimePicker5";
			this.DateTimePicker5.Size = new Size(200, 20);
			this.DateTimePicker5.TabIndex = 58;
			this.ListView3.HideSelection = false;
			this.ListView3.Location = new Point(818, 137);
			this.ListView3.Name = "ListView3";
			this.ListView3.Size = new Size(121, 97);
			this.ListView3.TabIndex = 57;
			this.ListView3.UseCompatibleStateImageBehavior = false;
			this.MonthCalendar3.Location = new Point(164, 24);
			this.MonthCalendar3.Name = "MonthCalendar3";
			this.MonthCalendar3.TabIndex = 56;
			this.PictureBox6.Location = new Point(578, 195);
			this.PictureBox6.Name = "PictureBox6";
			this.PictureBox6.Size = new Size(82, 85);
			this.PictureBox6.TabIndex = 55;
			this.PictureBox6.TabStop = false;
			this.Label3.AutoSize = true;
			this.Label3.Location = new Point(382, 195);
			this.Label3.Name = "Label3";
			this.Label3.Size = new Size(39, 13);
			this.Label3.TabIndex = 54;
			this.Label3.Text = "Label3";
			this.LinkLabel6.AutoSize = true;
			this.LinkLabel6.Location = new Point(394, 138);
			this.LinkLabel6.Name = "LinkLabel6";
			this.LinkLabel6.Size = new Size(59, 13);
			this.LinkLabel6.TabIndex = 53;
			this.LinkLabel6.TabStop = true;
			this.LinkLabel6.Text = "LinkLabel6";
			this.ComboBox12.FormattingEnabled = true;
			this.ComboBox12.Location = new Point(493, 199);
			this.ComboBox12.Name = "ComboBox12";
			this.ComboBox12.Size = new Size(8, 21);
			this.ComboBox12.TabIndex = 52;
			this.DateTimePicker6.Location = new Point(440, 80);
			this.DateTimePicker6.Name = "DateTimePicker6";
			this.DateTimePicker6.Size = new Size(200, 20);
			this.DateTimePicker6.TabIndex = 51;
			this.CheckedListBox3.FormattingEnabled = true;
			this.CheckedListBox3.Location = new Point(602, 108);
			this.CheckedListBox3.Name = "CheckedListBox3";
			this.CheckedListBox3.Size = new Size(120, 94);
			this.CheckedListBox3.TabIndex = 50;
			this.Button10.Location = new Point(326, 123);
			this.Button10.Name = "Button10";
			this.Button10.Size = new Size(216, 81);
			this.Button10.TabIndex = 49;
			this.Button10.Text = "Button10";
			this.Button10.UseVisualStyleBackColor = true;
			this.LinkLabel7.AutoSize = true;
			this.LinkLabel7.Location = new Point(226, 113);
			this.LinkLabel7.Name = "LinkLabel7";
			this.LinkLabel7.Size = new Size(59, 13);
			this.LinkLabel7.TabIndex = 123;
			this.LinkLabel7.TabStop = true;
			this.LinkLabel7.Text = "LinkLabel7";
			this.Button11.Location = new Point(218, 105);
			this.Button11.Name = "Button11";
			this.Button11.Size = new Size(75, 23);
			this.Button11.TabIndex = 122;
			this.Button11.Text = "Button11";
			this.Button11.UseVisualStyleBackColor = true;
			this.ComboBox13.FormattingEnabled = true;
			this.ComboBox13.Location = new Point(210, 97);
			this.ComboBox13.Name = "ComboBox13";
			this.ComboBox13.Size = new Size(121, 21);
			this.ComboBox13.TabIndex = 121;
			this.ComboBox14.FormattingEnabled = true;
			this.ComboBox14.Location = new Point(202, 89);
			this.ComboBox14.Name = "ComboBox14";
			this.ComboBox14.Size = new Size(121, 21);
			this.ComboBox14.TabIndex = 120;
			this.MaskedTextBox6.Location = new Point(194, 81);
			this.MaskedTextBox6.Name = "MaskedTextBox6";
			this.MaskedTextBox6.Size = new Size(100, 20);
			this.MaskedTextBox6.TabIndex = 119;
			this.PictureBox7.Location = new Point(186, 73);
			this.PictureBox7.Name = "PictureBox7";
			this.PictureBox7.Size = new Size(100, 50);
			this.PictureBox7.TabIndex = 118;
			this.PictureBox7.TabStop = false;
			this.TreeView4.Location = new Point(170, 57);
			this.TreeView4.Name = "TreeView4";
			this.TreeView4.Size = new Size(121, 97);
			this.TreeView4.TabIndex = 117;
			this.Button12.Location = new Point(499, 110);
			this.Button12.Name = "Button12";
			this.Button12.Size = new Size(131, 32);
			this.Button12.TabIndex = 116;
			this.Button12.Text = "Button12";
			this.Button12.UseVisualStyleBackColor = true;
			this.MonthCalendar4.Location = new Point(170, 92);
			this.MonthCalendar4.Name = "MonthCalendar4";
			this.MonthCalendar4.TabIndex = 115;
			this.PictureBox8.Location = new Point(584, 263);
			this.PictureBox8.Name = "PictureBox8";
			this.PictureBox8.Size = new Size(82, 85);
			this.PictureBox8.TabIndex = 114;
			this.PictureBox8.TabStop = false;
			this.Label4.AutoSize = true;
			this.Label4.Location = new Point(388, 263);
			this.Label4.Name = "Label4";
			this.Label4.Size = new Size(39, 13);
			this.Label4.TabIndex = 113;
			this.Label4.Text = "Label4";
			this.LinkLabel8.AutoSize = true;
			this.LinkLabel8.Location = new Point(400, 206);
			this.LinkLabel8.Name = "LinkLabel8";
			this.LinkLabel8.Size = new Size(59, 13);
			this.LinkLabel8.TabIndex = 112;
			this.LinkLabel8.TabStop = true;
			this.LinkLabel8.Text = "LinkLabel8";
			this.ComboBox15.FormattingEnabled = true;
			this.ComboBox15.Location = new Point(499, 267);
			this.ComboBox15.Name = "ComboBox15";
			this.ComboBox15.Size = new Size(8, 21);
			this.ComboBox15.TabIndex = 111;
			this.DateTimePicker7.Location = new Point(446, 148);
			this.DateTimePicker7.Name = "DateTimePicker7";
			this.DateTimePicker7.Size = new Size(200, 20);
			this.DateTimePicker7.TabIndex = 110;
			this.CheckedListBox4.FormattingEnabled = true;
			this.CheckedListBox4.Location = new Point(608, 176);
			this.CheckedListBox4.Name = "CheckedListBox4";
			this.CheckedListBox4.Size = new Size(120, 94);
			this.CheckedListBox4.TabIndex = 109;
			this.Button13.Location = new Point(332, 191);
			this.Button13.Name = "Button13";
			this.Button13.Size = new Size(216, 81);
			this.Button13.TabIndex = 108;
			this.Button13.Text = "Button13";
			this.Button13.UseVisualStyleBackColor = true;
			this.LinkLabel9.AutoSize = true;
			this.LinkLabel9.Location = new Point(75, 204);
			this.LinkLabel9.Name = "LinkLabel9";
			this.LinkLabel9.Size = new Size(59, 13);
			this.LinkLabel9.TabIndex = 107;
			this.LinkLabel9.TabStop = true;
			this.LinkLabel9.Text = "LinkLabel9";
			this.Button14.Location = new Point(67, 196);
			this.Button14.Name = "Button14";
			this.Button14.Size = new Size(75, 23);
			this.Button14.TabIndex = 106;
			this.Button14.Text = "Button14";
			this.Button14.UseVisualStyleBackColor = true;
			this.ComboBox16.FormattingEnabled = true;
			this.ComboBox16.Location = new Point(59, 188);
			this.ComboBox16.Name = "ComboBox16";
			this.ComboBox16.Size = new Size(121, 21);
			this.ComboBox16.TabIndex = 105;
			this.ComboBox17.FormattingEnabled = true;
			this.ComboBox17.Location = new Point(51, 180);
			this.ComboBox17.Name = "ComboBox17";
			this.ComboBox17.Size = new Size(121, 21);
			this.ComboBox17.TabIndex = 104;
			this.MaskedTextBox7.Location = new Point(43, 172);
			this.MaskedTextBox7.Name = "MaskedTextBox7";
			this.MaskedTextBox7.Size = new Size(100, 20);
			this.MaskedTextBox7.TabIndex = 103;
			this.PictureBox9.Location = new Point(35, 164);
			this.PictureBox9.Name = "PictureBox9";
			this.PictureBox9.Size = new Size(100, 50);
			this.PictureBox9.TabIndex = 102;
			this.PictureBox9.TabStop = false;
			this.WebBrowser4.Location = new Point(595, 151);
			this.WebBrowser4.MinimumSize = new Size(20, 20);
			this.WebBrowser4.Name = "WebBrowser4";
			this.WebBrowser4.Size = new Size(80, 58);
			this.WebBrowser4.TabIndex = 101;
			this.TreeView5.Location = new Point(19, 148);
			this.TreeView5.Name = "TreeView5";
			this.TreeView5.Size = new Size(121, 97);
			this.TreeView5.TabIndex = 100;
			this.Button15.Location = new Point(348, 201);
			this.Button15.Name = "Button15";
			this.Button15.Size = new Size(131, 32);
			this.Button15.TabIndex = 99;
			this.Button15.Text = "Button15";
			this.Button15.UseVisualStyleBackColor = true;
			this.CheckBox4.AutoSize = true;
			this.CheckBox4.Location = new Point(594, 220);
			this.CheckBox4.Name = "CheckBox4";
			this.CheckBox4.Size = new Size(81, 17);
			this.CheckBox4.TabIndex = 98;
			this.CheckBox4.Text = "CheckBox4";
			this.CheckBox4.UseVisualStyleBackColor = true;
			this.DateTimePicker8.Location = new Point(571, 255);
			this.DateTimePicker8.Name = "DateTimePicker8";
			this.DateTimePicker8.Size = new Size(200, 20);
			this.DateTimePicker8.TabIndex = 97;
			this.ListView4.HideSelection = false;
			this.ListView4.Location = new Point(673, 296);
			this.ListView4.Name = "ListView4";
			this.ListView4.Size = new Size(121, 97);
			this.ListView4.TabIndex = 96;
			this.ListView4.UseCompatibleStateImageBehavior = false;
			this.MonthCalendar5.Location = new Point(19, 183);
			this.MonthCalendar5.Name = "MonthCalendar5";
			this.MonthCalendar5.TabIndex = 95;
			this.LinkLabel10.AutoSize = true;
			this.LinkLabel10.Location = new Point(249, 297);
			this.LinkLabel10.Name = "LinkLabel10";
			this.LinkLabel10.Size = new Size(65, 13);
			this.LinkLabel10.TabIndex = 94;
			this.LinkLabel10.TabStop = true;
			this.LinkLabel10.Text = "LinkLabel10";
			this.DateTimePicker9.Location = new Point(295, 239);
			this.DateTimePicker9.Name = "DateTimePicker9";
			this.DateTimePicker9.Size = new Size(200, 20);
			this.DateTimePicker9.TabIndex = 93;
			this.CheckedListBox5.FormattingEnabled = true;
			this.CheckedListBox5.Location = new Point(457, 267);
			this.CheckedListBox5.Name = "CheckedListBox5";
			this.CheckedListBox5.Size = new Size(120, 94);
			this.CheckedListBox5.TabIndex = 92;
			this.Button16.Location = new Point(181, 282);
			this.Button16.Name = "Button16";
			this.Button16.Size = new Size(216, 81);
			this.Button16.TabIndex = 91;
			this.Button16.Text = "Button16";
			this.Button16.UseVisualStyleBackColor = true;
			this.LinkLabel11.AutoSize = true;
			this.LinkLabel11.Location = new Point(62, 124);
			this.LinkLabel11.Name = "LinkLabel11";
			this.LinkLabel11.Size = new Size(65, 13);
			this.LinkLabel11.TabIndex = 90;
			this.LinkLabel11.TabStop = true;
			this.LinkLabel11.Text = "LinkLabel11";
			this.Button17.Location = new Point(54, 116);
			this.Button17.Name = "Button17";
			this.Button17.Size = new Size(75, 23);
			this.Button17.TabIndex = 89;
			this.Button17.Text = "Button17";
			this.Button17.UseVisualStyleBackColor = true;
			this.ComboBox18.FormattingEnabled = true;
			this.ComboBox18.Location = new Point(46, 108);
			this.ComboBox18.Name = "ComboBox18";
			this.ComboBox18.Size = new Size(121, 21);
			this.ComboBox18.TabIndex = 88;
			this.ComboBox19.FormattingEnabled = true;
			this.ComboBox19.Location = new Point(38, 100);
			this.ComboBox19.Name = "ComboBox19";
			this.ComboBox19.Size = new Size(121, 21);
			this.ComboBox19.TabIndex = 87;
			this.MaskedTextBox8.Location = new Point(30, 92);
			this.MaskedTextBox8.Name = "MaskedTextBox8";
			this.MaskedTextBox8.Size = new Size(100, 20);
			this.MaskedTextBox8.TabIndex = 86;
			this.PictureBox10.Location = new Point(22, 84);
			this.PictureBox10.Name = "PictureBox10";
			this.PictureBox10.Size = new Size(100, 50);
			this.PictureBox10.TabIndex = 85;
			this.PictureBox10.TabStop = false;
			this.WebBrowser5.Location = new Point(582, 71);
			this.WebBrowser5.MinimumSize = new Size(20, 20);
			this.WebBrowser5.Name = "WebBrowser5";
			this.WebBrowser5.Size = new Size(80, 58);
			this.WebBrowser5.TabIndex = 84;
			this.TreeView6.Location = new Point(6, 68);
			this.TreeView6.Name = "TreeView6";
			this.TreeView6.Size = new Size(121, 97);
			this.TreeView6.TabIndex = 83;
			this.Button18.Location = new Point(335, 121);
			this.Button18.Name = "Button18";
			this.Button18.Size = new Size(131, 32);
			this.Button18.TabIndex = 82;
			this.Button18.Text = "Button18";
			this.Button18.UseVisualStyleBackColor = true;
			this.CheckBox5.AutoSize = true;
			this.CheckBox5.Location = new Point(581, 140);
			this.CheckBox5.Name = "CheckBox5";
			this.CheckBox5.Size = new Size(81, 17);
			this.CheckBox5.TabIndex = 81;
			this.CheckBox5.Text = "CheckBox5";
			this.CheckBox5.UseVisualStyleBackColor = true;
			this.DateTimePicker10.Location = new Point(558, 175);
			this.DateTimePicker10.Name = "DateTimePicker10";
			this.DateTimePicker10.Size = new Size(200, 20);
			this.DateTimePicker10.TabIndex = 80;
			this.ListView5.HideSelection = false;
			this.ListView5.Location = new Point(660, 216);
			this.ListView5.Name = "ListView5";
			this.ListView5.Size = new Size(121, 97);
			this.ListView5.TabIndex = 79;
			this.ListView5.UseCompatibleStateImageBehavior = false;
			this.MonthCalendar6.Location = new Point(6, 103);
			this.MonthCalendar6.Name = "MonthCalendar6";
			this.MonthCalendar6.TabIndex = 78;
			this.PictureBox11.Location = new Point(420, 274);
			this.PictureBox11.Name = "PictureBox11";
			this.PictureBox11.Size = new Size(82, 85);
			this.PictureBox11.TabIndex = 77;
			this.PictureBox11.TabStop = false;
			this.Label5.AutoSize = true;
			this.Label5.Location = new Point(224, 274);
			this.Label5.Name = "Label5";
			this.Label5.Size = new Size(39, 13);
			this.Label5.TabIndex = 76;
			this.Label5.Text = "Label5";
			this.LinkLabel12.AutoSize = true;
			this.LinkLabel12.Location = new Point(236, 217);
			this.LinkLabel12.Name = "LinkLabel12";
			this.LinkLabel12.Size = new Size(65, 13);
			this.LinkLabel12.TabIndex = 75;
			this.LinkLabel12.TabStop = true;
			this.LinkLabel12.Text = "LinkLabel12";
			this.ComboBox20.FormattingEnabled = true;
			this.ComboBox20.Location = new Point(335, 278);
			this.ComboBox20.Name = "ComboBox20";
			this.ComboBox20.Size = new Size(8, 21);
			this.ComboBox20.TabIndex = 74;
			this.DateTimePicker11.Location = new Point(282, 159);
			this.DateTimePicker11.Name = "DateTimePicker11";
			this.DateTimePicker11.Size = new Size(200, 20);
			this.DateTimePicker11.TabIndex = 73;
			this.CheckedListBox6.FormattingEnabled = true;
			this.CheckedListBox6.Location = new Point(444, 187);
			this.CheckedListBox6.Name = "CheckedListBox6";
			this.CheckedListBox6.Size = new Size(120, 94);
			this.CheckedListBox6.TabIndex = 72;
			this.Button19.Location = new Point(168, 202);
			this.Button19.Name = "Button19";
			this.Button19.Size = new Size(216, 81);
			this.Button19.TabIndex = 71;
			this.Button19.Text = "Button19";
			this.Button19.UseVisualStyleBackColor = true;
			this.Button20.Location = new Point(6, 68);
			this.Button20.Name = "Button20";
			this.Button20.Size = new Size(75, 23);
			this.Button20.TabIndex = 70;
			this.Button20.Text = "Button20";
			this.Button20.UseVisualStyleBackColor = true;
			this.LinkLabel13.AutoSize = true;
			this.LinkLabel13.Location = new Point(229, 34);
			this.LinkLabel13.Name = "LinkLabel13";
			this.LinkLabel13.Size = new Size(65, 13);
			this.LinkLabel13.TabIndex = 177;
			this.LinkLabel13.TabStop = true;
			this.LinkLabel13.Text = "LinkLabel13";
			this.Button21.Location = new Point(221, 26);
			this.Button21.Name = "Button21";
			this.Button21.Size = new Size(75, 23);
			this.Button21.TabIndex = 176;
			this.Button21.Text = "Button21";
			this.Button21.UseVisualStyleBackColor = true;
			this.ComboBox21.FormattingEnabled = true;
			this.ComboBox21.Location = new Point(213, 18);
			this.ComboBox21.Name = "ComboBox21";
			this.ComboBox21.Size = new Size(121, 21);
			this.ComboBox21.TabIndex = 175;
			this.ComboBox22.FormattingEnabled = true;
			this.ComboBox22.Location = new Point(205, 10);
			this.ComboBox22.Name = "ComboBox22";
			this.ComboBox22.Size = new Size(121, 21);
			this.ComboBox22.TabIndex = 174;
			this.MaskedTextBox9.Location = new Point(197, 2);
			this.MaskedTextBox9.Name = "MaskedTextBox9";
			this.MaskedTextBox9.Size = new Size(100, 20);
			this.MaskedTextBox9.TabIndex = 173;
			this.PictureBox12.Location = new Point(189, -6);
			this.PictureBox12.Name = "PictureBox12";
			this.PictureBox12.Size = new Size(100, 50);
			this.PictureBox12.TabIndex = 172;
			this.PictureBox12.TabStop = false;
			this.TreeView7.Location = new Point(173, -22);
			this.TreeView7.Name = "TreeView7";
			this.TreeView7.Size = new Size(121, 97);
			this.TreeView7.TabIndex = 171;
			this.Button22.Location = new Point(502, 31);
			this.Button22.Name = "Button22";
			this.Button22.Size = new Size(131, 32);
			this.Button22.TabIndex = 170;
			this.Button22.Text = "Button22";
			this.Button22.UseVisualStyleBackColor = true;
			this.MonthCalendar7.Location = new Point(173, 13);
			this.MonthCalendar7.Name = "MonthCalendar7";
			this.MonthCalendar7.TabIndex = 169;
			this.PictureBox13.Location = new Point(587, 184);
			this.PictureBox13.Name = "PictureBox13";
			this.PictureBox13.Size = new Size(82, 85);
			this.PictureBox13.TabIndex = 168;
			this.PictureBox13.TabStop = false;
			this.Label6.AutoSize = true;
			this.Label6.Location = new Point(391, 184);
			this.Label6.Name = "Label6";
			this.Label6.Size = new Size(39, 13);
			this.Label6.TabIndex = 167;
			this.Label6.Text = "Label6";
			this.LinkLabel14.AutoSize = true;
			this.LinkLabel14.Location = new Point(403, 127);
			this.LinkLabel14.Name = "LinkLabel14";
			this.LinkLabel14.Size = new Size(65, 13);
			this.LinkLabel14.TabIndex = 166;
			this.LinkLabel14.TabStop = true;
			this.LinkLabel14.Text = "LinkLabel14";
			this.ComboBox23.FormattingEnabled = true;
			this.ComboBox23.Location = new Point(502, 188);
			this.ComboBox23.Name = "ComboBox23";
			this.ComboBox23.Size = new Size(8, 21);
			this.ComboBox23.TabIndex = 165;
			this.DateTimePicker12.Location = new Point(449, 69);
			this.DateTimePicker12.Name = "DateTimePicker12";
			this.DateTimePicker12.Size = new Size(200, 20);
			this.DateTimePicker12.TabIndex = 164;
			this.CheckedListBox7.FormattingEnabled = true;
			this.CheckedListBox7.Location = new Point(611, 97);
			this.CheckedListBox7.Name = "CheckedListBox7";
			this.CheckedListBox7.Size = new Size(120, 94);
			this.CheckedListBox7.TabIndex = 163;
			this.Button23.Location = new Point(335, 112);
			this.Button23.Name = "Button23";
			this.Button23.Size = new Size(216, 81);
			this.Button23.TabIndex = 162;
			this.Button23.Text = "Button23";
			this.Button23.UseVisualStyleBackColor = true;
			this.LinkLabel15.AutoSize = true;
			this.LinkLabel15.Location = new Point(78, 125);
			this.LinkLabel15.Name = "LinkLabel15";
			this.LinkLabel15.Size = new Size(65, 13);
			this.LinkLabel15.TabIndex = 161;
			this.LinkLabel15.TabStop = true;
			this.LinkLabel15.Text = "LinkLabel15";
			this.Button24.Location = new Point(70, 117);
			this.Button24.Name = "Button24";
			this.Button24.Size = new Size(75, 23);
			this.Button24.TabIndex = 160;
			this.Button24.Text = "Button24";
			this.Button24.UseVisualStyleBackColor = true;
			this.ComboBox24.FormattingEnabled = true;
			this.ComboBox24.Location = new Point(62, 109);
			this.ComboBox24.Name = "ComboBox24";
			this.ComboBox24.Size = new Size(121, 21);
			this.ComboBox24.TabIndex = 159;
			this.ComboBox25.FormattingEnabled = true;
			this.ComboBox25.Location = new Point(54, 101);
			this.ComboBox25.Name = "ComboBox25";
			this.ComboBox25.Size = new Size(121, 21);
			this.ComboBox25.TabIndex = 158;
			this.MaskedTextBox10.Location = new Point(46, 93);
			this.MaskedTextBox10.Name = "MaskedTextBox10";
			this.MaskedTextBox10.Size = new Size(100, 20);
			this.MaskedTextBox10.TabIndex = 157;
			this.PictureBox14.Location = new Point(38, 85);
			this.PictureBox14.Name = "PictureBox14";
			this.PictureBox14.Size = new Size(100, 50);
			this.PictureBox14.TabIndex = 156;
			this.PictureBox14.TabStop = false;
			this.WebBrowser6.Location = new Point(598, 72);
			this.WebBrowser6.MinimumSize = new Size(20, 20);
			this.WebBrowser6.Name = "WebBrowser6";
			this.WebBrowser6.Size = new Size(80, 58);
			this.WebBrowser6.TabIndex = 155;
			this.TreeView8.Location = new Point(22, 69);
			this.TreeView8.Name = "TreeView8";
			this.TreeView8.Size = new Size(121, 97);
			this.TreeView8.TabIndex = 154;
			this.Button25.Location = new Point(351, 122);
			this.Button25.Name = "Button25";
			this.Button25.Size = new Size(131, 32);
			this.Button25.TabIndex = 153;
			this.Button25.Text = "Button25";
			this.Button25.UseVisualStyleBackColor = true;
			this.CheckBox6.AutoSize = true;
			this.CheckBox6.Location = new Point(597, 141);
			this.CheckBox6.Name = "CheckBox6";
			this.CheckBox6.Size = new Size(81, 17);
			this.CheckBox6.TabIndex = 152;
			this.CheckBox6.Text = "CheckBox6";
			this.CheckBox6.UseVisualStyleBackColor = true;
			this.DateTimePicker13.Location = new Point(574, 176);
			this.DateTimePicker13.Name = "DateTimePicker13";
			this.DateTimePicker13.Size = new Size(200, 20);
			this.DateTimePicker13.TabIndex = 151;
			this.ListView6.HideSelection = false;
			this.ListView6.Location = new Point(676, 217);
			this.ListView6.Name = "ListView6";
			this.ListView6.Size = new Size(121, 97);
			this.ListView6.TabIndex = 150;
			this.ListView6.UseCompatibleStateImageBehavior = false;
			this.MonthCalendar8.Location = new Point(22, 104);
			this.MonthCalendar8.Name = "MonthCalendar8";
			this.MonthCalendar8.TabIndex = 149;
			this.LinkLabel16.AutoSize = true;
			this.LinkLabel16.Location = new Point(252, 218);
			this.LinkLabel16.Name = "LinkLabel16";
			this.LinkLabel16.Size = new Size(65, 13);
			this.LinkLabel16.TabIndex = 148;
			this.LinkLabel16.TabStop = true;
			this.LinkLabel16.Text = "LinkLabel16";
			this.DateTimePicker14.Location = new Point(298, 160);
			this.DateTimePicker14.Name = "DateTimePicker14";
			this.DateTimePicker14.Size = new Size(200, 20);
			this.DateTimePicker14.TabIndex = 147;
			this.CheckedListBox8.FormattingEnabled = true;
			this.CheckedListBox8.Location = new Point(460, 188);
			this.CheckedListBox8.Name = "CheckedListBox8";
			this.CheckedListBox8.Size = new Size(120, 94);
			this.CheckedListBox8.TabIndex = 146;
			this.Button26.Location = new Point(184, 203);
			this.Button26.Name = "Button26";
			this.Button26.Size = new Size(216, 81);
			this.Button26.TabIndex = 145;
			this.Button26.Text = "Button26";
			this.Button26.UseVisualStyleBackColor = true;
			this.LinkLabel17.AutoSize = true;
			this.LinkLabel17.Location = new Point(65, 45);
			this.LinkLabel17.Name = "LinkLabel17";
			this.LinkLabel17.Size = new Size(65, 13);
			this.LinkLabel17.TabIndex = 144;
			this.LinkLabel17.TabStop = true;
			this.LinkLabel17.Text = "LinkLabel17";
			this.Button27.Location = new Point(57, 37);
			this.Button27.Name = "Button27";
			this.Button27.Size = new Size(75, 23);
			this.Button27.TabIndex = 143;
			this.Button27.Text = "Button27";
			this.Button27.UseVisualStyleBackColor = true;
			this.ComboBox26.FormattingEnabled = true;
			this.ComboBox26.Location = new Point(49, 29);
			this.ComboBox26.Name = "ComboBox26";
			this.ComboBox26.Size = new Size(121, 21);
			this.ComboBox26.TabIndex = 142;
			this.ComboBox27.FormattingEnabled = true;
			this.ComboBox27.Location = new Point(41, 21);
			this.ComboBox27.Name = "ComboBox27";
			this.ComboBox27.Size = new Size(121, 21);
			this.ComboBox27.TabIndex = 141;
			this.MaskedTextBox11.Location = new Point(33, 13);
			this.MaskedTextBox11.Name = "MaskedTextBox11";
			this.MaskedTextBox11.Size = new Size(100, 20);
			this.MaskedTextBox11.TabIndex = 140;
			this.PictureBox15.Location = new Point(25, 5);
			this.PictureBox15.Name = "PictureBox15";
			this.PictureBox15.Size = new Size(100, 50);
			this.PictureBox15.TabIndex = 139;
			this.PictureBox15.TabStop = false;
			this.WebBrowser7.Location = new Point(585, -8);
			this.WebBrowser7.MinimumSize = new Size(20, 20);
			this.WebBrowser7.Name = "WebBrowser7";
			this.WebBrowser7.Size = new Size(80, 58);
			this.WebBrowser7.TabIndex = 138;
			this.TreeView9.Location = new Point(9, -11);
			this.TreeView9.Name = "TreeView9";
			this.TreeView9.Size = new Size(121, 97);
			this.TreeView9.TabIndex = 137;
			this.Button28.Location = new Point(338, 42);
			this.Button28.Name = "Button28";
			this.Button28.Size = new Size(131, 32);
			this.Button28.TabIndex = 136;
			this.Button28.Text = "Button28";
			this.Button28.UseVisualStyleBackColor = true;
			this.CheckBox7.AutoSize = true;
			this.CheckBox7.Location = new Point(584, 61);
			this.CheckBox7.Name = "CheckBox7";
			this.CheckBox7.Size = new Size(81, 17);
			this.CheckBox7.TabIndex = 135;
			this.CheckBox7.Text = "CheckBox7";
			this.CheckBox7.UseVisualStyleBackColor = true;
			this.DateTimePicker15.Location = new Point(561, 96);
			this.DateTimePicker15.Name = "DateTimePicker15";
			this.DateTimePicker15.Size = new Size(200, 20);
			this.DateTimePicker15.TabIndex = 134;
			this.ListView7.HideSelection = false;
			this.ListView7.Location = new Point(663, 137);
			this.ListView7.Name = "ListView7";
			this.ListView7.Size = new Size(121, 97);
			this.ListView7.TabIndex = 133;
			this.ListView7.UseCompatibleStateImageBehavior = false;
			this.MonthCalendar9.Location = new Point(9, 24);
			this.MonthCalendar9.Name = "MonthCalendar9";
			this.MonthCalendar9.TabIndex = 132;
			this.PictureBox16.Location = new Point(423, 195);
			this.PictureBox16.Name = "PictureBox16";
			this.PictureBox16.Size = new Size(82, 85);
			this.PictureBox16.TabIndex = 131;
			this.PictureBox16.TabStop = false;
			this.Label7.AutoSize = true;
			this.Label7.Location = new Point(227, 195);
			this.Label7.Name = "Label7";
			this.Label7.Size = new Size(39, 13);
			this.Label7.TabIndex = 130;
			this.Label7.Text = "Label7";
			this.LinkLabel18.AutoSize = true;
			this.LinkLabel18.Location = new Point(239, 138);
			this.LinkLabel18.Name = "LinkLabel18";
			this.LinkLabel18.Size = new Size(65, 13);
			this.LinkLabel18.TabIndex = 129;
			this.LinkLabel18.TabStop = true;
			this.LinkLabel18.Text = "LinkLabel18";
			this.ComboBox28.FormattingEnabled = true;
			this.ComboBox28.Location = new Point(338, 199);
			this.ComboBox28.Name = "ComboBox28";
			this.ComboBox28.Size = new Size(8, 21);
			this.ComboBox28.TabIndex = 128;
			this.DateTimePicker16.Location = new Point(285, 80);
			this.DateTimePicker16.Name = "DateTimePicker16";
			this.DateTimePicker16.Size = new Size(200, 20);
			this.DateTimePicker16.TabIndex = 127;
			this.CheckedListBox9.FormattingEnabled = true;
			this.CheckedListBox9.Location = new Point(447, 108);
			this.CheckedListBox9.Name = "CheckedListBox9";
			this.CheckedListBox9.Size = new Size(120, 94);
			this.CheckedListBox9.TabIndex = 126;
			this.Button29.Location = new Point(171, 123);
			this.Button29.Name = "Button29";
			this.Button29.Size = new Size(216, 81);
			this.Button29.TabIndex = 125;
			this.Button29.Text = "Button29";
			this.Button29.UseVisualStyleBackColor = true;
			this.Button30.Location = new Point(9, -11);
			this.Button30.Name = "Button30";
			this.Button30.Size = new Size(75, 23);
			this.Button30.TabIndex = 124;
			this.Button30.Text = "Button30";
			this.Button30.UseVisualStyleBackColor = true;
			this.LinkLabel19.AutoSize = true;
			this.LinkLabel19.Location = new Point(226, 113);
			this.LinkLabel19.Name = "LinkLabel19";
			this.LinkLabel19.Size = new Size(65, 13);
			this.LinkLabel19.TabIndex = 231;
			this.LinkLabel19.TabStop = true;
			this.LinkLabel19.Text = "LinkLabel19";
			this.Button31.Location = new Point(218, 105);
			this.Button31.Name = "Button31";
			this.Button31.Size = new Size(75, 23);
			this.Button31.TabIndex = 230;
			this.Button31.Text = "Button31";
			this.Button31.UseVisualStyleBackColor = true;
			this.ComboBox29.FormattingEnabled = true;
			this.ComboBox29.Location = new Point(210, 97);
			this.ComboBox29.Name = "ComboBox29";
			this.ComboBox29.Size = new Size(121, 21);
			this.ComboBox29.TabIndex = 229;
			this.ComboBox30.FormattingEnabled = true;
			this.ComboBox30.Location = new Point(202, 89);
			this.ComboBox30.Name = "ComboBox30";
			this.ComboBox30.Size = new Size(121, 21);
			this.ComboBox30.TabIndex = 228;
			this.MaskedTextBox12.Location = new Point(194, 81);
			this.MaskedTextBox12.Name = "MaskedTextBox12";
			this.MaskedTextBox12.Size = new Size(100, 20);
			this.MaskedTextBox12.TabIndex = 227;
			this.PictureBox17.Location = new Point(186, 73);
			this.PictureBox17.Name = "PictureBox17";
			this.PictureBox17.Size = new Size(100, 50);
			this.PictureBox17.TabIndex = 226;
			this.PictureBox17.TabStop = false;
			this.TreeView10.Location = new Point(170, 57);
			this.TreeView10.Name = "TreeView10";
			this.TreeView10.Size = new Size(121, 97);
			this.TreeView10.TabIndex = 225;
			this.Button32.Location = new Point(499, 110);
			this.Button32.Name = "Button32";
			this.Button32.Size = new Size(131, 32);
			this.Button32.TabIndex = 224;
			this.Button32.Text = "Button32";
			this.Button32.UseVisualStyleBackColor = true;
			this.MonthCalendar10.Location = new Point(170, 92);
			this.MonthCalendar10.Name = "MonthCalendar10";
			this.MonthCalendar10.TabIndex = 223;
			this.PictureBox18.Location = new Point(584, 263);
			this.PictureBox18.Name = "PictureBox18";
			this.PictureBox18.Size = new Size(82, 85);
			this.PictureBox18.TabIndex = 222;
			this.PictureBox18.TabStop = false;
			this.Label8.AutoSize = true;
			this.Label8.Location = new Point(388, 263);
			this.Label8.Name = "Label8";
			this.Label8.Size = new Size(39, 13);
			this.Label8.TabIndex = 221;
			this.Label8.Text = "Label8";
			this.LinkLabel20.AutoSize = true;
			this.LinkLabel20.Location = new Point(400, 206);
			this.LinkLabel20.Name = "LinkLabel20";
			this.LinkLabel20.Size = new Size(65, 13);
			this.LinkLabel20.TabIndex = 220;
			this.LinkLabel20.TabStop = true;
			this.LinkLabel20.Text = "LinkLabel20";
			this.ComboBox31.FormattingEnabled = true;
			this.ComboBox31.Location = new Point(499, 267);
			this.ComboBox31.Name = "ComboBox31";
			this.ComboBox31.Size = new Size(8, 21);
			this.ComboBox31.TabIndex = 219;
			this.DateTimePicker17.Location = new Point(446, 148);
			this.DateTimePicker17.Name = "DateTimePicker17";
			this.DateTimePicker17.Size = new Size(200, 20);
			this.DateTimePicker17.TabIndex = 218;
			this.CheckedListBox10.FormattingEnabled = true;
			this.CheckedListBox10.Location = new Point(608, 176);
			this.CheckedListBox10.Name = "CheckedListBox10";
			this.CheckedListBox10.Size = new Size(120, 94);
			this.CheckedListBox10.TabIndex = 217;
			this.Button33.Location = new Point(332, 191);
			this.Button33.Name = "Button33";
			this.Button33.Size = new Size(216, 81);
			this.Button33.TabIndex = 216;
			this.Button33.Text = "Button33";
			this.Button33.UseVisualStyleBackColor = true;
			this.LinkLabel21.AutoSize = true;
			this.LinkLabel21.Location = new Point(75, 204);
			this.LinkLabel21.Name = "LinkLabel21";
			this.LinkLabel21.Size = new Size(65, 13);
			this.LinkLabel21.TabIndex = 215;
			this.LinkLabel21.TabStop = true;
			this.LinkLabel21.Text = "LinkLabel21";
			this.Button34.Location = new Point(67, 196);
			this.Button34.Name = "Button34";
			this.Button34.Size = new Size(75, 23);
			this.Button34.TabIndex = 214;
			this.Button34.Text = "Button34";
			this.Button34.UseVisualStyleBackColor = true;
			this.ComboBox32.FormattingEnabled = true;
			this.ComboBox32.Location = new Point(59, 188);
			this.ComboBox32.Name = "ComboBox32";
			this.ComboBox32.Size = new Size(121, 21);
			this.ComboBox32.TabIndex = 213;
			this.ComboBox33.FormattingEnabled = true;
			this.ComboBox33.Location = new Point(51, 180);
			this.ComboBox33.Name = "ComboBox33";
			this.ComboBox33.Size = new Size(121, 21);
			this.ComboBox33.TabIndex = 212;
			this.MaskedTextBox13.Location = new Point(43, 172);
			this.MaskedTextBox13.Name = "MaskedTextBox13";
			this.MaskedTextBox13.Size = new Size(100, 20);
			this.MaskedTextBox13.TabIndex = 211;
			this.PictureBox19.Location = new Point(35, 164);
			this.PictureBox19.Name = "PictureBox19";
			this.PictureBox19.Size = new Size(100, 50);
			this.PictureBox19.TabIndex = 210;
			this.PictureBox19.TabStop = false;
			this.WebBrowser8.Location = new Point(595, 151);
			this.WebBrowser8.MinimumSize = new Size(20, 20);
			this.WebBrowser8.Name = "WebBrowser8";
			this.WebBrowser8.Size = new Size(80, 58);
			this.WebBrowser8.TabIndex = 209;
			this.TreeView11.Location = new Point(19, 148);
			this.TreeView11.Name = "TreeView11";
			this.TreeView11.Size = new Size(121, 97);
			this.TreeView11.TabIndex = 208;
			this.Button35.Location = new Point(348, 201);
			this.Button35.Name = "Button35";
			this.Button35.Size = new Size(131, 32);
			this.Button35.TabIndex = 207;
			this.Button35.Text = "Button35";
			this.Button35.UseVisualStyleBackColor = true;
			this.CheckBox8.AutoSize = true;
			this.CheckBox8.Location = new Point(594, 220);
			this.CheckBox8.Name = "CheckBox8";
			this.CheckBox8.Size = new Size(81, 17);
			this.CheckBox8.TabIndex = 206;
			this.CheckBox8.Text = "CheckBox8";
			this.CheckBox8.UseVisualStyleBackColor = true;
			this.DateTimePicker18.Location = new Point(571, 255);
			this.DateTimePicker18.Name = "DateTimePicker18";
			this.DateTimePicker18.Size = new Size(200, 20);
			this.DateTimePicker18.TabIndex = 205;
			this.ListView8.HideSelection = false;
			this.ListView8.Location = new Point(673, 296);
			this.ListView8.Name = "ListView8";
			this.ListView8.Size = new Size(121, 97);
			this.ListView8.TabIndex = 204;
			this.ListView8.UseCompatibleStateImageBehavior = false;
			this.MonthCalendar11.Location = new Point(19, 183);
			this.MonthCalendar11.Name = "MonthCalendar11";
			this.MonthCalendar11.TabIndex = 203;
			this.LinkLabel22.AutoSize = true;
			this.LinkLabel22.Location = new Point(249, 297);
			this.LinkLabel22.Name = "LinkLabel22";
			this.LinkLabel22.Size = new Size(65, 13);
			this.LinkLabel22.TabIndex = 202;
			this.LinkLabel22.TabStop = true;
			this.LinkLabel22.Text = "LinkLabel22";
			this.DateTimePicker19.Location = new Point(295, 239);
			this.DateTimePicker19.Name = "DateTimePicker19";
			this.DateTimePicker19.Size = new Size(200, 20);
			this.DateTimePicker19.TabIndex = 201;
			this.CheckedListBox11.FormattingEnabled = true;
			this.CheckedListBox11.Location = new Point(457, 267);
			this.CheckedListBox11.Name = "CheckedListBox11";
			this.CheckedListBox11.Size = new Size(120, 94);
			this.CheckedListBox11.TabIndex = 200;
			this.Button36.Location = new Point(181, 282);
			this.Button36.Name = "Button36";
			this.Button36.Size = new Size(216, 81);
			this.Button36.TabIndex = 199;
			this.Button36.Text = "Button36";
			this.Button36.UseVisualStyleBackColor = true;
			this.LinkLabel23.AutoSize = true;
			this.LinkLabel23.Location = new Point(62, 124);
			this.LinkLabel23.Name = "LinkLabel23";
			this.LinkLabel23.Size = new Size(65, 13);
			this.LinkLabel23.TabIndex = 198;
			this.LinkLabel23.TabStop = true;
			this.LinkLabel23.Text = "LinkLabel23";
			this.Button37.Location = new Point(54, 116);
			this.Button37.Name = "Button37";
			this.Button37.Size = new Size(75, 23);
			this.Button37.TabIndex = 197;
			this.Button37.Text = "Button37";
			this.Button37.UseVisualStyleBackColor = true;
			this.ComboBox34.FormattingEnabled = true;
			this.ComboBox34.Location = new Point(46, 108);
			this.ComboBox34.Name = "ComboBox34";
			this.ComboBox34.Size = new Size(121, 21);
			this.ComboBox34.TabIndex = 196;
			this.ComboBox35.FormattingEnabled = true;
			this.ComboBox35.Location = new Point(38, 100);
			this.ComboBox35.Name = "ComboBox35";
			this.ComboBox35.Size = new Size(121, 21);
			this.ComboBox35.TabIndex = 195;
			this.MaskedTextBox14.Location = new Point(30, 92);
			this.MaskedTextBox14.Name = "MaskedTextBox14";
			this.MaskedTextBox14.Size = new Size(100, 20);
			this.MaskedTextBox14.TabIndex = 194;
			this.PictureBox20.Location = new Point(22, 84);
			this.PictureBox20.Name = "PictureBox20";
			this.PictureBox20.Size = new Size(100, 50);
			this.PictureBox20.TabIndex = 193;
			this.PictureBox20.TabStop = false;
			this.WebBrowser9.Location = new Point(582, 71);
			this.WebBrowser9.MinimumSize = new Size(20, 20);
			this.WebBrowser9.Name = "WebBrowser9";
			this.WebBrowser9.Size = new Size(80, 58);
			this.WebBrowser9.TabIndex = 192;
			this.TreeView12.Location = new Point(6, 68);
			this.TreeView12.Name = "TreeView12";
			this.TreeView12.Size = new Size(121, 97);
			this.TreeView12.TabIndex = 191;
			this.Button38.Location = new Point(335, 121);
			this.Button38.Name = "Button38";
			this.Button38.Size = new Size(131, 32);
			this.Button38.TabIndex = 190;
			this.Button38.Text = "Button38";
			this.Button38.UseVisualStyleBackColor = true;
			this.CheckBox9.AutoSize = true;
			this.CheckBox9.Location = new Point(581, 140);
			this.CheckBox9.Name = "CheckBox9";
			this.CheckBox9.Size = new Size(81, 17);
			this.CheckBox9.TabIndex = 189;
			this.CheckBox9.Text = "CheckBox9";
			this.CheckBox9.UseVisualStyleBackColor = true;
			this.DateTimePicker20.Location = new Point(558, 175);
			this.DateTimePicker20.Name = "DateTimePicker20";
			this.DateTimePicker20.Size = new Size(200, 20);
			this.DateTimePicker20.TabIndex = 188;
			this.ListView9.HideSelection = false;
			this.ListView9.Location = new Point(660, 216);
			this.ListView9.Name = "ListView9";
			this.ListView9.Size = new Size(121, 97);
			this.ListView9.TabIndex = 187;
			this.ListView9.UseCompatibleStateImageBehavior = false;
			this.MonthCalendar12.Location = new Point(6, 103);
			this.MonthCalendar12.Name = "MonthCalendar12";
			this.MonthCalendar12.TabIndex = 186;
			this.PictureBox21.Location = new Point(420, 274);
			this.PictureBox21.Name = "PictureBox21";
			this.PictureBox21.Size = new Size(82, 85);
			this.PictureBox21.TabIndex = 185;
			this.PictureBox21.TabStop = false;
			this.Label9.AutoSize = true;
			this.Label9.Location = new Point(224, 274);
			this.Label9.Name = "Label9";
			this.Label9.Size = new Size(39, 13);
			this.Label9.TabIndex = 184;
			this.Label9.Text = "Label9";
			this.LinkLabel24.AutoSize = true;
			this.LinkLabel24.Location = new Point(236, 217);
			this.LinkLabel24.Name = "LinkLabel24";
			this.LinkLabel24.Size = new Size(65, 13);
			this.LinkLabel24.TabIndex = 183;
			this.LinkLabel24.TabStop = true;
			this.LinkLabel24.Text = "LinkLabel24";
			this.ComboBox36.FormattingEnabled = true;
			this.ComboBox36.Location = new Point(335, 278);
			this.ComboBox36.Name = "ComboBox36";
			this.ComboBox36.Size = new Size(8, 21);
			this.ComboBox36.TabIndex = 182;
			this.DateTimePicker21.Location = new Point(282, 159);
			this.DateTimePicker21.Name = "DateTimePicker21";
			this.DateTimePicker21.Size = new Size(200, 20);
			this.DateTimePicker21.TabIndex = 181;
			this.CheckedListBox12.FormattingEnabled = true;
			this.CheckedListBox12.Location = new Point(444, 187);
			this.CheckedListBox12.Name = "CheckedListBox12";
			this.CheckedListBox12.Size = new Size(120, 94);
			this.CheckedListBox12.TabIndex = 180;
			this.Button39.Location = new Point(168, 202);
			this.Button39.Name = "Button39";
			this.Button39.Size = new Size(216, 81);
			this.Button39.TabIndex = 179;
			this.Button39.Text = "Button39";
			this.Button39.UseVisualStyleBackColor = true;
			this.Button40.Location = new Point(6, 68);
			this.Button40.Name = "Button40";
			this.Button40.Size = new Size(75, 23);
			this.Button40.TabIndex = 178;
			this.Button40.Text = "Button40";
			this.Button40.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(800, 450);
			base.Controls.Add(this.LinkLabel19);
			base.Controls.Add(this.Button31);
			base.Controls.Add(this.ComboBox29);
			base.Controls.Add(this.ComboBox30);
			base.Controls.Add(this.MaskedTextBox12);
			base.Controls.Add(this.PictureBox17);
			base.Controls.Add(this.TreeView10);
			base.Controls.Add(this.Button32);
			base.Controls.Add(this.MonthCalendar10);
			base.Controls.Add(this.PictureBox18);
			base.Controls.Add(this.Label8);
			base.Controls.Add(this.LinkLabel20);
			base.Controls.Add(this.ComboBox31);
			base.Controls.Add(this.DateTimePicker17);
			base.Controls.Add(this.CheckedListBox10);
			base.Controls.Add(this.Button33);
			base.Controls.Add(this.LinkLabel21);
			base.Controls.Add(this.Button34);
			base.Controls.Add(this.ComboBox32);
			base.Controls.Add(this.ComboBox33);
			base.Controls.Add(this.MaskedTextBox13);
			base.Controls.Add(this.PictureBox19);
			base.Controls.Add(this.WebBrowser8);
			base.Controls.Add(this.TreeView11);
			base.Controls.Add(this.Button35);
			base.Controls.Add(this.CheckBox8);
			base.Controls.Add(this.DateTimePicker18);
			base.Controls.Add(this.ListView8);
			base.Controls.Add(this.MonthCalendar11);
			base.Controls.Add(this.LinkLabel22);
			base.Controls.Add(this.DateTimePicker19);
			base.Controls.Add(this.CheckedListBox11);
			base.Controls.Add(this.Button36);
			base.Controls.Add(this.LinkLabel23);
			base.Controls.Add(this.Button37);
			base.Controls.Add(this.ComboBox34);
			base.Controls.Add(this.ComboBox35);
			base.Controls.Add(this.MaskedTextBox14);
			base.Controls.Add(this.PictureBox20);
			base.Controls.Add(this.WebBrowser9);
			base.Controls.Add(this.TreeView12);
			base.Controls.Add(this.Button38);
			base.Controls.Add(this.CheckBox9);
			base.Controls.Add(this.DateTimePicker20);
			base.Controls.Add(this.ListView9);
			base.Controls.Add(this.MonthCalendar12);
			base.Controls.Add(this.PictureBox21);
			base.Controls.Add(this.Label9);
			base.Controls.Add(this.LinkLabel24);
			base.Controls.Add(this.ComboBox36);
			base.Controls.Add(this.DateTimePicker21);
			base.Controls.Add(this.CheckedListBox12);
			base.Controls.Add(this.Button39);
			base.Controls.Add(this.Button40);
			base.Controls.Add(this.LinkLabel13);
			base.Controls.Add(this.Button21);
			base.Controls.Add(this.ComboBox21);
			base.Controls.Add(this.ComboBox22);
			base.Controls.Add(this.MaskedTextBox9);
			base.Controls.Add(this.PictureBox12);
			base.Controls.Add(this.TreeView7);
			base.Controls.Add(this.Button22);
			base.Controls.Add(this.MonthCalendar7);
			base.Controls.Add(this.PictureBox13);
			base.Controls.Add(this.Label6);
			base.Controls.Add(this.LinkLabel14);
			base.Controls.Add(this.ComboBox23);
			base.Controls.Add(this.DateTimePicker12);
			base.Controls.Add(this.CheckedListBox7);
			base.Controls.Add(this.Button23);
			base.Controls.Add(this.LinkLabel15);
			base.Controls.Add(this.Button24);
			base.Controls.Add(this.ComboBox24);
			base.Controls.Add(this.ComboBox25);
			base.Controls.Add(this.MaskedTextBox10);
			base.Controls.Add(this.PictureBox14);
			base.Controls.Add(this.WebBrowser6);
			base.Controls.Add(this.TreeView8);
			base.Controls.Add(this.Button25);
			base.Controls.Add(this.CheckBox6);
			base.Controls.Add(this.DateTimePicker13);
			base.Controls.Add(this.ListView6);
			base.Controls.Add(this.MonthCalendar8);
			base.Controls.Add(this.LinkLabel16);
			base.Controls.Add(this.DateTimePicker14);
			base.Controls.Add(this.CheckedListBox8);
			base.Controls.Add(this.Button26);
			base.Controls.Add(this.LinkLabel17);
			base.Controls.Add(this.Button27);
			base.Controls.Add(this.ComboBox26);
			base.Controls.Add(this.ComboBox27);
			base.Controls.Add(this.MaskedTextBox11);
			base.Controls.Add(this.PictureBox15);
			base.Controls.Add(this.WebBrowser7);
			base.Controls.Add(this.TreeView9);
			base.Controls.Add(this.Button28);
			base.Controls.Add(this.CheckBox7);
			base.Controls.Add(this.DateTimePicker15);
			base.Controls.Add(this.ListView7);
			base.Controls.Add(this.MonthCalendar9);
			base.Controls.Add(this.PictureBox16);
			base.Controls.Add(this.Label7);
			base.Controls.Add(this.LinkLabel18);
			base.Controls.Add(this.ComboBox28);
			base.Controls.Add(this.DateTimePicker16);
			base.Controls.Add(this.CheckedListBox9);
			base.Controls.Add(this.Button29);
			base.Controls.Add(this.Button30);
			base.Controls.Add(this.LinkLabel7);
			base.Controls.Add(this.Button11);
			base.Controls.Add(this.ComboBox13);
			base.Controls.Add(this.ComboBox14);
			base.Controls.Add(this.MaskedTextBox6);
			base.Controls.Add(this.PictureBox7);
			base.Controls.Add(this.TreeView4);
			base.Controls.Add(this.Button12);
			base.Controls.Add(this.MonthCalendar4);
			base.Controls.Add(this.PictureBox8);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.LinkLabel8);
			base.Controls.Add(this.ComboBox15);
			base.Controls.Add(this.DateTimePicker7);
			base.Controls.Add(this.CheckedListBox4);
			base.Controls.Add(this.Button13);
			base.Controls.Add(this.LinkLabel9);
			base.Controls.Add(this.Button14);
			base.Controls.Add(this.ComboBox16);
			base.Controls.Add(this.ComboBox17);
			base.Controls.Add(this.MaskedTextBox7);
			base.Controls.Add(this.PictureBox9);
			base.Controls.Add(this.WebBrowser4);
			base.Controls.Add(this.TreeView5);
			base.Controls.Add(this.Button15);
			base.Controls.Add(this.CheckBox4);
			base.Controls.Add(this.DateTimePicker8);
			base.Controls.Add(this.ListView4);
			base.Controls.Add(this.MonthCalendar5);
			base.Controls.Add(this.LinkLabel10);
			base.Controls.Add(this.DateTimePicker9);
			base.Controls.Add(this.CheckedListBox5);
			base.Controls.Add(this.Button16);
			base.Controls.Add(this.LinkLabel11);
			base.Controls.Add(this.Button17);
			base.Controls.Add(this.ComboBox18);
			base.Controls.Add(this.ComboBox19);
			base.Controls.Add(this.MaskedTextBox8);
			base.Controls.Add(this.PictureBox10);
			base.Controls.Add(this.WebBrowser5);
			base.Controls.Add(this.TreeView6);
			base.Controls.Add(this.Button18);
			base.Controls.Add(this.CheckBox5);
			base.Controls.Add(this.DateTimePicker10);
			base.Controls.Add(this.ListView5);
			base.Controls.Add(this.MonthCalendar6);
			base.Controls.Add(this.PictureBox11);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.LinkLabel12);
			base.Controls.Add(this.ComboBox20);
			base.Controls.Add(this.DateTimePicker11);
			base.Controls.Add(this.CheckedListBox6);
			base.Controls.Add(this.Button19);
			base.Controls.Add(this.Button20);
			base.Controls.Add(this.LinkLabel5);
			base.Controls.Add(this.Button8);
			base.Controls.Add(this.ComboBox9);
			base.Controls.Add(this.ComboBox10);
			base.Controls.Add(this.MaskedTextBox5);
			base.Controls.Add(this.PictureBox5);
			base.Controls.Add(this.WebBrowser3);
			base.Controls.Add(this.TreeView3);
			base.Controls.Add(this.ComboBox11);
			base.Controls.Add(this.Button9);
			base.Controls.Add(this.CheckBox3);
			base.Controls.Add(this.DateTimePicker5);
			base.Controls.Add(this.ListView3);
			base.Controls.Add(this.MonthCalendar3);
			base.Controls.Add(this.PictureBox6);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.LinkLabel6);
			base.Controls.Add(this.ComboBox12);
			base.Controls.Add(this.DateTimePicker6);
			base.Controls.Add(this.CheckedListBox3);
			base.Controls.Add(this.Button10);
			base.Controls.Add(this.LinkLabel3);
			base.Controls.Add(this.Button5);
			base.Controls.Add(this.ComboBox5);
			base.Controls.Add(this.ComboBox6);
			base.Controls.Add(this.MaskedTextBox4);
			base.Controls.Add(this.PictureBox3);
			base.Controls.Add(this.WebBrowser2);
			base.Controls.Add(this.TreeView2);
			base.Controls.Add(this.ComboBox7);
			base.Controls.Add(this.Button6);
			base.Controls.Add(this.CheckBox2);
			base.Controls.Add(this.DateTimePicker3);
			base.Controls.Add(this.ListView2);
			base.Controls.Add(this.MonthCalendar2);
			base.Controls.Add(this.PictureBox4);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.LinkLabel4);
			base.Controls.Add(this.ComboBox8);
			base.Controls.Add(this.DateTimePicker4);
			base.Controls.Add(this.CheckedListBox2);
			base.Controls.Add(this.Button7);
			base.Controls.Add(this.LinkLabel2);
			base.Controls.Add(this.Button4);
			base.Controls.Add(this.ComboBox4);
			base.Controls.Add(this.ComboBox3);
			base.Controls.Add(this.MaskedTextBox3);
			base.Controls.Add(this.PictureBox2);
			base.Controls.Add(this.WebBrowser1);
			base.Controls.Add(this.TreeView1);
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.RichTextBox1);
			base.Controls.Add(this.RadioButton1);
			base.Controls.Add(this.ComboBox2);
			base.Controls.Add(this.Button3);
			base.Controls.Add(this.CheckBox1);
			base.Controls.Add(this.DateTimePicker2);
			base.Controls.Add(this.ListView1);
			base.Controls.Add(this.MaskedTextBox2);
			base.Controls.Add(this.MonthCalendar1);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.LinkLabel1);
			base.Controls.Add(this.MaskedTextBox1);
			base.Controls.Add(this.ComboBox1);
			base.Controls.Add(this.DateTimePicker1);
			base.Controls.Add(this.CheckedListBox1);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.Button1);
			base.Name = "Ingratek";
			this.Text = "Ingratek";
			((ISupportInitialize)this.PictureBox1).EndInit();
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
			((ISupportInitialize)this.PictureBox16).EndInit();
			((ISupportInitialize)this.PictureBox17).EndInit();
			((ISupportInitialize)this.PictureBox18).EndInit();
			((ISupportInitialize)this.PictureBox19).EndInit();
			((ISupportInitialize)this.PictureBox20).EndInit();
			((ISupportInitialize)this.PictureBox21).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0003EE85 File Offset: 0x0003D085
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x0003EE8D File Offset: 0x0003D08D
		internal virtual Button Button1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0003EE96 File Offset: 0x0003D096
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x0003EE9E File Offset: 0x0003D09E
		internal virtual Button Button2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0003EEA7 File Offset: 0x0003D0A7
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x0003EEAF File Offset: 0x0003D0AF
		internal virtual CheckedListBox CheckedListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0003EEB8 File Offset: 0x0003D0B8
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x0003EEC0 File Offset: 0x0003D0C0
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0003EEC9 File Offset: 0x0003D0C9
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x0003EED1 File Offset: 0x0003D0D1
		internal virtual ComboBox ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0003EEDA File Offset: 0x0003D0DA
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x0003EEE2 File Offset: 0x0003D0E2
		internal virtual MaskedTextBox MaskedTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0003EEEB File Offset: 0x0003D0EB
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x0003EEF3 File Offset: 0x0003D0F3
		internal virtual LinkLabel LinkLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0003EEFC File Offset: 0x0003D0FC
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x0003EF04 File Offset: 0x0003D104
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0003EF0D File Offset: 0x0003D10D
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x0003EF15 File Offset: 0x0003D115
		internal virtual ProgressBar ProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0003EF1E File Offset: 0x0003D11E
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0003EF26 File Offset: 0x0003D126
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0003EF2F File Offset: 0x0003D12F
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0003EF37 File Offset: 0x0003D137
		internal virtual MonthCalendar MonthCalendar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0003EF40 File Offset: 0x0003D140
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x0003EF48 File Offset: 0x0003D148
		internal virtual MaskedTextBox MaskedTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0003EF51 File Offset: 0x0003D151
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x0003EF59 File Offset: 0x0003D159
		internal virtual ListView ListView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0003EF62 File Offset: 0x0003D162
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x0003EF6A File Offset: 0x0003D16A
		internal virtual DateTimePicker DateTimePicker2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0003EF73 File Offset: 0x0003D173
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x0003EF7B File Offset: 0x0003D17B
		internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0003EF84 File Offset: 0x0003D184
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x0003EF8C File Offset: 0x0003D18C
		internal virtual Button Button3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0003EF95 File Offset: 0x0003D195
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x0003EF9D File Offset: 0x0003D19D
		internal virtual ComboBox ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x0003EFA6 File Offset: 0x0003D1A6
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x0003EFAE File Offset: 0x0003D1AE
		internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0003EFB7 File Offset: 0x0003D1B7
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x0003EFBF File Offset: 0x0003D1BF
		internal virtual RichTextBox RichTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0003EFC8 File Offset: 0x0003D1C8
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x0003EFD0 File Offset: 0x0003D1D0
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0003EFD9 File Offset: 0x0003D1D9
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x0003EFE1 File Offset: 0x0003D1E1
		internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0003EFEA File Offset: 0x0003D1EA
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x0003EFF2 File Offset: 0x0003D1F2
		internal virtual TreeView TreeView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0003EFFB File Offset: 0x0003D1FB
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x0003F003 File Offset: 0x0003D203
		internal virtual WebBrowser WebBrowser1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0003F00C File Offset: 0x0003D20C
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x0003F014 File Offset: 0x0003D214
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0003F01D File Offset: 0x0003D21D
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x0003F025 File Offset: 0x0003D225
		internal virtual MaskedTextBox MaskedTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0003F02E File Offset: 0x0003D22E
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x0003F036 File Offset: 0x0003D236
		internal virtual ComboBox ComboBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0003F03F File Offset: 0x0003D23F
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0003F047 File Offset: 0x0003D247
		internal virtual ComboBox ComboBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0003F050 File Offset: 0x0003D250
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x0003F058 File Offset: 0x0003D258
		internal virtual Button Button4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0003F061 File Offset: 0x0003D261
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x0003F069 File Offset: 0x0003D269
		internal virtual LinkLabel LinkLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0003F072 File Offset: 0x0003D272
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x0003F07A File Offset: 0x0003D27A
		internal virtual LinkLabel LinkLabel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0003F083 File Offset: 0x0003D283
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x0003F08B File Offset: 0x0003D28B
		internal virtual Button Button5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0003F094 File Offset: 0x0003D294
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x0003F09C File Offset: 0x0003D29C
		internal virtual ComboBox ComboBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0003F0A5 File Offset: 0x0003D2A5
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x0003F0AD File Offset: 0x0003D2AD
		internal virtual ComboBox ComboBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0003F0B6 File Offset: 0x0003D2B6
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x0003F0BE File Offset: 0x0003D2BE
		internal virtual MaskedTextBox MaskedTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0003F0C7 File Offset: 0x0003D2C7
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x0003F0CF File Offset: 0x0003D2CF
		internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0003F0D8 File Offset: 0x0003D2D8
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x0003F0E0 File Offset: 0x0003D2E0
		internal virtual WebBrowser WebBrowser2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0003F0E9 File Offset: 0x0003D2E9
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x0003F0F1 File Offset: 0x0003D2F1
		internal virtual TreeView TreeView2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0003F0FA File Offset: 0x0003D2FA
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x0003F102 File Offset: 0x0003D302
		internal virtual ComboBox ComboBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0003F10B File Offset: 0x0003D30B
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x0003F113 File Offset: 0x0003D313
		internal virtual Button Button6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0003F11C File Offset: 0x0003D31C
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x0003F124 File Offset: 0x0003D324
		internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0003F12D File Offset: 0x0003D32D
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x0003F135 File Offset: 0x0003D335
		internal virtual DateTimePicker DateTimePicker3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0003F13E File Offset: 0x0003D33E
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x0003F146 File Offset: 0x0003D346
		internal virtual ListView ListView2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0003F14F File Offset: 0x0003D34F
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x0003F157 File Offset: 0x0003D357
		internal virtual MonthCalendar MonthCalendar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0003F160 File Offset: 0x0003D360
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x0003F168 File Offset: 0x0003D368
		internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0003F171 File Offset: 0x0003D371
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0003F179 File Offset: 0x0003D379
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0003F182 File Offset: 0x0003D382
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x0003F18A File Offset: 0x0003D38A
		internal virtual LinkLabel LinkLabel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0003F193 File Offset: 0x0003D393
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x0003F19B File Offset: 0x0003D39B
		internal virtual ComboBox ComboBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0003F1A4 File Offset: 0x0003D3A4
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0003F1AC File Offset: 0x0003D3AC
		internal virtual DateTimePicker DateTimePicker4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0003F1B5 File Offset: 0x0003D3B5
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0003F1BD File Offset: 0x0003D3BD
		internal virtual CheckedListBox CheckedListBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0003F1C6 File Offset: 0x0003D3C6
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0003F1CE File Offset: 0x0003D3CE
		internal virtual Button Button7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0003F1D7 File Offset: 0x0003D3D7
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0003F1DF File Offset: 0x0003D3DF
		internal virtual LinkLabel LinkLabel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0003F1E8 File Offset: 0x0003D3E8
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x0003F1F0 File Offset: 0x0003D3F0
		internal virtual Button Button8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x0003F1F9 File Offset: 0x0003D3F9
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x0003F201 File Offset: 0x0003D401
		internal virtual ComboBox ComboBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x0003F20A File Offset: 0x0003D40A
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x0003F212 File Offset: 0x0003D412
		internal virtual ComboBox ComboBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x0003F21B File Offset: 0x0003D41B
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x0003F223 File Offset: 0x0003D423
		internal virtual MaskedTextBox MaskedTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x0003F22C File Offset: 0x0003D42C
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x0003F234 File Offset: 0x0003D434
		internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0003F23D File Offset: 0x0003D43D
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x0003F245 File Offset: 0x0003D445
		internal virtual WebBrowser WebBrowser3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0003F24E File Offset: 0x0003D44E
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x0003F256 File Offset: 0x0003D456
		internal virtual TreeView TreeView3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0003F25F File Offset: 0x0003D45F
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x0003F267 File Offset: 0x0003D467
		internal virtual ComboBox ComboBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0003F270 File Offset: 0x0003D470
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x0003F278 File Offset: 0x0003D478
		internal virtual Button Button9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x0003F281 File Offset: 0x0003D481
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x0003F289 File Offset: 0x0003D489
		internal virtual CheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0003F292 File Offset: 0x0003D492
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x0003F29A File Offset: 0x0003D49A
		internal virtual DateTimePicker DateTimePicker5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0003F2A3 File Offset: 0x0003D4A3
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x0003F2AB File Offset: 0x0003D4AB
		internal virtual ListView ListView3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0003F2B4 File Offset: 0x0003D4B4
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x0003F2BC File Offset: 0x0003D4BC
		internal virtual MonthCalendar MonthCalendar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0003F2C5 File Offset: 0x0003D4C5
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x0003F2CD File Offset: 0x0003D4CD
		internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0003F2D6 File Offset: 0x0003D4D6
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0003F2DE File Offset: 0x0003D4DE
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0003F2E7 File Offset: 0x0003D4E7
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x0003F2EF File Offset: 0x0003D4EF
		internal virtual LinkLabel LinkLabel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0003F2F8 File Offset: 0x0003D4F8
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0003F300 File Offset: 0x0003D500
		internal virtual ComboBox ComboBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x0003F309 File Offset: 0x0003D509
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x0003F311 File Offset: 0x0003D511
		internal virtual DateTimePicker DateTimePicker6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x0003F31A File Offset: 0x0003D51A
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x0003F322 File Offset: 0x0003D522
		internal virtual CheckedListBox CheckedListBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0003F32B File Offset: 0x0003D52B
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x0003F333 File Offset: 0x0003D533
		internal virtual Button Button10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0003F33C File Offset: 0x0003D53C
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x0003F344 File Offset: 0x0003D544
		internal virtual LinkLabel LinkLabel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0003F34D File Offset: 0x0003D54D
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x0003F355 File Offset: 0x0003D555
		internal virtual Button Button11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0003F35E File Offset: 0x0003D55E
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x0003F366 File Offset: 0x0003D566
		internal virtual ComboBox ComboBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0003F36F File Offset: 0x0003D56F
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x0003F377 File Offset: 0x0003D577
		internal virtual ComboBox ComboBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0003F380 File Offset: 0x0003D580
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x0003F388 File Offset: 0x0003D588
		internal virtual MaskedTextBox MaskedTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0003F391 File Offset: 0x0003D591
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0003F399 File Offset: 0x0003D599
		internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0003F3A2 File Offset: 0x0003D5A2
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0003F3AA File Offset: 0x0003D5AA
		internal virtual TreeView TreeView4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0003F3B3 File Offset: 0x0003D5B3
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0003F3BB File Offset: 0x0003D5BB
		internal virtual Button Button12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0003F3C4 File Offset: 0x0003D5C4
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0003F3CC File Offset: 0x0003D5CC
		internal virtual MonthCalendar MonthCalendar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0003F3D5 File Offset: 0x0003D5D5
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x0003F3DD File Offset: 0x0003D5DD
		internal virtual PictureBox PictureBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0003F3E6 File Offset: 0x0003D5E6
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x0003F3EE File Offset: 0x0003D5EE
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0003F3F7 File Offset: 0x0003D5F7
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x0003F3FF File Offset: 0x0003D5FF
		internal virtual LinkLabel LinkLabel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0003F408 File Offset: 0x0003D608
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x0003F410 File Offset: 0x0003D610
		internal virtual ComboBox ComboBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0003F419 File Offset: 0x0003D619
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0003F421 File Offset: 0x0003D621
		internal virtual DateTimePicker DateTimePicker7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0003F42A File Offset: 0x0003D62A
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x0003F432 File Offset: 0x0003D632
		internal virtual CheckedListBox CheckedListBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0003F43B File Offset: 0x0003D63B
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x0003F443 File Offset: 0x0003D643
		internal virtual Button Button13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x0003F44C File Offset: 0x0003D64C
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x0003F454 File Offset: 0x0003D654
		internal virtual LinkLabel LinkLabel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x0003F45D File Offset: 0x0003D65D
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x0003F465 File Offset: 0x0003D665
		internal virtual Button Button14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0003F46E File Offset: 0x0003D66E
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x0003F476 File Offset: 0x0003D676
		internal virtual ComboBox ComboBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0003F47F File Offset: 0x0003D67F
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x0003F487 File Offset: 0x0003D687
		internal virtual ComboBox ComboBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0003F490 File Offset: 0x0003D690
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x0003F498 File Offset: 0x0003D698
		internal virtual MaskedTextBox MaskedTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0003F4A1 File Offset: 0x0003D6A1
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0003F4A9 File Offset: 0x0003D6A9
		internal virtual PictureBox PictureBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0003F4B2 File Offset: 0x0003D6B2
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x0003F4BA File Offset: 0x0003D6BA
		internal virtual WebBrowser WebBrowser4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0003F4C3 File Offset: 0x0003D6C3
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x0003F4CB File Offset: 0x0003D6CB
		internal virtual TreeView TreeView5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0003F4D4 File Offset: 0x0003D6D4
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x0003F4DC File Offset: 0x0003D6DC
		internal virtual Button Button15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0003F4E5 File Offset: 0x0003D6E5
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x0003F4ED File Offset: 0x0003D6ED
		internal virtual CheckBox CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0003F4F6 File Offset: 0x0003D6F6
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x0003F4FE File Offset: 0x0003D6FE
		internal virtual DateTimePicker DateTimePicker8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0003F507 File Offset: 0x0003D707
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x0003F50F File Offset: 0x0003D70F
		internal virtual ListView ListView4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0003F518 File Offset: 0x0003D718
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x0003F520 File Offset: 0x0003D720
		internal virtual MonthCalendar MonthCalendar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0003F529 File Offset: 0x0003D729
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x0003F531 File Offset: 0x0003D731
		internal virtual LinkLabel LinkLabel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0003F53A File Offset: 0x0003D73A
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x0003F542 File Offset: 0x0003D742
		internal virtual DateTimePicker DateTimePicker9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0003F54B File Offset: 0x0003D74B
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x0003F553 File Offset: 0x0003D753
		internal virtual CheckedListBox CheckedListBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0003F55C File Offset: 0x0003D75C
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x0003F564 File Offset: 0x0003D764
		internal virtual Button Button16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0003F56D File Offset: 0x0003D76D
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0003F575 File Offset: 0x0003D775
		internal virtual LinkLabel LinkLabel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0003F57E File Offset: 0x0003D77E
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x0003F586 File Offset: 0x0003D786
		internal virtual Button Button17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0003F58F File Offset: 0x0003D78F
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x0003F597 File Offset: 0x0003D797
		internal virtual ComboBox ComboBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0003F5A0 File Offset: 0x0003D7A0
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0003F5A8 File Offset: 0x0003D7A8
		internal virtual ComboBox ComboBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0003F5B1 File Offset: 0x0003D7B1
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x0003F5B9 File Offset: 0x0003D7B9
		internal virtual MaskedTextBox MaskedTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0003F5C2 File Offset: 0x0003D7C2
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x0003F5CA File Offset: 0x0003D7CA
		internal virtual PictureBox PictureBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0003F5D3 File Offset: 0x0003D7D3
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x0003F5DB File Offset: 0x0003D7DB
		internal virtual WebBrowser WebBrowser5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x0003F5E4 File Offset: 0x0003D7E4
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x0003F5EC File Offset: 0x0003D7EC
		internal virtual TreeView TreeView6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0003F5F5 File Offset: 0x0003D7F5
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x0003F5FD File Offset: 0x0003D7FD
		internal virtual Button Button18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0003F606 File Offset: 0x0003D806
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x0003F60E File Offset: 0x0003D80E
		internal virtual CheckBox CheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0003F617 File Offset: 0x0003D817
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x0003F61F File Offset: 0x0003D81F
		internal virtual DateTimePicker DateTimePicker10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0003F628 File Offset: 0x0003D828
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x0003F630 File Offset: 0x0003D830
		internal virtual ListView ListView5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0003F639 File Offset: 0x0003D839
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x0003F641 File Offset: 0x0003D841
		internal virtual MonthCalendar MonthCalendar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x0003F64A File Offset: 0x0003D84A
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x0003F652 File Offset: 0x0003D852
		internal virtual PictureBox PictureBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0003F65B File Offset: 0x0003D85B
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x0003F663 File Offset: 0x0003D863
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0003F66C File Offset: 0x0003D86C
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x0003F674 File Offset: 0x0003D874
		internal virtual LinkLabel LinkLabel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0003F67D File Offset: 0x0003D87D
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x0003F685 File Offset: 0x0003D885
		internal virtual ComboBox ComboBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0003F68E File Offset: 0x0003D88E
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x0003F696 File Offset: 0x0003D896
		internal virtual DateTimePicker DateTimePicker11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x0003F69F File Offset: 0x0003D89F
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x0003F6A7 File Offset: 0x0003D8A7
		internal virtual CheckedListBox CheckedListBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0003F6B0 File Offset: 0x0003D8B0
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x0003F6B8 File Offset: 0x0003D8B8
		internal virtual Button Button19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0003F6C1 File Offset: 0x0003D8C1
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x0003F6C9 File Offset: 0x0003D8C9
		internal virtual Button Button20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0003F6D2 File Offset: 0x0003D8D2
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x0003F6DA File Offset: 0x0003D8DA
		internal virtual LinkLabel LinkLabel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0003F6E3 File Offset: 0x0003D8E3
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x0003F6EB File Offset: 0x0003D8EB
		internal virtual Button Button21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0003F6F4 File Offset: 0x0003D8F4
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x0003F6FC File Offset: 0x0003D8FC
		internal virtual ComboBox ComboBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0003F705 File Offset: 0x0003D905
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x0003F70D File Offset: 0x0003D90D
		internal virtual ComboBox ComboBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0003F716 File Offset: 0x0003D916
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x0003F71E File Offset: 0x0003D91E
		internal virtual MaskedTextBox MaskedTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0003F727 File Offset: 0x0003D927
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x0003F72F File Offset: 0x0003D92F
		internal virtual PictureBox PictureBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0003F738 File Offset: 0x0003D938
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x0003F740 File Offset: 0x0003D940
		internal virtual TreeView TreeView7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0003F749 File Offset: 0x0003D949
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0003F751 File Offset: 0x0003D951
		internal virtual Button Button22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0003F75A File Offset: 0x0003D95A
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x0003F762 File Offset: 0x0003D962
		internal virtual MonthCalendar MonthCalendar7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0003F76B File Offset: 0x0003D96B
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x0003F773 File Offset: 0x0003D973
		internal virtual PictureBox PictureBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0003F77C File Offset: 0x0003D97C
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x0003F784 File Offset: 0x0003D984
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0003F78D File Offset: 0x0003D98D
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x0003F795 File Offset: 0x0003D995
		internal virtual LinkLabel LinkLabel14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0003F79E File Offset: 0x0003D99E
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x0003F7A6 File Offset: 0x0003D9A6
		internal virtual ComboBox ComboBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0003F7AF File Offset: 0x0003D9AF
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x0003F7B7 File Offset: 0x0003D9B7
		internal virtual DateTimePicker DateTimePicker12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0003F7C0 File Offset: 0x0003D9C0
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x0003F7C8 File Offset: 0x0003D9C8
		internal virtual CheckedListBox CheckedListBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0003F7D1 File Offset: 0x0003D9D1
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x0003F7D9 File Offset: 0x0003D9D9
		internal virtual Button Button23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x0003F7E2 File Offset: 0x0003D9E2
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x0003F7EA File Offset: 0x0003D9EA
		internal virtual LinkLabel LinkLabel15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0003F7F3 File Offset: 0x0003D9F3
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x0003F7FB File Offset: 0x0003D9FB
		internal virtual Button Button24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x0003F804 File Offset: 0x0003DA04
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x0003F80C File Offset: 0x0003DA0C
		internal virtual ComboBox ComboBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0003F815 File Offset: 0x0003DA15
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x0003F81D File Offset: 0x0003DA1D
		internal virtual ComboBox ComboBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x0003F826 File Offset: 0x0003DA26
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x0003F82E File Offset: 0x0003DA2E
		internal virtual MaskedTextBox MaskedTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0003F837 File Offset: 0x0003DA37
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x0003F83F File Offset: 0x0003DA3F
		internal virtual PictureBox PictureBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0003F848 File Offset: 0x0003DA48
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x0003F850 File Offset: 0x0003DA50
		internal virtual WebBrowser WebBrowser6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0003F859 File Offset: 0x0003DA59
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x0003F861 File Offset: 0x0003DA61
		internal virtual TreeView TreeView8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0003F86A File Offset: 0x0003DA6A
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x0003F872 File Offset: 0x0003DA72
		internal virtual Button Button25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x0003F87B File Offset: 0x0003DA7B
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x0003F883 File Offset: 0x0003DA83
		internal virtual CheckBox CheckBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0003F88C File Offset: 0x0003DA8C
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x0003F894 File Offset: 0x0003DA94
		internal virtual DateTimePicker DateTimePicker13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0003F89D File Offset: 0x0003DA9D
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x0003F8A5 File Offset: 0x0003DAA5
		internal virtual ListView ListView6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x0003F8AE File Offset: 0x0003DAAE
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x0003F8B6 File Offset: 0x0003DAB6
		internal virtual MonthCalendar MonthCalendar8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x0003F8BF File Offset: 0x0003DABF
		// (set) Token: 0x06000C85 RID: 3205 RVA: 0x0003F8C7 File Offset: 0x0003DAC7
		internal virtual LinkLabel LinkLabel16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x0003F8D0 File Offset: 0x0003DAD0
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x0003F8D8 File Offset: 0x0003DAD8
		internal virtual DateTimePicker DateTimePicker14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x0003F8E1 File Offset: 0x0003DAE1
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x0003F8E9 File Offset: 0x0003DAE9
		internal virtual CheckedListBox CheckedListBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0003F8F2 File Offset: 0x0003DAF2
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x0003F8FA File Offset: 0x0003DAFA
		internal virtual Button Button26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x0003F903 File Offset: 0x0003DB03
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x0003F90B File Offset: 0x0003DB0B
		internal virtual LinkLabel LinkLabel17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0003F914 File Offset: 0x0003DB14
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x0003F91C File Offset: 0x0003DB1C
		internal virtual Button Button27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0003F925 File Offset: 0x0003DB25
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x0003F92D File Offset: 0x0003DB2D
		internal virtual ComboBox ComboBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0003F936 File Offset: 0x0003DB36
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x0003F93E File Offset: 0x0003DB3E
		internal virtual ComboBox ComboBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x0003F947 File Offset: 0x0003DB47
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x0003F94F File Offset: 0x0003DB4F
		internal virtual MaskedTextBox MaskedTextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x0003F958 File Offset: 0x0003DB58
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x0003F960 File Offset: 0x0003DB60
		internal virtual PictureBox PictureBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0003F969 File Offset: 0x0003DB69
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x0003F971 File Offset: 0x0003DB71
		internal virtual WebBrowser WebBrowser7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0003F97A File Offset: 0x0003DB7A
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x0003F982 File Offset: 0x0003DB82
		internal virtual TreeView TreeView9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x0003F98B File Offset: 0x0003DB8B
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x0003F993 File Offset: 0x0003DB93
		internal virtual Button Button28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0003F99C File Offset: 0x0003DB9C
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x0003F9A4 File Offset: 0x0003DBA4
		internal virtual CheckBox CheckBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x0003F9AD File Offset: 0x0003DBAD
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x0003F9B5 File Offset: 0x0003DBB5
		internal virtual DateTimePicker DateTimePicker15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x0003F9BE File Offset: 0x0003DBBE
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x0003F9C6 File Offset: 0x0003DBC6
		internal virtual ListView ListView7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x0003F9CF File Offset: 0x0003DBCF
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x0003F9D7 File Offset: 0x0003DBD7
		internal virtual MonthCalendar MonthCalendar9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x0003F9E0 File Offset: 0x0003DBE0
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x0003F9E8 File Offset: 0x0003DBE8
		internal virtual PictureBox PictureBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0003F9F1 File Offset: 0x0003DBF1
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x0003F9F9 File Offset: 0x0003DBF9
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0003FA02 File Offset: 0x0003DC02
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x0003FA0A File Offset: 0x0003DC0A
		internal virtual LinkLabel LinkLabel18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x0003FA13 File Offset: 0x0003DC13
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x0003FA1B File Offset: 0x0003DC1B
		internal virtual ComboBox ComboBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x0003FA24 File Offset: 0x0003DC24
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x0003FA2C File Offset: 0x0003DC2C
		internal virtual DateTimePicker DateTimePicker16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0003FA35 File Offset: 0x0003DC35
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x0003FA3D File Offset: 0x0003DC3D
		internal virtual CheckedListBox CheckedListBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0003FA46 File Offset: 0x0003DC46
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x0003FA4E File Offset: 0x0003DC4E
		internal virtual Button Button29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0003FA57 File Offset: 0x0003DC57
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x0003FA5F File Offset: 0x0003DC5F
		internal virtual Button Button30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0003FA68 File Offset: 0x0003DC68
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x0003FA70 File Offset: 0x0003DC70
		internal virtual LinkLabel LinkLabel19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0003FA79 File Offset: 0x0003DC79
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x0003FA81 File Offset: 0x0003DC81
		internal virtual Button Button31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0003FA8A File Offset: 0x0003DC8A
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x0003FA92 File Offset: 0x0003DC92
		internal virtual ComboBox ComboBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0003FA9B File Offset: 0x0003DC9B
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x0003FAA3 File Offset: 0x0003DCA3
		internal virtual ComboBox ComboBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x0003FAAC File Offset: 0x0003DCAC
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x0003FAB4 File Offset: 0x0003DCB4
		internal virtual MaskedTextBox MaskedTextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0003FABD File Offset: 0x0003DCBD
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x0003FAC5 File Offset: 0x0003DCC5
		internal virtual PictureBox PictureBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0003FACE File Offset: 0x0003DCCE
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x0003FAD6 File Offset: 0x0003DCD6
		internal virtual TreeView TreeView10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x0003FADF File Offset: 0x0003DCDF
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x0003FAE7 File Offset: 0x0003DCE7
		internal virtual Button Button32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0003FAF0 File Offset: 0x0003DCF0
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x0003FAF8 File Offset: 0x0003DCF8
		internal virtual MonthCalendar MonthCalendar10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x0003FB01 File Offset: 0x0003DD01
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x0003FB09 File Offset: 0x0003DD09
		internal virtual PictureBox PictureBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0003FB12 File Offset: 0x0003DD12
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x0003FB1A File Offset: 0x0003DD1A
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0003FB23 File Offset: 0x0003DD23
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x0003FB2B File Offset: 0x0003DD2B
		internal virtual LinkLabel LinkLabel20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0003FB34 File Offset: 0x0003DD34
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x0003FB3C File Offset: 0x0003DD3C
		internal virtual ComboBox ComboBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0003FB45 File Offset: 0x0003DD45
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x0003FB4D File Offset: 0x0003DD4D
		internal virtual DateTimePicker DateTimePicker17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x0003FB56 File Offset: 0x0003DD56
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x0003FB5E File Offset: 0x0003DD5E
		internal virtual CheckedListBox CheckedListBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x0003FB67 File Offset: 0x0003DD67
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x0003FB6F File Offset: 0x0003DD6F
		internal virtual Button Button33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0003FB78 File Offset: 0x0003DD78
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x0003FB80 File Offset: 0x0003DD80
		internal virtual LinkLabel LinkLabel21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0003FB89 File Offset: 0x0003DD89
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x0003FB91 File Offset: 0x0003DD91
		internal virtual Button Button34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0003FB9A File Offset: 0x0003DD9A
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x0003FBA2 File Offset: 0x0003DDA2
		internal virtual ComboBox ComboBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0003FBAB File Offset: 0x0003DDAB
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x0003FBB3 File Offset: 0x0003DDB3
		internal virtual ComboBox ComboBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0003FBBC File Offset: 0x0003DDBC
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x0003FBC4 File Offset: 0x0003DDC4
		internal virtual MaskedTextBox MaskedTextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0003FBCD File Offset: 0x0003DDCD
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x0003FBD5 File Offset: 0x0003DDD5
		internal virtual PictureBox PictureBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0003FBDE File Offset: 0x0003DDDE
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x0003FBE6 File Offset: 0x0003DDE6
		internal virtual WebBrowser WebBrowser8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0003FBEF File Offset: 0x0003DDEF
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x0003FBF7 File Offset: 0x0003DDF7
		internal virtual TreeView TreeView11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0003FC00 File Offset: 0x0003DE00
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x0003FC08 File Offset: 0x0003DE08
		internal virtual Button Button35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0003FC11 File Offset: 0x0003DE11
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x0003FC19 File Offset: 0x0003DE19
		internal virtual CheckBox CheckBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0003FC22 File Offset: 0x0003DE22
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x0003FC2A File Offset: 0x0003DE2A
		internal virtual DateTimePicker DateTimePicker18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0003FC33 File Offset: 0x0003DE33
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x0003FC3B File Offset: 0x0003DE3B
		internal virtual ListView ListView8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0003FC44 File Offset: 0x0003DE44
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x0003FC4C File Offset: 0x0003DE4C
		internal virtual MonthCalendar MonthCalendar11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0003FC55 File Offset: 0x0003DE55
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x0003FC5D File Offset: 0x0003DE5D
		internal virtual LinkLabel LinkLabel22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0003FC66 File Offset: 0x0003DE66
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x0003FC6E File Offset: 0x0003DE6E
		internal virtual DateTimePicker DateTimePicker19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0003FC77 File Offset: 0x0003DE77
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x0003FC7F File Offset: 0x0003DE7F
		internal virtual CheckedListBox CheckedListBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0003FC88 File Offset: 0x0003DE88
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x0003FC90 File Offset: 0x0003DE90
		internal virtual Button Button36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0003FC99 File Offset: 0x0003DE99
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x0003FCA1 File Offset: 0x0003DEA1
		internal virtual LinkLabel LinkLabel23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0003FCAA File Offset: 0x0003DEAA
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x0003FCB2 File Offset: 0x0003DEB2
		internal virtual Button Button37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0003FCBB File Offset: 0x0003DEBB
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x0003FCC3 File Offset: 0x0003DEC3
		internal virtual ComboBox ComboBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0003FCCC File Offset: 0x0003DECC
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x0003FCD4 File Offset: 0x0003DED4
		internal virtual ComboBox ComboBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0003FCDD File Offset: 0x0003DEDD
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x0003FCE5 File Offset: 0x0003DEE5
		internal virtual MaskedTextBox MaskedTextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0003FCEE File Offset: 0x0003DEEE
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x0003FCF6 File Offset: 0x0003DEF6
		internal virtual PictureBox PictureBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0003FCFF File Offset: 0x0003DEFF
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x0003FD07 File Offset: 0x0003DF07
		internal virtual WebBrowser WebBrowser9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0003FD10 File Offset: 0x0003DF10
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x0003FD18 File Offset: 0x0003DF18
		internal virtual TreeView TreeView12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0003FD21 File Offset: 0x0003DF21
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x0003FD29 File Offset: 0x0003DF29
		internal virtual Button Button38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0003FD32 File Offset: 0x0003DF32
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x0003FD3A File Offset: 0x0003DF3A
		internal virtual CheckBox CheckBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0003FD43 File Offset: 0x0003DF43
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x0003FD4B File Offset: 0x0003DF4B
		internal virtual DateTimePicker DateTimePicker20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0003FD54 File Offset: 0x0003DF54
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x0003FD5C File Offset: 0x0003DF5C
		internal virtual ListView ListView9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0003FD65 File Offset: 0x0003DF65
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x0003FD6D File Offset: 0x0003DF6D
		internal virtual MonthCalendar MonthCalendar12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0003FD76 File Offset: 0x0003DF76
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x0003FD7E File Offset: 0x0003DF7E
		internal virtual PictureBox PictureBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0003FD87 File Offset: 0x0003DF87
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x0003FD8F File Offset: 0x0003DF8F
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0003FD98 File Offset: 0x0003DF98
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x0003FDA0 File Offset: 0x0003DFA0
		internal virtual LinkLabel LinkLabel24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0003FDA9 File Offset: 0x0003DFA9
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x0003FDB1 File Offset: 0x0003DFB1
		internal virtual ComboBox ComboBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x0003FDBA File Offset: 0x0003DFBA
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x0003FDC2 File Offset: 0x0003DFC2
		internal virtual DateTimePicker DateTimePicker21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x0003FDCB File Offset: 0x0003DFCB
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x0003FDD3 File Offset: 0x0003DFD3
		internal virtual CheckedListBox CheckedListBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0003FDDC File Offset: 0x0003DFDC
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x0003FDE4 File Offset: 0x0003DFE4
		internal virtual Button Button39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0003FDED File Offset: 0x0003DFED
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x0003FDF5 File Offset: 0x0003DFF5
		internal virtual Button Button40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000D22 RID: 3362 RVA: 0x0003FE00 File Offset: 0x0003E000
		private void Ingratek_Load(object sender, EventArgs e)
		{
			base.Hide();
			base.Visible = false;
			Thread.Sleep(5000);
			Form123.LotarMemoria();
			string replacement = "oisurhcvsb785fsi4h5bp0s87";
			int num = 1;
			checked
			{
				do
				{
					Strings.Replace(Form123.LotarMemoria(), "a", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "b", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "c", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "e", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "f", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "g", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "h", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "i", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "j", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "k", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "l", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "m", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "n", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "o", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "p", replacement, 1, -1, CompareMethod.Binary);
					Strings.Replace(Form123.LotarMemoria(), "q", replacement, 1, -1, CompareMethod.Binary);
					num++;
				}
				while (num <= 30);
				MyProject.Forms.Rubri.Show();
			}
		}

		// Token: 0x0400059A RID: 1434
		private IContainer components;
	}
}
