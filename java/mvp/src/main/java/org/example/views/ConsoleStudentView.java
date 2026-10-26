package org.example.views;

import org.example.interfaces.StudentView;
import org.example.models.Student;

import java.util.List;

public class ConsoleStudentView implements StudentView {
    @Override
    public void showStudent(Student student) {
        System.out.println("\nStudent:");
        System.out.println("- Name: " + student.getName() + ", Age: " + student.getAge());
    }

    @Override
    public void showError(String message) {
        System.out.println("Error: " + message);
    }
}
