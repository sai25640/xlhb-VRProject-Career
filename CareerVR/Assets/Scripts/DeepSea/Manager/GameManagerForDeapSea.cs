using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerForDeapSea : MonoBehaviour {

    public static  GameManagerForDeapSea instance;

    /// <summary>
    /// 游戏倒计时间
    /// </summary>
    public float timer = 3*60;

    /// <summary>
    /// 最终积分
    /// </summary>
    public int score;
   
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


    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 1*60 && timer >0)
        {
            //显示提示1分钟界面
            UIManager.Instance.ShowOneMinute();

        }
        else if(timer <= 0)
        {
            //显示最后的积分面板
            ComputeScore();
            UIManager.Instance.ShowScore(score);
        }
    }

    /// <summary>
    /// 计算最后总分
    /// </summary>
    void ComputeScore()
    {
        score = CrystalData.rhodochrositeData + CrystalData.monaziteData + CrystalData.combustibleIceData + CrystalData.metalMudData + CrystalData.haloboliteData + CrystalData.magnetiteData + CrystalData.fluoriteData + CrystalData.crystalData;
        score *= 100;
    }
}
