using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshBacker : MonoBehaviour {

    public MeshFilter Filter;

	// Use this for initialization
	void Start () {
        
	}

    [ContextMenu("DO")]
    public void Do()
    {
        Vector3[] vertices = Filter.sharedMesh.vertices;
    }
}
