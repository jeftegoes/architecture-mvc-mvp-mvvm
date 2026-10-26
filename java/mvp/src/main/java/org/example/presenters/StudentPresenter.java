package org.example.presenters;

import org.example.interfaces.StudentView;
import org.example.models.Student;

public class StudentPresenter {
    private final StudentView view;
    private final Student student;

    public StudentPresenter(StudentView view, Student student) {
        this.view = view;
        this.student = student;
    }

    public void loadStudents() {
        if (this.student != null) {
            view.showStudent(this.student);
        } else {
            view.showError("No student found.");
        }
    }
}