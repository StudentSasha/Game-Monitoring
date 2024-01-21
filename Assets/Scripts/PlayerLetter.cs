using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLetter : MonoBehaviour
{
    [SerializeField] private string[] tagsToCollideWith;
    //[SerializeField] private GameObject[] sprites;
    [SerializeField] private Dictionary<string, GameObject> spriteDict;

    [SerializeField] private int Sphere = 33;
    [SerializeField] private int CurrentSphere = 0;
    


    [SerializeField] private BatchPrefabCreate batchPrefabCreate;
    [SerializeField] private GameObject _futeDoorFinal;

    [SerializeField] private AudioSource SoundLitter;
    [SerializeField] private AudioSource SoundFinal;
    
    //[SerializeField] private Menu Menu;



    void Start()
    {

        spriteDict = new Dictionary<string, GameObject>();
        //for (int i = 0; i < sprites.Length; i++)
        //{
            //spriteDict.Add(tagsToCollideWith[i], sprites[i]);

        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        foreach (string tag in tagsToCollideWith)
        {
            if (other.gameObject.CompareTag(tag))
            {
                CurrentSphere++;
                SoundLitter.Play();
                
                batchPrefabCreate.Create();
                
                Destroy(other.gameObject);

                Debug.Log("Удален очередной объект");

                if (spriteDict.ContainsKey(tag))
                {
                    GameObject sprites = spriteDict[tag];
                    GetComponent<CanvasRenderer>().cull = gameObject;
                    sprites.SetActive(true);                  
                    Destroy(sprites, 2);
                }
                if (Sphere == CurrentSphere)
                {
                    DisplayMessage();
                }
            }
        }
    }

    public void DisplayMessage()
    {
        _futeDoorFinal.SetActive(true);
        SoundFinal.Play(); 
        
    }
}
