using System;
using System.Runtime.Serialization;

namespace WCF_DataContracts
{
    [DataContract]
    public class MSG
    {

        public MSG()
        {
            
        }

        public MSG(string opName, string appToken, object[] dataTable)
        {
            op_name = opName;
            app_token = appToken;
            data_table = dataTable;
        }

        private bool op_status;
        private string op_name;
        private string op_info;
        private string app_name;
        private string app_version;
        private string app_token;
        private string user_token;
        private string user_login;
        private string user_password;
        private Object[] data_table;

        public bool OpStatus
        {
            get => op_status;
            set => op_status = value;
        }
        [DataMember]
        public string OpName
        {
            get => op_name;
            set => op_name = value;
        }

        public string OpInfo
        {
            get => op_info;
            set => op_info = value;
        }

        public string AppName
        {
            get => app_name;
            set => app_name = value;
        }

        public string AppVersion
        {
            get => app_version;
            set => app_version = value;
        }
        [DataMember]
        public string AppToken
        {
            get => app_token;
            set => app_token = value;
        }

        public string UserToken
        {
            get => user_token;
            set => user_token = value;
        }

        public string UserLogin
        {
            get => user_login;
            set => user_login = value;
        }

        public string UserPassword
        {
            get => user_password;
            set => user_password = value;
        }
        [DataMember]
        public object[] DataTable
        {
            get => data_table;
            set => data_table = value;
        }
    }
}