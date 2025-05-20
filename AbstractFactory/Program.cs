using AbstractFactory.Core.Factories;
using AbstractFactory.Helpers;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddDriverFactoryWithDI();
var serviceProvider = services.BuildServiceProvider();

var driverFactory = serviceProvider.GetRequiredService<IDriverFactory>();
var bloodPressureDriver = driverFactory.CreateBloodPressureDriver();
var bloodPressureResult = bloodPressureDriver.PerformMeasurement();
var oximeterDriver = driverFactory.CreateOximeterDriver();
var oximeterResult = oximeterDriver.PerformMeasurement();
var scalePressureDriver = driverFactory.CreateScaleDriver();
var scaleResult = scalePressureDriver.PerformMeasurement();
