using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject mainMenu;

    public GameObject loadMenu;

    public GameObject optionsMenu;

    public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMenu() {
        mainMenu.SetActive(false);
        loadMenu.SetActive(true);
    }

    public void OptionsMenu() {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void Back() {
        mainMenu.SetActive(true);
        loadMenu.SetActive(false);
        optionsMenu.SetActive(false);
    }

}
