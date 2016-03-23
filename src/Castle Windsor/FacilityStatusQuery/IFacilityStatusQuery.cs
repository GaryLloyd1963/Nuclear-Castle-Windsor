namespace Nuclear.FacilityStatusQuery
{
    public enum FacilityStatus
    {
        Offline,
        OperatingWithinNormalLimits,
        ReactorCoreAboveNormalLimit,
        ReactorCoreCritical
    }

    public interface IFacilityStatusQuery
    {
        FacilityStatus GetMainFacilityStatus(string facilityCodeName);
        string GetDetailedFacilityStatus(string facilityCodeName);
    }
}