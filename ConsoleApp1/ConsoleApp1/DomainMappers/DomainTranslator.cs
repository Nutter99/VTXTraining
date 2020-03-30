using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ConsoleApp1.DomainMappers
{
    /// <summary>
    /// Translattor of classes between diferrente services domains
    /// </summary>
    public static class DomainTranslator
    {
        #region Methods that convert Finconditions and relateds (Flows and Rates)

        public static SVC_Simulations.FinConditions Translate(SVC_CreditOperation.FinConditions origin)
        {
            SVC_Simulations.FinConditions target = null;

            if (origin != null)
            {
                origin.ModifiedFields = null;
                origin.ModifiedValues = null;
                origin.TableData = null;
                origin.Dependencies = null;
                origin.FieldStates = null;
                origin.Warnings = null;

                // save flow reference
                SVC_CreditOperation.FinConditionsFlows[] originFlows = origin.Flows;
                origin.Flows = null;
                // save rates reference
                SVC_CreditOperation.FinConditionsRate[] originRates = origin.Rates;
                origin.Rates = null;

                /*get new object, which been mapped*/
                SVC_Simulations.FinConditions newMapped = origin.CreateMapped<SVC_CreditOperation.FinConditions, SVC_Simulations.FinConditions>();

                target = newMapped;
                target.Status = origin.Status == SVC_CreditOperation.InstanceStatus.Insert ? SVC_Simulations.InstanceStatus.Insert : SVC_Simulations.InstanceStatus.Update;

                target.Flows = DomainTranslator.Translate(originFlows);
                target.Rates = DomainTranslator.Translate(originRates);
            }

            return target;
        }
        
        public static SVC_CreditOperation.FinConditions Translate(SVC_Simulations.FinConditions origin)
        {
            SVC_CreditOperation.FinConditions target = null;

            if (origin != null)
            {
                origin.ModifiedFields = null;
                origin.ModifiedValues = null;
                origin.TableData = null;
                origin.Dependencies = null;
                origin.FieldStates = null;
                origin.Warnings = null;

                // save flow reference
                SVC_Simulations.FinConditionsFlows[] originFlows = origin.Flows;
                origin.Flows = null;
                // save rates reference
                SVC_Simulations.FinConditionsRate[] originRates = origin.Rates;
                origin.Rates = null;

                /*get new object, which been mapped*/
                SVC_CreditOperation.FinConditions newMapped = origin.CreateMapped<SVC_Simulations.FinConditions, SVC_CreditOperation.FinConditions>();

                target = newMapped;
                target.Status = origin.Status == SVC_Simulations.InstanceStatus.Insert ? SVC_CreditOperation.InstanceStatus.Insert : SVC_CreditOperation.InstanceStatus.Update;

                target.Flows = DomainTranslator.Translate(originFlows);
                target.Rates = DomainTranslator.Translate(originRates);
            }

            return target;
        }

        public static SVC_Simulations.FinConditionsFlows[] Translate(SVC_CreditOperation.FinConditionsFlows[] origin)
        {
            SVC_Simulations.FinConditionsFlows[] target = null;

            if (origin != null)
            {
                target = new SVC_Simulations.FinConditionsFlows[origin.Length];

                for (int i = 0; i < origin.Length; i++)
                {
                    origin[i].ModifiedFields = null;
                    origin[i].ModifiedValues = null;
                    origin[i].TableData = null;
                    origin[i].FieldStates = null;
                    origin[i].Warnings = null;

                    /*get new object, which been mapped*/
                    SVC_Simulations.FinConditionsFlows newMapped = origin[i].CreateMapped<SVC_CreditOperation.FinConditionsFlows, SVC_Simulations.FinConditionsFlows>();

                    target[i] = newMapped;
                    target[i].Status = origin[i].Status == SVC_CreditOperation.InstanceStatus.Insert ? SVC_Simulations.InstanceStatus.Insert : SVC_Simulations.InstanceStatus.Update;
                }
            }

            return target;
        }
        
        public static SVC_Simulations.FinConditionsRate[] Translate(SVC_CreditOperation.FinConditionsRate[] origin)
        {
            SVC_Simulations.FinConditionsRate[] target = null;

            if (origin != null)
            {
                target = new SVC_Simulations.FinConditionsRate[origin.Length];

                for (int i = 0; i < origin.Length; i++)
                {
                    origin[i].ModifiedFields = null;
                    origin[i].ModifiedValues = null;
                    origin[i].TableData = null;
                    origin[i].FieldStates = null;
                    origin[i].Warnings = null;

                    /*get new object, which been mapped*/
                    SVC_Simulations.FinConditionsRate newMapped = origin[i].CreateMapped<SVC_CreditOperation.FinConditionsRate, SVC_Simulations.FinConditionsRate>();

                    target[i] = newMapped;
                    target[i].Status = origin[i].Status == SVC_CreditOperation.InstanceStatus.Insert ? SVC_Simulations.InstanceStatus.Insert : SVC_Simulations.InstanceStatus.Update;
                }
            }

            return target;
        }

        public static SVC_CreditOperation.FinConditionsFlows[] Translate(SVC_Simulations.FinConditionsFlows[] origin)
        {
            SVC_CreditOperation.FinConditionsFlows[] target = null;

            if (origin != null)
            {
                target = new SVC_CreditOperation.FinConditionsFlows[origin.Length];

                for (int i = 0; i < origin.Length; i++)
                {
                    origin[i].ModifiedFields = null;
                    origin[i].ModifiedValues = null;
                    origin[i].TableData = null;
                    origin[i].FieldStates = null;
                    origin[i].Warnings = null;

                    /*get new object, which been mapped*/
                    SVC_CreditOperation.FinConditionsFlows newMapped = origin[i].CreateMapped<SVC_Simulations.FinConditionsFlows, SVC_CreditOperation.FinConditionsFlows>();

                    target[i] = newMapped;
                    target[i].Status = origin[i].Status == SVC_Simulations.InstanceStatus.Insert ? SVC_CreditOperation.InstanceStatus.Insert : SVC_CreditOperation.InstanceStatus.Update;
                }
            }

            return target;
        }
        
        public static SVC_CreditOperation.FinConditionsRate[] Translate(SVC_Simulations.FinConditionsRate[] origin)
        {
            SVC_CreditOperation.FinConditionsRate[] target = null;

            if (origin != null)
            {
                target = new SVC_CreditOperation.FinConditionsRate[origin.Length];

                for (int i = 0; i < origin.Length; i++)
                {
                    origin[i].ModifiedFields = null;
                    origin[i].ModifiedValues = null;
                    origin[i].TableData = null;
                    origin[i].FieldStates = null;
                    origin[i].Warnings = null;

                    /*get new object, which been mapped*/
                    SVC_CreditOperation.FinConditionsRate newMapped = origin[i].CreateMapped<SVC_Simulations.FinConditionsRate, SVC_CreditOperation.FinConditionsRate>();

                    target[i] = newMapped;
                    target[i].Status = origin[i].Status == SVC_Simulations.InstanceStatus.Insert ? SVC_CreditOperation.InstanceStatus.Insert : SVC_CreditOperation.InstanceStatus.Update;
                }
            }

            return target;
        }

        #endregion

        #region Methods to convert Entities and relateds (Address; LegalDocument; Company)

        public static SVC_CreditOperation.Entity Translate(SVC_Entities.Entity origin)
        {
            SVC_CreditOperation.Entity target = null;

            if (origin != null)
            {
                origin.ModifiedFields = null;
                origin.ModifiedValues = null;
                origin.TableData = null;
                origin.FieldStates = null;
                origin.Warnings = null;

                // save EntityAddress reference
                SVC_Entities.EntityAddress[] originAdresses = origin.Addresses;
                origin.Addresses = null;

                // save EntityLegalDoc reference
                SVC_Entities.EntityLegalDoc[] originLegalDocs = origin.LegalDocs;
                origin.LegalDocs = null;

                // save Company reference
                SVC_Entities.Company origincompany = origin.Company;
                origin.Company = null;

                /*get new object, which been mapped*/
                SVC_CreditOperation.Entity newMapped = origin.CreateMapped<SVC_Entities.Entity, SVC_CreditOperation.Entity>();

                target = newMapped;
                target.Status = origin.Status == SVC_Entities.InstanceStatus.Insert ? SVC_CreditOperation.InstanceStatus.Insert : SVC_CreditOperation.InstanceStatus.Update;

                target.Addresses = DomainTranslator.Translate(originAdresses);
                target.LegalDocs = DomainTranslator.Translate(originLegalDocs);
                target.Company = DomainTranslator.Translate(origincompany);

            }

            return target;
        }

        public static SVC_CreditOperation.EntityAddressValid[] Translate(SVC_Entities.EntityAddress[] origin)
        {
            SVC_CreditOperation.EntityAddressValid[] target = null;

            if (origin != null)
            {
                target = new SVC_CreditOperation.EntityAddressValid[origin.Length];

                for (int i = 0; i < origin.Length; i++)
                {
                    origin[i].ModifiedFields = null;
                    origin[i].ModifiedValues = null;
                    origin[i].TableData = null;
                    origin[i].FieldStates = null;
                    origin[i].Warnings = null;

                    /*get new object, which been mapped*/
                    SVC_CreditOperation.EntityAddressValid newMapped = origin[i].CreateMapped<SVC_Entities.EntityAddress, SVC_CreditOperation.EntityAddressValid>();

                    target[i] = newMapped;
                    target[i].Status = origin[i].Status == SVC_Entities.InstanceStatus.Insert ? SVC_CreditOperation.InstanceStatus.Insert : SVC_CreditOperation.InstanceStatus.Update;
                }
            }

            return target;
        }

        public static SVC_CreditOperation.EntityLegalDoc[] Translate(SVC_Entities.EntityLegalDoc[] origin)
        {
            SVC_CreditOperation.EntityLegalDoc[] target = null;

            if (origin != null)
            {
                target = new SVC_CreditOperation.EntityLegalDoc[origin.Length];

                for (int i = 0; i < origin.Length; i++)
                {
                    origin[i].ModifiedFields = null;
                    origin[i].ModifiedValues = null;
                    origin[i].TableData = null;
                    origin[i].FieldStates = null;
                    origin[i].Warnings = null;

                    /*get new object, which been mapped*/
                    SVC_CreditOperation.EntityLegalDoc newMapped = origin[i].CreateMapped<SVC_Entities.EntityLegalDoc, SVC_CreditOperation.EntityLegalDoc>();

                    target[i] = newMapped;
                    target[i].Status = origin[i].Status == SVC_Entities.InstanceStatus.Insert ? SVC_CreditOperation.InstanceStatus.Insert : SVC_CreditOperation.InstanceStatus.Update;
                }
            }

            return target;
        }

        public static SVC_CreditOperation.Company Translate(SVC_Entities.Company origin)
        {
            SVC_CreditOperation.Company target = null;

            if (origin != null)
            {
                origin.ModifiedFields = null;
                origin.ModifiedValues = null;
                origin.TableData = null;
                origin.FieldStates = null;
                origin.Warnings = null;

                /*get new object, which been mapped*/
                SVC_CreditOperation.Company newMapped = origin.CreateMapped<SVC_Entities.Company, SVC_CreditOperation.Company>();

                target = newMapped;
                target.Status = origin.Status == SVC_Entities.InstanceStatus.Insert ? SVC_CreditOperation.InstanceStatus.Insert : SVC_CreditOperation.InstanceStatus.Update;
            }

            return target;
        }

        #endregion
    }

    public static class MapperUtility
    {
        #region  Passing values to given object
        public static TTarget MapTo<TSource, TTarget>(this TSource aSource, TTarget aTarget)
        {
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;

            var srcFields = (from PropertyInfo aProp in typeof(TSource).GetProperties(flags)
                             where aProp.CanRead     //check if prop is readable
                             select new
                             {
                                 Name = aProp.Name,
                                 Type = Nullable.GetUnderlyingType(aProp.PropertyType) ??
                                                                        aProp.PropertyType
                             }).ToList();
            var trgFields = (from PropertyInfo aProp in aTarget.GetType().GetProperties(flags)
                             where aProp.CanWrite   //check if prop is writeable
                             select new
                             {
                                 Name = aProp.Name,
                                 Type = Nullable.GetUnderlyingType(aProp.PropertyType) ??
                                                                     aProp.PropertyType
                             }).ToList();


            var commonFields = srcFields.Intersect(trgFields).ToList();

            /*assign values*/
            foreach (var aField in commonFields)
            {
                var value = aSource.GetType().GetProperty(aField.Name).GetValue(aSource, null);
                PropertyInfo propertyInfos = aTarget.GetType().GetProperty(aField.Name);
                propertyInfos.SetValue(aTarget, value, null);
            }
            return aTarget;
        }
        #endregion

        #region Returns new object with mapping
        public static TTarget CreateMapped<TSource, TTarget>(this TSource aSource) where TTarget : new()
        {
            return aSource.MapTo(new TTarget());
        }
        #endregion
    }
}
