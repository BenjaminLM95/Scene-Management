using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject player;
    private GameObject SpawnPosition; 
    // Start is called before the first frame update
    void Start()
    {      
             
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha2)) 
        {
            LoadGamePlayScene();

        }

        if (Input.GetKey(KeyCode.Alpha1))
        {
            LoadMainMenuScene();
        }

    }

    void LoadGamePlayScene() 
    {
        SceneManager.LoadScene(1);
        //SpawnPosition = GameObject.Find("SpawnPointGamePlay");
        //player.transform.position = SpawnPosition.transform.position;

        SceneManager.sceneLoaded += onSceneLoaded;
    }

    void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);

        SceneManager.sceneLoaded += onSceneLoaded; 
        //SpawnPosition = GameObject.Find("SpawnPointMainMenu");
        //player.transform.position = SpawnPosition.transform.position;
    }

    void onSceneLoaded(Scene scene, LoadSceneMode mode) 
    {
        Debug.Log("Scene: " + scene.name + "is loaded"); 
    }

}
