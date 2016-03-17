using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Nuclear
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(
                Component.For<IFacilityStatusQuery>().ImplementedBy<FacilityStatusQuery>().LifestyleTransient());

            var facilityQuery = container.Resolve<IFacilityStatusQuery>();

            Console.WriteLine("Status of facility North Suffolk is {0}", facilityQuery.GetMainFacilityStatus("North Suffolk"));

        }
    }
}
