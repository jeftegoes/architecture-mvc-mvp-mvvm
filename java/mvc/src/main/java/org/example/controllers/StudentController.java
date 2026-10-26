package org.example.controllers;

import org.example.models.Student;
import org.example.views.StudentView;

public class StudentController {
    private Student student;
    private StudentView view;

    public StudentController(Student student, StudentView view) {
        this.student = student;
        this.view = view;
    }

    public void showStudent() {
        view.showStudent(student);
    }

    public void updateStudent(String name, int age) {
        student.setName(name);
        student.setAge(age);

        view.showMessage("Student updated successfully!");
    }
}
