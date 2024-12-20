package com.p1.ERS.Service;

import java.util.Optional;

import org.springframework.stereotype.Service;

import com.p1.ERS.Entity.Role;
import com.p1.ERS.Repository.RoleRepository;

@Service
public class RoleService {
    private RoleRepository roleRepository;

    public RoleService(RoleRepository roleRepository) {
        this.roleRepository = roleRepository;
    }

    public Role createRole(Role role) {
        Optional<Role> existingRole = roleRepository.findByRoleName(role.getRoleName());
        if (!existingRole.isPresent()) {
            return roleRepository.save(role);
        }
        return null;

    }

}
