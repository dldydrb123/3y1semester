package com.rubypaper.domain;

import java.util.ArrayList;
import java.util.List;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

public class Student3_2_이용규 {
	private String id;
	private String age;
	private String weight;
	private String disease;
	private String tWriCu;
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public String getAge() {
		return age;
	}
	public void setAge(String age) {
		this.age = age;
	}
	public String getWeight() {
		return weight;
	}
	public void setWeight(String weight) {
		this.weight = weight;
	}
	public String getDisease() {
		return disease;
	}
	public void setDisease(String disease) {
		this.disease = disease;
	}
	public String gettWriCu() {
		return tWriCu;
	}
	public void settWriCu(String string) {
		this.tWriCu = string;
	}
	@Override
	public String toString() {
		return "StudentVO [id=" + id + ", age=" + age + ", "
				+ "weight=" + weight + ", "
				+ "disease=" +disease + ", tWriCu=" + tWriCu
				+ ", toString()=" + super.toString() + "]";
	}
	@RestController
	public class Restcontroller {
	
	@RequestMapping("getStudentBoard")
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
}
