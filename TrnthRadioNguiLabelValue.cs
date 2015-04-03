using UnityEngine;
using System.Collections;

public class TrnthRadioNguiLabelValue : TrnthRadio {
	public UILabel label;
	void Update(){
		if(!label){
			enabled=false;
			return;
		}
		label.text=value+"";
	}
}
