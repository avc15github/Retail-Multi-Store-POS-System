using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using OfficeOpenXml;
using System.Windows.Forms;
using System.Linq;
using Import_Data_FromExcel;

namespace ImportVendorData_FromExcel
{
   public class Import_VendorMaster
   {
       string connectionstring;
       string excelfile;
       string branchid;
       string companyid;
       string fcyrid;
       string sql;
       Int16 importuser;
       TextBox txtstatus;
       TextBox txterrorstatus;
       Boolean ignoreerror;
       DateTime sqldt;
       Boolean stopimport;

       System.IO.StreamWriter sw;

       List<ImportCustomerColumns> cols;

       Boolean isInsert;
       Boolean isUpdate;


       Int32 excelrowline = 0;
       string itemseries = "";
       string barcode = "";
       string eanbarcode = "";
       string sectkey = "";
       Int32 itemid = 0;
       string itemkey = "";
       string itemgrpkey = "";
       string itemsubgrpkey = "";
       string brandkey = "";
       string rackkey = "";
       string unitkey = "";
       string itemmisckey = "";
       string qltykey = "";
       string itemsizekey = "";
       string stylekey = "";
       decimal purrate = 0;
       decimal mrp = 0;
       decimal salerate = 0;
       string errortext = "";
       string product = "";

       string COBRLocationID = "";


       string Ledger = "";
       Int32 LedID = 0;
       Int32 Ledkey = 0;
       Int32 StnKey = 0;
       Int32 PartyGrpKey = 0;
       Int32 AccLGrpKey = 0;
       Int32 CurrnID = 0;
       Int32 PytTermDiscKey = 0;
       Int32 CCBanKey = 0;
       Int32 CardTypeID = 0;
       Int32 RefLed_ID = 0;
       Int32 StateKey = 0;
       Int32 CountryKey = 0;
       String Alt_Code = "";

       public Boolean StopImport
       {
           get { return stopimport; }
           set { stopimport = value; }
       }

       public string ConnectionString
       {
           get { return connectionstring; }
           set { connectionstring = value; }
       }

       public string ExcelFile
       {
           get { return excelfile; }
           set { excelfile = value; }
       }

       public string CompanyId
       {
           get { return companyid; }
           set { companyid = value; }
       }

       public string BranchId
       {
           get { return branchid; }
           set { branchid = value; }
       }

       public string FiscalYearId
       {
           get { return fcyrid; }
           set { fcyrid = value; }
       }

       public Int16 ImportUser
       {
           get { return importuser; }
           set { importuser = value; }
       }

       public TextBox StatusTextbox
       {
           get { return txtstatus; }
           set { txtstatus = value; }
       }

       public TextBox StatusErrorTextbox
       {
           get { return txterrorstatus; }
           set { txterrorstatus = value; }
       }

       public Boolean IgnoreError
       {
           get { return ignoreerror; }
           set { ignoreerror = value; }
       }

       public Boolean IsImportFileInValid()
       {
           Boolean isinvalid = false;
           Int32 r = 1;

           try
           {
               string sheetname = "Ledger";
               ExcelPackage p = new ExcelPackage(new System.IO.FileInfo(excelfile));

               //ExcelPackage.LicenseContext = LicenseContext.NonCommercial
               ExcelWorksheet excelsht = p.Workbook.Worksheets[sheetname];

               if (excelsht == null)
               {
                   MessageBox.Show("Worksheet name [Ledger] not found in selected file.\r\nCannot continue !", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   return true;
               }

               ExcelCellAddress dimstart = excelsht.Dimension.Start;
               ExcelCellAddress dimend = excelsht.Dimension.End;


               string Ledname = "";
               string Abbr = "";
               string Currency = "";
               string StnName = "";
               string CountryName = "";
               string StateName = "";
               String AccLgrp = "";
               String StartDate = "";
               String TermDate = "";


               Int16 Lednamecol = 1;
               Int16 AbbrCol = 2;
               Int16 CurrencyCol = 4;
               Int16 Stnnamecol = 14;
               Int16 Countrycol = 13;
               Int16 Statecol = 14;
               Int16 AccLgrpCol = 54;
               Int16 StartDateCol = 8;
               Int16 TermDateCol = 9;
               //137
               for (r = 2; r <= dimend.Row; r++)
               {
                   txtstatus.Text = "Validating line number: " + (r - 1).ToString() + "\r\n";
                   Application.DoEvents();

                   if (stopimport)
                   {
                       if (MessageBox.Show("Do you want to STOP the import now ?", "UniRetail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                       {
                           MessageBox.Show("Import of file " + excelfile + " was interrupted by user.", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           return true;
                       }
                   }
                   Ledname = Convert.ToString(excelsht.Cells[r, Lednamecol].Value);
                   Abbr = Convert.ToString(excelsht.Cells[r, AbbrCol].Value);
                   //Currency = Convert.ToString(excelsht.Cells[r, CurrencyCol].Value);
                   StnName = Convert.ToString(excelsht.Cells[r, Stnnamecol].Value);
                   //CountryName = Convert.ToString(excelsht.Cells[r, Countrycol].Value);
                   //StateName = Convert.ToString(excelsht.Cells[r, Statecol].Value);
                   AccLgrp = Convert.ToString(excelsht.Cells[r, AccLgrpCol].Value);
                   //StartDate = Convert.ToString(excelsht.Cells[r, StartDateCol].Value);

                   //invalidcols = "";
                   isinvalid = false;
                   string lastcolumnname = "";
                   lastcolumnname = excelsht.Cells[1, dimend.Column].Value.ToString();
                   if (lastcolumnname.ToLower() != "led_id")
                   {
                       //if (barcode.Trim().Length == 0)
                       //{
                       //    //invalidcols += "barcode, ";
                       //    isinvalid = true;
                       //}

                       if (Ledname.Trim().Length == 0)
                       {
                           //invalidcols += "Itemname, ";

                           isinvalid = true;
                           txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'LedgerName' is missing.";
                       }

                       else if (StnName.Trim().Length == 0)
                       {
                           //invalidcols += "Subgroup, ";
                           isinvalid = true;
                           txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'StationName' is missing.";
                       }

                       else if (Abbr.Trim().Length == 0)
                       {
                           isinvalid = true;
                           txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'Abbr' is missing.";
                       }
                       else if (AccLgrp.Trim().Length == 0)
                       {

                           isinvalid = true;
                           txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'AccLgrp' is missing.";
                       }

                       if (isinvalid)
                       {
                           //txtstatus.Text += "\r\n\r\nValidation error at row: " + (r-1).ToString();
                           txtstatus.Text += "";

                           //MessageBox.Show("Cannot continue data import as there are validation errors.\r\nKindly correct the error at LINE: " + (r - 1).ToString() + " and re-import", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                           MessageBox.Show("Cannot start Importing since there are errors while validating file.Please correct your data file.", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                           return true;
                       }
                   }
                   else
                   {

                       Int32 c = 1;
                       for (c = 1; c <= dimend.Column; c++)
                       {
                           if (excelsht.Cells[1, c].Value.ToString() == "Led_Name" || excelsht.Cells[1, c].Value.ToString() == "Abbr" || excelsht.Cells[1, c].Value.ToString() == "OStn_Key" || excelsht.Cells[1, c].Value.ToString() == "AccLGrp_Key")
                           {
                               if (Convert.ToString(excelsht.Cells[r, c].Value) == "")
                               {
                                   //isinvalid = true;
                                   txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of '" + excelsht.Cells[1, c].Value.ToString() + "' is missing. \r\n\r\n ";
                                   return true;
                               }
                           }
                       }
                   }
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace, "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return true;
           }

           return isinvalid;
       }

       public void ImportExcelFile()
       {
           try
           {
               txtstatus.AppendText("Start at: " + DateTime.Now.ToString("hh:mm:ss"));
               txtstatus.AppendText("\r\nReading import file...");

               Application.DoEvents();

               string sheetname = "Ledger";
               ExcelPackage p = new ExcelPackage(new System.IO.FileInfo(excelfile));

               //ExcelPackage.LicenseContext = LicenseContext.NonCommercial
               ExcelWorksheet excelsht = p.Workbook.Worksheets[sheetname];

               ExcelCellAddress dimstart = excelsht.Dimension.Start;
               ExcelCellAddress dimend = excelsht.Dimension.End;

               string lastcolumnname = "";

               lastcolumnname = excelsht.Cells[1, dimend.Column].Value.ToString();

               isInsert = false;
               isUpdate = false;
               if (lastcolumnname.ToLower() != "led_id")
               {
                   isInsert = true;
               }
               else
               {
                   isUpdate = true;
               }

               //sql = "Select ORDINAL_POSITION, COLUMN_NAME, DATA_TYPE ";
               //sql += " from INFORMATION_SCHEMA.COLUMNS ";
               //sql += " where TABLE_NAME = 'Item' ";
               //sql += " Union All ";
               //sql += "Select ORDINAL_POSITION, COLUMN_NAME, DATA_TYPE ";
               //sql += " from INFORMATION_SCHEMA.COLUMNS ";
               //sql += " where TABLE_NAME = 'UserFieldDataItem' ";
               //sql += " order by ORDINAL_POSITION";
               sql = "Select ORDINAL_POSITION, COLUMN_NAME, DATA_TYPE ";
               sql += " from INFORMATION_SCHEMA.COLUMNS ";
               sql += " where TABLE_NAME = 'Ledger' ";
               sql += " order by ORDINAL_POSITION";

               SqlDataAdapter db = new SqlDataAdapter(sql, new SqlConnection(connectionstring));
               DataTable dt = new DataTable();
               db.Fill(dt);

               cols = FillTableColumnsToList(dt);

               db = null;
               dt = null;

               if (isInsert)
               {
                   CreateEntryInTable(excelsht);
               }
               else if (isUpdate)
               {
                   UpdateEntryInTable(excelsht);
               }

               txtstatus.AppendText("\r\n\r\nEnd at: " + DateTime.Now.ToString("hh:mm:ss"));
           }

           catch (Exception ex)
           {
               MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace, "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void CreateEntryInTable(ExcelWorksheet excelsheet)
       {
           SqlTransaction trans = null;
           Int32 r = 1;
           Int32 c = 1;
           Boolean error = false;
           Boolean IgnorErrorExcel = false;
           try
           {
               string filepath = System.IO.Directory.GetCurrentDirectory() + "\\ImportLog.txt";
               sw = new System.IO.StreamWriter(filepath);

               ExcelCellAddress dimstart = excelsheet.Dimension.Start;
               ExcelCellAddress dimend = excelsheet.Dimension.End;

               string columnstring = "";
               string valuestring = "";

               string udfcolumnstring = "";
               string udfvaluestring = "";
               Boolean witherror = false;

               SqlConnection conn = new SqlConnection(connectionstring);
               conn.Open();

               for (r = 2; r <= dimend.Row; r++)
               {
                   if (stopimport)
                   {
                       if (MessageBox.Show("Do you want to STOP the import now ?", "UniRetail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                       {
                           MessageBox.Show("Import of file " + excelfile + " was interrupted by user.", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           return;
                       }
                       else
                       {
                           stopimport = false;
                       }
                   }

                   trans = conn.BeginTransaction();

                   errortext = "";
                   error = false;
                   excelrowline = r - 1;
                   columnstring = "";
                   valuestring = "";
                   udfcolumnstring = "";
                   udfvaluestring = "";
                   sectkey = "";
                   itemid = 0;
                   itemkey = "";
                   itemgrpkey = "";
                   itemsubgrpkey = "";
                   brandkey = "";
                   rackkey = "";
                   unitkey = "";
                   itemmisckey = "";
                   qltykey = "";
                   itemsizekey = "";
                   eanbarcode = "";
                   barcode = "";
                   itemseries = "";
                   purrate = 0;
                   mrp = 0;
                   salerate = 0;
                   product = "";

                   Ledger = "";
                   LedID = 0;
                   Ledkey = 0;
                   StnKey = 0;
                   PartyGrpKey = 0;
                   PytTermDiscKey = 0;
                   CCBanKey = 0;
                   StateKey = 0;
                   CountryKey = 0;

                   Application.DoEvents();
                   txtstatus.AppendText("\r\n\r\nReading row " + excelrowline.ToString() + "...");


                   if (ignoreerror)
                   {
                       string Ledname = "";
                       string Abbr = "";
                       string Currency = "";
                       string StnName = "";
                       string CountryName = "";
                       string StateName = "";
                       String AccLgrp = "";
                       String StartDate = "";
                       String TermDate = "";
                       String PartyGroup = "";


                       Int16 Lednamecol = 1;
                       Int16 AbbrCol = 2;
                       Int16 CurrencyCol = 4;
                       Int16 Stnnamecol = 14;
                       //Int16 Countrycol = 13;
                       //Int16 Statecol = 14;
                       Int16 AccLgrpCol = 54;
                       Int16 StartDateCol = 8;
                       Int16 TermDateCol = 9;
                       Int16 PartyGroupCol = 43;

                       Ledname = Convert.ToString(excelsheet.Cells[r, Lednamecol].Value);
                       Abbr = Convert.ToString(excelsheet.Cells[r, AbbrCol].Value);
                       //Currency = Convert.ToString(excelsheet.Cells[r, CurrencyCol].Value);
                       StnName = Convert.ToString(excelsheet.Cells[r, Stnnamecol].Value);
                       //CountryName = Convert.ToString(excelsheet.Cells[r, Countrycol].Value);
                       //StateName = Convert.ToString(excelsheet.Cells[r, Statecol].Value);
                       AccLgrp = Convert.ToString(excelsheet.Cells[r, AccLgrpCol].Value);
                       //StartDate = Convert.ToString(excelsheet.Cells[r, StartDateCol].Value);
                       //TermDate = Convert.ToString(excelsheet.Cells[r, TermDateCol].Value);
                       PartyGroup = Convert.ToString(excelsheet.Cells[r, PartyGroupCol].Value);

                       IgnorErrorExcel = false;
                       if (Ledname.Trim().Length == 0)
                       {
                           //invalidcols += "Itemname, ";

                           IgnorErrorExcel = true;
                           txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'LedgerName' is missing.\r\n\r\n";
                       }

                       else if (StnName.Trim().Length == 0)
                       {
                           //invalidcols += "Subgroup, ";
                           IgnorErrorExcel = true;
                           txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'StationName' is missing.\r\n\r\n";
                       }

                       else if (Abbr.Trim().Length == 0)
                       {

                           IgnorErrorExcel = true;
                           txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'Abbr' is missing.\r\n\r\n";
                       }
                       else if (AccLgrp.Trim().Length == 0)
                       {

                           IgnorErrorExcel = true;
                           txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'AccLgrp' is missing.\r\n\r\n";
                       }
                       else if (PartyGroup.Trim().Length == 0)
                       {

                           IgnorErrorExcel = true;
                           txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'PartyGrp_Key' is missing.\r\n\r\n";
                       }
                       if (IgnorErrorExcel)
                       {
                           trans.Rollback();
                           goto Err;
                       }

                   }

                   //sunil /05/08/2021

                   String Vendor = "";
                   String CurrencyName = "";
                   String CardType = "";
                   String RefLedID = "";
                   string Abbrr = "";
                   //String ReferenceNo = "";

                   Int16 VendorCol = 1;
                   Int16 AbbrrCol = 2;
                   Int16 CurrencyNameCol = 4;
                   Int16 CardTypeCol = 60;
                   Int16 RefLedIDCol = 70;
                   //Int16 ReferenceNoCol = 7;

                   String StartDt = "";
                   string TermDt = "";

                   Int16 StartDtCol = 109;
                   Int16 TermDtCol = 110;


                   string Stn_Name = "";
                   String Acc_Lgrp = "";
                   String Party_Group = "";



                   Int16 StnName_Col = 14;
                   Int16 Acc_LgrpCol = 54;
                   Int16 Party_GroupCol = 43;



                   Vendor = Convert.ToString(excelsheet.Cells[r, VendorCol].Value);
                   Abbrr = Convert.ToString(excelsheet.Cells[r, AbbrrCol].Value);
                   //Currency = Convert.ToString(excelsheet.Cells[r, CurrencyCol].Value);
                   Stn_Name = Convert.ToString(excelsheet.Cells[r, StnName_Col].Value);
                   //CountryName = Convert.ToString(excelsheet.Cells[r, Countrycol].Value);
                   //StateName = Convert.ToString(excelsheet.Cells[r, Statecol].Value);
                   Acc_Lgrp = Convert.ToString(excelsheet.Cells[r, Acc_LgrpCol].Value);
                   //StartDate = Convert.ToString(excelsheet.Cells[r, StartDateCol].Value);
                   //TermDate = Convert.ToString(excelsheet.Cells[r, TermDateCol].Value);
                   Party_Group = Convert.ToString(excelsheet.Cells[r, Party_GroupCol].Value);


                   String StoreLoc = "";
                   Int16 StoreLocCol = 10;
                   StoreLoc = Convert.ToString(excelsheet.Cells[r, StoreLocCol].Value);

                   StartDt = Convert.ToString(excelsheet.Cells[r, StartDtCol].Value);
                   TermDt = Convert.ToString(excelsheet.Cells[r, TermDtCol].Value);

                   IgnorErrorExcel = false;

                   if (Vendor.Trim().Length == 0)
                   {
                       //invalidcols += "Itemname, ";

                       IgnorErrorExcel = true;
                       txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'LedgerName' is missing.\r\n\r\n";
                   }

                   else if (Stn_Name.Trim().Length == 0)
                   {
                       //invalidcols += "Subgroup, ";
                       IgnorErrorExcel = true;
                       txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'StationName' is missing.\r\n\r\n";
                   }

                   else if (Abbrr.Trim().Length == 0)
                   {

                       IgnorErrorExcel = true;
                       txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'Abbr' is missing.\r\n\r\n";
                   }
                   else if (Acc_Lgrp.Trim().Length == 0)
                   {

                       IgnorErrorExcel = true;
                       txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'AccLgrp' is missing.\r\n\r\n";
                   }
                   else if (Party_Group.Trim().Length == 0)
                   {

                       IgnorErrorExcel = true;
                       txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'PartyGrp_Key' is missing.\r\n\r\n";
                   }
                   if (IgnorErrorExcel)
                   {
                       trans.Rollback();
                       goto Err;
                   }

                   if (TermDt != "")
                   {
                       if (Convert.ToDateTime(StartDt) > Convert.ToDateTime(TermDt))
                       {
                           txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No: " + (r - 1).ToString() + " Start Date cannot be greater than terminate date \r\n\r\n";
                           trans.Rollback();
                           goto Err;
                       }
                   }

                   Vendor = Convert.ToString(excelsheet.Cells[r, VendorCol].Value);
                   sql = "Select Led_name From Ledger Where Ledger.Led_name = '" + Vendor + "' And Led_cat='V' ";
                   DataTable dt1 = null;
                   error = GetTable(sql, trans, ref dt1);
                   if (dt1.Rows.Count > 0)
                   {
                       txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No: " + (r - 1).ToString() + "  Vendor '" + Vendor + "' Already Exists \r\n\r\n";
                       trans.Rollback();
                       goto Err;
                   }

                   CardType = Convert.ToString(excelsheet.Cells[r, CardTypeCol].Value);
                   sql = "Select CardType_Name From CardType Where CardType.CardType_Name = '" + CardType + "'";
                   DataTable dt3 = null;
                   error = GetTable(sql, trans, ref dt3);
                   if (dt3.Rows.Count == 0)
                   {
                       txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No: " + (r - 1).ToString() + " CardType '" + CardType + "' Not Created \r\n\r\n";
                       trans.Rollback();
                       goto Err;
                   }

                   Stn_Name = Convert.ToString(excelsheet.Cells[r, StnName_Col].Value);
                   sql = "Select Stn_Name From Station Where Station.Stn_Name = '" + Stn_Name + "'";
                   DataTable dt4 = null;
                   error = GetTable(sql, trans, ref dt4);
                   if (dt4.Rows.Count == 0)
                   {
                       txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No: " + (r - 1).ToString() + " Station '" + Stn_Name + "' Not Created \r\n\r\n";
                       trans.Rollback();
                       goto Err;
                   }
                   Acc_Lgrp = Convert.ToString(excelsheet.Cells[r, Acc_LgrpCol].Value);
                   sql = "Select AccLgrp_Name From AccLgrp Where AccLgrp.AccLgrp_Name = '" + Acc_Lgrp + "'";
                   DataTable dt5 = null;
                   error = GetTable(sql, trans, ref dt5);
                   if (dt5.Rows.Count == 0)
                   {
                       txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No: " + (r - 1).ToString() + " AccLgrp '" + Acc_Lgrp + "' Not Created \r\n\r\n";
                       trans.Rollback();
                       goto Err;
                   }
                   Party_Group = Convert.ToString(excelsheet.Cells[r, Party_GroupCol].Value);
                   sql = "Select Grp_Name From PartyGroup Where PartyGroup.Grp_Name = '" + Party_Group + "'";
                   DataTable dt6 = null;
                   error = GetTable(sql, trans, ref dt6);
                   if (dt6.Rows.Count == 0)
                   {
                       txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No: " + (r - 1).ToString() + " PartyGroup '" + Party_Group + "' Not Created \r\n\r\n";
                       trans.Rollback();
                       goto Err;
                   }

                   Ledger = Convert.ToString(excelsheet.Cells[r, 1].Value);
                   for (c = 1; c <= dimend.Column; c++)
                   {
                       error = ReadAndCreate(excelsheet, r, c, trans, ref columnstring, ref valuestring, ref udfcolumnstring, ref udfvaluestring, ref LedID, ref Ledkey);
                   }

                   if (error)
                   {
                       //txterrorstatus.AppendText(errortext);
                       AppendErrorText();

                       if (!ignoreerror)
                       {
                           break;
                       }
                   }

                   if (columnstring.EndsWith(","))
                   {
                       columnstring = columnstring.Substring(0, columnstring.Length - 1);
                   }

                   if (valuestring.EndsWith(","))
                   {
                       valuestring = valuestring.Substring(0, valuestring.Length - 1);
                   }

                   if (udfcolumnstring.EndsWith(","))
                   {
                       udfcolumnstring = "," + udfcolumnstring.Substring(0, udfcolumnstring.Length - 1);
                   }

                   if (udfvaluestring.EndsWith(","))
                   {
                       udfvaluestring = "," + udfvaluestring.Substring(0, udfvaluestring.Length - 1);
                   }

                   error = NewRecordId("Ledger", "Led_id", trans, ref LedID);

                   if (error)
                   {
                       //txterrorstatus.AppendText(errortext);
                       AppendErrorText();

                       if (!ignoreerror)
                       {
                           break;
                       }
                   }

                   Ledkey = LedID;

                   DateTime dttime = new DateTime(1900, 01, 01);
                   error = GetSQLDatetime(trans, ref dttime);

                   //valuestring += "'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "',";
                   //columnstring += ",CHILDRENS,CASH_DISC_PERC,RDOFF,Stop_Dispatch ,REASON,OPBAL,OPDATE,CLBAL ";
                   //valuestring += ",0," + Convert.ToDecimal("0.00") + ",'0','0',''," + Convert.ToDecimal("0.00") + ",cast('" + DateTime.Now.ToString("MM/dd/yyyy") + "' as datetime2)," + Convert.ToDecimal("0.00") + " ";
                   //columnstring += ",CostCtr_Appbl,LastTransAmt,TotTransAmt,Bill_Id,ServTax_ID,SERVTAX_NO,OpSaleAmt,Dept_ID,Degn_ID,RateCat_Id,Tax_ID,FORMTYPE,SplMkDown,TDS_ID,TDSRate,TDSRdOff,AskRate ";
                   //valuestring += ",'0'," + Convert.ToDecimal("0.00") + ", " + Convert.ToDecimal("0.00") + ",0, 0,''," + Convert.ToDecimal("0.00") + ",0,0,0,0,'N'," + Convert.ToDecimal("0.00") + ",0," + Convert.ToDecimal("0.00") + ",'0','0'";
                   //columnstring += ",LOC_ID,ByDef_Tax,sales_Led_ID,Distr_Led_ID,FRANCHISEE_CODE,Allo_CoBr_id,Type_Inve,Pur_TaxID,Spcomm_Perc,BSR_CODE,Excise_Applicable,TRSP_REMARKS,AdharNo ,CUSTBRAND_ID,Dispatch_Order,STPDATE,DISPATCHDATE,DispOrderReason,PoBoxNo,LEVEL_TYPE,LEVELEMP_TYPE,APPROVAL";
                   //valuestring += ",0,0,0,0,'','','',0," + Convert.ToDecimal("0.00") + ",'','0','','',0,'0','1900-01-01 00:00:00.000','1900-01-01 00:00:00.000','','','1','','0' ";
                   //columnstring += ", Export,Revcm,Trsp_Dist,JOBBER_TYPE,TAX_PERC,REG_TYPE,PARTY_TYPE,ADDSUBTRACT,CALCULATIVE,ApplySalePur";
                   //valuestring += ",'0','0'," + Convert.ToDecimal("0.000") + ",'P', " + Convert.ToDecimal("0.00") + ",'','','','','' ";

                   columnstring = " Cobr_id,Led_id ,Led_Key, " + columnstring + " ,Status, Created_by, Created_dt,Updated_by,Updated_dt  ";
                   valuestring = "'" + branchid + "'," + Ledkey + ",'" + branchid + Ledkey + "'," + valuestring + ",1," + importuser + ",cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),NULL,NULL ";


                   sql = "Insert into Ledger (" + columnstring + ") values (" + valuestring + ")";
                   //Console.WriteLine(sql);
                   sw.WriteLine(sql);
                   error = ExecuteQuery(sql, trans);

                   if (error)
                   {
                       //txterrorstatus.AppendText(errortext);
                       AppendErrorText();

                       if (!ignoreerror)
                       {
                           break;
                       }
                   }


                   Int32 newid = 0;
                   error = NewRecordId("UserFieldDataCustomer", "UserFieldDataCustomer_Id", trans, ref newid);

                   if (error)
                   {
                       //txterrorstatus.AppendText(errortext);
                       AppendErrorText();

                       if (!ignoreerror)
                       {
                           break;
                       }
                   }

                   //dttime = new DateTime(1900, 01, 01);

                   //error = GetSQLDatetime(trans, ref dttime);

                   //if (error)
                   //{
                   //    //txterrorstatus.AppendText(errortext);
                   //    AppendErrorText();

                   //    if (!ignoreerror)
                   //    {
                   //        break;
                   //    }
                   //}



                   //sql = "Insert into UserFieldDataCustomer (UserFieldDataCustomer_Id, Cust_ID, MachName, Created_By, Created_Dt,Updated_By, Updated_Dt" + udfcolumnstring + ") ";
                   //sql += " values (" + newid + "," + Ledkey + ",'" + Environment.MachineName + "'," + importuser + ",'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "',0,'01/01/1900' " + udfvaluestring + ")";
                   //error = ExecuteQuery(sql, trans);

                   //if (error)
                   //{
                   //    //txterrorstatus.AppendText(errortext);
                   //    AppendErrorText();

                   //    if (!ignoreerror)
                   //    {
                   //        break;
                   //    }
                   //}



                   if (error)
                   {
                       witherror = true;

                       if (trans.Connection != null)
                       {
                           trans.Rollback();
                       }
                   }
                   else
                   {
                       trans.Commit();

                       txtstatus.AppendText("\r\nVendor : " + Ledger + " updated successfully");
                   }
               Err:
                   Application.DoEvents();
               }

               cols = null;

               string finalmessage = "Import of " + excelfile + " completed successfully";
               if (witherror)
               {
                   finalmessage = "Import of " + excelfile + " completed with errors";
               }

               MessageBox.Show(finalmessage, "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

           catch (SqlException sqlex)
           {
               errortext = sqlex.Message + "\r\n\r\n";
               trans.Rollback();
           }
           catch (Exception ex)
           {
               errortext = ex.Message + "\r\n\r\n";
               //MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace, "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
               trans.Rollback();
           }
           finally
           {
               sw.Close();
               sw = null;
           }
       }

       private void UpdateEntryInTable(ExcelWorksheet excelsheet)
       {
           SqlTransaction trans = null;
           Int32 r = 1;
           Int32 c = 1;
           Boolean error = false;

           try
           {
               string filepath = System.IO.Directory.GetCurrentDirectory() + "\\ImportLog.txt";
               sw = new System.IO.StreamWriter(filepath);

               ExcelCellAddress dimstart = excelsheet.Dimension.Start;
               ExcelCellAddress dimend = excelsheet.Dimension.End;

               string columnstring = "";
               string valuestring = "";
               string udfvaluestring = "";

               string updateoncolumn = excelsheet.Cells[1, dimend.Column].Value.ToString();
               string updateonvalue = "";

               if (!ignoreerror)
               {
                   SqlConnection conn = new SqlConnection(connectionstring);
                   conn.Open();
                   trans = conn.BeginTransaction();
               }

               for (r = 2; r <= dimend.Row; r++)
               {
                   errortext = "";
                   error = false;
                   excelrowline = r - 1;
                   columnstring = "";
                   valuestring = "";
                   udfvaluestring = "";
                   Ledger = "";
                   LedID = 0;
                   Ledkey = 0;
                   StnKey = 0;
                   PartyGrpKey = 0;
                   PytTermDiscKey = 0;
                   CCBanKey = 0;
                   StateKey = 0;
                   CountryKey = 0;


                   if (ignoreerror)
                   {
                       SqlConnection conn = new SqlConnection(connectionstring);
                       conn.Open();
                       trans = conn.BeginTransaction();
                   }

                   Application.DoEvents();
                   txtstatus.AppendText("\r\n\r\nReading row " + excelrowline.ToString() + "...");
                   //txtstatus.Select(txtstatus.Text.Length, 0);
                   //txtstatus.Focus();

                   updateonvalue = excelsheet.Cells[r, dimend.Column].Value.ToString();
                   Ledkey = Convert.ToInt32(updateonvalue);
                   LedID = Ledkey;
                   for (c = 1; c <= dimend.Column; c++)
                   {
                       error = UpdateReadAndCreate(excelsheet, r, c, trans, ref columnstring, ref valuestring, ref udfvaluestring, ref LedID, ref Ledkey);
                       if (error)
                       {
                           goto Err;
                       }
                   }
               Err:

                   if (error)
                   {
                       txterrorstatus.AppendText(errortext);

                       if (!ignoreerror)
                       {
                           trans.Rollback();
                           break;
                       }
                   }

                   if (!error)
                   {
                       //if (columnstring.EndsWith(","))
                       //{
                       //    columnstring = columnstring.Substring(0, columnstring.Length - 1);
                       //}
                       DateTime dttime = new DateTime(1900, 01, 01);
                       error = GetSQLDatetime(trans, ref dttime);

                       if (valuestring.EndsWith(","))
                       {
                           valuestring = valuestring.Substring(0, valuestring.Length - 1);
                       }

                       valuestring += ", Updated_By = " + importuser + ", Updated_Dt = '" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "'";
                       sql = "Update Ledger Set " + valuestring + "  Where " + updateoncolumn + " = " + updateonvalue + "";
                       //Console.WriteLine(sql);
                       sw.WriteLine(sql);
                       error = ExecuteQuery(sql, trans);

                       if (error)
                       {
                           txterrorstatus.AppendText(errortext);
                           //trans.Rollback();

                           if (!ignoreerror)
                           {
                               break;
                           }
                       }

                       //txtstatus.Select(txtstatus.Text.Length, 0);
                       //txtstatus.Focus();
                   }

                   //if (!error)
                   //{
                   //    DateTime dttime = new DateTime(1900, 01, 01);
                   //    error = GetSQLDatetime(trans, ref dttime);

                   //    //if (udfvaluestring.EndsWith(","))
                   //    //{
                   //    //    udfvaluestring = udfvaluestring.Substring(0, udfvaluestring.Length - 1);
                   //    //    udfvaluestring += ", Updated_By = " + importuser + ", Updated_Dt = '" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "'";
                   //    //}
                   //    //else
                   //    //{
                   //    //    udfvaluestring += " Updated_By = " + importuser + ", Updated_Dt = '" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "'";
                   //    //}

                   //    //sql = "Update userfielddataCustomer Set " + udfvaluestring + " Where Cust_ID = " + updateonvalue + "";
                   //    //sw.WriteLine(sql);
                   //    //error = ExecuteQuery(sql, trans);

                   //    if (error)
                   //    {
                   //        AppendErrorText();

                   //        if (!ignoreerror)
                   //        {
                   //            break;
                   //        }
                   //    }
                   //}
                   if (!error)
                   {
                       //trans.Commit();
                       txtstatus.AppendText("\r\nVendor: " + Ledger + " updated successfully");
                   }
               }

               if (error)
               {
                   trans.Rollback();
               }
               else if (!ignoreerror)
               {
                   trans.Commit();
                   // txtstatus.AppendText("\r\nCustomer: " + Ledger + " updated successfully");
               }

               cols = null;
           }

           catch (SqlException sqlex)
           {
               errortext = sqlex.Message + "\r\n\r\n";
               //MessageBox.Show(sqlex.Message + "\r\n" + sqlex.StackTrace, "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
               trans.Rollback();
           }
           catch (Exception ex)
           {
               errortext = ex.Message + "\r\n\r\n";
               //MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace, "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
               trans.Rollback();
           }
           finally
           {
               sw.Close();
               sw = null;
           }
       }

       private Boolean ReadAndCreate(ExcelWorksheet excelsheet, Int32 r, Int32 c, SqlTransaction trans, ref string columnstring, ref string valuestring, ref string udfcolumnstring, ref string udfvaluestring, ref Int32 ledid, ref Int32 Ledkey)
       {
           try
           {
               string dbcolname = "";
               string excelcolhdr = "";
               string val = "";
               string datatype = "";
               List<ImportCustomerColumns> srchcols;
               Boolean error;
               Boolean reterror;

               val = Convert.ToString(excelsheet.Cells[r, c].Value);
               excelcolhdr = Convert.ToString(excelsheet.Cells[1, c].Value);
               srchcols = cols.FindAll(x => x.ColumnName.ToLower() == excelcolhdr.ToLower());
               error = false;
               reterror = false;

               if (srchcols.Count != 0)
               {
                   dbcolname = srchcols[0].ColumnName;
                   datatype = srchcols[0].DataType;

                   //Console.WriteLine(dbcolname.Substring(0, 3).ToLower());
                   if (dbcolname.Substring(0, 3).ToLower() == "ud_")
                   {
                       udfcolumnstring += dbcolname + ",";
                   }
                   else if (dbcolname.ToLower() != "led_id")
                   {
                       columnstring += dbcolname + ",";
                   }

                   if (datatype.ToLower() == "varchar" || datatype.ToLower() == "char" || datatype.ToLower() == "image")
                   {
                       if (dbcolname.ToLower() == "ean_barcode")
                       {
                           eanbarcode = val;
                       }
                       else if (dbcolname.ToLower() == "item_series")
                       {
                           itemseries = val;
                       }
                       else if (dbcolname.ToLower() == "led_cat")
                       {
                           val = "V";
                       }
                       else if (dbcolname.ToLower() == "ostn_key")
                       {
                           sql = "select stn_key From Station where stn_name = '" + val.Trim() + "'";
                           DataTable dt4 = null;
                           error = GetTable(sql, trans, ref dt4);
                           val = Convert.ToString(dt4.Rows[0][0]);

                       }
                       else if (dbcolname.ToLower() == "rstn_key")
                       {
                           sql = "select stn_key From Station where stn_name = '" + val.Trim() + "'";
                           DataTable dt4 = null;
                           error = GetTable(sql, trans, ref dt4);
                           val = Convert.ToString(dt4.Rows[0][0]);

                       }
                       else if (dbcolname.ToLower() == "acclgrp_key")
                       {
                           sql = "select AccLGrp_key From AccLGrp where AccLGrp_name = '" + val.Trim() + "'";
                           DataTable dt4 = null;
                           error = GetTable(sql, trans, ref dt4);
                           val = Convert.ToString(dt4.Rows[0][0]);

                       }
                       else if (dbcolname.ToLower() == "partygrp_key")
                       {
                           sql = "select Grp_key From PartyGroup where Grp_name = '" + val.Trim() + "'";
                           DataTable dt4 = null;
                           error = GetTable(sql, trans, ref dt4);
                           val = Convert.ToString(dt4.Rows[0][0]);

                       }
                       //
                       else if (dbcolname.ToLower() == "alt_code")
                       {
                           val = "";
                       }
                       else if (dbcolname.ToLower() == "billwise_dtl")
                       {
                           val = "";
                       }
                       else if (dbcolname.ToLower() == "tax_include")
                       {
                           val = "";
                       }

                       val = GetKeyValue(dbcolname, val, trans, ref error);

                       if (error)
                       {
                           return true;
                       }

                       if (dbcolname.Substring(0, 3).ToLower() == "ud_")
                       {
                           udfvaluestring += "'" + val.Replace("'", "''") + "',";
                       }
                       else
                       {
                           valuestring += "'" + val.Replace("'", "''") + "',";
                       }
                   }
                   else if (datatype.ToLower() == "bigint" || datatype.ToLower() == "smallint" || datatype.ToLower() == "image" || datatype.ToLower() == "int" || datatype.ToLower() == "decimal" || datatype.ToLower() == "numeric" || datatype.ToLower() == "float")
                   {
                       if (dbcolname.ToLower() == "purrate")
                       {
                           purrate = Convert.ToDecimal(val);
                       }
                       else if (dbcolname.ToLower() == "mrp")
                       {
                           mrp = Convert.ToDecimal(val);
                       }
                       else if (dbcolname.ToLower() == "salerate")
                       {
                           salerate = Convert.ToDecimal(val);
                       }
                       val = GetKeyValue(dbcolname, val, trans, ref error);
                       if (dbcolname.Substring(0, 3).ToLower() == "ud_")
                       {
                           udfvaluestring += (val == "") ? 0.ToString() + "," : val + ",";
                       }
                       else
                       {
                           valuestring += (val == "") ? 0.ToString() + "," : val + ",";
                       }
                   }
                   else if (datatype.ToLower() == "datetime")
                   {

                       val = GetKeyValue(dbcolname, val, trans, ref error);
                       if (dbcolname.ToLower() == "terminate_dt")
                       {
                           if (val != "NULL" && val != "")
                           {
                               DateTime dttime = Convert.ToDateTime(val);
                               valuestring += "cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                           }
                           else
                           {
                               valuestring += " NULL , ";
                           }
                       }
                       else if (dbcolname.ToLower() == "pts_validto")
                       {
                           if (val != "NULL" && val != "")
                           {
                               DateTime dttime = Convert.ToDateTime(val);
                               valuestring += "cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                           }
                           else
                           {
                               DateTime dttime = new DateTime(1900, 01, 01);
                               error = GetSQLDatetime(trans, ref dttime);
                               valuestring += "cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                           }
                       }

                       else
                       {
                           if (dbcolname.Substring(0, 3).ToLower() == "ud_")
                           {
                               udfvaluestring += "'" + val + "',";
                           }
                           else
                           {
                               if (val != "NULL" && val != "")
                               {
                                   DateTime dttime = Convert.ToDateTime(val);
                                   valuestring += "cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";

                               }
                               else
                               {
                                   DateTime dttime = new DateTime(1900, 01, 01);
                                   error = GetSQLDatetime(trans, ref dttime);
                                   valuestring += "cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";


                               }
                           }
                       }
                   }
               }
           }

           catch (Exception ex)
           {
               errortext = ex.Message + "\r\n\r\n";
               AppendErrorText();
               return true;
               //MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace, "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
               //trans.Rollback();
           }

           return false;
       }

       private Boolean UpdateReadAndCreate(ExcelWorksheet excelsheet, Int32 r, Int32 c, SqlTransaction trans, ref string columnstring, ref string valuestring, ref string udfvaluestring, ref Int32 LedID, ref Int32 Ledkey)
       {
           try
           {
               string dbcolname = "";
               string excelcolhdr = "";
               string val = "";
               string datatype = "";
               List<ImportCustomerColumns> srchcols;
               Boolean error;

               val = Convert.ToString(excelsheet.Cells[r, c].Value);
               excelcolhdr = Convert.ToString(excelsheet.Cells[1, c].Value);
               srchcols = cols.FindAll(x => x.ColumnName.ToLower() == excelcolhdr.ToLower());
               error = false;


               if (ignoreerror)
               {
                   if (srchcols.Count == 0)
                   {
                       return false;
                   }
               }


               if (ignoreerror)
               {

                   if (srchcols[0].ColumnName.ToString() == "Led_Name" || srchcols[0].ColumnName.ToString() == "Abbr" || srchcols[0].ColumnName.ToString() == "Currn_ID" || srchcols[0].ColumnName.ToString() == "Start_Dt" || srchcols[0].ColumnName.ToString() == "State_ID" || srchcols[0].ColumnName.ToString() == "Cont_ID" || srchcols[0].ColumnName.ToString() == "OStn_ID" || srchcols[0].ColumnName.ToString() == "AccLGrp_ID")
                   {
                       if (Convert.ToString(excelsheet.Cells[r, c].Value) == "")
                       {
                           txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of '" + srchcols[0].ColumnName.ToString() + "' is missing. \r\n\r\n ";
                           return true;
                       }
                   }
               }

               if (srchcols.Count != 0)
               {
                   dbcolname = srchcols[0].ColumnName;
                   datatype = srchcols[0].DataType;

                   if (dbcolname.ToLower() == "led_id")
                   {
                       //columnstring += dbcolname + ",";
                       return false;
                   }
                   if (dbcolname.ToLower() == "led_name")
                   {
                       Ledger = val;
                   }
                   if (datatype.ToLower() == "varchar" || datatype.ToLower() == "char" || datatype.ToLower() == "image")
                   {
                       //if (dbcolname.ToLower() == "ean_barcode")
                       //{
                       //    eanbarcode = val;
                       //}

                       //if (dbcolname.ToLower() == "item_series")
                       //{
                       //    itemseries = val;
                       //}
                       if (dbcolname.ToLower() == "ostn_key")
                       {
                           sql = "select stn_key From Station where stn_name = '" + val.Trim() + "'";
                           DataTable dt4 = null;
                           error = GetTable(sql, trans, ref dt4);
                           val = Convert.ToString(dt4.Rows[0][0]);

                       }
                       else if (dbcolname.ToLower() == "rstn_key")
                       {
                           sql = "select stn_key From Station where stn_name = '" + val.Trim() + "'";
                           DataTable dt4 = null;
                           error = GetTable(sql, trans, ref dt4);
                           val = Convert.ToString(dt4.Rows[0][0]);

                       }
                       else if (dbcolname.ToLower() == "acclgrp_key")
                       {
                           sql = "select AccLGrp_key From AccLGrp where AccLGrp_name = '" + val.Trim() + "'";
                           DataTable dt4 = null;
                           error = GetTable(sql, trans, ref dt4);
                           val = Convert.ToString(dt4.Rows[0][0]);

                       }
                       else if (dbcolname.ToLower() == "partygrp_key")
                       {
                           sql = "select Grp_key From PartyGroup where Grp_name = '" + val.Trim() + "'";
                           DataTable dt4 = null;
                           error = GetTable(sql, trans, ref dt4);
                           val = Convert.ToString(dt4.Rows[0][0]);

                       }
                       //
                       else if (dbcolname.ToLower() == "alt_code")
                       {
                           val = "";
                       }
                       else if (dbcolname.ToLower() == "billwise_dtl")
                       {
                           val = "";
                       }
                       else if (dbcolname.ToLower() == "tax_include")
                       {
                           val = "";
                       }
                       val = GetKeyValue(dbcolname, val, trans, ref error);

                       if (error)
                       {
                           return true;
                       }

                       if (dbcolname.Substring(0, 3) == "Ud_")
                       {
                           udfvaluestring += dbcolname + " = '" + val.Replace("'", "''") + "',";
                       }
                       else
                       {
                           valuestring += dbcolname + " = '" + val.Replace("'", "''") + "',";
                       }
                   }
                   //else if (datatype.ToLower() == "system.int" || datatype.ToLower() == "system.int16" || datatype.ToLower() == "system.int32" || datatype.ToLower() == "system.int64" || datatype.ToLower() == "system.decimal")
                   else if (datatype.ToLower() == "bigint" || datatype.ToLower() == "int" || datatype.ToLower() == "decimal" || datatype.ToLower() == "float")
                   {
                       //if (dbcolname.ToLower() == "item_id")
                       //{
                       //    reterror = NewRecordId("item", "item_id", trans, ref itemid);

                       //    if (reterror)
                       //    {
                       //        return true;
                       //    }
                       //    itemkey = branchid + itemid;
                       //}
                       //else
                       //{
                       //valuestring += (val == "") ? 0.ToString() + "," : val + ",";
                       val = GetKeyValue(dbcolname, val, trans, ref error);
                       if (dbcolname.Substring(0, 3) == "Ud_")
                       {
                           udfvaluestring += dbcolname + " = " + val + ",";
                       }
                       else
                       {
                           if (val == "")
                           {
                               valuestring += dbcolname + " = 0,";
                           }
                           else
                           {
                               valuestring += dbcolname + " = " + val + ",";
                           }
                       }
                       //}
                   }
                   else if (datatype.ToLower() == "datetime")
                   {
                       val = GetKeyValue(dbcolname, val, trans, ref error);
                       DateTime dttime = new DateTime(1900, 01, 01);

                       error = GetSQLDatetime(trans, ref dttime);

                       if (!error)
                       {
                           if (dbcolname.Substring(0, 3) == "Ud_")
                           {
                               dttime = Convert.ToDateTime(val);
                               udfvaluestring += dbcolname + "= cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                           }
                           else if (dbcolname.ToLower() == "created_dt")
                           {
                               valuestring += "Created_Dt = '" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "',";
                           }
                           else if (dbcolname.ToLower() == "terminate_dt")
                           {
                               if (val != "NULL" && val != "")
                               {
                                   dttime = Convert.ToDateTime(val);
                                   valuestring += dbcolname + "= cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                               }
                               else
                               {
                                   valuestring += dbcolname + "= NULL ,";
                               }
                           }
                           else
                           {
                               if (val != "NULL" && val != "")
                               {
                                   dttime = Convert.ToDateTime(val);
                                   valuestring += dbcolname + "= cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                               }
                               else
                               {
                                   dttime = new DateTime(1900, 01, 01);
                                   valuestring += dbcolname + "= cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                               }
                           }
                       }
                   }
               }
           }

           catch (Exception ex)
           {
               errortext = ex.Message + "\r\n\r\n";
               AppendErrorText();
               return true;
           }

           return false;
       }

       private List<ImportCustomerColumns> FillTableColumnsToList(DataTable dt)
       {
           List<ImportCustomerColumns> lst = (from DataRow row in dt.Rows
                                              select new ImportCustomerColumns()
                                              {
                                                  ColumnName = row["Column_Name"].ToString(),
                                                  DataType = row["Data_Type"].ToString(),
                                                  ColumnIndex = Convert.ToInt16(row["Ordinal_Position"])
                                              }).ToList();

           return lst;
       }

       private string GetKeyValue(string fieldname, string mastervalue, SqlTransaction trans, ref Boolean error)
       {
           string keyfieldvalue = "";
           Int32 newid = 0;
           Int16 reccount = 0;


           try
           {
               mastervalue = mastervalue.Replace("'", "''");
               error = false;

               Int32 r = 1;
               string sheetname = "Ledger";
               ExcelPackage p = new ExcelPackage(new System.IO.FileInfo(excelfile));

               ExcelWorksheet excelsht = p.Workbook.Worksheets[sheetname];

               ExcelCellAddress dimstart = excelsht.Dimension.Start;
               ExcelCellAddress dimend = excelsht.Dimension.End;

               string Ctryname = "";
               string Statename = "";

               if (isInsert)
               {
                   Int16 ctrynamecol = 13;
                   Int16 statenamecol = 14;

                   for (r = 2; r <= dimend.Row; r++)
                   {
                       Ctryname = Convert.ToString(excelsht.Cells[r, ctrynamecol].Value);
                       Statename = Convert.ToString(excelsht.Cells[r, statenamecol].Value);
                   }
               }
               else //update
               {
                   for (r = 2; r <= dimend.Row; r++)
                   {
                       Int32 c = 1;
                       for (c = 1; c <= dimend.Column; c++)
                       {
                           if (excelsht.Cells[1, c].Value.ToString() == "State_ID" || excelsht.Cells[1, c].Value.ToString() == "Cont_ID")
                           {
                               if (Convert.ToString(excelsht.Cells[1, c].Value) == "Cont_ID")
                               {
                                   Int32 ctrynamecol = c;
                                   Ctryname = Convert.ToString(excelsht.Cells[r, ctrynamecol].Value);
                               }
                               else if (Convert.ToString(excelsht.Cells[1, c].Value) == "State_ID")
                               {
                                   Int32 statenamecol = c;
                                   Statename = Convert.ToString(excelsht.Cells[r, statenamecol].Value);
                               }
                           }
                       }
                   }
               }
               switch (fieldname.ToLower())
               {
                   case "currn_id":
                       {
                           error = RecordExists("Currency", "currn_Name", mastervalue, "currn_id", trans, ref keyfieldvalue, ref reccount);

                           if (!error && reccount == 0)
                           {
                               error = NewRecordId("Currency", "currn_id", trans, ref newid);

                               if (!error)
                               {
                                   keyfieldvalue = newid.ToString();

                                   error = GetSQLDatetime(trans, ref sqldt);

                                   if (!error)
                                   {

                                       sql = "Insert into Currency ( currn_id, currn_Name, Abbr, Alt_Code,Imp_Rate,Exp_Rate,Dec_name, Status, Created_By, Created_Dt,Symbol,Def_Currn,MachName) ";
                                       sql += " values (" + newid + ",'" + mastervalue + "','" + mastervalue + "','',0,0,'','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','',0,'" + Environment.MachineName + "')";
                                       error = ExecuteQuery(sql, trans);
                                   }
                               }
                           }

                           CurrnID = Convert.ToInt32(keyfieldvalue);
                           break;
                       }

                   case "ostn_id":
                       {
                           if (!error)
                           {
                               error = RecordExists("Country", "Cont_Name", Ctryname, "Cont_id", trans, ref keyfieldvalue, ref reccount);

                               if (!error && reccount == 0)
                               {
                                   error = NewRecordId("Country", "Cont_id", trans, ref newid);

                                   if (!error)
                                   {
                                       keyfieldvalue = newid.ToString();

                                       error = GetSQLDatetime(trans, ref sqldt);

                                       if (!error)
                                       {

                                           sql = "Insert into Country (Cont_id,  Cont_Name, Abbr, Alt_Code, Status, Created_By, Created_Dt,Regn_Id,Machname) ";
                                           sql += " values (" + newid + ",'" + Ctryname + "','" + Ctryname + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "',0,'" + Environment.MachineName + "')";
                                           error = ExecuteQuery(sql, trans);
                                       }
                                   }
                               }
                               CountryKey = Convert.ToInt32(keyfieldvalue);

                               if (!error)
                               {

                                   error = RecordExists("State", "State_Name", Statename, "State_ID", trans, ref keyfieldvalue, ref reccount);

                                   if (!error && reccount == 0)
                                   {
                                       error = NewRecordId("State", "State_id", trans, ref newid);

                                       if (!error)
                                       {
                                           keyfieldvalue = newid.ToString();

                                           error = GetSQLDatetime(trans, ref sqldt);

                                           if (!error)
                                           {

                                               sql = "Insert into State ( State_id,Cont_ID, State_Name, Abbr, Alt_Code, Status, Created_By, Created_Dt,Machname) ";
                                               sql += " values (" + newid + ",'" + CountryKey + "','" + Statename + "','" + Statename + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + Environment.MachineName + "')";
                                               error = ExecuteQuery(sql, trans);
                                           }
                                       }
                                   }
                                   StateKey = Convert.ToInt32(keyfieldvalue);

                                   error = RecordExists("Station", "Stn_Name", mastervalue, "Stn_ID", trans, ref keyfieldvalue, ref reccount);

                                   if (!error && reccount == 0)
                                   {
                                       error = NewRecordId("Station", "Stn_id", trans, ref newid);

                                       if (!error)
                                       {
                                           keyfieldvalue = newid.ToString();
                                           error = GetSQLDatetime(trans, ref sqldt);
                                           if (!error)
                                           {
                                               sql = "Insert into Station (Stn_id, Stn_Name,Pin, Abbr, Alt_Code, Status, Created_By, Created_Dt, State_Id, Machname) ";
                                               sql += " values (" + newid + ",'" + mastervalue + "','','" + mastervalue + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'," + StateKey + ",'" + Environment.MachineName + "')";
                                               error = ExecuteQuery(sql, trans);
                                           }
                                       }
                                   }
                                   StnKey = Convert.ToInt32(keyfieldvalue);
                               }
                           }
                           break;
                       }


                   case "rstn_id":
                       {
                           if (!error)
                           {
                               error = RecordExists("Country", "Cont_Name", Ctryname, "Cont_id", trans, ref keyfieldvalue, ref reccount);

                               if (!error && reccount == 0)
                               {
                                   error = NewRecordId("Country", "Cont_id", trans, ref newid);

                                   if (!error)
                                   {
                                       keyfieldvalue = newid.ToString();

                                       error = GetSQLDatetime(trans, ref sqldt);

                                       if (!error)
                                       {

                                           sql = "Insert into Country (Cont_id,  Cont_Name, Abbr, Alt_Code, Status, Created_By, Created_Dt,Regn_Id,Machname) ";
                                           sql += " values (" + newid + ",'" + Ctryname + "','" + Ctryname + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "',0,'" + Environment.MachineName + "')";
                                           error = ExecuteQuery(sql, trans);
                                       }
                                   }
                               }
                               CountryKey = Convert.ToInt32(keyfieldvalue);

                               if (!error)
                               {

                                   error = RecordExists("State", "State_Name", Statename, "State_ID", trans, ref keyfieldvalue, ref reccount);

                                   if (!error && reccount == 0)
                                   {
                                       error = NewRecordId("State", "State_id", trans, ref newid);

                                       if (!error)
                                       {
                                           keyfieldvalue = newid.ToString();

                                           error = GetSQLDatetime(trans, ref sqldt);

                                           if (!error)
                                           {

                                               sql = "Insert into State ( State_id,Cont_ID, State_Name, Abbr, Alt_Code, Status, Created_By, Created_Dt,Machname) ";
                                               sql += " values (" + newid + ",'" + CountryKey + "','" + Statename + "','" + Statename + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + Environment.MachineName + "')";
                                               error = ExecuteQuery(sql, trans);
                                           }
                                       }
                                   }
                                   StateKey = Convert.ToInt32(keyfieldvalue);

                                   error = RecordExists("Station", "Stn_Name", mastervalue, "Stn_ID", trans, ref keyfieldvalue, ref reccount);

                                   if (!error && reccount == 0)
                                   {
                                       error = NewRecordId("Station", "Stn_id", trans, ref newid);

                                       if (!error)
                                       {
                                           keyfieldvalue = newid.ToString();
                                           error = GetSQLDatetime(trans, ref sqldt);
                                           if (!error)
                                           {
                                               sql = "Insert into Station (Stn_id, Stn_Name,Pin, Abbr, Alt_Code, Status, Created_By, Created_Dt, State_Id, Machname) ";
                                               sql += " values (" + newid + ",'" + mastervalue + "','','" + mastervalue + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'," + StateKey + ",'" + Environment.MachineName + "')";
                                               error = ExecuteQuery(sql, trans);
                                           }
                                       }
                                   }
                                   StnKey = Convert.ToInt32(keyfieldvalue);
                               }
                           }
                           break;
                       }

                   case "partygrp_id":
                       {
                           error = RecordExists("PartyGroup", "Grp_Name", mastervalue, "Grp_Id", trans, ref keyfieldvalue, ref reccount);

                           if (!error && reccount == 0)
                           {
                               error = NewRecordId("PartyGroup", "Grp_id", trans, ref newid);

                               if (!error)
                               {
                                   keyfieldvalue = newid.ToString();

                                   error = GetSQLDatetime(trans, ref sqldt);

                                   if (!error)
                                   {

                                       sql = "Insert into PartyGroup (Grp_id,  Grp_Name, Abbr, Alt_Code, Status, Created_By, Created_Dt,Grp_Cat,Machname) ";
                                       sql += " values (" + newid + ",'" + mastervalue + "','" + mastervalue + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','','" + Environment.MachineName + "')";
                                       error = ExecuteQuery(sql, trans);
                                   }
                               }
                           }

                           PartyGrpKey = Convert.ToInt32(keyfieldvalue);
                           break;
                       }

                   case "acclgrp_id":
                       {
                           error = RecordExists("AccLGrp", "AccLGrp_Name", mastervalue, "acclgrp_id", trans, ref keyfieldvalue, ref reccount);

                           if (!error && reccount == 0)
                           {
                               error = NewRecordId("AccLGrp", "acclgrp_id", trans, ref newid);

                               if (!error)
                               {
                                   keyfieldvalue = newid.ToString();

                                   error = GetSQLDatetime(trans, ref sqldt);

                                   if (!error)
                                   {

                                       sql = "Insert into AccLGrp (AccLGrp_id, AccGrp_ID, AccLGrp_Name, Abbr, Alt_Code,Disp_Level, Status, Created_By, Created_Dt,Machname) ";
                                       sql += " values (" + newid + ",0,'" + mastervalue + "','" + mastervalue + "','','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + Environment.MachineName + "')";
                                       error = ExecuteQuery(sql, trans);
                                   }
                               }
                           }

                           AccLGrpKey = Convert.ToInt32(keyfieldvalue);
                           break;
                       }

                   case "pyttermdisc_id":
                       {
                           error = RecordExists("PytTermDisc", "PytTermDisc_Name", mastervalue, "PytTermDisc_Id", trans, ref keyfieldvalue, ref reccount);

                           if (!error && reccount == 0)
                           {
                               error = NewRecordId("PytTermDisc", "PytTermDisc_id", trans, ref newid);

                               if (!error)
                               {
                                   keyfieldvalue = newid.ToString();

                                   error = GetSQLDatetime(trans, ref sqldt);

                                   if (!error)
                                   {

                                       sql = "Insert into PytTermDisc (PytTermDisc_id,PytTermDisc_Name,PytTermDisc_Days,PytTermDisc_Disc, Abbr, Alt_Code, Status, Created_By, Created_Dt,PytTermDisc_Remark,Machname) ";
                                       sql += " values (" + newid + ",'" + mastervalue + "',0,0,'" + mastervalue + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','','" + Environment.MachineName + "')";
                                       error = ExecuteQuery(sql, trans);
                                   }
                               }
                           }

                           PytTermDiscKey = Convert.ToInt32(keyfieldvalue);
                           break;
                       }


                   case "bank_id":
                       {
                           error = RecordExists("CCBank", "CCBank_Name", mastervalue, "CCBank_ID", trans, ref keyfieldvalue, ref reccount);

                           if (!error && reccount == 0)
                           {
                               error = NewRecordId("CCBank", "CCBank_id", trans, ref newid);

                               if (!error)
                               {
                                   keyfieldvalue = newid.ToString();

                                   error = GetSQLDatetime(trans, ref sqldt);

                                   if (!error)
                                   {

                                       sql = "Insert into CCBank (CCBank_id,CCBank_Gateway, CCBank_Name,CCBankFlag, Abbr, Alt_Code, Status, Created_By, Created_Dt,synchcloud,Machname) ";
                                       sql += " values (" + newid + ",'','" + mastervalue + "','1','" + mastervalue + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','0','" + Environment.MachineName + "')";
                                       error = ExecuteQuery(sql, trans);
                                   }
                               }
                           }

                           CCBanKey = Convert.ToInt32(keyfieldvalue);
                           break;
                       }

                   case "cardtype_id":
                       {
                           error = RecordExists("CardType", "CardType_Name", mastervalue, "CardType_id", trans, ref keyfieldvalue, ref reccount);

                           if (!error && reccount == 0)
                           {
                               error = NewRecordId("cardtype", "cardtype_id", trans, ref newid);

                               if (!error)
                               {
                                   keyfieldvalue = newid.ToString();

                                   error = GetSQLDatetime(trans, ref sqldt);

                                   if (!error)
                                   {

                                       sql = "Insert into CardType (CardType_Id,CardType_Name,SaleVal_From,SaleVal_To,PointSaleAmt,Disc_Perc,Point_From,Point_To,PointOnSaleAmt,RedeemValPerPt,MinPtsForRedemp,Abbr,Alt_Code,Remark,Status,Created_By,Created_Dt,synchcloud,MachName) ";
                                       sql += " values (" + newid + ",'" + mastervalue + "',0,0,0,0,0,0,0,0,0,'" + mastervalue + "','','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','0','" + Environment.MachineName + "')";
                                       error = ExecuteQuery(sql, trans);
                                   }
                               }
                           }

                           CardTypeID = Convert.ToInt32(keyfieldvalue);
                           break;
                       }

                   case "ref_led_id":
                       {
                           error = RecordExists("Ledger", "Led_Name", mastervalue, "led_id", trans, ref keyfieldvalue, ref reccount);
                           RefLed_ID = Convert.ToInt32(keyfieldvalue);
                           break;
                       }


                   default:
                       {
                           keyfieldvalue = mastervalue;

                           break;
                       }
               }

               //error = false;
           }

           catch (Exception ex)
           {
               errortext = ex.Message + "\r\n\r\n";
               AppendErrorText();
               error = true;
           }

           return keyfieldvalue;
       }

       private Boolean GenerateBarcode(SqlTransaction trans)
       {
           Boolean error = false;

           try
           {
               sql = "Select IsNull(Max(SubString(BarCode, 3, Len(BarCode))), 0) + 1 ";
               sql += " From ItemStock with (nolock) ";
               sql += " Where SubString(BarCode, 1, 2) = '" + itemseries + "'";
               sql += " And CoBr_Id = '" + branchid + "'";
               DataTable dt = null;
               error = GetTable(sql, trans, ref dt);

               Int32 maxid = 0;
               if (dt.Rows.Count > 0)
               {
                   maxid = Convert.ToInt32(dt.Rows[0][0]);
               }

               barcode = itemseries + maxid.ToString("000000");
           }

           catch (Exception ex)
           {
               errortext = ex.Message + "\r\n\r\n";
               AppendErrorText();
               return true;
           }

           return error;
       }

       private Boolean NewRecordId(string table, string idfield, SqlTransaction trans, ref Int32 newid)
       {
           try
           {
               SqlParameter prmtable;
               SqlParameter prmidfield;
               SqlParameter prmcobridfield;
               SqlParameter prmnewid;
               SqlCommand cmdcommand;

               cmdcommand = new SqlCommand();

               prmtable = new SqlParameter();
               prmtable.ParameterName = "@strTable";
               prmtable.SqlDbType = SqlDbType.VarChar;
               prmtable.Size = 30;
               prmtable.Direction = ParameterDirection.Input;
               prmtable.SqlValue = table;

               prmidfield = new SqlParameter();
               prmidfield.ParameterName = "@strIdField";
               prmidfield.SqlDbType = SqlDbType.VarChar;
               prmidfield.Size = 30;
               prmidfield.Direction = ParameterDirection.Input;
               prmidfield.SqlValue = idfield;

               prmcobridfield = new SqlParameter();
               prmcobridfield.ParameterName = "@strCoBrId";
               prmcobridfield.SqlDbType = SqlDbType.VarChar;
               prmcobridfield.Size = 2;
               prmcobridfield.Direction = ParameterDirection.Input;
               prmcobridfield.SqlValue = "";

               prmnewid = new SqlParameter();
               prmnewid.ParameterName = "@NewId";
               prmnewid.SqlDbType = SqlDbType.Int;
               prmnewid.Direction = ParameterDirection.Output;

               cmdcommand.Parameters.Add(prmtable);
               cmdcommand.Parameters.Add(prmidfield);
               cmdcommand.Parameters.Add(prmcobridfield);
               cmdcommand.Parameters.Add(prmnewid);

               cmdcommand.CommandType = CommandType.StoredProcedure;
               cmdcommand.CommandText = "GetNewRecordId";
               cmdcommand.Connection = trans.Connection;
               cmdcommand.Transaction = trans;
               cmdcommand.ExecuteNonQuery();

               newid = Convert.ToInt32(prmnewid.Value.ToString());

               cmdcommand = null;
               prmtable = null;
               prmidfield = null;
               prmnewid = null;
               prmcobridfield = null;
           }

           catch (Exception ex)
           {
               errortext = ex.Message + "\r\n\r\n";
               //MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace, "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
               AppendErrorText();
               return true;
           }

           return false;
       }

       private Boolean RecordExists(string tablename, string namefield, string namefieldvalue, string keyfield, SqlTransaction trans, ref string keyfieldvalue, ref Int16 reccount)
       {
           try
           {
               sql = "Select " + keyfield + " from " + tablename + "  with (nolock) Where " + namefield + " = '" + namefieldvalue + "'";
               if (namefieldvalue.Trim().Length != 0)
               {
                   //sql += " And CoBr_Id = '" + branchid + "'";
               }
               SqlDataAdapter db = new SqlDataAdapter(sql, trans.Connection);
               db.SelectCommand.CommandTimeout = 5000;
               db.SelectCommand.Transaction = trans;
               DataTable dt = new DataTable();
               db.Fill(dt);

               if (dt.Rows.Count == 0)
               {
                   reccount = 0;
               }
               else
               {
                   keyfieldvalue = Convert.ToString(dt.Rows[0][0]);
                   reccount = 1;
               }

               db = null;
               dt = null;
           }

           catch (Exception ex)
           {
               errortext = ex.Message + "\r\n\r\n";
               AppendErrorText();
               return true;
           }

           return false;
       }

       private Boolean GetTable(string qry, SqlTransaction trans, ref DataTable dt)
       {
           try
           {
               SqlDataAdapter db = new SqlDataAdapter(qry, trans.Connection);
               db.SelectCommand.CommandTimeout = 0;
               db.SelectCommand.Transaction = trans;
               dt = new DataTable();
               db.Fill(dt);
           }

           catch (Exception ex)
           {
               errortext = ex.Message + "\r\n\r\n";
               AppendErrorText();
               return true;
           }
           return false;
       }

       private Boolean ExecuteQuery(string qry, SqlTransaction trans)
       {
           try
           {
               //Console.WriteLine(qry);
               SqlCommand cmd = new SqlCommand(qry, trans.Connection);
               cmd.CommandTimeout = 000;
               cmd.Transaction = trans;
               cmd.ExecuteNonQuery();

               return false;
           }

           catch (SqlException sqlex)
           {
               if (trans != null)
               {
                   errortext = sqlex.Message + "\r\n\r\n";
                   AppendErrorText();
                   trans.Rollback();
               }
               return true;
           }

           catch (Exception ex)
           {
               errortext = ex.Message + "\r\n\r\n";
               AppendErrorText();
               return true;
           }
       }

       private Boolean GetSQLDatetime(SqlTransaction trans, ref DateTime sqldatetime)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("Select Getdate()", trans.Connection);
               cmd.CommandTimeout = 5000;
               cmd.Transaction = trans;
               sqldatetime = Convert.ToDateTime(cmd.ExecuteScalar().ToString());
               cmd = null;

               return false;
           }

           catch (Exception ex)
           {
               errortext = ex.Message + "\r\n\r\n";
               AppendErrorText();
               return true;
           }
       }

       private void AppendErrorText()
       {
           //if (!txterrorstatus.Text.Contains("Error importing line: " + excelrowline + "\r\nRow not imported\r\n\r\n"))
           //{
           //    txterrorstatus.AppendText("Error importing line: " + excelrowline + "\r\nRow not imported\r\n\r\n");
           //}
           Boolean error = false;
           if (error)
           {
               if (!txterrorstatus.Text.Contains("Error importing line: " + excelrowline + " (Row not imported)\r\n\r\n"))
               {
                   txterrorstatus.AppendText("Error importing line: " + excelrowline + " (Row not imported)\r\n\r\n");
               }
           }
       }
   }
}



