using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AdminUtil
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILogUtil
    {
        [OperationContract]
        bool LogMessage(string userid, char msgtype, string message, out string err_msg);
        [OperationContract]
        messsagesTable[] GetMessages(string userid, out string err_msg);
        [OperationContract]
        messsagesTable[] GetMessagesDateRange(string userid, DateTime fromDate, DateTime toDate, out string errMsg);
        [OperationContract]
        messsagesTable[] GetMessagesType(string userid, char type, out string errMsg);
        [OperationContract]
        messsagesTable[] GetMessagesTypeDateRange(string userid, char type, DateTime fromDate, DateTime toDate, out string errMsg);
        [OperationContract]
        messsagesTable[] GetMessagesUser(string userid, string user, out string errMsg);
        [OperationContract]
        messsagesTable[] GetMessagesUserDateRange(string userid, string user, DateTime fromDate, DateTime toDate, out string errMsg);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class messsagesTable
    {
        char exceptionType;
        string errMsg;
        string userID;
        DateTime execeptionTime;

        [DataMember]
        public char ExceptionType
        {
            get { return exceptionType; }
            set { exceptionType = value; }
        }

        [DataMember]
        public string ErrorMessage
        {
            get { return errMsg; }
            set { errMsg = value; }
        }
        [DataMember]
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        [DataMember]
        public DateTime ExeceptionTime
        {
            get { return execeptionTime; }
            set { execeptionTime = value; }
        }
    }
}
