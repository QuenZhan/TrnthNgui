using UnityEngine;
using System.Collections;

public class TrnthQualitySlider : TrnthQuality {
	public UISlider slider;
	public void apply(){
		int index=(int)(slider.value*QualitySettings.names.Length);
		setQuality(index);
	}
	void OnEnable(){
		Debug.Log(QualitySettings.names.Length);
		slider.value=QualitySettings.GetQualityLevel()/(QualitySettings.names.Length-1f);
	}
}
