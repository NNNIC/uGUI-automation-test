using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UITest01Controlをラップしてコンポネント化
public class UITest01ControlCompo : UIControlCompo {

    public UITest01Control m_sm;

    public Canvas          m_target;

    public Canvas          m_temaplate_base;

    public GameObject      m_add_from_unitypackage; //Unity packageを再ロードしてもリンクが切れないようにするための措置

    [HideInInspector]
    public List<Canvas>    m_templates;

    private void Start()
    {
        m_templates = new List<Canvas>();
        m_templates.Add(m_temaplate_base);

        HierarchyUtility.TraverseComponent<Canvas>(
            m_add_from_unitypackage.transform,
            
            i=>{
                var s= i.ToString();
                Debug.Log(s);
                m_templates.Add(i);
                }
        );

        m_sm = new UITest01Control();
    }

    private void Update()
    {
        if (m_sm!=null) m_sm.update();
    }

    public override void SetTarget_TemplateAndStart()
    {
        m_sm.SetTargetAndTemplate(m_target,m_templates.ToArray());
        m_sm.Start();
    }

    public override bool IsEnd()
    {
        return m_sm.IsEnd();
    }
}
