using UnityEngine;
using System.Collections;

public class BtnAdventureClick : MonoBehaviour {
	public GameObject pnlAdventures;
	void OnClick(){
		pnlAdventures.SetActive(!pnlAdventures.activeSelf);
	}
}
