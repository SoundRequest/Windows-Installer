using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SoundRequest {
    class Setting {
        public static bool debug = false;
        public static bool inProgress = false;

        public static string programVer = "";
        public static string installerVer = "0.0.1";
        public static string tosVer = "";
        public static string lastUpdated = "";
        public static string changeLog = "";
        public static string tosURL = "";
        public static string downloadURL = "";
        public static string shortcut = "";

        private static string URL = "https://soundrequest.github.io/DB/version.json";

        public static bool LoadData() {
            try {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                using (WebClient client = new WebClient()) {
                    string info = client.DownloadString(URL);
                    var json = JObject.Parse(info);
                    if ((bool)json["Status"]) {
                        if (installerVer != json["InstallerVer"].ToString()) {
                            // Installer ver 
                        } else {
                            // read json
                            programVer = json["ProgramVer"].ToString();
                            tosVer = json["TOS"].ToString();
                            lastUpdated = json["LastUpdated"].ToString();
                            changeLog = json["ChangeLog"].ToString();
                            tosURL = json["TOS_URL"].ToString();
                            downloadURL = json["DownloadURL"].ToString();
                            shortcut = json["Shortcut"].ToString();

                            if (debug)
                                MessageBox.Show($"{programVer} {tosVer} {lastUpdated} {changeLog} {tosURL} {downloadURL} {shortcut}");
                        }
                    }
                }
                return true;
            } catch (Exception e) {
                if (debug)
                    MessageBox.Show(e.ToString());
                return false;
            }
        }
    }
}