using System.Collections.Generic;

public class GraphVerticesGenerator : IGraphVerticesGenerator
{
    private IFormula _formula;

    public GraphVerticesGenerator(IFormula formula)
    {
        _formula = formula;
    }
    
    public List<int> GetVertices(int inputData)
    {
        int vertice = inputData;
        List<int> vertices = new List<int>();
        vertices.Add(vertice);

        while (vertice != 1)
        {
            vertice = _formula.Calculate(vertice);
            vertices.Add(vertice);
        }

        return vertices;
    }
}