package com.p1.ERS.Service;

import java.util.Optional;

import org.springframework.stereotype.Service;

import com.p1.ERS.Entity.*;
import com.p1.ERS.Repository.ReimbursementRepository;
import com.p1.ERS.Repository.UserRepository;

@Service
public class ReimbursementService {
    ReimbursementRepository reimbursementRepository;
    UserRepository userRepository;

    public ReimbursementService(ReimbursementRepository reimbursementRepository, UserRepository userRepository) {
        this.reimbursementRepository = reimbursementRepository;
        this.userRepository = userRepository;
    }

    public Reimbursement createReimbursement(Reimbursement reimbursement, User user) {
        if (reimbursement.getDescription() == null || reimbursement.getDescription().trim().isEmpty()
                || reimbursement.getDescription().length() > 255) {
            return null;
        }
        reimbursement.setStatus("Pending");
        reimbursement.setUser(user);
        return reimbursementRepository.save(reimbursement);
    }

    public Reimbursement updateReimbursementStatus(Reimbursement reimbursement) {
        Optional<Reimbursement> optionalReimbursement = reimbursementRepository.findById(reimbursement.getReimId());
        if (optionalReimbursement.isPresent()) {
            Reimbursement foundReimbursement = optionalReimbursement.get();
            foundReimbursement.setStatus(reimbursement.getStatus());
            return reimbursementRepository.save(foundReimbursement);
        }
        return null;
    }

}
