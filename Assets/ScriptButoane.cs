using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptButoane : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("Level01");
    }

    public void EndGame(){
        Debug.Log("QUIT");
        Application.Quit();
    }
}
