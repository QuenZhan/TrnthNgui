﻿using UnityEngine;
using System.Collections;

public class TrnthRadioNguiLabelValue : TrnthRadio {
	public UILabel label;
	void Update(){
		if(!label){
			Debug.Log("if(!label)",transform);
			return;
		}
		label.text=value+"";
	}
}
