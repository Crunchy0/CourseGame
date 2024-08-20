using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        string objName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        switch (objName)
        {
            case "Player1Select":
                GameManager.instance.CharIndex = 0;
                break;
            case "Player2Select":
                GameManager.instance.CharIndex = 1;
                break;
            default:
                return;
        }
        
        SceneManager.LoadScene("Gameplay");
    }
}
