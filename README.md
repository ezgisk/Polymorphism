## Kurulum

1. Projeyi indirin veya klonlayın:
   ```bash
   git clone https://github.com/kullanici_adi/geometrik-sekil-hesaplama.git
   ```

2. Projeyi Visual Studio veya başka bir C# geliştirme ortamında açın.

3. Projeyi derleyin ve çalıştırın.

## Kullanım

Uygulama, belirli geometrik şekillerin alanlarını hesaplamak için aşağıdaki adımları takip eder:

1. `Kare`, `Dikdortgen` ve `DikUcgen` sınıflarını oluşturun.
2. Her bir nesne için genişlik ve yükseklik değerlerini belirtin.
3. `AlanHesapla` metodunu çağırarak alanı hesaplayın.

### Örnek Çıktı

```
Kare Alanı: 25
Dikdörtgen Alanı: 24
Dik Üçgen Alanı: 12
```

## Sınıflar

- **BaseGeometrikSekil**: Ortak özellikleri ve alan hesaplama metodunu tanımlar.
- **Kare**: Bir karenin alanını hesaplar.
- **Dikdortgen**: Bir dikdörtgenin alanını hesaplar.
- **DikUcgen**: Bir dik üçgenin alanını hesaplar.


