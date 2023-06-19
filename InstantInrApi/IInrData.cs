
using Newtonsoft.Json;

namespace InstantInrApi
{
    public interface IInrData
    {
        bool WriteInrData(InrDataModel inrData);
        InrDataModel? ReadInrData();
    }

    public class InrData : IInrData
    {
        private string _dataFilePath { get; set; }
        private ILogger<InrData> _logger { get; }

        public InrData(ILogger<InrData> logger)
        {
            string applicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
            _dataFilePath = Path.Combine(applicationDirectory, "data.json");
            _logger = logger;
        }
        public bool WriteInrData(InrDataModel inrData)
        {
            try
            {
                if (File.Exists(_dataFilePath))
                {
                    File.WriteAllText(_dataFilePath, JsonConvert.SerializeObject(inrData));
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message}\n{ex.StackTrace}", ex);
                return false;
            }

        }

        public InrDataModel? ReadInrData()
        {
            try
            {
                if (File.Exists(_dataFilePath))
                {
                    return JsonConvert.DeserializeObject<InrDataModel>(File.ReadAllText(_dataFilePath));
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message}\n{ex.StackTrace}", ex);
                return null;
            }
        }
    }
}
