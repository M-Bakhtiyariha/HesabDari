[English](#english) | [فارسی](#farsi)

---

<a name="english"></a>

# 🧾 Simple Accounting - Windows Forms Project

| **English** | **فارسی** |
|-------------|-----------|
| ## About This Project | ## معرفی پروژه |
| This project is an educational desktop application for simple accounting, developed using **C#** and **Windows Forms**. Its primary purpose is to serve as a practical learning resource for developers who are new to building database-driven applications with WinForms and SQL Server. | این پروژه یک نرم‌افزار دسکتاپ آموزشی برای حسابداری ساده است که با استفاده از **سی‌شارپ (#C)** و **ویندوز فرم (Windows Forms)** توسعه داده شده است. هدف اصلی آن، فراهم کردن یک منبع یادگیری کاربردی برای برنامه‌نویسانی است که به تازگی کار با نرم‌افزارهای مبتنی بر پایگاه داده در محیط WinForms و SQL Server را آغاز کرده‌اند. |
| It covers fundamental concepts such as database connectivity, CRUD operations (Create, Read, Update, Delete), and building a user-friendly interface for data management. | پروژه مفاهیم پایه‌ای مانند اتصال به پایگاه داده، عملیات CRUD (ایجاد، خواندن، به‌روزرسانی، حذف) و ساخت یک رابط کاربری ساده برای مدیریت داده‌ها را پوشش می‌دهد. |
| ## ✨ Features | ## ✨ ویژگی‌ها |
| - **Chart of Accounts:** Manage and categorize financial accounts. | - **کدینگ حسابداری:** مدیریت و دسته‌بندی سرفصل‌های حساب. |
| - **Journal Entries:** Record daily financial transactions (debits and credits). | - **ثبت اسناد روزانه:** ثبت تراکنش‌های مالی روزانه (بدهکار و بستانکار). |
| - **Basic Reporting:** View simple reports like account ledgers. | - **گزارشات پایه:** مشاهده گزارش‌های ساده مانند دفتر معین حساب‌ها. |
| - **Data Management:** Simple forms for adding, editing, and deleting records. | - **مدیریت داده‌ها:** فرم‌های ساده برای افزودن، ویرایش و حذف رکوردها. |
| ## 💻 Tech Stack | ## 💻 تکنولوژی‌های استفاده شده |
| - **.NET Framework** | - **.NET Framework** |
| - **C# (C-Sharp)** | - **C# (سی‌شارپ)** |
| - **Windows Forms (WinForms)** | - **Windows Forms (ویندوز فرم)** |
| - **Microsoft SQL Server** | - **Microsoft SQL Server** |
| ## 🚀 Getting Started | ## 🚀 راهنمای راه‌اندازی |
| Follow these steps to get the project up and running on your local machine. | برای اجرای پروژه روی کامپیوتر خود، مراحل زیر را دنبال کنید. |
| ### Prerequisites | ### پیش‌نیازها |
| - **Visual Studio** 2019 or later. | - **ویژوال استودیو** ۲۰۱۹ یا جدیدتر. |
| - **Microsoft SQL Server** 2017 or later (Express edition is sufficient). | - **Microsoft SQL Server** نسخه ۲۰۱۷ یا جدیدتر (نسخه Express کافی است). |
| - **SQL Server Management Studio (SSMS)**. | - **SQL Server Management Studio (SSMS)**. |
| ### Database Setup | ### نصب و راه‌اندازی پایگاه داده |
| You have two options to create the database: | برای ساخت دیتابیس، یکی از دو روش زیر را انتخاب کنید: |
| **Option A: Restore from Backup** | **روش اول: بازیابی از فایل پشتیبان** |
| 1. Open SSMS and connect to your SQL Server instance. | 1. SSMS را باز کرده و به سرور خود متصل شوید. |
| 2. In the Object Explorer, right-click on **"Databases"** and select **"Restore Database..."**. | 2. در پنل Object Explorer، روی پوشه **"Databases"** راست‌کلیک کرده و گزینه **"Restore Database..."** را انتخاب کنید. |
| 3. Choose **"Device"** and locate the `.bak` file included in the `/Database` folder of this project. | 3. گزینه **"Device"** را انتخاب کرده و فایل `.bak` موجود در پوشه `/Database` این پروژه را پیدا کنید. |
| 4. Click **"OK"** to restore the database. | 4. روی **"OK"** کلیک کنید تا دیتابیس بازیابی شود. |
| **Option B: Run the SQL Script** | **روش دوم: اجرای اسکریپت SQL** |
| 1. Open SSMS and connect to your instance. | 1. SSMS را باز کرده و به سرور خود متصل شوید. |
| 2. Open the `.sql` script file from the `/Database` folder of this project. | 2. فایل اسکریپت `.sql` را از پوشه `/Database` این پروژه باز کنید. |
| 3. Execute the script to create the database, tables, and seed initial data. | 3. اسکریپت را اجرا (Execute) کنید تا دیتابیس، جداول و داده‌های اولیه ساخته شوند. |
| ### Configure the Connection String | ### تنظیم رشته اتصال (Connection String) |
| 1. Open the solution file (`.sln`) in Visual Studio. | 1. فایل سولوشن (`.sln`) را در ویژوال استودیو باز کنید. |
| 2. Find the `App.config` file in the Solution Explorer. | 2. در Solution Explorer، فایل `App.config` را پیدا کنید. |
| 3. Locate the `<connectionStrings>` section and update the `connectionString` value to match your SQL Server instance and database name. | 3. بخش `<connectionStrings>` را پیدا کرده و مقدار `connectionString` را مطابق با نام سرور و دیتابیس خود ویرایش کنید. |
| **Example:** | **مثال:** |
| ```xml | ```xml |
| <connectionStrings> | <connectionStrings> |
|   <add name="MyConnectionString" connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=AccountingDB;Integrated Security=True" /> |   <add name="MyConnectionString" connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=AccountingDB;Integrated Security=True" /> |
| </connectionStrings> | </connectionStrings> |
| ``` | ``` |
| - Replace `YOUR_SERVER_NAME` with your server's name (e.g., `.` for local machine, `SQLEXPRESS`, etc.). | - به جای `YOUR_SERVER_NAME` نام سرور خود را قرار دهید (مثلاً `.` برای سرور محلی، `SQLEXPRESS` و...). |
| ### Build and Run | ### ساخت و اجرای پروژه |
| - Press **F5** or click the "Start" button in Visual Studio to build and run the application. | - کلید **F5** را فشار دهید یا روی دکمه "Start" در ویژوال استودیو کلیک کنید تا پروژه ساخته و اجرا شود. |
| ## 🙏 How to Contribute | ## 🙏 نحوه مشارکت |
| This is an educational project, and contributions are highly welcome! If you have ideas for improvements or want to fix a bug, please feel free to open an issue or submit a pull request. | این یک پروژه آموزشی است و از مشارکت شما به شدت استقبال می‌شود! اگر ایده‌ای برای بهبود پروژه دارید یا می‌خواهید باگی را برطرف کنید، لطفاً یک issue باز کرده یا pull request ارسال نمایید. |
