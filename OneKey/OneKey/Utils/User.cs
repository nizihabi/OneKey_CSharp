using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneKey
{
    class User
    {
        public static User GetInstance()
        {
            if (m_instance == null)
                m_instance = new User();
            return m_instance;
        }

        private static User m_instance;
        private string m_id;
        private string m_password;

        private User()
        {
            m_id = "";
            m_password = "";
        }

        public string ID
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }

        public string Password
        {
            get
            {
                return m_password;
            }
            set
            {
                m_password = value;
            }
        }
    }
}
