Shader "Custom/pointshader"
{
    
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface ConfigureSurface Standard fullforwardshadows
        #pragma target 3.0

        struct input{
            float3 worldpos;
        };
        
        void ConfigureSurface (Input input, inout SurfaceOutputStandard surface) {
        
        
        }
        ENDCG
    }
    FallBack "Diffuse"
}
