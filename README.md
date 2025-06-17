# TodoList Web App - 3-Tier Architecture

A full-stack Todo List web application built using 3-tier architecture pattern, providing a clean separation between presentation, business logic, and data access layers.

## 🏗️ Architecture Overview

This application follows the **3-Tier Architecture** pattern:

- **Presentation Layer (Tier 1)**: Frontend user interface
- **Business Logic Layer (Tier 2)**: Backend API and application logic
- **Data Access Layer (Tier 3)**: Database and data management

## ✨ Features

- ✅ Create new todo items
- ✏️ Edit existing todos
- ❌ Delete todo items
- ☑️ Mark todos as complete/incomplete
- 📋 View all todos with filtering options
- 🔍 Search functionality
- 📱 Responsive design for mobile and desktop

## 🛠️ Technology Stack

### Frontend (Presentation Layer)
- HTML5, CSS3, JavaScript
- Responsive design with modern UI/UX

### Backend (Business Logic Layer)
- Server-side framework (Flask/Node.js/ASP.NET)
- RESTful API endpoints
- Business logic implementation

### Database (Data Access Layer)
- Database system (SQLite/MySQL/PostgreSQL)
- Data models and relationships
- CRUD operations

## 🚀 Getting Started

### Prerequisites

Make sure you have the following installed:
- [Node.js](https://nodejs.org/) (if using Node.js backend)
- [Python](https://python.org/) (if using Flask/Django)
- Database system (SQLite, MySQL, or PostgreSQL)
- Git

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Khawla-alharthi/TodoListWebApp-3Teir.git
   cd TodoListWebApp-3Teir
   ```

2. **Install Dependencies**
   
   For Python/Flask backend:
   ```bash
   pip install -r requirements.txt
   ```
   
   For Node.js backend:
   ```bash
   npm install
   ```

3. **Database Setup**
   ```bash
   # Create database tables
   python database_setup.py
   # or
   npm run setup-db
   ```

4. **Environment Configuration**
   ```bash
   # Copy environment template
   cp .env.example .env
   # Edit .env with your database credentials and settings
   ```

5. **Run the Application**
   
   For Python/Flask:
   ```bash
   python app.py
   # or
   flask run
   ```
   
   For Node.js:
   ```bash
   npm start
   ```

6. **Access the Application**
   
   Open your browser and navigate to `http://localhost:3000` (or the configured port)

## 📁 Project Structure

```
TodoListWebApp-3Teir/
├── frontend/                 # Presentation Layer
│   ├── index.html
│   ├── css/
│   ├── js/
│   └── assets/
├── backend/                  # Business Logic Layer
│   ├── app.py               # Main application file
│   ├── models/              # Data models
│   ├── routes/              # API routes
│   ├── controllers/         # Business logic
│   └── utils/               # Utility functions
├── database/                # Data Access Layer
│   ├── schema.sql           # Database schema
│   ├── migrations/          # Database migrations
│   └── config.py           # Database configuration
├── tests/                   # Test files
├── docs/                    # Documentation
├── requirements.txt         # Python dependencies
├── package.json            # Node.js dependencies
└── README.md               # This file
```

## 🔌 API Endpoints

### Todo Operations

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/todos` | Get all todos |
| GET | `/api/todos/:id` | Get specific todo |
| POST | `/api/todos` | Create new todo |
| PUT | `/api/todos/:id` | Update todo |
| DELETE | `/api/todos/:id` | Delete todo |

### Example API Usage

**Create a new todo:**
```bash
curl -X POST http://localhost:3000/api/todos \
  -H "Content-Type: application/json" \
  -d '{"title": "Learn 3-tier architecture", "completed": false}'
```

**Get all todos:**
```bash
curl http://localhost:3000/api/todos
```

## 🗄️ Database Schema

### Todos Table

| Column | Type | Description |
|--------|------|-------------|
| id | INTEGER | Primary key |
| title | VARCHAR(255) | Todo title |
| description | TEXT | Todo description |
| completed | BOOLEAN | Completion status |
| created_at | TIMESTAMP | Creation date |
| updated_at | TIMESTAMP | Last update date |

## 🧪 Testing

Run the test suite:

```bash
# Python tests
python -m pytest tests/

# Node.js tests
npm test
```

## 🚀 Deployment

### Local Development
1. Follow the installation steps above
2. Use development database settings
3. Enable debug mode

### Production Deployment
1. Set up production database
2. Configure environment variables
3. Build and deploy using your preferred platform (Heroku, AWS, etc.)

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📋 Todo Application Features

- **Add Tasks**: Create new todo items with title and description
- **Edit Tasks**: Modify existing todo items
- **Delete Tasks**: Remove unwanted todo items
- **Mark Complete**: Toggle completion status of tasks
- **Filter Tasks**: View all, completed, or pending tasks
- **Search**: Find specific tasks by title or description
- **Responsive UI**: Works on desktop and mobile devices

## 🏛️ 3-Tier Architecture Benefits

- **Separation of Concerns**: Each layer has distinct responsibilities
- **Scalability**: Layers can be scaled independently
- **Maintainability**: Changes in one layer don't affect others
- **Testability**: Each layer can be tested independently
- **Flexibility**: Easy to swap technologies in individual layers

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👥 Author

**Khawla Al-Harthi**
- GitHub: [@Khawla-alharthi](https://github.com/Khawla-alharthi)

## 🙏 Acknowledgments

- Thanks to the open-source community for inspiration
- 3-tier architecture pattern documentation
- Modern web development best practices

---

⭐ If you found this project helpful, please give it a star!
