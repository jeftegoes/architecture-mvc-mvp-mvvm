package org.example;

import org.example.controllers.StudentController;
import org.example.models.Student;
import org.example.views.StudentView;

public class Main {
    static void main() {
        Student student = new Student(1, "Jefté", 35);

        StudentView view = new StudentView();

        StudentController controller = new StudentController(student, view);

        controller.showStudent();

        controller.updateStudent("John Smith", 21);

        controller.showStudent();
    }
}
