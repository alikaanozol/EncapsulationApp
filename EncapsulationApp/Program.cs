using EncapsulationApp;

Car car = new Car("Opel","Corsa","Beyaz",4);  //// Car sınıfından yeni bir nesne oluşturuyoruz. || We create a new object from the Car class.

Console.WriteLine($"Car: {car.Mark}, {car.Model}, {car.Colour},kapı sayısı {car.NumberofDoors}");