Shader "Custom/Quad2"
{
    Properties
    {
        _MainTex("Albedo (RGB)", 2D) = "white" {}
        _MainTex2("Albedo (RGB)", 2D) = "white" {}
        _LerpRange("Lerp Range", Range(0, 1)) = 0.5
    }
        SubShader
    {
        // Tags { "RenderType"="Opaque" }
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent" }

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows alpha:fade

        sampler2D _MainTex;
        sampler2D _MainTex2;
        float _LerpRange;

        struct Input
        {
            float2 uv_MainTex;
            float2 uv_MainTex2;
        };

        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            fixed4 d = tex2D(_MainTex2, float2(IN.uv_MainTex2.x, IN.uv_MainTex2.x - _Time.y));
            // o.Albedo = c.rgb;
            //o.Emission = c.rgb;
            //o.Alpha = c.a;
            o.Albedo = lerp(c.rgb, d.rgb, _LerpRange);
            o.Emission = c.rgb * d.rgb;
            o.Alpha = c.a * d.a;
        }
        ENDCG
    }
        FallBack "Diffuse"
}
