using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using OfficeOpenXml;
using System.Windows.Forms;
using System.Linq;

namespace Import_Data_FromExcel
{
    public class Import_ShadeMaster
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
        Int32 locid = 0;
        System.IO.StreamWriter sw;

        List<ImportItemColumns> cols;

        Boolean isInsert;
        Boolean isUpdate;

        string sheetname = "";
        Int32 excelrowline = 0;
    
        
        
        string ShadeName = "";
        string Abbr = "";
        string Alt_Code = "";
        string Remark = "";
        string Status = "";
         	

       
        string itemseries = "";
        string barcode = "";
        string eanbarcode = "";
        string altbarcode_No = "";
        string hsncode = "";

        string alternatebarcode = "";

        string ItemGroupCode = "";
        string ItemSubGroupCode = "";
        String AltEanbarcode = "";
        string ItemGroupCodeUpdate = "";
        Int32 sectkey = 0;
        Int32 itemid = 0;
        Int32 itemkey = 0;
        Int32 itemgrpkey = 0;
        Int32 itemsubgrpkey = 0;
        Int32 brandkey = 0;
        Int32 rackkey = 0;

        Int32 shadeid = 0;
        Int32 shadekey = 0;

        Int32 DRSSEQ_ID = 0;

        Int32 unitkey = 0;
        Int32 convunitkey = 0;
        Int32 itemmisckey = 0;
        Int32 qltykey = 0;
        Int32 itemsizekey = 0;
        Int32 stylekey = 0;
        Int32 SuplID = 0;
        Int32 PURTAXID = 0;
        Int32 TAXID = 0;
        string TaxInclude = "1";
        Int32 ProducTypeID = 0;
        Int32 CurrnID = 0;
        Int32 BarcodeId = 0;
        decimal convqty = 0;
        decimal purrate = 0;
        decimal mrp = 0;
        decimal ConvQty = 0;
        decimal salerate = 0;

        Decimal SaleRateCheck = 0;

        Decimal PurrateAfterTax = 0;
        Decimal saleratebeforetax = 0;
        decimal salerateafterconversion = 0;
        Decimal MkUpRate = 0;
        Decimal Margin = 0;
        decimal landedcostincltax = 0;
        decimal FreightAmt = 0;
        decimal DutyAmt = 0;
        decimal LandedCost = 0;

        string errortext = "";
        string product = "";

        string Purtax_idyn = "0";
        string tax_idyn = "0";

        string PurRateyn = "0";
        string PurRateAfterTaxyn = "0";
        string FreightAmtyn = "0";
        string DutyAmtyn = "0";
        string LandedCostyn = "0";
        string LandedCostInclTaxyn = "0";
        string MkUpRateyn = "0";
        string Marginyn = "0";
        string SaleRateBeforeTaxyn = "0";
        string SaleRateyn = "0";
        string MRPyn = "0";


        string ProductName = "";
        string ProductCode = "";

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

        public Int32 locID
        {
            get { return locid; }
            set { locid = value; }
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


                ExcelPackage p = new ExcelPackage(new System.IO.FileInfo(excelfile));
                int iSheetsCount = p.Workbook.Worksheets.Count;
                if (iSheetsCount > 0)
                {
                    ExcelWorksheet worksheet = p.Workbook.Worksheets[1];
                    sheetname = worksheet.Name;
                }

                string ShadeName = "";
                Int16 ShadeNamecol = 1;
                //ExcelPackage p = new ExcelPackage(new System.IO.FileInfo(excelfile));
                ExcelWorksheet excelsht = p.Workbook.Worksheets[sheetname];
                ShadeName = Convert.ToString(excelsht.Cells[r, ShadeNamecol].Value);



                if (ShadeName != "")
                {
                    sheetname = "Shade";
                    p = new ExcelPackage(new System.IO.FileInfo(excelfile));

                    //ExcelPackage.LicenseContext = LicenseContext.NonCommercial
                    excelsht = p.Workbook.Worksheets[sheetname];

                    if (excelsht == null)
                    {
                        MessageBox.Show("Worksheet name [Item] not found in selected file.\r\nCannot continue !", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }

                    ExcelCellAddress dimstart = excelsht.Dimension.Start;
                    ExcelCellAddress dimend = excelsht.Dimension.End;



                    barcode = "";
                    String EANBarcode = "";
                    string itemname = "";
                    string Abbr = "";
                    string ItemDesc = "";
                    string ItemGroup = "";
                    string subgroup = "";
                    string unit = "";
                    string Convunit = "";
                    string ConvQty = "";
                    string PurRate = "";
                    string PurUnit = "";
                    string SaleRate = "";
                    string SaleUnit = "";
                    string MRP = "";
                    string TaxIncl = "";
                    //string SaleRateBeforeTax = "";
                    string DefaultQty = "";
                    string MaintainStk = "";
                    string Supplier = "";

                    string Shade_Name = "";
                    string Abbrr = "";
                    string Alt_Code = "";
                    string Remark = "";

                    string val = "";

                    Int16 ShadeNameCol = 1;
                    Int16 Abbrcol = 2;
                    Int16 Alt_CodeCol = 3;
                    Int16 RemarkCol = 4;
                    Int16 ItemGroupCol = 6;
                    Int16 subgroupcol = 8;
                    Int16 unitcol = 13;
                    Int16 ConvunitCol = 14;
                    Int16 ConvQtyCol = 15;
                    Int16 PurRateCol = 21;
                    Int16 PurUnitCol = 23;
                    Int16 SaleRateCol = 29;
                    Int16 SaleUnitCol = 32;
                    Int16 MRPCol = 33;
                    Int16 TaxInclCol = 19;
                    //Int16 SaleRateBeforeTaxCol = 26;
                    Int16 DefaultQtyCol = 35;
                    Int16 MaintainStkCol = 36;
                    Int16 SupplierCol = 12;
                    Int16 ItemGroupCodeCol = 5;
                    Int16 ItemSubGroupCodeCol = 7;


                    //barcodecol = 46;

                    string invalidcols = "";

                    for (r = 2; r <= dimend.Row; r++)
                    {


                        txtstatus.Text = "Validating line number: " + (r - 1).ToString();
                        Application.DoEvents();

                        if (stopimport)
                        {
                            if (MessageBox.Show("Do you want to STOP the import now ?", "UniRetail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                MessageBox.Show("Import of file " + excelfile + " was interrupted by user.", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                        }

                        Shade_Name = Convert.ToString(excelsht.Cells[r, ShadeNamecol].Value);
                        Abbrr = Convert.ToString(excelsht.Cells[r, Abbrcol].Value);
                        Alt_Code = Convert.ToString(excelsht.Cells[r, Alt_CodeCol].Value);
                        Remark = Convert.ToString(excelsht.Cells[r, RemarkCol].Value);
                        subgroup = Convert.ToString(excelsht.Cells[r, subgroupcol].Value);
                        unit = Convert.ToString(excelsht.Cells[r, unitcol].Value);
                        Convunit = Convert.ToString(excelsht.Cells[r, ConvunitCol].Value);
                        ConvQty = Convert.ToString(excelsht.Cells[r, ConvQtyCol].Value);
                        PurRate = Convert.ToString(excelsht.Cells[r, PurRateCol].Value);
                        PurUnit = Convert.ToString(excelsht.Cells[r, PurUnitCol].Value);
                        SaleRate = Convert.ToString(excelsht.Cells[r, SaleRateCol].Value);
                        SaleUnit = Convert.ToString(excelsht.Cells[r, SaleUnitCol].Value);
                        MRP = Convert.ToString(excelsht.Cells[r, MRPCol].Value);
                        TaxIncl = Convert.ToString(excelsht.Cells[r, TaxInclCol].Value);
                        //SaleRateBeforeTax = Convert.ToString(excelsht.Cells[r, SaleRateBeforeTaxCol].Value);
                        DefaultQty = Convert.ToString(excelsht.Cells[r, DefaultQtyCol].Value);
                        MaintainStk = Convert.ToString(excelsht.Cells[r, MaintainStkCol].Value);
                        Supplier = Convert.ToString(excelsht.Cells[r, SupplierCol].Value);
                        ItemGroupCode = Convert.ToString(excelsht.Cells[r, ItemGroupCodeCol].Value);
                        ItemSubGroupCode = Convert.ToString(excelsht.Cells[r, ItemSubGroupCodeCol].Value);
                        invalidcols = "";

                        //if (SaleRate != "")
                        //{ 
                        //SaleRateCheck = Convert.ToDecimal(SaleRate);
                        //}
                        //purrate = Convert.ToDecimal(PurRate);
                        //salerate = Convert.ToDecimal(SaleRate);
                        isInsert = true;

                        Int16 reccount = 0;


                        string lastcolumnname = "";
                        lastcolumnname = excelsht.Cells[1, dimend.Column].Value.ToString();
                        //if (lastcolumnname.ToLower() != "item_id")
                        //{
                        //    isInsert = true;
                        //
                        if (lastcolumnname.ToLower() != "shade_id")
                        {

                            if (ShadeName.Trim().Length == 0)
                            {
                                //invalidcols += "barcode, ";
                                isinvalid = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'ShadeName' is missing.";
                            }                           
                            
                            
                            if (!ignoreerror)
                            {
                                if (isinvalid)
                                {
                                    //txtstatus.Text += "\r\n\r\nValidation error at row: " + (r-1).ToString();
                                    txtstatus.Text += "";

                                    //MessageBox.Show("Cannot continue data import as there are validation errors.\r\nKindly correct the error at LINE: " + (r - 1).ToString() + " and re-import", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    MessageBox.Show("Cannot start Importing since there are errors while validating file.Please correct your data file.", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return true;
                                }
                            }
                        }
                        else //update
                        {

                            Int32 c = 1;
                            for (c = 1; c <= dimend.Column; c++)
                            {
                                if (excelsht.Cells[1, c].Value.ToString() == "ShadeName" )
                                {
                                    if (Convert.ToString(excelsht.Cells[r, c].Value) == "")
                                    {
                                        isinvalid = true;
                                        txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of '" + excelsht.Cells[1, c].Value.ToString() + "' is missing. \r\n\r\n ";
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    sheetname = "altbarcode";
                    p = new ExcelPackage(new System.IO.FileInfo(excelfile));

                    //ExcelPackage.LicenseContext = LicenseContext.NonCommercial
                    excelsht = p.Workbook.Worksheets[sheetname];

                    if (excelsht == null)
                    {
                        MessageBox.Show("Worksheet name [altbarcode] not found in selected file.\r\nCannot continue !", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }

                    ExcelCellAddress dimstart = excelsht.Dimension.Start;
                    ExcelCellAddress dimend = excelsht.Dimension.End;

                    //string barcode = "";

                    string val = "";

                    //Int16 barcodecol = 1;

                    string invalidcols = "";

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

                        //barcode = Convert.ToString(excelsht.Cells[r, barcodecol].Value);

                        invalidcols = "";
                        isinvalid = false;
                        isInsert = true;

                        String altBarcode = "";
                        Int16 altBarcodecol = 2;


                        string AltEanBarcode = "";
                        Int16 AltEanBarcodeCol = 1;
                        ///Satyam 20022023
                        string Status = "";
                        Int16 StatusCol = 4;

                        altBarcode = Convert.ToString(excelsht.Cells[r, altBarcodecol].Value);
                        AltEanBarcode = Convert.ToString(excelsht.Cells[r, AltEanBarcodeCol].Value);
                     
                        string lastcolumnname = "";

                        lastcolumnname = excelsht.Cells[1, dimend.Column].Value.ToString();

                        isInsert = false;
                        isUpdate = false;
                        if (lastcolumnname.ToLower() != "status")
                        {
                            isInsert = true;
                        }
                        else
                        {
                            Status= Convert.ToString(excelsht.Cells[r, StatusCol ].Value);
                            isUpdate = true;
                        }

                        if (isInsert)
                        {
                            //if (barcode.Trim().Length == 0)
                            //{
                            //    //invalidcols += "barcode, ";
                            //    isinvalid = true;
                            //}
                            if (AltEanBarcode.Trim().Length == 0)
                            {
                                isinvalid = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'EAN Barcode' is missing.\r\n\r\n";
                            }
                            else if (altBarcode.Trim().Length == 0)
                            {
                                isinvalid = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'Alt Barcode' is missing.";
                            }


                            if (isinvalid)
                            {
                                txtstatus.Text += "";
                                MessageBox.Show("Cannot start Importing since there are errors while validating file.Please correct your data file.", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return true;
                            }
                        }

                        else if (isUpdate)
                        {
                            if (AltEanBarcode.Trim().Length == 0)
                            {
                                isinvalid = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'EAN Barcode' is missing.\r\n\r\n";
                            }
                            else if (altBarcode.Trim().Length == 0)
                            {
                                isinvalid = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'Alt Barcode' is missing.";
                            }
                            else if (Status.Trim().Length == 0 || Status != "0")
                            {
                                isinvalid = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Invalid Status.";
                            }

                            if (isinvalid)
                            {
                                txtstatus.Text += "";
                                MessageBox.Show("Cannot start Importing since there are errors while validating file.Please correct your data file.", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return true;
                            }

                            
                        }
                    }
                   // UpdateEntryInAltBarcode(excelsht);
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

                //sunil sir 
                if (IgnoreError)
                {
                    ExcelPackage p = new ExcelPackage(new System.IO.FileInfo(excelfile));
                    int iSheetsCount = p.Workbook.Worksheets.Count;
                    if (iSheetsCount > 0)
                    {
                        ExcelWorksheet worksheet = p.Workbook.Worksheets[1];
                        sheetname = worksheet.Name;
                    }
                }


                //string sheetname = "Item";
                // sheetname = "altbarcode";
                if (sheetname == "Shade")
                {
                    ExcelPackage p = new ExcelPackage(new System.IO.FileInfo(excelfile));

                    //ExcelPackage.LicenseContext = LicenseContext.NonCommercial
                    ExcelWorksheet excelsht = p.Workbook.Worksheets[sheetname];

                    ExcelCellAddress dimstart = excelsht.Dimension.Start;
                    ExcelCellAddress dimend = excelsht.Dimension.End;

                    string lastcolumnname = "";

                    lastcolumnname = excelsht.Cells[1, dimend.Column].Value.ToString();

                    isInsert = false;
                    isUpdate = false;
                    if (lastcolumnname.ToLower() != "shade_id")
                    {
                        isInsert = true;
                    }
                    else
                    {
                        isUpdate = true;
                    }

                    sql = "Select ORDINAL_POSITION, COLUMN_NAME, DATA_TYPE ";
                    sql += " from INFORMATION_SCHEMA.COLUMNS ";
                    sql += " where TABLE_NAME = 'Shade' ";                    
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
                else
                {
                    ExcelPackage p = new ExcelPackage(new System.IO.FileInfo(excelfile));


                    ExcelWorksheet excelsht = p.Workbook.Worksheets[sheetname];

                    ExcelCellAddress dimstart = excelsht.Dimension.Start;
                    ExcelCellAddress dimend = excelsht.Dimension.End;

                    string firstcolumnname = "";

                    firstcolumnname = excelsht.Cells[1, dimend.Column - 1].Value.ToString();

                    string lastcolumnname = "";

                    lastcolumnname = excelsht.Cells[1, dimend.Column].Value.ToString();

                    isInsert = false;
                    isUpdate = false;
                    if (lastcolumnname.ToLower() != "status")
                    {
                        isInsert = true;
                    }
                    else
                    {
                       
                        isUpdate = true;
                    }

                    //isInsert = false;
                    //isUpdate = false;
                    //if (firstcolumnname.ToLower() == "altbarcode_no")
                    //{
                    //    isInsert = true;
                    //}
                    //else
                    //{
                    //    isUpdate = true;
                    //}

                    sql = "Select ORDINAL_POSITION, COLUMN_NAME, DATA_TYPE ";
                    sql += " from INFORMATION_SCHEMA.COLUMNS ";
                    sql += " where TABLE_NAME = 'ItemWiseBarcode' ";
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
                        //UpdateEntryInTable(excelsht);
                        UpdateEntryInAltBarcode(excelsht);
                    }

                    txtstatus.AppendText("\r\n\r\nEnd at: " + DateTime.Now.ToString("hh:mm:ss"));
                }
            }//try
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
                    sectkey = 0;
                    itemid = 0;
                    itemkey = 0;
                    itemgrpkey = 0;
                    itemsubgrpkey = 0;
                    brandkey = 0;
                    rackkey = 0;

                    DRSSEQ_ID = 0;

                    unitkey = 0;
                    itemmisckey = 0;
                    qltykey = 0;
                    itemsizekey = 0;
                    eanbarcode = "";
                    barcode = "";
                    itemseries = "";
                    purrate = 0;
                    mrp = 0;
                    salerate = 0;
                    product = "";

                    shadeid = 0;
                    shadekey = 0;

                    Application.DoEvents();
                    txtstatus.AppendText("\r\n\r\nReading row " + excelrowline.ToString() + "...");

                    //sunil 05/08/2021
                    if (sheetname == "Shade")
                    {
                        if (ignoreerror)
                        {

                            ProductCode = "";
                            ProductName = "";

                            String EANBarcode = "";
                            string itemname = "";
                            //string Abbr = "";
                            string ItemDesc = "";
                            string ItemGroup = "";
                            string subgroup = "";
                            string unit = "";
                            string Convunit = "";
                            string ConvQty = "";
                            string PurRate = "";
                            string PurUnit = "";
                            string SaleRate = "";
                            string SaleUnit = "";
                            string MRP = "";
                            string TaxIncl = "";
                            //string SaleRateBeforeTax = "";
                            string DefaultQty = "";
                            string MaintainStk = "";

                            String ShadeName = "";
                            String Abbr = "";
                            String Alt_Code = "";
                            String Remark = "";
                            String Status = "";


                            Int16 ShadeNameCol = 1;
                            Int16 Abbrcol = 2;                            
                            Int16 RemarkCol = 3;
                            Int16 StatusCol = 4;
                            Int16 Alt_CodeCol = 5;
                            Int16 ItemGroupCol = 6;
                            Int16 subgroupcol = 8;
                            Int16 unitcol = 13;
                            Int16 ConvunitCol = 14;
                            Int16 ConvQtyCol = 15;
                            Int16 PurRateCol = 21;
                            Int16 PurUnitCol = 23;
                            Int16 SaleRateCol = 29;
                            Int16 SaleUnitCol = 32;
                            Int16 MRPCol = 33;
                            Int16 TaxInclCol = 19;
                            //Int16 SaleRateBeforeTaxCol = 26;
                            Int16 DefaultQtyCol = 35;
                            Int16 MaintainStkCol = 36;
                            Int16 SupplierCol = 12;


                            ShadeName = Convert.ToString(excelsheet.Cells[r, ShadeNameCol].Value);
                            Abbr = Convert.ToString(excelsheet.Cells[r, Abbrcol].Value);
                            Alt_Code = Convert.ToString(excelsheet.Cells[r, Alt_CodeCol].Value);
                            Remark = Convert.ToString(excelsheet.Cells[r, RemarkCol].Value);
                            Status = Convert.ToString(excelsheet.Cells[r, StatusCol].Value);

                            ItemGroup = Convert.ToString(excelsheet.Cells[r, ItemGroupCol].Value);
                            subgroup = Convert.ToString(excelsheet.Cells[r, subgroupcol].Value);
                            unit = Convert.ToString(excelsheet.Cells[r, unitcol].Value);
                            Convunit = Convert.ToString(excelsheet.Cells[r, ConvunitCol].Value);
                            ConvQty = Convert.ToString(excelsheet.Cells[r, ConvQtyCol].Value);
                            PurRate = Convert.ToString(excelsheet.Cells[r, PurRateCol].Value);
                            PurUnit = Convert.ToString(excelsheet.Cells[r, PurUnitCol].Value);
                            SaleRate = Convert.ToString(excelsheet.Cells[r, SaleRateCol].Value);
                            SaleUnit = Convert.ToString(excelsheet.Cells[r, SaleUnitCol].Value);
                            MRP = Convert.ToString(excelsheet.Cells[r, MRPCol].Value);
                            TaxIncl = Convert.ToString(excelsheet.Cells[r, TaxInclCol].Value);
                            //SaleRateBeforeTax = Convert.ToString(excelsheet.Cells[r, SaleRateBeforeTaxCol].Value);
                            DefaultQty = Convert.ToString(excelsheet.Cells[r, DefaultQtyCol].Value);
                            MaintainStk = Convert.ToString(excelsheet.Cells[r, MaintainStkCol].Value);



                            TaxInclude = TaxIncl;

                            IgnorErrorExcel = false;

                            if (ShadeName.Trim().Length == 0)
                            {
                                IgnorErrorExcel = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'Shade Name' is missing.";
                            }                           
                            else if (Abbr.Trim().Length == 0)
                            {
                                //invalidcols += "Subgroup, ";
                                IgnorErrorExcel = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'Abbr' is missing.";
                            }
                            
                            if (IgnorErrorExcel)
                            {
                                trans.Rollback();
                                goto Err;
                            }

                        }
                    }
                    else
                    {
                        String AltBarcode = "";
                        Int16 AltBarcodeCol = 2;
                        AltBarcode = Convert.ToString(excelsheet.Cells[r, AltBarcodeCol].Value);

                        IgnorErrorExcel = false;
                        if (ignoreerror)
                        {
                            if (AltBarcode.Trim().Length == 0)
                            {
                                IgnorErrorExcel = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'AltBarcodeNo' '" + AltBarcode + "' is missing.\r\n\r\n";
                            }
                            if (IgnorErrorExcel)
                            {
                                trans.Rollback();
                                goto Err;
                            }
                        }
                    }

                    //sunil /05/08/2021
                    if (sheetname == "Shade")
                    {
                        eanbarcode = "";
                        String Item = "";
                        String SubGroup = "";
                        string PurTax = "";
                        string Tax = "";
                        string Supl = "";
                        string SupplierCode = "";

                        string DRS_SEQ = "";


                        alternatebarcode = "";
                        Int16 alternatebarcodeCol = 55;
                        alternatebarcode = Convert.ToString(excelsheet.Cells[r, alternatebarcodeCol].Value);

                        Int16 eanbarcodeCol = 1;
                        Int16 ItemCol = 2;
                        Int16 SubGroupCol = 8;
                        Int16 PurTaxCol = 17;
                        Int16 TaxCol = 18;
                        Int16 SuplCol = 12;
                        Int16 SupplierCodeCol = 11;

                        Int16 DRSSEQCOL = 53;

                        ProductCode = "";
                        ProductName = "";

                        String ShadeName = "";
                        String Abbr = "";
                        String Alt_Code = "";
                        String Remark = "";
                        String Status = "";


                        Int16 ShadeNameCol = 1;
                        Int16 Abbrcol = 2;                        
                        Int16 RemarkCol = 3;
                        Int16 StatusCol = 4;
                        Int16 Alt_CodeCol = 5;

                        ShadeName = Convert.ToString(excelsheet.Cells[r, ShadeNameCol].Value);
                        Abbr = Convert.ToString(excelsheet.Cells[r, Abbrcol].Value);
                        Alt_Code = Convert.ToString(excelsheet.Cells[r, Alt_CodeCol].Value);
                        Remark = Convert.ToString(excelsheet.Cells[r, RemarkCol].Value);
                        Status = Convert.ToString(excelsheet.Cells[r, StatusCol].Value);
                        
                        Supl = Convert.ToString(excelsheet.Cells[r, SuplCol].Value);
                        SupplierCode = Convert.ToString(excelsheet.Cells[r, SupplierCodeCol].Value);

                        ItemGroupCode = Convert.ToString(excelsheet.Cells[r, 5].Value);
                        ItemSubGroupCode = Convert.ToString(excelsheet.Cells[r, 7].Value);


                        if (ShadeName.Trim().Length == 0)
                        {
                            IgnorErrorExcel = true;
                            txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'Shade Name' is missing.";
                        }
                        else if (Abbr.Trim().Length == 0)
                        {
                            //invalidcols += "Subgroup, ";
                            IgnorErrorExcel = true;
                            txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'Abbr' is missing.";
                        }

                        if (IgnorErrorExcel)
                        {
                            trans.Rollback();
                            goto Err;
                        }

                        sql = "Select Shade_Name From Shade Where Shade_Name = '" + ShadeName + "'";
                        DataTable dt1 = null;
                        error = GetTable(sql, trans, ref dt1);
                        if (dt1.Rows.Count > 0)
                        {
                            txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No: " + (r - 1).ToString() + " Shade '" + ShadeName + "' Already Exists \r\n\r\n";
                            trans.Rollback();
                            goto Err;
                        }



                    }
                    else
                    {
                        String Altbarcodeno = "";
                        Int32 ItemIDCheck = 0;
                        string EanBarcodeName = "";

                        Int16 AltbarcodenoCol = 2;
                        Int16 AltEanbarcodeCol = 1;
                        Int16 ItemIDCheckCol = 3;

                        Altbarcodeno = Convert.ToString(excelsheet.Cells[r, AltbarcodenoCol].Value);
                        AltEanbarcode = Convert.ToString(excelsheet.Cells[r, AltEanbarcodeCol].Value);
                        ItemIDCheck = Convert.ToInt32(excelsheet.Cells[r, ItemIDCheckCol].Value);



                        sql = "Select Altbarcode_no, Item.EAN_Barcode From ItemWiseBarcode Left Join Item on Item.Item_id=ItemWiseBarcode.Item_id  Where ItemWiseBarcode.Status='1' And ItemWiseBarcode.Altbarcode_no = '" + Altbarcodeno.Trim () + "'";
                        DataTable dt8 = null;
                        error = GetTable(sql, trans, ref dt8);
                        if (dt8.Rows.Count > 0)
                        {
                            EanBarcodeName = Convert.ToString(dt8.Rows[0][1]);
                            txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No: " + (r - 1).ToString() + " Altbarcode No '" + Altbarcodeno.Trim () + "' Already Exists With Product Code '" + EanBarcodeName + "' \r\n\r\n";
                            trans.Rollback();
                            goto Err;

                        }


                        sql = "Select EAN_Barcode From Item Where Item.EAN_Barcode = '" + AltEanbarcode + "'";
                        DataTable dt9 = null;
                        error = GetTable(sql, trans, ref dt9);

                        if (dt9.Rows.Count == 0)
                        {
                            txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No: " + (r - 1).ToString() + " EAN_Barcode '" + AltEanbarcode + "' Not Created \r\n\r\n";
                            trans.Rollback();
                            goto Err;
                        }
                    
                     

                  
                        sql = "Select Item_ID From Item Where Item.EAN_Barcode = '" + AltEanbarcode + "'";
                        DataTable dt10 = null;
                        error = GetTable(sql, trans, ref dt10);
                        Int32 ItemIDAltBarcode = 0;
                        ItemIDAltBarcode = Convert.ToInt32(dt10.Rows[0][0]);
                        if (ItemIDCheck != ItemIDAltBarcode)
                        {
                            txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No: " + (r - 1).ToString() + " EAN_Barcode '" + AltEanbarcode + "' And Item ID mismatched \r\n\r\n";
                            trans.Rollback();
                            goto Err;

                        }

                        sql = "Select * from ItemWiseBarcode where AltBarcode_no= '" + Altbarcodeno.Trim () + "' And  Status='0' And Item_id=' " + ItemIDAltBarcode + "'";
                        DataTable dt11 = null;
                        error = GetTable(sql, trans, ref dt11);
                        if (dt11.Rows.Count > 0)
                        {
                            sql = " Update ItemWiseBarcode Set Status='1' ,Updated_by = " + importuser + " , Updated_Dt = cast('" + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2) Where AltBarcode_no= '" + Altbarcodeno + "' And  Status='0' And Item_id='" + ItemIDAltBarcode + "' ";
                            sw.WriteLine(sql);
                            error = ExecuteQuery(sql, trans);
                            trans.Commit();
                            txtstatus.AppendText("\r\nAlternate Barcode: " + Altbarcodeno.Trim () + " updated successfully");
                            //conn.Open();
                            goto Err;
                        }


                    }

                    product = Convert.ToString(excelsheet.Cells[r, 2].Value);

                    //sunil 10/10/2021
                    for (c = 1; c <= dimend.Column; c++)
                    {
                        error = ReadAndCreate(excelsheet, r, c, trans, ref columnstring, ref valuestring, ref udfcolumnstring, ref udfvaluestring, ref shadeid, ref shadekey);
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

                    //string sheetname = "Item";
                    //sheetname = "altbarcode";
                    if (sheetname == "Shade")
                    {
                        error = NewRecordId("Shade", "shade_id", trans, ref shadeid);

                        if (error)
                        {
                            //txterrorstatus.AppendText(errortext);
                            AppendErrorText();

                            if (!ignoreerror)
                            {
                                break;
                            }
                        }

                        shadekey = shadeid;

                        DateTime dttime = new DateTime(1900, 01, 01);
                        error = GetSQLDatetime(trans, ref dttime);

                        //valuestring += "'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "',";
                        //columnstring += ",Item_Code,Item_Series,Alt_Code,Mfr_Id,MktdBy_Id,Weight,Weight_Unit,Height,Height_Unit,Length,Width,MkDownRate,RdOff ";
                        //valuestring += ",'','','',0,0," + Convert.ToDecimal("0.00") + ",0," + Convert.ToDecimal("0.00") + ",0," + Convert.ToDecimal("0.00") + ",''," + Convert.ToDecimal("0.00") + ",'0' ";
                        //columnstring += ",NoTax_Id,NoTax_Amt,Maintain_Size,Barcode_Type,Maintain_Style,DiscPerc,AllowDec,MaxDisc ";
                        //valuestring += ",0," + Convert.ToDecimal("0.00") + ",'0','P','0'," + Convert.ToDecimal("0.00") + ",'0'," + Convert.ToDecimal("0.00") + " ";
                        //columnstring += ",Rack_Id,Print_Barcode,ContainsQty,AskDisc,AllowDtls,AllowShade,AllowType,AllowMfgDt,AllowExpiryDt,AllowQlty,AllowSeason,AllowOccassion,Unit1_Id,CalcRateType,CDPer,Item_type,Cut_Type,AllowSizeWiseRate,Use_Weighing_Machine,MachName,Currn_ID ";
                        //valuestring += ",0,'0'," + Convert.ToDecimal("1.00") + ",'0','0','0','0','0','0','0','0','0'," + unitkey + ",'M'," + Convert.ToDecimal("0.00") + ",'F','P','0','0','" + Environment.MachineName + "', " + CurrnID + " ";
                        //columnstring += ", Item_Id,  Created_by, Created_dt, Cobr_id";
                        //valuestring += "," + itemid + "," + importuser + ",'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "','" + branchid + "'";
                        columnstring = "Cobr_id,Shade_Id,Shade_Key," + columnstring + ",Alt_Code,Status,Created_By,Created_Dt,Updated_By,Updated_Dt,Auto_Code";
                        valuestring = "'" + branchid + "'," + shadeid + ",'" + branchid + shadekey + "'," + valuestring + ",'',1," + importuser + ",'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "',NULL,NULL,''";

                        sql = "Insert into Shade (" + columnstring + ") values (" + valuestring + ")";
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

                        //if (eanbarcode != "")
                        //{
                        //ImportItemWiseBarcode(trans);
                        // }
                        //else if (alternatebarcode != "")
                        // {
                        //     ImportItemWiseBarcode(trans);
                        // }



                        //Int32 newid = 0;
                        //error = NewRecordId("UserFieldDataItem", "UserFieldDataItem_Id", trans, ref newid);

                        //if (error)
                        //{
                        //    //txterrorstatus.AppendText(errortext);
                        //    AppendErrorText();

                        //    if (!ignoreerror)
                        //    {
                        //        break;
                        //    }
                        //}

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

                        //sql = "Insert into UserFieldDataItem (UserFieldDataItem_Id, Item_ID, MachName, Created_By, Created_Dt, Updated_By, Updated_Dt" + udfcolumnstring + ") ";
                        //sql += " values (" + newid + "," + itemid + ",'" + Environment.MachineName + "'," + importuser + ",'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "',0,'01/01/1900' " + udfvaluestring + ")";
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


                        //error = NewRecordId("ItemRateHistory", "ItemRateHistory_Id", trans, ref newid);

                        //if (error)
                        //{
                        //    //txterrorstatus.AppendText(errortext);
                        //    AppendErrorText();

                        //    if (!ignoreerror)
                        //    {
                        //        break;
                        //    }
                        //}

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

                        //sql = "Insert into ItemRateHistory (ItemRateHistory_Id, Item_ID,PurRate,MRP,SaleRate,MkUpRate,SaleRateBeforeTax,SaleRateAfterConversion, PurRateAfterTax,MachName, Created_By, Created_Dt) ";
                        //sql += " values (" + newid + "," + itemid + "," + purrate + "," + mrp + "," + salerate + "," + MkUpRate + "," + saleratebeforetax + "," + salerateafterconversion + "," + PurrateAfterTax + ",'" + Environment.MachineName + "'," + importuser + ",'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "')";
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



                        //error = CreateItemSize(trans);

                        //if (error)
                        //{
                        //    //txterrorstatus.AppendText(errortext);
                        //    AppendErrorText();

                        //    if (!ignoreerror)
                        //    {
                        //        break;
                        //    }
                        //}

                        //error = CreateStyle(trans);

                        //if (error)
                        //{
                        //    //txterrorstatus.AppendText(errortext);
                        //    AppendErrorText();

                        //    if (!ignoreerror)
                        //    {
                        //        break;
                        //    }
                        //}

                        //error = CreateStyleSize(trans);

                        //if (error)
                        //{
                        //    //txterrorstatus.AppendText(errortext);
                        //    AppendErrorText();

                        //    if (!ignoreerror)
                        //    {
                        //        break;
                        //    }
                        //}

                        //error = CreateStkCatRt(trans);

                        //if (error)
                        //{
                        //    //txterrorstatus.AppendText(errortext);
                        //    AppendErrorText();

                        //    if (!ignoreerror)
                        //    {
                        //        break;
                        //    }
                        //}

                        //error = CreateItemStock(trans);

                        //if (error)
                        //{
                        //    AppendErrorText();

                        //    if (!ignoreerror)
                        //    {
                        //        break;
                        //    }
                        //}
                    }
                    else
                    {
                        Int32 newid = 0;
                        error = NewRecordId("ItemWiseBarcode", "Barcode_Id", trans, ref newid);

                        if (error)
                        {
                            //txterrorstatus.AppendText(errortext);
                            AppendErrorText();

                            if (!ignoreerror)
                            {
                                break;
                            }
                        }

                        DateTime dttime = new DateTime(1900, 01, 01);

                        error = GetSQLDatetime(trans, ref dttime);

                        if (error)
                        {
                            //txterrorstatus.AppendText(errortext);
                            AppendErrorText();

                            if (!ignoreerror)
                            {
                                break;
                            }
                        }

                        //sql = "Insert into ItemWiseBarcode (Barcode_ID, Item_ID, AltBarcode_No, Created_By, Created_Dt, Updated_By, Updated_Dt,MachName) ";
                        //sql += " values (" + newid + "," + itemid + ",''," + importuser + ",'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "',0,'01/01/1900','" + Environment.MachineName + "')";
                        //error = ExecuteQuery(sql, trans);

                        columnstring += ",item_id , barcode_Id,Status, Created_by, Created_dt,Machname,Barcode_Key";
                        valuestring += "," + newid + ",'1'," + importuser + ",'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "','" + Environment.MachineName + "','"+ branchid + newid  +"'";

                        sql = "Insert into ItemWiseBarcode (" + columnstring + ") values (" + valuestring + ")";
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
                    }
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
                        if (sheetname == "Shade")
                        {
                            //  txtstatus.AppendText("\r\nItem: " + product + " updated successfully");
                            txtstatus.AppendText("\r\n Shade: " + ShadeName  + " updated successfully");
                        }
                        else
                        {
                            txtstatus.AppendText("\r\nAlternate Barcode: " + altbarcode_No + " updated successfully");
                        }

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
                Boolean witherror = false;
                string filepath = System.IO.Directory.GetCurrentDirectory() + "\\ImportLog.txt";
                sw = new System.IO.StreamWriter(filepath);

                ExcelCellAddress dimstart = excelsheet.Dimension.Start;
                ExcelCellAddress dimend = excelsheet.Dimension.End;

                string columnstring = "";
                string valuestring = "";

                string updateoncolumn = excelsheet.Cells[1, dimend.Column].Value.ToString();
                Int32 updateonvalue = 0;
                string udfvaluestring = "";

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

                    if (ignoreerror)
                    {
                        SqlConnection conn = new SqlConnection(connectionstring);
                        conn.Open();
                        trans = conn.BeginTransaction();
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(connectionstring);
                        conn.Open();
                        trans = conn.BeginTransaction();
                    }


                    Application.DoEvents();
                    txtstatus.AppendText("\r\n\r\nReading row " + excelrowline.ToString() + "...");

                    
                    updateonvalue = Convert.ToInt32(excelsheet.Cells[r, dimend.Column].Value.ToString());
                    shadekey = updateonvalue;

                    for (c = 1; c <= dimend.Column; c++)
                    {
                        error = UpdateReadAndCreate(excelsheet, r, c, trans, ref columnstring, ref valuestring, ref udfvaluestring, ref shadeid, ref shadekey);
                        if (error)
                        {
                            goto Err;
                        }
                    }
                    Err:

                    if (error)
                    {
                        AppendErrorText();

                        if (!ignoreerror)
                        {
                            trans.Rollback();
                            break;
                        }
                        else if (ignoreerror)
                        {
                            trans.Rollback();
                            break;
                        }
                    }

                    if (!error)
                    {
                        DateTime dttime = new DateTime(1900, 01, 01);
                        error = GetSQLDatetime(trans, ref dttime);

                        if (valuestring.EndsWith(","))
                        {
                            valuestring = valuestring.Substring(0, valuestring.Length - 1);
                        }

                        valuestring += ", Updated_By = " + importuser + ", Updated_Dt = '" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "'";
                        sql = "Update Shade Set " + valuestring + " Where " + updateoncolumn + " = " + updateonvalue + "";
                        sw.WriteLine(sql);
                        error = ExecuteQuery(sql, trans);

                        Decimal TaxPerc = 0;
                        string val = "";
                        Decimal MarkUpVal = 0;
                        Decimal Margin = 0;
                        decimal ConvQty = 0;

                        if (PurRateyn == "1"  && PurRateAfterTaxyn == "0")
                        {
                            sql = "select PurTax_Id, SaleRate, FreightAmt, DutyAmt   From Item where Item_id = " + itemkey + "";
                            DataTable dtTaxId = null;
                            error = GetTable(sql, trans, ref dtTaxId);
                            PURTAXID = Convert.ToInt32(dtTaxId.Rows[0][0]);
                            salerate= Convert.ToDecimal(dtTaxId.Rows[0][1]);
                            FreightAmt = Convert.ToDecimal(dtTaxId.Rows[0][2]);
                            DutyAmt = Convert.ToDecimal(dtTaxId.Rows[0][3]);
                            LandedCost = FreightAmt + DutyAmt + purrate  ;

                            
                            sql = "select Isnull(Tax_perc,0) Tax_perc From Ledger where Led_id = " + PURTAXID + "";
                            DataTable dt4 = null;
                            error = GetTable(sql, trans, ref dt4);
                            TaxPerc = Convert.ToDecimal(dt4.Rows[0][0]);
                            PurrateAfterTax = Math.Round((purrate + Math.Round(((purrate * TaxPerc) / 100), 4)), 4);
                            val = Convert.ToString(PurrateAfterTax);

                            landedcostincltax = Math.Round((LandedCost + Math.Round(((LandedCost * TaxPerc) / 100), 4)), 4);

                            MkUpRate = Math.Round((((salerate - purrate) * 100) / purrate), 2);
                            MarkUpVal = purrate * (MkUpRate / 100);
                            Margin = Math.Round((MarkUpVal * 100) / salerate, 2);
                          
                            sql = "Update Item Set MkUpRate = " + MkUpRate + ", Margin = " + Margin + ",  LandedCost = " + LandedCost + ", landedcostincltax = " + landedcostincltax + ", purrateaftertax = " + val + "  Where " + updateoncolumn + " = " + updateonvalue + "";
                            sw.WriteLine(sql);

                            error = ExecuteQuery(sql, trans);
                        }

                        if (PurRateyn == "0" && PurRateAfterTaxyn == "1")
                        {
                            sql = "select PurTax_Id, SaleRate, FreightAmt, DutyAmt  From Item where Item_id = " + itemkey + "";
                            DataTable dtTaxId = null;
                            error = GetTable(sql, trans, ref dtTaxId);
                            PURTAXID = Convert.ToInt32(dtTaxId.Rows[0][0]);
                            salerate = Convert.ToDecimal(dtTaxId.Rows[0][1]);
                            FreightAmt = Convert.ToDecimal(dtTaxId.Rows[0][2]);
                            DutyAmt = Convert.ToDecimal(dtTaxId.Rows[0][3]);
                            

                            sql = "select Isnull(Tax_perc,0) Tax_perc From Ledger where Led_id = " + PURTAXID + "";
                            DataTable dt4 = null;
                            error = GetTable(sql, trans, ref dt4);
                            TaxPerc = Convert.ToDecimal(dt4.Rows[0][0]);
                            purrate  = Math.Round(((PurrateAfterTax /(TaxPerc+100)) * 100), 4);
                            val = Convert.ToString(purrate);

                            MkUpRate = Math.Round((((salerate - purrate) * 100) / purrate), 2);
                            MarkUpVal = purrate * (MkUpRate / 100);
                            Margin = Math.Round((MarkUpVal * 100) / salerate, 2);

                            LandedCost = FreightAmt + DutyAmt + purrate;

                            landedcostincltax = Math.Round((LandedCost + Math.Round(((LandedCost * TaxPerc) / 100), 4)), 4);

                            sql = "Update Item Set MkUpRate = " + MkUpRate + ", Margin = " + Margin + ", LandedCost = " + LandedCost + ", landedcostincltax = " + landedcostincltax + " , purrate= " + val + "  Where " + updateoncolumn + " = " + updateonvalue + "";
                            sw.WriteLine(sql);

                            error = ExecuteQuery(sql, trans);
                        }

                        if (FreightAmtyn == "1" || DutyAmtyn == "1")
                        {
                            sql = "select PurTax_Id, FreightAmt, DutyAmt, Purrate   From Item where Item_id = " + itemkey + "";
                            DataTable dtTaxId = null;
                            error = GetTable(sql, trans, ref dtTaxId);
                            PURTAXID = Convert.ToInt32(dtTaxId.Rows[0][0]);
                            FreightAmt = Convert.ToDecimal(dtTaxId.Rows[0][1]);
                            DutyAmt = Convert.ToDecimal(dtTaxId.Rows[0][2]);
                            purrate = Convert.ToDecimal(dtTaxId.Rows[0][3]);
                            LandedCost = FreightAmt + DutyAmt + purrate;

                            sql = "select Isnull(Tax_perc,0) Tax_perc From Ledger where Led_id = " + PURTAXID + "";
                            DataTable dt4 = null;
                            error = GetTable(sql, trans, ref dt4);
                            TaxPerc = Convert.ToDecimal(dt4.Rows[0][0]);

                            landedcostincltax = Math.Round((LandedCost + Math.Round(((LandedCost * TaxPerc) / 100), 4)), 4);
                            
                            sql = "Update Item Set LandedCost = " + LandedCost + ", landedcostincltax = " + landedcostincltax + " Where " + updateoncolumn + " = " + updateonvalue + "";
                            sw.WriteLine(sql);

                            error = ExecuteQuery(sql, trans);
                        }

                        if (SaleRateyn == "1" && SaleRateBeforeTaxyn == "0")
                        {
                            sql = "select Tax_Id, Purrate, Conv_Qty From Item where Item_id = " + itemkey + "";
                            DataTable dtTaxId = null;
                            error = GetTable(sql, trans, ref dtTaxId);
                            TAXID  = Convert.ToInt32(dtTaxId.Rows[0][0]);
                            purrate = Convert.ToDecimal(dtTaxId.Rows[0][1]);
                            ConvQty = Convert.ToDecimal(dtTaxId.Rows[0][2]);


                            sql = "select Isnull(Tax_perc,0) Tax_perc From Ledger where Led_id = " + TAXID + "";
                            DataTable dt4 = null;
                            error = GetTable(sql, trans, ref dt4);
                            TaxPerc = Convert.ToDecimal(dt4.Rows[0][0]);
                            saleratebeforetax  = Math.Round(((salerate/ (TaxPerc + 100)) * 100), 2);
                            val = Convert.ToString(saleratebeforetax);
                            
                            MkUpRate = Math.Round((((salerate - purrate) * 100) / purrate), 2);
                            MarkUpVal = purrate * (MkUpRate / 100);
                            Margin = Math.Round((MarkUpVal * 100) / salerate, 2);

                            if (salerateafterconversion == 0 && ConvQty == 1)
                            {
                                sql = "Update Item Set MkUpRate = " + MkUpRate + ", Margin = " + Margin + ",  SaleRateBeforeTax = " + saleratebeforetax + ", MRP = " + salerate + ",  SaleRateAfterConversion = " + salerate + " Where " + updateoncolumn + " = " + updateonvalue + "";
                            }
                            else
                            {
                                sql = "Update Item Set MkUpRate = " + MkUpRate + ", Margin = " + Margin + ",  SaleRateBeforeTax = " + saleratebeforetax + ", MRP = " + salerate + "  Where " + updateoncolumn + " = " + updateonvalue + "";
                            }
                            sw.WriteLine(sql);
                            error = ExecuteQuery(sql, trans);
                        }

                        if (SaleRateyn == "0" && SaleRateBeforeTaxyn == "1")
                        {
                            sql = "select Tax_Id, Purrate, Conv_Qty From Item where Item_id = " + itemkey + "";
                            DataTable dtTaxId = null;
                            error = GetTable(sql, trans, ref dtTaxId);
                            TAXID = Convert.ToInt32(dtTaxId.Rows[0][0]);
                            purrate = Convert.ToDecimal(dtTaxId.Rows[0][1]);
                            ConvQty = Convert.ToDecimal(dtTaxId.Rows[0][2]);


                            sql = "select Isnull(Tax_perc,0) Tax_perc From Ledger where Led_id = " + TAXID + "";
                            DataTable dt4 = null;
                            error = GetTable(sql, trans, ref dt4);
                            TaxPerc = Convert.ToDecimal(dt4.Rows[0][0]);
                            salerate = Math.Round((saleratebeforetax  + Math.Round(((saleratebeforetax * TaxPerc) / 100), 2)), 2);
                            val = Convert.ToString(salerate);

                            MkUpRate = Math.Round((((salerate - purrate) * 100) / purrate), 2);
                            MarkUpVal = purrate * (MkUpRate / 100);
                            Margin = Math.Round((MarkUpVal * 100) / salerate, 2);

                            if (salerateafterconversion == 0 && ConvQty == 1)
                            {
                                sql = "Update Item Set MkUpRate = " + MkUpRate + ", Margin = " + Margin + ",  SaleRate = " + salerate + ", MRP = " + salerate + ",  SaleRateAfterConversion = " + salerate + " Where " + updateoncolumn + " = " + updateonvalue + "";
                            }
                            else
                            {
                                sql = "Update Item Set MkUpRate = " + MkUpRate + ", Margin = " + Margin + ",  SaleRate = " + salerate + ", MRP = " + salerate + "  Where " + updateoncolumn + " = " + updateonvalue + "";
                            }
                            sw.WriteLine(sql);
                            error = ExecuteQuery(sql, trans);
                        }

                        if (SaleRateyn == "1" && SaleRateBeforeTaxyn == "1")
                        {
                            sql = "select Purrate, Conv_Qty From Item where Item_id = " + itemkey + "";
                            DataTable dtTaxId = null;
                            error = GetTable(sql, trans, ref dtTaxId);                            
                            purrate = Convert.ToDecimal(dtTaxId.Rows[0][0]);
                            ConvQty = Convert.ToDecimal(dtTaxId.Rows[0][1]);                            

                            MkUpRate = Math.Round((((salerate - purrate) * 100) / purrate), 2);
                            MarkUpVal = purrate * (MkUpRate / 100);
                            Margin = Math.Round((MarkUpVal * 100) / salerate, 2);

                            if (salerateafterconversion == 0 && ConvQty == 1)
                            {
                                sql = "Update Item Set MkUpRate = " + MkUpRate + ", Margin = " + Margin + ",  SaleRateAfterConversion = " + salerate + " Where " + updateoncolumn + " = " + updateonvalue + "";
                            }
                            else
                            {
                                sql = "Update Item Set MkUpRate = " + MkUpRate + ", Margin = " + Margin + "  Where " + updateoncolumn + " = " + updateonvalue + "";
                            }
                            sw.WriteLine(sql);
                            error = ExecuteQuery(sql, trans);
                        }

                        //, UpdatedFrom = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'
                        if (error)
                        {
                            AppendErrorText();

                            if (!ignoreerror)
                            {
                                break;
                            }
                        }
                    }

                    if (!error)
                    {
                       
                        if (error)
                        {
                            AppendErrorText();

                            if (!ignoreerror)
                            {
                                break;
                            }
                        }
                    }

                    //Int32 newid = 0;
                    //error = NewRecordId("ItemRateHistory", "ItemRateHistory_Id", trans, ref newid);

                    //if (error)
                    //{
                    //    //txterrorstatus.AppendText(errortext);
                    //    AppendErrorText();

                    //    if (!ignoreerror)
                    //    {
                    //        break;
                    //    }
                    //}

                    //DateTime dttime = new DateTime(1900, 01, 01);

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

                    //sql = "Insert into ItemRateHistory (ItemRateHistory_Id, Item_ID,PurRate,MRP,SaleRate,MkUpRate,SaleRateBeforeTax,SaleRateAfterConversion, PurRateAfterTax,MachName, Created_By, Created_Dt) ";
                    //sql += " values (" + newid + "," + updateonvalue + "," + purrate + "," + mrp + "," + salerate + "," + MkUpRate + "," + saleratebeforetax + "," + salerateafterconversion + "," + PurrateAfterTax + ",'" + Environment.MachineName + "'," + importuser + ",'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "')";
                    //error = ExecuteQuery(sql, trans);


                    //error = CreateItemSize(trans);

                    //if (error)
                    //{
                    //    AppendErrorText();
                    //    if (!ignoreerror)
                    //    {
                    //        break;
                    //    }
                    //}

                    //error = CreateStyle(trans);

                    //if (error)
                    //{
                    //    AppendErrorText();

                    //    if (!ignoreerror)
                    //    {
                    //        break;
                    //    }
                    //}

                    //error = CreateStyleSize(trans);

                    //if (error)
                    //{
                    //    AppendErrorText();

                    //    if (!ignoreerror)
                    //    {
                    //        break;
                    //    }
                    //}

                    //error = CreateStkCatRt(trans);

                    //if (error)
                    //{
                    //    AppendErrorText();

                    //    if (!ignoreerror)
                    //    {
                    //        break;
                    //    }
                    //}

                    //error = CreateItemStock(trans);

                    //if (error)
                    //{
                    //    AppendErrorText();

                    //    if (!ignoreerror)
                    //    {
                    //        break;
                    //    }
                    //}
                    //if (ignoreerror && !error)
                    //{
                    //    trans.Commit();
                    //    //txtstatus.AppendText("\r\nItem: " + product + " updated successfully");
                    //     txtstatus.AppendText("\r\nProduct Code: " + ProductCode + " Item: " + ProductName  + " updated successfully");
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

                        // txtstatus.AppendText("\r\nItem: " + product + " updated successfully");
                        txtstatus.AppendText("\r\n Shade: " + ShadeName + " updated successfully");
                    }
                    Err1:
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
        // Satyam 20022023
        private void UpdateEntryInAltBarcode(ExcelWorksheet excelsheet)
        {
            SqlTransaction trans = null;
            Int32 r = 1;
            Int32 c = 1;
            Boolean error = false;

            try
            {
                Boolean witherror = false;
                string filepath = System.IO.Directory.GetCurrentDirectory() + "\\ImportLog.txt";
                sw = new System.IO.StreamWriter(filepath);

                ExcelCellAddress dimstart = excelsheet.Dimension.Start;
                ExcelCellAddress dimend = excelsheet.Dimension.End;

          
                string valuestring = "";

                string updateoncolumn = excelsheet.Cells[1, dimend.Column].Value.ToString();
              
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
                   
                    valuestring = "";
                   

                    if (ignoreerror)
                    {
                        SqlConnection conn = new SqlConnection(connectionstring);
                        conn.Open();
                        trans = conn.BeginTransaction();
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(connectionstring);
                        conn.Open();
                        trans = conn.BeginTransaction();
                    }


                    Application.DoEvents();
                    txtstatus.AppendText("\r\n\r\nReading row " + excelrowline.ToString() + "...");
                    string invalidcols = "";
                    // Suraj 140921
                    if (sheetname == "altbarcode")
                    {
                        Boolean isinvalid = false;
                        //  invalidcols = "";
                        //string invalidcols = "";
                        isinvalid = false;

                        string val = "";

                        //Int16 barcodecol = 1;

                       // string invalidcols = "";


                        string   altBarcode = "";
                        Int16 altBarcodecol = 2;


                        string AltEanBarcode = "";
                        Int16 AltEanBarcodeCol = 1;
                        ///Satyam 20022023
                        ///
                        string Status = "";
                        Int16 StatusCol = 4;
                        string Item_id = "";
                        Int16 Item_IdCol =3;

                        altBarcode = Convert.ToString(excelsheet.Cells[r, altBarcodecol].Value);
                        AltEanBarcode = Convert.ToString(excelsheet.Cells[r, AltEanBarcodeCol].Value);
                        Status  = Convert.ToString(excelsheet.Cells[r, StatusCol ].Value);
                        Item_id = Convert.ToString(excelsheet.Cells[r, Item_IdCol ].Value);
                        string lastcolumnname = "";

                        lastcolumnname = excelsheet.Cells[1, dimend.Column].Value.ToString();




                        ////jyoti 25/11/2021
                        ////sql = "Select Ean_Barcode From Item Where Item.Ean_Barcode = '" + EANBarcode + "' and Item.Item_Name = '" + ItemName + "'";

                        altbarcode_No = altBarcode;
                        if (lastcolumnname.ToLower() != "status")
                        {
                            isInsert = true;
                        }
                        else
                        {
                            Status = Convert.ToString(excelsheet.Cells[r, StatusCol].Value);
                            isUpdate = true;
                        }


                        if (isInsert)
                        {
                            //if (barcode.Trim().Length == 0)
                            //{
                            //    //invalidcols += "barcode, ";
                            //    isinvalid = true;
                            //}
                            if (AltEanBarcode.Trim().Length == 0)
                            {
                                isinvalid = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'EAN Barcode' is missing.\r\n\r\n";
                                goto Err1;
                            }
                            else if (altBarcode.Trim().Length == 0)
                            {
                                isinvalid = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'Alt Barcode' is missing.\r\n\r\n";
                                goto Err1;
                            }


                            //if (isinvalid)
                            //{
                            //    txtstatus.Text += "";
                            //    MessageBox.Show("Cannot start Importing since there are errors while validating file.Please correct your data file.", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //    return true;
                            //}
                        }

                        else if (isUpdate)
                        {
                            if (AltEanBarcode.Trim().Length == 0)
                            {
                                isinvalid = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'EAN Barcode' is missing.\r\n\r\n";
                                goto Err1;
                            }
                            else if (altBarcode.Trim().Length == 0)
                            {
                                isinvalid = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of 'Alt Barcode' is missing.\r\n\r\n";
                                goto Err1;
                            }
                            else if (Status.Trim().Length == 0 || Status != "0")
                            {
                                isinvalid = true;
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Invalid Status.\r\n\r\n";
                                goto Err1;
                            }

                            //if (isinvalid)
                            //{
                            //    txtstatus.Text += "";
                            //    MessageBox.Show("Cannot start Importing since there are errors while validating file.Please correct your data file.", "UniRetail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //    return true;
                            //}


                        }

                        //updateonvalue = Convert.ToInt32(excelsheet.Cells[r, dimend.Column].Value.ToString());
                        //itemkey = updateonvalue;

                        //for (c = 1; c <= dimend.Column; c++)
                        //{
                        //    error = UpdateReadAndCreate(excelsheet, r, c, trans, ref columnstring, ref valuestring, ref udfvaluestring, ref itemid, ref itemkey);
                        //    if (error)
                        //    {
                        //        goto Err;
                        //    }
                        //}
                        //Err:

                        if (error)
                    {
                        AppendErrorText();

                        if (!ignoreerror)
                        {
                            trans.Rollback();
                            break;
                        }
                        else if (ignoreerror)
                        {
                            trans.Rollback();
                            break;
                        }
                    }

                    if (!error)
                    {
                        string barcode_id = "";
                        DateTime dttime = new DateTime(1900, 01, 01);
                        error = GetSQLDatetime(trans, ref dttime);

                        //if (valuestring.EndsWith(","))
                        //{
                        //    valuestring = valuestring.Substring(0, valuestring.Length - 1);
                        //}

                        sql = "select Barcode_id   From ItemWiseBarcode where altBarcode_No = '" + altBarcode  + "' and Item_id ="+ Item_id + " and Status='1'  ";
                        DataTable dt9 = null;
                        error = GetTable(sql, trans, ref dt9);


                            if (dt9.Rows.Count == 0)
                            {
                                txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No: " + (r - 1).ToString() + "  AltBarcode '" + altBarcode + "' with Product Code '" + AltEanBarcode + "' does not exist  \r\n\r\n";
                                trans.Rollback();
                                goto Err1;
                            }
                            else
                            {
                                barcode_id = Convert.ToString(dt9.Rows[0][0]);
                            }
                                 
                            



                            valuestring = " Updated_By = " + importuser + ", Updated_Dt = '" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "',Machname = '" + Environment.MachineName + "'";
                        sql = "Update ItemWiseBarcode Set " + valuestring + ",Status='0'  Where Barcode_id = " + barcode_id  + "";
                        sw.WriteLine(sql);
                        error = ExecuteQuery(sql, trans);

                     
                        }

                     

                        //, UpdatedFrom = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'
                        if (error)
                        {
                            AppendErrorText();

                            if (!ignoreerror)
                            {
                                break;
                            }
                        }
                    }
                   
                 

                    //error = CreateStyleSize(trans);

                    //if (error)
                    //{
                    //    AppendErrorText();

                    //    if (!ignoreerror)
                    //    {
                    //        break;
                    //    }
                    //}

                    //error = CreateStkCatRt(trans);

                    //if (error)
                    //{
                    //    AppendErrorText();

                    //    if (!ignoreerror)
                    //    {
                    //        break;
                    //    }
                    //}

                
                    if (  !error)
                    {
                        trans.Commit();
                        txtstatus.AppendText("\r\n\r\n Line No: " + (r - 1).ToString() + " Alternate Barcode: " + altbarcode_No + " Status updated successfully");

                    }

                    else if (error)
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

                        txtstatus.AppendText("\r\n\r\n Alternate Barcode: " + altbarcode_No + " Status updated successfully");

                    }
                    Err1:
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

        //
        private Boolean ReadAndCreate(ExcelWorksheet excelsheet, Int32 r, Int32 c, SqlTransaction trans, ref string columnstring, ref string valuestring, ref string udfcolumnstring, ref string udfvaluestring, ref Int32 shadeid, ref Int32 shadekey)
        {
            try
            {
                string dbcolname = "";
                string excelcolhdr = "";
                string val = "";
                string datatype = "";
                List<ImportItemColumns> srchcols;
                Boolean error;
                Boolean reterror;

                // sunil 10/10/2021
                //return false;

                val = Convert.ToString(excelsheet.Cells[r, c].Value);
                excelcolhdr = Convert.ToString(excelsheet.Cells[1, c].Value);
                srchcols = cols.FindAll(x => x.ColumnName.ToLower() == excelcolhdr.ToLower());
                error = false;
                reterror = false;

                if (srchcols.Count != 0 || excelcolhdr == "ShadeName" || excelcolhdr == "AltCode")
                {
                    if (excelcolhdr == "ItemGroup")
                    {
                        dbcolname = "itemgroup";
                        datatype = "varchar";
                    }
                    else if  (excelcolhdr == "DRS_SEQ")
                    {
                        dbcolname = "DRSMST_ID";
                        datatype = "bigint";
                    }
                    else
                    {
                        dbcolname = srchcols[0].ColumnName;
                        datatype = srchcols[0].DataType;
                    }

                    //Console.WriteLine(dbcolname.Substring(0, 3).ToLower());


                    if (dbcolname.Substring(0, 3).ToLower() == "ud_")
                    {
                        //udfcolumnstring += dbcolname + ",";
                        udfcolumnstring = string.Concat(udfcolumnstring, dbcolname + ",");
                    }
                    else if (dbcolname.ToLower() != "shade_id" )
                    {
                        //columnstring += dbcolname + ",";
                        columnstring = string.Concat(columnstring, dbcolname + ",");
                    }

                    if (datatype.ToLower() == "varchar" || datatype.ToLower() == "char")
                    {
                        if (dbcolname.ToLower() == "shade_name")
                        {
                            ShadeName = val;
                        }
                        if (dbcolname.ToLower() == "abbr")
                        {
                            Abbr = val;
                        }
                        if (dbcolname.ToLower() == "alt_code")
                        {
                            Alt_Code = val.Trim();
                        }
                        if (dbcolname.ToLower() == "remark")
                        {
                            Remark = val.Trim();
                        }
                        if (dbcolname.ToLower() == "status")
                        {
                            Status = val.Trim();
                        }
                        val = GetKeyValue(dbcolname, val.Trim (), trans, ref error, sheetname);



                        if (error)
                        {
                            return true;
                        }

                        if (dbcolname.Substring(0, 3).ToLower() == "ud_")
                        {
                            //udfvaluestring += "'" + val.Replace("'", "''") + "',";
                            udfvaluestring = string.Concat(udfvaluestring, "'" + val.Replace("'", "''") + "',");
                        }
                        else
                        {
                            //valuestring += "'" + val.Replace("'", "''") + "',";
                            if (dbcolname.ToLower() != "itemgroup")
                            {
                                valuestring = string.Concat(valuestring, "'" + val.Replace("'", "''") + "',");
                            }
                        }

                        return false;
                    }
                    else if (datatype.ToLower() == "bigint" || datatype.ToLower() == "int" || datatype.ToLower() == "decimal" || datatype.ToLower() == "numeric" || datatype.ToLower() == "float")
                    {
                        if (dbcolname.ToLower() == "purrate")
                        {
                            purrate = Math.Round(Convert.ToDecimal(val), 4);
                        }
                        else if (dbcolname.ToLower() == "mrp")
                        {
                            mrp = Math.Round(Convert.ToDecimal(val), 2);
                        }
                        else if (dbcolname.ToLower() == "conv_qty")
                        {
                            ConvQty = Convert.ToDecimal(val);
                        }
                        else if (dbcolname.ToLower() == "salerate")
                        {
                            salerate = Math.Round(Convert.ToDecimal(val), 2);
                        }
                        else if (dbcolname.ToLower() == "purrateaftertax")
                        {
                            if (val == "0" || val == "")
                            {
                                Decimal TaxPerc = 0;
                                sql = "select Isnull(Tax_perc,0) Tax_perc From Ledger where Led_id = " + PURTAXID + "";
                                DataTable dt4 = null;
                                error = GetTable(sql, trans, ref dt4);
                                TaxPerc = Convert.ToDecimal(dt4.Rows[0][0]);
                                PurrateAfterTax = Math.Round((purrate + Math.Round(((purrate * TaxPerc) / 100), 4)), 4);
                                val = Convert.ToString(PurrateAfterTax);
                            }
                            else
                            {
                                PurrateAfterTax = Math.Round(Convert.ToDecimal(val), 4);
                            }

                        }
                        else if (dbcolname.ToLower() == "saleratebeforetax")
                        {
                            if (val == "0" || val == "")
                            {
                                if (TaxInclude == "1")
                                {
                                    Decimal TaxPerc = 0;
                                    sql = "select Isnull(Tax_perc,0) Tax_perc From Ledger where Led_id = " + TAXID + "";
                                    DataTable dt4 = null;
                                    error = GetTable(sql, trans, ref dt4);
                                    TaxPerc = Convert.ToDecimal(dt4.Rows[0][0]);
                                    saleratebeforetax = Math.Round(((salerate / (100 + TaxPerc)) * 100), 2);
                                    val = Convert.ToString(saleratebeforetax);
                                }
                                else
                                {
                                    saleratebeforetax = Math.Round(salerate, 2);
                                    val = Convert.ToString(saleratebeforetax);
                                }
                            }
                            else
                            {
                                saleratebeforetax = Math.Round(Convert.ToDecimal(val), 2);
                                val = Convert.ToString(saleratebeforetax);
                            }

                        }
                        else if (dbcolname.ToLower() == "mkuprate")
                        {
                            if (val == "0" || val == "")
                            {
                                //Format$(((Val(txtSaleRt.EditValue) - Val(txtPurRt.EditValue)) * 100) / Val(txtPurRt.EditValue), "0.00")
                                //val =  "0" ;
                                //MkUpRate = Convert.ToDecimal(val);  
                                if (purrate > 0)
                                {
                                    MkUpRate = Math.Round((((salerate - purrate) * 100) / purrate), 2);

                                  
                                }
                                else
                                {
                                    MkUpRate = 0;

                                  
                                }

                                val = Convert.ToString(MkUpRate);

                            }
                            else
                            {
                                //MkUpRate = Math.Round(Convert.ToDecimal(val), 2);  
                                MkUpRate = Math.Round((((salerate - purrate) * 100) / purrate), 2); //satyam 09082023

                            }
                        }
                        else if (dbcolname.ToLower() == "margin")
                        {
                            if (val == "0" || val == "")
                            {
                                //Satyam 09082023
                                val = "0";
                                decimal  srate = Convert.ToDecimal (excelsheet.Cells[r, 29].Value);

                               

                                MkUpRate = Math.Round((((srate  - purrate) * 100) / purrate), 2);
                                decimal MarkUpVal = purrate * (MkUpRate / 100);

                                Margin = Math.Round((MarkUpVal * 100) / srate , 2);

                                val = Convert.ToString(Margin);

                                //end 
                            }
                            else
                            {
                                 //Margin = Convert.ToDecimal(val);
                                //satyam 09082023

                                decimal srate = Convert.ToDecimal(excelsheet.Cells[r, 29].Value);



                                MkUpRate = Math.Round((((srate - purrate) * 100) / purrate), 2);
                                decimal MarkUpVal = purrate * (MkUpRate / 100);

                                Margin = Math.Round((MarkUpVal * 100) / srate, 2);

                                val = Convert.ToString(Margin);
                                //end 
                            }
                        }
                        else if (dbcolname.ToLower() == "salerateafterconversion")
                        {
                            if (val == "0" || val == "")
                            {
                                salerateafterconversion = Math.Round((salerate), 2);
                                val = Convert.ToString(salerateafterconversion);
                            }
                            else
                            {
                                salerateafterconversion = Math.Round((Convert.ToDecimal(val)), 2);
                                val = Convert.ToString(salerateafterconversion);
                            }
                        }
                        else if (dbcolname.ToLower() == "freightamt")
                        {
                            FreightAmt = Convert.ToDecimal(val);
                        }
                        else if (dbcolname.ToLower() == "dutyamt")
                        {
                            DutyAmt = Convert.ToDecimal(val);
                        }
                        else if (dbcolname.ToLower() == "landedcost")
                        {
                            if (val == "0" || val == "")
                            {
                                LandedCost = Math.Round((purrate + FreightAmt + DutyAmt), 4);
                                val = Convert.ToString(LandedCost);
                            }
                            else
                            {
                                LandedCost = Math.Round((Convert.ToDecimal(val)), 4);
                            }
                        }
                        else if (dbcolname.ToLower() == "landedcostincltax")
                        {
                            if (val == "0" || val == "")
                            {
                                //val = "0";
                                //landedcostincltax = Convert.ToDecimal(val);

                                Decimal TaxPerc = 0;
                                sql = "select Isnull(Tax_perc,0) Tax_perc From Ledger where Led_id = " + PURTAXID + "";
                                DataTable dt4 = null;
                                error = GetTable(sql, trans, ref dt4);
                                TaxPerc = Convert.ToDecimal(dt4.Rows[0][0]);
                                landedcostincltax = Math.Round((LandedCost + ((LandedCost) * (TaxPerc) / 100)), 4);
                                val = Convert.ToString(landedcostincltax);

                            }
                            else
                            {
                                landedcostincltax = Math.Round((Convert.ToDecimal(val)), 4);
                            }
                        }
                        else if (sheetname == "altbarcode")
                        {
                            if (dbcolname.ToLower() == "item_id")
                            {
                                if (val == "")
                                {
                                    sql = "select Item.Item_Id From Item where Item.EAN_Barcode = '" + AltEanbarcode + "'";
                                    DataTable dt5 = null;
                                    error = GetTable(sql, trans, ref dt5);
                                    val = Convert.ToString(dt5.Rows[0][0]);
                                }
                            }
                        }
                        val = GetKeyValue(dbcolname, val, trans, ref error, sheetname);

                        if (dbcolname.Substring(0, 3).ToLower() == "ud_")
                        {
                            //udfvaluestring += (val == "") ? 0.ToString() + "," : val + ",";
                            udfvaluestring = string.Concat(udfvaluestring, (val == "") ? 0.ToString() + "," : val + ",");
                        }
                        else if (datatype.ToLower() == "decimal")
                        {
                            if (val != "NULL" && val != "")
                            {
                                //valuestring += Convert.ToDecimal(val) + ",";
                                valuestring = string.Concat(valuestring, Convert.ToDecimal(val) + ",");
                            }
                            else
                            {
                                //valuestring += string.Format("{0:0.00}", val) + ",";
                                valuestring = string.Concat(valuestring, string.Format("{0:0.00}", val) + ",");
                            }
                        }
                        else
                        {
                            //valuestring += (val == "") ? 0.ToString() + "," : val + ",";
                            valuestring = string.Concat(valuestring, (val == "") ? 0.ToString() + "," : val + ",");
                        }

                    }
                    else if (datatype.ToLower() == "datetime")
                    {

                        val = GetKeyValue(dbcolname, val, trans, ref error, sheetname);

                        if (dbcolname.ToLower() == "created_dt")
                        {
                            DateTime dttime = new DateTime(1900, 01, 01);
                            error = GetSQLDatetime(trans, ref dttime);

                            //valuestring += "'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "',";
                            valuestring = string.Concat(valuestring, "'" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "',");
                        }
                        else
                        {
                            if (dbcolname.Substring(0, 3).ToLower() == "ud_")
                            {
                                if (val != "NULL" && val != "")
                                {
                                    DateTime dttime = Convert.ToDateTime(val);
                                    //udfvaluestring += "cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                                    udfvaluestring = string.Concat(udfvaluestring, "cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),");
                                }
                                else
                                {
                                    //DateTime dttime = new DateTime(1900, 01, 01);
                                    //error = GetSQLDatetime(trans, ref dttime);
                                    //valuestring += "cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                                    //udfvaluestring += "'01/01/1900',";
                                    udfvaluestring = string.Concat(udfvaluestring, "'01/01/1900',");
                                }
                                // udfvaluestring += "'" + val + "',";
                            }
                            else
                            {
                                //valuestring += "'" + val + "',";
                                valuestring = string.Concat(valuestring, "'" + val + "',");
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

        private Boolean UpdateReadAndCreate(ExcelWorksheet excelsheet, Int32 r, Int32 c, SqlTransaction trans, ref string columnstring, ref string valuestring, ref string udfvaluestring, ref Int32 itemid, ref Int32 itemkey)
        {
            try
            {
                string dbcolname = "";
                string excelcolhdr = "";
                string val = "";
                string datatype = "";
                List<ImportItemColumns> srchcols;
                Boolean error;

                val = Convert.ToString(excelsheet.Cells[r, c].Value);
                excelcolhdr = Convert.ToString(excelsheet.Cells[1, c].Value);
                srchcols = cols.FindAll(x => x.ColumnName.ToLower() == excelcolhdr.ToLower());
                error = false;


                if (ignoreerror)
                {
                    if (srchcols.Count == 0 && (excelcolhdr != "Shade_Name"))
                    {
                        return false;
                    }
                }


                if (ignoreerror)
                {

                    if (excelcolhdr == "Shade_Name" )
                    {
                        if (Convert.ToString(excelsheet.Cells[r, c].Value) == "")
                        {
                            txterrorstatus.Text += "**********ERROR********** \r\n\r\n Line No:" + (r - 1).ToString() + " Required value of '" + srchcols[0].ColumnName.ToString() + "' is missing. \r\n\r\n ";
                            return true;
                        }
                    }
                   
                }

                if (srchcols.Count != 0 || excelcolhdr == "ItemGroup" || excelcolhdr == "ItemGroupCode" || excelcolhdr == "ItemSubGroupCode" || excelcolhdr == "DRS_SEQ")
                {
                    if (excelcolhdr == "ItemGroup")
                    {
                        dbcolname = "itemgroup";
                        datatype = "varchar";
                    }

                   else  if (excelcolhdr == "DRS_SEQ")
                    {
                        dbcolname = "DRSMST_ID";
                        datatype = "bigint";
                    }
                    else if (excelcolhdr == "ItemGroupCode")
                    {
                        dbcolname = "itemgroupcode";
                        datatype = "varchar";
                        ItemGroupCode = Convert.ToString(excelsheet.Cells[r, c].Value);
                    }
                    else if (excelcolhdr == "ItemSubGroupCode")
                    {
                        dbcolname = "itemsubgroupcode";
                        datatype = "varchar";
                        ItemSubGroupCode = Convert.ToString(excelsheet.Cells[r, c].Value);
                    }
                    else
                    {
                        dbcolname = srchcols[0].ColumnName.ToLower();
                        datatype = srchcols[0].DataType.ToLower();
                    }


                    if (dbcolname == "Shade_Id")
                    {
                        return false;
                    }

                    if (dbcolname == "item_name")
                    {
                        product = val;
                    }

                    if (datatype == "varchar" || datatype == "char")
                    {
                        if (dbcolname.ToLower() == "shade_name")
                        {
                            ShadeName = val;
                        }
                        if (dbcolname.ToLower() == "abbr")
                        {
                            Abbr = val;
                        }
                        if (dbcolname.ToLower() == "status")
                        {
                            Status = val.Trim();
                        }
                        if (dbcolname.ToLower() == "remark")
                        {
                            Remark = val.Trim();
                        }
                        val = GetKeyValue(dbcolname, val, trans, ref error, sheetname);

                        if (error)
                        {
                            return true;
                        }

                        if (dbcolname.Substring(0, 3) == "ud_")
                        {
                            udfvaluestring += dbcolname + " = '" + val.Replace("'", "''") + "',";
                        }
                        else
                        {
                            //valuestring += dbcolname + " = '" + val.Replace("'", "''") + "',";
                            if (dbcolname.ToLower() != "itemgroup" && dbcolname.ToLower() != "itemgroupcode" && dbcolname.ToLower() != "itemsubgroupcode")
                            {
                                valuestring += dbcolname + " = '" + val.Replace("'", "''") + "',";
                            }
                        }
                    }
                    else if (datatype == "bigint" || datatype == "int" || datatype == "decimal" || datatype == "numeric" || datatype == "float")
                    {

                        if (dbcolname == "purrate")
                        {
                            purrate = Math.Round(Convert.ToDecimal(val), 4);
                            PurRateyn = "1";
                        }
                        else if (dbcolname == "mrp")
                        {
                            mrp = Math.Round(Convert.ToDecimal(val), 2);
                            MRPyn = "1";
                        }
                        else if (dbcolname == "salerate")
                        {
                            salerate = Math.Round(Convert.ToDecimal(val), 2);
                            SaleRateyn = "1";
                        }
                        else if (dbcolname == "conv_qty")
                        {
                            ConvQty = Convert.ToDecimal(val);
                        }
                        else if (dbcolname.ToLower() == "saleratebeforetax")
                        {
                            SaleRateBeforeTaxyn = "1";
                            if (val == "0" || val == "")
                            {
                                if (TaxInclude == "1")
                                {
                                    Decimal TaxPerc = 0;
                                    if (TAXID ==0)
                                    {                                        
                                        sql = "select Tax_Id  From Item where Item_id = " + itemkey + "";
                                        DataTable dtTaxId = null;
                                        error = GetTable(sql, trans, ref dtTaxId);
                                        TAXID = Convert.ToInt32(dtTaxId.Rows[0][0]);
                                    }

                                   sql = "select Isnull(Tax_perc,0) Tax_perc From Ledger where Led_id = " + TAXID + "";
                                    DataTable dt4 = null;
                                    error = GetTable(sql, trans, ref dt4);
                                    TaxPerc = Convert.ToDecimal(dt4.Rows[0][0]);
                                    saleratebeforetax = Math.Round(((salerate / (100 + TaxPerc)) * 100), 2);
                                    val = Convert.ToString(saleratebeforetax);
                                }
                                else
                                {
                                    saleratebeforetax = Math.Round(salerate, 2);
                                    val = Convert.ToString(saleratebeforetax);
                                }
                            }
                            else
                            {
                                saleratebeforetax = Math.Round(Convert.ToDecimal(val), 2);
                                val = Convert.ToString(saleratebeforetax);
                            }

                        }
                        else if (dbcolname.ToLower() == "mkuprate")
                        {
                            MkUpRateyn = "1";

                            if (val == "0" || val == "")
                            {
                                //val = "0";
                                //MkUpRate = Convert.ToDecimal(val);
                                //MkUpRate = Math.Round((((SaleRateCheck - purrate) * 100) / purrate), 2);

                                if (purrate > 0)
                                {
                                    MkUpRate = Math.Round((((salerate - purrate) * 100) / purrate), 2);
                                }
                                else
                                {
                                    MkUpRate = 0;
                                }
                                val = Convert.ToString(MkUpRate);
                            }
                            else
                            {
                                MkUpRate = Math.Round(Convert.ToDecimal(val), 2);
                            }
                        }
                        else if (dbcolname.ToLower() == "margin")
                        {
                            Marginyn = "1";
                            if (val == "0" || val == "")
                            {
                                val = "0";
                                Margin = Convert.ToDecimal(val);
                            }
                            else
                            {
                                Margin = Convert.ToDecimal(val);
                            }
                        }
                        else if (dbcolname.ToLower() == "salerateafterconversion")
                        {
                            if (val == "0" || val == "")
                            {
                                salerateafterconversion = Math.Round((salerate), 2);
                                val = Convert.ToString(salerateafterconversion);
                            }
                            else
                            {
                                salerateafterconversion = Math.Round((Convert.ToDecimal(val)), 2);
                                val = Convert.ToString(salerateafterconversion);
                            }
                        }
                        else if (dbcolname.ToLower() == "dutyamt")
                        {
                            DutyAmtyn = "1";
                            DutyAmt = Convert.ToDecimal(val);
                        }
                        else if (dbcolname.ToLower() == "freightamt")
                        {
                            FreightAmtyn = "1";
                            FreightAmt  = Convert.ToDecimal(val);
                        }
                        else if (dbcolname.ToLower() == "landedcost")
                        {
                            LandedCostyn = "1";
                            if (val == "0" || val == "")
                            {
                                LandedCost = Math.Round((purrate + FreightAmt + DutyAmt), 4);
                                val = Convert.ToString(LandedCost);
                            }
                            else
                            {
                                LandedCost = Math.Round((Convert.ToDecimal(val)), 4);
                            }
                        }
                        else if (dbcolname.ToLower() == "landedcostincltax")
                        {
                            LandedCostInclTaxyn = "1";
                            if (val == "0" || val == "")
                            {
                                //val = "0";
                                //landedcostincltax = Convert.ToDecimal(val);
                                if (PURTAXID == 0)
                                {
                                    sql = "select PurTax_Id  From Item where Item_id = " + itemkey + "";
                                    DataTable dtTaxId = null;
                                    error = GetTable(sql, trans, ref dtTaxId);
                                    PURTAXID = Convert.ToInt32(dtTaxId.Rows[0][0]);
                                }

                                Decimal TaxPerc = 0;
                                sql = "select Isnull(Tax_perc,0) Tax_perc From Ledger where Led_id = " + PURTAXID + "";
                                DataTable dt4 = null;
                                error = GetTable(sql, trans, ref dt4);
                                TaxPerc = Convert.ToDecimal(dt4.Rows[0][0]);
                                landedcostincltax = Math.Round((LandedCost + ((LandedCost) * (TaxPerc) / 100)), 4);
                                val = Convert.ToString(landedcostincltax);

                            }
                            else
                            {
                                landedcostincltax = Math.Round((Convert.ToDecimal(val)), 4);
                            }
                        }
                        else if (dbcolname.ToLower() == "purrateaftertax")
                        {
                            // PurrateAfterTax = Convert.ToDecimal(val);
                            PurRateAfterTaxyn = "1";
                            if (val == "0" || val == "")
                            {
                                Decimal TaxPerc = 0;

                                if (PURTAXID == 0)
                                {
                                    sql = "select PurTax_Id  From Item where Item_id = " + itemkey + "";
                                    DataTable dtTaxId = null;
                                    error = GetTable(sql, trans, ref dtTaxId);
                                    PURTAXID = Convert.ToInt32(dtTaxId.Rows[0][0]);
                                }

                                sql = "select Isnull(Tax_perc,0) Tax_perc From Ledger where Led_id = " + PURTAXID + "";
                                DataTable dt4 = null;
                                error = GetTable(sql, trans, ref dt4);
                                TaxPerc = Convert.ToDecimal(dt4.Rows[0][0]);
                                PurrateAfterTax = Math.Round((purrate + Math.Round(((purrate * TaxPerc) / 100), 4)), 4);
                                val = Convert.ToString(PurrateAfterTax);
                            }
                            else
                            {
                                PurrateAfterTax = Math.Round(Convert.ToDecimal(val), 4);
                            }
                        }
                        val = GetKeyValue(dbcolname, val, trans, ref error, sheetname);

                        if (dbcolname.ToLower() == "purtax_id")
                        {
                            Purtax_idyn = "1";
                        }
                        else if (dbcolname.ToLower() == "tax_id")
                        {

                            tax_idyn = "1";
                        }

                        if (dbcolname.Substring(0, 3) == "ud_")
                        {
                            if (val == "NULL" || val == "")
                            {
                                udfvaluestring += dbcolname + " = 0,";
                            }
                            else
                            {
                                udfvaluestring += dbcolname + " = " + val + ",";
                            }
                        }
                        else
                        {
                            if (dbcolname.ToLower() == "itemgroup")
                            {
                                return false;
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
                        }
                    }
                    else if (datatype == "datetime")
                    {
                        val = GetKeyValue(dbcolname, val, trans, ref error, sheetname);
                        DateTime dttime = new DateTime(1900, 01, 01);

                        error = GetSQLDatetime(trans, ref dttime);

                        if (!error)
                        {
                            if (dbcolname.Substring(0, 3) == "ud_")
                            {
                                //udfvaluestring += dbcolname + " = '" + val + "',";
                                if (val == "NULL" || val == "")
                                {
                                    dttime = new DateTime(1900, 01, 01);
                                    udfvaluestring += dbcolname + "= cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                                }
                                else
                                {
                                    dttime = Convert.ToDateTime(val);
                                    udfvaluestring += dbcolname + "= cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                                }
                                //dttime = Convert.ToDateTime(val);
                                //udfvaluestring += dbcolname + "= cast('" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "' as datetime2),";
                            }
                            else if (dbcolname == "created_dt")
                            {
                                valuestring += "Created_Dt = '" + dttime.ToString("MM/dd/yyyy hh:mm tt") + "',";
                            }
                            else
                            {
                                valuestring += dbcolname + " = '" + val + "',";
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

        private List<ImportItemColumns> FillTableColumnsToList(DataTable dt)
        {
            List<ImportItemColumns> lst = (from DataRow row in dt.Rows
                                           select new ImportItemColumns()
                                           {
                                               ColumnName = row["Column_Name"].ToString(),
                                               DataType = row["Data_Type"].ToString(),
                                               ColumnIndex = Convert.ToInt16(row["Ordinal_Position"])
                                           }).ToList();

            return lst;
        }


        private string GetKeyValue(string fieldname, string mastervalue, SqlTransaction trans, ref Boolean error, string sheetname )
        {
            string keyfieldvalue = "";
            Int32 newid = 0;
            Int16 reccount = 0;

            try
            {
                mastervalue = mastervalue.Replace("'", "''");
                error = false;

                //ExcelPackage p = new ExcelPackage(new System.IO.FileInfo(excelfile));
                //int iSheetsCgount = p.Workbook.Worksheets.Count;
                //if (iSheetsCount > 0)
                //{
                //    ExcelWorksheet worksheet = p.Workbook.Worksheets[1];
                //    sheetname = worksheet.Name;
                //}
                //Int32 r = 1;

                if (sheetname == "Item")
                {
                    //p = new ExcelPackage(new System.IO.FileInfo(excelfile));

                    //ExcelWorksheet excelsht = p.Workbook.Worksheets[sheetname];

                    //ExcelCellAddress dimstart = excelsht.Dimension.Start;
                    //ExcelCellAddress dimend = excelsht.Dimension.End;

                    //string itemGrp = "";
                    //    Int16 itemGrpCol = 6;

                    //    if (isInsert)
                    //    {

                    //        for (r = 2; r <= dimend.Row; r++)
                    //        {
                    //itemGrp = Convert.ToString(excelsht.Cells[r, itemGrpCol].Value);
                    //        }
                    //    }
                    switch (fieldname.ToLower())
                    {
                        case "sect_id":
                            {
                                //sectkey = branchid + "1";
                                sectkey = 0;
                                keyfieldvalue = Convert.ToString(sectkey);

                                break;
                            }


                        case "itemgroup":
                            {
                                error = RecordExists("ItemGrp", "ItemGrp_Name", mastervalue, "ItemGrp_Id", trans, ref keyfieldvalue, ref reccount);

                                if (!error && reccount == 0)
                                {
                                    error = NewRecordId("itemgrp", "itemgrp_id", trans, ref newid);

                                    if (!error)
                                    {
                                        keyfieldvalue = Convert.ToString(newid);

                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Insert into ItemGrp (ItemGrp_Id, Sect_ID, ItemGrp_Name, Abbr, Alt_Code, Status, Created_By, Created_Dt,Machname,COBR_ID) ";
                                            sql += " values (" + newid + "," + sectkey + ",'" + mastervalue + "','" + mastervalue + "','" + ItemGroupCode + "','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + Environment.MachineName + "','" + branchid + "')";
                                            error = ExecuteQuery(sql, trans);
                                        }
                                    }
                                }
                                else
                                {
                                    if (mastervalue != "")
                                    {
                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Update ItemGrp set ItemGrp_Name = '" + mastervalue + "', Abbr = '" + mastervalue + "', Alt_Code= '" + ItemGroupCode + "', MachName = '" + Environment.MachineName + "' , Updated_By = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'";
                                            sql += " WHere ItemGrp_ID = " + keyfieldvalue + "";
                                            error = ExecuteQuery(sql, trans);
                                            //, UpdatedFrom = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'
                                        }
                                    }
                                }
                                if (keyfieldvalue != "")
                                {
                                    itemgrpkey = Convert.ToInt32(keyfieldvalue);
                                }
                                else
                                {
                                    itemgrpkey = 0;
                                }

                                break;
                            }

                        case "itemsubgrp_id":
                            {

                                if (!error)
                                {

                                    //error = RecordExists("ItemGrp", "ItemGrp_Name", itemGrp, "ItemGrp_Id", trans, ref keyfieldvalue, ref reccount);

                                    //if (!error && reccount == 0)
                                    //{
                                    //    error = NewRecordId("itemgrp", "itemgrp_id", trans, ref newid);

                                    //    if (!error)
                                    //    {
                                    //        keyfieldvalue = Convert.ToString(newid);

                                    //        error = GetSQLDatetime(trans, ref sqldt);

                                    //        if (!error)
                                    //        {
                                    //            //sql = "Exec Insert_ItemGrp '" + branchid + "'," + newid + ",'" + keyfieldvalue + "','" + sectkey + "','" + mastervalue + "','" + mastervalue + "','F','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + companyid + "'";
                                    //            sql = "Insert into ItemGrp (ItemGrp_Id, Sect_ID, ItemGrp_Name, Abbr, Alt_Code, Status, Created_By, Created_Dt,Machname,COBR_ID) ";
                                    //            sql += " values (" + newid + "," + sectkey + ",'" + itemGrp + "','" + itemGrp + "','" + ItemGroupCode + "','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + Environment.MachineName + "','" + branchid + "')";
                                    //            error = ExecuteQuery(sql, trans);
                                    //        }
                                    //    }
                                    //}
                                    //else
                                    //{
                                    //    if (mastervalue != "")
                                    //    {
                                    //        error = GetSQLDatetime(trans, ref sqldt);

                                    //        if (!error)
                                    //        {
                                    //            sql = "Update ItemGrp set ItemGrp_Name = '" + itemGrp  + "', Abbr = '" + itemGrp + "', MachName = '" + Environment.MachineName + "' , Updated_By = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'";
                                    //            sql += " WHere ItemGrp_ID = " + keyfieldvalue + "";
                                    //            error = ExecuteQuery(sql, trans);
                                    //        }
                                    //    }
                                    //}
                                    //itemgrpkey = Convert.ToInt32(keyfieldvalue);

                                    if (!error)
                                    {

                                        // error = RecordExists("ItemSubGrp", "ItemSubGrp_Name", mastervalue, "ItemSubGrp_Id", trans, ref keyfieldvalue, ref reccount);
                                        error = SubGroupRecordExists("ItemSubGrp", "ItemSubGrp_Name", mastervalue, "ItemSubGrp_Id", trans, ref keyfieldvalue, ref reccount, itemgrpkey);

                                        if (!error && reccount == 0)
                                        {
                                            error = NewRecordId("itemsubgrp", "itemsubgrp_id", trans, ref newid);

                                            if (!error)
                                            {
                                                keyfieldvalue = Convert.ToString(newid);
                                                error = GetSQLDatetime(trans, ref sqldt);
                                                if (!error)
                                                {
                                                    sql = "Insert into ItemSubGrp (ItemSubGrp_Id, ItemGrp_ID, ItemSubGrp_Name, Abbr, Alt_Code, Status, Created_By, Created_Dt,CoBr_Id,MachName) ";
                                                    sql += " Values (" + newid + "," + itemgrpkey + ",'" + mastervalue + "','" + mastervalue + "','" + ItemSubGroupCode + "','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + branchid + "','" + Environment.MachineName + "')";
                                                    error = ExecuteQuery(sql, trans);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (mastervalue != "")
                                            {
                                                error = GetSQLDatetime(trans, ref sqldt);

                                                if (!error)
                                                {
                                                    sql = "Update ItemSubGrp set ItemSubGrp_Name = '" + mastervalue + "', Abbr = '" + mastervalue + "', ItemGrp_Id= " + itemgrpkey + ",  Alt_Code= '" + ItemSubGroupCode + "' , MachName = '" + Environment.MachineName + "' , Updated_By = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'";
                                                    sql += " WHere ItemSubGrp_ID = " + keyfieldvalue + "";
                                                    error = ExecuteQuery(sql, trans);
                                                }
                                            }
                                        }
                                        itemsubgrpkey = Convert.ToInt32(keyfieldvalue);
                                    }
                                }
                                break;
                            }


                        case "brand_id":
                            {
                                error = RecordExists("Brand", "Brand_Name", mastervalue, "Brand_ID", trans, ref keyfieldvalue, ref reccount);

                                if (!error && reccount == 0)
                                {
                                    error = NewRecordId("Brand", "Brand_id", trans, ref newid);

                                    if (!error)
                                    {
                                        keyfieldvalue = Convert.ToString(newid);

                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Insert into Brand (Brand_Id, Brand_Name, Abbr, Alt_Code, Status, Created_By, Created_Dt,CoBr_Id,MachName) ";
                                            sql += " Values (" + newid + ",'" + mastervalue + "','" + mastervalue + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + branchid + "','" + Environment.MachineName + "')";
                                            error = ExecuteQuery(sql, trans);
                                        }
                                    }
                                }
                                else
                                {
                                    if (mastervalue != "")
                                    {
                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Update Brand set Brand_Name = '" + mastervalue + "', Abbr = '" + mastervalue + "', MachName = '" + Environment.MachineName + "' , Updated_By = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'";
                                            sql += " WHere Brand_ID = " + keyfieldvalue + "";
                                            error = ExecuteQuery(sql, trans);
                                            //, UpdatedFrom = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'
                                        }
                                    }
                                }
                                if (keyfieldvalue != "")
                                {
                                    brandkey = Convert.ToInt32(keyfieldvalue);
                                }
                                else
                                {
                                    brandkey = 0;
                                }

                                break;
                            }
                        case "supl_id":
                            {
                                error = RecordExists("Ledger", "Led_Name", mastervalue, "Led_ID", trans, ref keyfieldvalue, ref reccount);
                                SuplID = Convert.ToInt32(keyfieldvalue);
                                break;
                            }

                        case "drsmst_id":
                            {
                                error = RecordExists("DRSMASTER", "SEQ", mastervalue, "DRSMASTER_ID", trans, ref keyfieldvalue, ref reccount);
                                DRSSEQ_ID  = Convert.ToInt32(keyfieldvalue);
                                break;
                            }

                        case "purtax_id":
                            {
                                error = TaxRecordExist ("Ledger", "Led_Name", mastervalue, "Led_ID", trans, ref keyfieldvalue, ref reccount,"P");
                                PURTAXID = Convert.ToInt32(keyfieldvalue);
                                break;
                            }
                        case "tax_id":
                            {
                                error = TaxRecordExist ("Ledger", "Led_Name", mastervalue, "Led_ID", trans, ref keyfieldvalue, ref reccount,"S");
                                TAXID = Convert.ToInt32(keyfieldvalue);
                                break;
                            }

                        case "rack_id":
                            {
                                error = RecordExists("Rack", "Rack_Name", mastervalue, "Rack_ID", trans, ref keyfieldvalue, ref reccount);

                                if (!error && reccount == 0)
                                {
                                    error = NewRecordId("Rack", "Rack_id", trans, ref newid);

                                    if (!error)
                                    {
                                        keyfieldvalue = Convert.ToString(newid);

                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Insert into Rack (CoBr_Id, Rack_Id, Loc_ID, Rack_Name, Def_Rack, Abbr, Alt_Code, Status, Created_By, Created_Dt,Machname) ";
                                            sql += " Values ('" + branchid + "'," + newid + "," + sectkey + ",'" + mastervalue + "','1','" + mastervalue + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + Environment.MachineName + "')";
                                            error = ExecuteQuery(sql, trans);
                                        }
                                    }
                                }
                                else
                                {
                                    if (mastervalue != "")
                                    {
                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Update Rack set Rack_Name = '" + mastervalue + "', Abbr = '" + mastervalue + "', MachName = '" + Environment.MachineName + "' ,Updated_By = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'";
                                            sql += " Where Rack_ID = " + keyfieldvalue + "";
                                            error = ExecuteQuery(sql, trans);
                                        }
                                    }
                                }

                                rackkey = Convert.ToInt32(keyfieldvalue);
                                break;

                            }

                        case "producttype":
                            {
                                error = RecordExists("Misc", "Misc_Name", mastervalue, "Misc_ID", trans, ref keyfieldvalue, ref reccount);

                                if (!error && reccount == 0)
                                {
                                    error = NewRecordId("Misc", "Misc_ID", trans, ref newid);

                                    if (!error)
                                    {
                                        keyfieldvalue = Convert.ToString(newid);

                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Insert into Misc (Misc_ID, Misc_Name, Abbr, ItemFor,Alt_Code, Status, Created_By, Created_Dt ,Machname) ";
                                            sql += " Values (" + newid + ",'" + mastervalue + "','" + mastervalue + "','PT','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + Environment.MachineName + "')";
                                            error = ExecuteQuery(sql, trans);
                                        }
                                    }
                                }
                                else
                                {
                                    if (mastervalue != "")
                                    {
                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Update Misc set Misc_Name = '" + mastervalue + "', Abbr = '" + mastervalue + "', Updated_By = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'";
                                            sql += " Where Misc_ID = " + keyfieldvalue + "";
                                            error = ExecuteQuery(sql, trans);
                                        }
                                    }
                                }

                                ProducTypeID = Convert.ToInt32(keyfieldvalue);
                                break;
                            }


                        case "unit_id":
                        case "convunit_id":
                        case "purunit_id":
                        case "saleunit_id":
                        case "weight_id":
                        case "height_unit":
                        case "unit1_id":
                            {
                                error = RecordExists("Unit", "Unit_Name", mastervalue, "Unit_Id", trans, ref keyfieldvalue, ref reccount);

                                if (!error && reccount == 0)
                                {
                                    error = NewRecordId("Unit", "Unit_id", trans, ref newid);

                                    if (!error)
                                    {
                                        keyfieldvalue = Convert.ToString(newid);

                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Insert into Unit ( Unit_Id, Unit_Name, Abbr, UnitFor, Alt_Code, Status, Created_By, Created_Dt,synchcloud,MachName) ";
                                            sql += " Values (" + newid + ",'" + mastervalue + "','" + mastervalue + "','N','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','0','" + Environment.MachineName + "')";
                                            error = ExecuteQuery(sql, trans);
                                        }
                                    }
                                }
                                else
                                {
                                    if (mastervalue != "")
                                    {
                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Update Unit set Unit_Name = '" + mastervalue + "', Abbr = '" + mastervalue + "', MachName = '" + Environment.MachineName + "', Updated_By = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'";
                                            sql += " Where Unit_ID = " + keyfieldvalue + "";
                                            error = ExecuteQuery(sql, trans);
                                        }

                                        if (fieldname.ToLower() == "unit_id")
                                        {
                                            unitkey = Convert.ToInt32(keyfieldvalue);
                                        }
                                        else if (fieldname.ToLower() == "convunit_id")
                                        {
                                            convunitkey = Convert.ToInt32(keyfieldvalue);
                                        }
                                    }
                                }

                                unitkey = Convert.ToInt32(keyfieldvalue);
                                break;
                            }

                        case "itemmisc_id":
                            {
                                error = RecordExists("Misc", "Misc_Name", mastervalue, "Misc_Key", trans, ref keyfieldvalue, ref reccount);

                                if (!error && reccount == 0)
                                {
                                    error = NewRecordId("Misc", "Misc_id", trans, ref newid);

                                    if (!error)
                                    {
                                        keyfieldvalue = Convert.ToString(newid);

                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Insert into Misc (CoBr_Id, Misc_Id, Misc_Key, Misc_Name, Abbr, ItemFor, Alt_Code, Status, Created_By, Created_Dt) ";
                                            sql += " Values ('" + branchid + "'," + newid + ",'" + keyfieldvalue + "','" + mastervalue + "','" + mastervalue + "','MT','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "')";
                                            error = ExecuteQuery(sql, trans);
                                        }
                                    }
                                }
                                else
                                {
                                    if (mastervalue != "")
                                    {
                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Update Misc set Misc_Name = '" + mastervalue + "', Abbr = '" + mastervalue + "', Updated_By = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'";
                                            sql += " Where Misc_Key = '" + keyfieldvalue + "'";
                                            error = ExecuteQuery(sql, trans);
                                        }
                                    }
                                }

                                itemmisckey = Convert.ToInt32(keyfieldvalue);
                                break;
                            }




                        case "qlty_id":
                            {
                                error = RecordExists("Quality", "Qlty_Name", mastervalue, "Qlty_ID", trans, ref keyfieldvalue, ref reccount);

                                if (!error && reccount == 0)
                                {
                                    error = NewRecordId("Quality", "Qlty_id", trans, ref newid);

                                    if (!error)
                                    {
                                        keyfieldvalue = Convert.ToString(newid);

                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Insert into Quality (Qlty_Id, Qlty_Name, Abbr, Alt_Code, Status, Created_By, Created_Dt,CoBr_Id) ";
                                            sql += " Values (" + newid + ",'" + mastervalue + "','" + mastervalue + "','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + branchid + "')";
                                            error = ExecuteQuery(sql, trans);
                                        }
                                    }
                                }
                                else
                                {
                                    if (mastervalue != "")
                                    {
                                        error = GetSQLDatetime(trans, ref sqldt);

                                        if (!error)
                                        {
                                            sql = "Update Quality set Qlty_Name = '" + mastervalue + "', Abbr = '" + mastervalue + "', Updated_By = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'";
                                            sql += " WHere Qlty_ID  =" + keyfieldvalue + "";
                                            error = ExecuteQuery(sql, trans);
                                        }
                                    }
                                }

                                qltykey = Convert.ToInt32(keyfieldvalue);
                                break;
                            }

                        case "feature_id":
                            {
                                keyfieldvalue = mastervalue;

                                break;
                            }

                        case "itemref_id":
                            {
                                keyfieldvalue = mastervalue;

                                break;
                            }

                        case "itemcust_id":
                            {
                                keyfieldvalue = mastervalue;

                                break;
                            }

                        case "itemshade_id":
                            {
                                keyfieldvalue = mastervalue;

                                break;
                            }

                        case "cobr_id":
                            {
                                keyfieldvalue = branchid;

                                break;
                            }

                        default:
                            {

                                keyfieldvalue = mastervalue;

                                break;
                            }
                    }
                    //
                }
                else
                {
                    switch (fieldname.ToLower())
                    {
                        case "altbarcode_no":
                            {
                                keyfieldvalue = mastervalue;
                                break;
                            }

                        default:
                            {
                                keyfieldvalue = mastervalue;
                                break;
                            }
                    }
                }
                //
            }

            catch (Exception ex)
            {
                errortext = ex.Message + "\r\n\r\n";
                AppendErrorText();
                error = true;
            }

            return Convert.ToString(keyfieldvalue);
        }

        private Boolean CreateItemSize(SqlTransaction trans)
        {
            Boolean error = false;

            try
            {
                Int32 newid = 0;
                Int32 keyfieldvalue = 0;

                sql = "Select ItemSize_ID From ItemSize with (nolock) Where Item_ID = " + itemid + "";
                //sql += " And CoBr_Id = '" + branchid + "'";
                DataTable dt = null;
                error = GetTable(sql, trans, ref dt);

                if (!error && dt.Rows.Count == 0)
                {
                    error = NewRecordId("itemsize", "itemsize_id", trans, ref newid);

                    if (!error)
                    {
                        error = GetSQLDatetime(trans, ref sqldt);

                        if (!error)
                        {
                            keyfieldvalue = newid;
                            itemsizekey = keyfieldvalue;

                            sql = "Insert into ItemSize (ItemSize_Id, Item_ID, Size_Name, Abbr, SeqNo, Status, Created_By, Created_Dt, AltSize, PurRD, MrpRD, WspRD,MachName) ";
                            sql += " Values (" + newid + "," + itemid + ",'.','.','A','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','',0,0,0,'" + Environment.MachineName + "')";
                            error = ExecuteQuery(sql, trans);
                        }
                    }
                }
                else
                {
                    itemsizekey = Convert.ToInt32(dt.Rows[0][0]);
                }
            }

            catch (Exception ex)
            {
                errortext = ex.Message + "\r\n\r\n";
                AppendErrorText();
                return true;
            }

            return error;
        }

        private Boolean ImportItemWiseBarcode(SqlTransaction trans)
        {
            Boolean error = false;

            try
            {
                Int32 newid = 0;
                Int32 keyfieldvalue = 0;

                sql = "Select Barcode_Id From ItemWiseBarcode with (nolock) Where Item_ID = " + itemid + "";
                DataTable dt = null;
                error = GetTable(sql, trans, ref dt);

                if (!error && dt.Rows.Count == 0)
                {
                    error = NewRecordId("ItemWiseBarcode", "barcode_id", trans, ref newid);

                    if (!error)
                    {
                        error = GetSQLDatetime(trans, ref sqldt);

                        if (!error)
                        {
                            keyfieldvalue = newid;
                            itemsizekey = keyfieldvalue;


                            if (eanbarcode != "")
                            {
                                //error = NewRecordId("ItemWiseBarcode", "barcode_id", trans, ref newid);
                                sql = "Insert into ItemWiseBarcode (Barcode_ID, Item_ID, AltBarcode_No, Status, Created_By, Created_Dt,MachName,MainBarcode,Barcode_Key) ";
                                sql += " Values (" + newid + "," + itemid + ",'" + eanbarcode + "','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + Environment.MachineName + "','1','" + branchid + newid + "')";
                                error = ExecuteQuery(sql, trans);
                            }
                            if (alternatebarcode != "")
                            {
                                error = NewRecordId("ItemWiseBarcode", "barcode_id", trans, ref newid);
                                sql = "Insert into ItemWiseBarcode (Barcode_ID, Item_ID, AltBarcode_No, Status, Created_By, Created_Dt,MachName,Barcode_Key) ";
                                sql += " Values (" + newid + "," + itemid + ",'" + alternatebarcode.Trim () + "','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','" + Environment.MachineName + "','" + branchid + newid + "')";
                                error = ExecuteQuery(sql, trans);
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

            return error;
        }

        private Boolean CreateStyle(SqlTransaction trans)
        {
            Boolean error = false;

            try
            {
                Int32 newid = 0;
                Int32 keyfieldvalue = 0;

                sql = "Select Style_ID From Style with (nolock) Where Item_ID = " + itemkey + "";
                sql += " And CoBr_Id = '" + branchid + "'";
                DataTable dt = null;
                error = GetTable(sql, trans, ref dt);
                // Int32 StyleID = 0;

                if (!error && dt.Rows.Count == 0)
                {
                    error = NewRecordId("style", "style_id", trans, ref newid);

                    if (!error)
                    {
                        error = GetSQLDatetime(trans, ref sqldt);

                        if (!error)
                        {
                            keyfieldvalue = newid;
                            stylekey = keyfieldvalue;

                            sql = "Insert into Style (Style_Id,  Style_Code, Item_ID, Type_ID, Abbr, Brand_ID, Qlty_ID, Season_ID, Occn_ID, Supl_Style, Style_Flag, Style_Image, PurRate, MkUpPerc, MRP, MkDownPerc, SPrice, Margin, Disc_Perc, Disc_Amt, Min_Level, Max_Level, ReOrder_Level, Alt_Code, Remark, Status, Created_By, Created_Dt, Party_ID,Supl_ID,MachName,HSNCODE,CoBr_Id) ";
                            sql += " Values (" + newid + ",'.'," + itemkey + ",0,'.'," + brandkey + ",0,0,0,'','A',''," + purrate + ",0," + mrp + ",0," + salerate + "," + Margin + ",0,0,0,0,0,'','','1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "',0," + SuplID + ",'" + Environment.MachineName + "','','" + branchid + "') ";
                            error = ExecuteQuery(sql, trans);
                        }
                    }
                }
                else
                {
                    stylekey = Convert.ToInt32(dt.Rows[0][0]);

                    error = GetSQLDatetime(trans, ref sqldt);

                    if (!error)
                    {
                        sql = "Update Style Set PurRate = " + purrate + ", MRP = " + mrp + ", SPrice = " + salerate + ", HSNCode = '" + hsncode + "', updated_by = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "'";
                        sql += " Where Item_ID = " + itemkey + "";
                        error = ExecuteQuery(sql, trans);
                    }
                }
            }

            catch (Exception ex)
            {
                errortext = ex.Message + "\r\n\r\n";
                AppendErrorText();
                return true;
            }

            return error;
        }

        private Boolean CreateStyleSize(SqlTransaction trans)
        {
            Boolean error = false;

            try
            {
                Int32 newid = 0;

                sql = "Select Style_ID From StyleSize with (nolock) Where Item_ID = " + itemkey + "";
                //sql += " And CoBr_Id = '" + branchid + "'";
                DataTable dt = null;
                error = GetTable(sql, trans, ref dt);

                if (!error && dt.Rows.Count == 0)
                {
                    error = NewRecordId("stylesize", "stylesize_id", trans, ref newid);

                    if (!error)
                    {
                        error = GetSQLDatetime(trans, ref sqldt);

                        if (!error)
                        {
                            //keyfieldvalue = branchid + newid.ToString();

                            //sql = "Exec Insert_StyleSize " + newid + ",'" + stylekey + "','" + itemsizekey + "','" + itemkey + "','.','.',0,0,0,'1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "',0,0,0";
                            sql = "Insert into StyleSize (StyleSize_Id, Style_ID, ItemSize_ID, Item_ID, Size_Name, Print_Name, PurRD, MrpRD, WspRD, Status, Created_By, Created_Dt, SMrp, SWsp, SPurRt,MachName) ";
                            sql += " Values (" + newid + "," + stylekey + "," + itemsizekey + "," + itemid + ",'.','.',0,0,0,'1'," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "',0,0,0,'" + Environment.MachineName + "')";
                            error = ExecuteQuery(sql, trans);
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

            return error;
        }

        private Boolean CreateStkCatRt(SqlTransaction trans)
        {
            Boolean error = false;

            try
            {
                Int32 newid = 0;
                string keyfieldvalue = "";


                sql = "Select stkcatrt_id From StkCatRt with (nolock) Where Item_ID = " + itemkey + " And Ratecat_Id =1 ";
                DataTable dt = null;
                error = GetTable(sql, trans, ref dt);

                if (!error && dt.Rows.Count == 0)
                {
                    error = NewRecordId("StkCatRt", "stkcatrt_id", trans, ref newid);

                    if (!error)
                    {
                        error = GetSQLDatetime(trans, ref sqldt);

                        if (!error)
                        {
                            // keyfieldvalue = newid.ToString();

                            sql = "Insert into StkCatrt (StkCatRt_Id, Stk_Key, Ratecat_Id, Style_Id, PurDtl_Id, MRP, SP, PurRt, MachName,Item_ID,SaleRateBeforeTax,created_by,created_Dt) ";
                            sql += " Values (" + newid + ",'',1," + stylekey + ",0," + mrp + "," + salerate + "," + purrate + ",'" + Environment.MachineName + "'," + itemkey + "," + saleratebeforetax + "," + importuser + ",'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "') ";
                            error = ExecuteQuery(sql, trans);
                        }
                    }
                }
                else
                {
                    Int64 stkcatrtid = Convert.ToInt64(dt.Rows[0][0]);
                    decimal purrateCat = 0;
                    decimal mrpCat = 0;
                    decimal salerateCat = 0;
                    Decimal saleratebeforetaxCat = 0;

                    error = GetSQLDatetime(trans, ref sqldt);

                    if (!error)
                    {

                        sql = "Select PurRate, MRP, SaleRate, SaleRateBeforeTax From Item with (nolock) Where Item_ID = " + itemkey + " ";
                        DataTable dtStkCatrt = null;
                        error = GetTable(sql, trans, ref dtStkCatrt);
                        purrateCat = Convert.ToDecimal(dtStkCatrt.Rows[0][0]);
                        mrpCat = Convert.ToDecimal(dtStkCatrt.Rows[0][1]);
                        salerateCat = Convert.ToDecimal(dtStkCatrt.Rows[0][2]);
                        saleratebeforetaxCat = Convert.ToDecimal(dtStkCatrt.Rows[0][3]);

                        sql = "Update StkCatrt set MRP = " + mrpCat + ", SP = " + salerateCat + ", PurRt = " + purrateCat + ", SaleRateBeforeTax = " + saleratebeforetaxCat + ", MachName = '" + Environment.MachineName + "', Updated_by = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "' ";
                        sql += " Where stkcatrt_id = " + stkcatrtid + "";
                        error = ExecuteQuery(sql, trans);
                    }
                }
            }

            catch (Exception ex)
            {
                errortext = ex.Message + "\r\n\r\n";
                AppendErrorText();
                return true;
            }

            return error;
        }

        private Boolean CreateItemStock(SqlTransaction trans)
        {
            Boolean error = false;

            try
            {
                Int32 newid = 0;

                sql = "Select Style_ID From StyleSize with (nolock) Where Item_ID = " + itemid + "";
                DataTable dt1 = null;
                error = GetTable(sql, trans, ref dt1);
                Int32 stylesizeId = Convert.ToInt32(dt1.Rows[0][0]);

                sql = "Select Stk_Id From ItemStock with (nolock) Where Item_ID = " + itemid + " And Stk_From='F' ";
                sql += " And CoBr_Id = '" + branchid + "'";
                DataTable dt = null;
                error = GetTable(sql, trans, ref dt);

                sql = "Select Sr_Code From Series with (nolock) Where Rec_ID = 1 ";
                DataTable Sr = null;
                error = GetTable(sql, trans, ref Sr);
                string Series = "";
                Series = Convert.ToString(Sr.Rows[0][0]);

                if (!error && dt.Rows.Count == 0)
                {
                    error = NewRecordId("itemstock", "stk_id", trans, ref newid);

                    if (!error)
                    {
                        error = GenerateBarcode(trans);

                        if (!error)
                        {
                            error = GetSQLDatetime(trans, ref sqldt);

                            if (!error)
                            {
                                sql = "Insert Into ItemStock (CoBr_Id, FcYr_Id, Stk_Id, Loc_ID, Item_ID, Style_id, Type_id, Shade_ID, ItemSize_Id, Unit_ID, ConvUnit_ID, ConvQty, PurRate, MRP, SRate, BillPurRate, BillSaleRate, Barcode, AltBarcode1, AltBarcode2, Brand_ID, Qlty_ID, Season_ID, Occn_ID, Supl_ID, Mfr_Id, Mktd_id, Rack_Id, PurDoc_ID, PurDocDtl_Id, PurDoc_No, PurDoc_Dt, StockRefId, LotNo, ChlnNo, ChlnDt, StkSr, StkType, Min_Level, Max_Level, ReOrder_Level, OpDate, OpQty, OpAmt, InStock, OutStock, ClQty, DiscPerc, MaxDiscPerc, MfgDt, ExpiryMth, ExpiryDate, Code, BarcodePrn, BarcodePrnDt, Created_By, Created_Dt, LastPurNo, LastPurDt, Cut_Len, OpPcs, InPcs, OutPcs, ClPcs, StyleSize_Id, cut_type, SoDtl_Id,MachName,Stk_Key,LandedCost) ";
                                sql += " Values ('" + branchid + "','" + fcyrid + "'," + newid + "," + locID + "," + itemid + "," + stylekey + ",0,0," + itemsizekey + "," + unitkey + "," + unitkey + ",1," + purrate + "," + mrp + "," + salerate + ",0,0,'" + eanbarcode + "','',''," + brandkey + "," + qltykey + ",0,0,0,0,0,1,0,0,'',Null,0,'','',Null,'A','F',0,0,0,'" + sqldt.ToString("MM/dd/yyyy") + "',0,0,0,0,0,0,0,Null,0,Null,'',0,Null,1,'" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "','',Null,0,0,0,0,0," + stylesizeId + ",'',0,'" + Environment.MachineName + "','" + branchid + Series + newid + "'," + landedcostincltax + ")";
                                error = ExecuteQuery(sql, trans);
                            }
                        }
                    }
                }
                else
                {
                    decimal purrateStk = 0;
                    decimal mrpStk = 0;
                    decimal salerateStk = 0;
                    Decimal saleratebeforetaxStk = 0;
                    Int32 UnitKeyStk = 0;
                    Int32 convunitkeyStk = 0;
                    decimal convqtyStk = 0;
                    decimal landedcostincltaxStk = 0;


                    error = GetSQLDatetime(trans, ref sqldt);

                    if (!error)
                    {
                        sql = "Select PurRate, MRP, SaleRate, SaleRateBeforeTax, Unit_Id, ConvUnit_Id, Conv_Qty, LandedCostInclTax From Item with (nolock) Where Item_ID = " + itemkey + " ";
                        DataTable dtStkCatrt = null;
                        error = GetTable(sql, trans, ref dtStkCatrt);
                        purrateStk = Convert.ToDecimal(dtStkCatrt.Rows[0][0]);
                        mrpStk = Convert.ToDecimal(dtStkCatrt.Rows[0][1]);
                        salerateStk = Convert.ToDecimal(dtStkCatrt.Rows[0][2]);
                        saleratebeforetaxStk = Convert.ToDecimal(dtStkCatrt.Rows[0][3]);
                        UnitKeyStk = Convert.ToInt32(dtStkCatrt.Rows[0][4]);
                        convunitkeyStk = Convert.ToInt32(dtStkCatrt.Rows[0][5]);
                        convqtyStk = Convert.ToInt32(dtStkCatrt.Rows[0][6]);
                        landedcostincltaxStk = Convert.ToDecimal(dtStkCatrt.Rows[0][7]);

                        sql = "Update ItemStock Set Unit_id = " + UnitKeyStk + ", ConvUnit_ID = " + convunitkeyStk + ", ConvQty = " + convqtyStk + ", PurRate = " + purrateStk + ", MRP = " + mrpStk + ",SRATE = " + salerateStk + ", AltBarcode1 = '" + eanbarcode + "',LandedCost = " + landedcostincltaxStk + ", Updated_By = " + importuser + ", Updated_Dt = '" + sqldt.ToString("MM/dd/yyyy hh:mm tt") + "', MachName = '" + Environment.MachineName + "' ";
                        sql += " Where Item_ID = " + itemkey + " And Stk_From='F' ";
                        error = ExecuteQuery(sql, trans);
                    }
                }
            }

            catch (Exception ex)
            {
                errortext = ex.Message + "\r\n\r\n";
                AppendErrorText();
                return true;
            }

            return error;
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
                    maxid = Convert.ToInt32(dt.Rows[0][0]) + 3;
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
                //trans.Connection.Open(); 
                SqlDataAdapter db = new SqlDataAdapter(sql, trans.Connection);
                db.SelectCommand.CommandTimeout = 50000;
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


        private Boolean SubGroupRecordExists(string tablename, string namefield, string namefieldvalue, string keyfield, SqlTransaction trans, ref string keyfieldvalue, ref Int16 reccount, Int32 ItemGrpId)
        {
            try
            {
                sql = "Select " + keyfield + " from " + tablename + "  with (nolock) Where " + namefield + " = '" + namefieldvalue + "' And ItemGrp_Id = " + ItemGrpId + " ";
                if (namefieldvalue.Trim().Length != 0)
                {
                    //sql += " And CoBr_Id = '" + branchid + "'";
                }
                //trans.Connection.Open(); 
                SqlDataAdapter db = new SqlDataAdapter(sql, trans.Connection);
                db.SelectCommand.CommandTimeout = 50000;
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



        private Boolean TaxRecordExist(string tablename, string namefield, string namefieldvalue, string keyfield, SqlTransaction trans, ref string keyfieldvalue, ref Int16 reccount, string TaxType)
        {
            try
            {
                sql = "Select " + keyfield + " from " + tablename + "  with (nolock) Where " + namefield + " = '" + namefieldvalue + "' And ApplySalePur = '" + TaxType  + "' ";
                if (namefieldvalue.Trim().Length != 0)
                {
                    //sql += " And CoBr_Id = '" + branchid + "'";
                }
                //trans.Connection.Open(); 
                SqlDataAdapter db = new SqlDataAdapter(sql, trans.Connection);
                db.SelectCommand.CommandTimeout = 50000;
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
                db.SelectCommand.CommandTimeout = 50000;
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
                cmd.CommandTimeout = 50000;
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
                cmd.CommandTimeout = 50000;
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
            if (!error)
            {
                if (!txterrorstatus.Text.Contains("Error importing line: " + excelrowline + " (Row not imported)\r\n\r\n"))
                {
                    txterrorstatus.AppendText("Error importing line: " + excelrowline + " (Row not imported)\r\n\r\n");
                }
            }
        }
    }
}


public class ImportItemColumns
{
    private string columnname;
    private string datatype;
    private Int16 colindex;

    public string ColumnName
    {
        get
        {
            return columnname;
        }
        set
        {
            columnname = value;
        }
    }

    public string DataType
    {
        get
        {
            return datatype;
        }
        set
        {
            datatype = value;
        }
    }

    public Int16 ColumnIndex
    {
        get
        {
            return colindex;
        }
        set
        {
            colindex = value;
        }
    }
}