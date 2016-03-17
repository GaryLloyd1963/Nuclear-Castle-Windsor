using System;

namespace Nuclear
{
    public class FacilityReport : IFacilityReport
    {
        public void ReportOfflineStatus(string facility)
        {
            Console.WriteLine(string.Format("Facility {0} is currently offline", facility));
        }

        public void ReportNormalOperation(string facility, string status, string statusDetails)
        {
            Console.WriteLine(string.Format("Status report for {0} is {1}, {2}", facility, status, statusDetails));
        }

        public void EscalateAbnormalOperation(string facility, string status, string statusDetails)
        {
            Console.WriteLine(string.Format("Abnormal operation for {0}, status {1}, {2}", facility, status, statusDetails));
        }

        public void EvacuateFacilityNow(string facility)
        {
            Console.WriteLine(string.Format("Facility {0} is in a dangerous operational state, evacuate now!", facility));
        }

        public void ReportUnknownStatus(string facility, string status)
        {
            Console.WriteLine(string.Format("Facility {0} is reporting an unknown status {1}", facility, status));
        }
    }
}