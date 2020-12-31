/* GROUP MEMBERS
 * 
 * Thi Hoang Tram Tran (Wynne) - 101161665
 * 
 * Forough Kiani - 101282711
 * 
 * Matias Herter - 101272358
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentForm
{
    public class CustomerManager
    {

        private static int currentCustNumber;
        private int maxNumCustomers;
        private int numCustomers;
        private Customer1[] customerList;


        public CustomerManager(int ccn, int max)
        {
            currentCustNumber = ccn;
            maxNumCustomers = max;
            numCustomers = 0;
            customerList = new Customer1[maxNumCustomers];
        }

        public bool addCustomer(string fn, string ln, string ph)
        {
            if (numCustomers >= maxNumCustomers) { return false; }
            Customer1 c = new Customer1(currentCustNumber, fn, ln, ph);
            currentCustNumber++;
            customerList[numCustomers] = c;
            numCustomers++;

            return true;
        }

        public bool addCustomer(string fn, string ln, string ph, int booking)
        {
            if (numCustomers >= maxNumCustomers) { return false; }
            Customer1 c = new Customer1(currentCustNumber, fn, ln, ph, booking);
            currentCustNumber++;
            customerList[numCustomers] = c;
            numCustomers++;
            return true;
        }

        public int findCustomer(int cid)
        {
            for (int x = 0; x < numCustomers; x++)
            {
                if (customerList[x].getId() == cid)
                    return x;
            }
            return -1;
        }

        public bool customerExist(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return false; }
            return true;
        }

        public Customer1 getCustomer(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return null; }
            return customerList[loc];
        }

        public string getCustomerInfo(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return "There is no customer with id " + cid + "."; }
            return customerList[loc].ToString();
        }

        public string getCustomerInfo2(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return null; }
            return customerList[loc].ToString();
        }

        public bool deleteCustomer(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return false; }
            customerList[loc] = customerList[numCustomers - 1];
            numCustomers--;
            return true;
        }

        public string getCustomerList()
        {
            string s = "";
            for (int x = 0; x < numCustomers; x++)
            {
                s = s + customerList[x].getId() + "\n" + customerList[x].getFirstName() + "\n" + customerList[x].getLastName() + "\n" + customerList[x].getPhone();
                //s = s + "\n";
            }
            return s;
        }

        public string getCustomerList(int booking)
        {
            string s = "";
            for (int x = 0; x < numCustomers; x++)
            {
                s = s + customerList[x].getId() + "\n" + customerList[x].getFirstName() + "\n" + customerList[x].getLastName() + "\n" + customerList[x].getPhone()+"\n" + booking + "\n";
                //s = s + "\n";
            }
            return s;
        }

        public int getNumCustomer()
        {
            return numCustomers;
        }

        public Customer1 getAccountAtPosition(int loc)
        {
            if (loc < numCustomers)
            {
                return customerList[loc];
            }
            return null;
        }

        public int getBookingDetail(int cusId)
        {
            if(customerExist(cusId) == true)
            {
                return getCustomer(cusId).getNumBookings();
            }
            return 0;
        }

    }
}
