namespace DemoWebAssembly.Client.Services
{
    public class FakeDataContext
    {
        public List<string> MyProperty { get; set; }

        public FakeDataContext()
        {
            MyProperty = new List<string>();
            for(int i = 0; i < 300; i++)
            {
                MyProperty.Add("Salut " + i);
            }
            
        }

        public List<string> GetAll()
        {
            return MyProperty;
        }
    }
}
