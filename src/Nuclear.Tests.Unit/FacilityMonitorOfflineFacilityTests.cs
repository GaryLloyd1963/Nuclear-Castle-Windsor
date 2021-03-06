﻿using Moq;
using Nuclear.FacilityMonitoring;
using Nuclear.FacilityStatusQuery;
using Nuclear.FacilityStatusReporting;
using NUnit.Framework;

namespace Nuclear.Tests.Unit
{
    [TestFixture]
    public class FacilityMonitorOfflineFacilityTests
    {
        private readonly string[] _facilityCodeNames = { "Atlantis", "Fromelle" };
        private Mock<IFacilityStatusQuery> _mockFacilityStatusQuery;
        private Mock<IFacilityReport> _mockFacilityReport;

        [OneTimeSetUp]
        public void GivenaFaciltyMonitorAndOfflineFacilities()
        {
            _mockFacilityStatusQuery = new Mock<IFacilityStatusQuery>();
            _mockFacilityStatusQuery.Setup(x => x.GetMainFacilityStatus(It.IsAny<string>()))
                .Returns(FacilityStatus.Offline);

            _mockFacilityReport = new Mock<IFacilityReport>();
            _mockFacilityReport.Setup(x => x.ReportOfflineStatus(It.IsAny<string>())).Verifiable();

            var facilityMonitor = new FacilityMonitor(_facilityCodeNames, _mockFacilityStatusQuery.Object,
                _mockFacilityReport.Object);
            facilityMonitor.ReportOnAllFacilities();
        }

        [Test]
        public void WhenReportingOnAllFacilities_ThenGetMainFacilityStatusIsCalled()
        {
            _mockFacilityStatusQuery.Verify(x=>x.GetMainFacilityStatus(It.IsAny<string>()), Times.Exactly(2));
        }

        [Test]
        public void WhenReportingOnAllFacilities_ThenReportOfflineStatusIsCalled()
        {
            _mockFacilityReport.Verify(x => x.ReportOfflineStatus(It.IsAny<string>()), Times.Exactly(2));
        }
    }
}
