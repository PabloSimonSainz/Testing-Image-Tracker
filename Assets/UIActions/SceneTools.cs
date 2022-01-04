using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTools : MonoBehaviour
{
    public void LoadScene(string scene)
    {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index, LoadSceneMode.Single);
    }
}
