using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManagerForLogin: MonoBehaviour
{

    public GameObject loginPanel;
    public GameObject selectScenePanel;
    public GameObject operationTipsPanel;

    public void OnLoginButtonClick()
    {
        loginPanel.SetActive(false);
        selectScenePanel.SetActive(true);
    }

    public void OnDeapSeaClick()
    {
        selectScenePanel.SetActive(false);
        operationTipsPanel.SetActive(true);
    }

    public void OnDeapSeaOperationTips()
    {
        SceneManager.LoadScene("DeepSea");
    }

    public void OnSpaceClick()
    {
        SceneManager.LoadScene("Space");
    }
}
