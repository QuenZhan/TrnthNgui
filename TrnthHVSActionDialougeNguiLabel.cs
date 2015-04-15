using UnityEngine;
using System.Collections;

public class TrnthHVSActionDialougeNguiLabel : TrnthHVSAction {
	public TrnthDialogueManager dialogueManager;
	public UILabel label;
	protected override void _execute(){
		base._execute();
		label.text=dialogueManager.dialogue.text;
	}
}
