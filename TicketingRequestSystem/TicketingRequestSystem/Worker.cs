using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingRequestSystem
{
    class Worker
    {
        int workerID;
        string workerType;
        string firstName;
        string lastName;
        string departmentID;
        string contactInformation;

        public int WorkerID
        {
            get
            {
                return workerID;
            }

            set
            {
                workerID = value;
            }
        }

        public string WorkerType
        {
            get
            {
                return workerType;
            }

            set
            {
                workerType = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string DepartmentID
        {
            get
            {
                return departmentID;
            }

            set
            {
                departmentID = value;
            }
        }

        public string ContactInformation
        {
            get
            {
                return contactInformation;
            }

            set
            {
                contactInformation = value;
            }
        }
    }
}
