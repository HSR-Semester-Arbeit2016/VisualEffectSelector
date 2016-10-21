using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class Test : MonoBehaviour {
	
	private Queue myQ;
	public Test() {
		this.myQ = new Queue();

	}	


	void OnRenderImage(RenderTexture src, RenderTexture dest) {
		myQ.Enqueue (src);
	//gettmporary schauen
		if (myQ.Count == 20) {
			
			src = (RenderTexture)myQ.Dequeue ();
			Graphics.Blit(src,dest);
		} else {
			//	Graphics.Blit(src,dest);
		}

	}
}
