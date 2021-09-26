namespace Mod6
{
    public class Pet
    {
        Pet mac = new Pet();
        Pet chicken = new Pet();
            
        mac.SetName("Mac");
        chicken.SetName("Chicken");
        mac.SetAge(15);
        chicken.SetAge(5);
        Console.Write(mac.GetName());

        private string _name;
        private int _age;
        

        public void SetName(string n)
        {
            _name = n;
        }

        public void SetAge(int a)
        {
            _age = a;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }
        public Pet()
    }
}