using System.ComponentModel;

namespace MobilePhoneCardiography.Models.Json
{
    public class JsonMeasurement : IJsonDatabase, INotifyPropertyChanging
    {
        public event PropertyChangingEventHandler PropertyChanging;
        public string id { get; set; }
    }
}