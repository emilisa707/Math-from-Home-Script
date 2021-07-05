using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class Game 
{
    public static void SavePlayer (GameData data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/saveFile.dat";

        FileStream stream = new FileStream(path, FileMode.Create);

        GameStateData dataSave = new GameStateData(data);

        formatter.Serialize(stream, dataSave);
        stream.Close();
    }

    public static GameStateData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/saveFile.dat";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameStateData data = formatter.Deserialize(stream) as GameStateData;
            return data;
        } else
        {
            return null;
        }
    }
}
