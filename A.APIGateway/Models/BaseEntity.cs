﻿using System.ComponentModel.DataAnnotations;

namespace A.APIGateway.Models
{
    public abstract class BaseEntity
    {
        public bool IsDeleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime LastModified { get; set; }
    }
}
