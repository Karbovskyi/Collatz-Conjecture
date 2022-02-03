using System.Collections.Generic;
using UnityEngine;

public class GraphDrawingAlgorithm : IDrawingAlgorithm
{
    private LineRenderer _lineRendererPrefab;
    private IGraphVerticesGenerator _verticesGenerator;
    private ITransformVerticesIntoVector3Service _intoVector3Service;

    public GraphDrawingAlgorithm(LineRenderer lineRendererPrefab, IGraphVerticesGenerator verticesGenerator, ITransformVerticesIntoVector3Service intoVector3Service)
    {
        _lineRendererPrefab = lineRendererPrefab;
        _verticesGenerator = verticesGenerator;
        _intoVector3Service = intoVector3Service;
    }
    
    public void DrawGraph(int inputData)
    {
        List<int> vertices = _verticesGenerator.GetVertices(inputData);
        Vector3[] verticesInVector3 = _intoVector3Service.IntoVector3(vertices);
        SetPositionsToLineRenderer(verticesInVector3, _lineRendererPrefab);
    }

    public void DrawGraph(int[] inputData)
    {
        foreach (var x in inputData)
            DrawGraph(x);
    }

    private static void SetPositionsToLineRenderer(Vector3[] vertices, LineRenderer lineRendererPrefab)
    {
        LineRenderer lineRenderer = Object.Instantiate(lineRendererPrefab);
        lineRenderer.positionCount = vertices.Length;
        lineRenderer.SetPositions( vertices);
        
    }
}