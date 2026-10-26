package org.example.view;

import org.example.models.Student;
import org.example.viewmodels.StudentViewModel;

public class StudentView {
    private final StudentViewModel viewModel;

    public StudentView(StudentViewModel viewModel) {
        this.viewModel = viewModel;

        viewModel.addObserver(this::render);
    }

    public void onLoadStudent() {
        viewModel.loadStudent();
    }

    private void render() {
        if (viewModel.getErrorMessage() != null) {
            System.out.println(
                    "Error: " + viewModel.getErrorMessage()
            );
            return;
        }

        Student student = viewModel.getStudent();

        System.out.println("Student Information");
        System.out.println("Name: " + student.getName());
        System.out.println("Age: " + student.getAge());
    }
}
