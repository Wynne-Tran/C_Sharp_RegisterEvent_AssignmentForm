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
    public partial class Customer1
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int bookings;

        public Customer1(int cId, string fname, string lname, string ph)
        {
            bookings = 0;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;

        }

        public Customer1(int cId, string fname, string lname, string ph, int booking)
        {
            bookings = booking;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;

        }

        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getPhone() { return phone; }
        public int getNumBookings() { return bookings; }
        public int updateBookings()
        {
            return bookings = bookings + 1;
        }


        public override string ToString()
        {
            
            string s = "Customer: " + customerId;
            s = s + "\nName: " + firstName + " " + lastName;
            s = s + "\nPhone: " + phone;
            s = s + "\nBookings: " + bookings;
            
            return s;
        }
        
    }
}
