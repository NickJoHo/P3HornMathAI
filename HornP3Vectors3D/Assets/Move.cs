using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    void Start() {
        direction = goal.transform.position - transform.position;
        
    }

    private void LateUpdate() {
        this.transform.position = this.transform.position + direction.normalized;
    }
}
