namespace Nuclear
{
    public enum FacilityStatus
    {
        Offline,
        OperatingwithinNormalLimits,
        ReactorCoreAboveNormalLimit,
        ReactorCoreCritical
    }

    public interface IFacilityStatusQuery
    {
        FacilityStatus GetMainFacilityStatus(string facilityCodeName);
        string GetDetailedFacilityStatus(string facilityCodeName);
    }
}