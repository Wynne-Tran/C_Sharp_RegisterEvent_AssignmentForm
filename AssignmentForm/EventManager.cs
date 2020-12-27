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
   public class EventManager
    {
        private static int currentEventId;
        private int maxEvents;
        private int numEvents;
        private Event1[] eventList;

        public EventManager(int idSeed, int max)
        {
            currentEventId = idSeed;
            maxEvents = max;
            numEvents = 0;
            eventList = new Event1[maxEvents];

        }

        public bool addEvent(string name, string venue, Date eventDate, int maxAttendees)
        {
            if (numEvents >= maxEvents) { return false; }
            Event1 e = new Event1(currentEventId, name, venue, eventDate, maxAttendees);
            eventList[numEvents] = e;
            numEvents++;
            currentEventId++;
            return true;
        }

        private int findEvent(int eid)
        {
            for (int x = 0; x < numEvents; x++)
            {
                if (eventList[x].getEventId() == eid)
                    return x;
            }
            return -1;
        }

        // Question 1: no duplicate Venue
        public bool findVenue(string venue)
        {
            for (int x = 0; x < numEvents; x++)
            {
                if (eventList[x].getVenue() == venue)
                    return true;
            }
            return false;
        }

        public bool eventExists(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            return true;
        }

        public Event1 getEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return null; }
            return eventList[loc];
        }

        public bool deleteEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            eventList[loc] = eventList[numEvents - 1];
            numEvents--;
            return true;
        }
        public string getEventInfo(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return "There is no event with id " + eid + "."; }
            return eventList[loc].ToString();
        }
        public string getEventList()
        {
            string s = "";
            for (int x = 0; x < numEvents; x++)
            {
                s = eventList[x].getEventId() + "\n" + eventList[x].getEventName() + "\n" + eventList[x].getVenue()
                    ;
            }
            return s;
        }

        public string getEventListinForm()
        {
            string s = "";
            for (int x = 0; x < numEvents; x++)
            {
                s = eventList[x].getEventId() 
                    + "\n" + eventList[x].getEventName() 
                    + "\n" + eventList[x].getVenue()
                    + "\n" + eventList[x].getDay() 
                    + "\n" + eventList[x].getMonth() 
                    + "\n" + eventList[x].getYear() 
                    + "\n" + eventList[x].getHour() 
                    + "\n" + eventList[x].getMin() 
                    + "\n" + eventList[x].getMaxAttendees();
            }
            return s;
        }

        public int getNumEvents()
        {
            return numEvents;
        }


        public Event1 getEventAtPosition(int loc)
        {
            if (loc < numEvents)
            {
                return eventList[loc];
            }
            return null;
        }

    }
}
