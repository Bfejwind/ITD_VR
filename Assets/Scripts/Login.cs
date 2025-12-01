using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public TMP_InputField passwordText;
    public string correct = "CA3";
    public GameObject Error;
    public void Awake()
    {
        Error.SetActive(false);
    }
    public void PasswordCheck()
    {
        string password = passwordText.text.ToString();
        if (password != correct)
        {
            StartCoroutine(ErrorMessage());
        }
        else if (password == correct)
        {
            SceneManager.LoadScene("ITD_VR_SCENE");
        }
    }
    IEnumerator ErrorMessage()
    {
        Error.SetActive(true);
        yield return new WaitForSeconds(2);
        Error.SetActive(false);
    }
}
