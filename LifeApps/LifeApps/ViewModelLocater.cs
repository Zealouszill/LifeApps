using SharedLogic;

namespace LifeApps
{
    public class ViewModelLocator
    {
        
        public ViewModelLocator()
        {
            mainView = new MainViewModel();

            //IDataStorage testStorage = new SqliteDataStore();
            //PotentialRepository testRepo = new PotentialRepository(testStorage);
            
            //Main = new MainViewModel(testRepo);

        }


        public MainViewModel mainView { get; }


    }
}
