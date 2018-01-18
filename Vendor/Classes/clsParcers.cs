using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor.Classes
{
    public class clsParcers
    {
        public class erieNormalCMs : List<erieNormalCM>
        {
            public erieNormalCMs() { }
            public erieNormalCMs(List<erieNormalCM> erieNormalCMs) : base(erieNormalCMs) { }
        }
        public class erieNormalCM
        {
            public string  Code { get; set; }
            public string  district { get; set; }
            public string  schoolDistrict { get; set; }
            public string  parcelNumber { get; set; }
            public string  ownerName1 { get; set; }
            public string  ownerName2 { get; set; }
            public string  address1 { get; set; }
            public string  address2 { get; set; }
            public string  address3 { get; set; }
            public string  location { get; set; }
            public string  legal1 { get; set; }
            public string  legal2 { get; set; }
            public decimal currLand { get; set; }
            public decimal currBuilding { get; set; }
            public decimal currTotal { get; set; }
            public string  taxCode { get; set; }
            public string  acres { get; set; }
            public decimal taxTotal { get; set; }
            public decimal hydTotal { get; set; }
            public decimal ltsTotal { get; set; }
            public decimal swrTotal { get; set; }
            public decimal countyTax { get; set; }
            public decimal muniTax { get; set; }
            public decimal schoolTax { get; set; }
            public decimal libTax { get; set; }
            public decimal countyMills { get; set; }
            public decimal muniMills { get; set; }
            public decimal schoolMills { get; set; }
            public decimal libMills { get; set; }
            public string  book { get; set; }
            public string  page { get; set; }
            public string  LUC { get; set; }
            public string  cleanGreen { get; set; }
            public string  lertaFlag { get; set; }
            public decimal fairLand { get; set; }
            public decimal fairBuilding { get; set; }
            public decimal fairTotal { get; set; }
            public decimal lertaBuilding { get; set; }
            public string  _countyHomestead { get; set; }
            public string  _countyFarmstead { get; set; }
            public string  _muniHomestead { get; set; }
            public string  _muniFarmstead { get; set; }
            public string  _schoolHomestead { get; set; }
            public string  _schoolFarmstead { get; set; }
            public decimal countyAssessLessExclusion { get; set; }
            public decimal muniAssessLessExclusion { get; set; }
            public decimal schoolAssessLessExclusion { get; set; }
            public decimal origCountyTax { get; set; }
            public decimal origMuniTax { get; set; }
            public decimal origSchoolTax { get; set; }
            public decimal countyHomesteadExclusion { get; set; }
            public decimal muniHomesteadExclusion { get; set; }
            public decimal schoolHomesteadExclusion { get; set; }
            public decimal countyFarmesteadExclusion { get; set; }
            public decimal muniFarmsteadExclusion { get; set; }
            public decimal schoolFarmsteadExclusion { get; set; }
            public string  homesteadEligible { get; set; }
            public string  farmsteadEligible { get; set; }

        }


        public class eriePrinterRecords : List<eriePrinterRecord>
        {
            public eriePrinterRecords() { }
            public eriePrinterRecords(List<eriePrinterRecord> eriePrinterRecords) : base(eriePrinterRecords) { }
        }
        public class eriePrinterRecord
        {
            public string  parcelNumber  { get; set; }
            public decimal totalDiscount { get; set; }
            public decimal totalFace     { get; set; }
            public decimal totalPenalty  { get; set; }
        }

        public class erieNormalSchools : List<erieNormalSchool>
        {
            public erieNormalSchools() { }
            public erieNormalSchools(List<erieNormalSchool> erieNormalSchools) : base(erieNormalSchools) { }
        }
        public class erieNormalSchool
        {
            //Code	Dist	School Dist	Parid	
            //Owner 1	Owner 2	Paddr 1	Paddr 2	Paddr 3	
            //Location	Legal 1	Legal 2	Land	Bldg	Total	
            public string  code            { get; set; }
            public string  district        { get; set; }
            public string  schoolDistrict  { get; set; }
            public string  parcelNumber    { get; set; }
            public string  ownerName1      { get; set; }
            public string  ownerName2      { get; set; }
            public string  ownerAddress1   { get; set; }
            public string  ownerAddress2   { get; set; }
            public string  ownerAddress3   { get; set; }
            public string  location        { get; set; }
            public string  legal1          { get; set; }
            public string  legal2          { get; set; }
            public decimal landTaxable     { get; set; }
            public decimal buildingTaxable { get; set; }
            public decimal totalTaxable    { get; set; }
            //Tax Code	Acres	Tax Total	Hydtotal	LtsTotal	Swrtotal	
            //Cnty Tax	Muni Tax	School Tax	Lib Tax	
            //County Rate	Muni Rate	School Rate	Lib Rate	
            public string  taxcode      { get; set; }
            public string  acres        { get; set; }
            public decimal taxTotal     { get; set; }
            public decimal hydrantTotal { get; set; }
            public decimal lightTotal   { get; set; }
            public decimal sewerTotal   { get; set; }
            public decimal countyTax    { get; set; }
            public decimal muniTax      { get; set; }
            public decimal schoolTax    { get; set; }
            public decimal libraryTax   { get; set; }
            public decimal countyRate   { get; set; }
            public decimal muniRate     { get; set; }
            public decimal schoolRate   { get; set; }
            public decimal libraryRate  { get; set; }

            //Book	Page	LUC	C&G Flag	LERTA Flag	
            //Fair Land	Fair Bldg	Fair Total	LERTA Bldg	

            public string  book               { get; set; } 
            public string  page               { get; set; }
            public string  LUC                { get; set; }
            public string  cleanGreenFlag     { get; set; }
            public string  lertaFlag          { get; set; }
            public decimal landAssessment     { get; set; }
            public decimal buildingAssessment { get; set; }
            public decimal totalAssessment    { get; set; }
            public decimal lertaBuilding      { get; set; }

            //Cnty Hmsd	Cnty Fmsd	Muni Hmsd	Muni Fmsd	Schl Hmsd	Schl Fmsd	
            public decimal countyHomestead { get; set; }
            public decimal countyFarmstead { get; set; }
            public decimal muniHomestead   { get; set; }
            public decimal muniFarmstead   { get; set; }
            public decimal schoolHomestead { get; set; }
            public decimal schoolFarmstead { get; set; }
            //Cnty Taxable Less Exclusion	
            //Muni Taxable Less Exclusion	
            //Schl Taxable Less Exclusion	
            public decimal countyLessExclusion { get; set; }
            public decimal muniLessExclusion   { get; set; }
            public decimal schoolLessExclusion { get; set; }
            //Original Cnty Tax Dollars	Original Muni Tax Dollars	Original Schl Tax Dollars	
            public decimal countyOriginalTax { get; set; }
            public decimal muniOriginalTax   { get; set; }
            public decimal schoolOriginalTax { get; set; }
            //Cnty Hmsd Exclusion Tax Dollars	
            //Muni Hmsd Exclusion Tax Dollars	
            //Schl Hmsd Exclusion Tax Dollars	
            public decimal countyHomesteadExclusionDollars { get; set; }
            public decimal muniHomesteadExclusionDollars   { get; set; }
            public decimal schoolHomesteadExclusionDollars { get; set; }
            //Cnty Fmsd Exclusion Tax Dollars	
            //Muni Fmsd Exclusion Tax Dollars	
            //Schl Fmsd Excl Tax Dollars	
            public decimal countyFarmsteadExclusionDollars { get; set; }
            public decimal muniFarmsteadExclusionDollars   { get; set; }
            public decimal schoolFarmsteadExclusionDollars { get; set; }
            //Homestead Eligible	Farmstead Eligible

            public string homesteadEligible { get; set; }
            public string farmsteadEligible { get; set; }
        }

        public class erieInterims : List<erieInterim>
        {
            public erieInterims() { }
            public erieInterims(List<erieInterim> erieInterims) : base(erieInterims) { }
        }
        public class erieInterim
        {
            public string  parcelNumber { get; set; }
            public string  locationText { get; set; }
            public string  parcelClass { get; set; }
            public string  LUC { get; set; }
            public string  ID { get; set; }
            public string  schoolCode { get; set; }
            public string  ownerName { get; set; }
            public string  ownerAddress1 { get; set; }
            public string  ownerAddress2 { get; set; }
            public string  ownerAddress3 { get; set; }
            public string  bookNumber { get; set; }
            public string  pageNumber { get; set; }
            public string  cmDate { get; set; }
            public string  cmMonths { get; set; }
            public string  schoolDate { get; set; }
            public string  schoolMonths { get; set; }
            public string  btIndr { get; set; }
            public string  reasonText { get; set; }
            public string  prevLand { get; set; }
            public string  prevBuilding { get; set; }
            public string  prevTotal { get; set; }
            public string  currLand { get; set; }
            public string  currBuilding { get; set; }
            public string  currTotal { get; set; }
            public string  chgLand { get; set; }
            public string  chgBuilding { get; set; }
            public string  chgTotal { get; set; }
            public decimal countyFace { get; set; }
            public decimal muniFace { get; set; }
            public decimal schoolFace { get; set; }
        }
    }
}
