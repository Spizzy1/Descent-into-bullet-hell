using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossFightData : MonoBehaviour
{
    public LevelData.buttonType selectionScene;
    public List<bossdata> bossData;
    public int difficultyIndex;
    public string currentBoss;
    public int lives;
    public int HP;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(GameObject.FindGameObjectsWithTag("BossDataStore").Length > 1)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

[System.Serializable]
public class bossdata
{
    public string bossName;
    public string bossDesc;
    public string sceneName;
    public Sprite defaultSprite;
    public Sprite hoverSprite;
    public Sprite selectSprite;
    public LevelData.buttonType buttonPlace;
}
