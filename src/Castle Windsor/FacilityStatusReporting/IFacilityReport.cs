namespace Nuclear.FacilityStatusReporting
{
    public interface IFacilityReport
    {
        void ReportOfflineStatus(string facility);
        void ReportNormalOperation(string facility, string status, string statusDetails);
        void EscalateAbnormalOperation(string facility, string status, string statusDetails);
        void EvacuateFacilityNow(string facility);
        void ReportUnknownStatus(string facility, string status);
    }
}