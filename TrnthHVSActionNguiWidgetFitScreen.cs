using UnityEngine;
using System.Collections;

public class TrnthHVSActionNguiWidgetFitScreen : TrnthHVSAction {
	public UIWidget widget;
	[ContextMenu("execute")]

	protected override void _execute() {
		if(!widget)widget=GetComponent<UIWidget>();
		widget.width=Screen.width;
		widget.height=Screen.height;
	}
}
