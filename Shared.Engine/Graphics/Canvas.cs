using Shared.Engine.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Engine.Graphics
{
    public class Canvas : IDisposable
    {
        // <summary> The camera that draws the objects on the camera
        protected readonly Camera _Camera;
        // <summary> the camera that draws objects on canvas
        public Camera Camera => _Camera;

        // <summary> Creates the canvas
        // <params> name= camera
        public Canvas(Camera camera)
        {
            _Camera = camera;
            Renderer.Instance.AddCanvas(this);
        }

        // <summary> Draws the objects on canvas
        public void Draw()
        {
            System.Boolean viewChanged = _Camera.MatrixInvalid;
            if (viewChanged) = _Camera.UpdateViewProjectionMatrix();
        }

        // <summary> Disposes of the canvas
        public void Dispose()
        {
            Renderer.Instance.RemoveCanvas(this);
        }

    }
}
