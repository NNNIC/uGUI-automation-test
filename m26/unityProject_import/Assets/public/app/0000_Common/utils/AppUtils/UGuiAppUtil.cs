using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UGuiAppUtil : MonoBehaviour {

	public static void setup_imported_ui( Canvas[] templates)
	{
		foreach(var c in templates)
		{
			setup_imported_ui(c);
		}
	}

	public static void setup_imported_ui( Canvas template)
	{
		//子ノードを走査
		for(var i = 0; i<template.transform.childCount; i++)
		{
			var child = template.transform.GetChild(i);
			setup_imported_ui_sprite( child );
			//setup_imported_ui_button( child );
		}
	}
	public static void setup_imported_ui_button( Transform t)
	{
		var list = new List<Button>();
		HierarchyUtility.TraverseComponent<Button>(t, i=>{
			list.Add(i);
		});
		foreach(var i in list)
		{
			var but = ComponentUtil.AddComponentIfNotExist<UIButtonEvent>(i.gameObject);
			i.onClick.AddListener(but.PushDown);
		}
	}
	public static void setup_imported_ui_toggle( Transform t)
	{
		var list = new List<Toggle>();
		HierarchyUtility.TraverseComponent<Toggle>(t, i=>{
			list.Add(i);
		});
		foreach(var i in list)
		{
			var but = ComponentUtil.AddComponentIfNotExist<UIToggleEvent>(i.gameObject);
			i.onValueChanged.AddListener(but.PushDown);
		}
	}
	public static void setup_imported_ui_slider( Transform t)
	{
		var list = new List<Slider>();
		HierarchyUtility.TraverseComponent<Slider>(t, i=>{
			list.Add(i);
		});
		foreach(var i in list)
		{
			var slider = ComponentUtil.AddComponentIfNotExist<UISliderEvent>(i.gameObject);
			i.onValueChanged.AddListener(slider.Change);
		}
	}
	public static void setup_imported_ui_scrollbar( Transform t)
	{
		var list = new List<Scrollbar>();
		HierarchyUtility.TraverseComponent<Scrollbar>(t, i=>{
			list.Add(i);
		});
		foreach(var i in list)
		{
			var scrollbar = ComponentUtil.AddComponentIfNotExist<UIScrollbarEvent>(i.gameObject);
			i.onValueChanged.AddListener(scrollbar.Change);
		}
	}
	public static void setup_imported_ui_inputfield( Transform t)
	{
		var list = new List<InputField>();
		HierarchyUtility.TraverseComponent<InputField>(t, i=>{
			list.Add(i);
		});
		foreach(var i in list)
		{
			var inputfield = ComponentUtil.AddComponentIfNotExist<UIInputFieldEvent>(i.gameObject);
			i.onValueChanged.AddListener(inputfield.Change);
			i.onEndEdit.AddListener(inputfield.End);
		}
	}
	public static void setup_imported_ui_scrollview(Transform t)
	{
		var list = new List<ScrollRect>();
		HierarchyUtility.TraverseComponent<ScrollRect>(t, i=>{
			list.Add(i);
		});
		foreach(var i in list)
		{
			var scrollviewevent = ComponentUtil.AddComponentIfNotExist<UIScrollViewEvent>(i.gameObject);
			i.onValueChanged.AddListener(scrollviewevent.Change);
		}

	}
	

	public static void setup_imported_ui_sprite( Transform t)
	{
		//  *spriteノード検索
		HierarchyUtility.TraverseGameObject(t, i=>{
			//                     012345678
			if (i.name.StartsWith("*sprite="))
			{
				var partsname  = string.Empty;
				var spritename = string.Empty;

				var s = i.name.Substring(8);
				if (!string.IsNullOrEmpty(s))
				{
					var l = s.Split(':');
					if (l.Length>=2)
					{
						partsname = l[0].Trim();
						spritename = l[1].Trim();
					}
				}
				if (string.IsNullOrEmpty(partsname) || string.IsNullOrEmpty(spritename))
				{
					Debug.LogError("Unexpected! {50F74FF0-84C1-444F-9F3A-7390659B591B}");
					return;
				}
				var parent = i.parent;
				if (parent.name != partsname)
				{
					Debug.LogError("Unexpected! {412AC75C-C9E5-4424-9F42-5F610ECA67D8}");
					return;
				}
				var imagecompo = parent.GetComponent<Image>();
				imagecompo.sprite = UISpriteManager.V.GetSprite(spritename);
			}
		}); 
	}
}
