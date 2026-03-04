# ParnyRun

ParnyRun - A 2D endless runner game built with C# and WPF, featuring dynamic obstacle generation, physics-based jumping, and real-time score tracking.

<p align="center">
  <img src="Parny_Run.png" width="400" alt="Parny Run Banner">
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET-Framework%204.7.2-blue?style=flat-square&logo=dotnet" alt=".NET Framework">
  <img src="https://img.shields.io/badge/UI-WPF-orange?style=flat-square" alt="WPF">
  <img src="https://img.shields.io/badge/License-MIT-green?style=flat-square" alt="License">
</p>

---

## 🎮 Giới thiệu
**ParnyRun** là một trò chơi thuộc thể loại endless runner 2D được phát triển trên nền tảng **Windows Presentation Foundation (WPF)**. Trò chơi kết hợp giữa cơ chế vật lý nhảy thực tế và hệ thống chướng ngại vật động, mang lại trải nghiệm mượt mà và đầy thử thách.

## 🛠 Đặc tả kỹ thuật (Technical Specifications)
Dự án được xây dựng với kiến trúc logic chặt chẽ:
* **Physics Jumping:** Sử dụng `DispatcherTimer` để mô phỏng gia tốc trọng trường, tính toán vận tốc rơi tự do và tọa độ $$Y$$ của nhân vật theo thời gian thực.
* **Dynamic Obstacles:** Hệ thống chướng ngại vật được sinh ngẫu nhiên, di chuyển thông qua biến đổi `Canvas.Left` với tốc độ tăng dần theo thời gian.
* **Collision Detection:** Thuật toán kiểm tra va chạm dựa trên giao điểm của các `Rect` (Hitbox) trong mỗi chu kỳ tick của timer để đảm bảo độ chính xác tuyệt đối.

## 🚀 Tính năng nổi bật (Features)
- [x] **Character Physics:** Di chuyển và nhảy mượt mà bằng phím `Space`.
- [x] **Smart Score System:** Hệ thống tính điểm thời gian thực dựa trên quãng đường sinh tồn.
- [x] **Responsive UI:** Giao diện hiện đại với hệ thống menu "Bắt Đầu" và "Cài Đặt" được thiết kế bằng XAML Styling.
- [ ] **Hitbox Optimization:** (Đang phát triển) Nâng cấp thuật toán kiểm tra va chạm pixel-perfect.

## 📥 Hướng dẫn cài đặt (Installation)
### Dành cho người chơi
1. Truy cập mục **[Releases](https://github.com/tpc-pascal/Project-Pathesa/releases)**.
2. Tải xuống tệp nén `.rar` mới nhất.
3. Giải nén và chạy tệp `setup.exe` để bắt đầu cài đặt.
*Lưu ý: Yêu cầu máy tính có sẵn .NET Framework 4.7.2 Runtime.*

### Dành cho nhà phát triển (Contributing)
Nếu bạn muốn tìm hiểu mã nguồn hoặc đóng góp cho dự án:
```bash
# Clone repository
git clone [https://github.com/tpc-pascal/Project-Pathesa.git](https://github.com/tpc-pascal/Project-Pathesa.git)
