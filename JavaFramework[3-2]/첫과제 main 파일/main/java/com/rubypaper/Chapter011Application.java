package com.rubypaper;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.WebApplicationType;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class Chapter011Application {

	public static void main(String[] args) {
		SpringApplication application =
				new SpringApplication(Chapter011Application.class);
		application.setWebApplicationType(WebApplicationType.SERVLET);
		application.run(args);
	}
}
