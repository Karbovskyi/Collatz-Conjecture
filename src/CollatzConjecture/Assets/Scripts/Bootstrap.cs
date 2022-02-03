using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private LineRenderer _lineRenderer;
    [SerializeField] private InputField _inputFieldNumberA;
    [SerializeField] private InputField _inputFieldNumberB;

    private IDrawingAlgorithm drawingAlgorithm;
    private IGetRange _numbersInput;
    
    void Start()
    {
        IFormula formula = new CollatzConjectureFormula();
        IGraphVerticesGenerator verticesGenerator = new GraphVerticesGenerator(formula);
        ITransformVerticesIntoVector3Service intoVector3Service = new TransformVerticesIntoVector3Service();
        _numbersInput = new NumbersInput(_inputFieldNumberA, _inputFieldNumberB);
        drawingAlgorithm = new GraphDrawingAlgorithm(_lineRenderer, verticesGenerator, intoVector3Service);
    }
    
    public void DrawGraphButton()
    {
        (int, int) range = _numbersInput.GetRange();
        
        for (int i = range.Item1; i <= range.Item2; i++)
            drawingAlgorithm.DrawGraph(i);
    }
}