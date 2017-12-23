﻿using UnityEngine;
using UnityEditor;
using System.Collections;

public class ScriptableObjectCreator {

	[MenuItem ("Assets/Create/Scriptable Object/Inventory Item")]
	static public void CreateInventoryItem () {
		ScriptableObjectUtility.CreateAsset <InventoryItemData> ();
	}

	[MenuItem ("Assets/Create/Scriptable Object/Item Set")]
	static public void CreateItemSet () {
		ScriptableObjectUtility.CreateAsset <ItemSet> ();
	}


}
