namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// Parent class, containes successor,and method for buiding triangles
    /// </summary>
    abstract class Builder
    {
        public Builder Successor { get; set; }

        public abstract Triangle Build(Point p1, Point p2, Point p3);
    }
}
