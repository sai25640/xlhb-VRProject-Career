using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerForMars : MonoBehaviour {

    public static GameManagerForMars instance;

    /// <summary>
    /// 游戏倒计时间
    /// </summary>
    public float timer = 3*60;

    /// <summary>
    /// 建筑列表
    /// </summary>
    public GameObject buildList;
   
    void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

    }

    private bool gameIsOver = false;
    void Update()
    {
        if (gameIsOver == true) return;

        timer -= Time.deltaTime;
        if (timer <= 1*60 && timer >0)
        {
            //显示提示1分钟界面
            //UIManagerForDeepSea.instance.ShowOneMinute();

        }
        else if(timer <= 0)
        {
            //显示最后的积分面板
            string score = buildList.GetComponent<BuildList>().ComputeScore();
            UIManagerForMars.instance.ShowScore(score);
            gameIsOver = true;
        }
    }

    public bool GameIsOver()
    {
        return gameIsOver;
    }

}
