using UnityEngine;
using System.Collections;

public class TrnthRandomAlphaWidget : MonoBehaviour {
	public UIWidget widget;
	public float value;
	public float noise;
	public void execute(){
		widget.alpha=value+Random.value*noise;
	}
	void OnEnable () {
		execute();
	}
}
