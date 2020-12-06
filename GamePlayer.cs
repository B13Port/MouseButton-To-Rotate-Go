using UnityEngine;
链接：https://pan.baidu.com/s/11SdbhfqsaRHObVvqw60mRA 
提取码：1234 
复制这段内容后打开百度网盘手机App，操作更方便哦
public class RotateGameobject : MonoBehaviour
{
    private bool onDrag = false;
    public float speed = 6f;
    private float zSpeed;
    private float X;
    private float mXY;

    private void OnMouseDown()
    {
        X = 0f;
    }

    private void OnMouseDrag()
    {
        onDrag = true;
        X = -Input.GetAxis("Mouse X");
        mXY = Mathf.Sqrt(X * X);
        if (mXY == 0f)
        {
            mXY = 1f;
        }
    }

    private float RiSpeed()
    {
        if (onDrag)
        {
            zSpeed = speed;
        }
        else
        {
            zSpeed = 0;
        }
        return zSpeed;
    }

    private void LateUpdate()
    {
        transform.Rotate(new Vector3(0, X, 0) * RiSpeed(), Space.World);
        if (!Input.GetMouseButtonDown(0))
        {
            onDrag = false;
        }
    }
}
