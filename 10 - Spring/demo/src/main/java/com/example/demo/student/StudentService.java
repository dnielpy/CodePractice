package com.example.demo.student;

import java.time.LocalDate;
import java.time.Month;
import java.util.List;

public class StudentService {
    public List<Student> getStudent(){
        return List.of(
                new Student(
                        1L,
                        "Daniel",
                        "Daniel@sisi",
                        LocalDate.of(2000, Month.APRIL, 3),
                        21
                )
        );
    }
}
