using UnityEngine;

namespace DevDunk.RSUVTools
{
    public static class RSUVHelper
    {
        public static uint GetRSUV(MeshRenderer renderer)
        {
            return renderer.GetShaderUserValue();
        }

        public static uint GetRSUV(SkinnedMeshRenderer renderer)
        {
            return renderer.GetShaderUserValue();
        }

        public static void SetRSUV(MeshRenderer renderer, uint RSUV)
        {
            renderer.SetShaderUserValue(RSUV);
        }

        public static void SetRSUV(SkinnedMeshRenderer renderer, uint RSUV)
        {
            renderer.SetShaderUserValue(RSUV);
        }

        public static uint PackColor(Color color)
        {
            Color32 colorb = color;
            return (uint)colorb.r | ((uint)colorb.g << 8) | ((uint)colorb.b << 16);
        }

        public static uint PackColor(Color32 color)
        {
            return (uint)color.r | ((uint)color.g << 8) | ((uint)color.b << 16);
        }
    }
}