using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabaseTester : MonoBehaviour {

	void Start () {
		PrintItemInfo (InventoryItemDatabase.GetItem (0));
		PrintItemInfo (InventoryItemDatabase.GetItem (1));
	}

	void PrintItemInfo (InventoryItemData item) {
		print ("Name: " + item.itemName);
	}

}
