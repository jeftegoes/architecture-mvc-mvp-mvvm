package org.example.viewmodels;

import org.example.models.Student;

import java.util.ArrayList;
import java.util.List;

public class StudentViewModel {
    private final Student student;

    private String errorMessage;

    private final List<Runnable> observers = new ArrayList<>();

    public StudentViewModel(Student student) {
        this.student = student;
    }

    public void addObserver(Runnable observer) {
        observers.add(observer);
    }

    private void notifyObservers() {
        for (Runnable observer : observers) {
            observer.run();
        }
    }

    public Student getStudent() {
        return this.student;
    }

    public String getErrorMessage() {
        return errorMessage;
    }

    public void loadStudent() {
        if (this.student == null) {
            errorMessage = "Student not found.";
        } else {
            errorMessage = null;
        }

        notifyObservers();
    }

    public void updateStudent(String newName, int newAge) {
        if (this.student == null) {
            errorMessage = "Student not found.";
        } else {
            errorMessage = null;
            this.student.setName(newName);
            this.student.setAge(newAge);
        }

        notifyObservers();
    }
}
