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

        public static void SetUsername(string s_Username) { m_s_Username = s_Username; }
        public static string GetUsername() { return m_s_Username; }
        public static void SetPassword(string s_Password) { m_s_Password = s_Password; }
        public static string GetPassword() { return m_s_Password; }
    }
}
