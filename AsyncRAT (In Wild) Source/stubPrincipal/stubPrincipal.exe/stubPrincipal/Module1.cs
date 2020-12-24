using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using stubPrincipal.xlsgen;

namespace stubPrincipal
{
	// Token: 0x0200001C RID: 28
	[StandardModule]
	internal sealed class Module1
	{
		// Token: 0x06000D5C RID: 3420 RVA: 0x000431F8 File Offset: 0x000413F8
		public static void Main()
		{
			string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=sampledatabase.mdb";
			OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
			try
			{
				oleDbConnection.Open();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
			object value = "select * from Datasource";
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
			oleDbDataAdapter.SelectCommand = new OleDbCommand(Conversions.ToString(value), oleDbConnection);
			DataSet dataSet = new DataSet();
			oleDbDataAdapter.Fill(dataSet);
			Console.WriteLine("Database dump\\n-------------");
			try
			{
				foreach (object obj in dataSet.Tables)
				{
					DataTable dataTable = (DataTable)obj;
					Console.WriteLine(dataTable.TableName);
					try
					{
						foreach (object obj2 in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj2;
							try
							{
								foreach (object obj3 in dataTable.Columns)
								{
									DataColumn column = (DataColumn)obj3;
									if (dataRow[column] != null)
									{
										Console.Write(" " + dataRow[column].ToString());
									}
								}
							}
							finally
							{
								IEnumerator enumerator3;
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
							Console.WriteLine();
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			CoXlsEngine o = (CoXlsEngine)Interaction.CreateObject("ExcelGenerator.ARsTDesign", "");
			IXlsWorkbook xlsWorkbook;
			IXlsWorksheet xlsWorksheet = xlsWorkbook.get_AddWorksheet("Sheet1");
			IXlsStyle xlsStyle = null;
			DataTable dataTable2 = dataSet.Tables[0];
			object obj4 = dataTable2.Columns.Count;
			try
			{
				foreach (object obj5 in dataTable2.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj5;
					object left = 0;
					try
					{
						foreach (object obj6 in dataTable2.Rows)
						{
							DataRow dataRow2 = (DataRow)obj6;
							string text = dataColumn.DataType.ToString();
							uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
							if (num <= 1697786220U)
							{
								if (num <= 875577056U)
								{
									if (num != 347085918U)
									{
										if (num != 848225627U)
										{
											if (num == 875577056U)
											{
												if (Operators.CompareString(text, "System.UInt64", false) == 0)
												{
													DataRow dataRow3 = (DataRow)dataRow2[dataColumn];
												}
											}
										}
										else if (Operators.CompareString(text, "System.Double", false) == 0)
										{
											DataRow dataRow4 = (DataRow)dataRow2[dataColumn];
										}
									}
									else if (Operators.CompareString(text, "System.Boolean", false) == 0)
									{
										DataRow dataRow5 = (DataRow)dataRow2[dataColumn];
									}
								}
								else if (num <= 1103422971U)
								{
									if (num != 942540437U)
									{
										if (num == 1103422971U)
										{
											if (Operators.CompareString(text, "System.TimeSpan", false) == 0)
											{
												if (xlsStyle == null)
												{
													xlsStyle = xlsWorksheet.NewStyle();
												}
												xlsStyle.Apply();
												DataRow dataRow6 = (DataRow)dataRow2[dataColumn];
											}
										}
									}
									else if (Operators.CompareString(text, "System.UInt16", false) == 0)
									{
										DataRow dataRow7 = (DataRow)dataRow2[dataColumn];
									}
								}
								else if (num != 1541528931U)
								{
									if (num == 1697786220U)
									{
										if (Operators.CompareString(text, "System.Int16", false) == 0)
										{
											DataRow dataRow8 = (DataRow)dataRow2[dataColumn];
										}
									}
								}
								else if (Operators.CompareString(text, "System.DateTime", false) == 0)
								{
									if (xlsStyle == null)
									{
										xlsStyle = xlsWorksheet.NewStyle();
									}
									xlsStyle.Apply();
									DataRow dataRow9 = (DataRow)dataRow2[dataColumn];
								}
							}
							else if (num <= 2249825754U)
							{
								if (num <= 1764058053U)
								{
									if (num != 1741144581U)
									{
										if (num == 1764058053U)
										{
											if (Operators.CompareString(text, "System.Int64", false) == 0)
											{
												DataRow dataRow10 = (DataRow)dataRow2[dataColumn];
											}
										}
									}
									else if (Operators.CompareString(text, "System.Decimal", false) == 0)
									{
										DataRow dataRow11 = (DataRow)dataRow2[dataColumn];
									}
								}
								else if (num != 2185383742U)
								{
									if (num == 2249825754U)
									{
										if (Operators.CompareString(text, "System.Char", false) == 0)
										{
											DataRow dataRow12 = (DataRow)dataRow2[dataColumn];
										}
									}
								}
								else if (Operators.CompareString(text, "System.Single", false) == 0)
								{
									DataRow dataRow13 = (DataRow)dataRow2[dataColumn];
								}
							}
							else if (num <= 3079944380U)
							{
								if (num != 2747029693U)
								{
									if (num == 3079944380U)
									{
										if (Operators.CompareString(text, "System.Byte", false) == 0)
										{
											DataRow dataRow14 = (DataRow)dataRow2[dataColumn];
										}
									}
								}
								else if (Operators.CompareString(text, "System.SByte", false) == 0)
								{
									DataRow dataRow15 = (DataRow)dataRow2[dataColumn];
								}
							}
							else if (num != 3291009739U)
							{
								if (num == 4180476474U)
								{
									if (Operators.CompareString(text, "System.Int32", false) == 0)
									{
										DataRow dataRow16 = (DataRow)dataRow2[dataColumn];
									}
								}
							}
							else if (Operators.CompareString(text, "System.UInt32", false) == 0)
							{
								DataRow dataRow17 = (DataRow)dataRow2[dataColumn];
							}
							left = Operators.AddObject(left, 1);
						}
					}
					finally
					{
						IEnumerator enumerator5;
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator4;
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
			}
			xlsWorkbook.Close();
			oleDbConnection.Close();
			Marshal.ReleaseComObject(o);
		}
	}
}
