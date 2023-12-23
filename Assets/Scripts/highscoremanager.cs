using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class highscoremanager : MonoBehaviour
{
    
    public static highscoremanager main;

    public int highscore;



    private void Awake()
    {
        
        if (main != null)
        {
            Destroy(gameObject);
            return;
        }
        main = this;
        DontDestroyOnLoad(gameObject);
        loadhighscore();
    }
   

    // Update is called once per frame
    void Update()
    {
        
        if(MainManager.main.m_Points >= highscore)
        {
            highscore = MainManager.main.m_Points;
            savehscore();
        }
    }

    [System.Serializable]
    class savedata
    {
        public int highscore;
    }

    public void savehscore()
    {
        savedata data = new savedata();
        data.highscore = highscore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }


    public void loadhighscore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            savedata data = JsonUtility.FromJson<savedata>(json);

            highscore = data.highscore;
        }

    }
}
