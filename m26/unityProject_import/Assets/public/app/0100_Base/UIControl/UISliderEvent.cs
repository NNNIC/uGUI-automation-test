using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISliderEvent : MonoBehaviour {

	public void Change(float val)
    {
		var slider = GetComponent<Slider>();
        MainStateEvent.Push(MainStateEventId.SLIDER,HierarchyUtility.GetAbsoluteNodePath(gameObject), val);
    }	
}
