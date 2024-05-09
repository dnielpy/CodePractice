package com.example.demo.student;

import java.time.LocalDate;

public class Student {
    private long id;
    private String name;
    private String email;
    private LocalDate dob;
    private Integer age;

    //Constructor with all data
    public Student(long ID, String Name, String Email, LocalDate Dob, Integer Age){
        this.id = ID;
        this.name = Name;
        this.email = Email;
        this.dob = Dob;
        this.age = Age;
    }

    //Constructor without ID
    public Student(String Name, String Email, LocalDate Dob, Integer Age){
        this.name = Name;
        this.email = Email;
        this.dob = Dob;
        this.age = Age;
    }

    public long getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public String getEmail() {
        return email;
    }

    public LocalDate getDob() {
        return dob;
    }

    public Integer getAge() {
        return age;
    }

    @Override
    public String toString() {
        return "Student{" +
                "id=" + id +
                ", name='" + name + '\'' +
                ", email='" + email + '\'' +
                ", dob=" + dob +
                ", age=" + age +
                '}';
    }
}
