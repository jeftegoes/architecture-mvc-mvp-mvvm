package org.example;

import org.example.interfaces.StudentView;
import org.example.models.Student;
import org.example.presenters.StudentPresenter;
import org.example.views.AlternativeStudentView;
import org.example.views.ConsoleStudentView;

public class Main {
    public static void main(String[] args) {
        StudentView view = new AlternativeStudentView();

        Student model = new Student(1, "Jefté", 35);

        StudentPresenter presenter = new StudentPresenter(view, model);

        presenter.loadStudents();
    }
}