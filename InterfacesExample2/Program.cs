using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[3] { new SqlServerCustomerDal(), new OracleCustomerDal(), new MysqlCustomerDal() };

            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }
    }
}
