
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
    public class RSVPManager
    {
        private static int currentRegisterId;
        private int maxRegister;
        private int numRegister;
        private RSVP[] registerList;



        public RSVPManager(int idRegSeed, int max)
        {
            currentRegisterId = idRegSeed;
            maxRegister = max;
            numRegister = 0;
            registerList = new RSVP[maxRegister];
        }

        public bool addRegister(int cusId, string fname, string lname, int eveId)
        {
            if (numRegister >= maxRegister) { return false; }
            RSVP register = new RSVP(currentRegisterId, cusId, fname, lname, eveId);
            registerList[numRegister] = register;
            numRegister++;
            currentRegisterId++;
            return true;
        }
        
        public RSVP getRegisterByCusId(int cid)
        {
            int loc = findCusId(cid);
            if (loc == -1) { return null; }
            return registerList[loc];
        }
        
        public int findRSVP(int regId)
        {
            for (int x = 0; x < numRegister; x++)
            {
                if (registerList[x].getregId() == regId)
                    return x;
            }
            return -1;
        }

        public int findCusId(int cusId)
        {
            for (int x = 0; x < numRegister; x++)
            {
                if (registerList[x].getcusId() == cusId)
                    return x;
            }
            return -1;
        }

        public int findEventId(int eveId)
        {
            for (int x = 0; x < numRegister; x++)
            {
                if (registerList[x].geteveId() == eveId)
                    return x;
            }
            return -1;
        }

        public bool deleteRegCustomer(int cusId)
        {
            int loc = 0;
            while (loc < registerList.Length)
            {
                loc = findCusId(cusId);
                if (loc == -1) { return false; }
                registerList[loc] = registerList[numRegister - 1];
                numRegister--;
                loc++;
            }

            return true;
        }

        public string getRegisterList()
        {

            string s= "Register ID - Customer ID - Event ID";
            for (int x = 0; x < numRegister; x++)
            {
                s = s + "\n" + registerList[x].getregId() + "\n" + registerList[x].getcusId() + "\n" + registerList[x].geteveId();
            }
            return s;
        }

        public string getRegisterInfo(int regId)
        {
            int loc = findRSVP(regId);
            if (loc == -1) { return "There is no RSVP with id " + regId + "."; }
            return registerList[loc].ToString();
        }
    }
}
