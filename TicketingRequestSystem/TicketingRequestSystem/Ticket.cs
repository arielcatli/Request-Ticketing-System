using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingRequestSystem
{
    class Ticket
    {
        int ticketID;
        DateTime ticketTime;
        int workerID;
        string departmentID;
        string ticketStatus;
        string requestorName;
        string request;
        string requestorContactInformation;
        DateTime deadline;

        public int TicketID
        {
            get
            {
                return ticketID;
            }

            set
            {
                ticketID = value;
            }
        }

        public DateTime TicketTime
        {
            get
            {
                return ticketTime;
            }

            set
            {
                ticketTime = value;
            }
        }

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

        public string TicketStatus
        {
            get
            {
                return ticketStatus;
            }

            set
            {
                ticketStatus = value;
            }
        }

        public string RequestorName
        {
            get
            {
                return requestorName;
            }

            set
            {
                requestorName = value;
            }
        }

        public string Request
        {
            get
            {
                return request;
            }

            set
            {
                request = value;
            }
        }

        public string RequestorContactInformation
        {
            get
            {
                return requestorContactInformation;
            }

            set
            {
                requestorContactInformation = value;
            }
        }

        public DateTime Deadline
        {
            get
            {
                return deadline;
            }

            set
            {
                deadline = value;
            }
        }
    }
}
