using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrApp
{
    public enum Role
    {
        Admin,
        User,
        None
    }

    public static class RoleMethods
    {
        public static String LocalizedString(this Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    return "Администратор";
                case Role.User:
                    return "Пользователь";
                default:
                    return "";
            }
        }
    }

}
