using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    public void loadScene1 () {
        SceneManager.LoadScene ("Scene1");
    }
    public void loadScene2 () {
        SceneManager.LoadScene ("Scene2");
    }
    public void loadScene3 () {
        SceneManager.LoadScene ("Scene3");
    }

    // Update is called once per frame
    void Update () {

    }
}