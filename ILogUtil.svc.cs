using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AdminUtil
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LogUtil : ILogUtil
    {
        public bool LogMessage(string userid, char msgtype, string message, out string err_msg)
        {
            /*            OraDBLogMessageAccess dba = new OraDBLogMessageAccess();

                        return dba.LogMessage(msgtype, message, userid, out err_msg);
            */
            err_msg = "";
            return false;

        }

        public messsagesTable[] GetMessages(string userid, out string err_msg)
        {
            /*            List<messsagesTable> messages;

                        OraDBLogMessageAccess dba = new OraDBLogMessageAccess();

                        bool retVal = dba.getMessages(out messages, out err_msg);

                        if (retVal)
                            return messages.ToArray();
            */
            err_msg = "";
            return null;
        }

        public messsagesTable[] GetMessagesDateRange(string userid, DateTime fromDate, DateTime toDate, out string errMsg)
        {
            /*            List<messsagesTable> messages;

                        if (fromDate > toDate)
                        {
                            DateTime temp = fromDate;
                            fromDate = toDate;
                            toDate = temp;
                        }

                        OraDBLogMessageAccess dba = new OraDBLogMessageAccess();

                        bool retVal = dba.getMessagesDateRange(fromDate, toDate, out messages, out errMsg);

                        if (retVal)
                            return messages.ToArray();
            */
            errMsg = "";
            return null;
        }

        public messsagesTable[] GetMessagesType(string userid, char type, out string errMsg)
        {
            /*            List<messsagesTable> messages;

                        OraDBLogMessageAccess dba = new OraDBLogMessageAccess();

                        bool retVal = dba.getMessagesType(type, out messages, out errMsg);

                        if (retVal)
                            return messages.ToArray();
            */
            errMsg = "";
            return null;
        }

        public messsagesTable[] GetMessagesTypeDateRange(string userid, char type, DateTime fromDate, DateTime toDate, out string errMsg)
        {
            /*            List<messsagesTable> messages;

                        if (fromDate > toDate)
                        {
                            DateTime temp = fromDate;
                            fromDate = toDate;
                            toDate = temp;
                        }

                        OraDBLogMessageAccess dba = new OraDBLogMessageAccess();

                        bool retVal = dba.getMessagesTypeDateRange(type, fromDate, toDate, out messages, out errMsg);

                        if (retVal)
                            return messages.ToArray();
            */
            errMsg = "";
            return null;
        }

        public messsagesTable[] GetMessagesUser(string userid, string user, out string errMsg)
        {
            /*            List<messsagesTable> messages;

                        OraDBLogMessageAccess dba = new OraDBLogMessageAccess();

                        bool retVal = dba.getMessagesUser(user, out messages, out errMsg);

                        if (retVal)
                            return messages.ToArray();
            */
            errMsg = "";
            return null;
        }


        public messsagesTable[] GetMessagesUserDateRange(string userid, string user, DateTime fromDate, DateTime toDate, out string errMsg)
        {
            /*           List<messsagesTable> messages;

                       if (fromDate > toDate)
                       {
                           DateTime temp = fromDate;
                           fromDate = toDate;
                           toDate = temp;
                       }

                       OraDBLogMessageAccess dba = new OraDBLogMessageAccess();

                       bool retVal = dba.getMessagesUserDateRange(user, fromDate, toDate, out messages, out errMsg);

                       if (retVal)
                           return messages.ToArray();
           */
            errMsg = "";
            return null;
        }
    }
}
