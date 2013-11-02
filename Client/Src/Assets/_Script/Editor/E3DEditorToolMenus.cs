using UnityEngine;
using System.Collections;
using UnityEditor;

public class E3D_EditorToolMenus : MonoBehaviour {
//	[MenuItem("Enjoy3D/BakeScene")]
//	static void BakeScene(){
//		GameObject go = GameObject.Find("Directional light");
//		Light dirlight = go.GetComponent<Light>();
//		dirlight.shadows = LightShadows.Soft;
//		SetTreeCross();
//		Lightmapping.BakeAsync();
//	}
//	
//	[MenuItem("Enjoy3D/Set Directional light No Shadow")]
//	static void SetDirLightNoShadow(){
//		GameObject go = GameObject.Find("Directional light");
//		Light dirlight = go.GetComponent<Light>();
//		dirlight.shadows = LightShadows.None;
//	}
	
	[MenuItem("Enjoy3D/ListSceneUsedScripts")]
	static void ListSceneUsedScripts(){
		Object[] objs = Object.FindObjectsOfType(typeof(MonoBehaviour));
		foreach (MonoBehaviour go in objs){
			print(go.GetType().Name+"  "+go.name);
		}
	}
	
	[MenuItem("Enjoy3D/FixCharacterSize")]
	static void FixCharacterSize(){
		if (Selection.activeGameObject == null){
			Debug.LogWarning("you should select a GameObject!");
			return;
		}		
		CharacterController cc = Selection.activeGameObject.GetComponentInChildren<CharacterController>();
		if (cc){
			Bounds b = E3DGameLib.Common.Utils.getGameObjectBounds(Selection.activeGameObject);
           	cc.height = b.size.y - 0.16f;
           	cc.center = new Vector3(0f,b.center.y,0f);
		}
	}
	
//	[MenuItem("Enjoy3D/Tree/SetTreeBillBoard")]
//	static void SetTreeBillBoard(){
//		Object[] trs = Object.FindObjectsOfType(typeof(E3D_TreeRuntime));
//		foreach (E3D_TreeRuntime tr in trs){
//			if (tr.transform.GetChildCount()>1){
//				tr.transform.GetChild(0).gameObject.SetActive(true);
//				tr.transform.GetChild(1).gameObject.SetActive(false);
//			}
//		}
//	}
//	
//	[MenuItem("Enjoy3D/Tree/SetTreeCross")]
//	static void SetTreeCross(){
//		Object[] trs = Object.FindObjectsOfType(typeof(E3D_TreeRuntime));
//		foreach (E3D_TreeRuntime tr in trs){
//			if (tr.transform.GetChildCount()>1){
//				tr.transform.GetChild(0).gameObject.SetActive(false);
//				tr.transform.GetChild(1).gameObject.SetActive(true);
//			}
//		}
//	}	
}
