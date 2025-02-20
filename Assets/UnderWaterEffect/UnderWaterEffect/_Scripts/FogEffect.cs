﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class FogEffect : MonoBehaviour
{
    public Material _mat;
    public Color fogColor;
    public float depthStart = -12;
    public float depthDistance = 98;

    // Start is called before the first frame update
    public void Start()
    {
        //GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
    }

    // Update is called once per frame
    public void fixed_Update()
    {
       _mat.SetColor("_FogColor", fogColor);
       _mat.SetFloat("_DepthStart", depthStart);
       _mat.SetFloat("_DepthDistance", depthDistance);
    }

    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, _mat);
    }
}
