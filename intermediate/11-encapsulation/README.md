
# 11. Encapsulation

Инкапсуляция bo'yicha uyga vazifa.

## 1. WaterTank
- `Capacity` va `Water` faqat o'qiladi (`private set`)
- `Fill`, `Use`, `GetFreeCapacity` methodlari
- Konstruktorda sig'im va suv miqdori tekshiriladi, noto'g'ri bo'lsa `ArgumentOutOfRangeException`
- `Fill` da `amount <= Capacity - Water` bilan int chegarasidan oshish oldi olinadi

## 2. StudySession
- `Topic` va `SpentMinutes` faqat o'qiladi
- `PlannedMinutes` da tekshiradigan `set` (10-120 va sarflangan vaqtdan kam emas)
- `RecordMinutes` va `GetRemainingMinutes` methodlari
- Noto'g'ri reja uchun `ArgumentOutOfRangeException`, eski reja saqlanadi

## Ishga tushirish
```
dotnet run
```