namespace Nuclear
{
    public class FacilityMonitor : IFacilityMonitor
    {
        private readonly string[] _facilities;
        private IFacilityStatusQuery _facilityQuery;

        public FacilityMonitor(string[] facilities, IFacilityStatusQuery facilityQuery)
        {
            _facilities = facilities;
            _facilityQuery = facilityQuery;
        }

        public void CheckAllFacilities()
        {
            foreach (var facility in _facilities)
            {   
            }
        }
    }
}