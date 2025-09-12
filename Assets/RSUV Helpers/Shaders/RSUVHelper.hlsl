uint GetRSUV()
{
    return unity_RendererUserValue;
}

void GetRSUV_float(out uint RSUV)
{
    RSUV = GetRSUV();
}

void GetRSUV_half(out uint RSUV)
{
    RSUV = GetRSUV();
}

void UnpackColor_float(in uint rsuv, out half3 Color)
{
    Color = half3(rsuv & 0xFF, (rsuv >> 8) & 0xFF, (rsuv >> 16) & 0xFF) / 255;
}

void UnpackColor_half(in uint rsuv, out half3 Color)
{
    Color = half3(rsuv & 0xFF, (rsuv >> 8) & 0xFF, (rsuv >> 16) & 0xFF) / 255;
}


