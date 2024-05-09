package com.example.demo.student;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.time.LocalDate;
import java.time.Month;
import java.util.List;

//Student API
@RestController
@RequestMapping(path = "api/v1/student")
public class StudentController {

    @GetMapping
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
