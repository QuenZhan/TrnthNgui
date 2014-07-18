using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class TrnthProxySlider : TrnthMonoBehaviour {
	// public TrnthRadio radio;
	public UILabel label;
	public UISlider slider;
	public bool floor;
	public float start;
	public float end;
	public float value;
	public void execute(){
		value=Mathf.Lerp(start,end,slider.value);
		// radio.rate=;
		if(floor)value=Mathf.Floor(value);
		label.text=value+"";
	}
	void Update(){
		execute();
	}
}
