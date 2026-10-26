package org.example.views;

import org.example.models.Student;

public class StudentView {
    public void showStudent(Student student) {
        System.out.println("===== STUDENT =====");
        System.out.println("ID: " + student.getId());
        System.out.println("Name: " + student.getName());
        System.out.println("Age: " + student.getAge());
    }

    public void showMessage(String message) {
        System.out.println(message);
    }
}
