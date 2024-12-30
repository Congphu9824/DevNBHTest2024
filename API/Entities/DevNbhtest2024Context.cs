using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

public partial class DevNbhtest2024Context : DbContext
{
    public DevNbhtest2024Context()
    {
    }

    public DevNbhtest2024Context(DbContextOptions<DevNbhtest2024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AaasalesMenu> AaasalesMenus { get; set; }

    public virtual DbSet<AabsalesMenu> AabsalesMenus { get; set; }

    public virtual DbSet<Atest> Atests { get; set; }

    public virtual DbSet<BalanceStabilizationFund> BalanceStabilizationFunds { get; set; }

    public virtual DbSet<BillOfMaterial> BillOfMaterials { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<BusinessPriceList> BusinessPriceLists { get; set; }

    public virtual DbSet<CatalogAccountCostSold> CatalogAccountCostSolds { get; set; }

    public virtual DbSet<CatalogAccountMovement> CatalogAccountMovements { get; set; }

    public virtual DbSet<CatalogAccountMovement154> CatalogAccountMovement154s { get; set; }

    public virtual DbSet<CatalogAccountSymbol> CatalogAccountSymbols { get; set; }

    public virtual DbSet<CatalogAccountType> CatalogAccountTypes { get; set; }

    public virtual DbSet<CatalogAccounting> CatalogAccountings { get; set; }

    public virtual DbSet<CatalogAccountingByReason> CatalogAccountingByReasons { get; set; }

    public virtual DbSet<CatalogAccountingSave> CatalogAccountingSaves { get; set; }

    public virtual DbSet<CatalogArea> CatalogAreas { get; set; }

    public virtual DbSet<CatalogAsset> CatalogAssets { get; set; }

    public virtual DbSet<CatalogAssetGroup> CatalogAssetGroups { get; set; }

    public virtual DbSet<CatalogBankAccountNumber> CatalogBankAccountNumbers { get; set; }

    public virtual DbSet<CatalogBankOfAccount> CatalogBankOfAccounts { get; set; }

    public virtual DbSet<CatalogBarcodeByProduct> CatalogBarcodeByProducts { get; set; }

    public virtual DbSet<CatalogBranch> CatalogBranches { get; set; }

    public virtual DbSet<CatalogCapitalInterestPaymentMethod> CatalogCapitalInterestPaymentMethods { get; set; }

    public virtual DbSet<CatalogChosePrint> CatalogChosePrints { get; set; }

    public virtual DbSet<CatalogCodeProductExist> CatalogCodeProductExists { get; set; }

    public virtual DbSet<CatalogCommandType> CatalogCommandTypes { get; set; }

    public virtual DbSet<CatalogConsignee> CatalogConsignees { get; set; }

    public virtual DbSet<CatalogConstruction> CatalogConstructions { get; set; }

    public virtual DbSet<CatalogContract> CatalogContracts { get; set; }

    public virtual DbSet<CatalogContractFileAttach> CatalogContractFileAttaches { get; set; }

    public virtual DbSet<CatalogCreditProduct> CatalogCreditProducts { get; set; }

    public virtual DbSet<CatalogDiscount> CatalogDiscounts { get; set; }

    public virtual DbSet<CatalogDistrict> CatalogDistricts { get; set; }

    public virtual DbSet<CatalogFiveElement> CatalogFiveElements { get; set; }

    public virtual DbSet<CatalogForeignCurrency> CatalogForeignCurrencies { get; set; }

    public virtual DbSet<CatalogFundingSource> CatalogFundingSources { get; set; }

    public virtual DbSet<CatalogFundingSource1603> CatalogFundingSource1603s { get; set; }

    public virtual DbSet<CatalogFuntion> CatalogFuntions { get; set; }

    public virtual DbSet<CatalogGender> CatalogGenders { get; set; }

    public virtual DbSet<CatalogGetInforEnterprise> CatalogGetInforEnterprises { get; set; }

    public virtual DbSet<CatalogGoldenRatio> CatalogGoldenRatios { get; set; }

    public virtual DbSet<CatalogGroupArea> CatalogGroupAreas { get; set; }

    public virtual DbSet<CatalogGroupConstruction> CatalogGroupConstructions { get; set; }

    public virtual DbSet<CatalogGroupContract> CatalogGroupContracts { get; set; }

    public virtual DbSet<CatalogGroupContract1603> CatalogGroupContract1603s { get; set; }

    public virtual DbSet<CatalogGroupObj> CatalogGroupObjs { get; set; }

    public virtual DbSet<CatalogGroupProduct> CatalogGroupProducts { get; set; }

    public virtual DbSet<CatalogGroupProject> CatalogGroupProjects { get; set; }

    public virtual DbSet<CatalogGroupProject1603> CatalogGroupProject1603s { get; set; }

    public virtual DbSet<CatalogImageProduct> CatalogImageProducts { get; set; }

    public virtual DbSet<CatalogImpExpReason> CatalogImpExpReasons { get; set; }

    public virtual DbSet<CatalogInfoSendMail> CatalogInfoSendMails { get; set; }

    public virtual DbSet<CatalogInformationEinvoiceBkav> CatalogInformationEinvoiceBkavs { get; set; }

    public virtual DbSet<CatalogInvoiceInfo> CatalogInvoiceInfos { get; set; }

    public virtual DbSet<CatalogInvoiceSupplier> CatalogInvoiceSuppliers { get; set; }

    public virtual DbSet<CatalogLocationPublishInv> CatalogLocationPublishInvs { get; set; }

    public virtual DbSet<CatalogManufacturingStage> CatalogManufacturingStages { get; set; }

    public virtual DbSet<CatalogMemberRating> CatalogMemberRatings { get; set; }

    public virtual DbSet<CatalogMethodOfPayment> CatalogMethodOfPayments { get; set; }

    public virtual DbSet<CatalogModeType> CatalogModeTypes { get; set; }

    public virtual DbSet<CatalogMonth> CatalogMonths { get; set; }

    public virtual DbSet<CatalogObject> CatalogObjects { get; set; }

    public virtual DbSet<CatalogObject1503> CatalogObject1503s { get; set; }

    public virtual DbSet<CatalogPrinterName> CatalogPrinterNames { get; set; }

    public virtual DbSet<CatalogProduct> CatalogProducts { get; set; }

    public virtual DbSet<CatalogProductAll> CatalogProductAlls { get; set; }

    public virtual DbSet<CatalogProductExist> CatalogProductExists { get; set; }

    public virtual DbSet<CatalogProductMaterial> CatalogProductMaterials { get; set; }

    public virtual DbSet<CatalogProductQualityTeam> CatalogProductQualityTeams { get; set; }

    public virtual DbSet<CatalogProductSizeGroup> CatalogProductSizeGroups { get; set; }

    public virtual DbSet<CatalogProductType> CatalogProductTypes { get; set; }

    public virtual DbSet<CatalogProductionActivitie> CatalogProductionActivities { get; set; }

    public virtual DbSet<CatalogProductionActivitie1603> CatalogProductionActivitie1603s { get; set; }

    public virtual DbSet<CatalogProductionShift> CatalogProductionShifts { get; set; }

    public virtual DbSet<CatalogProgramPromotion> CatalogProgramPromotions { get; set; }

    public virtual DbSet<CatalogProject> CatalogProjects { get; set; }

    public virtual DbSet<CatalogProject1603> CatalogProject1603s { get; set; }

    public virtual DbSet<CatalogProvince> CatalogProvinces { get; set; }

    public virtual DbSet<CatalogPurposeOfUse> CatalogPurposeOfUses { get; set; }

    public virtual DbSet<CatalogRetailPriceVolatility> CatalogRetailPriceVolatilities { get; set; }

    public virtual DbSet<CatalogRevExp> CatalogRevExps { get; set; }

    public virtual DbSet<CatalogRevExp1603> CatalogRevExp1603s { get; set; }

    public virtual DbSet<CatalogRoom> CatalogRooms { get; set; }

    public virtual DbSet<CatalogSalaryAction> CatalogSalaryActions { get; set; }

    public virtual DbSet<CatalogSalaryType> CatalogSalaryTypes { get; set; }

    public virtual DbSet<CatalogSalesChannel> CatalogSalesChannels { get; set; }

    public virtual DbSet<CatalogScale> CatalogScales { get; set; }

    public virtual DbSet<CatalogSelecttedPrint> CatalogSelecttedPrints { get; set; }

    public virtual DbSet<CatalogServiceProduct> CatalogServiceProducts { get; set; }

    public virtual DbSet<CatalogShippingMethod> CatalogShippingMethods { get; set; }

    public virtual DbSet<CatalogSignTimeSheet> CatalogSignTimeSheets { get; set; }

    public virtual DbSet<CatalogStatusShopingCart> CatalogStatusShopingCarts { get; set; }

    public virtual DbSet<CatalogTableCommon> CatalogTableCommons { get; set; }

    public virtual DbSet<CatalogTemplateExcel> CatalogTemplateExcels { get; set; }

    public virtual DbSet<CatalogThickness> CatalogThicknesses { get; set; }

    public virtual DbSet<CatalogTone> CatalogTones { get; set; }

    public virtual DbSet<CatalogTool> CatalogTools { get; set; }

    public virtual DbSet<CatalogTypeOfMatarial> CatalogTypeOfMatarials { get; set; }

    public virtual DbSet<CatalogTypeOfTaxRate> CatalogTypeOfTaxRates { get; set; }

    public virtual DbSet<CatalogTypeReport> CatalogTypeReports { get; set; }

    public virtual DbSet<CatalogUnit> CatalogUnits { get; set; }

    public virtual DbSet<CatalogUnitPc> CatalogUnitPcs { get; set; }

    public virtual DbSet<CatalogUserFuntion> CatalogUserFuntions { get; set; }

    public virtual DbSet<CatalogVatRateType> CatalogVatRateTypes { get; set; }

    public virtual DbSet<CatalogVehicle> CatalogVehicles { get; set; }

    public virtual DbSet<CatalogVillage> CatalogVillages { get; set; }

    public virtual DbSet<CatalogVoucherNumber> CatalogVoucherNumbers { get; set; }

    public virtual DbSet<CatalogVouchersInherit> CatalogVouchersInherits { get; set; }

    public virtual DbSet<CatalogVouchersTrasfer> CatalogVouchersTrasfers { get; set; }

    public virtual DbSet<CatalogWard> CatalogWards { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryWarehose> CategoryWarehoses { get; set; }

    public virtual DbSet<CategoryWarehosesave> CategoryWarehosesaves { get; set; }

    public virtual DbSet<ContractInforPlu> ContractInforPlus { get; set; }

    public virtual DbSet<ContractOfCreditLine> ContractOfCreditLines { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<DataAdminAccountTransfer> DataAdminAccountTransfers { get; set; }

    public virtual DbSet<DataAdminAllotmentAssetTool> DataAdminAllotmentAssetTools { get; set; }

    public virtual DbSet<DataBusinessResultsLastPeriod> DataBusinessResultsLastPeriods { get; set; }

    public virtual DbSet<DataCalculatingCostOfGoodsSold> DataCalculatingCostOfGoodsSolds { get; set; }

    public virtual DbSet<DataContentsExportManu> DataContentsExportManus { get; set; }

    public virtual DbSet<DataContentsExportSell> DataContentsExportSells { get; set; }

    public virtual DbSet<DataCostAllotmentDeclaration> DataCostAllotmentDeclarations { get; set; }

    public virtual DbSet<DataCostOfGoodsTransfer> DataCostOfGoodsTransfers { get; set; }

    public virtual DbSet<DataDebtsAccordingToInvoice> DataDebtsAccordingToInvoices { get; set; }

    public virtual DbSet<DataExportManu> DataExportManus { get; set; }

    public virtual DbSet<DataField> DataFields { get; set; }

    public virtual DbSet<DataFieldUser> DataFieldUsers { get; set; }

    public virtual DbSet<DataImpFinish> DataImpFinishes { get; set; }

    public virtual DbSet<DataInvernExpManu> DataInvernExpManus { get; set; }

    public virtual DbSet<DataInvernImpFin> DataInvernImpFins { get; set; }

    public virtual DbSet<DataListVouchersExportManu> DataListVouchersExportManus { get; set; }

    public virtual DbSet<DataManufacturingStage> DataManufacturingStages { get; set; }

    public virtual DbSet<DataProducingProcess> DataProducingProcesses { get; set; }

    public virtual DbSet<DataProducingProcessSortMetal> DataProducingProcessSortMetals { get; set; }

    public virtual DbSet<DataSelect> DataSelects { get; set; }

    public virtual DbSet<DataStageResin> DataStageResins { get; set; }

    public virtual DbSet<DataTracingVoucher> DataTracingVouchers { get; set; }

    public virtual DbSet<DataTransBlanceAccouting> DataTransBlanceAccoutings { get; set; }

    public virtual DbSet<DataTransBlanceMaterrial> DataTransBlanceMaterrials { get; set; }

    public virtual DbSet<DataTypeAndAccountSymbol> DataTypeAndAccountSymbols { get; set; }

    public virtual DbSet<DataUserLog> DataUserLogs { get; set; }

    public virtual DbSet<DataWaitingForAllocation> DataWaitingForAllocations { get; set; }

    public virtual DbSet<DeleteSalesSmartContentsDatum> DeleteSalesSmartContentsData { get; set; }

    public virtual DbSet<DeleteSalesSmartDataAll> DeleteSalesSmartDataAlls { get; set; }

    public virtual DbSet<DeleteSalesSmartDatum> DeleteSalesSmartData { get; set; }

    public virtual DbSet<DeleteSalesSmartProductInventory> DeleteSalesSmartProductInventories { get; set; }

    public virtual DbSet<DeleteSmartContentsDatum> DeleteSmartContentsData { get; set; }

    public virtual DbSet<DeleteSmartCostAllotment> DeleteSmartCostAllotments { get; set; }

    public virtual DbSet<DeleteSmartDataAll> DeleteSmartDataAlls { get; set; }

    public virtual DbSet<DeleteSmartDatum> DeleteSmartData { get; set; }

    public virtual DbSet<DeleteSmartFileAttach> DeleteSmartFileAttaches { get; set; }

    public virtual DbSet<DeleteSmartListOfTool> DeleteSmartListOfTools { get; set; }

    public virtual DbSet<DeleteSmartVatTaxList> DeleteSmartVatTaxLists { get; set; }

    public virtual DbSet<ExcelCatalogObject> ExcelCatalogObjects { get; set; }

    public virtual DbSet<ExcelCatalogProduct> ExcelCatalogProducts { get; set; }

    public virtual DbSet<ExcelSmartDatum> ExcelSmartData { get; set; }

    public virtual DbSet<FtpInformation> FtpInformations { get; set; }

    public virtual DbSet<FundCreditContract> FundCreditContracts { get; set; }

    public virtual DbSet<ImageDocumentProduct> ImageDocumentProducts { get; set; }

    public virtual DbSet<InformationSerialPort> InformationSerialPorts { get; set; }

    public virtual DbSet<ListProductWithBarcode> ListProductWithBarcodes { get; set; }

    public virtual DbSet<ListViewConfig> ListViewConfigs { get; set; }

    public virtual DbSet<Lock> Locks { get; set; }

    public virtual DbSet<MaterialRemaining> MaterialRemainings { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<OpenAccounting> OpenAccountings { get; set; }

    public virtual DbSet<OptionPrintOrder> OptionPrintOrders { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<ParameterReport> ParameterReports { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductManufacturingStage> ProductManufacturingStages { get; set; }

    public virtual DbSet<QuickAccounting> QuickAccountings { get; set; }

    public virtual DbSet<RawMaterialConsumptionNorm> RawMaterialConsumptionNorms { get; set; }

    public virtual DbSet<RemainingQuantityManufaceture> RemainingQuantityManufacetures { get; set; }

    public virtual DbSet<RemainingQuantityManufacetureSortMetal> RemainingQuantityManufacetureSortMetals { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportAccountDetailsBook> ReportAccountDetailsBooks { get; set; }

    public virtual DbSet<ReportArisingBalanceSheet> ReportArisingBalanceSheets { get; set; }

    public virtual DbSet<ReportBalanceSheet> ReportBalanceSheets { get; set; }

    public virtual DbSet<ReportBusinessResultsSheet> ReportBusinessResultsSheets { get; set; }

    public virtual DbSet<ReportCalculateProductionCost> ReportCalculateProductionCosts { get; set; }

    public virtual DbSet<ReportCashBook> ReportCashBooks { get; set; }

    public virtual DbSet<ReportCashFlow> ReportCashFlows { get; set; }

    public virtual DbSet<ReportCashInSalePoint> ReportCashInSalePoints { get; set; }

    public virtual DbSet<ReportDataInventory> ReportDataInventories { get; set; }

    public virtual DbSet<ReportDebtReconciliation> ReportDebtReconciliations { get; set; }

    public virtual DbSet<ReportDebtSummaryBook> ReportDebtSummaryBooks { get; set; }

    public virtual DbSet<ReportDeliveryNotYetDelivered> ReportDeliveryNotYetDelivereds { get; set; }

    public virtual DbSet<ReportFileNameByPrinter> ReportFileNameByPrinters { get; set; }

    public virtual DbSet<ReportGeneralLogBook> ReportGeneralLogBooks { get; set; }

    public virtual DbSet<ReportGeneralLogLedger> ReportGeneralLogLedgers { get; set; }

    public virtual DbSet<ReportGrossProfit> ReportGrossProfits { get; set; }

    public virtual DbSet<ReportGrossProfitOutput> ReportGrossProfitOutputs { get; set; }

    public virtual DbSet<ReportImportExport> ReportImportExports { get; set; }

    public virtual DbSet<ReportLatePaymentTable> ReportLatePaymentTables { get; set; }

    public virtual DbSet<ReportLateProductAgeTable> ReportLateProductAgeTables { get; set; }

    public virtual DbSet<ReportMaterialDetailsBook> ReportMaterialDetailsBooks { get; set; }

    public virtual DbSet<ReportMaterialSummaryBook> ReportMaterialSummaryBooks { get; set; }

    public virtual DbSet<ReportMaterialSummaryBookAdmin> ReportMaterialSummaryBookAdmins { get; set; }

    public virtual DbSet<ReportMaterialSummaryByReasonBook> ReportMaterialSummaryByReasonBooks { get; set; }

    public virtual DbSet<ReportMaterialSummaryByReasonBookAdmin> ReportMaterialSummaryByReasonBookAdmins { get; set; }

    public virtual DbSet<ReportPrintSalesCompareNew> ReportPrintSalesCompareNews { get; set; }

    public virtual DbSet<ReportPrintSalesNew> ReportPrintSalesNews { get; set; }

    public virtual DbSet<ReportSalesDebtSummaryBook> ReportSalesDebtSummaryBooks { get; set; }

    public virtual DbSet<ReportSalesMaterialSummaryByReasonBook> ReportSalesMaterialSummaryByReasonBooks { get; set; }

    public virtual DbSet<ReportSalesMaterialSummaryByReasonBookAdmin> ReportSalesMaterialSummaryByReasonBookAdmins { get; set; }

    public virtual DbSet<ReportSalesMaterialSummaryByReasonBookBuyAdmin> ReportSalesMaterialSummaryByReasonBookBuyAdmins { get; set; }

    public virtual DbSet<ReportSalesMaterialSummaryByReasonBookNv0002> ReportSalesMaterialSummaryByReasonBookNv0002s { get; set; }

    public virtual DbSet<ReportSalesPublication> ReportSalesPublications { get; set; }

    public virtual DbSet<ReportSalesTreading> ReportSalesTreadings { get; set; }

    public virtual DbSet<ReportSalesWarehouse> ReportSalesWarehouses { get; set; }

    public virtual DbSet<ReportSalesWarehouseCard> ReportSalesWarehouseCards { get; set; }

    public virtual DbSet<ReportSalesWarehouseInv> ReportSalesWarehouseInvs { get; set; }

    public virtual DbSet<ReportSalesWarehouseStageLoss> ReportSalesWarehouseStageLosses { get; set; }

    public virtual DbSet<ReportSearchInvoiceImpExp> ReportSearchInvoiceImpExps { get; set; }

    public virtual DbSet<ReportSmartDetailAllInOne> ReportSmartDetailAllInOnes { get; set; }

    public virtual DbSet<ReportSmartMarterialInventoryInAllWarehose> ReportSmartMarterialInventoryInAllWarehoses { get; set; }

    public virtual DbSet<ReportToKhaiThueGtgt> ReportToKhaiThueGtgts { get; set; }

    public virtual DbSet<ResultBkavInvoice> ResultBkavInvoices { get; set; }

    public virtual DbSet<RetailPriceList> RetailPriceLists { get; set; }

    public virtual DbSet<RetailPriceListByWarehose> RetailPriceListByWarehoses { get; set; }

    public virtual DbSet<RuleAccountNumber> RuleAccountNumbers { get; set; }

    public virtual DbSet<RuleReport> RuleReports { get; set; }

    public virtual DbSet<RuleUnit> RuleUnits { get; set; }

    public virtual DbSet<RuleUser> RuleUsers { get; set; }

    public virtual DbSet<RuleUserSave> RuleUserSaves { get; set; }

    public virtual DbSet<RuleWarehose> RuleWarehoses { get; set; }

    public virtual DbSet<RuleWarehoseView> RuleWarehoseViews { get; set; }

    public virtual DbSet<SalaryConfig> SalaryConfigs { get; set; }

    public virtual DbSet<SalarySchedule> SalarySchedules { get; set; }

    public virtual DbSet<SalaryTimeSheet> SalaryTimeSheets { get; set; }

    public virtual DbSet<SalesCashRemaining> SalesCashRemainings { get; set; }

    public virtual DbSet<SalesCatalogColumnPump> SalesCatalogColumnPumps { get; set; }

    public virtual DbSet<SalesCatalogLossRate> SalesCatalogLossRates { get; set; }

    public virtual DbSet<SalesCatalogTank> SalesCatalogTanks { get; set; }

    public virtual DbSet<SalesCatalogVcfd15> SalesCatalogVcfd15s { get; set; }

    public virtual DbSet<SalesCatalogVoucherNumber> SalesCatalogVoucherNumbers { get; set; }

    public virtual DbSet<SalesCatalogVoucherNumbersave> SalesCatalogVoucherNumbersaves { get; set; }

    public virtual DbSet<SalesCountPump> SalesCountPumps { get; set; }

    public virtual DbSet<SalesDataInventoryDocumment> SalesDataInventoryDocumments { get; set; }

    public virtual DbSet<SalesDataInvoice> SalesDataInvoices { get; set; }

    public virtual DbSet<SalesDataShiftNotebook> SalesDataShiftNotebooks { get; set; }

    public virtual DbSet<SalesListBillImpReturn> SalesListBillImpReturns { get; set; }

    public virtual DbSet<SalesLock> SalesLocks { get; set; }

    public virtual DbSet<SalesMaterialRemaining> SalesMaterialRemainings { get; set; }

    public virtual DbSet<SalesMaterialRemainingMonth> SalesMaterialRemainingMonths { get; set; }

    public virtual DbSet<SalesMenu> SalesMenus { get; set; }

    public virtual DbSet<SalesOptionPrintOrder> SalesOptionPrintOrders { get; set; }

    public virtual DbSet<SalesReport> SalesReports { get; set; }

    public virtual DbSet<SalesReportSave> SalesReportSaves { get; set; }

    public virtual DbSet<SalesRuleReport> SalesRuleReports { get; set; }

    public virtual DbSet<SalesRuleUnit> SalesRuleUnits { get; set; }

    public virtual DbSet<SalesRuleUser> SalesRuleUsers { get; set; }

    public virtual DbSet<SalesRuleUserSave> SalesRuleUserSaves { get; set; }

    public virtual DbSet<SalesShoppingCart> SalesShoppingCarts { get; set; }

    public virtual DbSet<SalesShoppingCartContent> SalesShoppingCartContents { get; set; }

    public virtual DbSet<SalesSmartContentsDatum> SalesSmartContentsData { get; set; }

    public virtual DbSet<SalesSmartDataAll> SalesSmartDataAlls { get; set; }

    public virtual DbSet<SalesSmartDataAllSum> SalesSmartDataAllSums { get; set; }

    public virtual DbSet<SalesSmartDataAllok> SalesSmartDataAlloks { get; set; }

    public virtual DbSet<SalesSmartDataDc> SalesSmartDataDcs { get; set; }

    public virtual DbSet<SalesSmartDataImpExp> SalesSmartDataImpExps { get; set; }

    public virtual DbSet<SalesSmartDataImpExpManu> SalesSmartDataImpExpManus { get; set; }

    public virtual DbSet<SalesSmartDataImpExpSum> SalesSmartDataImpExpSums { get; set; }

    public virtual DbSet<SalesSmartDataInheritedDocument> SalesSmartDataInheritedDocuments { get; set; }

    public virtual DbSet<SalesSmartDataInv> SalesSmartDataInvs { get; set; }

    public virtual DbSet<SalesSmartDataInvSum> SalesSmartDataInvSums { get; set; }

    public virtual DbSet<SalesSmartDataInventory> SalesSmartDataInventories { get; set; }

    public virtual DbSet<SalesSmartDataInventoryDocument> SalesSmartDataInventoryDocuments { get; set; }

    public virtual DbSet<SalesSmartDataOrderBuy> SalesSmartDataOrderBuys { get; set; }

    public virtual DbSet<SalesSmartDataOrderBuyUneven> SalesSmartDataOrderBuyUnevens { get; set; }

    public virtual DbSet<SalesSmartDataOrderSell> SalesSmartDataOrderSells { get; set; }

    public virtual DbSet<SalesSmartDataShift> SalesSmartDataShifts { get; set; }

    public virtual DbSet<SalesSmartDataSumWarehose> SalesSmartDataSumWarehoses { get; set; }

    public virtual DbSet<SalesSmartDataTank> SalesSmartDataTanks { get; set; }

    public virtual DbSet<SalesSmartDataVoucher> SalesSmartDataVouchers { get; set; }

    public virtual DbSet<SalesSmartDataVoucherSum> SalesSmartDataVoucherSums { get; set; }

    public virtual DbSet<SalesSmartDataWarehouseSent> SalesSmartDataWarehouseSents { get; set; }

    public virtual DbSet<SalesSmartDataWarranty> SalesSmartDataWarranties { get; set; }

    public virtual DbSet<SalesSmartDatum> SalesSmartData { get; set; }

    public virtual DbSet<SalesSmartProductInventory> SalesSmartProductInventories { get; set; }

    public virtual DbSet<SalesSmartVoucherImpReturn> SalesSmartVoucherImpReturns { get; set; }

    public virtual DbSet<SalesSummaryMaterialTemporary> SalesSummaryMaterialTemporaries { get; set; }

    public virtual DbSet<SalesTrackVoucher> SalesTrackVouchers { get; set; }

    public virtual DbSet<SalesTradingOptionPrintOrder> SalesTradingOptionPrintOrders { get; set; }

    public virtual DbSet<SalesUnitInfo> SalesUnitInfos { get; set; }

    public virtual DbSet<SalesUser> SalesUsers { get; set; }

    public virtual DbSet<SalesUserLog> SalesUserLogs { get; set; }

    public virtual DbSet<SmartContentsDataDangchuyen> SmartContentsDataDangchuyens { get; set; }

    public virtual DbSet<SmartContentsDatum> SmartContentsData { get; set; }

    public virtual DbSet<SmartContentsDebtRepaymentPlan> SmartContentsDebtRepaymentPlans { get; set; }

    public virtual DbSet<SmartContentsPromotion> SmartContentsPromotions { get; set; }

    public virtual DbSet<SmartContentsPromotionArea> SmartContentsPromotionAreas { get; set; }

    public virtual DbSet<SmartCostAllotment> SmartCostAllotments { get; set; }

    public virtual DbSet<SmartDataAll> SmartDataAlls { get; set; }

    public virtual DbSet<SmartDataAllSum> SmartDataAllSums { get; set; }

    public virtual DbSet<SmartDataBillOfMaterial> SmartDataBillOfMaterials { get; set; }

    public virtual DbSet<SmartDataConsign> SmartDataConsigns { get; set; }

    public virtual DbSet<SmartDataExpSell> SmartDataExpSells { get; set; }

    public virtual DbSet<SmartDataExportByBom> SmartDataExportByBoms { get; set; }

    public virtual DbSet<SmartDataExportManuByBom> SmartDataExportManuByBoms { get; set; }

    public virtual DbSet<SmartDataFinalAdjustment> SmartDataFinalAdjustments { get; set; }

    public virtual DbSet<SmartDataImpExp> SmartDataImpExps { get; set; }

    public virtual DbSet<SmartDataImpExpSum> SmartDataImpExpSums { get; set; }

    public virtual DbSet<SmartDataIndenture> SmartDataIndentures { get; set; }

    public virtual DbSet<SmartDataInheritedDocument> SmartDataInheritedDocuments { get; set; }

    public virtual DbSet<SmartDataInvSum> SmartDataInvSums { get; set; }

    public virtual DbSet<SmartDataInvoice> SmartDataInvoices { get; set; }

    public virtual DbSet<SmartDataManufacture> SmartDataManufactures { get; set; }

    public virtual DbSet<SmartDataManufactureContent> SmartDataManufactureContents { get; set; }

    public virtual DbSet<SmartDataManufactureSum> SmartDataManufactureSums { get; set; }

    public virtual DbSet<SmartDataProductionRequirement> SmartDataProductionRequirements { get; set; }

    public virtual DbSet<SmartDataPromotion> SmartDataPromotions { get; set; }

    public virtual DbSet<SmartDataPumpCode> SmartDataPumpCodes { get; set; }

    public virtual DbSet<SmartDataSellsByMonth> SmartDataSellsByMonths { get; set; }

    public virtual DbSet<SmartDataShoppingCart> SmartDataShoppingCarts { get; set; }

    public virtual DbSet<SmartDataTool> SmartDataTools { get; set; }

    public virtual DbSet<SmartDataVat> SmartDataVats { get; set; }

    public virtual DbSet<SmartDataVoucher> SmartDataVouchers { get; set; }

    public virtual DbSet<SmartDataVoucherSum> SmartDataVoucherSums { get; set; }

    public virtual DbSet<SmartDataYesVat> SmartDataYesVats { get; set; }

    public virtual DbSet<SmartDatum> SmartData { get; set; }

    public virtual DbSet<SmartFileAttach> SmartFileAttaches { get; set; }

    public virtual DbSet<SmartFluctuatingInterestRate> SmartFluctuatingInterestRates { get; set; }

    public virtual DbSet<SmartIdImpReturn> SmartIdImpReturns { get; set; }

    public virtual DbSet<SmartInfoPaymentBill> SmartInfoPaymentBills { get; set; }

    public virtual DbSet<SmartListDataImportedExcel> SmartListDataImportedExcels { get; set; }

    public virtual DbSet<SmartListOfTool> SmartListOfTools { get; set; }

    public virtual DbSet<SmartListProductByBarcode> SmartListProductByBarcodes { get; set; }

    public virtual DbSet<SmartLog> SmartLogs { get; set; }

    public virtual DbSet<SmartLogsOfUsingVoucher> SmartLogsOfUsingVouchers { get; set; }

    public virtual DbSet<SmartManufacture> SmartManufactures { get; set; }

    public virtual DbSet<SmartMapColumnExcel> SmartMapColumnExcels { get; set; }

    public virtual DbSet<SmartOption> SmartOptions { get; set; }

    public virtual DbSet<SmartProductionDataSortMetal> SmartProductionDataSortMetals { get; set; }

    public virtual DbSet<SmartProductionDatum> SmartProductionData { get; set; }

    public virtual DbSet<SmartProductionLookup> SmartProductionLookups { get; set; }

    public virtual DbSet<SmartPromotionalProgram> SmartPromotionalPrograms { get; set; }

    public virtual DbSet<SmartRecorveryMaterial> SmartRecorveryMaterials { get; set; }

    public virtual DbSet<SmartRecorveryMaterialsSave> SmartRecorveryMaterialsSaves { get; set; }

    public virtual DbSet<SmartTableEven> SmartTableEvens { get; set; }

    public virtual DbSet<SmartTransportationCost> SmartTransportationCosts { get; set; }

    public virtual DbSet<SmartTypeDataImportExcel> SmartTypeDataImportExcels { get; set; }

    public virtual DbSet<SmartUseMaterial> SmartUseMaterials { get; set; }

    public virtual DbSet<SmartUseMaterialsSave> SmartUseMaterialsSaves { get; set; }

    public virtual DbSet<SmartVatTaxList> SmartVatTaxLists { get; set; }

    public virtual DbSet<Staff> Staffs { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<TempDataBalanceSheet> TempDataBalanceSheets { get; set; }

    public virtual DbSet<TempSmartTable> TempSmartTables { get; set; }

    public virtual DbSet<TemplateBalanceSheet> TemplateBalanceSheets { get; set; }

    public virtual DbSet<TemplateBusinessResult> TemplateBusinessResults { get; set; }

    public virtual DbSet<TemplateDirectCashFlow> TemplateDirectCashFlows { get; set; }

    public virtual DbSet<TemplateInDirectCashFlow> TemplateInDirectCashFlows { get; set; }

    public virtual DbSet<TemplateNotesToFinancialStatement> TemplateNotesToFinancialStatements { get; set; }

    public virtual DbSet<TradingCatalogVoucherNumber> TradingCatalogVoucherNumbers { get; set; }

    public virtual DbSet<TradingLock> TradingLocks { get; set; }

    public virtual DbSet<TradingMenu> TradingMenus { get; set; }

    public virtual DbSet<TradingOption> TradingOptions { get; set; }

    public virtual DbSet<TradingOptionPrintOrder> TradingOptionPrintOrders { get; set; }

    public virtual DbSet<TradingReport> TradingReports { get; set; }

    public virtual DbSet<TradingRuleReport> TradingRuleReports { get; set; }

    public virtual DbSet<TradingRuleUnit> TradingRuleUnits { get; set; }

    public virtual DbSet<TradingRuleUser> TradingRuleUsers { get; set; }

    public virtual DbSet<TradingSmartContentsDatum> TradingSmartContentsData { get; set; }

    public virtual DbSet<TradingSmartDataAll> TradingSmartDataAlls { get; set; }

    public virtual DbSet<TradingSmartDataAllSum> TradingSmartDataAllSums { get; set; }

    public virtual DbSet<TradingSmartDataSell> TradingSmartDataSells { get; set; }

    public virtual DbSet<TradingSmartDatum> TradingSmartData { get; set; }

    public virtual DbSet<TradingUnitInfo> TradingUnitInfos { get; set; }

    public virtual DbSet<TradingUser> TradingUsers { get; set; }

    public virtual DbSet<TradingUserLog> TradingUserLogs { get; set; }

    public virtual DbSet<UnitInfo> UnitInfos { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserLog> UserLogs { get; set; }

    public virtual DbSet<UserLogsSave> UserLogsSaves { get; set; }

    public virtual DbSet<ViewData131> ViewData131s { get; set; }

    public virtual DbSet<ViewDataCompareExp> ViewDataCompareExps { get; set; }

    public virtual DbSet<ViewDataCompareImp> ViewDataCompareImps { get; set; }

    public virtual DbSet<ViewDataCompareRemainder> ViewDataCompareRemainders { get; set; }

    public virtual DbSet<ViewSalesDataDetailsInv> ViewSalesDataDetailsInvs { get; set; }

    public virtual DbSet<ViewSalesDataImpExp> ViewSalesDataImpExps { get; set; }

    public virtual DbSet<ViewSalesDataInv> ViewSalesDataInvs { get; set; }

    public virtual DbSet<ViewSalesWarehose> ViewSalesWarehoses { get; set; }

    public virtual DbSet<WsmartCatalogInventory> WsmartCatalogInventories { get; set; }

    public virtual DbSet<WsmartCatalogInventoryNew> WsmartCatalogInventoryNews { get; set; }

    public virtual DbSet<WsmartDateInventory> WsmartDateInventories { get; set; }

    public virtual DbSet<WsmartFieldProperty> WsmartFieldProperties { get; set; }

    public virtual DbSet<WsmartFormSetting> WsmartFormSettings { get; set; }

    public virtual DbSet<WsmartInventoryResult> WsmartInventoryResults { get; set; }

    public virtual DbSet<WsmartInventoryResultsAll> WsmartInventoryResultsAlls { get; set; }

    public virtual DbSet<WsmartInventorySheet> WsmartInventorySheets { get; set; }

    public virtual DbSet<WsmartLogger> WsmartLoggers { get; set; }

    public virtual DbSet<WsmartMenu> WsmartMenus { get; set; }

    public virtual DbSet<WsmartMenuRule> WsmartMenuRules { get; set; }

    public virtual DbSet<WsmartProperty> WsmartProperties { get; set; }

    public virtual DbSet<WsmartReport> WsmartReports { get; set; }

    public virtual DbSet<WsmartRole> WsmartRoles { get; set; }

    public virtual DbSet<WsmartRoleClaim> WsmartRoleClaims { get; set; }

    public virtual DbSet<WsmartRuleFuntion> WsmartRuleFuntions { get; set; }

    public virtual DbSet<WsmartUser> WsmartUsers { get; set; }

    public virtual DbSet<WsmartUserClaim> WsmartUserClaims { get; set; }

    public virtual DbSet<WsmartUserLogin> WsmartUserLogins { get; set; }

    public virtual DbSet<WsmartUserToken> WsmartUserTokens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=testdb1.smartsoftwarevn.com,56789;Database=DevNBHTest2024;User Id=smartdev_phupc;Password=SMARTPCP122024@*;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AaasalesMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AAASalesMenu");

            entity.Property(e => e.MenuCaption).HasMaxLength(255);
            entity.Property(e => e.MenuImage).HasMaxLength(100);
            entity.Property(e => e.MenuLevel).HasMaxLength(50);
            entity.Property(e => e.MenuName).HasMaxLength(50);
            entity.Property(e => e.MenuNote).HasMaxLength(255);
            entity.Property(e => e.MenuParameters).HasMaxLength(50);
            entity.Property(e => e.ParameterReport).HasMaxLength(50);
            entity.Property(e => e.ParentMenu).HasMaxLength(50);
            entity.Property(e => e.TableName).HasMaxLength(50);
        });

        modelBuilder.Entity<AabsalesMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AABSalesMenu");

            entity.Property(e => e.MenuCaption).HasMaxLength(255);
            entity.Property(e => e.MenuImage).HasMaxLength(100);
            entity.Property(e => e.MenuLevel).HasMaxLength(50);
            entity.Property(e => e.MenuName).HasMaxLength(50);
            entity.Property(e => e.MenuNote).HasMaxLength(255);
            entity.Property(e => e.MenuParameters).HasMaxLength(50);
            entity.Property(e => e.ParameterReport).HasMaxLength(50);
            entity.Property(e => e.ParentMenu).HasMaxLength(50);
            entity.Property(e => e.TableName).HasMaxLength(50);
        });

        modelBuilder.Entity<Atest>(entity =>
        {
            entity.ToTable("ATEST");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasComment("Khóa");
            entity.Property(e => e.Birthday).HasComment("Ngày sinh");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Ngày Tạo")
                .HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasComment("Họ");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasComment("Tên");
        });

        modelBuilder.Entity<BalanceStabilizationFund>(entity =>
        {
            entity.ToTable("BalanceStabilizationFund");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Contents).HasMaxLength(256);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Note).HasMaxLength(256);
            entity.Property(e => e.Profit).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<BillOfMaterial>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("InsertBillOfMaterials"));

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Identifier).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK__brands__5E5A8E27AABA5DEF");

            entity.ToTable("brands", "production");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BrandName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("brand_name");
        });

        modelBuilder.Entity<BusinessPriceList>(entity =>
        {
            entity.HasKey(e => e.IdContents).HasName("PK_BusinessPriceList_1");

            entity.ToTable("BusinessPriceList");

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BeginDate).HasColumnType("datetime");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(150);
            entity.Property(e => e.DecisionNo).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogAccountCostSold>(entity =>
        {
            entity.ToTable("CatalogAccountCostSold");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreditSide).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Identifier).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<CatalogAccountMovement>(entity =>
        {
            entity.ToTable("CatalogAccountMovement");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogAccountMovement154>(entity =>
        {
            entity.ToTable("CatalogAccountMovement154");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogAccountSymbol>(entity =>
        {
            entity.HasKey(e => e.AccountSymbol);

            entity.ToTable("CatalogAccountSymbol");

            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(255);
            entity.Property(e => e.AccountType).HasMaxLength(255);
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogAccountType>(entity =>
        {
            entity.HasKey(e => e.AccountTypeCode);

            entity.ToTable("CatalogAccountType");

            entity.Property(e => e.AccountTypeCode).HasMaxLength(50);
            entity.Property(e => e.AccountTypeName).HasMaxLength(255);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogAccounting>(entity =>
        {
            entity.HasKey(e => e.IdAsc);

            entity.ToTable("CatalogAccounting");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.CatalogAccounting1)
                .HasMaxLength(50)
                .HasColumnName("CatalogAccounting");
            entity.Property(e => e.ContentContract).HasMaxLength(250);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(250);
            entity.Property(e => e.ContractNumber).HasMaxLength(50);
            entity.Property(e => e.CreditObjectCode).HasMaxLength(50);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataName1).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DataType1).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(50);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductActivCode).HasMaxLength(50);
            entity.Property(e => e.ProductActivName).HasMaxLength(250);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(150);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogAccountingByReason>(entity =>
        {
            entity.HasKey(e => e.IdAsc);

            entity.ToTable("CatalogAccountingByReason");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.CreditObjectCode).HasMaxLength(50);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataName1).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DataType1).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(50);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(150);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogAccountingSave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CatalogAccountingSave");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.CreditObjectCode).HasMaxLength(50);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(50);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(150);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogArea>(entity =>
        {
            entity.HasKey(e => e.CodeArea);

            entity.ToTable("CatalogArea");

            entity.Property(e => e.CodeArea).HasMaxLength(50);
            entity.Property(e => e.GrpCodeArea).HasMaxLength(50);
            entity.Property(e => e.GrpNameArea).HasMaxLength(255);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameArea).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogAsset>(entity =>
        {
            entity.HasKey(e => e.AssetCode);

            entity.ToTable("CatalogAsset");

            entity.Property(e => e.AssetCode).HasMaxLength(50);
            entity.Property(e => e.AssetGroupCode).HasMaxLength(50);
            entity.Property(e => e.AssetGroupName).HasMaxLength(250);
            entity.Property(e => e.AssetName).HasMaxLength(250);
            entity.Property(e => e.AssetValues).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DepreciationEndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Identifier).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.Origin).HasMaxLength(100);
            entity.Property(e => e.OriginalPrice).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PurchaseDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.Units).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogAssetGroup>(entity =>
        {
            entity.HasKey(e => e.AssetGroupCode);

            entity.ToTable("CatalogAssetGroup");

            entity.Property(e => e.AssetGroupCode).HasMaxLength(50);
            entity.Property(e => e.AssetGroupName).HasMaxLength(250);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<CatalogBankAccountNumber>(entity =>
        {
            entity.HasKey(e => e.BankAccountNumbers).HasName("PK_CatalogBankAccountNumbers");

            entity.ToTable("CatalogBankAccountNumber");

            entity.Property(e => e.BankAccountNumbers).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.Bancode)
                .HasMaxLength(50)
                .HasColumnName("BANCode");
            entity.Property(e => e.BankCode).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(250);
            entity.Property(e => e.BranchName).HasMaxLength(250);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<CatalogBankOfAccount>(entity =>
        {
            entity.ToTable("CatalogBankOfAccount");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BankCode).HasMaxLength(20);
            entity.Property(e => e.BankName).HasMaxLength(250);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(20);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Identifier).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogBarcodeByProduct>(entity =>
        {
            entity.ToTable("CatalogBarcodeByProduct", tb => tb.HasTrigger("InsertCatalogBarcodeByProduct"));

            entity.HasIndex(e => new { e.Barcode, e.ProductId, e.CodeProduct }, "Idx_Barcode").HasFillFactor(90);

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Barcode).HasMaxLength(250);
            entity.Property(e => e.CodeProduct).HasMaxLength(100);
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(150);
        });

        modelBuilder.Entity<CatalogBranch>(entity =>
        {
            entity.HasKey(e => new { e.BranchCode, e.Id });

            entity.ToTable("CatalogBranch");

            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BranchName).HasMaxLength(150);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogCapitalInterestPaymentMethod>(entity =>
        {
            entity.ToTable("CatalogCapitalInterestPaymentMethod");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Contents).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogChosePrint>(entity =>
        {
            entity.ToTable("CatalogChosePrint");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ChosePrint).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Subsystem).HasMaxLength(50);
            entity.Property(e => e.TypeNameReport).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogCodeProductExist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CatalogCodeProductExists");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogCommandType>(entity =>
        {
            entity.ToTable("CatalogCommandType");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CmdType).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Identifier).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.StatusInvoice).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogConsignee>(entity =>
        {
            entity.ToTable("CatalogConsignee");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BirthDay).HasColumnType("smalldatetime");
            entity.Property(e => e.CitizenIdentification).HasMaxLength(50);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DateOfIssue).HasColumnType("smalldatetime");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(150);
            entity.Property(e => e.ObjectName).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber).HasMaxLength(250);
            entity.Property(e => e.PlaceOfIssue).HasMaxLength(150);
        });

        modelBuilder.Entity<CatalogConstruction>(entity =>
        {
            entity.HasKey(e => e.ConstructionCode);

            entity.ToTable("CatalogConstruction");

            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ValueConstruction).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<CatalogContract>(entity =>
        {
            entity.HasKey(e => e.ContractNumber);

            entity.ToTable("CatalogContract");

            entity.Property(e => e.ContractNumber).HasMaxLength(50);
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CodeManage).HasMaxLength(20);
            entity.Property(e => e.CodeManage1).HasMaxLength(20);
            entity.Property(e => e.CodePartner).HasMaxLength(50);
            entity.Property(e => e.ContentContract).HasMaxLength(255);
            entity.Property(e => e.CurrencyType).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(250);
            entity.Property(e => e.GuaranteeDate).HasColumnType("smalldatetime");
            entity.Property(e => e.GuaranteeValue).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.MaintenanceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.NameManage).HasMaxLength(50);
            entity.Property(e => e.NameManage1).HasMaxLength(50);
            entity.Property(e => e.NamePartner).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductActivCode).HasMaxLength(50);
            entity.Property(e => e.ProductActivName).HasMaxLength(150);
            entity.Property(e => e.ReferenceNumber).HasMaxLength(255);
            entity.Property(e => e.SigningDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ValueContract).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ValuesMaintenance).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<CatalogContractFileAttach>(entity =>
        {
            entity.ToTable("CatalogContractFileAttach");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.FileNames).HasMaxLength(255);
            entity.Property(e => e.FilePath).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberContract).HasMaxLength(50);
            entity.Property(e => e.ViewFile).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogCreditProduct>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreditProductCode).HasMaxLength(50);
            entity.Property(e => e.CreditProductName).HasMaxLength(150);
            entity.Property(e => e.FormOfCapitalPayment).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InterestPaymentMethod).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogDiscount>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Barcode).HasMaxLength(20);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ContractNo).HasMaxLength(50);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(30);
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ObjectAddress).HasMaxLength(250);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.SignDay).HasColumnType("smalldatetime");
            entity.Property(e => e.Taxcode).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogDistrict>(entity =>
        {
            entity.HasKey(e => e.CodeDistrict);

            entity.ToTable("CatalogDistrict");

            entity.Property(e => e.CodeDistrict).HasMaxLength(50);
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CodeObj).HasMaxLength(50);
            entity.Property(e => e.CodeProvince).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameDistrict).HasMaxLength(255);
            entity.Property(e => e.NameObj).HasMaxLength(255);
            entity.Property(e => e.NameProvince).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogFiveElement>(entity =>
        {
            entity.HasKey(e => e.CodeFiveElements);

            entity.Property(e => e.CodeFiveElements).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameFiveElements).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogForeignCurrency>(entity =>
        {
            entity.ToTable("CatalogForeignCurrency");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<CatalogFundingSource>(entity =>
        {
            entity.HasKey(e => e.FundingSourceCode);

            entity.ToTable("CatalogFundingSource");

            entity.Property(e => e.FundingSourceCode)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogFundingSource1603>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CatalogFundingSource1603");

            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogFuntion>(entity =>
        {
            entity.HasKey(e => new { e.Module, e.FuntionCode });

            entity.ToTable("CatalogFuntion");

            entity.Property(e => e.Module).HasMaxLength(50);
            entity.Property(e => e.FuntionCode).HasMaxLength(50);
            entity.Property(e => e.FuntionLevel).HasMaxLength(50);
            entity.Property(e => e.FuntionName).HasMaxLength(255);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogGender>(entity =>
        {
            entity.ToTable("CatalogGender");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.GenderName).HasMaxLength(150);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogGetInforEnterprise>(entity =>
        {
            entity.ToTable("CatalogGetInforEnterprise");

            entity.Property(e => e.IsRealName).HasDefaultValue(true);
            entity.Property(e => e.LinkInfo).HasMaxLength(512);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogGoldenRatio>(entity =>
        {
            entity.HasKey(e => e.CodeGoldenRatio);

            entity.ToTable("CatalogGoldenRatio");

            entity.Property(e => e.CodeGoldenRatio).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameGoldenRatio).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogGroupArea>(entity =>
        {
            entity.HasKey(e => e.CodeGroupArea);

            entity.ToTable("CatalogGroupArea");

            entity.Property(e => e.CodeGroupArea).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameGroupArea).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogGroupConstruction>(entity =>
        {
            entity.HasKey(e => e.GrpCode);

            entity.ToTable("CatalogGroupConstruction");

            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(250);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogGroupContract>(entity =>
        {
            entity.HasKey(e => e.GrpCode);

            entity.ToTable("CatalogGroupContract");

            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(250);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogGroupContract1603>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CatalogGroupContract1603");

            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(250);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogGroupObj>(entity =>
        {
            entity.HasKey(e => e.CodeGroupObj);

            entity.ToTable("CatalogGroupObj");

            entity.Property(e => e.CodeGroupObj).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameGroupObj).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogGroupProduct>(entity =>
        {
            entity.HasKey(e => e.GroupCode).HasName("PK_CategoryGroupProduct");

            entity.ToTable("CatalogGroupProduct");

            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Note).HasMaxLength(250);
        });

        modelBuilder.Entity<CatalogGroupProject>(entity =>
        {
            entity.HasKey(e => e.GrpCode);

            entity.ToTable("CatalogGroupProject");

            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(250);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogGroupProject1603>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CatalogGroupProject1603");

            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(250);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogImageProduct>(entity =>
        {
            entity.ToTable("CatalogImageProduct");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeProduct).HasMaxLength(100);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.ImageName).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(150);
            entity.Property(e => e.PathImage).HasMaxLength(1024);
            entity.Property(e => e.PathLinkLocal).HasMaxLength(255);
            entity.Property(e => e.TypeImgDoc).HasMaxLength(30);
            entity.Property(e => e.ViewFile).HasMaxLength(30);
        });

        modelBuilder.Entity<CatalogImpExpReason>(entity =>
        {
            entity.HasKey(e => e.CodeReason).HasName("PK_ImpExpReason");

            entity.ToTable("CatalogImpExpReason");

            entity.Property(e => e.CodeReason).HasMaxLength(50);
            entity.Property(e => e.DataTypeUse).HasMaxLength(255);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IsSales).HasDefaultValue(true);
            entity.Property(e => e.MethodOfPayments).HasMaxLength(50);
            entity.Property(e => e.NameReason).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.TypeReason).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogInfoSendMail>(entity =>
        {
            entity.ToTable("CatalogInfoSendMail");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AddressMailSend).HasMaxLength(50);
            entity.Property(e => e.EmailSubject).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.MailServer).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PasswordEmail).HasMaxLength(50);
            entity.Property(e => e.PortMail).HasMaxLength(50);
            entity.Property(e => e.UserNameEmail).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogInformationEinvoiceBkav>(entity =>
        {
            entity.ToTable("CatalogInformationEInvoiceBkav");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InvPartnerGuid)
                .HasMaxLength(50)
                .HasColumnName("InvPartnerGUID");
            entity.Property(e => e.InvPartnerToken).HasMaxLength(255);
            entity.Property(e => e.InvoiceForm).HasMaxLength(50);
            entity.Property(e => e.InvoiceSerial).HasMaxLength(50);
            entity.Property(e => e.LinkService).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.PartnerGuid).HasColumnName("PartnerGUID");
            entity.Property(e => e.PartnerToken).HasMaxLength(250);
            entity.Property(e => e.PasswordApi).HasMaxLength(250);
            entity.Property(e => e.TaxCode).HasMaxLength(20);
            entity.Property(e => e.UrlInvInput).HasMaxLength(512);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogInvoiceInfo>(entity =>
        {
            entity.ToTable("CatalogInvoiceInfo");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AppKey).HasMaxLength(50);
            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.InvForm).HasMaxLength(50);
            entity.Property(e => e.InvSymbol).HasMaxLength(50);
            entity.Property(e => e.InvTemplate).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PartnerGuid)
                .HasMaxLength(255)
                .HasColumnName("PartnerGUID");
            entity.Property(e => e.PartnerToken).HasMaxLength(50);
            entity.Property(e => e.PasswordAc)
                .HasMaxLength(50)
                .HasColumnName("PasswordAC");
            entity.Property(e => e.PasswordApi).HasMaxLength(50);
            entity.Property(e => e.TaxCode).HasMaxLength(50);
            entity.Property(e => e.UrlApi).HasMaxLength(255);
            entity.Property(e => e.UrlBusiness).HasMaxLength(255);
            entity.Property(e => e.UrlPortal).HasMaxLength(255);
            entity.Property(e => e.UserAc)
                .HasMaxLength(50)
                .HasColumnName("UserAC");
            entity.Property(e => e.UserApi).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogInvoiceSupplier>(entity =>
        {
            entity.ToTable("CatalogInvoiceSupplier");

            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.SupplierCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogLocationPublishInv>(entity =>
        {
            entity.ToTable("CatalogLocationPublishInv");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LoacationName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Taxcode).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogManufacturingStage>(entity =>
        {
            entity.HasKey(e => e.StageCode);

            entity.ToTable("CatalogManufacturingStage", tb => tb.HasTrigger("UpdateStageCode"));

            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.StageName).HasMaxLength(250);
            entity.Property(e => e.StageType).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogMemberRating>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.FromMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.RatingCode).HasMaxLength(50);
            entity.Property(e => e.RatingName).HasMaxLength(150);
            entity.Property(e => e.ToMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.WithService).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogMethodOfPayment>(entity =>
        {
            entity.HasKey(e => e.MethodOfPaymentsCode);

            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.TypePayments).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogModeType>(entity =>
        {
            entity.ToTable("CatalogModeType");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeModeType).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameModeType).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogMonth>(entity =>
        {
            entity.ToTable("CatalogMonth");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeMonth).HasMaxLength(50);
            entity.Property(e => e.NameMonth).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogObject>(entity =>
        {
            entity.HasKey(e => e.ObjCode);

            entity.ToTable("CatalogObject", tb => tb.HasTrigger("UpdateObjectCode"));

            entity.Property(e => e.ObjCode).HasMaxLength(50);
            entity.Property(e => e.AccName).HasMaxLength(50);
            entity.Property(e => e.AccPosition).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(50);
            entity.Property(e => e.AccountNumber).HasMaxLength(30);
            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.AreaName).HasMaxLength(150);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.BusinessRegistrationNumber).HasMaxLength(150);
            entity.Property(e => e.Buyer).HasMaxLength(50);
            entity.Property(e => e.CitizenId).HasColumnName("CitizenID");
            entity.Property(e => e.CitizenIdnumber)
                .HasMaxLength(30)
                .HasColumnName("CitizenIDNumber");
            entity.Property(e => e.CodeManager).HasMaxLength(50);
            entity.Property(e => e.CodeOther).HasMaxLength(50);
            entity.Property(e => e.CodeRoom).HasMaxLength(50);
            entity.Property(e => e.CodeUnitManager).HasMaxLength(50);
            entity.Property(e => e.ContractNumber).HasMaxLength(70);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(30);
            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitHeadShops).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitLetterOfGuarantee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitMortgage).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DirectorName).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FacebookName).HasMaxLength(150);
            entity.Property(e => e.GrantedBy).HasMaxLength(150);
            entity.Property(e => e.GrpAreaCode).HasMaxLength(50);
            entity.Property(e => e.GrpAreaName).HasMaxLength(50);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(150);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LevelDiscount).HasMaxLength(50);
            entity.Property(e => e.MemberRate).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.MyCitizenId).HasColumnName("MyCitizenID");
            entity.Property(e => e.MyDob)
                .HasColumnType("smalldatetime")
                .HasColumnName("MyDOB");
            entity.Property(e => e.MyGrantedBy).HasMaxLength(150);
            entity.Property(e => e.MyObjAddress).HasMaxLength(255);
            entity.Property(e => e.MyObjName).HasMaxLength(150);
            entity.Property(e => e.MyPhoneNumber).HasMaxLength(50);
            entity.Property(e => e.MyRangeDate).HasColumnType("smalldatetime");
            entity.Property(e => e.MyRelationship).HasMaxLength(150);
            entity.Property(e => e.NameManager).HasMaxLength(150);
            entity.Property(e => e.NameRoom).HasMaxLength(150);
            entity.Property(e => e.NameUnitManager).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ObjAddress).HasMaxLength(255);
            entity.Property(e => e.ObjJob).HasMaxLength(150);
            entity.Property(e => e.ObjName).HasMaxLength(255);
            entity.Property(e => e.ObjSex).HasMaxLength(20);
            entity.Property(e => e.ObjSource).HasMaxLength(20);
            entity.Property(e => e.PermanentAddress).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(150);
            entity.Property(e => e.Position).HasMaxLength(50);
            entity.Property(e => e.RangeDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ShortAddress).HasMaxLength(255);
            entity.Property(e => e.ShortName).HasMaxLength(255);
            entity.Property(e => e.TaxCode).HasMaxLength(30);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.ZaloName).HasMaxLength(150);
        });

        modelBuilder.Entity<CatalogObject1503>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CatalogObject1503");

            entity.Property(e => e.AccName).HasMaxLength(50);
            entity.Property(e => e.AccPosition).HasMaxLength(50);
            entity.Property(e => e.AccountNumber).HasMaxLength(30);
            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.AreaName).HasMaxLength(150);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.BusinessRegistrationNumber).HasMaxLength(150);
            entity.Property(e => e.Buyer).HasMaxLength(50);
            entity.Property(e => e.CitizenId).HasColumnName("CitizenID");
            entity.Property(e => e.CitizenIdnumber)
                .HasMaxLength(30)
                .HasColumnName("CitizenIDNumber");
            entity.Property(e => e.CodeManager).HasMaxLength(50);
            entity.Property(e => e.CodeOther).HasMaxLength(50);
            entity.Property(e => e.CodeRoom).HasMaxLength(50);
            entity.Property(e => e.CodeUnitManager).HasMaxLength(50);
            entity.Property(e => e.ContractNumber).HasMaxLength(70);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(30);
            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitHeadShops).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitLetterOfGuarantee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitMortgage).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DirectorName).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FacebookName).HasMaxLength(150);
            entity.Property(e => e.GrantedBy).HasMaxLength(150);
            entity.Property(e => e.GrpAreaCode).HasMaxLength(50);
            entity.Property(e => e.GrpAreaName).HasMaxLength(50);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(150);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LevelDiscount).HasMaxLength(50);
            entity.Property(e => e.MemberRate).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.MyCitizenId).HasColumnName("MyCitizenID");
            entity.Property(e => e.MyDob)
                .HasColumnType("smalldatetime")
                .HasColumnName("MyDOB");
            entity.Property(e => e.MyGrantedBy).HasMaxLength(150);
            entity.Property(e => e.MyObjAddress).HasMaxLength(255);
            entity.Property(e => e.MyObjName).HasMaxLength(150);
            entity.Property(e => e.MyPhoneNumber).HasMaxLength(50);
            entity.Property(e => e.MyRangeDate).HasColumnType("smalldatetime");
            entity.Property(e => e.MyRelationship).HasMaxLength(150);
            entity.Property(e => e.NameManager).HasMaxLength(150);
            entity.Property(e => e.NameRoom).HasMaxLength(150);
            entity.Property(e => e.NameUnitManager).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ObjAddress).HasMaxLength(255);
            entity.Property(e => e.ObjCode).HasMaxLength(50);
            entity.Property(e => e.ObjJob).HasMaxLength(150);
            entity.Property(e => e.ObjName).HasMaxLength(255);
            entity.Property(e => e.ObjSex).HasMaxLength(20);
            entity.Property(e => e.PermanentAddress).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(150);
            entity.Property(e => e.Position).HasMaxLength(50);
            entity.Property(e => e.RangeDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ShortAddress).HasMaxLength(255);
            entity.Property(e => e.ShortName).HasMaxLength(255);
            entity.Property(e => e.TaxCode).HasMaxLength(30);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.ZaloName).HasMaxLength(150);
        });

        modelBuilder.Entity<CatalogPrinterName>(entity =>
        {
            entity.ToTable("CatalogPrinterName");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Hieght).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(150);
            entity.Property(e => e.PrintName).HasMaxLength(150);
            entity.Property(e => e.Witdh).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogProduct>(entity =>
        {
            entity.HasKey(e => e.ProductCode).HasName("PK_Products");

            entity.ToTable("CatalogProduct", tb => tb.HasTrigger("UpdateProductCode"));

            entity.HasIndex(e => e.ProductName, "IX_CatalogProduct_ProductName").HasFillFactor(90);

            entity.HasIndex(e => e.ProductCode, "Idx_CataProduct")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.AccCostOfCapital).HasMaxLength(20);
            entity.Property(e => e.AccMaterial).HasMaxLength(20);
            entity.Property(e => e.AccRevenue).HasMaxLength(20);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AddressSupplier).HasMaxLength(255);
            entity.Property(e => e.BarCode).HasMaxLength(250);
            entity.Property(e => e.Brand).HasMaxLength(255);
            entity.Property(e => e.CodeAuthor).HasMaxLength(50);
            entity.Property(e => e.CodeFiveElements).HasMaxLength(50);
            entity.Property(e => e.CodeIsbn)
                .HasMaxLength(50)
                .HasColumnName("CodeISBN");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CodeWarehose).HasMaxLength(50);
            entity.Property(e => e.ColorCode).HasMaxLength(20);
            entity.Property(e => e.ColorName).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.GenderName).HasMaxLength(150);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Material).HasMaxLength(50);
            entity.Property(e => e.MaterialCode).HasMaxLength(50);
            entity.Property(e => e.MaterialName).HasMaxLength(150);
            entity.Property(e => e.NameAuthor).HasMaxLength(50);
            entity.Property(e => e.NameFiveElements).HasMaxLength(150);
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.NameWarehose).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Pictures).HasMaxLength(255);
            entity.Property(e => e.ProductCodeFts).HasMaxLength(255);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.PublishingCode).HasMaxLength(50);
            entity.Property(e => e.PublishingName).HasMaxLength(250);
            entity.Property(e => e.QualityTeamCode).HasMaxLength(50);
            entity.Property(e => e.QualityTeamName).HasMaxLength(150);
            entity.Property(e => e.Reprinted).HasMaxLength(50);
            entity.Property(e => e.ShortAddressSupplier).HasMaxLength(255);
            entity.Property(e => e.ShortNameSupplier).HasMaxLength(255);
            entity.Property(e => e.SizeCode).HasMaxLength(50);
            entity.Property(e => e.SizeName).HasMaxLength(150);
            entity.Property(e => e.Specifications).HasMaxLength(50);
            entity.Property(e => e.Trademark).HasMaxLength(50);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.TypeVat).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(20);
            entity.Property(e => e.UnitPsc).HasMaxLength(20);
            entity.Property(e => e.Warranty).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogProductAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CatalogProductALL");

            entity.Property(e => e.AccCostOfCapital).HasMaxLength(20);
            entity.Property(e => e.AccMaterial).HasMaxLength(20);
            entity.Property(e => e.AccRevenue).HasMaxLength(20);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.Barcode).HasMaxLength(50);
            entity.Property(e => e.Brand).HasMaxLength(255);
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(4);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(1);
            entity.Property(e => e.Pictures).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductCodeFts).HasMaxLength(255);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.TypeVat).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(20);
            entity.Property(e => e.UnitPsc).HasMaxLength(20);
            entity.Property(e => e.WarehoseData).HasMaxLength(2);
        });

        modelBuilder.Entity<CatalogProductExist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CatalogProductExists");

            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.TypeVat).HasMaxLength(255);
            entity.Property(e => e.UnitPsc).HasMaxLength(20);
        });

        modelBuilder.Entity<CatalogProductMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CatalogMaterial");

            entity.ToTable("CatalogProductMaterial");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.MaterialCode).HasMaxLength(50);
            entity.Property(e => e.MaterialName).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogProductQualityTeam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CatalogQualityTeam");

            entity.ToTable("CatalogProductQualityTeam");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.QualityTeamCode).HasMaxLength(50);
            entity.Property(e => e.QualityTeamName).HasMaxLength(150);
        });

        modelBuilder.Entity<CatalogProductSizeGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CatalogSizeGroup");

            entity.ToTable("CatalogProductSizeGroup");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.SizeCode).HasMaxLength(50);
            entity.Property(e => e.SizeName).HasMaxLength(150);
        });

        modelBuilder.Entity<CatalogProductType>(entity =>
        {
            entity.HasKey(e => e.ProductTypeCode);

            entity.ToTable("CatalogProductType");

            entity.Property(e => e.ProductTypeCode).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductTypeName).HasMaxLength(255);
            entity.Property(e => e.SignType).HasMaxLength(20);
        });

        modelBuilder.Entity<CatalogProductionActivitie>(entity =>
        {
            entity.HasKey(e => e.ProductActivCode);

            entity.ToTable("CatalogProductionActivitie");

            entity.Property(e => e.ProductActivCode).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductActivName).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogProductionActivitie1603>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CatalogProductionActivitie1603");

            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductActivCode).HasMaxLength(50);
            entity.Property(e => e.ProductActivName).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogProductionShift>(entity =>
        {
            entity.HasKey(e => e.CodeShift);

            entity.ToTable("CatalogProductionShift");

            entity.Property(e => e.CodeShift).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameShift).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogProgramPromotion>(entity =>
        {
            entity.HasKey(e => e.FormOfPromotionCode);

            entity.ToTable("CatalogProgramPromotion");

            entity.Property(e => e.FormOfPromotionCode).HasMaxLength(50);
            entity.Property(e => e.FormOfPromotionName).HasMaxLength(255);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogProject>(entity =>
        {
            entity.HasKey(e => e.ProjectCode);

            entity.ToTable("CatalogProject");

            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.OwnerOfProjectCode).HasMaxLength(50);
            entity.Property(e => e.OwnerOfProjectName).HasMaxLength(255);
            entity.Property(e => e.ProductActivCode).HasMaxLength(50);
            entity.Property(e => e.ProductActivName).HasMaxLength(150);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ValueProject).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<CatalogProject1603>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CatalogProject1603");

            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.OwnerOfProjectCode).HasMaxLength(50);
            entity.Property(e => e.OwnerOfProjectName).HasMaxLength(255);
            entity.Property(e => e.ProductActivCode).HasMaxLength(50);
            entity.Property(e => e.ProductActivName).HasMaxLength(150);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ValueProject).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<CatalogProvince>(entity =>
        {
            entity.HasKey(e => e.CodeProvince);

            entity.ToTable("CatalogProvince");

            entity.Property(e => e.CodeProvince).HasMaxLength(50);
            entity.Property(e => e.CodeArea).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameArea).HasMaxLength(255);
            entity.Property(e => e.NameProvince).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogPurposeOfUse>(entity =>
        {
            entity.HasKey(e => e.PurposeCode);

            entity.ToTable("CatalogPurposeOfUse");

            entity.Property(e => e.PurposeCode).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PurposeName).HasMaxLength(150);
        });

        modelBuilder.Entity<CatalogRetailPriceVolatility>(entity =>
        {
            entity.ToTable("CatalogRetailPriceVolatility");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogRevExp>(entity =>
        {
            entity.HasKey(e => new { e.CodeRevExp, e.TypeRevExp });

            entity.ToTable("CatalogRevExp");

            entity.Property(e => e.CodeRevExp).HasMaxLength(50);
            entity.Property(e => e.TypeRevExp).HasMaxLength(20);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameRevExp).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogRevExp1603>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CatalogRevExp1603");

            entity.Property(e => e.CodeRevExp).HasMaxLength(50);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameRevExp).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.TypeRevExp).HasMaxLength(20);
        });

        modelBuilder.Entity<CatalogRoom>(entity =>
        {
            entity.HasKey(e => e.CodeRoom);

            entity.ToTable("CatalogRoom");

            entity.Property(e => e.CodeRoom).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameRoom).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogSalaryAction>(entity =>
        {
            entity.HasKey(e => e.CodeSalaryAction);

            entity.ToTable("CatalogSalaryAction");

            entity.Property(e => e.CodeSalaryAction).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameSalaryAction).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.TypeAction).HasMaxLength(30);
        });

        modelBuilder.Entity<CatalogSalaryType>(entity =>
        {
            entity.HasKey(e => e.CodeSalaryType);

            entity.ToTable("CatalogSalaryType");

            entity.Property(e => e.CodeSalaryType).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameSalaryType).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogSalesChannel>(entity =>
        {
            entity.ToTable("CatalogSalesChannel");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogScale>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ScaleCode).HasMaxLength(50);
            entity.Property(e => e.ScaleName).HasMaxLength(150);
        });

        modelBuilder.Entity<CatalogSelecttedPrint>(entity =>
        {
            entity.ToTable("CatalogSelecttedPrint");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CatalogName).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.ValueSelectted).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogServiceProduct>(entity =>
        {
            entity.ToTable("CatalogServiceProduct");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ServiceCode).HasMaxLength(50);
            entity.Property(e => e.ServiceName).HasMaxLength(150);
        });

        modelBuilder.Entity<CatalogShippingMethod>(entity =>
        {
            entity.HasKey(e => e.ShippingMethodsCode);

            entity.Property(e => e.ShippingMethodsCode).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ShippingMethodsName).HasMaxLength(250);
        });

        modelBuilder.Entity<CatalogSignTimeSheet>(entity =>
        {
            entity.ToTable("CatalogSignTimeSheet");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.SignTimeSheet).HasMaxLength(10);
        });

        modelBuilder.Entity<CatalogStatusShopingCart>(entity =>
        {
            entity.HasKey(e => e.CodeStatus);

            entity.ToTable("CatalogStatusShopingCart");

            entity.Property(e => e.CodeStatus).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameStatus).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogTableCommon>(entity =>
        {
            entity.ToTable("CatalogTableCommon");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameTable).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogTemplateExcel>(entity =>
        {
            entity.HasKey(e => e.TemplateExcelCode);

            entity.ToTable("CatalogTemplateExcel");

            entity.Property(e => e.TemplateExcelCode).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.TemplateExcelName).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogThickness>(entity =>
        {
            entity.HasKey(e => e.CodeThickness);

            entity.ToTable("CatalogThickness");

            entity.Property(e => e.CodeThickness).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameThickness).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogTone>(entity =>
        {
            entity.HasKey(e => e.CodeTone);

            entity.ToTable("CatalogTone");

            entity.Property(e => e.CodeTone).HasMaxLength(50);
            entity.Property(e => e.ColorHex).HasMaxLength(50);
            entity.Property(e => e.ColorName).HasMaxLength(50);
            entity.Property(e => e.ColorRgb)
                .HasMaxLength(50)
                .HasColumnName("ColorRGB");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameTone).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogTool>(entity =>
        {
            entity.HasKey(e => e.ToolsCode);

            entity.Property(e => e.ToolsCode).HasMaxLength(50);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DepMeCode).HasMaxLength(50);
            entity.Property(e => e.DepMeName).HasMaxLength(250);
            entity.Property(e => e.DepreciationEndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Identifier).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.Origin).HasMaxLength(100);
            entity.Property(e => e.OriginCode).HasMaxLength(50);
            entity.Property(e => e.OriginName).HasMaxLength(250);
            entity.Property(e => e.OriginalPrice).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PurchaseDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PurposeCode).HasMaxLength(50);
            entity.Property(e => e.PurposeName).HasMaxLength(250);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.ToolsGroupCode).HasMaxLength(50);
            entity.Property(e => e.ToolsGroupName).HasMaxLength(250);
            entity.Property(e => e.ToolsName).HasMaxLength(250);
            entity.Property(e => e.ToolsSourceCode).HasMaxLength(50);
            entity.Property(e => e.ToolsSourceName).HasMaxLength(250);
            entity.Property(e => e.ToolsValues).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Units).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogTypeOfMatarial>(entity =>
        {
            entity.HasKey(e => e.TypeCode);

            entity.ToTable("CatalogTypeOfMatarial");

            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.TypeName).HasMaxLength(512);
        });

        modelBuilder.Entity<CatalogTypeOfTaxRate>(entity =>
        {
            entity.HasKey(e => e.TypeCode);

            entity.ToTable("CatalogTypeOfTaxRate");

            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.TypeName).HasMaxLength(512);
        });

        modelBuilder.Entity<CatalogTypeReport>(entity =>
        {
            entity.ToTable("CatalogTypeReport");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Subsystem).HasMaxLength(50);
            entity.Property(e => e.TypeNameReport).HasMaxLength(50);
            entity.Property(e => e.TypeReport).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogUnit>(entity =>
        {
            entity.HasKey(e => new { e.IdUnitOk, e.CodeUnit });

            entity.ToTable("CatalogUnit");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.DirectorName).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.NameUnit).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PositionDir).HasMaxLength(100);
            entity.Property(e => e.Symbol).HasMaxLength(20);
            entity.Property(e => e.Taxcode).HasMaxLength(20);
            entity.Property(e => e.Vat).HasColumnName("VAT");
        });

        modelBuilder.Entity<CatalogUnitPc>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogUserFuntion>(entity =>
        {
            entity.ToTable("CatalogUserFuntion");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UserFuntionCode).HasMaxLength(50);
            entity.Property(e => e.UserFuntionName).HasMaxLength(512);
        });

        modelBuilder.Entity<CatalogVatRateType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CatalogVatRateType");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.TypeVatRate).HasMaxLength(50);
            entity.Property(e => e.VatRateTypeCode).HasMaxLength(50);
            entity.Property(e => e.VatRateTypeName).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogVehicle>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CitizenIdentification).HasMaxLength(50);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DateOfIssue).HasColumnType("smalldatetime");
            entity.Property(e => e.DriverName).HasMaxLength(150);
            entity.Property(e => e.DrivingLicense).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PlaceOfIssue).HasMaxLength(150);
            entity.Property(e => e.Vehicles).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogVillage>(entity =>
        {
            entity.HasKey(e => e.CodeVillage);

            entity.ToTable("CatalogVillage");

            entity.Property(e => e.CodeVillage).HasMaxLength(50);
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CodeObj).HasMaxLength(50);
            entity.Property(e => e.CodeWards).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameObj).HasMaxLength(255);
            entity.Property(e => e.NameVillage).HasMaxLength(255);
            entity.Property(e => e.NameWards).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogVoucherNumber>(entity =>
        {
            entity.ToTable("CatalogVoucherNumber");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreditSide).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InheritFrom).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ReasonUse).HasMaxLength(255);
            entity.Property(e => e.SignVoucher).HasMaxLength(50);
            entity.Property(e => e.TypeObject).HasMaxLength(50);
            entity.Property(e => e.VoucherName).HasMaxLength(100);
        });

        modelBuilder.Entity<CatalogVouchersInherit>(entity =>
        {
            entity.ToTable("CatalogVouchersInherit");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DataName).HasMaxLength(250);
            entity.Property(e => e.DataNameDes).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DataTypeDes).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonCodeDes).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(250);
            entity.Property(e => e.ReasonNameDes).HasMaxLength(255);
        });

        modelBuilder.Entity<CatalogVouchersTrasfer>(entity =>
        {
            entity.ToTable("CatalogVouchersTrasfer");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CatalogName).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.ValueSelectted).HasMaxLength(50);
        });

        modelBuilder.Entity<CatalogWard>(entity =>
        {
            entity.HasKey(e => e.CodeWards);

            entity.Property(e => e.CodeWards).HasMaxLength(50);
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CodeDistrict).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameDistrict).HasMaxLength(255);
            entity.Property(e => e.NameWards).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__categori__D54EE9B4A92D2A3B");

            entity.ToTable("categories", "production");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("category_name");
        });

        modelBuilder.Entity<CategoryWarehose>(entity =>
        {
            entity.HasKey(e => e.CodeWarehose);

            entity.ToTable("CategoryWarehose", tb => tb.HasTrigger("TrigUpdateWarehoseCode"));

            entity.Property(e => e.CodeWarehose).HasMaxLength(50);
            entity.Property(e => e.AddressWarehose).HasMaxLength(250);
            entity.Property(e => e.BankCode).HasMaxLength(50);
            entity.Property(e => e.BankOfAccount).HasMaxLength(50);
            entity.Property(e => e.BankOfName).HasMaxLength(250);
            entity.Property(e => e.Branch).HasMaxLength(150);
            entity.Property(e => e.CodeInv).HasMaxLength(50);
            entity.Property(e => e.CodeStocker).HasMaxLength(50);
            entity.Property(e => e.CodeUnit).HasDefaultValue(100);
            entity.Property(e => e.FristCode).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.NameInv).HasMaxLength(250);
            entity.Property(e => e.NameStocker).HasMaxLength(250);
            entity.Property(e => e.NameWarehose).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.ServiceProfile).HasMaxLength(50);
        });

        modelBuilder.Entity<CategoryWarehosesave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CategoryWarehosesave");

            entity.Property(e => e.AddressWarehose).HasMaxLength(250);
            entity.Property(e => e.Branch).HasMaxLength(150);
            entity.Property(e => e.CodeInv).HasMaxLength(50);
            entity.Property(e => e.CodeStocker).HasMaxLength(50);
            entity.Property(e => e.CodeWarehose).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.NameInv).HasMaxLength(250);
            entity.Property(e => e.NameStocker).HasMaxLength(250);
            entity.Property(e => e.NameWarehose).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<ContractInforPlu>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ContentsTransaction).HasMaxLength(512);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberContract).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ValueTransaction).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<ContractOfCreditLine>(entity =>
        {
            entity.ToTable("ContractOfCreditLine");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ContractContents).HasMaxLength(255);
            entity.Property(e => e.ContractNumber).HasMaxLength(50);
            entity.Property(e => e.ContractValue).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.PurposeCode).HasMaxLength(50);
            entity.Property(e => e.PurposeName).HasMaxLength(150);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__customer__CD65CB855AAFFCD6");

            entity.ToTable("customers", "sales");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.State)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("street");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("zip_code");
        });

        modelBuilder.Entity<DataAdminAccountTransfer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DataAdminAccountTransfer");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.CreditObjectCode).HasMaxLength(50);
            entity.Property(e => e.CreditObjectName).HasMaxLength(250);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(50);
            entity.Property(e => e.DebitObjectName).HasMaxLength(250);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(250);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(250);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<DataAdminAllotmentAssetTool>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DataAdminAllotmentAssetTool");

            entity.Property(e => e.AccumulatedDepreciation).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AllocationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.AllocationDateBegin).HasColumnType("smalldatetime");
            entity.Property(e => e.AllocationDateEnd).HasColumnType("smalldatetime");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountRules).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.CreditObjectCode).HasMaxLength(50);
            entity.Property(e => e.CreditObjectName).HasMaxLength(250);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(50);
            entity.Property(e => e.DebitObjectName).HasMaxLength(250);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.DepreciationCalueForThisPeriod).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DepreciationCalueForThisPeriodRules).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DepreciationValuePerMonth).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(250);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RemainingAmortization).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(250);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.ValueNotValid).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ValuePerMonthRules).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<DataBusinessResultsLastPeriod>(entity =>
        {
            entity.ToTable("DataBusinessResultsLastPeriod");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.UserCode).HasMaxLength(20);
        });

        modelBuilder.Entity<DataCalculatingCostOfGoodsSold>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DataCalculatingCostOfGoodsSold");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<DataContentsExportManu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataContentsExportManu");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BatchWarehose).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<DataContentsExportSell>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataContentsExportSell");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BatchWarehose).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(250);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<DataCostAllotmentDeclaration>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataCostAllotmentDeclaration");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DataCostOfGoodsTransfer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DataCostOfGoodsTransfer");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<DataDebtsAccordingToInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataDebtsAccordingToInvoices");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DataExportManu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataExportManu");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BatchWarehose).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<DataField>(entity =>
        {
            entity.ToTable("DataField");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BackColor).HasMaxLength(50);
            entity.Property(e => e.CellActivation)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CellClickAction).HasMaxLength(100);
            entity.Property(e => e.ColumnName).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DisplayText).HasMaxLength(150);
            entity.Property(e => e.FomatSum).HasMaxLength(50);
            entity.Property(e => e.ForeColor).HasMaxLength(50);
            entity.Property(e => e.FormatText).HasMaxLength(50);
            entity.Property(e => e.Formula).HasMaxLength(512);
            entity.Property(e => e.GroupKey).HasMaxLength(50);
            entity.Property(e => e.GroupText).HasMaxLength(50);
            entity.Property(e => e.LoaiPhieu).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(250);
            entity.Property(e => e.NullText).HasMaxLength(50);
            entity.Property(e => e.TabStop).HasDefaultValue(true);
            entity.Property(e => e.TableName).HasMaxLength(50);
            entity.Property(e => e.TextAlign).HasMaxLength(50);
            entity.Property(e => e.ViewColor).HasMaxLength(50);
        });

        modelBuilder.Entity<DataFieldUser>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BackColor).HasMaxLength(50);
            entity.Property(e => e.CellActivation)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CellClickAction).HasMaxLength(100);
            entity.Property(e => e.ColumnName).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DisplayText).HasMaxLength(150);
            entity.Property(e => e.FomatSum).HasMaxLength(50);
            entity.Property(e => e.ForeColor).HasMaxLength(50);
            entity.Property(e => e.FormatText).HasMaxLength(50);
            entity.Property(e => e.Formula).HasMaxLength(512);
            entity.Property(e => e.GroupKey).HasMaxLength(50);
            entity.Property(e => e.GroupText).HasMaxLength(50);
            entity.Property(e => e.LoaiPhieu).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(250);
            entity.Property(e => e.NullText).HasMaxLength(50);
            entity.Property(e => e.TabStop).HasDefaultValue(true);
            entity.Property(e => e.TableName).HasMaxLength(50);
            entity.Property(e => e.TextAlign).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.ViewColor).HasMaxLength(50);
        });

        modelBuilder.Entity<DataImpFinish>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataImpFinish");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContents).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(20);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.StageName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<DataInvernExpManu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataInvernExpManu");
        });

        modelBuilder.Entity<DataInvernImpFin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataInvernImpFin");
        });

        modelBuilder.Entity<DataListVouchersExportManu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataListVouchersExportManu");

            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<DataManufacturingStage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataManufacturingStage");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.StageName).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DataProducingProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataProducingProcess");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.Stagename).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
        });

        modelBuilder.Entity<DataProducingProcessSortMetal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataProducingProcessSortMetal");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.Stagename).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
        });

        modelBuilder.Entity<DataSelect>(entity =>
        {
            entity.ToTable("DataSelect");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Caption).HasMaxLength(50);
            entity.Property(e => e.Comfirm).HasMaxLength(50);
            entity.Property(e => e.FileLayout).HasMaxLength(50);
            entity.Property(e => e.GroupByField).HasMaxLength(255);
            entity.Property(e => e.OrderByField).HasMaxLength(255);
            entity.Property(e => e.StoreName).HasMaxLength(255);
            entity.Property(e => e.TableName).HasMaxLength(50);
            entity.Property(e => e.TypeDocument).HasMaxLength(50);
        });

        modelBuilder.Entity<DataStageResin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataStageResin");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.StageName).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<DataTracingVoucher>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataTracingVouchers");

            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.SmartType)
                .HasMaxLength(14)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DataTransBlanceAccouting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DataTransBlanceAccouting");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeUnit).HasMaxLength(20);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(250);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(250);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.OpeningCredit).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.OpeningDebit).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(250);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(250);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(250);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(20);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<DataTransBlanceMaterrial>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeUnit).HasMaxLength(20);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(250);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(250);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.OpeningCredit).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.OpeningDebit).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(250);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(250);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(250);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(20);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<DataTypeAndAccountSymbol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataTypeAndAccountSymbol");

            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
        });

        modelBuilder.Entity<DataUserLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataUserLogs");

            entity.Property(e => e.DateAction).HasColumnType("datetime");
            entity.Property(e => e.FunctionName).HasMaxLength(512);
            entity.Property(e => e.Notes).HasMaxLength(1024);
            entity.Property(e => e.TypeOrderOrCode).HasMaxLength(250);
            entity.Property(e => e.UserExc).HasMaxLength(50);
        });

        modelBuilder.Entity<DataWaitingForAllocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DataWaitingForAllocation");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<DeleteSalesSmartContentsDatum>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.ActualAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.IdSource).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProgramCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.Season).HasMaxLength(50);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VatType).HasMaxLength(250);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<DeleteSalesSmartDataAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DeleteSalesSmartDataAll");

            entity.Property(e => e.AccountingType).HasMaxLength(30);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountPayment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVoucher).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.Expr1).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Expr2).HasMaxLength(255);
            entity.Property(e => e.Expr3).HasMaxLength(50);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(150);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LevelDiscount).HasMaxLength(20);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.MoneyDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyReturnGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PointsMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(150);
            entity.Property(e => e.Season).HasMaxLength(50);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SubAmountPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<DeleteSalesSmartDatum>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountingType).HasMaxLength(30);
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountPayment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTransferred).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVoucher).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DeleteCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(150);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LevelDiscount).HasMaxLength(20);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(250)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.Location).HasMaxLength(150);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.MoneyDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyReturnGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PointsMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProgramCode).HasMaxLength(50);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(150);
            entity.Property(e => e.ShippingMethodsCode).HasMaxLength(50);
            entity.Property(e => e.ShippingMethodsName).HasMaxLength(255);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SubAmountPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<DeleteSalesSmartProductInventory>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.ToTable("DeleteSalesSmartProductInventory");

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<DeleteSmartContentsDatum>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountExciseTax).HasMaxLength(50);
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CostOfGoodsSold).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CostOfGoodsSold15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.CreditSideOut).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebitSideOut).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ExciseTaxRate).HasMaxLength(50);
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.IdSource).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumberContents).HasMaxLength(50);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.Season).HasMaxLength(150);
            entity.Property(e => e.ShipmentNumber).HasMaxLength(50);
            entity.Property(e => e.SignTransfer).HasMaxLength(50);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<DeleteSmartCostAllotment>(entity =>
        {
            entity.HasKey(e => new { e.IdAsc, e.IdContents });

            entity.ToTable("DeleteSmartCostAllotment");

            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AmountOfAllotment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditSide).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(50);
            entity.Property(e => e.IdData).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<DeleteSmartDataAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DeleteSmartDataAll");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CostOfGoodsSold).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CostOfGoodsSold15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.CreditSideOut).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DataTypeContents).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebitSideOut).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(50);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceNumberContents).HasMaxLength(50);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContents).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.SignTransfer).HasMaxLength(50);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<DeleteSmartDatum>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ComfirmVoucher).HasDefaultValue(false);
            entity.Property(e => e.ContractNo).HasMaxLength(100);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DeleteCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(50);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RoomCode).HasMaxLength(70);
            entity.Property(e => e.RoomName).HasMaxLength(70);
            entity.Property(e => e.ShippingMethodsCode).HasMaxLength(50);
            entity.Property(e => e.ShippingMethodsName).HasMaxLength(255);
            entity.Property(e => e.SignTransfer).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VehiclesName).HasMaxLength(75);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<DeleteSmartFileAttach>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc }).HasName("PK_DeleteSmartFileAttach_1");

            entity.ToTable("DeleteSmartFileAttach");

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FileNames).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.PathFile).HasMaxLength(255);
            entity.Property(e => e.Xem).HasMaxLength(50);
        });

        modelBuilder.Entity<DeleteSmartListOfTool>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AccumulatedDepreciation).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AllocationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CarryingAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RemainingAmortization).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<DeleteSmartVatTaxList>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.ToTable("DeleteSmartVatTaxList");

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ImportOrExport).HasMaxLength(50);
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceSign).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TaxCode).HasMaxLength(20);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<ExcelCatalogObject>(entity =>
        {
            entity.HasKey(e => e.ObjCode);

            entity.ToTable("ExcelCatalogObject");

            entity.Property(e => e.ObjCode).HasMaxLength(50);
            entity.Property(e => e.AccName).HasMaxLength(50);
            entity.Property(e => e.AccPosition).HasMaxLength(50);
            entity.Property(e => e.AccountNumber).HasMaxLength(30);
            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.AreaName).HasMaxLength(150);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.BusinessRegistrationNumber).HasMaxLength(150);
            entity.Property(e => e.Buyer).HasMaxLength(50);
            entity.Property(e => e.CitizenId).HasColumnName("CitizenID");
            entity.Property(e => e.CitizenIdnumber)
                .HasMaxLength(30)
                .HasColumnName("CitizenIDNumber");
            entity.Property(e => e.CodeManager).HasMaxLength(50);
            entity.Property(e => e.CodeOther).HasMaxLength(50);
            entity.Property(e => e.CodeRoom).HasMaxLength(50);
            entity.Property(e => e.CodeUnitManager).HasMaxLength(50);
            entity.Property(e => e.ContractNumber).HasMaxLength(70);
            entity.Property(e => e.CreateBy).HasMaxLength(150);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(30);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitHeadShops).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitLetterOfGuarantee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitMortgage).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DirectorName).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.GrantedBy).HasMaxLength(150);
            entity.Property(e => e.GrpAreaCode).HasMaxLength(50);
            entity.Property(e => e.GrpAreaName).HasMaxLength(50);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(150);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LevelDiscount).HasMaxLength(50);
            entity.Property(e => e.MyCitizenId).HasColumnName("MyCitizenID");
            entity.Property(e => e.MyDob)
                .HasColumnType("smalldatetime")
                .HasColumnName("MyDOB");
            entity.Property(e => e.MyGrantedBy).HasMaxLength(150);
            entity.Property(e => e.MyObjAddress).HasMaxLength(255);
            entity.Property(e => e.MyObjName).HasMaxLength(150);
            entity.Property(e => e.MyPhoneNumber).HasMaxLength(50);
            entity.Property(e => e.MyRangeDate).HasColumnType("smalldatetime");
            entity.Property(e => e.MyRelationship).HasMaxLength(150);
            entity.Property(e => e.NameManager).HasMaxLength(150);
            entity.Property(e => e.NameRoom).HasMaxLength(150);
            entity.Property(e => e.NameUnitManager).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberImport).HasMaxLength(150);
            entity.Property(e => e.ObjAddress).HasMaxLength(255);
            entity.Property(e => e.ObjJob).HasMaxLength(150);
            entity.Property(e => e.ObjName).HasMaxLength(255);
            entity.Property(e => e.ObjSex).HasMaxLength(20);
            entity.Property(e => e.PermanentAddress).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(150);
            entity.Property(e => e.Position).HasMaxLength(50);
            entity.Property(e => e.RangeDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TaxCode).HasMaxLength(30);
            entity.Property(e => e.TypeData).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
        });

        modelBuilder.Entity<ExcelCatalogProduct>(entity =>
        {
            entity.HasKey(e => e.ProductCode);

            entity.ToTable("ExcelCatalogProduct");

            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.AccCostOfCapital).HasMaxLength(20);
            entity.Property(e => e.AccMaterial).HasMaxLength(20);
            entity.Property(e => e.AccRevenue).HasMaxLength(20);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AddressSupplier).HasMaxLength(350);
            entity.Property(e => e.BarCode).HasMaxLength(250);
            entity.Property(e => e.Brand).HasMaxLength(255);
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CodeWarehose)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ColorCode).HasMaxLength(20);
            entity.Property(e => e.ColorName).HasMaxLength(50);
            entity.Property(e => e.CreateBy).HasMaxLength(150);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.GenderCode)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.GenderName)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.MaterialName)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.NameWarehose)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberImport).HasMaxLength(150);
            entity.Property(e => e.Origin).HasMaxLength(350);
            entity.Property(e => e.Pictures).HasMaxLength(255);
            entity.Property(e => e.ProductCodeFts).HasMaxLength(255);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.QualityTeamCode)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.QualityTeamName)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.ShortAddressSupplier).HasMaxLength(350);
            entity.Property(e => e.ShortNameSupplier).HasMaxLength(350);
            entity.Property(e => e.SizeCode)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.SizeName)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeData).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.TypeVat).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(20);
            entity.Property(e => e.UnitPsc).HasMaxLength(20);
        });

        modelBuilder.Entity<ExcelSmartDatum>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountExciseTax).HasMaxLength(50);
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.ComfirmVoucher).HasDefaultValue(false);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.ContractNo).HasMaxLength(100);
            entity.Property(e => e.CostOfGoodsSold).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CostOfGoodsSold15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.CreditSideOut).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebitSideOut).HasMaxLength(20);
            entity.Property(e => e.Delivered).HasDefaultValue(false);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Einvoice)
                .HasDefaultValue(false)
                .HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.ExciseTaxRate).HasMaxLength(50);
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(50);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceNumberContents).HasMaxLength(50);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.NotEnvironment).HasDefaultValue(false);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberImport).HasMaxLength(150);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.Pricing).HasDefaultValue(false);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Register).HasDefaultValue(false);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(70);
            entity.Property(e => e.RoomName).HasMaxLength(70);
            entity.Property(e => e.SaveTemp).HasDefaultValue(false);
            entity.Property(e => e.Season).HasMaxLength(150);
            entity.Property(e => e.ShipmentNumber).HasMaxLength(50);
            entity.Property(e => e.ShippingMethodsCode).HasMaxLength(50);
            entity.Property(e => e.ShippingMethodsName).HasMaxLength(255);
            entity.Property(e => e.SignTransfer).HasMaxLength(50);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeData).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VehiclesName).HasMaxLength(75);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<FtpInformation>(entity =>
        {
            entity.HasKey(e => e.CodeName);

            entity.ToTable("FtpInformation");

            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.Addressftp).HasMaxLength(250);
            entity.Property(e => e.DomainName).HasMaxLength(250);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IpAddress).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.Passwordftp).HasMaxLength(250);
            entity.Property(e => e.Port).HasMaxLength(50);
            entity.Property(e => e.UserNameftp).HasMaxLength(250);
        });

        modelBuilder.Entity<FundCreditContract>(entity =>
        {
            entity.ToTable("FundCreditContract");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AmountPaidPerMonth).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ContractName).HasMaxLength(250);
            entity.Property(e => e.ContractNumber).HasMaxLength(50);
            entity.Property(e => e.ContractNumberOld).HasMaxLength(50);
            entity.Property(e => e.ContractTypeCode).HasMaxLength(50);
            entity.Property(e => e.ContractTypeName).HasMaxLength(250);
            entity.Property(e => e.ContractValue).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreditProductCode).HasMaxLength(20);
            entity.Property(e => e.CreditProductName).HasMaxLength(100);
            entity.Property(e => e.DataName).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DateComfirm).HasColumnType("smalldatetime");
            entity.Property(e => e.DateDue).HasColumnType("smalldatetime");
            entity.Property(e => e.DateDueNew).HasColumnType("smalldatetime");
            entity.Property(e => e.DisbursementDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DistrictCode).HasMaxLength(50);
            entity.Property(e => e.DistrictName).HasMaxLength(150);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FormOfCapitalPayment).HasMaxLength(100);
            entity.Property(e => e.FormOfCapitalPaymentCode).HasMaxLength(100);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.HamletCode).HasMaxLength(50);
            entity.Property(e => e.HamletName).HasMaxLength(50);
            entity.Property(e => e.HouseholdType).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdDocument).HasMaxLength(100);
            entity.Property(e => e.IdSavingsBook).HasMaxLength(50);
            entity.Property(e => e.IndentureNo).HasMaxLength(50);
            entity.Property(e => e.InterePayMethCode).HasMaxLength(50);
            entity.Property(e => e.InterestPaymentMethod).HasMaxLength(100);
            entity.Property(e => e.MethodOfCalInterest).HasMaxLength(355);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.NumberOfVoucherAcc).HasMaxLength(100);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.PlaceOfCapitalDistri).HasMaxLength(250);
            entity.Property(e => e.PurposeCode).HasMaxLength(20);
            entity.Property(e => e.PurposeName).HasMaxLength(250);
            entity.Property(e => e.SavingsBookCode).HasMaxLength(50);
            entity.Property(e => e.SequentialCode).HasMaxLength(10);
            entity.Property(e => e.SequentialName).HasMaxLength(50);
            entity.Property(e => e.SettlementDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SignDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StatusName).HasMaxLength(50);
            entity.Property(e => e.SubordinateName).HasMaxLength(150);
            entity.Property(e => e.TransferBy).HasMaxLength(150);
            entity.Property(e => e.TransferDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VillageCode).HasMaxLength(50);
            entity.Property(e => e.VillageName).HasMaxLength(150);
            entity.Property(e => e.WardsCode).HasMaxLength(50);
            entity.Property(e => e.WardsName).HasMaxLength(150);
        });

        modelBuilder.Entity<ImageDocumentProduct>(entity =>
        {
            entity.ToTable("ImageDocumentProduct");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.FileNames).HasMaxLength(150);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PathLinkImage).HasMaxLength(512);
            entity.Property(e => e.PathLinkLocal).HasMaxLength(512);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.TypeImgDoc).HasMaxLength(50);
            entity.Property(e => e.ViewFile).HasMaxLength(50);
        });

        modelBuilder.Entity<InformationSerialPort>(entity =>
        {
            entity.ToTable("InformationSerialPort");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.MachineId).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PortName).HasMaxLength(50);
            entity.Property(e => e.ScaleCode).HasMaxLength(20);
            entity.Property(e => e.ScaleName).HasMaxLength(120);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<ListProductWithBarcode>(entity =>
        {
            entity.ToTable("ListProductWithBarcode");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Barcode).HasMaxLength(50);
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeVat).HasMaxLength(255);
            entity.Property(e => e.UnitPsc).HasMaxLength(20);
        });

        modelBuilder.Entity<ListViewConfig>(entity =>
        {
            entity.ToTable("ListViewConfig");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ComputerName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<Lock>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeMonth).HasMaxLength(50);
            entity.Property(e => e.LockType).HasMaxLength(50);
            entity.Property(e => e.NameMonth).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<MaterialRemaining>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MaterialRemaining_1");

            entity.ToTable("MaterialRemaining");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ShipmentNumber).HasMaxLength(50);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.ToTable("Menu");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.MenuCaption).HasMaxLength(255);
            entity.Property(e => e.MenuImage).HasMaxLength(100);
            entity.Property(e => e.MenuLevel).HasMaxLength(50);
            entity.Property(e => e.MenuName).HasMaxLength(50);
            entity.Property(e => e.MenuNote).HasMaxLength(255);
            entity.Property(e => e.MenuParameters).HasMaxLength(50);
            entity.Property(e => e.ParameterReport).HasMaxLength(50);
            entity.Property(e => e.ParentMenu).HasMaxLength(50);
            entity.Property(e => e.TableName).HasMaxLength(50);
        });

        modelBuilder.Entity<OpenAccounting>(entity =>
        {
            entity.ToTable("OpenAccounting");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.OpeningCredit).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.OpeningDebit).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<OptionPrintOrder>(entity =>
        {
            entity.ToTable("OptionPrintOrder");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.FileDoc).HasMaxLength(100);
            entity.Property(e => e.NameDoc).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.Prameters).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(250);
            entity.Property(e => e.TypeDoc).HasMaxLength(50);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__orders__465962298C3548AC");

            entity.ToTable("orders", "sales");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.OrderStatus).HasColumnName("order_status");
            entity.Property(e => e.RequiredDate).HasColumnName("required_date");
            entity.Property(e => e.ShippedDate).HasColumnName("shipped_date");
            entity.Property(e => e.StaffId).HasColumnName("staff_id");
            entity.Property(e => e.StoreId).HasColumnName("store_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__orders__customer__4B43C183");

            entity.HasOne(d => d.Staff).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__orders__staff_id__4D2C09F5");

            entity.HasOne(d => d.Store).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__orders__store_id__4C37E5BC");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ItemId }).HasName("PK__order_it__837942D420930D6F");

            entity.ToTable("order_items", "sales");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("discount");
            entity.Property(e => e.ListPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("list_price");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__order_ite__order__50FC9AD9");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__order_ite__produ__51F0BF12");
        });

        modelBuilder.Entity<ParameterReport>(entity =>
        {
            entity.ToTable("ParameterReport");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DisplayText).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.StoreName).HasMaxLength(255);
            entity.Property(e => e.TextColumn1).HasMaxLength(50);
            entity.Property(e => e.TextColumn2).HasMaxLength(50);
            entity.Property(e => e.TextColumn3).HasMaxLength(50);
            entity.Property(e => e.TextColumn4).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__products__47027DF5C133F9DD");

            entity.ToTable("products", "production");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.ListPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("list_price");
            entity.Property(e => e.ModelYear).HasColumnName("model_year");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("product_name");

            entity.HasOne(d => d.Brand).WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK__products__brand___3FD20ED7");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__products__catego__3EDDEA9E");
        });

        modelBuilder.Entity<ProductManufacturingStage>(entity =>
        {
            entity.ToTable("ProductManufacturingStage");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(250);
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.StageName).HasMaxLength(250);
        });

        modelBuilder.Entity<QuickAccounting>(entity =>
        {
            entity.ToTable("QuickAccounting");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(30);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Desctiption).HasMaxLength(250);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.KeyWord).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<RawMaterialConsumptionNorm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RawMaterialConsumptionNorms");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<RemainingQuantityManufaceture>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RemainingQuantityManufaceture");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.StageCode).HasMaxLength(50);
        });

        modelBuilder.Entity<RemainingQuantityManufacetureSortMetal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RemainingQuantityManufacetureSortMetal");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.StageCode).HasMaxLength(50);
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REPORT");

            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.DocTemplate).HasMaxLength(50);
            entity.Property(e => e.ExcelFileName).HasMaxLength(150);
            entity.Property(e => e.GroupContents1).HasMaxLength(100);
            entity.Property(e => e.GroupContents1Text).HasMaxLength(100);
            entity.Property(e => e.GroupContents2).HasMaxLength(100);
            entity.Property(e => e.GroupContents2Text).HasMaxLength(100);
            entity.Property(e => e.GroupHead).HasMaxLength(100);
            entity.Property(e => e.GroupHeadText).HasMaxLength(100);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.ImpDecision).HasMaxLength(255);
            entity.Property(e => e.NameReport).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.OrderByContents).HasMaxLength(255);
            entity.Property(e => e.Paramater).HasMaxLength(50);
            entity.Property(e => e.ReportFileName).HasMaxLength(150);
            entity.Property(e => e.StoreName).HasMaxLength(255);
            entity.Property(e => e.TableName).HasMaxLength(100);
            entity.Property(e => e.TemplateExcelCode).HasMaxLength(100);
            entity.Property(e => e.TemplateExcelText).HasMaxLength(100);
            entity.Property(e => e.TypeNameReport).HasMaxLength(250);
            entity.Property(e => e.TypeReport).HasMaxLength(50);
        });

        modelBuilder.Entity<ReportAccountDetailsBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportAccountDetailsBook");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BeginDate).HasMaxLength(10);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditAriseUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancBeginUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancEndUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancRemaining).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancRemainingUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Date).HasMaxLength(10);
            entity.Property(e => e.DayBefore).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebitBalanceUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtAriseUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancBeginUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancEndUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancRemaining).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancRemainingUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.EndDate).HasMaxLength(10);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.NextDay).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(100);
            entity.Property(e => e.Note1).HasMaxLength(100);
            entity.Property(e => e.Note2).HasMaxLength(100);
            entity.Property(e => e.Note3).HasMaxLength(100);
            entity.Property(e => e.Note4).HasMaxLength(100);
            entity.Property(e => e.Note5).HasMaxLength(100);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.TaxCode).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(250);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ReportArisingBalanceSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportArisingBalanceSheet");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.CreditAccumulated).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtAccumulated).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InOutSheet).HasMaxLength(250);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(20);
        });

        modelBuilder.Entity<ReportBalanceSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportBalanceSheet");

            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Formula).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Ok).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Presentation).HasMaxLength(50);
            entity.Property(e => e.Targets).HasMaxLength(255);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.YearEndNumber).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.YearFirstNumber).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<ReportBusinessResultsSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportBusinessResultsSheet");

            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Formula).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Presentation).HasMaxLength(50);
            entity.Property(e => e.Targets).HasMaxLength(255);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.YearEndNumber).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.YearFirstNumber).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<ReportCalculateProductionCost>(entity =>
        {
            entity.ToTable("ReportCalculateProductionCost");

            entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Amount154).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Amount621).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Amount622).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Amount627).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<ReportCashBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportCashBook");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancRemaining).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancRemaining).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ReportCashFlow>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportCashFlow");

            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Formula).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Presentation).HasMaxLength(50);
            entity.Property(e => e.Targets).HasMaxLength(255);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.YearEndNumber).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.YearFirstNumber).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<ReportCashInSalePoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportCashInSalePoint");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.ByShift).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditAccumulated).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DateNearest).HasColumnType("smalldatetime");
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitHeadShops).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitLetterOfGuarantee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitMortgage).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtAccumulated).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.DifferenceSalesList).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DifferenceShift).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.PaidMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.SalesListMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(20);
        });

        modelBuilder.Entity<ReportDataInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportDataInventory");

            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdVoucher).HasMaxLength(50);
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportDebtReconciliation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportDebtReconciliation");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyAbate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyAdjust).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpRe).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BeginDate).HasMaxLength(10);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditAriseUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancBeginUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancEndUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancRemaining).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancRemainingUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Date).HasMaxLength(10);
            entity.Property(e => e.DayBefore).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebitBalanceUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtAriseUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancBeginUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancEndUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancRemaining).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancRemainingUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.EndDate).HasMaxLength(10);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.NextDay).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(100);
            entity.Property(e => e.Note1).HasMaxLength(100);
            entity.Property(e => e.Note2).HasMaxLength(100);
            entity.Property(e => e.Note3).HasMaxLength(100);
            entity.Property(e => e.Note4).HasMaxLength(100);
            entity.Property(e => e.Note5).HasMaxLength(100);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(250);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.TaxCode).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(250);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ReportDebtSummaryBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportDebtSummaryBook");

            entity.Property(e => e.AccName).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AreaCode).HasMaxLength(50);
            entity.Property(e => e.AreaName).HasMaxLength(250);
            entity.Property(e => e.BankName).HasMaxLength(250);
            entity.Property(e => e.BeginDate).HasMaxLength(10);
            entity.Property(e => e.Blnhck)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BLNHCK");
            entity.Property(e => e.Blnhdk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BLNHDK");
            entity.Property(e => e.Blnhno)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BLNHNo");
            entity.Property(e => e.Blnhtt)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BLNHTT");
            entity.Property(e => e.Chblck)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CHBLCK");
            entity.Property(e => e.Chblckend)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CHBLCKEND");
            entity.Property(e => e.Chbldk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CHBLDK");
            entity.Property(e => e.Chblno)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CHBLNo");
            entity.Property(e => e.Chbltt)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CHBLTT");
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(250);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(250);
            entity.Property(e => e.CreditAccumulated).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditAccumulatedUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditAriseUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancBeginUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancEndUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancRemaining).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancRemainingUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Date).HasMaxLength(10);
            entity.Property(e => e.DayBefore).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitHeadShops).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitLetterOfGuarantee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitMortgage).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtAccumulated).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtAccumulatedUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtAriseUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancBeginUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancEndUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancRemaining).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancRemainingUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.DuCk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DuCK");
            entity.Property(e => e.DuDk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DuDK");
            entity.Property(e => e.DuNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DuTt)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DuTT");
            entity.Property(e => e.EndDate).HasMaxLength(10);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(250);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(250);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.HeadofDepartment).HasMaxLength(50);
            entity.Property(e => e.HeadofShifts).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.NextDay).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(100);
            entity.Property(e => e.Note1).HasMaxLength(100);
            entity.Property(e => e.Note2).HasMaxLength(100);
            entity.Property(e => e.Note3).HasMaxLength(100);
            entity.Property(e => e.Note4).HasMaxLength(100);
            entity.Property(e => e.Note5).HasMaxLength(100);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PositionAcc).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(250);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(250);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.Tmck)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TMCK");
            entity.Property(e => e.Tmdk)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TMDK");
            entity.Property(e => e.Tmno)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TMNo");
            entity.Property(e => e.Tmtt)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TMTT");
            entity.Property(e => e.Total).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UserCode).HasMaxLength(20);
        });

        modelBuilder.Entity<ReportDeliveryNotYetDelivered>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportDeliveryNotYetDelivered");

            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyDelivered).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyOrder).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Finish).HasDefaultValue(false);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.Parameter).HasMaxLength(70);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportFileNameByPrinter>(entity =>
        {
            entity.ToTable("ReportFileNameByPrinter");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.PrinterName).HasMaxLength(50);
            entity.Property(e => e.ReportFileName).HasMaxLength(255);
            entity.Property(e => e.TypeOrder).HasMaxLength(50);
        });

        modelBuilder.Entity<ReportGeneralLogBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportGeneralLogBook");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.Headline).HasMaxLength(150);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdData).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(50);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<ReportGeneralLogLedger>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportGeneralLogLedger");

            entity.Property(e => e.Account).HasMaxLength(20);
            entity.Property(e => e.AccountName).HasMaxLength(150);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.Headline).HasMaxLength(150);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IdData).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(50);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<ReportGrossProfit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportGrossProfit");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BeginBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CostArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.EndingBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.ProfitMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.TargetCode).HasMaxLength(50);
            entity.Property(e => e.TargetName).HasMaxLength(255);
            entity.Property(e => e.Template).HasMaxLength(250);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TurnoverArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
        });

        modelBuilder.Entity<ReportGrossProfitOutput>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportGrossProfitOutput");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.CostOfGoodsSold).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.GrossProfit).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportImportExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportImportExport");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.Headline).HasMaxLength(150);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IdData).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.Maso)
                .HasMaxLength(20)
                .HasColumnName("MASO");
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(50);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<ReportLatePaymentTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportLatePaymentTable");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.CreditAccumulated).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitHeadShops).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitLetterOfGuarantee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitMortgage).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtAccumulated).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancGreaterSixMonth).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancLessMonth).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancMonthTowMonth).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancThreeSixMonth).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancTowThreeMonth).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TotalCreditBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalDebtBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UserCode).HasMaxLength(20);
        });

        modelBuilder.Entity<ReportLateProductAgeTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportLateProductAgeTable");

            entity.Property(e => e.AccumulatedExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AccumulatedImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyNine).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyOverYear).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneySix).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyThree).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyYear).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportMaterialDetailsBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportMaterialDetailsBook");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.Parameter).HasMaxLength(70);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportMaterialSummaryBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportMaterialSummaryBook");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyBegin15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.Parameter).HasMaxLength(70);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportMaterialSummaryBookAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportMaterialSummaryBookADMIN");

            entity.HasIndex(e => new { e.WarehoseCode, e.CommodityCode, e.CommodityName }, "Ix_TempSmart15ADMIN").IsClustered();

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyBegin15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.Parameter).HasMaxLength(70);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportMaterialSummaryByReasonBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportMaterialSummaryByReasonBook");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyBegin15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15Another).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15Inventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15Return).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15Sell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15Transfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15Another).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15Borrowing).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15Buy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15Inventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15Transfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpBorrowing).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpBuy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportMaterialSummaryByReasonBookAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportMaterialSummaryByReasonBookADMIN");

            entity.HasIndex(e => new { e.WarehoseCode, e.CommodityCode, e.CommodityName }, "Ix_ReasonTempSmart15ADMIN").IsClustered();

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyBegin15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15Another).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15Inventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15Return).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15Sell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp15Transfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15Another).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15Borrowing).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15Buy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15Inventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp15Transfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpBorrowing).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpBuy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportPrintSalesCompareNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportPrintSalesCompareNew");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BeginDate).HasMaxLength(10);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancRemaining).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditSide).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DayText).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitSide).HasMaxLength(50);
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancRemaining).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.EndDate).HasMaxLength(10);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.MoneyMonth1).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonth10).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonth11).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonth12).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonth2).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonth3).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonth4).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonth5).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonth6).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonth7).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonth8).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonth9).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare1).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare10).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare11).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare12).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare2).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare3).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare4).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare5).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare6).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare7).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare8).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyMonthCompare9).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MonthText).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Note).HasMaxLength(150);
            entity.Property(e => e.Note1).HasMaxLength(150);
            entity.Property(e => e.Note2).HasMaxLength(150);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Percent1).HasColumnName("percent1");
            entity.Property(e => e.Percent10).HasColumnName("percent10");
            entity.Property(e => e.Percent11).HasColumnName("percent11");
            entity.Property(e => e.Percent12).HasColumnName("percent12");
            entity.Property(e => e.Percent2).HasColumnName("percent2");
            entity.Property(e => e.Percent3).HasColumnName("percent3");
            entity.Property(e => e.Percent4).HasColumnName("percent4");
            entity.Property(e => e.Percent5).HasColumnName("percent5");
            entity.Property(e => e.Percent6).HasColumnName("percent6");
            entity.Property(e => e.Percent7).HasColumnName("percent7");
            entity.Property(e => e.Percent8).HasColumnName("percent8");
            entity.Property(e => e.Percent9).HasColumnName("percent9");
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(250);
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.TaxCode).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(350);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VatName).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
            entity.Property(e => e.Year)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("year");
            entity.Property(e => e.YearCompare)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("yearCompare");
        });

        modelBuilder.Entity<ReportPrintSalesNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportPrintSalesNew");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.All1112)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ALL1112");
            entity.Property(e => e.AmountCit)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AmountCIT");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountEnvironmentax).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFixedCosts).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyA92).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyA95).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyDo)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AmountOfMoneyDO");
            entity.Property(e => e.AmountOfMoneyE5).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpGas).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpOil).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyFo)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AmountOfMoneyFO");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpGas).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpOil).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyKhac).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyNam).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyThang).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountPit)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AmountPIT");
            entity.Property(e => e.AmountTax).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVariablCosts).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AmountVAT");
            entity.Property(e => e.BeginDate).HasMaxLength(10);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancRemaining).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditSide).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DayText).HasMaxLength(50);
            entity.Property(e => e.Dccl01)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DCCL01");
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitSide).HasMaxLength(50);
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancRemaining).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.EndDate).HasMaxLength(10);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.Kvc0405)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("KVC0405");
            entity.Property(e => e.Lg01)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LG01");
            entity.Property(e => e.MonthText).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Note).HasMaxLength(150);
            entity.Property(e => e.Note1).HasMaxLength(150);
            entity.Property(e => e.Note2).HasMaxLength(150);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PriceDo).HasColumnName("PriceDO");
            entity.Property(e => e.PriceFo).HasColumnName("PriceFO");
            entity.Property(e => e.Qln0102)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QLN0102");
            entity.Property(e => e.QuantityDo).HasColumnName("QuantityDO");
            entity.Property(e => e.QuantityFo).HasColumnName("QuantityFO");
            entity.Property(e => e.QuantitySs).HasColumnName("QuantitySS");
            entity.Property(e => e.QuantitySs15).HasColumnName("QuantitySS15");
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(250);
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.TaxCode).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(350);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VatName).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<ReportSalesDebtSummaryBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSalesDebtSummaryBook");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(250);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(250);
            entity.Property(e => e.CreditAccumulated).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitHeadShops).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitLetterOfGuarantee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitMortgage).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtAccumulated).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(250);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(20);
        });

        modelBuilder.Entity<ReportSalesMaterialSummaryByReasonBook>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__ReportSa__3214EC0628A91766")
                .IsClustered(false);

            entity.ToTable("ReportSalesMaterialSummaryByReasonBook");

            entity.Property(e => e.AmountInWords).HasMaxLength(350);
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpOffer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpOrderSell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSellRetail).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpBuy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpOffer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpOrderBuy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(350);
            entity.Property(e => e.Decision).HasMaxLength(350);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(350);
            entity.Property(e => e.Headline).HasMaxLength(350);
            entity.Property(e => e.NameSupplier).HasMaxLength(350);
            entity.Property(e => e.NameUnit).HasMaxLength(350);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(350);
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(350);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(350);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(350);
        });

        modelBuilder.Entity<ReportSalesMaterialSummaryByReasonBookAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSalesMaterialSummaryByReasonBookAdmin");

            entity.HasIndex(e => new { e.WarehoseCode, e.CommodityCode, e.CommodityName }, "Ix_TempSmartReptAdmin").IsClustered();

            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpOffer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpOrderSell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSellRetail).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpBuy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpOffer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpOrderBuy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(250);
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportSalesMaterialSummaryByReasonBookBuyAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSalesMaterialSummaryByReasonBookBuyAdmin");

            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpOffer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpOrderSell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSellRetail).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpBuy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpOffer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpOrderBuy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(250);
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportSalesMaterialSummaryByReasonBookNv0002>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSalesMaterialSummaryByReasonBookNV0002");

            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpOffer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpOrderSell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSellRetail).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpBuy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpOffer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpOrderBuy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(20);
            entity.Property(e => e.CommodityCode).HasMaxLength(20);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(20);
            entity.Property(e => e.GroupName).HasMaxLength(100);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.NameUnit).HasMaxLength(150);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(20);
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TypeCode).HasMaxLength(20);
            entity.Property(e => e.TypeName).HasMaxLength(150);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseName).HasMaxLength(70);
        });

        modelBuilder.Entity<ReportSalesPublication>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Note).HasMaxLength(70);
            entity.Property(e => e.NoteMonth).HasMaxLength(70);
            entity.Property(e => e.NoteTime).HasMaxLength(70);
            entity.Property(e => e.NoteYear).HasMaxLength(70);
            entity.Property(e => e.Parameter).HasMaxLength(70);
            entity.Property(e => e.QuantityDo).HasColumnName("QuantityDO");
            entity.Property(e => e.QuantityE5a92).HasColumnName("QuantityE5A92");
            entity.Property(e => e.QuantityE5a95).HasColumnName("QuantityE5A95");
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesSgcin).HasColumnName("SalesSGCIn");
            entity.Property(e => e.SalesSgcon).HasColumnName("SalesSGCOn");
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TimePeriod).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportSalesTreading>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSalesTreading");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BeginDate).HasMaxLength(10);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Date).HasMaxLength(10);
            entity.Property(e => e.DayBefore).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EndDate).HasMaxLength(10);
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdData).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NextDay).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(50);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<ReportSalesWarehouse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSalesWarehouse");

            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyBb)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AmountOfMoneyBB");
            entity.Property(e => e.AmountOfMoneyBl)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AmountOfMoneyBL");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(70);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(250);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportSalesWarehouseCard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSalesWarehouseCard");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyAttrition).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BeginDate).HasMaxLength(10);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Date).HasMaxLength(10);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.EndDate).HasMaxLength(10);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(70);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseDataName).HasMaxLength(250);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportSalesWarehouseInv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSalesWarehouseInv");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BeginDate).HasMaxLength(10);
            entity.Property(e => e.Chitieu)
                .HasMaxLength(255)
                .HasColumnName("CHITIEU");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Date).HasMaxLength(10);
            entity.Property(e => e.DayBefore).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EndDate).HasMaxLength(10);
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdData).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NextDay).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(350);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(350);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.Sotienck)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SOTIENCK");
            entity.Property(e => e.Sotienckvat)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SOTIENCKVAT");
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<ReportSalesWarehouseStageLoss>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSalesWarehouseStageLoss");

            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyAttrition).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BeginDate).HasMaxLength(10);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Date).HasMaxLength(10);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.EndDate).HasMaxLength(10);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Hh758)
                .HasDefaultValue(0.0)
                .HasColumnName("HH_758");
            entity.Property(e => e.HhPvoil)
                .HasDefaultValue(0.0)
                .HasColumnName("HH_PVOIL");
            entity.Property(e => e.HhTd)
                .HasDefaultValue(0.0)
                .HasColumnName("HH_TD");
            entity.Property(e => e.HhTt)
                .HasDefaultValue(0.0)
                .HasColumnName("HH_TT");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Note).HasMaxLength(50);
            entity.Property(e => e.Parameter).HasMaxLength(70);
            entity.Property(e => e.PercentHh758)
                .HasDefaultValue(0.0)
                .HasColumnName("PERCENT_HH_758");
            entity.Property(e => e.PercentHhPvoil)
                .HasDefaultValue(0.0)
                .HasColumnName("PERCENT_HH_PVOIL");
            entity.Property(e => e.PercentHhTd)
                .HasDefaultValue(0.0)
                .HasColumnName("PERCENT_HH_TD");
            entity.Property(e => e.PercentHhTt)
                .HasDefaultValue(0.0)
                .HasColumnName("PERCENT_HH_TT");
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportSearchInvoiceImpExp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSearchInvoiceImpExp");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountInVouchers).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTaxInVouchers).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVatIpx).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.DiffAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DiffAmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.InvoiceSign).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VatType).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportSmartDetailAllInOne>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSmartDetailAllInOne");

            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoneyBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSell).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpSellRetail).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpTemporary).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyExpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImp).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpAnother).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpBuy).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpInventory).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpReturn).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpTemporary).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoneyImpTransfer).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditAriseUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancBeginUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancEndUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancRemaining).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreditBalancRemainingUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebitBalanceUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtAriseUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancBeginUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancEndUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancRemaining).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DebtBalancRemainingUsd).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(250);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VatRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<ReportSmartMarterialInventoryInAllWarehose>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportSmartMarterialInventoryInAllWarehose");

            entity.Property(e => e.AmountOfMoneyEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.ColumnSelect).HasMaxLength(221);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Kall).HasColumnName("KALL");
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
        });

        modelBuilder.Entity<ReportToKhaiThueGtgt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportToKhaiThueGTGT");

            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.AmountInWords).HasMaxLength(250);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BeginDate).HasMaxLength(10);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreditArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditBalancRemaining).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Date).HasMaxLength(10);
            entity.Property(e => e.DayBefore).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebtArise).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancRemaining).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.EndDate).HasMaxLength(10);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.Headline).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.NextDay).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(100);
            entity.Property(e => e.Note1).HasMaxLength(100);
            entity.Property(e => e.Note2).HasMaxLength(100);
            entity.Property(e => e.Note3).HasMaxLength(100);
            entity.Property(e => e.Note4).HasMaxLength(100);
            entity.Property(e => e.Note5).HasMaxLength(100);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SmartSort).HasMaxLength(20);
            entity.Property(e => e.TaxCode).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(250);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ResultBkavInvoice>(entity =>
        {
            entity.ToTable("ResultBkavInvoice");

            entity.Property(e => e.InvoiceForm).HasMaxLength(50);
            entity.Property(e => e.InvoiceGuid)
                .HasMaxLength(50)
                .HasColumnName("InvoiceGUID");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.InvoiceSerial).HasMaxLength(50);
            entity.Property(e => e.MaCuaCqt)
                .HasMaxLength(50)
                .HasColumnName("MaCuaCQT");
            entity.Property(e => e.MessLog).HasMaxLength(1024);
            entity.Property(e => e.Mtc)
                .HasMaxLength(50)
                .HasColumnName("MTC");
            entity.Property(e => e.PartnerInvoiceId)
                .HasMaxLength(50)
                .HasColumnName("PartnerInvoiceID");
            entity.Property(e => e.PartnerInvoiceStringId)
                .HasMaxLength(50)
                .HasColumnName("PartnerInvoiceStringID");
        });

        modelBuilder.Entity<RetailPriceList>(entity =>
        {
            entity.ToTable("RetailPriceList");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<RetailPriceListByWarehose>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RetailPriceListByWarehose");

            entity.Property(e => e.ColumnCode).HasMaxLength(100);
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<RuleAccountNumber>(entity =>
        {
            entity.ToTable("RuleAccountNumber");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountName).HasMaxLength(250);
            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<RuleReport>(entity =>
        {
            entity.ToTable("RuleReport");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.NameReport).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<RuleUnit>(entity =>
        {
            entity.ToTable("RuleUnit");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeUser).HasMaxLength(20);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<RuleUser>(entity =>
        {
            entity.ToTable("RuleUser");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.KeyFuntion).HasMaxLength(50);
            entity.Property(e => e.NameFuntion).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<RuleUserSave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RuleUserSave");

            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.KeyFuntion).HasMaxLength(50);
            entity.Property(e => e.NameFuntion).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<RuleWarehose>(entity =>
        {
            entity.ToTable("RuleWarehose");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeUser).HasMaxLength(20);
            entity.Property(e => e.CodeWarehose).HasMaxLength(20);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameWarehose).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<RuleWarehoseView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RuleWarehoseView");

            entity.Property(e => e.CodeUser).HasMaxLength(20);
            entity.Property(e => e.CodeWarehose).HasMaxLength(20);
        });

        modelBuilder.Entity<SalaryConfig>(entity =>
        {
            entity.ToTable("SalaryConfig");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Content).HasMaxLength(250);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberBegin).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NumberEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Value).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<SalarySchedule>(entity =>
        {
            entity.ToTable("SalarySchedule");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .HasComment("Tên tài khoản ngân hàng");
            entity.Property(e => e.ActuallyReceived)
                .HasComment("Thực nhận")
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AllowanceAwayHome).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AllowanceCostume).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AllowanceGasoline).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AllowanceMeals).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AllowanceMealsTax).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AllowanceTelephone).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AllowancesFamily).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AttendanceBonus).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .HasComment("Tên ngân hàng");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .HasComment("Số tài khoản ngân hàng");
            entity.Property(e => e.CodeSalaryType)
                .HasMaxLength(50)
                .HasComment("Mã loại bảng lương");
            entity.Property(e => e.CodeUnit).HasComment("Mã đơn vị trực thuộc");
            entity.Property(e => e.DataType)
                .HasMaxLength(50)
                .HasComment("Loại bảng lương");
            entity.Property(e => e.ExceptInsurance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Iddata).HasColumnName("IDdata");
            entity.Property(e => e.IncomeCode)
                .HasMaxLength(50)
                .HasComment("Mã số thu nhập");
            entity.Property(e => e.IncomeTaxable).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MonthText)
                .HasMaxLength(50)
                .HasComment("Tháng lương");
            entity.Property(e => e.NameSalaryType)
                .HasMaxLength(250)
                .HasComment("Tên loại bảng lương");
            entity.Property(e => e.NonTaxableIncome).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .HasComment("Ghi chú");
            entity.Property(e => e.NumberOfDaysWorked).HasComment("Số ngày làm việc");
            entity.Property(e => e.NumberOfDependents).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NumberOfWorkdays).HasComment("Số ngày công");
            entity.Property(e => e.ObjectCode)
                .HasMaxLength(50)
                .HasComment("Mã nhân viên");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(150)
                .HasComment("Tên nhân viên");
            entity.Property(e => e.PersonalIncomeTaxable).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasComment("Chức danh, chức vụ");
            entity.Property(e => e.RateHealthInsurance).HasComment("Tỷ lệ bảo hiểm y tế");
            entity.Property(e => e.RateInsurance).HasComment("Tỷ lệ bảo hiểm");
            entity.Property(e => e.RateSocialInsurance).HasComment("Tỷ lệ bảo hiểm XH");
            entity.Property(e => e.RateUnemploymentInsurance).HasComment("Tỷ lệ BH thất nghiệp");
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RewardComplyWith).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RewardOther).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RewardOvertime).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RewardsTrain).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RoomCode)
                .HasMaxLength(50)
                .HasComment("Mã phòng");
            entity.Property(e => e.RoomName)
                .HasMaxLength(250)
                .HasComment("Tên phòng");
            entity.Property(e => e.Salary).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SalaryAdvance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SalaryBasic)
                .HasComment("Lương cơ bản")
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SalaryCoefficient).HasComment("Hệ số lương");
            entity.Property(e => e.SalaryTaxes).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TaxableIncome).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalDeduction).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalMeals).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalMoney).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<SalaryTimeSheet>(entity =>
        {
            entity.ToTable("SalaryTimeSheet");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeSalaryType).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.MonthText).HasMaxLength(50);
            entity.Property(e => e.N01).HasMaxLength(10);
            entity.Property(e => e.N02).HasMaxLength(10);
            entity.Property(e => e.N03).HasMaxLength(10);
            entity.Property(e => e.N04).HasMaxLength(10);
            entity.Property(e => e.N05).HasMaxLength(10);
            entity.Property(e => e.N06).HasMaxLength(10);
            entity.Property(e => e.N07).HasMaxLength(10);
            entity.Property(e => e.N08).HasMaxLength(10);
            entity.Property(e => e.N09).HasMaxLength(10);
            entity.Property(e => e.N10).HasMaxLength(10);
            entity.Property(e => e.N11).HasMaxLength(10);
            entity.Property(e => e.N12).HasMaxLength(10);
            entity.Property(e => e.N13).HasMaxLength(10);
            entity.Property(e => e.N14).HasMaxLength(10);
            entity.Property(e => e.N15).HasMaxLength(10);
            entity.Property(e => e.N16).HasMaxLength(10);
            entity.Property(e => e.N17).HasMaxLength(10);
            entity.Property(e => e.N18).HasMaxLength(10);
            entity.Property(e => e.N19).HasMaxLength(10);
            entity.Property(e => e.N20).HasMaxLength(10);
            entity.Property(e => e.N21).HasMaxLength(10);
            entity.Property(e => e.N22).HasMaxLength(10);
            entity.Property(e => e.N23).HasMaxLength(10);
            entity.Property(e => e.N24).HasMaxLength(10);
            entity.Property(e => e.N25).HasMaxLength(10);
            entity.Property(e => e.N26).HasMaxLength(10);
            entity.Property(e => e.N27).HasMaxLength(10);
            entity.Property(e => e.N28).HasMaxLength(10);
            entity.Property(e => e.N29).HasMaxLength(10);
            entity.Property(e => e.N30).HasMaxLength(10);
            entity.Property(e => e.N31).HasMaxLength(10);
            entity.Property(e => e.NameSalaryType).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(150);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(150);
            entity.Property(e => e.Position).HasMaxLength(150);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesCashRemaining>(entity =>
        {
            entity.ToTable("SalesCashRemaining");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(150);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<SalesCatalogColumnPump>(entity =>
        {
            entity.ToTable("SalesCatalogColumnPump");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeWarehose).HasMaxLength(50);
            entity.Property(e => e.ColumnCode).HasMaxLength(100);
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Cột ngày tạo")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.NameWarehose).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(100);
        });

        modelBuilder.Entity<SalesCatalogLossRate>(entity =>
        {
            entity.ToTable("SalesCatalogLossRate");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.TypeLossRate).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesCatalogTank>(entity =>
        {
            entity.ToTable("SalesCatalogTank");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeWarehose).HasMaxLength(50);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Cột ngày tạo")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.NameWarehose).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.TankCode).HasMaxLength(100);
            entity.Property(e => e.TankName).HasMaxLength(100);
            entity.Property(e => e.UnitPsc).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesCatalogVcfd15>(entity =>
        {
            entity.ToTable("SalesCatalogVCFD15");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CommodityCode).HasMaxLength(100);
            entity.Property(e => e.CommodityName).HasMaxLength(100);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Cột ngày tạo")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.MonthText).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UnitPsc).HasMaxLength(20);
        });

        modelBuilder.Entity<SalesCatalogVoucherNumber>(entity =>
        {
            entity.ToTable("SalesCatalogVoucherNumber");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ByDate).HasDefaultValue(false);
            entity.Property(e => e.CreditSide).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(50);
            entity.Property(e => e.HasIinherit).HasColumnName("HasIInherit");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InheritFrom).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ReasonUse).HasMaxLength(255);
            entity.Property(e => e.SignVoucher).HasMaxLength(50);
            entity.Property(e => e.TypeObject).HasMaxLength(50);
            entity.Property(e => e.VoucherName).HasMaxLength(100);
        });

        modelBuilder.Entity<SalesCatalogVoucherNumbersave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesCatalogVoucherNumbersave");

            entity.Property(e => e.CreditSide).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.SignVoucher).HasMaxLength(50);
            entity.Property(e => e.VoucherName).HasMaxLength(100);
        });

        modelBuilder.Entity<SalesCountPump>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesCountPump");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesDataInventoryDocumment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesDataInventoryDocumment");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesDataInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesDataInvoice");

            entity.Property(e => e.Apipassword)
                .HasMaxLength(100)
                .HasColumnName("APIPassword");
            entity.Property(e => e.Apitaxcode)
                .HasMaxLength(50)
                .HasColumnName("APITaxcode");
            entity.Property(e => e.Apiurl)
                .HasMaxLength(255)
                .HasColumnName("APIUrl");
            entity.Property(e => e.Apiuser)
                .HasMaxLength(50)
                .HasColumnName("APIUser");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DateCreateInvoice).HasColumnType("datetime");
            entity.Property(e => e.DeliveryPointCode).HasMaxLength(100);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.HiloUserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idinvoice)
                .HasMaxLength(10)
                .HasColumnName("IDInvoice");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesDataShiftNotebook>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesDataShiftNotebook");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesListBillImpReturn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesListBillImpReturn");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesLock>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeMonth).HasMaxLength(50);
            entity.Property(e => e.LockType).HasMaxLength(50);
            entity.Property(e => e.NameMonth).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesMaterialRemaining>(entity =>
        {
            entity.ToTable("SalesMaterialRemaining");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifyBy).HasMaxLength(70);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ShipmentNumber).HasMaxLength(50);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<SalesMaterialRemainingMonth>(entity =>
        {
            entity.ToTable("SalesMaterialRemainingMonth");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.MonthText).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<SalesMenu>(entity =>
        {
            entity.ToTable("SalesMenu");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.MenuCaption).HasMaxLength(255);
            entity.Property(e => e.MenuImage).HasMaxLength(100);
            entity.Property(e => e.MenuLevel).HasMaxLength(50);
            entity.Property(e => e.MenuName).HasMaxLength(50);
            entity.Property(e => e.MenuNote).HasMaxLength(255);
            entity.Property(e => e.MenuParameters).HasMaxLength(50);
            entity.Property(e => e.ParameterReport).HasMaxLength(50);
            entity.Property(e => e.ParentMenu).HasMaxLength(50);
            entity.Property(e => e.TableName).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesOptionPrintOrder>(entity =>
        {
            entity.ToTable("SalesOptionPrintOrder");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.FileDoc).HasMaxLength(100);
            entity.Property(e => e.NameDoc).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.Prameters).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(250);
            entity.Property(e => e.TypeDoc).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesReport");

            entity.Property(e => e.ByConstruction).HasComment("0");
            entity.Property(e => e.ByContract).HasComment("0");
            entity.Property(e => e.ByExpense).HasComment("0");
            entity.Property(e => e.ByMaterials).HasComment("0");
            entity.Property(e => e.ByNoAcount).HasComment("0");
            entity.Property(e => e.ByObject).HasComment("0");
            entity.Property(e => e.ByRevenue).HasComment("0");
            entity.Property(e => e.ByWarehouse).HasComment("0");
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.DocTemplate).HasMaxLength(50);
            entity.Property(e => e.ExcelFileName).HasMaxLength(150);
            entity.Property(e => e.GroupContents1).HasMaxLength(100);
            entity.Property(e => e.GroupContents1Text).HasMaxLength(100);
            entity.Property(e => e.GroupContents2).HasMaxLength(100);
            entity.Property(e => e.GroupContents2Text).HasMaxLength(100);
            entity.Property(e => e.GroupHead).HasMaxLength(100);
            entity.Property(e => e.GroupHeadText).HasMaxLength(100);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.ImpDecision).HasMaxLength(255);
            entity.Property(e => e.NameReport).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Orderbycontens).HasColumnName("orderbycontens");
            entity.Property(e => e.Paramater).HasMaxLength(50);
            entity.Property(e => e.ReportFileName).HasMaxLength(150);
            entity.Property(e => e.StoreName).HasMaxLength(255);
            entity.Property(e => e.TableName).HasMaxLength(100);
            entity.Property(e => e.TemplateExcelCode).HasMaxLength(100);
            entity.Property(e => e.TemplateExcelText).HasMaxLength(100);
            entity.Property(e => e.TypeNameReport).HasMaxLength(250);
            entity.Property(e => e.TypeReport).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesReportSave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesReportSave");

            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.DocTemplate).HasMaxLength(50);
            entity.Property(e => e.ExcelFileName).HasMaxLength(150);
            entity.Property(e => e.GroupContents1).HasMaxLength(100);
            entity.Property(e => e.GroupContents1Text).HasMaxLength(100);
            entity.Property(e => e.GroupContents2).HasMaxLength(100);
            entity.Property(e => e.GroupContents2Text).HasMaxLength(100);
            entity.Property(e => e.GroupHead).HasMaxLength(100);
            entity.Property(e => e.GroupHeadText).HasMaxLength(100);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.ImpDecision).HasMaxLength(255);
            entity.Property(e => e.NameReport).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Paramater).HasMaxLength(50);
            entity.Property(e => e.ReportFileName).HasMaxLength(150);
            entity.Property(e => e.StoreName).HasMaxLength(255);
            entity.Property(e => e.TableName).HasMaxLength(100);
            entity.Property(e => e.TemplateExcelCode).HasMaxLength(100);
            entity.Property(e => e.TemplateExcelText).HasMaxLength(100);
            entity.Property(e => e.TypeNameReport).HasMaxLength(250);
            entity.Property(e => e.TypeReport).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesRuleReport>(entity =>
        {
            entity.ToTable("SalesRuleReport");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.NameReport).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<SalesRuleUnit>(entity =>
        {
            entity.ToTable("SalesRuleUnit");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeUser).HasMaxLength(20);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesRuleUser>(entity =>
        {
            entity.ToTable("SalesRuleUser");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.KeyFuntion).HasMaxLength(50);
            entity.Property(e => e.NameFuntion).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<SalesRuleUserSave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesRuleUserSave");

            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.KeyFuntion).HasMaxLength(50);
            entity.Property(e => e.NameFuntion).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<SalesShoppingCart>(entity =>
        {
            entity.ToTable("SalesShoppingCart");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesShoppingCartContent>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BatchWarehose).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.IdSource).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesSmartContentsDatum>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.ToTable(tb => tb.HasTrigger("TrigDeleteSalesSmartContentsData"));

            entity.HasIndex(e => new { e.IdAsc, e.CommodityCode }, "Idx_SalesSmartContentsData")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.ActualAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AddressSupplier).HasMaxLength(255);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountBog).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountExciseTax).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BatchWarehose).HasMaxLength(50);
            entity.Property(e => e.BogType).HasMaxLength(20);
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(50);
            entity.Property(e => e.CreditObjectName).HasMaxLength(150);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DateShipment).HasColumnType("smalldatetime");
            entity.Property(e => e.DebitObjectCode).HasMaxLength(50);
            entity.Property(e => e.DebitObjectName).HasMaxLength(150);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.EventsContentCode).HasMaxLength(20);
            entity.Property(e => e.EventsContentName).HasMaxLength(100);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.IdSource).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Km).HasColumnName("KM");
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(250);
            entity.Property(e => e.ProgramCode).HasMaxLength(250);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.ReasonCodeCont).HasMaxLength(30);
            entity.Property(e => e.ReasonNameCont).HasMaxLength(100);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(20);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(120);
            entity.Property(e => e.Season).HasMaxLength(50);
            entity.Property(e => e.ShipmentNumber).HasMaxLength(50);
            entity.Property(e => e.ShortAddressSupplier).HasMaxLength(255);
            entity.Property(e => e.ShortNameSupplier).HasMaxLength(255);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VatType).HasMaxLength(250);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataAll");

            entity.Property(e => e.AccountingType).HasMaxLength(30);
            entity.Property(e => e.ActualAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountPayment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVoucher).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BatchWarehose).HasMaxLength(50);
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(150);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.HeadAmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LevelDiscount).HasMaxLength(20);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.Location).HasMaxLength(150);
            entity.Property(e => e.MemberRate).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.MoneyDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyReturnGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchersDoc).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PointsMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProgramCode).HasMaxLength(250);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(150);
            entity.Property(e => e.Season).HasMaxLength(50);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SubAmountPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataAllSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataAllSum");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsCheck)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.VouchersStatus).HasMaxLength(18);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataAllok>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataAllok");

            entity.Property(e => e.AccountingType).HasMaxLength(30);
            entity.Property(e => e.ActualAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountPayment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVoucher).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(150);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.HeadAmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LevelDiscount).HasMaxLength(20);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.Location).HasMaxLength(150);
            entity.Property(e => e.MemberRate).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.MoneyDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyReturnGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchersDoc).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PointsMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProgramCode).HasMaxLength(250);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(150);
            entity.Property(e => e.Season).HasMaxLength(50);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SubAmountPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataDc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataDC");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Expr1).HasMaxLength(255);
            entity.Property(e => e.Expr2).HasMaxLength(50);
            entity.Property(e => e.Expr3).HasMaxLength(255);
            entity.Property(e => e.Expr4).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesSmartDataImpExp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataImpExp");

            entity.Property(e => e.AccountingType).HasMaxLength(30);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountPayment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVoucher).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.Expr1).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Expr2).HasMaxLength(255);
            entity.Property(e => e.Expr3).HasMaxLength(50);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(150);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LevelDiscount).HasMaxLength(20);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.MoneyDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyReturnGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchersDoc).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PointsMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(150);
            entity.Property(e => e.Season).HasMaxLength(50);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SubAmountPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataImpExpManu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataImpExpManu");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.Expr1).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Expr2).HasMaxLength(255);
            entity.Property(e => e.Expr3).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PointsMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(150);
            entity.Property(e => e.Season).HasMaxLength(50);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SubAmountPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VatType).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataImpExpSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataImpExpSum");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsCheck)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.VouchersStatus).HasMaxLength(18);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataInheritedDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataInheritedDocuments");

            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesSmartDataInv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataInv");

            entity.Property(e => e.AccountingType).HasMaxLength(30);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountPayment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVoucher).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.Expr1).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(150);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.Location).HasMaxLength(150);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.MoneyDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyReturnGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchersDoc).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PointsMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProgramCode).HasMaxLength(50);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(150);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SubAmountPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataInvSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataInvSum");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsCheck)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.VouchersStatus).HasMaxLength(18);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataInventory");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataInventoryDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataInventoryDocuments");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataOrderBuy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataOrderBuy");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesSmartDataOrderBuyUneven>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataOrderBuyUneven");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesSmartDataOrderSell>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataOrderSell");

            entity.Property(e => e.AccountingType).HasMaxLength(30);
            entity.Property(e => e.ActualAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountPayment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVoucher).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.Expr1).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Expr2).HasMaxLength(255);
            entity.Property(e => e.Expr3).HasMaxLength(50);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(150);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LevelDiscount).HasMaxLength(20);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(150);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.MoneyDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyReturnGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PointsMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProgramCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(150);
            entity.Property(e => e.Season).HasMaxLength(50);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SubAmountPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataShift>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataShift");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataSumWarehose>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataSumWarehose");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Month).HasColumnName("MONTH");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<SalesSmartDataTank>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataTank");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataVoucher>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataVoucher");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.Warehosecode).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesSmartDataVoucherSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataVoucherSum");

            entity.Property(e => e.AccountingType).HasMaxLength(30);
            entity.Property(e => e.ActualAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountPayment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVoucher).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(150);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.HeadAmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LevelDiscount).HasMaxLength(20);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.Location).HasMaxLength(150);
            entity.Property(e => e.MemberRate).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.MoneyDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyReturnGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchersDoc).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PointsMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProgramCode).HasMaxLength(250);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(150);
            entity.Property(e => e.Season).HasMaxLength(50);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SubAmountPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDataWarehouseSent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataWarehouseSent");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(4);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(3);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(12);
        });

        modelBuilder.Entity<SalesSmartDataWarranty>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartDataWarranty");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(250);
            entity.Property(e => e.Expr1).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Expr2).HasMaxLength(255);
            entity.Property(e => e.Expr3).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PointsMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(150);
            entity.Property(e => e.Season).HasMaxLength(50);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SubAmountPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VatType).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartDatum>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("InsertSalesSmartData");
                    tb.HasTrigger("TrigDeleteSalesSmartData");
                    tb.HasTrigger("UpdatetSalesSmartData");
                });

            entity.HasIndex(e => new { e.Id, e.RecordDate, e.DataType }, "Idx_SalesSmartData")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountingType).HasMaxLength(30);
            entity.Property(e => e.AccumulatedPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountPayment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountTransferred).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVoucher).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BeginDate).HasColumnType("datetime");
            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DateDraf).HasColumnType("datetime");
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(150);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvStatus).HasMaxLength(255);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LevelDiscount).HasMaxLength(20);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(250)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.Location).HasMaxLength(150);
            entity.Property(e => e.MemberRate).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.MoneyDiscountOnBill).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MoneyReturnGuests).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameUnit).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVoucherInherit).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchersDoc).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.PointsMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProgramCode).HasMaxLength(50);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SalesChannelCode).HasMaxLength(50);
            entity.Property(e => e.SalesChannelName).HasMaxLength(150);
            entity.Property(e => e.ShiftCode).HasMaxLength(20);
            entity.Property(e => e.ShiftName).HasMaxLength(255);
            entity.Property(e => e.ShippingMethodsCode).HasMaxLength(50);
            entity.Property(e => e.ShippingMethodsName).HasMaxLength(255);
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.SubAmountPoints).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TaxAuthorityCode).HasMaxLength(50);
            entity.Property(e => e.TotalAmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SalesSmartProductInventory>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc }).HasName("PK_SalesSmartListMoney");

            entity.ToTable("SalesSmartProductInventory", tb => tb.HasTrigger("TrigDeleteSalesSmartProductInventory"));

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesSmartVoucherImpReturn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesSmartVoucherImpReturn");
        });

        modelBuilder.Entity<SalesSummaryMaterialTemporary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesSummaryMaterialTemporary");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesTrackVoucher>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesTrackVouchers");

            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SrcDataName).HasMaxLength(150);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<SalesTradingOptionPrintOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesTradingOptionPrintOrder");

            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.FileDoc).HasMaxLength(100);
            entity.Property(e => e.NameDoc).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.Prameters).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(250);
            entity.Property(e => e.TypeDoc).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesUnitInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesUnitInfo");

            entity.Property(e => e.AccName).HasMaxLength(50);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.AddressUnit).HasMaxLength(255);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.Decide).HasMaxLength(150);
            entity.Property(e => e.DirectorName).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.FaxNumber).HasMaxLength(50);
            entity.Property(e => e.From).HasMaxLength(50);
            entity.Property(e => e.HeadofDepartment).HasMaxLength(50);
            entity.Property(e => e.HeadofShifts).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PositionAcc).HasMaxLength(50);
            entity.Property(e => e.PositionDir).HasMaxLength(50);
            entity.Property(e => e.PositionReport).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ReportDate).HasMaxLength(150);
            entity.Property(e => e.ReporterName).HasMaxLength(50);
            entity.Property(e => e.Stocker).HasMaxLength(50);
            entity.Property(e => e.SubordinateName).HasMaxLength(255);
            entity.Property(e => e.SuperiorName).HasMaxLength(255);
            entity.Property(e => e.Taxcode).HasMaxLength(50);
            entity.Property(e => e.Treasurer).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesUser>(entity =>
        {
            entity.HasKey(e => e.CodeUser);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("DeleteSalesUsers");
                    tb.HasTrigger("InsertSales");
                });

            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(50);
            entity.Property(e => e.AddressWarehose).HasMaxLength(255);
            entity.Property(e => e.Apipassword)
                .HasMaxLength(100)
                .HasColumnName("APIPassword");
            entity.Property(e => e.Apitaxcode)
                .HasMaxLength(50)
                .HasColumnName("APITaxcode");
            entity.Property(e => e.Apiurl)
                .HasMaxLength(255)
                .HasColumnName("APIUrl");
            entity.Property(e => e.Apiuser)
                .HasMaxLength(50)
                .HasColumnName("APIUser");
            entity.Property(e => e.CodeWarehose).HasMaxLength(50);
            entity.Property(e => e.CostAcc).HasMaxLength(50);
            entity.Property(e => e.DebitAcc).HasMaxLength(50);
            entity.Property(e => e.DeliveryPointCode).HasMaxLength(100);
            entity.Property(e => e.EmailUser).HasMaxLength(100);
            entity.Property(e => e.HasMetadata).HasDefaultValue(true);
            entity.Property(e => e.HiloUserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdInvoice).HasMaxLength(10);
            entity.Property(e => e.InvoiceForm).HasMaxLength(20);
            entity.Property(e => e.InvoiceSerial).HasMaxLength(20);
            entity.Property(e => e.IsInvoiceCalculatingMachine).HasDefaultValue(true);
            entity.Property(e => e.ManagerName).HasMaxLength(50);
            entity.Property(e => e.ModeType).HasMaxLength(50);
            entity.Property(e => e.ModeTypeName).HasMaxLength(150);
            entity.Property(e => e.NameUser).HasMaxLength(50);
            entity.Property(e => e.NameWarehose).HasMaxLength(255);
            entity.Property(e => e.NotInvCodePointExp).HasMaxLength(255);
            entity.Property(e => e.NotInvIdInvoice).HasMaxLength(30);
            entity.Property(e => e.NotInvNamePointExp).HasMaxLength(30);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(150);
            entity.Property(e => e.PartnerGuid)
                .HasMaxLength(255)
                .HasColumnName("PartnerGUID");
            entity.Property(e => e.PartnerToken).HasMaxLength(255);
            entity.Property(e => e.PassUser).HasMaxLength(100);
            entity.Property(e => e.SignWarehose).HasMaxLength(20);
            entity.Property(e => e.TaxEnviPro).HasMaxLength(30);
            entity.Property(e => e.TaxRevenue).HasMaxLength(30);
            entity.Property(e => e.TemplateCode).HasMaxLength(20);
            entity.Property(e => e.VatAccount).HasMaxLength(20);
        });

        modelBuilder.Entity<SalesUserLog>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DateAction)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FunctionName).HasMaxLength(250);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(1024);
            entity.Property(e => e.TypeOrderOrCode).HasMaxLength(250);
            entity.Property(e => e.UserExc).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartContentsDataDangchuyen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SmartContentsDataDangchuyen");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountExciseTax).HasMaxLength(50);
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CostOfGoodsSold).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CostOfGoodsSold15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.CreditSideOut).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DateShipment).HasColumnType("smalldatetime");
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebitSideOut).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ExciseTaxRate).HasMaxLength(50);
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumberContents).HasMaxLength(50);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.Season).HasMaxLength(150);
            entity.Property(e => e.ShipmentNumber).HasMaxLength(50);
            entity.Property(e => e.SignTransfer).HasMaxLength(50);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartContentsDatum>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.ToTable(tb => tb.HasTrigger("TrigDeleteSmartContentsData"));

            entity.HasIndex(e => new { e.IdAsc, e.CreditObjectCode, e.DebitObjectCode, e.CreditSide, e.DebitSide, e.CommodityCode }, "Idx_SmartContentsData")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountExciseTax).HasMaxLength(50);
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountImpTax).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CostOfGoodsSold).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CostOfGoodsSold15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.CreditSideOut).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DateShipment).HasColumnType("smalldatetime");
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebitSideOut).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ExciseTaxRate).HasMaxLength(50);
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.IdSource).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdTracing).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumberContents).HasMaxLength(50);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.Season).HasMaxLength(150);
            entity.Property(e => e.ShipmentNumber).HasMaxLength(50);
            entity.Property(e => e.SignTransfer).HasMaxLength(50);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartContentsDebtRepaymentPlan>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.ToTable("SmartContentsDebtRepaymentPlan");

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AmountOfInterest).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfSavings).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DateOfPayment).HasColumnType("smalldatetime");
            entity.Property(e => e.FirstDateOfPayment).HasColumnType("smalldatetime");
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.OriginalBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PrincipalAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalInterestPrincipal).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<SmartContentsPromotion>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.ToTable("SmartContentsPromotion");

            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartContentsPromotionArea>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.ToTable("SmartContentsPromotionArea");

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<SmartCostAllotment>(entity =>
        {
            entity.HasKey(e => new { e.IdAsc, e.IdContents });

            entity.ToTable("SmartCostAllotment", tb => tb.HasTrigger("TrigDeleteSmartCostAllotment"));

            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AmountOfAllotment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditSide).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(50);
            entity.Property(e => e.IdData).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartDataAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataAll");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CostOfGoodsSold).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CostOfGoodsSold15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.CreditSideOut).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DataTypeContents).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebitSideOut).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(50);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceNumberContents).HasMaxLength(50);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContents).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.SignTransfer).HasMaxLength(50);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartDataAllSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataAllSum");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartDataBillOfMaterial>(entity =>
        {
            entity.HasKey(e => e.IdAsc);

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(20);
            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdSource).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartDataConsign>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataConsign");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContents).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartDataExpSell>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataExpSell");

            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartDataExportByBom>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataExportByBOM");

            entity.Property(e => e.AccountSymbol)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreditSide)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DebitSide)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartDataExportManuByBom>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataExportManuByBOM");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartDataFinalAdjustment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SmartDataFinalAdjustment");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(70);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(20);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartDataImpExp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataImpExp");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CostOfGoodsSold).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CostOfGoodsSold15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.CreditSideOut).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebitSideOut).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(50);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContents).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartDataImpExpSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataImpExpSum");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartDataIndenture>(entity =>
        {
            entity.ToTable("SmartDataIndenture");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountPaidPerMonth).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ContractName).HasMaxLength(250);
            entity.Property(e => e.ContractNumber).HasMaxLength(50);
            entity.Property(e => e.ContractTypeCode).HasMaxLength(50);
            entity.Property(e => e.ContractTypeName).HasMaxLength(250);
            entity.Property(e => e.ContractValue).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreditProductCode).HasMaxLength(20);
            entity.Property(e => e.CreditProductName).HasMaxLength(100);
            entity.Property(e => e.DataName).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DateDue).HasColumnType("smalldatetime");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.DisbursementDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FormOfCapitalPayment).HasMaxLength(100);
            entity.Property(e => e.FormOfCapitalPaymentCode).HasMaxLength(100);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdDocument).HasMaxLength(100);
            entity.Property(e => e.IndentureNo).HasMaxLength(50);
            entity.Property(e => e.InterePayMethCode).HasMaxLength(50);
            entity.Property(e => e.InterestPaymentMethod).HasMaxLength(100);
            entity.Property(e => e.MethodOfCalInterest).HasMaxLength(355);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.NumberOfVoucherAcc).HasMaxLength(100);
            entity.Property(e => e.ObjectAddress).HasMaxLength(250);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(250);
            entity.Property(e => e.PurposeCode).HasMaxLength(20);
            entity.Property(e => e.PurposeName).HasMaxLength(250);
            entity.Property(e => e.SignDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<SmartDataInheritedDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataInheritedDocuments");

            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
        });

        modelBuilder.Entity<SmartDataInvSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataInvSum");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartDataInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataInvoice");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CostOfGoodsSold).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CostOfGoodsSold15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(50);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceNumberContents).HasMaxLength(50);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContents).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartDataManufacture>(entity =>
        {
            entity.ToTable("SmartDataManufacture");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(20);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.StageName).HasMaxLength(250);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartDataManufactureContent>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.IdSource).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdTracing).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.StageName).HasMaxLength(250);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartDataManufactureSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataManufactureSum");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(20);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartDataProductionRequirement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataProductionRequirements");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContents).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(20);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.StageName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartDataPromotion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataPromotion");

            entity.Property(e => e.BeginDate).HasColumnType("datetime");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FormOfPromotionCode).HasMaxLength(50);
            entity.Property(e => e.ProgramCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartDataPumpCode>(entity =>
        {
            entity.ToTable("SmartDataPumpCode");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BatchDate).HasColumnType("smalldatetime");
            entity.Property(e => e.BatchId).HasMaxLength(50);
            entity.Property(e => e.BatchNo).HasMaxLength(50);
            entity.Property(e => e.BatchWarehose).HasMaxLength(50);
            entity.Property(e => e.BeginDate).HasColumnType("datetime");
            entity.Property(e => e.CodeWarehose).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateCloseShift).HasColumnType("datetime");
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NameWarehose).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NozzleId).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(50);
            entity.Property(e => e.PersonName).HasMaxLength(255);
            entity.Property(e => e.Prameter).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(250);
            entity.Property(e => e.PumpNozzleCode).HasMaxLength(50);
            entity.Property(e => e.PumpNozzleName).HasMaxLength(250);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SaleNumber).HasMaxLength(50);
            entity.Property(e => e.Signature).HasMaxLength(255);
            entity.Property(e => e.StationId).HasMaxLength(50);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TransactionID");
            entity.Property(e => e.UnitPcs).HasMaxLength(20);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.WorkShift).HasMaxLength(70);
        });

        modelBuilder.Entity<SmartDataSellsByMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataSellsByMonth");

            entity.Property(e => e.AmountOfMoney01).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney02).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney03).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney04).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney05).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney06).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney07).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney08).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney09).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney10).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney11).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney12).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoneySum).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartDataShoppingCart>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataShoppingCart");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BatchWarehose).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NoteContents).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartDataTool>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataTools");

            entity.Property(e => e.AccumulatedDepreciation).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AllocationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CarryingAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.NumberOfVouchersContenst).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RecordDateContenst).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<SmartDataVat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataVat");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceSign).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TaxCode).HasMaxLength(20);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartDataVoucher>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataVouchers");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.CreditSideOut).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebitSideOut).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceNumberContents).HasMaxLength(50);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContents).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartDataVoucherSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataVoucherSum");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartDataYesVat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartDataYesVat");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(50);
            entity.Property(e => e.ContractName).HasMaxLength(255);
            entity.Property(e => e.CostOfGoodsSold).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CostOfGoodsSold15).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditObjectCode).HasMaxLength(20);
            entity.Property(e => e.CreditObjectName).HasMaxLength(255);
            entity.Property(e => e.CreditObjectTax).HasMaxLength(20);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.CreditSideOut).HasMaxLength(20);
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DataTypeContents).HasMaxLength(50);
            entity.Property(e => e.DebitObjectCode).HasMaxLength(20);
            entity.Property(e => e.DebitObjectName).HasMaxLength(255);
            entity.Property(e => e.DebitObjectTax).HasMaxLength(20);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.DebitSideOut).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DescriptionContents).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.ForeignCurrencyType).HasMaxLength(20);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(50);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceNumberContents).HasMaxLength(50);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContents).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.SignTransfer).HasMaxLength(50);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartDatum>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TrigDeleteSmartData");
                    tb.HasTrigger("UpdatetSmartData");
                });

            entity.HasIndex(e => new { e.Id, e.RecordDate, e.DataType }, "Idx_SmartData")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ComfirmVoucher).HasDefaultValue(false);
            entity.Property(e => e.ContractNo).HasMaxLength(100);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Einvoice).HasColumnName("EInvoice");
            entity.Property(e => e.EnumberInvoice)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoice");
            entity.Property(e => e.EnumberInvoiceDraft)
                .HasMaxLength(50)
                .HasColumnName("ENumberInvoiceDraft");
            entity.Property(e => e.GroupAreaCode).HasMaxLength(50);
            entity.Property(e => e.GroupAreaName).HasMaxLength(50);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(250);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceResult).HasMaxLength(1024);
            entity.Property(e => e.InvoiceSymbol).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.KeyInvoce).HasMaxLength(50);
            entity.Property(e => e.LicensePlates).HasMaxLength(250);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.MemberRate).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectEmail).HasMaxLength(255);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PersonTaxCode).HasMaxLength(20);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RoomCode).HasMaxLength(70);
            entity.Property(e => e.RoomName).HasMaxLength(70);
            entity.Property(e => e.ShippingMethodsCode).HasMaxLength(50);
            entity.Property(e => e.ShippingMethodsName).HasMaxLength(255);
            entity.Property(e => e.SignAdjust).HasMaxLength(50);
            entity.Property(e => e.SignTransfer).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VehiclesName).HasMaxLength(75);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.VoucherStatus).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartFileAttach>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc }).HasName("PK_SmartFileAttach_1");

            entity.ToTable("SmartFileAttach", tb => tb.HasTrigger("TrigDeleteSmartFileAttach"));

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FileNames).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.PathFile).HasMaxLength(255);
            entity.Property(e => e.Xem).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartFluctuatingInterestRate>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartIdImpReturn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartIdImpReturn");
        });

        modelBuilder.Entity<SmartInfoPaymentBill>(entity =>
        {
            entity.ToTable("SmartInfoPaymentBill");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BillId)
                .HasMaxLength(20)
                .HasComment("Id bill thanh toán có chiều dài 7 ký tự sinh nhẫu nhiên không trùng");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdInv).HasComment("ID hóa đơn bán hàng");
            entity.Property(e => e.Notes).HasMaxLength(100);
            entity.Property(e => e.StaffCode).HasMaxLength(20);
            entity.Property(e => e.StatusPayment).HasComment("Trạng thái đã thanh toán hay chưa thanh toán");
            entity.Property(e => e.StillValid).HasComment("Trạng thái hiệu lực của bill hàng, còn giá trị thanh toán hay không");
        });

        modelBuilder.Entity<SmartListDataImportedExcel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartListDataImportedExcel");

            entity.Property(e => e.CreateDate).HasMaxLength(61);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.NumberImport).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartListOfTool>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.ToTable(tb => tb.HasTrigger("TrigDeleteSmartListOfTools"));

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AccumulatedDepreciation).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AllocationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CarryingAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ConstructionCode).HasMaxLength(50);
            entity.Property(e => e.ConstructionName).HasMaxLength(255);
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FundingSourceCode).HasMaxLength(50);
            entity.Property(e => e.FundingSourceName).HasMaxLength(255);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ProductionActivitieCode).HasMaxLength(50);
            entity.Property(e => e.ProductionActivitieName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RemainingAmortization).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RevenueExpenseCode).HasMaxLength(50);
            entity.Property(e => e.RevenueExpenseName).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(50);
            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartListProductByBarcode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartListProductByBarcode");

            entity.Property(e => e.Barcode).HasMaxLength(250);
            entity.Property(e => e.CodeSupplier).HasMaxLength(250);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(255);
            entity.Property(e => e.NameSupplier).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.TypeVat).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(20);
            entity.Property(e => e.UnitPsc).HasMaxLength(20);
        });

        modelBuilder.Entity<SmartLog>(entity =>
        {
            entity.Property(e => e.BeginDate).HasMaxLength(10);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasMaxLength(10);
            entity.Property(e => e.ErrorMessage).HasMaxLength(250);
            entity.Property(e => e.ErrorProcedure).HasMaxLength(250);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.StoreName).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(20);
        });

        modelBuilder.Entity<SmartLogsOfUsingVoucher>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.ToTable(tb => tb.HasTrigger("UpdateSmartLogsOfUsingVouchers"));

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.IdSource).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.SubSystem).HasMaxLength(50);
            entity.Property(e => e.UserFuntionCode).HasMaxLength(50);
            entity.Property(e => e.UserFuntionName).HasMaxLength(512);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartManufacture>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartManufacture");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContents).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(20);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.StageName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartMapColumnExcel>(entity =>
        {
            entity.ToTable("SmartMapColumnExcel");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ColumNameTable).HasMaxLength(50);
            entity.Property(e => e.ColumnDataType).HasMaxLength(50);
            entity.Property(e => e.ColumnNameExcel).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.IdSort).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Parameter).HasMaxLength(255);
            entity.Property(e => e.SignalTrue).HasMaxLength(50);
            entity.Property(e => e.TableName).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartOption>(entity =>
        {
            entity.HasKey(e => e.OpType);

            entity.ToTable("SmartOption");

            entity.Property(e => e.OpType).HasMaxLength(50);
            entity.Property(e => e.Contenst).HasMaxLength(512);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.ObjectUse).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartProductionDataSortMetal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartProductionDataSortMetal");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.Stagename).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartProductionDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartProductionData");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.Stagename).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartProductionLookup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SmartProductionLookup");

            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdDataHead).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContents).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.PersonAddress).HasMaxLength(255);
            entity.Property(e => e.PersonCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(20);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.StageName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNoInherit).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<SmartPromotionalProgram>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PromotionalPrograms");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BeginDate).HasColumnType("datetime");
            entity.Property(e => e.CodeData).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(100);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FormOfPromotionCode).HasMaxLength(50);
            entity.Property(e => e.FormOfPromotionName).HasMaxLength(250);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.NameData).HasMaxLength(250);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ProgramCode).HasMaxLength(50);
            entity.Property(e => e.ProgramName).HasMaxLength(250);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<SmartRecorveryMaterial>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.StageName).HasMaxLength(250);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartRecorveryMaterialsSave>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc }).HasName("PK_SmartRecorveryMaterials");

            entity.ToTable("SmartRecorveryMaterialsSave");

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartTableEven>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SmartTableEven");

            entity.Property(e => e.Fluff)
                .HasMaxLength(3500)
                .IsUnicode(false)
                .HasColumnName("FLUFF");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SmartTransportationCost>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountAccumulated).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountAllotment).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreditSide).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdData).HasMaxLength(50);
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TaxCode).HasMaxLength(20);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
        });

        modelBuilder.Entity<SmartTypeDataImportExcel>(entity =>
        {
            entity.HasKey(e => e.DataType);

            entity.ToTable("SmartTypeDataImportExcel");

            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DataName).HasMaxLength(255);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<SmartUseMaterial>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.StageCode).HasMaxLength(50);
            entity.Property(e => e.StageName).HasMaxLength(250);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartUseMaterialsSave>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc }).HasName("PK_SmartUseMaterials");

            entity.ToTable("SmartUseMaterialsSave");

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.Vatrate).HasColumnName("vatrate");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<SmartVatTaxList>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.ToTable("SmartVatTaxList", tb => tb.HasTrigger("TrigDeleteSmartVatTaxList"));

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ImportOrExport).HasMaxLength(50);
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceSign).HasMaxLength(50);
            entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(20);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TaxCode).HasMaxLength(20);
            entity.Property(e => e.VatType).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(150);
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__staffs__1963DD9C7A8544C7");

            entity.ToTable("staffs", "sales");

            entity.HasIndex(e => e.Email, "UQ__staffs__AB6E6164F1E495CB").IsUnique();

            entity.Property(e => e.StaffId).HasColumnName("staff_id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.ManagerId).HasColumnName("manager_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.StoreId).HasColumnName("store_id");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__staffs__manager___486754D8");

            entity.HasOne(d => d.Store).WithMany(p => p.Staff)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__staffs__store_id__4773309F");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => new { e.StoreId, e.ProductId }).HasName("PK__stocks__E68284D34EAB1D59");

            entity.ToTable("stocks", "production");

            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Product).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__stocks__product___55C14FF6");

            entity.HasOne(d => d.Store).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__stocks__store_id__54CD2BBD");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PK__stores__A2F2A30CCC7BC80B");

            entity.ToTable("stores", "sales");

            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.State)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.StoreName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("store_name");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("street");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("zip_code");
        });

        modelBuilder.Entity<TempDataBalanceSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempDataBalanceSheet");

            entity.Property(e => e.AccountSymbol).HasMaxLength(50);
            entity.Property(e => e.CreditBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalancEnd).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(20);
        });

        modelBuilder.Entity<TempSmartTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempSmartTable");

            entity.Property(e => e.ActualAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeWarehose).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(250);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.PumpColumnName).HasMaxLength(250);
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<TemplateBalanceSheet>(entity =>
        {
            entity.ToTable("TemplateBalanceSheet");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.Formula).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Presentation).HasMaxLength(255);
            entity.Property(e => e.Targets).HasMaxLength(250);
        });

        modelBuilder.Entity<TemplateBusinessResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BusinessResults");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.Formula).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Presentation).HasMaxLength(255);
            entity.Property(e => e.Targets).HasMaxLength(250);
        });

        modelBuilder.Entity<TemplateDirectCashFlow>(entity =>
        {
            entity.ToTable("TemplateDirectCashFlow");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.Formula).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Presentation).HasMaxLength(255);
            entity.Property(e => e.Targets).HasMaxLength(250);
        });

        modelBuilder.Entity<TemplateInDirectCashFlow>(entity =>
        {
            entity.ToTable("TemplateInDirectCashFlow");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.Formula).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Presentation).HasMaxLength(255);
            entity.Property(e => e.Targets).HasMaxLength(250);
        });

        modelBuilder.Entity<TemplateNotesToFinancialStatement>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.Formula).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Presentation).HasMaxLength(255);
            entity.Property(e => e.Targets).HasMaxLength(250);
        });

        modelBuilder.Entity<TradingCatalogVoucherNumber>(entity =>
        {
            entity.ToTable("TradingCatalogVoucherNumber");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ByDate).HasDefaultValue(false);
            entity.Property(e => e.CreditSide).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InheritFrom).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ReasonUse).HasMaxLength(255);
            entity.Property(e => e.SignVoucher).HasMaxLength(50);
            entity.Property(e => e.VoucherName).HasMaxLength(100);
        });

        modelBuilder.Entity<TradingLock>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeMonth).HasMaxLength(50);
            entity.Property(e => e.LockType).HasMaxLength(50);
            entity.Property(e => e.NameMonth).HasMaxLength(50);
            entity.Property(e => e.NameUnit).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TradingMenu>(entity =>
        {
            entity.ToTable("TradingMenu");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.MenuCaption).HasMaxLength(255);
            entity.Property(e => e.MenuImage).HasMaxLength(100);
            entity.Property(e => e.MenuLevel).HasMaxLength(50);
            entity.Property(e => e.MenuName).HasMaxLength(50);
            entity.Property(e => e.MenuNote).HasMaxLength(255);
            entity.Property(e => e.MenuParameters).HasMaxLength(50);
            entity.Property(e => e.ParameterReport).HasMaxLength(50);
            entity.Property(e => e.ParentMenu).HasMaxLength(50);
            entity.Property(e => e.TableName).HasMaxLength(50);
        });

        modelBuilder.Entity<TradingOption>(entity =>
        {
            entity.HasKey(e => e.OpType);

            entity.ToTable("TradingOption");

            entity.Property(e => e.OpType).HasMaxLength(50);
            entity.Property(e => e.Contenst).HasMaxLength(512);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<TradingOptionPrintOrder>(entity =>
        {
            entity.ToTable("TradingOptionPrintOrder");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Decision).HasMaxLength(250);
            entity.Property(e => e.FileDoc).HasMaxLength(100);
            entity.Property(e => e.NameDoc).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.Prameters).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(250);
            entity.Property(e => e.TypeDoc).HasMaxLength(50);
        });

        modelBuilder.Entity<TradingReport>(entity =>
        {
            entity.ToTable("TradingReport");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.DocTemplate).HasMaxLength(50);
            entity.Property(e => e.ExcelFileName).HasMaxLength(150);
            entity.Property(e => e.GroupContents1).HasMaxLength(100);
            entity.Property(e => e.GroupContents1Text).HasMaxLength(100);
            entity.Property(e => e.GroupContents2).HasMaxLength(100);
            entity.Property(e => e.GroupContents2Text).HasMaxLength(100);
            entity.Property(e => e.GroupHead).HasMaxLength(100);
            entity.Property(e => e.GroupHeadText).HasMaxLength(100);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.ImpDecision).HasMaxLength(255);
            entity.Property(e => e.NameReport).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Paramater).HasMaxLength(50);
            entity.Property(e => e.ReportFileName).HasMaxLength(150);
            entity.Property(e => e.StoreName).HasMaxLength(255);
            entity.Property(e => e.TableName).HasMaxLength(100);
            entity.Property(e => e.TemplateExcelCode).HasMaxLength(100);
            entity.Property(e => e.TemplateExcelText).HasMaxLength(100);
            entity.Property(e => e.TypeNameReport).HasMaxLength(250);
            entity.Property(e => e.TypeReport).HasMaxLength(50);
        });

        modelBuilder.Entity<TradingRuleReport>(entity =>
        {
            entity.ToTable("TradingRuleReport");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.NameReport).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<TradingRuleUnit>(entity =>
        {
            entity.ToTable("TradingRuleUnit");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeUser).HasMaxLength(20);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUnit).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(255);
        });

        modelBuilder.Entity<TradingRuleUser>(entity =>
        {
            entity.ToTable("TradingRuleUser");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.KeyFuntion).HasMaxLength(50);
            entity.Property(e => e.NameFuntion).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<TradingSmartContentsDatum>(entity =>
        {
            entity.HasKey(e => new { e.IdContents, e.IdAsc });

            entity.HasIndex(e => new { e.IdAsc, e.CommodityCode }, "Idx_TradingSalesSmartContentsData")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdContents).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.ActualAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditSide).HasMaxLength(20);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DebitSide).HasMaxLength(20);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(150);
            entity.Property(e => e.IdSource).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ProgramCode).HasMaxLength(250);
            entity.Property(e => e.PumpColumnCode).HasMaxLength(50);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.TypeVat).HasMaxLength(255);
            entity.Property(e => e.UnitPackage).HasMaxLength(50);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VoucherNumberContents).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<TradingSmartDataAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TradingSmartDataAll");

            entity.Property(e => e.ActualAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CitizenIdentification).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ContractNo).HasMaxLength(50);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DateOfIssue).HasColumnType("smalldatetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContest).HasMaxLength(255);
            entity.Property(e => e.NumBerofferToExport).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PlaceOfIssue).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SignDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VehiclesName).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<TradingSmartDataAllSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TradingSmartDataAllSum");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ReasonName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TradingSmartDataSell>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TradingSmartDataSells");

            entity.Property(e => e.ActualAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountDiscount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountFeeEnvironRate).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVat).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AmountWithoutVatFee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CitizenIdentification).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.ContractNo).HasMaxLength(50);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DateOfIssue).HasColumnType("smalldatetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NotesContest).HasMaxLength(255);
            entity.Property(e => e.NumBerofferToExport).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PlaceOfIssue).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SignDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.VehiclesName).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<TradingSmartDatum>(entity =>
        {
            entity.HasIndex(e => new { e.Id, e.RecordDate, e.DataType }, "Idx_TradingSmartData")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CitizenIdentification).HasMaxLength(50);
            entity.Property(e => e.CodeAppraisal).HasMaxLength(50);
            entity.Property(e => e.CodeMethodExpImp).HasMaxLength(50);
            entity.Property(e => e.ContractNo).HasMaxLength(50);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DataName).HasMaxLength(150);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DateOfIssue).HasColumnType("smalldatetime");
            entity.Property(e => e.DebitBalance).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DebtBalanc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DecisionNo).HasMaxLength(150);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdTablePrice).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.LevelDiscount).HasMaxLength(20);
            entity.Property(e => e.LicensePlates).HasMaxLength(50);
            entity.Property(e => e.Loaiphieu)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEU");
            entity.Property(e => e.Loaiphieuhd)
                .HasMaxLength(50)
                .HasColumnName("LOAIPHIEUHD");
            entity.Property(e => e.MethodOfPaymentsCode).HasMaxLength(50);
            entity.Property(e => e.MethodOfPaymentsName).HasMaxLength(255);
            entity.Property(e => e.ModifyBy).HasMaxLength(50);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NameAppraisal).HasMaxLength(255);
            entity.Property(e => e.NameMethodExpImp).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.NumBerofferToExport).HasMaxLength(50);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ObjectAddress).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.ObjectName).HasMaxLength(255);
            entity.Property(e => e.ObjectTaxCode).HasMaxLength(20);
            entity.Property(e => e.PersonName).HasMaxLength(250);
            entity.Property(e => e.PlaceOfIssue).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ShippingMethodsCode).HasMaxLength(50);
            entity.Property(e => e.ShippingMethodsName).HasMaxLength(255);
            entity.Property(e => e.SignDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StaffCode).HasMaxLength(50);
            entity.Property(e => e.StaffName).HasMaxLength(50);
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VehiclesName).HasMaxLength(255);
            entity.Property(e => e.VoucherDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
            entity.Property(e => e.WarehoseNameReceive).HasMaxLength(255);
        });

        modelBuilder.Entity<TradingUnitInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TradingUnitInfo");

            entity.Property(e => e.AccName).HasMaxLength(50);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.AddressUnit).HasMaxLength(255);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.Decide).HasMaxLength(150);
            entity.Property(e => e.DirectorName).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.FaxNumber).HasMaxLength(50);
            entity.Property(e => e.From).HasMaxLength(50);
            entity.Property(e => e.HeadofDepartment).HasMaxLength(50);
            entity.Property(e => e.HeadofShifts).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PositionAcc).HasMaxLength(50);
            entity.Property(e => e.PositionDir).HasMaxLength(50);
            entity.Property(e => e.PositionReport).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ReportDate).HasMaxLength(150);
            entity.Property(e => e.ReporterName).HasMaxLength(50);
            entity.Property(e => e.Stocker).HasMaxLength(50);
            entity.Property(e => e.SubordinateName).HasMaxLength(255);
            entity.Property(e => e.SuperiorName).HasMaxLength(255);
            entity.Property(e => e.Taxcode).HasMaxLength(50);
            entity.Property(e => e.Treasurer).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TradingUser>(entity =>
        {
            entity.HasKey(e => e.CodeUser);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("DeleteTradingUsers");
                    tb.HasTrigger("InsertTrading");
                });

            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(50);
            entity.Property(e => e.AddressWarehose).HasMaxLength(255);
            entity.Property(e => e.Apipassword)
                .HasMaxLength(100)
                .HasColumnName("APIPassword");
            entity.Property(e => e.Apitaxcode)
                .HasMaxLength(50)
                .HasColumnName("APITaxcode");
            entity.Property(e => e.Apiurl)
                .HasMaxLength(255)
                .HasColumnName("APIUrl");
            entity.Property(e => e.Apiuser)
                .HasMaxLength(50)
                .HasColumnName("APIUser");
            entity.Property(e => e.CodeWarehose).HasMaxLength(50);
            entity.Property(e => e.CostAcc).HasMaxLength(50);
            entity.Property(e => e.DebitAcc).HasMaxLength(50);
            entity.Property(e => e.DeliveryPointCode).HasMaxLength(100);
            entity.Property(e => e.EmailUser).HasMaxLength(100);
            entity.Property(e => e.HiloUserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdInvoice).HasMaxLength(10);
            entity.Property(e => e.ManagerName).HasMaxLength(50);
            entity.Property(e => e.NameUser).HasMaxLength(50);
            entity.Property(e => e.NameWarehose).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.ObjectCode).HasMaxLength(50);
            entity.Property(e => e.ObjectName).HasMaxLength(150);
            entity.Property(e => e.PassUser).HasMaxLength(100);
            entity.Property(e => e.TaxEnviPro).HasMaxLength(30);
            entity.Property(e => e.TaxRevenue).HasMaxLength(30);
            entity.Property(e => e.VatAccount).HasMaxLength(20);
            entity.Property(e => e.WarehoseData).HasMaxLength(50);
        });

        modelBuilder.Entity<TradingUserLog>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DateAction)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FunctionName).HasMaxLength(250);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(1024);
            entity.Property(e => e.TypeOrderOrCode).HasMaxLength(250);
            entity.Property(e => e.UserExc).HasMaxLength(50);
        });

        modelBuilder.Entity<UnitInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UnitInfo");

            entity.Property(e => e.AccName).HasMaxLength(50);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.AddressUnit).HasMaxLength(255);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.Decide).HasMaxLength(150);
            entity.Property(e => e.DirectorName).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.FaxNumber).HasMaxLength(50);
            entity.Property(e => e.From).HasMaxLength(50);
            entity.Property(e => e.HeadofDepartment).HasMaxLength(50);
            entity.Property(e => e.HeadofShifts).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PositionAcc).HasMaxLength(50);
            entity.Property(e => e.PositionDir).HasMaxLength(50);
            entity.Property(e => e.PositionReport).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ReportDate).HasMaxLength(150);
            entity.Property(e => e.ReporterName).HasMaxLength(50);
            entity.Property(e => e.Stocker).HasMaxLength(50);
            entity.Property(e => e.SubordinateName).HasMaxLength(255);
            entity.Property(e => e.SuperiorName).HasMaxLength(255);
            entity.Property(e => e.Taxcode).HasMaxLength(50);
            entity.Property(e => e.Treasurer).HasMaxLength(50);
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.CodeUser);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("DeleteUser");
                    tb.HasTrigger("InsertUser");
                });

            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.Apipassword)
                .HasMaxLength(100)
                .HasColumnName("APIPassword");
            entity.Property(e => e.Apitaxcode)
                .HasMaxLength(50)
                .HasColumnName("APITaxcode");
            entity.Property(e => e.Apiurl)
                .HasMaxLength(255)
                .HasColumnName("APIUrl");
            entity.Property(e => e.Apiuser)
                .HasMaxLength(50)
                .HasColumnName("APIUser");
            entity.Property(e => e.DeliveryPointCode).HasMaxLength(100);
            entity.Property(e => e.EmailUser).HasMaxLength(100);
            entity.Property(e => e.HiloUserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HiloUserNameNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HiloUserNameNA");
            entity.Property(e => e.HiloUserNameQb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HiloUserNameQB");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.NameUser).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PassUser).HasMaxLength(100);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(255);
        });

        modelBuilder.Entity<UserLog>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DateAction)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(1024);
            entity.Property(e => e.TypeOrderOrCode).HasMaxLength(250);
            entity.Property(e => e.UserExc).HasMaxLength(50);
        });

        modelBuilder.Entity<UserLogsSave>(entity =>
        {
            entity.ToTable("UserLogsSave");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DateAction)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FunctionName).HasMaxLength(512);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.Notes).HasMaxLength(1024);
            entity.Property(e => e.TypeOrderOrCode).HasMaxLength(250);
            entity.Property(e => e.UserExc).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewData131>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewData131");

            entity.Property(e => e.AccountSymbol).HasMaxLength(20);
            entity.Property(e => e.AmountOfMoney).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.ObjectCode).HasMaxLength(20);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ViewDataCompareExp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewDataCompareExp");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewDataCompareImp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewDataCompareImp");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewDataCompareRemainder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewDataCompareRemainder");

            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSalesDataDetailsInv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewSalesDataDetailsInv");

            entity.Property(e => e.AmountOfMoneyExpSell).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoneyExpSellRetail).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoneyImpReturn).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSalesDataImpExp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewSalesDataImpExp");

            entity.Property(e => e.AmountAfterDiscount).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseCodeReceive).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSalesDataInv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewSalesDataINV");

            entity.Property(e => e.AmountOfMoneyExpSell).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoneyExpSellRetail).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoneyImpReturn).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSalesWarehose>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewSalesWarehose");

            entity.Property(e => e.AmountOfMoneyExpSell).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoneyExpSellRetail).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.AmountOfMoneyImpReturn).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<WsmartCatalogInventory>(entity =>
        {
            entity.ToTable("WSmartCatalogInventory");

            entity.Property(e => e.Barcode).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(250);
            entity.Property(e => e.MonthCode).HasMaxLength(10);
            entity.Property(e => e.MonthName).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<WsmartCatalogInventoryNew>(entity =>
        {
            entity.ToTable("WSmartCatalogInventoryNEW");

            entity.Property(e => e.Barcode).HasMaxLength(50);
            entity.Property(e => e.CodeSupplier).HasMaxLength(50);
            entity.Property(e => e.CommodityCode).HasMaxLength(50);
            entity.Property(e => e.CommodityName).HasMaxLength(255);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(250);
            entity.Property(e => e.MonthCode).HasMaxLength(10);
            entity.Property(e => e.MonthName).HasMaxLength(150);
            entity.Property(e => e.NameSupplier).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(250);
            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
            entity.Property(e => e.WarehoseName).HasMaxLength(250);
        });

        modelBuilder.Entity<WsmartDateInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WSmartDateInventory");

            entity.Property(e => e.RecordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);
        });

        modelBuilder.Entity<WsmartFieldProperty>(entity =>
        {
            entity.ToTable("WSmartFieldProperty");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Align).HasMaxLength(50);
            entity.Property(e => e.CodeField).HasMaxLength(50);
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Format).HasMaxLength(50);
            entity.Property(e => e.IdGridSetting).HasMaxLength(50);
            entity.Property(e => e.IsInvisible).HasDefaultValue(true);
            entity.Property(e => e.IsPrimaryKey).HasDefaultValue(false);
            entity.Property(e => e.NameField).HasMaxLength(50);
            entity.Property(e => e.Width).HasMaxLength(50);
        });

        modelBuilder.Entity<WsmartFormSetting>(entity =>
        {
            entity.ToTable("WSmartFormSetting");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeForm).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GroupBy).HasMaxLength(150);
            entity.Property(e => e.Height).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NameForm).HasMaxLength(50);
            entity.Property(e => e.NameTable).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(50);
            entity.Property(e => e.OrderBy).HasMaxLength(150);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.StoredProcedure).HasMaxLength(50);
            entity.Property(e => e.TypeForm).HasMaxLength(50);
            entity.Property(e => e.Width).HasMaxLength(50);
        });

        modelBuilder.Entity<WsmartInventoryResult>(entity =>
        {
            entity.ToTable("WSmartInventoryResults");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Barcode).HasMaxLength(512);
            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.DeviceName).HasMaxLength(50);
            entity.Property(e => e.GrpCode).HasMaxLength(50);
            entity.Property(e => e.GrpName).HasMaxLength(250);
            entity.Property(e => e.InvNumber).HasMaxLength(50);
            entity.Property(e => e.InvTime).HasColumnType("smalldatetime");
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(100);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(250);
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.UnitPcs).HasMaxLength(50);
            entity.Property(e => e.WarehoseCode).HasMaxLength(250);
            entity.Property(e => e.WarehoseName).HasMaxLength(500);
        });

        modelBuilder.Entity<WsmartInventoryResultsAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WSmartInventoryResultsAll");

            entity.Property(e => e.Barcode).HasMaxLength(512);
            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.DataType).HasMaxLength(2);
            entity.Property(e => e.DeviceName).HasMaxLength(50);
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.NumberOfVouchers).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(250);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.TypeName).HasMaxLength(250);
            entity.Property(e => e.WarehoseCode).HasMaxLength(250);
            entity.Property(e => e.WarehoseData).HasMaxLength(250);
            entity.Property(e => e.WarehoseName).HasMaxLength(500);
        });

        modelBuilder.Entity<WsmartInventorySheet>(entity =>
        {
            entity.HasKey(e => e.InvNumber);

            entity.ToTable("WSmartInventorySheet");

            entity.Property(e => e.InvNumber).HasMaxLength(100);
            entity.Property(e => e.CodeUser).HasMaxLength(50);
            entity.Property(e => e.CodeWarehose).HasMaxLength(250);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.DeviceName).HasMaxLength(50);
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.InventoryArea).HasMaxLength(50);
            entity.Property(e => e.InventoryTime).HasColumnType("smalldatetime");
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(100);
            entity.Property(e => e.NoteInvSheet).HasMaxLength(250);
        });

        modelBuilder.Entity<WsmartLogger>(entity =>
        {
            entity.ToTable("WSmartLoggers");

            entity.Property(e => e.ClientIp).HasColumnName("ClientIP");
            entity.Property(e => e.Properties).HasColumnType("xml");
            entity.Property(e => e.WarehoseCode).HasMaxLength(500);
        });

        modelBuilder.Entity<WsmartMenu>(entity =>
        {
            entity.ToTable("WSmartMenu");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DisPlay).HasMaxLength(150);
            entity.Property(e => e.Href).HasMaxLength(255);
            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.IconMobile).HasMaxLength(150);
            entity.Property(e => e.Match).HasMaxLength(50);
            entity.Property(e => e.MenuLevel).HasMaxLength(50);
        });

        modelBuilder.Entity<WsmartMenuRule>(entity =>
        {
            entity.ToTable("WSmartMenuRule");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Alias).HasMaxLength(250);
            entity.Property(e => e.MgName).HasMaxLength(250);
            entity.Property(e => e.Mid).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(250);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<WsmartProperty>(entity =>
        {
            entity.ToTable("WSmartProperty");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Align).HasMaxLength(50);
            entity.Property(e => e.CodeField).HasMaxLength(50);
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DropDownBindValue).HasMaxLength(50);
            entity.Property(e => e.DropDownText).HasMaxLength(50);
            entity.Property(e => e.DropDownValue).HasMaxLength(50);
            entity.Property(e => e.Format).HasMaxLength(50);
            entity.Property(e => e.IdAsc).ValueGeneratedOnAdd();
            entity.Property(e => e.IdSource).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsInvisible).HasDefaultValue(true);
            entity.Property(e => e.IsPrimaryKey).HasDefaultValue(false);
            entity.Property(e => e.IsRequired).HasDefaultValue(true);
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);
            entity.Property(e => e.NameField).HasMaxLength(250);
            entity.Property(e => e.Notes)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Width).HasMaxLength(50);
        });

        modelBuilder.Entity<WsmartReport>(entity =>
        {
            entity.ToTable("WSmartReport");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeReport).HasMaxLength(50);
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.NameReport).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(50);
            entity.Property(e => e.Parameter).HasMaxLength(50);
            entity.Property(e => e.StoredProcedure).HasMaxLength(50);
            entity.Property(e => e.TableReport).HasMaxLength(50);
        });

        modelBuilder.Entity<WsmartRole>(entity =>
        {
            entity.ToTable("WSmartRoles");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<WsmartRoleClaim>(entity =>
        {
            entity.ToTable("WSmartRoleClaims");

            entity.Property(e => e.RoleId).HasMaxLength(450);

            entity.HasOne(d => d.Role).WithMany(p => p.WsmartRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<WsmartRuleFuntion>(entity =>
        {
            entity.ToTable("WSmartRuleFuntion");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.MenuName).HasMaxLength(250);
            entity.Property(e => e.Note).HasMaxLength(250);
        });

        modelBuilder.Entity<WsmartUser>(entity =>
        {
            entity.ToTable("WSmartUsers");

            entity.Property(e => e.AddressUser).HasMaxLength(250);
            entity.Property(e => e.Chucvu)
                .HasMaxLength(150)
                .HasColumnName("CHUCVU");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasMaxLength(20)
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.GrpUser).HasMaxLength(150);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.ProfilePictureDataUrl).HasColumnType("text");
            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserName).HasMaxLength(256);
            entity.Property(e => e.WarehoseCode).HasMaxLength(50);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "WsmartUserRole",
                    r => r.HasOne<WsmartRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<WsmartUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("WSmartUserRoles");
                    });
        });

        modelBuilder.Entity<WsmartUserClaim>(entity =>
        {
            entity.ToTable("WSmartUserClaims");

            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.WsmartUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<WsmartUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("WSmartUserLogins");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.WsmartUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<WsmartUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("WSmartUserTokens");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.WsmartUserTokens).HasForeignKey(d => d.UserId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
