using System;
using System.Configuration;
using System.Reflection;
using System.Xml;
using System.Windows.Forms;

namespace ExcelFrm
{
	public class Settings
	{
    public string RowsNumber { get; set; }


    //public string AmapKey { get; set; }
    //public string A3005NJMapID { get; set; }


    /// <summary>
    /// 初始化
    /// </summary>
    /// <returns></returns>
    public bool Init()
		{
			try
			{
        //this.AmapKey = this.getConfig("AmapKey");
        RowsNumber = this.getConfig("RowsNumber");

				return true;
			}
			catch (Exception ex)
			{
        throw (ex);

			}
		}

		private string getConfig(string key)
		{
			ConfigurationManager.RefreshSection("appSettings");
			string value = ConfigurationManager.AppSettings[key];//.Get(key);
			if (value == null)
				throw new Exception("Read [" + key + "] failed!");
			return value;
		}

        public static void setConfig(string name, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings[name].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            config = null;   
        }



		private static Settings _instance;
		public static Settings Instance
		{
			get 
			{
				if (_instance == null)
				{
					_instance = new Settings();
				}
				return _instance;
			}
		}

	}
}
