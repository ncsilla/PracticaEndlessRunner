using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Save
{


    public static void SavePlayer(PlayerController player)
    {
        BinaryFormatter formatter = new();
        string path = Application.persistentDataPath + "/" + "player.save";
        PlayerDates data = new(player);
        
        PlayerDates best = Load();
        if (best==null || best.position < data.position)
        {
            using FileStream stream = new(path, FileMode.Create);
            try
            {
                
                formatter.Serialize(stream, data);
                Debug.Log("saveOk");
            }
            finally
            {
                stream.Close();
            }
        }
    }

    public static PlayerDates Load()
    {
        string path = Application.persistentDataPath + "/" +"player.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new();
            using FileStream stream = new(path, FileMode.Open);
            try
            {
                PlayerDates data = formatter.Deserialize(stream) as PlayerDates;
                Debug.Log("Load");
                return data;
            }
            finally
            {
                stream.Close();
            }
        }
        else
        {
            return null;
        }
    }

}