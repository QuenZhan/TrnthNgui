using UnityEngine;
using System.Collections;

public class TrnthRadioNguiLabelValue : TrnthRadio {
	public UILabel label;
	void Update(){
		label.text=value+"";
	}
}
