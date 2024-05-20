using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final2.Models;
using SQLite;

namespace Final2
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<StudentData>().Wait();
            _database.CreateTableAsync<CourseData>().Wait();
        }

        // Student operations
        public Task<List<StudentData>> GetStudentsAsync()
        {
            return _database.Table<StudentData>().ToListAsync();
        }

        public Task<int> SaveStudentAsync(StudentData student)
        {
            return _database.InsertAsync(student);
        }

        // Course operations
        public Task<List<CourseData>> GetCoursesAsync()
        {
            return _database.Table<CourseData>().ToListAsync();
        }

        public Task<int> SaveCourseAsync(CourseData course)
        {
            return _database.InsertAsync(course);
        }
    }
}
