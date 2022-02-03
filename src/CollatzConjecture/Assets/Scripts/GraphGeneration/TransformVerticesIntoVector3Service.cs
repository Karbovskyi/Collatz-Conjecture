using System.Collections.Generic;
using UnityEngine;

public class TransformVerticesIntoVector3Service : ITransformVerticesIntoVector3Service
{
    public Vector3[] IntoVector3(List<int> vertices)
    {
        Vector3[] verticesInVector3 = new Vector3[vertices.Count];
        
        for (var i = 0; i < vertices.Count; i++)
            verticesInVector3[i] = new Vector3(i, vertices[i], 0);

        return verticesInVector3;
    }
}