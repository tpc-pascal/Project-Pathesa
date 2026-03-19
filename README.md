# Project-Pathesa

[![GitHub License](https://img.shields.io/github/license/tpc-pascal/Project-Pathesa)](https://github.com/tpc-pascal/Project-Pathesa/blob/main/LICENSE)
[![GitHub Stars](https://img.shields.io/github/stars/tpc-pascal/Project-Pathesa)](https://github.com/tpc-pascal/Project-Pathesa/stargazers)

**ParnyRun** là một trò chơi Endless Runner 2D được phát triển trên nền tảng **C# / WPF**. Dự án tập trung vào việc mô phỏng vật lý nhảy thực tế, hệ thống chướng ngại vật động ngẫu nhiên và tối ưu hóa trải nghiệm người dùng trên môi trường Windows.

<p align="center">
  <img src="assets/parny_run_banner.png" height="300" width="400" alt="Parny Run Banner">
</p>

## 🚀 Tính năng chính

Hệ thống được thiết kế tập trung vào 3 cốt lõi kỹ thuật:

* **Vật lý nhân vật:** Mô phỏng gia tốc trọng trường, vận tốc rơi tự do và lực nhảy mượt mà bằng `DispatcherTimer`.
* **Cơ chế Game:** Hệ thống chướng ngại vật sinh ngẫu nhiên (Dynamic Generation) với tốc độ tăng dần theo thời gian sinh tồn.
* **Quản lý dữ liệu:** Hệ thống tính điểm thời gian thực (Real-time Scoring) và lưu trữ kỷ lục người chơi (High Score).
* **Giao diện hiện đại:** Thiết kế Responsive UI bằng XAML Styling, hỗ trợ menu "Bắt Đầu" và "Cài Đặt" trực quan.

## 🛠 Công nghệ sử dụng

* **Language:** C# - Ngôn ngữ lập trình chính xử lý Logic game.
* **Framework:** .NET Framework 4.7.2 - Nền tảng xây dựng ứng dụng Windows.
* **UI/UX:** WPF (Windows Presentation Foundation) - Thiết kế giao diện bằng XAML.
* **Physics:** Thuật toán kiểm tra va chạm (Collision Detection) dựa trên giao điểm Hitbox (`Rect`).

## 📁 Cấu trúc thư mục

```text
Project-Pathesa/
├── assets/             # Hình ảnh (Banner, Sprites), âm thanh và tài nguyên game
├── docs/               # Tài liệu kỹ thuật, sơ đồ thuật toán (Flowchart, Use Case)
├── src/                # Mã nguồn chính (.sln, .csproj, Views, Models)
├── .gitignore          # Cấu hình loại bỏ file rác khi commit
├── LICENSE             # Giấy phép MIT
└── README.md           # Hướng dẫn dự án
```

## 🎉 Tác giả

[![Contributors](https://contributors-img.web.app/image?repo=tpc-pascal/Project-Pathesa)](https://github.com/tpc-pascal/Project-Pathesa/graphs/contributors)
<details open>
<summary><b>🔍 Các thành viên</b></summary>

| STT | Tên | Vai trò |
|:---:|:---|:---|
| 1 | Trịnh Phú Cường | Thiết kế, xây dựng và phát triển game |
</details>
