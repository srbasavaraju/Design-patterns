namespace FacadePattern
{
    public class CarFacade : ICarFacade
    {
        readonly CarBody carBody;
        readonly CarAccessories carAccessories;
        readonly CarEngine carEngine;

        public CarFacade()
        {
            carBody = new CarBody();
            carEngine = new CarEngine();
            carAccessories = new CarAccessories();
        }

        public void AssembleCar()
        {
            carEngine.assemble();
            carAccessories.assemble();
            carBody.assemble();
        }
    }
}
