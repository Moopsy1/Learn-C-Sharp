namespace DependencyInjection
{
    public class IndexModel 
    {   
        //this is a poor way of doing this, this class creates and directly depends on the MyDependency class
        //to replace MyDependency with a different implementation means that this class needs to also be modified
        //If my dependency has its own dependencies then they must also be configured by the Index Model class
        private readonly MyDependency _depdendency = new MyDependency();

        public void OnGet()
        {
            _depdendency.WriteMessage("Index Model.OnGet created this message");
        }

    }
}
