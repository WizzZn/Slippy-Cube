using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void StartGame ()
    {

        SceneManager.LoadScene(1);
    }
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void AboutPannel(GameObject pannel)
    {
        if(pannel.activeSelf == true)
        {
            pannel.SetActive(false);
        }
        else
        {
            pannel.SetActive(true);
        }
    }

}
