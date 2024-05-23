using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0", "WELCOME to our planet!", "1");
        Speech.AddDialogue("1", "HELP ME!", "2");
        Speech.AddDialogue("2", "Monsters attacked US! ", "3");
        Speech.AddDialogue("3", "Find the SUPER jump and go to two planet!");
    }

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){
		Speech.SetDialogue("0");
	}
}