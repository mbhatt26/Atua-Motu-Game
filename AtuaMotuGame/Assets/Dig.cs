using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dig : MonoBehaviour
{

    public float digRadius = 0.8f;

    public GameObject digPrefab;

    public LayerMask diggable;

    public GameObject DigResult;

    public GameObject textObj;

    public int digs = 10;

    public int currentDigs;

    public GameObject digText; 

    // Start is called before the first frame update
    void Start()
    {
        currentDigs = digs;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            currentDigs--;
            Collider2D item = Physics2D.OverlapCircle(this.transform.position, digRadius, diggable);
            DigResult.SetActive(true);
            if (item == null)
            { 
                textObj.gameObject.GetComponent<TMP_Text>().text = "No Item Found";
            } else if (item.gameObject.name == "Item")
            {
                Debug.Log("Found");
                textObj.gameObject.GetComponent<TMP_Text>().text = "Item ____ Found";
                Destroy(item.gameObject);
                //add item here;
            }

            Instantiate(digPrefab, this.transform.position, digPrefab.transform.rotation);
        }
        updateDigs();
    }

    void updateDigs()
    {
        digText.gameObject.GetComponent<TMP_Text>().text = "Shovel Durability: " + currentDigs.ToString(); 
    }

}