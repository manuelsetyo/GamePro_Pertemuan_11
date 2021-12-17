using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionPlayerObjek : MonoBehaviour
{
    public Text teksScore;

    int score = 0;

    void OnCollisionEnter(Collision coll) {
        if (coll.collider.tag == "Enemy") {
            score++;
            teksScore.text = "Score = " + score.ToString();
            Destroy (coll.gameObject);
        }
    }
}
