using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    public int InputData;
    public LineRenderer LineRendererPrefab;
    void Start()
    {
        IFormula formula = new CollatzConjectureFormula();
        IGraphVerticesGenerator verticesGenerator = new GraphVerticesGenerator(formula);
        ITransformVerticesIntoVector3Service intoVector3Service = new TransformVerticesIntoVector3Service();
        IDrawingAlgorithm drawingAlgorithm = new GraphDrawingAlgorithm(LineRendererPrefab, verticesGenerator, intoVector3Service);
        
        drawingAlgorithm.DrawGraph(InputData);
    }
}