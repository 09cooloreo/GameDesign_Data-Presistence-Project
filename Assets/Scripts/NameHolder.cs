using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NameHolder : MonoBehaviour
{
    public static NameHolder Instance;

    public string Name;
    public int Score;

    public string PreName;
    public int PreScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class Best
    {
        public string BestName;
        public int BestScore;
    }

    public void SaveBest()
    {
        Best data = new Best();
        data.BestName = Name;
        data.BestScore = Score;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadBest()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Best data = JsonUtility.FromJson<Best>(json);

            PreName = data.BestName;
            PreScore = data.BestScore;
        }
    }
}
