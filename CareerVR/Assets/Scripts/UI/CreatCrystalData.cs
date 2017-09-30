using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreatCrystalData : MonoBehaviour {

    public Text text;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    // Use this for initialization
    void Start () {
        //菱锰矿
        text.text = CrystalData.rhodochrositeData + "克";
        //独居石
        text.text = CrystalData.monaziteData + "克";
        //可燃冰
        text.text = CrystalData.combustibleIceData + "克";
        //金属泥
        text.text = CrystalData.metalMudData + "克";
        //锰结核
        text.text = CrystalData.haloboliteData + "克";
        //磁铁矿
        text.text = CrystalData.magnetiteData + "克";
        //萤石
        text.text = CrystalData.fluoriteData + "克";
        //水晶
        text.text = CrystalData.crystalData + "克";

    }
	
}
