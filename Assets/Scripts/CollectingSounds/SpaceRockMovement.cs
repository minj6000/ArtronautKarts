using DG.Tweening;
using UnityEngine;
public class SpaceRockMovement : MonoBehaviour
{

    public float speed;
    private bool scalingon;

    public float ScalingTime = 15;
    public float ScalingRange;
    // Start is called before the first frame update
    void Start()
    {

        ScalingRange = Random.Range(2.5f, 3.5f);
        scalingon = true;
        ScalingTime = Random.Range(7, 15);

    }

    // Update is called once per frame
    void Update()
    {
        transform.DORotate(new Vector3(0, -360, 0), speed, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
        this.transform.DOScale(ScalingRange, 5f).SetLoops(-1);
    }

}
