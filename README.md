# C# ile Kahve Listesi İşlemleri

Bu proje, C# dilinde bir `List<string>` kullanılarak kahve isimlerinin saklanması ve ekrana yazdırılması işlemlerini göstermektedir. `Split` metodu kullanılarak her bir kahve ismi düzenlenmiş ve sadece kahve isimleri ekrana yazdırılmıştır.

## Adımlar:

1. **Liste Tanımlama**:
   - `Kahveler` adında bir `List<string>` tanımlanmıştır. Liste içerisinde farklı kahve türleri yer almaktadır.
   - Örnek kahveler: "Mocha", "Latte", "Maocha", "Cappucino" vb.

2. **Foreach Döngüsü ile Elemanları Yazdırma**:
   - `foreach` döngüsü kullanılarak listenin elemanları teker teker işlenmiştir.
   - Her bir eleman, `Split` metodu ile `':'` karakterinden bölünerek kahve isimleri alınmış ve `Last()` metodu ile sadece kahve adları ekrana yazdırılmıştır.

## Nasıl Çalıştırılır:

- Kodu bir C# geliştirme ortamında derleyip çalıştırın.
- Program, kahve isimlerini ekrana yazdıracaktır.
