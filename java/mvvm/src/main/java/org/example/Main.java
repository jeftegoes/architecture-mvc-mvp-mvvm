package org.example;

import org.example.models.Student;
import org.example.view.StudentView;
import org.example.viewmodels.StudentViewModel;

public class Main {
    public static void main(String[] args) {
        Student model = new Student(1, "Jefté", 35);

        StudentViewModel viewModel = new StudentViewModel(model);
        StudentView view = new StudentView(viewModel);

        System.out.println("Initial student data");
        view.onLoadStudent();

        System.out.println("\nSimulating user input...");
        String newName = "John Smith";
        int newAge = 21;
        viewModel.updateStudent(newName, newAge);

        System.out.println("\nUpdated student data");
        view.onLoadStudent();
    }
}