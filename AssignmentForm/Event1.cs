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
    public partial class Event1
    {
        private int eventId;
        private string eventName;
        private string venue;
        private Date eventDate;


        private int maxAttendees;
        private int numAttendees;
        private string dateCreated;
        private Customer1[] attendeeList;
        private string customer;
        public Event1(int eventId, string name, string venue, Date eventDate, int maxAttendees)
        {
            this.eventId = eventId;
            eventName = name;
            this.venue = venue;
            this.eventDate = eventDate;
            this.maxAttendees = maxAttendees;
            numAttendees = 0;
            attendeeList = new Customer1[maxAttendees];
            dateCreated = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }

        public Event1(int eventId, string name, string venue, Date eventDate, int maxAttendees, int attendee, string customer)
        {
            this.eventId = eventId;
            eventName = name;
            this.venue = venue;
            this.eventDate = eventDate;
            this.maxAttendees = maxAttendees;
            this.customer = customer;
            numAttendees = attendee;
            attendeeList = new Customer1[maxAttendees];
            dateCreated = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }

        public int getEventId() { return eventId; }
        public string getEventName() { return eventName; }
        public string getVenue() { return venue; }
        
        public int getMaxAttendees() { return maxAttendees; }
        public int getNumAttendees() { return numAttendees; }

        public Date getEventDate() { return eventDate; }
        public int getDay() { return eventDate.getDay(); }
        public int getMonth() { return eventDate.getMonth(); }
        public int getYear() { return eventDate.getYear(); }
        public int getHour() { return eventDate.getHour(); }
        public int getMin() { return eventDate.getMin(); }
        public int updateAttendee() { return getNumAttendees() + 1; }
        public bool addAttendee(Customer1 c)
        {
            if (numAttendees >= maxAttendees) { return false; }
            attendeeList[numAttendees] = c;
            numAttendees++;
            return true;
        }

        private int findAttendee(int custId)
        {
            for (int x = 0; x < maxAttendees; x++)
            {
                if (attendeeList[x].getId() == custId)
                    return x;
            }
            return -1;
        }

        public bool removeAttendee(int custId)
        {
            int loc = findAttendee(custId);
            if (loc == -1) return false;
            attendeeList[loc] = attendeeList[numAttendees - 1];
            numAttendees--;
            return true;
        }

        public string getAttendees()
        {
            string s = "";
            for (int x = 0; x < numAttendees; x++)
            {
                s = s + "\n" + attendeeList[x].getFirstName() + " " + attendeeList[x].getLastName();
            }
            return s;
        }

        public override string ToString()
        {
            string s = "Event: " + eventId ;
            s=s+ " Name: " + eventName;
            s = s + " Venue: " + venue;
            s = s + " Date:" + eventDate;
            s = s + " Registered Attendees:" + numAttendees;
            s = s + " Available spaces:" + (maxAttendees - numAttendees);
            s = s + " Attendee Lists:" + customer;
            return s;
        }

       
    }
}
