package org.example.views;

import org.example.interfaces.StudentView;
import org.example.models.Student;

import java.util.List;

public class AlternativeStudentView implements StudentView {
    @Override
    public void showStudent(Student student) {
        System.out.println("=== STUDENT REPORT ===");
        System.out.println("Name: " + student.getName().toUpperCase());
        System.out.println("Age: " + student.getAge());
    }

    @Override
    public void showError(String message) {
        System.out.println("REPORT ERROR: " + message);
    }
}
