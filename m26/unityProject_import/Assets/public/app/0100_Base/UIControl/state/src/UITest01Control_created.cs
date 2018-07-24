// psggConverterLib.dll converted from UITest01Control.xlsx. 
public partial class UITest01Control : StateManager {

    public void Start()
    {
        Goto(S_START);
    }


    /*
        S_START
        開始
    */
    void S_START(bool bFirst)
    {
        if (bFirst)
        {
        }
        if (!HasNextState())
        {
            SetNextState(S_SETUP);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_END
        終了
    */
    void S_END(bool bFirst)
    {
        if (bFirst)
        {
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_SETUP
        set up
    */
    void S_SETUP(bool bFirst)
    {
        if (bFirst)
        {
            setup();
        }
        if (!HasNextState())
        {
            SetNextState(S_SETUP_IMPORTED_UI);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_BUT01
        button 01 作成
    */
    void S_BUT01(bool bFirst)
    {
        if (bFirst)
        {
            create("BUT01","Button");
            set_anchor("TC");
            set_pivot("MC");
            set_size(200,50);
            set_pos(0,-100);
            set_text("BUT01");
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_BUT02);
        }
        if (HasNextState())
        {
                NoWait();
            GoNextState();
        }
    }
    /*
        S_BUT02
        button 02 作成
    */
    void S_BUT02(bool bFirst)
    {
        if (bFirst)
        {
            create("BUT02","Button");
            set_anchor("TC");
            set_pivot("MC");
            set_size(200,50);
            set_pos(0,-200);
            set_text("BUT02");
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_BUT03);
        }
        if (HasNextState())
        {
                NoWait();
            GoNextState();
        }
    }
    /*
        S_BUT03
        button 03 作成
    */
    void S_BUT03(bool bFirst)
    {
        if (bFirst)
        {
            create("BUT03","Button");
            set_anchor("TC");
            set_pivot("MC");
            set_size(200,50);
            set_pos(0,-300);
            set_text("BUT03");
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_BUT04);
        }
        if (HasNextState())
        {
                NoWait();
            GoNextState();
        }
    }
    /*
        S_BUT04
        button 03 作成
    */
    void S_BUT04(bool bFirst)
    {
        if (bFirst)
        {
            create("BUT04","Button");
            set_anchor("TC");
            set_pivot("MC");
            set_size(200,50);
            set_pos(0,-400);
            set_text("BUT04");
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_BUT05);
        }
        if (HasNextState())
        {
                NoWait();
            GoNextState();
        }
    }
    /*
        S_CREATE_PANEL_CENTER
        中央パネルを作成する
    */
    void S_CREATE_PANEL_CENTER(bool bFirst)
    {
        if (bFirst)
        {
            create("PNL_CTR","Panel");
            set_anchor("MC");
            set_pivot("MC");
            set_size(640,1136);
            set_pos(0,0);
        }
        set_parent();
        if (!HasNextState())
        {
            SetNextState(S_BUT01);
        }
        if (HasNextState())
        {
                NoWait();
            GoNextState();
        }
    }
    /*
        S_BUT05
        button 05 作成
    */
    void S_BUT05(bool bFirst)
    {
        if (bFirst)
        {
            create("BUT05","Button");
            set_anchor("TC");
            set_pivot("MC");
            set_size(200,50);
            set_pos(0,-500);
            set_text("BUT05");
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_END);
        }
        if (HasNextState())
        {
                NoWait();
            GoNextState();
        }
    }
    /*
        S_BUT_C
        button C 作成
    */
    void S_BUT_C(bool bFirst)
    {
        if (bFirst)
        {
            create("BUT_C","Button_T1");
            set_anchor("TC");
            set_pivot("MC");
            set_size(64,64);
            set_pos(0,-30);
            set_text_clr();
            set_sprite("m_C");
        }
        if (!HasNextState())
        {
            SetNextState(S_BUT_D);
        }
        if (HasNextState())
        {
                NoWait();
            GoNextState();
        }
    }
    /*
        S_BUT_D
        button D 作成
    */
    void S_BUT_D(bool bFirst)
    {
        if (bFirst)
        {
            create("BUT_D","Button_T1");
            set_anchor("TC");
            set_pivot("MC");
            set_size(64,64);
            set_pos(64,-30);
            set_text_clr();
            set_sprite("m_D");
        }
        if (!HasNextState())
        {
            SetNextState(S_BUT_E);
        }
        if (HasNextState())
        {
                NoWait();
            GoNextState();
        }
    }
    /*
        S_BUT_B
        button B 作成
    */
    void S_BUT_B(bool bFirst)
    {
        if (bFirst)
        {
            create("BUT_B","Button_T1");
            set_anchor("TC");
            set_pivot("MC");
            set_size(64,64);
            set_pos(-64,-30);
            set_text_clr();
            set_sprite("m_B");
        }
        if (!HasNextState())
        {
            SetNextState(S_BUT_C);
        }
        if (HasNextState())
        {
                NoWait();
            GoNextState();
        }
    }
    /*
        S_BUT_A
        button A 作成
    */
    void S_BUT_A(bool bFirst)
    {
        if (bFirst)
        {
            create("BUT_A","Button_T1");
            set_anchor("TC");
            set_pivot("MC");
            set_size(64,64);
            set_pos(-128,-30);
            set_text_clr();
            set_sprite("m_A");
        }
        if (!HasNextState())
        {
            SetNextState(S_BUT_B);
        }
        if (HasNextState())
        {
                NoWait();
            GoNextState();
        }
    }
    /*
        S_BUT_E
        button E 作成
    */
    void S_BUT_E(bool bFirst)
    {
        if (bFirst)
        {
            create("BUT_E","Button_T1");
            set_anchor("TC");
            set_pivot("MC");
            set_size(64,64);
            set_pos(128,-30);
            set_text_clr();
            set_sprite("m_E");
        }
        if (HasNextState())
        {
                NoWait();
            GoNextState();
        }
    }
    /*
        S_SETUP_IMPORTED_UI
        インポートされたUIをセットアップ
    */
    void S_SETUP_IMPORTED_UI(bool bFirst)
    {
        if (bFirst)
        {
            setup_imported_ui();
        }
        if (!HasNextState())
        {
            SetNextState(S_CREATE_PANEL_CENTER);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_BUTTON_A
        BUTTON A
    */
    void S_BUTTON_A(bool bFirst)
    {
        if (bFirst)
        {
            create("BUTTON_A","Button_A");
            set_anchor("MC");
            set_pivot("MC");
            set_pos(0,64);
            set_text_clr();
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_BUTTON_B);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_BUTTON_B
        BUTTON B
    */
    void S_BUTTON_B(bool bFirst)
    {
        if (bFirst)
        {
            create("BUTTON_B","Button_B");
            set_anchor("MC");
            set_pivot("MC");
            set_pos(0,-64);
            set_text_clr();
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_BUTTON_C);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_BUTTON_C
        BUTTON C
    */
    void S_BUTTON_C(bool bFirst)
    {
        if (bFirst)
        {
            create("BUTTON_C","Button_C");
            set_anchor("MC");
            set_pivot("MC");
            set_pos(0,-192);
            set_text_clr();
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_SCROLLBAR);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_TOGGLE_A
        Toggle A
    */
    void S_TOGGLE_A(bool bFirst)
    {
        if (bFirst)
        {
            create("TOGGLE_A","Toggle");
            set_anchor("MC");
            set_pivot("ML");
            set_pos(-300,0);
            set_text("TOGGLE A");
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_TOGGLE_B);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_TOGGLE_B
        Toggle B
    */
    void S_TOGGLE_B(bool bFirst)
    {
        if (bFirst)
        {
            create("TOGGLE_B","Toggle");
            set_anchor("MC");
            set_pivot("ML");
            set_pos(-150,0);
            set_text("TOGGLE B");
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_SLIDER_A);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_SLIDER_A
        Slider A
    */
    void S_SLIDER_A(bool bFirst)
    {
        if (bFirst)
        {
            create("SLIDER_A","Slider");
            set_anchor("MC");
            set_pivot("MR");
            set_pos(300,0);
            set_text("SLIDER A");
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_END);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_SCROLLBAR
        Scrollbar A
    */
    void S_SCROLLBAR(bool bFirst)
    {
        if (bFirst)
        {
            create("SCROLLBAR_A","Scrollbar");
            set_anchor("MC");
            set_pivot("MR");
            set_pos(300,0);
            set_text("SCROLLBAR");
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_END);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_INPUTFIELD
        Input field
    */
    void S_INPUTFIELD(bool bFirst)
    {
        if (bFirst)
        {
            create("INPUTFIELD_A","InputField");
            set_anchor("MC");
            set_pivot("MR");
            set_pos(300,0);
            set_text("INPUTFIELD");
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_END);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_SCROLL_VIEW
        Scroll view
    */
    void S_SCROLL_VIEW(bool bFirst)
    {
        if (bFirst)
        {
            create("SCROLLVIIEW_A","Scroll View");
            set_anchor("MC");
            set_pivot("MR");
            set_pos(300,0);
            set_text("Scroll View");
            set_event();
        }
        if (!HasNextState())
        {
            SetNextState(S_END);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }

}

