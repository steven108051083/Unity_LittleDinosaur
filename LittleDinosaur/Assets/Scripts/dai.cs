using UnityEngine;
/// <summary>
///  ��� : 2D ��V���b����
/// </summary>

public class dai : MonoBehaviour
{
    #region ��� : ���}
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 1500)]
    public float jump = 500;
    [Header("�ˬd�a�O�ؤo�P�첾"), Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("���D����P�i���D�ϼh")]
    public KeyCode keyJump = KeyCode.Space;
    public LayerMask canJumpLayer;
    #endregion
    /// <summary>
    ///  ���餸��
    /// </summary>
    private Rigidbody2D rig;

    /// <summary>
    ///  ø�s�ϥ�
    ///  �b Unity ø�s���U�Ϊ��ϥ�
    ///  �u���B�g�u�B��ΡB��ΡB���ΡB�Ϥ�
    /// </summary>
    private void OnDrawGizmos()
    {
        // 1. �M�w�ϥ��C��
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        // 2. �M�wø�s�ϧ� 
        // transform.position �����󪺥@�ɮy��
        Gizmos.DrawSphere(transform.position +
            transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    /// <summary>
    ///  Update �� 60 FPS
    ///  �T�w��s�ƥ� : 50 FPS
    ///  �B�z����欰��ĳ�ΩT�w��s�ƥ� FixedUpdate
    /// </summary>
    private void FixedUpdate()
    {
        Move();
    }
    private void Update()
    {
        Filp();
    }
    #region ��k
    /// <summary>
    /// ���󲾰� (API)
    /// </summary>
    private void Move()
    {
        // h �� ���w�� ��J.���o�b�V(�����b) - �����b�N���⥪�k����
        float h = Input.GetAxis("Horizontal");
        print("���a���k�����" + h);

        // ���餸�� �[�t�� = �s �G���V�q(h�� * ���ʳt��, ����.�[�t��.����);
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
    }
    /// <summary>
    ///  ½��:
    ///  h �� �p�� 0 ��:���� Y 180
    ///  h �� �j�� 0 �k:���� Y 0
    /// </summary>
    private void Filp()
    {
        float h = Input.GetAxis("Horizontal");

        // �p�G h �� �p�� 0 ��: ���� Y 180
        if (h < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        // �p�G h �� �j�� 0 �k: ���� Y 0
        else if (h > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
    }
    #endregion

}
