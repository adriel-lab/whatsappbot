using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizonWhatsappSender
{
    public class AppSettings

    {
        private readonly string settingsPath = "settings.ini";
       
        // Valores padrão
        public int MinDelayBetweenContacts { get; set; } = 60;
        public int MaxDelayBetweenContacts { get; set; } = 120;
        public int DelayAfterSend { get; set; } = 5;
        public int MaxRetryAttempts { get; set; } = 5;
        public int RetryDelayMultiplier { get; set; } = 2;
        public int ErrorDelay { get; set; } = 15;
        public int InitialLoadDelay { get; set; } = 10;
        public int MinSendDelay { get; set; } = 5;
        public int MaxSendDelay { get; set; } = 8;
        public int delayFoto { get; set; } = 4;
        public int delayVideo { get; set; } = 10;



        public AppSettings()
        {
            Load();  // Carrega as configurações ao criar uma instância
        }
        public void Load()
        {
            if (!File.Exists(settingsPath))
                return;

            foreach (var line in File.ReadAllLines(settingsPath))
            {
                var parts = line.Split('=');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    switch (key)
                    {
                        case "MinDelayBetweenContacts":
                            MinDelayBetweenContacts = int.Parse(value);
                            break;
                        case "MaxDelayBetweenContacts":
                            MaxDelayBetweenContacts = int.Parse(value);
                            break;
                        case "DelayAfterSend":
                            DelayAfterSend = int.Parse(value);
                            break;
                        case "MaxRetryAttempts":
                            MaxRetryAttempts = int.Parse(value);
                            break;
                        case "RetryDelayMultiplier":
                            RetryDelayMultiplier = int.Parse(value);
                            break;
                        case "ErrorDelay":
                            ErrorDelay = int.Parse(value);
                            break;
                        case "InitialLoadDelay":
                            InitialLoadDelay = int.Parse(value);
                            break;
                        case "MinSendDelay":
                            MinSendDelay = int.Parse(value);
                            break;
                        case "MaxSendDelay":
                            MaxSendDelay = int.Parse(value);
                            break;
                        case "delayFoto":
                            delayFoto = int.Parse(value);
                            break;
                        case "delayVideo":
                            delayVideo = int.Parse(value);
                            break;
                    }
                }
            }
        }
        public void ResetToDefaults()
        {
            MinDelayBetweenContacts = 60;
            MaxDelayBetweenContacts = 120;
            DelayAfterSend = 5;
            MaxRetryAttempts = 5;
            RetryDelayMultiplier = 2;
            ErrorDelay = 15;
            InitialLoadDelay = 10;
            MinSendDelay = 5;
            MaxSendDelay = 8;
            delayFoto = 4;
            delayVideo = 10;

            Save(); // Salva os valores padrão no arquivo
        }
        public void Save()
        {
            var lines = new List<string>
            {
                $"MinDelayBetweenContacts={MinDelayBetweenContacts}",
                $"MaxDelayBetweenContacts={MaxDelayBetweenContacts}",
                $"DelayAfterSend={DelayAfterSend}",
                $"MaxRetryAttempts={MaxRetryAttempts}",
                $"RetryDelayMultiplier={RetryDelayMultiplier}",
                $"ErrorDelay={ErrorDelay}",
                $"InitialLoadDelay={InitialLoadDelay}",
                $"MinSendDelay={MinSendDelay}",
                $"MaxSendDelay={MaxSendDelay}",
                $"delayFoto={delayFoto}",
                $"delayVideo={delayVideo}"
            };

            File.WriteAllLines(settingsPath, lines);
        }
    }
}