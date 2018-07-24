using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInputFieldEvent : MonoBehaviour {

	public void Change(string val)
    {
		var inputfield = GetComponent<InputField>();
        MainStateEvent.Push(MainStateEventId.INPUTFIELD_CHANGE,HierarchyUtility.GetAbsoluteNodePath(gameObject), val);
    }	
	public void End(string val)
	{
		var inputfield = GetComponent<InputField>();
        MainStateEvent.Push(MainStateEventId.INPUTFIELD_END,HierarchyUtility.GetAbsoluteNodePath(gameObject), val);
	}
}
