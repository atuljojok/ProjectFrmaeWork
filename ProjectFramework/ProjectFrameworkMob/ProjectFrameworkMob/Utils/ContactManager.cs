using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;
using ProjectFrameworkCommonLib;
namespace ProjectFrameworkMob.Utils
{
   public class ContactManager
    {
        private const string SettingsFileName = "ContactSettings.xml";
        private string AppDataFolder { get; set; }
        private string AppDataPath { get; set; }
        public ContactSettings CSettings { get; set; }
        public ContactManager()
        {
            try
            {
             
                CSettings = new ContactSettings();
                AppDataPath = GetApplicationDataPath();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public string GetApplicationDataPath()
        {
            
            // The folder for the roaming current user 
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Combine the base folder with your specific folder....
            string title = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

            AppDataFolder = Path.Combine(folder, title);
            //Create the folder if not there
            if (!Directory.Exists(AppDataFolder))
            {
                Directory.CreateDirectory(AppDataFolder);
            }

            AppDataPath = Path.Combine(AppDataFolder, SettingsFileName);
            return AppDataPath;
        }
        public void LoadSettings()
        {
            try
            {
                string strEncryptedData = "";

                if (System.IO.File.Exists(AppDataPath))
                {
                    strEncryptedData = System.IO.File.ReadAllText(AppDataPath);
                }

                if (string.IsNullOrEmpty(strEncryptedData))
                {
                    return;
                }
                string strData = DecryptData(strEncryptedData);
                XmlSerializer serializer = new XmlSerializer(typeof(ContactManager));
                XmlReaderSettings Xmlsettings = new XmlReaderSettings();
                // No settings need modifying here

                using (StringReader textReader = new StringReader(strData))
                {
                    ContactManager CManager = (ContactManager)serializer.Deserialize(textReader);

                    //Assign other Objects as well as when you add other datas 
                  
                    this.CSettings = CManager.CSettings;
                   

                }
            }
            catch (Exception Ex)
            {
                //Throw the exception and catch in the called block and display the error mesage
                //No bool return is needed 
                throw Ex;
            }

        }

        public void SaveSettings()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ContactManager));
                string strSerailizedString = "";
                using (StringWriter textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, this);
                    strSerailizedString = textWriter.ToString();
                }
                //Encrypt the Data
                string strEncryptedData = EncryptData(strSerailizedString);
                //Save it to App Data File
                System.IO.File.WriteAllText(AppDataPath, strEncryptedData);

            }
            catch (Exception Ex)
            {
                //Throw the exception and catch in the called block and display the error mesage
                //No bool return is needed 
                throw Ex;
            }
        }
        private string EncryptData(string strContent)
        {
            return PFCrypt.Encrypt(strContent);
        }
        private string DecryptData(string strContent)
        {
            return PFCrypt.Decrypt(strContent);
        }
    }
   
  
}


