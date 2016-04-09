## Nuclear-Castle-Windsor/NUnit3/Moq
###A simple DI example using Castle Windsor, NUnit3, and Moq
This uses simple classes to show some simple (but not exhaustive) test examples.
There are 3 main classes, the main one calls a query class to get a status, and then calls the appropriate report method
based on the returned query status. Moq allows the query status to be varied and so allow test coverage of which reporting methods are called.

### A facility monitor
https://github.com/GaryLloyd1963/Nuclear-Castle-Windsor/tree/master/src/Castle%20Windsor/FacilityMonitoring

### Status queries for the facilities
https://github.com/GaryLloyd1963/Nuclear-Castle-Windsor/tree/master/src/Castle%20Windsor/FacilityStatusQuery

### Status reporting
https://github.com/GaryLloyd1963/Nuclear-Castle-Windsor/tree/master/src/Castle%20Windsor/FacilityStatusReporting

### Testing using Moq
https://github.com/GaryLloyd1963/Nuclear-Castle-Windsor/tree/master/src/Nuclear.Tests.Unit


