using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public static string userName;
    [SerializeField] private TMP_InputField inputField;


    // Start is called before the first frame update
    void Start()
    {
        if(inputField != null && userName != null)
        {
            inputField.text = userName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        userName = inputField.text;
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();

        #else
            Application.Quit();
        #endif
    }
}
