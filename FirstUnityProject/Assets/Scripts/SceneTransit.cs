using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransit : MonoBehaviour
{
    [SerializeField]
    Canvas splashScreen;
    [SerializeField]
    Canvas mainMenu;
    [SerializeField]
    Canvas optionsCanvas;
    [SerializeField]
    Canvas shopScreen;
    [SerializeField]
    Canvas friendScreen;
    [SerializeField]
    Canvas skillScreen;
    [SerializeField]
    Canvas gearScreen;
    [SerializeField]
    Canvas heroScreen;

    Canvas currentCanvas;
    Canvas prevCanvas;

    protected void Start()
    {
        mainMenu.enabled = false;
        optionsCanvas.enabled = false;
        friendScreen.enabled = false;
        skillScreen.enabled = false;
        //shopScreen.enabled = false;
        //gearScreen.enabled = false;
        //heroScreen.enabled = false;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && splashScreen.enabled)
        {
            MainMenu();
        }
    }

    public void Game()
    {
        SceneManager.LoadScene("Prototype"); //load title of scene
    }

    public void MainMenu()
    {
        splashScreen.enabled = false;
        mainMenu.enabled = true;

        currentCanvas = mainMenu;
    }

    public void changeMenu(Canvas _canvas)
    {
        prevCanvas = currentCanvas;
        prevCanvas.enabled = false;

        _canvas.enabled = true;
        currentCanvas = _canvas;
    }

    

}
