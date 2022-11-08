using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Infrastructure.Setting
{
    public class ESetting : ESettingBase
    {
        private static readonly string SETTING_FILE_NAME = "setting.dat";

        private static readonly ESetting _instance = new ESetting(SETTING_FILE_NAME);
        public static ESetting Setting => _instance;

        public ESetting(string settingFileName)
            : base()
        {
            if (File.Exists(settingFileName))
            {
                this.loadSettingFromStream(new MemoryStream(File.ReadAllBytes(settingFileName)));
            }
            else
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    //DEFAULT
                    CurrentDbmsType = "SQL-SERVER";
                    SqlServerConnectionString = "Server=.; Database=LearnEnglish_001; Integrated Security=True;";
                    SqliteConnectionString = "Data source=LearnEnglish_001.sqlite3";

                    //SAVE
                    this.saveSettingToStream(ms);
                    File.WriteAllBytes(settingFileName, ms.ToArray());
                }
            }
        }

        public string CurrentDbmsType
        {
            get => this.getString("DBMS-TYPE", "SQL-SERVER");
            set => this.setString("DBMS-TYPE", value);
        }

        public string SqlServerConnectionString
        {
            get => this.getString("SQL-SERVER-CONN");
            set => this.setString("SQL-SERVER-CONN", value);
        }

        public string SqliteConnectionString
        {
            get => this.getString("SQLITE-CONN", "Database Source=LearnEnglish_001.sqlite3");
            set => this.setString("SQLITE-CONN", value);
        }

        public void loadSetting()
        {
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(SETTING_FILE_NAME)))
            {
                this.loadSettingFromStream(ms);
            }
        }

        public void saveSetting()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                this.saveSettingToStream(ms);
                File.WriteAllBytes(SETTING_FILE_NAME, ms.ToArray());
            }
        }
    }
}
