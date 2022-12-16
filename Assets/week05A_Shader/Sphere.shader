Shader "My/Sphere"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _MainTex2("Albedo (RGB" , 2D) = "white" {}
        _LerpRange("Lerp Range", Range(0, 1)) = 0.5
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        sampler2D _MainTex;
        sampler2D _MainTex2;
        float _LerpRange;
        
        struct Input
        {
            float2 uv_MainTex;
            float2 uv_MainTex2;
        };


        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            fixed4 d = tex2D(_MainTex2, IN.uv_MainTex2);
            //o.Albedo = c.rgb;
            o.Albedo = lerp(c.rgb, d.rgb, _LerpRange);
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
