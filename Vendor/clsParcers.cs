using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Vendor
{
    public class clsParcers
    {
        #region "Erie Printer File"
        public TTModels.clsOriginal.eriePrinterRecord eriePrinterFile(DataRow oRow)
        {
            TTModels.clsOriginal.eriePrinterRecord oRec = new TTModels.clsOriginal.eriePrinterRecord()
            {
                parcelNumber = oRow[1].ToString().Trim(),
                discountAmount = Convert.ToDecimal(oRow[26].ToString().Trim()),
                penaltyAmount = Convert.ToDecimal(oRow[27].ToString().Trim())
            };
            return oRec;
        }
        #endregion


        #region "Shippensburg Parcers Per Capita"
        public TTModels.clsOriginal.tblParcelInformation shippensburgPerCapita_ParcelInformation(DataRow oRow, string schoolDistrict)
        {
            string locationString = "";
            string legalString = "";
            string parcelNumber = oRow[0].ToString() + "-" + oRow[3].ToString();

            TTModels.clsOriginal.tblParcelInformation oRec = new TTModels.clsOriginal.tblParcelInformation()
            {
                keyParcelID             = 0,
                parcelMemoLegal         = legalString,
                parcelMemoLocation      = locationString,
                parcelMemoNotes         = "",
                parcelStrAcres          = "",
                parcelStrBook           = "",
                parcelStrCleanAndGreen  = "",
                parcelStrCode           = "PC",
                parcelStrControlNumber  = oRow[0].ToString(),
                parcelStrDistrict       = oRow[0].ToString(),
                parcelStrFarmsteadValue = "None",
                parcelStrHomesteadValue = "None",
                parcelStrNumber         = parcelNumber,
                parcelStrPage           = "",
                parcelStrSchoolDistrict = schoolDistrict,
                parcelStrTaxCode        = "PC"
            };
            return oRec;
        }
        public TTModels.clsOriginal.tblOwnerInformation shippensburgPerCapita_OwnerInformation(DataRow oRow, DateTime discountStart)
        {
            string parcelNumber = oRow[0].ToString() + "-" + oRow[3].ToString();
            string addressZip = oRow[21].ToString().Trim();
            if (oRow[22].ToString().Trim() != "") { addressZip += "-" + oRow[22].ToString().Trim(); }

            string addressInfo = oRow[12].ToString().Trim();
            if (oRow[13].ToString().Trim() != "") { addressInfo += "\n" + oRow[13].ToString().Trim(); }
            if (oRow[14].ToString().Trim() != "") { addressInfo += "\n" + oRow[14].ToString().Trim(); }
            addressInfo += "\n" + oRow[19].ToString().Trim() + ", " + oRow[20].ToString().Trim() + " " + addressZip;


            TTModels.clsOriginal.tblOwnerInformation oRec = new TTModels.clsOriginal.tblOwnerInformation()
            {
                //keyOwnerId = 0,
                ownerBolCurrent = true,
                ownerDateEffectiveDate = discountStart,
                ownerDateLastUpdated = DateTime.Now,
                ownerMemoBillingAddress = addressInfo,
                ownerStrBillingZipCode = addressZip,
                ownerStrOwnerName1 = oRow[5].ToString().Trim(),
                ownerStrOwnerName2 = "",
                ownerStrParcelNumber = parcelNumber
            };
            return oRec;
        }
        public TTModels.clsOriginal.tblLineItemTax shippensburgPerCapita_LineItemTaxes(DataRow oRow, Int32 taxTypeId, decimal taxTypeMillage, string fiscalYear, string fiscalSubYear, DateTime dateDiscountStart, decimal discountTax, decimal faceTax, decimal penaltyTax)
        {
            string billNumber = ""; try { billNumber = Convert.ToInt16(oRow[4].ToString()).ToString("00000"); }
            catch { billNumber = oRow[4].ToString(); }
            string parcelNumber = oRow[0].ToString() + "-" + oRow[3].ToString();

            TTModels.clsOriginal.tblLineItemTax oRec = new TTModels.clsOriginal.tblLineItemTax()
            {
                keyLineItemID = 0,
                litemStrParcelNumber = parcelNumber,
                litemStrBarCodeValue = parcelNumber,
                litemCurrAssessedBuilding = 0,
                litemCurrAssessedLand = 0,
                litemCurrAssessedMineral = 0,
                litemCurrAssessedTotal = 0,
                litemCurrBuilding = 0,
                litemCurrLand = 0,
                litemCurrMineral = 0,
                litemCurrTotal = 0,
                litemCurrTaxAmountDiscount = discountTax,
                litemCurrTaxAmountFace = faceTax,
                litemCurrTaxAmountPenalty = penaltyTax,
                litemDateInterimDate = DateTime.MaxValue,
                litemDateLastUpdatedDate = DateTime.Now,
                litemStrBillNumber = billNumber,

                litemCurrPrevBuilding = 0,
                litemCurrPrevLand = 0,
                litemCurrPrevMineral = 0,
                litemCurrPrevTotal = 0,
                litemIntInstallmentNumber = 0,
                litemIntInterimMonths = 12,
                litemIntPaymentPeriodID = 0,
                litemIntPaymentStatusID = 0,
                litemIntPaymentTypeID = 0,
                litemIntReceiptNumber = 0,
                litemIntRemittalID = 0,
                litemMemoNotes = "",
                litemPaymentID = 0,
                litemAmountPaid = 0,

                litemBolCloseOut = false,
                litemBolInterim = false,
                litemBolSelectedRow = false,

                litemDateEffectiveDate = dateDiscountStart,
                litemIntTaxTypeID = taxTypeId,
                litemStrFiscalSubYear = fiscalSubYear,
                litemStrFiscalYear = fiscalYear,
                litemDblRate = taxTypeMillage,


            };

            return oRec;
        }
        
        #endregion

        #region "Shippensburg Parcers Real Estate"
        public TTModels.clsOriginal.tblParcelInformation shippensburgRealEstate_ParcelInformation(DataRow oRow, string schoolDistrict)
        {
            string locationString = oRow[15].ToString().Trim();
            if (oRow[16].ToString().Trim() != "") { locationString += " " + oRow[16].ToString().Trim(); }
            if (oRow[17].ToString().Trim() != "") { locationString += " " + oRow[17].ToString().Trim(); }

            string legalString = "";

            TTModels.clsOriginal.tblParcelInformation oRec = new TTModels.clsOriginal.tblParcelInformation()
            {
                keyParcelID             = 0,
                parcelMemoLegal         = legalString,
                parcelMemoLocation      = locationString,
                parcelMemoNotes         = "",
                parcelStrAcres          = oRow[18].ToString(),
                parcelStrBook           = oRow[21].ToString(),
                parcelStrCleanAndGreen  = oRow[51].ToString(),
                parcelStrCode           = oRow[19].ToString(),
                parcelStrControlNumber  = oRow[3].ToString(),
                parcelStrDistrict       = oRow[0].ToString(),
                parcelStrFarmsteadValue = "",
                parcelStrHomesteadValue = oRow[74].ToString(),
                parcelStrNumber         = oRow[4].ToString().Trim(),
                parcelStrPage           = oRow[22].ToString(),
                parcelStrSchoolDistrict = schoolDistrict,
                parcelStrTaxCode = oRow[19].ToString()
            };
            return oRec;
        }

        public TTModels.clsOriginal.tblOwnerInformation shippensburgRealEstate_OwnerInformation(DataRow oRow, DateTime discountStart)
        {
            string addressZip = oRow[13].ToString().Trim();
            if (oRow[14].ToString().Trim() != "") { addressZip += "-" + oRow[14].ToString().Trim(); }
            string addressInfo = oRow[8].ToString().Trim();
            if (oRow[9].ToString().Trim()  != "") { addressInfo += "\n" + oRow[9].ToString().Trim();  }
            if (oRow[10].ToString().Trim() != "") { addressInfo += "\n" + oRow[10].ToString().Trim(); }
            addressInfo += "\n" + oRow[11].ToString().Trim() + ", " + oRow[12].ToString().Trim() + " " + addressZip;


            TTModels.clsOriginal.tblOwnerInformation oRec = new TTModels.clsOriginal.tblOwnerInformation()
            {
                //keyOwnerId              = 0,
                ownerBolCurrent         = true,
                ownerDateEffectiveDate  = discountStart,
                ownerDateLastUpdated    = DateTime.Now,
                ownerMemoBillingAddress = addressInfo,
                ownerStrBillingZipCode  = addressZip,
                ownerStrOwnerName1      = oRow[6].ToString().Trim(),
                ownerStrOwnerName2      = oRow[7].ToString().Trim(),
                ownerStrParcelNumber    = oRow[4].ToString().Trim()
            };
            return oRec;
        }

        public TTModels.clsOriginal.tblLineItemTax shippensburgRealEstate_LineItemTaxes(DataRow oRow, Int32 taxTypeId, decimal taxTypeMillage, string fiscalYear, string fiscalSubYear, DateTime dateDiscountStart, decimal discountTax, decimal faceTax, decimal penaltyTax)
        {
            decimal assessmentTotal = Convert.ToDecimal(oRow[24].ToString()) + Convert.ToDecimal(oRow[25].ToString()) + Convert.ToDecimal(oRow[26].ToString());
            decimal mvTotal         = Convert.ToDecimal(oRow[27].ToString()) + Convert.ToDecimal(oRow[28].ToString()) + Convert.ToDecimal(oRow[26].ToString());

            string billNumber = ""; try { billNumber = Convert.ToInt16(oRow[5].ToString()).ToString("00000"); } catch { billNumber = oRow[5].ToString(); }

            TTModels.clsOriginal.tblLineItemTax oRec = new TTModels.clsOriginal.tblLineItemTax()
            {
                keyLineItemID = 0,
                litemStrParcelNumber       = oRow[4].ToString().Trim(),
                litemStrBarCodeValue       = oRow[4].ToString().Trim(),
                litemCurrAssessedBuilding  = Convert.ToDecimal(oRow[25].ToString()),
                litemCurrAssessedLand      = Convert.ToDecimal(oRow[24].ToString()),
                litemCurrAssessedMineral   = Convert.ToDecimal(oRow[26].ToString()),
                litemCurrAssessedTotal     = assessmentTotal,
                litemCurrBuilding          = Convert.ToDecimal(oRow[28].ToString()),
                litemCurrLand              = Convert.ToDecimal(oRow[27].ToString()),
                litemCurrMineral           = Convert.ToDecimal(oRow[26].ToString()),
                litemCurrTotal             = mvTotal,
                litemCurrTaxAmountDiscount = discountTax,
                litemCurrTaxAmountFace     = faceTax,
                litemCurrTaxAmountPenalty  = penaltyTax,
                litemDateInterimDate       = DateTime.MaxValue,
                litemDateLastUpdatedDate   = DateTime.Now,
                litemStrBillNumber         = billNumber,

                litemCurrPrevBuilding     = 0, litemCurrPrevLand     = 0,  litemCurrPrevMineral    = 0,   litemCurrPrevTotal      = 0,
                litemIntInstallmentNumber = 0, litemIntInterimMonths = 12, litemIntPaymentPeriodID = 0,   litemIntPaymentStatusID = 0,
                litemIntPaymentTypeID     = 0, litemIntReceiptNumber = 0,  litemIntRemittalID      = 0,    litemMemoNotes         = "",
                litemPaymentID            = 0, litemAmountPaid       = 0,  

                litemBolCloseOut = false, litemBolInterim = false, litemBolSelectedRow = false, 

                litemDateEffectiveDate = dateDiscountStart,
                litemIntTaxTypeID      = taxTypeId,
                litemStrFiscalSubYear  = fiscalSubYear,
                litemStrFiscalYear     = fiscalYear,
                litemDblRate           = taxTypeMillage,


            };

            return oRec;
        }
        #endregion
    }
}
