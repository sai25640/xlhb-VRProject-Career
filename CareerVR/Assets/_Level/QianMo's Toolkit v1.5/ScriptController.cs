
//-----------------------------------------------【脚本说明】-------------------------------------------------------
//      脚本功能：   用按键控制脚本的启用与否
//      使用语言：   C#
//      开发所用IDE版本：Unity5.2.1f 、Visual Studio 2013  
//      2014年10月 Created by 浅墨    
//      更多内容或交流，请访问浅墨的博客：http://blog.csdn.net/poem_qianmo
//---------------------------------------------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;


public class ScriptController : MonoBehaviour 
{
    private ScreenWaterDropEffect curComponet;
	void Start () 
    {
        curComponet = GetComponent<ScreenWaterDropEffect>();
	}
	
	void Update () 
    {
         if(Input.GetKeyUp(KeyCode.F))
        {
            curComponet.enabled = !curComponet.enabled;
        }
     }
}
