package com.p1.ERS.Repository;

import java.util.List;
import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.p1.ERS.Entity.Reimbursement;
import com.p1.ERS.Entity.User;

@Repository
public interface ReimbursementRepository extends JpaRepository<Reimbursement, Integer> {
    Optional<Reimbursement> findByReimId(Integer reimId);

    @Query("SELECT r FROM Reimbursement r WHERE r.user = :userId")
    List<Reimbursement> findByUser(@Param("userId") User user);

}
