using ConsoleApp1.SVC_CreditOperation;
using System;
using System.Collections.Generic;
using ConsoleApp1.DomainMappers;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        #region Constans

        public static System.Net.NetworkCredential networkCredentialForm1 = new System.Net.NetworkCredential("form1", "form12345", "vantyx");

        public static int C_PrivatePerson_EntityTypeId = 2;             // Person
        public static int C_Corporate_EntityTypeId = 1;                 // Company
        public static int C_MaritalStatus = 1;                          // SINGLE
        public static int C_ResidenceType = 2;                          // OWNED WITH RENT
        public static int C_ActivityTypeContext = 1;                    // CAE

        public static long C_EntityEmailType = 2;                       // Entity Email of type Communication Email
        public static int C_LegalDocType = 501;                         // Legal Doc Type of Fiscal Number

        public const int C_EquipmentTypeId = 100;                       // Vehicle          <EquipmentTypeId to used>       --> to be defined in some portal configuration, or extracted from FinancialProduct
        public const int C_EquipmentCategoryId = 101;                   // Passenger Car    <EquipmentCategory to used>     --> to be defined in some portal configuration, or extracted from FinancialProduct
        public static int? C_PurposeTypeId = null;                      //                  <PurposeTypeId to used>         --> to be defined in some portal configuration, or extracted from FinancialProduct

        public const int C_ClientTaxRegimeId = 1;                       // Corresponds to "MAIN LAND" Tax

        public const int C_AplCompanyId = 1;                            // Corresponds to "DEMO BANK" >>> <AplCompanyId = Our Company>; 

        public const int C_AplBusinessId_Credit = 4;                    // Consumer Credit >>>      <AplBusinessId to used> --> to be defined in some portal configuration  
        public const int C_AplBusinessId_Leasing = 1;                   // Consumer Leasing >>>     <AplBusinessId to used> --> to be defined in some portal configuration  
        public const int C_AplBusinessId_Renting = 13;                  // Renting >>>              <AplBusinessId to used> --> to be defined in some portal configuration  

        public const int C_Equip_FinancialProductId = 43;               // Traditional Credit with Balloon Payment
        public const int C_CredPessoal_FinancialProductId = 1165;       // Credit w/o Equipment
        public const int C_Equip_Leasing_FinancialProductId = 1162;      // Leasing Auto

        public const long C_DefaultSupplierEntityId = 2807;             // EntityId of the supplier for test purposes

        #endregion

        static void Main(string[] args)
        {
            // ------------------------------------- DAY 1 -------------------------------------

            #region Day 1

            #region Login

            #region Demo Login

            SVC_Logon.LoginInfo info = Login(true);
            Console.WriteLine("token: {0} ", info.SessionToken);
            Console.WriteLine("username: {0}" + Environment.NewLine, info.UserLogin);

            #endregion

            #region Exercise1_Login

            // Insert Code Here
            // Already Created the method: Exercise1_Login(bool isWindowsUser)

            #endregion

            #endregion

            #region Basic Lists

            #region Demo Basic Lists

            //SVC_EntitiesBasicList.CodeAbbreviation[] listOfCompanies = GetCompaniesList(info.SessionToken);

            //if (listOfCompanies != null)
            //    foreach (SVC_EntitiesBasicList.CodeAbbreviation ca in listOfCompanies)
            //        Console.WriteLine("Code: " + ca.Code + " Abrev:  " + ca.Abbreviation + " Descr: " + ca.Description);

            //Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise2_GetEntityTypeList

            // Insert Code Here
            // Already created the Method:  Exercise2_GetEntityTypeList(string token)

            #endregion

            #endregion

            #endregion

            // ------------------------------------- DAY 2 -------------------------------------

            #region Day 2

            #region Search Entity

            #region Demo GetEntityInfo
            
            //Day2_GetEntityInfo(info);
            
            #endregion

            #region Day2_Exercise3_SearchEntity

            // Insert Code Here
            // Already created the Method: Day2_Exercise3_SearchEntity(SVC_Logon.LoginInfo info)

            #endregion

            #endregion

            #region Create Entity

            #region Demo Create Entity
            
            //Day2_CreateEntity(info);
            
            #endregion

            #region Day2_Exercise4_CreateEntity

            // Insert Code Here
            // Already created the Methods:
            //      Day2_Exercise4_CreateEntity(SVC_Logon.LoginInfo info)
            //      Exercise_CreateNewEntity()
            //      Example_SaveEntity

            #endregion

            #endregion

            #region Update Entity

            long entityId = 37814;

            #region Demo Update Entity            
            //string newEmailAddress = "newEmailAddress@email.com";
            //SVC_Entities.Entity entity = Day2_UpdateEntity(info, entityId, newEmailAddress);
            //SaveEntity(info.SessionToken, entity);
            #endregion

            #region Exercise5_UpdateEntity

            // Insert Code Here
            // Already created the Method: Day2_Exercise5_UpdateEntity(SVC_Logon.LoginInfo info, long entityId, string newAddress, string newFiscalNumber)

            #endregion

            #endregion

            #region Get Vehicle Information (Brand; Mode; Version; VehicleInfo)

            #region Demo Get Vehicle Information
            //Day2_GetVehicleInformation(info);
            #endregion

            #region Day2_Exercise6_GetVehicleInformation

            // Insert Code Here
            // Already created the Method: Day2_Exercise6_GetVehicleInformation(SVC_Logon.LoginInfo info)

            #endregion

            #endregion

            #endregion

            // ------------------------------------- DAY 3 -------------------------------------

            #region Day 3

            #region Get Financial Products

            #region Demo Get Financial Products
            //Day3_GetFinancialProduct(info);
            #endregion

            #region Day3_Exercise7_GetFinancialProduct

            // Insert Code Here
            // Already created the Method: Day3_Exercise7_GetFinancialProduct(SVC_Logon.LoginInfo info)

            #endregion

            #endregion

            #region Financial Products Limits

            #region Demo Get Financial Products Limits
            //Day3_GetFinancialProductLimits(info);
            #endregion

            #region Day3_Exercise8_GetFinancialProductLimits

            // Insert Code Here
            // Already created the Method: Day3_Exercise8_GetFinancialProductLimits(SVC_Logon.LoginInfo info)

            #endregion

            #endregion

            #region Create Quotation

            #region Demo Create Quotation (Credit)

            #region Create Quotation With Equipment
            //CredOper quotationDay3 = Day3_CreateQuotationWithEquipment(info);
            #endregion

            #region Create Quotation Without Equipment
            //CredOper quotationWithoutEqDay3 = Day3_CreateQuotationWithoutEquipment(info);
            #endregion

            #endregion

            #region Exercise 9 - Create Quotation (Leasing)

            // Insert Code Here
            // Already created the Methods: 
            //      Day3_Exercixe9_CreateQuotationWithEquipment(SVC_Logon.LoginInfo info)
            //      Day3_Exercise9_GetFinancialProductLimits(string token, CredOper credOper, int finProdId, out int? FinProd_FinDueRegime, out int? FinProd_Period)
            //      Other methods may need to be modified

            #endregion

            #endregion

            #endregion

            // ------------------------------------- DAY 4 -------------------------------------

            #region Day 4

            #region Day4_CalculateQuotations

            #region Demo Calculate Quotations

            #region Day4_CalculateQuotation (before quotation being saved)

            // create a quotation with 60 months, then calculate a second time with 48 months (without saving it)
            //CredOper quotationDay4 = Day3_CreateQuotationWithEquipment(info); // create quotation with original 60 months
            //quotationDay4 = Day4_CalculateQuotationWithNewTerm(info, quotationDay4); // calculate with new term of 48 months

            #endregion

            #region Day4_CalculateQuotation (after quotation being saved)

            #region change term after saved quotation (60 to 48 motnhs)

            //CredOper quotationDay4_2 = Day3_CreateQuotationWithEquipment(info); // create quotation with original 60 months
            //long quotationDay4ID2 = Day4_SaveQuotation(info, quotationDay4_2); // Save quotation with 60 motnhs term

            //quotationDay4_2 = Day4_CalculateQuotationWithNewTermAfterSaved(info, quotationDay4ID2); // get the quotation and calculate with new term of 36 months
            //quotationDay4ID2 = Day4_SaveQuotation(info, quotationDay4_2); // calculate with new term of 48 months

            #endregion

            #region change term after saved quotation (previously from 60 to 48 before save, now after save from 48 to 36 motnhs)

            // Save the Quotation created in Day 4 (where we change the original Term for 48 months)
            //long quotationDay4ID = Day4_SaveQuotation(info, quotationDay4);

            // Take the quotation from day 4 with 48 months and calculate it with 36 months and save it again
            //quotationDay4 = Day4_CalculateQuotationWithNewTermAfterSaved(info, quotationDay4ID);
            //quotationDay4ID = Day4_SaveQuotation(info, quotationDay4);

            #endregion

            #endregion

            #endregion

            #region Exercise10 - Calculate Quotation

            #region Exercise10 CalculateQuotation (before quotation being saved)

            // Insert Code Here
            // Already created the Method: Day4_Exercise10_CalculateQuotationWithNewTerm(SVC_Logon.LoginInfo info, CredOper credOper)
            //      Day4_Exercise10_CalculateQuotationWithNewTermAfterSaved(SVC_Logon.LoginInfo info, long credOperId)

            #endregion

            #region Exercise10 CalculateQuotation (after quotation being saved)

            #region change term after saved quotation (60 to 48 motnhs)

            // Insert Code Here
            // Already created the Method: Day4_Exercise10_CalculateQuotationWithNewTermAfterSaved(SVC_Logon.LoginInfo info, long credOperId)

            #endregion

            #region change term after saved quotation (previously from 60 to 48 before save, now after save from 48 to 36 motnhs)

            // Insert Code Here
            // Already created the Method: Day4_Exercise10_CalculateQuotationWithNewTermAfterSaved(SVC_Logon.LoginInfo info, long credOperId)

            #endregion

            #endregion

            #endregion

            #endregion

            #region Day4_SaveQuotation

            #region Save Quotations created in Day 3 

            //with Equipment and original Term of 60 months
            //long quotationDay3ID = Day4_SaveQuotation(info, quotationDay3);

            //without Equipment and original Term of 60 months
            //long quotationWithoutEqDay3ID = Day4_SaveQuotation(info, quotationWithoutEqDay3);

            #endregion

            #region Save Quotation created in Day 3 - Exercise 9
            //save quotation from Exercise 9
            //long quotationDay3_Exercise9 = Day4_SaveQuotation(info, exercise9Quotation);
            #endregion

            #endregion

            #region Day4_QuotationToProposal

            #region Demo Quotation to Proposal

            #region Day4_GetCurrentAvailableTransitions and Promote Quotation to Proporal

            //CredOper quotationDay4_3 = Day3_CreateQuotationWithEquipment(info); // create new quotation with original 60 months
            //long quotationDay4ID3 = Day4_SaveQuotation(info, quotationDay4_3); // Save quotation with 60 motnhs term

            //long transitionId = Day4_GetCurrentAvailableTransitions(info, quotationDay4ID3);

            //CredOper proposal = Day4_QuotationToProposal(info, quotationDay4ID3);

            #endregion

            #region Promote to proposal the quotation from Day 3 - Exercise 9
            // Insert code here
            #endregion

            #endregion

            #region Exercise11 - Quotation to Proposal

            // Insert Code Here
            // Already created the Method: Day4_Exercise11_QuotationToProposal(SVC_Logon.LoginInfo info, long quotationId)
            // Also consider what methods you may need to create in DomainTranslator.cs

            #endregion

            #endregion

            #endregion

            // ------------------------------------- DAY 5 -------------------------------------

            #region Day 5 - Exam

            // Insert Code Here
            // Already created the Method: 

            #endregion
        }

        // -------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------ DAY 1 ------------------------------------------------------

        #region Day 1   

        #region Day 1 - Login -

        #region Demo Login
        private static SVC_Logon.LoginInfo Login(bool isWindowsUser)
        {
            SVC_Logon.LogonClient clientLogon = new SVC_Logon.LogonClient();
            SVC_Logon.LoginExtraInfo extra = new SVC_Logon.LoginExtraInfo();
            SVC_Logon.LoginInfo loginInfo;

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            if (isWindowsUser) // For windows user
            {
                clientLogon.ClientCredentials.Windows.ClientCredential = networkCredentialForm1;

                loginInfo = clientLogon.LoginWindowsUserAndGetToken2("form1", "S-1-5-21-969721833-2662559552-2547471360-29738", "en-GB", "en-GB", extra.UserMachine, "en-GB", "en-GB");
                //loginInfo = clientLogon.LoginWindowsUserAndGetToken(userName, extra);
            }
            else // For custom user
            {
                clientLogon.ClientCredentials.Windows.ClientCredential = networkCredentialForm1;
                loginInfo = clientLogon.LoginCustomUserAndGetToken("accipienswebservices", "form12345@", extra);
            }

            return loginInfo;
        }
        #endregion

        #region Exercise 1 – Login  
        private static SVC_Logon.LoginInfo Exercise1_Login(bool isWindowsUser)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Exercise1_Login --------------------");

            // Insert Code Here

            return null;
        }
        #endregion

        #endregion

        #region Day 1 - Basic Lists -

        #region Demo Basic Lists
        public static SVC_EntitiesBasicList.CodeAbbreviation[] GetCompaniesList(string token)
        {
            try
            {
                SVC_EntitiesBasicList.SessionTokenWcfHeader tokenHeader = new SVC_EntitiesBasicList.SessionTokenWcfHeader { Token = token };

                // create the WebService client (in this case the SVC_EntityBasicList)
                SVC_EntitiesBasicList.EntitiesBasicListsClient clientEntBasicLists = new SVC_EntitiesBasicList.EntitiesBasicListsClient();
                
                // set the credentials
                //clientEntBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientEntBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;
                
                // create the desired Basic List
                SVC_EntitiesBasicList.BasicList basicList = clientEntBasicLists.GetDataList(tokenHeader, SVC_EntitiesBasicList.EntitiesDataListId.AplCompany);

                if (basicList == null || basicList.List == null)
                    return null;

                return basicList.List;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }
        #endregion

        #region Exercise 2 – Retrieve the Basic List Data from a database object 
        public static SVC_EntitiesBasicList.CodeAbbreviation[] Exercise2_GetEntityTypeList(string token)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Exercise2_GetEntityTypeList --------------------");

            // Insert Code Here

            return null;
        }
        #endregion

        #endregion

        #endregion

        // -------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------ DAY 2 ------------------------------------------------------

        #region Day 2

        #region Day 2 - Search Entity - 

        #region Demo Search Entity
        private static void Day2_GetEntityInfo(SVC_Logon.LoginInfo info)
        {
            try
            {
                string token = info.SessionToken;

                SVC_Entities.SessionTokenWcfHeader tokenHeader = new SVC_Entities.SessionTokenWcfHeader { Token = token };

                // search entities and get entities data
                SVC_Entities.EntitiesClient clientEntities = new SVC_Entities.EntitiesClient();
                
                // set credentials
                //clientEntities.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientEntities.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                // *******************************************
                // SEARCH ENTITIES
                // *******************************************
                List<SVC_Entities.BusinessConstraint> constraints = new List<SVC_Entities.BusinessConstraint>();

                List<SVC_Entities.BusinessOrderInfo> orderinfoList = new List<SVC_Entities.BusinessOrderInfo>();                

                // Create the constraint of entities where the full name contains the string "*customer*"
                SVC_Entities.BusinessConstraint constraint = new SVC_Entities.BusinessConstraint {   FullContext = "ENTITY", Field = (int)SVC_Entities.EntityField.FullName, ConstraintValue = "*customer*" };
                constraints.Add(constraint);                               

                SVC_Entities.BusinessOrderInfo orderinfo = new SVC_Entities.BusinessOrderInfo { FullContext = "ENTITY", Field = (int)SVC_Entities.EntityField.FullName,  Order = SVC_Entities.OrderType.Ascendant };
                orderinfoList.Add(orderinfo);

                // add the constraint to the search criteria
                SVC_Entities.SearchCriteria criterias = new SVC_Entities.SearchCriteria { Constraints = constraints.ToArray() };

                // search entities with that seach criteria
                SVC_Entities.SearchResult result = clientEntities.SearchEntities(tokenHeader, SVC_Entities.EntitiesSearchClass.Entity, criterias);

                // check if found results
                if (result != null && result.Keys != null && result.Keys.Length > 0)
                {
                    Console.WriteLine(Environment.NewLine + " ------- Day2_GetEntityInfo Founded Records -> {0} -------", result.Keys.Length);

                    for (int j = 0; j < result.Keys.Length; j++)
                    {
                        // Define the details you want to retrieve from the entities ( Detail Type Deep and Detail Person)
                        SVC_Entities.BusinessDetailFetchInfo[] details = {  new SVC_Entities.BusinessDetailFetchInfo { Type = SVC_Entities.SelectType.Deep, Detail = (int)SVC_Entities.EntityDetail.Person },
                                                                            new SVC_Entities.BusinessDetailFetchInfo { Type = SVC_Entities.SelectType.Deep, Detail = (int)SVC_Entities.EntityDetail.Company }};

                        SVC_Entities.BusinessEntityKey[] keys = { result.Keys[j] };
                        SVC_Entities.Entity[] entities = clientEntities.GetEntityByKeys(tokenHeader, keys, false, details);

                        for (int i = 0; i < entities.Length; i++)
                        {
                            Console.WriteLine(Environment.NewLine + "Search entity {0}", (j + 1));
                            Console.WriteLine("Full Name: {0}", entities[i].FullName);
                            Console.WriteLine("Entity Number: {0}", entities[i].EntityNumber);
                            Console.WriteLine("Entity State Id: {0}", entities[i].AutUserStateId);
                            Console.WriteLine("Entity Type: {0}", entities[i].EntityTypeId);

                            if (entities[i].EntityTypeId == C_PrivatePerson_EntityTypeId)
                                Console.WriteLine("Person Birth Date: {0}", entities[i].Person.BirthDate);
                            else if (entities[i].EntityTypeId == C_Corporate_EntityTypeId)
                                Console.WriteLine("Company Number of Employees: {0} ", entities[i].Company.Employees);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + " ------- Day2_GetEntityInfo Founded Records -> 0 -------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region Exercise 3 – Search an Entity 
        private static void Day2_Exercise3_SearchEntity(SVC_Logon.LoginInfo info)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day2_Exercise3_SearchEntity --------------------");

            // Insert Code Here
        }
        #endregion

        #endregion

        #region Day 2 - Create Entity -

        #region Demo Create Entity

        private static void Day2_CreateEntity(SVC_Logon.LoginInfo info)
        {
            Console.WriteLine("--------- Create New Entity ---------");
            SVC_Entities.Entity newEntity = CreateNewEntity();

            if (newEntity != null)
                SaveEntity(info.SessionToken, newEntity);
            else
                Console.WriteLine("Entity came out Null");

        }

        private static SVC_Entities.Entity CreateNewEntity()
        {
            try
            {
                // *******************************************
                // SAVE NEW Entity - PrivatePerson
                // *******************************************
                SVC_Entities.Entity newEntity = new SVC_Entities.Entity();
                newEntity.Status = SVC_Entities.InstanceStatus.Insert;
                newEntity.EntityTypeId = C_PrivatePerson_EntityTypeId;
                newEntity.FullName = "New Test Entity from Webservice test";
                newEntity.ShortName = "Entity";
                newEntity.CountryId = "PRT";

                #region Address

                SVC_Entities.EntityAddressValid addr_1 = new SVC_Entities.EntityAddressValid();
                addr_1.Status = SVC_Entities.InstanceStatus.Insert;
                addr_1.District = "district";
                addr_1.Council = "council name";
                addr_1.CouncilCode = 1; // 1st council
                addr_1.Street = "street 1";
                addr_1.IsResidentialAddress = true;
                addr_1.IsFiscal = true;
                addr_1.IsPostal = true;

                List<SVC_Entities.EntityAddressValid> addr = new List<SVC_Entities.EntityAddressValid>();
                addr.Add(addr_1);
                newEntity.Addresses = addr.ToArray();

                newEntity.Addresses[0].IsResidentialAddress = true;

                #endregion

                #region Phone

                SVC_Entities.EntityPhone phone_1 = new SVC_Entities.EntityPhone();
                phone_1.Status = SVC_Entities.InstanceStatus.Insert;
                phone_1.PhoneTypeId = 3; //Mobile
                phone_1.PhoneNumber = "13456789";

                List<SVC_Entities.EntityPhone> phones = new List<SVC_Entities.EntityPhone>();
                phones.Add(phone_1);
                newEntity.Phones = phones.ToArray();

                #endregion

                #region Email

                SVC_Entities.EntityEmail mail_1 = new SVC_Entities.EntityEmail();
                mail_1.Status = SVC_Entities.InstanceStatus.Insert;
                mail_1.EntityEmailTypeId = 2; //Communication
                mail_1.EmailAddress = "mail@example.com";
                mail_1.IsMain = true;

                List<SVC_Entities.EntityEmail> mails = new List<SVC_Entities.EntityEmail>();
                mails.Add(mail_1);
                newEntity.Emails = mails.ToArray();

                #endregion

                #region EntityLegalDoc

                SVC_Entities.EntityLegalDoc legalDoc_1 = new SVC_Entities.EntityLegalDoc();
                legalDoc_1.Status = SVC_Entities.InstanceStatus.Insert;
                legalDoc_1.LegalDocTypeId = 501; //Fiscal Number
                legalDoc_1.LegalDocNumber = "13456789";
                legalDoc_1.IsMain = true;

                List<SVC_Entities.EntityLegalDoc> legalDocs = new List<SVC_Entities.EntityLegalDoc>();
                legalDocs.Add(legalDoc_1);
                newEntity.LegalDocs = legalDocs.ToArray();

                #endregion

                #region Person

                newEntity.Person = new SVC_Entities.Person { Status = SVC_Entities.InstanceStatus.Insert };
                newEntity.Person.MaritalStatusId = C_MaritalStatus;
                newEntity.Person.ResidenceTypeId = C_ResidenceType;
                newEntity.Person.ResidenceSeniority = 10;
                newEntity.Person.ActivityTypeContextId = C_ActivityTypeContext;
                newEntity.Person.EmploymentCompany = "company name";
                newEntity.Person.EmploymentAddress = "employment address";
                newEntity.Person.SalaryAmount = 10000;
                newEntity.Person.OtherDuties = 2000;

                #endregion

                #region Roles

                SVC_Entities.EntityRole role_1 = new SVC_Entities.EntityRole();
                role_1.Status = SVC_Entities.InstanceStatus.Insert;
                role_1.EntityRoleTypeId = 1; //RoleTypeId - Client

                List<SVC_Entities.EntityRole> roles = new List<SVC_Entities.EntityRole>();
                roles.Add(role_1);
                newEntity.Roles = roles.ToArray();

                newEntity.TaxRegimeId = 1; //mandatory for role customer - Main Land

                #endregion

                return newEntity;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Try Catch CreateNewEntity: " + ex.ToString());
            }

            return null;
        }

        private static void SaveEntity(string token, SVC_Entities.Entity newEntity)
        {
            #region Creation of TokenHeaders - SVC_Entities
            SVC_Entities.SessionTokenWcfHeader tokenHeader = new SVC_Entities.SessionTokenWcfHeader { Token = token };

            // search entities and get entities data
            SVC_Entities.EntitiesClient clientEntities = new SVC_Entities.EntitiesClient();
            
            // set credentials
            //clientEntities.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientEntities.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;
            #endregion

            SVC_Entities.SaveResult saveInfo = null;

            try
            {
                saveInfo = clientEntities.SaveEntities(tokenHeader, SVC_Entities.EntitiesSaveClass.Entity, newEntity);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Try Catch SaveEntity: " + ex.ToString());
            }

            if (saveInfo != null && saveInfo.Key != null)
            {
                SVC_Entities.BusinessDetailFetchInfo[] entityDetails = {
                        new SVC_Entities.BusinessDetailFetchInfo { Type = SVC_Entities.SelectType.Deep, Detail = (int)EntityDetail.Person } ,
                        new SVC_Entities.BusinessDetailFetchInfo { Type = SVC_Entities.SelectType.Deep, Detail = (int)EntityDetail.Email } ,
                        new SVC_Entities.BusinessDetailFetchInfo { Type = SVC_Entities.SelectType.Deep, Detail = (int)EntityDetail.Phone } ,
                        new SVC_Entities.BusinessDetailFetchInfo { Type = SVC_Entities.SelectType.Deep, Detail = (int)EntityDetail.Address } ,
                        new SVC_Entities.BusinessDetailFetchInfo { Type = SVC_Entities.SelectType.Deep, Detail = (int)EntityDetail.LegalDoc }
                    };

                SVC_Entities.BusinessEntityKey[] createdEntityKeys = { saveInfo.Key };
                SVC_Entities.Entity[] entities = clientEntities.GetEntityByKeys(tokenHeader, createdEntityKeys, false, entityDetails);
                //SVC_Entities.Entity[] entities = clientEntities.GetEntityByKeys(tokenHeader, createdEntityKeys, false, null);

                Console.WriteLine("{0}Entity Data", Environment.NewLine);
                Console.WriteLine("new entity number: {0}", entities[0].EntityNumber);
                Console.WriteLine("new entity state id: {0}", entities[0].AutUserStateId);
                Console.WriteLine("new entity email: {0}", entities[0].Emails[0].EmailAddress);
                Console.WriteLine("new entity phone number: {0}", entities[0].Phones[0].PhoneNumber);
                Console.WriteLine("new entity fiscal number: {0}", entities[0].LegalDocs[0].LegalDocNumber);
                Console.WriteLine("new entity address: {0}", string.Format("{0}, {1}, {2}", entities[0].Addresses[0].Street, entities[0].Addresses[0].Council, entities[0].Addresses[0].CountryId));

            }
        }

        #endregion

        #region Exercise 4 – Create a new Entity 

        private static void Day2_Exercise4_CreateEntity(SVC_Logon.LoginInfo info)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day2_Exercise4_CreateEntity --------------------");

            // Insert Code Here
        }
        private static SVC_Entities.Entity Exercise_CreateNewEntity()
        {
            // Insert Code Here

            return null;
        }
        private static void Example_SaveEntity(string token, SVC_Entities.Entity newEntity)
        {
            // Insert Code Here
        }

        #endregion

        #endregion

        #region Day 2 - Update Entity - 

        #region Demo Update Entity
        private static SVC_Entities.Entity Day2_UpdateEntity(SVC_Logon.LoginInfo info, long entityId, string newEmailAddress)
        {
            Console.WriteLine("--------- Day2_UpdateEntity ---------");

            SVC_Entities.Entity entity = null; 

            try
            {
                #region Token Entities
                string token = info.SessionToken;
                SVC_Entities.SessionTokenWcfHeader tokenHeader = new SVC_Entities.SessionTokenWcfHeader { Token = token };

                // search entities and get entities data
                SVC_Entities.EntitiesClient clientEntities = new SVC_Entities.EntitiesClient();

                // set credentials
                //clientEntities.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientEntities.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                #endregion

                #region Retrieve the Entity Object and Print data before update

                // Define the details you want to retrieve from the entities ( Detail Type Deep and Detail Email)
                SVC_Entities.BusinessDetailFetchInfo[] details = { new SVC_Entities.BusinessDetailFetchInfo { Type = SVC_Entities.SelectType.Deep, Detail = (int)SVC_Entities.EntityDetail.Email } };

                SVC_Entities.EntityKey[] keys = { new SVC_Entities.EntityKey() { Id = entityId } };
                SVC_Entities.Entity[] entities = clientEntities.GetEntityByKeys(tokenHeader, keys, false, details);

                if(entities != null && entities.Length > 0)
                    entity = entities[0];

                if (entity != null)
                {
                    Console.WriteLine(Environment.NewLine + "Entity Found - Update Entity - Data Before Update");
                    Console.WriteLine("Entity Number: {0}", entity.EntityNumber);
                    Console.WriteLine("Entity FullName: {0}", entity.FullName);

                    if (entity.Emails != null && entity.Emails.Length > 0)
                        foreach (SVC_Entities.EntityEmail email in entity.Emails)
                            if (email.EntityEmailTypeId == C_EntityEmailType)
                                Console.WriteLine("Entity Email: {0}", email.EmailAddress);
                }

                #endregion

                #region Update EntityEmail of type Communication

                bool hasEmail = false;

                // Check if the entity has an email of type Communication
                // If yes, Update with the new email address
                // If no, add a communication email to the entity
                if (entity != null && entity.Emails != null && entity.Emails.Length > 0)
                {
                    foreach (SVC_Entities.EntityEmail email in entity.Emails)
                    {                        
                        if (email.EntityEmailTypeId == C_EntityEmailType)
                        {
                            #region Update Existing Email

                            Console.WriteLine(Environment.NewLine + "Update Existing Email");

                            hasEmail = true;

                            entity.Status = SVC_Entities.InstanceStatus.Update;
                            email.Status = SVC_Entities.InstanceStatus.Update;

                            email.EmailAddress = newEmailAddress;
                            email.IsMain = true;

                            #endregion
                        }
                    }                    
                }

                if (!hasEmail)
                {
                    entity.Status = SVC_Entities.InstanceStatus.Update;

                    #region Create New Email

                    Console.WriteLine(Environment.NewLine + "Create New Email");

                    SVC_Entities.EntityEmail email = new SVC_Entities.EntityEmail();
                    email.Status = SVC_Entities.InstanceStatus.Insert;
                    email.EntityEmailTypeId = 2; //Communication
                    email.EmailAddress = newEmailAddress;
                    email.IsMain = true;

                    List<SVC_Entities.EntityEmail> mails = new List<SVC_Entities.EntityEmail>();
                    mails.Add(email);
                    entity.Emails = mails.ToArray();

                    #endregion
                }

                #endregion

                #region Print Entity Fields after update
                if (entity != null)
                {
                    Console.WriteLine(Environment.NewLine + "Entity Found - Update Entity - Data After Update");
                    Console.WriteLine("Entity Number: {0}", entity.EntityNumber);
                    Console.WriteLine("Entity FullName: {0}", entity.FullName);

                    if (entity.Emails != null && entity.Emails.Length > 0)
                        foreach (SVC_Entities.EntityEmail email in entity.Emails)
                            if (email.EntityEmailTypeId == C_EntityEmailType)
                                Console.WriteLine("Entity Email: {0}", email.EmailAddress);
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine + "TryCatch Day2_UpdateEntity" + ex.ToString());
            }

            return entity;
        }
        #endregion

        #region Exercise 5 - Update an Entity

        private static SVC_Entities.Entity Day2_Exercise5_UpdateEntity(SVC_Logon.LoginInfo info, long entityId, string newAddress, string newFiscalNumber)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day2_Exercise5_UpdateEntity --------------------");

            // Insert Code Here

            return null;
        }

        #endregion

        #endregion

        #region Day 2 - Get Vehicle Information - 

        #region Demo Get Vehicle Information
        private static void Day2_GetVehicleInformation(SVC_Logon.LoginInfo info)
        {
            #region - Get List of Brands - 
            SVC_OPBasicLists.CodeAbbreviation[] listOfBrands = Day2_GetBrandsList(info.SessionToken);

            Console.WriteLine("--------- List of Brands ---------");

            if (listOfBrands != null)
                foreach (SVC_OPBasicLists.CodeAbbreviation ca in listOfBrands)
                    Console.WriteLine("Code: " + ca.Code + " Abrev:  " + ca.Abbreviation + " Descr: " + ca.Description);

            Console.WriteLine(Environment.NewLine);
            #endregion

            #region - Get List of Models - 
            SVC_OPBasicLists.CodeAbbreviation[] listOfModels = Day2_GetModelsList(info.SessionToken, "AUDI");

            Console.WriteLine("--------- List of Models for Brand: AUDI ---------");

            if (listOfModels != null)
                foreach (SVC_OPBasicLists.CodeAbbreviation ca in listOfModels)
                    Console.WriteLine("Code: " + ca.Code + " Abrev:  " + ca.Abbreviation + " Descr: " + ca.Description);

            Console.WriteLine(Environment.NewLine);
            #endregion

            #region - Get List of Versions - 
            SVC_OPBasicLists.CodeAbbreviation[] listOfVersions = Day2_GetVersionsList(info.SessionToken, "AUDI", "A1 Sportback (GB)");

            Console.WriteLine("--------- List of Versions for Brand: AUDI and Model: A1 Sportback (GB) ---------");

            if (listOfVersions != null)
                foreach (SVC_OPBasicLists.CodeAbbreviation ca in listOfVersions)
                    Console.WriteLine("Code: " + ca.Code + " Abrev:  " + ca.Abbreviation + " Descr: " + ca.Description);

            Console.WriteLine(Environment.NewLine);
            #endregion

            #region - Get Vehicle Information -
            Console.WriteLine("--------- Get Vehicle Information for the combination of Brand: AUDI and Model: A1 Sportback (GB) and Version: A1 SB 30 TFSI ---------");
            EqpPricingInfo carInfo = Day2_GetVehicleInfo(info.SessionToken, "AUDI", "A1 Sportback (GB)", "A1 SB 30 TFSI 116 CV 5 Doors 5 Seats 4x2 A 01-01-2019");
            if (carInfo != null)
            {
                Console.WriteLine("Car Code (Tyla Code): {0}", carInfo.TableCode);
                Console.WriteLine("Car Price: {0}", carInfo.MarketValue);
                Console.WriteLine("Brand: {0}", carInfo.Brand);
                Console.WriteLine("EngineSize: {0}", carInfo.EngineSize);
            }
            #endregion
        }

        #region - Get Brand & Model & Version - 
        private static SVC_OPBasicLists.CodeAbbreviation[] Day2_GetBrandsList(string token)
        {
            try
            {
                SVC_OPBasicLists.SessionTokenWcfHeader tokenHeader = new SVC_OPBasicLists.SessionTokenWcfHeader { Token = token };

                SVC_OPBasicLists.EqpPricingParam param = new SVC_OPBasicLists.EqpPricingParam();

                param.EquipmentState = (int)EquipmentStateKind.New;
                param.EquipmentType = C_EquipmentTypeId;
                param.EquipmentCategory = C_EquipmentCategoryId;
                param.PurposeTypeId = C_PurposeTypeId;
                param.Year = DateTime.Today.Year;

                SVC_OPBasicLists.CreditOperationsBasicListsClient clientCOBasicLists = new SVC_OPBasicLists.CreditOperationsBasicListsClient();

                // set credentials
                // clientCOBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientCOBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                SVC_OPBasicLists.BasicList basicList = clientCOBasicLists.GetEquipmentBrandDataList(tokenHeader, C_EquipmentTypeId, param);

                if (basicList == null || basicList.List == null)
                    return null;

                return basicList.List;
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine + "TryCatch GetBrandsList: " + ex.ToString());
            }

            return null;
        }

        private static SVC_OPBasicLists.CodeAbbreviation[] Day2_GetModelsList(string token, string brand)
        {
            try
            {
                SVC_OPBasicLists.SessionTokenWcfHeader tokenHeader = new SVC_OPBasicLists.SessionTokenWcfHeader { Token = token };

                SVC_OPBasicLists.EqpPricingParam param = new SVC_OPBasicLists.EqpPricingParam();
                param.EquipmentState = (int)EquipmentStateKind.New;
                param.EquipmentType = C_EquipmentTypeId;
                param.EquipmentCategory = C_EquipmentCategoryId;
                param.PurposeTypeId = C_PurposeTypeId;
                param.Year = 2019;

                param.Brand = brand;

                SVC_OPBasicLists.CreditOperationsBasicListsClient clientCOBasicLists = new SVC_OPBasicLists.CreditOperationsBasicListsClient();

                // set credentials
                //clientCOBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientCOBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;
                
                SVC_OPBasicLists.BasicList basicList = clientCOBasicLists.GetEquipmentModelDataList(tokenHeader, C_EquipmentTypeId, param);

                if (basicList == null || basicList.List == null)
                    return null;

                return basicList.List;
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine + "TryCatch GetModelsList: " + ex.ToString());
            }

            return null;
        }

        private static SVC_OPBasicLists.CodeAbbreviation[] Day2_GetVersionsList(string token, string brand, string model)
        {
            try
            {
                SVC_OPBasicLists.SessionTokenWcfHeader tokenHeader = new SVC_OPBasicLists.SessionTokenWcfHeader { Token = token };

                SVC_OPBasicLists.EqpPricingParam param = new SVC_OPBasicLists.EqpPricingParam();
                param.EquipmentState = (int)EquipmentStateKind.New;
                param.EquipmentType = C_EquipmentTypeId;
                param.EquipmentCategory = C_EquipmentCategoryId;
                param.PurposeTypeId = C_PurposeTypeId;
                param.Year = DateTime.Today.Year;

                param.Brand = brand;
                param.Model = model;

                SVC_OPBasicLists.CreditOperationsBasicListsClient clientCOBasicLists = new SVC_OPBasicLists.CreditOperationsBasicListsClient();

                // set credentials
                //clientCOBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientCOBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                SVC_OPBasicLists.BasicList basicList = clientCOBasicLists.GetEquipmentVersionDataList(tokenHeader, C_EquipmentTypeId, param);

                if (basicList == null || basicList.List == null)
                    return null;

                return basicList.List;
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine + "TryCatch GetVersionsList: " + ex.ToString());
            }

            return null;
        }
        #endregion

        public static EqpPricingInfo Day2_GetVehicleInfo(string token, string brand, string model, string version)
        {
            try
            {
                SessionTokenWcfHeader tokenHeader = new SessionTokenWcfHeader { Token = token };

                // ----------------- EqpPricingParam -----------------
                EqpPricingParam param = new EqpPricingParam();

                param.ClientTaxRegimeId = C_ClientTaxRegimeId;
                param.PurposeTypeId = C_PurposeTypeId;

                param.EquipmentType = C_EquipmentTypeId;
                param.EquipmentCategory = C_EquipmentCategoryId;
                param.EquipmentState = (int)EquipmentStateKind.New;

                param.Year = DateTime.Today.Year;
                param.Brand = brand;
                param.Model = model;
                param.Version = version;

                // -------------------- Equipment --------------------
                Equipment eqp = new Equipment();
                eqp.Status = InstanceStatus.Unchanged;

                eqp.EquipmentTypeId = C_EquipmentTypeId;
                eqp.EquipmentCategoryId = C_EquipmentCategoryId;
                eqp.EquipmentStateId = (int)EquipmentStateKind.New;

                eqp.EquipYear = DateTime.Today.Year;
                eqp.EquipmentBrand = brand;
                eqp.EquipmentModel = model;
                eqp.EquipVersion = version;

                //----------------------------------------------------

                CreditOperationsClient clientCO = new CreditOperationsClient();

                // set credentials 
                //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                EqpPricingInfo info = clientCO.GetEquipmentSourcePricingInfo(tokenHeader, eqp, param);

                return info;
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine + "TryCatch Day2_GetVehicleInfo: " + ex.ToString());
            }

            return null;
        }

        #endregion

        #region Exercise 6 – Get Brands; Models; Versions and Vehicle Information's 

        private static void Day2_Exercise6_GetVehicleInformation(SVC_Logon.LoginInfo info)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day2_Exercise6_GetVehicleInformation --------------------");

            // Insert Code Here
        }

        #endregion

        #endregion

        #endregion

        // -------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------ DAY 3 ------------------------------------------------------

        #region Day 3

        #region Day 3 - Get & Restrict & Use Financial Products - 

        #region Get Financial Products

        #region Demo Get Financial Products
        private static void Day3_GetFinancialProduct(SVC_Logon.LoginInfo info)
        {
            SVC_OPBasicLists.CodeAbbreviation[] products = Day3_GetProductsList(info.SessionToken, C_AplBusinessId_Leasing);

            Console.WriteLine("--------- List Financial Products ---------");

            if (products != null)
                foreach (SVC_OPBasicLists.CodeAbbreviation ca in products)
                    Console.WriteLine("Code: " + ca.Code + " Abrev:  " + ca.Abbreviation + " Descr: " + ca.Description);

            Console.WriteLine(Environment.NewLine);
        }
                
        private static SVC_OPBasicLists.CodeAbbreviation[] Day3_GetProductsList(string token, int business)
        {
            try
            {
                #region Tokens - CreditOperations
                SVC_OPBasicLists.SessionTokenWcfHeader tokenHeader = new SVC_OPBasicLists.SessionTokenWcfHeader { Token = token };                

                SVC_OPBasicLists.CreditOperationsBasicListsClient clientCOBasicLists = new SVC_OPBasicLists.CreditOperationsBasicListsClient();

                // set credentials
                //clientCOBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientCOBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                #endregion

                #region Define the Parameters to Restrict the Financial Products

                SVC_OPBasicLists.FinProductBasicListParam param = new SVC_OPBasicLists.FinProductBasicListParam();
                param.AplCompanyId = C_AplCompanyId;
                param.AplBusinessId = business;
                param.AplBusinessPurposeTypeId = C_PurposeTypeId;
                param.AddProductsWithoutImporters = true;
                param.AddProductsWithoutChannel = true;    // >> on the final version when we have configured channels should be false
                                                           //param.CurrencyId = "EUR";
                                                           //param.CustomerTypeId = 1;
                                                           //param.ImporterStructNodeId;
                                                           //param.MarketCampaignId;
                                                           //param.ProductPurposeId;

                List<SVC_OPBasicLists.SymbolValueList> list = new List<SVC_OPBasicLists.SymbolValueList>();
                SVC_OPBasicLists.SymbolValueList restriction = new SVC_OPBasicLists.SymbolValueList();

                restriction = new SVC_OPBasicLists.SymbolValueList();
                restriction.FinSymbolId = (int)FinSymbolKind.AssetCategory;
                restriction.SymbolId = C_EquipmentCategoryId;
                list.Add(restriction);

                restriction = new SVC_OPBasicLists.SymbolValueList();
                restriction.FinSymbolId = (int)FinSymbolKind.AssetState;
                restriction.SymbolId = (int)EquipmentStateKind.Used; // in this case we use "symbolid" and not "symbolstring"
                list.Add(restriction);

                if (list != null && list.Count > 0)
                    param.SymbolValues = list.ToArray();

                #region Other restriction examples to retrieve the Financial Products - (currently commentted code)
                /*
                List<SVC_OPBasicLists.SymbolValueList> list = new List<SVC_OPBasicLists.SymbolValueList>();

                SVC_OPBasicLists.SymbolValueList restriction = new SVC_OPBasicLists.SymbolValueList();
                restriction.FinSymbolId = (int)FinSymbolKind.AssetType;
                restriction.SymbolId = C_EquipmentTypeId;
                list.Add(restriction);

                //restriction = new SVC_OPBasicLists.SymbolValueList();
                //restriction.FinSymbolId = (int)FinSymbolKind.AssetCategory;
                //restriction.SymbolId = C_EquipmentCategoryId;
                //list.Add(restriction);

                restriction = new SVC_OPBasicLists.SymbolValueList();
                restriction.FinSymbolId = (int)FinSymbolKind.AssetState;
                restriction.SymbolId = (int)EquipmentStateKind.New; // in this case we use "symbolid" and not "symbolstring"
                list.Add(restriction);

                if (!string.IsNullOrEmpty(brand))
                {
                    restriction = new SVC_OPBasicLists.SymbolValueList();
                    restriction.FinSymbolId = (int)FinSymbolKind.AssetBrand;
                    restriction.SymbolString = brand;

                    list.Add(restriction);
                }

                if (!string.IsNullOrEmpty(model))
                {
                    restriction = new SVC_OPBasicLists.SymbolValueList();
                    restriction.FinSymbolId = (int)FinSymbolKind.AssetModel;
                    restriction.SymbolString = model;

                    list.Add(restriction);
                }

                if (list != null && list.Count > 0)
                    param.SymbolValues = list.ToArray();
                */
                #endregion

                #endregion
                               
                #region GetFinancialProductWithRestrictionsBasicList

                SVC_OPBasicLists.BasicList basicList = clientCOBasicLists.GetFinancialProductWithRestrictionsBasicList(tokenHeader, param);

                if (basicList == null || basicList.List == null)
                    return null;

                #region Filter to obtain only valid products
                List<SVC_OPBasicLists.CodeAbbreviation> codeAbrevList = new List<SVC_OPBasicLists.CodeAbbreviation>();

                // check the FetchLevel of the Financial Products and only add the valid one's
                foreach (var codeAbrev in basicList.List)
                {
                    if (codeAbrev.FetchLevel >= 0)
                        codeAbrevList.Add(codeAbrev);
                }
                #endregion

                #endregion

                return codeAbrevList.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }

        #endregion

        #region Exercise 7 – Get Financial Products for Leasing Business  
        private static void Day3_Exercise7_GetFinancialProduct(SVC_Logon.LoginInfo info)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day3_Exercise7_GetFinancialProduct --------------------");

            // Insert Code Here
        }
        #endregion

        #endregion

        #region Get and Use Financial Product Limits 

        #region Demo GetFinancialProductLimits
        private static void Day3_GetFinancialProductLimits(SVC_Logon.LoginInfo info)
        {
            #region Token - CreditOperations
            string token = info.SessionToken;
            SessionTokenWcfHeader tokenHeaderCO = new SessionTokenWcfHeader { Token = token };

            CreditOperationsClient clientCO = new CreditOperationsClient();

            // set credentials
            //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            #endregion

            try
            {
                CredOper credOper = Day3_CreateQuotationWithEquipment(info);

                Console.WriteLine(Environment.NewLine + "-------------- Day3_GetFinancialProductLimits --------------");

                SymbolLimit termLimits = clientCO.GetFinancialProductLimitsWithBasicLists(tokenHeaderCO, credOper, C_Equip_FinancialProductId, (int)FinSymbolKind.Term, null);
                if (termLimits != null && termLimits.DefaultSymbolValue != null)
                    Console.WriteLine("DefaultSymbolValue (Term) = {0}", termLimits.DefaultSymbolValue);

                SymbolLimit DDR = clientCO.GetFinancialProductLimitsWithBasicLists(tokenHeaderCO, credOper, C_Equip_FinancialProductId, (int)FinSymbolKind.PurchaseValue, null);
                if (DDR != null && DDR.DefaultSymbolValue != null)
                    Console.WriteLine("DefaultSymbolValue (DDR) = {0}", DDR.DefaultSymbolValue);

                Console.WriteLine(Environment.NewLine + "- Period -");
                SymbolLimit period = clientCO.GetFinancialProductLimitsWithBasicLists(tokenHeaderCO, credOper, C_Equip_FinancialProductId, (int)FinSymbolKind.Period, null);
                if (period != null && period.DefaultSymbolValue != null)
                {
                    Console.WriteLine("- DefaultSymbolValue (Period) = {0}{1}", period.DefaultSymbolValue, Environment.NewLine);
                }
                else if (period != null && period.SymbolIdList != null && period.SymbolIdList.Length > 0)
                {
                    foreach (SymbolLimitId symbolId in period.SymbolIdList)
                        if (symbolId.IsDefault ?? false)
                            Console.WriteLine("- SymbolId (Period) = " + symbolId.SymbolId);
                }
                else
                {
                    if (period != null && period.DefaultSymbolId != null)
                        Console.WriteLine("- DefaultSymbolId (Period) = " + period.DefaultSymbolId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("TryCatch Day3_GetFinancialProductLimits = {0}", ex.ToString());
            }
        }
        #endregion

        #region Exercise 8 - Day3_Exercise8_GetFinancialProductLimits
        private static void Day3_Exercise8_GetFinancialProductLimits(SVC_Logon.LoginInfo info)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day3_Exercise8_GetFinancialProductLimits --------------------");

            // Insert Code Here
        }
        #endregion

        #region Exercise 9 - Day3_Exercise9_GetFinancialProductLimits
        private static void Day3_Exercise9_GetFinancialProductLimits(string token, CredOper credOper, int finProdId, out int? FinProd_FinDueRegime, out int? FinProd_Period)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day3_Exercise9_GetFinancialProductLimits --------------------");

            FinProd_FinDueRegime = null;
            FinProd_Period = null;

            // Insert Code Here
        }
        #endregion

        #endregion

        #endregion

        #region Day 3 - Create Quotation

        #region Day 3 - Demo Create Quotation

        #region Day 3 - Create Quotation with Equipment (Credit) -
        private static CredOper Day3_CreateQuotationWithEquipment(SVC_Logon.LoginInfo info)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day3_CreateQuotationWithEquipment --------------------");

            try
            {
                #region TokenHeader CreditOperations
                string token = info.SessionToken;
                SessionTokenWcfHeader tokenHeader = new SessionTokenWcfHeader { Token = token };

                CreditOperationsClient clientCO = new CreditOperationsClient();

                // set credentials
                //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                #endregion

                #region set up variables
                CredOper oper = null;
                CredOperValidationResult credOperResult = null;

                // *********************************************************************************************************************
                // Values that need to be set by the portal depending on the product and parameter selection made by the end user
                // *********************************************************************************************************************
                decimal vehicleMarketVal = 45000; // just for testing
                int prodId = C_Equip_FinancialProductId;
                #endregion

                #region Day3_PrepareCredOperForCalculation
                oper = Day3_PrepareCredOperForCalculation(token, prodId, vehicleMarketVal);
                #endregion

                #region CalculateCredOperWithAssetExpensesGeneration

                try
                {
                    credOperResult = clientCO.CalculateCredOperWithAssetExpensesGeneration(tokenHeader, oper, 0, 0, (int)AssetTypeKind.Equipment);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Try Catch CalculateCredOperWithAssetExpensesGeneration: " + ex.ToString());
                }

                if (credOperResult != null)
                {
                    if (credOperResult.CredOper != null)
                        oper = credOperResult.CredOper;
                }
                else
                {
                    Console.WriteLine("Error: credOperResult is null");
                }

                if (oper != null && oper.Conditions != null && oper.Conditions.Length > 0 && oper.Conditions[0].Flows != null && oper.Conditions[0].Flows.Length > 0)
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("CredOperNumber: {0}", oper.CredOperNumber);
                    Console.WriteLine("Installment Amount: {0}", oper.Conditions[0].Flows[0].Amount);
                    Console.WriteLine("Ballon Amount: {0}", oper.Conditions[0].Flows[1].Amount);
                    Console.WriteLine("Number of Rents (Term): {0}", oper.Conditions[0].Term);
                    //Console.WriteLine("Customer Rental Amount With Tax: {0}", oper.Conditions[0].Flows[0].CustomerRentalAmountWithTax);

                    #region Quotation Suppliers 
                    if (oper.IntervSuppliers != null && oper.IntervSuppliers.Length > 0 && oper.IntervSuppliers[0].EntityId != null)
                        Console.WriteLine("Supplier Entity Number: {0}", oper.IntervSuppliers[0].EntityId);

                    #endregion

                    #region Equipment Supplier 
                    if (oper.Assets != null
                        && oper.Assets.Length > 0
                        && oper.Assets[0].Equipment != null
                        && oper.Assets[0].Equipment.SupplierEntityId.HasValue)
                    {
                        Console.WriteLine("Equipment Supplier Entity is: {0}", oper.Assets[0].Equipment.SupplierEntityId);
                    }
                    #endregion

                    return oper;
                }

                #endregion                
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine + "Try Catch Day3_CreateQuotationWithEquipment: " + ex.ToString());
            }

            return null;
        }
        #endregion

        #region Day 3 - Create Quotation without Equipment (Credit) -
        private static CredOper Day3_CreateQuotationWithoutEquipment(SVC_Logon.LoginInfo info)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day3_CreateQuotationWithoutEquipment --------------------");

            try
            {
                #region TokenHeader CreditOperations
                string token = info.SessionToken;
                SessionTokenWcfHeader tokenHeader = new SessionTokenWcfHeader { Token = token };

                CreditOperationsClient clientCO = new CreditOperationsClient();

                // set credentias
                //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                #endregion

                #region set up variables
                CredOper oper = null;
                CredOperValidationResult credOperResult = null;

                // *********************************************************************************************************************
                // Values that need to be set by the portal depending on the product and parameter selection made by the end user
                // *********************************************************************************************************************
                decimal loanAmount = 10000;
                int prodId = C_CredPessoal_FinancialProductId;
                #endregion

                #region Day3_PrepareCredOperForCalculation
                oper = Day3_PrepareCredOperForCalculation(token, prodId, loanAmount);
                #endregion

                #region CalculateCredOper

                try
                {             
                    credOperResult = clientCO.CalculateCredOper(tokenHeader, oper, 0, 0, 0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Try Catch CalculateCredOper: " + ex.ToString());
                }

                if (credOperResult != null)
                {
                    if (credOperResult.CredOper != null)
                        oper = credOperResult.CredOper;
                }
                else
                {
                    Console.WriteLine("Error: credOperResult is null");
                }

                if (oper != null && oper.Conditions != null && oper.Conditions.Length > 0 && oper.Conditions[0].Flows != null && oper.Conditions[0].Flows.Length > 0)
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("CredOperNumber: {0}", oper.CredOperNumber);
                    Console.WriteLine("Installment Amount: {0}", oper.Conditions[0].Flows[0].Amount);
                    Console.WriteLine("Number of Rents (Term): {0}", oper.Conditions[0].Term);
                    Console.WriteLine("Financed Amount: {0}", oper.Conditions[0].EquipmentAmount);

                    return oper;
                }

                #endregion                
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine + "Try Catch Day3_CreateQuotationWithoutEquipment: " + ex.ToString());
            }

            return null;
        }
        #endregion

        #region - PrepareCredOperForCalculation
        private static CredOper Day3_PrepareCredOperForCalculation( string token,
                                                                    int productId,
                                                                    decimal vehicleMarketValue_LoanAmount)
        {
            #region Creation of TokenHeaders - CreditOperations; Simulations; BusinessFramework

            SessionTokenWcfHeader tokenHeaderCO = new SessionTokenWcfHeader { Token = token };
            CreditOperationsClient clientCO = new CreditOperationsClient();
            //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            SVC_Simulations.SessionTokenWcfHeader tokenHeaderS = new SVC_Simulations.SessionTokenWcfHeader { Token = token };
            SVC_Simulations.SimulationsClient clientS = new SVC_Simulations.SimulationsClient();
            //clientS.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientS.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            SVC_BusinessFramework.SessionTokenWcfHeader tokenHeaderBF = new SVC_BusinessFramework.SessionTokenWcfHeader { Token = token };
            SVC_BusinessFramework.BusinessFrameworkClient clientBF = new SVC_BusinessFramework.BusinessFrameworkClient();
            //clientBF.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientBF.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            // **********************************************************************
            #endregion

            #region Day3_MapBaseCredOperFields

            int ? taxTypeId = null;
            int? retakeAmount = null;
            bool isAutoCredit = false;
            SVC_Framework.BusinessKind? businessKind;
            SVC_CreditOperationsConfig.CredOperType credOperType = null;
            SVC_Simulations.FinancialProduct finProd = null;
            DateTime beginDate = DateTime.Today;

            Console.WriteLine(" - Calling the method Day3_MapBaseCredOperFields -");
            CredOper credOper = Day3_MapBaseCredOperFields(token, productId, ref taxTypeId, out businessKind, out finProd, out credOperType, out isAutoCredit, out beginDate);

            long credOperTypeId = finProd.ProductOperTypes[0].OperTypeId.Value;

            #endregion

            #region Only for Quotations With Equipment
            if (credOperType.AssetTypeId == (int)AssetTypeKind.Equipment)
            {
                #region Day3_MapCredOperAssetWithEquipment

                Console.WriteLine(" - Calling the method Day3_MapCredOperAssetWithEquipment -");
                CredOperAsset asset = Day3_MapCredOperAssetWithEquipment(taxTypeId, finProd, tokenHeaderCO, clientCO, credOper, beginDate);
                credOper.Assets[0] = asset;

                #endregion

                #region Day3_SetEquipmentCredOperAmounts

                // set operation amounts
                Console.WriteLine(" - Calling the method Day3_SetEquipmentCredOperAmounts -");
                credOper = Day3_SetEquipmentCredOperAmounts(token, credOper, finProd, isAutoCredit, credOperType, vehicleMarketValue_LoanAmount, retakeAmount, ref taxTypeId);

                if (credOper.Conditions != null && credOper.Conditions.Length > 0)
                    credOper.Conditions[0].Term = 60;

                #endregion

                #region Day3_SetEquipmentSupplier
                if (credOper != null && credOper.Assets != null && credOper.Assets.Length > 0 && credOper.Assets[0].Equipment != null)
                {
                    Console.WriteLine(" - Calling the method Day3_SetEquipmentSupplier -");
                    credOper = Day3_SetEquipmentSupplier(credOper);
                }
                #endregion
            }
            #endregion

            #region Exercise 9 - Set FinDueRegime and Period and Credoper EndDate
            if (credOper.AplBusinessId == C_AplBusinessId_Leasing)
            {
                #region Set FinDueRegime and Period
                Console.WriteLine(" - Exercise 9: Set FinDueRegime and Period -");
                if (credOper.Conditions != null && credOper.Conditions.Length > 0)
                {
                    Day3_Exercise9_GetFinancialProductLimits(token, credOper, productId, out int? FinProd_FinDueRegimeId, out int? FinProd_PeriodId);

                    credOper.Conditions[0].FinDueRegimeId = FinProd_FinDueRegimeId;
                    credOper.Conditions[0].PeriodId = FinProd_PeriodId;
                }
                #endregion

                #region Set CredOper EndDate
                Console.WriteLine(" - Exercise 9: Set CredOper EndDate -");
                SVC_Simulations.FinDateCalcInfo dateInf = clientS.GetTransferDate(tokenHeaderS,
                                                                                credOperTypeId,
                                                                                credOper.BeginDate,
                                                                                credOper.Conditions[0].FinDueRegimeId,
                                                                                credOper.Conditions[0].FinInitialEntryTypeId,
                                                                                credOper.Conditions[0].DifferPeriods,
                                                                                credOper.Conditions[0].GracePeriods,
                                                                                credOper.Conditions[0].PeriodId,
                                                                                null, null);

                credOper.EndDate = clientBF.GetFinalDate(tokenHeaderBF,
                                                        credOper.BeginDate,
                                                        credOper.Conditions[0].Term ?? credOper.Assets[0].Term,
                                                        dateInf.Day,
                                                        null);
                #endregion

            }
            #endregion

            #region SetFinancialProductAndSymbolProdDefaults

            // set product defaults
            Console.WriteLine(" - Calling the method clientCO.SetFinancialProductAndSymbolProdDefaults -");
            credOper = clientCO.SetFinancialProductAndSymbolProdDefaults(tokenHeaderCO, credOper, null);

            #endregion

            #region Set Interest Control type
            Console.WriteLine(" - Set Interest Control type -");
            if (credOper.Conditions != null && credOper.Conditions.Length > 0)
            {
                if (credOper.Conditions[0].FinInterestControlTypeId == null)
                    credOper.Conditions[0].FinInterestControlTypeId = (int)SVC_BusinessFramework.FinInterestControlTypeKind.Calculate;
            }
            #endregion

            #region Only for Quotations Without Equipment
            if (credOperType.AssetTypeId == null)
            {
                Console.WriteLine(" - Set Parameters: Loan Amount -");
                #region Set Parameters: Loan Amount
                //if (businessKind != SVC_Framework.BusinessKind.Renting)
                //{
                if (credOper.Conditions != null && credOper.Conditions.Length > 0)
                    {
                        //credOper.Conditions[0].Term = currentTerm;
                        credOper.Conditions[0].EquipmentAmount = vehicleMarketValue_LoanAmount;
                    }
                //}
                //else
                //{
                //    if (credOper.Assets != null && credOper.Assets.Length > 0)
                //        credOper.Assets[0].Term = currentTerm;
                //}
                #endregion
            }
            #endregion

            #region Set Quotation and Dates

            Console.WriteLine(" - Calling the method dateInfo = clientS.GetTransferDate");
            SVC_Simulations.FinDateCalcInfo dateInfo = clientS.GetTransferDate( tokenHeaderS,
                                                                                credOperTypeId,
                                                                                credOper.BeginDate,
                                                                                credOper.Conditions[0].FinDueRegimeId,
                                                                                credOper.Conditions[0].FinInitialEntryTypeId,
                                                                                credOper.Conditions[0].DifferPeriods,
                                                                                credOper.Conditions[0].GracePeriods,
                                                                                credOper.Conditions[0].PeriodId,
                                                                                null, null);

            credOper.Conditions[0].TransferDate = dateInfo.Date;
            credOper.Conditions[0].SpreadDate = credOper.Conditions[0].InitialDate;
            credOper.Conditions[0].ValueDate = credOper.Conditions[0].InitialDate;

            credOper.Conditions[0].DayRent = dateInfo.Day;

            credOper.EndDate = clientBF.GetFinalDate(tokenHeaderBF,
                                                        credOper.BeginDate,
                                                        credOper.Conditions[0].Term ?? credOper.Assets[0].Term,
                                                        dateInfo.Day,
                                                        null);

            credOper.Conditions[0].FinalDate = credOper.EndDate;

            if (businessKind == SVC_Framework.BusinessKind.Renting)
            {
                if (credOper.Conditions[0].FinInitialEntryTypeId == (int)SVC_Simulations.FinInitialEntryTypeKind.ProRataRent)
                    credOper.Conditions[0].Term = (credOper.Assets[0].Term ?? 0) + 1;
                else
                    credOper.Conditions[0].Term = credOper.Assets[0].Term;
            }

            #endregion

            credOper.Conditions[0].AmountHasTaxes = businessKind != SVC_Framework.BusinessKind.Credit;

            #region Get Ballon Limits from Financial Product Restrictions - Commentted Code - 
            //if (isAutoCredit)
            //{
            //    Console.WriteLine(" - Calling the method dateInfo = clientCO.GetFinancialProductLimitsWithBasicLists");
            //    SymbolLimit balloonLimits = clientCO.GetFinancialProductLimitsWithBasicLists(tokenHeaderCO, credOper, productId, (int)FinSymbolKind.AssetRetakePercentage, null);

            //    if (balloonLimits != null && balloonLimits.LimitBasicList != null)
            //    {
            //        // do something with "balloonLimits.LimitBasicList"                            
            //    }

            //    if (balloonLimits != null && balloonLimits.DefaultSymbolValue != null)
            //    {
            //        if (credOper.Conditions[0].Flows != null && credOper.Conditions[0].Flows.Length > 1)
            //        {
            //            if (credOper.Conditions[0].Flows[1].Quantity == 1 && credOper.Conditions[0].Flows[1].FinFlowControlTypeId == (int)SVC_BusinessFramework.FinFlowControlTypeKind.NotIndexed)
            //            {
            //                credOper.Conditions[0].Flows[1].UserInputFieldId = (int)SVC_Simulations.UserInputField.PercentageAmount;
            //                credOper.Conditions[0].Flows[1].Factor = null;
            //                credOper.Conditions[0].Flows[1].PercentageAmount = balloonLimits.DefaultSymbolValue;

            //                //balloonLimits.MaxDate
            //                //balloonLimits.MinDate
            //                //balloonLimits.MaxValue
            //                //balloonLimits.MinValue
            //                //balloonLimits. ...
            //            }
            //        }
            //    }
            //    credOper.Conditions[0].ResidualValuePercentage = null;
            //    credOper.Conditions[0].ResidualValue = null;
            //}
            #endregion

            #region Calculate New Rent Calendar

            Console.WriteLine(" - Calling the method dateInfo = clientS.CalculateRentsCalendar");
            SVC_Simulations.FinConditions newConditions = clientS.CalculateRentsCalendar(tokenHeaderS,
                                                                                            DomainTranslator.Translate(credOper.Conditions[0]),
                                                                                            credOperTypeId,
                                                                                            productId,
                                                                                            false);
            credOper.Conditions[0] = DomainTranslator.Translate(newConditions);

            #endregion

            #region Print of contract values - COMMENTED            
            //if (credOper.Insurances != null && credOper.Insurances.Length > 0)
            //{
            //    Console.Write(Environment.NewLine + "--- Exercise 9 (Insurances ");
            //    Console.WriteLine("Length: {0}) ---", credOper.Insurances.Length);

            //    for (int i = 0; i < credOper.Insurances.Length; i++)
            //    {
            //        Console.WriteLine("Insurance {0} / BeginDate: {1} / EndDate {2}", credOper.Insurances[i].InsuranceTypeId, credOper.Insurances[i].BeginDate, credOper.Insurances[i].EndDate);
            //    }
            //}

            //Console.WriteLine("Contract Begin Date: {0} / End Date: {1} / Term: {2} / Financial Product: {3} / Operation Type: {4} / AssetCategory: {5}" + Environment.NewLine,
            //        credOper.BeginDate,
            //        credOper.EndDate,
            //        credOper.Conditions[0].Term,
            //        credOper.FinancialProductId,
            //        credOper.CredOperTypeId,
            //        credOper.Assets[0].Equipment.EquipmentCategoryId);
            #endregion

            return credOper;
        }
        #endregion

        #region - MapBaseCredOperFields
        // Map basic CredOper fields, create FinConditions
        private static CredOper Day3_MapBaseCredOperFields(string token,
                                                            int productId,
                                                            ref int? taxTypeId,
                                                            out SVC_Framework.BusinessKind? businessKind,
                                                            out SVC_Simulations.FinancialProduct finProd,
                                                            out SVC_CreditOperationsConfig.CredOperType credOperType,
                                                            out bool isAutoCredit,
                                                            out DateTime beginDate)
        {
            #region Creation of TokenHeaders - CreditOperations; Simulations; CreditOperationsConfig
            // *******************************

            SessionTokenWcfHeader tokenHeaderCO = new SessionTokenWcfHeader { Token = token };
            CreditOperationsClient clientCO = new CreditOperationsClient();
            //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            SVC_Simulations.SessionTokenWcfHeader tokenHeaderS = new SVC_Simulations.SessionTokenWcfHeader { Token = token };
            SVC_Simulations.SimulationsClient clientS = new SVC_Simulations.SimulationsClient();
            //clientS.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientS.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            SVC_CreditOperationsConfig.SessionTokenWcfHeader tokenHeaderCOC = new SVC_CreditOperationsConfig.SessionTokenWcfHeader { Token = token };
            SVC_CreditOperationsConfig.CreditOperationsConfigClient clientCOC = new SVC_CreditOperationsConfig.CreditOperationsConfigClient();
            //clientCOC.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientCOC.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            // *******************************
            #endregion

            #region Get The Financial Procuct and Fetch Missing Details

            // Fetch Missing Details: Product OperType relation; Symbols; Restrictions; PurposeTypes; Importer
            SVC_Simulations.BusinessDetailFetchInfo d1 = new SVC_Simulations.BusinessDetailFetchInfo { Type = SVC_Simulations.SelectType.Deep, Detail = (int)SVC_Simulations.FinancialProductDetail.ProductOperType };
            SVC_Simulations.BusinessDetailFetchInfo d2 = new SVC_Simulations.BusinessDetailFetchInfo { Type = SVC_Simulations.SelectType.Deep, Detail = (int)SVC_Simulations.FinancialProductDetail.OutputSymbol };
            SVC_Simulations.BusinessDetailFetchInfo d3 = new SVC_Simulations.BusinessDetailFetchInfo { Type = SVC_Simulations.SelectType.Deep, Detail = (int)SVC_Simulations.FinancialProductDetail.Restriction };
            //SVC_Simulations.BusinessDetailFetchInfo d4 = new SVC_Simulations.BusinessDetailFetchInfo { Type = SVC_Simulations.SelectType.Deep, Detail = (int)SVC_Simulations.FinancialProductDetail.PurposeType };
            //SVC_Simulations.BusinessDetailFetchInfo d5 = new SVC_Simulations.BusinessDetailFetchInfo { Type = SVC_Simulations.SelectType.Deep, Detail = (int)SVC_Simulations.FinancialProductDetail.Importer };

            SVC_Simulations.BusinessDetailFetchInfo[] prodDetails = { d1, d2, d3/*, d4, d5*/ };

            // get a Financial Product of a specific ID
            SVC_Simulations.BusinessEntityKey[] keysProd = { new SVC_Simulations.FinancialProductKey { Id = productId } };

            // Fetch the Financial Product with more details
            Console.WriteLine(" - Calling the method clientS.GetFinancialProductByKeys -");
            SVC_Simulations.FinancialProduct[] finProds = clientS.GetFinancialProductByKeys(tokenHeaderS, keysProd, false, prodDetails);

            finProd = null;
            if (finProds != null && finProds.Length > 0)
                finProd = finProds[0];

            // retrieve the business ID from the Financial Product
            businessKind = (SVC_Framework.BusinessKind)finProd.AplBusinessId.Value;

            // Other fields that may be of use 
            // finProd.AutUserStateId --> record current state
            // finProd.StateDate --> record current state date
            // finProd.ValidityBeginDate
            // finProd.ValidityEndDate

            #endregion

            #region Map CredOper Fields
            // Create the CredOper Object
            CredOper credOper = new CredOper();
            credOper.Status = InstanceStatus.Insert;

            #region Get OperType from Financial Product
            // Check if the retrieved Financial Product has the OperType correcly parametrized
            if (finProd.ProductOperTypes == null || finProd.ProductOperTypes.Length == 0)
                throw new Exception("ERROR: The retrieved Finantial Product does not have any OperType Parametrized!");

            // retrieve the OperTypes parametrized in the Financial Product
            List<BusinessEntityKey> keysCOT = new List<BusinessEntityKey>();
            long credOperTypeId = 0;
            foreach (SVC_Simulations.FinancialProductCredOperType financialProduct in finProd.ProductOperTypes)
            {
                if (financialProduct.IsDefault.Value)
                    credOperTypeId = financialProduct.OperTypeId.Value;
            }

            //long credOperTypeId = finProd.ProductOperTypes[0].OperTypeId.Value;

            SVC_CreditOperationsConfig.BusinessEntityKey[] keysOPT = { new SVC_CreditOperationsConfig.CredOperTypeKey { OperTypeId = credOperTypeId } };
            SVC_CreditOperationsConfig.CredOperType[] opTypes = clientCOC.GetCredOperTypeByKeys(tokenHeaderCOC, keysOPT, false, null);

            credOperType = null;
            if (opTypes != null && opTypes.Length > 0)
                credOperType = opTypes[0];

            if (credOperType == null)
                throw new Exception("ERROR: Financial Product without CredOperType parametrized!");
            else
                Console.WriteLine("    - Selected CredOperType: {0}", opTypes[0].OperTypeId);

            #endregion

            // Calculate the Operation Initial Date (Transfer Date) based on the rules parametrized in the CredOperType
            Console.WriteLine(" - Calling the method clientCO.CalculateInitialDate -");
            beginDate = clientCO.CalculateInitialDate(tokenHeaderCO, credOperTypeId, DateTime.Today, null);

            #region Map CredOper fields from Financial Product and from CredOperType parametrizations
            Console.WriteLine(" - Map CredOper fields from Financial Product and from CredOperType parametrizations -");
            credOper.AplCompanyId = finProd.AplCompanyId;
            credOper.AplBusinessId = finProd.AplBusinessId;
            credOper.CredOperTypeId = credOperTypeId;
            CodeAbbreviation operationInicialStateStr = clientCO.GetCredOperInitialState(tokenHeaderCO, credOperTypeId);
            credOper.AutUserStateId = long.Parse(operationInicialStateStr.Code);
            credOper.StateDate = DateTime.Today;
            credOper.CredOperStep = credOperType.CredOperStep.Value;
            credOper.BeginDate = beginDate;
            credOper.FinancialProductId = finProd.Id;
            credOper.CurrencyId = finProd.CurrencyId;
            credOper.TaxRegimeId = 1; // <TaxRegime Identifier> to be defined in some portal configuration

            //credOper.CredOperChannelId = 19; // <portal ChannelId> to be defined in some portal configuration  
            //credOper.AplBusinessPurposeTypeId = aplBusinessPurposeTypeId;
            #endregion

            isAutoCredit = credOperType.IsAutoCredit ?? false;
            
            #region Create FinConditions

            // get tax type from CredOperType parametrization
            taxTypeId = credOperType.RentTaxTypeId;

            // In case of AutoCredit, the tax type is from the asset parametrization
            if (businessKind == SVC_Framework.BusinessKind.Credit && isAutoCredit)
                taxTypeId = credOperType.AssetTaxTypeId;

            // Create the FinConditions for the CredOper
            FinConditions finCond = new FinConditions();
            finCond.Status = InstanceStatus.Insert;
            finCond.CurrencyId = finProd.CurrencyId;
            finCond.InitialDate = beginDate;
            finCond.ValueDate = beginDate;
            finCond.ResidualValue = 0;
            finCond.FinInitialEntryTypeId = (int)FinInitialEntryTypeKind.DoesntHave;
            finCond.InitialEntryValue = null;
            finCond.InitialEntryPercentage = null;

            finCond.RentTaxTypeId = credOperType.RentTaxTypeId;
            //if (businessKind == SVC_Framework.BusinessKind.Renting)
            finCond.SaleTaxTypeId = credOperType.RentTaxTypeId;

            finCond.AmountHasTaxes = businessKind == SVC_Framework.BusinessKind.Credit || businessKind == SVC_Framework.BusinessKind.CreditImob;

            credOper.Conditions = new FinConditions[1];
            credOper.Conditions[0] = finCond;

            #endregion

            #endregion

            return credOper;
        }
        #endregion

        #region - MapCredOperAssetWithEquipment
        // Create the Equipment, set equipment fields and map to CredOperAsset
        private static CredOperAsset Day3_MapCredOperAssetWithEquipment(int? taxTypeId,
                                                                        SVC_Simulations.FinancialProduct finProd,
                                                                        SessionTokenWcfHeader tokenHeaderCO,
                                                                        CreditOperationsClient clientCO,
                                                                        CredOper credOper,
                                                                        DateTime beginDate)
        {
            CredOperAsset asset = new CredOperAsset();
            asset.Status = InstanceStatus.Insert;
            asset.BeginDate = beginDate;
            asset.AssetType = (int)AssetTypeKind.Equipment;

            #region Map Equipment Fields

            Equipment equip = new Equipment();
            equip.Status = InstanceStatus.Insert;
            equip.AplCompanyId = finProd.AplCompanyId;
            //equip.EquipmentBrand = "brand";
            //equip.EquipmentModel = "model";
            //equip.EquipVersion = "variant";

            //equip.AssetOriginId = 3; //dealer

            equip.CurrencyId = finProd.CurrencyId;

            equip.TaxTypeId = taxTypeId; //purshase tax
            equip.EquipYear = DateTime.Today.Year;
            equip.EquipmentStateId = (int)EquipmentStateKind.New;
            equip.CurrencyId = finProd.CurrencyId;

            CodeAbbreviation equipmentInicialStateStr = clientCO.GetEquipmentInicialState(tokenHeaderCO, C_AplCompanyId, null);
            equip.AutUserStateId = long.Parse(equipmentInicialStateStr.Code);
            equip.StateDate = DateTime.Today;

            if (finProd.AplBusinessId == (int)SVC_Framework.BusinessKind.Renting)
            {
                equip.EquipMonth = 1;
                equip.Quantity = 1;
            }

            #endregion

            asset.AssetItem = 1;
            asset.NewAssetId = 1;
            asset.IsRelocation = false;
            asset.CurrencyId = finProd.CurrencyId;
            asset.Equipment = equip;

            if (credOper.Assets == null || credOper.Assets.Length == 0)
                credOper.Assets = new CredOperAsset[1];

            return asset;
        }
        #endregion

        #region - SetEquipmentCredOperAmounts
        // Set amount fields on operation/quotation to be calculated
        private static CredOper Day3_SetEquipmentCredOperAmounts(   string token,
                                                                CredOper credOper,
                                                                SVC_Simulations.FinancialProduct finprod,
                                                                bool isAutoCredit,
                                                                SVC_CreditOperationsConfig.CredOperType credOperType,
                                                                decimal purchaseAmount,
                                                                decimal? retakeAmount,
                                                                ref int? taxTypeId)
        {
            #region TokenHeader AcpFramework
            SVC_Framework.SessionTokenWcfHeader tokenHeader = new SVC_Framework.SessionTokenWcfHeader { Token = token };
            SVC_Framework.AcpFrameworkClient clientCO = new SVC_Framework.AcpFrameworkClient();
            //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;
            #endregion

            #region Set EquipmentAmounts
            // we need to calculate the retake amount after the SetFinancialProductAndSymbolProdDefaults 
            // to ensure that the correct restriction or symbol is set

            #region Variables 
            decimal baseAmount = 0;
            decimal accessoriesAmountWithTax = 0;
            decimal optionsAmountWithTax = 0;
            decimal accessoriesNetAmount = 0;
            decimal optionsNetAmount = 0;
            #endregion

            if (retakeAmount == null)
                retakeAmount = purchaseAmount * (credOper.Assets[0].Equipment.RetakePercentage ?? 0) / 100.00m;

            if (credOper.AplBusinessId == (int)SVC_Framework.BusinessKind.Credit && !isAutoCredit)
            {
                baseAmount = purchaseAmount - retakeAmount.Value;

                decimal amountWithoutOptions = purchaseAmount - accessoriesAmountWithTax - optionsAmountWithTax;

                credOper.Assets[0].Equipment.PurchaseAmount = purchaseAmount;
                credOper.Assets[0].Equipment.TaxTypeId = taxTypeId;

                credOper.Assets[0].Equipment.OptionsAmount = optionsAmountWithTax;
                credOper.Assets[0].Equipment.AccessoriesAmount = accessoriesAmountWithTax;

                decimal taxAmount = clientCO.GetIncludedTaxAmount(tokenHeader, taxTypeId.Value, DateTime.Today, amountWithoutOptions, credOper.CurrencyId);

                credOper.Assets[0].Equipment.TaxAmount = taxAmount;
                credOper.Assets[0].Equipment.NetAmount = amountWithoutOptions - taxAmount;

                credOper.Assets[0].Equipment.RetakeAmount = retakeAmount;

                credOper.Assets[0].BaseAmount = baseAmount;
                credOper.Assets[0].Amount = baseAmount;
            }
            else if (credOper.AplBusinessId == (int)SVC_Framework.BusinessKind.Credit && isAutoCredit)
            {
                taxTypeId = credOperType.AssetTaxTypeId;
                //SymbolLimit rvSymbol = credOper.GetFinancialProductLimits(finProd.Id.Value, (int)FinSymbolKind.BalloonPercentage, null, false);

                baseAmount = purchaseAmount - accessoriesAmountWithTax - optionsAmountWithTax;
                decimal includedTaxAmount = clientCO.GetIncludedTaxAmount(tokenHeader, taxTypeId.Value, DateTime.Today, baseAmount, credOper.CurrencyId);
                decimal netAmount = baseAmount - includedTaxAmount;

                credOper.Assets[0].Equipment.PurchaseAmount = baseAmount;
                credOper.Assets[0].Equipment.TaxTypeId = taxTypeId;

                credOper.Assets[0].Equipment.BaseNetAmount = netAmount;
                credOper.Assets[0].Equipment.NetAmount = netAmount;
                credOper.Assets[0].Equipment.TaxAmount = includedTaxAmount;

                credOper.Assets[0].Equipment.OptionsAmount = optionsAmountWithTax;
                credOper.Assets[0].Equipment.AccessoriesAmount = accessoriesAmountWithTax;

                credOper.Assets[0].Equipment.RetakeAmount = retakeAmount;

                credOper.Assets[0].BaseAmount = baseAmount + accessoriesAmountWithTax + optionsAmountWithTax - retakeAmount;
                credOper.Assets[0].Amount = null;// baseAmount + accessoriesAmount + optionsAmount;
                credOper.Conditions[0].FinancialValue = null;// baseAmount + accessoriesAmount + optionsAmount;
            }
            else //if (credOper.AplBusinessId == (int)SVC_Framework.BusinessKind.Renting)
            {
                //BaseAmount: for credit business the value is with tax
                //In the future, for other businesses, need to be checked since value is without tax.

                baseAmount = purchaseAmount - accessoriesAmountWithTax - optionsAmountWithTax;

                decimal includedTaxAmount = clientCO.GetIncludedTaxAmount(tokenHeader, taxTypeId.Value, DateTime.Today, baseAmount, credOper.CurrencyId);
                decimal netAmount = baseAmount - includedTaxAmount;

                //finprod.RentIncludedTaxAmount = includedTaxAmount;

                credOper.Assets[0].Equipment.TaxAmount = includedTaxAmount;
                credOper.Assets[0].Equipment.NetAmount = netAmount;
                credOper.Assets[0].Equipment.PurchaseAmount = baseAmount;
                credOper.Assets[0].Equipment.TaxTypeId = credOperType.AssetTaxTypeId;
                credOper.Assets[0].Equipment.BaseNetAmount = credOper.Assets[0].Equipment.NetAmount;

                credOper.Assets[0].Equipment.OptionsAmount = optionsNetAmount;
                credOper.Assets[0].Equipment.AccessoriesAmount = accessoriesNetAmount;

                //credOper.Assets[0].Equipment.RetakeAmount = retakeAmount;

                credOper.Assets[0].BaseAmount = netAmount + accessoriesNetAmount + optionsNetAmount;
                credOper.Assets[0].Amount = null;//baseAmount + accessoriesAmount + optionsAmount;

                credOper.Conditions[0].FinancialValue = null;// baseAmount + taxAmount + accessoriesAmount + optionsAmount;
            }
            #endregion

            return credOper;
        }
        #endregion

        #region - SetEquipmentSupplier
        // Add a Supplier to the Equipment
        private static CredOper Day3_SetEquipmentSupplier(CredOper credOper)
        {
            CredOper co = credOper;

            if (credOper != null && credOper.Assets != null && credOper.Assets.Length > 0 && credOper.Assets[0].Equipment != null)
            {
                // set supplier entity identifier
                credOper.Assets[0].Equipment.SupplierEntityId = C_DefaultSupplierEntityId;

                if (credOper.IntervSuppliers == null)
                    credOper.IntervSuppliers = new CredOperIntervSupplier[1];

                credOper.IntervSuppliers[0] = new CredOperIntervSupplier
                {
                    Status = InstanceStatus.Insert,
                    EntityId = C_DefaultSupplierEntityId
                };
            }

            return co;
        }
        #endregion

        #endregion

        #region Exercise 9 - Create Quotation (Leasing)
        
        private static CredOper Day3_Exercixe9_CreateQuotationWithEquipment(SVC_Logon.LoginInfo info)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day3_Exercixe9_CreateQuotationWithEquipment --------------------");

            // Insert Code Here

            return null;
        }

        #endregion
        
        #endregion

        #endregion

        // -------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------ DAY 4 ------------------------------------------------------

        #region Day 4

        #region Day 4 - Calculate Quotation - 

        #region Demo Calculate Quotations
        private static CredOper Day4_CalculateQuotationWithNewTerm(SVC_Logon.LoginInfo info, CredOper credOper)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day4_CalculateQuotationWithNewTerm --------------------");

            #region Initialize Variables

            string token = info.SessionToken;
            int productId = credOper.FinancialProductId.Value;
            long credOperTypeId = credOper.CredOperTypeId.Value;
            CredOperValidationResult credOperResult = null;
            SVC_Framework.BusinessKind? businessKind = (SVC_Framework.BusinessKind)credOper.AplBusinessId.Value;

            int newTerm = 48;

            #endregion

            #region Creation of TokenHeaders - CreditOperations; Simulations; BusinessFramework

            SessionTokenWcfHeader tokenHeaderCO = new SessionTokenWcfHeader { Token = token };
            CreditOperationsClient clientCO = new CreditOperationsClient();
            //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            SVC_Simulations.SessionTokenWcfHeader tokenHeaderS = new SVC_Simulations.SessionTokenWcfHeader { Token = token };
            SVC_Simulations.SimulationsClient clientS = new SVC_Simulations.SimulationsClient();
            //clientS.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientS.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            SVC_BusinessFramework.SessionTokenWcfHeader tokenHeaderBF = new SVC_BusinessFramework.SessionTokenWcfHeader { Token = token };
            SVC_BusinessFramework.BusinessFrameworkClient clientBF = new SVC_BusinessFramework.BusinessFrameworkClient();
            //clientBF.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientBF.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            // **********************************************************************
            #endregion

            try
            {
                #region Change the Term

                if (credOper.Conditions != null && credOper.Conditions.Length > 0)
                {
                    credOper.Conditions[0].IRRate = null;
                    credOper.Conditions[0].ERRate = null;
                    credOper.Conditions[0].InitialRentValue = null;
                }

                //if (businessKind != SVC_Framework.BusinessKind.Renting)
                //{
                if (credOper.Conditions != null && credOper.Conditions.Length > 0)
                    credOper.Conditions[0].Term = newTerm;
                //}
                //else
                //{
                if (credOper.Assets != null && credOper.Assets.Length > 0)
                    credOper.Assets[0].Term = newTerm;
                //}

                //if (currentMileage != null && (isAutoCredit || businessKind == SVC_Framework.BusinessKind.Renting))
                //{
                //    if (credOper.Assets != null && credOper.Assets.Length > 0)
                //        credOper.Assets[0].AssetUsage = currentMileage;
                //}

                #endregion

                #region Set Quotation and Dates

                SVC_Simulations.FinDateCalcInfo dateInfo = clientS.GetTransferDate(tokenHeaderS,
                                                                                    credOperTypeId,
                                                                                    credOper.BeginDate,
                                                                                    credOper.Conditions[0].FinDueRegimeId,
                                                                                    credOper.Conditions[0].FinInitialEntryTypeId,
                                                                                    credOper.Conditions[0].DifferPeriods,
                                                                                    credOper.Conditions[0].GracePeriods,
                                                                                    credOper.Conditions[0].PeriodId,
                                                                                    null, null);

                credOper.Conditions[0].TransferDate = dateInfo.Date;
                credOper.Conditions[0].SpreadDate = credOper.Conditions[0].InitialDate;
                credOper.Conditions[0].ValueDate = credOper.Conditions[0].InitialDate;

                credOper.Conditions[0].DayRent = dateInfo.Day;

                credOper.EndDate = clientBF.GetFinalDate(tokenHeaderBF,
                                                            credOper.BeginDate,
                                                            credOper.Conditions[0].Term ?? credOper.Assets[0].Term,
                                                            dateInfo.Day,
                                                            null);

                credOper.Conditions[0].FinalDate = credOper.EndDate;

                if (businessKind == SVC_Framework.BusinessKind.Renting)
                {
                    if (credOper.Conditions[0].FinInitialEntryTypeId == (int)SVC_Simulations.FinInitialEntryTypeKind.ProRataRent)
                        credOper.Conditions[0].Term = (credOper.Assets[0].Term ?? 0) + 1;
                    else
                        credOper.Conditions[0].Term = credOper.Assets[0].Term;
                }

                #endregion

                #region Calculate New Rent Calendar

                SVC_Simulations.FinConditions newConditions = clientS.CalculateRentsCalendar(tokenHeaderS,
                                                                                                DomainTranslator.Translate(credOper.Conditions[0]),
                                                                                                credOperTypeId,
                                                                                                productId,
                                                                                                false);
                credOper.Conditions[0] = DomainTranslator.Translate(newConditions);

                #endregion

                #region CalculateCredOperWithAssetExpensesGeneration

                try
                {
                    credOperResult = clientCO.CalculateCredOperWithAssetExpensesGeneration(tokenHeaderCO, credOper, 0, 0, (int)AssetTypeKind.Equipment);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Try Catch CalculateCredOperWithAssetExpensesGeneration: " + ex.ToString());
                }

                if (credOperResult != null)
                {
                    if (credOperResult.CredOper != null)
                        credOper = credOperResult.CredOper;
                }
                else
                {
                    Console.WriteLine("Error: credOperResult is null");
                }

                if (credOper != null && credOper.Conditions != null && credOper.Conditions.Length > 0 && credOper.Conditions[0].Flows != null && credOper.Conditions[0].Flows.Length > 0)
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("CredOperNumber: {0}", credOper.CredOperNumber);
                    Console.WriteLine("Installment Amount: {0}", credOper.Conditions[0].Flows[0].Amount);
                    Console.WriteLine("Ballon Amount: {0}", credOper.Conditions[0].Flows[1].Amount);
                    Console.WriteLine("Number of Rents (Term): {0}", credOper.Conditions[0].Term);
                    //Console.WriteLine("Customer Rental Amount With Tax: {0}", oper.Conditions[0].Flows[0].CustomerRentalAmountWithTax);

                    return credOper;
                }

                #endregion  
            }
            catch (Exception ex)
            {
                Console.WriteLine("TryCatch Day4_CalculateQuotationWithNewTerm: " + ex.ToString());
            }

            return credOper;
        }

        private static CredOper Day4_CalculateQuotationWithNewTermAfterSaved(SVC_Logon.LoginInfo info, long credOperId)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day4_CalculateQuotationWithNewTermAfterSaved --------------------");

            #region Creation of TokenHeaders - CreditOperations; Simulations; BusinessFramework

            string token = info.SessionToken;

            SessionTokenWcfHeader tokenHeaderCO = new SessionTokenWcfHeader { Token = token };
            CreditOperationsClient clientCO = new CreditOperationsClient();
            //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            SVC_Simulations.SessionTokenWcfHeader tokenHeaderS = new SVC_Simulations.SessionTokenWcfHeader { Token = token };
            SVC_Simulations.SimulationsClient clientS = new SVC_Simulations.SimulationsClient();
            //clientS.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientS.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            SVC_BusinessFramework.SessionTokenWcfHeader tokenHeaderBF = new SVC_BusinessFramework.SessionTokenWcfHeader { Token = token };
            SVC_BusinessFramework.BusinessFrameworkClient clientBF = new SVC_BusinessFramework.BusinessFrameworkClient();
            //clientBF.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientBF.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            // **********************************************************************
            #endregion

            CredOper credOper = null;

            try
            {
                #region Fetch CredOper (Quotation)

                CredOperKey[] key = { new CredOperKey() { Id = credOperId } };
                BusinessDetailFetchInfo[] equipmentDetails = { new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)CredOperAssetDetail.Equipment } };
                BusinessDetailFetchInfo[] conditionsFlows = { new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)FinConditionsDetail.Flow } };
                BusinessDetailFetchInfo[] proposalDetails = {   new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)CredOperDetail.Asset, DetailsInfo = equipmentDetails },
                                                                new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)CredOperDetail.Condition, DetailsInfo = conditionsFlows } };

                CredOper[] credOpers = clientCO.GetCredOperByKeys(tokenHeaderCO, key, false, proposalDetails);

                if (credOpers != null && credOpers.Length > 0)
                    credOper = credOpers[0];

                Console.WriteLine(Environment.NewLine + "Quotation Data Before Update");
                Console.WriteLine("Did: {0}", credOper.Id);
                Console.WriteLine("CredOperNumber: {0}", credOper.CredOperNumber);
                if (credOper.Conditions != null && credOper.Conditions.Length > 0)
                {
                    if (credOper.Conditions[0].Flows != null && credOper.Conditions[0].Flows.Length > 0)
                    {
                        Console.WriteLine("Installment Amount: {0}", credOper.Conditions[0].Flows[0].Amount);
                        Console.WriteLine("Ballon Amount: {0}", credOper.Conditions[0].Flows[1].Amount);
                        Console.WriteLine("Number of Rents (Term): {0}", credOper.Conditions[0].Term);
                    }
                }
                credOper.Status = InstanceStatus.Update;

                if (credOper.Conditions != null && credOper.Conditions.Length > 0)
                {
                    credOper.Conditions[0].IRRate = null;
                    credOper.Conditions[0].ERRate = null;
                    credOper.Conditions[0].InitialRentValue = null;
                }

                #endregion

                #region Initialize Variables

                int productId = credOper.FinancialProductId.Value;
                long credOperTypeId = credOper.CredOperTypeId.Value;
                CredOperValidationResult credOperResult = null;
                SVC_Framework.BusinessKind? businessKind = (SVC_Framework.BusinessKind)credOper.AplBusinessId.Value;

                int newTerm = 36;

                #endregion

                #region Change the Term

                //if (businessKind != SVC_Framework.BusinessKind.Renting)
                //{
                if (credOper.Conditions != null && credOper.Conditions.Length > 0)
                    credOper.Conditions[0].Term = newTerm;
                //}
                //else
                //{
                if (credOper.Assets != null && credOper.Assets.Length > 0)
                    credOper.Assets[0].Term = newTerm;
                //}

                //if (currentMileage != null && (isAutoCredit || businessKind == SVC_Framework.BusinessKind.Renting))
                //{
                //    if (credOper.Assets != null && credOper.Assets.Length > 0)
                //        credOper.Assets[0].AssetUsage = currentMileage;
                //}

                #endregion

                #region Set Quotation and Dates

                SVC_Simulations.FinDateCalcInfo dateInfo = clientS.GetTransferDate(tokenHeaderS,
                                                                                    credOperTypeId,
                                                                                    credOper.BeginDate,
                                                                                    credOper.Conditions[0].FinDueRegimeId,
                                                                                    credOper.Conditions[0].FinInitialEntryTypeId,
                                                                                    credOper.Conditions[0].DifferPeriods,
                                                                                    credOper.Conditions[0].GracePeriods,
                                                                                    credOper.Conditions[0].PeriodId,
                                                                                    null, null);

                credOper.Conditions[0].TransferDate = dateInfo.Date;
                credOper.Conditions[0].SpreadDate = credOper.Conditions[0].InitialDate;
                credOper.Conditions[0].ValueDate = credOper.Conditions[0].InitialDate;

                credOper.Conditions[0].DayRent = dateInfo.Day;

                credOper.EndDate = clientBF.GetFinalDate(tokenHeaderBF,
                                                            credOper.BeginDate,
                                                            credOper.Conditions[0].Term ?? credOper.Assets[0].Term,
                                                            dateInfo.Day,
                                                            null);

                credOper.Conditions[0].FinalDate = credOper.EndDate;

                if (businessKind == SVC_Framework.BusinessKind.Renting)
                {
                    if (credOper.Conditions[0].FinInitialEntryTypeId == (int)SVC_Simulations.FinInitialEntryTypeKind.ProRataRent)
                        credOper.Conditions[0].Term = (credOper.Assets[0].Term ?? 0) + 1;
                    else
                        credOper.Conditions[0].Term = credOper.Assets[0].Term;
                }

                #endregion

                #region Calculate New Rent Calendar

                SVC_Simulations.FinConditions newConditions = clientS.CalculateRentsCalendar(tokenHeaderS,
                                                                                                DomainTranslator.Translate(credOper.Conditions[0]),
                                                                                                credOperTypeId,
                                                                                                productId,
                                                                                                false);
                credOper.Conditions[0] = DomainTranslator.Translate(newConditions);

                #endregion

                #region CalculateCredOperWithAssetExpensesGeneration

                try
                {
                    credOperResult = clientCO.CalculateCredOperWithAssetExpensesGeneration(tokenHeaderCO, credOper, 0, 0, (int)AssetTypeKind.Equipment);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Try Catch CalculateCredOperWithAssetExpensesGeneration: " + ex.ToString());
                }

                if (credOperResult != null)
                {
                    if (credOperResult.CredOper != null)
                        credOper = credOperResult.CredOper;
                }
                else
                {
                    Console.WriteLine("Error: credOperResult is null");
                }

                if (credOper != null && credOper.Conditions != null && credOper.Conditions.Length > 0 && credOper.Conditions[0].Flows != null && credOper.Conditions[0].Flows.Length > 0)
                {
                    Console.WriteLine(Environment.NewLine + "Quotation Data After Update");
                    Console.WriteLine("CredOperNumber: {0}", credOper.CredOperNumber);
                    Console.WriteLine("Installment Amount: {0}", credOper.Conditions[0].Flows[0].Amount);
                    Console.WriteLine("Ballon Amount: {0}", credOper.Conditions[0].Flows[1].Amount);
                    Console.WriteLine("Number of Rents (Term): {0}", credOper.Conditions[0].Term);
                    //Console.WriteLine("Customer Rental Amount With Tax: {0}", oper.Conditions[0].Flows[0].CustomerRentalAmountWithTax);

                    return credOper;
                }

                #endregion  
            }
            catch (Exception ex)
            {
                Console.WriteLine("TryCatch Day4_CalculateQuotationWithNewTermAfterSaved: " + ex.ToString());
            }

            return credOper;
        }
        #endregion

        #region Exercise10 - Calculate Quotation

        private static CredOper Day4_Exercise10_CalculateQuotationWithNewTerm(SVC_Logon.LoginInfo info, CredOper credOper)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day4_Exercise10_CalculateQuotationWithNewTerm --------------------");

            // Insert Code Here

            return credOper;
        }

        private static CredOper Day4_Exercise10_CalculateQuotationWithNewTermAfterSaved(SVC_Logon.LoginInfo info, long credOperId)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day4_Exercise10_CalculateQuotationWithNewTermAfterSaved --------------------");

            // Insert Code Here

            return null;
        }

        #endregion

        #endregion

        #region Day 4 - Save Quotation - 
        private static long Day4_SaveQuotation(SVC_Logon.LoginInfo info, CredOper quotation)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day4_SaveQuotation --------------------");
            long quotationId = 0;

            try
            {
                #region TokenHeader CreditOperations; AcpParametrization

                string token = info.SessionToken;

                SessionTokenWcfHeader tokenHeader = new SessionTokenWcfHeader { Token = token };

                CreditOperationsClient clientCO = new CreditOperationsClient();
                //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                SVC_AcpParameterizations.SessionTokenWcfHeader tokenHeaderParam = new SVC_AcpParameterizations.SessionTokenWcfHeader { Token = token };

                SVC_AcpParameterizations.AcpParameterizationClient clientParam = new SVC_AcpParameterizations.AcpParameterizationClient();
                //clientParam.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientParam.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                #endregion

                #region Save Quotation 

                SaveResult resultQuotation = clientCO.SaveCreditOperationsV2(tokenHeader, CreditOperationsSaveClass.CredOper, quotation, null);

                // we may need to check the "resultQuotation.Validations" to find if we had any error and the quotation was not save
                if (resultQuotation != null && resultQuotation.Key != null)
                {
                    quotationId = ((CredOperKey)resultQuotation.Key).Id.Value;

                    Console.WriteLine("New Quotation ID: {0}", quotationId);
                    Console.WriteLine("Quotation Number: {0}", ((CredOperKey)resultQuotation.Key).CredOperNumber.Value);
                }
                else
                {
                    Console.WriteLine("Quotation Not Created");

                    if (resultQuotation.Validations.Length > 0)
                        foreach (ValidationResult val in resultQuotation.Validations)
                            Console.WriteLine("Error message:" + val.Message);
                }

                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine("TryCatch Day4_SaveQuotation: " + ex.ToString());
            }

            return quotationId;
        }
        #endregion

        #region Day 4 - Day4_QuotationToProposal - 

        #region Demo Quotation to Proposal

        private static long Day4_GetCurrentAvailableTransitions(SVC_Logon.LoginInfo info, long quotationId)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day4_GetCurrentAvailableTransitions --------------------");

            #region Creation of TokenHeaders - CreditOperations

            string token = info.SessionToken;
            SessionTokenWcfHeader tokenHeader = new SessionTokenWcfHeader { Token = token };

            CreditOperationsClient clientCO = new CreditOperationsClient();
            //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            #endregion

            long transitionId = 0;
            int aux = 0;

            try
            {
                Console.WriteLine("Quotation ID: {0}", quotationId);

                // ****************************************************************************
                // Make Transition in Quotation to a State that allows the creation of the Proposal
                // ****************************************************************************
                // --> Depends on the quotation workflow that is setup
                AutTransition[] currentAvailableTransitions = clientCO.GetCredOperTransitionList(tokenHeader, quotationId, false, false); // to check available transitions
                
                // hardcoded final state example just for test purposes
                long finalStateId = 1145; // Proposal State

                if (currentAvailableTransitions != null)
                {
                    for (int i = 0; i < currentAvailableTransitions.Length; i++)
                    {
                        Console.WriteLine("TransitionId: {0}; Abrev: {1}; Initial State: {2}; Final State: {3}",
                                            currentAvailableTransitions[i].Id.Value,
                                            currentAvailableTransitions[i].Abrev,
                                            currentAvailableTransitions[i].InitialAutStateId,
                                            currentAvailableTransitions[i].FinalAutStateId);

                        if (currentAvailableTransitions[i].FinalAutStateId == finalStateId)
                        {
                            transitionId = currentAvailableTransitions[i].Id.Value;
                            aux = i;
                        }
                    }
                }

                Console.WriteLine(Environment.NewLine +
                                    "Transition Selected ->  TransitionId: {0}; Abrev: {1}; Initial State: {2}; Final State: {3}",
                                    currentAvailableTransitions[aux].Id.Value,
                                    currentAvailableTransitions[aux].Abrev,
                                    currentAvailableTransitions[aux].InitialAutStateId,
                                    currentAvailableTransitions[aux].FinalAutStateId);

            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine + "TryCatch Day4_GetCurrentAvailableTransitions: " + ex.ToString());
            }

            return transitionId;
        }

        private static CredOper Day4_QuotationToProposal(SVC_Logon.LoginInfo info, long quotationId)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day4_QuotationToProposal --------------------");

            #region Creation of TokenHeaders - CreditOperations; AcpParameterization

            string token = info.SessionToken;
            SessionTokenWcfHeader tokenHeader = new SessionTokenWcfHeader { Token = token };

            CreditOperationsClient clientCO = new CreditOperationsClient();
            //clientCO.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientCO.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            SVC_AcpParameterizations.SessionTokenWcfHeader tokenHeaderParam = new SVC_AcpParameterizations.SessionTokenWcfHeader { Token = token };

            SVC_AcpParameterizations.AcpParameterizationClient clientParam = new SVC_AcpParameterizations.AcpParameterizationClient();
            //clientParam.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
            clientParam.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

            #endregion

            CredOper proposal = null;

            try
            {
                #region Get "Proposal Slim Object" - The object saved in memory before the proposal being saved
                
                // **************************************
                // Transit Quotation to Proposal
                // **************************************
                
                // The proposal is just an object in memory until is saved and the quotation state is only changed if the proposal is saved
                proposal = clientCO.GetQuotationToProposal(tokenHeader, quotationId);
               
                #endregion

                #region Add a Customer to the Proposal

                proposal.IntervCustomers = new CredOperIntervCustomer[1];
                proposal.IntervCustomers[0] = new CredOperIntervCustomer()
                {
                    Status = InstanceStatus.Insert,
                    CredOperIntervType = clientParam.GetCreditOperationsIntervenientsTypeCid(tokenHeaderParam, SVC_AcpParameterizations.CredOperIntervTypeIndicator.Customer)
                };

                #region Use Existing Entity
                // **************************************
                // if we use an entity that already exists
                // **************************************

                long existingEntityId = 7167;

                proposal.CustomerEntityId = existingEntityId;
                proposal.IntervCustomers[0].EntityId = existingEntityId;

                #endregion

                // OR 

                #region Create new entity as the proposal Customer

                //SVC_Entities.Entity newEntity = Exercise_CreateNewEntity();
                //proposal.IntervCustomers[0].Entity = DomainTranslator.Translate(newEntity);

                // create the Company record of the intervention and that is relevant for tracebility of what data was considered when the proposal has a credit analisys
                //proposal.IntervCustomers[0].Company = new Company { Status = InstanceStatus.Insert };
                
                #region commented code - PErson fields and payment mode examples
                // proposal.IntervCustomers[0].Person.ActivityTypeContextId = <default id>

                // Set Customer Payment mode
                //proposal.IntervCustomers[0].PaymentModes = new OperationPaymentDataInUse[1];
                //proposal.IntervCustomers[0].PaymentModes[0].IsMain = true;
                //proposal.IntervCustomers[0].PaymentModes[0].PaymentModeId = ?;
                //proposal.IntervCustomers[0].PaymentModes[0].PaymentDataInfo = new PaymentDataInfo();
                //proposal.IntervCustomers[0].PaymentModes[0].PaymentDataInfo.Iban = ?;
                //proposal.IntervCustomers[0].PaymentModes[0].PaymentDataInfo.Swift = ?;
                #endregion

                #endregion

                #endregion

                #region Financial calculation of the proposal

                CredOperValidationResult credOperResult = clientCO.CalculateCredOperWithAssetExpensesGeneration(tokenHeader, proposal, 0, 0, (int)AssetTypeKind.Equipment);

                // get reference to calculated proposal
                proposal = credOperResult.CredOper;

                #endregion

                #region Save/Create the Proposal
                
                SaveResult resultProposal = clientCO.SaveCreditOperationsV2(tokenHeader, CreditOperationsSaveClass.CredOper, proposal, null);

                // we may need to check the "resultQuotation.Validations" to find if we had any error and the quotation was not save
                if (resultProposal != null && resultProposal.Key != null)
                {
                    #region Get contrat and vehicle detail

                    long? proposalId = ((CredOperKey)resultProposal.Key).Id.Value; // new proposal ID

                    // Proposal Asset Detail: Equipment - Vehicle 
                    BusinessDetailFetchInfo[] equipmentDetails = { new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)CredOperAssetDetail.Equipment } };

                    BusinessDetailFetchInfo[] entityDetails = { new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)EntityDetail.Person } };
                    BusinessDetailFetchInfo[] intervCustomerDetails = { new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)CredOperIntervDetail.Entity, DetailsInfo = entityDetails } };

                    //BusinessDetailFetchInfo[] intervSupplierDetails = { new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)CredOperIntervDetail.Entity } };

                    BusinessDetailFetchInfo[] proposalDetails = {       new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)CredOperDetail.IntervCustomer, DetailsInfo = intervCustomerDetails },
                                                                        //new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)CredOperDetail.IntervSupplier, DetailsInfo = intervSupplierDetails },
                                                                        new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)CredOperDetail.Asset, DetailsInfo = equipmentDetails },
                                                                        new BusinessDetailFetchInfo { Type = SelectType.Deep, Detail = (int)CredOperDetail.OtherExpense }
                        };

                    // GET info from the created proposal
                    BusinessEntityKey[] keys = { resultProposal.Key };
                    CredOper[] proposals = clientCO.GetCredOperByKeys(tokenHeader, keys, false, proposalDetails);

                    #endregion

                    if (proposals[0].IntervCustomers != null && proposals[0].IntervCustomers[0].Entity != null)
                    {
                        Console.WriteLine("Created Entity in Proposal Creation");
                        Console.WriteLine("Proposal Creation - New entity Id: {0}", proposals[0].IntervCustomers[0].Entity.Id);
                        Console.WriteLine("Proposal Creation - New Entity Number: {0}", proposals[0].IntervCustomers[0].Entity.EntityNumber);
                        Console.WriteLine("Proposal Creation - New Entity Name: {0}", proposals[0].IntervCustomers[0].Entity.FullName);

                        #region Proposal Suppliers 
                        if (proposals[0].IntervSuppliers != null && proposals[0].IntervSuppliers.Length > 0 && proposals[0].IntervSuppliers[0].Entity != null)
                        {
                            Console.WriteLine("Proposal Creation - Supplier Entity Number: {0}", proposals[0].IntervSuppliers[0].Entity.EntityNumber);
                            Console.WriteLine("proposal Creation - Supplier entity Name: {0}", proposals[0].IntervSuppliers[0].Entity.FullName);
                        }
                        #endregion

                        #region Equipment Supplier 
                        if (proposals[0].Assets != null
                            && proposals[0].Assets.Length > 0
                            && proposals[0].Assets[0].Equipment != null
                            && proposals[0].Assets[0].Equipment.SupplierEntityId.HasValue)
                        {
                            Console.WriteLine("Proposal Creation - Equipment Supplier Entity is: {0}", proposals[0].Assets[0].Equipment.SupplierEntityId);
                        }
                        #endregion

                        // get descrition for current proposal state
                        SVC_AutomatonsBasicLists.CodeAbbreviation[] states = GetOperationAutomatonStatesList(token, CreditOperationStep.Proposal);

                        string strId = proposals[0].AutUserStateId.ToString(); ;
                        string stateAbrev = states.Where<SVC_AutomatonsBasicLists.CodeAbbreviation>(x => x.Code == strId).Select<SVC_AutomatonsBasicLists.CodeAbbreviation, string>(x => x.Abbreviation).SingleOrDefault<string>();

                        Console.WriteLine("Proposal Creation - New Proposal Number: {0}", proposals[0].CredOperNumber);
                        Console.WriteLine("Proposal Creation - New Proposal State Id: {0}", proposals[0].AutUserStateId);
                        Console.WriteLine("Proposal Creation - New Proposal State Abreviation: {0}", stateAbrev);
                    }

                    return proposals[0];
                }
                else
                {
                    Console.WriteLine("Validation resultProposal != null && resultProposal.Key != nul dind't pass");
                }

                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine + "TryCatch Day4_QuotationToProposal: " + ex.ToString());
            }

            return proposal;
        }

        public static SVC_AutomatonsBasicLists.CodeAbbreviation[] GetOperationAutomatonStatesList(string token, CreditOperationStep operationStep)
        {
            try
            {
                #region Creation of TokenHeaders - Automatons and AutomatonsBasicLists - 

                SVC_Automatons.SessionTokenWcfHeader tokenHeader = new SVC_Automatons.SessionTokenWcfHeader { Token = token };

                SVC_Automatons.AutomatonsClient clientAut = new SVC_Automatons.AutomatonsClient();
                //clientAut.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientAut.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                SVC_AutomatonsBasicLists.SessionTokenWcfHeader tokenHeaderBL = new SVC_AutomatonsBasicLists.SessionTokenWcfHeader { Token = token };

                SVC_AutomatonsBasicLists.AutomatonsBasicListsClient clientAutBasicLists = new SVC_AutomatonsBasicLists.AutomatonsBasicListsClient();
                //clientAutBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials; /*set credentials of current AD user */
                clientAutBasicLists.ChannelFactory.Credentials.Windows.ClientCredential = networkCredentialForm1;

                #endregion

                 long autContextId;
                SVC_AutomatonsBasicLists.BasicList basicList = null;

                if (operationStep == CreditOperationStep.Proposal)
                {
                    autContextId = clientAut.GetAutContextId(tokenHeader, CreditOperationsAutContext.Proposal.ToString());
                    basicList = clientAutBasicLists.GetForeignDataList(tokenHeaderBL, SVC_AutomatonsBasicLists.AutomatonsForeignDataListId.UserState, autContextId.ToString());
                }
                else if (operationStep == CreditOperationStep.Quotation)
                {
                    autContextId = clientAut.GetAutContextId(tokenHeader, CreditOperationsAutContext.Quotation.ToString());
                    basicList = clientAutBasicLists.GetForeignDataList(tokenHeaderBL, SVC_AutomatonsBasicLists.AutomatonsForeignDataListId.UserState, autContextId.ToString());
                }

                if (basicList == null || basicList.List == null)
                    return null;

                return basicList.List;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }

        #endregion

        #region Exercise11 - Quotation to Proposal
        
        private static CredOper Day4_Exercise11_QuotationToProposal(SVC_Logon.LoginInfo info, long quotationId)
        {
            Console.WriteLine(Environment.NewLine + "-------------------- Day4_Exercise11_QuotationToProposal --------------------");

            // Insert Code Here

            return null;
        }

        #endregion

        #endregion

        #endregion

        // -------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------ DAY 5 ------------------------------------------------------

        #region Day 5 - Exam

        // Insert Code Here

        #endregion

    }
}