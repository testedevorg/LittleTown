using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public string cena_ = "";

    public void ChangeScene(string cena)
    {
        cena_ = cena;
        StartCoroutine(FadeImage());
    }

    public void CloseApp() => StartCoroutine(CloseImage());

    IEnumerator FadeImage()
    {
        Time.timeScale = 1;
        this.gameObject.transform.GetChild(2).GetComponent<Animator>().SetBool("s", true);
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(cena_);
    }

    IEnumerator CloseImage()
    {
        yield return FadeImage();
        Application.Quit();
    }
}
