
# PersianDateTimePickerDemo

🎯 **نمونه پروژه Razor Page** برای استفاده از تقویم شمسی (Persian DateTime Picker) با استفاده از کتابخانه [MD.BootstrapPersianDateTimePicker](https://github.com/Mds92/MD.BootstrapPersianDateTimePicker).

---

## 📷 پیش‌نمایش

این پروژه یک فرم ساده با یک فیلد تاریخ شمسی ایجاد می‌کند که همزمان تاریخ میلادی را نیز برای ذخیره‌سازی ارسال می‌کند.

---

## 📦 پیش‌نیازها

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)  
- Visual Studio 2022 یا جدیدتر  
- اتصال اینترنت برای بارگذاری CDN (یا می‌توانید کتابخانه را به صورت لوکال اضافه کنید)

---

## 🛠️ نحوه استفاده

1. ریپوزیتوری را کلون کنید یا فایل ZIP پروژه را دانلود و اکسترکت کنید:

   ```bash
   git clone https://github.com/sunn789/PersianDateTimePickerDemo.git
   ```

2. پروژه را در Visual Studio یا VS Code باز کنید.

3. پروژه را اجرا کنید:

   - در Visual Studio: `F5` یا `Ctrl + F5`
   - در خط فرمان: در مسیر پروژه دستور زیر را اجرا کنید:
     ```bash
     dotnet run
     ```

4. به آدرس `https://localhost:5001` (یا آدرس مشابه) مراجعه و فرم را تست کنید.

---

## 🔍 شرح اجزای پروژه

### افزودن CSS به Layout

در فایل `_Layout.cshtml` در بخش `<head>` این خط را اضافه کنید:

```html
<link href="https://cdn.jsdelivr.net/npm/md.bootstrappersiandatetimepicker/dist/mds.bs.datetimepicker.style.css" rel="stylesheet" />
```

---

### افزودن اسکریپت به صفحه Razor

در بخش `@section Scripts` فایل Razor که فرم در آن قرار دارد، کد زیر را اضافه کنید:

```cshtml
@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
    <script src="https://cdn.jsdelivr.net/npm/md.bootstrappersiandatetimepicker/dist/mds.bs.datetimepicker.js"></script>
    <script>
        const dtp1Instance = new mds.MdsPersianDateTimePicker(document.getElementById("shamsiDate"), {
          targetTextSelector: '[data-name="dtp1-text"]',
          targetDateSelector: '[data-name="dtp1-date"]',
        });
    </script>
}
```

---

### فرم دریافت تاریخ در Razor Page (`Index.cshtml`)

```cshtml
<div class="form-group">
    <label asp-for="Receipt.LastPayment" class="control-label"></label>
    <input asp-for="Receipt.LastPayment" type="text" id="shamsiDate" data-name="dtp1-text" class="form-control" />
    <input type="hidden" data-name="dtp1-date" name="Receipt.LastPayment" />
    <span asp-validation-for="Receipt.LastPayment" class="text-danger"></span>
</div>
```

توضیح:  
فیلد متنی برای نمایش تاریخ شمسی به کاربر است و مقدار تاریخ میلادی در فیلد مخفی ارسال می‌شود.

---

### مدل `Receipt`

```csharp
public class Receipt
{
    [Required(ErrorMessage = "تاریخ پرداخت اجباری است")]
    public DateTime LastPayment { get; set; }
}
```

---

## 📚 منابع و مستندات

- [MD.BootstrapPersianDateTimePicker در GitHub](https://github.com/Mds92/MD.BootstrapPersianDateTimePicker)  
- [آموزش استفاده در وبلاگ](https://devex.ir/PostDetails/Post/13236/%DA%86%DA%AF%D9%88%D9%86%D9%87-%D8%A7%D8%B2-datetimepicker-%D9%81%D8%A7%D8%B1%D8%B3%DB%8C-%D8%A7%D8%B2%D8%AA%D9%81%D8%A7%D8%AF%D9%87-%DA%A9%D9%86%DB%8C%D9%85)

---

## 🧑‍💻 نویسنده

Hossein Aftabi  
📧 [hossein.aftabi@gmail.com](mailto:hossein.aftabi@gmail.com)  
🌐 [devex.ir](http://devex.ir)

---

## 📄 مجوز

این پروژه تحت مجوز MIT منتشر شده است.

---

## ⭐ کمک به پروژه

اگر این پروژه برای شما مفید بود، خوشحال می‌شوم با ⭐ دادن به ریپو در GitHub حمایت کنید.

---
