using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class screenManagement
{

    public static string directory;

    public static string Fillname;

    public static void save(saveObject so)
    {

        string dir = Application.persistentDataPath + directory;

        if(!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

         string json = JsonUtility.ToJson(so);
        File.WriteAllText(dir+Fillname, json);







    }

    public static saveObject Load()
    {
        string fullpath = Application.persistentDataPath + directory+Fillname; 

        saveObject so = new saveObject();   

        if(File.Exists(fullpath))
        {

            string json= File.ReadAllText(fullpath);

            so = JsonUtility.FromJson<saveObject>(json);

        }
        else
        {
            Debug.Log("Dictionary is empty");
        }

        return so;


    }







  
}
