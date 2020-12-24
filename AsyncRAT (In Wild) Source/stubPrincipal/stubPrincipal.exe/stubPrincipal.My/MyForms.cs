using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using stubPrincipal;
using stubPrincipal.My;

// Token: 0x02000028 RID: 40
[EditorBrowsable(EditorBrowsableState.Never)]
[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
internal sealed class MyForms
{
	// Token: 0x06001073 RID: 4211 RVA: 0x000517C4 File Offset: 0x0004F9C4
	[DebuggerHidden]
	private static T Create__Instance__<T>(T Instance) where T : Form, new()
	{
		if (Instance == null || Instance.IsDisposed)
		{
			if (MyProject.MyForms.m_FormBeingCreated != null)
			{
				if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(!!0)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				MyProject.MyForms.m_FormBeingCreated = new Hashtable();
			}
			MyProject.MyForms.m_FormBeingCreated.Add(typeof(!!0), null);
			try
			{
				return Activator.CreateInstance<T>();
			}
			catch (TargetInvocationException ex) when (ex.InnerException != null)
			{
				throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[]
				{
					ex.InnerException.Message
				}), ex.InnerException);
			}
			finally
			{
				MyProject.MyForms.m_FormBeingCreated.Remove(typeof(!!0));
			}
		}
		return Instance;
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x000518C8 File Offset: 0x0004FAC8
	[DebuggerHidden]
	private void Dispose__Instance__<T>(ref T instance) where T : Form
	{
		instance.Dispose();
		instance = default(!!0);
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x000518DD File Offset: 0x0004FADD
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyForms()
	{
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x000518E5 File Offset: 0x0004FAE5
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool Equals(object o)
	{
		return base.Equals(RuntimeHelpers.GetObjectValue(o));
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x000518F3 File Offset: 0x0004FAF3
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x000518FB File Offset: 0x0004FAFB
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal new Type GetType()
	{
		return typeof(MyProject.MyForms);
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x00051907 File Offset: 0x0004FB07
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override string ToString()
	{
		return base.ToString();
	}

	// Token: 0x170007EF RID: 2031
	// (get) Token: 0x0600107A RID: 4218 RVA: 0x0005190F File Offset: 0x0004FB0F
	// (set) Token: 0x06001083 RID: 4227 RVA: 0x000519F0 File Offset: 0x0004FBF0
	public Bereta Bereta
	{
		get
		{
			this.m_Bereta = MyProject.MyForms.Create__Instance__<Bereta>(this.m_Bereta);
			return this.m_Bereta;
		}
		set
		{
			if (value != this.m_Bereta)
			{
				if (value != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				this.Dispose__Instance__<Bereta>(ref this.m_Bereta);
			}
		}
	}

	// Token: 0x170007F0 RID: 2032
	// (get) Token: 0x0600107B RID: 4219 RVA: 0x00051928 File Offset: 0x0004FB28
	// (set) Token: 0x06001084 RID: 4228 RVA: 0x00051A15 File Offset: 0x0004FC15
	public Form1 Form1
	{
		get
		{
			this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
			return this.m_Form1;
		}
		set
		{
			if (value != this.m_Form1)
			{
				if (value != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				this.Dispose__Instance__<Form1>(ref this.m_Form1);
			}
		}
	}

	// Token: 0x170007F1 RID: 2033
	// (get) Token: 0x0600107C RID: 4220 RVA: 0x00051941 File Offset: 0x0004FB41
	// (set) Token: 0x06001085 RID: 4229 RVA: 0x00051A3A File Offset: 0x0004FC3A
	public Form123 Form123
	{
		get
		{
			this.m_Form123 = MyProject.MyForms.Create__Instance__<Form123>(this.m_Form123);
			return this.m_Form123;
		}
		set
		{
			if (value != this.m_Form123)
			{
				if (value != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				this.Dispose__Instance__<Form123>(ref this.m_Form123);
			}
		}
	}

	// Token: 0x170007F2 RID: 2034
	// (get) Token: 0x0600107D RID: 4221 RVA: 0x0005195A File Offset: 0x0004FB5A
	// (set) Token: 0x06001086 RID: 4230 RVA: 0x00051A5F File Offset: 0x0004FC5F
	public Form1656 Form1656
	{
		get
		{
			this.m_Form1656 = MyProject.MyForms.Create__Instance__<Form1656>(this.m_Form1656);
			return this.m_Form1656;
		}
		set
		{
			if (value != this.m_Form1656)
			{
				if (value != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				this.Dispose__Instance__<Form1656>(ref this.m_Form1656);
			}
		}
	}

	// Token: 0x170007F3 RID: 2035
	// (get) Token: 0x0600107E RID: 4222 RVA: 0x00051973 File Offset: 0x0004FB73
	// (set) Token: 0x06001087 RID: 4231 RVA: 0x00051A84 File Offset: 0x0004FC84
	public FormulaMagicaDaPaz FormulaMagicaDaPaz
	{
		get
		{
			this.m_FormulaMagicaDaPaz = MyProject.MyForms.Create__Instance__<FormulaMagicaDaPaz>(this.m_FormulaMagicaDaPaz);
			return this.m_FormulaMagicaDaPaz;
		}
		set
		{
			if (value != this.m_FormulaMagicaDaPaz)
			{
				if (value != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				this.Dispose__Instance__<FormulaMagicaDaPaz>(ref this.m_FormulaMagicaDaPaz);
			}
		}
	}

	// Token: 0x170007F4 RID: 2036
	// (get) Token: 0x0600107F RID: 4223 RVA: 0x0005198C File Offset: 0x0004FB8C
	// (set) Token: 0x06001088 RID: 4232 RVA: 0x00051AA9 File Offset: 0x0004FCA9
	public FormularioDoCrime FormularioDoCrime
	{
		get
		{
			this.m_FormularioDoCrime = MyProject.MyForms.Create__Instance__<FormularioDoCrime>(this.m_FormularioDoCrime);
			return this.m_FormularioDoCrime;
		}
		set
		{
			if (value != this.m_FormularioDoCrime)
			{
				if (value != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				this.Dispose__Instance__<FormularioDoCrime>(ref this.m_FormularioDoCrime);
			}
		}
	}

	// Token: 0x170007F5 RID: 2037
	// (get) Token: 0x06001080 RID: 4224 RVA: 0x000519A5 File Offset: 0x0004FBA5
	// (set) Token: 0x06001089 RID: 4233 RVA: 0x00051ACE File Offset: 0x0004FCCE
	public Ingratek Ingratek
	{
		get
		{
			this.m_Ingratek = MyProject.MyForms.Create__Instance__<Ingratek>(this.m_Ingratek);
			return this.m_Ingratek;
		}
		set
		{
			if (value != this.m_Ingratek)
			{
				if (value != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				this.Dispose__Instance__<Ingratek>(ref this.m_Ingratek);
			}
		}
	}

	// Token: 0x170007F6 RID: 2038
	// (get) Token: 0x06001081 RID: 4225 RVA: 0x000519BE File Offset: 0x0004FBBE
	// (set) Token: 0x0600108A RID: 4234 RVA: 0x00051AF3 File Offset: 0x0004FCF3
	public MainForm MainForm
	{
		get
		{
			this.m_MainForm = MyProject.MyForms.Create__Instance__<MainForm>(this.m_MainForm);
			return this.m_MainForm;
		}
		set
		{
			if (value != this.m_MainForm)
			{
				if (value != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				this.Dispose__Instance__<MainForm>(ref this.m_MainForm);
			}
		}
	}

	// Token: 0x170007F7 RID: 2039
	// (get) Token: 0x06001082 RID: 4226 RVA: 0x000519D7 File Offset: 0x0004FBD7
	// (set) Token: 0x0600108B RID: 4235 RVA: 0x00051B18 File Offset: 0x0004FD18
	public Rubri Rubri
	{
		get
		{
			this.m_Rubri = MyProject.MyForms.Create__Instance__<Rubri>(this.m_Rubri);
			return this.m_Rubri;
		}
		set
		{
			if (value != this.m_Rubri)
			{
				if (value != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				this.Dispose__Instance__<Rubri>(ref this.m_Rubri);
			}
		}
	}

	// Token: 0x0400080B RID: 2059
	[ThreadStatic]
	private static Hashtable m_FormBeingCreated;

	// Token: 0x0400080C RID: 2060
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Bereta m_Bereta;

	// Token: 0x0400080D RID: 2061
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Form1 m_Form1;

	// Token: 0x0400080E RID: 2062
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Form123 m_Form123;

	// Token: 0x0400080F RID: 2063
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Form1656 m_Form1656;

	// Token: 0x04000810 RID: 2064
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FormulaMagicaDaPaz m_FormulaMagicaDaPaz;

	// Token: 0x04000811 RID: 2065
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FormularioDoCrime m_FormularioDoCrime;

	// Token: 0x04000812 RID: 2066
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Ingratek m_Ingratek;

	// Token: 0x04000813 RID: 2067
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MainForm m_MainForm;

	// Token: 0x04000814 RID: 2068
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Rubri m_Rubri;
}
