using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnlightning : MonoBehaviour
{
    public Camera Playercamera;
    public GameObject LightningPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            Ray targetLocationRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitData;
            if (Physics.Raycast(targetLocationRay, out hitData))
            {

                GameObject lightningClone = Instantiate(LightningPrefab, hitData.point, Quaternion.identity);
                lightningClone.transform.position += new Vector3(0, 1.75f, 0);

                Destroy(lightningClone, 1f);
            }
        }   
    }
}
