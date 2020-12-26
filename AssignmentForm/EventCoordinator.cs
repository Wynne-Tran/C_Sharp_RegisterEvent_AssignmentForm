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
    public class EventCoordinator
    {
        CustomerManager custMan;
        EventManager eventMan;
        RSVPManager registerMan;

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int maxEvents, int idRegSeed, int maxRegister)
        {
            custMan = new CustomerManager(custIdSeed, maxCust);
            eventMan = new EventManager(eventIdSeed, maxEvents);
            registerMan = new RSVPManager(idRegSeed, maxRegister);
        }

        //customer related methods
        public bool addCustomer(string fname, string lname, string phone)
        {
            return custMan.addCustomer(fname, lname, phone);
        }

        public string customerList()
        {
            return custMan.getCustomerList();
        }

        public string getCustomerInfoById(int id)
        {
            return custMan.getCustomerInfo(id);
        }
        public bool deleteCustomer(int id)
        {
            return custMan.deleteCustomer(id);
        }

        // Event related methods
        public bool addEvent(string name, string venue, Date eventDate, int maxAttendee)
        {
            //check: duplicate venue
            while (eventMan.findVenue(venue) == true)
            {
                Console.Write("Venue is available, please enter another venue:");
                venue = Console.ReadLine();
            }
            return eventMan.addEvent(name, venue, eventDate, maxAttendee);
        }

        public string eventList()
        {
            return eventMan.getEventList();
        }

        public string getEventInfoById(int eid)
        {

            return eventMan.getEventInfo(eid);
        }

        // Register related methods
        public bool addRegister(int customerId, int eventId)
        {
            //check: is there free space in the event ?
            Event1 e = eventMan.getEvent(eventId);
            //if (e.getNumAttendees() >= e.getMaxAttendees()) { return false; }
            // check: the event id exists
            if (eventMan.eventExists(eventId) == false) { return false; }
            //check: the customer id exists
            if (custMan.customerExist(customerId) == false) { return false; }

            Customer1 c = custMan.getCustomer(customerId);
            string fname = c.getFirstName();
            string lname = c.getLastName();
            return registerMan.addRegister(customerId, fname, lname, eventId);
        }

        public bool deleteRegCustomer(int cusId)
        {
            return registerMan.deleteRegCustomer(cusId);
        }

        public string registerList()
        {
            return registerMan.getRegisterList();
        }

        public string getRegisterInfoById(int id)
        {
            return registerMan.getRegisterInfo(id);
        }


        // add code for addAttendee 

        public bool addAttendee(int customerId, int eventId)
        {
            Customer1 a = custMan.getCustomer(customerId);
            Event1 e = eventMan.getEvent(eventId);
            if (e != null)
            {
                e.addAttendee(a);
                a.updateBookings();
                return true;
            }
            return false;

        }
    }
}
