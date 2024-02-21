using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float scrollSpeed = 1.0f;

    void Update()
    {
        // Nesnenin kaymas�
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        // Nesnenin ekradan ��kt���n� kontrol etme
        if (transform.position.x < -10f)
        {
            // E�er nesne ekrandan ��kt�ysa, tekrar sa�a getir
            Reposition();
        }
    }

    void Reposition()
    {
        // Nesneyi ekrandan ��kt��� yerin sa� taraf�na getir
        float offset = 20f;  // �ste�e ba�l�: Nesneler aras�ndaki bo�lu�u ayarlamak i�in
        transform.position = new Vector2(transform.position.x + offset, transform.position.y);
    }
}
