using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManagerForLogin: MonoBehaviour
{

    public GameObject loginPanel;
    public GameObject selectScenePanel;

    public void OnLoginButtonClick()
    {
        loginPanel.SetActive(false);
        selectScenePanel.SetActive(true);
    }

    public void OnDeapSeaClick()
    {
        //Debug.Log(" OnDeapSeaClick!");
        SceneManager.LoadScene("DeepSea");
    }
}
