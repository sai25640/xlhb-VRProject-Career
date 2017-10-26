using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildList : MonoBehaviour {

    int m_ilivingCenter = 0;
    int m_iRecyclingPlant = 0;
    int m_iComms = 0;
    int m_iAirlock = 0;
    int m_iSolarEnergyArray = 0;
    int m_iHeadquater = 0;
    int m_iBiodome = 0;
    int m_iCorridor = 0;

    /// <summary>
    /// 统计总分
    /// </summary>
    int TotalPoints()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            string tag = this.transform.GetChild(i).tag;
            switch (tag)
            {
                case "LivingCenter": m_ilivingCenter++; break;
                case "RecyclingPlant": m_iRecyclingPlant++; break;
                case "Comms": m_iComms++; break;
                case "Airlock": m_iAirlock++; break;
                case "SolarEnergyArray": m_iSolarEnergyArray++; break;
                case "Headquater": m_iHeadquater++; break;
                case "Biodome": m_iBiodome++; break;
                case "Corridor": m_iCorridor++; break;
            }
        }
        
        return m_ilivingCenter + m_iRecyclingPlant + m_iComms + m_iAirlock + m_iSolarEnergyArray + m_iHeadquater + m_iBiodome + m_iCorridor;
    }
    
    /// <summary>
    /// 比较太阳能、人体工程、循环总数谁比较多
    /// </summary>
    /// <returns></returns>
    string Compare()
    {
        string result = "";
        if (m_iSolarEnergyArray > m_ilivingCenter + m_iRecyclingPlant)
        {
            result = "Solarexpert";
        }
        else if (m_ilivingCenter > m_iSolarEnergyArray + m_iRecyclingPlant)
        {
            result = "Humanengineering";
        }
        else if (m_iRecyclingPlant > m_ilivingCenter + m_iSolarEnergyArray)
        {
            result = "Circulation";
        }
        Debug.Log("CompareResult =" + result);
        return result;
    }

    /// <summary>
    /// 计算最终结果
    /// </summary>
    /// <returns>返回关键字</returns>
    public string ComputeScore()
    {
        string keyStr = "";
        int points = TotalPoints();
        Debug.Log("TotalPoints =" + points);
        if (points <= 0)
        {
            keyStr = "Architect";
        }
        else if (points >0 && points < 10)
        {
            keyStr = "Counselor";
        }
        else if(points >= 10 )
        {
            keyStr = "Planner";
        }

        string result = Compare();
        if (result != "")
            keyStr = result;

        Debug.Log("ComputeScore =" + keyStr);
        return keyStr;
    }
}
