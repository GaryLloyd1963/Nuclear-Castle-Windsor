using Nuclear.FacilityStatusQuery;
using Nuclear.FacilityStatusReporting;

namespace Nuclear.FacilityMonitoring
{
    public class FacilityMonitor : IFacilityMonitor
    {
        private readonly string[] _facilitieCodeNames;
        private readonly IFacilityStatusQuery _facilityStatusQuery;
        private readonly IFacilityReport _facilityReport;

        public FacilityMonitor(string[] facilitieCodeNames, IFacilityStatusQuery facilityStatusQuery, IFacilityReport facilityReport)
        {
            _facilitieCodeNames = facilitieCodeNames;
            _facilityStatusQuery = facilityStatusQuery;
            _facilityReport = facilityReport;
        }

        public void ReportOnAllFacilities()
        {
            foreach (var facilityCodeName in _facilitieCodeNames)
            {
                var facilityStatus = _facilityStatusQuery.GetMainFacilityStatus(facilityCodeName);
                var facilityStatusDetails = _facilityStatusQuery.GetDetailedFacilityStatus(facilityCodeName);
                switch (facilityStatus)
                {
                    case FacilityStatus.Offline:
                        _facilityReport.ReportOfflineStatus(facilityCodeName);
                        break;
                    case FacilityStatus.OperatingwithinNormalLimits:
                        _facilityReport.ReportNormalOperation(facilityCodeName, facilityStatus.ToString(), facilityStatusDetails);
                        break;
                    case FacilityStatus.ReactorCoreAboveNormalLimit:
                        _facilityReport.EscalateAbnormalOperation(facilityCodeName, facilityStatus.ToString(), facilityStatusDetails);
                        break;
                    case FacilityStatus.ReactorCoreCritical:
                        _facilityReport.EvacuateFacilityNow(facilityCodeName);
                        break;
                    default:
                        _facilityReport.ReportUnknownStatus(facilityCodeName, facilityStatus.ToString());
                        break;
                }
            }
        }
    }
}