# TaskManagementSystem
ASP.net core project with basic CRUD operations via API endpoints , sql database

**Users**
POST /api/users
{
 "name": "Ahmed Ali",
 "email": "ahmed.ali@gmail.com"
}
PUT api/users/api/users/11111111-1111-1111-1111-111111111111
{
  "name": "Mohamed khaled ",
  "email": "mohamed.khaled@gmail.com"
}
GET /api/users
GET /api/users{id}
DELETE/api/users/{id}

**Projects**
POST /api/projects
{
 "name": "Website Documentation",
 "description": "Initial documentation for the website",
 "ownerId": "7a6f2e84-3c17-45b7-9f3e-92e4a1ab0e0f"
}
PUT  api/projects/{id}
{
"id":"22222222-2222-2222-2222-222222222222",
  "name": "Project beta",
  "description": "This is the first project.",
  "ownerId": "11111111-1111-1111-1111-111111111111"
}
**GET /api/projects**
**GET /api/projects/{id}**
**DELETE/api/projects/{id}**

**Tasks
POST /api/taskitems**
{
 "title": "Task 1",
 "status": 0,
 "dueDate": "2025-09-10",
 "projectId": "d298a56e-b84a-46c6-8fa2-229e87f70d4c",
 "assignedUserId": "7a6f2e84-3c17-45b7-9f3e-92e4a1ab0e0f"
}

**GET /api/taskitems**
**GET /api/taskitems/{id}**

**PUT /api/taskitems/{id}**
{
 "title": "Updated Task 1",
 "status": 2,
 "dueDate": "2025-09-20",
 "projectId": "d298a56e-b84a-46c6-8fa2-229e87f70d4c",
 "assignedUserId": "bdf22a07-4a29-4b58-b3f2-60f3f2e79eaf"
}
**DELETE /api/taskitems/{id}**
