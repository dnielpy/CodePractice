package com.example.demo.student;
import org.springframework.boot.CommandLineRunner;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.core.env.CommandLinePropertySource;

import java.time.LocalDate;
import java.time.Month;
import java.util.List;

@Configuration
public class StudentConfig {

    @Bean
    CommandLineRunner commandLineRunner(StudentRepository repository){
        return args -> {
            Student daniel = new Student(
                            1L,
                            "Daniel",
                            "Daniel@sisi",
                            LocalDate.of(2000, Month.APRIL, 3),
                            21
                    );
            Student mariam = new Student(
                    1L,
                    "Alex",
                    "alex@sisi",
                    LocalDate.of(2010, Month.APRIL, 4),
                    41
            );
            repository.saveAll(
                    List.of(daniel, mariam)
            );
        };
    }
}
