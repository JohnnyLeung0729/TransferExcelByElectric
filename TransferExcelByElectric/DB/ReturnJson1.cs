using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferExcelByElectric.DB
{
    class ReturnJson1
    {
        public void init()
        {

        }

        int code = 0;
        String message = String.Empty;
        Hashtable map = null;
        String object_ = String.Empty;
        String codeString= string.Empty;

        public int Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        public Hashtable Map
        {
            get
            {
                return map;
            }

            set
            {
                map = value;
            }
        }

        public string Object
        {
            get
            {
                return object_;
            }

            set
            {
                object_ = value;
            }
        }

        public string CodeString
        {
            get
            {
                return codeString;
            }

            set
            {
                codeString = value;
            }
        }
    }
}
