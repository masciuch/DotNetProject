using Newtonsoft.Json;
using Projekt.Model;
using System;
using System.IO;

namespace Projekt.Core
{
    public static class PersistenceService
    {
        public static PasswdTable OpenFile(String filepath, String password)
        {
            FileEncryptor fileEncyptor = new FileEncryptor();
            var encryptedJson = File.ReadAllText(filepath);
            var decryptedJson = fileEncyptor.Decrypt(encryptedJson, password);
            var modelObject = JsonConvert.DeserializeObject<PasswdTable>(decryptedJson);
            return modelObject;
        }

        public static void SaveFile(PasswdTable table, String password, String path)
        {
            FileEncryptor fileEncyptor = new FileEncryptor();
            var json = JsonConvert.SerializeObject(table);
            var encryptedJson = fileEncyptor.Encrypt(json, password);
            File.WriteAllText(path, encryptedJson);
        }

    }
}
