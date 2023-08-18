using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MyPersistentJSON : MonoBehaviour
{
    private static string myPath = Application.persistentDataPath + "savefile.json";
    class SaveData
    {
        public string name;
        public int score;
    }

    public static void SaveUserScore(string name, int score)
    {
        SaveData data = new SaveData();
        data.name = name;
        data.score = score;

        string jsonString = JsonUtility.ToJson(data);
        File.WriteAllText(myPath, jsonString);
    }

    public static string GetNameFromFile()
    {
        if(extractDataFromJSON() == null)
        {
            return "";
        }
        return extractDataFromJSON().name;
    }

    public static int GetScoreFromFile()
    {
        if (extractDataFromJSON() == null)
        {
            return 0;
        }
        return extractDataFromJSON().score; 
   
    }

    private static SaveData extractDataFromJSON()
    {
        if (File.Exists(myPath))
        {
            string json = File.ReadAllText(myPath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            return data;
        }
        return null;
    }
}
