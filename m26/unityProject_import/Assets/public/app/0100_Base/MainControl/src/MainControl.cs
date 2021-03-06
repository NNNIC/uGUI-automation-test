﻿using System;
using System.IO;

public partial class MainControl  {
		
	// write your code 
    bool base_isready()
    {
        return BaseProcess.V!=null;
    }

    void base_init() {
        BaseProcess.V.ReqStart();
    }

    bool base_init_done()
    {
        return BaseProcess.V.m_state == ProcessState.RUNNING;
    }

    void ui_start() {
        UIControl.V.ReqStart();
    }



	void br_BUT05(Action<bool> st)
    {
        if (!HasNextState())
        {
            var cur = MainStateEvent.Cur();
            if (cur!=null && cur.id == MainStateEventId.BUTTON )
            { 
                var s = RegexUtil.Get1stMatch(@"\/[^\/]+?$",cur.name);
                UnityEngine.Debug.Log(s);
                if (s == "/BUT05")
                {
                    SetNextState(st);
                }
            }
        }
    }

    void disp_error()
    {
        ErrorDlg.V.SetError("test");
    }

}
