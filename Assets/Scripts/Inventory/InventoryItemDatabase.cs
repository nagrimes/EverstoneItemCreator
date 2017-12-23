using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class InventoryItemDatabase {
	
	private static Dictionary <int, InventoryItemData> items;
	private static bool isDatabaseLoaded = false;

	private static void ValidateDatabase () {
		if (items == null)
			items = new Dictionary<int, InventoryItemData> ();
		if (!isDatabaseLoaded)
			LoadDatabase ();
	}

	public static void LoadDatabase () {
		if (isDatabaseLoaded)
			return;
		isDatabaseLoaded = true;
		LoadDatabaseForce ();
	}

	public static void LoadDatabaseForce () {
		ValidateDatabase ();
		InventoryItemData[] resources = Resources.LoadAll<InventoryItemData>(@"Inventory Items");
		foreach (InventoryItemData item in resources) {
			if (items.ContainsKey (item.itemID)) {
				Debug.Log ("Duplicate item ID detected in the Inventory Item Database!");
				Debug.Log ("[" + item.itemName + "] and [" + items[item.itemID].itemName + "] both have the same item ID value of [" + item.itemID + "].");
			} else {
				items.Add (item.itemID, item);
			}
		}
	}

	public static void ClearDatabase () {
		isDatabaseLoaded = false;
		items.Clear ();
	}

	/// <summary>
	/// Returns the source data for a specific inventory item
	/// </summary>
	public static InventoryItemData GetItem (int itemID) {
		ValidateDatabase ();
		return items[itemID];
	}
}

