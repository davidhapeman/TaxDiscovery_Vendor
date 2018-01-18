using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor.Classes
{
    public class clsDataStructures
    {
        public class erieRoundCorrections : List<erieRoundCorrection>
        {
            public erieRoundCorrections() { }
            public erieRoundCorrections(List<erieRoundCorrection> erieRoundCorrections) : base(erieRoundCorrections) { }
        }
        public class erieRoundCorrection
        {
            public string keyLineItemID { get; set; }
            public string parcelNumber { get; set; }
            public decimal orgDisc { get; set; }
            public decimal orgPenl { get; set; }
            public decimal newDisc { get; set; }
            public decimal newPenl { get; set; }
            public decimal adjDisc { get; set; }
            public decimal adjPenl { get; set; }
            public decimal ttOrgDisc { get; set; }
            public decimal ttOrgPenl { get; set; }
            public decimal ttNewDisc { get; set; }
            public decimal ttNewPenl { get; set; }
        }


        public class tblParcelInformations : List<tblParcelInformation>
        {
            public tblParcelInformations() { }
            public tblParcelInformations(List<tblParcelInformation> tblParcelInformations) : base(tblParcelInformations) { }
        }
        public class tblParcelInformation
        {
            public string keyParcelID             { get; set; }
            public string parcelStrNumber         { get; set; }
            public string parcelStrCode           { get; set; }
            public string parcelStrDistrict       { get; set; }
            public string parcelStrSchoolDistrict { get; set; }
            public string parcelMemoLocation      { get; set; }
            public string parcelMemoLegal         { get; set; }
            public string parcelStrTaxCode        { get; set; }
            public string parcelStrAcres          { get; set; }
            public string parcelStrBook           { get; set; }
            public string parcelStrPage           { get; set; }
            public string parcelStrCleanAndGreen  { get; set; }
            public string parcelMemoNotes         { get; set; }
            public string parcelStrHomesteadValue { get; set; }
            public string parcelStrFarmsteadValue { get; set; }
            public string parcelStrControlNumber  { get; set; }
        }

        public class tblOwnerInformations : List<tblOwnerInformation>
        {
            public tblOwnerInformations() { }
            public tblOwnerInformations(List<tblOwnerInformation> tblOwnerInformations) : base(tblOwnerInformations) { }
        }
        public class tblOwnerInformation
        {
            public string keyOwnerId              { get; set; }
            public string ownerStrParcelNumber    { get; set; }
            public string ownerStrOwnerName1      { get; set; }
            public string ownerStrOwnerName2      { get; set; }
            public string ownerMemoBillingAddress { get; set; }
            public string ownerBolCurrent         { get; set; }
            public string ownerDateEffectiveDate  { get; set; }
            public string ownerDateLastUpdated    { get; set; }
            public string ownerStrBillingZipCode  { get; set; }
        }

        public class tblLineItemTaxs : List<tblLineItemTax>
        {
            public tblLineItemTaxs() { }
            public tblLineItemTaxs(List<tblLineItemTax> tblLineItemTaxs) : base(tblLineItemTaxs) { }
        }
        public class tblLineItemTax
        {
            public string keyLineItemID              { get; set; }
            public string litemStrParcelNumber       { get; set; }
            public string litemIntTaxTypeID          { get; set; }
            public string litemDateEffectiveDate     { get; set; }
            public string litemCurrLand              { get; set; }
            public string litemCurrBuilding          { get; set; }
            public string litemCurrMineral           { get; set; }
            public string litemCurrTotal             { get; set; }
            public string litemCurrAssessedLand      { get; set; }
            public string litemCurrAssessedBuilding  { get; set; }
            public string litemCurrAssessedMineral   { get; set; }
            public string litemCurrAssessedTotal     { get; set; }
            public string litemCurrTaxAmountFace     { get; set; }
            public string litemCurrTaxAmountDiscount { get; set; }
            public string litemCurrTaxAmountPenalty  { get; set; }
            public string litemDblRate               { get; set; }
            public string litemAmountPaid            { get; set; }
            public string litemPaymentID             { get; set; }
            public string litemIntPaymentTypeID      { get; set; }
            public string litemIntPaymentStatusID    { get; set; }
            public string litemIntReceiptNumber      { get; set; }
            public string litemIntRemittalID         { get; set; }
            public string litemIntPaymentPeriodID    { get; set; }
            public string litemBolInterim            { get; set; }
            public string litemCurrPrevLand          { get; set; }
            public string litemCurrPrevBuilding      { get; set; }
            public string litemCurrPrevMineral       { get; set; }
            public string litemCurrPrevTotal         { get; set; }
            public string litemStrFiscalYear         { get; set; }
            public string litemStrFiscalSubYear      { get; set; }
            public string litemStrBillNumber         { get; set; }
            public string litemBolCloseOut           { get; set; }
            public string litemDateInterimDate       { get; set; }
            public string litemIntInterimMonths      { get; set; }
            public string litemBolSelectedRow        { get; set; }
            public string litemMemoNotes             { get; set; }
            public string litemDateLastUpdatedDate   { get; set; }
            public string litemIntInstallmentNumber  { get; set; }
            public string litemStrBarCodeValue       { get; set; }
        }

        public class tblPaymentPeriods : List<tblPaymentPeriod>
        {
            public tblPaymentPeriods() { }
            public tblPaymentPeriods(List<tblPaymentPeriod> tblPaymentPeriods) : base(tblPaymentPeriods) { }
        }
        public class tblPaymentPeriod
        {
            public string keyPaymentPeriodsID        { get; set; }
            public string payPeriodDateDiscountStart { get; set; }
            public string payPeriodDateDiscountEnd   { get; set; }
            public string payPeriodDateFaceStart     { get; set; }
            public string payPeriodDateFaceEnd       { get; set; }
            public string payPeriodDatePenaltyStart  { get; set; }
            public string payPeriodDatePenaltyEnd    { get; set; }
            public string payPeriodIntReference      { get; set; }
            public string payPeriodFiscalYear        { get; set; }
            public string payPeriodFiscalSubYear     { get; set; }
            public string payPeriodTaxTypeID         { get; set; }
            public string payPeriodInstallmentNumber { get; set; }
            public string payPeriodDiscountPercent   { get; set; }
            public string payPeriodPenaltyPercent    { get; set; }
        }

        public class tblStartingFigures : List<tblStartingFigure>
        {
            public tblStartingFigures() { }
            public tblStartingFigures(List<tblStartingFigure> tblStartingFigures) : base(tblStartingFigures) { }
        }
        public class tblStartingFigure
        {
            public string keyStartingFigureID { get; set; }
            public string sfigFiscalYear      { get; set; }
            public string sfigFiscalSubYear   { get; set; }
            public string sfigTaxTypeID       { get; set; }
            public string sfigDiscountAmount  { get; set; }
            public string sfigFaceAmount      { get; set; }
            public string sfigPenaltyAmount   { get; set; }
            public string sfigAssessmentTotal { get; set; }
            public string sfigTaxableTotal    { get; set; }
        }
    }
}
