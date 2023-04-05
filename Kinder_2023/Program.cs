namespace Kinder_2023 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Kinderfütterer!");

            Nahrung apfel = new Nahrung();
            Kind memduh = new Kind();
            Fuetterer mohammad = new Fuetterer();

            mohammad.Fuettert(memduh, apfel);

            Console.Read();
        }
    }
}