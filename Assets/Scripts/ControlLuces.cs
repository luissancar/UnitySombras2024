
using System;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class ControlLuces : MonoBehaviour
{
   public Image imagen;

   [SerializeField] private GameObject onGameObject;
   [SerializeField] private GameObject offGameObject;

   public GameObject[] luces;

   [SerializeField] private bool sombras = true;

   private void Start()
   {
      luces = GameObject.FindGameObjectsWithTag("luz");
      SombrasOnOff();

   }


   public void SombrasOnOff()
   {
      sombras = !sombras; 
      foreach (GameObject luz in luces)
      {
         if (sombras)
         {
            onGameObject.SetActive(true);
            offGameObject.SetActive(false);
            luz.GetComponent<Light>().shadows = LightShadows.Soft;
         }
         else
         {
            onGameObject.SetActive(false);
            offGameObject.SetActive(true);
            luz.GetComponent<Light>().shadows = LightShadows.None;
         }
      }
   }

   public void Alta()
   {
      foreach (GameObject luz in luces)
      {
         if (sombras)
         {
            luz.GetComponent<Light>().shadowResolution = UnityEngine.Rendering.LightShadowResolution.High;
         }
         
      }
   }
   
   
   public void Baja()
   {
      foreach (GameObject luz in luces)
      {
         if (sombras)
         {
            
            luz.GetComponent<Light>().shadowResolution = UnityEngine.Rendering.LightShadowResolution.Low;
         }
         
      }
   }
}
