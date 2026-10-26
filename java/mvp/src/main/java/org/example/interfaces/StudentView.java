package org.example.interfaces;

import org.example.models.Student;

public interface StudentView {
    void showStudent(Student student);

    void showError(String message);
}