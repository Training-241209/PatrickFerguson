package com.p1.ERS.Service;

import java.util.Optional;

import org.mindrot.jbcrypt.BCrypt;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.p1.ERS.Entity.Role;
import com.p1.ERS.Entity.User;
import com.p1.ERS.Repository.RoleRepository;
import com.p1.ERS.Repository.UserRepository;

@Service
public class UserService {
    private UserRepository userRepository;
    private RoleRepository roleRepository;

    @Autowired
    public UserService(UserRepository userRepository, RoleRepository roleRepository) {
        this.userRepository = userRepository;
        this.roleRepository = roleRepository;
    }

    public User getUserById(Integer userId) {
        return userRepository.findById(userId).orElse(null);
    }

    public User registerUser(User user) {
        Optional<User> existingUser = userRepository.findByUsername(user.getUsername());

        if (existingUser.isPresent())
            return null;

        Optional<Role> defaultRole = roleRepository.findByRoleName("Employee");
        if (defaultRole != null)
            user.setRole(defaultRole.get());
        else
            return null;

        String hashed = BCrypt.hashpw(user.getPassword(), BCrypt.gensalt());
        user.setPassword(hashed);

        return userRepository.save(user);
    }

    public User login(String username, String password) {
        Optional<User> user = userRepository.findByUsername(username);
        if (user.isPresent() && user.get().getUsername().equals(username)
                && BCrypt.checkpw(password, user.get().getPassword())) {
            return user.get();
        } else
            return null;
    }
}
