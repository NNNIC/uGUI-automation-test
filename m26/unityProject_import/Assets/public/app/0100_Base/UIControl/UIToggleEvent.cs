using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIToggleEvent : MonoBehaviour {


	public void PushDown(bool b)
    {
		var toggle = GetComponent<Toggle>();
        MainStateEvent.Push(MainStateEventId.TOGGLE, HierarchyUtility.GetAbsoluteNodePath(gameObject), b);
    }	


}
