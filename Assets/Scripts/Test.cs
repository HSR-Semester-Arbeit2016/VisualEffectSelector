using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class Test : MonoBehaviour {

	public Material mat;
	void OnRenderImage(RenderTexture src, RenderTexture dest) {
		List<RenderTexture> sources = new List<RenderTexture>();
		sources.Add (src);
		if (sources.Count == 5) {
			//Thread.Sleep(2000);
			foreach (RenderTexture element in sources) {
				Graphics.Blit (src, dest, mat);
			}
		}
	}
}
