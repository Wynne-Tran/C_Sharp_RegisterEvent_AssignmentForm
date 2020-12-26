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
    public class RSVP
    {
        private string registerDate;
        private int registerId;
        private int customerId;
        private string customerFname;
        private string customerLname;
        private int eventId;


        public RSVP(int regId, int cusId, string fname, string lname, int eveId)
        {
            registerDate = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            registerId = regId;
            customerId = cusId;
            customerFname = fname;
            customerLname = lname;
            eventId = eveId;

        }

        public int getregId() { return registerId; }
        public int getcusId() { return customerId; }
        public int geteveId() { return eventId; }




        public override string ToString()
        {
            string s = "-----------Register Infomation----------" + "\n";
            s = s + "\nRegister Day: " + registerDate;
            s = s + "\nRegister Number: " + registerId;
            s = s + "\nRegister Name: " + customerFname + " " + customerLname;
            s = s + "\nEven ID: " + eventId;
            return s;
        }
    }
}
