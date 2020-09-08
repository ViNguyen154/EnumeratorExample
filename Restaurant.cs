namespace Enumerable
{
     public class Restaurant {
      public  string Name { get; set; }
      public  bool IsOpen { get; set; }
        public Restaurant (string name, bool isOpen){
            this.Name = name;
            this.IsOpen = isOpen;
        }
    }
}