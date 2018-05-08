using OpenTK;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Engine.Graphics
{
    public class Camera
    {
        // <summary> Position of camera
        protected Vector2 _Position;
        // <summary> Dimensions of camera viewport
        protected Vector2 _Dimensions;
        // <summary> View matrix for camera
        protected Matrix4 _ViewMatrix;
        // <summary> projection matricx for camera
        protected Matrix4 _ProjectionMatrix;
        // <summary> View projection for camera
        protected Matrix4 _ViewProjectionMatrix;

        // <summary> Whether or not view projection is invalid
        public Boolean MatrixInvalid { get; protected set; }

        public Vector2 Position
        {
            get { return _Position; }
            set { _Position = value;
                MatrixInvalid = true;
            }
        }

        // <summary> The view projection for camera
        public Matrix4 viewProjectionMatrix => _ViewProjectionMatrix;

        public Camera(Vector2 position, Vector2 dimensions)
        {
            _Dimensions = dimensions;
            _Position = position;
            _ProjectionMatrix = Matrix4.CreateOrthographic(_Dimensions.X, _Dimensions.Y, 1, 1000);
            UpdateViewProjectionMatrix();
        }

        // <summary> Updates view projection matrix when somethin has changed
        public virtual void UpdateViewProjectionMatrix()
        {
            _ViewProjectionMatrix = Matrix4.Identity;
            _ViewMatrix = Matrix4.LookAt(new Vector3(_Position.X, _Position.Y, 1), new Vector3(_Position.X, _Position.Y, 0), new Vector3(0, 1, 0));
            _ViewProjectionMatrix = Matrix4.Mult(_ViewMatrix, _ProjectionMatrix);
            MatrixInvalid = false;
        }
    }
}
