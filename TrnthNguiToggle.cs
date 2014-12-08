using UnityEngine;
using System.Collections;

public class TrnthNguiToggle : MonoBehaviour {
	public UIToggle toggle;
	public GameObject targetSync;
	public void execture(){
		targetSync.SetActive(toggle.value);
	} 
}
