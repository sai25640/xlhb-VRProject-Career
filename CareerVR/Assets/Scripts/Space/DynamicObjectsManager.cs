using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DynamicObjectsManager : MonoBehaviour {

    public Animator mars;//火星动画
    public Animator airship;//宇宙飞船动画


    private AnimatorStateInfo info;//火星动画状态信息
    private bool marsFlag = true;//火星动画是否在运行中
    private float timer = 0;
    public GameObject tip1;
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer >= 22f)
        {
            //播放地震动画
            airship.SetBool("shake", true);
            //tip1.SetActive(true);
        }


        if (timer>=27)
        {
            Debug.Log("MarsStop!");
            //开始切换场景到火星
            SceneManager.LoadScene("Mars");
        }
        //if (!marsFlag) return;  
        ////判断宇宙飞船是否已经到达火星上空
        //info = mars.GetCurrentAnimatorStateInfo(0);
        //if (info.normalizedTime >= 1.0)
        //{
        //    Debug.Log("MarsStop!");
        //    //开始切换场景到火星
        //    SceneManager.LoadScene("Mars");
        //    marsFlag = false;
        //}
    }
}
