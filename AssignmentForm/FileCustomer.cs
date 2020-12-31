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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentForm
{
    class FileCustomer
    {
        public static void writeToFileDetail(CustomerManager am, int booking)
        {
            int numCustomer = am.getNumCustomer();
            Customer1 temp;
            StreamWriter sw = new StreamWriter(@"CustomerListDetail.txt");
            sw.WriteLine(numCustomer);
            for (int x = 0; x < numCustomer; x++)
            {
                temp = am.getAccountAtPosition(x);
            }
            sw.WriteLine(am.getCustomerList(booking));
            
            sw.Flush();
            sw.Close();
            

        }

        public static CustomerManager loadFromFileDetail()
        {
            CustomerManager am = new CustomerManager(1, 100);
            int numCustomer;
            string id;
            string fname, lname, ph, booking;

            StreamReader sr = new StreamReader(@"CustomerListDetail.txt");
            numCustomer = Convert.ToInt32(sr.ReadLine());
            //sr.ReadLine();
            for (int x = 0; x < numCustomer; x++)
            {
                id = sr.ReadLine();
                fname = sr.ReadLine();
                lname = sr.ReadLine();
                ph = sr.ReadLine();
                booking = sr.ReadLine();
                am.addCustomer(fname, lname, ph, Convert.ToInt32(booking));
            }
            sr.Close();
            return am;
        }


        public static void writeToFile(CustomerManager am)
        {
            int numCustomer = am.getNumCustomer();
            Customer1 temp;
            StreamWriter sw = new StreamWriter(@"CustomerList.txt");
            sw.WriteLine(numCustomer);  
            for(int x = 0; x < numCustomer; x++)
            {
                temp = am.getAccountAtPosition(x);
            }
            sw.WriteLineAsync(am.getCustomerList());
            sw.Flush(); // buffer make sure no error
            sw.Close();
            
        }

        public static CustomerManager loadFromFile()
        {
            CustomerManager am = new CustomerManager(1, 100);
            int numCustomer;
            string id;
            string fname, lname, ph;
            
            StreamReader sr = new StreamReader(@"CustomerList.txt");
            numCustomer = Convert.ToInt32(sr.ReadLine());
            for(int x = 0; x < numCustomer; x++) 
            {
                id = sr.ReadLine();
                fname = sr.ReadLine();
                lname = sr.ReadLine();
                ph = sr.ReadLine();
                am.addCustomer(fname, lname, ph);
                
            }
            sr.Close();
            return am;
        }


        public static void writeToTXTFile(EventManager am)
        {
            int numEvent = am.getNumEvents();
            Event1 temp;
            StreamWriter sw = new StreamWriter(@"EventList.txt");
            sw.WriteLine(numEvent);
            for (int x = 0; x < numEvent; x++)
            {
                temp = am.getEventAtPosition(x);
            }
            sw.WriteLineAsync(am.getEventListinForm());
            sw.Flush();
            sw.Close();


        }
        public static EventManager loadFromTXTFile()
        {

            EventManager em = new EventManager(1, 100);
            int numEvent;
            string id, name, venue;
            int day, month, year, hour, minus, maxAttendee;
            StreamReader sr = new StreamReader(@"EventList.txt");
            numEvent = Convert.ToInt32(sr.ReadLine());
            sr.ReadLine();
            for (int x = 0; x < numEvent; x++)
            {
                id = sr.ReadLine();
                name = sr.ReadLine();
                venue = sr.ReadLine();
                day = Int32.Parse(sr.ReadLine());
                month = Int32.Parse(sr.ReadLine());
                year = Int32.Parse(sr.ReadLine());
                hour = Int32.Parse(sr.ReadLine());
                minus = Int32.Parse(sr.ReadLine()); 
                maxAttendee = Int32.Parse(sr.ReadLine());
                Date edate = new Date(day, month, year, hour, minus);
                em.addEvent(name, venue, edate, maxAttendee);
            }

            sr.Close();
            return em;
        }



        public static void writeToTXTFileDetail(EventManager am, int attendee, Customer1 c)
        {
            int numEvent = am.getNumEvents();
            string customer = c.getFirstName() + " " + c.getLastName();
            Event1 temp;
            StreamWriter sw = new StreamWriter(@"EventListDetail.txt");
            sw.WriteLine(numEvent);
            //sw = File.AppendText(@"EventListDetail.txt");
            for (int x = 0; x < numEvent; x++)
            {
                temp = am.getEventAtPosition(x);
            }
            sw.WriteLineAsync(am.getEventListinForm(attendee, customer));
            sw.Flush(); 
            sw.Close();


        }
        public static EventManager loadFromTXTFileDetail()
        {
            EventManager em = new EventManager(1, 100);
            int numEvent;
            string id, name, venue, customer;
            int day, month, year, hour, minus, attendee, maxAttendee;
            StreamReader sr = new StreamReader(@"EventListDetail.txt");
            numEvent = Convert.ToInt32(sr.ReadLine());
            sr.ReadLine();
            for (int x = 0; x < numEvent; x++)
            {
                id = sr.ReadLine();
                name = sr.ReadLine();
                venue = sr.ReadLine();
                day = Convert.ToInt32(sr.ReadLine());
                month = Convert.ToInt32(sr.ReadLine());
                year = Convert.ToInt32(sr.ReadLine());
                hour = Convert.ToInt32(sr.ReadLine());
                minus = Convert.ToInt32(sr.ReadLine());
                attendee = Convert.ToInt32(sr.ReadLine());
                maxAttendee = Convert.ToInt32(sr.ReadLine());
                customer = sr.ReadLine();
                Date edate = new Date(day, month, year, hour, minus);
                em.addEvent(name, venue, edate, maxAttendee, attendee, customer);
             }

            sr.Close();
            return em;
        }




        public static void writeRSVPFile(RSVPManager am)
        {
            int numEvent = am.getnumRegister();
            RSVP temp;
            StreamWriter sw = new StreamWriter(@"RSVPList.txt");
            sw.WriteLine(numEvent);
            for (int x = 0; x < numEvent; x++)
            {
                temp = am.getRSVPAtPosition(x);
            }
            sw.WriteLineAsync(am.getRegisterListinForm());
            sw.Flush(); 
            sw.Close();

        }
        public static RSVPManager loadRSVPFile()
        {
            RSVPManager rm = new RSVPManager( 1, 100);
            int numRSVP;
            string id, fname, lname;
            int cusId, eId;
            StreamReader sr = new StreamReader(@"RSVPList.txt");
            numRSVP = Convert.ToInt32(sr.ReadLine());
            sr.ReadLine();
            for (int x = 0; x < numRSVP; x++)
            {
                id = sr.ReadLine();
                cusId = Convert.ToInt32(sr.ReadLine());
                eId = Convert.ToInt32(sr.ReadLine());
                fname = sr.ReadLine();
                lname = sr.ReadLine();
                rm.addRegister(cusId, fname, lname, eId);
            }
            sr.Close();
            return rm;
        }

        

        public static void writeCoordFile(EventCoordinator ec)
        {
            StreamWriter sw = new StreamWriter(@"CoordList.txt");
            sw.WriteAsync(ec.registerListinForm() + "\n");
            sw.Flush(); // buffer make sure no error
            sw.Close();

        }


        public static EventCoordinator loadCoordFile() 
        {

            EventCoordinator ec = new EventCoordinator(1, 100, 1, 100, 1, 100);
            string line;

            StreamReader sr = new StreamReader(@"CoordList.txt");
            string id;
            int cusId = 0, eId = 0, num;
            while ((line = sr.ReadLine()) != null)
            {
                id = sr.ReadLine();
                if (int.TryParse(sr.ReadLine(), out num)) { cusId = num; }
                if (int.TryParse(sr.ReadLine(), out num)) { eId = num; }
                ec.addRegister(cusId, eId);
            }
            sr.Close();
            return ec;
            
        }
        
    }
}
