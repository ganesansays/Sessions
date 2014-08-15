using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2.View
{
    public class Intent
    {
        public int EntityToActOn { get; set; }
        public int OperationToPerform { get; set; }
        public object Param { get; set; }
        public int IdToActOn { get; set; }

        public static int CUSTOMER_ENTITY = 1;
        public static int PRODUCT_ENTITY = 2;
        public static int SALES_PERSON_ENTITY = 3;
        public static int SALE_ENTITY = 4;
        public static int INVOICE_ENTITY = 5;
        public static int BILL_ENTITY = 6;
        public static int EXIT = 7;

        public static int CREATE = 1;
        public static int FETCH_AND_UPDATE = 2;
        public static int INVALID_ACTION = 3;
        public static int DELETE = 4;
        public static int GO_TO_MAIN = 5;
        public static int SAVE = 6;
    }
}
