# 🎹 Beep Player

以 C# / WinForms 開發的互動式鋼琴音效程式，支援滑鼠點擊與鍵盤演奏，並搭配即時視覺化動畫。

## 執行畫面

> 上方為即時視覺化動畫區，中間為彩色鋼琴鍵，下方為狀態列。
<img width="645" height="305" alt="螢幕擷取畫面 2026-05-07 163449" src="https://github.com/user-attachments/assets/d58acdb9-309b-4e08-a85f-e950430e5b15" />
<img width="642" height="299" alt="image" src="https://github.com/user-attachments/assets/de34c8d6-4043-47d3-b581-f54c2833acde" />


## 功能說明

| 功能 | 說明 |
|------|------|
| 🎹 八個彩色琴鍵 | Do Re Mi Fa Sol La Si Do'，每個音符對應獨特配色 |
| 🌈 即時視覺化 | 按鍵時顯示對應顏色的頻譜律動動畫 |
| ⌨️ 鍵盤演奏 | 使用鍵盤 A S D F G H J K 對應八個音符 |
| 📐 自適應縮放 | 拖曳視窗大小時，琴鍵會等比例縮放 |
| 📢 狀態列 | 即時顯示目前播放的音符名稱與頻率 |

## 鍵盤對應

| 鍵盤 | 音符 | 頻率 |
|------|------|------|
| A | Do  | 523 Hz |
| S | Re  | 587 Hz |
| D | Mi  | 659 Hz |
| F | Fa  | 698 Hz |
| G | Sol | 784 Hz |
| H | La  | 880 Hz |
| J | Si  | 988 Hz |
| K | Do' | 1046 Hz |

## 執行環境

- Windows 10 / 11
- .NET Framework 4.7.2 或以上（Visual Studio 預設）
- Visual Studio 2022（建議）

## 開啟專案

1. 下載或 clone 此專案
2. 以 Visual Studio 開啟 `BeepPlayer.sln`
3. 按下 **F5** 或點選「開始」即可執行

## 專案結構

```
BeepPlayer/
├── BeepPlayer.sln
├── .gitignore
├── README.md
└── BeepPlayer/
    ├── frmBeepPlayer.cs          # 主要邏輯
    ├── frmBeepPlayer.Designer.cs # UI 佈局
    └── Program.cs                # 程式進入點
```

## 技術說明

- **`Beep` API**：呼叫 `kernel32.dll` 的系統嗶聲函式，傳入頻率（Hz）與持續時間（ms）發出對應音符
- **自適應縮放**：於 `Load` 事件記錄各控制項初始尺寸，`SizeChanged` 時依比例重新計算位置與大小
- **視覺化動畫**：使用 `System.Windows.Forms.Timer`（40ms / ~25fps）驅動自繪 Panel，按鍵時切換為對應音符的彩色頻譜效果
- **共用事件**：btn2～btn8 共用 `btn1_Click`，透過 `TabIndex` 區分音符索引
- **鍵盤支援**：`KeyPreview = true` 搭配 `KeyDown` 事件，將 A～K 對應至各琴鍵的 `PerformClick()`
