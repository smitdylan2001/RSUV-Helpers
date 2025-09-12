using UnityEngine;

namespace DevDunk.RSUVTools
{
    [ExecuteInEditMode]
    public class RSUVSetter : MonoBehaviour
    {
        public uint RSUV;
        public Color32 Color;
        public MeshRenderer Renderer;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            if (!Renderer) Renderer = GetComponent<MeshRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            if (!Renderer) Renderer = GetComponent<MeshRenderer>();
            Renderer.SetShaderUserValue(RSUVHelper.PackColor(Color));
        }
    }
}