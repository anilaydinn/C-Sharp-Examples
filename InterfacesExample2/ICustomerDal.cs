using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample2
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }
    }

    class OracleCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }
    }

    class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added");
        }

        public void Update()
        {
            Console.WriteLine("Mysql updated");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted");
        }
    }
}
