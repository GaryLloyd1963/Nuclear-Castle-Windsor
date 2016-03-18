using System;

namespace Nuclear.FacilityStatusReporting
{
    public class FacilityReport : IFacilityReport
    {
        public void ReportOfflineStatus(string facility)
        {
            Console.WriteLine($"Facility {facility} is currently offline");
        }

        public void ReportNormalOperation(string facility, string status, string statusDetails)
        {
            Console.WriteLine($"Status report for {facility} is {status}, {statusDetails}");
        }

        public void EscalateAbnormalOperation(string facility, string status, string statusDetails)
        {
            Console.WriteLine($"Abnormal operation for {facility}, status {status}, {statusDetails}");
        }

        public void EvacuateFacilityNow(string facility)
        {
            Console.WriteLine($"Facility {facility} is in a dangerous operational state, evacuate now!");
        }

        public void ReportUnknownStatus(string facility, string status)
        {
            Console.WriteLine($"Facility {facility} is reporting an unknown status {status}");
        }
    }
}