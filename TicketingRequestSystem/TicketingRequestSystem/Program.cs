using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingRequestSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new frmLogin();
            frmOperator operatorForm;
            frmWorker workerForm ;
            Application.Run(login);
            UserAccount user;
            if (login.Tag != null)
            {
                user = (UserAccount)login.Tag;

                if (user.UserType == "OPERATOR")
                {
                    operatorForm = new frmOperator(user.UserID, user.Username);
                    Application.Run(operatorForm);
                }
                else
                {
                    workerForm = new frmWorker(user.Username,user.UserID);
                    Application.Run(workerForm);
                }
            }

            



            //frmOperator operatorLogin = new frmOperator();
            //Application.Run(operatorLogin);
        }
    }
}
