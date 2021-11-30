using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class hourlypayemployee : employee
    {
        public int hoursworked
        {
            get
            {
                hoursworked = 4;
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int basepay
        {
            get
            {
                basepay = 400;
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int unitpay
        {
            get
            {
                unitpay = 30;
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int overtimepay
        {
            get
            {
                overtimepay = 250;
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int hourspay
        {
            get
            {
                hourspay = 20;
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Property
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int grosspay
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void calculate_salary()
        {
            Console.WriteLine(grosspay);

                

               
                
            throw new System.NotImplementedException();
        }
    }
}