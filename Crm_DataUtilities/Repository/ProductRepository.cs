﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Crm_Entities;
//using Crm_DataUtilities;
//using Crm_Global;


//namespace Crm_DataUtilities.Repository
//{

    
//    public class ProductRepository
//    {
//        private MyDataEntities dbEntity;

//        public ProductRepository (MyDataEntities dbEntity=null)
//        {
//            this.dbEntity = dbEntity ?? new MyDataEntities();
//        }



//        public IQueryable<tProdoct> GetAllProducts()
//        {
//            return this.dbEntity.tProdoct;
//        }

//        public tProdoct GetProductFromId (int Id)
//        {
//            return this.dbEntity.tProdoct.FirstOrDefault(x=> x.IdProdotto==Id);
//        }

//        public void SaveProduct (tProdoct prodoct,EnumUseful.typeOfDatabaseOperation typeOfDatabaseOperation)
//        {
//            switch (typeOfDatabaseOperation)
//            {
//                case EnumUseful.typeOfDatabaseOperation.EDIT:
//                    tProdoct prodoct_ = dbEntity.tProdoct.FirstOrDefault(x=> x.IdProdotto== prodoct.IdProdotto);
//                    if (prodoct_!= null)
//                    {
//                        prodoct_.IdProdotto = prodoct.IdProdotto;
//                        prodoct_.NomeProdotto = prodoct.NomeProdotto;
//                        prodoct_.Descrizione = prodoct.Descrizione;
//                        prodoct_.PrezzoPerUnita = prodoct.PrezzoPerUnita;
//                        prodoct_.IdDitta = prodoct.IdDitta;                        

//                    }

//                    break;
//                case EnumUseful.typeOfDatabaseOperation.CREATE:
//                    if (prodoct!=null)
//                    {
//                        dbEntity.tProdoct.Add(prodoct);
//                    }
//                    break;
//                case EnumUseful.typeOfDatabaseOperation.SAVE:
//                    break;
//                default:
//                    break;
//            }

//            dbEntity.SaveChanges();
//        }

//        public void RemovePreventiveWithId(int id)
//        {
//            tProdoct prodoct =
//                dbEntity.
//                tProdoct.
//                FirstOrDefault(x=> x.IdProdotto==id);

//            if (prodoct!= null)
//            {
//                dbEntity.tProdoct.Remove(prodoct);
//                dbEntity.SaveChangesAsync();
//            }
//        }

//        public void Dispose()
//        { }

//    }
//}
