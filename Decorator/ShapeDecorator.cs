﻿namespace CMPS253.GoFPatterns.Structural.Decorator
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape decoratedShape;

        public ShapeDecorator(IShape shapeToDecorate)
        {
            this.decoratedShape = shapeToDecorate;
        }
        public virtual void Draw()
        {
            decoratedShape.Draw();
        }
    }
}
