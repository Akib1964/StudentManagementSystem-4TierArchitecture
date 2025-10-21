using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DataAccess
{
    public  class StudentRepository
    {
        // Database context (AppDbContext) hold করে রাখবে
        private readonly AppDbContext _context;
        // Constructor – যখন এই ক্লাসের object তৈরি হবে, তখন context ইনজেক্ট হবে
        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Student> GetAll()
        {
            // ToList() মানে database থেকে সব রেকর্ড এনে list বানানো
            return _context.Students.ToList();
        }
        //? holo মানে এই method return করবে either
        //✅ কোনো Student object
        //❌ অথবা null (যদি ওই id-এর student না থাকে)
        public Student?GetById(int id)
        {
            var exist = _context.Students.FirstOrDefault(s => s.Id == id);
            return exist;
        }
        // // নতুন student যোগ করে
        public void Add(Student student)
        {
            _context.Students.Add(student);// Memory তে add করে
            _context.SaveChanges();// Database এ save করে
        }
        public void Update(Student student)
        {
            var exist = _context.Students.FirstOrDefault(s => s.Id == student.Id);
            if(exist !=null)
            {
                exist.Name = student.Name;
                exist.Department = student.Department;
                exist.Age = student.Age;
                _context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var exist = _context.Students.FirstOrDefault(s => s.Id == id);
            if(exist!=null)
            {
                _context.Students.Remove(exist);// Remove from memory
                _context.SaveChanges();//save to database
            }
        }
    }
}
