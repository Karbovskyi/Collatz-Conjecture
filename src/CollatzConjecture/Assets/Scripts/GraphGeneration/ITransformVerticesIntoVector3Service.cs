using System.Collections.Generic;
using UnityEngine;

public interface ITransformVerticesIntoVector3Service
{
    public Vector3[] IntoVector3(List<int> vertices);
}