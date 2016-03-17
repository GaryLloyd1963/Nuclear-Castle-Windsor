namespace Nuclear
{
    public interface IFacilityReport
    {
        void ReportOfflineStatus(string facility);
        void ReportNormalOperation(string facility, string status, string statusDetails);
        void EscalateAbnormalOperation(string facility, string status, string statusDetails);
        void EvacuateFacilityNow(string facility);
    }
}