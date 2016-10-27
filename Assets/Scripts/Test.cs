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
		RenderTexture temporary = RenderTexture.GetTemporary (src.width, src.height);


		if (temporary.IsCreated ()) {
			Debug.Log ("Yuhi ");
			myQ.Enqueue (temporary);
		} else {myQ.Enqueue (src);
		}

	//gettmporary schauen


		if (myQ.Count == 80) {
			
			src = (RenderTexture)myQ.Dequeue ();
			Graphics.Blit(src,dest);
		} else {
			//	Graphics.Blit(src,dest);
		}

	}
}
