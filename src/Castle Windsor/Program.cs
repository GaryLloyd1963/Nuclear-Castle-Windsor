using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Nuclear.FacilityMonitoring;
using Nuclear.FacilityStatusQuery;
using Nuclear.FacilityStatusReporting;

namespace Nuclear
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] facilityCodeNames = {"Alpha", "Beta", "Gamma", "Delta"};

            var container = new WindsorContainer();
            container.Register(
                Component.For<IFacilityStatusQuery>().ImplementedBy<FacilityStatusQuery.FacilityStatusQuery>().LifestyleTransient());
            container.Register(
                Component.For<IFacilityReport>().ImplementedBy<FacilityReport>().LifestyleTransient());
            container.Register(
                Component.For<IFacilityMonitor>().ImplementedBy<FacilityMonitor>().LifestyleTransient()
                                                 .DependsOn(Dependency.OnValue("facilitieCodeNames", facilityCodeNames)));

            var facilityMonitor = container.Resolve<IFacilityMonitor>();
            facilityMonitor.ReportOnAllFacilities();
            Console.ReadKey();
        }
    }
}
