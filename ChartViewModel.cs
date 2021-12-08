// create the class of chart.xaml view model for binding the data to the chart.xaml

public class ChartViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    private ObservableCollection<ChartData> _data;
    public ObservableCollection<ChartData> Data
    {
        get
        {
            return _data;
        }
        set
        {
            _data = value;
            OnPropertyChanged("Data");
        }
    }

    // bind for the chart title
    private string _chartTitle;

    public string ChartTitle
    {
        get
        {
            return _chartTitle;
        }
        set
        {
            _chartTitle = value;
            OnPropertyChanged("ChartTitle");
        }
    }

    public ChartViewModel()
    {
        Data = new ObservableCollection<ChartData>();
        Data.Add(new ChartData() { Category = "Jan", Value = 0.5 });
        Data.Add(new ChartData() { Category = "Feb", Value = 0.6 });
        Data.Add(new ChartData() { Category = "Mar", Value = 0.7 });
        Data.Add(new ChartData() { Category = "Apr", Value = 0.8 });
        Data.Add(new ChartData() { Category = "May", Value = 0.9 });
        Data.Add(new ChartData() { Category = "Jun", Value = 1.0 });
        Data.Add(new ChartData() { Category = "Jul", Value = 1.1 });
        Data.Add(new ChartData() { Category = "Aug", Value = 1.2 });
        Data.Add(new ChartData() { Category = "Sep", Value = 1.3 });
        Data.Add(new ChartData() { Category = "Oct", Value = 1.4 });
        Data.Add(new ChartData() { Category = "Nov", Value = 1.5 });
        Data.Add(new ChartData() { Category = "Dec", Value = 1.6 });
    }
}