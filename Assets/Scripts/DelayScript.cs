using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class DelayScript : MonoBehaviour {
	private Queue myQ;

	public DelayScript() {
		this.myQ = new Queue();

	}	

	void OnRenderImage(RenderTexture src, RenderTexture dest) {
		if (src.IsCreated()) {
			Debug.Log ("Source");
		}
		RenderTexture temporary = RenderTexture.GetTemporary (src.width, src.height);
		if (temporary.IsCreated ()) {
			Debug.Log ("Delay");
			myQ.Enqueue (temporary);
		} else {
			myQ.Enqueue (src);
		}
		if (myQ.Count == 80) {
			src = (RenderTexture)myQ.Dequeue ();
			Graphics.Blit(src,dest);
		} 
	}
}
