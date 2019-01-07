using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Diagnostics;

namespace SharedLogic
{
    public class MainViewModel : INotifyPropertyChanged
    {
        


        public MainViewModel()
        {
            TestString = "This word";

            currentTimeFunction = 100;

            Timer aTimer = new Timer();

            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;

        }

        

        private double CurrentTime;
        public double currentTimeFunction
        {

            get {
                Debug.WriteLine("Get is called");
                return CurrentTime; }
            set {
                Debug.WriteLine("Set is called");
                SetField(ref CurrentTime, value); }
        }

        private string TestString;
        public string testStringFunction
        {
            get { return TestString; }
            set { SetField(ref TestString, value); }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Debug.WriteLine("Hello World!");
            currentTimeFunction = currentTimeFunction - 1;

        }











        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        #endregion
    }
}
