using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScrollViewEvent : MonoBehaviour {

	public void Change(Vector2 val)
    {
		var scrollrect = GetComponent<ScrollRect>();
        MainStateEvent.Push(MainStateEventId.SCROLLVIEW,HierarchyUtility.GetAbsoluteNodePath(gameObject), val);
    }	
}
