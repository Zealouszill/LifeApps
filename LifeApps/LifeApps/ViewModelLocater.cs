using SharedLogic;

namespace LifeApps
{
    public class ViewModelLocator
    {
        
        public ViewModelLocator()
        {
            MainViewModel mainView = new MainViewModel();

            //IDataStorage testStorage = new SqliteDataStore();
            //PotentialRepository testRepo = new PotentialRepository(testStorage);
            
            //Main = new MainViewModel(testRepo);

        }


        public MainViewModel Main { get; }


    }
}
