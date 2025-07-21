# 🚀 ProjectForDockerCompose

Этот проект поможет новичкам понять, как работает Docker и Docker Compose на практике.

## 📦 Что делает этот проект?

Проект показывает, как с помощью `docker-compose` можно быстро развернуть приложение в изолированной среде, не устанавливая зависимости вручную.

## 🛠️ Что нужно установить заранее

- Docker Desktop – установите и запустите: https://www.docker.com/products/docker-desktop/
- Git – для клонирования проекта из GitHub

## 🚀 Запуск проекта шаг за шагом

### 1. Открываем терминал

```bash
Win + R -> cmd -> Enter
```

Если проект нужно разместить на другом диске (например, D:), сначала введите:

```bash
D:
```

### 2. Клонируем репозиторий с GitHub

```bash
git clone https://github.com/Artifait/ProjectForDockerCompose.git
```

### 3. Переходим в папку с проектом

```bash
cd ProjectForDockerCompose
```

### 4. Убеждаемся, что Docker Desktop запущен

Проверьте, что иконка Docker (в виде кита 🐳) активна в системном трее.

### 5. Запускаем проект через Docker Compose

```bash
docker-compose up --build
```

## ✅ Проверка работы

Открой в браузере:

```
http://localhost:18000/
```

Если всё работает, ты увидишь следующую страницу:
<img width="1063" height="562" alt="image" src="https://github.com/user-attachments/assets/f195a6b7-b806-4ad3-9e27-dba161dabd2e" />
А в консоли — примерно такой вывод:
<img width="2040" height="1270" alt="image" src="https://github.com/user-attachments/assets/233a0e9b-fb56-4d0e-8ca7-0d2be0840c2c" />

## 🛑 Как остановить контейнеры

Нажми `Ctrl + C` в терминале, где запускал `docker-compose`

## ℹ️ Советы

- Если не запускается — перезапусти Docker Desktop
- Проверь, нет ли ошибок в консоли
- Убедись, что порт `18000` не занят другим приложением
