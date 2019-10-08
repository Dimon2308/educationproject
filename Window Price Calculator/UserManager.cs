using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Price_Calculator
{
    class UserManager
    {
        FilesHelper _fileshelper;
        public UserManager()
        {
            _fileshelper = new FilesHelper();
        }
        static void SaveUserToFile(User user)
        {
            _fileshelper.Appendtexttofile(string path, string text); ;
        }
    }
}
