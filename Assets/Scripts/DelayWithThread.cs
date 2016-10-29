using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class DelayWithThread : MonoBehaviour {	

	void OnRenderImage(RenderTexture src, RenderTexture dest) {
		if (src.IsCreated()) {
			Debug.Log ("Source");
		}
		RenderTexture temporary = RenderTexture.GetTemporary (src.width, src.height);
		Graphics.Blit (src , temporary);
		Thread.Sleep (200);
		Graphics.Blit(temporary,dest);
	}
}
