﻿namespace Nuclear.FacilityStatusQuery
{
    public class FacilityStatusQuery : IFacilityStatusQuery
    {
        public FacilityStatus GetMainFacilityStatus(string facilityCodeName)
        {
            return FacilityStatus.OperatingWithinNormalLimits;
        }

        public string GetDetailedFacilityStatus(string facilityCodeName)
        {
            return "No details available";
        }
    }
}