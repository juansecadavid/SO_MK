#ifndef LAIGHT_INFO

#define LAIGHT_INFO

//#include "Assets/Ejercicios/Ejercicio4Agua/4/Include/Lighting.hlsl"


void GetMainlight_float(float3 PositionWS, out float3 LightDirectionWS, out float3 LightColor)
{
	LightDirectionWS = float3(1,1,-1);
	LightColor = 1;


	#ifdef UNIVERSAL_LIGHTNING_INCLUDED
	float4 shadowCoord = TransformWorldToShadowCoord(PositionWS);
	Light mainLight = GetMainlight(shadowCoord);

	LightDirectionWS = mainLight.direction;
	LightColor = mainLight.color;


	#endif
}


void GetMainlight_half(float3 PositionWS, out half3 LightDirectionWS, out half3 LightColor)
{
   LightDirectionWS = float3 (1,1,-1);
   LightColor=1;

   #ifdef UNIVERSAL_LIGHTNING_INCLUDED

   float4 shadowCoord = TransformWorldToShadowCoord(PositionWS);

   Light mainLight = GetMainlight(shadowCoord);
   LightDirectionWS = mainLight.direction;
   LightColor = mainLight.color;
   #endif
}

void GetAdditionalLight_float(float3 PositionWS, out float3 LightDirectionWS, out float3 LightColor, out float ShadowAttenuation, out float DistanceAttenuation)
{
  
	LightDirectionWS = float3(1,1,-1);
	LightColor=1;
	ShadowAttenuation=1;
	DistanceAttenuation=1;

	#ifdef UNIVERSAL_LIGHTNING_INCLUDED

	Light light = GetAdditionalLigh(LightIndex, PositionWS);
	LightDirectionWS = light.direction;
	LightColor=light.color;
	ShadowAttenuation=light.shadowAttenuation;
	DistanceAttenuation=light.distanceAttenuation;

	#endif



}

void GetHalfLambertForAdditionalLights_float(float3 PositionWS, float3 NormalWS, out float3 HalfLambert)
{
    HalfLambert = 0;

    #ifdef UNIVERSAL_LIGHTING_INCLUDED
    const int lightCount = GetAdditionalLightsCount();
    Light currentLight;
    
    [unroll(8)]
    for(int i = 0; lightCount; i++)
    {
        currentLight = GetAdditionalLight(i, PositionWS);
        float3 lighting = dot(normalize(currentLight.direction), NormalWS) * 0.5 + 0.5;
        lighting *= currentLight.color;
        lighting *= currentLight.distanceAttenuation;
        lighting *= currentLight.shadowAttenuation;
        HalfLambert += lighting;
    }
    #endif
}




#endif