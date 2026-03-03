# Project-Pathesa
 
ParnyRun - A 2D endless runner game built with C# and WPF, featuring dynamic obstacle generation, physics-based jumping, and real-time score tracking

![Parny Run](Parny_Run.png)

---

🛠 Technical Specifications (Đặc tả kỹ thuật):
- Framework: .NET Framework 4.7.2
- UI/UX: Windows Presentation Foundation (WPF) với XAML styling
- Core Logic:
  + Physics Jumping: Sử dụng DispatcherTimer để tính toán vận tốc rơi tự do và tọa độ $Y$ của nhân vật theo thời gian thực
  + Dynamic Obstacles: Chướng ngại vật được khởi tạo ngẫu nhiên và di chuyển bằng cách thay đổi Canvas.Left dựa trên tốc độ game tăng dần
  + Collision Detection: Kiểm tra va chạm giữa các Rect (Hitbox) của nhân vật và vật thể trong mỗi tick của timer

---

🚀 Features (Tính năng):
- [x] Character Animation: Di chuyển và nhảy mượt mà bằng phím Space
- [x] Score System: Tự động tính điểm dựa trên thời gian tồn tại của nhân vật
- [x] Responsive UI: Giao diện trực quan với nút "Bắt Đầu" và "Cài Đặt"
- [ ] Hitbox Optimization: Thuật toán kiểm tra va chạm để đạt độ chính xác cao hơn

---

📥 Installation (Hướng dẫn cài đặt):
- Yêu cầu: Máy tính cài đặt sẵn .NET Framework 4.7.2 Runtime trở lên
- Cách chạy: * Tải file nén .rar từ mục Releases
- Giải nén và chạy file setup.exe để cài đặt ứng dụng vào máy
- Dành cho Developer: Mở file .sln bằng Visual Studio 2019/2022 để xem mã nguồn và đóng góp
