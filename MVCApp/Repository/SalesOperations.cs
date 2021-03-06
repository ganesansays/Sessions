﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;


namespace Session2
{
    public static class SalesOperations
    {
        public static void CreateSale(Sale saleObj)
        {
            Repository.SaleList.Add(saleObj);
        }
        public static Sale FetchSale(int Id)
        {
            return Repository.SaleList.Find(tempSaleObj => tempSaleObj.Id == Id);
        }
        public static void UpdateSale(Sale saleObj)
        {
            if (saleObj == null) return;

            Sale saleResultObj = Repository.SaleList.Find(tempSaleObj => tempSaleObj.Id == saleObj.Id);

            if (saleResultObj != null)
            {

                saleResultObj.Id = saleObj.Id;
                saleResultObj.SalesPersonId = saleObj.SalesPersonId;
                saleResultObj.CustomerId = saleObj.CustomerId;
                saleResultObj.ProductId = saleObj.ProductId;
                saleResultObj.Quantity = saleObj.Quantity;
                saleResultObj.Discount = saleObj.Discount;
            }
        }

        public static void DeleteSale(int Id)
        {
            Sale saleObj = Repository.SaleList.Find(tempSaleObj => tempSaleObj.Id == Id);

            if (saleObj != null)
            {
                Repository.SaleList.Remove(saleObj);
            }
        }
    }

}
