using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_practical_tasks.Classes
{
    static class cls_user
    {
       private static  string m_s_Username = "Test";
       private static string m_s_Password = "123";


        public static string Username
        {
            get { return m_s_Username; }
            set { m_s_Username = value; }
        }

        public static string Password
        {
            get { return m_s_Password; }
            set { m_s_Password = value; }
        }
    }
}
