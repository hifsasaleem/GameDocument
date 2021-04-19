using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GamePlayUIManager : MonoBehaviour
{

    public GameObject GamePauseMode;
    public GameObject GamePlayMode;
    // Start is called before the first frame update
    void Start()
    {
              GamePauseMode.SetActive(false);
        
    }

    public void OnClickPausebutton(){
        GamePlayMode.SetActive(false);
      GamePauseMode.SetActive(true);
        Time.timeScale = 0;
    }


    public void OnClickResumebutton(){
      GamePauseMode.SetActive(false);
      GamePlayMode.SetActive(true);

        Time.timeScale = 1;
    }

}
