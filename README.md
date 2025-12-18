# 🌱 Plantator

**Plantator** to nowoczesna aplikacja stworzona w **.NET MAUI**, która umożliwia łatwe zarządzanie roślinami w domu lub ogrodzie.  
Dzięki Plantatorowi możesz dodawać rośliny, przeglądać je w katalogu, a także śledzić ich potrzeby.

![Plantator Screenshot](path/to/screenshot.png)  <!-- Zamień na własny obrazek -->

---

## 🚀 Funkcjonalności

- Dodawanie i przeglądanie roślin  
- Zarządzanie widokami aplikacji (`Views`)  
- Obsługa lokalnej bazy danych SQLite  
- Przyjazny interfejs dla wielu platform (Android, iOS, Windows, Mac)

---

## 🗂 Struktura projektu


```
erp-backend/
├── src/                  # Source code
│   └── index.js          # Main application entry point
├── tests/                # Test files
├── config/               # Configuration files
├── .gitignore            # Git ignore file
├── package.json          # Project dependencies and scripts
├── README.md             # Project documentation
└── LICENSE               # License file
```


---

## ⚙️ Wymagania

- .NET 9.0 SDK  
- Visual Studio 2022 / Rider z obsługą MAUI  
- macOS lub Windows (w zależności od targetu)  

---

## 💻 Instalacja i uruchomienie

1. Sklonuj repozytorium:  
```bash
git clone https://github.com/Latsownik1/plantator.git
cd plantator
Otwórz projekt w Visual Studio lub Rider

Wybierz platformę docelową (Android / iOS / Windows / Mac Catalyst)

Zbuduj i uruchom aplikację

Dodawaj własne widoki w folderze Views, a dane w db.
```
## 🤝 Kontrybucja

- Chcesz pomóc w rozwoju Plantatora? Świetnie!

1. Fork repozytorium

2. Stwórz nową gałąź:

- git checkout -b feature/nazwa-funkcji

3. Wprowadź zmiany i commit:

- git commit -m "Opis zmian"

4. Wypchnij zmiany:

- git push origin feature/nazwa-funkcji


5. Otwórz pull request
