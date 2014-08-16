﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using Session2.View;

namespace Session2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int choice = Home.Display();

                //Customer, Create

                switch (choice)
                {
                    case 1:
                        HandleCustomerInformation();
                        break;
                    case 2:
                        HandleProductInformation();
                        break;
                    case 3:
                        HandleSalesPerson();
                        break;
                    case 4:
                        HandleSalesInformation();
                        break;
                    case 5:
                        break;
                    case 6:
                        HandleBills();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Please enter a valid choice ...");
                        continue;
                }
            }
        }

        private static void HandleSalesInformation()
        {
            string v_userMenuChoice;
            int v_userChoice = 0;

            int i_SalesID;
            int i_SalesPersonID;
            int i_CustomerID;
            int i_SalesProductID;
            int i_SalesQuantity;
            decimal i_SalesDiscount;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose the operation you would like to perform:");
                Console.WriteLine("[1]: Create Sales");
                Console.WriteLine("[2]: Retrieve Sales ");
                Console.WriteLine("[3]: Update Sales");
                Console.WriteLine("[4]: Delete Sales");
                Console.WriteLine("[5]: Go to Main Menu");

                v_userMenuChoice = Console.ReadLine();

                if (!Int32.TryParse(v_userMenuChoice, out v_userChoice))
                {
                    Console.WriteLine("Please choose a valid option...");
                }

                switch (v_userChoice)
                {
                    case 1:
                        Console.Clear();

                        Console.Write("Enter Sales ID:");
                        i_SalesID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sales Person ID:");
                        i_SalesPersonID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sales Customer ID:");
                        i_CustomerID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sales Product ID:");
                        i_SalesProductID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sales Quantity:");
                        i_SalesQuantity = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sales Discount:");
                        i_SalesDiscount = Convert.ToDecimal(Console.ReadLine());

                        Sale o_sales = new Sale(i_SalesID, i_SalesPersonID, i_CustomerID, i_SalesProductID, i_SalesQuantity, i_SalesDiscount);
                        SalesOperations.CreateSale(o_sales);
                        Console.WriteLine("Successful! Sales Added.Press any key to continue...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();

                        Console.Write("Enter Sales ID:");
                        i_SalesID = Convert.ToInt32(Console.ReadLine());
                        o_sales = SalesOperations.FetchSale(i_SalesID);

                        if (o_sales != null)
                        {
                            Console.WriteLine("Sales ID : {0}", o_sales.Id);
                            Console.WriteLine("Sales Person ID : {0}", o_sales.SalesPersonId);
                            Console.WriteLine("Sales Customer ID : {0}", o_sales.CustomerId);
                            Console.WriteLine("Sales Product ID : {0}", o_sales.ProductId);
                            Console.WriteLine("Sales Quantity : {0}", o_sales.Quantity);
                            Console.WriteLine("Sales Discount : {0}", o_sales.Discount);
                        }
                        else
                        {
                            Console.WriteLine("The mentioned sales id {0} does not exist", i_SalesID);
                        }

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;


                    case 3:
                        Console.Clear();

                        Console.Write("Enter Sales ID:");
                        i_SalesID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sales Person ID:");
                        i_SalesPersonID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sales Customer ID:");
                        i_CustomerID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sales Product ID:");
                        i_SalesProductID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sales Quantity:");
                        i_SalesQuantity = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sales Discount:");
                        i_SalesDiscount = Convert.ToDecimal(Console.ReadLine());

                        o_sales = new Sale(i_SalesID, i_SalesPersonID, i_CustomerID, i_SalesProductID, i_SalesQuantity, i_SalesDiscount);
                        SalesOperations.UpdateSale(o_sales);
                        Console.WriteLine("Successful! Sales Updated.Press any key to continue...");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();

                        Console.Write("Enter Sales ID:");
                        i_SalesID = Convert.ToInt32(Console.ReadLine());

                        SalesOperations.DeleteSale(i_SalesID);
                        Console.WriteLine("Successful! Sales Deleted.Press any key to continue...");
                        Console.ReadLine();
                        break;

                    case 5:
                        return;
                }
            }


        }

        private static void HandleCustomerInformation() //CustomerController -> Create
        {
            while (true)
            {
                int choice = CustomerView.Display();

                switch (choice) 
                {
                    case 1: //Create
                        //Start
                        Customer cust = CustomerView.Create(); //Display View
                        CustomerOperation.CreateCustomer(cust); //Business Operation
                        Console.WriteLine("Sucessfully created ... press anykey to continue ...");
                        Console.ReadLine();
                        break;
                        //End
                    case 2: //Fetch
                        int idtoFetch = CustomerView.GetCustomerId();                        
                        Customer custToDisplay = CustomerOperation.FetchCustomer(idtoFetch); //Business Operation
                        CustomerView.Display(custToDisplay); //Display View
                        break;
                    case 3: //Update
                       Customer custToUpdate = CustomerView.Update();
                        if (custToUpdate != null)
                        {
                            CustomerOperation.UpdateCustomer(custToUpdate);
                            Console.WriteLine("Sucessfully updated ... press anykey to continue ...");
                        }
                        else
                        {
                            Console.WriteLine("Customer doesnt exist");
                        }

                        Console.ReadLine();
                        break;
                    case 4: //Delete
                        int idToDelete = CustomerView.GetCustomerId();                        
                        CustomerOperation.DeleteCustomer(idToDelete);
                        Console.WriteLine("Sucessfully deleted ... press anykey to continue ...");
                        Console.ReadLine();
                        break;
                    case 5:
                        return;
                }
            }
        }

        private static void HandleProductInformation()
        {
            while (true)
            {
                int choice = CustomerView.Display();

                switch (choice)
                {
                    case 1:
                        Product ProdtoAdd = ProductView.Create();
                        ProductOperation.CreateProduct(ProdtoAdd);
                        Console.WriteLine("Sucessfully created ... press anykey to continue ...");
                        Console.ReadLine();
                        break;
                    case 2:
                        int idtoFetch = ProductView.GetProductId();
                        Product ProdtoFetch = ProductOperation.FetchProduct(idtoFetch);
                        ProductView.DisplayProduct(ProdtoFetch);
                        break;
                    case 3:

                        Product ProdtoUpdate = ProductView.UpdateProduct();
                        if (ProdtoUpdate != null)
                        {
                            ProductOperation.UpdateProduct(ProdtoUpdate);
                            Console.WriteLine("Sucessfully updated ... press anykey to continue ...");
                        }
                        else
                        {
                            Console.WriteLine("Product doesnt exist");
                        }

                        Console.ReadLine();
                        break;
                    case 4:
                        int prodidtodelete = ProductView.GetProductId();
                        ProductOperation.DeleteProduct(prodidtodelete);
                        Console.WriteLine("Sucessfully deleted ... press anykey to continue ...");
                        Console.ReadLine();
                        break;
                    case 5:
                        return;
                }
            }
        }

        private static void HandleSalesPerson()
        {
            //HandleSaleperson

            while (true)
            {
                Console.Clear();
                Console.WriteLine("SALES PERSON");
                Console.WriteLine("What operation you want to perform?");
                Console.WriteLine("[1]: Create");
                Console.WriteLine("[2]: Fetch");
                Console.WriteLine("[3]: Update");
                Console.WriteLine("[4]: Delete");
                Console.WriteLine("[5]: Go to main menu");

                string choiceString = Console.ReadLine();
                int choice = 0;
                if (!Int32.TryParse(choiceString, out choice))
                {
                    Console.WriteLine("Please enter a valid choice ...");
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter SalesPerson Id: ");
                        string spIdInput = Console.ReadLine();
                        Console.Write("Enter SalesPerson Name: ");
                        string spNameInput = Console.ReadLine();
                        Console.Write("Enter SalesPerson Number: ");
                        string spContactNumberInput = Console.ReadLine();

                        int id = 0;
                        Int32.TryParse(spIdInput, out id);

                        SalesPerson salePersonObject = new SalesPerson(id, spNameInput, spContactNumberInput);
                        SalesPersonOperation.CreateSalesPerson(salePersonObject);
                        Console.WriteLine("Sucessfully created SP  ... press anykey to continue ...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Enter SalesPerson Id: ");
                        spIdInput = Console.ReadLine();
                        id = 0;
                        Int32.TryParse(spIdInput, out id);

                        salePersonObject = SalesPersonOperation.FetchSalesPerson(id);


                        if (salePersonObject != null)
                        {
                            Console.WriteLine("SP Name:" + salePersonObject.Name);
                        }
                        else
                        {
                            Console.WriteLine("SP doesnt exist");
                        }

                        Console.WriteLine("press anykey to continue ...");
                        Console.ReadLine();
                        break;

                    case 3:
                        //update
                        Console.Clear();
                        Console.Write("Enter SalePerson Id: ");
                        spIdInput = Console.ReadLine();
                        Console.Write("Enter SalePerson Name: ");
                        spNameInput = Console.ReadLine();
                        Console.Write("Enter Contact Number: ");
                        spContactNumberInput = Console.ReadLine();

                        id = 0;
                        Int32.TryParse(spIdInput, out id);

                        salePersonObject = new SalesPerson(id, spNameInput, spContactNumberInput);

                        if (salePersonObject != null)
                        {
                            SalesPersonOperation.UpdateSalesPerson(salePersonObject);
                            Console.WriteLine("Sucessfully updated SP... press anykey to continue ...");
                        }
                        else
                        {
                            Console.WriteLine("SP doesnt exist");
                        }

                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Enter Customer Id: ");
                        spIdInput = Console.ReadLine();
                        id = 0;
                        Int32.TryParse(spIdInput, out id);
                        SalesPersonOperation.DeleteSalesPerson(id);
                        Console.WriteLine("Sucessfully deleted SP ... press anykey to continue ...");
                        Console.ReadLine();
                        break;
                    case 5:
                        return;
                }
            }
        }

        private static void HandleBills()
        {

            while (true)
            {

                int choice = CustomerView.Display();

                switch (choice)
                {

                    case 1:

                        Bill BilltoCreate = BillView.CreateBill();

                        BillOperations.CreateBill(BilltoCreate);

                        Console.WriteLine("Sucessfully created ... press anykey to continue ...");

                        Console.ReadLine();

                        break;

                    case 2:

                        int idtoFetch = BillView.GetBillId();

                        Bill BilltoFetch = BillOperations.FetchBill(idtoFetch);

                        BillView.DisplayBill(BilltoFetch);

                        break;

                    case 3:

                        Bill BilltoUpdate = BillView.UpdateBill();

                        if (BilltoUpdate!= null)
                        {

                            BillOperations.UpdateBill(BilltoUpdate);

                            Console.WriteLine("Sucessfully updated ... press anykey to continue ...");

                        }

                        else
                        {

                            Console.WriteLine("Bill Id doesnt exist");

                        }

                        Console.ReadLine();

                        break;

                    case 4:

                        int billidtodelete = BillView.GetBillId();

                        BillOperations.DeleteBill(billidtodelete);

                        Console.WriteLine("Sucessfully deleted ... press anykey to continue ...");

                        Console.ReadLine();

                        break;

                    case 5:

                        return;

                }

            }

        }

    }
}
        