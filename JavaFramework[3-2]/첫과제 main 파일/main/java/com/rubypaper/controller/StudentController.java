package com.rubypaper.controller;

import java.util.ArrayList;
import java.util.List;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import com.rubypaper.domain.Student3_2_이용규;

@RestController
@RequestMapping("/student")
public class StudentController {
    @GetMapping("/getStudentBoard")
    @ResponseBody
    public List<Student3_2_이용규> getStudent() {
        List<Student3_2_이용규> students = new ArrayList<>();
        
        Student3_2_이용규 student1 = new Student3_2_이용규();
        student1.setId("2423223");
        student1.setAge("19");
        student1.setWeight("45");
        student1.setDisease("depression");
        student1.settWriCu("32");
        
        Student3_2_이용규 student2 = new Student3_2_이용규();
        student2.setId("2423223");
        student2.setAge("19");
        student2.setWeight("45");
        student2.setDisease("depression");
        student2.settWriCu("32");
        
        students.add(student1);
        students.add(student2);
        
        return students;
    }
}
