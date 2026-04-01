using UnityEngine;
using UnityEngine.SceneManagement;

public class SCenechanger : MonoBehaviour
{
    [SerializeField] private GameObject menupanel;

    public void back()
    {
        Application.Quit();
    }

    void offmenu()
    {
        menupanel.SetActive(false);
    }

    public void retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}