using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float scrollSpeed = 1.0f;

    void Update()
    {
        // Nesnenin kaymasý
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        // Nesnenin ekradan çýktýðýný kontrol etme
        if (transform.position.x < -10f)
        {
            // Eðer nesne ekrandan çýktýysa, tekrar saða getir
            Reposition();
        }
    }

    void Reposition()
    {
        // Nesneyi ekrandan çýktýðý yerin sað tarafýna getir
        float offset = 20f;  // Ýsteðe baðlý: Nesneler arasýndaki boþluðu ayarlamak için
        transform.position = new Vector2(transform.position.x + offset, transform.position.y);
    }
}
