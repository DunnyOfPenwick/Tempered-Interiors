// Project:     Tempered Interiors for Daggerfall Unity
// Author:      DunnyOfPenwick
// Origin Date: October 2022

using UnityEngine;
using DaggerfallWorkshop;


namespace TemperedInteriors
{
    public enum Textures
    {
        BedEndHi,
        BedEndLow,
        BedSideHi,
        BedSideLow,
        BedTopHi,
        BedTopLow,
        WardrobeFrontHi,
        WardrobeFrontEdgeHi,
        WardrobeSideEdgeHi,
        WardrobeSideHi,
        DoorHi,
        CarpetLow,
        CarpetEdgeLow1,
        CarpetEdgeLow2,
        TapestryLow,
        Cord,
        Chain,
        Stain,
        FoodBit

    } //enum Textures


    public static class TexturesExtension
    {
        /// <summary>
        /// </summary>
        public static Texture2D Get(this Textures key)
        {
            Texture2D texture = TemperedInteriorsMod.Mod.GetAsset<Texture2D>(key.ToString());
            if (texture == null)
                Debug.LogErrorFormat("Tempered Interiors Error: unable to find mod texture '{0}'", key.ToString());
            else
                texture.filterMode = DaggerfallUnity.Instance.MaterialReader.MainFilterMode;
            
            return texture;
        }


    } //class TextExtension



} //namespace
