package com.p1.ERS.Controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.p1.ERS.Service.JwtService;
import com.p1.ERS.Service.UserService;
import com.p1.ERS.dto.response.UserResponse;
import com.p1.ERS.Entity.User;

@RestController
@RequestMapping("/user")
public class AuthController {
    UserService userService;
    JwtService jwtService;

    @Autowired
    public AuthController(UserService userService, JwtService jwtService) {
        this.userService = userService;
        this.jwtService = jwtService;

    }

    @PostMapping("/register")
    public ResponseEntity<User> registerUser(@RequestBody User user) {
        User registeredUser = userService.registerUser(user);

        if (registeredUser != null) {
            return ResponseEntity.status(HttpStatus.OK).body(registeredUser);
        } else
            return ResponseEntity.status(HttpStatus.CONFLICT).build();

    }

    @PostMapping("/login")
    public ResponseEntity<UserResponse> login(@RequestBody User user) {
        User loggedInUser = userService.login(user.getUsername(),
                user.getPassword());

        if (loggedInUser != null) {
            String token = jwtService.generateToken(loggedInUser);
            UserResponse userResponse = new UserResponse(loggedInUser, token);
            return ResponseEntity.status(HttpStatus.OK).body(userResponse);
        } else
            return ResponseEntity.status(HttpStatus.BAD_REQUEST).build();
    }
}
