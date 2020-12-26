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

        public static void writeToFile(CustomerManager am)
        {
            StreamWriter sw = new StreamWriter(@"CustomerList.txt");
            
                sw.WriteLineAsync(am.getCustomerList() + "\n");
                sw.Flush(); // buffer make sure no error
                sw.Close();
            
            
        }
        
        public static CustomerManager loadFromFile()
        {
            CustomerManager am = new CustomerManager(1, 100);
            string id;
            string f, l, p;
            string line;
            StreamReader sr = new StreamReader(@"CustomerList.txt");
            while ((line = sr.ReadLine()) != null)
            {
                id = sr.ReadLine();
                f = sr.ReadLine();
                l = sr.ReadLine();
                p = sr.ReadLine();
                am.addCustomer(f, l, p);
            }
            
            sr.Close();
            return am;
        }



        public static void writeToTXTFile(EventManager em)
        {
            StreamWriter sw = new StreamWriter(@"EventList.txt");

            sw.WriteLineAsync(em.getEventList() + "\n");
            sw.Flush(); // buffer make sure no error
            sw.Close();


        }
        public static EventManager loadFromTXTFile()
        {
            EventManager em = new EventManager(1, 100);
            string id, name, venue;
            int day = 0, month = 0, year = 0, hour = 0, minus = 0, max = 0, num;
            string line;
            StreamReader sr = new StreamReader(@"EventList.txt");
            while ((line = sr.ReadLine()) != null)
            {
                id = sr.ReadLine();
                name = sr.ReadLine();
                venue = sr.ReadLine();

                if (int.TryParse(sr.ReadLine(), out num)){ day = num; }
                if (int.TryParse(sr.ReadLine(), out num)) { month = num; }
                if (int.TryParse(sr.ReadLine(), out num)) { year = num; }
                if (int.TryParse(sr.ReadLine(), out num)) { hour = num; }
                if (int.TryParse(sr.ReadLine(), out num)) { minus = num; }
                if (int.TryParse(sr.ReadLine(), out num)) { max = num; }

                Date edate = new Date(day, month, year, hour, minus);
                em.addEvent(name, venue, edate, max);
                    
                    
             }

            sr.Close();
            return em;
        }


        public static void writeRSVPFile(RSVPManager rm)
        {
            StreamWriter sw = new StreamWriter(@"RSVPList.txt");
            sw.WriteAsync(rm.getRegisterList()+ "\n");
            sw.Flush(); // buffer make sure no error
            sw.Close();

        }
        public static RSVPManager loadRSVPFile()
        {
            RSVPManager rm = new RSVPManager( 1, 100);
            
            string line, id, fname, lname;
            int cusId = 0, eId = 0, num;
            StreamReader sr = new StreamReader(@"RSVPList.txt");
            while ((line = sr.ReadLine()) != null)
            {
                id = sr.ReadLine();
                if (int.TryParse(sr.ReadLine(), out num)) { cusId = num; }
                fname = sr.ReadLine();
                lname = sr.ReadLine();
                if (int.TryParse(sr.ReadLine(), out num)) { eId = num; }
                rm.addRegister(cusId, fname, lname, eId);

            }
            sr.Close();
            return rm;
        }



        public static void writeCoordFile(EventCoordinator ec)
        {
            StreamWriter sw = new StreamWriter(@"CoordList.txt");
            sw.WriteAsync(ec.registerList() + "\n");
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
