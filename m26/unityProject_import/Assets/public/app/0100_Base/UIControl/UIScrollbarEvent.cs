using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScrollbarEvent : MonoBehaviour {

	public void Change(float val)
    {
		var scrollbar = GetComponent<Scrollbar>();
        MainStateEvent.Push(MainStateEventId.SCROLLBAR,HierarchyUtility.GetAbsoluteNodePath(gameObject), val);
    }	
}
