using StudentManagementSystem.DataAccess;
using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Business
{
    public class StudentService
    {
        private readonly StudentRepository _repo;
        public StudentService(StudentRepository repo)
        {
            _repo = repo;
        }
        public List<Student> GetAllStudents()
        {
            return _repo.GetAll();
        }
        // ✅ নির্দিষ্ট Id এর Student আনবে (না থাকলে null)
        public Student?GetStudentById(int id)
        {
            return _repo.GetById(id);
        }
        // ✅ নতুন Student যোগ করবে
        public void AddStudent(Student student)
        {
            _repo.Add(student);
        }
        public void UpdateStudent(Student student)
        {
            _repo.Update(student);
        }
        public void DeleteStudent(int id)
        {
            _repo.Delete(id);
        }
    }
}
