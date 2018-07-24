using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentUtil {

	public static T AddComponentIfNotExist<T>(GameObject go) where T : Component
	{
		var compo = go.GetComponent<T>();
		if (compo==null)
		{
			return go.AddComponent<T>();
		}
		return compo;
	}

}
